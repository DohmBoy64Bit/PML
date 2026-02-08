using System;
using MoonSharp.Interpreter;
using PML;

namespace TheBadPlaceExecutor.Scripting
{
    public static class CommandRegistry
    {
        private static readonly Func<ScriptExecutionContext, CallbackArguments, DynValue> _printCustomDelegate = PrintCustom;

        public static void RegisterCustomCommands()
        {
            try
            {
                // Register print_custom to the global PML Lua API
                // This will be applied to all tracked script instances
                PML.Lua.Register("print_custom", _printCustomDelegate);
                
                Logger.LogMod("TheBadPlaceExecutor", "Registered custom commands to PML Lua API.");
            }
            catch (Exception ex)
            {
                Logger.LogMod("TheBadPlaceExecutor", $"Failed to register custom commands: {ex.Message}");
            }
        }

        private static DynValue PrintCustom(ScriptExecutionContext context, CallbackArguments args)
        {
            string message = args.Count > 0 ? args[0].String : "";
            Logger.LogMod("TheBadPlaceExecutor", $"[Lua Custom Print] {message}");
            return DynValue.Nil;
        }
    }
}
