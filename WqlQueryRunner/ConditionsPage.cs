using System;
using System.ComponentModel;
using System.Drawing;
using System.Management;
using System.Windows.Forms;
using Wizard.UI;

namespace WqlQueryRunner
{
    public partial class ConditionsPage 
        : Wizard.UI.InternalWizardPage
    {
        #region Constructors

        public ConditionsPage()
        {
            InitializeComponent();
        }

        #endregion

        #region Private Procedures

        private void ConditionsPage_SetActive(
            object sender, CancelEventArgs e)
        {
            string tempProperty = "";

            lblText.Text = "You have chosen to monitor " + 
                ((QueryWizard)this.Parent.Parent).TargetClassName +
                "WMI class. Please review its properties " +
                "and select the one for which to filter " +
                "the received events. If you skip this step " +
                "you will receive all events for this WMI class";

            // Populate the list view 
            // with the selected WMI class properties.

            if (this.lstProperties.SelectedItems.Count == 1)
            {
                tempProperty = this.lstProperties.SelectedItems[0].Text;
            }

            this.lstProperties.Items.Clear();

            ManagementClass WmiClass = new ManagementClass(
                ((QueryWizard)this.Parent.Parent).TargetClassName);

            foreach (PropertyData property in WmiClass.Properties)
            {
                lstProperties.Items.Add(property.Name, property.Name, null);
            }

            if (this.lstProperties.Items.ContainsKey(tempProperty))
            {
                this.lstProperties.Items[tempProperty].Selected = true;
                this.lstProperties.Items[tempProperty].EnsureVisible();
            }

            if (this.lstProperties.Items.Count > 0 & this.lstProperties.SelectedItems.Count == 0)
            {
                this.lstProperties.Items[0].Selected = true;
            }

            //

            SetWizardButtons(WizardButtons.Back | WizardButtons.Next);
        }

        // Populates the combo box with the values
        // of the selected property.
        // TODO: Get rid of the duplicate entries.

        private void PopulateComboValues(ManagementClass WmiClass)
        {
            comboValues.Items.Clear();

            foreach(ManagementObject instance in WmiClass.GetInstances())
            {
                if(instance.Properties[lstProperties.SelectedItems[0].Text].Value != null)
                {
                    comboValues.Items.Add(
                        instance.Properties[lstProperties.SelectedItems[0].Text].Value);
                }
            }
        }

        // What radio button was selected

        private RadioButton GetSelectedRadioButton()
        {
            RadioButton checkedButton = null;
            foreach (RadioButton button in groupOperators.Controls)
            {
                if (button.Checked)
                {
                    checkedButton = button;
                }
            }
            return checkedButton;
        }

        // Construct the WQL query condition
        // based on the current control values.

        private void ConstructConditionText()
        {
            this.txtCondition.Text =
                "TargetInstance." +
                lstProperties.SelectedItems[0].Text + " " +
                GetSelectedRadioButton().Text + " \"" +
                GetComboBoxValue() + "\"";
        }

        // Try to get a meaningful value from the combo box

        private string GetComboBoxValue()
        {
            if (this.comboValues.Text.Length > 0)
            {
                return this.comboValues.Text;
            }
            else if (this.comboValues.Items.Count > 0)
            {
                return this.comboValues.Items[0].ToString();
            }
            else
            {
                return "";
            }
        }

        #endregion

        #region Control Event Procedures

        // react to each control value change
        // and set the WQL query condition text box accordingly.

        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            foreach (RadioButton radio in groupOperators.Controls)
            {
                if (radio.Checked)
                {
                    radio.BackColor = SystemColors.ControlLightLight;
                }
                else
                {
                    radio.BackColor = SystemColors.Control;
                }
            }

            ConstructConditionText();
        }

        private void lblProperty_TextChanged(object sender, EventArgs e)
        {
            ConstructConditionText();
        }

        private void comboValues_TextChanged(object sender, EventArgs e)
        {
            ConstructConditionText();
        }

        private void lstProperties_ItemSelectionChanged(
            object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.Item.Selected)
            {
                PopulateComboValues(new ManagementClass(
                    ((QueryWizard)this.ParentForm).TargetClassName));
                ConstructConditionText();

            }
        }

        #endregion

        #region Condition Accept - Clear

        private void btnAccept_Click(object sender, EventArgs e)
        {
            ((QueryWizard)this.ParentForm).Condition = txtCondition.Text;
            ((QueryWizard)this.ParentForm).SetQueryCondition();
            ((QueryWizard)this.ParentForm).ShowQueryInLabel();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ((QueryWizard)this.ParentForm).Condition = "";
            ((QueryWizard)this.ParentForm).SetQueryCondition();
            ((QueryWizard)this.ParentForm).ShowQueryInLabel();
        }

        #endregion
    }
}
