using System;
using System.IO;

namespace ProjectUtils
{
    public static class SimpleLogger
    {
        private static readonly string logFile = "Logs/logs.txt";

        public static void Log(string message)
        {
            Directory.CreateDirectory("Logs");
            File.AppendAllText(logFile, $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}{Environment.NewLine}");
        }
    }
}
