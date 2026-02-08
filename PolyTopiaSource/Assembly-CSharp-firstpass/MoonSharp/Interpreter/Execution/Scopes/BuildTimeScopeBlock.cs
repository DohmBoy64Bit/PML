using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using MoonSharp.Interpreter.Tree.Statements;

namespace MoonSharp.Interpreter.Execution.Scopes
{
	// Token: 0x020000EE RID: 238
	public class BuildTimeScopeBlock : Object
	{
		// Token: 0x06001250 RID: 4688 RVA: 0x00060614 File Offset: 0x0005E814
		// Note: this type is marked as 'beforefieldinit'.
		static BuildTimeScopeBlock()
		{
			Il2CppClassPointerStore<BuildTimeScopeBlock>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Execution.Scopes", "BuildTimeScopeBlock");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildTimeScopeBlock>.NativeClassPtr);
			BuildTimeScopeBlock.NativeFieldInfoPtr__Parent_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildTimeScopeBlock>.NativeClassPtr, "<Parent>k__BackingField");
			BuildTimeScopeBlock.NativeFieldInfoPtr__ChildNodes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildTimeScopeBlock>.NativeClassPtr, "<ChildNodes>k__BackingField");
			BuildTimeScopeBlock.NativeFieldInfoPtr__ScopeBlock_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildTimeScopeBlock>.NativeClassPtr, "<ScopeBlock>k__BackingField");
			BuildTimeScopeBlock.NativeFieldInfoPtr_m_DefinedNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildTimeScopeBlock>.NativeClassPtr, "m_DefinedNames");
			BuildTimeScopeBlock.NativeFieldInfoPtr_m_PendingGotos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildTimeScopeBlock>.NativeClassPtr, "m_PendingGotos");
			BuildTimeScopeBlock.NativeFieldInfoPtr_m_LocalLabels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildTimeScopeBlock>.NativeClassPtr, "m_LocalLabels");
			BuildTimeScopeBlock.NativeFieldInfoPtr_m_LastDefinedName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildTimeScopeBlock>.NativeClassPtr, "m_LastDefinedName");
			BuildTimeScopeBlock.NativeMethodInfoPtr_get_Parent_Internal_get_BuildTimeScopeBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildTimeScopeBlock>.NativeClassPtr, 100666533);
			BuildTimeScopeBlock.NativeMethodInfoPtr_set_Parent_Private_set_Void_BuildTimeScopeBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildTimeScopeBlock>.NativeClassPtr, 100666534);
			BuildTimeScopeBlock.NativeMethodInfoPtr_get_ChildNodes_Internal_get_List_1_BuildTimeScopeBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildTimeScopeBlock>.NativeClassPtr, 100666535);
			BuildTimeScopeBlock.NativeMethodInfoPtr_set_ChildNodes_Private_set_Void_List_1_BuildTimeScopeBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildTimeScopeBlock>.NativeClassPtr, 100666536);
			BuildTimeScopeBlock.NativeMethodInfoPtr_get_ScopeBlock_Internal_get_RuntimeScopeBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildTimeScopeBlock>.NativeClassPtr, 100666537);
			BuildTimeScopeBlock.NativeMethodInfoPtr_set_ScopeBlock_Private_set_Void_RuntimeScopeBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildTimeScopeBlock>.NativeClassPtr, 100666538);
			BuildTimeScopeBlock.NativeMethodInfoPtr__ctor_Internal_Void_BuildTimeScopeBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildTimeScopeBlock>.NativeClassPtr, 100666540);
			BuildTimeScopeBlock.NativeMethodInfoPtr_Rename_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildTimeScopeBlock>.NativeClassPtr, 100666539);
			BuildTimeScopeBlock.NativeMethodInfoPtr_AddChild_Internal_BuildTimeScopeBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildTimeScopeBlock>.NativeClassPtr, 100666541);
			BuildTimeScopeBlock.NativeMethodInfoPtr_Find_Internal_SymbolRef_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildTimeScopeBlock>.NativeClassPtr, 100666542);
			BuildTimeScopeBlock.NativeMethodInfoPtr_Define_Internal_SymbolRef_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildTimeScopeBlock>.NativeClassPtr, 100666543);
			BuildTimeScopeBlock.NativeMethodInfoPtr_ResolveLRefs_Internal_Int32_BuildTimeScopeFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildTimeScopeBlock>.NativeClassPtr, 100666544);
			BuildTimeScopeBlock.NativeMethodInfoPtr_DefineLabel_Internal_Void_LabelStatement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildTimeScopeBlock>.NativeClassPtr, 100666545);
			BuildTimeScopeBlock.NativeMethodInfoPtr_RegisterGoto_Internal_Void_GotoStatement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildTimeScopeBlock>.NativeClassPtr, 100666546);
			BuildTimeScopeBlock.NativeMethodInfoPtr_ResolveGotos_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildTimeScopeBlock>.NativeClassPtr, 100666547);
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x06001251 RID: 4689 RVA: 0x000607FC File Offset: 0x0005E9FC
		// (set) Token: 0x06001252 RID: 4690 RVA: 0x0006083C File Offset: 0x0005EA3C
		public unsafe BuildTimeScopeBlock Parent
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 17906, RefRangeEnd = 17917, XrefRangeStart = 17906, XrefRangeEnd = 17917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildTimeScopeBlock.NativeMethodInfoPtr_get_Parent_Internal_get_BuildTimeScopeBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BuildTimeScopeBlock>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildTimeScopeBlock.NativeMethodInfoPtr_set_Parent_Private_set_Void_BuildTimeScopeBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06001253 RID: 4691 RVA: 0x00060880 File Offset: 0x0005EA80
		// (set) Token: 0x06001254 RID: 4692 RVA: 0x000608C0 File Offset: 0x0005EAC0
		public unsafe List<BuildTimeScopeBlock> ChildNodes
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildTimeScopeBlock.NativeMethodInfoPtr_get_ChildNodes_Internal_get_List_1_BuildTimeScopeBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<BuildTimeScopeBlock>>(intPtr3) : null;
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 21274, RefRangeEnd = 21282, XrefRangeStart = 21274, XrefRangeEnd = 21282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildTimeScopeBlock.NativeMethodInfoPtr_set_ChildNodes_Private_set_Void_List_1_BuildTimeScopeBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06001255 RID: 4693 RVA: 0x00060904 File Offset: 0x0005EB04
		// (set) Token: 0x06001256 RID: 4694 RVA: 0x00060944 File Offset: 0x0005EB44
		public unsafe RuntimeScopeBlock ScopeBlock
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 21282, RefRangeEnd = 21289, XrefRangeStart = 21282, XrefRangeEnd = 21289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildTimeScopeBlock.NativeMethodInfoPtr_get_ScopeBlock_Internal_get_RuntimeScopeBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuntimeScopeBlock>(intPtr3) : null;
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 21290, RefRangeEnd = 21298, XrefRangeStart = 21290, XrefRangeEnd = 21298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildTimeScopeBlock.NativeMethodInfoPtr_set_ScopeBlock_Private_set_Void_RuntimeScopeBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001257 RID: 4695 RVA: 0x00060988 File Offset: 0x0005EB88
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 46034, RefRangeEnd = 46037, XrefRangeStart = 46013, XrefRangeEnd = 46034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildTimeScopeBlock(BuildTimeScopeBlock parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildTimeScopeBlock>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildTimeScopeBlock.NativeMethodInfoPtr__ctor_Internal_Void_BuildTimeScopeBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001258 RID: 4696 RVA: 0x000609D4 File Offset: 0x0005EBD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46037, XrefRangeEnd = 46055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Rename(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildTimeScopeBlock.NativeMethodInfoPtr_Rename_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001259 RID: 4697 RVA: 0x00060A18 File Offset: 0x0005EC18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46055, XrefRangeEnd = 46062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildTimeScopeBlock AddChild()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildTimeScopeBlock.NativeMethodInfoPtr_AddChild_Internal_BuildTimeScopeBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BuildTimeScopeBlock>(intPtr3) : null;
		}

		// Token: 0x0600125A RID: 4698 RVA: 0x00060A58 File Offset: 0x0005EC58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46062, XrefRangeEnd = 46065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SymbolRef Find(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildTimeScopeBlock.NativeMethodInfoPtr_Find_Internal_SymbolRef_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SymbolRef>(intPtr3) : null;
			}
		}

		// Token: 0x0600125B RID: 4699 RVA: 0x00060AA8 File Offset: 0x0005ECA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 46073, RefRangeEnd = 46075, XrefRangeStart = 46065, XrefRangeEnd = 46073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SymbolRef Define(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildTimeScopeBlock.NativeMethodInfoPtr_Define_Internal_SymbolRef_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SymbolRef>(intPtr3) : null;
			}
		}

		// Token: 0x0600125C RID: 4700 RVA: 0x00060AF8 File Offset: 0x0005ECF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 46136, RefRangeEnd = 46138, XrefRangeStart = 46075, XrefRangeEnd = 46136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ResolveLRefs(BuildTimeScopeFrame buildTimeScopeFrame)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buildTimeScopeFrame);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildTimeScopeBlock.NativeMethodInfoPtr_ResolveLRefs_Internal_Int32_BuildTimeScopeFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600125D RID: 4701 RVA: 0x00060B48 File Offset: 0x0005ED48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 46185, RefRangeEnd = 46186, XrefRangeStart = 46138, XrefRangeEnd = 46185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DefineLabel(LabelStatement label)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(label);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildTimeScopeBlock.NativeMethodInfoPtr_DefineLabel_Internal_Void_LabelStatement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600125E RID: 4702 RVA: 0x00060B8C File Offset: 0x0005ED8C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 46204, RefRangeEnd = 46206, XrefRangeStart = 46186, XrefRangeEnd = 46204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterGoto(GotoStatement gotostat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gotostat);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildTimeScopeBlock.NativeMethodInfoPtr_RegisterGoto_Internal_Void_GotoStatement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600125F RID: 4703 RVA: 0x00060BD0 File Offset: 0x0005EDD0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 46228, RefRangeEnd = 46230, XrefRangeStart = 46206, XrefRangeEnd = 46228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResolveGotos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildTimeScopeBlock.NativeMethodInfoPtr_ResolveGotos_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001260 RID: 4704 RVA: 0x00007870 File Offset: 0x00005A70
		public BuildTimeScopeBlock(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06001261 RID: 4705 RVA: 0x00060C04 File Offset: 0x0005EE04
		// (set) Token: 0x06001262 RID: 4706 RVA: 0x00007879 File Offset: 0x00005A79
		public unsafe BuildTimeScopeBlock _Parent_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildTimeScopeBlock.NativeFieldInfoPtr__Parent_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BuildTimeScopeBlock>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildTimeScopeBlock.NativeFieldInfoPtr__Parent_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x06001263 RID: 4707 RVA: 0x00060C34 File Offset: 0x0005EE34
		// (set) Token: 0x06001264 RID: 4708 RVA: 0x00007898 File Offset: 0x00005A98
		public unsafe List<BuildTimeScopeBlock> _ChildNodes_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildTimeScopeBlock.NativeFieldInfoPtr__ChildNodes_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BuildTimeScopeBlock>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildTimeScopeBlock.NativeFieldInfoPtr__ChildNodes_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x06001265 RID: 4709 RVA: 0x00060C64 File Offset: 0x0005EE64
		// (set) Token: 0x06001266 RID: 4710 RVA: 0x000078B7 File Offset: 0x00005AB7
		public unsafe RuntimeScopeBlock _ScopeBlock_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildTimeScopeBlock.NativeFieldInfoPtr__ScopeBlock_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RuntimeScopeBlock>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildTimeScopeBlock.NativeFieldInfoPtr__ScopeBlock_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x06001267 RID: 4711 RVA: 0x00060C94 File Offset: 0x0005EE94
		// (set) Token: 0x06001268 RID: 4712 RVA: 0x000078D6 File Offset: 0x00005AD6
		public unsafe Dictionary<string, SymbolRef> m_DefinedNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildTimeScopeBlock.NativeFieldInfoPtr_m_DefinedNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, SymbolRef>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildTimeScopeBlock.NativeFieldInfoPtr_m_DefinedNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x06001269 RID: 4713 RVA: 0x00060CC4 File Offset: 0x0005EEC4
		// (set) Token: 0x0600126A RID: 4714 RVA: 0x000078F5 File Offset: 0x00005AF5
		public unsafe List<GotoStatement> m_PendingGotos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildTimeScopeBlock.NativeFieldInfoPtr_m_PendingGotos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GotoStatement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildTimeScopeBlock.NativeFieldInfoPtr_m_PendingGotos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x0600126B RID: 4715 RVA: 0x00060CF4 File Offset: 0x0005EEF4
		// (set) Token: 0x0600126C RID: 4716 RVA: 0x00007914 File Offset: 0x00005B14
		public unsafe Dictionary<string, LabelStatement> m_LocalLabels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildTimeScopeBlock.NativeFieldInfoPtr_m_LocalLabels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, LabelStatement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildTimeScopeBlock.NativeFieldInfoPtr_m_LocalLabels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x0600126D RID: 4717 RVA: 0x00060D24 File Offset: 0x0005EF24
		// (set) Token: 0x0600126E RID: 4718 RVA: 0x00007933 File Offset: 0x00005B33
		public unsafe string m_LastDefinedName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildTimeScopeBlock.NativeFieldInfoPtr_m_LastDefinedName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildTimeScopeBlock.NativeFieldInfoPtr_m_LastDefinedName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000F21 RID: 3873
		private static readonly IntPtr NativeFieldInfoPtr__Parent_k__BackingField;

		// Token: 0x04000F22 RID: 3874
		private static readonly IntPtr NativeFieldInfoPtr__ChildNodes_k__BackingField;

		// Token: 0x04000F23 RID: 3875
		private static readonly IntPtr NativeFieldInfoPtr__ScopeBlock_k__BackingField;

		// Token: 0x04000F24 RID: 3876
		private static readonly IntPtr NativeFieldInfoPtr_m_DefinedNames;

		// Token: 0x04000F25 RID: 3877
		private static readonly IntPtr NativeFieldInfoPtr_m_PendingGotos;

		// Token: 0x04000F26 RID: 3878
		private static readonly IntPtr NativeFieldInfoPtr_m_LocalLabels;

		// Token: 0x04000F27 RID: 3879
		private static readonly IntPtr NativeFieldInfoPtr_m_LastDefinedName;

		// Token: 0x04000F28 RID: 3880
		private static readonly IntPtr NativeMethodInfoPtr_get_Parent_Internal_get_BuildTimeScopeBlock_0;

		// Token: 0x04000F29 RID: 3881
		private static readonly IntPtr NativeMethodInfoPtr_set_Parent_Private_set_Void_BuildTimeScopeBlock_0;

		// Token: 0x04000F2A RID: 3882
		private static readonly IntPtr NativeMethodInfoPtr_get_ChildNodes_Internal_get_List_1_BuildTimeScopeBlock_0;

		// Token: 0x04000F2B RID: 3883
		private static readonly IntPtr NativeMethodInfoPtr_set_ChildNodes_Private_set_Void_List_1_BuildTimeScopeBlock_0;

		// Token: 0x04000F2C RID: 3884
		private static readonly IntPtr NativeMethodInfoPtr_get_ScopeBlock_Internal_get_RuntimeScopeBlock_0;

		// Token: 0x04000F2D RID: 3885
		private static readonly IntPtr NativeMethodInfoPtr_set_ScopeBlock_Private_set_Void_RuntimeScopeBlock_0;

		// Token: 0x04000F2E RID: 3886
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_BuildTimeScopeBlock_0;

		// Token: 0x04000F2F RID: 3887
		private static readonly IntPtr NativeMethodInfoPtr_Rename_Internal_Void_String_0;

		// Token: 0x04000F30 RID: 3888
		private static readonly IntPtr NativeMethodInfoPtr_AddChild_Internal_BuildTimeScopeBlock_0;

		// Token: 0x04000F31 RID: 3889
		private static readonly IntPtr NativeMethodInfoPtr_Find_Internal_SymbolRef_String_0;

		// Token: 0x04000F32 RID: 3890
		private static readonly IntPtr NativeMethodInfoPtr_Define_Internal_SymbolRef_String_0;

		// Token: 0x04000F33 RID: 3891
		private static readonly IntPtr NativeMethodInfoPtr_ResolveLRefs_Internal_Int32_BuildTimeScopeFrame_0;

		// Token: 0x04000F34 RID: 3892
		private static readonly IntPtr NativeMethodInfoPtr_DefineLabel_Internal_Void_LabelStatement_0;

		// Token: 0x04000F35 RID: 3893
		private static readonly IntPtr NativeMethodInfoPtr_RegisterGoto_Internal_Void_GotoStatement_0;

		// Token: 0x04000F36 RID: 3894
		private static readonly IntPtr NativeMethodInfoPtr_ResolveGotos_Internal_Void_0;
	}
}
