using System;
using System.ComponentModel;
using System.Windows.Forms;


namespace WqlQueryRunner
{
    public partial class TargetClassPage 
        : Wizard.UI.InternalWizardPage
    {
        #region Constructors

        public TargetClassPage()
        {
            InitializeComponent();
        }

        #endregion

        #region Private Procedures

        private void TargetClassPage_SetActive(
            object sender, CancelEventArgs e)
        {
            if (lstTargetClasses.Items.Count == 0)
            {
                PopulateLstTargetClasses();
                lstTargetClasses.Sort();
            }
        }

        // Add Win32 WMI classes to QueryWizard.WmiClasses
        // and populate the list view with them

        private void btnMoreItems_Click(object sender, EventArgs e)
        {
            ((QueryWizard)this.ParentForm).AddWin32Classes();
            PopulateLstTargetClasses();

            if (lstTargetClasses.SelectedItems.Count > 0)
            {
                lstTargetClasses.SelectedItems[0].EnsureVisible();
            }
            btnMoreItems.Enabled = false;
        }

        // Populate the list view with QueryWizard.WmiClasses

        private void PopulateLstTargetClasses()
        {
            foreach (string key in
                ((QueryWizard)this.ParentForm).WmiClasses.Keys)
            {
                if (!lstTargetClasses.Items.ContainsKey(key))
                {
                    lstTargetClasses.Items.Add(key,
                        ((QueryWizard)this.ParentForm).WmiClasses[key], null);
                }
            }

            if (((QueryWizard)this.ParentForm).TargetClassName.Length > 0 &
                lstTargetClasses.Items.ContainsKey(
                    ((QueryWizard)this.ParentForm).TargetClassName))
            {
                lstTargetClasses.Items[
                    ((QueryWizard)this.ParentForm).TargetClassName].Selected = true;
            }
            else
            {
                lstTargetClasses.Items[0].Selected = true;
            }
        }

        // When a class in the list view is selected
        // set the query target class

        private void lstTargetClasses_ItemSelectionChanged(
            object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.Item.Selected)
            {
                if (((QueryWizard)this.ParentForm).TargetClassName != e.Item.Name)
                {
                    ((QueryWizard)this.ParentForm).Condition = "";
                    ((QueryWizard)this.ParentForm).SetQueryCondition();
                }
                ((QueryWizard)this.ParentForm).TargetClassName = e.Item.Name;
                ((QueryWizard)this.ParentForm).SetQueryCondition();
                ((QueryWizard)this.ParentForm).ShowQueryInLabel();
            }
        }

        #endregion
    }
}
