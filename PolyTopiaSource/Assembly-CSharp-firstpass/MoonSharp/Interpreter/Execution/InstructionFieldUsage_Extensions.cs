using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using MoonSharp.Interpreter.Execution.VM;

namespace MoonSharp.Interpreter.Execution
{
	// Token: 0x020000DD RID: 221
	public static class InstructionFieldUsage_Extensions : Object
	{
		// Token: 0x060010E5 RID: 4325 RVA: 0x00007063 File Offset: 0x00005263
		// Note: this type is marked as 'beforefieldinit'.
		static InstructionFieldUsage_Extensions()
		{
			Il2CppClassPointerStore<InstructionFieldUsage_Extensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Execution", "InstructionFieldUsage_Extensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InstructionFieldUsage_Extensions>.NativeClassPtr);
			InstructionFieldUsage_Extensions.NativeMethodInfoPtr_GetFieldUsage_Internal_Static_InstructionFieldUsage_OpCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionFieldUsage_Extensions>.NativeClassPtr, 100666311);
		}

		// Token: 0x060010E6 RID: 4326 RVA: 0x0005A384 File Offset: 0x00058584
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 42847, RefRangeEnd = 42852, XrefRangeStart = 42847, XrefRangeEnd = 42847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InstructionFieldUsage GetFieldUsage(this OpCode op)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(op);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionFieldUsage_Extensions.NativeMethodInfoPtr_GetFieldUsage_Internal_Static_InstructionFieldUsage_OpCode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InstructionFieldUsage>(intPtr3) : null;
			}
		}

		// Token: 0x060010E7 RID: 4327 RVA: 0x0000709C File Offset: 0x0000529C
		public InstructionFieldUsage_Extensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000DCF RID: 3535
		private static readonly IntPtr NativeMethodInfoPtr_GetFieldUsage_Internal_Static_InstructionFieldUsage_OpCode_0;
	}
}
