using System;
using System.IO;

namespace PML
{
    public static class Logger
    {
        private static readonly string LogPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "PML_Internal", "PML_Log.txt");

        static Logger()
        {
            try
            {
                string dir = Path.GetDirectoryName(LogPath)!;
                if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);
                if (File.Exists(LogPath)) File.Delete(LogPath);
                File.WriteAllText(LogPath, "--- PML Log Started ---\n");
            }
            catch { }
        }

        public static void Log(string tag, string message)
        {
            string formatted = $"[{DateTime.Now:HH:mm:ss}] [{tag}] {message}";
            Console.WriteLine(formatted);
            
            try
            {
                File.AppendAllText(LogPath, formatted + Environment.NewLine);
            }
            catch { }
        }

        public static void LogCore(string message) => Log("PML:CORE", message);
        public static void LogV39(string message) => Log("PML:V39", message);
        public static void LogLua(string message) => Log("PML:LUA", message);

        // Generic mod-specific logging
        public static void LogMod(string modName, string message) => Log($"PML:MOD", $"{modName}: {message}");
        public static void LogMod(string message) => Log("PML:MOD", message);
    }
}
