using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace PML
{
    public static class ModLoader
    {
        private static readonly string ModsDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Mods");
        private static readonly List<PolytoriaMod> _loadedMods = new List<PolytoriaMod>();

        public static IReadOnlyList<PolytoriaMod> LoadedMods => _loadedMods;

        public static void LoadMods()
        {
            if (!Directory.Exists(ModsDir))
            {
                Directory.CreateDirectory(ModsDir);
                return;
            }

            Logger.LogCore("Discovering mods...");

            foreach (string modDir in Directory.GetDirectories(ModsDir))
            {
                string modName = Path.GetFileName(modDir);
                LoadModFromDirectory(modDir);
            }

            Logger.LogCore($"Loaded {_loadedMods.Count} mods.");
            
            // Initialize all loaded mods
            foreach (var mod in _loadedMods)
            {
                try
                {
                    mod.OnInitialize();
                }
                catch (Exception ex)
                {
                    Logger.LogMod(mod.Name, $"Failed to initialize: {ex.Message}");
                }
            }
        }

        private static void LoadModFromDirectory(string modDir)
        {
            foreach (string dllFile in Directory.GetFiles(modDir, "*.dll"))
            {
                try
                {
                    Assembly assembly = Assembly.LoadFrom(dllFile);
                    LoadModsFromAssembly(assembly);
                }
                catch (Exception ex)
                {
                    Logger.LogCore($"Failed to load assembly {dllFile}: {ex.Message}");
                }
            }
        }

        private static void LoadModsFromAssembly(Assembly assembly)
        {
            Type modBaseType = typeof(PolytoriaMod);
            var modTypes = assembly.GetTypes()
                .Where(t => modBaseType.IsAssignableFrom(t) && !t.IsAbstract && t.IsClass);

            foreach (var type in modTypes)
            {
                try
                {
                    if (Activator.CreateInstance(type) is PolytoriaMod mod)
                    {
                        _loadedMods.Add(mod);
                        Logger.LogMod(mod.Name, $"Loaded version {mod.Version}");
                    }
                }
                catch (Exception ex)
                {
                    Logger.LogCore($"Failed to instantiate mod {type.FullName}: {ex.Message}");
                }
            }
        }

        public static void OnUnityReady()
        {
            foreach (var mod in _loadedMods)
            {
                try
                {
                    mod.OnUnityReady();
                }
                catch (Exception ex)
                {
                    Logger.LogMod(mod.Name, $"Error in OnUnityReady: {ex.Message}");
                }
            }
        }

        public static void OnUpdate()
        {
            foreach (var mod in _loadedMods)
            {
                try
                {
                    mod.OnUpdate();
                }
                catch (Exception ex)
                {
                    Logger.LogMod(mod.Name, $"Error in OnUpdate: {ex.Message}. Disabling mod.");
                    // In a more complex implementation, we might want to remove it from the list
                    // or flag it as disabled.
                }
            }
        }
    }
}
