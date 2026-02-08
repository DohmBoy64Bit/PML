using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Mirror;
using UnityEngine.Networking;

namespace Polytoria.Datamodel.Services
{
	// Token: 0x020002C5 RID: 709
	public class DataStoreService : NetworkBehaviour
	{
		// Token: 0x06003EA9 RID: 16041 RVA: 0x00119A5C File Offset: 0x00117C5C
		// Note: this type is marked as 'beforefieldinit'.
		static DataStoreService()
		{
			Il2CppClassPointerStore<DataStoreService>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Services", "DataStoreService");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataStoreService>.NativeClassPtr);
			DataStoreService.NativeFieldInfoPtr__Instance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataStoreService>.NativeClassPtr, "<Instance>k__BackingField");
			DataStoreService.NativeFieldInfoPtr_MaxReadRequestsPerMinute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataStoreService>.NativeClassPtr, "MaxReadRequestsPerMinute");
			DataStoreService.NativeFieldInfoPtr_ReadRequestsPerPlayerModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataStoreService>.NativeClassPtr, "ReadRequestsPerPlayerModifier");
			DataStoreService.NativeFieldInfoPtr_MaxWriteRequestsPerMinute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataStoreService>.NativeClassPtr, "MaxWriteRequestsPerMinute");
			DataStoreService.NativeFieldInfoPtr_WriteRequestsPerPlayerModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataStoreService>.NativeClassPtr, "WriteRequestsPerPlayerModifier");
			DataStoreService.NativeFieldInfoPtr_getDataStoreQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataStoreService>.NativeClassPtr, "getDataStoreQueue");
			DataStoreService.NativeFieldInfoPtr_datastores = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataStoreService>.NativeClassPtr, "datastores");
			DataStoreService.NativeFieldInfoPtr_readRequestsThisMinute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataStoreService>.NativeClassPtr, "readRequestsThisMinute");
			DataStoreService.NativeFieldInfoPtr_writeRequestThisMinute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataStoreService>.NativeClassPtr, "writeRequestThisMinute");
			DataStoreService.NativeFieldInfoPtr_currentMinute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataStoreService>.NativeClassPtr, "currentMinute");
			DataStoreService.NativeFieldInfoPtr_isGettingDatastore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataStoreService>.NativeClassPtr, "isGettingDatastore");
			DataStoreService.NativeMethodInfoPtr_get_Instance_Public_Static_get_DataStoreService_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStoreService>.NativeClassPtr, 100672950);
			DataStoreService.NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_DataStoreService_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStoreService>.NativeClassPtr, 100672951);
			DataStoreService.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStoreService>.NativeClassPtr, 100672961);
			DataStoreService.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStoreService>.NativeClassPtr, 100672952);
			DataStoreService.NativeMethodInfoPtr_GetDatastore_Public_Datastore_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStoreService>.NativeClassPtr, 100672953);
			DataStoreService.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStoreService>.NativeClassPtr, 100672954);
			DataStoreService.NativeMethodInfoPtr_UseReadRequest_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStoreService>.NativeClassPtr, 100672955);
			DataStoreService.NativeMethodInfoPtr_UseWriteRequest_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStoreService>.NativeClassPtr, 100672956);
			DataStoreService.NativeMethodInfoPtr_LoadFromServer_Public_Void_Datastore_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStoreService>.NativeClassPtr, 100672957);
			DataStoreService.NativeMethodInfoPtr_DoLoadFromServer_Private_IEnumerator_GetDataStoreQueueEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStoreService>.NativeClassPtr, 100672958);
			DataStoreService.NativeMethodInfoPtr_WriteToServer_Public_Void_Datastore_String_Object_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStoreService>.NativeClassPtr, 100672959);
			DataStoreService.NativeMethodInfoPtr_DoWriteToServer_Private_IEnumerator_Datastore_String_Object_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStoreService>.NativeClassPtr, 100672960);
			DataStoreService.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStoreService>.NativeClassPtr, 100672962);
		}

		// Token: 0x170015A2 RID: 5538
		// (get) Token: 0x06003EAA RID: 16042 RVA: 0x00119C6C File Offset: 0x00117E6C
		// (set) Token: 0x06003EAB RID: 16043 RVA: 0x00119CA0 File Offset: 0x00117EA0
		public unsafe static DataStoreService Instance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124443, XrefRangeEnd = 124445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataStoreService.NativeMethodInfoPtr_get_Instance_Public_Static_get_DataStoreService_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataStoreService>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124445, XrefRangeEnd = 124449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataStoreService.NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_DataStoreService_0, 0, (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003EAC RID: 16044 RVA: 0x00119CD8 File Offset: 0x00117ED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124449, XrefRangeEnd = 124464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataStoreService()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataStoreService>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataStoreService.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EAD RID: 16045 RVA: 0x00119D14 File Offset: 0x00117F14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124464, XrefRangeEnd = 124468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataStoreService.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EAE RID: 16046 RVA: 0x00119D48 File Offset: 0x00117F48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 124478, RefRangeEnd = 124479, XrefRangeStart = 124468, XrefRangeEnd = 124478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Datastore GetDatastore(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataStoreService.NativeMethodInfoPtr_GetDatastore_Public_Datastore_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Datastore>(intPtr3) : null;
			}
		}

		// Token: 0x06003EAF RID: 16047 RVA: 0x00119D98 File Offset: 0x00117F98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124479, XrefRangeEnd = 124490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataStoreService.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EB0 RID: 16048 RVA: 0x00119DCC File Offset: 0x00117FCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 124501, RefRangeEnd = 124502, XrefRangeStart = 124490, XrefRangeEnd = 124501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool UseReadRequest()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataStoreService.NativeMethodInfoPtr_UseReadRequest_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003EB1 RID: 16049 RVA: 0x00119E08 File Offset: 0x00118008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124502, XrefRangeEnd = 124513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool UseWriteRequest()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataStoreService.NativeMethodInfoPtr_UseWriteRequest_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003EB2 RID: 16050 RVA: 0x00119E44 File Offset: 0x00118044
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 124527, RefRangeEnd = 124528, XrefRangeStart = 124513, XrefRangeEnd = 124527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadFromServer(Datastore ds, Action<bool> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ds);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataStoreService.NativeMethodInfoPtr_LoadFromServer_Public_Void_Datastore_Action_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EB3 RID: 16051 RVA: 0x00119E98 File Offset: 0x00118098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124528, XrefRangeEnd = 124534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DoLoadFromServer(GetDataStoreQueueEntry entry)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entry);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataStoreService.NativeMethodInfoPtr_DoLoadFromServer_Private_IEnumerator_GetDataStoreQueueEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06003EB4 RID: 16052 RVA: 0x00119EE8 File Offset: 0x001180E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124534, XrefRangeEnd = 124548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteToServer(Datastore ds, string key, Object value, Action<bool> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ds);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataStoreService.NativeMethodInfoPtr_WriteToServer_Public_Void_Datastore_String_Object_Action_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EB5 RID: 16053 RVA: 0x00119F64 File Offset: 0x00118164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124548, XrefRangeEnd = 124556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DoWriteToServer(Datastore ds, string key, Object value, Action<bool> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ds);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataStoreService.NativeMethodInfoPtr_DoWriteToServer_Private_IEnumerator_Datastore_String_Object_Action_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06003EB6 RID: 16054 RVA: 0x00119FEC File Offset: 0x001181EC
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 20124, RefRangeEnd = 20136, XrefRangeStart = 20124, XrefRangeEnd = 20136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Weaved()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DataStoreService.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003EB7 RID: 16055 RVA: 0x00018048 File Offset: 0x00016248
		public DataStoreService(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001597 RID: 5527
		// (get) Token: 0x06003EB8 RID: 16056 RVA: 0x0011A034 File Offset: 0x00118234
		// (set) Token: 0x06003EB9 RID: 16057 RVA: 0x00018051 File Offset: 0x00016251
		public unsafe static DataStoreService _Instance_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DataStoreService.NativeFieldInfoPtr__Instance_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataStoreService>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DataStoreService.NativeFieldInfoPtr__Instance_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001598 RID: 5528
		// (get) Token: 0x06003EBA RID: 16058 RVA: 0x0011A05C File Offset: 0x0011825C
		// (set) Token: 0x06003EBB RID: 16059 RVA: 0x00018063 File Offset: 0x00016263
		public unsafe int MaxReadRequestsPerMinute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataStoreService.NativeFieldInfoPtr_MaxReadRequestsPerMinute);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataStoreService.NativeFieldInfoPtr_MaxReadRequestsPerMinute)) = value;
			}
		}

		// Token: 0x17001599 RID: 5529
		// (get) Token: 0x06003EBC RID: 16060 RVA: 0x0011A084 File Offset: 0x00118284
		// (set) Token: 0x06003EBD RID: 16061 RVA: 0x0001807E File Offset: 0x0001627E
		public unsafe int ReadRequestsPerPlayerModifier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataStoreService.NativeFieldInfoPtr_ReadRequestsPerPlayerModifier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataStoreService.NativeFieldInfoPtr_ReadRequestsPerPlayerModifier)) = value;
			}
		}

		// Token: 0x1700159A RID: 5530
		// (get) Token: 0x06003EBE RID: 16062 RVA: 0x0011A0AC File Offset: 0x001182AC
		// (set) Token: 0x06003EBF RID: 16063 RVA: 0x00018099 File Offset: 0x00016299
		public unsafe int MaxWriteRequestsPerMinute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataStoreService.NativeFieldInfoPtr_MaxWriteRequestsPerMinute);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataStoreService.NativeFieldInfoPtr_MaxWriteRequestsPerMinute)) = value;
			}
		}

		// Token: 0x1700159B RID: 5531
		// (get) Token: 0x06003EC0 RID: 16064 RVA: 0x0011A0D4 File Offset: 0x001182D4
		// (set) Token: 0x06003EC1 RID: 16065 RVA: 0x000180B4 File Offset: 0x000162B4
		public unsafe int WriteRequestsPerPlayerModifier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataStoreService.NativeFieldInfoPtr_WriteRequestsPerPlayerModifier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataStoreService.NativeFieldInfoPtr_WriteRequestsPerPlayerModifier)) = value;
			}
		}

		// Token: 0x1700159C RID: 5532
		// (get) Token: 0x06003EC2 RID: 16066 RVA: 0x0011A0FC File Offset: 0x001182FC
		// (set) Token: 0x06003EC3 RID: 16067 RVA: 0x000180CF File Offset: 0x000162CF
		public unsafe Queue<GetDataStoreQueueEntry> getDataStoreQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataStoreService.NativeFieldInfoPtr_getDataStoreQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<GetDataStoreQueueEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataStoreService.NativeFieldInfoPtr_getDataStoreQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700159D RID: 5533
		// (get) Token: 0x06003EC4 RID: 16068 RVA: 0x0011A12C File Offset: 0x0011832C
		// (set) Token: 0x06003EC5 RID: 16069 RVA: 0x000180EE File Offset: 0x000162EE
		public unsafe Dictionary<string, Datastore> datastores
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataStoreService.NativeFieldInfoPtr_datastores);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Datastore>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataStoreService.NativeFieldInfoPtr_datastores), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700159E RID: 5534
		// (get) Token: 0x06003EC6 RID: 16070 RVA: 0x0011A15C File Offset: 0x0011835C
		// (set) Token: 0x06003EC7 RID: 16071 RVA: 0x0001810D File Offset: 0x0001630D
		public unsafe int readRequestsThisMinute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataStoreService.NativeFieldInfoPtr_readRequestsThisMinute);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataStoreService.NativeFieldInfoPtr_readRequestsThisMinute)) = value;
			}
		}

		// Token: 0x1700159F RID: 5535
		// (get) Token: 0x06003EC8 RID: 16072 RVA: 0x0011A184 File Offset: 0x00118384
		// (set) Token: 0x06003EC9 RID: 16073 RVA: 0x00018128 File Offset: 0x00016328
		public unsafe int writeRequestThisMinute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataStoreService.NativeFieldInfoPtr_writeRequestThisMinute);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataStoreService.NativeFieldInfoPtr_writeRequestThisMinute)) = value;
			}
		}

		// Token: 0x170015A0 RID: 5536
		// (get) Token: 0x06003ECA RID: 16074 RVA: 0x0011A1AC File Offset: 0x001183AC
		// (set) Token: 0x06003ECB RID: 16075 RVA: 0x00018143 File Offset: 0x00016343
		public unsafe int currentMinute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataStoreService.NativeFieldInfoPtr_currentMinute);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataStoreService.NativeFieldInfoPtr_currentMinute)) = value;
			}
		}

		// Token: 0x170015A1 RID: 5537
		// (get) Token: 0x06003ECC RID: 16076 RVA: 0x0011A1D4 File Offset: 0x001183D4
		// (set) Token: 0x06003ECD RID: 16077 RVA: 0x0001815E File Offset: 0x0001635E
		public unsafe bool isGettingDatastore
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataStoreService.NativeFieldInfoPtr_isGettingDatastore);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataStoreService.NativeFieldInfoPtr_isGettingDatastore)) = value;
			}
		}

		// Token: 0x040030BA RID: 12474
		private static readonly IntPtr NativeFieldInfoPtr__Instance_k__BackingField;

		// Token: 0x040030BB RID: 12475
		private static readonly IntPtr NativeFieldInfoPtr_MaxReadRequestsPerMinute;

		// Token: 0x040030BC RID: 12476
		private static readonly IntPtr NativeFieldInfoPtr_ReadRequestsPerPlayerModifier;

		// Token: 0x040030BD RID: 12477
		private static readonly IntPtr NativeFieldInfoPtr_MaxWriteRequestsPerMinute;

		// Token: 0x040030BE RID: 12478
		private static readonly IntPtr NativeFieldInfoPtr_WriteRequestsPerPlayerModifier;

		// Token: 0x040030BF RID: 12479
		private static readonly IntPtr NativeFieldInfoPtr_getDataStoreQueue;

		// Token: 0x040030C0 RID: 12480
		private static readonly IntPtr NativeFieldInfoPtr_datastores;

		// Token: 0x040030C1 RID: 12481
		private static readonly IntPtr NativeFieldInfoPtr_readRequestsThisMinute;

		// Token: 0x040030C2 RID: 12482
		private static readonly IntPtr NativeFieldInfoPtr_writeRequestThisMinute;

		// Token: 0x040030C3 RID: 12483
		private static readonly IntPtr NativeFieldInfoPtr_currentMinute;

		// Token: 0x040030C4 RID: 12484
		private static readonly IntPtr NativeFieldInfoPtr_isGettingDatastore;

		// Token: 0x040030C5 RID: 12485
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_DataStoreService_0;

		// Token: 0x040030C6 RID: 12486
		private static readonly IntPtr NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_DataStoreService_0;

		// Token: 0x040030C7 RID: 12487
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040030C8 RID: 12488
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040030C9 RID: 12489
		private static readonly IntPtr NativeMethodInfoPtr_GetDatastore_Public_Datastore_String_0;

		// Token: 0x040030CA RID: 12490
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040030CB RID: 12491
		private static readonly IntPtr NativeMethodInfoPtr_UseReadRequest_Public_Boolean_0;

		// Token: 0x040030CC RID: 12492
		private static readonly IntPtr NativeMethodInfoPtr_UseWriteRequest_Public_Boolean_0;

		// Token: 0x040030CD RID: 12493
		private static readonly IntPtr NativeMethodInfoPtr_LoadFromServer_Public_Void_Datastore_Action_1_Boolean_0;

		// Token: 0x040030CE RID: 12494
		private static readonly IntPtr NativeMethodInfoPtr_DoLoadFromServer_Private_IEnumerator_GetDataStoreQueueEntry_0;

		// Token: 0x040030CF RID: 12495
		private static readonly IntPtr NativeMethodInfoPtr_WriteToServer_Public_Void_Datastore_String_Object_Action_1_Boolean_0;

		// Token: 0x040030D0 RID: 12496
		private static readonly IntPtr NativeMethodInfoPtr_DoWriteToServer_Private_IEnumerator_Datastore_String_Object_Action_1_Boolean_0;

		// Token: 0x040030D1 RID: 12497
		private static readonly IntPtr NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0;

		// Token: 0x0200040D RID: 1037
		[ObfuscatedName("Polytoria.Datamodel.Services.DataStoreService+<DoLoadFromServer>d__20")]
		public sealed class _DoLoadFromServer_d__20 : Object
		{
			// Token: 0x06004F44 RID: 20292 RVA: 0x00155A40 File Offset: 0x00153C40
			// Note: this type is marked as 'beforefieldinit'.
			static _DoLoadFromServer_d__20()
			{
				Il2CppClassPointerStore<DataStoreService._DoLoadFromServer_d__20>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DataStoreService>.NativeClassPtr, "<DoLoadFromServer>d__20");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataStoreService._DoLoadFromServer_d__20>.NativeClassPtr);
				DataStoreService._DoLoadFromServer_d__20.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataStoreService._DoLoadFromServer_d__20>.NativeClassPtr, "<>1__state");
				DataStoreService._DoLoadFromServer_d__20.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataStoreService._DoLoadFromServer_d__20>.NativeClassPtr, "<>2__current");
				DataStoreService._DoLoadFromServer_d__20.NativeFieldInfoPtr_entry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataStoreService._DoLoadFromServer_d__20>.NativeClassPtr, "entry");
				DataStoreService._DoLoadFromServer_d__20.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataStoreService._DoLoadFromServer_d__20>.NativeClassPtr, "<>4__this");
				DataStoreService._DoLoadFromServer_d__20.NativeFieldInfoPtr__ds_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataStoreService._DoLoadFromServer_d__20>.NativeClassPtr, "<ds>5__2");
				DataStoreService._DoLoadFromServer_d__20.NativeFieldInfoPtr__uwr_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataStoreService._DoLoadFromServer_d__20>.NativeClassPtr, "<uwr>5__3");
				DataStoreService._DoLoadFromServer_d__20.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStoreService._DoLoadFromServer_d__20>.NativeClassPtr, 100672967);
				DataStoreService._DoLoadFromServer_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStoreService._DoLoadFromServer_d__20>.NativeClassPtr, 100672969);
				DataStoreService._DoLoadFromServer_d__20.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStoreService._DoLoadFromServer_d__20>.NativeClassPtr, 100672963);
				DataStoreService._DoLoadFromServer_d__20.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStoreService._DoLoadFromServer_d__20>.NativeClassPtr, 100672964);
				DataStoreService._DoLoadFromServer_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStoreService._DoLoadFromServer_d__20>.NativeClassPtr, 100672965);
				DataStoreService._DoLoadFromServer_d__20.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStoreService._DoLoadFromServer_d__20>.NativeClassPtr, 100672966);
				DataStoreService._DoLoadFromServer_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStoreService._DoLoadFromServer_d__20>.NativeClassPtr, 100672968);
			}

			// Token: 0x17001ABF RID: 6847
			// (get) Token: 0x06004F45 RID: 20293 RVA: 0x00155B70 File Offset: 0x00153D70
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataStoreService._DoLoadFromServer_d__20.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001AC0 RID: 6848
			// (get) Token: 0x06004F46 RID: 20294 RVA: 0x00155BB0 File Offset: 0x00153DB0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataStoreService._DoLoadFromServer_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004F47 RID: 20295 RVA: 0x00155BF0 File Offset: 0x00153DF0
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 10168, RefRangeEnd = 10216, XrefRangeStart = 10168, XrefRangeEnd = 10216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DoLoadFromServer_d__20(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataStoreService._DoLoadFromServer_d__20>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataStoreService._DoLoadFromServer_d__20.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004F48 RID: 20296 RVA: 0x00155C38 File Offset: 0x00153E38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124316, XrefRangeEnd = 124321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataStoreService._DoLoadFromServer_d__20.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F49 RID: 20297 RVA: 0x00155C6C File Offset: 0x00153E6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124321, XrefRangeEnd = 124356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataStoreService._DoLoadFromServer_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004F4A RID: 20298 RVA: 0x00155CA8 File Offset: 0x00153EA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124356, XrefRangeEnd = 124359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataStoreService._DoLoadFromServer_d__20.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F4B RID: 20299 RVA: 0x00155CDC File Offset: 0x00153EDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124359, XrefRangeEnd = 124364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataStoreService._DoLoadFromServer_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F4C RID: 20300 RVA: 0x0001E369 File Offset: 0x0001C569
			public _DoLoadFromServer_d__20(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001AB9 RID: 6841
			// (get) Token: 0x06004F4D RID: 20301 RVA: 0x00155D10 File Offset: 0x00153F10
			// (set) Token: 0x06004F4E RID: 20302 RVA: 0x0001E372 File Offset: 0x0001C572
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataStoreService._DoLoadFromServer_d__20.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataStoreService._DoLoadFromServer_d__20.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001ABA RID: 6842
			// (get) Token: 0x06004F4F RID: 20303 RVA: 0x00155D38 File Offset: 0x00153F38
			// (set) Token: 0x06004F50 RID: 20304 RVA: 0x0001E38D File Offset: 0x0001C58D
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataStoreService._DoLoadFromServer_d__20.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataStoreService._DoLoadFromServer_d__20.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001ABB RID: 6843
			// (get) Token: 0x06004F51 RID: 20305 RVA: 0x00155D68 File Offset: 0x00153F68
			// (set) Token: 0x06004F52 RID: 20306 RVA: 0x0001E3AC File Offset: 0x0001C5AC
			public unsafe GetDataStoreQueueEntry entry
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataStoreService._DoLoadFromServer_d__20.NativeFieldInfoPtr_entry);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GetDataStoreQueueEntry>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataStoreService._DoLoadFromServer_d__20.NativeFieldInfoPtr_entry), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001ABC RID: 6844
			// (get) Token: 0x06004F53 RID: 20307 RVA: 0x00155D98 File Offset: 0x00153F98
			// (set) Token: 0x06004F54 RID: 20308 RVA: 0x0001E3CB File Offset: 0x0001C5CB
			public unsafe DataStoreService __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataStoreService._DoLoadFromServer_d__20.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataStoreService>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataStoreService._DoLoadFromServer_d__20.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001ABD RID: 6845
			// (get) Token: 0x06004F55 RID: 20309 RVA: 0x00155DC8 File Offset: 0x00153FC8
			// (set) Token: 0x06004F56 RID: 20310 RVA: 0x0001E3EA File Offset: 0x0001C5EA
			public unsafe Datastore _ds_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataStoreService._DoLoadFromServer_d__20.NativeFieldInfoPtr__ds_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Datastore>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataStoreService._DoLoadFromServer_d__20.NativeFieldInfoPtr__ds_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001ABE RID: 6846
			// (get) Token: 0x06004F57 RID: 20311 RVA: 0x00155DF8 File Offset: 0x00153FF8
			// (set) Token: 0x06004F58 RID: 20312 RVA: 0x0001E409 File Offset: 0x0001C609
			public unsafe UnityWebRequest _uwr_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataStoreService._DoLoadFromServer_d__20.NativeFieldInfoPtr__uwr_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataStoreService._DoLoadFromServer_d__20.NativeFieldInfoPtr__uwr_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003D3A RID: 15674
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003D3B RID: 15675
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003D3C RID: 15676
			private static readonly IntPtr NativeFieldInfoPtr_entry;

			// Token: 0x04003D3D RID: 15677
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003D3E RID: 15678
			private static readonly IntPtr NativeFieldInfoPtr__ds_5__2;

			// Token: 0x04003D3F RID: 15679
			private static readonly IntPtr NativeFieldInfoPtr__uwr_5__3;

			// Token: 0x04003D40 RID: 15680
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003D41 RID: 15681
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003D42 RID: 15682
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003D43 RID: 15683
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003D44 RID: 15684
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003D45 RID: 15685
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04003D46 RID: 15686
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}

		// Token: 0x0200040E RID: 1038
		[ObfuscatedName("Polytoria.Datamodel.Services.DataStoreService+<DoWriteToServer>d__22")]
		public sealed class _DoWriteToServer_d__22 : Object
		{
			// Token: 0x06004F59 RID: 20313 RVA: 0x00155E28 File Offset: 0x00154028
			// Note: this type is marked as 'beforefieldinit'.
			static _DoWriteToServer_d__22()
			{
				Il2CppClassPointerStore<DataStoreService._DoWriteToServer_d__22>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DataStoreService>.NativeClassPtr, "<DoWriteToServer>d__22");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataStoreService._DoWriteToServer_d__22>.NativeClassPtr);
				DataStoreService._DoWriteToServer_d__22.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataStoreService._DoWriteToServer_d__22>.NativeClassPtr, "<>1__state");
				DataStoreService._DoWriteToServer_d__22.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataStoreService._DoWriteToServer_d__22>.NativeClassPtr, "<>2__current");
				DataStoreService._DoWriteToServer_d__22.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataStoreService._DoWriteToServer_d__22>.NativeClassPtr, "value");
				DataStoreService._DoWriteToServer_d__22.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataStoreService._DoWriteToServer_d__22>.NativeClassPtr, "key");
				DataStoreService._DoWriteToServer_d__22.NativeFieldInfoPtr_ds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataStoreService._DoWriteToServer_d__22>.NativeClassPtr, "ds");
				DataStoreService._DoWriteToServer_d__22.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataStoreService._DoWriteToServer_d__22>.NativeClassPtr, "callback");
				DataStoreService._DoWriteToServer_d__22.NativeFieldInfoPtr__uwr_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataStoreService._DoWriteToServer_d__22>.NativeClassPtr, "<uwr>5__2");
				DataStoreService._DoWriteToServer_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStoreService._DoWriteToServer_d__22>.NativeClassPtr, 100672974);
				DataStoreService._DoWriteToServer_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStoreService._DoWriteToServer_d__22>.NativeClassPtr, 100672976);
				DataStoreService._DoWriteToServer_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStoreService._DoWriteToServer_d__22>.NativeClassPtr, 100672970);
				DataStoreService._DoWriteToServer_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStoreService._DoWriteToServer_d__22>.NativeClassPtr, 100672971);
				DataStoreService._DoWriteToServer_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStoreService._DoWriteToServer_d__22>.NativeClassPtr, 100672972);
				DataStoreService._DoWriteToServer_d__22.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStoreService._DoWriteToServer_d__22>.NativeClassPtr, 100672973);
				DataStoreService._DoWriteToServer_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStoreService._DoWriteToServer_d__22>.NativeClassPtr, 100672975);
			}

			// Token: 0x17001AC8 RID: 6856
			// (get) Token: 0x06004F5A RID: 20314 RVA: 0x00155F6C File Offset: 0x0015416C
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataStoreService._DoWriteToServer_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001AC9 RID: 6857
			// (get) Token: 0x06004F5B RID: 20315 RVA: 0x00155FAC File Offset: 0x001541AC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataStoreService._DoWriteToServer_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004F5C RID: 20316 RVA: 0x00155FEC File Offset: 0x001541EC
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 10168, RefRangeEnd = 10216, XrefRangeStart = 10168, XrefRangeEnd = 10216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DoWriteToServer_d__22(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataStoreService._DoWriteToServer_d__22>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataStoreService._DoWriteToServer_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004F5D RID: 20317 RVA: 0x00156034 File Offset: 0x00154234
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124364, XrefRangeEnd = 124369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataStoreService._DoWriteToServer_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F5E RID: 20318 RVA: 0x00156068 File Offset: 0x00154268
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124369, XrefRangeEnd = 124435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataStoreService._DoWriteToServer_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004F5F RID: 20319 RVA: 0x001560A4 File Offset: 0x001542A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124435, XrefRangeEnd = 124438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataStoreService._DoWriteToServer_d__22.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F60 RID: 20320 RVA: 0x001560D8 File Offset: 0x001542D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124438, XrefRangeEnd = 124443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataStoreService._DoWriteToServer_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F61 RID: 20321 RVA: 0x0001E428 File Offset: 0x0001C628
			public _DoWriteToServer_d__22(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001AC1 RID: 6849
			// (get) Token: 0x06004F62 RID: 20322 RVA: 0x0015610C File Offset: 0x0015430C
			// (set) Token: 0x06004F63 RID: 20323 RVA: 0x0001E431 File Offset: 0x0001C631
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataStoreService._DoWriteToServer_d__22.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataStoreService._DoWriteToServer_d__22.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001AC2 RID: 6850
			// (get) Token: 0x06004F64 RID: 20324 RVA: 0x00156134 File Offset: 0x00154334
			// (set) Token: 0x06004F65 RID: 20325 RVA: 0x0001E44C File Offset: 0x0001C64C
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataStoreService._DoWriteToServer_d__22.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataStoreService._DoWriteToServer_d__22.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AC3 RID: 6851
			// (get) Token: 0x06004F66 RID: 20326 RVA: 0x00156164 File Offset: 0x00154364
			// (set) Token: 0x06004F67 RID: 20327 RVA: 0x0001E46B File Offset: 0x0001C66B
			public unsafe Object value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataStoreService._DoWriteToServer_d__22.NativeFieldInfoPtr_value);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataStoreService._DoWriteToServer_d__22.NativeFieldInfoPtr_value), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AC4 RID: 6852
			// (get) Token: 0x06004F68 RID: 20328 RVA: 0x00156194 File Offset: 0x00154394
			// (set) Token: 0x06004F69 RID: 20329 RVA: 0x0001E48A File Offset: 0x0001C68A
			public unsafe string key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataStoreService._DoWriteToServer_d__22.NativeFieldInfoPtr_key);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataStoreService._DoWriteToServer_d__22.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001AC5 RID: 6853
			// (get) Token: 0x06004F6A RID: 20330 RVA: 0x001561BC File Offset: 0x001543BC
			// (set) Token: 0x06004F6B RID: 20331 RVA: 0x0001E4A9 File Offset: 0x0001C6A9
			public unsafe Datastore ds
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataStoreService._DoWriteToServer_d__22.NativeFieldInfoPtr_ds);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Datastore>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataStoreService._DoWriteToServer_d__22.NativeFieldInfoPtr_ds), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AC6 RID: 6854
			// (get) Token: 0x06004F6C RID: 20332 RVA: 0x001561EC File Offset: 0x001543EC
			// (set) Token: 0x06004F6D RID: 20333 RVA: 0x0001E4C8 File Offset: 0x0001C6C8
			public unsafe Action<bool> callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataStoreService._DoWriteToServer_d__22.NativeFieldInfoPtr_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataStoreService._DoWriteToServer_d__22.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AC7 RID: 6855
			// (get) Token: 0x06004F6E RID: 20334 RVA: 0x0015621C File Offset: 0x0015441C
			// (set) Token: 0x06004F6F RID: 20335 RVA: 0x0001E4E7 File Offset: 0x0001C6E7
			public unsafe UnityWebRequest _uwr_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataStoreService._DoWriteToServer_d__22.NativeFieldInfoPtr__uwr_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataStoreService._DoWriteToServer_d__22.NativeFieldInfoPtr__uwr_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003D47 RID: 15687
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003D48 RID: 15688
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003D49 RID: 15689
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x04003D4A RID: 15690
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x04003D4B RID: 15691
			private static readonly IntPtr NativeFieldInfoPtr_ds;

			// Token: 0x04003D4C RID: 15692
			private static readonly IntPtr NativeFieldInfoPtr_callback;

			// Token: 0x04003D4D RID: 15693
			private static readonly IntPtr NativeFieldInfoPtr__uwr_5__2;

			// Token: 0x04003D4E RID: 15694
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003D4F RID: 15695
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003D50 RID: 15696
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003D51 RID: 15697
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003D52 RID: 15698
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003D53 RID: 15699
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04003D54 RID: 15700
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}
	}
}
