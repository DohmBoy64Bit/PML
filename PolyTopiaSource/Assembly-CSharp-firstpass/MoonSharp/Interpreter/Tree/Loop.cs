using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;

namespace MoonSharp.Interpreter.Tree
{
	// Token: 0x02000060 RID: 96
	public class Loop : Object
	{
		// Token: 0x060009A7 RID: 2471 RVA: 0x0003B8B0 File Offset: 0x00039AB0
		// Note: this type is marked as 'beforefieldinit'.
		static Loop()
		{
			Il2CppClassPointerStore<Loop>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Tree", "Loop");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Loop>.NativeClassPtr);
			Loop.NativeFieldInfoPtr_Scope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loop>.NativeClassPtr, "Scope");
			Loop.NativeFieldInfoPtr_BreakJumps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Loop>.NativeClassPtr, "BreakJumps");
			Loop.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loop>.NativeClassPtr, 100665093);
			Loop.NativeMethodInfoPtr_CompileBreak_Public_Virtual_Final_New_Void_ByteCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loop>.NativeClassPtr, 100665091);
			Loop.NativeMethodInfoPtr_IsBoundary_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loop>.NativeClassPtr, 100665092);
		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x0003B944 File Offset: 0x00039B44
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 29419, RefRangeEnd = 29423, XrefRangeStart = 29411, XrefRangeEnd = 29419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Loop()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Loop>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Loop.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009A9 RID: 2473 RVA: 0x0003B980 File Offset: 0x00039B80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29423, XrefRangeEnd = 29431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CompileBreak(ByteCode bc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Loop.NativeMethodInfoPtr_CompileBreak_Public_Virtual_Final_New_Void_ByteCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x0003B9C4 File Offset: 0x00039BC4
		[CallerCount(126)]
		[CachedScanResults(RefRangeStart = 18232, RefRangeEnd = 18358, XrefRangeStart = 18232, XrefRangeEnd = 18358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsBoundary()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Loop.NativeMethodInfoPtr_IsBoundary_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060009AB RID: 2475 RVA: 0x00004957 File Offset: 0x00002B57
		public Loop(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x060009AC RID: 2476 RVA: 0x0003BA00 File Offset: 0x00039C00
		// (set) Token: 0x060009AD RID: 2477 RVA: 0x00004960 File Offset: 0x00002B60
		public unsafe RuntimeScopeBlock Scope
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loop.NativeFieldInfoPtr_Scope);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RuntimeScopeBlock>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loop.NativeFieldInfoPtr_Scope), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x060009AE RID: 2478 RVA: 0x0003BA30 File Offset: 0x00039C30
		// (set) Token: 0x060009AF RID: 2479 RVA: 0x0000497F File Offset: 0x00002B7F
		public unsafe List<Instruction> BreakJumps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loop.NativeFieldInfoPtr_BreakJumps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Instruction>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Loop.NativeFieldInfoPtr_BreakJumps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000887 RID: 2183
		private static readonly IntPtr NativeFieldInfoPtr_Scope;

		// Token: 0x04000888 RID: 2184
		private static readonly IntPtr NativeFieldInfoPtr_BreakJumps;

		// Token: 0x04000889 RID: 2185
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400088A RID: 2186
		private static readonly IntPtr NativeMethodInfoPtr_CompileBreak_Public_Virtual_Final_New_Void_ByteCode_0;

		// Token: 0x0400088B RID: 2187
		private static readonly IntPtr NativeMethodInfoPtr_IsBoundary_Public_Virtual_Final_New_Boolean_0;
	}
}
