using System;
using System.IO;
using System.Windows.Forms;
using AxWMPLib;

namespace PresentationLayer
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new LogInForm(false) { StartPosition = FormStartPosition.CenterScreen });
        }
    }
}