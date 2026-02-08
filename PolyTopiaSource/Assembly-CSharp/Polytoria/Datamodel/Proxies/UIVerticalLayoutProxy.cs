using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x02000305 RID: 773
	public class UIVerticalLayoutProxy : UIHVLayoutProxy
	{
		// Token: 0x06004338 RID: 17208 RVA: 0x0012DF3C File Offset: 0x0012C13C
		// Note: this type is marked as 'beforefieldinit'.
		static UIVerticalLayoutProxy()
		{
			Il2CppClassPointerStore<UIVerticalLayoutProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Proxies", "UIVerticalLayoutProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIVerticalLayoutProxy>.NativeClassPtr);
			UIVerticalLayoutProxy.NativeFieldInfoPtr_uiVerticalLayout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIVerticalLayoutProxy>.NativeClassPtr, "uiVerticalLayout");
			UIVerticalLayoutProxy.NativeMethodInfoPtr__ctor_Public_Void_UIVerticalLayout_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIVerticalLayoutProxy>.NativeClassPtr, 100673944);
		}

		// Token: 0x06004339 RID: 17209 RVA: 0x0012DF94 File Offset: 0x0012C194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIVerticalLayoutProxy(UIVerticalLayout target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIVerticalLayoutProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIVerticalLayoutProxy.NativeMethodInfoPtr__ctor_Public_Void_UIVerticalLayout_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600433A RID: 17210 RVA: 0x00018D09 File Offset: 0x00016F09
		public UIVerticalLayoutProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001744 RID: 5956
		// (get) Token: 0x0600433B RID: 17211 RVA: 0x0012DFE0 File Offset: 0x0012C1E0
		// (set) Token: 0x0600433C RID: 17212 RVA: 0x00018D12 File Offset: 0x00016F12
		public unsafe UIVerticalLayout uiVerticalLayout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIVerticalLayoutProxy.NativeFieldInfoPtr_uiVerticalLayout);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIVerticalLayout>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIVerticalLayoutProxy.NativeFieldInfoPtr_uiVerticalLayout), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003468 RID: 13416
		private static readonly IntPtr NativeFieldInfoPtr_uiVerticalLayout;

		// Token: 0x04003469 RID: 13417
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UIVerticalLayout_0;
	}
}
