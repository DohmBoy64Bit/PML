using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002DC RID: 732
	public class HiddenProxy : InstanceProxy
	{
		// Token: 0x0600405F RID: 16479 RVA: 0x001210C4 File Offset: 0x0011F2C4
		// Note: this type is marked as 'beforefieldinit'.
		static HiddenProxy()
		{
			Il2CppClassPointerStore<HiddenProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Proxies", "HiddenProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HiddenProxy>.NativeClassPtr);
			HiddenProxy.NativeFieldInfoPtr_hidden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HiddenProxy>.NativeClassPtr, "hidden");
			HiddenProxy.NativeMethodInfoPtr__ctor_Public_Void_Hidden_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HiddenProxy>.NativeClassPtr, 100673379);
		}

		// Token: 0x06004060 RID: 16480 RVA: 0x0012111C File Offset: 0x0011F31C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HiddenProxy(Hidden target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HiddenProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HiddenProxy.NativeMethodInfoPtr__ctor_Public_Void_Hidden_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004061 RID: 16481 RVA: 0x000186A1 File Offset: 0x000168A1
		public HiddenProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700161E RID: 5662
		// (get) Token: 0x06004062 RID: 16482 RVA: 0x00121168 File Offset: 0x0011F368
		// (set) Token: 0x06004063 RID: 16483 RVA: 0x000186AA File Offset: 0x000168AA
		public unsafe Hidden hidden
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HiddenProxy.NativeFieldInfoPtr_hidden);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hidden>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HiddenProxy.NativeFieldInfoPtr_hidden), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400320A RID: 12810
		private static readonly IntPtr NativeFieldInfoPtr_hidden;

		// Token: 0x0400320B RID: 12811
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Hidden_0;
	}
}
