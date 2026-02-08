using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000071 RID: 113
	public class RTGizmosEngine : MonoSingleton<RTGizmosEngine>
	{
		// Token: 0x0600083C RID: 2108 RVA: 0x000415A0 File Offset: 0x0003F7A0
		// Note: this type is marked as 'beforefieldinit'.
		static RTGizmosEngine()
		{
			Il2CppClassPointerStore<RTGizmosEngine>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "RTGizmosEngine");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTGizmosEngine>.NativeClassPtr);
			RTGizmosEngine.NativeFieldInfoPtr_CanDoHoverUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTGizmosEngine>.NativeClassPtr, "CanDoHoverUpdate");
			RTGizmosEngine.NativeFieldInfoPtr__mainToolbar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTGizmosEngine>.NativeClassPtr, "_mainToolbar");
			RTGizmosEngine.NativeFieldInfoPtr__settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTGizmosEngine>.NativeClassPtr, "_settings");
			RTGizmosEngine.NativeFieldInfoPtr__pipelineStage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTGizmosEngine>.NativeClassPtr, "_pipelineStage");
			RTGizmosEngine.NativeFieldInfoPtr__draggedGizmo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTGizmosEngine>.NativeClassPtr, "_draggedGizmo");
			RTGizmosEngine.NativeFieldInfoPtr__justReleasedDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTGizmosEngine>.NativeClassPtr, "_justReleasedDrag");
			RTGizmosEngine.NativeFieldInfoPtr__hoveredGizmo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTGizmosEngine>.NativeClassPtr, "_hoveredGizmo");
			RTGizmosEngine.NativeFieldInfoPtr__gizmoHoverInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTGizmosEngine>.NativeClassPtr, "_gizmoHoverInfo");
			RTGizmosEngine.NativeFieldInfoPtr__gizmos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTGizmosEngine>.NativeClassPtr, "_gizmos");
			RTGizmosEngine.NativeFieldInfoPtr__sceneGizmos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTGizmosEngine>.NativeClassPtr, "_sceneGizmos");
			RTGizmosEngine.NativeFieldInfoPtr__sceneGizmoCameras = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTGizmosEngine>.NativeClassPtr, "_sceneGizmoCameras");
			RTGizmosEngine.NativeFieldInfoPtr__renderCameras = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTGizmosEngine>.NativeClassPtr, "_renderCameras");
			RTGizmosEngine.NativeFieldInfoPtr__sharedSceneGizmoLookAndFeel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTGizmosEngine>.NativeClassPtr, "_sharedSceneGizmoLookAndFeel");
			RTGizmosEngine.NativeMethodInfoPtr_get_Settings_Public_get_GizmoEngineSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTGizmosEngine>.NativeClassPtr, 100664551);
			RTGizmosEngine.NativeMethodInfoPtr_get_PipelineStage_Public_get_GizmosEnginePipelineStage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTGizmosEngine>.NativeClassPtr, 100664552);
			RTGizmosEngine.NativeMethodInfoPtr_get_RenderStageCamera_Public_get_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTGizmosEngine>.NativeClassPtr, 100664553);
			RTGizmosEngine.NativeMethodInfoPtr_get_HasHoveredSceneEntity_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTGizmosEngine>.NativeClassPtr, 100664554);
			RTGizmosEngine.NativeMethodInfoPtr_get_IsAnyGizmoHovered_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTGizmosEngine>.NativeClassPtr, 100664555);
			RTGizmosEngine.NativeMethodInfoPtr_get_HoveredGizmo_Public_get_Gizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTGizmosEngine>.NativeClassPtr, 100664556);
			RTGizmosEngine.NativeMethodInfoPtr_get_DraggedGizmo_Public_get_Gizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTGizmosEngine>.NativeClassPtr, 100664557);
			RTGizmosEngine.NativeMethodInfoPtr_get_JustReleasedDrag_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTGizmosEngine>.NativeClassPtr, 100664558);
			RTGizmosEngine.NativeMethodInfoPtr_get_NumRenderCameras_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTGizmosEngine>.NativeClassPtr, 100664559);
			RTGizmosEngine.NativeMethodInfoPtr_get_SharedSceneGizmoLookAndFeel_Public_get_SceneGizmoLookAndFeel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTGizmosEngine>.NativeClassPtr, 100664560);
			RTGizmosEngine.NativeMethodInfoPtr_add_CanDoHoverUpdate_Public_add_Void_GizmoEngineCanDoHoverUpdateHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTGizmosEngine>.NativeClassPtr, 100664549);
			RTGizmosEngine.NativeMethodInfoPtr_remove_CanDoHoverUpdate_Public_rem_Void_GizmoEngineCanDoHoverUpdateHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTGizmosEngine>.NativeClassPtr, 100664550);
			RTGizmosEngine.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTGizmosEngine>.NativeClassPtr, 100664590);
			RTGizmosEngine.NativeMethodInfoPtr_AddRenderCamera_Public_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTGizmosEngine>.NativeClassPtr, 100664561);
			RTGizmosEngine.NativeMethodInfoPtr_IsRenderCamera_Public_Boolean_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTGizmosEngine>.NativeClassPtr, 100664562);
			RTGizmosEngine.NativeMethodInfoPtr_RemoveRenderCamera_Public_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTGizmosEngine>.NativeClassPtr, 100664563);
			RTGizmosEngine.NativeMethodInfoPtr_CreateSceneGizmoCamera_Public_RTSceneGizmoCamera_Camera_ISceneGizmoCamViewportUpdater_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTGizmosEngine>.NativeClassPtr, 100664564);
			RTGizmosEngine.NativeMethodInfoPtr_IsSceneGizmoCamera_Public_Boolean_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTGizmosEngine>.NativeClassPtr, 100664565);
			RTGizmosEngine.NativeMethodInfoPtr_GetSceneGizmoByCamera_Public_ISceneGizmo_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTGizmosEngine>.NativeClassPtr, 100664566);
			RTGizmosEngine.NativeMethodInfoPtr_CreateGizmo_Public_Gizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTGizmosEngine>.NativeClassPtr, 100664567);
			RTGizmosEngine.NativeMethodInfoPtr_RemoveGizmo_Public_Void_Gizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTGizmosEngine>.NativeClassPtr, 100664568);
			RTGizmosEngine.NativeMethodInfoPtr_CreateSceneGizmo_Public_SceneGizmo_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTGizmosEngine>.NativeClassPtr, 100664569);
			RTGizmosEngine.NativeMethodInfoPtr_CreateMoveGizmo_Public_MoveGizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTGizmosEngine>.NativeClassPtr, 100664570);
			RTGizmosEngine.NativeMethodInfoPtr_CreateObjectMoveGizmo_Public_ObjectTransformGizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTGizmosEngine>.NativeClassPtr, 100664571);
			RTGizmosEngine.NativeMethodInfoPtr_CreateRotationGizmo_Public_RotationGizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTGizmosEngine>.NativeClassPtr, 100664572);
			RTGizmosEngine.NativeMethodInfoPtr_CreateObjectRotationGizmo_Public_ObjectTransformGizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTGizmosEngine>.NativeClassPtr, 100664573);
			RTGizmosEngine.NativeMethodInfoPtr_CreateScaleGizmo_Public_ScaleGizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTGizmosEngine>.NativeClassPtr, 100664574);
			RTGizmosEngine.NativeMethodInfoPtr_CreateObjectScaleGizmo_Public_ObjectTransformGizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTGizmosEngine>.NativeClassPtr, 100664575);
			RTGizmosEngine.NativeMethodInfoPtr_CreateUniversalGizmo_Public_UniversalGizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTGizmosEngine>.NativeClassPtr, 100664576);
			RTGizmosEngine.NativeMethodInfoPtr_CreateObjectUniversalGizmo_Public_ObjectTransformGizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTGizmosEngine>.NativeClassPtr, 100664577);
			RTGizmosEngine.NativeMethodInfoPtr_CreateBoxGizmo_Public_BoxGizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTGizmosEngine>.NativeClassPtr, 100664578);
			RTGizmosEngine.NativeMethodInfoPtr_CreateObjectBoxScaleGizmo_Public_BoxGizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTGizmosEngine>.NativeClassPtr, 100664579);
			RTGizmosEngine.NativeMethodInfoPtr_CreateObjectExtrudeGizmo_Public_ObjectExtrudeGizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTGizmosEngine>.NativeClassPtr, 100664580);
			RTGizmosEngine.NativeMethodInfoPtr_Update_SystemCall_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTGizmosEngine>.NativeClassPtr, 100664581);
			RTGizmosEngine.NativeMethodInfoPtr_GetGizmoHandleHoverData_Public_GizmoHandleHoverData_Gizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTGizmosEngine>.NativeClassPtr, 100664582);
			RTGizmosEngine.NativeMethodInfoPtr_Render_SystemCall_Public_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTGizmosEngine>.NativeClassPtr, 100664583);
			RTGizmosEngine.NativeMethodInfoPtr_SortHandleHoverDataCollection_Private_Void_List_1_GizmoHandleHoverData_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTGizmosEngine>.NativeClassPtr, 100664584);
			RTGizmosEngine.NativeMethodInfoPtr_RegisterGizmo_Private_Void_Gizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTGizmosEngine>.NativeClassPtr, 100664585);
			RTGizmosEngine.NativeMethodInfoPtr_UnregisterGizmo_Private_Void_Gizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTGizmosEngine>.NativeClassPtr, 100664586);
			RTGizmosEngine.NativeMethodInfoPtr_OnGUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTGizmosEngine>.NativeClassPtr, 100664587);
			RTGizmosEngine.NativeMethodInfoPtr_OnGizmoDragBegin_Private_Void_Gizmo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTGizmosEngine>.NativeClassPtr, 100664588);
			RTGizmosEngine.NativeMethodInfoPtr_OnGizmoDragEnd_Private_Void_Gizmo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTGizmosEngine>.NativeClassPtr, 100664589);
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x0600083D RID: 2109 RVA: 0x00041A1C File Offset: 0x0003FC1C
		public unsafe GizmoEngineSettings Settings
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 21537, RefRangeEnd = 21548, XrefRangeStart = 21537, XrefRangeEnd = 21548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTGizmosEngine.NativeMethodInfoPtr_get_Settings_Public_get_GizmoEngineSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoEngineSettings>(intPtr3) : null;
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x0600083E RID: 2110 RVA: 0x00041A5C File Offset: 0x0003FC5C
		public unsafe GizmosEnginePipelineStage PipelineStage
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTGizmosEngine.NativeMethodInfoPtr_get_PipelineStage_Public_get_GizmosEnginePipelineStage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmosEnginePipelineStage>(intPtr3) : null;
			}
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x0600083F RID: 2111 RVA: 0x00041A9C File Offset: 0x0003FC9C
		public unsafe Camera RenderStageCamera
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62955, XrefRangeEnd = 62961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTGizmosEngine.NativeMethodInfoPtr_get_RenderStageCamera_Public_get_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr3) : null;
			}
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06000840 RID: 2112 RVA: 0x00041ADC File Offset: 0x0003FCDC
		public unsafe virtual bool HasHoveredSceneEntity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTGizmosEngine.NativeMethodInfoPtr_get_HasHoveredSceneEntity_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06000841 RID: 2113 RVA: 0x00041B18 File Offset: 0x0003FD18
		public unsafe bool IsAnyGizmoHovered
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTGizmosEngine.NativeMethodInfoPtr_get_IsAnyGizmoHovered_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06000842 RID: 2114 RVA: 0x00041B54 File Offset: 0x0003FD54
		public unsafe Gizmo HoveredGizmo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTGizmosEngine.NativeMethodInfoPtr_get_HoveredGizmo_Public_get_Gizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Gizmo>(intPtr3) : null;
			}
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06000843 RID: 2115 RVA: 0x00041B94 File Offset: 0x0003FD94
		public unsafe Gizmo DraggedGizmo
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 26452, RefRangeEnd = 26453, XrefRangeStart = 26452, XrefRangeEnd = 26453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTGizmosEngine.NativeMethodInfoPtr_get_DraggedGizmo_Public_get_Gizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Gizmo>(intPtr3) : null;
			}
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06000844 RID: 2116 RVA: 0x00041BD4 File Offset: 0x0003FDD4
		public unsafe bool JustReleasedDrag
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTGizmosEngine.NativeMethodInfoPtr_get_JustReleasedDrag_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06000845 RID: 2117 RVA: 0x00041C10 File Offset: 0x0003FE10
		public unsafe int NumRenderCameras
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 62962, RefRangeEnd = 62966, XrefRangeStart = 62961, XrefRangeEnd = 62962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTGizmosEngine.NativeMethodInfoPtr_get_NumRenderCameras_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06000846 RID: 2118 RVA: 0x00041C4C File Offset: 0x0003FE4C
		public unsafe SceneGizmoLookAndFeel SharedSceneGizmoLookAndFeel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTGizmosEngine.NativeMethodInfoPtr_get_SharedSceneGizmoLookAndFeel_Public_get_SceneGizmoLookAndFeel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SceneGizmoLookAndFeel>(intPtr3) : null;
			}
		}

		// Token: 0x06000847 RID: 2119 RVA: 0x00041C8C File Offset: 0x0003FE8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 62970, RefRangeEnd = 62971, XrefRangeStart = 62966, XrefRangeEnd = 62970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_CanDoHoverUpdate(GizmoEngineCanDoHoverUpdateHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTGizmosEngine.NativeMethodInfoPtr_add_CanDoHoverUpdate_Public_add_Void_GizmoEngineCanDoHoverUpdateHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x00041CD0 File Offset: 0x0003FED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62971, XrefRangeEnd = 62975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_CanDoHoverUpdate(GizmoEngineCanDoHoverUpdateHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTGizmosEngine.NativeMethodInfoPtr_remove_CanDoHoverUpdate_Public_rem_Void_GizmoEngineCanDoHoverUpdateHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x00041D14 File Offset: 0x0003FF14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62975, XrefRangeEnd = 63052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RTGizmosEngine()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTGizmosEngine>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTGizmosEngine.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x00041D50 File Offset: 0x0003FF50
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 63059, RefRangeEnd = 63061, XrefRangeStart = 63052, XrefRangeEnd = 63059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddRenderCamera(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTGizmosEngine.NativeMethodInfoPtr_AddRenderCamera_Public_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x00041D94 File Offset: 0x0003FF94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63061, XrefRangeEnd = 63065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsRenderCamera(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTGizmosEngine.NativeMethodInfoPtr_IsRenderCamera_Public_Boolean_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600084C RID: 2124 RVA: 0x00041DE4 File Offset: 0x0003FFE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 63069, RefRangeEnd = 63070, XrefRangeStart = 63065, XrefRangeEnd = 63069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveRenderCamera(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTGizmosEngine.NativeMethodInfoPtr_RemoveRenderCamera_Public_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x00041E28 File Offset: 0x00040028
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 63098, RefRangeEnd = 63099, XrefRangeStart = 63070, XrefRangeEnd = 63098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RTSceneGizmoCamera CreateSceneGizmoCamera(Camera sceneCamera, ISceneGizmoCamViewportUpdater viewportUpdater)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sceneCamera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(viewportUpdater);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTGizmosEngine.NativeMethodInfoPtr_CreateSceneGizmoCamera_Public_RTSceneGizmoCamera_Camera_ISceneGizmoCamViewportUpdater_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTSceneGizmoCamera>(intPtr3) : null;
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x00041E8C File Offset: 0x0004008C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 63107, RefRangeEnd = 63113, XrefRangeStart = 63099, XrefRangeEnd = 63107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsSceneGizmoCamera(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTGizmosEngine.NativeMethodInfoPtr_IsSceneGizmoCamera_Public_Boolean_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600084F RID: 2127 RVA: 0x00041EDC File Offset: 0x000400DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 63130, RefRangeEnd = 63131, XrefRangeStart = 63113, XrefRangeEnd = 63130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ISceneGizmo GetSceneGizmoByCamera(Camera sceneCamera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sceneCamera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTGizmosEngine.NativeMethodInfoPtr_GetSceneGizmoByCamera_Public_ISceneGizmo_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISceneGizmo>(intPtr3) : null;
			}
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x00041F2C File Offset: 0x0004012C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63131, XrefRangeEnd = 63136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Gizmo CreateGizmo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTGizmosEngine.NativeMethodInfoPtr_CreateGizmo_Public_Gizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Gizmo>(intPtr3) : null;
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x00041F6C File Offset: 0x0004016C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63136, XrefRangeEnd = 63137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveGizmo(Gizmo gizmo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gizmo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTGizmosEngine.NativeMethodInfoPtr_RemoveGizmo_Public_Void_Gizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x00041FB0 File Offset: 0x000401B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 63151, RefRangeEnd = 63152, XrefRangeStart = 63137, XrefRangeEnd = 63151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SceneGizmo CreateSceneGizmo(Camera sceneCamera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sceneCamera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTGizmosEngine.NativeMethodInfoPtr_CreateSceneGizmo_Public_SceneGizmo_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SceneGizmo>(intPtr3) : null;
			}
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x00042000 File Offset: 0x00040200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63152, XrefRangeEnd = 63162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MoveGizmo CreateMoveGizmo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTGizmosEngine.NativeMethodInfoPtr_CreateMoveGizmo_Public_MoveGizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MoveGizmo>(intPtr3) : null;
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x00042040 File Offset: 0x00040240
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 63176, RefRangeEnd = 63177, XrefRangeStart = 63162, XrefRangeEnd = 63176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectTransformGizmo CreateObjectMoveGizmo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTGizmosEngine.NativeMethodInfoPtr_CreateObjectMoveGizmo_Public_ObjectTransformGizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectTransformGizmo>(intPtr3) : null;
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x00042080 File Offset: 0x00040280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63177, XrefRangeEnd = 63187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RotationGizmo CreateRotationGizmo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTGizmosEngine.NativeMethodInfoPtr_CreateRotationGizmo_Public_RotationGizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RotationGizmo>(intPtr3) : null;
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x000420C0 File Offset: 0x000402C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 63201, RefRangeEnd = 63202, XrefRangeStart = 63187, XrefRangeEnd = 63201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectTransformGizmo CreateObjectRotationGizmo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTGizmosEngine.NativeMethodInfoPtr_CreateObjectRotationGizmo_Public_ObjectTransformGizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectTransformGizmo>(intPtr3) : null;
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x00042100 File Offset: 0x00040300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63202, XrefRangeEnd = 63212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScaleGizmo CreateScaleGizmo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTGizmosEngine.NativeMethodInfoPtr_CreateScaleGizmo_Public_ScaleGizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScaleGizmo>(intPtr3) : null;
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x00042140 File Offset: 0x00040340
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 63228, RefRangeEnd = 63229, XrefRangeStart = 63212, XrefRangeEnd = 63228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectTransformGizmo CreateObjectScaleGizmo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTGizmosEngine.NativeMethodInfoPtr_CreateObjectScaleGizmo_Public_ObjectTransformGizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectTransformGizmo>(intPtr3) : null;
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x00042180 File Offset: 0x00040380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63229, XrefRangeEnd = 63239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniversalGizmo CreateUniversalGizmo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTGizmosEngine.NativeMethodInfoPtr_CreateUniversalGizmo_Public_UniversalGizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UniversalGizmo>(intPtr3) : null;
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x000421C0 File Offset: 0x000403C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 63253, RefRangeEnd = 63254, XrefRangeStart = 63239, XrefRangeEnd = 63253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectTransformGizmo CreateObjectUniversalGizmo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTGizmosEngine.NativeMethodInfoPtr_CreateObjectUniversalGizmo_Public_ObjectTransformGizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectTransformGizmo>(intPtr3) : null;
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x00042200 File Offset: 0x00040400
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 63294, RefRangeEnd = 63295, XrefRangeStart = 63254, XrefRangeEnd = 63294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BoxGizmo CreateBoxGizmo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTGizmosEngine.NativeMethodInfoPtr_CreateBoxGizmo_Public_BoxGizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BoxGizmo>(intPtr3) : null;
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x00042240 File Offset: 0x00040440
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 63296, RefRangeEnd = 63297, XrefRangeStart = 63295, XrefRangeEnd = 63296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BoxGizmo CreateObjectBoxScaleGizmo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTGizmosEngine.NativeMethodInfoPtr_CreateObjectBoxScaleGizmo_Public_BoxGizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BoxGizmo>(intPtr3) : null;
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x00042280 File Offset: 0x00040480
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 63307, RefRangeEnd = 63308, XrefRangeStart = 63297, XrefRangeEnd = 63307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectExtrudeGizmo CreateObjectExtrudeGizmo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTGizmosEngine.NativeMethodInfoPtr_CreateObjectExtrudeGizmo_Public_ObjectExtrudeGizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectExtrudeGizmo>(intPtr3) : null;
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x000422C0 File Offset: 0x000404C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 63439, RefRangeEnd = 63440, XrefRangeStart = 63308, XrefRangeEnd = 63439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update_SystemCall()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTGizmosEngine.NativeMethodInfoPtr_Update_SystemCall_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x000422F4 File Offset: 0x000404F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 63470, RefRangeEnd = 63471, XrefRangeStart = 63440, XrefRangeEnd = 63470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoHandleHoverData GetGizmoHandleHoverData(Gizmo gizmo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gizmo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTGizmosEngine.NativeMethodInfoPtr_GetGizmoHandleHoverData_Public_GizmoHandleHoverData_Gizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoHandleHoverData>(intPtr3) : null;
			}
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x00042344 File Offset: 0x00040544
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 63524, RefRangeEnd = 63525, XrefRangeStart = 63471, XrefRangeEnd = 63524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Render_SystemCall(Camera renderCamera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderCamera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTGizmosEngine.NativeMethodInfoPtr_Render_SystemCall_Public_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000861 RID: 2145 RVA: 0x00042388 File Offset: 0x00040588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63525, XrefRangeEnd = 63542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SortHandleHoverDataCollection(List<GizmoHandleHoverData> hoverDataCollection, Vector3 inputDevicePos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hoverDataCollection);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(inputDevicePos);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTGizmosEngine.NativeMethodInfoPtr_SortHandleHoverDataCollection_Private_Void_List_1_GizmoHandleHoverData_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x000423DC File Offset: 0x000405DC
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 63567, RefRangeEnd = 63579, XrefRangeStart = 63542, XrefRangeEnd = 63567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterGizmo(Gizmo gizmo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gizmo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTGizmosEngine.NativeMethodInfoPtr_RegisterGizmo_Private_Void_Gizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x00042420 File Offset: 0x00040620
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 63602, RefRangeEnd = 63603, XrefRangeStart = 63579, XrefRangeEnd = 63602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnregisterGizmo(Gizmo gizmo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gizmo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTGizmosEngine.NativeMethodInfoPtr_UnregisterGizmo_Private_Void_Gizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x00042464 File Offset: 0x00040664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63603, XrefRangeEnd = 63618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTGizmosEngine.NativeMethodInfoPtr_OnGUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x00042498 File Offset: 0x00040698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGizmoDragBegin(Gizmo gizmo, int handleId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gizmo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handleId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTGizmosEngine.NativeMethodInfoPtr_OnGizmoDragBegin_Private_Void_Gizmo_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x000424E8 File Offset: 0x000406E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63618, XrefRangeEnd = 63619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGizmoDragEnd(Gizmo gizmo, int handleId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gizmo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handleId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTGizmosEngine.NativeMethodInfoPtr_OnGizmoDragEnd_Private_Void_Gizmo_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x00004BC5 File Offset: 0x00002DC5
		public RTGizmosEngine(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06000868 RID: 2152 RVA: 0x00042538 File Offset: 0x00040738
		// (set) Token: 0x06000869 RID: 2153 RVA: 0x00004BCE File Offset: 0x00002DCE
		public unsafe GizmoEngineCanDoHoverUpdateHandler CanDoHoverUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTGizmosEngine.NativeFieldInfoPtr_CanDoHoverUpdate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoEngineCanDoHoverUpdateHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTGizmosEngine.NativeFieldInfoPtr_CanDoHoverUpdate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x0600086A RID: 2154 RVA: 0x00042568 File Offset: 0x00040768
		// (set) Token: 0x0600086B RID: 2155 RVA: 0x00004BED File Offset: 0x00002DED
		public unsafe EditorToolbar _mainToolbar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTGizmosEngine.NativeFieldInfoPtr__mainToolbar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EditorToolbar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTGizmosEngine.NativeFieldInfoPtr__mainToolbar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x0600086C RID: 2156 RVA: 0x00042598 File Offset: 0x00040798
		// (set) Token: 0x0600086D RID: 2157 RVA: 0x00004C0C File Offset: 0x00002E0C
		public unsafe GizmoEngineSettings _settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTGizmosEngine.NativeFieldInfoPtr__settings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoEngineSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTGizmosEngine.NativeFieldInfoPtr__settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x0600086E RID: 2158 RVA: 0x000425C8 File Offset: 0x000407C8
		// (set) Token: 0x0600086F RID: 2159 RVA: 0x00004C2B File Offset: 0x00002E2B
		public unsafe GizmosEnginePipelineStage _pipelineStage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTGizmosEngine.NativeFieldInfoPtr__pipelineStage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmosEnginePipelineStage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTGizmosEngine.NativeFieldInfoPtr__pipelineStage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06000870 RID: 2160 RVA: 0x000425F8 File Offset: 0x000407F8
		// (set) Token: 0x06000871 RID: 2161 RVA: 0x00004C4A File Offset: 0x00002E4A
		public unsafe Gizmo _draggedGizmo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTGizmosEngine.NativeFieldInfoPtr__draggedGizmo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gizmo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTGizmosEngine.NativeFieldInfoPtr__draggedGizmo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06000872 RID: 2162 RVA: 0x00042628 File Offset: 0x00040828
		// (set) Token: 0x06000873 RID: 2163 RVA: 0x00004C69 File Offset: 0x00002E69
		public unsafe bool _justReleasedDrag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTGizmosEngine.NativeFieldInfoPtr__justReleasedDrag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTGizmosEngine.NativeFieldInfoPtr__justReleasedDrag)) = value;
			}
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06000874 RID: 2164 RVA: 0x00042650 File Offset: 0x00040850
		// (set) Token: 0x06000875 RID: 2165 RVA: 0x00004C84 File Offset: 0x00002E84
		public unsafe Gizmo _hoveredGizmo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTGizmosEngine.NativeFieldInfoPtr__hoveredGizmo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gizmo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTGizmosEngine.NativeFieldInfoPtr__hoveredGizmo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06000876 RID: 2166 RVA: 0x00042680 File Offset: 0x00040880
		// (set) Token: 0x06000877 RID: 2167 RVA: 0x00004CA3 File Offset: 0x00002EA3
		public unsafe GizmoHoverInfo _gizmoHoverInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTGizmosEngine.NativeFieldInfoPtr__gizmoHoverInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoHoverInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTGizmosEngine.NativeFieldInfoPtr__gizmoHoverInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06000878 RID: 2168 RVA: 0x000426B0 File Offset: 0x000408B0
		// (set) Token: 0x06000879 RID: 2169 RVA: 0x00004CC2 File Offset: 0x00002EC2
		public unsafe List<Gizmo> _gizmos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTGizmosEngine.NativeFieldInfoPtr__gizmos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Gizmo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTGizmosEngine.NativeFieldInfoPtr__gizmos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x0600087A RID: 2170 RVA: 0x000426E0 File Offset: 0x000408E0
		// (set) Token: 0x0600087B RID: 2171 RVA: 0x00004CE1 File Offset: 0x00002EE1
		public unsafe List<ISceneGizmo> _sceneGizmos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTGizmosEngine.NativeFieldInfoPtr__sceneGizmos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ISceneGizmo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTGizmosEngine.NativeFieldInfoPtr__sceneGizmos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x0600087C RID: 2172 RVA: 0x00042710 File Offset: 0x00040910
		// (set) Token: 0x0600087D RID: 2173 RVA: 0x00004D00 File Offset: 0x00002F00
		public unsafe List<RTSceneGizmoCamera> _sceneGizmoCameras
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTGizmosEngine.NativeFieldInfoPtr__sceneGizmoCameras);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RTSceneGizmoCamera>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTGizmosEngine.NativeFieldInfoPtr__sceneGizmoCameras), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x0600087E RID: 2174 RVA: 0x00042740 File Offset: 0x00040940
		// (set) Token: 0x0600087F RID: 2175 RVA: 0x00004D1F File Offset: 0x00002F1F
		public unsafe List<Camera> _renderCameras
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTGizmosEngine.NativeFieldInfoPtr__renderCameras);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Camera>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTGizmosEngine.NativeFieldInfoPtr__renderCameras), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06000880 RID: 2176 RVA: 0x00042770 File Offset: 0x00040970
		// (set) Token: 0x06000881 RID: 2177 RVA: 0x00004D3E File Offset: 0x00002F3E
		public unsafe SceneGizmoLookAndFeel _sharedSceneGizmoLookAndFeel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTGizmosEngine.NativeFieldInfoPtr__sharedSceneGizmoLookAndFeel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneGizmoLookAndFeel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTGizmosEngine.NativeFieldInfoPtr__sharedSceneGizmoLookAndFeel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000657 RID: 1623
		private static readonly IntPtr NativeFieldInfoPtr_CanDoHoverUpdate;

		// Token: 0x04000658 RID: 1624
		private static readonly IntPtr NativeFieldInfoPtr__mainToolbar;

		// Token: 0x04000659 RID: 1625
		private static readonly IntPtr NativeFieldInfoPtr__settings;

		// Token: 0x0400065A RID: 1626
		private static readonly IntPtr NativeFieldInfoPtr__pipelineStage;

		// Token: 0x0400065B RID: 1627
		private static readonly IntPtr NativeFieldInfoPtr__draggedGizmo;

		// Token: 0x0400065C RID: 1628
		private static readonly IntPtr NativeFieldInfoPtr__justReleasedDrag;

		// Token: 0x0400065D RID: 1629
		private static readonly IntPtr NativeFieldInfoPtr__hoveredGizmo;

		// Token: 0x0400065E RID: 1630
		private static readonly IntPtr NativeFieldInfoPtr__gizmoHoverInfo;

		// Token: 0x0400065F RID: 1631
		private static readonly IntPtr NativeFieldInfoPtr__gizmos;

		// Token: 0x04000660 RID: 1632
		private static readonly IntPtr NativeFieldInfoPtr__sceneGizmos;

		// Token: 0x04000661 RID: 1633
		private static readonly IntPtr NativeFieldInfoPtr__sceneGizmoCameras;

		// Token: 0x04000662 RID: 1634
		private static readonly IntPtr NativeFieldInfoPtr__renderCameras;

		// Token: 0x04000663 RID: 1635
		private static readonly IntPtr NativeFieldInfoPtr__sharedSceneGizmoLookAndFeel;

		// Token: 0x04000664 RID: 1636
		private static readonly IntPtr NativeMethodInfoPtr_get_Settings_Public_get_GizmoEngineSettings_0;

		// Token: 0x04000665 RID: 1637
		private static readonly IntPtr NativeMethodInfoPtr_get_PipelineStage_Public_get_GizmosEnginePipelineStage_0;

		// Token: 0x04000666 RID: 1638
		private static readonly IntPtr NativeMethodInfoPtr_get_RenderStageCamera_Public_get_Camera_0;

		// Token: 0x04000667 RID: 1639
		private static readonly IntPtr NativeMethodInfoPtr_get_HasHoveredSceneEntity_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000668 RID: 1640
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAnyGizmoHovered_Public_get_Boolean_0;

		// Token: 0x04000669 RID: 1641
		private static readonly IntPtr NativeMethodInfoPtr_get_HoveredGizmo_Public_get_Gizmo_0;

		// Token: 0x0400066A RID: 1642
		private static readonly IntPtr NativeMethodInfoPtr_get_DraggedGizmo_Public_get_Gizmo_0;

		// Token: 0x0400066B RID: 1643
		private static readonly IntPtr NativeMethodInfoPtr_get_JustReleasedDrag_Public_get_Boolean_0;

		// Token: 0x0400066C RID: 1644
		private static readonly IntPtr NativeMethodInfoPtr_get_NumRenderCameras_Public_get_Int32_0;

		// Token: 0x0400066D RID: 1645
		private static readonly IntPtr NativeMethodInfoPtr_get_SharedSceneGizmoLookAndFeel_Public_get_SceneGizmoLookAndFeel_0;

		// Token: 0x0400066E RID: 1646
		private static readonly IntPtr NativeMethodInfoPtr_add_CanDoHoverUpdate_Public_add_Void_GizmoEngineCanDoHoverUpdateHandler_0;

		// Token: 0x0400066F RID: 1647
		private static readonly IntPtr NativeMethodInfoPtr_remove_CanDoHoverUpdate_Public_rem_Void_GizmoEngineCanDoHoverUpdateHandler_0;

		// Token: 0x04000670 RID: 1648
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000671 RID: 1649
		private static readonly IntPtr NativeMethodInfoPtr_AddRenderCamera_Public_Void_Camera_0;

		// Token: 0x04000672 RID: 1650
		private static readonly IntPtr NativeMethodInfoPtr_IsRenderCamera_Public_Boolean_Camera_0;

		// Token: 0x04000673 RID: 1651
		private static readonly IntPtr NativeMethodInfoPtr_RemoveRenderCamera_Public_Void_Camera_0;

		// Token: 0x04000674 RID: 1652
		private static readonly IntPtr NativeMethodInfoPtr_CreateSceneGizmoCamera_Public_RTSceneGizmoCamera_Camera_ISceneGizmoCamViewportUpdater_0;

		// Token: 0x04000675 RID: 1653
		private static readonly IntPtr NativeMethodInfoPtr_IsSceneGizmoCamera_Public_Boolean_Camera_0;

		// Token: 0x04000676 RID: 1654
		private static readonly IntPtr NativeMethodInfoPtr_GetSceneGizmoByCamera_Public_ISceneGizmo_Camera_0;

		// Token: 0x04000677 RID: 1655
		private static readonly IntPtr NativeMethodInfoPtr_CreateGizmo_Public_Gizmo_0;

		// Token: 0x04000678 RID: 1656
		private static readonly IntPtr NativeMethodInfoPtr_RemoveGizmo_Public_Void_Gizmo_0;

		// Token: 0x04000679 RID: 1657
		private static readonly IntPtr NativeMethodInfoPtr_CreateSceneGizmo_Public_SceneGizmo_Camera_0;

		// Token: 0x0400067A RID: 1658
		private static readonly IntPtr NativeMethodInfoPtr_CreateMoveGizmo_Public_MoveGizmo_0;

		// Token: 0x0400067B RID: 1659
		private static readonly IntPtr NativeMethodInfoPtr_CreateObjectMoveGizmo_Public_ObjectTransformGizmo_0;

		// Token: 0x0400067C RID: 1660
		private static readonly IntPtr NativeMethodInfoPtr_CreateRotationGizmo_Public_RotationGizmo_0;

		// Token: 0x0400067D RID: 1661
		private static readonly IntPtr NativeMethodInfoPtr_CreateObjectRotationGizmo_Public_ObjectTransformGizmo_0;

		// Token: 0x0400067E RID: 1662
		private static readonly IntPtr NativeMethodInfoPtr_CreateScaleGizmo_Public_ScaleGizmo_0;

		// Token: 0x0400067F RID: 1663
		private static readonly IntPtr NativeMethodInfoPtr_CreateObjectScaleGizmo_Public_ObjectTransformGizmo_0;

		// Token: 0x04000680 RID: 1664
		private static readonly IntPtr NativeMethodInfoPtr_CreateUniversalGizmo_Public_UniversalGizmo_0;

		// Token: 0x04000681 RID: 1665
		private static readonly IntPtr NativeMethodInfoPtr_CreateObjectUniversalGizmo_Public_ObjectTransformGizmo_0;

		// Token: 0x04000682 RID: 1666
		private static readonly IntPtr NativeMethodInfoPtr_CreateBoxGizmo_Public_BoxGizmo_0;

		// Token: 0x04000683 RID: 1667
		private static readonly IntPtr NativeMethodInfoPtr_CreateObjectBoxScaleGizmo_Public_BoxGizmo_0;

		// Token: 0x04000684 RID: 1668
		private static readonly IntPtr NativeMethodInfoPtr_CreateObjectExtrudeGizmo_Public_ObjectExtrudeGizmo_0;

		// Token: 0x04000685 RID: 1669
		private static readonly IntPtr NativeMethodInfoPtr_Update_SystemCall_Public_Void_0;

		// Token: 0x04000686 RID: 1670
		private static readonly IntPtr NativeMethodInfoPtr_GetGizmoHandleHoverData_Public_GizmoHandleHoverData_Gizmo_0;

		// Token: 0x04000687 RID: 1671
		private static readonly IntPtr NativeMethodInfoPtr_Render_SystemCall_Public_Void_Camera_0;

		// Token: 0x04000688 RID: 1672
		private static readonly IntPtr NativeMethodInfoPtr_SortHandleHoverDataCollection_Private_Void_List_1_GizmoHandleHoverData_Vector3_0;

		// Token: 0x04000689 RID: 1673
		private static readonly IntPtr NativeMethodInfoPtr_RegisterGizmo_Private_Void_Gizmo_0;

		// Token: 0x0400068A RID: 1674
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterGizmo_Private_Void_Gizmo_0;

		// Token: 0x0400068B RID: 1675
		private static readonly IntPtr NativeMethodInfoPtr_OnGUI_Private_Void_0;

		// Token: 0x0400068C RID: 1676
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoDragBegin_Private_Void_Gizmo_Int32_0;

		// Token: 0x0400068D RID: 1677
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoDragEnd_Private_Void_Gizmo_Int32_0;

		// Token: 0x02000366 RID: 870
		[ObfuscatedName("RLD.RTGizmosEngine+<>c__DisplayClass56_0")]
		public sealed class __c__DisplayClass56_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060049C6 RID: 18886 RVA: 0x00145918 File Offset: 0x00143B18
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass56_0()
			{
				Il2CppClassPointerStore<RTGizmosEngine.__c__DisplayClass56_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RTGizmosEngine>.NativeClassPtr, "<>c__DisplayClass56_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTGizmosEngine.__c__DisplayClass56_0>.NativeClassPtr);
				RTGizmosEngine.__c__DisplayClass56_0.NativeFieldInfoPtr_gizmo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTGizmosEngine.__c__DisplayClass56_0>.NativeClassPtr, "gizmo");
				RTGizmosEngine.__c__DisplayClass56_0.NativeFieldInfoPtr_screenRayOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTGizmosEngine.__c__DisplayClass56_0>.NativeClassPtr, "screenRayOrigin");
				RTGizmosEngine.__c__DisplayClass56_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTGizmosEngine.__c__DisplayClass56_0>.NativeClassPtr, 100664591);
				RTGizmosEngine.__c__DisplayClass56_0.NativeMethodInfoPtr__GetGizmoHandleHoverData_b__0_Internal_Int32_GizmoHandleHoverData_GizmoHandleHoverData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTGizmosEngine.__c__DisplayClass56_0>.NativeClassPtr, 100664592);
			}

			// Token: 0x060049C7 RID: 18887 RVA: 0x00145994 File Offset: 0x00143B94
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass56_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTGizmosEngine.__c__DisplayClass56_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTGizmosEngine.__c__DisplayClass56_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060049C8 RID: 18888 RVA: 0x001459D0 File Offset: 0x00143BD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62927, XrefRangeEnd = 62952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetGizmoHandleHoverData_b__0(GizmoHandleHoverData h0, GizmoHandleHoverData h1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(h0);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(h1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTGizmosEngine.__c__DisplayClass56_0.NativeMethodInfoPtr__GetGizmoHandleHoverData_b__0_Internal_Int32_GizmoHandleHoverData_GizmoHandleHoverData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060049C9 RID: 18889 RVA: 0x0001B719 File Offset: 0x00019919
			public __c__DisplayClass56_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001900 RID: 6400
			// (get) Token: 0x060049CA RID: 18890 RVA: 0x00145A30 File Offset: 0x00143C30
			// (set) Token: 0x060049CB RID: 18891 RVA: 0x0001B722 File Offset: 0x00019922
			public unsafe Gizmo gizmo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTGizmosEngine.__c__DisplayClass56_0.NativeFieldInfoPtr_gizmo);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gizmo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTGizmosEngine.__c__DisplayClass56_0.NativeFieldInfoPtr_gizmo), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001901 RID: 6401
			// (get) Token: 0x060049CC RID: 18892 RVA: 0x00145A60 File Offset: 0x00143C60
			// (set) Token: 0x060049CD RID: 18893 RVA: 0x0001B741 File Offset: 0x00019941
			public unsafe Vector3 screenRayOrigin
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTGizmosEngine.__c__DisplayClass56_0.NativeFieldInfoPtr_screenRayOrigin);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTGizmosEngine.__c__DisplayClass56_0.NativeFieldInfoPtr_screenRayOrigin), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003952 RID: 14674
			private static readonly IntPtr NativeFieldInfoPtr_gizmo;

			// Token: 0x04003953 RID: 14675
			private static readonly IntPtr NativeFieldInfoPtr_screenRayOrigin;

			// Token: 0x04003954 RID: 14676
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003955 RID: 14677
			private static readonly IntPtr NativeMethodInfoPtr__GetGizmoHandleHoverData_b__0_Internal_Int32_GizmoHandleHoverData_GizmoHandleHoverData_0;
		}

		// Token: 0x02000367 RID: 871
		[ObfuscatedName("RLD.RTGizmosEngine+<>c__DisplayClass57_0")]
		public sealed class __c__DisplayClass57_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060049CE RID: 18894 RVA: 0x00145A90 File Offset: 0x00143C90
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass57_0()
			{
				Il2CppClassPointerStore<RTGizmosEngine.__c__DisplayClass57_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RTGizmosEngine>.NativeClassPtr, "<>c__DisplayClass57_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTGizmosEngine.__c__DisplayClass57_0>.NativeClassPtr);
				RTGizmosEngine.__c__DisplayClass57_0.NativeFieldInfoPtr_camPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTGizmosEngine.__c__DisplayClass57_0>.NativeClassPtr, "camPos");
				RTGizmosEngine.__c__DisplayClass57_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTGizmosEngine.__c__DisplayClass57_0>.NativeClassPtr, 100664593);
				RTGizmosEngine.__c__DisplayClass57_0.NativeMethodInfoPtr__Render_SystemCall_b__0_Internal_Int32_Gizmo_Gizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTGizmosEngine.__c__DisplayClass57_0>.NativeClassPtr, 100664594);
			}

			// Token: 0x060049CF RID: 18895 RVA: 0x00145AF8 File Offset: 0x00143CF8
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass57_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTGizmosEngine.__c__DisplayClass57_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTGizmosEngine.__c__DisplayClass57_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060049D0 RID: 18896 RVA: 0x00145B34 File Offset: 0x00143D34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62952, XrefRangeEnd = 62953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _Render_SystemCall_b__0(Gizmo g0, Gizmo g1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(g0);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(g1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTGizmosEngine.__c__DisplayClass57_0.NativeMethodInfoPtr__Render_SystemCall_b__0_Internal_Int32_Gizmo_Gizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060049D1 RID: 18897 RVA: 0x0001B760 File Offset: 0x00019960
			public __c__DisplayClass57_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001902 RID: 6402
			// (get) Token: 0x060049D2 RID: 18898 RVA: 0x00145B94 File Offset: 0x00143D94
			// (set) Token: 0x060049D3 RID: 18899 RVA: 0x0001B769 File Offset: 0x00019969
			public unsafe Vector3 camPos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTGizmosEngine.__c__DisplayClass57_0.NativeFieldInfoPtr_camPos);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTGizmosEngine.__c__DisplayClass57_0.NativeFieldInfoPtr_camPos), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003956 RID: 14678
			private static readonly IntPtr NativeFieldInfoPtr_camPos;

			// Token: 0x04003957 RID: 14679
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003958 RID: 14680
			private static readonly IntPtr NativeMethodInfoPtr__Render_SystemCall_b__0_Internal_Int32_Gizmo_Gizmo_0;
		}

		// Token: 0x02000368 RID: 872
		[ObfuscatedName("RLD.RTGizmosEngine+<>c__DisplayClass58_0")]
		public sealed class __c__DisplayClass58_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060049D4 RID: 18900 RVA: 0x00145BC4 File Offset: 0x00143DC4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass58_0()
			{
				Il2CppClassPointerStore<RTGizmosEngine.__c__DisplayClass58_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RTGizmosEngine>.NativeClassPtr, "<>c__DisplayClass58_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTGizmosEngine.__c__DisplayClass58_0>.NativeClassPtr);
				RTGizmosEngine.__c__DisplayClass58_0.NativeFieldInfoPtr_inputDevicePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTGizmosEngine.__c__DisplayClass58_0>.NativeClassPtr, "inputDevicePos");
				RTGizmosEngine.__c__DisplayClass58_0.NativeFieldInfoPtr_hoverRay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTGizmosEngine.__c__DisplayClass58_0>.NativeClassPtr, "hoverRay");
				RTGizmosEngine.__c__DisplayClass58_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTGizmosEngine.__c__DisplayClass58_0>.NativeClassPtr, 100664595);
				RTGizmosEngine.__c__DisplayClass58_0.NativeMethodInfoPtr__SortHandleHoverDataCollection_b__0_Internal_Int32_GizmoHandleHoverData_GizmoHandleHoverData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTGizmosEngine.__c__DisplayClass58_0>.NativeClassPtr, 100664596);
			}

			// Token: 0x060049D5 RID: 18901 RVA: 0x00145C40 File Offset: 0x00143E40
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass58_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTGizmosEngine.__c__DisplayClass58_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTGizmosEngine.__c__DisplayClass58_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060049D6 RID: 18902 RVA: 0x00145C7C File Offset: 0x00143E7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62953, XrefRangeEnd = 62955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _SortHandleHoverDataCollection_b__0(GizmoHandleHoverData h0, GizmoHandleHoverData h1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(h0);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(h1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTGizmosEngine.__c__DisplayClass58_0.NativeMethodInfoPtr__SortHandleHoverDataCollection_b__0_Internal_Int32_GizmoHandleHoverData_GizmoHandleHoverData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060049D7 RID: 18903 RVA: 0x0001B788 File Offset: 0x00019988
			public __c__DisplayClass58_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001903 RID: 6403
			// (get) Token: 0x060049D8 RID: 18904 RVA: 0x00145CDC File Offset: 0x00143EDC
			// (set) Token: 0x060049D9 RID: 18905 RVA: 0x0001B791 File Offset: 0x00019991
			public unsafe Vector3 inputDevicePos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTGizmosEngine.__c__DisplayClass58_0.NativeFieldInfoPtr_inputDevicePos);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTGizmosEngine.__c__DisplayClass58_0.NativeFieldInfoPtr_inputDevicePos), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001904 RID: 6404
			// (get) Token: 0x060049DA RID: 18906 RVA: 0x00145D0C File Offset: 0x00143F0C
			// (set) Token: 0x060049DB RID: 18907 RVA: 0x0001B7B0 File Offset: 0x000199B0
			public unsafe Ray hoverRay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTGizmosEngine.__c__DisplayClass58_0.NativeFieldInfoPtr_hoverRay);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Ray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTGizmosEngine.__c__DisplayClass58_0.NativeFieldInfoPtr_hoverRay), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003959 RID: 14681
			private static readonly IntPtr NativeFieldInfoPtr_inputDevicePos;

			// Token: 0x0400395A RID: 14682
			private static readonly IntPtr NativeFieldInfoPtr_hoverRay;

			// Token: 0x0400395B RID: 14683
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400395C RID: 14684
			private static readonly IntPtr NativeMethodInfoPtr__SortHandleHoverDataCollection_b__0_Internal_Int32_GizmoHandleHoverData_GizmoHandleHoverData_0;
		}
	}
}
