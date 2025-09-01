using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Extensions.Logging;
using Serilog;
using ILogger = Microsoft.Extensions.Logging.ILogger;

namespace PresentationLayer
{
    internal static class Program
    {
        public static ILogger Logger;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string logFolder = @"C:\Logs";
            Directory.CreateDirectory(logFolder);
            string logPath = Path.Combine(logFolder, "logs.txt");

            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Information()
                .WriteTo.File(logPath, rollingInterval: RollingInterval.Day)
                .CreateLogger();

            var loggerFactory = LoggerFactory.Create(builder =>
            {
                builder.AddSerilog();
            });

            Logger = loggerFactory.CreateLogger("BarnManagementApp");
            Logger.LogInformation("Application started");

            //Hata yakalama
            Application.ThreadException += (sender, e) =>
            {
                ProjectUtils.SimpleLogger.Log($"Unhandled UI exception: {e.Exception.Message}");
                MessageBox.Show("An unexpected error occurred. Check the logs.");
            };

            AppDomain.CurrentDomain.UnhandledException += (sender, e) =>
            {
                var ex = (Exception)e.ExceptionObject;
                ProjectUtils.SimpleLogger.Log($"Unhandled non-UI exception: {ex.Message}");
                MessageBox.Show("A critical error occurred. Check the logs.");
            };

            Application.Run(new LogInForm(false));
        }
    }
}