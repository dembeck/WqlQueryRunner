using System;
using System.Collections.Generic;
using System.Management;
using System.Text;
using System.Windows.Forms;

namespace WqlQueryRunner
{
    public partial class QueryWizard 
        : Wizard.UI.WizardSheet
    {
        #region Internal Properties

        internal WqlEventQuery Query = new WqlEventQuery();
        internal string TargetClassName = "Win32_Process";
        internal string Condition = "";
        internal Dictionary<string, string> WmiClasses = 
            new Dictionary<string,string>();

        internal QueryManager MyParent;

        #endregion

        #region Constructors

        public QueryWizard()
        {
            InitializeComponent();

            // Add pages to  the wizard

            this.Pages.Add(new WelcomePage());
            this.Pages.Add(new EventTypePage());
            this.Pages.Add(new PollIntervalPage());
            this.Pages.Add(new TargetClassPage());
            this.Pages.Add(new ConditionsPage());
            this.Pages.Add(new CompletePage());

            // Add some common WMI classes
            // to displayed in the target class page

            this.WmiClasses.Add("Win32_Process", "Processes");
            this.WmiClasses.Add("Win32_Service", "Services");
            this.WmiClasses.Add("Win32_PrintJob", "Print Jobs");
            this.WmiClasses.Add("Win32_LogicalDisk", "Logical Disks");
            this.WmiClasses.Add("Win32_ComputerSystem", "Computer System");

            this.Query.EventClassName = "__InstanceCreationEvent";
            this.Query.WithinInterval = new TimeSpan(0, 0, 5);
            SetQueryCondition();
        }

        #endregion

        #region Internal Procedures

        // Set the WQL query condition
        // based on Condition property;

        internal void SetQueryCondition()
        {

            this.Query.Condition = @"TargetInstance Isa '" +
                TargetClassName + @"'";
            if(Condition.Length > 0)
            {
                this.Query.Condition += " And " + Condition;
            }
        }

        // Add WMI Win32 classes to WmiClasses
        // to be used in target class wizard page.

        internal void AddWin32Classes()
        {
            ManagementObjectSearcher searcher =
                new ManagementObjectSearcher();

            searcher.Query.QueryString =
                @"Select * From Meta_Class " +
                @"Where (__Class Like 'Win32_%') " + 
                @"And (__Dynasty <> 'CIM_StatisticalInformation') " +
                @"And (__Dynasty <> '__SystemClass')";

            foreach (ManagementObject win32Class in searcher.Get())
            {
                if (!WmiClasses.ContainsKey(
                    win32Class.SystemProperties["__Class"].Value.ToString()))
                {
                    WmiClasses.Add(
                        win32Class.SystemProperties["__Class"].Value.ToString(),
                        HumanizeString(win32Class.SystemProperties["__Class"].Value.ToString().Substring(6)));
                }
            }
        }

        #endregion

        #region Private Procedures

        // Convert WMI class names to human readable form

        private string HumanizeString(string source)
        {
            StringBuilder sb = new StringBuilder();

            char last = char.MinValue;
            foreach (char c in source)
            {
                if (char.IsLower(last) &&
                char.IsUpper(c))
                { sb.Append(' '); }
                sb.Append(c);
                last = c;
            }
            return sb.ToString();
        }

        // Return the unique name for the WQL query
        // to be returned to Query Manager

        private string NewItemName(string name)
        {
            if (name.Length == 0)
            {
                name = "untitled";
            }

            int i = 1;

            if (MyParent.MyEventViewer.MonitoringItems.ContainsKey(name))
            {
                while (MyParent.MyEventViewer.MonitoringItems
                    .ContainsKey(name + i.ToString()))
                {
                    i++;
                }
                return name + i.ToString();
            }
            else
            {
                return name;
            }
        }

        #endregion

        #region Query Label

        public void ShowQueryInLabel()
        {
            this.Controls["pagePanel"].Controls["lblQuery"].Text =
                this.Query.QueryString;
        }

        public void ClearQueryLabel()
        {
            this.Controls["pagePanel"].Controls["lblQuery"].Text = "";
        }

        #endregion

        #region Finish Button

        private void finishButton_Click(object sender, EventArgs e)
        {
            string exitChoice = null;

            foreach (RadioButton radio in 
                GetActivePage().Controls["groupExitOptions"].Controls)
            {
                if (radio.Checked)
                {
                    exitChoice = radio.Name;
                }
            }

            switch (exitChoice)
            {
                case "radioAdd":

                    MonitoringItem item = new MonitoringItem(
                        Query, NewItemName(GetActivePage().Controls["txtQueryName"].Text));

                    MyParent.MyEventViewer.AddItemToDictionary(item.Name, item);
                    MyParent.AddItemToListView(item);
                    MyParent.UpdateQueryListView();
                    MyParent.lstMonitoringItems.Items[item.Name].Selected = true;
                    break;

                case "radioEdit":

                    SimpleQueryEditor simpleEditor = new SimpleQueryEditor(true);
                    simpleEditor.MyQueryManager = MyParent;
                    simpleEditor.Controls["txtName"].Text = GetActivePage().Controls["txtQueryName"].Text;
                    simpleEditor.Controls["txtQuery"].Text = Query.QueryString;
                    simpleEditor.ShowDialog();
                    break;

                case "radioClose":
                    
                    break;
            }
        }

        #endregion
    }
}
