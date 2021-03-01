using System;
using System.Management;
using System.Windows.Forms;

namespace WqlQueryRunner
{
    public partial class SimpleQueryEditor : Form
    {
        // For access to the form parent

        public QueryManager MyQueryManager;

        // Are we adding or editing the query;

        private bool AddFlag;

        public SimpleQueryEditor(bool addFlag)
        {
            InitializeComponent();

            AddFlag = addFlag;
            
            if (!AddFlag)
            {
                txtName.Enabled = false;
            }
        }

        // Attempt to save the query and exit
        // TODO: get rid of the arrow code

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (AddFlag)
            {
                if ((txtName.Text.Length > 0) & (txtQuery.Text.Length > 0))
                {
                    MonitoringItem item;
                    if (MyQueryManager.MyEventViewer.MonitoringItems.
                        TryGetValue(this.txtName.Text, out item))
                    {
                        DialogResult result =
                        MessageBox.Show("A monitoring item with the name " +
                            txtName.Text + " already exists. Do you want " +
                            "to replace it?", "Item already exists",
                            MessageBoxButtons.YesNoCancel);
                        switch (result)
                        {
                            case DialogResult.Yes:
                                item.WqlQuery.QueryString = this.txtQuery.Text;
                                MyQueryManager.lstMonitoringItems.Items
                                    [item.Name].Selected = true;
                                MyQueryManager.UpdateQueryListView();
                                this.Close();
                                break;

                            case DialogResult.No:
                                this.Close();
                                break;

                            case DialogResult.Cancel:
                                break;
                        }

                    }
                    else
                    {
                        item = new MonitoringItem(
                            this.txtQuery.Text, this.txtName.Text);

                        MyQueryManager.MyEventViewer.AddItemToDictionary(
                            item.Name, item);
                        MyQueryManager.AddItemToListView(item);

                        MyQueryManager.lstMonitoringItems.Items
                           [item.Name].Selected = true;
                        MyQueryManager.UpdateQueryListView();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show(" You need to enter both " +
                        "monitoring item name and query text.");
                }
            }
            else
            {
                MonitoringItem item = 
                    MyQueryManager.MyEventViewer.MonitoringItems[txtName.Text];
                try
                {
                    item.WqlQuery.QueryString =
                        txtQuery.Text;
                }
                // It appears that trying to set WqlEventQuery.QueryString
                // can throw these exceptions:
                catch (ManagementException ex)
                {
                    item.State = MonitoringItemState.Incomplete;
                    MessageBox.Show(
                        "Can't save changes to the monitoring item " +
                        Environment.NewLine +
                        ex.Message);
                }
                catch (FormatException ex)
                {
                    item.State = MonitoringItemState.Incomplete;
                    MessageBox.Show(
                      "Can't save changes to the monitoring item " +
                      Environment.NewLine +
                      ex.Message);
                }
                catch (ArgumentException ex)
                {
                    item.State = MonitoringItemState.Incomplete;
                    MessageBox.Show(
                       "Can't save changes to the monitoring item " +
                       Environment.NewLine +
                       ex.Message);
                }
                MyQueryManager.UpdateQueryListView();
                Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
