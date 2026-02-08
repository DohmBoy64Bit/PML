using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200009B RID: 155
	public class GizmoLineSlider3D : GizmoSlider
	{
		// Token: 0x06000C55 RID: 3157 RVA: 0x000509A4 File Offset: 0x0004EBA4
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoLineSlider3D()
		{
			Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoLineSlider3D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr);
			GizmoLineSlider3D.NativeFieldInfoPtr__segment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, "_segment");
			GizmoLineSlider3D.NativeFieldInfoPtr__box = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, "_box");
			GizmoLineSlider3D.NativeFieldInfoPtr__cylinder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, "_cylinder");
			GizmoLineSlider3D.NativeFieldInfoPtr__segmentIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, "_segmentIndex");
			GizmoLineSlider3D.NativeFieldInfoPtr__boxIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, "_boxIndex");
			GizmoLineSlider3D.NativeFieldInfoPtr__cylinderIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, "_cylinderIndex");
			GizmoLineSlider3D.NativeFieldInfoPtr__controllers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, "_controllers");
			GizmoLineSlider3D.NativeFieldInfoPtr__controllerData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, "_controllerData");
			GizmoLineSlider3D.NativeFieldInfoPtr__dragChannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, "_dragChannel");
			GizmoLineSlider3D.NativeFieldInfoPtr__offsetDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, "_offsetDrag");
			GizmoLineSlider3D.NativeFieldInfoPtr__rotationDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, "_rotationDrag");
			GizmoLineSlider3D.NativeFieldInfoPtr__rotationArc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, "_rotationArc");
			GizmoLineSlider3D.NativeFieldInfoPtr__scaleDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, "_scaleDrag");
			GizmoLineSlider3D.NativeFieldInfoPtr__scaleDragAxisIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, "_scaleDragAxisIndex");
			GizmoLineSlider3D.NativeFieldInfoPtr__scalerHandles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, "_scalerHandles");
			GizmoLineSlider3D.NativeFieldInfoPtr__selectedDragSession = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, "_selectedDragSession");
			GizmoLineSlider3D.NativeFieldInfoPtr__cap3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, "_cap3D");
			GizmoLineSlider3D.NativeFieldInfoPtr__transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, "_transform");
			GizmoLineSlider3D.NativeFieldInfoPtr__directionAxisMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, "_directionAxisMap");
			GizmoLineSlider3D.NativeFieldInfoPtr__dragRotationAxisMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, "_dragRotationAxisMap");
			GizmoLineSlider3D.NativeFieldInfoPtr__overrideColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, "_overrideColor");
			GizmoLineSlider3D.NativeFieldInfoPtr__settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, "_settings");
			GizmoLineSlider3D.NativeFieldInfoPtr__sharedSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, "_sharedSettings");
			GizmoLineSlider3D.NativeFieldInfoPtr__lookAndFeel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, "_lookAndFeel");
			GizmoLineSlider3D.NativeFieldInfoPtr__sharedLookAndFeel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, "_sharedLookAndFeel");
			GizmoLineSlider3D.NativeMethodInfoPtr_get_Direction_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, 100665097);
			GizmoLineSlider3D.NativeMethodInfoPtr_get_DragRotationAxis_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, 100665098);
			GizmoLineSlider3D.NativeMethodInfoPtr_get_ScaleDragAxisIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, 100665099);
			GizmoLineSlider3D.NativeMethodInfoPtr_set_ScaleDragAxisIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, 100665100);
			GizmoLineSlider3D.NativeMethodInfoPtr_get_StartPosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, 100665101);
			GizmoLineSlider3D.NativeMethodInfoPtr_set_StartPosition_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, 100665102);
			GizmoLineSlider3D.NativeMethodInfoPtr_get_DragChannel_Public_get_GizmoDragChannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, 100665103);
			GizmoLineSlider3D.NativeMethodInfoPtr_get_IsDragged_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, 100665104);
			GizmoLineSlider3D.NativeMethodInfoPtr_get_IsMoving_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, 100665105);
			GizmoLineSlider3D.NativeMethodInfoPtr_get_IsRotating_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, 100665106);
			GizmoLineSlider3D.NativeMethodInfoPtr_get_IsScaling_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, 100665107);
			GizmoLineSlider3D.NativeMethodInfoPtr_get_Is3DCapVisible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, 100665108);
			GizmoLineSlider3D.NativeMethodInfoPtr_get_Is3DCapHoverable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, 100665109);
			GizmoLineSlider3D.NativeMethodInfoPtr_get_Cap3DHandleId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, 100665110);
			GizmoLineSlider3D.NativeMethodInfoPtr_get_TotalDragOffset_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, 100665111);
			GizmoLineSlider3D.NativeMethodInfoPtr_get_RelativeDragOffset_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, 100665112);
			GizmoLineSlider3D.NativeMethodInfoPtr_get_TotalDragRotation_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, 100665113);
			GizmoLineSlider3D.NativeMethodInfoPtr_get_RelativeDragRotation_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, 100665114);
			GizmoLineSlider3D.NativeMethodInfoPtr_get_TotalDragScale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, 100665115);
			GizmoLineSlider3D.NativeMethodInfoPtr_get_RelativeDragScale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, 100665116);
			GizmoLineSlider3D.NativeMethodInfoPtr_get_OverrideColor_Public_get_GizmoOverrideColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, 100665117);
			GizmoLineSlider3D.NativeMethodInfoPtr_get_Cap3DOverrideColor_Public_get_GizmoOverrideColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, 100665118);
			GizmoLineSlider3D.NativeMethodInfoPtr_get_Settings_Public_get_GizmoLineSlider3DSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, 100665119);
			GizmoLineSlider3D.NativeMethodInfoPtr_get_SharedSettings_Public_get_GizmoLineSlider3DSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, 100665120);
			GizmoLineSlider3D.NativeMethodInfoPtr_set_SharedSettings_Public_set_Void_GizmoLineSlider3DSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, 100665121);
			GizmoLineSlider3D.NativeMethodInfoPtr_get_LookAndFeel_Public_get_GizmoLineSlider3DLookAndFeel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, 100665122);
			GizmoLineSlider3D.NativeMethodInfoPtr_get_SharedLookAndFeel_Public_get_GizmoLineSlider3DLookAndFeel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, 100665123);
			GizmoLineSlider3D.NativeMethodInfoPtr_set_SharedLookAndFeel_Public_set_Void_GizmoLineSlider3DLookAndFeel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, 100665124);
			GizmoLineSlider3D.NativeMethodInfoPtr__ctor_Public_Void_Gizmo_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, 100665125);
			GizmoLineSlider3D.NativeMethodInfoPtr_IsScalerHandleRegistered_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, 100665126);
			GizmoLineSlider3D.NativeMethodInfoPtr_IsScalerHandleRegistered_Public_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, 100665127);
			GizmoLineSlider3D.NativeMethodInfoPtr_RegisterScalerHandle_Public_Void_Int32_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, 100665128);
			GizmoLineSlider3D.NativeMethodInfoPtr_UnregisterScalerHandle_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, 100665129);
			GizmoLineSlider3D.NativeMethodInfoPtr_SetSnapEnabled_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, 100665130);
			GizmoLineSlider3D.NativeMethodInfoPtr_Set3DCapVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, 100665131);
			GizmoLineSlider3D.NativeMethodInfoPtr_Set3DCapHoverable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, 100665132);
			GizmoLineSlider3D.NativeMethodInfoPtr_SetZoomFactorTransform_Public_Void_GizmoTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, 100665133);
			GizmoLineSlider3D.NativeMethodInfoPtr_GetZoomFactor_Public_Single_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, 100665134);
			GizmoLineSlider3D.NativeMethodInfoPtr_GetRealDirection_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, 100665135);
			GizmoLineSlider3D.NativeMethodInfoPtr_GetRealSizeAlongDirection_Public_Single_Camera_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, 100665136);
			GizmoLineSlider3D.NativeMethodInfoPtr_GetRealLength_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, 100665137);
			GizmoLineSlider3D.NativeMethodInfoPtr_GetRealLengthWith3DCap_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, 100665138);
			GizmoLineSlider3D.NativeMethodInfoPtr_GetRealEndPosition_Public_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, 100665139);
			GizmoLineSlider3D.NativeMethodInfoPtr_GetRealEndPositionWith3DCap_Public_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, 100665140);
			GizmoLineSlider3D.NativeMethodInfoPtr_GetRealBoxHeight_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, 100665141);
			GizmoLineSlider3D.NativeMethodInfoPtr_GetRealBoxDepth_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, 100665142);
			GizmoLineSlider3D.NativeMethodInfoPtr_GetRealCylinderRadius_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, 100665143);
			GizmoLineSlider3D.NativeMethodInfoPtr_MapDirection_Public_Void_Int32_AxisSign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, 100665144);
			GizmoLineSlider3D.NativeMethodInfoPtr_MapDragRotationAxis_Public_Void_GizmoTransform_Int32_AxisSign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, 100665145);
			GizmoLineSlider3D.NativeMethodInfoPtr_UnmapDragRotationAxis_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, 100665146);
			GizmoLineSlider3D.NativeMethodInfoPtr_SetDirection_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, 100665147);
			GizmoLineSlider3D.NativeMethodInfoPtr_SetDragRotationAxis_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, 100665148);
			GizmoLineSlider3D.NativeMethodInfoPtr_AddTargetTransform_Public_Void_GizmoTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, 100665149);
			GizmoLineSlider3D.NativeMethodInfoPtr_AddTargetTransform_Public_Void_GizmoTransform_GizmoDragChannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, 100665150);
			GizmoLineSlider3D.NativeMethodInfoPtr_RemoveTargetTransform_Public_Void_GizmoTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, 100665151);
			GizmoLineSlider3D.NativeMethodInfoPtr_RemoveTargetTransform_Public_Void_GizmoTransform_GizmoDragChannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, 100665152);
			GizmoLineSlider3D.NativeMethodInfoPtr_SetDragChannel_Public_Void_GizmoDragChannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, 100665153);
			GizmoLineSlider3D.NativeMethodInfoPtr_ApplyZoomFactor_Public_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, 100665154);
			GizmoLineSlider3D.NativeMethodInfoPtr_Render_Public_Virtual_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, 100665155);
			GizmoLineSlider3D.NativeMethodInfoPtr_Refresh_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, 100665156);
			GizmoLineSlider3D.NativeMethodInfoPtr_OnVisibilityStateChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, 100665157);
			GizmoLineSlider3D.NativeMethodInfoPtr_OnHoverableStateChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, 100665158);
			GizmoLineSlider3D.NativeMethodInfoPtr_OnGizmoPreUpdateBegin_Private_Void_Gizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, 100665159);
			GizmoLineSlider3D.NativeMethodInfoPtr_OnGizmoAttemptHandleDragBegin_Private_Void_Gizmo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, 100665160);
			GizmoLineSlider3D.NativeMethodInfoPtr_OnTransformChanged_Private_Void_GizmoTransform_ChangeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, 100665161);
			GizmoLineSlider3D.NativeMethodInfoPtr_OnGizmoHandleHoverEnter_Private_Void_Gizmo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, 100665162);
			GizmoLineSlider3D.NativeMethodInfoPtr_OnGizmoPostEnabled_Private_Void_Gizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, 100665163);
			GizmoLineSlider3D.NativeMethodInfoPtr_OnGizmoPostDisabled_Private_Void_Gizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, 100665164);
			GizmoLineSlider3D.NativeMethodInfoPtr_OnGizmoHandleHoverExit_Private_Void_Gizmo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, 100665165);
			GizmoLineSlider3D.NativeMethodInfoPtr_SetupSharedLookAndFeel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, 100665166);
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06000C56 RID: 3158 RVA: 0x00051140 File Offset: 0x0004F340
		public unsafe Vector3 Direction
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66356, XrefRangeEnd = 66357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3D.NativeMethodInfoPtr_get_Direction_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x06000C57 RID: 3159 RVA: 0x00051180 File Offset: 0x0004F380
		public unsafe Vector3 DragRotationAxis
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66357, XrefRangeEnd = 66358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3D.NativeMethodInfoPtr_get_DragRotationAxis_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06000C58 RID: 3160 RVA: 0x000511C0 File Offset: 0x0004F3C0
		// (set) Token: 0x06000C59 RID: 3161 RVA: 0x000511FC File Offset: 0x0004F3FC
		public unsafe int ScaleDragAxisIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3D.NativeMethodInfoPtr_get_ScaleDragAxisIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 66358, RefRangeEnd = 66364, XrefRangeStart = 66358, XrefRangeEnd = 66358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3D.NativeMethodInfoPtr_set_ScaleDragAxisIndex_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06000C5A RID: 3162 RVA: 0x0005123C File Offset: 0x0004F43C
		// (set) Token: 0x06000C5B RID: 3163 RVA: 0x0005127C File Offset: 0x0004F47C
		public unsafe Vector3 StartPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3D.NativeMethodInfoPtr_get_StartPosition_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 66365, RefRangeEnd = 66371, XrefRangeStart = 66364, XrefRangeEnd = 66365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3D.NativeMethodInfoPtr_set_StartPosition_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06000C5C RID: 3164 RVA: 0x000512C0 File Offset: 0x0004F4C0
		public unsafe GizmoDragChannel DragChannel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3D.NativeMethodInfoPtr_get_DragChannel_Public_get_GizmoDragChannel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoDragChannel>(intPtr3) : null;
			}
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06000C5D RID: 3165 RVA: 0x00051300 File Offset: 0x0004F500
		public unsafe bool IsDragged
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 65131, RefRangeEnd = 65139, XrefRangeStart = 65131, XrefRangeEnd = 65139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3D.NativeMethodInfoPtr_get_IsDragged_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06000C5E RID: 3166 RVA: 0x0005133C File Offset: 0x0004F53C
		public unsafe bool IsMoving
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66371, XrefRangeEnd = 66372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3D.NativeMethodInfoPtr_get_IsMoving_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06000C5F RID: 3167 RVA: 0x00051378 File Offset: 0x0004F578
		public unsafe bool IsRotating
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3D.NativeMethodInfoPtr_get_IsRotating_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06000C60 RID: 3168 RVA: 0x000513B4 File Offset: 0x0004F5B4
		public unsafe bool IsScaling
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66372, XrefRangeEnd = 66373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3D.NativeMethodInfoPtr_get_IsScaling_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06000C61 RID: 3169 RVA: 0x000513F0 File Offset: 0x0004F5F0
		public unsafe bool Is3DCapVisible
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3D.NativeMethodInfoPtr_get_Is3DCapVisible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06000C62 RID: 3170 RVA: 0x0005142C File Offset: 0x0004F62C
		public unsafe bool Is3DCapHoverable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3D.NativeMethodInfoPtr_get_Is3DCapHoverable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06000C63 RID: 3171 RVA: 0x00051468 File Offset: 0x0004F668
		public unsafe int Cap3DHandleId
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 65124, RefRangeEnd = 65130, XrefRangeStart = 65124, XrefRangeEnd = 65130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3D.NativeMethodInfoPtr_get_Cap3DHandleId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06000C64 RID: 3172 RVA: 0x000514A4 File Offset: 0x0004F6A4
		public unsafe Vector3 TotalDragOffset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3D.NativeMethodInfoPtr_get_TotalDragOffset_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06000C65 RID: 3173 RVA: 0x000514E4 File Offset: 0x0004F6E4
		public unsafe Vector3 RelativeDragOffset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3D.NativeMethodInfoPtr_get_RelativeDragOffset_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06000C66 RID: 3174 RVA: 0x00051524 File Offset: 0x0004F724
		public unsafe float TotalDragRotation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3D.NativeMethodInfoPtr_get_TotalDragRotation_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06000C67 RID: 3175 RVA: 0x00051560 File Offset: 0x0004F760
		public unsafe float RelativeDragRotation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3D.NativeMethodInfoPtr_get_RelativeDragRotation_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06000C68 RID: 3176 RVA: 0x0005159C File Offset: 0x0004F79C
		public unsafe float TotalDragScale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3D.NativeMethodInfoPtr_get_TotalDragScale_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06000C69 RID: 3177 RVA: 0x000515D8 File Offset: 0x0004F7D8
		public unsafe float RelativeDragScale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3D.NativeMethodInfoPtr_get_RelativeDragScale_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06000C6A RID: 3178 RVA: 0x00051614 File Offset: 0x0004F814
		public unsafe GizmoOverrideColor OverrideColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3D.NativeMethodInfoPtr_get_OverrideColor_Public_get_GizmoOverrideColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoOverrideColor>(intPtr3) : null;
			}
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06000C6B RID: 3179 RVA: 0x00051654 File Offset: 0x0004F854
		public unsafe GizmoOverrideColor Cap3DOverrideColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3D.NativeMethodInfoPtr_get_Cap3DOverrideColor_Public_get_GizmoOverrideColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoOverrideColor>(intPtr3) : null;
			}
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06000C6C RID: 3180 RVA: 0x00051694 File Offset: 0x0004F894
		public unsafe GizmoLineSlider3DSettings Settings
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 62245, RefRangeEnd = 62251, XrefRangeStart = 62245, XrefRangeEnd = 62251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3D.NativeMethodInfoPtr_get_Settings_Public_get_GizmoLineSlider3DSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoLineSlider3DSettings>(intPtr3) : null;
			}
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06000C6D RID: 3181 RVA: 0x000516D4 File Offset: 0x0004F8D4
		// (set) Token: 0x06000C6E RID: 3182 RVA: 0x00051714 File Offset: 0x0004F914
		public unsafe GizmoLineSlider3DSettings SharedSettings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3D.NativeMethodInfoPtr_get_SharedSettings_Public_get_GizmoLineSlider3DSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoLineSlider3DSettings>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17932, RefRangeEnd = 17933, XrefRangeStart = 17932, XrefRangeEnd = 17933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3D.NativeMethodInfoPtr_set_SharedSettings_Public_set_Void_GizmoLineSlider3DSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06000C6F RID: 3183 RVA: 0x00051758 File Offset: 0x0004F958
		public unsafe GizmoLineSlider3DLookAndFeel LookAndFeel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3D.NativeMethodInfoPtr_get_LookAndFeel_Public_get_GizmoLineSlider3DLookAndFeel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoLineSlider3DLookAndFeel>(intPtr3) : null;
			}
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06000C70 RID: 3184 RVA: 0x00051798 File Offset: 0x0004F998
		// (set) Token: 0x06000C71 RID: 3185 RVA: 0x000517D8 File Offset: 0x0004F9D8
		public unsafe GizmoLineSlider3DLookAndFeel SharedLookAndFeel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3D.NativeMethodInfoPtr_get_SharedLookAndFeel_Public_get_GizmoLineSlider3DLookAndFeel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoLineSlider3DLookAndFeel>(intPtr3) : null;
			}
			[CallerCount(29)]
			[CachedScanResults(RefRangeStart = 66376, RefRangeEnd = 66405, XrefRangeStart = 66373, XrefRangeEnd = 66376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3D.NativeMethodInfoPtr_set_SharedLookAndFeel_Public_set_Void_GizmoLineSlider3DLookAndFeel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000C72 RID: 3186 RVA: 0x0005181C File Offset: 0x0004FA1C
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 66615, RefRangeEnd = 66639, XrefRangeStart = 66405, XrefRangeEnd = 66615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoLineSlider3D(Gizmo gizmo, int handleId, int capHandleId)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gizmo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handleId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capHandleId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3D.NativeMethodInfoPtr__ctor_Public_Void_Gizmo_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C73 RID: 3187 RVA: 0x00051884 File Offset: 0x0004FA84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66639, XrefRangeEnd = 66653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsScalerHandleRegistered(int handleId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handleId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3D.NativeMethodInfoPtr_IsScalerHandleRegistered_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C74 RID: 3188 RVA: 0x000518D0 File Offset: 0x0004FAD0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 66671, RefRangeEnd = 66673, XrefRangeStart = 66653, XrefRangeEnd = 66671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsScalerHandleRegistered(int handleId, int scaleDragAxisIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handleId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scaleDragAxisIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3D.NativeMethodInfoPtr_IsScalerHandleRegistered_Public_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C75 RID: 3189 RVA: 0x00051928 File Offset: 0x0004FB28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66673, XrefRangeEnd = 66694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterScalerHandle(int handleId, IEnumerable<int> scaleDragAxisIndices)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handleId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scaleDragAxisIndices);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3D.NativeMethodInfoPtr_RegisterScalerHandle_Public_Void_Int32_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C76 RID: 3190 RVA: 0x00051978 File Offset: 0x0004FB78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66694, XrefRangeEnd = 66708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnregisterScalerHandle(int handleId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handleId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3D.NativeMethodInfoPtr_UnregisterScalerHandle_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C77 RID: 3191 RVA: 0x000519B8 File Offset: 0x0004FBB8
		[CallerCount(0)]
		public unsafe override void SetSnapEnabled(bool isEnabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isEnabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoLineSlider3D.NativeMethodInfoPtr_SetSnapEnabled_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C78 RID: 3192 RVA: 0x00051A04 File Offset: 0x0004FC04
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 65349, RefRangeEnd = 65386, XrefRangeStart = 65349, XrefRangeEnd = 65386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set3DCapVisible(bool isVisible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isVisible;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3D.NativeMethodInfoPtr_Set3DCapVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C79 RID: 3193 RVA: 0x00051A44 File Offset: 0x0004FC44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set3DCapHoverable(bool isHoverable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isHoverable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3D.NativeMethodInfoPtr_Set3DCapHoverable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C7A RID: 3194 RVA: 0x00051A84 File Offset: 0x0004FC84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66708, XrefRangeEnd = 66710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetZoomFactorTransform(GizmoTransform transform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3D.NativeMethodInfoPtr_SetZoomFactorTransform_Public_Void_GizmoTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C7B RID: 3195 RVA: 0x00051AC8 File Offset: 0x0004FCC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66710, XrefRangeEnd = 66711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetZoomFactor(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3D.NativeMethodInfoPtr_GetZoomFactor_Public_Single_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C7C RID: 3196 RVA: 0x00051B18 File Offset: 0x0004FD18
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 66719, RefRangeEnd = 66728, XrefRangeStart = 66711, XrefRangeEnd = 66719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetRealDirection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3D.NativeMethodInfoPtr_GetRealDirection_Public_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
		}

		// Token: 0x06000C7D RID: 3197 RVA: 0x00051B58 File Offset: 0x0004FD58
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 66734, RefRangeEnd = 66736, XrefRangeStart = 66728, XrefRangeEnd = 66734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetRealSizeAlongDirection(Camera camera, Vector3 direction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(direction);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3D.NativeMethodInfoPtr_GetRealSizeAlongDirection_Public_Single_Camera_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C7E RID: 3198 RVA: 0x00051BB8 File Offset: 0x0004FDB8
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 66741, RefRangeEnd = 66751, XrefRangeStart = 66736, XrefRangeEnd = 66741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetRealLength(float zoomFactor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref zoomFactor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3D.NativeMethodInfoPtr_GetRealLength_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C7F RID: 3199 RVA: 0x00051C04 File Offset: 0x0004FE04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66751, XrefRangeEnd = 66753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetRealLengthWith3DCap(float zoomFactor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref zoomFactor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3D.NativeMethodInfoPtr_GetRealLengthWith3DCap_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C80 RID: 3200 RVA: 0x00051C50 File Offset: 0x0004FE50
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 66755, RefRangeEnd = 66764, XrefRangeStart = 66753, XrefRangeEnd = 66755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetRealEndPosition(float zoomFactor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref zoomFactor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3D.NativeMethodInfoPtr_GetRealEndPosition_Public_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x06000C81 RID: 3201 RVA: 0x00051C9C File Offset: 0x0004FE9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66764, XrefRangeEnd = 66767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetRealEndPositionWith3DCap(float zoomFactor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref zoomFactor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3D.NativeMethodInfoPtr_GetRealEndPositionWith3DCap_Public_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x06000C82 RID: 3202 RVA: 0x00051CE8 File Offset: 0x0004FEE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 66767, RefRangeEnd = 66769, XrefRangeStart = 66767, XrefRangeEnd = 66767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetRealBoxHeight(float zoomFactor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref zoomFactor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3D.NativeMethodInfoPtr_GetRealBoxHeight_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C83 RID: 3203 RVA: 0x00051D34 File Offset: 0x0004FF34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 66769, RefRangeEnd = 66771, XrefRangeStart = 66769, XrefRangeEnd = 66769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetRealBoxDepth(float zoomFactor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref zoomFactor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3D.NativeMethodInfoPtr_GetRealBoxDepth_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C84 RID: 3204 RVA: 0x00051D80 File Offset: 0x0004FF80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 66771, RefRangeEnd = 66773, XrefRangeStart = 66771, XrefRangeEnd = 66771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetRealCylinderRadius(float zoomFactor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref zoomFactor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3D.NativeMethodInfoPtr_GetRealCylinderRadius_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C85 RID: 3205 RVA: 0x00051DCC File Offset: 0x0004FFCC
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 66775, RefRangeEnd = 66793, XrefRangeStart = 66773, XrefRangeEnd = 66775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MapDirection(int axisIndex, AxisSign axisSign)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axisIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(axisSign);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3D.NativeMethodInfoPtr_MapDirection_Public_Void_Int32_AxisSign_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C86 RID: 3206 RVA: 0x00051E1C File Offset: 0x0005001C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66793, XrefRangeEnd = 66795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MapDragRotationAxis(GizmoTransform mapTransform, int axisIndex, AxisSign axisSign)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mapTransform);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axisIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(axisSign);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3D.NativeMethodInfoPtr_MapDragRotationAxis_Public_Void_GizmoTransform_Int32_AxisSign_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C87 RID: 3207 RVA: 0x00051E80 File Offset: 0x00050080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66795, XrefRangeEnd = 66797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnmapDragRotationAxis()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3D.NativeMethodInfoPtr_UnmapDragRotationAxis_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C88 RID: 3208 RVA: 0x00051EB4 File Offset: 0x000500B4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 66799, RefRangeEnd = 66805, XrefRangeStart = 66797, XrefRangeEnd = 66799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDirection(Vector3 directionAxis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(directionAxis);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3D.NativeMethodInfoPtr_SetDirection_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C89 RID: 3209 RVA: 0x00051EF8 File Offset: 0x000500F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66805, XrefRangeEnd = 66808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDragRotationAxis(Vector3 rotationAxis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rotationAxis);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3D.NativeMethodInfoPtr_SetDragRotationAxis_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C8A RID: 3210 RVA: 0x00051F3C File Offset: 0x0005013C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66808, XrefRangeEnd = 66812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddTargetTransform(GizmoTransform transform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3D.NativeMethodInfoPtr_AddTargetTransform_Public_Void_GizmoTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C8B RID: 3211 RVA: 0x00051F80 File Offset: 0x00050180
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66812, XrefRangeEnd = 66813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddTargetTransform(GizmoTransform transform, GizmoDragChannel dragChannel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dragChannel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3D.NativeMethodInfoPtr_AddTargetTransform_Public_Void_GizmoTransform_GizmoDragChannel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C8C RID: 3212 RVA: 0x00051FD4 File Offset: 0x000501D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66813, XrefRangeEnd = 66817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveTargetTransform(GizmoTransform transform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3D.NativeMethodInfoPtr_RemoveTargetTransform_Public_Void_GizmoTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C8D RID: 3213 RVA: 0x00052018 File Offset: 0x00050218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66817, XrefRangeEnd = 66818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveTargetTransform(GizmoTransform transform, GizmoDragChannel dragChannel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dragChannel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3D.NativeMethodInfoPtr_RemoveTargetTransform_Public_Void_GizmoTransform_GizmoDragChannel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C8E RID: 3214 RVA: 0x0005206C File Offset: 0x0005026C
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 66824, RefRangeEnd = 66848, XrefRangeStart = 66818, XrefRangeEnd = 66824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDragChannel(GizmoDragChannel dragChannel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dragChannel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3D.NativeMethodInfoPtr_SetDragChannel_Public_Void_GizmoDragChannel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C8F RID: 3215 RVA: 0x000520B0 File Offset: 0x000502B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66848, XrefRangeEnd = 66856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyZoomFactor(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3D.NativeMethodInfoPtr_ApplyZoomFactor_Public_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C90 RID: 3216 RVA: 0x000520F4 File Offset: 0x000502F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66856, XrefRangeEnd = 66899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Render(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoLineSlider3D.NativeMethodInfoPtr_Render_Public_Virtual_Void_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C91 RID: 3217 RVA: 0x00052144 File Offset: 0x00050344
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 66912, RefRangeEnd = 66913, XrefRangeStart = 66899, XrefRangeEnd = 66912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Refresh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3D.NativeMethodInfoPtr_Refresh_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C92 RID: 3218 RVA: 0x00052178 File Offset: 0x00050378
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66913, XrefRangeEnd = 66926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnVisibilityStateChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoLineSlider3D.NativeMethodInfoPtr_OnVisibilityStateChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C93 RID: 3219 RVA: 0x000521B4 File Offset: 0x000503B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnHoverableStateChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoLineSlider3D.NativeMethodInfoPtr_OnHoverableStateChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C94 RID: 3220 RVA: 0x000521F0 File Offset: 0x000503F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66926, XrefRangeEnd = 66948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGizmoPreUpdateBegin(Gizmo gizmo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gizmo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3D.NativeMethodInfoPtr_OnGizmoPreUpdateBegin_Private_Void_Gizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C95 RID: 3221 RVA: 0x00052234 File Offset: 0x00050434
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66948, XrefRangeEnd = 66951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGizmoAttemptHandleDragBegin(Gizmo gizmo, int handleId)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3D.NativeMethodInfoPtr_OnGizmoAttemptHandleDragBegin_Private_Void_Gizmo_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C96 RID: 3222 RVA: 0x00052284 File Offset: 0x00050484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66951, XrefRangeEnd = 66960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTransformChanged(GizmoTransform transform, GizmoTransform.ChangeData changeData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref changeData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3D.NativeMethodInfoPtr_OnTransformChanged_Private_Void_GizmoTransform_ChangeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C97 RID: 3223 RVA: 0x000522D4 File Offset: 0x000504D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66960, XrefRangeEnd = 66962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGizmoHandleHoverEnter(Gizmo gizmo, int handleId)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3D.NativeMethodInfoPtr_OnGizmoHandleHoverEnter_Private_Void_Gizmo_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C98 RID: 3224 RVA: 0x00052324 File Offset: 0x00050524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66962, XrefRangeEnd = 66963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGizmoPostEnabled(Gizmo gizmo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gizmo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3D.NativeMethodInfoPtr_OnGizmoPostEnabled_Private_Void_Gizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C99 RID: 3225 RVA: 0x00052368 File Offset: 0x00050568
		[CallerCount(0)]
		public unsafe void OnGizmoPostDisabled(Gizmo gizmo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gizmo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3D.NativeMethodInfoPtr_OnGizmoPostDisabled_Private_Void_Gizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C9A RID: 3226 RVA: 0x000523AC File Offset: 0x000505AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66963, XrefRangeEnd = 66965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGizmoHandleHoverExit(Gizmo gizmo, int handleId)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3D.NativeMethodInfoPtr_OnGizmoHandleHoverExit_Private_Void_Gizmo_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C9B RID: 3227 RVA: 0x000523FC File Offset: 0x000505FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66965, XrefRangeEnd = 66967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupSharedLookAndFeel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3D.NativeMethodInfoPtr_SetupSharedLookAndFeel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C9C RID: 3228 RVA: 0x00006696 File Offset: 0x00004896
		public GizmoLineSlider3D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06000C9D RID: 3229 RVA: 0x00052430 File Offset: 0x00050630
		// (set) Token: 0x06000C9E RID: 3230 RVA: 0x0000669F File Offset: 0x0000489F
		public unsafe SegmentShape3D _segment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3D.NativeFieldInfoPtr__segment);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SegmentShape3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3D.NativeFieldInfoPtr__segment), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06000C9F RID: 3231 RVA: 0x00052460 File Offset: 0x00050660
		// (set) Token: 0x06000CA0 RID: 3232 RVA: 0x000066BE File Offset: 0x000048BE
		public unsafe BoxShape3D _box
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3D.NativeFieldInfoPtr__box);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxShape3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3D.NativeFieldInfoPtr__box), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x06000CA1 RID: 3233 RVA: 0x00052490 File Offset: 0x00050690
		// (set) Token: 0x06000CA2 RID: 3234 RVA: 0x000066DD File Offset: 0x000048DD
		public unsafe CylinderShape3D _cylinder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3D.NativeFieldInfoPtr__cylinder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CylinderShape3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3D.NativeFieldInfoPtr__cylinder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06000CA3 RID: 3235 RVA: 0x000524C0 File Offset: 0x000506C0
		// (set) Token: 0x06000CA4 RID: 3236 RVA: 0x000066FC File Offset: 0x000048FC
		public unsafe int _segmentIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3D.NativeFieldInfoPtr__segmentIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3D.NativeFieldInfoPtr__segmentIndex)) = value;
			}
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06000CA5 RID: 3237 RVA: 0x000524E8 File Offset: 0x000506E8
		// (set) Token: 0x06000CA6 RID: 3238 RVA: 0x00006717 File Offset: 0x00004917
		public unsafe int _boxIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3D.NativeFieldInfoPtr__boxIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3D.NativeFieldInfoPtr__boxIndex)) = value;
			}
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x06000CA7 RID: 3239 RVA: 0x00052510 File Offset: 0x00050710
		// (set) Token: 0x06000CA8 RID: 3240 RVA: 0x00006732 File Offset: 0x00004932
		public unsafe int _cylinderIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3D.NativeFieldInfoPtr__cylinderIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3D.NativeFieldInfoPtr__cylinderIndex)) = value;
			}
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x06000CA9 RID: 3241 RVA: 0x00052538 File Offset: 0x00050738
		// (set) Token: 0x06000CAA RID: 3242 RVA: 0x0000674D File Offset: 0x0000494D
		public unsafe Il2CppReferenceArray<IGizmoLineSlider3DController> _controllers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3D.NativeFieldInfoPtr__controllers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IGizmoLineSlider3DController>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3D.NativeFieldInfoPtr__controllers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x06000CAB RID: 3243 RVA: 0x00052568 File Offset: 0x00050768
		// (set) Token: 0x06000CAC RID: 3244 RVA: 0x0000676C File Offset: 0x0000496C
		public unsafe GizmoLineSlider3DControllerData _controllerData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3D.NativeFieldInfoPtr__controllerData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoLineSlider3DControllerData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3D.NativeFieldInfoPtr__controllerData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x06000CAD RID: 3245 RVA: 0x00052598 File Offset: 0x00050798
		// (set) Token: 0x06000CAE RID: 3246 RVA: 0x0000678B File Offset: 0x0000498B
		public unsafe GizmoDragChannel _dragChannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3D.NativeFieldInfoPtr__dragChannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoDragChannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3D.NativeFieldInfoPtr__dragChannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x06000CAF RID: 3247 RVA: 0x000525C8 File Offset: 0x000507C8
		// (set) Token: 0x06000CB0 RID: 3248 RVA: 0x000067AA File Offset: 0x000049AA
		public unsafe GizmoSglAxisOffsetDrag3D _offsetDrag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3D.NativeFieldInfoPtr__offsetDrag);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoSglAxisOffsetDrag3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3D.NativeFieldInfoPtr__offsetDrag), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x06000CB1 RID: 3249 RVA: 0x000525F8 File Offset: 0x000507F8
		// (set) Token: 0x06000CB2 RID: 3250 RVA: 0x000067C9 File Offset: 0x000049C9
		public unsafe GizmoSglAxisRotationDrag3D _rotationDrag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3D.NativeFieldInfoPtr__rotationDrag);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoSglAxisRotationDrag3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3D.NativeFieldInfoPtr__rotationDrag), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x06000CB3 RID: 3251 RVA: 0x00052628 File Offset: 0x00050828
		// (set) Token: 0x06000CB4 RID: 3252 RVA: 0x000067E8 File Offset: 0x000049E8
		public unsafe GizmoRotationArc3D _rotationArc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3D.NativeFieldInfoPtr__rotationArc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoRotationArc3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3D.NativeFieldInfoPtr__rotationArc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06000CB5 RID: 3253 RVA: 0x00052658 File Offset: 0x00050858
		// (set) Token: 0x06000CB6 RID: 3254 RVA: 0x00006807 File Offset: 0x00004A07
		public unsafe GizmoSglAxisScaleDrag3D _scaleDrag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3D.NativeFieldInfoPtr__scaleDrag);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoSglAxisScaleDrag3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3D.NativeFieldInfoPtr__scaleDrag), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06000CB7 RID: 3255 RVA: 0x00052688 File Offset: 0x00050888
		// (set) Token: 0x06000CB8 RID: 3256 RVA: 0x00006826 File Offset: 0x00004A26
		public unsafe int _scaleDragAxisIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3D.NativeFieldInfoPtr__scaleDragAxisIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3D.NativeFieldInfoPtr__scaleDragAxisIndex)) = value;
			}
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x06000CB9 RID: 3257 RVA: 0x000526B0 File Offset: 0x000508B0
		// (set) Token: 0x06000CBA RID: 3258 RVA: 0x00006841 File Offset: 0x00004A41
		public unsafe List<GizmoScalerHandle> _scalerHandles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3D.NativeFieldInfoPtr__scalerHandles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GizmoScalerHandle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3D.NativeFieldInfoPtr__scalerHandles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x06000CBB RID: 3259 RVA: 0x000526E0 File Offset: 0x000508E0
		// (set) Token: 0x06000CBC RID: 3260 RVA: 0x00006860 File Offset: 0x00004A60
		public unsafe IGizmoDragSession _selectedDragSession
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3D.NativeFieldInfoPtr__selectedDragSession);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGizmoDragSession>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3D.NativeFieldInfoPtr__selectedDragSession), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x06000CBD RID: 3261 RVA: 0x00052710 File Offset: 0x00050910
		// (set) Token: 0x06000CBE RID: 3262 RVA: 0x0000687F File Offset: 0x00004A7F
		public unsafe GizmoCap3D _cap3D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3D.NativeFieldInfoPtr__cap3D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoCap3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3D.NativeFieldInfoPtr__cap3D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06000CBF RID: 3263 RVA: 0x00052740 File Offset: 0x00050940
		// (set) Token: 0x06000CC0 RID: 3264 RVA: 0x0000689E File Offset: 0x00004A9E
		public unsafe GizmoTransform _transform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3D.NativeFieldInfoPtr__transform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3D.NativeFieldInfoPtr__transform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x06000CC1 RID: 3265 RVA: 0x00052770 File Offset: 0x00050970
		// (set) Token: 0x06000CC2 RID: 3266 RVA: 0x000068BD File Offset: 0x00004ABD
		public unsafe GizmoTransformAxisMap3D _directionAxisMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3D.NativeFieldInfoPtr__directionAxisMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoTransformAxisMap3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3D.NativeFieldInfoPtr__directionAxisMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x06000CC3 RID: 3267 RVA: 0x000527A0 File Offset: 0x000509A0
		// (set) Token: 0x06000CC4 RID: 3268 RVA: 0x000068DC File Offset: 0x00004ADC
		public unsafe GizmoTransformAxisMap3D _dragRotationAxisMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3D.NativeFieldInfoPtr__dragRotationAxisMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoTransformAxisMap3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3D.NativeFieldInfoPtr__dragRotationAxisMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x06000CC5 RID: 3269 RVA: 0x000527D0 File Offset: 0x000509D0
		// (set) Token: 0x06000CC6 RID: 3270 RVA: 0x000068FB File Offset: 0x00004AFB
		public unsafe GizmoOverrideColor _overrideColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3D.NativeFieldInfoPtr__overrideColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoOverrideColor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3D.NativeFieldInfoPtr__overrideColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x06000CC7 RID: 3271 RVA: 0x00052800 File Offset: 0x00050A00
		// (set) Token: 0x06000CC8 RID: 3272 RVA: 0x0000691A File Offset: 0x00004B1A
		public unsafe GizmoLineSlider3DSettings _settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3D.NativeFieldInfoPtr__settings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoLineSlider3DSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3D.NativeFieldInfoPtr__settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x06000CC9 RID: 3273 RVA: 0x00052830 File Offset: 0x00050A30
		// (set) Token: 0x06000CCA RID: 3274 RVA: 0x00006939 File Offset: 0x00004B39
		public unsafe GizmoLineSlider3DSettings _sharedSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3D.NativeFieldInfoPtr__sharedSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoLineSlider3DSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3D.NativeFieldInfoPtr__sharedSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x06000CCB RID: 3275 RVA: 0x00052860 File Offset: 0x00050A60
		// (set) Token: 0x06000CCC RID: 3276 RVA: 0x00006958 File Offset: 0x00004B58
		public unsafe GizmoLineSlider3DLookAndFeel _lookAndFeel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3D.NativeFieldInfoPtr__lookAndFeel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoLineSlider3DLookAndFeel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3D.NativeFieldInfoPtr__lookAndFeel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x06000CCD RID: 3277 RVA: 0x00052890 File Offset: 0x00050A90
		// (set) Token: 0x06000CCE RID: 3278 RVA: 0x00006977 File Offset: 0x00004B77
		public unsafe GizmoLineSlider3DLookAndFeel _sharedLookAndFeel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3D.NativeFieldInfoPtr__sharedLookAndFeel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoLineSlider3DLookAndFeel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3D.NativeFieldInfoPtr__sharedLookAndFeel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000956 RID: 2390
		private static readonly IntPtr NativeFieldInfoPtr__segment;

		// Token: 0x04000957 RID: 2391
		private static readonly IntPtr NativeFieldInfoPtr__box;

		// Token: 0x04000958 RID: 2392
		private static readonly IntPtr NativeFieldInfoPtr__cylinder;

		// Token: 0x04000959 RID: 2393
		private static readonly IntPtr NativeFieldInfoPtr__segmentIndex;

		// Token: 0x0400095A RID: 2394
		private static readonly IntPtr NativeFieldInfoPtr__boxIndex;

		// Token: 0x0400095B RID: 2395
		private static readonly IntPtr NativeFieldInfoPtr__cylinderIndex;

		// Token: 0x0400095C RID: 2396
		private static readonly IntPtr NativeFieldInfoPtr__controllers;

		// Token: 0x0400095D RID: 2397
		private static readonly IntPtr NativeFieldInfoPtr__controllerData;

		// Token: 0x0400095E RID: 2398
		private static readonly IntPtr NativeFieldInfoPtr__dragChannel;

		// Token: 0x0400095F RID: 2399
		private static readonly IntPtr NativeFieldInfoPtr__offsetDrag;

		// Token: 0x04000960 RID: 2400
		private static readonly IntPtr NativeFieldInfoPtr__rotationDrag;

		// Token: 0x04000961 RID: 2401
		private static readonly IntPtr NativeFieldInfoPtr__rotationArc;

		// Token: 0x04000962 RID: 2402
		private static readonly IntPtr NativeFieldInfoPtr__scaleDrag;

		// Token: 0x04000963 RID: 2403
		private static readonly IntPtr NativeFieldInfoPtr__scaleDragAxisIndex;

		// Token: 0x04000964 RID: 2404
		private static readonly IntPtr NativeFieldInfoPtr__scalerHandles;

		// Token: 0x04000965 RID: 2405
		private static readonly IntPtr NativeFieldInfoPtr__selectedDragSession;

		// Token: 0x04000966 RID: 2406
		private static readonly IntPtr NativeFieldInfoPtr__cap3D;

		// Token: 0x04000967 RID: 2407
		private static readonly IntPtr NativeFieldInfoPtr__transform;

		// Token: 0x04000968 RID: 2408
		private static readonly IntPtr NativeFieldInfoPtr__directionAxisMap;

		// Token: 0x04000969 RID: 2409
		private static readonly IntPtr NativeFieldInfoPtr__dragRotationAxisMap;

		// Token: 0x0400096A RID: 2410
		private static readonly IntPtr NativeFieldInfoPtr__overrideColor;

		// Token: 0x0400096B RID: 2411
		private static readonly IntPtr NativeFieldInfoPtr__settings;

		// Token: 0x0400096C RID: 2412
		private static readonly IntPtr NativeFieldInfoPtr__sharedSettings;

		// Token: 0x0400096D RID: 2413
		private static readonly IntPtr NativeFieldInfoPtr__lookAndFeel;

		// Token: 0x0400096E RID: 2414
		private static readonly IntPtr NativeFieldInfoPtr__sharedLookAndFeel;

		// Token: 0x0400096F RID: 2415
		private static readonly IntPtr NativeMethodInfoPtr_get_Direction_Public_get_Vector3_0;

		// Token: 0x04000970 RID: 2416
		private static readonly IntPtr NativeMethodInfoPtr_get_DragRotationAxis_Public_get_Vector3_0;

		// Token: 0x04000971 RID: 2417
		private static readonly IntPtr NativeMethodInfoPtr_get_ScaleDragAxisIndex_Public_get_Int32_0;

		// Token: 0x04000972 RID: 2418
		private static readonly IntPtr NativeMethodInfoPtr_set_ScaleDragAxisIndex_Public_set_Void_Int32_0;

		// Token: 0x04000973 RID: 2419
		private static readonly IntPtr NativeMethodInfoPtr_get_StartPosition_Public_get_Vector3_0;

		// Token: 0x04000974 RID: 2420
		private static readonly IntPtr NativeMethodInfoPtr_set_StartPosition_Public_set_Void_Vector3_0;

		// Token: 0x04000975 RID: 2421
		private static readonly IntPtr NativeMethodInfoPtr_get_DragChannel_Public_get_GizmoDragChannel_0;

		// Token: 0x04000976 RID: 2422
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDragged_Public_get_Boolean_0;

		// Token: 0x04000977 RID: 2423
		private static readonly IntPtr NativeMethodInfoPtr_get_IsMoving_Public_get_Boolean_0;

		// Token: 0x04000978 RID: 2424
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRotating_Public_get_Boolean_0;

		// Token: 0x04000979 RID: 2425
		private static readonly IntPtr NativeMethodInfoPtr_get_IsScaling_Public_get_Boolean_0;

		// Token: 0x0400097A RID: 2426
		private static readonly IntPtr NativeMethodInfoPtr_get_Is3DCapVisible_Public_get_Boolean_0;

		// Token: 0x0400097B RID: 2427
		private static readonly IntPtr NativeMethodInfoPtr_get_Is3DCapHoverable_Public_get_Boolean_0;

		// Token: 0x0400097C RID: 2428
		private static readonly IntPtr NativeMethodInfoPtr_get_Cap3DHandleId_Public_get_Int32_0;

		// Token: 0x0400097D RID: 2429
		private static readonly IntPtr NativeMethodInfoPtr_get_TotalDragOffset_Public_get_Vector3_0;

		// Token: 0x0400097E RID: 2430
		private static readonly IntPtr NativeMethodInfoPtr_get_RelativeDragOffset_Public_get_Vector3_0;

		// Token: 0x0400097F RID: 2431
		private static readonly IntPtr NativeMethodInfoPtr_get_TotalDragRotation_Public_get_Single_0;

		// Token: 0x04000980 RID: 2432
		private static readonly IntPtr NativeMethodInfoPtr_get_RelativeDragRotation_Public_get_Single_0;

		// Token: 0x04000981 RID: 2433
		private static readonly IntPtr NativeMethodInfoPtr_get_TotalDragScale_Public_get_Single_0;

		// Token: 0x04000982 RID: 2434
		private static readonly IntPtr NativeMethodInfoPtr_get_RelativeDragScale_Public_get_Single_0;

		// Token: 0x04000983 RID: 2435
		private static readonly IntPtr NativeMethodInfoPtr_get_OverrideColor_Public_get_GizmoOverrideColor_0;

		// Token: 0x04000984 RID: 2436
		private static readonly IntPtr NativeMethodInfoPtr_get_Cap3DOverrideColor_Public_get_GizmoOverrideColor_0;

		// Token: 0x04000985 RID: 2437
		private static readonly IntPtr NativeMethodInfoPtr_get_Settings_Public_get_GizmoLineSlider3DSettings_0;

		// Token: 0x04000986 RID: 2438
		private static readonly IntPtr NativeMethodInfoPtr_get_SharedSettings_Public_get_GizmoLineSlider3DSettings_0;

		// Token: 0x04000987 RID: 2439
		private static readonly IntPtr NativeMethodInfoPtr_set_SharedSettings_Public_set_Void_GizmoLineSlider3DSettings_0;

		// Token: 0x04000988 RID: 2440
		private static readonly IntPtr NativeMethodInfoPtr_get_LookAndFeel_Public_get_GizmoLineSlider3DLookAndFeel_0;

		// Token: 0x04000989 RID: 2441
		private static readonly IntPtr NativeMethodInfoPtr_get_SharedLookAndFeel_Public_get_GizmoLineSlider3DLookAndFeel_0;

		// Token: 0x0400098A RID: 2442
		private static readonly IntPtr NativeMethodInfoPtr_set_SharedLookAndFeel_Public_set_Void_GizmoLineSlider3DLookAndFeel_0;

		// Token: 0x0400098B RID: 2443
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Gizmo_Int32_Int32_0;

		// Token: 0x0400098C RID: 2444
		private static readonly IntPtr NativeMethodInfoPtr_IsScalerHandleRegistered_Public_Boolean_Int32_0;

		// Token: 0x0400098D RID: 2445
		private static readonly IntPtr NativeMethodInfoPtr_IsScalerHandleRegistered_Public_Boolean_Int32_Int32_0;

		// Token: 0x0400098E RID: 2446
		private static readonly IntPtr NativeMethodInfoPtr_RegisterScalerHandle_Public_Void_Int32_IEnumerable_1_Int32_0;

		// Token: 0x0400098F RID: 2447
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterScalerHandle_Public_Void_Int32_0;

		// Token: 0x04000990 RID: 2448
		private static readonly IntPtr NativeMethodInfoPtr_SetSnapEnabled_Public_Virtual_Void_Boolean_0;

		// Token: 0x04000991 RID: 2449
		private static readonly IntPtr NativeMethodInfoPtr_Set3DCapVisible_Public_Void_Boolean_0;

		// Token: 0x04000992 RID: 2450
		private static readonly IntPtr NativeMethodInfoPtr_Set3DCapHoverable_Public_Void_Boolean_0;

		// Token: 0x04000993 RID: 2451
		private static readonly IntPtr NativeMethodInfoPtr_SetZoomFactorTransform_Public_Void_GizmoTransform_0;

		// Token: 0x04000994 RID: 2452
		private static readonly IntPtr NativeMethodInfoPtr_GetZoomFactor_Public_Single_Camera_0;

		// Token: 0x04000995 RID: 2453
		private static readonly IntPtr NativeMethodInfoPtr_GetRealDirection_Public_Vector3_0;

		// Token: 0x04000996 RID: 2454
		private static readonly IntPtr NativeMethodInfoPtr_GetRealSizeAlongDirection_Public_Single_Camera_Vector3_0;

		// Token: 0x04000997 RID: 2455
		private static readonly IntPtr NativeMethodInfoPtr_GetRealLength_Public_Single_Single_0;

		// Token: 0x04000998 RID: 2456
		private static readonly IntPtr NativeMethodInfoPtr_GetRealLengthWith3DCap_Public_Single_Single_0;

		// Token: 0x04000999 RID: 2457
		private static readonly IntPtr NativeMethodInfoPtr_GetRealEndPosition_Public_Vector3_Single_0;

		// Token: 0x0400099A RID: 2458
		private static readonly IntPtr NativeMethodInfoPtr_GetRealEndPositionWith3DCap_Public_Vector3_Single_0;

		// Token: 0x0400099B RID: 2459
		private static readonly IntPtr NativeMethodInfoPtr_GetRealBoxHeight_Public_Single_Single_0;

		// Token: 0x0400099C RID: 2460
		private static readonly IntPtr NativeMethodInfoPtr_GetRealBoxDepth_Public_Single_Single_0;

		// Token: 0x0400099D RID: 2461
		private static readonly IntPtr NativeMethodInfoPtr_GetRealCylinderRadius_Public_Single_Single_0;

		// Token: 0x0400099E RID: 2462
		private static readonly IntPtr NativeMethodInfoPtr_MapDirection_Public_Void_Int32_AxisSign_0;

		// Token: 0x0400099F RID: 2463
		private static readonly IntPtr NativeMethodInfoPtr_MapDragRotationAxis_Public_Void_GizmoTransform_Int32_AxisSign_0;

		// Token: 0x040009A0 RID: 2464
		private static readonly IntPtr NativeMethodInfoPtr_UnmapDragRotationAxis_Public_Void_0;

		// Token: 0x040009A1 RID: 2465
		private static readonly IntPtr NativeMethodInfoPtr_SetDirection_Public_Void_Vector3_0;

		// Token: 0x040009A2 RID: 2466
		private static readonly IntPtr NativeMethodInfoPtr_SetDragRotationAxis_Public_Void_Vector3_0;

		// Token: 0x040009A3 RID: 2467
		private static readonly IntPtr NativeMethodInfoPtr_AddTargetTransform_Public_Void_GizmoTransform_0;

		// Token: 0x040009A4 RID: 2468
		private static readonly IntPtr NativeMethodInfoPtr_AddTargetTransform_Public_Void_GizmoTransform_GizmoDragChannel_0;

		// Token: 0x040009A5 RID: 2469
		private static readonly IntPtr NativeMethodInfoPtr_RemoveTargetTransform_Public_Void_GizmoTransform_0;

		// Token: 0x040009A6 RID: 2470
		private static readonly IntPtr NativeMethodInfoPtr_RemoveTargetTransform_Public_Void_GizmoTransform_GizmoDragChannel_0;

		// Token: 0x040009A7 RID: 2471
		private static readonly IntPtr NativeMethodInfoPtr_SetDragChannel_Public_Void_GizmoDragChannel_0;

		// Token: 0x040009A8 RID: 2472
		private static readonly IntPtr NativeMethodInfoPtr_ApplyZoomFactor_Public_Void_Camera_0;

		// Token: 0x040009A9 RID: 2473
		private static readonly IntPtr NativeMethodInfoPtr_Render_Public_Virtual_Void_Camera_0;

		// Token: 0x040009AA RID: 2474
		private static readonly IntPtr NativeMethodInfoPtr_Refresh_Public_Void_0;

		// Token: 0x040009AB RID: 2475
		private static readonly IntPtr NativeMethodInfoPtr_OnVisibilityStateChanged_Protected_Virtual_Void_0;

		// Token: 0x040009AC RID: 2476
		private static readonly IntPtr NativeMethodInfoPtr_OnHoverableStateChanged_Protected_Virtual_Void_0;

		// Token: 0x040009AD RID: 2477
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoPreUpdateBegin_Private_Void_Gizmo_0;

		// Token: 0x040009AE RID: 2478
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoAttemptHandleDragBegin_Private_Void_Gizmo_Int32_0;

		// Token: 0x040009AF RID: 2479
		private static readonly IntPtr NativeMethodInfoPtr_OnTransformChanged_Private_Void_GizmoTransform_ChangeData_0;

		// Token: 0x040009B0 RID: 2480
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoHandleHoverEnter_Private_Void_Gizmo_Int32_0;

		// Token: 0x040009B1 RID: 2481
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoPostEnabled_Private_Void_Gizmo_0;

		// Token: 0x040009B2 RID: 2482
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoPostDisabled_Private_Void_Gizmo_0;

		// Token: 0x040009B3 RID: 2483
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoHandleHoverExit_Private_Void_Gizmo_Int32_0;

		// Token: 0x040009B4 RID: 2484
		private static readonly IntPtr NativeMethodInfoPtr_SetupSharedLookAndFeel_Private_Void_0;

		// Token: 0x0200036C RID: 876
		[ObfuscatedName("RLD.GizmoLineSlider3D+<>c__DisplayClass78_0")]
		public sealed class __c__DisplayClass78_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060049E8 RID: 18920 RVA: 0x00145F8C File Offset: 0x0014418C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass78_0()
			{
				Il2CppClassPointerStore<GizmoLineSlider3D.__c__DisplayClass78_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, "<>c__DisplayClass78_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoLineSlider3D.__c__DisplayClass78_0>.NativeClassPtr);
				GizmoLineSlider3D.__c__DisplayClass78_0.NativeFieldInfoPtr_handleId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider3D.__c__DisplayClass78_0>.NativeClassPtr, "handleId");
				GizmoLineSlider3D.__c__DisplayClass78_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D.__c__DisplayClass78_0>.NativeClassPtr, 100665167);
				GizmoLineSlider3D.__c__DisplayClass78_0.NativeMethodInfoPtr__IsScalerHandleRegistered_b__0_Internal_Boolean_GizmoScalerHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D.__c__DisplayClass78_0>.NativeClassPtr, 100665168);
			}

			// Token: 0x060049E9 RID: 18921 RVA: 0x00145FF4 File Offset: 0x001441F4
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass78_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoLineSlider3D.__c__DisplayClass78_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3D.__c__DisplayClass78_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060049EA RID: 18922 RVA: 0x00146030 File Offset: 0x00144230
			[CallerCount(0)]
			public unsafe bool _IsScalerHandleRegistered_b__0(GizmoScalerHandle item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3D.__c__DisplayClass78_0.NativeMethodInfoPtr__IsScalerHandleRegistered_b__0_Internal_Boolean_GizmoScalerHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060049EB RID: 18923 RVA: 0x0001B81B File Offset: 0x00019A1B
			public __c__DisplayClass78_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001907 RID: 6407
			// (get) Token: 0x060049EC RID: 18924 RVA: 0x00146080 File Offset: 0x00144280
			// (set) Token: 0x060049ED RID: 18925 RVA: 0x0001B824 File Offset: 0x00019A24
			public unsafe int handleId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3D.__c__DisplayClass78_0.NativeFieldInfoPtr_handleId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3D.__c__DisplayClass78_0.NativeFieldInfoPtr_handleId)) = value;
				}
			}

			// Token: 0x04003966 RID: 14694
			private static readonly IntPtr NativeFieldInfoPtr_handleId;

			// Token: 0x04003967 RID: 14695
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003968 RID: 14696
			private static readonly IntPtr NativeMethodInfoPtr__IsScalerHandleRegistered_b__0_Internal_Boolean_GizmoScalerHandle_0;
		}

		// Token: 0x0200036D RID: 877
		[ObfuscatedName("RLD.GizmoLineSlider3D+<>c__DisplayClass79_0")]
		public sealed class __c__DisplayClass79_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060049EE RID: 18926 RVA: 0x001460A8 File Offset: 0x001442A8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass79_0()
			{
				Il2CppClassPointerStore<GizmoLineSlider3D.__c__DisplayClass79_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, "<>c__DisplayClass79_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoLineSlider3D.__c__DisplayClass79_0>.NativeClassPtr);
				GizmoLineSlider3D.__c__DisplayClass79_0.NativeFieldInfoPtr_handleId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider3D.__c__DisplayClass79_0>.NativeClassPtr, "handleId");
				GizmoLineSlider3D.__c__DisplayClass79_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D.__c__DisplayClass79_0>.NativeClassPtr, 100665169);
				GizmoLineSlider3D.__c__DisplayClass79_0.NativeMethodInfoPtr__IsScalerHandleRegistered_b__0_Internal_Boolean_GizmoScalerHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D.__c__DisplayClass79_0>.NativeClassPtr, 100665170);
			}

			// Token: 0x060049EF RID: 18927 RVA: 0x00146110 File Offset: 0x00144310
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass79_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoLineSlider3D.__c__DisplayClass79_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3D.__c__DisplayClass79_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060049F0 RID: 18928 RVA: 0x0014614C File Offset: 0x0014434C
			[CallerCount(0)]
			public unsafe bool _IsScalerHandleRegistered_b__0(GizmoScalerHandle item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3D.__c__DisplayClass79_0.NativeMethodInfoPtr__IsScalerHandleRegistered_b__0_Internal_Boolean_GizmoScalerHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060049F1 RID: 18929 RVA: 0x0001B83F File Offset: 0x00019A3F
			public __c__DisplayClass79_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001908 RID: 6408
			// (get) Token: 0x060049F2 RID: 18930 RVA: 0x0014619C File Offset: 0x0014439C
			// (set) Token: 0x060049F3 RID: 18931 RVA: 0x0001B848 File Offset: 0x00019A48
			public unsafe int handleId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3D.__c__DisplayClass79_0.NativeFieldInfoPtr_handleId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3D.__c__DisplayClass79_0.NativeFieldInfoPtr_handleId)) = value;
				}
			}

			// Token: 0x04003969 RID: 14697
			private static readonly IntPtr NativeFieldInfoPtr_handleId;

			// Token: 0x0400396A RID: 14698
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400396B RID: 14699
			private static readonly IntPtr NativeMethodInfoPtr__IsScalerHandleRegistered_b__0_Internal_Boolean_GizmoScalerHandle_0;
		}

		// Token: 0x0200036E RID: 878
		[ObfuscatedName("RLD.GizmoLineSlider3D+<>c__DisplayClass81_0")]
		public sealed class __c__DisplayClass81_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060049F4 RID: 18932 RVA: 0x001461C4 File Offset: 0x001443C4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass81_0()
			{
				Il2CppClassPointerStore<GizmoLineSlider3D.__c__DisplayClass81_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GizmoLineSlider3D>.NativeClassPtr, "<>c__DisplayClass81_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoLineSlider3D.__c__DisplayClass81_0>.NativeClassPtr);
				GizmoLineSlider3D.__c__DisplayClass81_0.NativeFieldInfoPtr_handleId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider3D.__c__DisplayClass81_0>.NativeClassPtr, "handleId");
				GizmoLineSlider3D.__c__DisplayClass81_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D.__c__DisplayClass81_0>.NativeClassPtr, 100665171);
				GizmoLineSlider3D.__c__DisplayClass81_0.NativeMethodInfoPtr__UnregisterScalerHandle_b__0_Internal_Boolean_GizmoScalerHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider3D.__c__DisplayClass81_0>.NativeClassPtr, 100665172);
			}

			// Token: 0x060049F5 RID: 18933 RVA: 0x0014622C File Offset: 0x0014442C
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass81_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoLineSlider3D.__c__DisplayClass81_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3D.__c__DisplayClass81_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060049F6 RID: 18934 RVA: 0x00146268 File Offset: 0x00144468
			[CallerCount(0)]
			public unsafe bool _UnregisterScalerHandle_b__0(GizmoScalerHandle item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider3D.__c__DisplayClass81_0.NativeMethodInfoPtr__UnregisterScalerHandle_b__0_Internal_Boolean_GizmoScalerHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060049F7 RID: 18935 RVA: 0x0001B863 File Offset: 0x00019A63
			public __c__DisplayClass81_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001909 RID: 6409
			// (get) Token: 0x060049F8 RID: 18936 RVA: 0x001462B8 File Offset: 0x001444B8
			// (set) Token: 0x060049F9 RID: 18937 RVA: 0x0001B86C File Offset: 0x00019A6C
			public unsafe int handleId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3D.__c__DisplayClass81_0.NativeFieldInfoPtr_handleId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider3D.__c__DisplayClass81_0.NativeFieldInfoPtr_handleId)) = value;
				}
			}

			// Token: 0x0400396C RID: 14700
			private static readonly IntPtr NativeFieldInfoPtr_handleId;

			// Token: 0x0400396D RID: 14701
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400396E RID: 14702
			private static readonly IntPtr NativeMethodInfoPtr__UnregisterScalerHandle_b__0_Internal_Boolean_GizmoScalerHandle_0;
		}
	}
}
