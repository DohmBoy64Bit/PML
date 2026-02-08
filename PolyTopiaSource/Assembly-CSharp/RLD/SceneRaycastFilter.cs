using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001BB RID: 443
	public class SceneRaycastFilter : global::Il2CppSystem.Object
	{
		// Token: 0x0600224F RID: 8783 RVA: 0x000A95DC File Offset: 0x000A77DC
		// Note: this type is marked as 'beforefieldinit'.
		static SceneRaycastFilter()
		{
			Il2CppClassPointerStore<SceneRaycastFilter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "SceneRaycastFilter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneRaycastFilter>.NativeClassPtr);
			SceneRaycastFilter.NativeFieldInfoPtr__allowedObjectTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneRaycastFilter>.NativeClassPtr, "_allowedObjectTypes");
			SceneRaycastFilter.NativeFieldInfoPtr__ignoreObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneRaycastFilter>.NativeClassPtr, "_ignoreObjects");
			SceneRaycastFilter.NativeFieldInfoPtr__layerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneRaycastFilter>.NativeClassPtr, "_layerMask");
			SceneRaycastFilter.NativeMethodInfoPtr_get_AllowedObjectTypes_Public_get_List_1_GameObjectType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneRaycastFilter>.NativeClassPtr, 100668481);
			SceneRaycastFilter.NativeMethodInfoPtr_get_IgnoreObjects_Public_get_List_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneRaycastFilter>.NativeClassPtr, 100668482);
			SceneRaycastFilter.NativeMethodInfoPtr_get_LayerMask_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneRaycastFilter>.NativeClassPtr, 100668483);
			SceneRaycastFilter.NativeMethodInfoPtr_set_LayerMask_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneRaycastFilter>.NativeClassPtr, 100668484);
			SceneRaycastFilter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneRaycastFilter>.NativeClassPtr, 100668486);
			SceneRaycastFilter.NativeMethodInfoPtr_FilterHits_Public_Void_List_1_GameObjectRayHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneRaycastFilter>.NativeClassPtr, 100668485);
			SceneRaycastFilter.NativeMethodInfoPtr__FilterHits_b__10_0_Private_Boolean_GameObjectRayHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneRaycastFilter>.NativeClassPtr, 100668487);
		}

		// Token: 0x17000C18 RID: 3096
		// (get) Token: 0x06002250 RID: 8784 RVA: 0x000A96D4 File Offset: 0x000A78D4
		public unsafe List<GameObjectType> AllowedObjectTypes
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 17906, RefRangeEnd = 17917, XrefRangeStart = 17906, XrefRangeEnd = 17917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneRaycastFilter.NativeMethodInfoPtr_get_AllowedObjectTypes_Public_get_List_1_GameObjectType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<GameObjectType>>(intPtr3) : null;
			}
		}

		// Token: 0x17000C19 RID: 3097
		// (get) Token: 0x06002251 RID: 8785 RVA: 0x000A9714 File Offset: 0x000A7914
		public unsafe List<GameObject> IgnoreObjects
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneRaycastFilter.NativeMethodInfoPtr_get_IgnoreObjects_Public_get_List_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr3) : null;
			}
		}

		// Token: 0x17000C1A RID: 3098
		// (get) Token: 0x06002252 RID: 8786 RVA: 0x000A9754 File Offset: 0x000A7954
		// (set) Token: 0x06002253 RID: 8787 RVA: 0x000A9790 File Offset: 0x000A7990
		public unsafe int LayerMask
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 23450, RefRangeEnd = 23451, XrefRangeStart = 23450, XrefRangeEnd = 23451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneRaycastFilter.NativeMethodInfoPtr_get_LayerMask_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneRaycastFilter.NativeMethodInfoPtr_set_LayerMask_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002254 RID: 8788 RVA: 0x000A97D0 File Offset: 0x000A79D0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 87036, RefRangeEnd = 87041, XrefRangeStart = 87021, XrefRangeEnd = 87036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SceneRaycastFilter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneRaycastFilter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneRaycastFilter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002255 RID: 8789 RVA: 0x000A980C File Offset: 0x000A7A0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87041, XrefRangeEnd = 87051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FilterHits(List<GameObjectRayHit> hits)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hits);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneRaycastFilter.NativeMethodInfoPtr_FilterHits_Public_Void_List_1_GameObjectRayHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002256 RID: 8790 RVA: 0x000A9850 File Offset: 0x000A7A50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87051, XrefRangeEnd = 87063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _FilterHits_b__10_0(GameObjectRayHit item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneRaycastFilter.NativeMethodInfoPtr__FilterHits_b__10_0_Private_Boolean_GameObjectRayHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002257 RID: 8791 RVA: 0x0000E04A File Offset: 0x0000C24A
		public SceneRaycastFilter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C15 RID: 3093
		// (get) Token: 0x06002258 RID: 8792 RVA: 0x000A98A0 File Offset: 0x000A7AA0
		// (set) Token: 0x06002259 RID: 8793 RVA: 0x0000E053 File Offset: 0x0000C253
		public unsafe List<GameObjectType> _allowedObjectTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneRaycastFilter.NativeFieldInfoPtr__allowedObjectTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObjectType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneRaycastFilter.NativeFieldInfoPtr__allowedObjectTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C16 RID: 3094
		// (get) Token: 0x0600225A RID: 8794 RVA: 0x000A98D0 File Offset: 0x000A7AD0
		// (set) Token: 0x0600225B RID: 8795 RVA: 0x0000E072 File Offset: 0x0000C272
		public unsafe List<GameObject> _ignoreObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneRaycastFilter.NativeFieldInfoPtr__ignoreObjects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneRaycastFilter.NativeFieldInfoPtr__ignoreObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C17 RID: 3095
		// (get) Token: 0x0600225C RID: 8796 RVA: 0x000A9900 File Offset: 0x000A7B00
		// (set) Token: 0x0600225D RID: 8797 RVA: 0x0000E091 File Offset: 0x0000C291
		public unsafe int _layerMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneRaycastFilter.NativeFieldInfoPtr__layerMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneRaycastFilter.NativeFieldInfoPtr__layerMask)) = value;
			}
		}

		// Token: 0x04001AA8 RID: 6824
		private static readonly IntPtr NativeFieldInfoPtr__allowedObjectTypes;

		// Token: 0x04001AA9 RID: 6825
		private static readonly IntPtr NativeFieldInfoPtr__ignoreObjects;

		// Token: 0x04001AAA RID: 6826
		private static readonly IntPtr NativeFieldInfoPtr__layerMask;

		// Token: 0x04001AAB RID: 6827
		private static readonly IntPtr NativeMethodInfoPtr_get_AllowedObjectTypes_Public_get_List_1_GameObjectType_0;

		// Token: 0x04001AAC RID: 6828
		private static readonly IntPtr NativeMethodInfoPtr_get_IgnoreObjects_Public_get_List_1_GameObject_0;

		// Token: 0x04001AAD RID: 6829
		private static readonly IntPtr NativeMethodInfoPtr_get_LayerMask_Public_get_Int32_0;

		// Token: 0x04001AAE RID: 6830
		private static readonly IntPtr NativeMethodInfoPtr_set_LayerMask_Public_set_Void_Int32_0;

		// Token: 0x04001AAF RID: 6831
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001AB0 RID: 6832
		private static readonly IntPtr NativeMethodInfoPtr_FilterHits_Public_Void_List_1_GameObjectRayHit_0;

		// Token: 0x04001AB1 RID: 6833
		private static readonly IntPtr NativeMethodInfoPtr__FilterHits_b__10_0_Private_Boolean_GameObjectRayHit_0;
	}
}
