using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001B9 RID: 441
	public class SceneOverlapFilter : global::Il2CppSystem.Object
	{
		// Token: 0x06002240 RID: 8768 RVA: 0x000A9290 File Offset: 0x000A7490
		// Note: this type is marked as 'beforefieldinit'.
		static SceneOverlapFilter()
		{
			Il2CppClassPointerStore<SceneOverlapFilter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "SceneOverlapFilter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneOverlapFilter>.NativeClassPtr);
			SceneOverlapFilter.NativeFieldInfoPtr__allowedObjectTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneOverlapFilter>.NativeClassPtr, "_allowedObjectTypes");
			SceneOverlapFilter.NativeFieldInfoPtr__ignoreObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneOverlapFilter>.NativeClassPtr, "_ignoreObjects");
			SceneOverlapFilter.NativeFieldInfoPtr__layerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneOverlapFilter>.NativeClassPtr, "_layerMask");
			SceneOverlapFilter.NativeMethodInfoPtr_get_AllowedObjectTypes_Public_get_List_1_GameObjectType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneOverlapFilter>.NativeClassPtr, 100668474);
			SceneOverlapFilter.NativeMethodInfoPtr_get_IgnoreObjects_Public_get_List_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneOverlapFilter>.NativeClassPtr, 100668475);
			SceneOverlapFilter.NativeMethodInfoPtr_get_LayerMask_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneOverlapFilter>.NativeClassPtr, 100668476);
			SceneOverlapFilter.NativeMethodInfoPtr_set_LayerMask_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneOverlapFilter>.NativeClassPtr, 100668477);
			SceneOverlapFilter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneOverlapFilter>.NativeClassPtr, 100668479);
			SceneOverlapFilter.NativeMethodInfoPtr_FilterOverlaps_Public_Void_List_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneOverlapFilter>.NativeClassPtr, 100668478);
			SceneOverlapFilter.NativeMethodInfoPtr__FilterOverlaps_b__10_0_Private_Boolean_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneOverlapFilter>.NativeClassPtr, 100668480);
		}

		// Token: 0x17000C12 RID: 3090
		// (get) Token: 0x06002241 RID: 8769 RVA: 0x000A9388 File Offset: 0x000A7588
		public unsafe List<GameObjectType> AllowedObjectTypes
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 17906, RefRangeEnd = 17917, XrefRangeStart = 17906, XrefRangeEnd = 17917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneOverlapFilter.NativeMethodInfoPtr_get_AllowedObjectTypes_Public_get_List_1_GameObjectType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<GameObjectType>>(intPtr3) : null;
			}
		}

		// Token: 0x17000C13 RID: 3091
		// (get) Token: 0x06002242 RID: 8770 RVA: 0x000A93C8 File Offset: 0x000A75C8
		public unsafe List<GameObject> IgnoreObjects
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneOverlapFilter.NativeMethodInfoPtr_get_IgnoreObjects_Public_get_List_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr3) : null;
			}
		}

		// Token: 0x17000C14 RID: 3092
		// (get) Token: 0x06002243 RID: 8771 RVA: 0x000A9408 File Offset: 0x000A7608
		// (set) Token: 0x06002244 RID: 8772 RVA: 0x000A9444 File Offset: 0x000A7644
		public unsafe int LayerMask
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 23450, RefRangeEnd = 23451, XrefRangeStart = 23450, XrefRangeEnd = 23451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneOverlapFilter.NativeMethodInfoPtr_get_LayerMask_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneOverlapFilter.NativeMethodInfoPtr_set_LayerMask_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002245 RID: 8773 RVA: 0x000A9484 File Offset: 0x000A7684
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 86998, RefRangeEnd = 86999, XrefRangeStart = 86983, XrefRangeEnd = 86998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SceneOverlapFilter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneOverlapFilter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneOverlapFilter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002246 RID: 8774 RVA: 0x000A94C0 File Offset: 0x000A76C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86999, XrefRangeEnd = 87009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FilterOverlaps(List<GameObject> gameObjects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObjects);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneOverlapFilter.NativeMethodInfoPtr_FilterOverlaps_Public_Void_List_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002247 RID: 8775 RVA: 0x000A9504 File Offset: 0x000A7704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87009, XrefRangeEnd = 87021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _FilterOverlaps_b__10_0(GameObject item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneOverlapFilter.NativeMethodInfoPtr__FilterOverlaps_b__10_0_Private_Boolean_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002248 RID: 8776 RVA: 0x0000DFE8 File Offset: 0x0000C1E8
		public SceneOverlapFilter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C0F RID: 3087
		// (get) Token: 0x06002249 RID: 8777 RVA: 0x000A9554 File Offset: 0x000A7754
		// (set) Token: 0x0600224A RID: 8778 RVA: 0x0000DFF1 File Offset: 0x0000C1F1
		public unsafe List<GameObjectType> _allowedObjectTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneOverlapFilter.NativeFieldInfoPtr__allowedObjectTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObjectType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneOverlapFilter.NativeFieldInfoPtr__allowedObjectTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C10 RID: 3088
		// (get) Token: 0x0600224B RID: 8779 RVA: 0x000A9584 File Offset: 0x000A7784
		// (set) Token: 0x0600224C RID: 8780 RVA: 0x0000E010 File Offset: 0x0000C210
		public unsafe List<GameObject> _ignoreObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneOverlapFilter.NativeFieldInfoPtr__ignoreObjects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneOverlapFilter.NativeFieldInfoPtr__ignoreObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C11 RID: 3089
		// (get) Token: 0x0600224D RID: 8781 RVA: 0x000A95B4 File Offset: 0x000A77B4
		// (set) Token: 0x0600224E RID: 8782 RVA: 0x0000E02F File Offset: 0x0000C22F
		public unsafe int _layerMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneOverlapFilter.NativeFieldInfoPtr__layerMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneOverlapFilter.NativeFieldInfoPtr__layerMask)) = value;
			}
		}

		// Token: 0x04001A9B RID: 6811
		private static readonly IntPtr NativeFieldInfoPtr__allowedObjectTypes;

		// Token: 0x04001A9C RID: 6812
		private static readonly IntPtr NativeFieldInfoPtr__ignoreObjects;

		// Token: 0x04001A9D RID: 6813
		private static readonly IntPtr NativeFieldInfoPtr__layerMask;

		// Token: 0x04001A9E RID: 6814
		private static readonly IntPtr NativeMethodInfoPtr_get_AllowedObjectTypes_Public_get_List_1_GameObjectType_0;

		// Token: 0x04001A9F RID: 6815
		private static readonly IntPtr NativeMethodInfoPtr_get_IgnoreObjects_Public_get_List_1_GameObject_0;

		// Token: 0x04001AA0 RID: 6816
		private static readonly IntPtr NativeMethodInfoPtr_get_LayerMask_Public_get_Int32_0;

		// Token: 0x04001AA1 RID: 6817
		private static readonly IntPtr NativeMethodInfoPtr_set_LayerMask_Public_set_Void_Int32_0;

		// Token: 0x04001AA2 RID: 6818
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001AA3 RID: 6819
		private static readonly IntPtr NativeMethodInfoPtr_FilterOverlaps_Public_Void_List_1_GameObject_0;

		// Token: 0x04001AA4 RID: 6820
		private static readonly IntPtr NativeMethodInfoPtr__FilterOverlaps_b__10_0_Private_Boolean_GameObject_0;
	}
}
