using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace MoonSharp.Interpreter.Debugging
{
	// Token: 0x020000FF RID: 255
	public class WatchItem : Object
	{
		// Token: 0x06001356 RID: 4950 RVA: 0x0006430C File Offset: 0x0006250C
		// Note: this type is marked as 'beforefieldinit'.
		static WatchItem()
		{
			Il2CppClassPointerStore<WatchItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "MoonSharp.Interpreter.Debugging", "WatchItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WatchItem>.NativeClassPtr);
			WatchItem.NativeFieldInfoPtr__Address_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WatchItem>.NativeClassPtr, "<Address>k__BackingField");
			WatchItem.NativeFieldInfoPtr__BasePtr_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WatchItem>.NativeClassPtr, "<BasePtr>k__BackingField");
			WatchItem.NativeFieldInfoPtr__RetAddress_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WatchItem>.NativeClassPtr, "<RetAddress>k__BackingField");
			WatchItem.NativeFieldInfoPtr__Name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WatchItem>.NativeClassPtr, "<Name>k__BackingField");
			WatchItem.NativeFieldInfoPtr__Value_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WatchItem>.NativeClassPtr, "<Value>k__BackingField");
			WatchItem.NativeFieldInfoPtr__LValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WatchItem>.NativeClassPtr, "<LValue>k__BackingField");
			WatchItem.NativeFieldInfoPtr__IsError_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WatchItem>.NativeClassPtr, "<IsError>k__BackingField");
			WatchItem.NativeFieldInfoPtr__Location_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WatchItem>.NativeClassPtr, "<Location>k__BackingField");
			WatchItem.NativeMethodInfoPtr_get_Address_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WatchItem>.NativeClassPtr, 100666669);
			WatchItem.NativeMethodInfoPtr_set_Address_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WatchItem>.NativeClassPtr, 100666670);
			WatchItem.NativeMethodInfoPtr_get_BasePtr_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WatchItem>.NativeClassPtr, 100666671);
			WatchItem.NativeMethodInfoPtr_set_BasePtr_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WatchItem>.NativeClassPtr, 100666672);
			WatchItem.NativeMethodInfoPtr_get_RetAddress_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WatchItem>.NativeClassPtr, 100666673);
			WatchItem.NativeMethodInfoPtr_set_RetAddress_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WatchItem>.NativeClassPtr, 100666674);
			WatchItem.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WatchItem>.NativeClassPtr, 100666675);
			WatchItem.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WatchItem>.NativeClassPtr, 100666676);
			WatchItem.NativeMethodInfoPtr_get_Value_Public_get_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WatchItem>.NativeClassPtr, 100666677);
			WatchItem.NativeMethodInfoPtr_set_Value_Public_set_Void_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WatchItem>.NativeClassPtr, 100666678);
			WatchItem.NativeMethodInfoPtr_get_LValue_Public_get_SymbolRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WatchItem>.NativeClassPtr, 100666679);
			WatchItem.NativeMethodInfoPtr_set_LValue_Public_set_Void_SymbolRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WatchItem>.NativeClassPtr, 100666680);
			WatchItem.NativeMethodInfoPtr_get_IsError_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WatchItem>.NativeClassPtr, 100666681);
			WatchItem.NativeMethodInfoPtr_set_IsError_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WatchItem>.NativeClassPtr, 100666682);
			WatchItem.NativeMethodInfoPtr_get_Location_Public_get_SourceRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WatchItem>.NativeClassPtr, 100666683);
			WatchItem.NativeMethodInfoPtr_set_Location_Public_set_Void_SourceRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WatchItem>.NativeClassPtr, 100666684);
			WatchItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WatchItem>.NativeClassPtr, 100666686);
			WatchItem.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WatchItem>.NativeClassPtr, 100666685);
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06001357 RID: 4951 RVA: 0x00064544 File Offset: 0x00062744
		// (set) Token: 0x06001358 RID: 4952 RVA: 0x00064580 File Offset: 0x00062780
		public unsafe int Address
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WatchItem.NativeMethodInfoPtr_get_Address_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 3, RefRangeEnd = 6, XrefRangeStart = 3, XrefRangeEnd = 6, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WatchItem.NativeMethodInfoPtr_set_Address_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06001359 RID: 4953 RVA: 0x000645C0 File Offset: 0x000627C0
		// (set) Token: 0x0600135A RID: 4954 RVA: 0x000645FC File Offset: 0x000627FC
		public unsafe int BasePtr
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WatchItem.NativeMethodInfoPtr_get_BasePtr_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 43069, RefRangeEnd = 43073, XrefRangeStart = 43069, XrefRangeEnd = 43073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WatchItem.NativeMethodInfoPtr_set_BasePtr_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x0600135B RID: 4955 RVA: 0x0006463C File Offset: 0x0006283C
		// (set) Token: 0x0600135C RID: 4956 RVA: 0x00064678 File Offset: 0x00062878
		public unsafe int RetAddress
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WatchItem.NativeMethodInfoPtr_get_RetAddress_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WatchItem.NativeMethodInfoPtr_set_RetAddress_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x0600135D RID: 4957 RVA: 0x000646B8 File Offset: 0x000628B8
		// (set) Token: 0x0600135E RID: 4958 RVA: 0x000646F0 File Offset: 0x000628F0
		public unsafe string Name
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 21282, RefRangeEnd = 21289, XrefRangeStart = 21282, XrefRangeEnd = 21289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WatchItem.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 21290, RefRangeEnd = 21298, XrefRangeStart = 21290, XrefRangeEnd = 21298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WatchItem.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x0600135F RID: 4959 RVA: 0x00064734 File Offset: 0x00062934
		// (set) Token: 0x06001360 RID: 4960 RVA: 0x00064774 File Offset: 0x00062974
		public unsafe DynValue Value
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 21306, RefRangeEnd = 21309, XrefRangeStart = 21306, XrefRangeEnd = 21309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WatchItem.NativeMethodInfoPtr_get_Value_Public_get_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WatchItem.NativeMethodInfoPtr_set_Value_Public_set_Void_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x06001361 RID: 4961 RVA: 0x000647B8 File Offset: 0x000629B8
		// (set) Token: 0x06001362 RID: 4962 RVA: 0x000647F8 File Offset: 0x000629F8
		public unsafe SymbolRef LValue
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 21537, RefRangeEnd = 21548, XrefRangeStart = 21537, XrefRangeEnd = 21548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WatchItem.NativeMethodInfoPtr_get_LValue_Public_get_SymbolRef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SymbolRef>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WatchItem.NativeMethodInfoPtr_set_LValue_Public_set_Void_SymbolRef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06001363 RID: 4963 RVA: 0x0006483C File Offset: 0x00062A3C
		// (set) Token: 0x06001364 RID: 4964 RVA: 0x00064878 File Offset: 0x00062A78
		public unsafe bool IsError
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WatchItem.NativeMethodInfoPtr_get_IsError_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WatchItem.NativeMethodInfoPtr_set_IsError_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x06001365 RID: 4965 RVA: 0x000648B8 File Offset: 0x00062AB8
		// (set) Token: 0x06001366 RID: 4966 RVA: 0x000648F8 File Offset: 0x00062AF8
		public unsafe SourceRef Location
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 26452, RefRangeEnd = 26453, XrefRangeStart = 26452, XrefRangeEnd = 26453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WatchItem.NativeMethodInfoPtr_get_Location_Public_get_SourceRef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SourceRef>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WatchItem.NativeMethodInfoPtr_set_Location_Public_set_Void_SourceRef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001367 RID: 4967 RVA: 0x0006493C File Offset: 0x00062B3C
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WatchItem()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WatchItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WatchItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001368 RID: 4968 RVA: 0x00064978 File Offset: 0x00062B78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46663, XrefRangeEnd = 46693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WatchItem.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001369 RID: 4969 RVA: 0x00007ECA File Offset: 0x000060CA
		public WatchItem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x0600136A RID: 4970 RVA: 0x000649BC File Offset: 0x00062BBC
		// (set) Token: 0x0600136B RID: 4971 RVA: 0x00007ED3 File Offset: 0x000060D3
		public unsafe int _Address_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WatchItem.NativeFieldInfoPtr__Address_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WatchItem.NativeFieldInfoPtr__Address_k__BackingField)) = value;
			}
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x0600136C RID: 4972 RVA: 0x000649E4 File Offset: 0x00062BE4
		// (set) Token: 0x0600136D RID: 4973 RVA: 0x00007EEE File Offset: 0x000060EE
		public unsafe int _BasePtr_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WatchItem.NativeFieldInfoPtr__BasePtr_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WatchItem.NativeFieldInfoPtr__BasePtr_k__BackingField)) = value;
			}
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x0600136E RID: 4974 RVA: 0x00064A0C File Offset: 0x00062C0C
		// (set) Token: 0x0600136F RID: 4975 RVA: 0x00007F09 File Offset: 0x00006109
		public unsafe int _RetAddress_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WatchItem.NativeFieldInfoPtr__RetAddress_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WatchItem.NativeFieldInfoPtr__RetAddress_k__BackingField)) = value;
			}
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06001370 RID: 4976 RVA: 0x00064A34 File Offset: 0x00062C34
		// (set) Token: 0x06001371 RID: 4977 RVA: 0x00007F24 File Offset: 0x00006124
		public unsafe string _Name_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WatchItem.NativeFieldInfoPtr__Name_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WatchItem.NativeFieldInfoPtr__Name_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06001372 RID: 4978 RVA: 0x00064A5C File Offset: 0x00062C5C
		// (set) Token: 0x06001373 RID: 4979 RVA: 0x00007F43 File Offset: 0x00006143
		public unsafe DynValue _Value_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WatchItem.NativeFieldInfoPtr__Value_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WatchItem.NativeFieldInfoPtr__Value_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06001374 RID: 4980 RVA: 0x00064A8C File Offset: 0x00062C8C
		// (set) Token: 0x06001375 RID: 4981 RVA: 0x00007F62 File Offset: 0x00006162
		public unsafe SymbolRef _LValue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WatchItem.NativeFieldInfoPtr__LValue_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SymbolRef>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WatchItem.NativeFieldInfoPtr__LValue_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06001376 RID: 4982 RVA: 0x00064ABC File Offset: 0x00062CBC
		// (set) Token: 0x06001377 RID: 4983 RVA: 0x00007F81 File Offset: 0x00006181
		public unsafe bool _IsError_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WatchItem.NativeFieldInfoPtr__IsError_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WatchItem.NativeFieldInfoPtr__IsError_k__BackingField)) = value;
			}
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06001378 RID: 4984 RVA: 0x00064AE4 File Offset: 0x00062CE4
		// (set) Token: 0x06001379 RID: 4985 RVA: 0x00007F9C File Offset: 0x0000619C
		public unsafe SourceRef _Location_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WatchItem.NativeFieldInfoPtr__Location_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SourceRef>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WatchItem.NativeFieldInfoPtr__Location_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000FE5 RID: 4069
		private static readonly IntPtr NativeFieldInfoPtr__Address_k__BackingField;

		// Token: 0x04000FE6 RID: 4070
		private static readonly IntPtr NativeFieldInfoPtr__BasePtr_k__BackingField;

		// Token: 0x04000FE7 RID: 4071
		private static readonly IntPtr NativeFieldInfoPtr__RetAddress_k__BackingField;

		// Token: 0x04000FE8 RID: 4072
		private static readonly IntPtr NativeFieldInfoPtr__Name_k__BackingField;

		// Token: 0x04000FE9 RID: 4073
		private static readonly IntPtr NativeFieldInfoPtr__Value_k__BackingField;

		// Token: 0x04000FEA RID: 4074
		private static readonly IntPtr NativeFieldInfoPtr__LValue_k__BackingField;

		// Token: 0x04000FEB RID: 4075
		private static readonly IntPtr NativeFieldInfoPtr__IsError_k__BackingField;

		// Token: 0x04000FEC RID: 4076
		private static readonly IntPtr NativeFieldInfoPtr__Location_k__BackingField;

		// Token: 0x04000FED RID: 4077
		private static readonly IntPtr NativeMethodInfoPtr_get_Address_Public_get_Int32_0;

		// Token: 0x04000FEE RID: 4078
		private static readonly IntPtr NativeMethodInfoPtr_set_Address_Public_set_Void_Int32_0;

		// Token: 0x04000FEF RID: 4079
		private static readonly IntPtr NativeMethodInfoPtr_get_BasePtr_Public_get_Int32_0;

		// Token: 0x04000FF0 RID: 4080
		private static readonly IntPtr NativeMethodInfoPtr_set_BasePtr_Public_set_Void_Int32_0;

		// Token: 0x04000FF1 RID: 4081
		private static readonly IntPtr NativeMethodInfoPtr_get_RetAddress_Public_get_Int32_0;

		// Token: 0x04000FF2 RID: 4082
		private static readonly IntPtr NativeMethodInfoPtr_set_RetAddress_Public_set_Void_Int32_0;

		// Token: 0x04000FF3 RID: 4083
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04000FF4 RID: 4084
		private static readonly IntPtr NativeMethodInfoPtr_set_Name_Public_set_Void_String_0;

		// Token: 0x04000FF5 RID: 4085
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_DynValue_0;

		// Token: 0x04000FF6 RID: 4086
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_set_Void_DynValue_0;

		// Token: 0x04000FF7 RID: 4087
		private static readonly IntPtr NativeMethodInfoPtr_get_LValue_Public_get_SymbolRef_0;

		// Token: 0x04000FF8 RID: 4088
		private static readonly IntPtr NativeMethodInfoPtr_set_LValue_Public_set_Void_SymbolRef_0;

		// Token: 0x04000FF9 RID: 4089
		private static readonly IntPtr NativeMethodInfoPtr_get_IsError_Public_get_Boolean_0;

		// Token: 0x04000FFA RID: 4090
		private static readonly IntPtr NativeMethodInfoPtr_set_IsError_Public_set_Void_Boolean_0;

		// Token: 0x04000FFB RID: 4091
		private static readonly IntPtr NativeMethodInfoPtr_get_Location_Public_get_SourceRef_0;

		// Token: 0x04000FFC RID: 4092
		private static readonly IntPtr NativeMethodInfoPtr_set_Location_Public_set_Void_SourceRef_0;

		// Token: 0x04000FFD RID: 4093
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000FFE RID: 4094
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
