

using System;
using System.IO;

namespace CommandoProject.Utils
{
    public static class Logger
    {
        private static readonly string logFilePath = "logs.txt";

        public static void Log(string message)
        {
            string logEntry = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}";
            File.AppendAllText(logFilePath, logEntry + Environment.NewLine);
        }
    }
}