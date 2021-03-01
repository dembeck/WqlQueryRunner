using System;
using System.Management;
using System.Windows.Forms;

namespace WqlQueryRunner
{
    public partial class WmiNamespaceBrowser : UserControl
    {
        public WmiNamespaceBrowser()
        {
            InitializeComponent();
        }

        private void WMINamespaceBrowser_Load(object sender, EventArgs e)
        {
            this.label1.Text = "Retrieving WMI namespaces. Please wait ...";

            this.treeBrowser.Nodes.Add("Root", "Root");

            PopulateTreeView(treeBrowser.Nodes["Root"]);
        }

        private void PopulateTreeView(TreeNode treeNode)
        {
            ManagementObjectSearcher searcher =
                new ManagementObjectSearcher(treeNode.FullPath,
                "Select * From __Namespace");

            foreach (ManagementObject nameSpace in searcher.Get())
            {
                TreeNode subNode = new TreeNode(nameSpace["Name"].ToString());
                subNode.Name = nameSpace["Name"].ToString();
                treeNode.Nodes.Add(subNode);
                PopulateTreeView(subNode);
            }
        }

        private void treeBrowser_AfterSelect(object sender, TreeViewEventArgs e)
        {
            this.label1.Text = this.treeBrowser.SelectedNode.FullPath;
        }
    }
}
