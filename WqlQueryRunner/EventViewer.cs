using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Management;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WqlQueryRunner
{
    public partial class EventViewer : Form
    {
        #region Public Members

        // monitored items holds the collection
        // of created items to monitor

        public Dictionary<string, MonitoringItem> MonitoringItems;

        #endregion

        #region Private Members

        // used to move the form around

        private Point position;
        private bool mouseDown;

        // This mutex used in HandleEvent() 
        // to prevent System.NullReferenceException
        // at RichTextBox.EditStreamProc()

        private Mutex richTextMutex = new Mutex();

        #endregion

        #region Constructors

        public EventViewer()
        {
            InitializeComponent();
            
            MonitoringItems = new Dictionary<string, MonitoringItem>();

            MonitoringItem item1 = new MonitoringItem(
                @"Select * From __InstanceCreationEvent Within 1 " +
                @"Where TargetInstance Isa 'Win32_Process' " +
                @"And TargetInstance.Name = 'Notepad.exe'", "Sample1");
            MonitoringItem item2 = new MonitoringItem(
                @"Select * From __InstanceOperationEvent Within 1 " +
                @"Where TargetInstance Isa 'Win32_Service'", "Sample2");
            MonitoringItem item3 = new MonitoringItem(
                @"Select * From __InstanceDeletionEvent Within 1 " +
                @"Where TargetInstance Isa 'Win32_PrintJob'", "Sample3");

            item1.State = MonitoringItemState.Stopped;
            item2.State = MonitoringItemState.Stopped;
            item3.State = MonitoringItemState.Stopped;

            AddItemToDictionary(item1.Name, item1);
            AddItemToDictionary(item2.Name, item2);
            AddItemToDictionary(item3.Name, item3);
        }

        #endregion

        #region System Tray

        // Without this the icon showed in the System Tray
        // whan the application was opened.

        private void EventViewer_Load(object sender, EventArgs e)
        {
            notifyIcon.Visible = false;
        }

        // Two procedures used to put the application in the System Tray
        // when it is minimized and to restore the main window 
        // when the icon in the Tray is clicked.

        private void EventViewer_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
            }
            notifyIcon.Visible = true;
        }

        private void notifyIcon_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        #endregion

        #region Moving Around

        // Three procedures to handle moving around the window.

        private void richEventReceiver_MouseDown(
            object sender, MouseEventArgs e)
        {
            position.X = 
                Form.MousePosition.X - Form.ActiveForm.Location.X;
            position.Y = 
                Form.MousePosition.Y - Form.ActiveForm.Location.Y;
            mouseDown = true;
        }

        private void richEventReceiver_MouseMove(
            object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Form.ActiveForm.Location =
                    new Point(
                    MousePosition.X - position.X, 
                    MousePosition.Y - position.Y);
            }
        }

        private void richEventReceiver_MouseUp(
            object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        #endregion

        #region Context menu

        // Context menu procedures

        private void exitToolStripMenuItem_Click(
            object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeToolStripMenuItem_Click(
            object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void openControlPanelMenuItem_Click(
            object sender, EventArgs e)
        {
            QueryManager controlPanel = new QueryManager();
            controlPanel.MyEventViewer = this;
            controlPanel.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(
            object sender, EventArgs e)
        {
            RunnerAbout about = new RunnerAbout();
            about.ShowDialog();
        }

        private void helpToolStripMenuItem_Click(
            object sender, EventArgs e)
        {
            try
            {
                Process process = new Process();
                process.StartInfo.FileName = 
                    Path.GetDirectoryName(Application.ExecutablePath)
                    + "\\QueryRunnerHelp.chm";
                process.Start();
            }
            catch (System.ComponentModel.Win32Exception ex)
            {
                MessageBox.Show("Can not find the help file.");
            }
        }

        private void optionsToolStripMenuItem_Click(
            object sender, EventArgs e)
        {
            UserSettings userSettings = new UserSettings();
            userSettings.ShowDialog();
        }

        private void copyToolStripMenuItem_Click(
            object sender, EventArgs e)
        {
            // Without Replace() the copied text doesn't
            // show new lines in Notepad.
            if (richEventReceiver.Text.Length > 0)
            {
                Clipboard.SetText(richEventReceiver.Text.Replace(
                    "\n", Environment.NewLine));
            }
        }

        private void saveToolStripMenuItem_Click(
            object sender, EventArgs e)
        {
            if (saveTextDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer =
                    new StreamWriter(saveTextDialog.FileName);
                writer.Write(richEventReceiver.Text.Replace(
                    "\n", Environment.NewLine));
                writer.Close();
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richEventReceiver.Text = "";
        }

        #endregion

        #region Event Handler

        // Event handler procedure 
        // for events received from MonitoredItem.

        public void HandleEvent(
            object sender, WmiEventReceivedEventArgs e)
        {

            richTextMutex.WaitOne();

            richEventReceiver.AppendText(
                DateTime.Now.ToLongTimeString() + 
                " : Event received" + Environment.NewLine);
            richEventReceiver.AppendText(
                "Class : " + e.TargetInstance.ClassPath.ClassName + 
                Environment.NewLine);
            richEventReceiver.AppendText(
                "Instance : " + Environment.NewLine + e.TargetInstance.
                SystemProperties["__RelPath"].Value.ToString() + 
                Environment.NewLine);
            
            // TODO: Change this to only delete lines from the beginning

            if (richEventReceiver.Text.Length > 100000)
            {
                richEventReceiver.Text = "";
            }
        
            richEventReceiver.AppendText(Environment.NewLine);

            richTextMutex.ReleaseMutex();

            foreach (EventAction action in 
                (sender as MonitoringItem).Actions.Values)
            {
                if(action.State == EventActionState.Active)
                {
                    try
                    {
                        action.Execute(e.TargetInstance, e.PreviousInstance);
                    }
                    catch(FileNotFoundException ex)
                    {
                        if (Properties.Settings.Default.Popup_Show)
                        {
                            PopupStarter popup = new PopupStarter(
                                ex.FileName + Environment.NewLine +
                                "The script file could not be found");

                            popup.Show();
                        }
                    }
                }
            }

        }

        #endregion

        #region Dictionary

        public void AddItemToDictionary(string name, MonitoringItem item)
        {
            MonitoringItems.Add(name, item);
        }

        #endregion

    }
}
