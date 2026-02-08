using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace RLD
{
	// Token: 0x020001B7 RID: 439
	public class RTScene : MonoSingleton<RTScene>
	{
		// Token: 0x060021E2 RID: 8674 RVA: 0x000A7C1C File Offset: 0x000A5E1C
		// Note: this type is marked as 'beforefieldinit'.
		static RTScene()
		{
			Il2CppClassPointerStore<RTScene>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "RTScene");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTScene>.NativeClassPtr);
			RTScene.NativeFieldInfoPtr_CanRenderCameraIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTScene>.NativeClassPtr, "CanRenderCameraIcon");
			RTScene.NativeFieldInfoPtr__yesNoAnswer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTScene>.NativeClassPtr, "_yesNoAnswer");
			RTScene.NativeFieldInfoPtr__settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTScene>.NativeClassPtr, "_settings");
			RTScene.NativeFieldInfoPtr__lookAndFeel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTScene>.NativeClassPtr, "_lookAndFeel");
			RTScene.NativeFieldInfoPtr__iconRenderIgnoreCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTScene>.NativeClassPtr, "_iconRenderIgnoreCamera");
			RTScene.NativeFieldInfoPtr__ignoredRootObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTScene>.NativeClassPtr, "_ignoredRootObjects");
			RTScene.NativeFieldInfoPtr__hoverableSceneEntityContainers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTScene>.NativeClassPtr, "_hoverableSceneEntityContainers");
			RTScene.NativeFieldInfoPtr__sceneTree = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTScene>.NativeClassPtr, "_sceneTree");
			RTScene.NativeFieldInfoPtr__rootGameObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTScene>.NativeClassPtr, "_rootGameObjects");
			RTScene.NativeFieldInfoPtr__lights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTScene>.NativeClassPtr, "_lights");
			RTScene.NativeFieldInfoPtr__particleSystems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTScene>.NativeClassPtr, "_particleSystems");
			RTScene.NativeFieldInfoPtr__cameras = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTScene>.NativeClassPtr, "_cameras");
			RTScene.NativeFieldInfoPtr__childrenAndSelfBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTScene>.NativeClassPtr, "_childrenAndSelfBuffer");
			RTScene.NativeFieldInfoPtr__objectHitBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTScene>.NativeClassPtr, "_objectHitBuffer");
			RTScene.NativeMethodInfoPtr_get_Settings_Public_get_SceneSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTScene>.NativeClassPtr, 100668427);
			RTScene.NativeMethodInfoPtr_get_LookAndFeel_Public_get_SceneLookAndFeel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTScene>.NativeClassPtr, 100668428);
			RTScene.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTScene>.NativeClassPtr, 100668451);
			RTScene.NativeMethodInfoPtr_SetRootObjectIgnored_Public_Void_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTScene>.NativeClassPtr, 100668429);
			RTScene.NativeMethodInfoPtr_OnGameObjectWillBeDestroyed_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTScene>.NativeClassPtr, 100668430);
			RTScene.NativeMethodInfoPtr_AddIconRenderIgnoreCamera_Public_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTScene>.NativeClassPtr, 100668431);
			RTScene.NativeMethodInfoPtr_IsIconRenderIgnoreCamera_Public_Boolean_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTScene>.NativeClassPtr, 100668432);
			RTScene.NativeMethodInfoPtr_CalculateBounds_Public_AABB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTScene>.NativeClassPtr, 100668433);
			RTScene.NativeMethodInfoPtr_IsAnySceneEntityHovered_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTScene>.NativeClassPtr, 100668434);
			RTScene.NativeMethodInfoPtr_RegisterHoverableSceneEntityContainer_Public_Void_IHoverableSceneEntityContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTScene>.NativeClassPtr, 100668435);
			RTScene.NativeMethodInfoPtr_IsAnyUIElementHovered_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTScene>.NativeClassPtr, 100668436);
			RTScene.NativeMethodInfoPtr_GetHoveredUIElements_Public_List_1_RaycastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTScene>.NativeClassPtr, 100668437);
			RTScene.NativeMethodInfoPtr_GetSceneObjects_Public_Il2CppReferenceArray_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTScene>.NativeClassPtr, 100668438);
			RTScene.NativeMethodInfoPtr_OverlapBox_Public_Boolean_OBB_List_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTScene>.NativeClassPtr, 100668439);
			RTScene.NativeMethodInfoPtr_OverlapBox_Public_Boolean_OBB_SceneOverlapFilter_List_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTScene>.NativeClassPtr, 100668440);
			RTScene.NativeMethodInfoPtr_Raycast_Public_SceneRaycastHit_Ray_SceneRaycastPrecision_SceneRaycastFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTScene>.NativeClassPtr, 100668441);
			RTScene.NativeMethodInfoPtr_RaycastAllObjects_Public_Boolean_Ray_SceneRaycastPrecision_List_1_GameObjectRayHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTScene>.NativeClassPtr, 100668442);
			RTScene.NativeMethodInfoPtr_RaycastAllObjectsSorted_Public_Boolean_Ray_SceneRaycastPrecision_List_1_GameObjectRayHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTScene>.NativeClassPtr, 100668443);
			RTScene.NativeMethodInfoPtr_RaycastAllObjectsSorted_Public_Boolean_Ray_SceneRaycastPrecision_SceneRaycastFilter_List_1_GameObjectRayHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTScene>.NativeClassPtr, 100668444);
			RTScene.NativeMethodInfoPtr_RaycastMeshObject_Public_GameObjectRayHit_Ray_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTScene>.NativeClassPtr, 100668445);
			RTScene.NativeMethodInfoPtr_RaycastMeshObjectReverseIfFail_Public_GameObjectRayHit_Ray_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTScene>.NativeClassPtr, 100668446);
			RTScene.NativeMethodInfoPtr_RaycastSpriteObject_Public_GameObjectRayHit_Ray_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTScene>.NativeClassPtr, 100668447);
			RTScene.NativeMethodInfoPtr_RaycastSceneGridIfVisible_Public_XZGridRayHit_Ray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTScene>.NativeClassPtr, 100668448);
			RTScene.NativeMethodInfoPtr_Update_SystemCall_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTScene>.NativeClassPtr, 100668449);
			RTScene.NativeMethodInfoPtr_Render_SystemCall_Public_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTScene>.NativeClassPtr, 100668450);
		}

		// Token: 0x17000BFB RID: 3067
		// (get) Token: 0x060021E3 RID: 8675 RVA: 0x000A7F58 File Offset: 0x000A6158
		public unsafe SceneSettings Settings
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 21537, RefRangeEnd = 21548, XrefRangeStart = 21537, XrefRangeEnd = 21548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTScene.NativeMethodInfoPtr_get_Settings_Public_get_SceneSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SceneSettings>(intPtr3) : null;
			}
		}

		// Token: 0x17000BFC RID: 3068
		// (get) Token: 0x060021E4 RID: 8676 RVA: 0x000A7F98 File Offset: 0x000A6198
		public unsafe SceneLookAndFeel LookAndFeel
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 23521, RefRangeEnd = 23535, XrefRangeStart = 23521, XrefRangeEnd = 23535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTScene.NativeMethodInfoPtr_get_LookAndFeel_Public_get_SceneLookAndFeel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SceneLookAndFeel>(intPtr3) : null;
			}
		}

		// Token: 0x060021E5 RID: 8677 RVA: 0x000A7FD8 File Offset: 0x000A61D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86312, XrefRangeEnd = 86426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RTScene()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTScene>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTScene.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021E6 RID: 8678 RVA: 0x000A8014 File Offset: 0x000A6214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86426, XrefRangeEnd = 86433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRootObjectIgnored(GameObject root, bool ignored)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignored;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTScene.NativeMethodInfoPtr_SetRootObjectIgnored_Public_Void_GameObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021E7 RID: 8679 RVA: 0x000A8064 File Offset: 0x000A6264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86433, XrefRangeEnd = 86491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGameObjectWillBeDestroyed(GameObject gameObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTScene.NativeMethodInfoPtr_OnGameObjectWillBeDestroyed_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021E8 RID: 8680 RVA: 0x000A80A8 File Offset: 0x000A62A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86491, XrefRangeEnd = 86497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddIconRenderIgnoreCamera(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTScene.NativeMethodInfoPtr_AddIconRenderIgnoreCamera_Public_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021E9 RID: 8681 RVA: 0x000A80EC File Offset: 0x000A62EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86497, XrefRangeEnd = 86501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsIconRenderIgnoreCamera(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTScene.NativeMethodInfoPtr_IsIconRenderIgnoreCamera_Public_Boolean_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060021EA RID: 8682 RVA: 0x000A813C File Offset: 0x000A633C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 86550, RefRangeEnd = 86551, XrefRangeStart = 86501, XrefRangeEnd = 86550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AABB CalculateBounds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTScene.NativeMethodInfoPtr_CalculateBounds_Public_AABB_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AABB>(intPtr3) : null;
		}

		// Token: 0x060021EB RID: 8683 RVA: 0x000A817C File Offset: 0x000A637C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 86564, RefRangeEnd = 86566, XrefRangeStart = 86551, XrefRangeEnd = 86564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAnySceneEntityHovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTScene.NativeMethodInfoPtr_IsAnySceneEntityHovered_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021EC RID: 8684 RVA: 0x000A81B8 File Offset: 0x000A63B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 86572, RefRangeEnd = 86573, XrefRangeStart = 86566, XrefRangeEnd = 86572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterHoverableSceneEntityContainer(IHoverableSceneEntityContainer container)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(container);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTScene.NativeMethodInfoPtr_RegisterHoverableSceneEntityContainer_Public_Void_IHoverableSceneEntityContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021ED RID: 8685 RVA: 0x000A81FC File Offset: 0x000A63FC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 86575, RefRangeEnd = 86579, XrefRangeStart = 86573, XrefRangeEnd = 86575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAnyUIElementHovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTScene.NativeMethodInfoPtr_IsAnyUIElementHovered_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021EE RID: 8686 RVA: 0x000A8238 File Offset: 0x000A6438
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 86631, RefRangeEnd = 86633, XrefRangeStart = 86579, XrefRangeEnd = 86631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<RaycastResult> GetHoveredUIElements()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTScene.NativeMethodInfoPtr_GetHoveredUIElements_Public_List_1_RaycastResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<RaycastResult>>(intPtr3) : null;
		}

		// Token: 0x060021EF RID: 8687 RVA: 0x000A8278 File Offset: 0x000A6478
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 86639, RefRangeEnd = 86640, XrefRangeStart = 86633, XrefRangeEnd = 86639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<GameObject> GetSceneObjects()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTScene.NativeMethodInfoPtr_GetSceneObjects_Public_Il2CppReferenceArray_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr3) : null;
		}

		// Token: 0x060021F0 RID: 8688 RVA: 0x000A82B8 File Offset: 0x000A64B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 86646, RefRangeEnd = 86648, XrefRangeStart = 86640, XrefRangeEnd = 86646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTScene.NativeMethodInfoPtr_OverlapBox_Public_Boolean_OBB_List_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021F1 RID: 8689 RVA: 0x000A8318 File Offset: 0x000A6518
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 86659, RefRangeEnd = 86660, XrefRangeStart = 86648, XrefRangeEnd = 86659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool OverlapBox(OBB obb, SceneOverlapFilter overlapFilter, List<GameObject> gameObjects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(overlapFilter);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(gameObjects);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTScene.NativeMethodInfoPtr_OverlapBox_Public_Boolean_OBB_SceneOverlapFilter_List_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021F2 RID: 8690 RVA: 0x000A838C File Offset: 0x000A658C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 86685, RefRangeEnd = 86690, XrefRangeStart = 86660, XrefRangeEnd = 86685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SceneRaycastHit Raycast(Ray ray, SceneRaycastPrecision rtRaycastPrecision, SceneRaycastFilter raycastFilter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rtRaycastPrecision);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(raycastFilter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTScene.NativeMethodInfoPtr_Raycast_Public_SceneRaycastHit_Ray_SceneRaycastPrecision_SceneRaycastFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SceneRaycastHit>(intPtr3) : null;
		}

		// Token: 0x060021F3 RID: 8691 RVA: 0x000A8400 File Offset: 0x000A6600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86690, XrefRangeEnd = 86695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool RaycastAllObjects(Ray ray, SceneRaycastPrecision rtRaycastPrecision, List<GameObjectRayHit> hits)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rtRaycastPrecision);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hits);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTScene.NativeMethodInfoPtr_RaycastAllObjects_Public_Boolean_Ray_SceneRaycastPrecision_List_1_GameObjectRayHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021F4 RID: 8692 RVA: 0x000A8474 File Offset: 0x000A6674
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 86727, RefRangeEnd = 86729, XrefRangeStart = 86695, XrefRangeEnd = 86727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool RaycastAllObjectsSorted(Ray ray, SceneRaycastPrecision raycastPresicion, List<GameObjectRayHit> hits)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTScene.NativeMethodInfoPtr_RaycastAllObjectsSorted_Public_Boolean_Ray_SceneRaycastPrecision_List_1_GameObjectRayHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021F5 RID: 8693 RVA: 0x000A84E8 File Offset: 0x000A66E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86729, XrefRangeEnd = 86733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool RaycastAllObjectsSorted(Ray ray, SceneRaycastPrecision rtRaycastPrecision, SceneRaycastFilter raycastFilter, List<GameObjectRayHit> hits)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rtRaycastPrecision);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(raycastFilter);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hits);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTScene.NativeMethodInfoPtr_RaycastAllObjectsSorted_Public_Boolean_Ray_SceneRaycastPrecision_SceneRaycastFilter_List_1_GameObjectRayHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060021F6 RID: 8694 RVA: 0x000A856C File Offset: 0x000A676C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 86738, RefRangeEnd = 86741, XrefRangeStart = 86733, XrefRangeEnd = 86738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameObjectRayHit RaycastMeshObject(Ray ray, GameObject meshObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(meshObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTScene.NativeMethodInfoPtr_RaycastMeshObject_Public_GameObjectRayHit_Ray_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObjectRayHit>(intPtr3) : null;
		}

		// Token: 0x060021F7 RID: 8695 RVA: 0x000A85D0 File Offset: 0x000A67D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86741, XrefRangeEnd = 86745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameObjectRayHit RaycastMeshObjectReverseIfFail(Ray ray, GameObject meshObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(meshObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTScene.NativeMethodInfoPtr_RaycastMeshObjectReverseIfFail_Public_GameObjectRayHit_Ray_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObjectRayHit>(intPtr3) : null;
		}

		// Token: 0x060021F8 RID: 8696 RVA: 0x000A8634 File Offset: 0x000A6834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86745, XrefRangeEnd = 86746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameObjectRayHit RaycastSpriteObject(Ray ray, GameObject spriteObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ray);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(spriteObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTScene.NativeMethodInfoPtr_RaycastSpriteObject_Public_GameObjectRayHit_Ray_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObjectRayHit>(intPtr3) : null;
		}

		// Token: 0x060021F9 RID: 8697 RVA: 0x000A8698 File Offset: 0x000A6898
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 86771, RefRangeEnd = 86774, XrefRangeStart = 86746, XrefRangeEnd = 86771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XZGridRayHit RaycastSceneGridIfVisible(Ray ray)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ray);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTScene.NativeMethodInfoPtr_RaycastSceneGridIfVisible_Public_XZGridRayHit_Ray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XZGridRayHit>(intPtr3) : null;
			}
		}

		// Token: 0x060021FA RID: 8698 RVA: 0x000A86E8 File Offset: 0x000A68E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 86841, RefRangeEnd = 86842, XrefRangeStart = 86774, XrefRangeEnd = 86841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update_SystemCall()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTScene.NativeMethodInfoPtr_Update_SystemCall_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060021FB RID: 8699 RVA: 0x000A871C File Offset: 0x000A691C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 86981, RefRangeEnd = 86982, XrefRangeStart = 86842, XrefRangeEnd = 86981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Render_SystemCall(Camera renderCamera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderCamera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTScene.NativeMethodInfoPtr_Render_SystemCall_Public_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060021FC RID: 8700 RVA: 0x0000DD25 File Offset: 0x0000BF25
		public RTScene(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BED RID: 3053
		// (get) Token: 0x060021FD RID: 8701 RVA: 0x000A8760 File Offset: 0x000A6960
		// (set) Token: 0x060021FE RID: 8702 RVA: 0x0000DD2E File Offset: 0x0000BF2E
		public unsafe SceneCanRenderCameraIconHandler CanRenderCameraIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTScene.NativeFieldInfoPtr_CanRenderCameraIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneCanRenderCameraIconHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTScene.NativeFieldInfoPtr_CanRenderCameraIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BEE RID: 3054
		// (get) Token: 0x060021FF RID: 8703 RVA: 0x000A8790 File Offset: 0x000A6990
		// (set) Token: 0x06002200 RID: 8704 RVA: 0x0000DD4D File Offset: 0x0000BF4D
		public unsafe YesNoAnswer _yesNoAnswer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTScene.NativeFieldInfoPtr__yesNoAnswer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<YesNoAnswer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTScene.NativeFieldInfoPtr__yesNoAnswer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BEF RID: 3055
		// (get) Token: 0x06002201 RID: 8705 RVA: 0x000A87C0 File Offset: 0x000A69C0
		// (set) Token: 0x06002202 RID: 8706 RVA: 0x0000DD6C File Offset: 0x0000BF6C
		public unsafe SceneSettings _settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTScene.NativeFieldInfoPtr__settings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTScene.NativeFieldInfoPtr__settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BF0 RID: 3056
		// (get) Token: 0x06002203 RID: 8707 RVA: 0x000A87F0 File Offset: 0x000A69F0
		// (set) Token: 0x06002204 RID: 8708 RVA: 0x0000DD8B File Offset: 0x0000BF8B
		public unsafe SceneLookAndFeel _lookAndFeel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTScene.NativeFieldInfoPtr__lookAndFeel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneLookAndFeel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTScene.NativeFieldInfoPtr__lookAndFeel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BF1 RID: 3057
		// (get) Token: 0x06002205 RID: 8709 RVA: 0x000A8820 File Offset: 0x000A6A20
		// (set) Token: 0x06002206 RID: 8710 RVA: 0x0000DDAA File Offset: 0x0000BFAA
		public unsafe List<Camera> _iconRenderIgnoreCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTScene.NativeFieldInfoPtr__iconRenderIgnoreCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Camera>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTScene.NativeFieldInfoPtr__iconRenderIgnoreCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BF2 RID: 3058
		// (get) Token: 0x06002207 RID: 8711 RVA: 0x000A8850 File Offset: 0x000A6A50
		// (set) Token: 0x06002208 RID: 8712 RVA: 0x0000DDC9 File Offset: 0x0000BFC9
		public unsafe HashSet<GameObject> _ignoredRootObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTScene.NativeFieldInfoPtr__ignoredRootObjects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTScene.NativeFieldInfoPtr__ignoredRootObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BF3 RID: 3059
		// (get) Token: 0x06002209 RID: 8713 RVA: 0x000A8880 File Offset: 0x000A6A80
		// (set) Token: 0x0600220A RID: 8714 RVA: 0x0000DDE8 File Offset: 0x0000BFE8
		public unsafe List<IHoverableSceneEntityContainer> _hoverableSceneEntityContainers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTScene.NativeFieldInfoPtr__hoverableSceneEntityContainers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IHoverableSceneEntityContainer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTScene.NativeFieldInfoPtr__hoverableSceneEntityContainers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BF4 RID: 3060
		// (get) Token: 0x0600220B RID: 8715 RVA: 0x000A88B0 File Offset: 0x000A6AB0
		// (set) Token: 0x0600220C RID: 8716 RVA: 0x0000DE07 File Offset: 0x0000C007
		public unsafe SceneTree _sceneTree
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTScene.NativeFieldInfoPtr__sceneTree);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneTree>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTScene.NativeFieldInfoPtr__sceneTree), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BF5 RID: 3061
		// (get) Token: 0x0600220D RID: 8717 RVA: 0x000A88E0 File Offset: 0x000A6AE0
		// (set) Token: 0x0600220E RID: 8718 RVA: 0x0000DE26 File Offset: 0x0000C026
		public unsafe List<GameObject> _rootGameObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTScene.NativeFieldInfoPtr__rootGameObjects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTScene.NativeFieldInfoPtr__rootGameObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BF6 RID: 3062
		// (get) Token: 0x0600220F RID: 8719 RVA: 0x000A8910 File Offset: 0x000A6B10
		// (set) Token: 0x06002210 RID: 8720 RVA: 0x0000DE45 File Offset: 0x0000C045
		public unsafe List<Light> _lights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTScene.NativeFieldInfoPtr__lights);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Light>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTScene.NativeFieldInfoPtr__lights), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BF7 RID: 3063
		// (get) Token: 0x06002211 RID: 8721 RVA: 0x000A8940 File Offset: 0x000A6B40
		// (set) Token: 0x06002212 RID: 8722 RVA: 0x0000DE64 File Offset: 0x0000C064
		public unsafe List<ParticleSystem> _particleSystems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTScene.NativeFieldInfoPtr__particleSystems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ParticleSystem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTScene.NativeFieldInfoPtr__particleSystems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BF8 RID: 3064
		// (get) Token: 0x06002213 RID: 8723 RVA: 0x000A8970 File Offset: 0x000A6B70
		// (set) Token: 0x06002214 RID: 8724 RVA: 0x0000DE83 File Offset: 0x0000C083
		public unsafe List<Camera> _cameras
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTScene.NativeFieldInfoPtr__cameras);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Camera>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTScene.NativeFieldInfoPtr__cameras), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BF9 RID: 3065
		// (get) Token: 0x06002215 RID: 8725 RVA: 0x000A89A0 File Offset: 0x000A6BA0
		// (set) Token: 0x06002216 RID: 8726 RVA: 0x0000DEA2 File Offset: 0x0000C0A2
		public unsafe List<GameObject> _childrenAndSelfBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTScene.NativeFieldInfoPtr__childrenAndSelfBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTScene.NativeFieldInfoPtr__childrenAndSelfBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BFA RID: 3066
		// (get) Token: 0x06002217 RID: 8727 RVA: 0x000A89D0 File Offset: 0x000A6BD0
		// (set) Token: 0x06002218 RID: 8728 RVA: 0x0000DEC1 File Offset: 0x0000C0C1
		public unsafe List<GameObjectRayHit> _objectHitBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTScene.NativeFieldInfoPtr__objectHitBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObjectRayHit>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTScene.NativeFieldInfoPtr__objectHitBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001A58 RID: 6744
		private static readonly IntPtr NativeFieldInfoPtr_CanRenderCameraIcon;

		// Token: 0x04001A59 RID: 6745
		private static readonly IntPtr NativeFieldInfoPtr__yesNoAnswer;

		// Token: 0x04001A5A RID: 6746
		private static readonly IntPtr NativeFieldInfoPtr__settings;

		// Token: 0x04001A5B RID: 6747
		private static readonly IntPtr NativeFieldInfoPtr__lookAndFeel;

		// Token: 0x04001A5C RID: 6748
		private static readonly IntPtr NativeFieldInfoPtr__iconRenderIgnoreCamera;

		// Token: 0x04001A5D RID: 6749
		private static readonly IntPtr NativeFieldInfoPtr__ignoredRootObjects;

		// Token: 0x04001A5E RID: 6750
		private static readonly IntPtr NativeFieldInfoPtr__hoverableSceneEntityContainers;

		// Token: 0x04001A5F RID: 6751
		private static readonly IntPtr NativeFieldInfoPtr__sceneTree;

		// Token: 0x04001A60 RID: 6752
		private static readonly IntPtr NativeFieldInfoPtr__rootGameObjects;

		// Token: 0x04001A61 RID: 6753
		private static readonly IntPtr NativeFieldInfoPtr__lights;

		// Token: 0x04001A62 RID: 6754
		private static readonly IntPtr NativeFieldInfoPtr__particleSystems;

		// Token: 0x04001A63 RID: 6755
		private static readonly IntPtr NativeFieldInfoPtr__cameras;

		// Token: 0x04001A64 RID: 6756
		private static readonly IntPtr NativeFieldInfoPtr__childrenAndSelfBuffer;

		// Token: 0x04001A65 RID: 6757
		private static readonly IntPtr NativeFieldInfoPtr__objectHitBuffer;

		// Token: 0x04001A66 RID: 6758
		private static readonly IntPtr NativeMethodInfoPtr_get_Settings_Public_get_SceneSettings_0;

		// Token: 0x04001A67 RID: 6759
		private static readonly IntPtr NativeMethodInfoPtr_get_LookAndFeel_Public_get_SceneLookAndFeel_0;

		// Token: 0x04001A68 RID: 6760
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001A69 RID: 6761
		private static readonly IntPtr NativeMethodInfoPtr_SetRootObjectIgnored_Public_Void_GameObject_Boolean_0;

		// Token: 0x04001A6A RID: 6762
		private static readonly IntPtr NativeMethodInfoPtr_OnGameObjectWillBeDestroyed_Public_Void_GameObject_0;

		// Token: 0x04001A6B RID: 6763
		private static readonly IntPtr NativeMethodInfoPtr_AddIconRenderIgnoreCamera_Public_Void_Camera_0;

		// Token: 0x04001A6C RID: 6764
		private static readonly IntPtr NativeMethodInfoPtr_IsIconRenderIgnoreCamera_Public_Boolean_Camera_0;

		// Token: 0x04001A6D RID: 6765
		private static readonly IntPtr NativeMethodInfoPtr_CalculateBounds_Public_AABB_0;

		// Token: 0x04001A6E RID: 6766
		private static readonly IntPtr NativeMethodInfoPtr_IsAnySceneEntityHovered_Public_Boolean_0;

		// Token: 0x04001A6F RID: 6767
		private static readonly IntPtr NativeMethodInfoPtr_RegisterHoverableSceneEntityContainer_Public_Void_IHoverableSceneEntityContainer_0;

		// Token: 0x04001A70 RID: 6768
		private static readonly IntPtr NativeMethodInfoPtr_IsAnyUIElementHovered_Public_Boolean_0;

		// Token: 0x04001A71 RID: 6769
		private static readonly IntPtr NativeMethodInfoPtr_GetHoveredUIElements_Public_List_1_RaycastResult_0;

		// Token: 0x04001A72 RID: 6770
		private static readonly IntPtr NativeMethodInfoPtr_GetSceneObjects_Public_Il2CppReferenceArray_1_GameObject_0;

		// Token: 0x04001A73 RID: 6771
		private static readonly IntPtr NativeMethodInfoPtr_OverlapBox_Public_Boolean_OBB_List_1_GameObject_0;

		// Token: 0x04001A74 RID: 6772
		private static readonly IntPtr NativeMethodInfoPtr_OverlapBox_Public_Boolean_OBB_SceneOverlapFilter_List_1_GameObject_0;

		// Token: 0x04001A75 RID: 6773
		private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_SceneRaycastHit_Ray_SceneRaycastPrecision_SceneRaycastFilter_0;

		// Token: 0x04001A76 RID: 6774
		private static readonly IntPtr NativeMethodInfoPtr_RaycastAllObjects_Public_Boolean_Ray_SceneRaycastPrecision_List_1_GameObjectRayHit_0;

		// Token: 0x04001A77 RID: 6775
		private static readonly IntPtr NativeMethodInfoPtr_RaycastAllObjectsSorted_Public_Boolean_Ray_SceneRaycastPrecision_List_1_GameObjectRayHit_0;

		// Token: 0x04001A78 RID: 6776
		private static readonly IntPtr NativeMethodInfoPtr_RaycastAllObjectsSorted_Public_Boolean_Ray_SceneRaycastPrecision_SceneRaycastFilter_List_1_GameObjectRayHit_0;

		// Token: 0x04001A79 RID: 6777
		private static readonly IntPtr NativeMethodInfoPtr_RaycastMeshObject_Public_GameObjectRayHit_Ray_GameObject_0;

		// Token: 0x04001A7A RID: 6778
		private static readonly IntPtr NativeMethodInfoPtr_RaycastMeshObjectReverseIfFail_Public_GameObjectRayHit_Ray_GameObject_0;

		// Token: 0x04001A7B RID: 6779
		private static readonly IntPtr NativeMethodInfoPtr_RaycastSpriteObject_Public_GameObjectRayHit_Ray_GameObject_0;

		// Token: 0x04001A7C RID: 6780
		private static readonly IntPtr NativeMethodInfoPtr_RaycastSceneGridIfVisible_Public_XZGridRayHit_Ray_0;

		// Token: 0x04001A7D RID: 6781
		private static readonly IntPtr NativeMethodInfoPtr_Update_SystemCall_Public_Void_0;

		// Token: 0x04001A7E RID: 6782
		private static readonly IntPtr NativeMethodInfoPtr_Render_SystemCall_Public_Void_Camera_0;

		// Token: 0x020003A5 RID: 933
		[ObfuscatedName("RLD.RTScene+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06004BB0 RID: 19376 RVA: 0x0014B4F4 File Offset: 0x001496F4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<RTScene.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RTScene>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTScene.__c>.NativeClassPtr);
				RTScene.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTScene.__c>.NativeClassPtr, "<>9");
				RTScene.__c.NativeFieldInfoPtr___9__26_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTScene.__c>.NativeClassPtr, "<>9__26_0");
				RTScene.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTScene.__c>.NativeClassPtr, 100668453);
				RTScene.__c.NativeMethodInfoPtr__GetHoveredUIElements_b__26_0_Internal_Boolean_RaycastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTScene.__c>.NativeClassPtr, 100668454);
			}

			// Token: 0x06004BB1 RID: 19377 RVA: 0x0014B570 File Offset: 0x00149770
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTScene.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTScene.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004BB2 RID: 19378 RVA: 0x0014B5AC File Offset: 0x001497AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86304, XrefRangeEnd = 86312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetHoveredUIElements_b__26_0(RaycastResult item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTScene.__c.NativeMethodInfoPtr__GetHoveredUIElements_b__26_0_Internal_Boolean_RaycastResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004BB3 RID: 19379 RVA: 0x0001C573 File Offset: 0x0001A773
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700197B RID: 6523
			// (get) Token: 0x06004BB4 RID: 19380 RVA: 0x0014B5FC File Offset: 0x001497FC
			// (set) Token: 0x06004BB5 RID: 19381 RVA: 0x0001C57C File Offset: 0x0001A77C
			public unsafe static RTScene.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RTScene.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTScene.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RTScene.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700197C RID: 6524
			// (get) Token: 0x06004BB6 RID: 19382 RVA: 0x0014B624 File Offset: 0x00149824
			// (set) Token: 0x06004BB7 RID: 19383 RVA: 0x0001C58E File Offset: 0x0001A78E
			public unsafe static Predicate<RaycastResult> __9__26_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RTScene.__c.NativeFieldInfoPtr___9__26_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<RaycastResult>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RTScene.__c.NativeFieldInfoPtr___9__26_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003AA6 RID: 15014
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04003AA7 RID: 15015
			private static readonly IntPtr NativeFieldInfoPtr___9__26_0;

			// Token: 0x04003AA8 RID: 15016
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003AA9 RID: 15017
			private static readonly IntPtr NativeMethodInfoPtr__GetHoveredUIElements_b__26_0_Internal_Boolean_RaycastResult_0;
		}
	}
}
