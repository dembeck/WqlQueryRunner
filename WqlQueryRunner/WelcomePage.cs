using System.ComponentModel;

using Wizard.UI;

namespace WqlQueryRunner
{
    public partial class WelcomePage 
        : Wizard.UI.ExternalWizardPage
    {
        #region Constructors

        public WelcomePage()
        {
            InitializeComponent();
        }

        #endregion

        #region Private Procedures

        private void WelcomePage_SetActive(
            object sender, CancelEventArgs e)
        {
            SetWizardButtons(WizardButtons.Next);
            ((QueryWizard)this.ParentForm).ClearQueryLabel();
        }

        #endregion
    }
}
