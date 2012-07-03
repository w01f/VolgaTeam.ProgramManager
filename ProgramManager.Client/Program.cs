using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProgramManager.Client
{
    static class Program
    {
        private static System.Threading.Mutex mutex; //Used to determine if the application is already open
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool firstInstance;
            string uniqueIdentifier = "Local\\ProgramManagerApplication";
            mutex = new System.Threading.Mutex(false, uniqueIdentifier, out firstInstance);
            if (firstInstance)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.FirstDayOfWeek = DayOfWeek.Monday;
                System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = @"MM/dd/yyyy";
                System.Threading.Thread.CurrentThread.CurrentUICulture = System.Threading.Thread.CurrentThread.CurrentCulture;
                Controllers.AppManager.Instance.RunForm();
            }
            else
            {
                Controllers.AppManager.Instance.ActivateMainForm();
            }
        }
    }
}
