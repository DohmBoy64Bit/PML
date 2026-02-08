using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("PML.Tests")]

namespace PML
{
    public static class AssemblyResolver
    {
        private static readonly string BaseDir = AppDomain.CurrentDomain.BaseDirectory;
        private static readonly string InternalDir = Path.Combine(BaseDir, "PML_Internal", "Il2CppAssemblies");
        private static readonly string ModsDir = Path.Combine(BaseDir, "Mods");

        internal static readonly List<string> SearchDirectories = new List<string>();

        public static void Initialize()
        {
            AppDomain.CurrentDomain.AssemblyResolve += OnResolve;
            UpdateSearchDirectories();
            Logger.LogCore("Assembly Resolver initialized.");
        }

        public static void UpdateSearchDirectories()
        {
            SearchDirectories.Clear();

            // 1. System Tier
            if (Directory.Exists(InternalDir))
            {
                SearchDirectories.Add(InternalDir);
            }

            // 2 & 3. Plugin Tier & Dependency Tier
            if (Directory.Exists(ModsDir))
            {
                foreach (string modDir in Directory.GetDirectories(ModsDir))
                {
                    // Plugin Tier: Mods/[ModName]/
                    SearchDirectories.Add(modDir);

                    // Dependency Tier: Mods/[ModName]/Deps/
                    string depsDir = Path.Combine(modDir, "Deps");
                    if (Directory.Exists(depsDir))
                    {
                        SearchDirectories.Add(depsDir);
                    }
                }
            }
        }

        private static Assembly? OnResolve(object? sender, ResolveEventArgs args)
        {
            string? assemblyName = new AssemblyName(args.Name).Name;
            if (assemblyName == null) return null;
            
            foreach (string directory in SearchDirectories)
            {
                string assemblyPath = Path.Combine(directory, assemblyName + ".dll");
                if (File.Exists(assemblyPath))
                {
                    try
                    {
                        return Assembly.LoadFrom(assemblyPath);
                    }
                    catch (Exception ex)
                    {
                        Logger.LogCore($"Failed to load assembly {assemblyName} from {assemblyPath}: {ex.Message}");
                    }
                }
            }

            return null;
        }
    }
}
