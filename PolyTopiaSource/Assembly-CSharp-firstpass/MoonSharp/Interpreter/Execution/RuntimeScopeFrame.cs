using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace MoonSharp.Interpreter.Execution
{
	// Token: 0x020000E4 RID: 228
	public class RuntimeScopeFrame : Object
	{
		// Token: 0x06001120 RID: 4384 RVA: 0x0005B108 File Offset: 0x00059308
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeScopeFrame()
		{
			Il2CppClassPointerStore<RuntimeScopeFrame>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Execution", "RuntimeScopeFrame");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeScopeFrame>.NativeClassPtr);
			RuntimeScopeFrame.NativeFieldInfoPtr__DebugSymbols_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeScopeFrame>.NativeClassPtr, "<DebugSymbols>k__BackingField");
			RuntimeScopeFrame.NativeFieldInfoPtr__ToFirstBlock_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeScopeFrame>.NativeClassPtr, "<ToFirstBlock>k__BackingField");
			RuntimeScopeFrame.NativeMethodInfoPtr_get_DebugSymbols_Public_get_List_1_SymbolRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeScopeFrame>.NativeClassPtr, 100666345);
			RuntimeScopeFrame.NativeMethodInfoPtr_set_DebugSymbols_Private_set_Void_List_1_SymbolRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeScopeFrame>.NativeClassPtr, 100666346);
			RuntimeScopeFrame.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeScopeFrame>.NativeClassPtr, 100666347);
			RuntimeScopeFrame.NativeMethodInfoPtr_get_ToFirstBlock_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeScopeFrame>.NativeClassPtr, 100666348);
			RuntimeScopeFrame.NativeMethodInfoPtr_set_ToFirstBlock_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeScopeFrame>.NativeClassPtr, 100666349);
			RuntimeScopeFrame.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeScopeFrame>.NativeClassPtr, 100666350);
			RuntimeScopeFrame.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeScopeFrame>.NativeClassPtr, 100666351);
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06001121 RID: 4385 RVA: 0x0005B1EC File Offset: 0x000593EC
		// (set) Token: 0x06001122 RID: 4386 RVA: 0x0005B22C File Offset: 0x0005942C
		public unsafe List<SymbolRef> DebugSymbols
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 17906, RefRangeEnd = 17917, XrefRangeStart = 17906, XrefRangeEnd = 17917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeScopeFrame.NativeMethodInfoPtr_get_DebugSymbols_Public_get_List_1_SymbolRef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<SymbolRef>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeScopeFrame.NativeMethodInfoPtr_set_DebugSymbols_Private_set_Void_List_1_SymbolRef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06001123 RID: 4387 RVA: 0x0005B270 File Offset: 0x00059470
		public unsafe int Count
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43082, XrefRangeEnd = 43083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeScopeFrame.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06001124 RID: 4388 RVA: 0x0005B2AC File Offset: 0x000594AC
		// (set) Token: 0x06001125 RID: 4389 RVA: 0x0005B2E8 File Offset: 0x000594E8
		public unsafe int ToFirstBlock
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeScopeFrame.NativeMethodInfoPtr_get_ToFirstBlock_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 21383, RefRangeEnd = 21385, XrefRangeStart = 21383, XrefRangeEnd = 21385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeScopeFrame.NativeMethodInfoPtr_set_ToFirstBlock_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001126 RID: 4390 RVA: 0x0005B328 File Offset: 0x00059528
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43091, RefRangeEnd = 43092, XrefRangeStart = 43083, XrefRangeEnd = 43091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeScopeFrame()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimeScopeFrame>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeScopeFrame.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001127 RID: 4391 RVA: 0x0005B364 File Offset: 0x00059564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43092, XrefRangeEnd = 43098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeScopeFrame.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001128 RID: 4392 RVA: 0x000071D7 File Offset: 0x000053D7
		public RuntimeScopeFrame(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06001129 RID: 4393 RVA: 0x0005B3A8 File Offset: 0x000595A8
		// (set) Token: 0x0600112A RID: 4394 RVA: 0x000071E0 File Offset: 0x000053E0
		public unsafe List<SymbolRef> _DebugSymbols_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeScopeFrame.NativeFieldInfoPtr__DebugSymbols_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SymbolRef>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeScopeFrame.NativeFieldInfoPtr__DebugSymbols_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x0600112B RID: 4395 RVA: 0x0005B3D8 File Offset: 0x000595D8
		// (set) Token: 0x0600112C RID: 4396 RVA: 0x000071FF File Offset: 0x000053FF
		public unsafe int _ToFirstBlock_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeScopeFrame.NativeFieldInfoPtr__ToFirstBlock_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeScopeFrame.NativeFieldInfoPtr__ToFirstBlock_k__BackingField)) = value;
			}
		}

		// Token: 0x04000DF5 RID: 3573
		private static readonly IntPtr NativeFieldInfoPtr__DebugSymbols_k__BackingField;

		// Token: 0x04000DF6 RID: 3574
		private static readonly IntPtr NativeFieldInfoPtr__ToFirstBlock_k__BackingField;

		// Token: 0x04000DF7 RID: 3575
		private static readonly IntPtr NativeMethodInfoPtr_get_DebugSymbols_Public_get_List_1_SymbolRef_0;

		// Token: 0x04000DF8 RID: 3576
		private static readonly IntPtr NativeMethodInfoPtr_set_DebugSymbols_Private_set_Void_List_1_SymbolRef_0;

		// Token: 0x04000DF9 RID: 3577
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x04000DFA RID: 3578
		private static readonly IntPtr NativeMethodInfoPtr_get_ToFirstBlock_Public_get_Int32_0;

		// Token: 0x04000DFB RID: 3579
		private static readonly IntPtr NativeMethodInfoPtr_set_ToFirstBlock_Internal_set_Void_Int32_0;

		// Token: 0x04000DFC RID: 3580
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000DFD RID: 3581
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
