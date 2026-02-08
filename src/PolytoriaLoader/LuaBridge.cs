using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using MoonSharp.Interpreter;

namespace PML
{
    internal static class LuaBridge
    {
        private static readonly List<Script> _trackedScripts = new List<Script>();

        public static IEnumerable<Script> TrackedScripts => _trackedScripts;

        public static void Initialize()
        {
            PML.Lua.RunDelegate = Run;
            PML.Lua.RegisterDelegate = Register;
            
            Logger.LogLua("LuaBridge initialized and hooked to PML.Lua API.");
        }

        public static void RegisterScript(Script script)
        {
            if (!_trackedScripts.Contains(script))
            {
                _trackedScripts.Add(script);
                Logger.LogLua($"Tracked new Lua script instance. Total: {_trackedScripts.Count}");
            }
        }

        public static void Run(string lua)
        {
            foreach (var script in _trackedScripts)
            {
                try
                {
                    script.DoString(lua);
                }
                catch (Exception ex)
                {
                    Logger.LogLua($"Error executing Lua: {ex.Message}");
                }
            }
        }

        public static void Register(string name, Delegate action)
        {
            foreach (var script in _trackedScripts)
            {
                script.Globals[name] = action;
            }
            Logger.LogLua($"Registered C# function '{name}' to all tracked scripts.");
        }

        /// <summary>
        /// Attempts to find Script instances in the game using reflection.
        /// This is a fallback if scripts aren't manually registered.
        /// </summary>
        public static void ScanForScripts()
        {
            // Implementation would depend on how Polytoria stores its scripts.
            // For now, this is a placeholder for the reflection logic.
            Logger.LogLua("Scanning for MoonSharp Script instances...");
        }
    }
}
