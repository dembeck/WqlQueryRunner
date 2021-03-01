using System.ComponentModel;

using Wizard.UI;

namespace WqlQueryRunner
{
    public partial class CompletePage 
        : Wizard.UI.ExternalWizardPage
    {
        #region Constructors

        public CompletePage()
        {
            InitializeComponent();
        }

        #endregion

        #region Private Procedures

        private void CompletePage_SetActive(
            object sender, CancelEventArgs e)
        {
            SetWizardButtons(
                WizardButtons.Back | WizardButtons.Finish);
        }

        #endregion
    }
}
