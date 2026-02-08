using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Polytoria.Datamodel.Services;

namespace Polytoria.Datamodel.Proxies.Services
{
	// Token: 0x0200030D RID: 781
	public class DataStoreServiceProxy : Object
	{
		// Token: 0x06004383 RID: 17283 RVA: 0x0012F1DC File Offset: 0x0012D3DC
		// Note: this type is marked as 'beforefieldinit'.
		static DataStoreServiceProxy()
		{
			Il2CppClassPointerStore<DataStoreServiceProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Proxies.Services", "DataStoreServiceProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataStoreServiceProxy>.NativeClassPtr);
			DataStoreServiceProxy.NativeFieldInfoPtr_dataStoreService = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataStoreServiceProxy>.NativeClassPtr, "dataStoreService");
			DataStoreServiceProxy.NativeMethodInfoPtr__ctor_Public_Void_DataStoreService_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStoreServiceProxy>.NativeClassPtr, 100673987);
			DataStoreServiceProxy.NativeMethodInfoPtr_GetDatastore_Public_Datastore_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataStoreServiceProxy>.NativeClassPtr, 100673988);
		}

		// Token: 0x06004384 RID: 17284 RVA: 0x0012F248 File Offset: 0x0012D448
		[CallerCount(60)]
		[CachedScanResults(RefRangeStart = 43100, RefRangeEnd = 43160, XrefRangeStart = 43100, XrefRangeEnd = 43160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataStoreServiceProxy(DataStoreService target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataStoreServiceProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataStoreServiceProxy.NativeMethodInfoPtr__ctor_Public_Void_DataStoreService_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004385 RID: 17285 RVA: 0x0012F294 File Offset: 0x0012D494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129226, XrefRangeEnd = 129228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Datastore GetDatastore(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataStoreServiceProxy.NativeMethodInfoPtr_GetDatastore_Public_Datastore_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Datastore>(intPtr3) : null;
			}
		}

		// Token: 0x06004386 RID: 17286 RVA: 0x00018E49 File Offset: 0x00017049
		public DataStoreServiceProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700175C RID: 5980
		// (get) Token: 0x06004387 RID: 17287 RVA: 0x0012F2E4 File Offset: 0x0012D4E4
		// (set) Token: 0x06004388 RID: 17288 RVA: 0x00018E52 File Offset: 0x00017052
		public unsafe DataStoreService dataStoreService
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataStoreServiceProxy.NativeFieldInfoPtr_dataStoreService);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataStoreService>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataStoreServiceProxy.NativeFieldInfoPtr_dataStoreService), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400349B RID: 13467
		private static readonly IntPtr NativeFieldInfoPtr_dataStoreService;

		// Token: 0x0400349C RID: 13468
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataStoreService_0;

		// Token: 0x0400349D RID: 13469
		private static readonly IntPtr NativeMethodInfoPtr_GetDatastore_Public_Datastore_String_0;
	}
}
