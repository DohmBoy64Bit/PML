using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Polytoria.Datamodel;
using UnityEngine;

namespace Polytoria.Controllers
{
	// Token: 0x02000331 RID: 817
	public class MaterialCache : MonoBehaviour
	{
		// Token: 0x06004606 RID: 17926 RVA: 0x00138424 File Offset: 0x00136624
		// Note: this type is marked as 'beforefieldinit'.
		static MaterialCache()
		{
			Il2CppClassPointerStore<MaterialCache>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Controllers", "MaterialCache");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialCache>.NativeClassPtr);
			MaterialCache.NativeFieldInfoPtr__Instance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialCache>.NativeClassPtr, "<Instance>k__BackingField");
			MaterialCache.NativeFieldInfoPtr_materials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialCache>.NativeClassPtr, "materials");
			MaterialCache.NativeMethodInfoPtr_get_Instance_Public_Static_get_MaterialCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialCache>.NativeClassPtr, 100674378);
			MaterialCache.NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_MaterialCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialCache>.NativeClassPtr, 100674379);
			MaterialCache.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialCache>.NativeClassPtr, 100674382);
			MaterialCache.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialCache>.NativeClassPtr, 100674380);
			MaterialCache.NativeMethodInfoPtr_GetMaterial_Public_Material_PartMaterial_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialCache>.NativeClassPtr, 100674381);
		}

		// Token: 0x1700180B RID: 6155
		// (get) Token: 0x06004607 RID: 17927 RVA: 0x001384E0 File Offset: 0x001366E0
		// (set) Token: 0x06004608 RID: 17928 RVA: 0x00138514 File Offset: 0x00136714
		public unsafe static MaterialCache Instance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135282, XrefRangeEnd = 135284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialCache.NativeMethodInfoPtr_get_Instance_Public_Static_get_MaterialCache_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MaterialCache>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135284, XrefRangeEnd = 135288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialCache.NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_MaterialCache_0, 0, (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06004609 RID: 17929 RVA: 0x0013854C File Offset: 0x0013674C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135288, XrefRangeEnd = 135296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MaterialCache()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialCache>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialCache.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600460A RID: 17930 RVA: 0x00138588 File Offset: 0x00136788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135296, XrefRangeEnd = 135300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialCache.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600460B RID: 17931 RVA: 0x001385BC File Offset: 0x001367BC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 135333, RefRangeEnd = 135336, XrefRangeStart = 135300, XrefRangeEnd = 135333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Material GetMaterial(PartMaterial material, bool isTransparent = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(material);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isTransparent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialCache.NativeMethodInfoPtr_GetMaterial_Public_Material_PartMaterial_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x0600460C RID: 17932 RVA: 0x00019E5F File Offset: 0x0001805F
		public MaterialCache(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001809 RID: 6153
		// (get) Token: 0x0600460D RID: 17933 RVA: 0x0013861C File Offset: 0x0013681C
		// (set) Token: 0x0600460E RID: 17934 RVA: 0x00019E68 File Offset: 0x00018068
		public unsafe static MaterialCache _Instance_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MaterialCache.NativeFieldInfoPtr__Instance_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MaterialCache>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MaterialCache.NativeFieldInfoPtr__Instance_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700180A RID: 6154
		// (get) Token: 0x0600460F RID: 17935 RVA: 0x00138644 File Offset: 0x00136844
		// (set) Token: 0x06004610 RID: 17936 RVA: 0x00019E7A File Offset: 0x0001807A
		public unsafe Dictionary<PartMaterial, MaterialCache.MaterialCacheEntry> materials
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialCache.NativeFieldInfoPtr_materials);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<PartMaterial, MaterialCache.MaterialCacheEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialCache.NativeFieldInfoPtr_materials), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400365A RID: 13914
		private static readonly IntPtr NativeFieldInfoPtr__Instance_k__BackingField;

		// Token: 0x0400365B RID: 13915
		private static readonly IntPtr NativeFieldInfoPtr_materials;

		// Token: 0x0400365C RID: 13916
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_MaterialCache_0;

		// Token: 0x0400365D RID: 13917
		private static readonly IntPtr NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_MaterialCache_0;

		// Token: 0x0400365E RID: 13918
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400365F RID: 13919
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04003660 RID: 13920
		private static readonly IntPtr NativeMethodInfoPtr_GetMaterial_Public_Material_PartMaterial_Boolean_0;

		// Token: 0x0200042F RID: 1071
		public sealed class MaterialCacheEntry : ValueType
		{
			// Token: 0x06005228 RID: 21032 RVA: 0x0015E444 File Offset: 0x0015C644
			// Note: this type is marked as 'beforefieldinit'.
			static MaterialCacheEntry()
			{
				Il2CppClassPointerStore<MaterialCache.MaterialCacheEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MaterialCache>.NativeClassPtr, "MaterialCacheEntry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialCache.MaterialCacheEntry>.NativeClassPtr);
				MaterialCache.MaterialCacheEntry.NativeFieldInfoPtr_Opaque = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialCache.MaterialCacheEntry>.NativeClassPtr, "Opaque");
				MaterialCache.MaterialCacheEntry.NativeFieldInfoPtr_Transparent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialCache.MaterialCacheEntry>.NativeClassPtr, "Transparent");
			}

			// Token: 0x06005229 RID: 21033 RVA: 0x0001FB0E File Offset: 0x0001DD0E
			public MaterialCacheEntry(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600522A RID: 21034 RVA: 0x0001FB17 File Offset: 0x0001DD17
			public MaterialCacheEntry()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialCache.MaterialCacheEntry>.NativeClassPtr))
			{
			}

			// Token: 0x17001BB9 RID: 7097
			// (get) Token: 0x0600522B RID: 21035 RVA: 0x0015E498 File Offset: 0x0015C698
			// (set) Token: 0x0600522C RID: 21036 RVA: 0x0001FB29 File Offset: 0x0001DD29
			public unsafe Material Opaque
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialCache.MaterialCacheEntry.NativeFieldInfoPtr_Opaque);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialCache.MaterialCacheEntry.NativeFieldInfoPtr_Opaque), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BBA RID: 7098
			// (get) Token: 0x0600522D RID: 21037 RVA: 0x0015E4C8 File Offset: 0x0015C6C8
			// (set) Token: 0x0600522E RID: 21038 RVA: 0x0001FB48 File Offset: 0x0001DD48
			public unsafe Material Transparent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialCache.MaterialCacheEntry.NativeFieldInfoPtr_Transparent);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialCache.MaterialCacheEntry.NativeFieldInfoPtr_Transparent), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003EFA RID: 16122
			private static readonly IntPtr NativeFieldInfoPtr_Opaque;

			// Token: 0x04003EFB RID: 16123
			private static readonly IntPtr NativeFieldInfoPtr_Transparent;
		}
	}
}
