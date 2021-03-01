using System;
using System.Drawing;
using System.IO;
using System.Management;
using System.Windows.Forms;

namespace WqlQueryRunner
{
    public partial class QueryManager : Form
    {
        #region Public Properties

        public EventViewer MyEventViewer;

        #endregion

        #region Constructors

        public QueryManager()
        {
            InitializeComponent();
        }

        #endregion

        #region Form

        // Populate the ListView control with existing items.

        private void ControlPanel_Load(object sender, EventArgs e)
        {
            lstMonitoringItems.Items.Clear();

            foreach (MonitoringItem item 
                in MyEventViewer.MonitoringItems.Values)
            {
                AddItemToListView(item);
            }

            UpdateQueryListView();
        }

        #endregion

        #region Buttons

        // When the Add button is clicked, 
        // the form for adding a monitoring item opens

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SimpleQueryEditor simpleEditor = new SimpleQueryEditor(true);
            simpleEditor.MyQueryManager = this;
            simpleEditor.ShowDialog();
        }

        // Edit an existing monitored item
        // Don't allow editing of active (running) items

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstMonitoringItems.SelectedItems.Count == 1)
            {
                MonitoringItem item = null;
                MyEventViewer.MonitoringItems.TryGetValue(
                    lstMonitoringItems.SelectedItems[0].Text, out item);

                if (item.State != MonitoringItemState.Running)
                {
                    SimpleQueryEditor simpleEditor = new SimpleQueryEditor(false);
                    
                    simpleEditor.Controls["txtName"].Text = item.Name;                    
                    simpleEditor.Controls["txtQuery"].Text = item.WqlQuery.QueryString;

                    simpleEditor.MyQueryManager = this;
                    simpleEditor.ShowDialog();
                }
                else
                {
                    MessageBox.Show("You need to stop monitoring" +
                        " before you can edit an item properties.");
                }
            }
        }

        // Try to register the event handler and start monitoring

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (lstMonitoringItems.SelectedItems.Count == 1)
            {
                MonitoringItem item = null;
                MyEventViewer.MonitoringItems.TryGetValue(
                    lstMonitoringItems.SelectedItems[0].Text, out item);

                try
                {
                    item.WmiEventReceived +=
                        new WmiEventReceivedHandler(MyEventViewer.HandleEvent);

                    item.StartMonitoring();
                }
                catch (ManagementException ex)
                {
                    item.State = MonitoringItemState.Incomplete;
                    MessageBox.Show("Can not start monitoring" +
                        " for the following reason:" +
                        Environment.NewLine + ex.Message);
                }
                catch (System.Runtime.InteropServices.COMException ex)
                {
                    item.State = MonitoringItemState.Incomplete;
                    MessageBox.Show("Can not start monitoring" +
                       " for the following reason:" +
                       Environment.NewLine + ex.Message);
                }
                UpdateQueryListView();
            }
        }

        // Try to unregister the event handler and stop monitoring

        private void btnStop_Click(object sender, EventArgs e)
        {
            if(lstMonitoringItems.SelectedItems.Count == 1)
            {
                MonitoringItem item = null;
                MyEventViewer.MonitoringItems.TryGetValue(
                    lstMonitoringItems.SelectedItems[0].Text, out item);

                if (item.State == MonitoringItemState.Running)
                {
                    try
                    {
                        item.StopMonitoring();
                        item.WmiEventReceived -= MyEventViewer.HandleEvent;
                        UpdateQueryListView();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Can not stop monitoring" +
                            " for the following reason:" +
                            Environment.NewLine + ex.Message);
                    }
                }
            }
        }

        // Clicking btnRemove should do two things:
        // 1. Remove the selected element from the monitoredItems dictionary
        // 2. Remove the selected element from the ListView

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstMonitoringItems.SelectedItems.Count == 1)
            {
                MonitoringItem item = null;
                MyEventViewer.MonitoringItems.TryGetValue(
                    lstMonitoringItems.SelectedItems[0].Name, out item);
   
                item.StopMonitoring();

                MyEventViewer.MonitoringItems.Remove(item.Name);

                // Select the item after the one that got deleted
                // If the last item is deleted select the new
                // last item in the list

                int deletedIndex = 
                    lstMonitoringItems.SelectedItems[0].Index;
                
                lstMonitoringItems.SelectedItems[0].Remove();

                if (lstMonitoringItems.Items.Count > deletedIndex)
                {
                    lstMonitoringItems.Items[deletedIndex].Selected = true;
                }
                else if(lstMonitoringItems.Items.Count > 1)
                {
                    lstMonitoringItems.Items
                        [lstMonitoringItems.Items.Count - 1].Selected = true;
                }
                
            }
            else
            {
                MessageBox.Show("Please select the monitoring item" +
                    " you want to delete");
            }
        }

        // Starts an instance of the QueryWizard form

        private void btnWizard_Click(object sender, EventArgs e)
        {
            QueryWizard wizard = new QueryWizard();
            wizard.MyParent = this;
            wizard.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (saveQueriesDialog.ShowDialog() == DialogResult.OK)
            {
                TextWriter writer =
                    new StreamWriter(saveQueriesDialog.FileName, false);

                foreach (MonitoringItem item in
                    MyEventViewer.MonitoringItems.Values)
                {
                    if (item.State == MonitoringItemState.Running)
                    {
                        writer.WriteLine(
                            item.Name + ":.:" + item.WqlQuery.QueryString +
                            ":.:" + ((int)MonitoringItemState.Stopped).ToString());
                    }
                    else
                    {
                        writer.WriteLine(
                            item.Name + ":.:" + item.WqlQuery.QueryString +
                            ":.:" + ((int)item.State).ToString());
                    }
                }
                writer.Close();
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            SavedItems savedItems = new SavedItems();
            savedItems.MyQueryManager = this;
            savedItems.ShowDialog();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            string stringToCopy = "";

            foreach (ListViewItem listItem in
                lstMonitoringItems.Items)
            {
                stringToCopy +=
                    listItem.SubItems[2].Text + Environment.NewLine;
            }

            Clipboard.SetText(stringToCopy);
        }

        private void btnActions_Click(object sender, EventArgs e)
        {
            OpenQueryActions();
        }

        // This should probably go away

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UpdateQueryListView();
        }

        private void OpenQueryActions()
        {
            if (lstMonitoringItems.SelectedItems.Count == 1)
            {
                QueryActions actions = new QueryActions(
                    MyEventViewer.MonitoringItems
                    [lstMonitoringItems.SelectedItems[0].Name]);
                actions.ShowDialog();
            }
            else
            {
                MessageBox.Show(
                    "Please select a query to edit actions for");
            }
        }

        #endregion

        #region Context Menu

        private void copyQueryTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstMonitoringItems.SelectedItems.Count == 1)
            {
                Clipboard.SetText(
                    MyEventViewer.MonitoringItems[
                    lstMonitoringItems.SelectedItems[0].Name]
                    .WqlQuery.QueryString);
            }
        }

        private void queryActionsToolStripMenuItem_Click(
            object sender, EventArgs e)
        {
            OpenQueryActions();
        }

        #endregion

        #region Public Methods

        // An attempt to colorize ListView items
        // according to monitored item state

        public void AddItemToListView(MonitoringItem monitoringItem)
        {
            ListViewItem listItem = new ListViewItem();
            listItem.Name = monitoringItem.Name;
            listItem.Text = monitoringItem.Name;

            listItem.SubItems.Add(new ListViewItem.ListViewSubItem());
            listItem.SubItems.Add(new ListViewItem.ListViewSubItem());
            listItem.SubItems[1].Text = monitoringItem.State.ToString();
            listItem.SubItems[2].Text = monitoringItem.WqlQuery.QueryString;

            lstMonitoringItems.Items.Add(listItem);
        }

        public void UpdateQueryListView()
        {
            foreach (ListViewItem item in lstMonitoringItems.Items)
            {
                switch (MyEventViewer.MonitoringItems[item.Text].State)
                {
                    case MonitoringItemState.Running:
                        {
                            item.BackColor = Color.LawnGreen;
                            break;
                        }
                    case MonitoringItemState.Stopped:
                        {
                            item.BackColor = Color.LightSalmon;
                            break;
                        }
                    case MonitoringItemState.Undefined:
                        {
                            item.BackColor = Color.Gainsboro;
                            break;
                        }
                    case MonitoringItemState.Incomplete:
                        {
                            item.BackColor = Color.Moccasin;
                            break;
                        }
                }

                item.SubItems[1].Text =
                    MyEventViewer.MonitoringItems[item.Text].State.ToString();
                item.SubItems[2].Text = 
                    MyEventViewer.MonitoringItems[item.Text].WqlQuery.QueryString;
            }
        }

        #endregion

    }
}
