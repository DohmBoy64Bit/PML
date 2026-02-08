using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using MoonSharp.Interpreter;
using Polytoria.Datamodel.Services;

namespace Polytoria.Datamodel.Proxies.Services
{
	// Token: 0x0200030F RID: 783
	public class HttpServiceProxy : Object
	{
		// Token: 0x0600438F RID: 17295 RVA: 0x0012F438 File Offset: 0x0012D638
		// Note: this type is marked as 'beforefieldinit'.
		static HttpServiceProxy()
		{
			Il2CppClassPointerStore<HttpServiceProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Proxies.Services", "HttpServiceProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpServiceProxy>.NativeClassPtr);
			HttpServiceProxy.NativeFieldInfoPtr_httpService = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpServiceProxy>.NativeClassPtr, "httpService");
			HttpServiceProxy.NativeMethodInfoPtr__ctor_Public_Void_HttpService_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpServiceProxy>.NativeClassPtr, 100673991);
			HttpServiceProxy.NativeMethodInfoPtr_Get_Public_Static_Void_String_DynValue_Table_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpServiceProxy>.NativeClassPtr, 100673992);
			HttpServiceProxy.NativeMethodInfoPtr_Post_Public_Static_Void_String_String_DynValue_Table_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpServiceProxy>.NativeClassPtr, 100673993);
			HttpServiceProxy.NativeMethodInfoPtr_Put_Public_Static_Void_String_String_DynValue_Table_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpServiceProxy>.NativeClassPtr, 100673994);
			HttpServiceProxy.NativeMethodInfoPtr_Delete_Public_Static_Void_String_DynValue_Table_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpServiceProxy>.NativeClassPtr, 100673995);
			HttpServiceProxy.NativeMethodInfoPtr_Patch_Public_Static_Void_String_String_DynValue_Table_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpServiceProxy>.NativeClassPtr, 100673996);
		}

		// Token: 0x06004390 RID: 17296 RVA: 0x0012F4F4 File Offset: 0x0012D6F4
		[CallerCount(60)]
		[CachedScanResults(RefRangeStart = 43100, RefRangeEnd = 43160, XrefRangeStart = 43100, XrefRangeEnd = 43160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HttpServiceProxy(HttpService target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpServiceProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpServiceProxy.NativeMethodInfoPtr__ctor_Public_Void_HttpService_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004391 RID: 17297 RVA: 0x0012F540 File Offset: 0x0012D740
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129232, XrefRangeEnd = 129236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Get(string url, DynValue callback = null, Table headers = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(headers);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpServiceProxy.NativeMethodInfoPtr_Get_Public_Static_Void_String_DynValue_Table_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004392 RID: 17298 RVA: 0x0012F59C File Offset: 0x0012D79C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129236, XrefRangeEnd = 129240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Post(string url, string body, DynValue callback = null, Table headers = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(body);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(headers);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpServiceProxy.NativeMethodInfoPtr_Post_Public_Static_Void_String_String_DynValue_Table_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004393 RID: 17299 RVA: 0x0012F608 File Offset: 0x0012D808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129240, XrefRangeEnd = 129244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Put(string url, string body, DynValue callback = null, Table headers = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(body);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(headers);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpServiceProxy.NativeMethodInfoPtr_Put_Public_Static_Void_String_String_DynValue_Table_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004394 RID: 17300 RVA: 0x0012F674 File Offset: 0x0012D874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129244, XrefRangeEnd = 129248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Delete(string url, DynValue callback = null, Table headers = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(headers);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpServiceProxy.NativeMethodInfoPtr_Delete_Public_Static_Void_String_DynValue_Table_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004395 RID: 17301 RVA: 0x0012F6D0 File Offset: 0x0012D8D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129248, XrefRangeEnd = 129252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Patch(string url, string body, DynValue callback = null, Table headers = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(body);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(headers);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpServiceProxy.NativeMethodInfoPtr_Patch_Public_Static_Void_String_String_DynValue_Table_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004396 RID: 17302 RVA: 0x00018E99 File Offset: 0x00017099
		public HttpServiceProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700175E RID: 5982
		// (get) Token: 0x06004397 RID: 17303 RVA: 0x0012F73C File Offset: 0x0012D93C
		// (set) Token: 0x06004398 RID: 17304 RVA: 0x00018EA2 File Offset: 0x000170A2
		public unsafe HttpService httpService
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpServiceProxy.NativeFieldInfoPtr_httpService);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpService>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpServiceProxy.NativeFieldInfoPtr_httpService), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040034A1 RID: 13473
		private static readonly IntPtr NativeFieldInfoPtr_httpService;

		// Token: 0x040034A2 RID: 13474
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_HttpService_0;

		// Token: 0x040034A3 RID: 13475
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_Void_String_DynValue_Table_0;

		// Token: 0x040034A4 RID: 13476
		private static readonly IntPtr NativeMethodInfoPtr_Post_Public_Static_Void_String_String_DynValue_Table_0;

		// Token: 0x040034A5 RID: 13477
		private static readonly IntPtr NativeMethodInfoPtr_Put_Public_Static_Void_String_String_DynValue_Table_0;

		// Token: 0x040034A6 RID: 13478
		private static readonly IntPtr NativeMethodInfoPtr_Delete_Public_Static_Void_String_DynValue_Table_0;

		// Token: 0x040034A7 RID: 13479
		private static readonly IntPtr NativeMethodInfoPtr_Patch_Public_Static_Void_String_String_DynValue_Table_0;
	}
}
