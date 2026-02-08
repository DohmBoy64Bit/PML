using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x020001BF RID: 447
	public class SceneTree : global::Il2CppSystem.Object
	{
		// Token: 0x06002275 RID: 8821 RVA: 0x000A9E3C File Offset: 0x000A803C
		// Note: this type is marked as 'beforefieldinit'.
		static SceneTree()
		{
			Il2CppClassPointerStore<SceneTree>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "SceneTree");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneTree>.NativeClassPtr);
			SceneTree.NativeFieldInfoPtr__objectTree = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneTree>.NativeClassPtr, "_objectTree");
			SceneTree.NativeFieldInfoPtr__objectToNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneTree>.NativeClassPtr, "_objectToNode");
			SceneTree.NativeFieldInfoPtr__nodeHitBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneTree>.NativeClassPtr, "_nodeHitBuffer");
			SceneTree.NativeFieldInfoPtr__nodeBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneTree>.NativeClassPtr, "_nodeBuffer");
			SceneTree.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneTree>.NativeClassPtr, 100668510);
			SceneTree.NativeMethodInfoPtr_RaycastMeshObject_Public_GameObjectRayHit_Ray_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneTree>.NativeClassPtr, 100668499);
			SceneTree.NativeMethodInfoPtr_RaycastSpriteObject_Public_GameObjectRayHit_Ray_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneTree>.NativeClassPtr, 100668500);
			SceneTree.NativeMethodInfoPtr_RaycastAll_Public_Boolean_Ray_SceneRaycastPrecision_List_1_GameObjectRayHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneTree>.NativeClassPtr, 100668501);
			SceneTree.NativeMethodInfoPtr_OverlapBox_Public_Boolean_OBB_List_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneTree>.NativeClassPtr, 100668502);
			SceneTree.NativeMethodInfoPtr_IsObjectRegistered_Public_Boolean_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneTree>.NativeClassPtr, 100668503);
			SceneTree.NativeMethodInfoPtr_RegisterObject_Public_Boolean_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneTree>.NativeClassPtr, 100668504);
			SceneTree.NativeMethodInfoPtr_UnregisterObject_Public_Boolean_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneTree>.NativeClassPtr, 100668505);
			SceneTree.NativeMethodInfoPtr_OnObjectTransformChanged_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneTree>.NativeClassPtr, 100668506);
			SceneTree.NativeMethodInfoPtr_RemoveNodesWithNullObjects_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneTree>.NativeClassPtr, 100668507);
			SceneTree.NativeMethodInfoPtr_DebugDraw_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneTree>.NativeClassPtr, 100668508);
			SceneTree.NativeMethodInfoPtr_CanRegisterObject_Private_Boolean_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneTree>.NativeClassPtr, 100668509);
		}

		// Token: 0x06002276 RID: 8822 RVA: 0x000A9FAC File Offset: 0x000A81AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87075, XrefRangeEnd = 87104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SceneTree()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneTree>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneTree.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002277 RID: 8823 RVA: 0x000A9FE8 File Offset: 0x000A81E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 87127, RefRangeEnd = 87129, XrefRangeStart = 87104, XrefRangeEnd = 87127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameObjectRayHit RaycastMeshObject(Ray ray, GameObject gameObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneTree.NativeMethodInfoPtr_RaycastMeshObject_Public_GameObjectRayHit_Ray_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObjectRayHit>(intPtr3) : null;
		}

		// Token: 0x06002278 RID: 8824 RVA: 0x000AA04C File Offset: 0x000A824C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 87138, RefRangeEnd = 87140, XrefRangeStart = 87129, XrefRangeEnd = 87138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameObjectRayHit RaycastSpriteObject(Ray ray, GameObject gameObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneTree.NativeMethodInfoPtr_RaycastSpriteObject_Public_GameObjectRayHit_Ray_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObjectRayHit>(intPtr3) : null;
		}

		// Token: 0x06002279 RID: 8825 RVA: 0x000AA0B0 File Offset: 0x000A82B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 87256, RefRangeEnd = 87258, XrefRangeStart = 87140, XrefRangeEnd = 87256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool RaycastAll(Ray ray, SceneRaycastPrecision raycastPresicion, List<GameObjectRayHit> hits)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(raycastPresicion);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hits);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneTree.NativeMethodInfoPtr_RaycastAll_Public_Boolean_Ray_SceneRaycastPrecision_List_1_GameObjectRayHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600227A RID: 8826 RVA: 0x000AA124 File Offset: 0x000A8324
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 87306, RefRangeEnd = 87307, XrefRangeStart = 87258, XrefRangeEnd = 87306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool OverlapBox(OBB obb, List<GameObject> gameObjects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(gameObjects);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneTree.NativeMethodInfoPtr_OverlapBox_Public_Boolean_OBB_List_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600227B RID: 8827 RVA: 0x000AA184 File Offset: 0x000A8384
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 87311, RefRangeEnd = 87312, XrefRangeStart = 87307, XrefRangeEnd = 87311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsObjectRegistered(GameObject gameObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneTree.NativeMethodInfoPtr_IsObjectRegistered_Public_Boolean_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600227C RID: 8828 RVA: 0x000AA1D4 File Offset: 0x000A83D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 87361, RefRangeEnd = 87362, XrefRangeStart = 87312, XrefRangeEnd = 87361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool RegisterObject(GameObject gameObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneTree.NativeMethodInfoPtr_RegisterObject_Public_Boolean_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600227D RID: 8829 RVA: 0x000AA224 File Offset: 0x000A8424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87362, XrefRangeEnd = 87381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool UnregisterObject(GameObject gameObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneTree.NativeMethodInfoPtr_UnregisterObject_Public_Boolean_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600227E RID: 8830 RVA: 0x000AA274 File Offset: 0x000A8474
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 87416, RefRangeEnd = 87417, XrefRangeStart = 87381, XrefRangeEnd = 87416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnObjectTransformChanged(Transform objectTransform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectTransform);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneTree.NativeMethodInfoPtr_OnObjectTransformChanged_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600227F RID: 8831 RVA: 0x000AA2B8 File Offset: 0x000A84B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87417, XrefRangeEnd = 87454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveNodesWithNullObjects()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneTree.NativeMethodInfoPtr_RemoveNodesWithNullObjects_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002280 RID: 8832 RVA: 0x000AA2EC File Offset: 0x000A84EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87454, XrefRangeEnd = 87458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DebugDraw()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneTree.NativeMethodInfoPtr_DebugDraw_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002281 RID: 8833 RVA: 0x000AA320 File Offset: 0x000A8520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87458, XrefRangeEnd = 87475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanRegisterObject(GameObject gameObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneTree.NativeMethodInfoPtr_CanRegisterObject_Private_Boolean_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002282 RID: 8834 RVA: 0x0000E136 File Offset: 0x0000C336
		public SceneTree(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C26 RID: 3110
		// (get) Token: 0x06002283 RID: 8835 RVA: 0x000AA370 File Offset: 0x000A8570
		// (set) Token: 0x06002284 RID: 8836 RVA: 0x0000E13F File Offset: 0x0000C33F
		public unsafe SphereTree<GameObject> _objectTree
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneTree.NativeFieldInfoPtr__objectTree);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SphereTree<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneTree.NativeFieldInfoPtr__objectTree), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C27 RID: 3111
		// (get) Token: 0x06002285 RID: 8837 RVA: 0x000AA3A0 File Offset: 0x000A85A0
		// (set) Token: 0x06002286 RID: 8838 RVA: 0x0000E15E File Offset: 0x0000C35E
		public unsafe Dictionary<GameObject, SphereTreeNode<GameObject>> _objectToNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneTree.NativeFieldInfoPtr__objectToNode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<GameObject, SphereTreeNode<GameObject>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneTree.NativeFieldInfoPtr__objectToNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C28 RID: 3112
		// (get) Token: 0x06002287 RID: 8839 RVA: 0x000AA3D0 File Offset: 0x000A85D0
		// (set) Token: 0x06002288 RID: 8840 RVA: 0x0000E17D File Offset: 0x0000C37D
		public unsafe List<SphereTreeNodeRayHit<GameObject>> _nodeHitBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneTree.NativeFieldInfoPtr__nodeHitBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SphereTreeNodeRayHit<GameObject>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneTree.NativeFieldInfoPtr__nodeHitBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C29 RID: 3113
		// (get) Token: 0x06002289 RID: 8841 RVA: 0x000AA400 File Offset: 0x000A8600
		// (set) Token: 0x0600228A RID: 8842 RVA: 0x0000E19C File Offset: 0x0000C39C
		public unsafe List<SphereTreeNode<GameObject>> _nodeBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneTree.NativeFieldInfoPtr__nodeBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SphereTreeNode<GameObject>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneTree.NativeFieldInfoPtr__nodeBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001AC4 RID: 6852
		private static readonly IntPtr NativeFieldInfoPtr__objectTree;

		// Token: 0x04001AC5 RID: 6853
		private static readonly IntPtr NativeFieldInfoPtr__objectToNode;

		// Token: 0x04001AC6 RID: 6854
		private static readonly IntPtr NativeFieldInfoPtr__nodeHitBuffer;

		// Token: 0x04001AC7 RID: 6855
		private static readonly IntPtr NativeFieldInfoPtr__nodeBuffer;

		// Token: 0x04001AC8 RID: 6856
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001AC9 RID: 6857
		private static readonly IntPtr NativeMethodInfoPtr_RaycastMeshObject_Public_GameObjectRayHit_Ray_GameObject_0;

		// Token: 0x04001ACA RID: 6858
		private static readonly IntPtr NativeMethodInfoPtr_RaycastSpriteObject_Public_GameObjectRayHit_Ray_GameObject_0;

		// Token: 0x04001ACB RID: 6859
		private static readonly IntPtr NativeMethodInfoPtr_RaycastAll_Public_Boolean_Ray_SceneRaycastPrecision_List_1_GameObjectRayHit_0;

		// Token: 0x04001ACC RID: 6860
		private static readonly IntPtr NativeMethodInfoPtr_OverlapBox_Public_Boolean_OBB_List_1_GameObject_0;

		// Token: 0x04001ACD RID: 6861
		private static readonly IntPtr NativeMethodInfoPtr_IsObjectRegistered_Public_Boolean_GameObject_0;

		// Token: 0x04001ACE RID: 6862
		private static readonly IntPtr NativeMethodInfoPtr_RegisterObject_Public_Boolean_GameObject_0;

		// Token: 0x04001ACF RID: 6863
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterObject_Public_Boolean_GameObject_0;

		// Token: 0x04001AD0 RID: 6864
		private static readonly IntPtr NativeMethodInfoPtr_OnObjectTransformChanged_Public_Void_Transform_0;

		// Token: 0x04001AD1 RID: 6865
		private static readonly IntPtr NativeMethodInfoPtr_RemoveNodesWithNullObjects_Public_Void_0;

		// Token: 0x04001AD2 RID: 6866
		private static readonly IntPtr NativeMethodInfoPtr_DebugDraw_Public_Void_0;

		// Token: 0x04001AD3 RID: 6867
		private static readonly IntPtr NativeMethodInfoPtr_CanRegisterObject_Private_Boolean_GameObject_0;
	}
}
