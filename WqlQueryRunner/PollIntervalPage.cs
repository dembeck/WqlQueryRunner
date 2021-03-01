using System;
using System.ComponentModel;

using Wizard.UI;

namespace WqlQueryRunner
{
    public partial class PollIntervalPage 
        : Wizard.UI.InternalWizardPage
    {
        #region Constructors

        public PollIntervalPage()
        {
            InitializeComponent();
        }

        #endregion

        #region Private Procedures

        private void PollIntervalPage_SetActive(
            object sender, CancelEventArgs e)
        {
            SetWizardButtons(WizardButtons.Back 
                | WizardButtons.Next);
        }

        #endregion

        #region Query Related

        private void upDownPollingInterval_ValueChanged(
            object sender, EventArgs e)
        {
            ((QueryWizard)this.ParentForm).Query.WithinInterval =
                new TimeSpan(0, 0, 0, 0, 
                    (int)(upDownPollingInterval.Value * 1000));
            ((QueryWizard)this.ParentForm).ShowQueryInLabel();
        }

        #endregion

    }
}
