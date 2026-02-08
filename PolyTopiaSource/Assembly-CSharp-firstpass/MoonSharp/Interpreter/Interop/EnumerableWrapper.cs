using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace MoonSharp.Interpreter.Interop
{
	// Token: 0x020000A3 RID: 163
	public class EnumerableWrapper : Object
	{
		// Token: 0x06000CD7 RID: 3287 RVA: 0x000484E8 File Offset: 0x000466E8
		// Note: this type is marked as 'beforefieldinit'.
		static EnumerableWrapper()
		{
			Il2CppClassPointerStore<EnumerableWrapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Interop", "EnumerableWrapper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumerableWrapper>.NativeClassPtr);
			EnumerableWrapper.NativeFieldInfoPtr_m_Enumerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumerableWrapper>.NativeClassPtr, "m_Enumerator");
			EnumerableWrapper.NativeFieldInfoPtr_m_Script = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumerableWrapper>.NativeClassPtr, "m_Script");
			EnumerableWrapper.NativeFieldInfoPtr_m_Prev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumerableWrapper>.NativeClassPtr, "m_Prev");
			EnumerableWrapper.NativeFieldInfoPtr_m_HasTurnOnce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumerableWrapper>.NativeClassPtr, "m_HasTurnOnce");
			EnumerableWrapper.NativeMethodInfoPtr__ctor_Private_Void_Script_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumerableWrapper>.NativeClassPtr, 100665530);
			EnumerableWrapper.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumerableWrapper>.NativeClassPtr, 100665531);
			EnumerableWrapper.NativeMethodInfoPtr_GetNext_Private_DynValue_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumerableWrapper>.NativeClassPtr, 100665532);
			EnumerableWrapper.NativeMethodInfoPtr_LuaIteratorCallback_Private_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumerableWrapper>.NativeClassPtr, 100665533);
			EnumerableWrapper.NativeMethodInfoPtr_ConvertIterator_Internal_Static_DynValue_Script_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumerableWrapper>.NativeClassPtr, 100665534);
			EnumerableWrapper.NativeMethodInfoPtr_ConvertTable_Internal_Static_DynValue_Table_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumerableWrapper>.NativeClassPtr, 100665535);
			EnumerableWrapper.NativeMethodInfoPtr_Index_Public_Virtual_Final_New_DynValue_Script_DynValue_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumerableWrapper>.NativeClassPtr, 100665536);
			EnumerableWrapper.NativeMethodInfoPtr_SetIndex_Public_Virtual_Final_New_Boolean_Script_DynValue_DynValue_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumerableWrapper>.NativeClassPtr, 100665537);
			EnumerableWrapper.NativeMethodInfoPtr_MetaIndex_Public_Virtual_Final_New_DynValue_Script_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumerableWrapper>.NativeClassPtr, 100665538);
			EnumerableWrapper.NativeMethodInfoPtr__Index_b__10_0_Private_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumerableWrapper>.NativeClassPtr, 100665539);
			EnumerableWrapper.NativeMethodInfoPtr__Index_b__10_1_Private_DynValue_ScriptExecutionContext_CallbackArguments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumerableWrapper>.NativeClassPtr, 100665540);
		}

		// Token: 0x06000CD8 RID: 3288 RVA: 0x00048644 File Offset: 0x00046844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33348, XrefRangeEnd = 33359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EnumerableWrapper(Script script, IEnumerator enumerator)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnumerableWrapper>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(script);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(enumerator);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumerableWrapper.NativeMethodInfoPtr__ctor_Private_Void_Script_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CD9 RID: 3289 RVA: 0x000486A4 File Offset: 0x000468A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33359, XrefRangeEnd = 33362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumerableWrapper.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CDA RID: 3290 RVA: 0x000486D8 File Offset: 0x000468D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33362, XrefRangeEnd = 33374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue GetNext(DynValue prev)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prev);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumerableWrapper.NativeMethodInfoPtr_GetNext_Private_DynValue_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x06000CDB RID: 3291 RVA: 0x00048728 File Offset: 0x00046928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33374, XrefRangeEnd = 33394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue LuaIteratorCallback(ScriptExecutionContext executionContext, CallbackArguments args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(executionContext);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumerableWrapper.NativeMethodInfoPtr_LuaIteratorCallback_Private_DynValue_ScriptExecutionContext_CallbackArguments_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000CDC RID: 3292 RVA: 0x0004878C File Offset: 0x0004698C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 33432, RefRangeEnd = 33433, XrefRangeStart = 33394, XrefRangeEnd = 33432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue ConvertIterator(Script script, IEnumerator enumerator)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(script);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(enumerator);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumerableWrapper.NativeMethodInfoPtr_ConvertIterator_Internal_Static_DynValue_Script_IEnumerator_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000CDD RID: 3293 RVA: 0x000487E4 File Offset: 0x000469E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 33439, RefRangeEnd = 33440, XrefRangeStart = 33433, XrefRangeEnd = 33439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DynValue ConvertTable(Table table)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumerableWrapper.NativeMethodInfoPtr_ConvertTable_Internal_Static_DynValue_Table_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
		}

		// Token: 0x06000CDE RID: 3294 RVA: 0x00048828 File Offset: 0x00046A28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33440, XrefRangeEnd = 33483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual DynValue Index(Script script, DynValue index, bool isDirectIndexing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(script);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(index);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isDirectIndexing;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumerableWrapper.NativeMethodInfoPtr_Index_Public_Virtual_Final_New_DynValue_Script_DynValue_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000CDF RID: 3295 RVA: 0x00048898 File Offset: 0x00046A98
		[CallerCount(126)]
		[CachedScanResults(RefRangeStart = 18232, RefRangeEnd = 18358, XrefRangeStart = 18232, XrefRangeEnd = 18358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool SetIndex(Script script, DynValue index, DynValue value, bool isDirectIndexing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(script);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(index);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isDirectIndexing;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumerableWrapper.NativeMethodInfoPtr_SetIndex_Public_Virtual_Final_New_Boolean_Script_DynValue_DynValue_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CE0 RID: 3296 RVA: 0x00048918 File Offset: 0x00046B18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33483, XrefRangeEnd = 33489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual DynValue MetaIndex(Script script, string metaname)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(script);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(metaname);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumerableWrapper.NativeMethodInfoPtr_MetaIndex_Public_Virtual_Final_New_DynValue_Script_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000CE1 RID: 3297 RVA: 0x0004897C File Offset: 0x00046B7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33489, XrefRangeEnd = 33497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue _Index_b__10_0(ScriptExecutionContext ctx, CallbackArguments args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ctx);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumerableWrapper.NativeMethodInfoPtr__Index_b__10_0_Private_DynValue_ScriptExecutionContext_CallbackArguments_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000CE2 RID: 3298 RVA: 0x000489E0 File Offset: 0x00046BE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33497, XrefRangeEnd = 33507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynValue _Index_b__10_1(ScriptExecutionContext ctx, CallbackArguments args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ctx);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumerableWrapper.NativeMethodInfoPtr__Index_b__10_1_Private_DynValue_ScriptExecutionContext_CallbackArguments_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
		}

		// Token: 0x06000CE3 RID: 3299 RVA: 0x00005C77 File Offset: 0x00003E77
		public EnumerableWrapper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06000CE4 RID: 3300 RVA: 0x00048A44 File Offset: 0x00046C44
		// (set) Token: 0x06000CE5 RID: 3301 RVA: 0x00005C80 File Offset: 0x00003E80
		public unsafe IEnumerator m_Enumerator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumerableWrapper.NativeFieldInfoPtr_m_Enumerator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumerableWrapper.NativeFieldInfoPtr_m_Enumerator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06000CE6 RID: 3302 RVA: 0x00048A74 File Offset: 0x00046C74
		// (set) Token: 0x06000CE7 RID: 3303 RVA: 0x00005C9F File Offset: 0x00003E9F
		public unsafe Script m_Script
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumerableWrapper.NativeFieldInfoPtr_m_Script);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Script>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumerableWrapper.NativeFieldInfoPtr_m_Script), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06000CE8 RID: 3304 RVA: 0x00048AA4 File Offset: 0x00046CA4
		// (set) Token: 0x06000CE9 RID: 3305 RVA: 0x00005CBE File Offset: 0x00003EBE
		public unsafe DynValue m_Prev
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumerableWrapper.NativeFieldInfoPtr_m_Prev);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumerableWrapper.NativeFieldInfoPtr_m_Prev), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06000CEA RID: 3306 RVA: 0x00048AD4 File Offset: 0x00046CD4
		// (set) Token: 0x06000CEB RID: 3307 RVA: 0x00005CDD File Offset: 0x00003EDD
		public unsafe bool m_HasTurnOnce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumerableWrapper.NativeFieldInfoPtr_m_HasTurnOnce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumerableWrapper.NativeFieldInfoPtr_m_HasTurnOnce)) = value;
			}
		}

		// Token: 0x04000AA9 RID: 2729
		private static readonly IntPtr NativeFieldInfoPtr_m_Enumerator;

		// Token: 0x04000AAA RID: 2730
		private static readonly IntPtr NativeFieldInfoPtr_m_Script;

		// Token: 0x04000AAB RID: 2731
		private static readonly IntPtr NativeFieldInfoPtr_m_Prev;

		// Token: 0x04000AAC RID: 2732
		private static readonly IntPtr NativeFieldInfoPtr_m_HasTurnOnce;

		// Token: 0x04000AAD RID: 2733
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Script_IEnumerator_0;

		// Token: 0x04000AAE RID: 2734
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

		// Token: 0x04000AAF RID: 2735
		private static readonly IntPtr NativeMethodInfoPtr_GetNext_Private_DynValue_DynValue_0;

		// Token: 0x04000AB0 RID: 2736
		private static readonly IntPtr NativeMethodInfoPtr_LuaIteratorCallback_Private_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x04000AB1 RID: 2737
		private static readonly IntPtr NativeMethodInfoPtr_ConvertIterator_Internal_Static_DynValue_Script_IEnumerator_0;

		// Token: 0x04000AB2 RID: 2738
		private static readonly IntPtr NativeMethodInfoPtr_ConvertTable_Internal_Static_DynValue_Table_0;

		// Token: 0x04000AB3 RID: 2739
		private static readonly IntPtr NativeMethodInfoPtr_Index_Public_Virtual_Final_New_DynValue_Script_DynValue_Boolean_0;

		// Token: 0x04000AB4 RID: 2740
		private static readonly IntPtr NativeMethodInfoPtr_SetIndex_Public_Virtual_Final_New_Boolean_Script_DynValue_DynValue_Boolean_0;

		// Token: 0x04000AB5 RID: 2741
		private static readonly IntPtr NativeMethodInfoPtr_MetaIndex_Public_Virtual_Final_New_DynValue_Script_String_0;

		// Token: 0x04000AB6 RID: 2742
		private static readonly IntPtr NativeMethodInfoPtr__Index_b__10_0_Private_DynValue_ScriptExecutionContext_CallbackArguments_0;

		// Token: 0x04000AB7 RID: 2743
		private static readonly IntPtr NativeMethodInfoPtr__Index_b__10_1_Private_DynValue_ScriptExecutionContext_CallbackArguments_0;
	}
}
