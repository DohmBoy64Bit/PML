using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Polytoria.Controllers;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x02000302 RID: 770
	public class UIImageProxy : UIFieldProxy
	{
		// Token: 0x060042F0 RID: 17136 RVA: 0x0012CA28 File Offset: 0x0012AC28
		// Note: this type is marked as 'beforefieldinit'.
		static UIImageProxy()
		{
			Il2CppClassPointerStore<UIImageProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Proxies", "UIImageProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIImageProxy>.NativeClassPtr);
			UIImageProxy.NativeFieldInfoPtr_uiImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIImageProxy>.NativeClassPtr, "uiImage");
			UIImageProxy.NativeMethodInfoPtr_get_ImageID_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIImageProxy>.NativeClassPtr, 100673885);
			UIImageProxy.NativeMethodInfoPtr_set_ImageID_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIImageProxy>.NativeClassPtr, 100673886);
			UIImageProxy.NativeMethodInfoPtr_get_ImageType_Public_get_ImageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIImageProxy>.NativeClassPtr, 100673887);
			UIImageProxy.NativeMethodInfoPtr_set_ImageType_Public_set_Void_ImageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIImageProxy>.NativeClassPtr, 100673888);
			UIImageProxy.NativeMethodInfoPtr_get_Color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIImageProxy>.NativeClassPtr, 100673889);
			UIImageProxy.NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIImageProxy>.NativeClassPtr, 100673890);
			UIImageProxy.NativeMethodInfoPtr_get_Clickable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIImageProxy>.NativeClassPtr, 100673891);
			UIImageProxy.NativeMethodInfoPtr_set_Clickable_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIImageProxy>.NativeClassPtr, 100673892);
			UIImageProxy.NativeMethodInfoPtr_get_Loading_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIImageProxy>.NativeClassPtr, 100673893);
			UIImageProxy.NativeMethodInfoPtr__ctor_Public_Void_UIImage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIImageProxy>.NativeClassPtr, 100673884);
		}

		// Token: 0x17001724 RID: 5924
		// (get) Token: 0x060042F1 RID: 17137 RVA: 0x0012CB34 File Offset: 0x0012AD34
		// (set) Token: 0x060042F2 RID: 17138 RVA: 0x0012CB6C File Offset: 0x0012AD6C
		public unsafe string ImageID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIImageProxy.NativeMethodInfoPtr_get_ImageID_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129122, XrefRangeEnd = 129124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIImageProxy.NativeMethodInfoPtr_set_ImageID_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001725 RID: 5925
		// (get) Token: 0x060042F3 RID: 17139 RVA: 0x0012CBB0 File Offset: 0x0012ADB0
		// (set) Token: 0x060042F4 RID: 17140 RVA: 0x0012CBF0 File Offset: 0x0012ADF0
		public unsafe ImageType ImageType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIImageProxy.NativeMethodInfoPtr_get_ImageType_Public_get_ImageType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ImageType>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129124, XrefRangeEnd = 129126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIImageProxy.NativeMethodInfoPtr_set_ImageType_Public_set_Void_ImageType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001726 RID: 5926
		// (get) Token: 0x060042F5 RID: 17141 RVA: 0x0012CC34 File Offset: 0x0012AE34
		// (set) Token: 0x060042F6 RID: 17142 RVA: 0x0012CC74 File Offset: 0x0012AE74
		public unsafe Color Color
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIImageProxy.NativeMethodInfoPtr_get_Color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129126, XrefRangeEnd = 129127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIImageProxy.NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001727 RID: 5927
		// (get) Token: 0x060042F7 RID: 17143 RVA: 0x0012CCB8 File Offset: 0x0012AEB8
		// (set) Token: 0x060042F8 RID: 17144 RVA: 0x0012CCF4 File Offset: 0x0012AEF4
		public unsafe bool Clickable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIImageProxy.NativeMethodInfoPtr_get_Clickable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129127, XrefRangeEnd = 129129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIImageProxy.NativeMethodInfoPtr_set_Clickable_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001728 RID: 5928
		// (get) Token: 0x060042F9 RID: 17145 RVA: 0x0012CD34 File Offset: 0x0012AF34
		public unsafe bool Loading
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIImageProxy.NativeMethodInfoPtr_get_Loading_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060042FA RID: 17146 RVA: 0x0012CD70 File Offset: 0x0012AF70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIImageProxy(UIImage target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIImageProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIImageProxy.NativeMethodInfoPtr__ctor_Public_Void_UIImage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060042FB RID: 17147 RVA: 0x00018C91 File Offset: 0x00016E91
		public UIImageProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001723 RID: 5923
		// (get) Token: 0x060042FC RID: 17148 RVA: 0x0012CDBC File Offset: 0x0012AFBC
		// (set) Token: 0x060042FD RID: 17149 RVA: 0x00018C9A File Offset: 0x00016E9A
		public unsafe UIImage uiImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIImageProxy.NativeFieldInfoPtr_uiImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIImage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIImageProxy.NativeFieldInfoPtr_uiImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003429 RID: 13353
		private static readonly IntPtr NativeFieldInfoPtr_uiImage;

		// Token: 0x0400342A RID: 13354
		private static readonly IntPtr NativeMethodInfoPtr_get_ImageID_Public_get_String_0;

		// Token: 0x0400342B RID: 13355
		private static readonly IntPtr NativeMethodInfoPtr_set_ImageID_Public_set_Void_String_0;

		// Token: 0x0400342C RID: 13356
		private static readonly IntPtr NativeMethodInfoPtr_get_ImageType_Public_get_ImageType_0;

		// Token: 0x0400342D RID: 13357
		private static readonly IntPtr NativeMethodInfoPtr_set_ImageType_Public_set_Void_ImageType_0;

		// Token: 0x0400342E RID: 13358
		private static readonly IntPtr NativeMethodInfoPtr_get_Color_Public_get_Color_0;

		// Token: 0x0400342F RID: 13359
		private static readonly IntPtr NativeMethodInfoPtr_set_Color_Public_set_Void_Color_0;

		// Token: 0x04003430 RID: 13360
		private static readonly IntPtr NativeMethodInfoPtr_get_Clickable_Public_get_Boolean_0;

		// Token: 0x04003431 RID: 13361
		private static readonly IntPtr NativeMethodInfoPtr_set_Clickable_Public_set_Void_Boolean_0;

		// Token: 0x04003432 RID: 13362
		private static readonly IntPtr NativeMethodInfoPtr_get_Loading_Public_get_Boolean_0;

		// Token: 0x04003433 RID: 13363
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UIImage_0;
	}
}
