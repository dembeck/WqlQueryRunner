using System;
using System.ComponentModel;

using Wizard.UI;

namespace WqlQueryRunner
{
    public partial class EventTypePage 
        : Wizard.UI.InternalWizardPage
    {
        #region Constructors

        public EventTypePage()
        {
            InitializeComponent();
        }

        #endregion

        #region Private Procedures

        private void EventTypePage_SetActive(
            object sender, CancelEventArgs e)
        {
            SetWizardButtons(WizardButtons.Back | WizardButtons.Next);
            ((QueryWizard)this.ParentForm).ShowQueryInLabel();
        }

        #endregion

        #region Radio Buttons

        // When one of the radio buttons is selected
        // change the query event class
        // and change the text in the query label

        private void radioCreation_CheckedChanged(
            object sender, EventArgs e)
        {
            if (radioCreation.Checked)
            {
                ((QueryWizard)this.ParentForm).Query.EventClassName = 
                    "__InstanceCreationEvent";
                ((QueryWizard)this.ParentForm).ShowQueryInLabel();
            }
        }

        private void radioDeletion_CheckedChanged(
            object sender, EventArgs e)
        {
            if (radioDeletion.Checked)
            {
                ((QueryWizard)this.ParentForm).Query.EventClassName =
                    "__InstanceDeletionEvent";
                ((QueryWizard)this.ParentForm).ShowQueryInLabel();
            }
        }

        private void radioModification_CheckedChanged(
            object sender, EventArgs e)
        {
            if (radioModification.Checked)
            {
                ((QueryWizard)this.ParentForm).Query.EventClassName =
                    "__InstanceModificationEvent";
                ((QueryWizard)this.ParentForm).ShowQueryInLabel();
            }
        }

        private void radioOperation_CheckedChanged(
            object sender, EventArgs e)
        {
            if (radioOperation.Checked)
            {
                ((QueryWizard)this.ParentForm).Query.EventClassName =
                    "__InstanceOperationEvent";
                ((QueryWizard)this.ParentForm).ShowQueryInLabel();
            }
        }

        #endregion

    }
}
