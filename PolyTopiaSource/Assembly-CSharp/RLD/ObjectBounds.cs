using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000208 RID: 520
	public static class ObjectBounds : global::Il2CppSystem.Object
	{
		// Token: 0x06002977 RID: 10615 RVA: 0x000C5A54 File Offset: 0x000C3C54
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectBounds()
		{
			Il2CppClassPointerStore<ObjectBounds>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "ObjectBounds");
			ObjectBounds.NativeFieldInfoPtr__defaultQConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectBounds>.NativeClassPtr, "_defaultQConfig");
			ObjectBounds.NativeMethodInfoPtr_get_DefaultQConfig_Public_Static_get_QueryConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectBounds>.NativeClassPtr, 100669634);
			ObjectBounds.NativeMethodInfoPtr_CalcScreenRect_Public_Static_Rect_GameObject_Camera_QueryConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectBounds>.NativeClassPtr, 100669635);
			ObjectBounds.NativeMethodInfoPtr_CalcSpriteWorldOBB_Public_Static_OBB_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectBounds>.NativeClassPtr, 100669636);
			ObjectBounds.NativeMethodInfoPtr_CalcSpriteWorldAABB_Public_Static_AABB_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectBounds>.NativeClassPtr, 100669637);
			ObjectBounds.NativeMethodInfoPtr_CalcSpriteModelAABB_Public_Static_AABB_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectBounds>.NativeClassPtr, 100669638);
			ObjectBounds.NativeMethodInfoPtr_GetMeshWorldOBB_Public_Static_OBB_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectBounds>.NativeClassPtr, 100669639);
			ObjectBounds.NativeMethodInfoPtr_GetMeshWorldAABB_Public_Static_AABB_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectBounds>.NativeClassPtr, 100669640);
			ObjectBounds.NativeMethodInfoPtr_CalcObjectCollectionWorldAABB_Public_Static_AABB_IEnumerable_1_GameObject_QueryConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectBounds>.NativeClassPtr, 100669641);
			ObjectBounds.NativeMethodInfoPtr_CalcHierarchyCollectionWorldAABB_Public_Static_AABB_List_1_GameObject_QueryConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectBounds>.NativeClassPtr, 100669642);
			ObjectBounds.NativeMethodInfoPtr_CalcHierarchyWorldOBB_Public_Static_OBB_GameObject_QueryConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectBounds>.NativeClassPtr, 100669643);
			ObjectBounds.NativeMethodInfoPtr_CalcHierarchyWorldAABB_Public_Static_AABB_GameObject_QueryConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectBounds>.NativeClassPtr, 100669644);
			ObjectBounds.NativeMethodInfoPtr_CalcWorldOBB_Public_Static_OBB_GameObject_QueryConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectBounds>.NativeClassPtr, 100669645);
			ObjectBounds.NativeMethodInfoPtr_CalcWorldAABB_Public_Static_AABB_GameObject_QueryConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectBounds>.NativeClassPtr, 100669646);
			ObjectBounds.NativeMethodInfoPtr_CalcMeshWorldAABB_Public_Static_AABB_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectBounds>.NativeClassPtr, 100669647);
			ObjectBounds.NativeMethodInfoPtr_CalcHierarchyModelAABB_Public_Static_AABB_GameObject_QueryConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectBounds>.NativeClassPtr, 100669648);
			ObjectBounds.NativeMethodInfoPtr_CalcMeshModelAABB_Public_Static_AABB_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectBounds>.NativeClassPtr, 100669649);
			ObjectBounds.NativeMethodInfoPtr_CalcModelAABB_Public_Static_AABB_GameObject_QueryConfig_GameObjectType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectBounds>.NativeClassPtr, 100669650);
		}

		// Token: 0x17000EE9 RID: 3817
		// (get) Token: 0x06002978 RID: 10616 RVA: 0x000C5BE4 File Offset: 0x000C3DE4
		public unsafe static ObjectBounds.QueryConfig DefaultQConfig
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91917, XrefRangeEnd = 91921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectBounds.NativeMethodInfoPtr_get_DefaultQConfig_Public_Static_get_QueryConfig_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002979 RID: 10617 RVA: 0x000C5C14 File Offset: 0x000C3E14
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 91927, RefRangeEnd = 91931, XrefRangeStart = 91921, XrefRangeEnd = 91927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Rect CalcScreenRect(GameObject gameObject, Camera camera, ObjectBounds.QueryConfig queryConfig)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref queryConfig;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectBounds.NativeMethodInfoPtr_CalcScreenRect_Public_Static_Rect_GameObject_Camera_QueryConfig_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Rect>(intPtr3) : null;
		}

		// Token: 0x0600297A RID: 10618 RVA: 0x000C5C78 File Offset: 0x000C3E78
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 91946, RefRangeEnd = 91948, XrefRangeStart = 91931, XrefRangeEnd = 91946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static OBB CalcSpriteWorldOBB(GameObject gameObject)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectBounds.NativeMethodInfoPtr_CalcSpriteWorldOBB_Public_Static_OBB_GameObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<OBB>(intPtr3) : null;
			}
		}

		// Token: 0x0600297B RID: 10619 RVA: 0x000C5CBC File Offset: 0x000C3EBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91948, XrefRangeEnd = 91964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AABB CalcSpriteWorldAABB(GameObject gameObject)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectBounds.NativeMethodInfoPtr_CalcSpriteWorldAABB_Public_Static_AABB_GameObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AABB>(intPtr3) : null;
			}
		}

		// Token: 0x0600297C RID: 10620 RVA: 0x000C5D00 File Offset: 0x000C3F00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91964, XrefRangeEnd = 91974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AABB CalcSpriteModelAABB(GameObject spriteObject)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(spriteObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectBounds.NativeMethodInfoPtr_CalcSpriteModelAABB_Public_Static_AABB_GameObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AABB>(intPtr3) : null;
			}
		}

		// Token: 0x0600297D RID: 10621 RVA: 0x000C5D44 File Offset: 0x000C3F44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91974, XrefRangeEnd = 91980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static OBB GetMeshWorldOBB(GameObject gameObject)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectBounds.NativeMethodInfoPtr_GetMeshWorldOBB_Public_Static_OBB_GameObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<OBB>(intPtr3) : null;
			}
		}

		// Token: 0x0600297E RID: 10622 RVA: 0x000C5D88 File Offset: 0x000C3F88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91980, XrefRangeEnd = 91987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AABB GetMeshWorldAABB(GameObject gameObject)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectBounds.NativeMethodInfoPtr_GetMeshWorldAABB_Public_Static_AABB_GameObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AABB>(intPtr3) : null;
			}
		}

		// Token: 0x0600297F RID: 10623 RVA: 0x000C5DCC File Offset: 0x000C3FCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 92021, RefRangeEnd = 92022, XrefRangeStart = 91987, XrefRangeEnd = 92021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AABB CalcObjectCollectionWorldAABB(IEnumerable<GameObject> gameObjectCollection, ObjectBounds.QueryConfig queryConfig)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObjectCollection);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref queryConfig;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectBounds.NativeMethodInfoPtr_CalcObjectCollectionWorldAABB_Public_Static_AABB_IEnumerable_1_GameObject_QueryConfig_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AABB>(intPtr3) : null;
		}

		// Token: 0x06002980 RID: 10624 RVA: 0x000C5E20 File Offset: 0x000C4020
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 92051, RefRangeEnd = 92052, XrefRangeStart = 92022, XrefRangeEnd = 92051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AABB CalcHierarchyCollectionWorldAABB(List<GameObject> roots, ObjectBounds.QueryConfig queryConfig)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(roots);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref queryConfig;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectBounds.NativeMethodInfoPtr_CalcHierarchyCollectionWorldAABB_Public_Static_AABB_List_1_GameObject_QueryConfig_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AABB>(intPtr3) : null;
		}

		// Token: 0x06002981 RID: 10625 RVA: 0x000C5E74 File Offset: 0x000C4074
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 92060, RefRangeEnd = 92078, XrefRangeStart = 92052, XrefRangeEnd = 92060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static OBB CalcHierarchyWorldOBB(GameObject root, ObjectBounds.QueryConfig queryConfig)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref queryConfig;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectBounds.NativeMethodInfoPtr_CalcHierarchyWorldOBB_Public_Static_OBB_GameObject_QueryConfig_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<OBB>(intPtr3) : null;
		}

		// Token: 0x06002982 RID: 10626 RVA: 0x000C5EC8 File Offset: 0x000C40C8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 92087, RefRangeEnd = 92090, XrefRangeStart = 92078, XrefRangeEnd = 92087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AABB CalcHierarchyWorldAABB(GameObject root, ObjectBounds.QueryConfig queryConfig)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref queryConfig;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectBounds.NativeMethodInfoPtr_CalcHierarchyWorldAABB_Public_Static_AABB_GameObject_QueryConfig_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AABB>(intPtr3) : null;
		}

		// Token: 0x06002983 RID: 10627 RVA: 0x000C5F1C File Offset: 0x000C411C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 92102, RefRangeEnd = 92109, XrefRangeStart = 92090, XrefRangeEnd = 92102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static OBB CalcWorldOBB(GameObject gameObject, ObjectBounds.QueryConfig queryConfig)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref queryConfig;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectBounds.NativeMethodInfoPtr_CalcWorldOBB_Public_Static_OBB_GameObject_QueryConfig_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<OBB>(intPtr3) : null;
		}

		// Token: 0x06002984 RID: 10628 RVA: 0x000C5F70 File Offset: 0x000C4170
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 92120, RefRangeEnd = 92130, XrefRangeStart = 92109, XrefRangeEnd = 92120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AABB CalcWorldAABB(GameObject gameObject, ObjectBounds.QueryConfig queryConfig)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref queryConfig;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectBounds.NativeMethodInfoPtr_CalcWorldAABB_Public_Static_AABB_GameObject_QueryConfig_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AABB>(intPtr3) : null;
		}

		// Token: 0x06002985 RID: 10629 RVA: 0x000C5FC4 File Offset: 0x000C41C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 92137, RefRangeEnd = 92138, XrefRangeStart = 92130, XrefRangeEnd = 92137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AABB CalcMeshWorldAABB(GameObject gameObject)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectBounds.NativeMethodInfoPtr_CalcMeshWorldAABB_Public_Static_AABB_GameObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AABB>(intPtr3) : null;
			}
		}

		// Token: 0x06002986 RID: 10630 RVA: 0x000C6008 File Offset: 0x000C4208
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 92175, RefRangeEnd = 92179, XrefRangeStart = 92138, XrefRangeEnd = 92175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AABB CalcHierarchyModelAABB(GameObject root, ObjectBounds.QueryConfig queryConfig)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref queryConfig;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectBounds.NativeMethodInfoPtr_CalcHierarchyModelAABB_Public_Static_AABB_GameObject_QueryConfig_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AABB>(intPtr3) : null;
		}

		// Token: 0x06002987 RID: 10631 RVA: 0x000C605C File Offset: 0x000C425C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 92189, RefRangeEnd = 92192, XrefRangeStart = 92179, XrefRangeEnd = 92189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AABB CalcMeshModelAABB(GameObject gameObject)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectBounds.NativeMethodInfoPtr_CalcMeshModelAABB_Public_Static_AABB_GameObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AABB>(intPtr3) : null;
			}
		}

		// Token: 0x06002988 RID: 10632 RVA: 0x000C60A0 File Offset: 0x000C42A0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 92222, RefRangeEnd = 92227, XrefRangeStart = 92192, XrefRangeEnd = 92222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AABB CalcModelAABB(GameObject gameObject, ObjectBounds.QueryConfig queryConfig, GameObjectType objectType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref queryConfig;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectBounds.NativeMethodInfoPtr_CalcModelAABB_Public_Static_AABB_GameObject_QueryConfig_GameObjectType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AABB>(intPtr3) : null;
		}

		// Token: 0x06002989 RID: 10633 RVA: 0x000105F6 File Offset: 0x0000E7F6
		public ObjectBounds(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000EE8 RID: 3816
		// (get) Token: 0x0600298A RID: 10634 RVA: 0x000C6104 File Offset: 0x000C4304
		// (set) Token: 0x0600298B RID: 10635 RVA: 0x000105FF File Offset: 0x0000E7FF
		public unsafe static ObjectBounds.QueryConfig _defaultQConfig
		{
			get
			{
				ObjectBounds.QueryConfig queryConfig;
				IL2CPP.il2cpp_field_static_get_value(ObjectBounds.NativeFieldInfoPtr__defaultQConfig, (void*)(&queryConfig));
				return queryConfig;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ObjectBounds.NativeFieldInfoPtr__defaultQConfig, (void*)(&value));
			}
		}

		// Token: 0x04002025 RID: 8229
		private static readonly IntPtr NativeFieldInfoPtr__defaultQConfig;

		// Token: 0x04002026 RID: 8230
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultQConfig_Public_Static_get_QueryConfig_0;

		// Token: 0x04002027 RID: 8231
		private static readonly IntPtr NativeMethodInfoPtr_CalcScreenRect_Public_Static_Rect_GameObject_Camera_QueryConfig_0;

		// Token: 0x04002028 RID: 8232
		private static readonly IntPtr NativeMethodInfoPtr_CalcSpriteWorldOBB_Public_Static_OBB_GameObject_0;

		// Token: 0x04002029 RID: 8233
		private static readonly IntPtr NativeMethodInfoPtr_CalcSpriteWorldAABB_Public_Static_AABB_GameObject_0;

		// Token: 0x0400202A RID: 8234
		private static readonly IntPtr NativeMethodInfoPtr_CalcSpriteModelAABB_Public_Static_AABB_GameObject_0;

		// Token: 0x0400202B RID: 8235
		private static readonly IntPtr NativeMethodInfoPtr_GetMeshWorldOBB_Public_Static_OBB_GameObject_0;

		// Token: 0x0400202C RID: 8236
		private static readonly IntPtr NativeMethodInfoPtr_GetMeshWorldAABB_Public_Static_AABB_GameObject_0;

		// Token: 0x0400202D RID: 8237
		private static readonly IntPtr NativeMethodInfoPtr_CalcObjectCollectionWorldAABB_Public_Static_AABB_IEnumerable_1_GameObject_QueryConfig_0;

		// Token: 0x0400202E RID: 8238
		private static readonly IntPtr NativeMethodInfoPtr_CalcHierarchyCollectionWorldAABB_Public_Static_AABB_List_1_GameObject_QueryConfig_0;

		// Token: 0x0400202F RID: 8239
		private static readonly IntPtr NativeMethodInfoPtr_CalcHierarchyWorldOBB_Public_Static_OBB_GameObject_QueryConfig_0;

		// Token: 0x04002030 RID: 8240
		private static readonly IntPtr NativeMethodInfoPtr_CalcHierarchyWorldAABB_Public_Static_AABB_GameObject_QueryConfig_0;

		// Token: 0x04002031 RID: 8241
		private static readonly IntPtr NativeMethodInfoPtr_CalcWorldOBB_Public_Static_OBB_GameObject_QueryConfig_0;

		// Token: 0x04002032 RID: 8242
		private static readonly IntPtr NativeMethodInfoPtr_CalcWorldAABB_Public_Static_AABB_GameObject_QueryConfig_0;

		// Token: 0x04002033 RID: 8243
		private static readonly IntPtr NativeMethodInfoPtr_CalcMeshWorldAABB_Public_Static_AABB_GameObject_0;

		// Token: 0x04002034 RID: 8244
		private static readonly IntPtr NativeMethodInfoPtr_CalcHierarchyModelAABB_Public_Static_AABB_GameObject_QueryConfig_0;

		// Token: 0x04002035 RID: 8245
		private static readonly IntPtr NativeMethodInfoPtr_CalcMeshModelAABB_Public_Static_AABB_GameObject_0;

		// Token: 0x04002036 RID: 8246
		private static readonly IntPtr NativeMethodInfoPtr_CalcModelAABB_Public_Static_AABB_GameObject_QueryConfig_GameObjectType_0;

		// Token: 0x020003C8 RID: 968
		[StructLayout(2)]
		public struct QueryConfig
		{
			// Token: 0x06004C95 RID: 19605 RVA: 0x0014DEC8 File Offset: 0x0014C0C8
			// Note: this type is marked as 'beforefieldinit'.
			static QueryConfig()
			{
				Il2CppClassPointerStore<ObjectBounds.QueryConfig>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ObjectBounds>.NativeClassPtr, "QueryConfig");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectBounds.QueryConfig>.NativeClassPtr);
				ObjectBounds.QueryConfig.NativeFieldInfoPtr_ObjectTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectBounds.QueryConfig>.NativeClassPtr, "ObjectTypes");
				ObjectBounds.QueryConfig.NativeFieldInfoPtr_NoVolumeSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectBounds.QueryConfig>.NativeClassPtr, "NoVolumeSize");
			}

			// Token: 0x06004C96 RID: 19606 RVA: 0x0001CCBD File Offset: 0x0001AEBD
			public global::Il2CppSystem.Object BoxIl2CppObject()
			{
				return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ObjectBounds.QueryConfig>.NativeClassPtr, ref this));
			}

			// Token: 0x04003B80 RID: 15232
			private static readonly IntPtr NativeFieldInfoPtr_ObjectTypes;

			// Token: 0x04003B81 RID: 15233
			private static readonly IntPtr NativeFieldInfoPtr_NoVolumeSize;

			// Token: 0x04003B82 RID: 15234
			[FieldOffset(0)]
			public IntPtr ObjectTypes;

			// Token: 0x04003B83 RID: 15235
			[FieldOffset(4)]
			public IntPtr NoVolumeSize;
		}
	}
}
