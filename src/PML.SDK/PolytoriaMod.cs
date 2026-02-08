using System;

namespace PML
{
    public abstract class PolytoriaMod
    {
        public abstract string Name { get; }
        public abstract string Version { get; }

        // Standard Lifecycle Hooks
        public virtual void OnInitialize() { }     // Called on Loader boot
        public virtual void OnUnityReady() { }      // Called after Unity 6 domain is live
        public virtual void OnUpdate() { }          // Frame-by-frame loop
        
        // Developer Helpers
        public void ConsoleLog(string message) => PML.Logger.LogMod(Name, message);
    }
}
