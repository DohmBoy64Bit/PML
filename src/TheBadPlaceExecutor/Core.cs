using System;
using System.IO;
using PML;
using TheBadPlaceExecutor.IPC;
using TheBadPlaceExecutor.Scripting;
using TheBadPlaceExecutor.Utils;

namespace TheBadPlaceExecutor
{
    public class Core : PolytoriaMod
    {
        public override string Name => "The Bad Place Executor";
        public override string Version => "1.0.0";

        private bool _hasRunAutoExec = false;

        public override void OnInitialize()
        {
            ConsoleLog("Initializing...");
            
            // Initialize folder structure
            EnvironmentUtils.InitializeFolders();
            
            // Register custom Lua commands
            CommandRegistry.RegisterCustomCommands();
            
            // Start IPC Pipe Server
            PipeServer.Start();
            
            ConsoleLog("Initialization complete.");
        }

        public override void OnUnityReady()
        {
            ConsoleLog("Unity is ready.");
        }

        public override void OnUpdate()
        {
            if (!_hasRunAutoExec)
            {
                // In PML, we can use PML.Lua.Run which will execute on all tracked scripts.
                // We'll run AutoExec once we have at least one script or just run it and hope for the best.
                // Actually, PML.Lua.Run only works if there are tracked scripts.
                _hasRunAutoExec = true;
                RunAutoExec();
            }

            // Execute scripts received via IPC on the main thread
            if (PipeServer.TryGetNextScript(out string? scriptCode))
            {
                if (string.IsNullOrEmpty(scriptCode)) return;

                try
                {
                    ConsoleLog("Executing script from IPC...");
                    PML.Lua.Run(scriptCode);
                }
                catch (Exception ex)
                {
                    ConsoleLog($"Error executing script: {ex.Message}");
                }
            }
        }

        private void RunAutoExec()
        {
            try
            {
                string path = EnvironmentUtils.AutoExecPath;
                if (!Directory.Exists(path)) return;

                ConsoleLog("Checking AutoExec folder...");
                foreach (string file in Directory.GetFiles(path))
                {
                    string ext = Path.GetExtension(file).ToLower();
                    if (ext == ".lua" || ext == ".txt")
                    {
                        ConsoleLog($"AutoExecuting: {Path.GetFileName(file)}");
                        try
                        {
                            string content = File.ReadAllText(file);
                            PML.Lua.Run(content);
                        }
                        catch (Exception ex)
                        {
                            ConsoleLog($"Error in AutoExec script {Path.GetFileName(file)}: {ex.Message}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ConsoleLog($"AutoExec error: {ex.Message}");
            }
        }
    }
}
