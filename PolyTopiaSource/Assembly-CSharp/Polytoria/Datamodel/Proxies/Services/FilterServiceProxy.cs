using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Polytoria.Datamodel.Services;

namespace Polytoria.Datamodel.Proxies.Services
{
	// Token: 0x0200030E RID: 782
	public class FilterServiceProxy : Object
	{
		// Token: 0x06004389 RID: 17289 RVA: 0x0012F314 File Offset: 0x0012D514
		// Note: this type is marked as 'beforefieldinit'.
		static FilterServiceProxy()
		{
			Il2CppClassPointerStore<FilterServiceProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Proxies.Services", "FilterServiceProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterServiceProxy>.NativeClassPtr);
			FilterServiceProxy.NativeFieldInfoPtr_filterService = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterServiceProxy>.NativeClassPtr, "filterService");
			FilterServiceProxy.NativeMethodInfoPtr__ctor_Public_Void_FilterService_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterServiceProxy>.NativeClassPtr, 100673989);
			FilterServiceProxy.NativeMethodInfoPtr_Filter_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterServiceProxy>.NativeClassPtr, 100673990);
		}

		// Token: 0x0600438A RID: 17290 RVA: 0x0012F380 File Offset: 0x0012D580
		[CallerCount(60)]
		[CachedScanResults(RefRangeStart = 43100, RefRangeEnd = 43160, XrefRangeStart = 43100, XrefRangeEnd = 43160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FilterServiceProxy(FilterService target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilterServiceProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterServiceProxy.NativeMethodInfoPtr__ctor_Public_Void_FilterService_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600438B RID: 17291 RVA: 0x0012F3CC File Offset: 0x0012D5CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129228, XrefRangeEnd = 129232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Filter(string input)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterServiceProxy.NativeMethodInfoPtr_Filter_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600438C RID: 17292 RVA: 0x00018E71 File Offset: 0x00017071
		public FilterServiceProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700175D RID: 5981
		// (get) Token: 0x0600438D RID: 17293 RVA: 0x0012F408 File Offset: 0x0012D608
		// (set) Token: 0x0600438E RID: 17294 RVA: 0x00018E7A File Offset: 0x0001707A
		public unsafe FilterService filterService
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterServiceProxy.NativeFieldInfoPtr_filterService);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FilterService>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterServiceProxy.NativeFieldInfoPtr_filterService), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400349E RID: 13470
		private static readonly IntPtr NativeFieldInfoPtr_filterService;

		// Token: 0x0400349F RID: 13471
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_FilterService_0;

		// Token: 0x040034A0 RID: 13472
		private static readonly IntPtr NativeMethodInfoPtr_Filter_Public_Static_String_String_0;
	}
}
