using PML;

namespace TestMod
{
    public class MyTestMod : PolytoriaMod
    {
        public override string Name => "Test Mod";
        public override string Version => "1.0.0";

        public override void OnInitialize()
        {
            ConsoleLog("OnInitialize called!");
        }

        public override void OnUnityReady()
        {
            ConsoleLog("OnUnityReady called!");
            PML.Lua.Run("print('[TestMod] Lua test from OnUnityReady')");
        }

        private int _updateCount = 0;
        public override void OnUpdate()
        {
            _updateCount++;
            if (_updateCount % 100 == 0)
            {
                // ConsoleLog($"OnUpdate called 100 times! (Total: {_updateCount})");
            }
        }
    }
}
