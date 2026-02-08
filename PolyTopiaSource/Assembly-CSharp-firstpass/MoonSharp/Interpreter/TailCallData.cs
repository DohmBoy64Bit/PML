using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter
{
	// Token: 0x02000038 RID: 56
	public class TailCallData : Object
	{
		// Token: 0x0600074A RID: 1866 RVA: 0x000317A8 File Offset: 0x0002F9A8
		// Note: this type is marked as 'beforefieldinit'.
		static TailCallData()
		{
			Il2CppClassPointerStore<TailCallData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter", "TailCallData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TailCallData>.NativeClassPtr);
			TailCallData.NativeFieldInfoPtr__Function_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TailCallData>.NativeClassPtr, "<Function>k__BackingField");
			TailCallData.NativeFieldInfoPtr__Args_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TailCallData>.NativeClassPtr, "<Args>k__BackingField");
			TailCallData.NativeFieldInfoPtr__Continuation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TailCallData>.NativeClassPtr, "<Continuation>k__BackingField");
			TailCallData.NativeFieldInfoPtr__ErrorHandler_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TailCallData>.NativeClassPtr, "<ErrorHandler>k__BackingField");
			TailCallData.NativeFieldInfoPtr__ErrorHandlerBeforeUnwind_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TailCallData>.NativeClassPtr, "<ErrorHandlerBeforeUnwind>k__BackingField");
			TailCallData.NativeMethodInfoPtr_get_Function_Public_get_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TailCallData>.NativeClassPtr, 100664701);
			TailCallData.NativeMethodInfoPtr_set_Function_Public_set_Void_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TailCallData>.NativeClassPtr, 100664702);
			TailCallData.NativeMethodInfoPtr_get_Args_Public_get_Il2CppReferenceArray_1_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TailCallData>.NativeClassPtr, 100664703);
			TailCallData.NativeMethodInfoPtr_set_Args_Public_set_Void_Il2CppReferenceArray_1_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TailCallData>.NativeClassPtr, 100664704);
			TailCallData.NativeMethodInfoPtr_get_Continuation_Public_get_CallbackFunction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TailCallData>.NativeClassPtr, 100664705);
			TailCallData.NativeMethodInfoPtr_set_Continuation_Public_set_Void_CallbackFunction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TailCallData>.NativeClassPtr, 100664706);
			TailCallData.NativeMethodInfoPtr_get_ErrorHandler_Public_get_CallbackFunction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TailCallData>.NativeClassPtr, 100664707);
			TailCallData.NativeMethodInfoPtr_set_ErrorHandler_Public_set_Void_CallbackFunction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TailCallData>.NativeClassPtr, 100664708);
			TailCallData.NativeMethodInfoPtr_get_ErrorHandlerBeforeUnwind_Public_get_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TailCallData>.NativeClassPtr, 100664709);
			TailCallData.NativeMethodInfoPtr_set_ErrorHandlerBeforeUnwind_Public_set_Void_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TailCallData>.NativeClassPtr, 100664710);
			TailCallData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TailCallData>.NativeClassPtr, 100664711);
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x0600074B RID: 1867 RVA: 0x00031918 File Offset: 0x0002FB18
		// (set) Token: 0x0600074C RID: 1868 RVA: 0x00031958 File Offset: 0x0002FB58
		public unsafe DynValue Function
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 17906, RefRangeEnd = 17917, XrefRangeStart = 17906, XrefRangeEnd = 17917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TailCallData.NativeMethodInfoPtr_get_Function_Public_get_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TailCallData.NativeMethodInfoPtr_set_Function_Public_set_Void_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x0600074D RID: 1869 RVA: 0x0003199C File Offset: 0x0002FB9C
		// (set) Token: 0x0600074E RID: 1870 RVA: 0x000319DC File Offset: 0x0002FBDC
		public unsafe Il2CppReferenceArray<DynValue> Args
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TailCallData.NativeMethodInfoPtr_get_Args_Public_get_Il2CppReferenceArray_1_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DynValue>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TailCallData.NativeMethodInfoPtr_set_Args_Public_set_Void_Il2CppReferenceArray_1_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x0600074F RID: 1871 RVA: 0x00031A20 File Offset: 0x0002FC20
		// (set) Token: 0x06000750 RID: 1872 RVA: 0x00031A60 File Offset: 0x0002FC60
		public unsafe CallbackFunction Continuation
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 21282, RefRangeEnd = 21289, XrefRangeStart = 21282, XrefRangeEnd = 21289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TailCallData.NativeMethodInfoPtr_get_Continuation_Public_get_CallbackFunction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CallbackFunction>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TailCallData.NativeMethodInfoPtr_set_Continuation_Public_set_Void_CallbackFunction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x06000751 RID: 1873 RVA: 0x00031AA4 File Offset: 0x0002FCA4
		// (set) Token: 0x06000752 RID: 1874 RVA: 0x00031AE4 File Offset: 0x0002FCE4
		public unsafe CallbackFunction ErrorHandler
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 21306, RefRangeEnd = 21309, XrefRangeStart = 21306, XrefRangeEnd = 21309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TailCallData.NativeMethodInfoPtr_get_ErrorHandler_Public_get_CallbackFunction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CallbackFunction>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TailCallData.NativeMethodInfoPtr_set_ErrorHandler_Public_set_Void_CallbackFunction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06000753 RID: 1875 RVA: 0x00031B28 File Offset: 0x0002FD28
		// (set) Token: 0x06000754 RID: 1876 RVA: 0x00031B68 File Offset: 0x0002FD68
		public unsafe DynValue ErrorHandlerBeforeUnwind
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 21537, RefRangeEnd = 21548, XrefRangeStart = 21537, XrefRangeEnd = 21548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TailCallData.NativeMethodInfoPtr_get_ErrorHandlerBeforeUnwind_Public_get_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr3) : null;
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 21549, RefRangeEnd = 21556, XrefRangeStart = 21549, XrefRangeEnd = 21556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TailCallData.NativeMethodInfoPtr_set_ErrorHandlerBeforeUnwind_Public_set_Void_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x00031BAC File Offset: 0x0002FDAC
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TailCallData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TailCallData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TailCallData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x00003D0E File Offset: 0x00001F0E
		public TailCallData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06000757 RID: 1879 RVA: 0x00031BE8 File Offset: 0x0002FDE8
		// (set) Token: 0x06000758 RID: 1880 RVA: 0x00003D17 File Offset: 0x00001F17
		public unsafe DynValue _Function_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TailCallData.NativeFieldInfoPtr__Function_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TailCallData.NativeFieldInfoPtr__Function_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000759 RID: 1881 RVA: 0x00031C18 File Offset: 0x0002FE18
		// (set) Token: 0x0600075A RID: 1882 RVA: 0x00003D36 File Offset: 0x00001F36
		public unsafe Il2CppReferenceArray<DynValue> _Args_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TailCallData.NativeFieldInfoPtr__Args_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DynValue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TailCallData.NativeFieldInfoPtr__Args_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x0600075B RID: 1883 RVA: 0x00031C48 File Offset: 0x0002FE48
		// (set) Token: 0x0600075C RID: 1884 RVA: 0x00003D55 File Offset: 0x00001F55
		public unsafe CallbackFunction _Continuation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TailCallData.NativeFieldInfoPtr__Continuation_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CallbackFunction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TailCallData.NativeFieldInfoPtr__Continuation_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x0600075D RID: 1885 RVA: 0x00031C78 File Offset: 0x0002FE78
		// (set) Token: 0x0600075E RID: 1886 RVA: 0x00003D74 File Offset: 0x00001F74
		public unsafe CallbackFunction _ErrorHandler_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TailCallData.NativeFieldInfoPtr__ErrorHandler_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CallbackFunction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TailCallData.NativeFieldInfoPtr__ErrorHandler_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x0600075F RID: 1887 RVA: 0x00031CA8 File Offset: 0x0002FEA8
		// (set) Token: 0x06000760 RID: 1888 RVA: 0x00003D93 File Offset: 0x00001F93
		public unsafe DynValue _ErrorHandlerBeforeUnwind_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TailCallData.NativeFieldInfoPtr__ErrorHandlerBeforeUnwind_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TailCallData.NativeFieldInfoPtr__ErrorHandlerBeforeUnwind_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000660 RID: 1632
		private static readonly IntPtr NativeFieldInfoPtr__Function_k__BackingField;

		// Token: 0x04000661 RID: 1633
		private static readonly IntPtr NativeFieldInfoPtr__Args_k__BackingField;

		// Token: 0x04000662 RID: 1634
		private static readonly IntPtr NativeFieldInfoPtr__Continuation_k__BackingField;

		// Token: 0x04000663 RID: 1635
		private static readonly IntPtr NativeFieldInfoPtr__ErrorHandler_k__BackingField;

		// Token: 0x04000664 RID: 1636
		private static readonly IntPtr NativeFieldInfoPtr__ErrorHandlerBeforeUnwind_k__BackingField;

		// Token: 0x04000665 RID: 1637
		private static readonly IntPtr NativeMethodInfoPtr_get_Function_Public_get_DynValue_0;

		// Token: 0x04000666 RID: 1638
		private static readonly IntPtr NativeMethodInfoPtr_set_Function_Public_set_Void_DynValue_0;

		// Token: 0x04000667 RID: 1639
		private static readonly IntPtr NativeMethodInfoPtr_get_Args_Public_get_Il2CppReferenceArray_1_DynValue_0;

		// Token: 0x04000668 RID: 1640
		private static readonly IntPtr NativeMethodInfoPtr_set_Args_Public_set_Void_Il2CppReferenceArray_1_DynValue_0;

		// Token: 0x04000669 RID: 1641
		private static readonly IntPtr NativeMethodInfoPtr_get_Continuation_Public_get_CallbackFunction_0;

		// Token: 0x0400066A RID: 1642
		private static readonly IntPtr NativeMethodInfoPtr_set_Continuation_Public_set_Void_CallbackFunction_0;

		// Token: 0x0400066B RID: 1643
		private static readonly IntPtr NativeMethodInfoPtr_get_ErrorHandler_Public_get_CallbackFunction_0;

		// Token: 0x0400066C RID: 1644
		private static readonly IntPtr NativeMethodInfoPtr_set_ErrorHandler_Public_set_Void_CallbackFunction_0;

		// Token: 0x0400066D RID: 1645
		private static readonly IntPtr NativeMethodInfoPtr_get_ErrorHandlerBeforeUnwind_Public_get_DynValue_0;

		// Token: 0x0400066E RID: 1646
		private static readonly IntPtr NativeMethodInfoPtr_set_ErrorHandlerBeforeUnwind_Public_set_Void_DynValue_0;

		// Token: 0x0400066F RID: 1647
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
