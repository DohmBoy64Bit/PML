using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x02000300 RID: 768
	public class UIHorizontalLayoutProxy : UIHVLayoutProxy
	{
		// Token: 0x060042CC RID: 17100 RVA: 0x0012C024 File Offset: 0x0012A224
		// Note: this type is marked as 'beforefieldinit'.
		static UIHorizontalLayoutProxy()
		{
			Il2CppClassPointerStore<UIHorizontalLayoutProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Proxies", "UIHorizontalLayoutProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIHorizontalLayoutProxy>.NativeClassPtr);
			UIHorizontalLayoutProxy.NativeFieldInfoPtr_uiHorizontalLayout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHorizontalLayoutProxy>.NativeClassPtr, "uiHorizontalLayout");
			UIHorizontalLayoutProxy.NativeMethodInfoPtr__ctor_Public_Void_UIHorizontalLayout_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHorizontalLayoutProxy>.NativeClassPtr, 100673856);
		}

		// Token: 0x060042CD RID: 17101 RVA: 0x0012C07C File Offset: 0x0012A27C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIHorizontalLayoutProxy(UIHorizontalLayout target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIHorizontalLayoutProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIHorizontalLayoutProxy.NativeMethodInfoPtr__ctor_Public_Void_UIHorizontalLayout_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060042CE RID: 17102 RVA: 0x00018C41 File Offset: 0x00016E41
		public UIHorizontalLayoutProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001714 RID: 5908
		// (get) Token: 0x060042CF RID: 17103 RVA: 0x0012C0C8 File Offset: 0x0012A2C8
		// (set) Token: 0x060042D0 RID: 17104 RVA: 0x00018C4A File Offset: 0x00016E4A
		public unsafe UIHorizontalLayout uiHorizontalLayout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIHorizontalLayoutProxy.NativeFieldInfoPtr_uiHorizontalLayout);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIHorizontalLayout>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIHorizontalLayoutProxy.NativeFieldInfoPtr_uiHorizontalLayout), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400340B RID: 13323
		private static readonly IntPtr NativeFieldInfoPtr_uiHorizontalLayout;

		// Token: 0x0400340C RID: 13324
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UIHorizontalLayout_0;
	}
}
