using System;
using MoonSharp.Interpreter;

namespace PML
{
    public static class Lua
    {
        // These delegates will be set by the loader at runtime
        public static Action<string>? RunDelegate;
        public static Action<string, Delegate>? RegisterDelegate;

        /// <summary>
        /// Executes a script string in the game's global Lua state.
        /// </summary>
        public static void Run(string lua)
        {
            RunDelegate?.Invoke(lua);
        }

        /// <summary>
        /// Allows C# mods to expose functions directly to Polytoria's Lua scripts.
        /// </summary>
        public static void Register(string name, Delegate action)
        {
            RegisterDelegate?.Invoke(name, action);
        }
    }
}
