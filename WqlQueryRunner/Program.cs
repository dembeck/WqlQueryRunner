using System;
using System.Threading;
using System.Windows.Forms;

namespace WqlQueryRunner
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // The Mutex thing tries to make sure that the application
            // has a single instance. Taken from:
            // http://www.codeproject.com/kb/cs/singleinstanceapplication.aspx
            // With the correction of mutex handling from Leppie (discussion)

            bool newMutexCreated = false;
            string mutexName = "Global\\" + 
                System.Reflection.Assembly.
                GetExecutingAssembly().GetName().Name;

            Mutex mutex = null;
            try
            {
                mutex = new Mutex(false, mutexName, out newMutexCreated);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "\n\n" + e.StackTrace +
                    "\n\n" + "Application Exiting...", "Exception thrown");
                Application.Exit();
            }

            if (newMutexCreated && mutex.WaitOne())
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new EventViewer());
                mutex.ReleaseMutex();
            }
            mutex.Close();
        }
    }
}
