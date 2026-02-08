using System;
using System.Collections.Generic;
using UnityEngine;
using Il2CppInterop.Runtime.Attributes;

namespace PML
{
    public class MainThreadDispatcher : MonoBehaviour
    {
        private static readonly Queue<Action> _executionQueue = new Queue<Action>();
        private static MainThreadDispatcher? _instance;

        public MainThreadDispatcher(IntPtr ptr) : base(ptr) { }

        [HideFromIl2Cpp]
        public static void Initialize()
        {
            if (_instance != null) return;

            var go = new GameObject("PML_MainThreadDispatcher");
            _instance = go.AddComponent<MainThreadDispatcher>();
            UnityEngine.Object.DontDestroyOnLoad(go);
            go.hideFlags = HideFlags.HideAndDontSave;
            
            Logger.LogCore("MainThreadDispatcher initialized.");
        }

        [HideFromIl2Cpp]
        public static void Enqueue(Action action)
        {
            lock (_executionQueue)
            {
                _executionQueue.Enqueue(action);
            }
        }

        public void Update()
        {
            lock (_executionQueue)
            {
                while (_executionQueue.Count > 0)
                {
                    try
                    {
                        _executionQueue.Dequeue().Invoke();
                    }
                    catch (Exception ex)
                    {
                        Logger.LogCore($"Error in MainThreadDispatcher: {ex.Message}");
                    }
                }
            }
        }
    }
}
