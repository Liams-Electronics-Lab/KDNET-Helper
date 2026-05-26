using System;
using System.Windows.Forms;

namespace KdnetHelper
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += (sender, e) =>
            {
                MessageBox.Show($"Thread Exception:\n{e.Exception.Message}\n\n{e.Exception.StackTrace}", 
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
            AppDomain.CurrentDomain.UnhandledException += (sender, e) =>
            {
                MessageBox.Show($"Unhandled Exception:\n{(e.ExceptionObject as Exception)?.Message}\n\n{(e.ExceptionObject as Exception)?.StackTrace}", 
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}