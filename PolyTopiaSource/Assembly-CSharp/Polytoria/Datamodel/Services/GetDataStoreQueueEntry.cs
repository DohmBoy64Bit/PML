using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Polytoria.Datamodel.Services
{
	// Token: 0x020002C6 RID: 710
	public class GetDataStoreQueueEntry : Object
	{
		// Token: 0x06003ECE RID: 16078 RVA: 0x0011A1FC File Offset: 0x001183FC
		// Note: this type is marked as 'beforefieldinit'.
		static GetDataStoreQueueEntry()
		{
			Il2CppClassPointerStore<GetDataStoreQueueEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Services", "GetDataStoreQueueEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetDataStoreQueueEntry>.NativeClassPtr);
			GetDataStoreQueueEntry.NativeFieldInfoPtr_datastore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetDataStoreQueueEntry>.NativeClassPtr, "datastore");
			GetDataStoreQueueEntry.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetDataStoreQueueEntry>.NativeClassPtr, "callback");
			GetDataStoreQueueEntry.NativeMethodInfoPtr__ctor_Public_Void_Datastore_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetDataStoreQueueEntry>.NativeClassPtr, 100672977);
		}

		// Token: 0x06003ECF RID: 16079 RVA: 0x0011A268 File Offset: 0x00118468
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 33819, RefRangeEnd = 33846, XrefRangeStart = 33819, XrefRangeEnd = 33846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GetDataStoreQueueEntry(Datastore datastore, Action<bool> callback)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetDataStoreQueueEntry>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(datastore);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetDataStoreQueueEntry.NativeMethodInfoPtr__ctor_Public_Void_Datastore_Action_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003ED0 RID: 16080 RVA: 0x00018179 File Offset: 0x00016379
		public GetDataStoreQueueEntry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170015A3 RID: 5539
		// (get) Token: 0x06003ED1 RID: 16081 RVA: 0x0011A2C8 File Offset: 0x001184C8
		// (set) Token: 0x06003ED2 RID: 16082 RVA: 0x00018182 File Offset: 0x00016382
		public unsafe Datastore datastore
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetDataStoreQueueEntry.NativeFieldInfoPtr_datastore);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Datastore>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetDataStoreQueueEntry.NativeFieldInfoPtr_datastore), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015A4 RID: 5540
		// (get) Token: 0x06003ED3 RID: 16083 RVA: 0x0011A2F8 File Offset: 0x001184F8
		// (set) Token: 0x06003ED4 RID: 16084 RVA: 0x000181A1 File Offset: 0x000163A1
		public unsafe Action<bool> callback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetDataStoreQueueEntry.NativeFieldInfoPtr_callback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetDataStoreQueueEntry.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040030D2 RID: 12498
		private static readonly IntPtr NativeFieldInfoPtr_datastore;

		// Token: 0x040030D3 RID: 12499
		private static readonly IntPtr NativeFieldInfoPtr_callback;

		// Token: 0x040030D4 RID: 12500
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Datastore_Action_1_Boolean_0;
	}
}
