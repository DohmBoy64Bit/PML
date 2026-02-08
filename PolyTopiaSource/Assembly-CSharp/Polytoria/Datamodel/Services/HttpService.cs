using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using MoonSharp.Interpreter;
using UnityEngine;
using UnityEngine.Networking;

namespace Polytoria.Datamodel.Services
{
	// Token: 0x020002C9 RID: 713
	public class HttpService : MonoBehaviour
	{
		// Token: 0x06003EF3 RID: 16115 RVA: 0x0011A854 File Offset: 0x00118A54
		// Note: this type is marked as 'beforefieldinit'.
		static HttpService()
		{
			Il2CppClassPointerStore<HttpService>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Services", "HttpService");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpService>.NativeClassPtr);
			HttpService.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpService>.NativeClassPtr, "instance");
			HttpService.NativeFieldInfoPtr_maxRequestsPerMinute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpService>.NativeClassPtr, "maxRequestsPerMinute");
			HttpService.NativeFieldInfoPtr_requestsThisMinute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpService>.NativeClassPtr, "requestsThisMinute");
			HttpService.NativeFieldInfoPtr_currentMinute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpService>.NativeClassPtr, "currentMinute");
			HttpService.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpService>.NativeClassPtr, 100673008);
			HttpService.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpService>.NativeClassPtr, 100673000);
			HttpService.NativeMethodInfoPtr_RateLimit_Private_Static_Boolean_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpService>.NativeClassPtr, 100673001);
			HttpService.NativeMethodInfoPtr_Get_Public_Static_Void_String_DynValue_Table_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpService>.NativeClassPtr, 100673002);
			HttpService.NativeMethodInfoPtr_Post_Public_Static_Void_String_String_DynValue_Table_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpService>.NativeClassPtr, 100673003);
			HttpService.NativeMethodInfoPtr_Put_Public_Static_Void_String_String_DynValue_Table_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpService>.NativeClassPtr, 100673004);
			HttpService.NativeMethodInfoPtr_Delete_Public_Static_Void_String_DynValue_Table_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpService>.NativeClassPtr, 100673005);
			HttpService.NativeMethodInfoPtr_Patch_Public_Static_Void_String_String_DynValue_Table_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpService>.NativeClassPtr, 100673006);
			HttpService.NativeMethodInfoPtr_DoRequest_Private_Static_IEnumerator_String_String_String_DynValue_Table_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpService>.NativeClassPtr, 100673007);
		}

		// Token: 0x06003EF4 RID: 16116 RVA: 0x0011A988 File Offset: 0x00118B88
		[CallerCount(61)]
		[CachedScanResults(RefRangeStart = 10788, RefRangeEnd = 10849, XrefRangeStart = 10788, XrefRangeEnd = 10849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HttpService()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpService>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpService.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EF5 RID: 16117 RVA: 0x0011A9C4 File Offset: 0x00118BC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124958, XrefRangeEnd = 124964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpService.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EF6 RID: 16118 RVA: 0x0011A9F8 File Offset: 0x00118BF8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 124990, RefRangeEnd = 124995, XrefRangeStart = 124964, XrefRangeEnd = 124990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RateLimit(DynValue callback = null)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpService.NativeMethodInfoPtr_RateLimit_Private_Static_Boolean_DynValue_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003EF7 RID: 16119 RVA: 0x0011AA3C File Offset: 0x00118C3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 125006, RefRangeEnd = 125007, XrefRangeStart = 124995, XrefRangeEnd = 125006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpService.NativeMethodInfoPtr_Get_Public_Static_Void_String_DynValue_Table_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EF8 RID: 16120 RVA: 0x0011AA98 File Offset: 0x00118C98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 125018, RefRangeEnd = 125019, XrefRangeStart = 125007, XrefRangeEnd = 125018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpService.NativeMethodInfoPtr_Post_Public_Static_Void_String_String_DynValue_Table_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EF9 RID: 16121 RVA: 0x0011AB04 File Offset: 0x00118D04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 125030, RefRangeEnd = 125031, XrefRangeStart = 125019, XrefRangeEnd = 125030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpService.NativeMethodInfoPtr_Put_Public_Static_Void_String_String_DynValue_Table_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EFA RID: 16122 RVA: 0x0011AB70 File Offset: 0x00118D70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 125042, RefRangeEnd = 125043, XrefRangeStart = 125031, XrefRangeEnd = 125042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpService.NativeMethodInfoPtr_Delete_Public_Static_Void_String_DynValue_Table_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EFB RID: 16123 RVA: 0x0011ABCC File Offset: 0x00118DCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 125054, RefRangeEnd = 125055, XrefRangeStart = 125043, XrefRangeEnd = 125054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpService.NativeMethodInfoPtr_Patch_Public_Static_Void_String_String_DynValue_Table_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EFC RID: 16124 RVA: 0x0011AC38 File Offset: 0x00118E38
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 125064, RefRangeEnd = 125069, XrefRangeStart = 125055, XrefRangeEnd = 125064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerator DoRequest(string method, string url, string body = null, DynValue callback = null, Table headers = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(method);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(url);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(body);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(headers);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpService.NativeMethodInfoPtr_DoRequest_Private_Static_IEnumerator_String_String_String_DynValue_Table_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06003EFD RID: 16125 RVA: 0x0001827D File Offset: 0x0001647D
		public HttpService(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170015AE RID: 5550
		// (get) Token: 0x06003EFE RID: 16126 RVA: 0x0011ACC8 File Offset: 0x00118EC8
		// (set) Token: 0x06003EFF RID: 16127 RVA: 0x00018286 File Offset: 0x00016486
		public unsafe static HttpService instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HttpService.NativeFieldInfoPtr_instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpService>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HttpService.NativeFieldInfoPtr_instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015AF RID: 5551
		// (get) Token: 0x06003F00 RID: 16128 RVA: 0x0011ACF0 File Offset: 0x00118EF0
		// (set) Token: 0x06003F01 RID: 16129 RVA: 0x00018298 File Offset: 0x00016498
		public unsafe static int maxRequestsPerMinute
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HttpService.NativeFieldInfoPtr_maxRequestsPerMinute, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HttpService.NativeFieldInfoPtr_maxRequestsPerMinute, (void*)(&value));
			}
		}

		// Token: 0x170015B0 RID: 5552
		// (get) Token: 0x06003F02 RID: 16130 RVA: 0x0011AD0C File Offset: 0x00118F0C
		// (set) Token: 0x06003F03 RID: 16131 RVA: 0x000182A6 File Offset: 0x000164A6
		public unsafe static int requestsThisMinute
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HttpService.NativeFieldInfoPtr_requestsThisMinute, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HttpService.NativeFieldInfoPtr_requestsThisMinute, (void*)(&value));
			}
		}

		// Token: 0x170015B1 RID: 5553
		// (get) Token: 0x06003F04 RID: 16132 RVA: 0x0011AD28 File Offset: 0x00118F28
		// (set) Token: 0x06003F05 RID: 16133 RVA: 0x000182B4 File Offset: 0x000164B4
		public unsafe static int currentMinute
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(HttpService.NativeFieldInfoPtr_currentMinute, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HttpService.NativeFieldInfoPtr_currentMinute, (void*)(&value));
			}
		}

		// Token: 0x040030E7 RID: 12519
		private static readonly IntPtr NativeFieldInfoPtr_instance;

		// Token: 0x040030E8 RID: 12520
		private static readonly IntPtr NativeFieldInfoPtr_maxRequestsPerMinute;

		// Token: 0x040030E9 RID: 12521
		private static readonly IntPtr NativeFieldInfoPtr_requestsThisMinute;

		// Token: 0x040030EA RID: 12522
		private static readonly IntPtr NativeFieldInfoPtr_currentMinute;

		// Token: 0x040030EB RID: 12523
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040030EC RID: 12524
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040030ED RID: 12525
		private static readonly IntPtr NativeMethodInfoPtr_RateLimit_Private_Static_Boolean_DynValue_0;

		// Token: 0x040030EE RID: 12526
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_Void_String_DynValue_Table_0;

		// Token: 0x040030EF RID: 12527
		private static readonly IntPtr NativeMethodInfoPtr_Post_Public_Static_Void_String_String_DynValue_Table_0;

		// Token: 0x040030F0 RID: 12528
		private static readonly IntPtr NativeMethodInfoPtr_Put_Public_Static_Void_String_String_DynValue_Table_0;

		// Token: 0x040030F1 RID: 12529
		private static readonly IntPtr NativeMethodInfoPtr_Delete_Public_Static_Void_String_DynValue_Table_0;

		// Token: 0x040030F2 RID: 12530
		private static readonly IntPtr NativeMethodInfoPtr_Patch_Public_Static_Void_String_String_DynValue_Table_0;

		// Token: 0x040030F3 RID: 12531
		private static readonly IntPtr NativeMethodInfoPtr_DoRequest_Private_Static_IEnumerator_String_String_String_DynValue_Table_0;

		// Token: 0x02000411 RID: 1041
		[ObfuscatedName("Polytoria.Datamodel.Services.HttpService+<DoRequest>d__11")]
		public sealed class _DoRequest_d__11 : global::Il2CppSystem.Object
		{
			// Token: 0x06004F8A RID: 20362 RVA: 0x00156750 File Offset: 0x00154950
			// Note: this type is marked as 'beforefieldinit'.
			static _DoRequest_d__11()
			{
				Il2CppClassPointerStore<HttpService._DoRequest_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HttpService>.NativeClassPtr, "<DoRequest>d__11");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpService._DoRequest_d__11>.NativeClassPtr);
				HttpService._DoRequest_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpService._DoRequest_d__11>.NativeClassPtr, "<>1__state");
				HttpService._DoRequest_d__11.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpService._DoRequest_d__11>.NativeClassPtr, "<>2__current");
				HttpService._DoRequest_d__11.NativeFieldInfoPtr_url = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpService._DoRequest_d__11>.NativeClassPtr, "url");
				HttpService._DoRequest_d__11.NativeFieldInfoPtr_method = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpService._DoRequest_d__11>.NativeClassPtr, "method");
				HttpService._DoRequest_d__11.NativeFieldInfoPtr_body = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpService._DoRequest_d__11>.NativeClassPtr, "body");
				HttpService._DoRequest_d__11.NativeFieldInfoPtr_headers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpService._DoRequest_d__11>.NativeClassPtr, "headers");
				HttpService._DoRequest_d__11.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpService._DoRequest_d__11>.NativeClassPtr, "callback");
				HttpService._DoRequest_d__11.NativeFieldInfoPtr__uwr_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HttpService._DoRequest_d__11>.NativeClassPtr, "<uwr>5__2");
				HttpService._DoRequest_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpService._DoRequest_d__11>.NativeClassPtr, 100673014);
				HttpService._DoRequest_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpService._DoRequest_d__11>.NativeClassPtr, 100673016);
				HttpService._DoRequest_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpService._DoRequest_d__11>.NativeClassPtr, 100673010);
				HttpService._DoRequest_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpService._DoRequest_d__11>.NativeClassPtr, 100673011);
				HttpService._DoRequest_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpService._DoRequest_d__11>.NativeClassPtr, 100673012);
				HttpService._DoRequest_d__11.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpService._DoRequest_d__11>.NativeClassPtr, 100673013);
				HttpService._DoRequest_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpService._DoRequest_d__11>.NativeClassPtr, 100673015);
			}

			// Token: 0x17001ADA RID: 6874
			// (get) Token: 0x06004F8B RID: 20363 RVA: 0x001568A8 File Offset: 0x00154AA8
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpService._DoRequest_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001ADB RID: 6875
			// (get) Token: 0x06004F8C RID: 20364 RVA: 0x001568E8 File Offset: 0x00154AE8
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpService._DoRequest_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004F8D RID: 20365 RVA: 0x00156928 File Offset: 0x00154B28
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 10168, RefRangeEnd = 10216, XrefRangeStart = 10168, XrefRangeEnd = 10216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DoRequest_d__11(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HttpService._DoRequest_d__11>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpService._DoRequest_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004F8E RID: 20366 RVA: 0x00156970 File Offset: 0x00154B70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124850, XrefRangeEnd = 124855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpService._DoRequest_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F8F RID: 20367 RVA: 0x001569A4 File Offset: 0x00154BA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124855, XrefRangeEnd = 124950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpService._DoRequest_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004F90 RID: 20368 RVA: 0x001569E0 File Offset: 0x00154BE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124950, XrefRangeEnd = 124953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpService._DoRequest_d__11.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F91 RID: 20369 RVA: 0x00156A14 File Offset: 0x00154C14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124953, XrefRangeEnd = 124958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpService._DoRequest_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F92 RID: 20370 RVA: 0x0001E5A7 File Offset: 0x0001C7A7
			public _DoRequest_d__11(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001AD2 RID: 6866
			// (get) Token: 0x06004F93 RID: 20371 RVA: 0x00156A48 File Offset: 0x00154C48
			// (set) Token: 0x06004F94 RID: 20372 RVA: 0x0001E5B0 File Offset: 0x0001C7B0
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpService._DoRequest_d__11.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpService._DoRequest_d__11.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001AD3 RID: 6867
			// (get) Token: 0x06004F95 RID: 20373 RVA: 0x00156A70 File Offset: 0x00154C70
			// (set) Token: 0x06004F96 RID: 20374 RVA: 0x0001E5CB File Offset: 0x0001C7CB
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpService._DoRequest_d__11.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpService._DoRequest_d__11.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AD4 RID: 6868
			// (get) Token: 0x06004F97 RID: 20375 RVA: 0x00156AA0 File Offset: 0x00154CA0
			// (set) Token: 0x06004F98 RID: 20376 RVA: 0x0001E5EA File Offset: 0x0001C7EA
			public unsafe string url
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpService._DoRequest_d__11.NativeFieldInfoPtr_url);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpService._DoRequest_d__11.NativeFieldInfoPtr_url), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001AD5 RID: 6869
			// (get) Token: 0x06004F99 RID: 20377 RVA: 0x00156AC8 File Offset: 0x00154CC8
			// (set) Token: 0x06004F9A RID: 20378 RVA: 0x0001E609 File Offset: 0x0001C809
			public unsafe string method
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpService._DoRequest_d__11.NativeFieldInfoPtr_method);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpService._DoRequest_d__11.NativeFieldInfoPtr_method), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001AD6 RID: 6870
			// (get) Token: 0x06004F9B RID: 20379 RVA: 0x00156AF0 File Offset: 0x00154CF0
			// (set) Token: 0x06004F9C RID: 20380 RVA: 0x0001E628 File Offset: 0x0001C828
			public unsafe string body
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpService._DoRequest_d__11.NativeFieldInfoPtr_body);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpService._DoRequest_d__11.NativeFieldInfoPtr_body), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001AD7 RID: 6871
			// (get) Token: 0x06004F9D RID: 20381 RVA: 0x00156B18 File Offset: 0x00154D18
			// (set) Token: 0x06004F9E RID: 20382 RVA: 0x0001E647 File Offset: 0x0001C847
			public unsafe Table headers
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpService._DoRequest_d__11.NativeFieldInfoPtr_headers);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Table>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpService._DoRequest_d__11.NativeFieldInfoPtr_headers), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AD8 RID: 6872
			// (get) Token: 0x06004F9F RID: 20383 RVA: 0x00156B48 File Offset: 0x00154D48
			// (set) Token: 0x06004FA0 RID: 20384 RVA: 0x0001E666 File Offset: 0x0001C866
			public unsafe DynValue callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpService._DoRequest_d__11.NativeFieldInfoPtr_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpService._DoRequest_d__11.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AD9 RID: 6873
			// (get) Token: 0x06004FA1 RID: 20385 RVA: 0x00156B78 File Offset: 0x00154D78
			// (set) Token: 0x06004FA2 RID: 20386 RVA: 0x0001E685 File Offset: 0x0001C885
			public unsafe UnityWebRequest _uwr_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpService._DoRequest_d__11.NativeFieldInfoPtr__uwr_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HttpService._DoRequest_d__11.NativeFieldInfoPtr__uwr_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003D65 RID: 15717
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003D66 RID: 15718
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003D67 RID: 15719
			private static readonly IntPtr NativeFieldInfoPtr_url;

			// Token: 0x04003D68 RID: 15720
			private static readonly IntPtr NativeFieldInfoPtr_method;

			// Token: 0x04003D69 RID: 15721
			private static readonly IntPtr NativeFieldInfoPtr_body;

			// Token: 0x04003D6A RID: 15722
			private static readonly IntPtr NativeFieldInfoPtr_headers;

			// Token: 0x04003D6B RID: 15723
			private static readonly IntPtr NativeFieldInfoPtr_callback;

			// Token: 0x04003D6C RID: 15724
			private static readonly IntPtr NativeFieldInfoPtr__uwr_5__2;

			// Token: 0x04003D6D RID: 15725
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003D6E RID: 15726
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003D6F RID: 15727
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003D70 RID: 15728
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003D71 RID: 15729
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003D72 RID: 15730
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04003D73 RID: 15731
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}
	}
}
