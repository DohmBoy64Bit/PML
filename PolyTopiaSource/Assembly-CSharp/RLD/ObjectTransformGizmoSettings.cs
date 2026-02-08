using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x020000E1 RID: 225
	[Serializable]
	public class ObjectTransformGizmoSettings : Settings
	{
		// Token: 0x06001350 RID: 4944 RVA: 0x0006A714 File Offset: 0x00068914
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectTransformGizmoSettings()
		{
			Il2CppClassPointerStore<ObjectTransformGizmoSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "ObjectTransformGizmoSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectTransformGizmoSettings>.NativeClassPtr);
			ObjectTransformGizmoSettings.NativeFieldInfoPtr__transformableLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectTransformGizmoSettings>.NativeClassPtr, "_transformableLayers");
			ObjectTransformGizmoSettings.NativeFieldInfoPtr__nonTransformableObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectTransformGizmoSettings>.NativeClassPtr, "_nonTransformableObjects");
			ObjectTransformGizmoSettings.NativeMethodInfoPtr_get_TransformableLayers_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTransformGizmoSettings>.NativeClassPtr, 100666011);
			ObjectTransformGizmoSettings.NativeMethodInfoPtr_set_TransformableLayers_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTransformGizmoSettings>.NativeClassPtr, 100666012);
			ObjectTransformGizmoSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTransformGizmoSettings>.NativeClassPtr, 100666018);
			ObjectTransformGizmoSettings.NativeMethodInfoPtr_IsLayerTransformable_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTransformGizmoSettings>.NativeClassPtr, 100666013);
			ObjectTransformGizmoSettings.NativeMethodInfoPtr_SetLayerTransformable_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTransformGizmoSettings>.NativeClassPtr, 100666014);
			ObjectTransformGizmoSettings.NativeMethodInfoPtr_IsObjectTransformable_Public_Boolean_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTransformGizmoSettings>.NativeClassPtr, 100666015);
			ObjectTransformGizmoSettings.NativeMethodInfoPtr_SetObjectTransformable_Public_Void_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTransformGizmoSettings>.NativeClassPtr, 100666016);
			ObjectTransformGizmoSettings.NativeMethodInfoPtr_SetObjectCollectionTransformable_Public_Void_List_1_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTransformGizmoSettings>.NativeClassPtr, 100666017);
		}

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x06001351 RID: 4945 RVA: 0x0006A80C File Offset: 0x00068A0C
		// (set) Token: 0x06001352 RID: 4946 RVA: 0x0006A848 File Offset: 0x00068A48
		public unsafe int TransformableLayers
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30388, RefRangeEnd = 30389, XrefRangeStart = 30388, XrefRangeEnd = 30389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectTransformGizmoSettings.NativeMethodInfoPtr_get_TransformableLayers_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 30389, RefRangeEnd = 30394, XrefRangeStart = 30389, XrefRangeEnd = 30394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectTransformGizmoSettings.NativeMethodInfoPtr_set_TransformableLayers_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001353 RID: 4947 RVA: 0x0006A888 File Offset: 0x00068A88
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 71159, RefRangeEnd = 71163, XrefRangeStart = 71151, XrefRangeEnd = 71159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectTransformGizmoSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectTransformGizmoSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectTransformGizmoSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001354 RID: 4948 RVA: 0x0006A8C4 File Offset: 0x00068AC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsLayerTransformable(int objectLayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref objectLayer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectTransformGizmoSettings.NativeMethodInfoPtr_IsLayerTransformable_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001355 RID: 4949 RVA: 0x0006A910 File Offset: 0x00068B10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLayerTransformable(int objectLayer, bool isTransformable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref objectLayer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isTransformable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectTransformGizmoSettings.NativeMethodInfoPtr_SetLayerTransformable_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001356 RID: 4950 RVA: 0x0006A95C File Offset: 0x00068B5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 71170, RefRangeEnd = 71171, XrefRangeStart = 71163, XrefRangeEnd = 71170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsObjectTransformable(GameObject gameObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectTransformGizmoSettings.NativeMethodInfoPtr_IsObjectTransformable_Public_Boolean_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001357 RID: 4951 RVA: 0x0006A9AC File Offset: 0x00068BAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71171, XrefRangeEnd = 71179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetObjectTransformable(GameObject gameObject, bool isTransformable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isTransformable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectTransformGizmoSettings.NativeMethodInfoPtr_SetObjectTransformable_Public_Void_GameObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001358 RID: 4952 RVA: 0x0006A9FC File Offset: 0x00068BFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71179, XrefRangeEnd = 71204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetObjectCollectionTransformable(List<GameObject> gameObjectCollection, bool areTransformable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObjectCollection);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref areTransformable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectTransformGizmoSettings.NativeMethodInfoPtr_SetObjectCollectionTransformable_Public_Void_List_1_GameObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001359 RID: 4953 RVA: 0x00009563 File Offset: 0x00007763
		public ObjectTransformGizmoSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x0600135A RID: 4954 RVA: 0x0006AA4C File Offset: 0x00068C4C
		// (set) Token: 0x0600135B RID: 4955 RVA: 0x0000956C File Offset: 0x0000776C
		public unsafe int _transformableLayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectTransformGizmoSettings.NativeFieldInfoPtr__transformableLayers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectTransformGizmoSettings.NativeFieldInfoPtr__transformableLayers)) = value;
			}
		}

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x0600135C RID: 4956 RVA: 0x0006AA74 File Offset: 0x00068C74
		// (set) Token: 0x0600135D RID: 4957 RVA: 0x00009587 File Offset: 0x00007787
		public unsafe HashSet<GameObject> _nonTransformableObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectTransformGizmoSettings.NativeFieldInfoPtr__nonTransformableObjects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectTransformGizmoSettings.NativeFieldInfoPtr__nonTransformableObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E64 RID: 3684
		private static readonly IntPtr NativeFieldInfoPtr__transformableLayers;

		// Token: 0x04000E65 RID: 3685
		private static readonly IntPtr NativeFieldInfoPtr__nonTransformableObjects;

		// Token: 0x04000E66 RID: 3686
		private static readonly IntPtr NativeMethodInfoPtr_get_TransformableLayers_Public_get_Int32_0;

		// Token: 0x04000E67 RID: 3687
		private static readonly IntPtr NativeMethodInfoPtr_set_TransformableLayers_Public_set_Void_Int32_0;

		// Token: 0x04000E68 RID: 3688
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000E69 RID: 3689
		private static readonly IntPtr NativeMethodInfoPtr_IsLayerTransformable_Public_Boolean_Int32_0;

		// Token: 0x04000E6A RID: 3690
		private static readonly IntPtr NativeMethodInfoPtr_SetLayerTransformable_Public_Void_Int32_Boolean_0;

		// Token: 0x04000E6B RID: 3691
		private static readonly IntPtr NativeMethodInfoPtr_IsObjectTransformable_Public_Boolean_GameObject_0;

		// Token: 0x04000E6C RID: 3692
		private static readonly IntPtr NativeMethodInfoPtr_SetObjectTransformable_Public_Void_GameObject_Boolean_0;

		// Token: 0x04000E6D RID: 3693
		private static readonly IntPtr NativeMethodInfoPtr_SetObjectCollectionTransformable_Public_Void_List_1_GameObject_Boolean_0;
	}
}
