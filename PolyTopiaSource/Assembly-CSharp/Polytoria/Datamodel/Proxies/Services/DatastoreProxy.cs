using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using MoonSharp.Interpreter;
using Polytoria.Datamodel.Services;
using Polytoria.Lua;

namespace Polytoria.Datamodel.Proxies.Services
{
	// Token: 0x0200030C RID: 780
	public class DatastoreProxy : Object
	{
		// Token: 0x06004378 RID: 17272 RVA: 0x0012EECC File Offset: 0x0012D0CC
		// Note: this type is marked as 'beforefieldinit'.
		static DatastoreProxy()
		{
			Il2CppClassPointerStore<DatastoreProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Proxies.Services", "DatastoreProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DatastoreProxy>.NativeClassPtr);
			DatastoreProxy.NativeFieldInfoPtr_datastore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DatastoreProxy>.NativeClassPtr, "datastore");
			DatastoreProxy.NativeMethodInfoPtr_get_Key_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatastoreProxy>.NativeClassPtr, 100673981);
			DatastoreProxy.NativeMethodInfoPtr_get_Loading_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatastoreProxy>.NativeClassPtr, 100673982);
			DatastoreProxy.NativeMethodInfoPtr_get_Loaded_Public_get_LuaEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatastoreProxy>.NativeClassPtr, 100673983);
			DatastoreProxy.NativeMethodInfoPtr__ctor_Public_Void_Datastore_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatastoreProxy>.NativeClassPtr, 100673980);
			DatastoreProxy.NativeMethodInfoPtr_Get_Public_Void_String_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatastoreProxy>.NativeClassPtr, 100673984);
			DatastoreProxy.NativeMethodInfoPtr_Set_Public_Void_String_DynValue_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatastoreProxy>.NativeClassPtr, 100673985);
			DatastoreProxy.NativeMethodInfoPtr_Remove_Public_Void_String_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DatastoreProxy>.NativeClassPtr, 100673986);
		}

		// Token: 0x17001759 RID: 5977
		// (get) Token: 0x06004379 RID: 17273 RVA: 0x0012EF9C File Offset: 0x0012D19C
		public unsafe string Key
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 129218, RefRangeEnd = 129220, XrefRangeStart = 129218, XrefRangeEnd = 129218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatastoreProxy.NativeMethodInfoPtr_get_Key_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700175A RID: 5978
		// (get) Token: 0x0600437A RID: 17274 RVA: 0x0012EFD4 File Offset: 0x0012D1D4
		public unsafe bool Loading
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatastoreProxy.NativeMethodInfoPtr_get_Loading_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700175B RID: 5979
		// (get) Token: 0x0600437B RID: 17275 RVA: 0x0012F010 File Offset: 0x0012D210
		public unsafe LuaEvent Loaded
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 69511, RefRangeEnd = 69513, XrefRangeStart = 69511, XrefRangeEnd = 69513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatastoreProxy.NativeMethodInfoPtr_get_Loaded_Public_get_LuaEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LuaEvent>(intPtr3) : null;
			}
		}

		// Token: 0x0600437C RID: 17276 RVA: 0x0012F050 File Offset: 0x0012D250
		[CallerCount(60)]
		[CachedScanResults(RefRangeStart = 43100, RefRangeEnd = 43160, XrefRangeStart = 43100, XrefRangeEnd = 43160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DatastoreProxy(Datastore target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DatastoreProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatastoreProxy.NativeMethodInfoPtr__ctor_Public_Void_Datastore_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600437D RID: 17277 RVA: 0x0012F09C File Offset: 0x0012D29C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129220, XrefRangeEnd = 129222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Get(string key, DynValue callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatastoreProxy.NativeMethodInfoPtr_Get_Public_Void_String_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600437E RID: 17278 RVA: 0x0012F0F0 File Offset: 0x0012D2F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129222, XrefRangeEnd = 129224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(string key, DynValue value, DynValue callback = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatastoreProxy.NativeMethodInfoPtr_Set_Public_Void_String_DynValue_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600437F RID: 17279 RVA: 0x0012F158 File Offset: 0x0012D358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129224, XrefRangeEnd = 129226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove(string key, DynValue callback = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DatastoreProxy.NativeMethodInfoPtr_Remove_Public_Void_String_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004380 RID: 17280 RVA: 0x00018E21 File Offset: 0x00017021
		public DatastoreProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001758 RID: 5976
		// (get) Token: 0x06004381 RID: 17281 RVA: 0x0012F1AC File Offset: 0x0012D3AC
		// (set) Token: 0x06004382 RID: 17282 RVA: 0x00018E2A File Offset: 0x0001702A
		public unsafe Datastore datastore
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DatastoreProxy.NativeFieldInfoPtr_datastore);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Datastore>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DatastoreProxy.NativeFieldInfoPtr_datastore), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003493 RID: 13459
		private static readonly IntPtr NativeFieldInfoPtr_datastore;

		// Token: 0x04003494 RID: 13460
		private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_get_String_0;

		// Token: 0x04003495 RID: 13461
		private static readonly IntPtr NativeMethodInfoPtr_get_Loading_Public_get_Boolean_0;

		// Token: 0x04003496 RID: 13462
		private static readonly IntPtr NativeMethodInfoPtr_get_Loaded_Public_get_LuaEvent_0;

		// Token: 0x04003497 RID: 13463
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Datastore_0;

		// Token: 0x04003498 RID: 13464
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Void_String_DynValue_0;

		// Token: 0x04003499 RID: 13465
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_String_DynValue_DynValue_0;

		// Token: 0x0400349A RID: 13466
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Void_String_DynValue_0;
	}
}
