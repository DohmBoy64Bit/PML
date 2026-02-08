using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

namespace Polytoria.Controllers
{
	// Token: 0x0200032A RID: 810
	public class ImageCacheController : MonoBehaviour
	{
		// Token: 0x0600458F RID: 17807 RVA: 0x00137144 File Offset: 0x00135344
		// Note: this type is marked as 'beforefieldinit'.
		static ImageCacheController()
		{
			Il2CppClassPointerStore<ImageCacheController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Controllers", "ImageCacheController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImageCacheController>.NativeClassPtr);
			ImageCacheController.NativeFieldInfoPtr__Instance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageCacheController>.NativeClassPtr, "<Instance>k__BackingField");
			ImageCacheController.NativeFieldInfoPtr_cache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageCacheController>.NativeClassPtr, "cache");
			ImageCacheController.NativeFieldInfoPtr_loadQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageCacheController>.NativeClassPtr, "loadQueue");
			ImageCacheController.NativeFieldInfoPtr_fallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageCacheController>.NativeClassPtr, "fallback");
			ImageCacheController.NativeFieldInfoPtr_loading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageCacheController>.NativeClassPtr, "loading");
			ImageCacheController.NativeMethodInfoPtr_get_Instance_Public_Static_get_ImageCacheController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageCacheController>.NativeClassPtr, 100674333);
			ImageCacheController.NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_ImageCacheController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageCacheController>.NativeClassPtr, 100674334);
			ImageCacheController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageCacheController>.NativeClassPtr, 100674340);
			ImageCacheController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageCacheController>.NativeClassPtr, 100674335);
			ImageCacheController.NativeMethodInfoPtr_GetImage_Public_Void_ImageCacheKey_Action_2_ImageCacheKey_ImageCacheEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageCacheController>.NativeClassPtr, 100674336);
			ImageCacheController.NativeMethodInfoPtr_WaitForImage_Private_IEnumerator_ImageCacheKey_Action_2_ImageCacheKey_ImageCacheEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageCacheController>.NativeClassPtr, 100674337);
			ImageCacheController.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageCacheController>.NativeClassPtr, 100674338);
			ImageCacheController.NativeMethodInfoPtr_LoadImage_Private_IEnumerator_ImageCacheKey_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageCacheController>.NativeClassPtr, 100674339);
		}

		// Token: 0x170017E3 RID: 6115
		// (get) Token: 0x06004590 RID: 17808 RVA: 0x00137278 File Offset: 0x00135478
		// (set) Token: 0x06004591 RID: 17809 RVA: 0x001372AC File Offset: 0x001354AC
		public unsafe static ImageCacheController Instance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134766, XrefRangeEnd = 134770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageCacheController.NativeMethodInfoPtr_get_Instance_Public_Static_get_ImageCacheController_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ImageCacheController>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134770, XrefRangeEnd = 134776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageCacheController.NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_ImageCacheController_0, 0, (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06004592 RID: 17810 RVA: 0x001372E4 File Offset: 0x001354E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134776, XrefRangeEnd = 134784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ImageCacheController()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImageCacheController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageCacheController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004593 RID: 17811 RVA: 0x00137320 File Offset: 0x00135520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134784, XrefRangeEnd = 134814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageCacheController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004594 RID: 17812 RVA: 0x00137354 File Offset: 0x00135554
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 134842, RefRangeEnd = 134852, XrefRangeStart = 134814, XrefRangeEnd = 134842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetImage(ImageCacheKey key, Action<ImageCacheKey, ImageCacheEntry> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageCacheController.NativeMethodInfoPtr_GetImage_Public_Void_ImageCacheKey_Action_2_ImageCacheKey_ImageCacheEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004595 RID: 17813 RVA: 0x001373A8 File Offset: 0x001355A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134852, XrefRangeEnd = 134859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator WaitForImage(ImageCacheKey key, Action<ImageCacheKey, ImageCacheEntry> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageCacheController.NativeMethodInfoPtr_WaitForImage_Private_IEnumerator_ImageCacheKey_Action_2_ImageCacheKey_ImageCacheEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004596 RID: 17814 RVA: 0x0013740C File Offset: 0x0013560C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134859, XrefRangeEnd = 134870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageCacheController.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004597 RID: 17815 RVA: 0x00137440 File Offset: 0x00135640
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 134876, RefRangeEnd = 134879, XrefRangeStart = 134870, XrefRangeEnd = 134876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator LoadImage(ImageCacheKey key, int tries = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tries;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageCacheController.NativeMethodInfoPtr_LoadImage_Private_IEnumerator_ImageCacheKey_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004598 RID: 17816 RVA: 0x00019A35 File Offset: 0x00017C35
		public ImageCacheController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170017DE RID: 6110
		// (get) Token: 0x06004599 RID: 17817 RVA: 0x001374A0 File Offset: 0x001356A0
		// (set) Token: 0x0600459A RID: 17818 RVA: 0x00019A3E File Offset: 0x00017C3E
		public unsafe static ImageCacheController _Instance_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ImageCacheController.NativeFieldInfoPtr__Instance_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ImageCacheController>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ImageCacheController.NativeFieldInfoPtr__Instance_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017DF RID: 6111
		// (get) Token: 0x0600459B RID: 17819 RVA: 0x001374C8 File Offset: 0x001356C8
		// (set) Token: 0x0600459C RID: 17820 RVA: 0x00019A50 File Offset: 0x00017C50
		public unsafe static Dictionary<ImageCacheKey, ImageCacheEntry> cache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ImageCacheController.NativeFieldInfoPtr_cache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<ImageCacheKey, ImageCacheEntry>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ImageCacheController.NativeFieldInfoPtr_cache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017E0 RID: 6112
		// (get) Token: 0x0600459D RID: 17821 RVA: 0x001374F0 File Offset: 0x001356F0
		// (set) Token: 0x0600459E RID: 17822 RVA: 0x00019A62 File Offset: 0x00017C62
		public unsafe Queue<ImageCacheKey> loadQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageCacheController.NativeFieldInfoPtr_loadQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<ImageCacheKey>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageCacheController.NativeFieldInfoPtr_loadQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017E1 RID: 6113
		// (get) Token: 0x0600459F RID: 17823 RVA: 0x00137520 File Offset: 0x00135720
		// (set) Token: 0x060045A0 RID: 17824 RVA: 0x00019A81 File Offset: 0x00017C81
		public unsafe Texture2D fallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageCacheController.NativeFieldInfoPtr_fallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageCacheController.NativeFieldInfoPtr_fallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017E2 RID: 6114
		// (get) Token: 0x060045A1 RID: 17825 RVA: 0x00137550 File Offset: 0x00135750
		// (set) Token: 0x060045A2 RID: 17826 RVA: 0x00019AA0 File Offset: 0x00017CA0
		public unsafe bool loading
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageCacheController.NativeFieldInfoPtr_loading);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageCacheController.NativeFieldInfoPtr_loading)) = value;
			}
		}

		// Token: 0x0400360C RID: 13836
		private static readonly IntPtr NativeFieldInfoPtr__Instance_k__BackingField;

		// Token: 0x0400360D RID: 13837
		private static readonly IntPtr NativeFieldInfoPtr_cache;

		// Token: 0x0400360E RID: 13838
		private static readonly IntPtr NativeFieldInfoPtr_loadQueue;

		// Token: 0x0400360F RID: 13839
		private static readonly IntPtr NativeFieldInfoPtr_fallback;

		// Token: 0x04003610 RID: 13840
		private static readonly IntPtr NativeFieldInfoPtr_loading;

		// Token: 0x04003611 RID: 13841
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_ImageCacheController_0;

		// Token: 0x04003612 RID: 13842
		private static readonly IntPtr NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_ImageCacheController_0;

		// Token: 0x04003613 RID: 13843
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003614 RID: 13844
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04003615 RID: 13845
		private static readonly IntPtr NativeMethodInfoPtr_GetImage_Public_Void_ImageCacheKey_Action_2_ImageCacheKey_ImageCacheEntry_0;

		// Token: 0x04003616 RID: 13846
		private static readonly IntPtr NativeMethodInfoPtr_WaitForImage_Private_IEnumerator_ImageCacheKey_Action_2_ImageCacheKey_ImageCacheEntry_0;

		// Token: 0x04003617 RID: 13847
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04003618 RID: 13848
		private static readonly IntPtr NativeMethodInfoPtr_LoadImage_Private_IEnumerator_ImageCacheKey_Int32_0;

		// Token: 0x0200042C RID: 1068
		[ObfuscatedName("Polytoria.Controllers.ImageCacheController+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x060051F4 RID: 20980 RVA: 0x0015DAF0 File Offset: 0x0015BCF0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ImageCacheController.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ImageCacheController>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImageCacheController.__c>.NativeClassPtr);
				ImageCacheController.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageCacheController.__c>.NativeClassPtr, "<>9");
				ImageCacheController.__c.NativeFieldInfoPtr___9__12_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageCacheController.__c>.NativeClassPtr, "<>9__12_0");
				ImageCacheController.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageCacheController.__c>.NativeClassPtr, 100674343);
				ImageCacheController.__c.NativeMethodInfoPtr__LoadImage_b__12_0_Internal_Boolean_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageCacheController.__c>.NativeClassPtr, 100674344);
			}

			// Token: 0x060051F5 RID: 20981 RVA: 0x0015DB6C File Offset: 0x0015BD6C
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImageCacheController.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageCacheController.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060051F6 RID: 20982 RVA: 0x0015DBA8 File Offset: 0x0015BDA8
			[CallerCount(0)]
			public unsafe bool _LoadImage_b__12_0(Color32 c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageCacheController.__c.NativeMethodInfoPtr__LoadImage_b__12_0_Internal_Boolean_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060051F7 RID: 20983 RVA: 0x0001F94C File Offset: 0x0001DB4C
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001BA6 RID: 7078
			// (get) Token: 0x060051F8 RID: 20984 RVA: 0x0015DBF8 File Offset: 0x0015BDF8
			// (set) Token: 0x060051F9 RID: 20985 RVA: 0x0001F955 File Offset: 0x0001DB55
			public unsafe static ImageCacheController.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ImageCacheController.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ImageCacheController.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ImageCacheController.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BA7 RID: 7079
			// (get) Token: 0x060051FA RID: 20986 RVA: 0x0015DC20 File Offset: 0x0015BE20
			// (set) Token: 0x060051FB RID: 20987 RVA: 0x0001F967 File Offset: 0x0001DB67
			public unsafe static Func<Color32, bool> __9__12_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ImageCacheController.__c.NativeFieldInfoPtr___9__12_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Color32, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ImageCacheController.__c.NativeFieldInfoPtr___9__12_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003EDB RID: 16091
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04003EDC RID: 16092
			private static readonly IntPtr NativeFieldInfoPtr___9__12_0;

			// Token: 0x04003EDD RID: 16093
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003EDE RID: 16094
			private static readonly IntPtr NativeMethodInfoPtr__LoadImage_b__12_0_Internal_Boolean_Color32_0;
		}

		// Token: 0x0200042D RID: 1069
		[ObfuscatedName("Polytoria.Controllers.ImageCacheController+<LoadImage>d__12")]
		public sealed class _LoadImage_d__12 : global::Il2CppSystem.Object
		{
			// Token: 0x060051FC RID: 20988 RVA: 0x0015DC48 File Offset: 0x0015BE48
			// Note: this type is marked as 'beforefieldinit'.
			static _LoadImage_d__12()
			{
				Il2CppClassPointerStore<ImageCacheController._LoadImage_d__12>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ImageCacheController>.NativeClassPtr, "<LoadImage>d__12");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImageCacheController._LoadImage_d__12>.NativeClassPtr);
				ImageCacheController._LoadImage_d__12.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageCacheController._LoadImage_d__12>.NativeClassPtr, "<>1__state");
				ImageCacheController._LoadImage_d__12.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageCacheController._LoadImage_d__12>.NativeClassPtr, "<>2__current");
				ImageCacheController._LoadImage_d__12.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageCacheController._LoadImage_d__12>.NativeClassPtr, "key");
				ImageCacheController._LoadImage_d__12.NativeFieldInfoPtr_tries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageCacheController._LoadImage_d__12>.NativeClassPtr, "tries");
				ImageCacheController._LoadImage_d__12.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageCacheController._LoadImage_d__12>.NativeClassPtr, "<>4__this");
				ImageCacheController._LoadImage_d__12.NativeFieldInfoPtr__url_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageCacheController._LoadImage_d__12>.NativeClassPtr, "<url>5__2");
				ImageCacheController._LoadImage_d__12.NativeFieldInfoPtr__uwr_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageCacheController._LoadImage_d__12>.NativeClassPtr, "<uwr>5__3");
				ImageCacheController._LoadImage_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageCacheController._LoadImage_d__12>.NativeClassPtr, 100674350);
				ImageCacheController._LoadImage_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageCacheController._LoadImage_d__12>.NativeClassPtr, 100674352);
				ImageCacheController._LoadImage_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageCacheController._LoadImage_d__12>.NativeClassPtr, 100674345);
				ImageCacheController._LoadImage_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageCacheController._LoadImage_d__12>.NativeClassPtr, 100674346);
				ImageCacheController._LoadImage_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageCacheController._LoadImage_d__12>.NativeClassPtr, 100674347);
				ImageCacheController._LoadImage_d__12.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageCacheController._LoadImage_d__12>.NativeClassPtr, 100674348);
				ImageCacheController._LoadImage_d__12.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageCacheController._LoadImage_d__12>.NativeClassPtr, 100674349);
				ImageCacheController._LoadImage_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageCacheController._LoadImage_d__12>.NativeClassPtr, 100674351);
			}

			// Token: 0x17001BAF RID: 7087
			// (get) Token: 0x060051FD RID: 20989 RVA: 0x0015DDA0 File Offset: 0x0015BFA0
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageCacheController._LoadImage_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001BB0 RID: 7088
			// (get) Token: 0x060051FE RID: 20990 RVA: 0x0015DDE0 File Offset: 0x0015BFE0
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageCacheController._LoadImage_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060051FF RID: 20991 RVA: 0x0015DE20 File Offset: 0x0015C020
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 10168, RefRangeEnd = 10216, XrefRangeStart = 10168, XrefRangeEnd = 10216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _LoadImage_d__12(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImageCacheController._LoadImage_d__12>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageCacheController._LoadImage_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005200 RID: 20992 RVA: 0x0015DE68 File Offset: 0x0015C068
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134574, XrefRangeEnd = 134584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageCacheController._LoadImage_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005201 RID: 20993 RVA: 0x0015DE9C File Offset: 0x0015C09C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134584, XrefRangeEnd = 134736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageCacheController._LoadImage_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005202 RID: 20994 RVA: 0x0015DED8 File Offset: 0x0015C0D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134736, XrefRangeEnd = 134739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageCacheController._LoadImage_d__12.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005203 RID: 20995 RVA: 0x0015DF0C File Offset: 0x0015C10C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134739, XrefRangeEnd = 134742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageCacheController._LoadImage_d__12.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005204 RID: 20996 RVA: 0x0015DF40 File Offset: 0x0015C140
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134742, XrefRangeEnd = 134747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageCacheController._LoadImage_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005205 RID: 20997 RVA: 0x0001F979 File Offset: 0x0001DB79
			public _LoadImage_d__12(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001BA8 RID: 7080
			// (get) Token: 0x06005206 RID: 20998 RVA: 0x0015DF74 File Offset: 0x0015C174
			// (set) Token: 0x06005207 RID: 20999 RVA: 0x0001F982 File Offset: 0x0001DB82
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageCacheController._LoadImage_d__12.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageCacheController._LoadImage_d__12.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001BA9 RID: 7081
			// (get) Token: 0x06005208 RID: 21000 RVA: 0x0015DF9C File Offset: 0x0015C19C
			// (set) Token: 0x06005209 RID: 21001 RVA: 0x0001F99D File Offset: 0x0001DB9D
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageCacheController._LoadImage_d__12.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageCacheController._LoadImage_d__12.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BAA RID: 7082
			// (get) Token: 0x0600520A RID: 21002 RVA: 0x0015DFCC File Offset: 0x0015C1CC
			// (set) Token: 0x0600520B RID: 21003 RVA: 0x0001F9BC File Offset: 0x0001DBBC
			public unsafe ImageCacheKey key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageCacheController._LoadImage_d__12.NativeFieldInfoPtr_key);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ImageCacheKey>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageCacheController._LoadImage_d__12.NativeFieldInfoPtr_key), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BAB RID: 7083
			// (get) Token: 0x0600520C RID: 21004 RVA: 0x0015DFFC File Offset: 0x0015C1FC
			// (set) Token: 0x0600520D RID: 21005 RVA: 0x0001F9DB File Offset: 0x0001DBDB
			public unsafe int tries
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageCacheController._LoadImage_d__12.NativeFieldInfoPtr_tries);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageCacheController._LoadImage_d__12.NativeFieldInfoPtr_tries)) = value;
				}
			}

			// Token: 0x17001BAC RID: 7084
			// (get) Token: 0x0600520E RID: 21006 RVA: 0x0015E024 File Offset: 0x0015C224
			// (set) Token: 0x0600520F RID: 21007 RVA: 0x0001F9F6 File Offset: 0x0001DBF6
			public unsafe ImageCacheController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageCacheController._LoadImage_d__12.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ImageCacheController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageCacheController._LoadImage_d__12.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BAD RID: 7085
			// (get) Token: 0x06005210 RID: 21008 RVA: 0x0015E054 File Offset: 0x0015C254
			// (set) Token: 0x06005211 RID: 21009 RVA: 0x0001FA15 File Offset: 0x0001DC15
			public unsafe string _url_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageCacheController._LoadImage_d__12.NativeFieldInfoPtr__url_5__2);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageCacheController._LoadImage_d__12.NativeFieldInfoPtr__url_5__2), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001BAE RID: 7086
			// (get) Token: 0x06005212 RID: 21010 RVA: 0x0015E07C File Offset: 0x0015C27C
			// (set) Token: 0x06005213 RID: 21011 RVA: 0x0001FA34 File Offset: 0x0001DC34
			public unsafe UnityWebRequest _uwr_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageCacheController._LoadImage_d__12.NativeFieldInfoPtr__uwr_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageCacheController._LoadImage_d__12.NativeFieldInfoPtr__uwr_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003EDF RID: 16095
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003EE0 RID: 16096
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003EE1 RID: 16097
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x04003EE2 RID: 16098
			private static readonly IntPtr NativeFieldInfoPtr_tries;

			// Token: 0x04003EE3 RID: 16099
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003EE4 RID: 16100
			private static readonly IntPtr NativeFieldInfoPtr__url_5__2;

			// Token: 0x04003EE5 RID: 16101
			private static readonly IntPtr NativeFieldInfoPtr__uwr_5__3;

			// Token: 0x04003EE6 RID: 16102
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003EE7 RID: 16103
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003EE8 RID: 16104
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003EE9 RID: 16105
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003EEA RID: 16106
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003EEB RID: 16107
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04003EEC RID: 16108
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x04003EED RID: 16109
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}

		// Token: 0x0200042E RID: 1070
		[ObfuscatedName("Polytoria.Controllers.ImageCacheController+<WaitForImage>d__10")]
		public sealed class _WaitForImage_d__10 : global::Il2CppSystem.Object
		{
			// Token: 0x06005214 RID: 21012 RVA: 0x0015E0AC File Offset: 0x0015C2AC
			// Note: this type is marked as 'beforefieldinit'.
			static _WaitForImage_d__10()
			{
				Il2CppClassPointerStore<ImageCacheController._WaitForImage_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ImageCacheController>.NativeClassPtr, "<WaitForImage>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImageCacheController._WaitForImage_d__10>.NativeClassPtr);
				ImageCacheController._WaitForImage_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageCacheController._WaitForImage_d__10>.NativeClassPtr, "<>1__state");
				ImageCacheController._WaitForImage_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageCacheController._WaitForImage_d__10>.NativeClassPtr, "<>2__current");
				ImageCacheController._WaitForImage_d__10.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageCacheController._WaitForImage_d__10>.NativeClassPtr, "callback");
				ImageCacheController._WaitForImage_d__10.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageCacheController._WaitForImage_d__10>.NativeClassPtr, "key");
				ImageCacheController._WaitForImage_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageCacheController._WaitForImage_d__10>.NativeClassPtr, "<>4__this");
				ImageCacheController._WaitForImage_d__10.NativeFieldInfoPtr__time_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImageCacheController._WaitForImage_d__10>.NativeClassPtr, "<time>5__2");
				ImageCacheController._WaitForImage_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageCacheController._WaitForImage_d__10>.NativeClassPtr, 100674356);
				ImageCacheController._WaitForImage_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageCacheController._WaitForImage_d__10>.NativeClassPtr, 100674358);
				ImageCacheController._WaitForImage_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageCacheController._WaitForImage_d__10>.NativeClassPtr, 100674353);
				ImageCacheController._WaitForImage_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageCacheController._WaitForImage_d__10>.NativeClassPtr, 100674354);
				ImageCacheController._WaitForImage_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageCacheController._WaitForImage_d__10>.NativeClassPtr, 100674355);
				ImageCacheController._WaitForImage_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImageCacheController._WaitForImage_d__10>.NativeClassPtr, 100674357);
			}

			// Token: 0x17001BB7 RID: 7095
			// (get) Token: 0x06005215 RID: 21013 RVA: 0x0015E1C8 File Offset: 0x0015C3C8
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageCacheController._WaitForImage_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001BB8 RID: 7096
			// (get) Token: 0x06005216 RID: 21014 RVA: 0x0015E208 File Offset: 0x0015C408
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageCacheController._WaitForImage_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005217 RID: 21015 RVA: 0x0015E248 File Offset: 0x0015C448
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 10168, RefRangeEnd = 10216, XrefRangeStart = 10168, XrefRangeEnd = 10216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _WaitForImage_d__10(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImageCacheController._WaitForImage_d__10>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageCacheController._WaitForImage_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005218 RID: 21016 RVA: 0x0015E290 File Offset: 0x0015C490
			[CallerCount(7535)]
			[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageCacheController._WaitForImage_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005219 RID: 21017 RVA: 0x0015E2C4 File Offset: 0x0015C4C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134747, XrefRangeEnd = 134758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageCacheController._WaitForImage_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600521A RID: 21018 RVA: 0x0015E300 File Offset: 0x0015C500
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134758, XrefRangeEnd = 134766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImageCacheController._WaitForImage_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600521B RID: 21019 RVA: 0x0001FA53 File Offset: 0x0001DC53
			public _WaitForImage_d__10(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001BB1 RID: 7089
			// (get) Token: 0x0600521C RID: 21020 RVA: 0x0015E334 File Offset: 0x0015C534
			// (set) Token: 0x0600521D RID: 21021 RVA: 0x0001FA5C File Offset: 0x0001DC5C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageCacheController._WaitForImage_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageCacheController._WaitForImage_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001BB2 RID: 7090
			// (get) Token: 0x0600521E RID: 21022 RVA: 0x0015E35C File Offset: 0x0015C55C
			// (set) Token: 0x0600521F RID: 21023 RVA: 0x0001FA77 File Offset: 0x0001DC77
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageCacheController._WaitForImage_d__10.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageCacheController._WaitForImage_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BB3 RID: 7091
			// (get) Token: 0x06005220 RID: 21024 RVA: 0x0015E38C File Offset: 0x0015C58C
			// (set) Token: 0x06005221 RID: 21025 RVA: 0x0001FA96 File Offset: 0x0001DC96
			public unsafe Action<ImageCacheKey, ImageCacheEntry> callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageCacheController._WaitForImage_d__10.NativeFieldInfoPtr_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ImageCacheKey, ImageCacheEntry>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageCacheController._WaitForImage_d__10.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BB4 RID: 7092
			// (get) Token: 0x06005222 RID: 21026 RVA: 0x0015E3BC File Offset: 0x0015C5BC
			// (set) Token: 0x06005223 RID: 21027 RVA: 0x0001FAB5 File Offset: 0x0001DCB5
			public unsafe ImageCacheKey key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageCacheController._WaitForImage_d__10.NativeFieldInfoPtr_key);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ImageCacheKey>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageCacheController._WaitForImage_d__10.NativeFieldInfoPtr_key), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BB5 RID: 7093
			// (get) Token: 0x06005224 RID: 21028 RVA: 0x0015E3EC File Offset: 0x0015C5EC
			// (set) Token: 0x06005225 RID: 21029 RVA: 0x0001FAD4 File Offset: 0x0001DCD4
			public unsafe ImageCacheController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageCacheController._WaitForImage_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ImageCacheController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageCacheController._WaitForImage_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BB6 RID: 7094
			// (get) Token: 0x06005226 RID: 21030 RVA: 0x0015E41C File Offset: 0x0015C61C
			// (set) Token: 0x06005227 RID: 21031 RVA: 0x0001FAF3 File Offset: 0x0001DCF3
			public unsafe float _time_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageCacheController._WaitForImage_d__10.NativeFieldInfoPtr__time_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImageCacheController._WaitForImage_d__10.NativeFieldInfoPtr__time_5__2)) = value;
				}
			}

			// Token: 0x04003EEE RID: 16110
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003EEF RID: 16111
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003EF0 RID: 16112
			private static readonly IntPtr NativeFieldInfoPtr_callback;

			// Token: 0x04003EF1 RID: 16113
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x04003EF2 RID: 16114
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003EF3 RID: 16115
			private static readonly IntPtr NativeFieldInfoPtr__time_5__2;

			// Token: 0x04003EF4 RID: 16116
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003EF5 RID: 16117
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003EF6 RID: 16118
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003EF7 RID: 16119
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003EF8 RID: 16120
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003EF9 RID: 16121
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}
	}
}
