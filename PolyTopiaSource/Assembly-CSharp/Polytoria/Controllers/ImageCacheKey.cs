using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Polytoria.Controllers
{
	// Token: 0x0200032C RID: 812
	public sealed class ImageCacheKey : ValueType
	{
		// Token: 0x060045AC RID: 17836 RVA: 0x001376B4 File Offset: 0x001358B4
		// Note: this type is marked as 'beforefieldinit'.
		static ImageCacheKey()
		{
			Il2CppClassPointerStore<ImageCacheKey>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Controllers", "ImageCacheKey");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImageCacheKey>.NativeClassPtr);
			ImageCacheKey.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageCacheKey>.NativeClassPtr, "id");
			ImageCacheKey.NativeFieldInfoPtr_url = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageCacheKey>.NativeClassPtr, "url");
			ImageCacheKey.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageCacheKey>.NativeClassPtr, "type");
			ImageCacheKey.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageCacheKey>.NativeClassPtr, 100674360);
			ImageCacheKey.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageCacheKey>.NativeClassPtr, 100674361);
		}

		// Token: 0x060045AD RID: 17837 RVA: 0x00137748 File Offset: 0x00135948
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 134884, RefRangeEnd = 134887, XrefRangeStart = 134879, XrefRangeEnd = 134884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageCacheKey.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060045AE RID: 17838 RVA: 0x0013779C File Offset: 0x0013599C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134887, XrefRangeEnd = 134888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageCacheKey.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060045AF RID: 17839 RVA: 0x00019B19 File Offset: 0x00017D19
		public ImageCacheKey(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060045B0 RID: 17840 RVA: 0x00019B22 File Offset: 0x00017D22
		public ImageCacheKey()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImageCacheKey>.NativeClassPtr))
		{
		}

		// Token: 0x170017E7 RID: 6119
		// (get) Token: 0x060045B1 RID: 17841 RVA: 0x001377E0 File Offset: 0x001359E0
		// (set) Token: 0x060045B2 RID: 17842 RVA: 0x00019B34 File Offset: 0x00017D34
		public unsafe string id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageCacheKey.NativeFieldInfoPtr_id);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageCacheKey.NativeFieldInfoPtr_id), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170017E8 RID: 6120
		// (get) Token: 0x060045B3 RID: 17843 RVA: 0x00137808 File Offset: 0x00135A08
		// (set) Token: 0x060045B4 RID: 17844 RVA: 0x00019B53 File Offset: 0x00017D53
		public unsafe string url
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageCacheKey.NativeFieldInfoPtr_url);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageCacheKey.NativeFieldInfoPtr_url), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170017E9 RID: 6121
		// (get) Token: 0x060045B5 RID: 17845 RVA: 0x00137830 File Offset: 0x00135A30
		// (set) Token: 0x060045B6 RID: 17846 RVA: 0x00019B72 File Offset: 0x00017D72
		public unsafe ImageType type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageCacheKey.NativeFieldInfoPtr_type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ImageType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageCacheKey.NativeFieldInfoPtr_type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400361D RID: 13853
		private static readonly IntPtr NativeFieldInfoPtr_id;

		// Token: 0x0400361E RID: 13854
		private static readonly IntPtr NativeFieldInfoPtr_url;

		// Token: 0x0400361F RID: 13855
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x04003620 RID: 13856
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04003621 RID: 13857
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
