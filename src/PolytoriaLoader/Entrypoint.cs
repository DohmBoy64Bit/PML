using System;
using System.Runtime.InteropServices;

namespace PML
{
    public static class Entrypoint
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool AllocConsole();

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
            // TODO: Implement metadata version override
        }
    }
}
