using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x02000306 RID: 774
	public class UIViewProxy : UIFieldProxy
	{
		// Token: 0x0600433D RID: 17213 RVA: 0x0012E010 File Offset: 0x0012C210
		// Note: this type is marked as 'beforefieldinit'.
		static UIViewProxy()
		{
			Il2CppClassPointerStore<UIViewProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Proxies", "UIViewProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIViewProxy>.NativeClassPtr);
			UIViewProxy.NativeFieldInfoPtr_uiView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIViewProxy>.NativeClassPtr, "uiView");
			UIViewProxy.NativeMethodInfoPtr_get_BorderColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIViewProxy>.NativeClassPtr, 100673946);
			UIViewProxy.NativeMethodInfoPtr_set_BorderColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIViewProxy>.NativeClassPtr, 100673947);
			UIViewProxy.NativeMethodInfoPtr_get_BorderWidth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIViewProxy>.NativeClassPtr, 100673948);
			UIViewProxy.NativeMethodInfoPtr_set_BorderWidth_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIViewProxy>.NativeClassPtr, 100673949);
			UIViewProxy.NativeMethodInfoPtr_get_Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIViewProxy>.NativeClassPtr, 100673950);
			UIViewProxy.NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIViewProxy>.NativeClassPtr, 100673951);
			UIViewProxy.NativeMethodInfoPtr_get_CornerRadius_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIViewProxy>.NativeClassPtr, 100673952);
			UIViewProxy.NativeMethodInfoPtr_set_CornerRadius_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIViewProxy>.NativeClassPtr, 100673953);
			UIViewProxy.NativeMethodInfoPtr__ctor_Public_Void_UIView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIViewProxy>.NativeClassPtr, 100673945);
		}

		// Token: 0x17001746 RID: 5958
		// (get) Token: 0x0600433E RID: 17214 RVA: 0x0012E108 File Offset: 0x0012C308
		// (set) Token: 0x0600433F RID: 17215 RVA: 0x0012E148 File Offset: 0x0012C348
		public unsafe Color BorderColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIViewProxy.NativeMethodInfoPtr_get_BorderColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129175, XrefRangeEnd = 129176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIViewProxy.NativeMethodInfoPtr_set_BorderColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001747 RID: 5959
		// (get) Token: 0x06004340 RID: 17216 RVA: 0x0012E18C File Offset: 0x0012C38C
		// (set) Token: 0x06004341 RID: 17217 RVA: 0x0012E1C8 File Offset: 0x0012C3C8
		public unsafe float BorderWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIViewProxy.NativeMethodInfoPtr_get_BorderWidth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129176, XrefRangeEnd = 129178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIViewProxy.NativeMethodInfoPtr_set_BorderWidth_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001748 RID: 5960
		// (get) Token: 0x06004342 RID: 17218 RVA: 0x0012E208 File Offset: 0x0012C408
		// (set) Token: 0x06004343 RID: 17219 RVA: 0x0012E248 File Offset: 0x0012C448
		public unsafe Color Color
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIViewProxy.NativeMethodInfoPtr_get_Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129178, XrefRangeEnd = 129179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIViewProxy.NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001749 RID: 5961
		// (get) Token: 0x06004344 RID: 17220 RVA: 0x0012E28C File Offset: 0x0012C48C
		// (set) Token: 0x06004345 RID: 17221 RVA: 0x0012E2C8 File Offset: 0x0012C4C8
		public unsafe float CornerRadius
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIViewProxy.NativeMethodInfoPtr_get_CornerRadius_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129179, XrefRangeEnd = 129181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIViewProxy.NativeMethodInfoPtr_set_CornerRadius_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06004346 RID: 17222 RVA: 0x0012E308 File Offset: 0x0012C508
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIViewProxy(UIView target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIViewProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIViewProxy.NativeMethodInfoPtr__ctor_Public_Void_UIView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004347 RID: 17223 RVA: 0x00018D31 File Offset: 0x00016F31
		public UIViewProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001745 RID: 5957
		// (get) Token: 0x06004348 RID: 17224 RVA: 0x0012E354 File Offset: 0x0012C554
		// (set) Token: 0x06004349 RID: 17225 RVA: 0x00018D3A File Offset: 0x00016F3A
		public unsafe UIView uiView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIViewProxy.NativeFieldInfoPtr_uiView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIViewProxy.NativeFieldInfoPtr_uiView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400346A RID: 13418
		private static readonly IntPtr NativeFieldInfoPtr_uiView;

		// Token: 0x0400346B RID: 13419
		private static readonly IntPtr NativeMethodInfoPtr_get_BorderColor_Public_get_Color_0;

		// Token: 0x0400346C RID: 13420
		private static readonly IntPtr NativeMethodInfoPtr_set_BorderColor_Public_set_Void_Color_0;

		// Token: 0x0400346D RID: 13421
		private static readonly IntPtr NativeMethodInfoPtr_get_BorderWidth_Public_get_Single_0;

		// Token: 0x0400346E RID: 13422
		private static readonly IntPtr NativeMethodInfoPtr_set_BorderWidth_Public_set_Void_Single_0;

		// Token: 0x0400346F RID: 13423
		private static readonly IntPtr NativeMethodInfoPtr_get_Color_Public_get_Color_0;

		// Token: 0x04003470 RID: 13424
		private static readonly IntPtr NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0;

		// Token: 0x04003471 RID: 13425
		private static readonly IntPtr NativeMethodInfoPtr_get_CornerRadius_Public_get_Single_0;

		// Token: 0x04003472 RID: 13426
		private static readonly IntPtr NativeMethodInfoPtr_set_CornerRadius_Public_set_Void_Single_0;

		// Token: 0x04003473 RID: 13427
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UIView_0;
	}
}
