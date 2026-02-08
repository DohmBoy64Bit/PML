using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000114 RID: 276
	public class RTFocusCamera : MonoSingleton<RTFocusCamera>
	{
		// Token: 0x060019F0 RID: 6640 RVA: 0x00085EE4 File Offset: 0x000840E4
		// Note: this type is marked as 'beforefieldinit'.
		static RTFocusCamera()
		{
			Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "RTFocusCamera");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr);
			RTFocusCamera.NativeFieldInfoPtr_PrjSwitchTransitionBegin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, "PrjSwitchTransitionBegin");
			RTFocusCamera.NativeFieldInfoPtr_PrjSwitchTransitionUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, "PrjSwitchTransitionUpdate");
			RTFocusCamera.NativeFieldInfoPtr_PrjSwitchTransitionEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, "PrjSwitchTransitionEnd");
			RTFocusCamera.NativeFieldInfoPtr_CanProcessInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, "CanProcessInput");
			RTFocusCamera.NativeFieldInfoPtr_CanUseScrollWheel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, "CanUseScrollWheel");
			RTFocusCamera.NativeFieldInfoPtr__targetCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, "_targetCamera");
			RTFocusCamera.NativeFieldInfoPtr__targetTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, "_targetTransform");
			RTFocusCamera.NativeFieldInfoPtr__fieldOfView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, "_fieldOfView");
			RTFocusCamera.NativeFieldInfoPtr__worldTransformSnapshot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, "_worldTransformSnapshot");
			RTFocusCamera.NativeFieldInfoPtr__prjSwitchTranstion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, "_prjSwitchTranstion");
			RTFocusCamera.NativeFieldInfoPtr__isDoingFocus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, "_isDoingFocus");
			RTFocusCamera.NativeFieldInfoPtr__focusCrtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, "_focusCrtn");
			RTFocusCamera.NativeFieldInfoPtr__isDoingRotationSwitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, "_isDoingRotationSwitch");
			RTFocusCamera.NativeFieldInfoPtr__genricCamTransformCrtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, "_genricCamTransformCrtn");
			RTFocusCamera.NativeFieldInfoPtr__isObjectVisibilityDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, "_isObjectVisibilityDirty");
			RTFocusCamera.NativeFieldInfoPtr__visibleObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, "_visibleObjects");
			RTFocusCamera.NativeFieldInfoPtr__focusPointOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, "_focusPointOffset");
			RTFocusCamera.NativeFieldInfoPtr__lastFocusPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, "_lastFocusPoint");
			RTFocusCamera.NativeFieldInfoPtr__moveDirFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, "_moveDirFlags");
			RTFocusCamera.NativeFieldInfoPtr__currentAcceleration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, "_currentAcceleration");
			RTFocusCamera.NativeFieldInfoPtr__settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, "_settings");
			RTFocusCamera.NativeFieldInfoPtr__moveSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, "_moveSettings");
			RTFocusCamera.NativeFieldInfoPtr__panSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, "_panSettings");
			RTFocusCamera.NativeFieldInfoPtr__lookAroundSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, "_lookAroundSettings");
			RTFocusCamera.NativeFieldInfoPtr__orbitSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, "_orbitSettings");
			RTFocusCamera.NativeFieldInfoPtr__zoomSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, "_zoomSettings");
			RTFocusCamera.NativeFieldInfoPtr__focusSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, "_focusSettings");
			RTFocusCamera.NativeFieldInfoPtr__rotationSwitchSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, "_rotationSwitchSettings");
			RTFocusCamera.NativeFieldInfoPtr__projectionSwitchSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, "_projectionSwitchSettings");
			RTFocusCamera.NativeFieldInfoPtr__hotkeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, "_hotkeys");
			RTFocusCamera.NativeMethodInfoPtr_get_TargetCamera_Public_get_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667123);
			RTFocusCamera.NativeMethodInfoPtr_get_IsDoingProjectionSwitch_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667124);
			RTFocusCamera.NativeMethodInfoPtr_get_PrjSwitchTransitionType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667125);
			RTFocusCamera.NativeMethodInfoPtr_get_IsDoingRotationSwitch_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667126);
			RTFocusCamera.NativeMethodInfoPtr_get_PrjSwitchProgress_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667127);
			RTFocusCamera.NativeMethodInfoPtr_get_PrjSwitchDurationInSeconds_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667128);
			RTFocusCamera.NativeMethodInfoPtr_get_IsDoingFocus_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667129);
			RTFocusCamera.NativeMethodInfoPtr_get_WorldPosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667130);
			RTFocusCamera.NativeMethodInfoPtr_set_WorldPosition_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667131);
			RTFocusCamera.NativeMethodInfoPtr_get_WorldRotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667132);
			RTFocusCamera.NativeMethodInfoPtr_set_WorldRotation_Public_set_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667133);
			RTFocusCamera.NativeMethodInfoPtr_get_Right_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667134);
			RTFocusCamera.NativeMethodInfoPtr_get_Up_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667135);
			RTFocusCamera.NativeMethodInfoPtr_get_Look_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667136);
			RTFocusCamera.NativeMethodInfoPtr_get_IsMovingForward_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667137);
			RTFocusCamera.NativeMethodInfoPtr_get_IsMovingBackwards_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667138);
			RTFocusCamera.NativeMethodInfoPtr_get_IsMovingLeft_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667139);
			RTFocusCamera.NativeMethodInfoPtr_get_IsMovingRight_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667140);
			RTFocusCamera.NativeMethodInfoPtr_get_IsMovingUp_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667141);
			RTFocusCamera.NativeMethodInfoPtr_get_IsMovingDown_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667142);
			RTFocusCamera.NativeMethodInfoPtr_get_Settings_Public_get_CameraSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667143);
			RTFocusCamera.NativeMethodInfoPtr_get_MoveSettings_Public_get_CameraMoveSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667144);
			RTFocusCamera.NativeMethodInfoPtr_get_PanSettings_Public_get_CameraPanSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667145);
			RTFocusCamera.NativeMethodInfoPtr_get_LookAroundSettings_Public_get_CameraLookAroundSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667146);
			RTFocusCamera.NativeMethodInfoPtr_get_OrbitSettings_Public_get_CameraOrbitSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667147);
			RTFocusCamera.NativeMethodInfoPtr_get_ZoomSettings_Public_get_CameraZoomSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667148);
			RTFocusCamera.NativeMethodInfoPtr_get_FocusSettings_Public_get_CameraFocusSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667149);
			RTFocusCamera.NativeMethodInfoPtr_get_RotationSwitchSettings_Public_get_CameraRotationSwitchSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667150);
			RTFocusCamera.NativeMethodInfoPtr_get_ProjectionSwitchSettings_Public_get_CameraProjectionSwitchSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667151);
			RTFocusCamera.NativeMethodInfoPtr_get_Hotkeys_Public_get_CameraHotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667152);
			RTFocusCamera.NativeMethodInfoPtr_add_PrjSwitchTransitionBegin_Public_add_Void_CameraProjectionSwitchBeginHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667113);
			RTFocusCamera.NativeMethodInfoPtr_remove_PrjSwitchTransitionBegin_Public_rem_Void_CameraProjectionSwitchBeginHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667114);
			RTFocusCamera.NativeMethodInfoPtr_add_PrjSwitchTransitionUpdate_Public_add_Void_CameraProjectionSwitchUpdateHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667115);
			RTFocusCamera.NativeMethodInfoPtr_remove_PrjSwitchTransitionUpdate_Public_rem_Void_CameraProjectionSwitchUpdateHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667116);
			RTFocusCamera.NativeMethodInfoPtr_add_PrjSwitchTransitionEnd_Public_add_Void_CameraProjectionSwitchBeginHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667117);
			RTFocusCamera.NativeMethodInfoPtr_remove_PrjSwitchTransitionEnd_Public_rem_Void_CameraProjectionSwitchBeginHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667118);
			RTFocusCamera.NativeMethodInfoPtr_add_CanProcessInput_Public_add_Void_CameraCanProcessInputHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667119);
			RTFocusCamera.NativeMethodInfoPtr_remove_CanProcessInput_Public_rem_Void_CameraCanProcessInputHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667120);
			RTFocusCamera.NativeMethodInfoPtr_add_CanUseScrollWheel_Public_add_Void_CameraCanUseScrollWheelHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667121);
			RTFocusCamera.NativeMethodInfoPtr_remove_CanUseScrollWheel_Public_rem_Void_CameraCanUseScrollWheelHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667122);
			RTFocusCamera.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667193);
			RTFocusCamera.NativeMethodInfoPtr_IsViewportHoveredByDevice_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667153);
			RTFocusCamera.NativeMethodInfoPtr_SetTargetCamera_Public_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667154);
			RTFocusCamera.NativeMethodInfoPtr_SetFieldOfView_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667155);
			RTFocusCamera.NativeMethodInfoPtr_SetObjectVisibilityDirty_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667156);
			RTFocusCamera.NativeMethodInfoPtr_GetVisibleObjects_Public_Void_List_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667157);
			RTFocusCamera.NativeMethodInfoPtr_PerformRotationSwitch_Public_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667158);
			RTFocusCamera.NativeMethodInfoPtr_PerformProjectionSwitch_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667159);
			RTFocusCamera.NativeMethodInfoPtr_Focus_Public_Void_AABB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667160);
			RTFocusCamera.NativeMethodInfoPtr_Update_SystemCall_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667161);
			RTFocusCamera.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667162);
			RTFocusCamera.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667163);
			RTFocusCamera.NativeMethodInfoPtr_HandleMouseAndKeyboardInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667164);
			RTFocusCamera.NativeMethodInfoPtr_CanUseMouseScrollWheel_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667165);
			RTFocusCamera.NativeMethodInfoPtr_CanCameraProcessInput_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667166);
			RTFocusCamera.NativeMethodInfoPtr_Zoom_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667167);
			RTFocusCamera.NativeMethodInfoPtr_GetFocusPoint_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667168);
			RTFocusCamera.NativeMethodInfoPtr_CalculateScrollZoomAmount_Private_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667169);
			RTFocusCamera.NativeMethodInfoPtr_Pan_Private_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667170);
			RTFocusCamera.NativeMethodInfoPtr_LookAround_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667171);
			RTFocusCamera.NativeMethodInfoPtr_Orbit_Private_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667172);
			RTFocusCamera.NativeMethodInfoPtr_PerformInstantFocus_Private_Void_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667173);
			RTFocusCamera.NativeMethodInfoPtr_PerformInstantProjectionSwitch_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667174);
			RTFocusCamera.NativeMethodInfoPtr_CalculateLookAroundRotation_Private_Vector2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667175);
			RTFocusCamera.NativeMethodInfoPtr_CalculateOrbitRotation_Private_Vector2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667176);
			RTFocusCamera.NativeMethodInfoPtr_CalculatePanAmount_Private_Vector2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667177);
			RTFocusCamera.NativeMethodInfoPtr_StopCamTransform_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667178);
			RTFocusCamera.NativeMethodInfoPtr_StopFocus_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667179);
			RTFocusCamera.NativeMethodInfoPtr_SetFocusPoint_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667180);
			RTFocusCamera.NativeMethodInfoPtr_AdjustOrthoSizeForFocusPt_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667181);
			RTFocusCamera.NativeMethodInfoPtr_DoSmoothPan_Private_IEnumerator_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667182);
			RTFocusCamera.NativeMethodInfoPtr_DoSmoothLookAround_Private_IEnumerator_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667183);
			RTFocusCamera.NativeMethodInfoPtr_DoSmoothOrbit_Private_IEnumerator_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667184);
			RTFocusCamera.NativeMethodInfoPtr_DoSmoothZoom_Private_IEnumerator_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667185);
			RTFocusCamera.NativeMethodInfoPtr_DoConstantRotationSwitch_Private_IEnumerator_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667186);
			RTFocusCamera.NativeMethodInfoPtr_DoSmoothRotationSwitch_Private_IEnumerator_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667187);
			RTFocusCamera.NativeMethodInfoPtr_DoConstantFocus_Private_IEnumerator_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667188);
			RTFocusCamera.NativeMethodInfoPtr_DoSmoothFocus_Private_IEnumerator_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667189);
			RTFocusCamera.NativeMethodInfoPtr_OnPrjSwitchTransitionBegin_Private_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667190);
			RTFocusCamera.NativeMethodInfoPtr_OnPrjSwitchTransitionUpate_Private_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667191);
			RTFocusCamera.NativeMethodInfoPtr_OnPrjSwitchTransitionEnd_Private_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, 100667192);
		}

		// Token: 0x170009BD RID: 2493
		// (get) Token: 0x060019F1 RID: 6641 RVA: 0x000867C0 File Offset: 0x000849C0
		public unsafe Camera TargetCamera
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_get_TargetCamera_Public_get_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr3) : null;
			}
		}

		// Token: 0x170009BE RID: 2494
		// (get) Token: 0x060019F2 RID: 6642 RVA: 0x00086800 File Offset: 0x00084A00
		public unsafe bool IsDoingProjectionSwitch
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 75219, RefRangeEnd = 75220, XrefRangeStart = 75219, XrefRangeEnd = 75219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_get_IsDoingProjectionSwitch_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009BF RID: 2495
		// (get) Token: 0x060019F3 RID: 6643 RVA: 0x0008683C File Offset: 0x00084A3C
		public unsafe CameraPrjSwitchTransition.Type PrjSwitchTransitionType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 75220, RefRangeEnd = 75221, XrefRangeStart = 75220, XrefRangeEnd = 75220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_get_PrjSwitchTransitionType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009C0 RID: 2496
		// (get) Token: 0x060019F4 RID: 6644 RVA: 0x00086878 File Offset: 0x00084A78
		public unsafe bool IsDoingRotationSwitch
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 72888, RefRangeEnd = 72889, XrefRangeStart = 72888, XrefRangeEnd = 72889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_get_IsDoingRotationSwitch_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009C1 RID: 2497
		// (get) Token: 0x060019F5 RID: 6645 RVA: 0x000868B4 File Offset: 0x00084AB4
		public unsafe float PrjSwitchProgress
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 75221, RefRangeEnd = 75223, XrefRangeStart = 75221, XrefRangeEnd = 75221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_get_PrjSwitchProgress_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009C2 RID: 2498
		// (get) Token: 0x060019F6 RID: 6646 RVA: 0x000868F0 File Offset: 0x00084AF0
		public unsafe float PrjSwitchDurationInSeconds
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_get_PrjSwitchDurationInSeconds_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009C3 RID: 2499
		// (get) Token: 0x060019F7 RID: 6647 RVA: 0x0008692C File Offset: 0x00084B2C
		public unsafe bool IsDoingFocus
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_get_IsDoingFocus_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009C4 RID: 2500
		// (get) Token: 0x060019F8 RID: 6648 RVA: 0x00086968 File Offset: 0x00084B68
		// (set) Token: 0x060019F9 RID: 6649 RVA: 0x000869A8 File Offset: 0x00084BA8
		public unsafe Vector3 WorldPosition
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75223, XrefRangeEnd = 75224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_get_WorldPosition_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75224, XrefRangeEnd = 75228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_set_WorldPosition_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009C5 RID: 2501
		// (get) Token: 0x060019FA RID: 6650 RVA: 0x000869EC File Offset: 0x00084BEC
		// (set) Token: 0x060019FB RID: 6651 RVA: 0x00086A2C File Offset: 0x00084C2C
		public unsafe Quaternion WorldRotation
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75228, XrefRangeEnd = 75229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_get_WorldRotation_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75229, XrefRangeEnd = 75230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_set_WorldRotation_Public_set_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170009C6 RID: 2502
		// (get) Token: 0x060019FC RID: 6652 RVA: 0x00086A70 File Offset: 0x00084C70
		public unsafe Vector3 Right
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75230, XrefRangeEnd = 75231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_get_Right_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x170009C7 RID: 2503
		// (get) Token: 0x060019FD RID: 6653 RVA: 0x00086AB0 File Offset: 0x00084CB0
		public unsafe Vector3 Up
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75231, XrefRangeEnd = 75232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_get_Up_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x170009C8 RID: 2504
		// (get) Token: 0x060019FE RID: 6654 RVA: 0x00086AF0 File Offset: 0x00084CF0
		public unsafe Vector3 Look
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 75233, RefRangeEnd = 75234, XrefRangeStart = 75232, XrefRangeEnd = 75233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_get_Look_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x170009C9 RID: 2505
		// (get) Token: 0x060019FF RID: 6655 RVA: 0x00086B30 File Offset: 0x00084D30
		public unsafe bool IsMovingForward
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_get_IsMovingForward_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009CA RID: 2506
		// (get) Token: 0x06001A00 RID: 6656 RVA: 0x00086B6C File Offset: 0x00084D6C
		public unsafe bool IsMovingBackwards
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_get_IsMovingBackwards_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009CB RID: 2507
		// (get) Token: 0x06001A01 RID: 6657 RVA: 0x00086BA8 File Offset: 0x00084DA8
		public unsafe bool IsMovingLeft
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_get_IsMovingLeft_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009CC RID: 2508
		// (get) Token: 0x06001A02 RID: 6658 RVA: 0x00086BE4 File Offset: 0x00084DE4
		public unsafe bool IsMovingRight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_get_IsMovingRight_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009CD RID: 2509
		// (get) Token: 0x06001A03 RID: 6659 RVA: 0x00086C20 File Offset: 0x00084E20
		public unsafe bool IsMovingUp
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_get_IsMovingUp_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009CE RID: 2510
		// (get) Token: 0x06001A04 RID: 6660 RVA: 0x00086C5C File Offset: 0x00084E5C
		public unsafe bool IsMovingDown
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_get_IsMovingDown_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009CF RID: 2511
		// (get) Token: 0x06001A05 RID: 6661 RVA: 0x00086C98 File Offset: 0x00084E98
		public unsafe CameraSettings Settings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_get_Settings_Public_get_CameraSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CameraSettings>(intPtr3) : null;
			}
		}

		// Token: 0x170009D0 RID: 2512
		// (get) Token: 0x06001A06 RID: 6662 RVA: 0x00086CD8 File Offset: 0x00084ED8
		public unsafe CameraMoveSettings MoveSettings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_get_MoveSettings_Public_get_CameraMoveSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CameraMoveSettings>(intPtr3) : null;
			}
		}

		// Token: 0x170009D1 RID: 2513
		// (get) Token: 0x06001A07 RID: 6663 RVA: 0x00086D18 File Offset: 0x00084F18
		public unsafe CameraPanSettings PanSettings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_get_PanSettings_Public_get_CameraPanSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CameraPanSettings>(intPtr3) : null;
			}
		}

		// Token: 0x170009D2 RID: 2514
		// (get) Token: 0x06001A08 RID: 6664 RVA: 0x00086D58 File Offset: 0x00084F58
		public unsafe CameraLookAroundSettings LookAroundSettings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_get_LookAroundSettings_Public_get_CameraLookAroundSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CameraLookAroundSettings>(intPtr3) : null;
			}
		}

		// Token: 0x170009D3 RID: 2515
		// (get) Token: 0x06001A09 RID: 6665 RVA: 0x00086D98 File Offset: 0x00084F98
		public unsafe CameraOrbitSettings OrbitSettings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_get_OrbitSettings_Public_get_CameraOrbitSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CameraOrbitSettings>(intPtr3) : null;
			}
		}

		// Token: 0x170009D4 RID: 2516
		// (get) Token: 0x06001A0A RID: 6666 RVA: 0x00086DD8 File Offset: 0x00084FD8
		public unsafe CameraZoomSettings ZoomSettings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_get_ZoomSettings_Public_get_CameraZoomSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CameraZoomSettings>(intPtr3) : null;
			}
		}

		// Token: 0x170009D5 RID: 2517
		// (get) Token: 0x06001A0B RID: 6667 RVA: 0x00086E18 File Offset: 0x00085018
		public unsafe CameraFocusSettings FocusSettings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_get_FocusSettings_Public_get_CameraFocusSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CameraFocusSettings>(intPtr3) : null;
			}
		}

		// Token: 0x170009D6 RID: 2518
		// (get) Token: 0x06001A0C RID: 6668 RVA: 0x00086E58 File Offset: 0x00085058
		public unsafe CameraRotationSwitchSettings RotationSwitchSettings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_get_RotationSwitchSettings_Public_get_CameraRotationSwitchSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CameraRotationSwitchSettings>(intPtr3) : null;
			}
		}

		// Token: 0x170009D7 RID: 2519
		// (get) Token: 0x06001A0D RID: 6669 RVA: 0x00086E98 File Offset: 0x00085098
		public unsafe CameraProjectionSwitchSettings ProjectionSwitchSettings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_get_ProjectionSwitchSettings_Public_get_CameraProjectionSwitchSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CameraProjectionSwitchSettings>(intPtr3) : null;
			}
		}

		// Token: 0x170009D8 RID: 2520
		// (get) Token: 0x06001A0E RID: 6670 RVA: 0x00086ED8 File Offset: 0x000850D8
		public unsafe CameraHotkeys Hotkeys
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_get_Hotkeys_Public_get_CameraHotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CameraHotkeys>(intPtr3) : null;
			}
		}

		// Token: 0x06001A0F RID: 6671 RVA: 0x00086F18 File Offset: 0x00085118
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75234, XrefRangeEnd = 75238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_PrjSwitchTransitionBegin(CameraProjectionSwitchBeginHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_add_PrjSwitchTransitionBegin_Public_add_Void_CameraProjectionSwitchBeginHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A10 RID: 6672 RVA: 0x00086F5C File Offset: 0x0008515C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75238, XrefRangeEnd = 75242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_PrjSwitchTransitionBegin(CameraProjectionSwitchBeginHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_remove_PrjSwitchTransitionBegin_Public_rem_Void_CameraProjectionSwitchBeginHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A11 RID: 6673 RVA: 0x00086FA0 File Offset: 0x000851A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75242, XrefRangeEnd = 75246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_PrjSwitchTransitionUpdate(CameraProjectionSwitchUpdateHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_add_PrjSwitchTransitionUpdate_Public_add_Void_CameraProjectionSwitchUpdateHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A12 RID: 6674 RVA: 0x00086FE4 File Offset: 0x000851E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75246, XrefRangeEnd = 75250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_PrjSwitchTransitionUpdate(CameraProjectionSwitchUpdateHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_remove_PrjSwitchTransitionUpdate_Public_rem_Void_CameraProjectionSwitchUpdateHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A13 RID: 6675 RVA: 0x00087028 File Offset: 0x00085228
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75250, XrefRangeEnd = 75254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_PrjSwitchTransitionEnd(CameraProjectionSwitchBeginHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_add_PrjSwitchTransitionEnd_Public_add_Void_CameraProjectionSwitchBeginHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A14 RID: 6676 RVA: 0x0008706C File Offset: 0x0008526C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75254, XrefRangeEnd = 75258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_PrjSwitchTransitionEnd(CameraProjectionSwitchBeginHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_remove_PrjSwitchTransitionEnd_Public_rem_Void_CameraProjectionSwitchBeginHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A15 RID: 6677 RVA: 0x000870B0 File Offset: 0x000852B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75258, XrefRangeEnd = 75262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_CanProcessInput(CameraCanProcessInputHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_add_CanProcessInput_Public_add_Void_CameraCanProcessInputHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A16 RID: 6678 RVA: 0x000870F4 File Offset: 0x000852F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75262, XrefRangeEnd = 75266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_CanProcessInput(CameraCanProcessInputHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_remove_CanProcessInput_Public_rem_Void_CameraCanProcessInputHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A17 RID: 6679 RVA: 0x00087138 File Offset: 0x00085338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75266, XrefRangeEnd = 75270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_CanUseScrollWheel(CameraCanUseScrollWheelHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_add_CanUseScrollWheel_Public_add_Void_CameraCanUseScrollWheelHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A18 RID: 6680 RVA: 0x0008717C File Offset: 0x0008537C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75270, XrefRangeEnd = 75274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_CanUseScrollWheel(CameraCanUseScrollWheelHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_remove_CanUseScrollWheel_Public_rem_Void_CameraCanUseScrollWheelHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A19 RID: 6681 RVA: 0x000871C0 File Offset: 0x000853C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75274, XrefRangeEnd = 75397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RTFocusCamera()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A1A RID: 6682 RVA: 0x000871FC File Offset: 0x000853FC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 75407, RefRangeEnd = 75410, XrefRangeStart = 75397, XrefRangeEnd = 75407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsViewportHoveredByDevice()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_IsViewportHoveredByDevice_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A1B RID: 6683 RVA: 0x00087238 File Offset: 0x00085438
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 75425, RefRangeEnd = 75428, XrefRangeStart = 75410, XrefRangeEnd = 75425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTargetCamera(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_SetTargetCamera_Public_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A1C RID: 6684 RVA: 0x0008727C File Offset: 0x0008547C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75428, XrefRangeEnd = 75429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFieldOfView(float fov)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fov;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_SetFieldOfView_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A1D RID: 6685 RVA: 0x000872BC File Offset: 0x000854BC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 75429, RefRangeEnd = 75433, XrefRangeStart = 75429, XrefRangeEnd = 75429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetObjectVisibilityDirty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_SetObjectVisibilityDirty_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A1E RID: 6686 RVA: 0x000872F0 File Offset: 0x000854F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 75460, RefRangeEnd = 75462, XrefRangeStart = 75433, XrefRangeEnd = 75460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetVisibleObjects(List<GameObject> visibleObjects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(visibleObjects);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_GetVisibleObjects_Public_Void_List_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A1F RID: 6687 RVA: 0x00087334 File Offset: 0x00085534
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 75467, RefRangeEnd = 75468, XrefRangeStart = 75462, XrefRangeEnd = 75467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PerformRotationSwitch(Quaternion targetRotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetRotation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_PerformRotationSwitch_Public_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A20 RID: 6688 RVA: 0x00087378 File Offset: 0x00085578
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 75474, RefRangeEnd = 75476, XrefRangeStart = 75468, XrefRangeEnd = 75474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PerformProjectionSwitch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_PerformProjectionSwitch_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A21 RID: 6689 RVA: 0x000873AC File Offset: 0x000855AC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 75503, RefRangeEnd = 75508, XrefRangeStart = 75476, XrefRangeEnd = 75503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Focus(AABB focusAABB)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(focusAABB);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_Focus_Public_Void_AABB_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A22 RID: 6690 RVA: 0x000873F0 File Offset: 0x000855F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75508, XrefRangeEnd = 75523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update_SystemCall()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_Update_SystemCall_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A23 RID: 6691 RVA: 0x00087424 File Offset: 0x00085624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75523, XrefRangeEnd = 75575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A24 RID: 6692 RVA: 0x00087458 File Offset: 0x00085658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75575, XrefRangeEnd = 75581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A25 RID: 6693 RVA: 0x0008748C File Offset: 0x0008568C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 75679, RefRangeEnd = 75681, XrefRangeStart = 75581, XrefRangeEnd = 75679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleMouseAndKeyboardInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_HandleMouseAndKeyboardInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A26 RID: 6694 RVA: 0x000874C0 File Offset: 0x000856C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75681, XrefRangeEnd = 75685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanUseMouseScrollWheel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_CanUseMouseScrollWheel_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A27 RID: 6695 RVA: 0x000874FC File Offset: 0x000856FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75685, XrefRangeEnd = 75689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanCameraProcessInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_CanCameraProcessInput_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A28 RID: 6696 RVA: 0x00087538 File Offset: 0x00085738
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 75702, RefRangeEnd = 75704, XrefRangeStart = 75689, XrefRangeEnd = 75702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Zoom(float zoomAmount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref zoomAmount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_Zoom_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A29 RID: 6697 RVA: 0x00087578 File Offset: 0x00085778
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 75706, RefRangeEnd = 75709, XrefRangeStart = 75704, XrefRangeEnd = 75706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetFocusPoint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_GetFocusPoint_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
		}

		// Token: 0x06001A2A RID: 6698 RVA: 0x000875B8 File Offset: 0x000857B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 75719, RefRangeEnd = 75720, XrefRangeStart = 75709, XrefRangeEnd = 75719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float CalculateScrollZoomAmount(float deviceScroll)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deviceScroll;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_CalculateScrollZoomAmount_Private_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A2B RID: 6699 RVA: 0x00087604 File Offset: 0x00085804
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 75724, RefRangeEnd = 75726, XrefRangeStart = 75720, XrefRangeEnd = 75724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Pan(Vector2 panAmount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(panAmount);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_Pan_Private_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A2C RID: 6700 RVA: 0x00087648 File Offset: 0x00085848
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 75731, RefRangeEnd = 75733, XrefRangeStart = 75726, XrefRangeEnd = 75731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LookAround(float degreesLocalX, float degreesWorldY)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref degreesLocalX;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref degreesWorldY;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_LookAround_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A2D RID: 6701 RVA: 0x00087694 File Offset: 0x00085894
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 75742, RefRangeEnd = 75744, XrefRangeStart = 75733, XrefRangeEnd = 75742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Orbit(float degreesLocalX, float degreesWorldY)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref degreesLocalX;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref degreesWorldY;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_Orbit_Private_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A2E RID: 6702 RVA: 0x000876E0 File Offset: 0x000858E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75744, XrefRangeEnd = 75749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PerformInstantFocus(CameraFocus.Data focusData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(focusData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_PerformInstantFocus_Private_Void_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A2F RID: 6703 RVA: 0x00087724 File Offset: 0x00085924
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75749, XrefRangeEnd = 75752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PerformInstantProjectionSwitch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_PerformInstantProjectionSwitch_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A30 RID: 6704 RVA: 0x00087758 File Offset: 0x00085958
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 75753, RefRangeEnd = 75755, XrefRangeStart = 75752, XrefRangeEnd = 75753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 CalculateLookAroundRotation(float deviceAxisX, float deviceAxisY)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deviceAxisX;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deviceAxisY;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_CalculateLookAroundRotation_Private_Vector2_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
		}

		// Token: 0x06001A31 RID: 6705 RVA: 0x000877B4 File Offset: 0x000859B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 75756, RefRangeEnd = 75758, XrefRangeStart = 75755, XrefRangeEnd = 75756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 CalculateOrbitRotation(float deviceAxisX, float deviceAxisY)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deviceAxisX;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deviceAxisY;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_CalculateOrbitRotation_Private_Vector2_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
		}

		// Token: 0x06001A32 RID: 6706 RVA: 0x00087810 File Offset: 0x00085A10
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 75763, RefRangeEnd = 75765, XrefRangeStart = 75758, XrefRangeEnd = 75763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 CalculatePanAmount(float deviceAxisX, float deviceAxisY)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deviceAxisX;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deviceAxisY;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_CalculatePanAmount_Private_Vector2_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
		}

		// Token: 0x06001A33 RID: 6707 RVA: 0x0008786C File Offset: 0x00085A6C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 75767, RefRangeEnd = 75772, XrefRangeStart = 75765, XrefRangeEnd = 75767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopCamTransform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_StopCamTransform_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A34 RID: 6708 RVA: 0x000878A0 File Offset: 0x00085AA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75772, XrefRangeEnd = 75774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopFocus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_StopFocus_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A35 RID: 6709 RVA: 0x000878D4 File Offset: 0x00085AD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 75776, RefRangeEnd = 75777, XrefRangeStart = 75774, XrefRangeEnd = 75776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFocusPoint(Vector3 focusPoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(focusPoint);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_SetFocusPoint_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A36 RID: 6710 RVA: 0x00087918 File Offset: 0x00085B18
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 75784, RefRangeEnd = 75788, XrefRangeStart = 75777, XrefRangeEnd = 75784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AdjustOrthoSizeForFocusPt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_AdjustOrthoSizeForFocusPt_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A37 RID: 6711 RVA: 0x0008794C File Offset: 0x00085B4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75788, XrefRangeEnd = 75793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DoSmoothPan(float deviceAxisX, float deviceAxisY)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deviceAxisX;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deviceAxisY;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_DoSmoothPan_Private_IEnumerator_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001A38 RID: 6712 RVA: 0x000879A8 File Offset: 0x00085BA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75793, XrefRangeEnd = 75798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DoSmoothLookAround(float deviceAxisX, float deviceAxisY)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deviceAxisX;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deviceAxisY;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_DoSmoothLookAround_Private_IEnumerator_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001A39 RID: 6713 RVA: 0x00087A04 File Offset: 0x00085C04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75798, XrefRangeEnd = 75803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DoSmoothOrbit(float deviceAxisX, float deviceAxisY)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deviceAxisX;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deviceAxisY;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_DoSmoothOrbit_Private_IEnumerator_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001A3A RID: 6714 RVA: 0x00087A60 File Offset: 0x00085C60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75803, XrefRangeEnd = 75808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DoSmoothZoom(float deviceScroll)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deviceScroll;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_DoSmoothZoom_Private_IEnumerator_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06001A3B RID: 6715 RVA: 0x00087AAC File Offset: 0x00085CAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75808, XrefRangeEnd = 75813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DoConstantRotationSwitch(Quaternion targetRotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetRotation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_DoConstantRotationSwitch_Private_IEnumerator_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06001A3C RID: 6716 RVA: 0x00087AFC File Offset: 0x00085CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75813, XrefRangeEnd = 75818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DoSmoothRotationSwitch(Quaternion targetRotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetRotation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_DoSmoothRotationSwitch_Private_IEnumerator_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06001A3D RID: 6717 RVA: 0x00087B4C File Offset: 0x00085D4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75818, XrefRangeEnd = 75824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DoConstantFocus(CameraFocus.Data focusData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(focusData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_DoConstantFocus_Private_IEnumerator_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06001A3E RID: 6718 RVA: 0x00087B9C File Offset: 0x00085D9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75824, XrefRangeEnd = 75830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DoSmoothFocus(CameraFocus.Data focusData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(focusData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_DoSmoothFocus_Private_IEnumerator_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06001A3F RID: 6719 RVA: 0x00087BEC File Offset: 0x00085DEC
		[CallerCount(0)]
		public unsafe void OnPrjSwitchTransitionBegin(CameraPrjSwitchTransition.Type transitionType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref transitionType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_OnPrjSwitchTransitionBegin_Private_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A40 RID: 6720 RVA: 0x00087C2C File Offset: 0x00085E2C
		[CallerCount(0)]
		public unsafe void OnPrjSwitchTransitionUpate(CameraPrjSwitchTransition.Type transitionType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref transitionType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_OnPrjSwitchTransitionUpate_Private_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A41 RID: 6721 RVA: 0x00087C6C File Offset: 0x00085E6C
		[CallerCount(0)]
		public unsafe void OnPrjSwitchTransitionEnd(CameraPrjSwitchTransition.Type transitionType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref transitionType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera.NativeMethodInfoPtr_OnPrjSwitchTransitionEnd_Private_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A42 RID: 6722 RVA: 0x0000B5E2 File Offset: 0x000097E2
		public RTFocusCamera(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700099F RID: 2463
		// (get) Token: 0x06001A43 RID: 6723 RVA: 0x00087CAC File Offset: 0x00085EAC
		// (set) Token: 0x06001A44 RID: 6724 RVA: 0x0000B5EB File Offset: 0x000097EB
		public unsafe CameraProjectionSwitchBeginHandler PrjSwitchTransitionBegin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera.NativeFieldInfoPtr_PrjSwitchTransitionBegin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CameraProjectionSwitchBeginHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera.NativeFieldInfoPtr_PrjSwitchTransitionBegin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009A0 RID: 2464
		// (get) Token: 0x06001A45 RID: 6725 RVA: 0x00087CDC File Offset: 0x00085EDC
		// (set) Token: 0x06001A46 RID: 6726 RVA: 0x0000B60A File Offset: 0x0000980A
		public unsafe CameraProjectionSwitchUpdateHandler PrjSwitchTransitionUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera.NativeFieldInfoPtr_PrjSwitchTransitionUpdate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CameraProjectionSwitchUpdateHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera.NativeFieldInfoPtr_PrjSwitchTransitionUpdate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009A1 RID: 2465
		// (get) Token: 0x06001A47 RID: 6727 RVA: 0x00087D0C File Offset: 0x00085F0C
		// (set) Token: 0x06001A48 RID: 6728 RVA: 0x0000B629 File Offset: 0x00009829
		public unsafe CameraProjectionSwitchBeginHandler PrjSwitchTransitionEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera.NativeFieldInfoPtr_PrjSwitchTransitionEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CameraProjectionSwitchBeginHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera.NativeFieldInfoPtr_PrjSwitchTransitionEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009A2 RID: 2466
		// (get) Token: 0x06001A49 RID: 6729 RVA: 0x00087D3C File Offset: 0x00085F3C
		// (set) Token: 0x06001A4A RID: 6730 RVA: 0x0000B648 File Offset: 0x00009848
		public unsafe CameraCanProcessInputHandler CanProcessInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera.NativeFieldInfoPtr_CanProcessInput);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CameraCanProcessInputHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera.NativeFieldInfoPtr_CanProcessInput), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009A3 RID: 2467
		// (get) Token: 0x06001A4B RID: 6731 RVA: 0x00087D6C File Offset: 0x00085F6C
		// (set) Token: 0x06001A4C RID: 6732 RVA: 0x0000B667 File Offset: 0x00009867
		public unsafe CameraCanUseScrollWheelHandler CanUseScrollWheel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera.NativeFieldInfoPtr_CanUseScrollWheel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CameraCanUseScrollWheelHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera.NativeFieldInfoPtr_CanUseScrollWheel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009A4 RID: 2468
		// (get) Token: 0x06001A4D RID: 6733 RVA: 0x00087D9C File Offset: 0x00085F9C
		// (set) Token: 0x06001A4E RID: 6734 RVA: 0x0000B686 File Offset: 0x00009886
		public unsafe Camera _targetCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera.NativeFieldInfoPtr__targetCamera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera.NativeFieldInfoPtr__targetCamera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009A5 RID: 2469
		// (get) Token: 0x06001A4F RID: 6735 RVA: 0x00087DCC File Offset: 0x00085FCC
		// (set) Token: 0x06001A50 RID: 6736 RVA: 0x0000B6A5 File Offset: 0x000098A5
		public unsafe Transform _targetTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera.NativeFieldInfoPtr__targetTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera.NativeFieldInfoPtr__targetTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009A6 RID: 2470
		// (get) Token: 0x06001A51 RID: 6737 RVA: 0x00087DFC File Offset: 0x00085FFC
		// (set) Token: 0x06001A52 RID: 6738 RVA: 0x0000B6C4 File Offset: 0x000098C4
		public unsafe float _fieldOfView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera.NativeFieldInfoPtr__fieldOfView);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera.NativeFieldInfoPtr__fieldOfView)) = value;
			}
		}

		// Token: 0x170009A7 RID: 2471
		// (get) Token: 0x06001A53 RID: 6739 RVA: 0x00087E24 File Offset: 0x00086024
		// (set) Token: 0x06001A54 RID: 6740 RVA: 0x0000B6DF File Offset: 0x000098DF
		public unsafe WorldTransformSnapshot _worldTransformSnapshot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera.NativeFieldInfoPtr__worldTransformSnapshot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldTransformSnapshot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera.NativeFieldInfoPtr__worldTransformSnapshot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009A8 RID: 2472
		// (get) Token: 0x06001A55 RID: 6741 RVA: 0x00087E54 File Offset: 0x00086054
		// (set) Token: 0x06001A56 RID: 6742 RVA: 0x0000B6FE File Offset: 0x000098FE
		public unsafe CameraPrjSwitchTransition _prjSwitchTranstion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera.NativeFieldInfoPtr__prjSwitchTranstion);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CameraPrjSwitchTransition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera.NativeFieldInfoPtr__prjSwitchTranstion), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009A9 RID: 2473
		// (get) Token: 0x06001A57 RID: 6743 RVA: 0x00087E84 File Offset: 0x00086084
		// (set) Token: 0x06001A58 RID: 6744 RVA: 0x0000B71D File Offset: 0x0000991D
		public unsafe bool _isDoingFocus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera.NativeFieldInfoPtr__isDoingFocus);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera.NativeFieldInfoPtr__isDoingFocus)) = value;
			}
		}

		// Token: 0x170009AA RID: 2474
		// (get) Token: 0x06001A59 RID: 6745 RVA: 0x00087EAC File Offset: 0x000860AC
		// (set) Token: 0x06001A5A RID: 6746 RVA: 0x0000B738 File Offset: 0x00009938
		public unsafe IEnumerator _focusCrtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera.NativeFieldInfoPtr__focusCrtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera.NativeFieldInfoPtr__focusCrtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009AB RID: 2475
		// (get) Token: 0x06001A5B RID: 6747 RVA: 0x00087EDC File Offset: 0x000860DC
		// (set) Token: 0x06001A5C RID: 6748 RVA: 0x0000B757 File Offset: 0x00009957
		public unsafe bool _isDoingRotationSwitch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera.NativeFieldInfoPtr__isDoingRotationSwitch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera.NativeFieldInfoPtr__isDoingRotationSwitch)) = value;
			}
		}

		// Token: 0x170009AC RID: 2476
		// (get) Token: 0x06001A5D RID: 6749 RVA: 0x00087F04 File Offset: 0x00086104
		// (set) Token: 0x06001A5E RID: 6750 RVA: 0x0000B772 File Offset: 0x00009972
		public unsafe IEnumerator _genricCamTransformCrtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera.NativeFieldInfoPtr__genricCamTransformCrtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera.NativeFieldInfoPtr__genricCamTransformCrtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009AD RID: 2477
		// (get) Token: 0x06001A5F RID: 6751 RVA: 0x00087F34 File Offset: 0x00086134
		// (set) Token: 0x06001A60 RID: 6752 RVA: 0x0000B791 File Offset: 0x00009991
		public unsafe bool _isObjectVisibilityDirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera.NativeFieldInfoPtr__isObjectVisibilityDirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera.NativeFieldInfoPtr__isObjectVisibilityDirty)) = value;
			}
		}

		// Token: 0x170009AE RID: 2478
		// (get) Token: 0x06001A61 RID: 6753 RVA: 0x00087F5C File Offset: 0x0008615C
		// (set) Token: 0x06001A62 RID: 6754 RVA: 0x0000B7AC File Offset: 0x000099AC
		public unsafe List<GameObject> _visibleObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera.NativeFieldInfoPtr__visibleObjects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera.NativeFieldInfoPtr__visibleObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009AF RID: 2479
		// (get) Token: 0x06001A63 RID: 6755 RVA: 0x00087F8C File Offset: 0x0008618C
		// (set) Token: 0x06001A64 RID: 6756 RVA: 0x0000B7CB File Offset: 0x000099CB
		public unsafe float _focusPointOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera.NativeFieldInfoPtr__focusPointOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera.NativeFieldInfoPtr__focusPointOffset)) = value;
			}
		}

		// Token: 0x170009B0 RID: 2480
		// (get) Token: 0x06001A65 RID: 6757 RVA: 0x00087FB4 File Offset: 0x000861B4
		// (set) Token: 0x06001A66 RID: 6758 RVA: 0x0000B7E6 File Offset: 0x000099E6
		public unsafe Vector3 _lastFocusPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera.NativeFieldInfoPtr__lastFocusPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera.NativeFieldInfoPtr__lastFocusPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009B1 RID: 2481
		// (get) Token: 0x06001A67 RID: 6759 RVA: 0x00087FE4 File Offset: 0x000861E4
		// (set) Token: 0x06001A68 RID: 6760 RVA: 0x0000B805 File Offset: 0x00009A05
		public unsafe Il2CppStructArray<bool> _moveDirFlags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera.NativeFieldInfoPtr__moveDirFlags);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera.NativeFieldInfoPtr__moveDirFlags), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009B2 RID: 2482
		// (get) Token: 0x06001A69 RID: 6761 RVA: 0x00088014 File Offset: 0x00086214
		// (set) Token: 0x06001A6A RID: 6762 RVA: 0x0000B824 File Offset: 0x00009A24
		public unsafe float _currentAcceleration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera.NativeFieldInfoPtr__currentAcceleration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera.NativeFieldInfoPtr__currentAcceleration)) = value;
			}
		}

		// Token: 0x170009B3 RID: 2483
		// (get) Token: 0x06001A6B RID: 6763 RVA: 0x0008803C File Offset: 0x0008623C
		// (set) Token: 0x06001A6C RID: 6764 RVA: 0x0000B83F File Offset: 0x00009A3F
		public unsafe CameraSettings _settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera.NativeFieldInfoPtr__settings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CameraSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera.NativeFieldInfoPtr__settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009B4 RID: 2484
		// (get) Token: 0x06001A6D RID: 6765 RVA: 0x0008806C File Offset: 0x0008626C
		// (set) Token: 0x06001A6E RID: 6766 RVA: 0x0000B85E File Offset: 0x00009A5E
		public unsafe CameraMoveSettings _moveSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera.NativeFieldInfoPtr__moveSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CameraMoveSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera.NativeFieldInfoPtr__moveSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009B5 RID: 2485
		// (get) Token: 0x06001A6F RID: 6767 RVA: 0x0008809C File Offset: 0x0008629C
		// (set) Token: 0x06001A70 RID: 6768 RVA: 0x0000B87D File Offset: 0x00009A7D
		public unsafe CameraPanSettings _panSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera.NativeFieldInfoPtr__panSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CameraPanSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera.NativeFieldInfoPtr__panSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009B6 RID: 2486
		// (get) Token: 0x06001A71 RID: 6769 RVA: 0x000880CC File Offset: 0x000862CC
		// (set) Token: 0x06001A72 RID: 6770 RVA: 0x0000B89C File Offset: 0x00009A9C
		public unsafe CameraLookAroundSettings _lookAroundSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera.NativeFieldInfoPtr__lookAroundSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CameraLookAroundSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera.NativeFieldInfoPtr__lookAroundSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009B7 RID: 2487
		// (get) Token: 0x06001A73 RID: 6771 RVA: 0x000880FC File Offset: 0x000862FC
		// (set) Token: 0x06001A74 RID: 6772 RVA: 0x0000B8BB File Offset: 0x00009ABB
		public unsafe CameraOrbitSettings _orbitSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera.NativeFieldInfoPtr__orbitSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CameraOrbitSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera.NativeFieldInfoPtr__orbitSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009B8 RID: 2488
		// (get) Token: 0x06001A75 RID: 6773 RVA: 0x0008812C File Offset: 0x0008632C
		// (set) Token: 0x06001A76 RID: 6774 RVA: 0x0000B8DA File Offset: 0x00009ADA
		public unsafe CameraZoomSettings _zoomSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera.NativeFieldInfoPtr__zoomSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CameraZoomSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera.NativeFieldInfoPtr__zoomSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009B9 RID: 2489
		// (get) Token: 0x06001A77 RID: 6775 RVA: 0x0008815C File Offset: 0x0008635C
		// (set) Token: 0x06001A78 RID: 6776 RVA: 0x0000B8F9 File Offset: 0x00009AF9
		public unsafe CameraFocusSettings _focusSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera.NativeFieldInfoPtr__focusSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CameraFocusSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera.NativeFieldInfoPtr__focusSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009BA RID: 2490
		// (get) Token: 0x06001A79 RID: 6777 RVA: 0x0008818C File Offset: 0x0008638C
		// (set) Token: 0x06001A7A RID: 6778 RVA: 0x0000B918 File Offset: 0x00009B18
		public unsafe CameraRotationSwitchSettings _rotationSwitchSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera.NativeFieldInfoPtr__rotationSwitchSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CameraRotationSwitchSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera.NativeFieldInfoPtr__rotationSwitchSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009BB RID: 2491
		// (get) Token: 0x06001A7B RID: 6779 RVA: 0x000881BC File Offset: 0x000863BC
		// (set) Token: 0x06001A7C RID: 6780 RVA: 0x0000B937 File Offset: 0x00009B37
		public unsafe CameraProjectionSwitchSettings _projectionSwitchSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera.NativeFieldInfoPtr__projectionSwitchSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CameraProjectionSwitchSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera.NativeFieldInfoPtr__projectionSwitchSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009BC RID: 2492
		// (get) Token: 0x06001A7D RID: 6781 RVA: 0x000881EC File Offset: 0x000863EC
		// (set) Token: 0x06001A7E RID: 6782 RVA: 0x0000B956 File Offset: 0x00009B56
		public unsafe CameraHotkeys _hotkeys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera.NativeFieldInfoPtr__hotkeys);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CameraHotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera.NativeFieldInfoPtr__hotkeys), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040013BC RID: 5052
		private static readonly IntPtr NativeFieldInfoPtr_PrjSwitchTransitionBegin;

		// Token: 0x040013BD RID: 5053
		private static readonly IntPtr NativeFieldInfoPtr_PrjSwitchTransitionUpdate;

		// Token: 0x040013BE RID: 5054
		private static readonly IntPtr NativeFieldInfoPtr_PrjSwitchTransitionEnd;

		// Token: 0x040013BF RID: 5055
		private static readonly IntPtr NativeFieldInfoPtr_CanProcessInput;

		// Token: 0x040013C0 RID: 5056
		private static readonly IntPtr NativeFieldInfoPtr_CanUseScrollWheel;

		// Token: 0x040013C1 RID: 5057
		private static readonly IntPtr NativeFieldInfoPtr__targetCamera;

		// Token: 0x040013C2 RID: 5058
		private static readonly IntPtr NativeFieldInfoPtr__targetTransform;

		// Token: 0x040013C3 RID: 5059
		private static readonly IntPtr NativeFieldInfoPtr__fieldOfView;

		// Token: 0x040013C4 RID: 5060
		private static readonly IntPtr NativeFieldInfoPtr__worldTransformSnapshot;

		// Token: 0x040013C5 RID: 5061
		private static readonly IntPtr NativeFieldInfoPtr__prjSwitchTranstion;

		// Token: 0x040013C6 RID: 5062
		private static readonly IntPtr NativeFieldInfoPtr__isDoingFocus;

		// Token: 0x040013C7 RID: 5063
		private static readonly IntPtr NativeFieldInfoPtr__focusCrtn;

		// Token: 0x040013C8 RID: 5064
		private static readonly IntPtr NativeFieldInfoPtr__isDoingRotationSwitch;

		// Token: 0x040013C9 RID: 5065
		private static readonly IntPtr NativeFieldInfoPtr__genricCamTransformCrtn;

		// Token: 0x040013CA RID: 5066
		private static readonly IntPtr NativeFieldInfoPtr__isObjectVisibilityDirty;

		// Token: 0x040013CB RID: 5067
		private static readonly IntPtr NativeFieldInfoPtr__visibleObjects;

		// Token: 0x040013CC RID: 5068
		private static readonly IntPtr NativeFieldInfoPtr__focusPointOffset;

		// Token: 0x040013CD RID: 5069
		private static readonly IntPtr NativeFieldInfoPtr__lastFocusPoint;

		// Token: 0x040013CE RID: 5070
		private static readonly IntPtr NativeFieldInfoPtr__moveDirFlags;

		// Token: 0x040013CF RID: 5071
		private static readonly IntPtr NativeFieldInfoPtr__currentAcceleration;

		// Token: 0x040013D0 RID: 5072
		private static readonly IntPtr NativeFieldInfoPtr__settings;

		// Token: 0x040013D1 RID: 5073
		private static readonly IntPtr NativeFieldInfoPtr__moveSettings;

		// Token: 0x040013D2 RID: 5074
		private static readonly IntPtr NativeFieldInfoPtr__panSettings;

		// Token: 0x040013D3 RID: 5075
		private static readonly IntPtr NativeFieldInfoPtr__lookAroundSettings;

		// Token: 0x040013D4 RID: 5076
		private static readonly IntPtr NativeFieldInfoPtr__orbitSettings;

		// Token: 0x040013D5 RID: 5077
		private static readonly IntPtr NativeFieldInfoPtr__zoomSettings;

		// Token: 0x040013D6 RID: 5078
		private static readonly IntPtr NativeFieldInfoPtr__focusSettings;

		// Token: 0x040013D7 RID: 5079
		private static readonly IntPtr NativeFieldInfoPtr__rotationSwitchSettings;

		// Token: 0x040013D8 RID: 5080
		private static readonly IntPtr NativeFieldInfoPtr__projectionSwitchSettings;

		// Token: 0x040013D9 RID: 5081
		private static readonly IntPtr NativeFieldInfoPtr__hotkeys;

		// Token: 0x040013DA RID: 5082
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetCamera_Public_get_Camera_0;

		// Token: 0x040013DB RID: 5083
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDoingProjectionSwitch_Public_get_Boolean_0;

		// Token: 0x040013DC RID: 5084
		private static readonly IntPtr NativeMethodInfoPtr_get_PrjSwitchTransitionType_Public_get_Type_0;

		// Token: 0x040013DD RID: 5085
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDoingRotationSwitch_Public_get_Boolean_0;

		// Token: 0x040013DE RID: 5086
		private static readonly IntPtr NativeMethodInfoPtr_get_PrjSwitchProgress_Public_get_Single_0;

		// Token: 0x040013DF RID: 5087
		private static readonly IntPtr NativeMethodInfoPtr_get_PrjSwitchDurationInSeconds_Public_get_Single_0;

		// Token: 0x040013E0 RID: 5088
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDoingFocus_Public_get_Boolean_0;

		// Token: 0x040013E1 RID: 5089
		private static readonly IntPtr NativeMethodInfoPtr_get_WorldPosition_Public_get_Vector3_0;

		// Token: 0x040013E2 RID: 5090
		private static readonly IntPtr NativeMethodInfoPtr_set_WorldPosition_Public_set_Void_Vector3_0;

		// Token: 0x040013E3 RID: 5091
		private static readonly IntPtr NativeMethodInfoPtr_get_WorldRotation_Public_get_Quaternion_0;

		// Token: 0x040013E4 RID: 5092
		private static readonly IntPtr NativeMethodInfoPtr_set_WorldRotation_Public_set_Void_Quaternion_0;

		// Token: 0x040013E5 RID: 5093
		private static readonly IntPtr NativeMethodInfoPtr_get_Right_Public_get_Vector3_0;

		// Token: 0x040013E6 RID: 5094
		private static readonly IntPtr NativeMethodInfoPtr_get_Up_Public_get_Vector3_0;

		// Token: 0x040013E7 RID: 5095
		private static readonly IntPtr NativeMethodInfoPtr_get_Look_Public_get_Vector3_0;

		// Token: 0x040013E8 RID: 5096
		private static readonly IntPtr NativeMethodInfoPtr_get_IsMovingForward_Public_get_Boolean_0;

		// Token: 0x040013E9 RID: 5097
		private static readonly IntPtr NativeMethodInfoPtr_get_IsMovingBackwards_Public_get_Boolean_0;

		// Token: 0x040013EA RID: 5098
		private static readonly IntPtr NativeMethodInfoPtr_get_IsMovingLeft_Public_get_Boolean_0;

		// Token: 0x040013EB RID: 5099
		private static readonly IntPtr NativeMethodInfoPtr_get_IsMovingRight_Public_get_Boolean_0;

		// Token: 0x040013EC RID: 5100
		private static readonly IntPtr NativeMethodInfoPtr_get_IsMovingUp_Public_get_Boolean_0;

		// Token: 0x040013ED RID: 5101
		private static readonly IntPtr NativeMethodInfoPtr_get_IsMovingDown_Public_get_Boolean_0;

		// Token: 0x040013EE RID: 5102
		private static readonly IntPtr NativeMethodInfoPtr_get_Settings_Public_get_CameraSettings_0;

		// Token: 0x040013EF RID: 5103
		private static readonly IntPtr NativeMethodInfoPtr_get_MoveSettings_Public_get_CameraMoveSettings_0;

		// Token: 0x040013F0 RID: 5104
		private static readonly IntPtr NativeMethodInfoPtr_get_PanSettings_Public_get_CameraPanSettings_0;

		// Token: 0x040013F1 RID: 5105
		private static readonly IntPtr NativeMethodInfoPtr_get_LookAroundSettings_Public_get_CameraLookAroundSettings_0;

		// Token: 0x040013F2 RID: 5106
		private static readonly IntPtr NativeMethodInfoPtr_get_OrbitSettings_Public_get_CameraOrbitSettings_0;

		// Token: 0x040013F3 RID: 5107
		private static readonly IntPtr NativeMethodInfoPtr_get_ZoomSettings_Public_get_CameraZoomSettings_0;

		// Token: 0x040013F4 RID: 5108
		private static readonly IntPtr NativeMethodInfoPtr_get_FocusSettings_Public_get_CameraFocusSettings_0;

		// Token: 0x040013F5 RID: 5109
		private static readonly IntPtr NativeMethodInfoPtr_get_RotationSwitchSettings_Public_get_CameraRotationSwitchSettings_0;

		// Token: 0x040013F6 RID: 5110
		private static readonly IntPtr NativeMethodInfoPtr_get_ProjectionSwitchSettings_Public_get_CameraProjectionSwitchSettings_0;

		// Token: 0x040013F7 RID: 5111
		private static readonly IntPtr NativeMethodInfoPtr_get_Hotkeys_Public_get_CameraHotkeys_0;

		// Token: 0x040013F8 RID: 5112
		private static readonly IntPtr NativeMethodInfoPtr_add_PrjSwitchTransitionBegin_Public_add_Void_CameraProjectionSwitchBeginHandler_0;

		// Token: 0x040013F9 RID: 5113
		private static readonly IntPtr NativeMethodInfoPtr_remove_PrjSwitchTransitionBegin_Public_rem_Void_CameraProjectionSwitchBeginHandler_0;

		// Token: 0x040013FA RID: 5114
		private static readonly IntPtr NativeMethodInfoPtr_add_PrjSwitchTransitionUpdate_Public_add_Void_CameraProjectionSwitchUpdateHandler_0;

		// Token: 0x040013FB RID: 5115
		private static readonly IntPtr NativeMethodInfoPtr_remove_PrjSwitchTransitionUpdate_Public_rem_Void_CameraProjectionSwitchUpdateHandler_0;

		// Token: 0x040013FC RID: 5116
		private static readonly IntPtr NativeMethodInfoPtr_add_PrjSwitchTransitionEnd_Public_add_Void_CameraProjectionSwitchBeginHandler_0;

		// Token: 0x040013FD RID: 5117
		private static readonly IntPtr NativeMethodInfoPtr_remove_PrjSwitchTransitionEnd_Public_rem_Void_CameraProjectionSwitchBeginHandler_0;

		// Token: 0x040013FE RID: 5118
		private static readonly IntPtr NativeMethodInfoPtr_add_CanProcessInput_Public_add_Void_CameraCanProcessInputHandler_0;

		// Token: 0x040013FF RID: 5119
		private static readonly IntPtr NativeMethodInfoPtr_remove_CanProcessInput_Public_rem_Void_CameraCanProcessInputHandler_0;

		// Token: 0x04001400 RID: 5120
		private static readonly IntPtr NativeMethodInfoPtr_add_CanUseScrollWheel_Public_add_Void_CameraCanUseScrollWheelHandler_0;

		// Token: 0x04001401 RID: 5121
		private static readonly IntPtr NativeMethodInfoPtr_remove_CanUseScrollWheel_Public_rem_Void_CameraCanUseScrollWheelHandler_0;

		// Token: 0x04001402 RID: 5122
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001403 RID: 5123
		private static readonly IntPtr NativeMethodInfoPtr_IsViewportHoveredByDevice_Public_Boolean_0;

		// Token: 0x04001404 RID: 5124
		private static readonly IntPtr NativeMethodInfoPtr_SetTargetCamera_Public_Void_Camera_0;

		// Token: 0x04001405 RID: 5125
		private static readonly IntPtr NativeMethodInfoPtr_SetFieldOfView_Public_Void_Single_0;

		// Token: 0x04001406 RID: 5126
		private static readonly IntPtr NativeMethodInfoPtr_SetObjectVisibilityDirty_Public_Void_0;

		// Token: 0x04001407 RID: 5127
		private static readonly IntPtr NativeMethodInfoPtr_GetVisibleObjects_Public_Void_List_1_GameObject_0;

		// Token: 0x04001408 RID: 5128
		private static readonly IntPtr NativeMethodInfoPtr_PerformRotationSwitch_Public_Void_Quaternion_0;

		// Token: 0x04001409 RID: 5129
		private static readonly IntPtr NativeMethodInfoPtr_PerformProjectionSwitch_Public_Void_0;

		// Token: 0x0400140A RID: 5130
		private static readonly IntPtr NativeMethodInfoPtr_Focus_Public_Void_AABB_0;

		// Token: 0x0400140B RID: 5131
		private static readonly IntPtr NativeMethodInfoPtr_Update_SystemCall_Public_Void_0;

		// Token: 0x0400140C RID: 5132
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400140D RID: 5133
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400140E RID: 5134
		private static readonly IntPtr NativeMethodInfoPtr_HandleMouseAndKeyboardInput_Private_Void_0;

		// Token: 0x0400140F RID: 5135
		private static readonly IntPtr NativeMethodInfoPtr_CanUseMouseScrollWheel_Private_Boolean_0;

		// Token: 0x04001410 RID: 5136
		private static readonly IntPtr NativeMethodInfoPtr_CanCameraProcessInput_Private_Boolean_0;

		// Token: 0x04001411 RID: 5137
		private static readonly IntPtr NativeMethodInfoPtr_Zoom_Private_Void_Single_0;

		// Token: 0x04001412 RID: 5138
		private static readonly IntPtr NativeMethodInfoPtr_GetFocusPoint_Private_Vector3_0;

		// Token: 0x04001413 RID: 5139
		private static readonly IntPtr NativeMethodInfoPtr_CalculateScrollZoomAmount_Private_Single_Single_0;

		// Token: 0x04001414 RID: 5140
		private static readonly IntPtr NativeMethodInfoPtr_Pan_Private_Void_Vector2_0;

		// Token: 0x04001415 RID: 5141
		private static readonly IntPtr NativeMethodInfoPtr_LookAround_Public_Void_Single_Single_0;

		// Token: 0x04001416 RID: 5142
		private static readonly IntPtr NativeMethodInfoPtr_Orbit_Private_Void_Single_Single_0;

		// Token: 0x04001417 RID: 5143
		private static readonly IntPtr NativeMethodInfoPtr_PerformInstantFocus_Private_Void_Data_0;

		// Token: 0x04001418 RID: 5144
		private static readonly IntPtr NativeMethodInfoPtr_PerformInstantProjectionSwitch_Private_Void_0;

		// Token: 0x04001419 RID: 5145
		private static readonly IntPtr NativeMethodInfoPtr_CalculateLookAroundRotation_Private_Vector2_Single_Single_0;

		// Token: 0x0400141A RID: 5146
		private static readonly IntPtr NativeMethodInfoPtr_CalculateOrbitRotation_Private_Vector2_Single_Single_0;

		// Token: 0x0400141B RID: 5147
		private static readonly IntPtr NativeMethodInfoPtr_CalculatePanAmount_Private_Vector2_Single_Single_0;

		// Token: 0x0400141C RID: 5148
		private static readonly IntPtr NativeMethodInfoPtr_StopCamTransform_Private_Void_0;

		// Token: 0x0400141D RID: 5149
		private static readonly IntPtr NativeMethodInfoPtr_StopFocus_Private_Void_0;

		// Token: 0x0400141E RID: 5150
		private static readonly IntPtr NativeMethodInfoPtr_SetFocusPoint_Private_Void_Vector3_0;

		// Token: 0x0400141F RID: 5151
		private static readonly IntPtr NativeMethodInfoPtr_AdjustOrthoSizeForFocusPt_Private_Void_0;

		// Token: 0x04001420 RID: 5152
		private static readonly IntPtr NativeMethodInfoPtr_DoSmoothPan_Private_IEnumerator_Single_Single_0;

		// Token: 0x04001421 RID: 5153
		private static readonly IntPtr NativeMethodInfoPtr_DoSmoothLookAround_Private_IEnumerator_Single_Single_0;

		// Token: 0x04001422 RID: 5154
		private static readonly IntPtr NativeMethodInfoPtr_DoSmoothOrbit_Private_IEnumerator_Single_Single_0;

		// Token: 0x04001423 RID: 5155
		private static readonly IntPtr NativeMethodInfoPtr_DoSmoothZoom_Private_IEnumerator_Single_0;

		// Token: 0x04001424 RID: 5156
		private static readonly IntPtr NativeMethodInfoPtr_DoConstantRotationSwitch_Private_IEnumerator_Quaternion_0;

		// Token: 0x04001425 RID: 5157
		private static readonly IntPtr NativeMethodInfoPtr_DoSmoothRotationSwitch_Private_IEnumerator_Quaternion_0;

		// Token: 0x04001426 RID: 5158
		private static readonly IntPtr NativeMethodInfoPtr_DoConstantFocus_Private_IEnumerator_Data_0;

		// Token: 0x04001427 RID: 5159
		private static readonly IntPtr NativeMethodInfoPtr_DoSmoothFocus_Private_IEnumerator_Data_0;

		// Token: 0x04001428 RID: 5160
		private static readonly IntPtr NativeMethodInfoPtr_OnPrjSwitchTransitionBegin_Private_Void_Type_0;

		// Token: 0x04001429 RID: 5161
		private static readonly IntPtr NativeMethodInfoPtr_OnPrjSwitchTransitionUpate_Private_Void_Type_0;

		// Token: 0x0400142A RID: 5162
		private static readonly IntPtr NativeMethodInfoPtr_OnPrjSwitchTransitionEnd_Private_Void_Type_0;

		// Token: 0x02000381 RID: 897
		public enum MoveDirection
		{
			// Token: 0x040039D5 RID: 14805
			Left,
			// Token: 0x040039D6 RID: 14806
			Right,
			// Token: 0x040039D7 RID: 14807
			Up,
			// Token: 0x040039D8 RID: 14808
			Down,
			// Token: 0x040039D9 RID: 14809
			Forward,
			// Token: 0x040039DA RID: 14810
			Backwards
		}

		// Token: 0x02000382 RID: 898
		[ObfuscatedName("RLD.RTFocusCamera+<DoConstantFocus>d__134")]
		public sealed class _DoConstantFocus_d__134 : global::Il2CppSystem.Object
		{
			// Token: 0x06004A68 RID: 19048 RVA: 0x001478F4 File Offset: 0x00145AF4
			// Note: this type is marked as 'beforefieldinit'.
			static _DoConstantFocus_d__134()
			{
				Il2CppClassPointerStore<RTFocusCamera._DoConstantFocus_d__134>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, "<DoConstantFocus>d__134");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTFocusCamera._DoConstantFocus_d__134>.NativeClassPtr);
				RTFocusCamera._DoConstantFocus_d__134.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera._DoConstantFocus_d__134>.NativeClassPtr, "<>1__state");
				RTFocusCamera._DoConstantFocus_d__134.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera._DoConstantFocus_d__134>.NativeClassPtr, "<>2__current");
				RTFocusCamera._DoConstantFocus_d__134.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera._DoConstantFocus_d__134>.NativeClassPtr, "<>4__this");
				RTFocusCamera._DoConstantFocus_d__134.NativeFieldInfoPtr_focusData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera._DoConstantFocus_d__134>.NativeClassPtr, "focusData");
				RTFocusCamera._DoConstantFocus_d__134.NativeFieldInfoPtr__targetOrthoSize_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera._DoConstantFocus_d__134>.NativeClassPtr, "<targetOrthoSize>5__2");
				RTFocusCamera._DoConstantFocus_d__134.NativeFieldInfoPtr__camMoveDir_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera._DoConstantFocus_d__134>.NativeClassPtr, "<camMoveDir>5__3");
				RTFocusCamera._DoConstantFocus_d__134.NativeFieldInfoPtr__distanceToTravel_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera._DoConstantFocus_d__134>.NativeClassPtr, "<distanceToTravel>5__4");
				RTFocusCamera._DoConstantFocus_d__134.NativeFieldInfoPtr__initialCamOrthoSize_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera._DoConstantFocus_d__134>.NativeClassPtr, "<initialCamOrthoSize>5__5");
				RTFocusCamera._DoConstantFocus_d__134.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera._DoConstantFocus_d__134>.NativeClassPtr, 100667197);
				RTFocusCamera._DoConstantFocus_d__134.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera._DoConstantFocus_d__134>.NativeClassPtr, 100667199);
				RTFocusCamera._DoConstantFocus_d__134.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera._DoConstantFocus_d__134>.NativeClassPtr, 100667194);
				RTFocusCamera._DoConstantFocus_d__134.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera._DoConstantFocus_d__134>.NativeClassPtr, 100667195);
				RTFocusCamera._DoConstantFocus_d__134.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera._DoConstantFocus_d__134>.NativeClassPtr, 100667196);
				RTFocusCamera._DoConstantFocus_d__134.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera._DoConstantFocus_d__134>.NativeClassPtr, 100667198);
			}

			// Token: 0x1700192B RID: 6443
			// (get) Token: 0x06004A69 RID: 19049 RVA: 0x00147A38 File Offset: 0x00145C38
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera._DoConstantFocus_d__134.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x1700192C RID: 6444
			// (get) Token: 0x06004A6A RID: 19050 RVA: 0x00147A78 File Offset: 0x00145C78
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera._DoConstantFocus_d__134.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004A6B RID: 19051 RVA: 0x00147AB8 File Offset: 0x00145CB8
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 10168, RefRangeEnd = 10216, XrefRangeStart = 10168, XrefRangeEnd = 10216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DoConstantFocus_d__134(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTFocusCamera._DoConstantFocus_d__134>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera._DoConstantFocus_d__134.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004A6C RID: 19052 RVA: 0x00147B00 File Offset: 0x00145D00
			[CallerCount(7535)]
			[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera._DoConstantFocus_d__134.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004A6D RID: 19053 RVA: 0x00147B34 File Offset: 0x00145D34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75067, XrefRangeEnd = 75094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera._DoConstantFocus_d__134.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004A6E RID: 19054 RVA: 0x00147B70 File Offset: 0x00145D70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75094, XrefRangeEnd = 75099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera._DoConstantFocus_d__134.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004A6F RID: 19055 RVA: 0x0001BBA6 File Offset: 0x00019DA6
			public _DoConstantFocus_d__134(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001923 RID: 6435
			// (get) Token: 0x06004A70 RID: 19056 RVA: 0x00147BA4 File Offset: 0x00145DA4
			// (set) Token: 0x06004A71 RID: 19057 RVA: 0x0001BBAF File Offset: 0x00019DAF
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoConstantFocus_d__134.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoConstantFocus_d__134.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001924 RID: 6436
			// (get) Token: 0x06004A72 RID: 19058 RVA: 0x00147BCC File Offset: 0x00145DCC
			// (set) Token: 0x06004A73 RID: 19059 RVA: 0x0001BBCA File Offset: 0x00019DCA
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoConstantFocus_d__134.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoConstantFocus_d__134.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001925 RID: 6437
			// (get) Token: 0x06004A74 RID: 19060 RVA: 0x00147BFC File Offset: 0x00145DFC
			// (set) Token: 0x06004A75 RID: 19061 RVA: 0x0001BBE9 File Offset: 0x00019DE9
			public unsafe RTFocusCamera __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoConstantFocus_d__134.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTFocusCamera>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoConstantFocus_d__134.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001926 RID: 6438
			// (get) Token: 0x06004A76 RID: 19062 RVA: 0x00147C2C File Offset: 0x00145E2C
			// (set) Token: 0x06004A77 RID: 19063 RVA: 0x0001BC08 File Offset: 0x00019E08
			public unsafe CameraFocus.Data focusData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoConstantFocus_d__134.NativeFieldInfoPtr_focusData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CameraFocus.Data>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoConstantFocus_d__134.NativeFieldInfoPtr_focusData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001927 RID: 6439
			// (get) Token: 0x06004A78 RID: 19064 RVA: 0x00147C5C File Offset: 0x00145E5C
			// (set) Token: 0x06004A79 RID: 19065 RVA: 0x0001BC27 File Offset: 0x00019E27
			public unsafe float _targetOrthoSize_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoConstantFocus_d__134.NativeFieldInfoPtr__targetOrthoSize_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoConstantFocus_d__134.NativeFieldInfoPtr__targetOrthoSize_5__2)) = value;
				}
			}

			// Token: 0x17001928 RID: 6440
			// (get) Token: 0x06004A7A RID: 19066 RVA: 0x00147C84 File Offset: 0x00145E84
			// (set) Token: 0x06004A7B RID: 19067 RVA: 0x0001BC42 File Offset: 0x00019E42
			public unsafe Vector3 _camMoveDir_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoConstantFocus_d__134.NativeFieldInfoPtr__camMoveDir_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoConstantFocus_d__134.NativeFieldInfoPtr__camMoveDir_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001929 RID: 6441
			// (get) Token: 0x06004A7C RID: 19068 RVA: 0x00147CB4 File Offset: 0x00145EB4
			// (set) Token: 0x06004A7D RID: 19069 RVA: 0x0001BC61 File Offset: 0x00019E61
			public unsafe float _distanceToTravel_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoConstantFocus_d__134.NativeFieldInfoPtr__distanceToTravel_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoConstantFocus_d__134.NativeFieldInfoPtr__distanceToTravel_5__4)) = value;
				}
			}

			// Token: 0x1700192A RID: 6442
			// (get) Token: 0x06004A7E RID: 19070 RVA: 0x00147CDC File Offset: 0x00145EDC
			// (set) Token: 0x06004A7F RID: 19071 RVA: 0x0001BC7C File Offset: 0x00019E7C
			public unsafe float _initialCamOrthoSize_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoConstantFocus_d__134.NativeFieldInfoPtr__initialCamOrthoSize_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoConstantFocus_d__134.NativeFieldInfoPtr__initialCamOrthoSize_5__5)) = value;
				}
			}

			// Token: 0x040039DB RID: 14811
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040039DC RID: 14812
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040039DD RID: 14813
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040039DE RID: 14814
			private static readonly IntPtr NativeFieldInfoPtr_focusData;

			// Token: 0x040039DF RID: 14815
			private static readonly IntPtr NativeFieldInfoPtr__targetOrthoSize_5__2;

			// Token: 0x040039E0 RID: 14816
			private static readonly IntPtr NativeFieldInfoPtr__camMoveDir_5__3;

			// Token: 0x040039E1 RID: 14817
			private static readonly IntPtr NativeFieldInfoPtr__distanceToTravel_5__4;

			// Token: 0x040039E2 RID: 14818
			private static readonly IntPtr NativeFieldInfoPtr__initialCamOrthoSize_5__5;

			// Token: 0x040039E3 RID: 14819
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040039E4 RID: 14820
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040039E5 RID: 14821
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040039E6 RID: 14822
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040039E7 RID: 14823
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040039E8 RID: 14824
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}

		// Token: 0x02000383 RID: 899
		[ObfuscatedName("RLD.RTFocusCamera+<DoConstantRotationSwitch>d__132")]
		public sealed class _DoConstantRotationSwitch_d__132 : global::Il2CppSystem.Object
		{
			// Token: 0x06004A80 RID: 19072 RVA: 0x00147D04 File Offset: 0x00145F04
			// Note: this type is marked as 'beforefieldinit'.
			static _DoConstantRotationSwitch_d__132()
			{
				Il2CppClassPointerStore<RTFocusCamera._DoConstantRotationSwitch_d__132>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, "<DoConstantRotationSwitch>d__132");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTFocusCamera._DoConstantRotationSwitch_d__132>.NativeClassPtr);
				RTFocusCamera._DoConstantRotationSwitch_d__132.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera._DoConstantRotationSwitch_d__132>.NativeClassPtr, "<>1__state");
				RTFocusCamera._DoConstantRotationSwitch_d__132.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera._DoConstantRotationSwitch_d__132>.NativeClassPtr, "<>2__current");
				RTFocusCamera._DoConstantRotationSwitch_d__132.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera._DoConstantRotationSwitch_d__132>.NativeClassPtr, "<>4__this");
				RTFocusCamera._DoConstantRotationSwitch_d__132.NativeFieldInfoPtr_targetRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera._DoConstantRotationSwitch_d__132>.NativeClassPtr, "targetRotation");
				RTFocusCamera._DoConstantRotationSwitch_d__132.NativeFieldInfoPtr__sourceRotation_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera._DoConstantRotationSwitch_d__132>.NativeClassPtr, "<sourceRotation>5__2");
				RTFocusCamera._DoConstantRotationSwitch_d__132.NativeFieldInfoPtr__elapsedTime_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera._DoConstantRotationSwitch_d__132>.NativeClassPtr, "<elapsedTime>5__3");
				RTFocusCamera._DoConstantRotationSwitch_d__132.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera._DoConstantRotationSwitch_d__132>.NativeClassPtr, 100667203);
				RTFocusCamera._DoConstantRotationSwitch_d__132.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera._DoConstantRotationSwitch_d__132>.NativeClassPtr, 100667205);
				RTFocusCamera._DoConstantRotationSwitch_d__132.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera._DoConstantRotationSwitch_d__132>.NativeClassPtr, 100667200);
				RTFocusCamera._DoConstantRotationSwitch_d__132.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera._DoConstantRotationSwitch_d__132>.NativeClassPtr, 100667201);
				RTFocusCamera._DoConstantRotationSwitch_d__132.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera._DoConstantRotationSwitch_d__132>.NativeClassPtr, 100667202);
				RTFocusCamera._DoConstantRotationSwitch_d__132.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera._DoConstantRotationSwitch_d__132>.NativeClassPtr, 100667204);
			}

			// Token: 0x17001933 RID: 6451
			// (get) Token: 0x06004A81 RID: 19073 RVA: 0x00147E20 File Offset: 0x00146020
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera._DoConstantRotationSwitch_d__132.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001934 RID: 6452
			// (get) Token: 0x06004A82 RID: 19074 RVA: 0x00147E60 File Offset: 0x00146060
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera._DoConstantRotationSwitch_d__132.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004A83 RID: 19075 RVA: 0x00147EA0 File Offset: 0x001460A0
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 10168, RefRangeEnd = 10216, XrefRangeStart = 10168, XrefRangeEnd = 10216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DoConstantRotationSwitch_d__132(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTFocusCamera._DoConstantRotationSwitch_d__132>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera._DoConstantRotationSwitch_d__132.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004A84 RID: 19076 RVA: 0x00147EE8 File Offset: 0x001460E8
			[CallerCount(7535)]
			[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera._DoConstantRotationSwitch_d__132.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004A85 RID: 19077 RVA: 0x00147F1C File Offset: 0x0014611C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75099, XrefRangeEnd = 75108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera._DoConstantRotationSwitch_d__132.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004A86 RID: 19078 RVA: 0x00147F58 File Offset: 0x00146158
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75108, XrefRangeEnd = 75113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera._DoConstantRotationSwitch_d__132.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004A87 RID: 19079 RVA: 0x0001BC97 File Offset: 0x00019E97
			public _DoConstantRotationSwitch_d__132(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700192D RID: 6445
			// (get) Token: 0x06004A88 RID: 19080 RVA: 0x00147F8C File Offset: 0x0014618C
			// (set) Token: 0x06004A89 RID: 19081 RVA: 0x0001BCA0 File Offset: 0x00019EA0
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoConstantRotationSwitch_d__132.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoConstantRotationSwitch_d__132.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700192E RID: 6446
			// (get) Token: 0x06004A8A RID: 19082 RVA: 0x00147FB4 File Offset: 0x001461B4
			// (set) Token: 0x06004A8B RID: 19083 RVA: 0x0001BCBB File Offset: 0x00019EBB
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoConstantRotationSwitch_d__132.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoConstantRotationSwitch_d__132.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700192F RID: 6447
			// (get) Token: 0x06004A8C RID: 19084 RVA: 0x00147FE4 File Offset: 0x001461E4
			// (set) Token: 0x06004A8D RID: 19085 RVA: 0x0001BCDA File Offset: 0x00019EDA
			public unsafe RTFocusCamera __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoConstantRotationSwitch_d__132.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTFocusCamera>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoConstantRotationSwitch_d__132.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001930 RID: 6448
			// (get) Token: 0x06004A8E RID: 19086 RVA: 0x00148014 File Offset: 0x00146214
			// (set) Token: 0x06004A8F RID: 19087 RVA: 0x0001BCF9 File Offset: 0x00019EF9
			public unsafe Quaternion targetRotation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoConstantRotationSwitch_d__132.NativeFieldInfoPtr_targetRotation);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoConstantRotationSwitch_d__132.NativeFieldInfoPtr_targetRotation), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001931 RID: 6449
			// (get) Token: 0x06004A90 RID: 19088 RVA: 0x00148044 File Offset: 0x00146244
			// (set) Token: 0x06004A91 RID: 19089 RVA: 0x0001BD18 File Offset: 0x00019F18
			public unsafe Quaternion _sourceRotation_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoConstantRotationSwitch_d__132.NativeFieldInfoPtr__sourceRotation_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoConstantRotationSwitch_d__132.NativeFieldInfoPtr__sourceRotation_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001932 RID: 6450
			// (get) Token: 0x06004A92 RID: 19090 RVA: 0x00148074 File Offset: 0x00146274
			// (set) Token: 0x06004A93 RID: 19091 RVA: 0x0001BD37 File Offset: 0x00019F37
			public unsafe float _elapsedTime_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoConstantRotationSwitch_d__132.NativeFieldInfoPtr__elapsedTime_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoConstantRotationSwitch_d__132.NativeFieldInfoPtr__elapsedTime_5__3)) = value;
				}
			}

			// Token: 0x040039E9 RID: 14825
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040039EA RID: 14826
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040039EB RID: 14827
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040039EC RID: 14828
			private static readonly IntPtr NativeFieldInfoPtr_targetRotation;

			// Token: 0x040039ED RID: 14829
			private static readonly IntPtr NativeFieldInfoPtr__sourceRotation_5__2;

			// Token: 0x040039EE RID: 14830
			private static readonly IntPtr NativeFieldInfoPtr__elapsedTime_5__3;

			// Token: 0x040039EF RID: 14831
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040039F0 RID: 14832
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040039F1 RID: 14833
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040039F2 RID: 14834
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040039F3 RID: 14835
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040039F4 RID: 14836
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}

		// Token: 0x02000384 RID: 900
		[ObfuscatedName("RLD.RTFocusCamera+<DoSmoothFocus>d__135")]
		public sealed class _DoSmoothFocus_d__135 : global::Il2CppSystem.Object
		{
			// Token: 0x06004A94 RID: 19092 RVA: 0x0014809C File Offset: 0x0014629C
			// Note: this type is marked as 'beforefieldinit'.
			static _DoSmoothFocus_d__135()
			{
				Il2CppClassPointerStore<RTFocusCamera._DoSmoothFocus_d__135>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, "<DoSmoothFocus>d__135");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTFocusCamera._DoSmoothFocus_d__135>.NativeClassPtr);
				RTFocusCamera._DoSmoothFocus_d__135.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera._DoSmoothFocus_d__135>.NativeClassPtr, "<>1__state");
				RTFocusCamera._DoSmoothFocus_d__135.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera._DoSmoothFocus_d__135>.NativeClassPtr, "<>2__current");
				RTFocusCamera._DoSmoothFocus_d__135.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera._DoSmoothFocus_d__135>.NativeClassPtr, "<>4__this");
				RTFocusCamera._DoSmoothFocus_d__135.NativeFieldInfoPtr_focusData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera._DoSmoothFocus_d__135>.NativeClassPtr, "focusData");
				RTFocusCamera._DoSmoothFocus_d__135.NativeFieldInfoPtr__targetOrthoSize_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera._DoSmoothFocus_d__135>.NativeClassPtr, "<targetOrthoSize>5__2");
				RTFocusCamera._DoSmoothFocus_d__135.NativeFieldInfoPtr__camMoveDir_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera._DoSmoothFocus_d__135>.NativeClassPtr, "<camMoveDir>5__3");
				RTFocusCamera._DoSmoothFocus_d__135.NativeFieldInfoPtr__elapsedTime_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera._DoSmoothFocus_d__135>.NativeClassPtr, "<elapsedTime>5__4");
				RTFocusCamera._DoSmoothFocus_d__135.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera._DoSmoothFocus_d__135>.NativeClassPtr, 100667209);
				RTFocusCamera._DoSmoothFocus_d__135.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera._DoSmoothFocus_d__135>.NativeClassPtr, 100667211);
				RTFocusCamera._DoSmoothFocus_d__135.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera._DoSmoothFocus_d__135>.NativeClassPtr, 100667206);
				RTFocusCamera._DoSmoothFocus_d__135.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera._DoSmoothFocus_d__135>.NativeClassPtr, 100667207);
				RTFocusCamera._DoSmoothFocus_d__135.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera._DoSmoothFocus_d__135>.NativeClassPtr, 100667208);
				RTFocusCamera._DoSmoothFocus_d__135.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera._DoSmoothFocus_d__135>.NativeClassPtr, 100667210);
			}

			// Token: 0x1700193C RID: 6460
			// (get) Token: 0x06004A95 RID: 19093 RVA: 0x001481CC File Offset: 0x001463CC
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera._DoSmoothFocus_d__135.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x1700193D RID: 6461
			// (get) Token: 0x06004A96 RID: 19094 RVA: 0x0014820C File Offset: 0x0014640C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera._DoSmoothFocus_d__135.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004A97 RID: 19095 RVA: 0x0014824C File Offset: 0x0014644C
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 10168, RefRangeEnd = 10216, XrefRangeStart = 10168, XrefRangeEnd = 10216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DoSmoothFocus_d__135(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTFocusCamera._DoSmoothFocus_d__135>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera._DoSmoothFocus_d__135.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004A98 RID: 19096 RVA: 0x00148294 File Offset: 0x00146494
			[CallerCount(7535)]
			[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera._DoSmoothFocus_d__135.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004A99 RID: 19097 RVA: 0x001482C8 File Offset: 0x001464C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75113, XrefRangeEnd = 75139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera._DoSmoothFocus_d__135.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004A9A RID: 19098 RVA: 0x00148304 File Offset: 0x00146504
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75139, XrefRangeEnd = 75144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera._DoSmoothFocus_d__135.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004A9B RID: 19099 RVA: 0x0001BD52 File Offset: 0x00019F52
			public _DoSmoothFocus_d__135(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001935 RID: 6453
			// (get) Token: 0x06004A9C RID: 19100 RVA: 0x00148338 File Offset: 0x00146538
			// (set) Token: 0x06004A9D RID: 19101 RVA: 0x0001BD5B File Offset: 0x00019F5B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoSmoothFocus_d__135.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoSmoothFocus_d__135.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001936 RID: 6454
			// (get) Token: 0x06004A9E RID: 19102 RVA: 0x00148360 File Offset: 0x00146560
			// (set) Token: 0x06004A9F RID: 19103 RVA: 0x0001BD76 File Offset: 0x00019F76
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoSmoothFocus_d__135.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoSmoothFocus_d__135.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001937 RID: 6455
			// (get) Token: 0x06004AA0 RID: 19104 RVA: 0x00148390 File Offset: 0x00146590
			// (set) Token: 0x06004AA1 RID: 19105 RVA: 0x0001BD95 File Offset: 0x00019F95
			public unsafe RTFocusCamera __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoSmoothFocus_d__135.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTFocusCamera>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoSmoothFocus_d__135.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001938 RID: 6456
			// (get) Token: 0x06004AA2 RID: 19106 RVA: 0x001483C0 File Offset: 0x001465C0
			// (set) Token: 0x06004AA3 RID: 19107 RVA: 0x0001BDB4 File Offset: 0x00019FB4
			public unsafe CameraFocus.Data focusData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoSmoothFocus_d__135.NativeFieldInfoPtr_focusData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CameraFocus.Data>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoSmoothFocus_d__135.NativeFieldInfoPtr_focusData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001939 RID: 6457
			// (get) Token: 0x06004AA4 RID: 19108 RVA: 0x001483F0 File Offset: 0x001465F0
			// (set) Token: 0x06004AA5 RID: 19109 RVA: 0x0001BDD3 File Offset: 0x00019FD3
			public unsafe float _targetOrthoSize_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoSmoothFocus_d__135.NativeFieldInfoPtr__targetOrthoSize_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoSmoothFocus_d__135.NativeFieldInfoPtr__targetOrthoSize_5__2)) = value;
				}
			}

			// Token: 0x1700193A RID: 6458
			// (get) Token: 0x06004AA6 RID: 19110 RVA: 0x00148418 File Offset: 0x00146618
			// (set) Token: 0x06004AA7 RID: 19111 RVA: 0x0001BDEE File Offset: 0x00019FEE
			public unsafe Vector3 _camMoveDir_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoSmoothFocus_d__135.NativeFieldInfoPtr__camMoveDir_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoSmoothFocus_d__135.NativeFieldInfoPtr__camMoveDir_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700193B RID: 6459
			// (get) Token: 0x06004AA8 RID: 19112 RVA: 0x00148448 File Offset: 0x00146648
			// (set) Token: 0x06004AA9 RID: 19113 RVA: 0x0001BE0D File Offset: 0x0001A00D
			public unsafe float _elapsedTime_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoSmoothFocus_d__135.NativeFieldInfoPtr__elapsedTime_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoSmoothFocus_d__135.NativeFieldInfoPtr__elapsedTime_5__4)) = value;
				}
			}

			// Token: 0x040039F5 RID: 14837
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040039F6 RID: 14838
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040039F7 RID: 14839
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040039F8 RID: 14840
			private static readonly IntPtr NativeFieldInfoPtr_focusData;

			// Token: 0x040039F9 RID: 14841
			private static readonly IntPtr NativeFieldInfoPtr__targetOrthoSize_5__2;

			// Token: 0x040039FA RID: 14842
			private static readonly IntPtr NativeFieldInfoPtr__camMoveDir_5__3;

			// Token: 0x040039FB RID: 14843
			private static readonly IntPtr NativeFieldInfoPtr__elapsedTime_5__4;

			// Token: 0x040039FC RID: 14844
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040039FD RID: 14845
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040039FE RID: 14846
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040039FF RID: 14847
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003A00 RID: 14848
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003A01 RID: 14849
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}

		// Token: 0x02000385 RID: 901
		[ObfuscatedName("RLD.RTFocusCamera+<DoSmoothLookAround>d__129")]
		public sealed class _DoSmoothLookAround_d__129 : global::Il2CppSystem.Object
		{
			// Token: 0x06004AAA RID: 19114 RVA: 0x00148470 File Offset: 0x00146670
			// Note: this type is marked as 'beforefieldinit'.
			static _DoSmoothLookAround_d__129()
			{
				Il2CppClassPointerStore<RTFocusCamera._DoSmoothLookAround_d__129>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, "<DoSmoothLookAround>d__129");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTFocusCamera._DoSmoothLookAround_d__129>.NativeClassPtr);
				RTFocusCamera._DoSmoothLookAround_d__129.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera._DoSmoothLookAround_d__129>.NativeClassPtr, "<>1__state");
				RTFocusCamera._DoSmoothLookAround_d__129.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera._DoSmoothLookAround_d__129>.NativeClassPtr, "<>2__current");
				RTFocusCamera._DoSmoothLookAround_d__129.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera._DoSmoothLookAround_d__129>.NativeClassPtr, "<>4__this");
				RTFocusCamera._DoSmoothLookAround_d__129.NativeFieldInfoPtr_deviceAxisX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera._DoSmoothLookAround_d__129>.NativeClassPtr, "deviceAxisX");
				RTFocusCamera._DoSmoothLookAround_d__129.NativeFieldInfoPtr_deviceAxisY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera._DoSmoothLookAround_d__129>.NativeClassPtr, "deviceAxisY");
				RTFocusCamera._DoSmoothLookAround_d__129.NativeFieldInfoPtr__rotationAmount_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera._DoSmoothLookAround_d__129>.NativeClassPtr, "<rotationAmount>5__2");
				RTFocusCamera._DoSmoothLookAround_d__129.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera._DoSmoothLookAround_d__129>.NativeClassPtr, 100667215);
				RTFocusCamera._DoSmoothLookAround_d__129.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera._DoSmoothLookAround_d__129>.NativeClassPtr, 100667217);
				RTFocusCamera._DoSmoothLookAround_d__129.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera._DoSmoothLookAround_d__129>.NativeClassPtr, 100667212);
				RTFocusCamera._DoSmoothLookAround_d__129.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera._DoSmoothLookAround_d__129>.NativeClassPtr, 100667213);
				RTFocusCamera._DoSmoothLookAround_d__129.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera._DoSmoothLookAround_d__129>.NativeClassPtr, 100667214);
				RTFocusCamera._DoSmoothLookAround_d__129.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera._DoSmoothLookAround_d__129>.NativeClassPtr, 100667216);
			}

			// Token: 0x17001944 RID: 6468
			// (get) Token: 0x06004AAB RID: 19115 RVA: 0x0014858C File Offset: 0x0014678C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera._DoSmoothLookAround_d__129.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001945 RID: 6469
			// (get) Token: 0x06004AAC RID: 19116 RVA: 0x001485CC File Offset: 0x001467CC
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera._DoSmoothLookAround_d__129.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004AAD RID: 19117 RVA: 0x0014860C File Offset: 0x0014680C
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 10168, RefRangeEnd = 10216, XrefRangeStart = 10168, XrefRangeEnd = 10216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DoSmoothLookAround_d__129(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTFocusCamera._DoSmoothLookAround_d__129>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera._DoSmoothLookAround_d__129.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004AAE RID: 19118 RVA: 0x00148654 File Offset: 0x00146854
			[CallerCount(7535)]
			[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera._DoSmoothLookAround_d__129.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004AAF RID: 19119 RVA: 0x00148688 File Offset: 0x00146888
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75144, XrefRangeEnd = 75154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera._DoSmoothLookAround_d__129.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004AB0 RID: 19120 RVA: 0x001486C4 File Offset: 0x001468C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75154, XrefRangeEnd = 75159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera._DoSmoothLookAround_d__129.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004AB1 RID: 19121 RVA: 0x0001BE28 File Offset: 0x0001A028
			public _DoSmoothLookAround_d__129(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700193E RID: 6462
			// (get) Token: 0x06004AB2 RID: 19122 RVA: 0x001486F8 File Offset: 0x001468F8
			// (set) Token: 0x06004AB3 RID: 19123 RVA: 0x0001BE31 File Offset: 0x0001A031
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoSmoothLookAround_d__129.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoSmoothLookAround_d__129.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700193F RID: 6463
			// (get) Token: 0x06004AB4 RID: 19124 RVA: 0x00148720 File Offset: 0x00146920
			// (set) Token: 0x06004AB5 RID: 19125 RVA: 0x0001BE4C File Offset: 0x0001A04C
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoSmoothLookAround_d__129.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoSmoothLookAround_d__129.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001940 RID: 6464
			// (get) Token: 0x06004AB6 RID: 19126 RVA: 0x00148750 File Offset: 0x00146950
			// (set) Token: 0x06004AB7 RID: 19127 RVA: 0x0001BE6B File Offset: 0x0001A06B
			public unsafe RTFocusCamera __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoSmoothLookAround_d__129.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTFocusCamera>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoSmoothLookAround_d__129.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001941 RID: 6465
			// (get) Token: 0x06004AB8 RID: 19128 RVA: 0x00148780 File Offset: 0x00146980
			// (set) Token: 0x06004AB9 RID: 19129 RVA: 0x0001BE8A File Offset: 0x0001A08A
			public unsafe float deviceAxisX
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoSmoothLookAround_d__129.NativeFieldInfoPtr_deviceAxisX);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoSmoothLookAround_d__129.NativeFieldInfoPtr_deviceAxisX)) = value;
				}
			}

			// Token: 0x17001942 RID: 6466
			// (get) Token: 0x06004ABA RID: 19130 RVA: 0x001487A8 File Offset: 0x001469A8
			// (set) Token: 0x06004ABB RID: 19131 RVA: 0x0001BEA5 File Offset: 0x0001A0A5
			public unsafe float deviceAxisY
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoSmoothLookAround_d__129.NativeFieldInfoPtr_deviceAxisY);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoSmoothLookAround_d__129.NativeFieldInfoPtr_deviceAxisY)) = value;
				}
			}

			// Token: 0x17001943 RID: 6467
			// (get) Token: 0x06004ABC RID: 19132 RVA: 0x001487D0 File Offset: 0x001469D0
			// (set) Token: 0x06004ABD RID: 19133 RVA: 0x0001BEC0 File Offset: 0x0001A0C0
			public unsafe Vector2 _rotationAmount_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoSmoothLookAround_d__129.NativeFieldInfoPtr__rotationAmount_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoSmoothLookAround_d__129.NativeFieldInfoPtr__rotationAmount_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003A02 RID: 14850
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003A03 RID: 14851
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003A04 RID: 14852
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003A05 RID: 14853
			private static readonly IntPtr NativeFieldInfoPtr_deviceAxisX;

			// Token: 0x04003A06 RID: 14854
			private static readonly IntPtr NativeFieldInfoPtr_deviceAxisY;

			// Token: 0x04003A07 RID: 14855
			private static readonly IntPtr NativeFieldInfoPtr__rotationAmount_5__2;

			// Token: 0x04003A08 RID: 14856
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003A09 RID: 14857
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003A0A RID: 14858
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003A0B RID: 14859
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003A0C RID: 14860
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003A0D RID: 14861
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}

		// Token: 0x02000386 RID: 902
		[ObfuscatedName("RLD.RTFocusCamera+<DoSmoothOrbit>d__130")]
		public sealed class _DoSmoothOrbit_d__130 : global::Il2CppSystem.Object
		{
			// Token: 0x06004ABE RID: 19134 RVA: 0x00148800 File Offset: 0x00146A00
			// Note: this type is marked as 'beforefieldinit'.
			static _DoSmoothOrbit_d__130()
			{
				Il2CppClassPointerStore<RTFocusCamera._DoSmoothOrbit_d__130>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, "<DoSmoothOrbit>d__130");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTFocusCamera._DoSmoothOrbit_d__130>.NativeClassPtr);
				RTFocusCamera._DoSmoothOrbit_d__130.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera._DoSmoothOrbit_d__130>.NativeClassPtr, "<>1__state");
				RTFocusCamera._DoSmoothOrbit_d__130.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera._DoSmoothOrbit_d__130>.NativeClassPtr, "<>2__current");
				RTFocusCamera._DoSmoothOrbit_d__130.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera._DoSmoothOrbit_d__130>.NativeClassPtr, "<>4__this");
				RTFocusCamera._DoSmoothOrbit_d__130.NativeFieldInfoPtr_deviceAxisX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera._DoSmoothOrbit_d__130>.NativeClassPtr, "deviceAxisX");
				RTFocusCamera._DoSmoothOrbit_d__130.NativeFieldInfoPtr_deviceAxisY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera._DoSmoothOrbit_d__130>.NativeClassPtr, "deviceAxisY");
				RTFocusCamera._DoSmoothOrbit_d__130.NativeFieldInfoPtr__rotationAmount_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera._DoSmoothOrbit_d__130>.NativeClassPtr, "<rotationAmount>5__2");
				RTFocusCamera._DoSmoothOrbit_d__130.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera._DoSmoothOrbit_d__130>.NativeClassPtr, 100667221);
				RTFocusCamera._DoSmoothOrbit_d__130.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera._DoSmoothOrbit_d__130>.NativeClassPtr, 100667223);
				RTFocusCamera._DoSmoothOrbit_d__130.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera._DoSmoothOrbit_d__130>.NativeClassPtr, 100667218);
				RTFocusCamera._DoSmoothOrbit_d__130.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera._DoSmoothOrbit_d__130>.NativeClassPtr, 100667219);
				RTFocusCamera._DoSmoothOrbit_d__130.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera._DoSmoothOrbit_d__130>.NativeClassPtr, 100667220);
				RTFocusCamera._DoSmoothOrbit_d__130.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera._DoSmoothOrbit_d__130>.NativeClassPtr, 100667222);
			}

			// Token: 0x1700194C RID: 6476
			// (get) Token: 0x06004ABF RID: 19135 RVA: 0x0014891C File Offset: 0x00146B1C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera._DoSmoothOrbit_d__130.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x1700194D RID: 6477
			// (get) Token: 0x06004AC0 RID: 19136 RVA: 0x0014895C File Offset: 0x00146B5C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera._DoSmoothOrbit_d__130.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004AC1 RID: 19137 RVA: 0x0014899C File Offset: 0x00146B9C
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 10168, RefRangeEnd = 10216, XrefRangeStart = 10168, XrefRangeEnd = 10216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DoSmoothOrbit_d__130(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTFocusCamera._DoSmoothOrbit_d__130>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera._DoSmoothOrbit_d__130.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004AC2 RID: 19138 RVA: 0x001489E4 File Offset: 0x00146BE4
			[CallerCount(7535)]
			[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera._DoSmoothOrbit_d__130.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004AC3 RID: 19139 RVA: 0x00148A18 File Offset: 0x00146C18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75159, XrefRangeEnd = 75169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera._DoSmoothOrbit_d__130.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004AC4 RID: 19140 RVA: 0x00148A54 File Offset: 0x00146C54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75169, XrefRangeEnd = 75174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera._DoSmoothOrbit_d__130.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004AC5 RID: 19141 RVA: 0x0001BEDF File Offset: 0x0001A0DF
			public _DoSmoothOrbit_d__130(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001946 RID: 6470
			// (get) Token: 0x06004AC6 RID: 19142 RVA: 0x00148A88 File Offset: 0x00146C88
			// (set) Token: 0x06004AC7 RID: 19143 RVA: 0x0001BEE8 File Offset: 0x0001A0E8
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoSmoothOrbit_d__130.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoSmoothOrbit_d__130.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001947 RID: 6471
			// (get) Token: 0x06004AC8 RID: 19144 RVA: 0x00148AB0 File Offset: 0x00146CB0
			// (set) Token: 0x06004AC9 RID: 19145 RVA: 0x0001BF03 File Offset: 0x0001A103
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoSmoothOrbit_d__130.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoSmoothOrbit_d__130.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001948 RID: 6472
			// (get) Token: 0x06004ACA RID: 19146 RVA: 0x00148AE0 File Offset: 0x00146CE0
			// (set) Token: 0x06004ACB RID: 19147 RVA: 0x0001BF22 File Offset: 0x0001A122
			public unsafe RTFocusCamera __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoSmoothOrbit_d__130.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTFocusCamera>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoSmoothOrbit_d__130.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001949 RID: 6473
			// (get) Token: 0x06004ACC RID: 19148 RVA: 0x00148B10 File Offset: 0x00146D10
			// (set) Token: 0x06004ACD RID: 19149 RVA: 0x0001BF41 File Offset: 0x0001A141
			public unsafe float deviceAxisX
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoSmoothOrbit_d__130.NativeFieldInfoPtr_deviceAxisX);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoSmoothOrbit_d__130.NativeFieldInfoPtr_deviceAxisX)) = value;
				}
			}

			// Token: 0x1700194A RID: 6474
			// (get) Token: 0x06004ACE RID: 19150 RVA: 0x00148B38 File Offset: 0x00146D38
			// (set) Token: 0x06004ACF RID: 19151 RVA: 0x0001BF5C File Offset: 0x0001A15C
			public unsafe float deviceAxisY
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoSmoothOrbit_d__130.NativeFieldInfoPtr_deviceAxisY);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoSmoothOrbit_d__130.NativeFieldInfoPtr_deviceAxisY)) = value;
				}
			}

			// Token: 0x1700194B RID: 6475
			// (get) Token: 0x06004AD0 RID: 19152 RVA: 0x00148B60 File Offset: 0x00146D60
			// (set) Token: 0x06004AD1 RID: 19153 RVA: 0x0001BF77 File Offset: 0x0001A177
			public unsafe Vector2 _rotationAmount_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoSmoothOrbit_d__130.NativeFieldInfoPtr__rotationAmount_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoSmoothOrbit_d__130.NativeFieldInfoPtr__rotationAmount_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003A0E RID: 14862
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003A0F RID: 14863
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003A10 RID: 14864
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003A11 RID: 14865
			private static readonly IntPtr NativeFieldInfoPtr_deviceAxisX;

			// Token: 0x04003A12 RID: 14866
			private static readonly IntPtr NativeFieldInfoPtr_deviceAxisY;

			// Token: 0x04003A13 RID: 14867
			private static readonly IntPtr NativeFieldInfoPtr__rotationAmount_5__2;

			// Token: 0x04003A14 RID: 14868
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003A15 RID: 14869
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003A16 RID: 14870
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003A17 RID: 14871
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003A18 RID: 14872
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003A19 RID: 14873
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}

		// Token: 0x02000387 RID: 903
		[ObfuscatedName("RLD.RTFocusCamera+<DoSmoothPan>d__128")]
		public sealed class _DoSmoothPan_d__128 : global::Il2CppSystem.Object
		{
			// Token: 0x06004AD2 RID: 19154 RVA: 0x00148B90 File Offset: 0x00146D90
			// Note: this type is marked as 'beforefieldinit'.
			static _DoSmoothPan_d__128()
			{
				Il2CppClassPointerStore<RTFocusCamera._DoSmoothPan_d__128>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, "<DoSmoothPan>d__128");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTFocusCamera._DoSmoothPan_d__128>.NativeClassPtr);
				RTFocusCamera._DoSmoothPan_d__128.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera._DoSmoothPan_d__128>.NativeClassPtr, "<>1__state");
				RTFocusCamera._DoSmoothPan_d__128.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera._DoSmoothPan_d__128>.NativeClassPtr, "<>2__current");
				RTFocusCamera._DoSmoothPan_d__128.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera._DoSmoothPan_d__128>.NativeClassPtr, "<>4__this");
				RTFocusCamera._DoSmoothPan_d__128.NativeFieldInfoPtr_deviceAxisX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera._DoSmoothPan_d__128>.NativeClassPtr, "deviceAxisX");
				RTFocusCamera._DoSmoothPan_d__128.NativeFieldInfoPtr_deviceAxisY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera._DoSmoothPan_d__128>.NativeClassPtr, "deviceAxisY");
				RTFocusCamera._DoSmoothPan_d__128.NativeFieldInfoPtr__panAmount_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera._DoSmoothPan_d__128>.NativeClassPtr, "<panAmount>5__2");
				RTFocusCamera._DoSmoothPan_d__128.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera._DoSmoothPan_d__128>.NativeClassPtr, 100667227);
				RTFocusCamera._DoSmoothPan_d__128.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera._DoSmoothPan_d__128>.NativeClassPtr, 100667229);
				RTFocusCamera._DoSmoothPan_d__128.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera._DoSmoothPan_d__128>.NativeClassPtr, 100667224);
				RTFocusCamera._DoSmoothPan_d__128.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera._DoSmoothPan_d__128>.NativeClassPtr, 100667225);
				RTFocusCamera._DoSmoothPan_d__128.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera._DoSmoothPan_d__128>.NativeClassPtr, 100667226);
				RTFocusCamera._DoSmoothPan_d__128.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera._DoSmoothPan_d__128>.NativeClassPtr, 100667228);
			}

			// Token: 0x17001954 RID: 6484
			// (get) Token: 0x06004AD3 RID: 19155 RVA: 0x00148CAC File Offset: 0x00146EAC
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera._DoSmoothPan_d__128.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001955 RID: 6485
			// (get) Token: 0x06004AD4 RID: 19156 RVA: 0x00148CEC File Offset: 0x00146EEC
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera._DoSmoothPan_d__128.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004AD5 RID: 19157 RVA: 0x00148D2C File Offset: 0x00146F2C
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 10168, RefRangeEnd = 10216, XrefRangeStart = 10168, XrefRangeEnd = 10216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DoSmoothPan_d__128(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTFocusCamera._DoSmoothPan_d__128>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera._DoSmoothPan_d__128.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004AD6 RID: 19158 RVA: 0x00148D74 File Offset: 0x00146F74
			[CallerCount(7535)]
			[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera._DoSmoothPan_d__128.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004AD7 RID: 19159 RVA: 0x00148DA8 File Offset: 0x00146FA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75174, XrefRangeEnd = 75184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera._DoSmoothPan_d__128.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004AD8 RID: 19160 RVA: 0x00148DE4 File Offset: 0x00146FE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75184, XrefRangeEnd = 75189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera._DoSmoothPan_d__128.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004AD9 RID: 19161 RVA: 0x0001BF96 File Offset: 0x0001A196
			public _DoSmoothPan_d__128(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700194E RID: 6478
			// (get) Token: 0x06004ADA RID: 19162 RVA: 0x00148E18 File Offset: 0x00147018
			// (set) Token: 0x06004ADB RID: 19163 RVA: 0x0001BF9F File Offset: 0x0001A19F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoSmoothPan_d__128.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoSmoothPan_d__128.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700194F RID: 6479
			// (get) Token: 0x06004ADC RID: 19164 RVA: 0x00148E40 File Offset: 0x00147040
			// (set) Token: 0x06004ADD RID: 19165 RVA: 0x0001BFBA File Offset: 0x0001A1BA
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoSmoothPan_d__128.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoSmoothPan_d__128.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001950 RID: 6480
			// (get) Token: 0x06004ADE RID: 19166 RVA: 0x00148E70 File Offset: 0x00147070
			// (set) Token: 0x06004ADF RID: 19167 RVA: 0x0001BFD9 File Offset: 0x0001A1D9
			public unsafe RTFocusCamera __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoSmoothPan_d__128.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTFocusCamera>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoSmoothPan_d__128.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001951 RID: 6481
			// (get) Token: 0x06004AE0 RID: 19168 RVA: 0x00148EA0 File Offset: 0x001470A0
			// (set) Token: 0x06004AE1 RID: 19169 RVA: 0x0001BFF8 File Offset: 0x0001A1F8
			public unsafe float deviceAxisX
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoSmoothPan_d__128.NativeFieldInfoPtr_deviceAxisX);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoSmoothPan_d__128.NativeFieldInfoPtr_deviceAxisX)) = value;
				}
			}

			// Token: 0x17001952 RID: 6482
			// (get) Token: 0x06004AE2 RID: 19170 RVA: 0x00148EC8 File Offset: 0x001470C8
			// (set) Token: 0x06004AE3 RID: 19171 RVA: 0x0001C013 File Offset: 0x0001A213
			public unsafe float deviceAxisY
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoSmoothPan_d__128.NativeFieldInfoPtr_deviceAxisY);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoSmoothPan_d__128.NativeFieldInfoPtr_deviceAxisY)) = value;
				}
			}

			// Token: 0x17001953 RID: 6483
			// (get) Token: 0x06004AE4 RID: 19172 RVA: 0x00148EF0 File Offset: 0x001470F0
			// (set) Token: 0x06004AE5 RID: 19173 RVA: 0x0001C02E File Offset: 0x0001A22E
			public unsafe Vector2 _panAmount_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoSmoothPan_d__128.NativeFieldInfoPtr__panAmount_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoSmoothPan_d__128.NativeFieldInfoPtr__panAmount_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003A1A RID: 14874
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003A1B RID: 14875
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003A1C RID: 14876
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003A1D RID: 14877
			private static readonly IntPtr NativeFieldInfoPtr_deviceAxisX;

			// Token: 0x04003A1E RID: 14878
			private static readonly IntPtr NativeFieldInfoPtr_deviceAxisY;

			// Token: 0x04003A1F RID: 14879
			private static readonly IntPtr NativeFieldInfoPtr__panAmount_5__2;

			// Token: 0x04003A20 RID: 14880
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003A21 RID: 14881
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003A22 RID: 14882
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003A23 RID: 14883
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003A24 RID: 14884
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003A25 RID: 14885
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}

		// Token: 0x02000388 RID: 904
		[ObfuscatedName("RLD.RTFocusCamera+<DoSmoothRotationSwitch>d__133")]
		public sealed class _DoSmoothRotationSwitch_d__133 : global::Il2CppSystem.Object
		{
			// Token: 0x06004AE6 RID: 19174 RVA: 0x00148F20 File Offset: 0x00147120
			// Note: this type is marked as 'beforefieldinit'.
			static _DoSmoothRotationSwitch_d__133()
			{
				Il2CppClassPointerStore<RTFocusCamera._DoSmoothRotationSwitch_d__133>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, "<DoSmoothRotationSwitch>d__133");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTFocusCamera._DoSmoothRotationSwitch_d__133>.NativeClassPtr);
				RTFocusCamera._DoSmoothRotationSwitch_d__133.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera._DoSmoothRotationSwitch_d__133>.NativeClassPtr, "<>1__state");
				RTFocusCamera._DoSmoothRotationSwitch_d__133.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera._DoSmoothRotationSwitch_d__133>.NativeClassPtr, "<>2__current");
				RTFocusCamera._DoSmoothRotationSwitch_d__133.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera._DoSmoothRotationSwitch_d__133>.NativeClassPtr, "<>4__this");
				RTFocusCamera._DoSmoothRotationSwitch_d__133.NativeFieldInfoPtr_targetRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera._DoSmoothRotationSwitch_d__133>.NativeClassPtr, "targetRotation");
				RTFocusCamera._DoSmoothRotationSwitch_d__133.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera._DoSmoothRotationSwitch_d__133>.NativeClassPtr, 100667233);
				RTFocusCamera._DoSmoothRotationSwitch_d__133.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera._DoSmoothRotationSwitch_d__133>.NativeClassPtr, 100667235);
				RTFocusCamera._DoSmoothRotationSwitch_d__133.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera._DoSmoothRotationSwitch_d__133>.NativeClassPtr, 100667230);
				RTFocusCamera._DoSmoothRotationSwitch_d__133.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera._DoSmoothRotationSwitch_d__133>.NativeClassPtr, 100667231);
				RTFocusCamera._DoSmoothRotationSwitch_d__133.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera._DoSmoothRotationSwitch_d__133>.NativeClassPtr, 100667232);
				RTFocusCamera._DoSmoothRotationSwitch_d__133.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera._DoSmoothRotationSwitch_d__133>.NativeClassPtr, 100667234);
			}

			// Token: 0x1700195A RID: 6490
			// (get) Token: 0x06004AE7 RID: 19175 RVA: 0x00149014 File Offset: 0x00147214
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera._DoSmoothRotationSwitch_d__133.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x1700195B RID: 6491
			// (get) Token: 0x06004AE8 RID: 19176 RVA: 0x00149054 File Offset: 0x00147254
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera._DoSmoothRotationSwitch_d__133.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004AE9 RID: 19177 RVA: 0x00149094 File Offset: 0x00147294
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 10168, RefRangeEnd = 10216, XrefRangeStart = 10168, XrefRangeEnd = 10216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DoSmoothRotationSwitch_d__133(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTFocusCamera._DoSmoothRotationSwitch_d__133>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera._DoSmoothRotationSwitch_d__133.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004AEA RID: 19178 RVA: 0x001490DC File Offset: 0x001472DC
			[CallerCount(7535)]
			[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera._DoSmoothRotationSwitch_d__133.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004AEB RID: 19179 RVA: 0x00149110 File Offset: 0x00147310
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75189, XrefRangeEnd = 75200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera._DoSmoothRotationSwitch_d__133.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004AEC RID: 19180 RVA: 0x0014914C File Offset: 0x0014734C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75200, XrefRangeEnd = 75205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera._DoSmoothRotationSwitch_d__133.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004AED RID: 19181 RVA: 0x0001C04D File Offset: 0x0001A24D
			public _DoSmoothRotationSwitch_d__133(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001956 RID: 6486
			// (get) Token: 0x06004AEE RID: 19182 RVA: 0x00149180 File Offset: 0x00147380
			// (set) Token: 0x06004AEF RID: 19183 RVA: 0x0001C056 File Offset: 0x0001A256
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoSmoothRotationSwitch_d__133.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoSmoothRotationSwitch_d__133.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001957 RID: 6487
			// (get) Token: 0x06004AF0 RID: 19184 RVA: 0x001491A8 File Offset: 0x001473A8
			// (set) Token: 0x06004AF1 RID: 19185 RVA: 0x0001C071 File Offset: 0x0001A271
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoSmoothRotationSwitch_d__133.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoSmoothRotationSwitch_d__133.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001958 RID: 6488
			// (get) Token: 0x06004AF2 RID: 19186 RVA: 0x001491D8 File Offset: 0x001473D8
			// (set) Token: 0x06004AF3 RID: 19187 RVA: 0x0001C090 File Offset: 0x0001A290
			public unsafe RTFocusCamera __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoSmoothRotationSwitch_d__133.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTFocusCamera>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoSmoothRotationSwitch_d__133.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001959 RID: 6489
			// (get) Token: 0x06004AF4 RID: 19188 RVA: 0x00149208 File Offset: 0x00147408
			// (set) Token: 0x06004AF5 RID: 19189 RVA: 0x0001C0AF File Offset: 0x0001A2AF
			public unsafe Quaternion targetRotation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoSmoothRotationSwitch_d__133.NativeFieldInfoPtr_targetRotation);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoSmoothRotationSwitch_d__133.NativeFieldInfoPtr_targetRotation), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003A26 RID: 14886
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003A27 RID: 14887
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003A28 RID: 14888
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003A29 RID: 14889
			private static readonly IntPtr NativeFieldInfoPtr_targetRotation;

			// Token: 0x04003A2A RID: 14890
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003A2B RID: 14891
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003A2C RID: 14892
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003A2D RID: 14893
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003A2E RID: 14894
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003A2F RID: 14895
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}

		// Token: 0x02000389 RID: 905
		[ObfuscatedName("RLD.RTFocusCamera+<DoSmoothZoom>d__131")]
		public sealed class _DoSmoothZoom_d__131 : global::Il2CppSystem.Object
		{
			// Token: 0x06004AF6 RID: 19190 RVA: 0x00149238 File Offset: 0x00147438
			// Note: this type is marked as 'beforefieldinit'.
			static _DoSmoothZoom_d__131()
			{
				Il2CppClassPointerStore<RTFocusCamera._DoSmoothZoom_d__131>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RTFocusCamera>.NativeClassPtr, "<DoSmoothZoom>d__131");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTFocusCamera._DoSmoothZoom_d__131>.NativeClassPtr);
				RTFocusCamera._DoSmoothZoom_d__131.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera._DoSmoothZoom_d__131>.NativeClassPtr, "<>1__state");
				RTFocusCamera._DoSmoothZoom_d__131.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera._DoSmoothZoom_d__131>.NativeClassPtr, "<>2__current");
				RTFocusCamera._DoSmoothZoom_d__131.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera._DoSmoothZoom_d__131>.NativeClassPtr, "<>4__this");
				RTFocusCamera._DoSmoothZoom_d__131.NativeFieldInfoPtr_deviceScroll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera._DoSmoothZoom_d__131>.NativeClassPtr, "deviceScroll");
				RTFocusCamera._DoSmoothZoom_d__131.NativeFieldInfoPtr__zoomAmount_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTFocusCamera._DoSmoothZoom_d__131>.NativeClassPtr, "<zoomAmount>5__2");
				RTFocusCamera._DoSmoothZoom_d__131.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera._DoSmoothZoom_d__131>.NativeClassPtr, 100667239);
				RTFocusCamera._DoSmoothZoom_d__131.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera._DoSmoothZoom_d__131>.NativeClassPtr, 100667241);
				RTFocusCamera._DoSmoothZoom_d__131.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera._DoSmoothZoom_d__131>.NativeClassPtr, 100667236);
				RTFocusCamera._DoSmoothZoom_d__131.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera._DoSmoothZoom_d__131>.NativeClassPtr, 100667237);
				RTFocusCamera._DoSmoothZoom_d__131.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera._DoSmoothZoom_d__131>.NativeClassPtr, 100667238);
				RTFocusCamera._DoSmoothZoom_d__131.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTFocusCamera._DoSmoothZoom_d__131>.NativeClassPtr, 100667240);
			}

			// Token: 0x17001961 RID: 6497
			// (get) Token: 0x06004AF7 RID: 19191 RVA: 0x00149340 File Offset: 0x00147540
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera._DoSmoothZoom_d__131.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001962 RID: 6498
			// (get) Token: 0x06004AF8 RID: 19192 RVA: 0x00149380 File Offset: 0x00147580
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera._DoSmoothZoom_d__131.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004AF9 RID: 19193 RVA: 0x001493C0 File Offset: 0x001475C0
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 10168, RefRangeEnd = 10216, XrefRangeStart = 10168, XrefRangeEnd = 10216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DoSmoothZoom_d__131(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTFocusCamera._DoSmoothZoom_d__131>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera._DoSmoothZoom_d__131.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004AFA RID: 19194 RVA: 0x00149408 File Offset: 0x00147608
			[CallerCount(7535)]
			[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera._DoSmoothZoom_d__131.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004AFB RID: 19195 RVA: 0x0014943C File Offset: 0x0014763C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75205, XrefRangeEnd = 75214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera._DoSmoothZoom_d__131.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004AFC RID: 19196 RVA: 0x00149478 File Offset: 0x00147678
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75214, XrefRangeEnd = 75219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTFocusCamera._DoSmoothZoom_d__131.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004AFD RID: 19197 RVA: 0x0001C0CE File Offset: 0x0001A2CE
			public _DoSmoothZoom_d__131(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700195C RID: 6492
			// (get) Token: 0x06004AFE RID: 19198 RVA: 0x001494AC File Offset: 0x001476AC
			// (set) Token: 0x06004AFF RID: 19199 RVA: 0x0001C0D7 File Offset: 0x0001A2D7
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoSmoothZoom_d__131.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoSmoothZoom_d__131.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700195D RID: 6493
			// (get) Token: 0x06004B00 RID: 19200 RVA: 0x001494D4 File Offset: 0x001476D4
			// (set) Token: 0x06004B01 RID: 19201 RVA: 0x0001C0F2 File Offset: 0x0001A2F2
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoSmoothZoom_d__131.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoSmoothZoom_d__131.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700195E RID: 6494
			// (get) Token: 0x06004B02 RID: 19202 RVA: 0x00149504 File Offset: 0x00147704
			// (set) Token: 0x06004B03 RID: 19203 RVA: 0x0001C111 File Offset: 0x0001A311
			public unsafe RTFocusCamera __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoSmoothZoom_d__131.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTFocusCamera>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoSmoothZoom_d__131.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700195F RID: 6495
			// (get) Token: 0x06004B04 RID: 19204 RVA: 0x00149534 File Offset: 0x00147734
			// (set) Token: 0x06004B05 RID: 19205 RVA: 0x0001C130 File Offset: 0x0001A330
			public unsafe float deviceScroll
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoSmoothZoom_d__131.NativeFieldInfoPtr_deviceScroll);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoSmoothZoom_d__131.NativeFieldInfoPtr_deviceScroll)) = value;
				}
			}

			// Token: 0x17001960 RID: 6496
			// (get) Token: 0x06004B06 RID: 19206 RVA: 0x0014955C File Offset: 0x0014775C
			// (set) Token: 0x06004B07 RID: 19207 RVA: 0x0001C14B File Offset: 0x0001A34B
			public unsafe float _zoomAmount_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoSmoothZoom_d__131.NativeFieldInfoPtr__zoomAmount_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTFocusCamera._DoSmoothZoom_d__131.NativeFieldInfoPtr__zoomAmount_5__2)) = value;
				}
			}

			// Token: 0x04003A30 RID: 14896
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003A31 RID: 14897
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003A32 RID: 14898
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003A33 RID: 14899
			private static readonly IntPtr NativeFieldInfoPtr_deviceScroll;

			// Token: 0x04003A34 RID: 14900
			private static readonly IntPtr NativeFieldInfoPtr__zoomAmount_5__2;

			// Token: 0x04003A35 RID: 14901
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003A36 RID: 14902
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003A37 RID: 14903
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003A38 RID: 14904
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003A39 RID: 14905
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003A3A RID: 14906
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}
	}
}
