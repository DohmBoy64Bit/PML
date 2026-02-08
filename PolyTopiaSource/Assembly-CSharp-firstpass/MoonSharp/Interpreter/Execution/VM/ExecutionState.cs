using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using MoonSharp.Interpreter.DataStructs;

namespace MoonSharp.Interpreter.Execution.VM
{
	// Token: 0x020000E9 RID: 233
	public sealed class ExecutionState : Object
	{
		// Token: 0x0600119D RID: 4509 RVA: 0x0005D0A0 File Offset: 0x0005B2A0
		// Note: this type is marked as 'beforefieldinit'.
		static ExecutionState()
		{
			Il2CppClassPointerStore<ExecutionState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Execution.VM", "ExecutionState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExecutionState>.NativeClassPtr);
			ExecutionState.NativeFieldInfoPtr_ValueStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecutionState>.NativeClassPtr, "ValueStack");
			ExecutionState.NativeFieldInfoPtr_ExecutionStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecutionState>.NativeClassPtr, "ExecutionStack");
			ExecutionState.NativeFieldInfoPtr_InstructionPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecutionState>.NativeClassPtr, "InstructionPtr");
			ExecutionState.NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecutionState>.NativeClassPtr, "State");
			ExecutionState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionState>.NativeClassPtr, 100666413);
		}

		// Token: 0x0600119E RID: 4510 RVA: 0x0005D134 File Offset: 0x0005B334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43723, XrefRangeEnd = 43738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExecutionState()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExecutionState>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExecutionState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600119F RID: 4511 RVA: 0x000074F8 File Offset: 0x000056F8
		public ExecutionState(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x060011A0 RID: 4512 RVA: 0x0005D170 File Offset: 0x0005B370
		// (set) Token: 0x060011A1 RID: 4513 RVA: 0x00007501 File Offset: 0x00005701
		public unsafe FastStack<DynValue> ValueStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionState.NativeFieldInfoPtr_ValueStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FastStack<DynValue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionState.NativeFieldInfoPtr_ValueStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x060011A2 RID: 4514 RVA: 0x0005D1A0 File Offset: 0x0005B3A0
		// (set) Token: 0x060011A3 RID: 4515 RVA: 0x00007520 File Offset: 0x00005720
		public unsafe FastStack<CallStackItem> ExecutionStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionState.NativeFieldInfoPtr_ExecutionStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FastStack<CallStackItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionState.NativeFieldInfoPtr_ExecutionStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x060011A4 RID: 4516 RVA: 0x0005D1D0 File Offset: 0x0005B3D0
		// (set) Token: 0x060011A5 RID: 4517 RVA: 0x0000753F File Offset: 0x0000573F
		public unsafe int InstructionPtr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionState.NativeFieldInfoPtr_InstructionPtr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionState.NativeFieldInfoPtr_InstructionPtr)) = value;
			}
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x060011A6 RID: 4518 RVA: 0x0005D1F8 File Offset: 0x0005B3F8
		// (set) Token: 0x060011A7 RID: 4519 RVA: 0x0000755A File Offset: 0x0000575A
		public unsafe CoroutineState State
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionState.NativeFieldInfoPtr_State);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CoroutineState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExecutionState.NativeFieldInfoPtr_State), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E57 RID: 3671
		private static readonly IntPtr NativeFieldInfoPtr_ValueStack;

		// Token: 0x04000E58 RID: 3672
		private static readonly IntPtr NativeFieldInfoPtr_ExecutionStack;

		// Token: 0x04000E59 RID: 3673
		private static readonly IntPtr NativeFieldInfoPtr_InstructionPtr;

		// Token: 0x04000E5A RID: 3674
		private static readonly IntPtr NativeFieldInfoPtr_State;

		// Token: 0x04000E5B RID: 3675
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
