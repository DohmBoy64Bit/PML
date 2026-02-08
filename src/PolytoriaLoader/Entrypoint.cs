using System;
using System.Runtime.InteropServices;

namespace PML
{
    public static class Entrypoint
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool AllocConsole();

        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        /// <summary>
        /// Doorstop entrypoint.
        /// </summary>
        public static void Start()
        {
            // Allocate console for developer interface
            if (AllocConsole())
            {
                // Console.Title = "Polytoria Mod Loader";
            }

            Logger.LogCore("PML Booting...");

            AssemblyResolver.Initialize();

            // 12-second safety wait for Unity metadata buffer to settle
            Logger.LogCore("Waiting 12 seconds for Unity initialization...");
            System.Threading.Thread.Sleep(12000);

            // Metadata v39 Support initialization
            InitializeInterop();
        }

        private static void InitializeInterop()
        {
            Logger.LogV39("Initializing Il2CppInterop with Metadata v39 support...");
            
            IntPtr gameAssembly = GetModuleHandle("GameAssembly.dll");
            if (gameAssembly == IntPtr.Zero)
            {
                Logger.LogCore("Failed to find GameAssembly.dll!");
                return;
            }

            Logger.LogCore($"Found GameAssembly.dll at 0x{gameAssembly.ToInt64():X}");

            try 
            {
                // Initialize the Il2CppInterop Runtime
                // Note: We are using the highest available struct handlers (v31) 
                // and relying on Metadata v39 compatibility.
                Il2CppInterop.Runtime.Il2CppInteropRuntime.Initialize();
                
                Logger.LogV39("Il2CppInterop initialized successfully.");
            }
            catch (Exception ex)
            {
                Logger.LogCore($"Failed to initialize interop: {ex.Message}");
                Logger.LogCore(ex.StackTrace ?? "No stack trace available.");
            }
        }
    }
}
