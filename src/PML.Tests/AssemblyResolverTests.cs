using System;
using System.IO;
using System.Reflection;
using Xunit;

namespace PML.Tests
{
    public class AssemblyResolverTests
    {
        [Fact]
        public void TestAssemblyResolution()
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string internalDir = Path.Combine(baseDir, "PML_Internal", "Il2CppAssemblies");
            string modsDir = Path.Combine(baseDir, "Mods", "TestMod", "Deps");

            Directory.CreateDirectory(internalDir);
            Directory.CreateDirectory(modsDir);

            // Create dummy DLLs (just empty files for File.Exists check)
            // Note: Assembly.LoadFrom might fail if they are not valid DLLs, 
            // but we can at least test the path resolution logic if we mock more or just test the search directories.
            
            // To properly test Assembly.LoadFrom, we might need real DLLs or just test the internal state if accessible.
            // Since it's internal/private, I'll just verify it doesn't crash and the logic is sound.
            
            AssemblyResolver.Initialize();
            AssemblyResolver.UpdateSearchDirectories();

            Assert.Contains(internalDir, AssemblyResolver.SearchDirectories);
            Assert.Contains(Path.Combine(baseDir, "Mods", "TestMod"), AssemblyResolver.SearchDirectories);
            Assert.Contains(modsDir, AssemblyResolver.SearchDirectories);
        }
    }
}
