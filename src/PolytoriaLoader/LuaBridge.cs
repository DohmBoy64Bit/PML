using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using MoonSharp.Interpreter;
using HarmonyLib;

namespace PML
{
    internal static class LuaBridge
    {
        private static readonly List<Script> _trackedScripts = new List<Script>();
        private static Harmony? _harmony;

        public static IEnumerable<Script> TrackedScripts => _trackedScripts;

        public static void Initialize()
        {
            PML.Lua.RunDelegate = Run;
            PML.Lua.RegisterDelegate = Register;
            
            _harmony = new Harmony("com.pml.luabridge");
            ApplyPatches();
            
            Logger.LogLua("LuaBridge initialized and hooked to PML.Lua API.");
        }

        private static void ApplyPatches()
        {
            try
            {
                // Patch Script.DoString to capture Script instances
                var doStringMethod = typeof(Script).GetMethod("DoString", new[] { typeof(string), typeof(Table), typeof(string) });
                if (doStringMethod != null)
                {
                    var prefix = typeof(LuaBridge).GetMethod(nameof(OnDoStringPrefix), BindingFlags.NonPublic | BindingFlags.Static);
                    _harmony?.Patch(doStringMethod, prefix: new HarmonyMethod(prefix));
                    Logger.LogLua("Successfully patched Script.DoString for capture.");
                }
                else
                {
                    Logger.LogLua("Failed to find Script.DoString method.");
                }
            }
            catch (Exception ex)
            {
                Logger.LogLua($"Error applying Lua capture patches: {ex.Message}");
            }
        }

        private static void OnDoStringPrefix(Script __instance)
        {
            if (__instance != null)
            {
                RegisterScript(__instance);
            }
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
