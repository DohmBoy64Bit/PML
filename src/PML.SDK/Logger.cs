using System;

namespace PML
{
    public static class Logger
    {
        public static void Log(string tag, string message)
        {
            Console.WriteLine($"[{tag}] {message}");
        }

        public static void LogCore(string message) => Log("PML:CORE", message);
        public static void LogV39(string message) => Log("PML:V39", message);
        public static void LogLua(string message) => Log("PML:LUA", message);

        // Generic mod-specific logging
        public static void LogMod(string modName, string message) => Log($"PML:MOD", $"{modName}: {message}");
        public static void LogMod(string message) => Log("PML:MOD", message);
    }
}
