using System;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace AirfoilDesigner
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 

        // Create an object of the window to allow the controls on the form to be referenced.
        public static frmMainWindow form1;

        [STAThread]
        static void Main()
        {
            //ApplicationConfiguration.Initialize();
            //Application.Run(new frmMainWindow());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form1 = new frmMainWindow();
            Application.Run(form1);
        }
    }
}