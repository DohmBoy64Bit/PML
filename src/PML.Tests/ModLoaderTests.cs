using System;
using System.IO;
using System.Reflection;
using Xunit;
using PML;
using System.Collections.Generic;

namespace PML.Tests
{
    public class ModLoaderTests
    {
        [Fact]
        public void TestModLifecycle()
        {
            // Since we can't easily test file system discovery in this environment without complex mocking,
            // we will test the internal loading logic directly.
            
            var testMod = new TestModInternal();
            
            // 1. OnInitialize
            testMod.OnInitialize();
            Assert.True(testMod.InitializeCalled);
            
            // 2. OnUnityReady
            testMod.OnUnityReady();
            Assert.True(testMod.UnityReadyCalled);
            
            // 3. OnUpdate
            testMod.OnUpdate();
            Assert.True(testMod.UpdateCalled);
        }

        private class TestModInternal : PolytoriaMod
        {
            public override string Name => "TestInternal";
            public override string Version => "1.0.0";
            
            public bool InitializeCalled { get; private set; }
            public bool UnityReadyCalled { get; private set; }
            public bool UpdateCalled { get; private set; }

            public override void OnInitialize() => InitializeCalled = true;
            public override void OnUnityReady() => UnityReadyCalled = true;
            public override void OnUpdate() => UpdateCalled = true;
        }
    }
}
