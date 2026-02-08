using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime.Injection;
using Il2CppInterop.Runtime;
using PML;

namespace Doorstop
{
    public static class Entrypoint
    {
        static Entrypoint()
        {
            // This runs as soon as the class is referenced by the loader
            if (System.IO.File.Exists("PML_VERBOSE") || System.IO.File.Exists("PML_VERBOSE.txt"))
            {
                MessageBox(IntPtr.Zero, "PML Static Constructor Hit!", "PML Debug", 0);
            }
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool AllocConsole();

        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type);

        /// <summary>
        /// Alternate entrypoint for Doorstop CoreCLR.
        /// </summary>
        public static void Main(string[] args)
        {
            Start();
        }

        /// <summary>
        /// Doorstop entrypoint.
        /// </summary>
        public static void Start()
        {
            // Immediate feedback to verify loading
            if (System.IO.File.Exists("PML_VERBOSE") || System.IO.File.Exists("PML_VERBOSE.txt"))
                MessageBox(IntPtr.Zero, "PML Start() Hit!", "PML Debug", 0);

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

            try
            {
                // Register and Initialize MainThreadDispatcher
                Logger.LogCore("Registering MainThreadDispatcher...");
                ClassInjector.RegisterTypeInIl2Cpp<MainThreadDispatcher>();
                
                Logger.LogCore("Initializing MainThreadDispatcher...");
                MainThreadDispatcher.Initialize();

                // Initialize Lua Bridge
                Logger.LogCore("Initializing LuaBridge...");
                LuaBridge.Initialize();

                // Discover and Load Mods
                Logger.LogCore("Loading Mods...");
                ModLoader.LoadMods();

                Logger.LogCore("PML initialization sequence complete.");
            }
            catch (Exception ex)
            {
                string errorMsg = $"FATAL ERROR during PML initialization:\n{ex.Message}\n\n{ex.StackTrace}";
                Logger.LogCore(errorMsg);
                MessageBox(IntPtr.Zero, errorMsg, "PML Fatal Error", 0x10); // 0x10 is MB_ICONERROR
            }
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
                // ACTUAL INITIALIZATION
                Logger.LogV39("Calling Runtime.Initialize()...");
                Il2CppInterop.Runtime.Runtime.Initialize();
                
                Logger.LogV39("Il2CppInterop initialized successfully.");
            }
            catch (Exception ex)
            {
                string errorMsg = $"Failed to initialize interop: {ex.Message}\n{ex.StackTrace}";
                Logger.LogCore(errorMsg);
                MessageBox(IntPtr.Zero, errorMsg, "PML Interop Error", 0x10);
            }
        }
    }
}
