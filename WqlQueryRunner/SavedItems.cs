using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WqlQueryRunner
{
    public partial class SavedItems : Form
    {
        #region Public Properties

        public QueryManager MyQueryManager;

        #endregion

        #region Constructors

        public SavedItems()
        {
            InitializeComponent();
        }

        #endregion

        #region Buttons

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (openQueriesDialog.ShowDialog() == DialogResult.OK)
            {
                OpenItemsFile(openQueriesDialog.FileName);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem savedItem in lstSavedItems.CheckedItems)
            {
                if (!MyQueryManager.MyEventViewer.MonitoringItems.ContainsKey(savedItem.Name))
                {
                    MonitoringItem item = 
                        new MonitoringItem(savedItem.SubItems[1].Text, savedItem.Name);
                    MyQueryManager.MyEventViewer.AddItemToDictionary(savedItem.Name, item);
                    MyQueryManager.AddItemToListView(item);
                }
            }
            MyQueryManager.UpdateQueryListView();
            Close();
        }

        #endregion

        #region List View

        private void lstSavedItems_AfterLabelEdit(
            object sender, LabelEditEventArgs e)
        {
            if (e.Label != null)
            {
                if (!MyQueryManager.MyEventViewer.MonitoringItems.ContainsKey(e.Label) &
                    !lstSavedItems.Items.ContainsKey(e.Label))
                {
                    lstSavedItems.Items[e.Item].BackColor = Color.White;
                }
                else
                {
                    lstSavedItems.Items[e.Item].BackColor = Color.Orange;
                }
                lstSavedItems.Items[e.Item].Name = e.Label;
            }
        }

        #endregion

        #region Public Methods

        public void OpenItemsFile(String fileName)
        {
            lstSavedItems.Items.Clear();
            lblMessage.Text = "";

            String[] separator = new String[1] { ":.:" };
            TextReader reader = new StreamReader(fileName);

            String savedItem = null;

            while ((savedItem = reader.ReadLine()) != null)
            {
                try
                {
                    String[] savedArray = savedItem.Split(separator, StringSplitOptions.None);
                    ListViewItem item = new ListViewItem(savedArray[0]);
                    item.Name = savedArray[0];
                    item.SubItems.Add(new ListViewItem.ListViewSubItem(item, savedArray[1]));
                    item.SubItems.Add(new ListViewItem.ListViewSubItem(item, ((MonitoringItemState)(Convert.ToInt32(savedArray[2]))).ToString()));
                    if (MyQueryManager.MyEventViewer.MonitoringItems.ContainsKey(savedArray[0]))
                    {
                        item.BackColor = Color.Orange;
                        lblMessage.Text =
                            "Orange colored items already exist." + Environment.NewLine +
                            "Please rename them so you can add them to the list";
                    }
                    lstSavedItems.Items.Add(item);
                }
                catch
                {
                    //
                }

                if (lstSavedItems.Items.Count == 0)
                {
                    lblMessage.Text = "No items found in the file";
                }
            }
        }

        #endregion
    }
}
