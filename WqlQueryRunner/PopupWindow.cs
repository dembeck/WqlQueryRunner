using System;
using System.Threading;
using System.Windows.Forms;

namespace WqlQueryRunner
{
    public partial class PopupWindow : Form
    {
        public string Message
        {
            get
            {
                return lblMessage.Text;
            }
            set
            {
                lblMessage.Text = value;
            }
        }

        public PopupWindow()
        {
            InitializeComponent();
        }

        public PopupWindow(string message)
        {
            InitializeComponent();
            Message = message;
            timerTimeout.Interval =
                Properties.Settings.Default.PopupWindow_Timeout;
        }

        private void timerTimeout_Tick(
            object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(
            object sender, EventArgs e)
        {
            Close();
        }
    }

    public class PopupStarter
    {
        private object[] parameters = new object[1];

        public PopupStarter(string message)
        {
            parameters[0] = message;
        }

        public void Show()
        {
            Thread thread = new Thread(
                new ParameterizedThreadStart(ShowPopup));
            thread.Start(parameters);
        }

        private void ShowPopup(object parameters)
        {
            object[] parameterArray = (object[])parameters;
            string message = (string)parameterArray[0];

            PopupWindow popup = new PopupWindow(message);
            popup.ShowDialog();
        }
    }

}
