using System;
using System.Drawing;
using System.Windows.Forms;

namespace WqlQueryRunner
{
    public partial class UserSettings : Form
    {
        public UserSettings()
        {
            InitializeComponent();
        }

        private void UserSettings_Load(object sender, EventArgs e)
        {
            // Event viewer form settings

            numericOpacity.Value = Convert.ToDecimal(
                Properties.Settings.Default.EventViewer_Opacity);
            colorPicker.Color =
                Properties.Settings.Default.EventViewer_BackColor;
            fontPicker.Font =
                Properties.Settings.Default.EventViewer_Font;
            fontPicker.Color =
                Properties.Settings.Default.EventViewer_ForeColor;
            numericHeight.Value =
                Properties.Settings.Default.EventViewer_Size.Height;
            numericWidth.Value =
                Properties.Settings.Default.EventViewer_Size.Width;

            // Popup window settings

            numericPopupOpacity.Value = Convert.ToDecimal(
                Properties.Settings.Default.PopupWindow_Opacity);
            numericPopupTimeout.Value = Convert.ToDecimal(
                Properties.Settings.Default.PopupWindow_Timeout);
            if (Properties.Settings.Default.Popup_Show)
            {
                checkPopupWindow.Checked = true;
            }
            else
            {
                checkPopupWindow.Checked = false;
            }
        }

        private void numericOpacity_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.EventViewer_Opacity =
                Convert.ToDouble(numericOpacity.Value);
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reload();
            Close();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            colorPicker.ShowDialog();
            Properties.Settings.Default.EventViewer_BackColor = 
                colorPicker.Color;
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            fontPicker.ShowDialog();
            Properties.Settings.Default.EventViewer_Font =
                fontPicker.Font;
            Properties.Settings.Default.EventViewer_ForeColor =
                fontPicker.Color;
        }

        private void numericWidth_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.EventViewer_Size =
                new Size(Convert.ToInt32(numericWidth.Value),
                    Properties.Settings.Default.EventViewer_Size.Height);
        }

        private void numericHeight_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.EventViewer_Size =
                new Size(Properties.Settings.Default.EventViewer_Size.Width,
                    Convert.ToInt32(numericHeight.Value));
        }

        private void btnRestoreDefaults_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
        }

        private void numericPopupOpacity_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.PopupWindow_Opacity =
                Convert.ToDouble(numericPopupOpacity.Value);
        }

        private void numericPopupTimeout_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.PopupWindow_Timeout =
                Convert.ToInt32(numericPopupTimeout.Value);
        }

        private void checkPopupWindow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPopupWindow.Checked)
            {
                Properties.Settings.Default.Popup_Show = true;
            }
            else
            {
                Properties.Settings.Default.Popup_Show = false;
            }
        }
    }
}
