using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000120 RID: 288
	public static class GameObjectEx : global::Il2CppSystem.Object
	{
		// Token: 0x06001B31 RID: 6961 RVA: 0x0008AE98 File Offset: 0x00089098
		// Note: this type is marked as 'beforefieldinit'.
		static GameObjectEx()
		{
			Il2CppClassPointerStore<GameObjectEx>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GameObjectEx");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameObjectEx>.NativeClassPtr);
			GameObjectEx.NativeFieldInfoPtr__transformsChildren = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameObjectEx>.NativeClassPtr, "_transformsChildren");
			GameObjectEx.NativeMethodInfoPtr_InheritHierarchyLayers_Public_Static_Void_GameObject_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectEx>.NativeClassPtr, 100667353);
			GameObjectEx.NativeMethodInfoPtr_SetStatic_Public_Static_Void_GameObject_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectEx>.NativeClassPtr, 100667354);
			GameObjectEx.NativeMethodInfoPtr_IsRLDAppObject_Public_Static_Boolean_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectEx>.NativeClassPtr, 100667355);
			GameObjectEx.NativeMethodInfoPtr_GetGameObjectType_Public_Static_GameObjectType_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectEx>.NativeClassPtr, 100667356);
			GameObjectEx.NativeMethodInfoPtr_HierarchyHasMesh_Public_Static_Boolean_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectEx>.NativeClassPtr, 100667357);
			GameObjectEx.NativeMethodInfoPtr_HierarchyHasSprite_Public_Static_Boolean_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectEx>.NativeClassPtr, 100667358);
			GameObjectEx.NativeMethodInfoPtr_HierarchyHasObjectsOfType_Public_Static_Boolean_GameObject_GameObjectType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectEx>.NativeClassPtr, 100667359);
			GameObjectEx.NativeMethodInfoPtr_GetMeshObjectsInHierarchy_Public_Static_List_1_GameObject_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectEx>.NativeClassPtr, 100667360);
			GameObjectEx.NativeMethodInfoPtr_GetSpriteObjectsInHierarchy_Public_Static_List_1_GameObject_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectEx>.NativeClassPtr, 100667361);
			GameObjectEx.NativeMethodInfoPtr_SetHierarchyWorldScaleByPivot_Public_Static_Void_GameObject_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectEx>.NativeClassPtr, 100667362);
			GameObjectEx.NativeMethodInfoPtr_GetAllChildren_Public_Static_List_1_GameObject_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectEx>.NativeClassPtr, 100667363);
			GameObjectEx.NativeMethodInfoPtr_GetAllChildrenAndSelf_Public_Static_List_1_GameObject_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectEx>.NativeClassPtr, 100667364);
			GameObjectEx.NativeMethodInfoPtr_GetAllChildrenAndSelf_Public_Static_Void_GameObject_List_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectEx>.NativeClassPtr, 100667365);
			GameObjectEx.NativeMethodInfoPtr_GetMesh_Public_Static_Mesh_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectEx>.NativeClassPtr, 100667366);
			GameObjectEx.NativeMethodInfoPtr_GetMeshRenderer_Public_Static_Renderer_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectEx>.NativeClassPtr, 100667367);
			GameObjectEx.NativeMethodInfoPtr_GetSprite_Public_Static_Sprite_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectEx>.NativeClassPtr, 100667368);
			GameObjectEx.NativeMethodInfoPtr_GetRoots_Public_Static_List_1_GameObject_IEnumerable_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectEx>.NativeClassPtr, 100667369);
			GameObjectEx.NativeMethodInfoPtr_FilterParentsOnly_Public_Static_List_1_GameObject_IEnumerable_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectEx>.NativeClassPtr, 100667370);
		}

		// Token: 0x06001B32 RID: 6962 RVA: 0x0008B044 File Offset: 0x00089244
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 76444, RefRangeEnd = 76446, XrefRangeStart = 76409, XrefRangeEnd = 76444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InheritHierarchyLayers(this GameObject hierarchy, GameObject sourceHierarchy)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hierarchy);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceHierarchy);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectEx.NativeMethodInfoPtr_InheritHierarchyLayers_Public_Static_Void_GameObject_GameObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B33 RID: 6963 RVA: 0x0008B08C File Offset: 0x0008928C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76446, XrefRangeEnd = 76467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetStatic(this GameObject gameObject, bool isStatic, bool affectChildren)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isStatic;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref affectChildren;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectEx.NativeMethodInfoPtr_SetStatic_Public_Static_Void_GameObject_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B34 RID: 6964 RVA: 0x0008B0E0 File Offset: 0x000892E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 76473, RefRangeEnd = 76475, XrefRangeStart = 76467, XrefRangeEnd = 76473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsRLDAppObject(this GameObject gameObject)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectEx.NativeMethodInfoPtr_IsRLDAppObject_Public_Static_Boolean_GameObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B35 RID: 6965 RVA: 0x0008B124 File Offset: 0x00089324
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 76515, RefRangeEnd = 76528, XrefRangeStart = 76475, XrefRangeEnd = 76515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObjectType GetGameObjectType(this GameObject gameObject)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectEx.NativeMethodInfoPtr_GetGameObjectType_Public_Static_GameObjectType_GameObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObjectType>(intPtr3) : null;
			}
		}

		// Token: 0x06001B36 RID: 6966 RVA: 0x0008B168 File Offset: 0x00089368
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 76549, RefRangeEnd = 76551, XrefRangeStart = 76528, XrefRangeEnd = 76549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HierarchyHasMesh(this GameObject root)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectEx.NativeMethodInfoPtr_HierarchyHasMesh_Public_Static_Boolean_GameObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B37 RID: 6967 RVA: 0x0008B1AC File Offset: 0x000893AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 76580, RefRangeEnd = 76582, XrefRangeStart = 76551, XrefRangeEnd = 76580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HierarchyHasSprite(this GameObject root)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectEx.NativeMethodInfoPtr_HierarchyHasSprite_Public_Static_Boolean_GameObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B38 RID: 6968 RVA: 0x0008B1F0 File Offset: 0x000893F0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 76599, RefRangeEnd = 76602, XrefRangeStart = 76582, XrefRangeEnd = 76599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HierarchyHasObjectsOfType(this GameObject root, GameObjectType typeFlags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeFlags);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectEx.NativeMethodInfoPtr_HierarchyHasObjectsOfType_Public_Static_Boolean_GameObject_GameObjectType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B39 RID: 6969 RVA: 0x0008B244 File Offset: 0x00089444
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 76637, RefRangeEnd = 76639, XrefRangeStart = 76602, XrefRangeEnd = 76637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<GameObject> GetMeshObjectsInHierarchy(this GameObject root)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectEx.NativeMethodInfoPtr_GetMeshObjectsInHierarchy_Public_Static_List_1_GameObject_GameObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr3) : null;
			}
		}

		// Token: 0x06001B3A RID: 6970 RVA: 0x0008B288 File Offset: 0x00089488
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 76682, RefRangeEnd = 76684, XrefRangeStart = 76639, XrefRangeEnd = 76682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<GameObject> GetSpriteObjectsInHierarchy(this GameObject root)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectEx.NativeMethodInfoPtr_GetSpriteObjectsInHierarchy_Public_Static_List_1_GameObject_GameObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr3) : null;
			}
		}

		// Token: 0x06001B3B RID: 6971 RVA: 0x0008B2CC File Offset: 0x000894CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 76690, RefRangeEnd = 76691, XrefRangeStart = 76684, XrefRangeEnd = 76690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetHierarchyWorldScaleByPivot(this GameObject root, Vector3 worldScale, Vector3 pivotPoint)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(worldScale);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pivotPoint);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectEx.NativeMethodInfoPtr_SetHierarchyWorldScaleByPivot_Public_Static_Void_GameObject_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B3C RID: 6972 RVA: 0x0008B328 File Offset: 0x00089528
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 76710, RefRangeEnd = 76712, XrefRangeStart = 76691, XrefRangeEnd = 76710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<GameObject> GetAllChildren(this GameObject gameObject)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectEx.NativeMethodInfoPtr_GetAllChildren_Public_Static_List_1_GameObject_GameObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr3) : null;
			}
		}

		// Token: 0x06001B3D RID: 6973 RVA: 0x0008B36C File Offset: 0x0008956C
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 76728, RefRangeEnd = 76746, XrefRangeStart = 76712, XrefRangeEnd = 76728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<GameObject> GetAllChildrenAndSelf(this GameObject gameObject)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectEx.NativeMethodInfoPtr_GetAllChildrenAndSelf_Public_Static_List_1_GameObject_GameObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr3) : null;
			}
		}

		// Token: 0x06001B3E RID: 6974 RVA: 0x0008B3B0 File Offset: 0x000895B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 76779, RefRangeEnd = 76781, XrefRangeStart = 76746, XrefRangeEnd = 76779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetAllChildrenAndSelf(this GameObject gameObject, List<GameObject> childrenAndSelf)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(childrenAndSelf);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectEx.NativeMethodInfoPtr_GetAllChildrenAndSelf_Public_Static_Void_GameObject_List_1_GameObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B3F RID: 6975 RVA: 0x0008B3F8 File Offset: 0x000895F8
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 76804, RefRangeEnd = 76814, XrefRangeStart = 76781, XrefRangeEnd = 76804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Mesh GetMesh(this GameObject gameObject)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectEx.NativeMethodInfoPtr_GetMesh_Public_Static_Mesh_GameObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
			}
		}

		// Token: 0x06001B40 RID: 6976 RVA: 0x0008B43C File Offset: 0x0008963C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 76824, RefRangeEnd = 76825, XrefRangeStart = 76814, XrefRangeEnd = 76824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Renderer GetMeshRenderer(this GameObject gameObject)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectEx.NativeMethodInfoPtr_GetMeshRenderer_Public_Static_Renderer_GameObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Renderer>(intPtr3) : null;
			}
		}

		// Token: 0x06001B41 RID: 6977 RVA: 0x0008B480 File Offset: 0x00089680
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 76833, RefRangeEnd = 76835, XrefRangeStart = 76825, XrefRangeEnd = 76833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Sprite GetSprite(this GameObject gameObject)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectEx.NativeMethodInfoPtr_GetSprite_Public_Static_Sprite_GameObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}
		}

		// Token: 0x06001B42 RID: 6978 RVA: 0x0008B4C4 File Offset: 0x000896C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76835, XrefRangeEnd = 76879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<GameObject> GetRoots(IEnumerable<GameObject> gameObjects)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObjects);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectEx.NativeMethodInfoPtr_GetRoots_Public_Static_List_1_GameObject_IEnumerable_1_GameObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr3) : null;
			}
		}

		// Token: 0x06001B43 RID: 6979 RVA: 0x0008B508 File Offset: 0x00089708
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 76926, RefRangeEnd = 76945, XrefRangeStart = 76879, XrefRangeEnd = 76926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<GameObject> FilterParentsOnly(IEnumerable<GameObject> gameObjects)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObjects);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameObjectEx.NativeMethodInfoPtr_FilterParentsOnly_Public_Static_List_1_GameObject_IEnumerable_1_GameObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr3) : null;
			}
		}

		// Token: 0x06001B44 RID: 6980 RVA: 0x0000BCF2 File Offset: 0x00009EF2
		public GameObjectEx(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A10 RID: 2576
		// (get) Token: 0x06001B45 RID: 6981 RVA: 0x0008B54C File Offset: 0x0008974C
		// (set) Token: 0x06001B46 RID: 6982 RVA: 0x0000BCFB File Offset: 0x00009EFB
		public unsafe static List<Transform> _transformsChildren
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GameObjectEx.NativeFieldInfoPtr__transformsChildren, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameObjectEx.NativeFieldInfoPtr__transformsChildren, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040014B1 RID: 5297
		private static readonly IntPtr NativeFieldInfoPtr__transformsChildren;

		// Token: 0x040014B2 RID: 5298
		private static readonly IntPtr NativeMethodInfoPtr_InheritHierarchyLayers_Public_Static_Void_GameObject_GameObject_0;

		// Token: 0x040014B3 RID: 5299
		private static readonly IntPtr NativeMethodInfoPtr_SetStatic_Public_Static_Void_GameObject_Boolean_Boolean_0;

		// Token: 0x040014B4 RID: 5300
		private static readonly IntPtr NativeMethodInfoPtr_IsRLDAppObject_Public_Static_Boolean_GameObject_0;

		// Token: 0x040014B5 RID: 5301
		private static readonly IntPtr NativeMethodInfoPtr_GetGameObjectType_Public_Static_GameObjectType_GameObject_0;

		// Token: 0x040014B6 RID: 5302
		private static readonly IntPtr NativeMethodInfoPtr_HierarchyHasMesh_Public_Static_Boolean_GameObject_0;

		// Token: 0x040014B7 RID: 5303
		private static readonly IntPtr NativeMethodInfoPtr_HierarchyHasSprite_Public_Static_Boolean_GameObject_0;

		// Token: 0x040014B8 RID: 5304
		private static readonly IntPtr NativeMethodInfoPtr_HierarchyHasObjectsOfType_Public_Static_Boolean_GameObject_GameObjectType_0;

		// Token: 0x040014B9 RID: 5305
		private static readonly IntPtr NativeMethodInfoPtr_GetMeshObjectsInHierarchy_Public_Static_List_1_GameObject_GameObject_0;

		// Token: 0x040014BA RID: 5306
		private static readonly IntPtr NativeMethodInfoPtr_GetSpriteObjectsInHierarchy_Public_Static_List_1_GameObject_GameObject_0;

		// Token: 0x040014BB RID: 5307
		private static readonly IntPtr NativeMethodInfoPtr_SetHierarchyWorldScaleByPivot_Public_Static_Void_GameObject_Vector3_Vector3_0;

		// Token: 0x040014BC RID: 5308
		private static readonly IntPtr NativeMethodInfoPtr_GetAllChildren_Public_Static_List_1_GameObject_GameObject_0;

		// Token: 0x040014BD RID: 5309
		private static readonly IntPtr NativeMethodInfoPtr_GetAllChildrenAndSelf_Public_Static_List_1_GameObject_GameObject_0;

		// Token: 0x040014BE RID: 5310
		private static readonly IntPtr NativeMethodInfoPtr_GetAllChildrenAndSelf_Public_Static_Void_GameObject_List_1_GameObject_0;

		// Token: 0x040014BF RID: 5311
		private static readonly IntPtr NativeMethodInfoPtr_GetMesh_Public_Static_Mesh_GameObject_0;

		// Token: 0x040014C0 RID: 5312
		private static readonly IntPtr NativeMethodInfoPtr_GetMeshRenderer_Public_Static_Renderer_GameObject_0;

		// Token: 0x040014C1 RID: 5313
		private static readonly IntPtr NativeMethodInfoPtr_GetSprite_Public_Static_Sprite_GameObject_0;

		// Token: 0x040014C2 RID: 5314
		private static readonly IntPtr NativeMethodInfoPtr_GetRoots_Public_Static_List_1_GameObject_IEnumerable_1_GameObject_0;

		// Token: 0x040014C3 RID: 5315
		private static readonly IntPtr NativeMethodInfoPtr_FilterParentsOnly_Public_Static_List_1_GameObject_IEnumerable_1_GameObject_0;
	}
}
