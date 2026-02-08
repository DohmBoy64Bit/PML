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

            // Note: The 12-second safety wait and metadata version override 
            // will be implemented in the "Interop & Metadata v39 Support" step.
        }
    }
}
