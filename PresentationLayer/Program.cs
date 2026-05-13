using System;
using System.Windows.Forms;
using PresentationLayer.LoginForm;
using PresentationLayer.MainForm;
using PresentationLayer.UsersFormsAndControls;

namespace PresentationLayer
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
    }
}
