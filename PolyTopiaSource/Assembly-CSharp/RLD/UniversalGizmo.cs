using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x020000EA RID: 234
	[Serializable]
	public class UniversalGizmo : GizmoBehaviour
	{
		// Token: 0x06001507 RID: 5383 RVA: 0x00071B84 File Offset: 0x0006FD84
		// Note: this type is marked as 'beforefieldinit'.
		static UniversalGizmo()
		{
			Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "UniversalGizmo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr);
			UniversalGizmo.NativeFieldInfoPtr__mvPXSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, "_mvPXSlider");
			UniversalGizmo.NativeFieldInfoPtr__mvPYSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, "_mvPYSlider");
			UniversalGizmo.NativeFieldInfoPtr__mvPZSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, "_mvPZSlider");
			UniversalGizmo.NativeFieldInfoPtr__mvNXSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, "_mvNXSlider");
			UniversalGizmo.NativeFieldInfoPtr__mvNYSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, "_mvNYSlider");
			UniversalGizmo.NativeFieldInfoPtr__mvNZSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, "_mvNZSlider");
			UniversalGizmo.NativeFieldInfoPtr__mvAxesSliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, "_mvAxesSliders");
			UniversalGizmo.NativeFieldInfoPtr__mvXYSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, "_mvXYSlider");
			UniversalGizmo.NativeFieldInfoPtr__mvYZSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, "_mvYZSlider");
			UniversalGizmo.NativeFieldInfoPtr__mvZXSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, "_mvZXSlider");
			UniversalGizmo.NativeFieldInfoPtr__mvDblSliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, "_mvDblSliders");
			UniversalGizmo.NativeFieldInfoPtr__isMvVertexSnapEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, "_isMvVertexSnapEnabled");
			UniversalGizmo.NativeFieldInfoPtr__mvVertSnapCap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, "_mvVertSnapCap");
			UniversalGizmo.NativeFieldInfoPtr__mvVertexSnapDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, "_mvVertexSnapDrag");
			UniversalGizmo.NativeFieldInfoPtr__mvPostVSnapPosRestore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, "_mvPostVSnapPosRestore");
			UniversalGizmo.NativeFieldInfoPtr__mvP2DModeXSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, "_mvP2DModeXSlider");
			UniversalGizmo.NativeFieldInfoPtr__mvP2DModeYSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, "_mvP2DModeYSlider");
			UniversalGizmo.NativeFieldInfoPtr__mvN2DModeXSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, "_mvN2DModeXSlider");
			UniversalGizmo.NativeFieldInfoPtr__mvN2DModeYSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, "_mvN2DModeYSlider");
			UniversalGizmo.NativeFieldInfoPtr__mv2DModeSliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, "_mv2DModeSliders");
			UniversalGizmo.NativeFieldInfoPtr__mv2DModeDblSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, "_mv2DModeDblSlider");
			UniversalGizmo.NativeFieldInfoPtr__rtXSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, "_rtXSlider");
			UniversalGizmo.NativeFieldInfoPtr__rtYSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, "_rtYSlider");
			UniversalGizmo.NativeFieldInfoPtr__rtZSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, "_rtZSlider");
			UniversalGizmo.NativeFieldInfoPtr__rtAxesSliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, "_rtAxesSliders");
			UniversalGizmo.NativeFieldInfoPtr__rtMidCap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, "_rtMidCap");
			UniversalGizmo.NativeFieldInfoPtr__rtCamXYRotationDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, "_rtCamXYRotationDrag");
			UniversalGizmo.NativeFieldInfoPtr__rtCamLookSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, "_rtCamLookSlider");
			UniversalGizmo.NativeFieldInfoPtr__scMidCap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, "_scMidCap");
			UniversalGizmo.NativeFieldInfoPtr__scUnformScaleDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, "_scUnformScaleDrag");
			UniversalGizmo.NativeFieldInfoPtr__scScaleGuide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, "_scScaleGuide");
			UniversalGizmo.NativeFieldInfoPtr__scScaleGuideTargetObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, "_scScaleGuideTargetObjects");
			UniversalGizmo.NativeFieldInfoPtr__is2DModeEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, "_is2DModeEnabled");
			UniversalGizmo.NativeFieldInfoPtr__settings2D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, "_settings2D");
			UniversalGizmo.NativeFieldInfoPtr__sharedSettings2D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, "_sharedSettings2D");
			UniversalGizmo.NativeFieldInfoPtr__settings3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, "_settings3D");
			UniversalGizmo.NativeFieldInfoPtr__sharedSettings3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, "_sharedSettings3D");
			UniversalGizmo.NativeFieldInfoPtr__lookAndFeel2D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, "_lookAndFeel2D");
			UniversalGizmo.NativeFieldInfoPtr__sharedLookAndFeel2D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, "_sharedLookAndFeel2D");
			UniversalGizmo.NativeFieldInfoPtr__lookAndFeel3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, "_lookAndFeel3D");
			UniversalGizmo.NativeFieldInfoPtr__sharedLookAndFeel3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, "_sharedLookAndFeel3D");
			UniversalGizmo.NativeFieldInfoPtr__hotkeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, "_hotkeys");
			UniversalGizmo.NativeFieldInfoPtr__sharedHotkeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, "_sharedHotkeys");
			UniversalGizmo.NativeFieldInfoPtr__useSnapEnableHotkey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, "_useSnapEnableHotkey");
			UniversalGizmo.NativeFieldInfoPtr__useVertSnapEnableHotkey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, "_useVertSnapEnableHotkey");
			UniversalGizmo.NativeFieldInfoPtr__use2DModeEnableHotkey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, "_use2DModeEnableHotkey");
			UniversalGizmo.NativeMethodInfoPtr_get_Settings2D_Public_get_UniversalGizmoSettings2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, 100666302);
			UniversalGizmo.NativeMethodInfoPtr_get_SharedSettings2D_Public_get_UniversalGizmoSettings2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, 100666303);
			UniversalGizmo.NativeMethodInfoPtr_set_SharedSettings2D_Public_set_Void_UniversalGizmoSettings2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, 100666304);
			UniversalGizmo.NativeMethodInfoPtr_get_Settings3D_Public_get_UniversalGizmoSettings3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, 100666305);
			UniversalGizmo.NativeMethodInfoPtr_get_SharedSettings3D_Public_get_UniversalGizmoSettings3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, 100666306);
			UniversalGizmo.NativeMethodInfoPtr_set_SharedSettings3D_Public_set_Void_UniversalGizmoSettings3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, 100666307);
			UniversalGizmo.NativeMethodInfoPtr_get_LookAndFeel2D_Public_get_UniversalGizmoLookAndFeel2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, 100666308);
			UniversalGizmo.NativeMethodInfoPtr_get_SharedLookAndFeel2D_Public_get_UniversalGizmoLookAndFeel2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, 100666309);
			UniversalGizmo.NativeMethodInfoPtr_set_SharedLookAndFeel2D_Public_set_Void_UniversalGizmoLookAndFeel2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, 100666310);
			UniversalGizmo.NativeMethodInfoPtr_get_LookAndFeel3D_Public_get_UniversalGizmoLookAndFeel3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, 100666311);
			UniversalGizmo.NativeMethodInfoPtr_get_SharedLookAndFeel3D_Public_get_UniversalGizmoLookAndFeel3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, 100666312);
			UniversalGizmo.NativeMethodInfoPtr_set_SharedLookAndFeel3D_Public_set_Void_UniversalGizmoLookAndFeel3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, 100666313);
			UniversalGizmo.NativeMethodInfoPtr_get_Hotkeys_Public_get_UniversalGizmoHotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, 100666314);
			UniversalGizmo.NativeMethodInfoPtr_get_SharedHotkeys_Public_get_UniversalGizmoHotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, 100666315);
			UniversalGizmo.NativeMethodInfoPtr_set_SharedHotkeys_Public_set_Void_UniversalGizmoHotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, 100666316);
			UniversalGizmo.NativeMethodInfoPtr_get_UseSnapEnableHotkey_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, 100666317);
			UniversalGizmo.NativeMethodInfoPtr_set_UseSnapEnableHotkey_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, 100666318);
			UniversalGizmo.NativeMethodInfoPtr_get_UseVertSnapEnableHotkey_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, 100666319);
			UniversalGizmo.NativeMethodInfoPtr_set_UseVertSnapEnableHotkey_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, 100666320);
			UniversalGizmo.NativeMethodInfoPtr_get_Use2DModeEnableHotkey_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, 100666321);
			UniversalGizmo.NativeMethodInfoPtr_set_Use2DModeEnableHotkey_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, 100666322);
			UniversalGizmo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, 100666366);
			UniversalGizmo.NativeMethodInfoPtr_GetMvVertexSnapState_Public_MvVertexSnapState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, 100666323);
			UniversalGizmo.NativeMethodInfoPtr_GetMvZoomFactor_Public_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, 100666324);
			UniversalGizmo.NativeMethodInfoPtr_GetMvZoomFactor_Public_Single_Vector3_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, 100666325);
			UniversalGizmo.NativeMethodInfoPtr_GetRtZoomFactor_Public_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, 100666326);
			UniversalGizmo.NativeMethodInfoPtr_GetRtZoomFactor_Public_Single_Vector3_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, 100666327);
			UniversalGizmo.NativeMethodInfoPtr_GetScZoomFactor_Public_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, 100666328);
			UniversalGizmo.NativeMethodInfoPtr_GetScZoomFactor_Public_Single_Vector3_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, 100666329);
			UniversalGizmo.NativeMethodInfoPtr_IsDraggingMoveHandle_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, 100666330);
			UniversalGizmo.NativeMethodInfoPtr_IsDraggingRotationHandle_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, 100666331);
			UniversalGizmo.NativeMethodInfoPtr_IsDraggingScaleHandle_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, 100666332);
			UniversalGizmo.NativeMethodInfoPtr_IsMoveHandle_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, 100666333);
			UniversalGizmo.NativeMethodInfoPtr_IsRotationHandle_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, 100666334);
			UniversalGizmo.NativeMethodInfoPtr_IsScaleHandle_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, 100666335);
			UniversalGizmo.NativeMethodInfoPtr_OwnsHandle_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, 100666336);
			UniversalGizmo.NativeMethodInfoPtr_SetSnapEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, 100666337);
			UniversalGizmo.NativeMethodInfoPtr_SetMvVertexSnapEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, 100666338);
			UniversalGizmo.NativeMethodInfoPtr_Set2DModeEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, 100666339);
			UniversalGizmo.NativeMethodInfoPtr_SetMvVertexSnapTargetObjects_Public_Void_IEnumerable_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, 100666340);
			UniversalGizmo.NativeMethodInfoPtr_SetMvAxesLinesHoverable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, 100666341);
			UniversalGizmo.NativeMethodInfoPtr_SetRtMidCapHoverable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, 100666342);
			UniversalGizmo.NativeMethodInfoPtr_SetScaleGuideTargetObjects_Public_Void_IEnumerable_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, 100666343);
			UniversalGizmo.NativeMethodInfoPtr_OnAttached_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, 100666344);
			UniversalGizmo.NativeMethodInfoPtr_OnDetached_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, 100666345);
			UniversalGizmo.NativeMethodInfoPtr_OnEnabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, 100666346);
			UniversalGizmo.NativeMethodInfoPtr_OnDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, 100666347);
			UniversalGizmo.NativeMethodInfoPtr_OnGizmoEnabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, 100666348);
			UniversalGizmo.NativeMethodInfoPtr_OnGizmoUpdateBegin_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, 100666349);
			UniversalGizmo.NativeMethodInfoPtr_OnGizmoRender_Public_Virtual_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, 100666350);
			UniversalGizmo.NativeMethodInfoPtr_OnGizmoDragUpdate_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, 100666351);
			UniversalGizmo.NativeMethodInfoPtr_OnGizmoDragBegin_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, 100666352);
			UniversalGizmo.NativeMethodInfoPtr_OnGizmoDragEnd_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, 100666353);
			UniversalGizmo.NativeMethodInfoPtr_OnGizmoAttemptHandleDragBegin_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, 100666354);
			UniversalGizmo.NativeMethodInfoPtr_PlaceMvDblSlidersInSliderPlanes_Private_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, 100666355);
			UniversalGizmo.NativeMethodInfoPtr_SetupSharedLookAndFeel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, 100666356);
			UniversalGizmo.NativeMethodInfoPtr_SetupSharedSettings_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, 100666357);
			UniversalGizmo.NativeMethodInfoPtr_Update2DGizmoPosition_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, 100666358);
			UniversalGizmo.NativeMethodInfoPtr_Update2DModeHandlePositions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, 100666359);
			UniversalGizmo.NativeMethodInfoPtr_OnGizmoTransformChanged_Private_Void_GizmoTransform_ChangeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, 100666360);
			UniversalGizmo.NativeMethodInfoPtr_Hide2DModeHandles_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, 100666361);
			UniversalGizmo.NativeMethodInfoPtr_UpdateRtCamLookSlider_Private_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, 100666362);
			UniversalGizmo.NativeMethodInfoPtr_SetMoveHandlesVisible_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, 100666363);
			UniversalGizmo.NativeMethodInfoPtr_SetRotationHandlesVisible_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, 100666364);
			UniversalGizmo.NativeMethodInfoPtr_SetScaleHandlesVisible_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr, 100666365);
		}

		// Token: 0x170007D7 RID: 2007
		// (get) Token: 0x06001508 RID: 5384 RVA: 0x00072460 File Offset: 0x00070660
		public unsafe UniversalGizmoSettings2D Settings2D
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmo.NativeMethodInfoPtr_get_Settings2D_Public_get_UniversalGizmoSettings2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UniversalGizmoSettings2D>(intPtr3) : null;
			}
		}

		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x06001509 RID: 5385 RVA: 0x000724A0 File Offset: 0x000706A0
		// (set) Token: 0x0600150A RID: 5386 RVA: 0x000724E0 File Offset: 0x000706E0
		public unsafe UniversalGizmoSettings2D SharedSettings2D
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmo.NativeMethodInfoPtr_get_SharedSettings2D_Public_get_UniversalGizmoSettings2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UniversalGizmoSettings2D>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 72075, RefRangeEnd = 72076, XrefRangeStart = 72073, XrefRangeEnd = 72075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmo.NativeMethodInfoPtr_set_SharedSettings2D_Public_set_Void_UniversalGizmoSettings2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007D9 RID: 2009
		// (get) Token: 0x0600150B RID: 5387 RVA: 0x00072524 File Offset: 0x00070724
		public unsafe UniversalGizmoSettings3D Settings3D
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmo.NativeMethodInfoPtr_get_Settings3D_Public_get_UniversalGizmoSettings3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UniversalGizmoSettings3D>(intPtr3) : null;
			}
		}

		// Token: 0x170007DA RID: 2010
		// (get) Token: 0x0600150C RID: 5388 RVA: 0x00072564 File Offset: 0x00070764
		// (set) Token: 0x0600150D RID: 5389 RVA: 0x000725A4 File Offset: 0x000707A4
		public unsafe UniversalGizmoSettings3D SharedSettings3D
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 59872, RefRangeEnd = 59873, XrefRangeStart = 59872, XrefRangeEnd = 59873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmo.NativeMethodInfoPtr_get_SharedSettings3D_Public_get_UniversalGizmoSettings3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UniversalGizmoSettings3D>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 72078, RefRangeEnd = 72079, XrefRangeStart = 72076, XrefRangeEnd = 72078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmo.NativeMethodInfoPtr_set_SharedSettings3D_Public_set_Void_UniversalGizmoSettings3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007DB RID: 2011
		// (get) Token: 0x0600150E RID: 5390 RVA: 0x000725E8 File Offset: 0x000707E8
		public unsafe UniversalGizmoLookAndFeel2D LookAndFeel2D
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmo.NativeMethodInfoPtr_get_LookAndFeel2D_Public_get_UniversalGizmoLookAndFeel2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UniversalGizmoLookAndFeel2D>(intPtr3) : null;
			}
		}

		// Token: 0x170007DC RID: 2012
		// (get) Token: 0x0600150F RID: 5391 RVA: 0x00072628 File Offset: 0x00070828
		// (set) Token: 0x06001510 RID: 5392 RVA: 0x00072668 File Offset: 0x00070868
		public unsafe UniversalGizmoLookAndFeel2D SharedLookAndFeel2D
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmo.NativeMethodInfoPtr_get_SharedLookAndFeel2D_Public_get_UniversalGizmoLookAndFeel2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UniversalGizmoLookAndFeel2D>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 72081, RefRangeEnd = 72082, XrefRangeStart = 72079, XrefRangeEnd = 72081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmo.NativeMethodInfoPtr_set_SharedLookAndFeel2D_Public_set_Void_UniversalGizmoLookAndFeel2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007DD RID: 2013
		// (get) Token: 0x06001511 RID: 5393 RVA: 0x000726AC File Offset: 0x000708AC
		public unsafe UniversalGizmoLookAndFeel3D LookAndFeel3D
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmo.NativeMethodInfoPtr_get_LookAndFeel3D_Public_get_UniversalGizmoLookAndFeel3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UniversalGizmoLookAndFeel3D>(intPtr3) : null;
			}
		}

		// Token: 0x170007DE RID: 2014
		// (get) Token: 0x06001512 RID: 5394 RVA: 0x000726EC File Offset: 0x000708EC
		// (set) Token: 0x06001513 RID: 5395 RVA: 0x0007272C File Offset: 0x0007092C
		public unsafe UniversalGizmoLookAndFeel3D SharedLookAndFeel3D
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmo.NativeMethodInfoPtr_get_SharedLookAndFeel3D_Public_get_UniversalGizmoLookAndFeel3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UniversalGizmoLookAndFeel3D>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 72084, RefRangeEnd = 72085, XrefRangeStart = 72082, XrefRangeEnd = 72084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmo.NativeMethodInfoPtr_set_SharedLookAndFeel3D_Public_set_Void_UniversalGizmoLookAndFeel3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007DF RID: 2015
		// (get) Token: 0x06001514 RID: 5396 RVA: 0x00072770 File Offset: 0x00070970
		public unsafe UniversalGizmoHotkeys Hotkeys
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmo.NativeMethodInfoPtr_get_Hotkeys_Public_get_UniversalGizmoHotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UniversalGizmoHotkeys>(intPtr3) : null;
			}
		}

		// Token: 0x170007E0 RID: 2016
		// (get) Token: 0x06001515 RID: 5397 RVA: 0x000727B0 File Offset: 0x000709B0
		// (set) Token: 0x06001516 RID: 5398 RVA: 0x000727F0 File Offset: 0x000709F0
		public unsafe UniversalGizmoHotkeys SharedHotkeys
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmo.NativeMethodInfoPtr_get_SharedHotkeys_Public_get_UniversalGizmoHotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UniversalGizmoHotkeys>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72085, XrefRangeEnd = 72086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmo.NativeMethodInfoPtr_set_SharedHotkeys_Public_set_Void_UniversalGizmoHotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007E1 RID: 2017
		// (get) Token: 0x06001517 RID: 5399 RVA: 0x00072834 File Offset: 0x00070A34
		// (set) Token: 0x06001518 RID: 5400 RVA: 0x00072870 File Offset: 0x00070A70
		public unsafe bool UseSnapEnableHotkey
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmo.NativeMethodInfoPtr_get_UseSnapEnableHotkey_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmo.NativeMethodInfoPtr_set_UseSnapEnableHotkey_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007E2 RID: 2018
		// (get) Token: 0x06001519 RID: 5401 RVA: 0x000728B0 File Offset: 0x00070AB0
		// (set) Token: 0x0600151A RID: 5402 RVA: 0x000728EC File Offset: 0x00070AEC
		public unsafe bool UseVertSnapEnableHotkey
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmo.NativeMethodInfoPtr_get_UseVertSnapEnableHotkey_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmo.NativeMethodInfoPtr_set_UseVertSnapEnableHotkey_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170007E3 RID: 2019
		// (get) Token: 0x0600151B RID: 5403 RVA: 0x0007292C File Offset: 0x00070B2C
		// (set) Token: 0x0600151C RID: 5404 RVA: 0x00072968 File Offset: 0x00070B68
		public unsafe bool Use2DModeEnableHotkey
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmo.NativeMethodInfoPtr_get_Use2DModeEnableHotkey_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmo.NativeMethodInfoPtr_set_Use2DModeEnableHotkey_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600151D RID: 5405 RVA: 0x000729A8 File Offset: 0x00070BA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 72174, RefRangeEnd = 72176, XrefRangeStart = 72086, XrefRangeEnd = 72174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniversalGizmo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniversalGizmo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600151E RID: 5406 RVA: 0x000729E4 File Offset: 0x00070BE4
		[CallerCount(0)]
		public unsafe UniversalGizmo.MvVertexSnapState GetMvVertexSnapState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmo.NativeMethodInfoPtr_GetMvVertexSnapState_Public_MvVertexSnapState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600151F RID: 5407 RVA: 0x00072A20 File Offset: 0x00070C20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72176, XrefRangeEnd = 72181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetMvZoomFactor(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(position);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmo.NativeMethodInfoPtr_GetMvZoomFactor_Public_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001520 RID: 5408 RVA: 0x00072A70 File Offset: 0x00070C70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72181, XrefRangeEnd = 72185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetMvZoomFactor(Vector3 position, Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(position);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmo.NativeMethodInfoPtr_GetMvZoomFactor_Public_Single_Vector3_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001521 RID: 5409 RVA: 0x00072AD0 File Offset: 0x00070CD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72185, XrefRangeEnd = 72190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetRtZoomFactor(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(position);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmo.NativeMethodInfoPtr_GetRtZoomFactor_Public_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001522 RID: 5410 RVA: 0x00072B20 File Offset: 0x00070D20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72190, XrefRangeEnd = 72194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetRtZoomFactor(Vector3 position, Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(position);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmo.NativeMethodInfoPtr_GetRtZoomFactor_Public_Single_Vector3_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001523 RID: 5411 RVA: 0x00072B80 File Offset: 0x00070D80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72194, XrefRangeEnd = 72199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetScZoomFactor(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(position);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmo.NativeMethodInfoPtr_GetScZoomFactor_Public_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001524 RID: 5412 RVA: 0x00072BD0 File Offset: 0x00070DD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72199, XrefRangeEnd = 72203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetScZoomFactor(Vector3 position, Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(position);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmo.NativeMethodInfoPtr_GetScZoomFactor_Public_Single_Vector3_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001525 RID: 5413 RVA: 0x00072C30 File Offset: 0x00070E30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72203, XrefRangeEnd = 72204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsDraggingMoveHandle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmo.NativeMethodInfoPtr_IsDraggingMoveHandle_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001526 RID: 5414 RVA: 0x00072C6C File Offset: 0x00070E6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72204, XrefRangeEnd = 72205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsDraggingRotationHandle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmo.NativeMethodInfoPtr_IsDraggingRotationHandle_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001527 RID: 5415 RVA: 0x00072CA8 File Offset: 0x00070EA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72205, XrefRangeEnd = 72206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsDraggingScaleHandle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmo.NativeMethodInfoPtr_IsDraggingScaleHandle_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001528 RID: 5416 RVA: 0x00072CE4 File Offset: 0x00070EE4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 72212, RefRangeEnd = 72217, XrefRangeStart = 72206, XrefRangeEnd = 72212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsMoveHandle(int handleId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handleId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmo.NativeMethodInfoPtr_IsMoveHandle_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001529 RID: 5417 RVA: 0x00072D30 File Offset: 0x00070F30
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 72220, RefRangeEnd = 72223, XrefRangeStart = 72217, XrefRangeEnd = 72220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsRotationHandle(int handleId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handleId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmo.NativeMethodInfoPtr_IsRotationHandle_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600152A RID: 5418 RVA: 0x00072D7C File Offset: 0x00070F7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72223, XrefRangeEnd = 72224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsScaleHandle(int handleId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handleId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmo.NativeMethodInfoPtr_IsScaleHandle_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600152B RID: 5419 RVA: 0x00072DC8 File Offset: 0x00070FC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72224, XrefRangeEnd = 72227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool OwnsHandle(int handleId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handleId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmo.NativeMethodInfoPtr_OwnsHandle_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600152C RID: 5420 RVA: 0x00072E14 File Offset: 0x00071014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72227, XrefRangeEnd = 72231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSnapEnabled(bool isEnabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isEnabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmo.NativeMethodInfoPtr_SetSnapEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600152D RID: 5421 RVA: 0x00072E54 File Offset: 0x00071054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72231, XrefRangeEnd = 72238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMvVertexSnapEnabled(bool isEnabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isEnabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmo.NativeMethodInfoPtr_SetMvVertexSnapEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600152E RID: 5422 RVA: 0x00072E94 File Offset: 0x00071094
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 72241, RefRangeEnd = 72242, XrefRangeStart = 72238, XrefRangeEnd = 72241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set2DModeEnabled(bool isEnabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isEnabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmo.NativeMethodInfoPtr_Set2DModeEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600152F RID: 5423 RVA: 0x00072ED4 File Offset: 0x000710D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 72244, RefRangeEnd = 72245, XrefRangeStart = 72242, XrefRangeEnd = 72244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMvVertexSnapTargetObjects(IEnumerable<GameObject> targetObjects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetObjects);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmo.NativeMethodInfoPtr_SetMvVertexSnapTargetObjects_Public_Void_IEnumerable_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001530 RID: 5424 RVA: 0x00072F18 File Offset: 0x00071118
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMvAxesLinesHoverable(bool hoverable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hoverable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmo.NativeMethodInfoPtr_SetMvAxesLinesHoverable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001531 RID: 5425 RVA: 0x00072F58 File Offset: 0x00071158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72245, XrefRangeEnd = 72247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRtMidCapHoverable(bool hoverable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hoverable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmo.NativeMethodInfoPtr_SetRtMidCapHoverable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001532 RID: 5426 RVA: 0x00072F98 File Offset: 0x00071198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72247, XrefRangeEnd = 72248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetScaleGuideTargetObjects(IEnumerable<GameObject> targetObjects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetObjects);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmo.NativeMethodInfoPtr_SetScaleGuideTargetObjects_Public_Void_IEnumerable_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001533 RID: 5427 RVA: 0x00072FDC File Offset: 0x000711DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72248, XrefRangeEnd = 72459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnAttached()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UniversalGizmo.NativeMethodInfoPtr_OnAttached_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001534 RID: 5428 RVA: 0x00073018 File Offset: 0x00071218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72459, XrefRangeEnd = 72467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDetached()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UniversalGizmo.NativeMethodInfoPtr_OnDetached_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001535 RID: 5429 RVA: 0x00073054 File Offset: 0x00071254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72467, XrefRangeEnd = 72475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UniversalGizmo.NativeMethodInfoPtr_OnEnabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001536 RID: 5430 RVA: 0x00073090 File Offset: 0x00071290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72475, XrefRangeEnd = 72483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UniversalGizmo.NativeMethodInfoPtr_OnDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001537 RID: 5431 RVA: 0x000730CC File Offset: 0x000712CC
		[CallerCount(0)]
		public unsafe override void OnGizmoEnabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UniversalGizmo.NativeMethodInfoPtr_OnGizmoEnabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001538 RID: 5432 RVA: 0x00073108 File Offset: 0x00071308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72483, XrefRangeEnd = 72565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnGizmoUpdateBegin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UniversalGizmo.NativeMethodInfoPtr_OnGizmoUpdateBegin_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001539 RID: 5433 RVA: 0x00073144 File Offset: 0x00071344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72565, XrefRangeEnd = 72605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnGizmoRender(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UniversalGizmo.NativeMethodInfoPtr_OnGizmoRender_Public_Virtual_Void_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600153A RID: 5434 RVA: 0x00073194 File Offset: 0x00071394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72605, XrefRangeEnd = 72606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnGizmoDragUpdate(int handleId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handleId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UniversalGizmo.NativeMethodInfoPtr_OnGizmoDragUpdate_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600153B RID: 5435 RVA: 0x000731E0 File Offset: 0x000713E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72606, XrefRangeEnd = 72611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnGizmoDragBegin(int handleId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handleId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UniversalGizmo.NativeMethodInfoPtr_OnGizmoDragBegin_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600153C RID: 5436 RVA: 0x0007322C File Offset: 0x0007142C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72611, XrefRangeEnd = 72613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnGizmoDragEnd(int handleId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handleId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UniversalGizmo.NativeMethodInfoPtr_OnGizmoDragEnd_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600153D RID: 5437 RVA: 0x00073278 File Offset: 0x00071478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72613, XrefRangeEnd = 72623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnGizmoAttemptHandleDragBegin(int handleId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handleId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UniversalGizmo.NativeMethodInfoPtr_OnGizmoAttemptHandleDragBegin_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600153E RID: 5438 RVA: 0x000732C4 File Offset: 0x000714C4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 69930, RefRangeEnd = 69934, XrefRangeStart = 69930, XrefRangeEnd = 69934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlaceMvDblSlidersInSliderPlanes(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmo.NativeMethodInfoPtr_PlaceMvDblSlidersInSliderPlanes_Private_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600153F RID: 5439 RVA: 0x00073308 File Offset: 0x00071508
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 72647, RefRangeEnd = 72650, XrefRangeStart = 72623, XrefRangeEnd = 72647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupSharedLookAndFeel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmo.NativeMethodInfoPtr_SetupSharedLookAndFeel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001540 RID: 5440 RVA: 0x0007333C File Offset: 0x0007153C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 72670, RefRangeEnd = 72673, XrefRangeStart = 72650, XrefRangeEnd = 72670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupSharedSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmo.NativeMethodInfoPtr_SetupSharedSettings_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001541 RID: 5441 RVA: 0x00073370 File Offset: 0x00071570
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 69979, RefRangeEnd = 69985, XrefRangeStart = 69979, XrefRangeEnd = 69985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update2DGizmoPosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmo.NativeMethodInfoPtr_Update2DGizmoPosition_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001542 RID: 5442 RVA: 0x000733A4 File Offset: 0x000715A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 72686, RefRangeEnd = 72688, XrefRangeStart = 72673, XrefRangeEnd = 72686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update2DModeHandlePositions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmo.NativeMethodInfoPtr_Update2DModeHandlePositions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001543 RID: 5443 RVA: 0x000733D8 File Offset: 0x000715D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72688, XrefRangeEnd = 72691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGizmoTransformChanged(GizmoTransform transform, GizmoTransform.ChangeData changeData)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmo.NativeMethodInfoPtr_OnGizmoTransformChanged_Private_Void_GizmoTransform_ChangeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001544 RID: 5444 RVA: 0x00073428 File Offset: 0x00071628
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 72696, RefRangeEnd = 72697, XrefRangeStart = 72691, XrefRangeEnd = 72696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hide2DModeHandles()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmo.NativeMethodInfoPtr_Hide2DModeHandles_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001545 RID: 5445 RVA: 0x0007345C File Offset: 0x0007165C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 72700, RefRangeEnd = 72703, XrefRangeStart = 72697, XrefRangeEnd = 72700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateRtCamLookSlider(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmo.NativeMethodInfoPtr_UpdateRtCamLookSlider_Private_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001546 RID: 5446 RVA: 0x000734A0 File Offset: 0x000716A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 72707, RefRangeEnd = 72708, XrefRangeStart = 72703, XrefRangeEnd = 72707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMoveHandlesVisible(bool visible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref visible;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmo.NativeMethodInfoPtr_SetMoveHandlesVisible_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001547 RID: 5447 RVA: 0x000734E0 File Offset: 0x000716E0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 72712, RefRangeEnd = 72715, XrefRangeStart = 72708, XrefRangeEnd = 72712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRotationHandlesVisible(bool visible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref visible;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmo.NativeMethodInfoPtr_SetRotationHandlesVisible_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001548 RID: 5448 RVA: 0x00073520 File Offset: 0x00071720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72715, XrefRangeEnd = 72717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetScaleHandlesVisible(bool visible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref visible;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UniversalGizmo.NativeMethodInfoPtr_SetScaleHandlesVisible_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001549 RID: 5449 RVA: 0x00009D67 File Offset: 0x00007F67
		public UniversalGizmo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x0600154A RID: 5450 RVA: 0x00073560 File Offset: 0x00071760
		// (set) Token: 0x0600154B RID: 5451 RVA: 0x00009D70 File Offset: 0x00007F70
		public unsafe GizmoLineSlider3D _mvPXSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__mvPXSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoLineSlider3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__mvPXSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x0600154C RID: 5452 RVA: 0x00073590 File Offset: 0x00071790
		// (set) Token: 0x0600154D RID: 5453 RVA: 0x00009D8F File Offset: 0x00007F8F
		public unsafe GizmoLineSlider3D _mvPYSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__mvPYSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoLineSlider3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__mvPYSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x0600154E RID: 5454 RVA: 0x000735C0 File Offset: 0x000717C0
		// (set) Token: 0x0600154F RID: 5455 RVA: 0x00009DAE File Offset: 0x00007FAE
		public unsafe GizmoLineSlider3D _mvPZSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__mvPZSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoLineSlider3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__mvPZSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x06001550 RID: 5456 RVA: 0x000735F0 File Offset: 0x000717F0
		// (set) Token: 0x06001551 RID: 5457 RVA: 0x00009DCD File Offset: 0x00007FCD
		public unsafe GizmoLineSlider3D _mvNXSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__mvNXSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoLineSlider3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__mvNXSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x06001552 RID: 5458 RVA: 0x00073620 File Offset: 0x00071820
		// (set) Token: 0x06001553 RID: 5459 RVA: 0x00009DEC File Offset: 0x00007FEC
		public unsafe GizmoLineSlider3D _mvNYSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__mvNYSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoLineSlider3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__mvNYSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x06001554 RID: 5460 RVA: 0x00073650 File Offset: 0x00071850
		// (set) Token: 0x06001555 RID: 5461 RVA: 0x00009E0B File Offset: 0x0000800B
		public unsafe GizmoLineSlider3D _mvNZSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__mvNZSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoLineSlider3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__mvNZSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x06001556 RID: 5462 RVA: 0x00073680 File Offset: 0x00071880
		// (set) Token: 0x06001557 RID: 5463 RVA: 0x00009E2A File Offset: 0x0000802A
		public unsafe GizmoLineSlider3DCollection _mvAxesSliders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__mvAxesSliders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoLineSlider3DCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__mvAxesSliders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x06001558 RID: 5464 RVA: 0x000736B0 File Offset: 0x000718B0
		// (set) Token: 0x06001559 RID: 5465 RVA: 0x00009E49 File Offset: 0x00008049
		public unsafe GizmoPlaneSlider3D _mvXYSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__mvXYSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPlaneSlider3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__mvXYSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x0600155A RID: 5466 RVA: 0x000736E0 File Offset: 0x000718E0
		// (set) Token: 0x0600155B RID: 5467 RVA: 0x00009E68 File Offset: 0x00008068
		public unsafe GizmoPlaneSlider3D _mvYZSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__mvYZSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPlaneSlider3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__mvYZSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x0600155C RID: 5468 RVA: 0x00073710 File Offset: 0x00071910
		// (set) Token: 0x0600155D RID: 5469 RVA: 0x00009E87 File Offset: 0x00008087
		public unsafe GizmoPlaneSlider3D _mvZXSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__mvZXSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPlaneSlider3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__mvZXSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x0600155E RID: 5470 RVA: 0x00073740 File Offset: 0x00071940
		// (set) Token: 0x0600155F RID: 5471 RVA: 0x00009EA6 File Offset: 0x000080A6
		public unsafe GizmoPlaneSlider3DCollection _mvDblSliders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__mvDblSliders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPlaneSlider3DCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__mvDblSliders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x06001560 RID: 5472 RVA: 0x00073770 File Offset: 0x00071970
		// (set) Token: 0x06001561 RID: 5473 RVA: 0x00009EC5 File Offset: 0x000080C5
		public unsafe bool _isMvVertexSnapEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__isMvVertexSnapEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__isMvVertexSnapEnabled)) = value;
			}
		}

		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x06001562 RID: 5474 RVA: 0x00073798 File Offset: 0x00071998
		// (set) Token: 0x06001563 RID: 5475 RVA: 0x00009EE0 File Offset: 0x000080E0
		public unsafe GizmoCap2D _mvVertSnapCap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__mvVertSnapCap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoCap2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__mvVertSnapCap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x06001564 RID: 5476 RVA: 0x000737C8 File Offset: 0x000719C8
		// (set) Token: 0x06001565 RID: 5477 RVA: 0x00009EFF File Offset: 0x000080FF
		public unsafe GizmoObjectVertexSnapDrag3D _mvVertexSnapDrag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__mvVertexSnapDrag);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoObjectVertexSnapDrag3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__mvVertexSnapDrag), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x06001566 RID: 5478 RVA: 0x000737F8 File Offset: 0x000719F8
		// (set) Token: 0x06001567 RID: 5479 RVA: 0x00009F1E File Offset: 0x0000811E
		public unsafe Vector3 _mvPostVSnapPosRestore
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__mvPostVSnapPosRestore);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__mvPostVSnapPosRestore), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x06001568 RID: 5480 RVA: 0x00073828 File Offset: 0x00071A28
		// (set) Token: 0x06001569 RID: 5481 RVA: 0x00009F3D File Offset: 0x0000813D
		public unsafe GizmoLineSlider2D _mvP2DModeXSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__mvP2DModeXSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoLineSlider2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__mvP2DModeXSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x0600156A RID: 5482 RVA: 0x00073858 File Offset: 0x00071A58
		// (set) Token: 0x0600156B RID: 5483 RVA: 0x00009F5C File Offset: 0x0000815C
		public unsafe GizmoLineSlider2D _mvP2DModeYSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__mvP2DModeYSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoLineSlider2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__mvP2DModeYSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x0600156C RID: 5484 RVA: 0x00073888 File Offset: 0x00071A88
		// (set) Token: 0x0600156D RID: 5485 RVA: 0x00009F7B File Offset: 0x0000817B
		public unsafe GizmoLineSlider2D _mvN2DModeXSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__mvN2DModeXSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoLineSlider2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__mvN2DModeXSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x0600156E RID: 5486 RVA: 0x000738B8 File Offset: 0x00071AB8
		// (set) Token: 0x0600156F RID: 5487 RVA: 0x00009F9A File Offset: 0x0000819A
		public unsafe GizmoLineSlider2D _mvN2DModeYSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__mvN2DModeYSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoLineSlider2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__mvN2DModeYSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x06001570 RID: 5488 RVA: 0x000738E8 File Offset: 0x00071AE8
		// (set) Token: 0x06001571 RID: 5489 RVA: 0x00009FB9 File Offset: 0x000081B9
		public unsafe GizmoLineSlider2DCollection _mv2DModeSliders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__mv2DModeSliders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoLineSlider2DCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__mv2DModeSliders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007BD RID: 1981
		// (get) Token: 0x06001572 RID: 5490 RVA: 0x00073918 File Offset: 0x00071B18
		// (set) Token: 0x06001573 RID: 5491 RVA: 0x00009FD8 File Offset: 0x000081D8
		public unsafe GizmoPlaneSlider2D _mv2DModeDblSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__mv2DModeDblSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPlaneSlider2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__mv2DModeDblSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007BE RID: 1982
		// (get) Token: 0x06001574 RID: 5492 RVA: 0x00073948 File Offset: 0x00071B48
		// (set) Token: 0x06001575 RID: 5493 RVA: 0x00009FF7 File Offset: 0x000081F7
		public unsafe GizmoPlaneSlider3D _rtXSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__rtXSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPlaneSlider3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__rtXSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x06001576 RID: 5494 RVA: 0x00073978 File Offset: 0x00071B78
		// (set) Token: 0x06001577 RID: 5495 RVA: 0x0000A016 File Offset: 0x00008216
		public unsafe GizmoPlaneSlider3D _rtYSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__rtYSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPlaneSlider3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__rtYSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x06001578 RID: 5496 RVA: 0x000739A8 File Offset: 0x00071BA8
		// (set) Token: 0x06001579 RID: 5497 RVA: 0x0000A035 File Offset: 0x00008235
		public unsafe GizmoPlaneSlider3D _rtZSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__rtZSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPlaneSlider3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__rtZSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x0600157A RID: 5498 RVA: 0x000739D8 File Offset: 0x00071BD8
		// (set) Token: 0x0600157B RID: 5499 RVA: 0x0000A054 File Offset: 0x00008254
		public unsafe GizmoPlaneSlider3DCollection _rtAxesSliders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__rtAxesSliders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPlaneSlider3DCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__rtAxesSliders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x0600157C RID: 5500 RVA: 0x00073A08 File Offset: 0x00071C08
		// (set) Token: 0x0600157D RID: 5501 RVA: 0x0000A073 File Offset: 0x00008273
		public unsafe GizmoCap3D _rtMidCap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__rtMidCap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoCap3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__rtMidCap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x0600157E RID: 5502 RVA: 0x00073A38 File Offset: 0x00071C38
		// (set) Token: 0x0600157F RID: 5503 RVA: 0x0000A092 File Offset: 0x00008292
		public unsafe GizmoDblAxisRotationDrag3D _rtCamXYRotationDrag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__rtCamXYRotationDrag);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoDblAxisRotationDrag3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__rtCamXYRotationDrag), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C4 RID: 1988
		// (get) Token: 0x06001580 RID: 5504 RVA: 0x00073A68 File Offset: 0x00071C68
		// (set) Token: 0x06001581 RID: 5505 RVA: 0x0000A0B1 File Offset: 0x000082B1
		public unsafe GizmoPlaneSlider2D _rtCamLookSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__rtCamLookSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPlaneSlider2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__rtCamLookSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C5 RID: 1989
		// (get) Token: 0x06001582 RID: 5506 RVA: 0x00073A98 File Offset: 0x00071C98
		// (set) Token: 0x06001583 RID: 5507 RVA: 0x0000A0D0 File Offset: 0x000082D0
		public unsafe GizmoCap3D _scMidCap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__scMidCap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoCap3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__scMidCap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C6 RID: 1990
		// (get) Token: 0x06001584 RID: 5508 RVA: 0x00073AC8 File Offset: 0x00071CC8
		// (set) Token: 0x06001585 RID: 5509 RVA: 0x0000A0EF File Offset: 0x000082EF
		public unsafe GizmoUniformScaleDrag3D _scUnformScaleDrag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__scUnformScaleDrag);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoUniformScaleDrag3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__scUnformScaleDrag), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C7 RID: 1991
		// (get) Token: 0x06001586 RID: 5510 RVA: 0x00073AF8 File Offset: 0x00071CF8
		// (set) Token: 0x06001587 RID: 5511 RVA: 0x0000A10E File Offset: 0x0000830E
		public unsafe GizmoScaleGuide _scScaleGuide
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__scScaleGuide);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoScaleGuide>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__scScaleGuide), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C8 RID: 1992
		// (get) Token: 0x06001588 RID: 5512 RVA: 0x00073B28 File Offset: 0x00071D28
		// (set) Token: 0x06001589 RID: 5513 RVA: 0x0000A12D File Offset: 0x0000832D
		public unsafe IEnumerable<GameObject> _scScaleGuideTargetObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__scScaleGuideTargetObjects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__scScaleGuideTargetObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C9 RID: 1993
		// (get) Token: 0x0600158A RID: 5514 RVA: 0x00073B58 File Offset: 0x00071D58
		// (set) Token: 0x0600158B RID: 5515 RVA: 0x0000A14C File Offset: 0x0000834C
		public unsafe bool _is2DModeEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__is2DModeEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__is2DModeEnabled)) = value;
			}
		}

		// Token: 0x170007CA RID: 1994
		// (get) Token: 0x0600158C RID: 5516 RVA: 0x00073B80 File Offset: 0x00071D80
		// (set) Token: 0x0600158D RID: 5517 RVA: 0x0000A167 File Offset: 0x00008367
		public unsafe UniversalGizmoSettings2D _settings2D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__settings2D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UniversalGizmoSettings2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__settings2D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007CB RID: 1995
		// (get) Token: 0x0600158E RID: 5518 RVA: 0x00073BB0 File Offset: 0x00071DB0
		// (set) Token: 0x0600158F RID: 5519 RVA: 0x0000A186 File Offset: 0x00008386
		public unsafe UniversalGizmoSettings2D _sharedSettings2D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__sharedSettings2D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UniversalGizmoSettings2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__sharedSettings2D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007CC RID: 1996
		// (get) Token: 0x06001590 RID: 5520 RVA: 0x00073BE0 File Offset: 0x00071DE0
		// (set) Token: 0x06001591 RID: 5521 RVA: 0x0000A1A5 File Offset: 0x000083A5
		public unsafe UniversalGizmoSettings3D _settings3D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__settings3D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UniversalGizmoSettings3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__settings3D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007CD RID: 1997
		// (get) Token: 0x06001592 RID: 5522 RVA: 0x00073C10 File Offset: 0x00071E10
		// (set) Token: 0x06001593 RID: 5523 RVA: 0x0000A1C4 File Offset: 0x000083C4
		public unsafe UniversalGizmoSettings3D _sharedSettings3D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__sharedSettings3D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UniversalGizmoSettings3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__sharedSettings3D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007CE RID: 1998
		// (get) Token: 0x06001594 RID: 5524 RVA: 0x00073C40 File Offset: 0x00071E40
		// (set) Token: 0x06001595 RID: 5525 RVA: 0x0000A1E3 File Offset: 0x000083E3
		public unsafe UniversalGizmoLookAndFeel2D _lookAndFeel2D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__lookAndFeel2D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UniversalGizmoLookAndFeel2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__lookAndFeel2D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007CF RID: 1999
		// (get) Token: 0x06001596 RID: 5526 RVA: 0x00073C70 File Offset: 0x00071E70
		// (set) Token: 0x06001597 RID: 5527 RVA: 0x0000A202 File Offset: 0x00008402
		public unsafe UniversalGizmoLookAndFeel2D _sharedLookAndFeel2D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__sharedLookAndFeel2D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UniversalGizmoLookAndFeel2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__sharedLookAndFeel2D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x06001598 RID: 5528 RVA: 0x00073CA0 File Offset: 0x00071EA0
		// (set) Token: 0x06001599 RID: 5529 RVA: 0x0000A221 File Offset: 0x00008421
		public unsafe UniversalGizmoLookAndFeel3D _lookAndFeel3D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__lookAndFeel3D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UniversalGizmoLookAndFeel3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__lookAndFeel3D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007D1 RID: 2001
		// (get) Token: 0x0600159A RID: 5530 RVA: 0x00073CD0 File Offset: 0x00071ED0
		// (set) Token: 0x0600159B RID: 5531 RVA: 0x0000A240 File Offset: 0x00008440
		public unsafe UniversalGizmoLookAndFeel3D _sharedLookAndFeel3D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__sharedLookAndFeel3D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UniversalGizmoLookAndFeel3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__sharedLookAndFeel3D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007D2 RID: 2002
		// (get) Token: 0x0600159C RID: 5532 RVA: 0x00073D00 File Offset: 0x00071F00
		// (set) Token: 0x0600159D RID: 5533 RVA: 0x0000A25F File Offset: 0x0000845F
		public unsafe UniversalGizmoHotkeys _hotkeys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__hotkeys);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UniversalGizmoHotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__hotkeys), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007D3 RID: 2003
		// (get) Token: 0x0600159E RID: 5534 RVA: 0x00073D30 File Offset: 0x00071F30
		// (set) Token: 0x0600159F RID: 5535 RVA: 0x0000A27E File Offset: 0x0000847E
		public unsafe UniversalGizmoHotkeys _sharedHotkeys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__sharedHotkeys);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UniversalGizmoHotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__sharedHotkeys), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007D4 RID: 2004
		// (get) Token: 0x060015A0 RID: 5536 RVA: 0x00073D60 File Offset: 0x00071F60
		// (set) Token: 0x060015A1 RID: 5537 RVA: 0x0000A29D File Offset: 0x0000849D
		public unsafe bool _useSnapEnableHotkey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__useSnapEnableHotkey);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__useSnapEnableHotkey)) = value;
			}
		}

		// Token: 0x170007D5 RID: 2005
		// (get) Token: 0x060015A2 RID: 5538 RVA: 0x00073D88 File Offset: 0x00071F88
		// (set) Token: 0x060015A3 RID: 5539 RVA: 0x0000A2B8 File Offset: 0x000084B8
		public unsafe bool _useVertSnapEnableHotkey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__useVertSnapEnableHotkey);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__useVertSnapEnableHotkey)) = value;
			}
		}

		// Token: 0x170007D6 RID: 2006
		// (get) Token: 0x060015A4 RID: 5540 RVA: 0x00073DB0 File Offset: 0x00071FB0
		// (set) Token: 0x060015A5 RID: 5541 RVA: 0x0000A2D3 File Offset: 0x000084D3
		public unsafe bool _use2DModeEnableHotkey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__use2DModeEnableHotkey);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UniversalGizmo.NativeFieldInfoPtr__use2DModeEnableHotkey)) = value;
			}
		}

		// Token: 0x04000FC8 RID: 4040
		private static readonly IntPtr NativeFieldInfoPtr__mvPXSlider;

		// Token: 0x04000FC9 RID: 4041
		private static readonly IntPtr NativeFieldInfoPtr__mvPYSlider;

		// Token: 0x04000FCA RID: 4042
		private static readonly IntPtr NativeFieldInfoPtr__mvPZSlider;

		// Token: 0x04000FCB RID: 4043
		private static readonly IntPtr NativeFieldInfoPtr__mvNXSlider;

		// Token: 0x04000FCC RID: 4044
		private static readonly IntPtr NativeFieldInfoPtr__mvNYSlider;

		// Token: 0x04000FCD RID: 4045
		private static readonly IntPtr NativeFieldInfoPtr__mvNZSlider;

		// Token: 0x04000FCE RID: 4046
		private static readonly IntPtr NativeFieldInfoPtr__mvAxesSliders;

		// Token: 0x04000FCF RID: 4047
		private static readonly IntPtr NativeFieldInfoPtr__mvXYSlider;

		// Token: 0x04000FD0 RID: 4048
		private static readonly IntPtr NativeFieldInfoPtr__mvYZSlider;

		// Token: 0x04000FD1 RID: 4049
		private static readonly IntPtr NativeFieldInfoPtr__mvZXSlider;

		// Token: 0x04000FD2 RID: 4050
		private static readonly IntPtr NativeFieldInfoPtr__mvDblSliders;

		// Token: 0x04000FD3 RID: 4051
		private static readonly IntPtr NativeFieldInfoPtr__isMvVertexSnapEnabled;

		// Token: 0x04000FD4 RID: 4052
		private static readonly IntPtr NativeFieldInfoPtr__mvVertSnapCap;

		// Token: 0x04000FD5 RID: 4053
		private static readonly IntPtr NativeFieldInfoPtr__mvVertexSnapDrag;

		// Token: 0x04000FD6 RID: 4054
		private static readonly IntPtr NativeFieldInfoPtr__mvPostVSnapPosRestore;

		// Token: 0x04000FD7 RID: 4055
		private static readonly IntPtr NativeFieldInfoPtr__mvP2DModeXSlider;

		// Token: 0x04000FD8 RID: 4056
		private static readonly IntPtr NativeFieldInfoPtr__mvP2DModeYSlider;

		// Token: 0x04000FD9 RID: 4057
		private static readonly IntPtr NativeFieldInfoPtr__mvN2DModeXSlider;

		// Token: 0x04000FDA RID: 4058
		private static readonly IntPtr NativeFieldInfoPtr__mvN2DModeYSlider;

		// Token: 0x04000FDB RID: 4059
		private static readonly IntPtr NativeFieldInfoPtr__mv2DModeSliders;

		// Token: 0x04000FDC RID: 4060
		private static readonly IntPtr NativeFieldInfoPtr__mv2DModeDblSlider;

		// Token: 0x04000FDD RID: 4061
		private static readonly IntPtr NativeFieldInfoPtr__rtXSlider;

		// Token: 0x04000FDE RID: 4062
		private static readonly IntPtr NativeFieldInfoPtr__rtYSlider;

		// Token: 0x04000FDF RID: 4063
		private static readonly IntPtr NativeFieldInfoPtr__rtZSlider;

		// Token: 0x04000FE0 RID: 4064
		private static readonly IntPtr NativeFieldInfoPtr__rtAxesSliders;

		// Token: 0x04000FE1 RID: 4065
		private static readonly IntPtr NativeFieldInfoPtr__rtMidCap;

		// Token: 0x04000FE2 RID: 4066
		private static readonly IntPtr NativeFieldInfoPtr__rtCamXYRotationDrag;

		// Token: 0x04000FE3 RID: 4067
		private static readonly IntPtr NativeFieldInfoPtr__rtCamLookSlider;

		// Token: 0x04000FE4 RID: 4068
		private static readonly IntPtr NativeFieldInfoPtr__scMidCap;

		// Token: 0x04000FE5 RID: 4069
		private static readonly IntPtr NativeFieldInfoPtr__scUnformScaleDrag;

		// Token: 0x04000FE6 RID: 4070
		private static readonly IntPtr NativeFieldInfoPtr__scScaleGuide;

		// Token: 0x04000FE7 RID: 4071
		private static readonly IntPtr NativeFieldInfoPtr__scScaleGuideTargetObjects;

		// Token: 0x04000FE8 RID: 4072
		private static readonly IntPtr NativeFieldInfoPtr__is2DModeEnabled;

		// Token: 0x04000FE9 RID: 4073
		private static readonly IntPtr NativeFieldInfoPtr__settings2D;

		// Token: 0x04000FEA RID: 4074
		private static readonly IntPtr NativeFieldInfoPtr__sharedSettings2D;

		// Token: 0x04000FEB RID: 4075
		private static readonly IntPtr NativeFieldInfoPtr__settings3D;

		// Token: 0x04000FEC RID: 4076
		private static readonly IntPtr NativeFieldInfoPtr__sharedSettings3D;

		// Token: 0x04000FED RID: 4077
		private static readonly IntPtr NativeFieldInfoPtr__lookAndFeel2D;

		// Token: 0x04000FEE RID: 4078
		private static readonly IntPtr NativeFieldInfoPtr__sharedLookAndFeel2D;

		// Token: 0x04000FEF RID: 4079
		private static readonly IntPtr NativeFieldInfoPtr__lookAndFeel3D;

		// Token: 0x04000FF0 RID: 4080
		private static readonly IntPtr NativeFieldInfoPtr__sharedLookAndFeel3D;

		// Token: 0x04000FF1 RID: 4081
		private static readonly IntPtr NativeFieldInfoPtr__hotkeys;

		// Token: 0x04000FF2 RID: 4082
		private static readonly IntPtr NativeFieldInfoPtr__sharedHotkeys;

		// Token: 0x04000FF3 RID: 4083
		private static readonly IntPtr NativeFieldInfoPtr__useSnapEnableHotkey;

		// Token: 0x04000FF4 RID: 4084
		private static readonly IntPtr NativeFieldInfoPtr__useVertSnapEnableHotkey;

		// Token: 0x04000FF5 RID: 4085
		private static readonly IntPtr NativeFieldInfoPtr__use2DModeEnableHotkey;

		// Token: 0x04000FF6 RID: 4086
		private static readonly IntPtr NativeMethodInfoPtr_get_Settings2D_Public_get_UniversalGizmoSettings2D_0;

		// Token: 0x04000FF7 RID: 4087
		private static readonly IntPtr NativeMethodInfoPtr_get_SharedSettings2D_Public_get_UniversalGizmoSettings2D_0;

		// Token: 0x04000FF8 RID: 4088
		private static readonly IntPtr NativeMethodInfoPtr_set_SharedSettings2D_Public_set_Void_UniversalGizmoSettings2D_0;

		// Token: 0x04000FF9 RID: 4089
		private static readonly IntPtr NativeMethodInfoPtr_get_Settings3D_Public_get_UniversalGizmoSettings3D_0;

		// Token: 0x04000FFA RID: 4090
		private static readonly IntPtr NativeMethodInfoPtr_get_SharedSettings3D_Public_get_UniversalGizmoSettings3D_0;

		// Token: 0x04000FFB RID: 4091
		private static readonly IntPtr NativeMethodInfoPtr_set_SharedSettings3D_Public_set_Void_UniversalGizmoSettings3D_0;

		// Token: 0x04000FFC RID: 4092
		private static readonly IntPtr NativeMethodInfoPtr_get_LookAndFeel2D_Public_get_UniversalGizmoLookAndFeel2D_0;

		// Token: 0x04000FFD RID: 4093
		private static readonly IntPtr NativeMethodInfoPtr_get_SharedLookAndFeel2D_Public_get_UniversalGizmoLookAndFeel2D_0;

		// Token: 0x04000FFE RID: 4094
		private static readonly IntPtr NativeMethodInfoPtr_set_SharedLookAndFeel2D_Public_set_Void_UniversalGizmoLookAndFeel2D_0;

		// Token: 0x04000FFF RID: 4095
		private static readonly IntPtr NativeMethodInfoPtr_get_LookAndFeel3D_Public_get_UniversalGizmoLookAndFeel3D_0;

		// Token: 0x04001000 RID: 4096
		private static readonly IntPtr NativeMethodInfoPtr_get_SharedLookAndFeel3D_Public_get_UniversalGizmoLookAndFeel3D_0;

		// Token: 0x04001001 RID: 4097
		private static readonly IntPtr NativeMethodInfoPtr_set_SharedLookAndFeel3D_Public_set_Void_UniversalGizmoLookAndFeel3D_0;

		// Token: 0x04001002 RID: 4098
		private static readonly IntPtr NativeMethodInfoPtr_get_Hotkeys_Public_get_UniversalGizmoHotkeys_0;

		// Token: 0x04001003 RID: 4099
		private static readonly IntPtr NativeMethodInfoPtr_get_SharedHotkeys_Public_get_UniversalGizmoHotkeys_0;

		// Token: 0x04001004 RID: 4100
		private static readonly IntPtr NativeMethodInfoPtr_set_SharedHotkeys_Public_set_Void_UniversalGizmoHotkeys_0;

		// Token: 0x04001005 RID: 4101
		private static readonly IntPtr NativeMethodInfoPtr_get_UseSnapEnableHotkey_Public_get_Boolean_0;

		// Token: 0x04001006 RID: 4102
		private static readonly IntPtr NativeMethodInfoPtr_set_UseSnapEnableHotkey_Public_set_Void_Boolean_0;

		// Token: 0x04001007 RID: 4103
		private static readonly IntPtr NativeMethodInfoPtr_get_UseVertSnapEnableHotkey_Public_get_Boolean_0;

		// Token: 0x04001008 RID: 4104
		private static readonly IntPtr NativeMethodInfoPtr_set_UseVertSnapEnableHotkey_Public_set_Void_Boolean_0;

		// Token: 0x04001009 RID: 4105
		private static readonly IntPtr NativeMethodInfoPtr_get_Use2DModeEnableHotkey_Public_get_Boolean_0;

		// Token: 0x0400100A RID: 4106
		private static readonly IntPtr NativeMethodInfoPtr_set_Use2DModeEnableHotkey_Public_set_Void_Boolean_0;

		// Token: 0x0400100B RID: 4107
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400100C RID: 4108
		private static readonly IntPtr NativeMethodInfoPtr_GetMvVertexSnapState_Public_MvVertexSnapState_0;

		// Token: 0x0400100D RID: 4109
		private static readonly IntPtr NativeMethodInfoPtr_GetMvZoomFactor_Public_Single_Vector3_0;

		// Token: 0x0400100E RID: 4110
		private static readonly IntPtr NativeMethodInfoPtr_GetMvZoomFactor_Public_Single_Vector3_Camera_0;

		// Token: 0x0400100F RID: 4111
		private static readonly IntPtr NativeMethodInfoPtr_GetRtZoomFactor_Public_Single_Vector3_0;

		// Token: 0x04001010 RID: 4112
		private static readonly IntPtr NativeMethodInfoPtr_GetRtZoomFactor_Public_Single_Vector3_Camera_0;

		// Token: 0x04001011 RID: 4113
		private static readonly IntPtr NativeMethodInfoPtr_GetScZoomFactor_Public_Single_Vector3_0;

		// Token: 0x04001012 RID: 4114
		private static readonly IntPtr NativeMethodInfoPtr_GetScZoomFactor_Public_Single_Vector3_Camera_0;

		// Token: 0x04001013 RID: 4115
		private static readonly IntPtr NativeMethodInfoPtr_IsDraggingMoveHandle_Public_Boolean_0;

		// Token: 0x04001014 RID: 4116
		private static readonly IntPtr NativeMethodInfoPtr_IsDraggingRotationHandle_Public_Boolean_0;

		// Token: 0x04001015 RID: 4117
		private static readonly IntPtr NativeMethodInfoPtr_IsDraggingScaleHandle_Public_Boolean_0;

		// Token: 0x04001016 RID: 4118
		private static readonly IntPtr NativeMethodInfoPtr_IsMoveHandle_Public_Boolean_Int32_0;

		// Token: 0x04001017 RID: 4119
		private static readonly IntPtr NativeMethodInfoPtr_IsRotationHandle_Public_Boolean_Int32_0;

		// Token: 0x04001018 RID: 4120
		private static readonly IntPtr NativeMethodInfoPtr_IsScaleHandle_Public_Boolean_Int32_0;

		// Token: 0x04001019 RID: 4121
		private static readonly IntPtr NativeMethodInfoPtr_OwnsHandle_Public_Boolean_Int32_0;

		// Token: 0x0400101A RID: 4122
		private static readonly IntPtr NativeMethodInfoPtr_SetSnapEnabled_Public_Void_Boolean_0;

		// Token: 0x0400101B RID: 4123
		private static readonly IntPtr NativeMethodInfoPtr_SetMvVertexSnapEnabled_Public_Void_Boolean_0;

		// Token: 0x0400101C RID: 4124
		private static readonly IntPtr NativeMethodInfoPtr_Set2DModeEnabled_Public_Void_Boolean_0;

		// Token: 0x0400101D RID: 4125
		private static readonly IntPtr NativeMethodInfoPtr_SetMvVertexSnapTargetObjects_Public_Void_IEnumerable_1_GameObject_0;

		// Token: 0x0400101E RID: 4126
		private static readonly IntPtr NativeMethodInfoPtr_SetMvAxesLinesHoverable_Public_Void_Boolean_0;

		// Token: 0x0400101F RID: 4127
		private static readonly IntPtr NativeMethodInfoPtr_SetRtMidCapHoverable_Public_Void_Boolean_0;

		// Token: 0x04001020 RID: 4128
		private static readonly IntPtr NativeMethodInfoPtr_SetScaleGuideTargetObjects_Public_Void_IEnumerable_1_GameObject_0;

		// Token: 0x04001021 RID: 4129
		private static readonly IntPtr NativeMethodInfoPtr_OnAttached_Public_Virtual_Void_0;

		// Token: 0x04001022 RID: 4130
		private static readonly IntPtr NativeMethodInfoPtr_OnDetached_Public_Virtual_Void_0;

		// Token: 0x04001023 RID: 4131
		private static readonly IntPtr NativeMethodInfoPtr_OnEnabled_Public_Virtual_Void_0;

		// Token: 0x04001024 RID: 4132
		private static readonly IntPtr NativeMethodInfoPtr_OnDisabled_Public_Virtual_Void_0;

		// Token: 0x04001025 RID: 4133
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoEnabled_Public_Virtual_Void_0;

		// Token: 0x04001026 RID: 4134
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoUpdateBegin_Public_Virtual_Void_0;

		// Token: 0x04001027 RID: 4135
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoRender_Public_Virtual_Void_Camera_0;

		// Token: 0x04001028 RID: 4136
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoDragUpdate_Public_Virtual_Void_Int32_0;

		// Token: 0x04001029 RID: 4137
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoDragBegin_Public_Virtual_Void_Int32_0;

		// Token: 0x0400102A RID: 4138
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoDragEnd_Public_Virtual_Void_Int32_0;

		// Token: 0x0400102B RID: 4139
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoAttemptHandleDragBegin_Public_Virtual_Void_Int32_0;

		// Token: 0x0400102C RID: 4140
		private static readonly IntPtr NativeMethodInfoPtr_PlaceMvDblSlidersInSliderPlanes_Private_Void_Camera_0;

		// Token: 0x0400102D RID: 4141
		private static readonly IntPtr NativeMethodInfoPtr_SetupSharedLookAndFeel_Private_Void_0;

		// Token: 0x0400102E RID: 4142
		private static readonly IntPtr NativeMethodInfoPtr_SetupSharedSettings_Private_Void_0;

		// Token: 0x0400102F RID: 4143
		private static readonly IntPtr NativeMethodInfoPtr_Update2DGizmoPosition_Private_Void_0;

		// Token: 0x04001030 RID: 4144
		private static readonly IntPtr NativeMethodInfoPtr_Update2DModeHandlePositions_Private_Void_0;

		// Token: 0x04001031 RID: 4145
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoTransformChanged_Private_Void_GizmoTransform_ChangeData_0;

		// Token: 0x04001032 RID: 4146
		private static readonly IntPtr NativeMethodInfoPtr_Hide2DModeHandles_Private_Void_0;

		// Token: 0x04001033 RID: 4147
		private static readonly IntPtr NativeMethodInfoPtr_UpdateRtCamLookSlider_Private_Void_Camera_0;

		// Token: 0x04001034 RID: 4148
		private static readonly IntPtr NativeMethodInfoPtr_SetMoveHandlesVisible_Private_Void_Boolean_0;

		// Token: 0x04001035 RID: 4149
		private static readonly IntPtr NativeMethodInfoPtr_SetRotationHandlesVisible_Private_Void_Boolean_0;

		// Token: 0x04001036 RID: 4150
		private static readonly IntPtr NativeMethodInfoPtr_SetScaleHandlesVisible_Private_Void_Boolean_0;

		// Token: 0x02000378 RID: 888
		public enum MvVertexSnapState
		{
			// Token: 0x0400399C RID: 14748
			SelectingPivot,
			// Token: 0x0400399D RID: 14749
			Snapping,
			// Token: 0x0400399E RID: 14750
			Inactive
		}
	}
}
