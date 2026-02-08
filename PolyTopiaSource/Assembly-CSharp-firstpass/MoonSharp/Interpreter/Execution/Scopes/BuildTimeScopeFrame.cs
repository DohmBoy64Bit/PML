using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using MoonSharp.Interpreter.Tree.Statements;

namespace MoonSharp.Interpreter.Execution.Scopes
{
	// Token: 0x020000EF RID: 239
	public class BuildTimeScopeFrame : Object
	{
		// Token: 0x0600126F RID: 4719 RVA: 0x00060D4C File Offset: 0x0005EF4C
		// Note: this type is marked as 'beforefieldinit'.
		static BuildTimeScopeFrame()
		{
			Il2CppClassPointerStore<BuildTimeScopeFrame>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Execution.Scopes", "BuildTimeScopeFrame");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildTimeScopeFrame>.NativeClassPtr);
			BuildTimeScopeFrame.NativeFieldInfoPtr_m_ScopeTreeRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildTimeScopeFrame>.NativeClassPtr, "m_ScopeTreeRoot");
			BuildTimeScopeFrame.NativeFieldInfoPtr_m_ScopeTreeHead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildTimeScopeFrame>.NativeClassPtr, "m_ScopeTreeHead");
			BuildTimeScopeFrame.NativeFieldInfoPtr_m_ScopeFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildTimeScopeFrame>.NativeClassPtr, "m_ScopeFrame");
			BuildTimeScopeFrame.NativeFieldInfoPtr__HasVarArgs_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildTimeScopeFrame>.NativeClassPtr, "<HasVarArgs>k__BackingField");
			BuildTimeScopeFrame.NativeMethodInfoPtr_get_HasVarArgs_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildTimeScopeFrame>.NativeClassPtr, 100666548);
			BuildTimeScopeFrame.NativeMethodInfoPtr_set_HasVarArgs_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildTimeScopeFrame>.NativeClassPtr, 100666549);
			BuildTimeScopeFrame.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildTimeScopeFrame>.NativeClassPtr, 100666550);
			BuildTimeScopeFrame.NativeMethodInfoPtr_PushBlock_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildTimeScopeFrame>.NativeClassPtr, 100666551);
			BuildTimeScopeFrame.NativeMethodInfoPtr_PopBlock_Internal_RuntimeScopeBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildTimeScopeFrame>.NativeClassPtr, 100666552);
			BuildTimeScopeFrame.NativeMethodInfoPtr_GetRuntimeFrameData_Internal_RuntimeScopeFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildTimeScopeFrame>.NativeClassPtr, 100666553);
			BuildTimeScopeFrame.NativeMethodInfoPtr_Find_Internal_SymbolRef_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildTimeScopeFrame>.NativeClassPtr, 100666554);
			BuildTimeScopeFrame.NativeMethodInfoPtr_DefineLocal_Internal_SymbolRef_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildTimeScopeFrame>.NativeClassPtr, 100666555);
			BuildTimeScopeFrame.NativeMethodInfoPtr_TryDefineLocal_Internal_SymbolRef_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildTimeScopeFrame>.NativeClassPtr, 100666556);
			BuildTimeScopeFrame.NativeMethodInfoPtr_ResolveLRefs_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildTimeScopeFrame>.NativeClassPtr, 100666557);
			BuildTimeScopeFrame.NativeMethodInfoPtr_AllocVar_Internal_Int32_SymbolRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildTimeScopeFrame>.NativeClassPtr, 100666558);
			BuildTimeScopeFrame.NativeMethodInfoPtr_GetPosForNextVar_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildTimeScopeFrame>.NativeClassPtr, 100666559);
			BuildTimeScopeFrame.NativeMethodInfoPtr_DefineLabel_Internal_Void_LabelStatement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildTimeScopeFrame>.NativeClassPtr, 100666560);
			BuildTimeScopeFrame.NativeMethodInfoPtr_RegisterGoto_Internal_Void_GotoStatement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildTimeScopeFrame>.NativeClassPtr, 100666561);
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x06001270 RID: 4720 RVA: 0x00060EE4 File Offset: 0x0005F0E4
		// (set) Token: 0x06001271 RID: 4721 RVA: 0x00060F20 File Offset: 0x0005F120
		public unsafe bool HasVarArgs
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildTimeScopeFrame.NativeMethodInfoPtr_get_HasVarArgs_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildTimeScopeFrame.NativeMethodInfoPtr_set_HasVarArgs_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001272 RID: 4722 RVA: 0x00060F60 File Offset: 0x0005F160
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 46242, RefRangeEnd = 46243, XrefRangeStart = 46230, XrefRangeEnd = 46242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildTimeScopeFrame(bool hasVarArgs)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildTimeScopeFrame>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hasVarArgs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildTimeScopeFrame.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001273 RID: 4723 RVA: 0x00060FA8 File Offset: 0x0005F1A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 46255, RefRangeEnd = 46256, XrefRangeStart = 46243, XrefRangeEnd = 46255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushBlock()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildTimeScopeFrame.NativeMethodInfoPtr_PushBlock_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001274 RID: 4724 RVA: 0x00060FDC File Offset: 0x0005F1DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 46258, RefRangeEnd = 46259, XrefRangeStart = 46256, XrefRangeEnd = 46258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeScopeBlock PopBlock()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildTimeScopeFrame.NativeMethodInfoPtr_PopBlock_Internal_RuntimeScopeBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuntimeScopeBlock>(intPtr3) : null;
		}

		// Token: 0x06001275 RID: 4725 RVA: 0x0006101C File Offset: 0x0005F21C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 46259, RefRangeEnd = 46260, XrefRangeStart = 46259, XrefRangeEnd = 46259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeScopeFrame GetRuntimeFrameData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildTimeScopeFrame.NativeMethodInfoPtr_GetRuntimeFrameData_Internal_RuntimeScopeFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuntimeScopeFrame>(intPtr3) : null;
		}

		// Token: 0x06001276 RID: 4726 RVA: 0x0006105C File Offset: 0x0005F25C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 46263, RefRangeEnd = 46265, XrefRangeStart = 46260, XrefRangeEnd = 46263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SymbolRef Find(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildTimeScopeFrame.NativeMethodInfoPtr_Find_Internal_SymbolRef_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SymbolRef>(intPtr3) : null;
			}
		}

		// Token: 0x06001277 RID: 4727 RVA: 0x000610AC File Offset: 0x0005F2AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 46267, RefRangeEnd = 46268, XrefRangeStart = 46265, XrefRangeEnd = 46267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SymbolRef DefineLocal(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildTimeScopeFrame.NativeMethodInfoPtr_DefineLocal_Internal_SymbolRef_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SymbolRef>(intPtr3) : null;
			}
		}

		// Token: 0x06001278 RID: 4728 RVA: 0x000610FC File Offset: 0x0005F2FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 46292, RefRangeEnd = 46293, XrefRangeStart = 46268, XrefRangeEnd = 46292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SymbolRef TryDefineLocal(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildTimeScopeFrame.NativeMethodInfoPtr_TryDefineLocal_Internal_SymbolRef_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SymbolRef>(intPtr3) : null;
			}
		}

		// Token: 0x06001279 RID: 4729 RVA: 0x0006114C File Offset: 0x0005F34C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 46296, RefRangeEnd = 46297, XrefRangeStart = 46293, XrefRangeEnd = 46296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResolveLRefs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildTimeScopeFrame.NativeMethodInfoPtr_ResolveLRefs_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600127A RID: 4730 RVA: 0x00061180 File Offset: 0x0005F380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46297, XrefRangeEnd = 46301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int AllocVar(SymbolRef var)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(var);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildTimeScopeFrame.NativeMethodInfoPtr_AllocVar_Internal_Int32_SymbolRef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600127B RID: 4731 RVA: 0x000611D0 File Offset: 0x0005F3D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46301, XrefRangeEnd = 46302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetPosForNextVar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildTimeScopeFrame.NativeMethodInfoPtr_GetPosForNextVar_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600127C RID: 4732 RVA: 0x0006120C File Offset: 0x0005F40C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 46304, RefRangeEnd = 46305, XrefRangeStart = 46302, XrefRangeEnd = 46304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DefineLabel(LabelStatement label)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(label);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildTimeScopeFrame.NativeMethodInfoPtr_DefineLabel_Internal_Void_LabelStatement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600127D RID: 4733 RVA: 0x00061250 File Offset: 0x0005F450
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 46307, RefRangeEnd = 46308, XrefRangeStart = 46305, XrefRangeEnd = 46307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterGoto(GotoStatement gotostat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gotostat);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildTimeScopeFrame.NativeMethodInfoPtr_RegisterGoto_Internal_Void_GotoStatement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600127E RID: 4734 RVA: 0x00007952 File Offset: 0x00005B52
		public BuildTimeScopeFrame(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x0600127F RID: 4735 RVA: 0x00061294 File Offset: 0x0005F494
		// (set) Token: 0x06001280 RID: 4736 RVA: 0x0000795B File Offset: 0x00005B5B
		public unsafe BuildTimeScopeBlock m_ScopeTreeRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildTimeScopeFrame.NativeFieldInfoPtr_m_ScopeTreeRoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BuildTimeScopeBlock>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildTimeScopeFrame.NativeFieldInfoPtr_m_ScopeTreeRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x06001281 RID: 4737 RVA: 0x000612C4 File Offset: 0x0005F4C4
		// (set) Token: 0x06001282 RID: 4738 RVA: 0x0000797A File Offset: 0x00005B7A
		public unsafe BuildTimeScopeBlock m_ScopeTreeHead
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildTimeScopeFrame.NativeFieldInfoPtr_m_ScopeTreeHead);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BuildTimeScopeBlock>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildTimeScopeFrame.NativeFieldInfoPtr_m_ScopeTreeHead), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x06001283 RID: 4739 RVA: 0x000612F4 File Offset: 0x0005F4F4
		// (set) Token: 0x06001284 RID: 4740 RVA: 0x00007999 File Offset: 0x00005B99
		public unsafe RuntimeScopeFrame m_ScopeFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildTimeScopeFrame.NativeFieldInfoPtr_m_ScopeFrame);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RuntimeScopeFrame>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildTimeScopeFrame.NativeFieldInfoPtr_m_ScopeFrame), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06001285 RID: 4741 RVA: 0x00061324 File Offset: 0x0005F524
		// (set) Token: 0x06001286 RID: 4742 RVA: 0x000079B8 File Offset: 0x00005BB8
		public unsafe bool _HasVarArgs_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildTimeScopeFrame.NativeFieldInfoPtr__HasVarArgs_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildTimeScopeFrame.NativeFieldInfoPtr__HasVarArgs_k__BackingField)) = value;
			}
		}

		// Token: 0x04000F37 RID: 3895
		private static readonly IntPtr NativeFieldInfoPtr_m_ScopeTreeRoot;

		// Token: 0x04000F38 RID: 3896
		private static readonly IntPtr NativeFieldInfoPtr_m_ScopeTreeHead;

		// Token: 0x04000F39 RID: 3897
		private static readonly IntPtr NativeFieldInfoPtr_m_ScopeFrame;

		// Token: 0x04000F3A RID: 3898
		private static readonly IntPtr NativeFieldInfoPtr__HasVarArgs_k__BackingField;

		// Token: 0x04000F3B RID: 3899
		private static readonly IntPtr NativeMethodInfoPtr_get_HasVarArgs_Public_get_Boolean_0;

		// Token: 0x04000F3C RID: 3900
		private static readonly IntPtr NativeMethodInfoPtr_set_HasVarArgs_Private_set_Void_Boolean_0;

		// Token: 0x04000F3D RID: 3901
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0;

		// Token: 0x04000F3E RID: 3902
		private static readonly IntPtr NativeMethodInfoPtr_PushBlock_Internal_Void_0;

		// Token: 0x04000F3F RID: 3903
		private static readonly IntPtr NativeMethodInfoPtr_PopBlock_Internal_RuntimeScopeBlock_0;

		// Token: 0x04000F40 RID: 3904
		private static readonly IntPtr NativeMethodInfoPtr_GetRuntimeFrameData_Internal_RuntimeScopeFrame_0;

		// Token: 0x04000F41 RID: 3905
		private static readonly IntPtr NativeMethodInfoPtr_Find_Internal_SymbolRef_String_0;

		// Token: 0x04000F42 RID: 3906
		private static readonly IntPtr NativeMethodInfoPtr_DefineLocal_Internal_SymbolRef_String_0;

		// Token: 0x04000F43 RID: 3907
		private static readonly IntPtr NativeMethodInfoPtr_TryDefineLocal_Internal_SymbolRef_String_0;

		// Token: 0x04000F44 RID: 3908
		private static readonly IntPtr NativeMethodInfoPtr_ResolveLRefs_Internal_Void_0;

		// Token: 0x04000F45 RID: 3909
		private static readonly IntPtr NativeMethodInfoPtr_AllocVar_Internal_Int32_SymbolRef_0;

		// Token: 0x04000F46 RID: 3910
		private static readonly IntPtr NativeMethodInfoPtr_GetPosForNextVar_Internal_Int32_0;

		// Token: 0x04000F47 RID: 3911
		private static readonly IntPtr NativeMethodInfoPtr_DefineLabel_Internal_Void_LabelStatement_0;

		// Token: 0x04000F48 RID: 3912
		private static readonly IntPtr NativeMethodInfoPtr_RegisterGoto_Internal_Void_GotoStatement_0;
	}
}
