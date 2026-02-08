using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using MoonSharp.Interpreter.Execution.Scopes;
using MoonSharp.Interpreter.Tree.Statements;

namespace MoonSharp.Interpreter.Execution
{
	// Token: 0x020000DE RID: 222
	public class BuildTimeScope : Object
	{
		// Token: 0x060010E8 RID: 4328 RVA: 0x0005A3C8 File Offset: 0x000585C8
		// Note: this type is marked as 'beforefieldinit'.
		static BuildTimeScope()
		{
			Il2CppClassPointerStore<BuildTimeScope>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Execution", "BuildTimeScope");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildTimeScope>.NativeClassPtr);
			BuildTimeScope.NativeFieldInfoPtr_m_Frames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildTimeScope>.NativeClassPtr, "m_Frames");
			BuildTimeScope.NativeFieldInfoPtr_m_ClosureBuilders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildTimeScope>.NativeClassPtr, "m_ClosureBuilders");
			BuildTimeScope.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildTimeScope>.NativeClassPtr, 100666325);
			BuildTimeScope.NativeMethodInfoPtr_PushFunction_Public_Void_IClosureBuilder_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildTimeScope>.NativeClassPtr, 100666312);
			BuildTimeScope.NativeMethodInfoPtr_PushBlock_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildTimeScope>.NativeClassPtr, 100666313);
			BuildTimeScope.NativeMethodInfoPtr_PopBlock_Public_RuntimeScopeBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildTimeScope>.NativeClassPtr, 100666314);
			BuildTimeScope.NativeMethodInfoPtr_PopFunction_Public_RuntimeScopeFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildTimeScope>.NativeClassPtr, 100666315);
			BuildTimeScope.NativeMethodInfoPtr_Find_Public_SymbolRef_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildTimeScope>.NativeClassPtr, 100666316);
			BuildTimeScope.NativeMethodInfoPtr_CreateGlobalReference_Public_SymbolRef_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildTimeScope>.NativeClassPtr, 100666317);
			BuildTimeScope.NativeMethodInfoPtr_ForceEnvUpValue_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildTimeScope>.NativeClassPtr, 100666318);
			BuildTimeScope.NativeMethodInfoPtr_CreateUpValue_Private_SymbolRef_BuildTimeScope_SymbolRef_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildTimeScope>.NativeClassPtr, 100666319);
			BuildTimeScope.NativeMethodInfoPtr_DefineLocal_Public_SymbolRef_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildTimeScope>.NativeClassPtr, 100666320);
			BuildTimeScope.NativeMethodInfoPtr_TryDefineLocal_Public_SymbolRef_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildTimeScope>.NativeClassPtr, 100666321);
			BuildTimeScope.NativeMethodInfoPtr_CurrentFunctionHasVarArgs_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildTimeScope>.NativeClassPtr, 100666322);
			BuildTimeScope.NativeMethodInfoPtr_DefineLabel_Internal_Void_LabelStatement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildTimeScope>.NativeClassPtr, 100666323);
			BuildTimeScope.NativeMethodInfoPtr_RegisterGoto_Internal_Void_GotoStatement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildTimeScope>.NativeClassPtr, 100666324);
		}

		// Token: 0x060010E9 RID: 4329 RVA: 0x0005A538 File Offset: 0x00058738
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 42867, RefRangeEnd = 42868, XrefRangeStart = 42852, XrefRangeEnd = 42867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildTimeScope()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildTimeScope>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildTimeScope.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010EA RID: 4330 RVA: 0x0005A574 File Offset: 0x00058774
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 42883, RefRangeEnd = 42885, XrefRangeStart = 42868, XrefRangeEnd = 42883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushFunction(IClosureBuilder closureBuilder, bool hasVarArgs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(closureBuilder);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasVarArgs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildTimeScope.NativeMethodInfoPtr_PushFunction_Public_Void_IClosureBuilder_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010EB RID: 4331 RVA: 0x0005A5C4 File Offset: 0x000587C4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 42890, RefRangeEnd = 42897, XrefRangeStart = 42885, XrefRangeEnd = 42890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushBlock()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildTimeScope.NativeMethodInfoPtr_PushBlock_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010EC RID: 4332 RVA: 0x0005A5F8 File Offset: 0x000587F8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 42902, RefRangeEnd = 42909, XrefRangeStart = 42897, XrefRangeEnd = 42902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeScopeBlock PopBlock()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildTimeScope.NativeMethodInfoPtr_PopBlock_Public_RuntimeScopeBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuntimeScopeBlock>(intPtr3) : null;
		}

		// Token: 0x060010ED RID: 4333 RVA: 0x0005A638 File Offset: 0x00058838
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 42923, RefRangeEnd = 42925, XrefRangeStart = 42909, XrefRangeEnd = 42923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeScopeFrame PopFunction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildTimeScope.NativeMethodInfoPtr_PopFunction_Public_RuntimeScopeFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuntimeScopeFrame>(intPtr3) : null;
		}

		// Token: 0x060010EE RID: 4334 RVA: 0x0005A678 File Offset: 0x00058878
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 42944, RefRangeEnd = 42950, XrefRangeStart = 42925, XrefRangeEnd = 42944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SymbolRef Find(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildTimeScope.NativeMethodInfoPtr_Find_Public_SymbolRef_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SymbolRef>(intPtr3) : null;
			}
		}

		// Token: 0x060010EF RID: 4335 RVA: 0x0005A6C8 File Offset: 0x000588C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42950, XrefRangeEnd = 42965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SymbolRef CreateGlobalReference(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildTimeScope.NativeMethodInfoPtr_CreateGlobalReference_Public_SymbolRef_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SymbolRef>(intPtr3) : null;
			}
		}

		// Token: 0x060010F0 RID: 4336 RVA: 0x0005A718 File Offset: 0x00058918
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 42968, RefRangeEnd = 42969, XrefRangeStart = 42965, XrefRangeEnd = 42968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ForceEnvUpValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildTimeScope.NativeMethodInfoPtr_ForceEnvUpValue_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010F1 RID: 4337 RVA: 0x0005A74C File Offset: 0x0005894C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 42979, RefRangeEnd = 42981, XrefRangeStart = 42969, XrefRangeEnd = 42979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SymbolRef CreateUpValue(BuildTimeScope buildTimeScope, SymbolRef symb, int closuredFrame, int currentFrame)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buildTimeScope);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(symb);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref closuredFrame;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentFrame;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildTimeScope.NativeMethodInfoPtr_CreateUpValue_Private_SymbolRef_BuildTimeScope_SymbolRef_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SymbolRef>(intPtr3) : null;
		}

		// Token: 0x060010F2 RID: 4338 RVA: 0x0005A7CC File Offset: 0x000589CC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 42986, RefRangeEnd = 42991, XrefRangeStart = 42981, XrefRangeEnd = 42986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SymbolRef DefineLocal(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildTimeScope.NativeMethodInfoPtr_DefineLocal_Public_SymbolRef_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SymbolRef>(intPtr3) : null;
			}
		}

		// Token: 0x060010F3 RID: 4339 RVA: 0x0005A81C File Offset: 0x00058A1C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 42996, RefRangeEnd = 42999, XrefRangeStart = 42991, XrefRangeEnd = 42996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SymbolRef TryDefineLocal(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildTimeScope.NativeMethodInfoPtr_TryDefineLocal_Public_SymbolRef_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SymbolRef>(intPtr3) : null;
			}
		}

		// Token: 0x060010F4 RID: 4340 RVA: 0x0005A86C File Offset: 0x00058A6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43002, RefRangeEnd = 43003, XrefRangeStart = 42999, XrefRangeEnd = 43002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CurrentFunctionHasVarArgs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildTimeScope.NativeMethodInfoPtr_CurrentFunctionHasVarArgs_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010F5 RID: 4341 RVA: 0x0005A8A8 File Offset: 0x00058AA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43008, RefRangeEnd = 43009, XrefRangeStart = 43003, XrefRangeEnd = 43008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DefineLabel(LabelStatement label)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(label);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildTimeScope.NativeMethodInfoPtr_DefineLabel_Internal_Void_LabelStatement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010F6 RID: 4342 RVA: 0x0005A8EC File Offset: 0x00058AEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43014, RefRangeEnd = 43015, XrefRangeStart = 43009, XrefRangeEnd = 43014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterGoto(GotoStatement gotostat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gotostat);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildTimeScope.NativeMethodInfoPtr_RegisterGoto_Internal_Void_GotoStatement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010F7 RID: 4343 RVA: 0x000070A5 File Offset: 0x000052A5
		public BuildTimeScope(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x060010F8 RID: 4344 RVA: 0x0005A930 File Offset: 0x00058B30
		// (set) Token: 0x060010F9 RID: 4345 RVA: 0x000070AE File Offset: 0x000052AE
		public unsafe List<BuildTimeScopeFrame> m_Frames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildTimeScope.NativeFieldInfoPtr_m_Frames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BuildTimeScopeFrame>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildTimeScope.NativeFieldInfoPtr_m_Frames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x060010FA RID: 4346 RVA: 0x0005A960 File Offset: 0x00058B60
		// (set) Token: 0x060010FB RID: 4347 RVA: 0x000070CD File Offset: 0x000052CD
		public unsafe List<IClosureBuilder> m_ClosureBuilders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildTimeScope.NativeFieldInfoPtr_m_ClosureBuilders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IClosureBuilder>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildTimeScope.NativeFieldInfoPtr_m_ClosureBuilders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000DD0 RID: 3536
		private static readonly IntPtr NativeFieldInfoPtr_m_Frames;

		// Token: 0x04000DD1 RID: 3537
		private static readonly IntPtr NativeFieldInfoPtr_m_ClosureBuilders;

		// Token: 0x04000DD2 RID: 3538
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000DD3 RID: 3539
		private static readonly IntPtr NativeMethodInfoPtr_PushFunction_Public_Void_IClosureBuilder_Boolean_0;

		// Token: 0x04000DD4 RID: 3540
		private static readonly IntPtr NativeMethodInfoPtr_PushBlock_Public_Void_0;

		// Token: 0x04000DD5 RID: 3541
		private static readonly IntPtr NativeMethodInfoPtr_PopBlock_Public_RuntimeScopeBlock_0;

		// Token: 0x04000DD6 RID: 3542
		private static readonly IntPtr NativeMethodInfoPtr_PopFunction_Public_RuntimeScopeFrame_0;

		// Token: 0x04000DD7 RID: 3543
		private static readonly IntPtr NativeMethodInfoPtr_Find_Public_SymbolRef_String_0;

		// Token: 0x04000DD8 RID: 3544
		private static readonly IntPtr NativeMethodInfoPtr_CreateGlobalReference_Public_SymbolRef_String_0;

		// Token: 0x04000DD9 RID: 3545
		private static readonly IntPtr NativeMethodInfoPtr_ForceEnvUpValue_Public_Void_0;

		// Token: 0x04000DDA RID: 3546
		private static readonly IntPtr NativeMethodInfoPtr_CreateUpValue_Private_SymbolRef_BuildTimeScope_SymbolRef_Int32_Int32_0;

		// Token: 0x04000DDB RID: 3547
		private static readonly IntPtr NativeMethodInfoPtr_DefineLocal_Public_SymbolRef_String_0;

		// Token: 0x04000DDC RID: 3548
		private static readonly IntPtr NativeMethodInfoPtr_TryDefineLocal_Public_SymbolRef_String_0;

		// Token: 0x04000DDD RID: 3549
		private static readonly IntPtr NativeMethodInfoPtr_CurrentFunctionHasVarArgs_Public_Boolean_0;

		// Token: 0x04000DDE RID: 3550
		private static readonly IntPtr NativeMethodInfoPtr_DefineLabel_Internal_Void_LabelStatement_0;

		// Token: 0x04000DDF RID: 3551
		private static readonly IntPtr NativeMethodInfoPtr_RegisterGoto_Internal_Void_GotoStatement_0;
	}
}
