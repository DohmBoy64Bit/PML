using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002DD RID: 733
	public class ImageSkyProxy : SkyBaseProxy
	{
		// Token: 0x06004064 RID: 16484 RVA: 0x00121198 File Offset: 0x0011F398
		// Note: this type is marked as 'beforefieldinit'.
		static ImageSkyProxy()
		{
			Il2CppClassPointerStore<ImageSkyProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Proxies", "ImageSkyProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImageSkyProxy>.NativeClassPtr);
			ImageSkyProxy.NativeFieldInfoPtr_imageSky = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageSkyProxy>.NativeClassPtr, "imageSky");
			ImageSkyProxy.NativeMethodInfoPtr_get_TopId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSkyProxy>.NativeClassPtr, 100673381);
			ImageSkyProxy.NativeMethodInfoPtr_set_TopId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSkyProxy>.NativeClassPtr, 100673382);
			ImageSkyProxy.NativeMethodInfoPtr_get_BottomId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSkyProxy>.NativeClassPtr, 100673383);
			ImageSkyProxy.NativeMethodInfoPtr_set_BottomId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSkyProxy>.NativeClassPtr, 100673384);
			ImageSkyProxy.NativeMethodInfoPtr_get_LeftId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSkyProxy>.NativeClassPtr, 100673385);
			ImageSkyProxy.NativeMethodInfoPtr_set_LeftId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSkyProxy>.NativeClassPtr, 100673386);
			ImageSkyProxy.NativeMethodInfoPtr_get_RightId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSkyProxy>.NativeClassPtr, 100673387);
			ImageSkyProxy.NativeMethodInfoPtr_set_RightId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSkyProxy>.NativeClassPtr, 100673388);
			ImageSkyProxy.NativeMethodInfoPtr_get_FrontId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSkyProxy>.NativeClassPtr, 100673389);
			ImageSkyProxy.NativeMethodInfoPtr_set_FrontId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSkyProxy>.NativeClassPtr, 100673390);
			ImageSkyProxy.NativeMethodInfoPtr_get_BackId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSkyProxy>.NativeClassPtr, 100673391);
			ImageSkyProxy.NativeMethodInfoPtr_set_BackId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSkyProxy>.NativeClassPtr, 100673392);
			ImageSkyProxy.NativeMethodInfoPtr__ctor_Public_Void_ImageSky_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageSkyProxy>.NativeClassPtr, 100673380);
		}

		// Token: 0x17001620 RID: 5664
		// (get) Token: 0x06004065 RID: 16485 RVA: 0x001212E0 File Offset: 0x0011F4E0
		// (set) Token: 0x06004066 RID: 16486 RVA: 0x0012131C File Offset: 0x0011F51C
		public unsafe int TopId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageSkyProxy.NativeMethodInfoPtr_get_TopId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128579, XrefRangeEnd = 128581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageSkyProxy.NativeMethodInfoPtr_set_TopId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001621 RID: 5665
		// (get) Token: 0x06004067 RID: 16487 RVA: 0x0012135C File Offset: 0x0011F55C
		// (set) Token: 0x06004068 RID: 16488 RVA: 0x00121398 File Offset: 0x0011F598
		public unsafe int BottomId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageSkyProxy.NativeMethodInfoPtr_get_BottomId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128581, XrefRangeEnd = 128583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageSkyProxy.NativeMethodInfoPtr_set_BottomId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001622 RID: 5666
		// (get) Token: 0x06004069 RID: 16489 RVA: 0x001213D8 File Offset: 0x0011F5D8
		// (set) Token: 0x0600406A RID: 16490 RVA: 0x00121414 File Offset: 0x0011F614
		public unsafe int LeftId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageSkyProxy.NativeMethodInfoPtr_get_LeftId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128583, XrefRangeEnd = 128585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageSkyProxy.NativeMethodInfoPtr_set_LeftId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001623 RID: 5667
		// (get) Token: 0x0600406B RID: 16491 RVA: 0x00121454 File Offset: 0x0011F654
		// (set) Token: 0x0600406C RID: 16492 RVA: 0x00121490 File Offset: 0x0011F690
		public unsafe int RightId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageSkyProxy.NativeMethodInfoPtr_get_RightId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128585, XrefRangeEnd = 128587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageSkyProxy.NativeMethodInfoPtr_set_RightId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001624 RID: 5668
		// (get) Token: 0x0600406D RID: 16493 RVA: 0x001214D0 File Offset: 0x0011F6D0
		// (set) Token: 0x0600406E RID: 16494 RVA: 0x0012150C File Offset: 0x0011F70C
		public unsafe int FrontId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageSkyProxy.NativeMethodInfoPtr_get_FrontId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128587, XrefRangeEnd = 128589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageSkyProxy.NativeMethodInfoPtr_set_FrontId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001625 RID: 5669
		// (get) Token: 0x0600406F RID: 16495 RVA: 0x0012154C File Offset: 0x0011F74C
		// (set) Token: 0x06004070 RID: 16496 RVA: 0x00121588 File Offset: 0x0011F788
		public unsafe int BackId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageSkyProxy.NativeMethodInfoPtr_get_BackId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128589, XrefRangeEnd = 128591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageSkyProxy.NativeMethodInfoPtr_set_BackId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06004071 RID: 16497 RVA: 0x001215C8 File Offset: 0x0011F7C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ImageSkyProxy(ImageSky target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImageSkyProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageSkyProxy.NativeMethodInfoPtr__ctor_Public_Void_ImageSky_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004072 RID: 16498 RVA: 0x000186C9 File Offset: 0x000168C9
		public ImageSkyProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700161F RID: 5663
		// (get) Token: 0x06004073 RID: 16499 RVA: 0x00121614 File Offset: 0x0011F814
		// (set) Token: 0x06004074 RID: 16500 RVA: 0x000186D2 File Offset: 0x000168D2
		public unsafe ImageSky imageSky
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageSkyProxy.NativeFieldInfoPtr_imageSky);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ImageSky>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageSkyProxy.NativeFieldInfoPtr_imageSky), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400320C RID: 12812
		private static readonly IntPtr NativeFieldInfoPtr_imageSky;

		// Token: 0x0400320D RID: 12813
		private static readonly IntPtr NativeMethodInfoPtr_get_TopId_Public_get_Int32_0;

		// Token: 0x0400320E RID: 12814
		private static readonly IntPtr NativeMethodInfoPtr_set_TopId_Public_set_Void_Int32_0;

		// Token: 0x0400320F RID: 12815
		private static readonly IntPtr NativeMethodInfoPtr_get_BottomId_Public_get_Int32_0;

		// Token: 0x04003210 RID: 12816
		private static readonly IntPtr NativeMethodInfoPtr_set_BottomId_Public_set_Void_Int32_0;

		// Token: 0x04003211 RID: 12817
		private static readonly IntPtr NativeMethodInfoPtr_get_LeftId_Public_get_Int32_0;

		// Token: 0x04003212 RID: 12818
		private static readonly IntPtr NativeMethodInfoPtr_set_LeftId_Public_set_Void_Int32_0;

		// Token: 0x04003213 RID: 12819
		private static readonly IntPtr NativeMethodInfoPtr_get_RightId_Public_get_Int32_0;

		// Token: 0x04003214 RID: 12820
		private static readonly IntPtr NativeMethodInfoPtr_set_RightId_Public_set_Void_Int32_0;

		// Token: 0x04003215 RID: 12821
		private static readonly IntPtr NativeMethodInfoPtr_get_FrontId_Public_get_Int32_0;

		// Token: 0x04003216 RID: 12822
		private static readonly IntPtr NativeMethodInfoPtr_set_FrontId_Public_set_Void_Int32_0;

		// Token: 0x04003217 RID: 12823
		private static readonly IntPtr NativeMethodInfoPtr_get_BackId_Public_get_Int32_0;

		// Token: 0x04003218 RID: 12824
		private static readonly IntPtr NativeMethodInfoPtr_set_BackId_Public_set_Void_Int32_0;

		// Token: 0x04003219 RID: 12825
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ImageSky_0;
	}
}
