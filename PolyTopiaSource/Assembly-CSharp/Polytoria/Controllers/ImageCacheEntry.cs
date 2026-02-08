using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Polytoria.Controllers
{
	// Token: 0x0200032B RID: 811
	public class ImageCacheEntry : global::Il2CppSystem.Object
	{
		// Token: 0x060045A3 RID: 17827 RVA: 0x00137578 File Offset: 0x00135778
		// Note: this type is marked as 'beforefieldinit'.
		static ImageCacheEntry()
		{
			Il2CppClassPointerStore<ImageCacheEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Controllers", "ImageCacheEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImageCacheEntry>.NativeClassPtr);
			ImageCacheEntry.NativeFieldInfoPtr_texture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageCacheEntry>.NativeClassPtr, "texture");
			ImageCacheEntry.NativeFieldInfoPtr_loaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageCacheEntry>.NativeClassPtr, "loaded");
			ImageCacheEntry.NativeFieldInfoPtr_hasTransparency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageCacheEntry>.NativeClassPtr, "hasTransparency");
			ImageCacheEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageCacheEntry>.NativeClassPtr, 100674359);
		}

		// Token: 0x060045A4 RID: 17828 RVA: 0x001375F8 File Offset: 0x001357F8
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ImageCacheEntry()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImageCacheEntry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageCacheEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045A5 RID: 17829 RVA: 0x00019ABB File Offset: 0x00017CBB
		public ImageCacheEntry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170017E4 RID: 6116
		// (get) Token: 0x060045A6 RID: 17830 RVA: 0x00137634 File Offset: 0x00135834
		// (set) Token: 0x060045A7 RID: 17831 RVA: 0x00019AC4 File Offset: 0x00017CC4
		public unsafe Texture2D texture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageCacheEntry.NativeFieldInfoPtr_texture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageCacheEntry.NativeFieldInfoPtr_texture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017E5 RID: 6117
		// (get) Token: 0x060045A8 RID: 17832 RVA: 0x00137664 File Offset: 0x00135864
		// (set) Token: 0x060045A9 RID: 17833 RVA: 0x00019AE3 File Offset: 0x00017CE3
		public unsafe bool loaded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageCacheEntry.NativeFieldInfoPtr_loaded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageCacheEntry.NativeFieldInfoPtr_loaded)) = value;
			}
		}

		// Token: 0x170017E6 RID: 6118
		// (get) Token: 0x060045AA RID: 17834 RVA: 0x0013768C File Offset: 0x0013588C
		// (set) Token: 0x060045AB RID: 17835 RVA: 0x00019AFE File Offset: 0x00017CFE
		public unsafe bool hasTransparency
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageCacheEntry.NativeFieldInfoPtr_hasTransparency);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageCacheEntry.NativeFieldInfoPtr_hasTransparency)) = value;
			}
		}

		// Token: 0x04003619 RID: 13849
		private static readonly IntPtr NativeFieldInfoPtr_texture;

		// Token: 0x0400361A RID: 13850
		private static readonly IntPtr NativeFieldInfoPtr_loaded;

		// Token: 0x0400361B RID: 13851
		private static readonly IntPtr NativeFieldInfoPtr_hasTransparency;

		// Token: 0x0400361C RID: 13852
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
