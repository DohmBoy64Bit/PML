using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Polytoria.Datamodel
{
	// Token: 0x02000271 RID: 625
	public class Camera : DynamicInstance
	{
		// Token: 0x06003007 RID: 12295 RVA: 0x000DD6AC File Offset: 0x000DB8AC
		// Note: this type is marked as 'beforefieldinit'.
		static Camera()
		{
			Il2CppClassPointerStore<Camera>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel", "Camera");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Camera>.NativeClassPtr);
			Camera.NativeFieldInfoPtr_sensitivityModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera>.NativeClassPtr, "sensitivityModifier");
			Camera.NativeFieldInfoPtr_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera>.NativeClassPtr, "Instance");
			Camera.NativeFieldInfoPtr_clipIgnoreLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera>.NativeClassPtr, "clipIgnoreLayers");
			Camera.NativeFieldInfoPtr_disableOnFirstPerson = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera>.NativeClassPtr, "disableOnFirstPerson");
			Camera.NativeFieldInfoPtr_cam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera>.NativeClassPtr, "cam");
			Camera.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera>.NativeClassPtr, "target");
			Camera.NativeFieldInfoPtr_distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera>.NativeClassPtr, "distance");
			Camera.NativeFieldInfoPtr_distanceLerp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera>.NativeClassPtr, "distanceLerp");
			Camera.NativeFieldInfoPtr_xSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera>.NativeClassPtr, "xSpeed");
			Camera.NativeFieldInfoPtr_ySpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera>.NativeClassPtr, "ySpeed");
			Camera.NativeFieldInfoPtr_yMinLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera>.NativeClassPtr, "yMinLimit");
			Camera.NativeFieldInfoPtr_yMaxLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera>.NativeClassPtr, "yMaxLimit");
			Camera.NativeFieldInfoPtr_distanceMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera>.NativeClassPtr, "distanceMax");
			Camera.NativeFieldInfoPtr_minDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera>.NativeClassPtr, "minDist");
			Camera.NativeFieldInfoPtr_maxDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera>.NativeClassPtr, "maxDist");
			Camera.NativeFieldInfoPtr_clipThroughWalls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera>.NativeClassPtr, "clipThroughWalls");
			Camera.NativeFieldInfoPtr_scrollSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera>.NativeClassPtr, "scrollSensitivity");
			Camera.NativeFieldInfoPtr_flySpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera>.NativeClassPtr, "flySpeed");
			Camera.NativeFieldInfoPtr_fastFlySpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera>.NativeClassPtr, "fastFlySpeed");
			Camera.NativeFieldInfoPtr_freeLookSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera>.NativeClassPtr, "freeLookSensitivity");
			Camera.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera>.NativeClassPtr, "x");
			Camera.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera>.NativeClassPtr, "y");
			Camera.NativeFieldInfoPtr_init = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera>.NativeClassPtr, "init");
			Camera.NativeFieldInfoPtr_wasLocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera>.NativeClassPtr, "wasLocked");
			Camera.NativeFieldInfoPtr_looking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera>.NativeClassPtr, "looking");
			Camera.NativeFieldInfoPtr_locked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera>.NativeClassPtr, "locked");
			Camera.NativeFieldInfoPtr_wasFirstPerson = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera>.NativeClassPtr, "wasFirstPerson");
			Camera.NativeFieldInfoPtr__Mode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera>.NativeClassPtr, "<Mode>k__BackingField");
			Camera.NativeFieldInfoPtr__LerpSpeed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera>.NativeClassPtr, "<LerpSpeed>k__BackingField");
			Camera.NativeFieldInfoPtr__FollowLerp_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera>.NativeClassPtr, "<FollowLerp>k__BackingField");
			Camera.NativeFieldInfoPtr__CanLock_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera>.NativeClassPtr, "<CanLock>k__BackingField");
			Camera.NativeFieldInfoPtr__CtrlLocked_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera>.NativeClassPtr, "<CtrlLocked>k__BackingField");
			Camera.NativeFieldInfoPtr__SensitivityMultiplier_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera>.NativeClassPtr, "<SensitivityMultiplier>k__BackingField");
			Camera.NativeFieldInfoPtr__PositionOffset_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera>.NativeClassPtr, "<PositionOffset>k__BackingField");
			Camera.NativeFieldInfoPtr__RotationOffset_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera>.NativeClassPtr, "<RotationOffset>k__BackingField");
			Camera.NativeFieldInfoPtr_lastDisableFPCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera>.NativeClassPtr, "lastDisableFPCount");
			Camera.NativeFieldInfoPtr_followTargetInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera>.NativeClassPtr, "followTargetInstance");
			Camera.NativeFieldInfoPtr_followTargetTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Camera>.NativeClassPtr, "followTargetTransform");
			Camera.NativeMethodInfoPtr_get_DoLerp_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670538);
			Camera.NativeMethodInfoPtr_get_Mode_Public_get_CameraMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670539);
			Camera.NativeMethodInfoPtr_set_Mode_Public_set_Void_CameraMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670540);
			Camera.NativeMethodInfoPtr_get_FOV_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670541);
			Camera.NativeMethodInfoPtr_set_FOV_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670542);
			Camera.NativeMethodInfoPtr_get_Orthographic_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670543);
			Camera.NativeMethodInfoPtr_set_Orthographic_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670544);
			Camera.NativeMethodInfoPtr_get_OrthographicSize_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670545);
			Camera.NativeMethodInfoPtr_set_OrthographicSize_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670546);
			Camera.NativeMethodInfoPtr_get_Distance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670547);
			Camera.NativeMethodInfoPtr_set_Distance_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670548);
			Camera.NativeMethodInfoPtr_get_MinDistance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670549);
			Camera.NativeMethodInfoPtr_set_MinDistance_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670550);
			Camera.NativeMethodInfoPtr_get_MaxDistance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670551);
			Camera.NativeMethodInfoPtr_set_MaxDistance_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670552);
			Camera.NativeMethodInfoPtr_get_HorizontalSpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670553);
			Camera.NativeMethodInfoPtr_set_HorizontalSpeed_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670554);
			Camera.NativeMethodInfoPtr_get_VerticalSpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670555);
			Camera.NativeMethodInfoPtr_set_VerticalSpeed_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670556);
			Camera.NativeMethodInfoPtr_get_ScrollSensitivity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670557);
			Camera.NativeMethodInfoPtr_set_ScrollSensitivity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670558);
			Camera.NativeMethodInfoPtr_get_ClipThroughWalls_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670559);
			Camera.NativeMethodInfoPtr_set_ClipThroughWalls_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670560);
			Camera.NativeMethodInfoPtr_get_FlySpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670561);
			Camera.NativeMethodInfoPtr_set_FlySpeed_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670562);
			Camera.NativeMethodInfoPtr_get_FastFlySpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670563);
			Camera.NativeMethodInfoPtr_set_FastFlySpeed_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670564);
			Camera.NativeMethodInfoPtr_get_FreeLookSensitivity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670565);
			Camera.NativeMethodInfoPtr_set_FreeLookSensitivity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670566);
			Camera.NativeMethodInfoPtr_get_LerpSpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670567);
			Camera.NativeMethodInfoPtr_set_LerpSpeed_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670568);
			Camera.NativeMethodInfoPtr_get_FollowLerp_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670569);
			Camera.NativeMethodInfoPtr_set_FollowLerp_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670570);
			Camera.NativeMethodInfoPtr_get_CanLock_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670571);
			Camera.NativeMethodInfoPtr_set_CanLock_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670572);
			Camera.NativeMethodInfoPtr_get_CtrlLocked_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670573);
			Camera.NativeMethodInfoPtr_set_CtrlLocked_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670574);
			Camera.NativeMethodInfoPtr_get_SensitivityMultiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670575);
			Camera.NativeMethodInfoPtr_set_SensitivityMultiplier_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670576);
			Camera.NativeMethodInfoPtr_get_PositionOffset_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670577);
			Camera.NativeMethodInfoPtr_set_PositionOffset_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670578);
			Camera.NativeMethodInfoPtr_get_RotationOffset_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670579);
			Camera.NativeMethodInfoPtr_set_RotationOffset_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670580);
			Camera.NativeMethodInfoPtr_get_IsFirstPerson_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670581);
			Camera.NativeMethodInfoPtr_get_DoTransformSync_Protected_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670582);
			Camera.NativeMethodInfoPtr_get_FollowTarget_Public_get_DynamicInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670585);
			Camera.NativeMethodInfoPtr_set_FollowTarget_Public_set_Void_DynamicInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670586);
			Camera.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670612);
			Camera.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670583);
			Camera.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670584);
			Camera.NativeMethodInfoPtr_SetFollowTarget_Private_Void_DynamicInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670587);
			Camera.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670588);
			Camera.NativeMethodInfoPtr_UpdateFollow_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670589);
			Camera.NativeMethodInfoPtr_UpdateFollowTarget_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670590);
			Camera.NativeMethodInfoPtr_UpdateFollowMode_Private_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670591);
			Camera.NativeMethodInfoPtr_HandleLockInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670592);
			Camera.NativeMethodInfoPtr_HandleScrollInput_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670593);
			Camera.NativeMethodInfoPtr_HandleFirstPersonRendering_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670594);
			Camera.NativeMethodInfoPtr_ShouldProcessCameraInput_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670595);
			Camera.NativeMethodInfoPtr_HandleCursorLocking_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670596);
			Camera.NativeMethodInfoPtr_HandleCameraRotation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670597);
			Camera.NativeMethodInfoPtr_HandleScrollZoom_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670598);
			Camera.NativeMethodInfoPtr_ApplyCameraTransform_Private_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670599);
			Camera.NativeMethodInfoPtr_ClampDistance_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670600);
			Camera.NativeMethodInfoPtr_CalculateWallClipping_Private_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670601);
			Camera.NativeMethodInfoPtr_UpdateFree_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670602);
			Camera.NativeMethodInfoPtr_HandleFreeMovement_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670603);
			Camera.NativeMethodInfoPtr_HandleFreeLook_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670604);
			Camera.NativeMethodInfoPtr_HandleFreeZoom_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670605);
			Camera.NativeMethodInfoPtr_HandleFreeLookToggle_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670606);
			Camera.NativeMethodInfoPtr_StartLooking_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670607);
			Camera.NativeMethodInfoPtr_StopLooking_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670608);
			Camera.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670609);
			Camera.NativeMethodInfoPtr_ClampAngle_Private_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670610);
			Camera.NativeMethodInfoPtr_SetTarget_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670611);
			Camera.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Camera>.NativeClassPtr, 100670614);
		}

		// Token: 0x170010EB RID: 4331
		// (get) Token: 0x06003008 RID: 12296 RVA: 0x000DDFC4 File Offset: 0x000DC1C4
		public unsafe bool DoLerp
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_DoLerp_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170010EC RID: 4332
		// (get) Token: 0x06003009 RID: 12297 RVA: 0x000DE000 File Offset: 0x000DC200
		// (set) Token: 0x0600300A RID: 12298 RVA: 0x000DE040 File Offset: 0x000DC240
		public unsafe CameraMode Mode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_Mode_Public_get_CameraMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CameraMode>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_Mode_Public_set_Void_CameraMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170010ED RID: 4333
		// (get) Token: 0x0600300B RID: 12299 RVA: 0x000DE084 File Offset: 0x000DC284
		// (set) Token: 0x0600300C RID: 12300 RVA: 0x000DE0C0 File Offset: 0x000DC2C0
		public unsafe float FOV
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 100675, RefRangeEnd = 100677, XrefRangeStart = 100673, XrefRangeEnd = 100675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_FOV_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 100679, RefRangeEnd = 100682, XrefRangeStart = 100677, XrefRangeEnd = 100679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_FOV_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170010EE RID: 4334
		// (get) Token: 0x0600300D RID: 12301 RVA: 0x000DE100 File Offset: 0x000DC300
		// (set) Token: 0x0600300E RID: 12302 RVA: 0x000DE13C File Offset: 0x000DC33C
		public unsafe bool Orthographic
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 100684, RefRangeEnd = 100685, XrefRangeStart = 100682, XrefRangeEnd = 100684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_Orthographic_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 100687, RefRangeEnd = 100688, XrefRangeStart = 100685, XrefRangeEnd = 100687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_Orthographic_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170010EF RID: 4335
		// (get) Token: 0x0600300F RID: 12303 RVA: 0x000DE17C File Offset: 0x000DC37C
		// (set) Token: 0x06003010 RID: 12304 RVA: 0x000DE1B8 File Offset: 0x000DC3B8
		public unsafe float OrthographicSize
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 100690, RefRangeEnd = 100691, XrefRangeStart = 100688, XrefRangeEnd = 100690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_OrthographicSize_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 100693, RefRangeEnd = 100694, XrefRangeStart = 100691, XrefRangeEnd = 100693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_OrthographicSize_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170010F0 RID: 4336
		// (get) Token: 0x06003011 RID: 12305 RVA: 0x000DE1F8 File Offset: 0x000DC3F8
		// (set) Token: 0x06003012 RID: 12306 RVA: 0x000DE234 File Offset: 0x000DC434
		public unsafe float Distance
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_Distance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_Distance_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170010F1 RID: 4337
		// (get) Token: 0x06003013 RID: 12307 RVA: 0x000DE274 File Offset: 0x000DC474
		// (set) Token: 0x06003014 RID: 12308 RVA: 0x000DE2B0 File Offset: 0x000DC4B0
		public unsafe float MinDistance
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_MinDistance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_MinDistance_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170010F2 RID: 4338
		// (get) Token: 0x06003015 RID: 12309 RVA: 0x000DE2F0 File Offset: 0x000DC4F0
		// (set) Token: 0x06003016 RID: 12310 RVA: 0x000DE32C File Offset: 0x000DC52C
		public unsafe float MaxDistance
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_MaxDistance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_MaxDistance_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170010F3 RID: 4339
		// (get) Token: 0x06003017 RID: 12311 RVA: 0x000DE36C File Offset: 0x000DC56C
		// (set) Token: 0x06003018 RID: 12312 RVA: 0x000DE3A8 File Offset: 0x000DC5A8
		public unsafe float HorizontalSpeed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_HorizontalSpeed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_HorizontalSpeed_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170010F4 RID: 4340
		// (get) Token: 0x06003019 RID: 12313 RVA: 0x000DE3E8 File Offset: 0x000DC5E8
		// (set) Token: 0x0600301A RID: 12314 RVA: 0x000DE424 File Offset: 0x000DC624
		public unsafe float VerticalSpeed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_VerticalSpeed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_VerticalSpeed_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170010F5 RID: 4341
		// (get) Token: 0x0600301B RID: 12315 RVA: 0x000DE464 File Offset: 0x000DC664
		// (set) Token: 0x0600301C RID: 12316 RVA: 0x000DE4A0 File Offset: 0x000DC6A0
		public unsafe float ScrollSensitivity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_ScrollSensitivity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_ScrollSensitivity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170010F6 RID: 4342
		// (get) Token: 0x0600301D RID: 12317 RVA: 0x000DE4E0 File Offset: 0x000DC6E0
		// (set) Token: 0x0600301E RID: 12318 RVA: 0x000DE51C File Offset: 0x000DC71C
		public unsafe bool ClipThroughWalls
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_ClipThroughWalls_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_ClipThroughWalls_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170010F7 RID: 4343
		// (get) Token: 0x0600301F RID: 12319 RVA: 0x000DE55C File Offset: 0x000DC75C
		// (set) Token: 0x06003020 RID: 12320 RVA: 0x000DE598 File Offset: 0x000DC798
		public unsafe float FlySpeed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_FlySpeed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_FlySpeed_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170010F8 RID: 4344
		// (get) Token: 0x06003021 RID: 12321 RVA: 0x000DE5D8 File Offset: 0x000DC7D8
		// (set) Token: 0x06003022 RID: 12322 RVA: 0x000DE614 File Offset: 0x000DC814
		public unsafe float FastFlySpeed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_FastFlySpeed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_FastFlySpeed_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170010F9 RID: 4345
		// (get) Token: 0x06003023 RID: 12323 RVA: 0x000DE654 File Offset: 0x000DC854
		// (set) Token: 0x06003024 RID: 12324 RVA: 0x000DE690 File Offset: 0x000DC890
		public unsafe float FreeLookSensitivity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_FreeLookSensitivity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_FreeLookSensitivity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170010FA RID: 4346
		// (get) Token: 0x06003025 RID: 12325 RVA: 0x000DE6D0 File Offset: 0x000DC8D0
		// (set) Token: 0x06003026 RID: 12326 RVA: 0x000DE70C File Offset: 0x000DC90C
		public unsafe float LerpSpeed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_LerpSpeed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_LerpSpeed_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170010FB RID: 4347
		// (get) Token: 0x06003027 RID: 12327 RVA: 0x000DE74C File Offset: 0x000DC94C
		// (set) Token: 0x06003028 RID: 12328 RVA: 0x000DE788 File Offset: 0x000DC988
		public unsafe bool FollowLerp
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_FollowLerp_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_FollowLerp_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170010FC RID: 4348
		// (get) Token: 0x06003029 RID: 12329 RVA: 0x000DE7C8 File Offset: 0x000DC9C8
		// (set) Token: 0x0600302A RID: 12330 RVA: 0x000DE804 File Offset: 0x000DCA04
		public unsafe bool CanLock
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_CanLock_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_CanLock_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170010FD RID: 4349
		// (get) Token: 0x0600302B RID: 12331 RVA: 0x000DE844 File Offset: 0x000DCA44
		// (set) Token: 0x0600302C RID: 12332 RVA: 0x000DE880 File Offset: 0x000DCA80
		public unsafe bool CtrlLocked
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_CtrlLocked_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_CtrlLocked_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170010FE RID: 4350
		// (get) Token: 0x0600302D RID: 12333 RVA: 0x000DE8C0 File Offset: 0x000DCAC0
		// (set) Token: 0x0600302E RID: 12334 RVA: 0x000DE8FC File Offset: 0x000DCAFC
		public unsafe float SensitivityMultiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_SensitivityMultiplier_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_SensitivityMultiplier_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170010FF RID: 4351
		// (get) Token: 0x0600302F RID: 12335 RVA: 0x000DE93C File Offset: 0x000DCB3C
		// (set) Token: 0x06003030 RID: 12336 RVA: 0x000DE97C File Offset: 0x000DCB7C
		public unsafe Vector3 PositionOffset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_PositionOffset_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_PositionOffset_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001100 RID: 4352
		// (get) Token: 0x06003031 RID: 12337 RVA: 0x000DE9C0 File Offset: 0x000DCBC0
		// (set) Token: 0x06003032 RID: 12338 RVA: 0x000DEA00 File Offset: 0x000DCC00
		public unsafe Vector3 RotationOffset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_RotationOffset_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_RotationOffset_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001101 RID: 4353
		// (get) Token: 0x06003033 RID: 12339 RVA: 0x000DEA44 File Offset: 0x000DCC44
		public unsafe bool IsFirstPerson
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 100694, RefRangeEnd = 100697, XrefRangeStart = 100694, XrefRangeEnd = 100694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_IsFirstPerson_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001102 RID: 4354
		// (get) Token: 0x06003034 RID: 12340 RVA: 0x000DEA80 File Offset: 0x000DCC80
		public unsafe override bool DoTransformSync
		{
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 18232, RefRangeEnd = 18358, XrefRangeStart = 18232, XrefRangeEnd = 18358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Camera.NativeMethodInfoPtr_get_DoTransformSync_Protected_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001103 RID: 4355
		// (get) Token: 0x06003035 RID: 12341 RVA: 0x000DEAC8 File Offset: 0x000DCCC8
		// (set) Token: 0x06003036 RID: 12342 RVA: 0x000DEB08 File Offset: 0x000DCD08
		public unsafe DynamicInstance FollowTarget
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_get_FollowTarget_Public_get_DynamicInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicInstance>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 100712, RefRangeEnd = 100713, XrefRangeStart = 100697, XrefRangeEnd = 100712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_set_FollowTarget_Public_set_Void_DynamicInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003037 RID: 12343 RVA: 0x000DEB4C File Offset: 0x000DCD4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100713, XrefRangeEnd = 100717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Camera()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Camera>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003038 RID: 12344 RVA: 0x000DEB88 File Offset: 0x000DCD88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100717, XrefRangeEnd = 100759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Camera.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003039 RID: 12345 RVA: 0x000DEBC4 File Offset: 0x000DCDC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100759, XrefRangeEnd = 100766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Camera.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600303A RID: 12346 RVA: 0x000DEC00 File Offset: 0x000DCE00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100766, XrefRangeEnd = 100775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFollowTarget(DynamicInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_SetFollowTarget_Private_Void_DynamicInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600303B RID: 12347 RVA: 0x000DEC44 File Offset: 0x000DCE44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100775, XrefRangeEnd = 100778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600303C RID: 12348 RVA: 0x000DEC78 File Offset: 0x000DCE78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100778, XrefRangeEnd = 100779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateFollow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_UpdateFollow_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600303D RID: 12349 RVA: 0x000DECAC File Offset: 0x000DCEAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100779, XrefRangeEnd = 100780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateFollowTarget()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_UpdateFollowTarget_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600303E RID: 12350 RVA: 0x000DECE0 File Offset: 0x000DCEE0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 100834, RefRangeEnd = 100838, XrefRangeStart = 100780, XrefRangeEnd = 100834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateFollowMode(Transform followTarget)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(followTarget);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_UpdateFollowMode_Private_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600303F RID: 12351 RVA: 0x000DED24 File Offset: 0x000DCF24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100838, XrefRangeEnd = 100843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleLockInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_HandleLockInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003040 RID: 12352 RVA: 0x000DED58 File Offset: 0x000DCF58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100843, XrefRangeEnd = 100858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float HandleScrollInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_HandleScrollInput_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003041 RID: 12353 RVA: 0x000DED94 File Offset: 0x000DCF94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 100917, RefRangeEnd = 100918, XrefRangeStart = 100858, XrefRangeEnd = 100917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleFirstPersonRendering()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_HandleFirstPersonRendering_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003042 RID: 12354 RVA: 0x000DEDC8 File Offset: 0x000DCFC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100918, XrefRangeEnd = 100937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ShouldProcessCameraInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_ShouldProcessCameraInput_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003043 RID: 12355 RVA: 0x000DEE04 File Offset: 0x000DD004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100937, XrefRangeEnd = 100940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleCursorLocking()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_HandleCursorLocking_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003044 RID: 12356 RVA: 0x000DEE38 File Offset: 0x000DD038
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 100978, RefRangeEnd = 100979, XrefRangeStart = 100940, XrefRangeEnd = 100978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleCameraRotation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_HandleCameraRotation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003045 RID: 12357 RVA: 0x000DEE6C File Offset: 0x000DD06C
		[CallerCount(0)]
		public unsafe void HandleScrollZoom(float scroll)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scroll;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_HandleScrollZoom_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003046 RID: 12358 RVA: 0x000DEEAC File Offset: 0x000DD0AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 100997, RefRangeEnd = 100998, XrefRangeStart = 100979, XrefRangeEnd = 100997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyCameraTransform(Transform followTarget)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(followTarget);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_ApplyCameraTransform_Private_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003047 RID: 12359 RVA: 0x000DEEF0 File Offset: 0x000DD0F0
		[CallerCount(0)]
		public unsafe void ClampDistance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_ClampDistance_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003048 RID: 12360 RVA: 0x000DEF24 File Offset: 0x000DD124
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 101013, RefRangeEnd = 101014, XrefRangeStart = 100998, XrefRangeEnd = 101013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CalculateWallClipping(Transform followTarget)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(followTarget);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_CalculateWallClipping_Private_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003049 RID: 12361 RVA: 0x000DEF68 File Offset: 0x000DD168
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 101043, RefRangeEnd = 101044, XrefRangeStart = 101014, XrefRangeEnd = 101043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateFree()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_UpdateFree_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600304A RID: 12362 RVA: 0x000DEF9C File Offset: 0x000DD19C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 101089, RefRangeEnd = 101090, XrefRangeStart = 101044, XrefRangeEnd = 101089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleFreeMovement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_HandleFreeMovement_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600304B RID: 12363 RVA: 0x000DEFD0 File Offset: 0x000DD1D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101090, XrefRangeEnd = 101102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleFreeLook()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_HandleFreeLook_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600304C RID: 12364 RVA: 0x000DF004 File Offset: 0x000DD204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101102, XrefRangeEnd = 101110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleFreeZoom()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_HandleFreeZoom_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600304D RID: 12365 RVA: 0x000DF038 File Offset: 0x000DD238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101110, XrefRangeEnd = 101116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleFreeLookToggle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_HandleFreeLookToggle_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600304E RID: 12366 RVA: 0x000DF06C File Offset: 0x000DD26C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101116, XrefRangeEnd = 101118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartLooking()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_StartLooking_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600304F RID: 12367 RVA: 0x000DF0A0 File Offset: 0x000DD2A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101118, XrefRangeEnd = 101120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopLooking()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_StopLooking_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003050 RID: 12368 RVA: 0x000DF0D4 File Offset: 0x000DD2D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003051 RID: 12369 RVA: 0x000DF108 File Offset: 0x000DD308
		[CallerCount(0)]
		public unsafe static float ClampAngle(float angle, float min, float max)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref angle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_ClampAngle_Private_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003052 RID: 12370 RVA: 0x000DF164 File Offset: 0x000DD364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101120, XrefRangeEnd = 101121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTarget(Transform target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Camera.NativeMethodInfoPtr_SetTarget_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003053 RID: 12371 RVA: 0x000DF1A8 File Offset: 0x000DD3A8
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 20124, RefRangeEnd = 20136, XrefRangeStart = 20124, XrefRangeEnd = 20136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Weaved()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Camera.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003054 RID: 12372 RVA: 0x00013174 File Offset: 0x00011374
		public Camera(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170010C5 RID: 4293
		// (get) Token: 0x06003055 RID: 12373 RVA: 0x000DF1F0 File Offset: 0x000DD3F0
		// (set) Token: 0x06003056 RID: 12374 RVA: 0x0001317D File Offset: 0x0001137D
		public unsafe static float sensitivityModifier
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Camera.NativeFieldInfoPtr_sensitivityModifier, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Camera.NativeFieldInfoPtr_sensitivityModifier, (void*)(&value));
			}
		}

		// Token: 0x170010C6 RID: 4294
		// (get) Token: 0x06003057 RID: 12375 RVA: 0x000DF20C File Offset: 0x000DD40C
		// (set) Token: 0x06003058 RID: 12376 RVA: 0x0001318B File Offset: 0x0001138B
		public unsafe static Camera Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Camera.NativeFieldInfoPtr_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Camera.NativeFieldInfoPtr_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010C7 RID: 4295
		// (get) Token: 0x06003059 RID: 12377 RVA: 0x000DF234 File Offset: 0x000DD434
		// (set) Token: 0x0600305A RID: 12378 RVA: 0x0001319D File Offset: 0x0001139D
		public unsafe static LayerMask clipIgnoreLayers
		{
			get
			{
				LayerMask layerMask;
				IL2CPP.il2cpp_field_static_get_value(Camera.NativeFieldInfoPtr_clipIgnoreLayers, (void*)(&layerMask));
				return layerMask;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Camera.NativeFieldInfoPtr_clipIgnoreLayers, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010C8 RID: 4296
		// (get) Token: 0x0600305B RID: 12379 RVA: 0x000DF250 File Offset: 0x000DD450
		// (set) Token: 0x0600305C RID: 12380 RVA: 0x000131AF File Offset: 0x000113AF
		public unsafe static List<MeshRenderer> disableOnFirstPerson
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Camera.NativeFieldInfoPtr_disableOnFirstPerson, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Camera.NativeFieldInfoPtr_disableOnFirstPerson, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010C9 RID: 4297
		// (get) Token: 0x0600305D RID: 12381 RVA: 0x000DF278 File Offset: 0x000DD478
		// (set) Token: 0x0600305E RID: 12382 RVA: 0x000131C1 File Offset: 0x000113C1
		public unsafe Camera cam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.NativeFieldInfoPtr_cam);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.NativeFieldInfoPtr_cam), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010CA RID: 4298
		// (get) Token: 0x0600305F RID: 12383 RVA: 0x000DF2A8 File Offset: 0x000DD4A8
		// (set) Token: 0x06003060 RID: 12384 RVA: 0x000131E0 File Offset: 0x000113E0
		public unsafe Transform target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.NativeFieldInfoPtr_target);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010CB RID: 4299
		// (get) Token: 0x06003061 RID: 12385 RVA: 0x000DF2D8 File Offset: 0x000DD4D8
		// (set) Token: 0x06003062 RID: 12386 RVA: 0x000131FF File Offset: 0x000113FF
		public unsafe float distance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.NativeFieldInfoPtr_distance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.NativeFieldInfoPtr_distance)) = value;
			}
		}

		// Token: 0x170010CC RID: 4300
		// (get) Token: 0x06003063 RID: 12387 RVA: 0x000DF300 File Offset: 0x000DD500
		// (set) Token: 0x06003064 RID: 12388 RVA: 0x0001321A File Offset: 0x0001141A
		public unsafe float distanceLerp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.NativeFieldInfoPtr_distanceLerp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.NativeFieldInfoPtr_distanceLerp)) = value;
			}
		}

		// Token: 0x170010CD RID: 4301
		// (get) Token: 0x06003065 RID: 12389 RVA: 0x000DF328 File Offset: 0x000DD528
		// (set) Token: 0x06003066 RID: 12390 RVA: 0x00013235 File Offset: 0x00011435
		public unsafe float xSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.NativeFieldInfoPtr_xSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.NativeFieldInfoPtr_xSpeed)) = value;
			}
		}

		// Token: 0x170010CE RID: 4302
		// (get) Token: 0x06003067 RID: 12391 RVA: 0x000DF350 File Offset: 0x000DD550
		// (set) Token: 0x06003068 RID: 12392 RVA: 0x00013250 File Offset: 0x00011450
		public unsafe float ySpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.NativeFieldInfoPtr_ySpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.NativeFieldInfoPtr_ySpeed)) = value;
			}
		}

		// Token: 0x170010CF RID: 4303
		// (get) Token: 0x06003069 RID: 12393 RVA: 0x000DF378 File Offset: 0x000DD578
		// (set) Token: 0x0600306A RID: 12394 RVA: 0x0001326B File Offset: 0x0001146B
		public unsafe float yMinLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.NativeFieldInfoPtr_yMinLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.NativeFieldInfoPtr_yMinLimit)) = value;
			}
		}

		// Token: 0x170010D0 RID: 4304
		// (get) Token: 0x0600306B RID: 12395 RVA: 0x000DF3A0 File Offset: 0x000DD5A0
		// (set) Token: 0x0600306C RID: 12396 RVA: 0x00013286 File Offset: 0x00011486
		public unsafe float yMaxLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.NativeFieldInfoPtr_yMaxLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.NativeFieldInfoPtr_yMaxLimit)) = value;
			}
		}

		// Token: 0x170010D1 RID: 4305
		// (get) Token: 0x0600306D RID: 12397 RVA: 0x000DF3C8 File Offset: 0x000DD5C8
		// (set) Token: 0x0600306E RID: 12398 RVA: 0x000132A1 File Offset: 0x000114A1
		public unsafe float distanceMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.NativeFieldInfoPtr_distanceMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.NativeFieldInfoPtr_distanceMax)) = value;
			}
		}

		// Token: 0x170010D2 RID: 4306
		// (get) Token: 0x0600306F RID: 12399 RVA: 0x000DF3F0 File Offset: 0x000DD5F0
		// (set) Token: 0x06003070 RID: 12400 RVA: 0x000132BC File Offset: 0x000114BC
		public unsafe float minDist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.NativeFieldInfoPtr_minDist);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.NativeFieldInfoPtr_minDist)) = value;
			}
		}

		// Token: 0x170010D3 RID: 4307
		// (get) Token: 0x06003071 RID: 12401 RVA: 0x000DF418 File Offset: 0x000DD618
		// (set) Token: 0x06003072 RID: 12402 RVA: 0x000132D7 File Offset: 0x000114D7
		public unsafe float maxDist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.NativeFieldInfoPtr_maxDist);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.NativeFieldInfoPtr_maxDist)) = value;
			}
		}

		// Token: 0x170010D4 RID: 4308
		// (get) Token: 0x06003073 RID: 12403 RVA: 0x000DF440 File Offset: 0x000DD640
		// (set) Token: 0x06003074 RID: 12404 RVA: 0x000132F2 File Offset: 0x000114F2
		public unsafe bool clipThroughWalls
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.NativeFieldInfoPtr_clipThroughWalls);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.NativeFieldInfoPtr_clipThroughWalls)) = value;
			}
		}

		// Token: 0x170010D5 RID: 4309
		// (get) Token: 0x06003075 RID: 12405 RVA: 0x000DF468 File Offset: 0x000DD668
		// (set) Token: 0x06003076 RID: 12406 RVA: 0x0001330D File Offset: 0x0001150D
		public unsafe float scrollSensitivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.NativeFieldInfoPtr_scrollSensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.NativeFieldInfoPtr_scrollSensitivity)) = value;
			}
		}

		// Token: 0x170010D6 RID: 4310
		// (get) Token: 0x06003077 RID: 12407 RVA: 0x000DF490 File Offset: 0x000DD690
		// (set) Token: 0x06003078 RID: 12408 RVA: 0x00013328 File Offset: 0x00011528
		public unsafe float flySpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.NativeFieldInfoPtr_flySpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.NativeFieldInfoPtr_flySpeed)) = value;
			}
		}

		// Token: 0x170010D7 RID: 4311
		// (get) Token: 0x06003079 RID: 12409 RVA: 0x000DF4B8 File Offset: 0x000DD6B8
		// (set) Token: 0x0600307A RID: 12410 RVA: 0x00013343 File Offset: 0x00011543
		public unsafe float fastFlySpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.NativeFieldInfoPtr_fastFlySpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.NativeFieldInfoPtr_fastFlySpeed)) = value;
			}
		}

		// Token: 0x170010D8 RID: 4312
		// (get) Token: 0x0600307B RID: 12411 RVA: 0x000DF4E0 File Offset: 0x000DD6E0
		// (set) Token: 0x0600307C RID: 12412 RVA: 0x0001335E File Offset: 0x0001155E
		public unsafe float freeLookSensitivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.NativeFieldInfoPtr_freeLookSensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.NativeFieldInfoPtr_freeLookSensitivity)) = value;
			}
		}

		// Token: 0x170010D9 RID: 4313
		// (get) Token: 0x0600307D RID: 12413 RVA: 0x000DF508 File Offset: 0x000DD708
		// (set) Token: 0x0600307E RID: 12414 RVA: 0x00013379 File Offset: 0x00011579
		public unsafe float x
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.NativeFieldInfoPtr_x);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.NativeFieldInfoPtr_x)) = value;
			}
		}

		// Token: 0x170010DA RID: 4314
		// (get) Token: 0x0600307F RID: 12415 RVA: 0x000DF530 File Offset: 0x000DD730
		// (set) Token: 0x06003080 RID: 12416 RVA: 0x00013394 File Offset: 0x00011594
		public unsafe float y
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.NativeFieldInfoPtr_y);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.NativeFieldInfoPtr_y)) = value;
			}
		}

		// Token: 0x170010DB RID: 4315
		// (get) Token: 0x06003081 RID: 12417 RVA: 0x000DF558 File Offset: 0x000DD758
		// (set) Token: 0x06003082 RID: 12418 RVA: 0x000133AF File Offset: 0x000115AF
		public unsafe bool init
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.NativeFieldInfoPtr_init);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.NativeFieldInfoPtr_init)) = value;
			}
		}

		// Token: 0x170010DC RID: 4316
		// (get) Token: 0x06003083 RID: 12419 RVA: 0x000DF580 File Offset: 0x000DD780
		// (set) Token: 0x06003084 RID: 12420 RVA: 0x000133CA File Offset: 0x000115CA
		public unsafe bool wasLocked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.NativeFieldInfoPtr_wasLocked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.NativeFieldInfoPtr_wasLocked)) = value;
			}
		}

		// Token: 0x170010DD RID: 4317
		// (get) Token: 0x06003085 RID: 12421 RVA: 0x000DF5A8 File Offset: 0x000DD7A8
		// (set) Token: 0x06003086 RID: 12422 RVA: 0x000133E5 File Offset: 0x000115E5
		public unsafe bool looking
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.NativeFieldInfoPtr_looking);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.NativeFieldInfoPtr_looking)) = value;
			}
		}

		// Token: 0x170010DE RID: 4318
		// (get) Token: 0x06003087 RID: 12423 RVA: 0x000DF5D0 File Offset: 0x000DD7D0
		// (set) Token: 0x06003088 RID: 12424 RVA: 0x00013400 File Offset: 0x00011600
		public unsafe bool locked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.NativeFieldInfoPtr_locked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.NativeFieldInfoPtr_locked)) = value;
			}
		}

		// Token: 0x170010DF RID: 4319
		// (get) Token: 0x06003089 RID: 12425 RVA: 0x000DF5F8 File Offset: 0x000DD7F8
		// (set) Token: 0x0600308A RID: 12426 RVA: 0x0001341B File Offset: 0x0001161B
		public unsafe bool wasFirstPerson
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.NativeFieldInfoPtr_wasFirstPerson);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.NativeFieldInfoPtr_wasFirstPerson)) = value;
			}
		}

		// Token: 0x170010E0 RID: 4320
		// (get) Token: 0x0600308B RID: 12427 RVA: 0x000DF620 File Offset: 0x000DD820
		// (set) Token: 0x0600308C RID: 12428 RVA: 0x00013436 File Offset: 0x00011636
		public unsafe CameraMode _Mode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.NativeFieldInfoPtr__Mode_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CameraMode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.NativeFieldInfoPtr__Mode_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010E1 RID: 4321
		// (get) Token: 0x0600308D RID: 12429 RVA: 0x000DF650 File Offset: 0x000DD850
		// (set) Token: 0x0600308E RID: 12430 RVA: 0x00013455 File Offset: 0x00011655
		public unsafe float _LerpSpeed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.NativeFieldInfoPtr__LerpSpeed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.NativeFieldInfoPtr__LerpSpeed_k__BackingField)) = value;
			}
		}

		// Token: 0x170010E2 RID: 4322
		// (get) Token: 0x0600308F RID: 12431 RVA: 0x000DF678 File Offset: 0x000DD878
		// (set) Token: 0x06003090 RID: 12432 RVA: 0x00013470 File Offset: 0x00011670
		public unsafe bool _FollowLerp_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.NativeFieldInfoPtr__FollowLerp_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.NativeFieldInfoPtr__FollowLerp_k__BackingField)) = value;
			}
		}

		// Token: 0x170010E3 RID: 4323
		// (get) Token: 0x06003091 RID: 12433 RVA: 0x000DF6A0 File Offset: 0x000DD8A0
		// (set) Token: 0x06003092 RID: 12434 RVA: 0x0001348B File Offset: 0x0001168B
		public unsafe bool _CanLock_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.NativeFieldInfoPtr__CanLock_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.NativeFieldInfoPtr__CanLock_k__BackingField)) = value;
			}
		}

		// Token: 0x170010E4 RID: 4324
		// (get) Token: 0x06003093 RID: 12435 RVA: 0x000DF6C8 File Offset: 0x000DD8C8
		// (set) Token: 0x06003094 RID: 12436 RVA: 0x000134A6 File Offset: 0x000116A6
		public unsafe bool _CtrlLocked_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.NativeFieldInfoPtr__CtrlLocked_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.NativeFieldInfoPtr__CtrlLocked_k__BackingField)) = value;
			}
		}

		// Token: 0x170010E5 RID: 4325
		// (get) Token: 0x06003095 RID: 12437 RVA: 0x000DF6F0 File Offset: 0x000DD8F0
		// (set) Token: 0x06003096 RID: 12438 RVA: 0x000134C1 File Offset: 0x000116C1
		public unsafe float _SensitivityMultiplier_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.NativeFieldInfoPtr__SensitivityMultiplier_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.NativeFieldInfoPtr__SensitivityMultiplier_k__BackingField)) = value;
			}
		}

		// Token: 0x170010E6 RID: 4326
		// (get) Token: 0x06003097 RID: 12439 RVA: 0x000DF718 File Offset: 0x000DD918
		// (set) Token: 0x06003098 RID: 12440 RVA: 0x000134DC File Offset: 0x000116DC
		public unsafe Vector3 _PositionOffset_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.NativeFieldInfoPtr__PositionOffset_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.NativeFieldInfoPtr__PositionOffset_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010E7 RID: 4327
		// (get) Token: 0x06003099 RID: 12441 RVA: 0x000DF748 File Offset: 0x000DD948
		// (set) Token: 0x0600309A RID: 12442 RVA: 0x000134FB File Offset: 0x000116FB
		public unsafe Vector3 _RotationOffset_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.NativeFieldInfoPtr__RotationOffset_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.NativeFieldInfoPtr__RotationOffset_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010E8 RID: 4328
		// (get) Token: 0x0600309B RID: 12443 RVA: 0x000DF778 File Offset: 0x000DD978
		// (set) Token: 0x0600309C RID: 12444 RVA: 0x0001351A File Offset: 0x0001171A
		public unsafe int lastDisableFPCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.NativeFieldInfoPtr_lastDisableFPCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.NativeFieldInfoPtr_lastDisableFPCount)) = value;
			}
		}

		// Token: 0x170010E9 RID: 4329
		// (get) Token: 0x0600309D RID: 12445 RVA: 0x000DF7A0 File Offset: 0x000DD9A0
		// (set) Token: 0x0600309E RID: 12446 RVA: 0x00013535 File Offset: 0x00011735
		public unsafe DynamicInstance followTargetInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.NativeFieldInfoPtr_followTargetInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynamicInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.NativeFieldInfoPtr_followTargetInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010EA RID: 4330
		// (get) Token: 0x0600309F RID: 12447 RVA: 0x000DF7D0 File Offset: 0x000DD9D0
		// (set) Token: 0x060030A0 RID: 12448 RVA: 0x00013554 File Offset: 0x00011754
		public unsafe Transform followTargetTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.NativeFieldInfoPtr_followTargetTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Camera.NativeFieldInfoPtr_followTargetTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040024B9 RID: 9401
		private static readonly IntPtr NativeFieldInfoPtr_sensitivityModifier;

		// Token: 0x040024BA RID: 9402
		private static readonly IntPtr NativeFieldInfoPtr_Instance;

		// Token: 0x040024BB RID: 9403
		private static readonly IntPtr NativeFieldInfoPtr_clipIgnoreLayers;

		// Token: 0x040024BC RID: 9404
		private static readonly IntPtr NativeFieldInfoPtr_disableOnFirstPerson;

		// Token: 0x040024BD RID: 9405
		private static readonly IntPtr NativeFieldInfoPtr_cam;

		// Token: 0x040024BE RID: 9406
		private static readonly IntPtr NativeFieldInfoPtr_target;

		// Token: 0x040024BF RID: 9407
		private static readonly IntPtr NativeFieldInfoPtr_distance;

		// Token: 0x040024C0 RID: 9408
		private static readonly IntPtr NativeFieldInfoPtr_distanceLerp;

		// Token: 0x040024C1 RID: 9409
		private static readonly IntPtr NativeFieldInfoPtr_xSpeed;

		// Token: 0x040024C2 RID: 9410
		private static readonly IntPtr NativeFieldInfoPtr_ySpeed;

		// Token: 0x040024C3 RID: 9411
		private static readonly IntPtr NativeFieldInfoPtr_yMinLimit;

		// Token: 0x040024C4 RID: 9412
		private static readonly IntPtr NativeFieldInfoPtr_yMaxLimit;

		// Token: 0x040024C5 RID: 9413
		private static readonly IntPtr NativeFieldInfoPtr_distanceMax;

		// Token: 0x040024C6 RID: 9414
		private static readonly IntPtr NativeFieldInfoPtr_minDist;

		// Token: 0x040024C7 RID: 9415
		private static readonly IntPtr NativeFieldInfoPtr_maxDist;

		// Token: 0x040024C8 RID: 9416
		private static readonly IntPtr NativeFieldInfoPtr_clipThroughWalls;

		// Token: 0x040024C9 RID: 9417
		private static readonly IntPtr NativeFieldInfoPtr_scrollSensitivity;

		// Token: 0x040024CA RID: 9418
		private static readonly IntPtr NativeFieldInfoPtr_flySpeed;

		// Token: 0x040024CB RID: 9419
		private static readonly IntPtr NativeFieldInfoPtr_fastFlySpeed;

		// Token: 0x040024CC RID: 9420
		private static readonly IntPtr NativeFieldInfoPtr_freeLookSensitivity;

		// Token: 0x040024CD RID: 9421
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x040024CE RID: 9422
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x040024CF RID: 9423
		private static readonly IntPtr NativeFieldInfoPtr_init;

		// Token: 0x040024D0 RID: 9424
		private static readonly IntPtr NativeFieldInfoPtr_wasLocked;

		// Token: 0x040024D1 RID: 9425
		private static readonly IntPtr NativeFieldInfoPtr_looking;

		// Token: 0x040024D2 RID: 9426
		private static readonly IntPtr NativeFieldInfoPtr_locked;

		// Token: 0x040024D3 RID: 9427
		private static readonly IntPtr NativeFieldInfoPtr_wasFirstPerson;

		// Token: 0x040024D4 RID: 9428
		private static readonly IntPtr NativeFieldInfoPtr__Mode_k__BackingField;

		// Token: 0x040024D5 RID: 9429
		private static readonly IntPtr NativeFieldInfoPtr__LerpSpeed_k__BackingField;

		// Token: 0x040024D6 RID: 9430
		private static readonly IntPtr NativeFieldInfoPtr__FollowLerp_k__BackingField;

		// Token: 0x040024D7 RID: 9431
		private static readonly IntPtr NativeFieldInfoPtr__CanLock_k__BackingField;

		// Token: 0x040024D8 RID: 9432
		private static readonly IntPtr NativeFieldInfoPtr__CtrlLocked_k__BackingField;

		// Token: 0x040024D9 RID: 9433
		private static readonly IntPtr NativeFieldInfoPtr__SensitivityMultiplier_k__BackingField;

		// Token: 0x040024DA RID: 9434
		private static readonly IntPtr NativeFieldInfoPtr__PositionOffset_k__BackingField;

		// Token: 0x040024DB RID: 9435
		private static readonly IntPtr NativeFieldInfoPtr__RotationOffset_k__BackingField;

		// Token: 0x040024DC RID: 9436
		private static readonly IntPtr NativeFieldInfoPtr_lastDisableFPCount;

		// Token: 0x040024DD RID: 9437
		private static readonly IntPtr NativeFieldInfoPtr_followTargetInstance;

		// Token: 0x040024DE RID: 9438
		private static readonly IntPtr NativeFieldInfoPtr_followTargetTransform;

		// Token: 0x040024DF RID: 9439
		private static readonly IntPtr NativeMethodInfoPtr_get_DoLerp_Private_get_Boolean_0;

		// Token: 0x040024E0 RID: 9440
		private static readonly IntPtr NativeMethodInfoPtr_get_Mode_Public_get_CameraMode_0;

		// Token: 0x040024E1 RID: 9441
		private static readonly IntPtr NativeMethodInfoPtr_set_Mode_Public_set_Void_CameraMode_0;

		// Token: 0x040024E2 RID: 9442
		private static readonly IntPtr NativeMethodInfoPtr_get_FOV_Public_get_Single_0;

		// Token: 0x040024E3 RID: 9443
		private static readonly IntPtr NativeMethodInfoPtr_set_FOV_Public_set_Void_Single_0;

		// Token: 0x040024E4 RID: 9444
		private static readonly IntPtr NativeMethodInfoPtr_get_Orthographic_Public_get_Boolean_0;

		// Token: 0x040024E5 RID: 9445
		private static readonly IntPtr NativeMethodInfoPtr_set_Orthographic_Public_set_Void_Boolean_0;

		// Token: 0x040024E6 RID: 9446
		private static readonly IntPtr NativeMethodInfoPtr_get_OrthographicSize_Public_get_Single_0;

		// Token: 0x040024E7 RID: 9447
		private static readonly IntPtr NativeMethodInfoPtr_set_OrthographicSize_Public_set_Void_Single_0;

		// Token: 0x040024E8 RID: 9448
		private static readonly IntPtr NativeMethodInfoPtr_get_Distance_Public_get_Single_0;

		// Token: 0x040024E9 RID: 9449
		private static readonly IntPtr NativeMethodInfoPtr_set_Distance_Public_set_Void_Single_0;

		// Token: 0x040024EA RID: 9450
		private static readonly IntPtr NativeMethodInfoPtr_get_MinDistance_Public_get_Single_0;

		// Token: 0x040024EB RID: 9451
		private static readonly IntPtr NativeMethodInfoPtr_set_MinDistance_Public_set_Void_Single_0;

		// Token: 0x040024EC RID: 9452
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxDistance_Public_get_Single_0;

		// Token: 0x040024ED RID: 9453
		private static readonly IntPtr NativeMethodInfoPtr_set_MaxDistance_Public_set_Void_Single_0;

		// Token: 0x040024EE RID: 9454
		private static readonly IntPtr NativeMethodInfoPtr_get_HorizontalSpeed_Public_get_Single_0;

		// Token: 0x040024EF RID: 9455
		private static readonly IntPtr NativeMethodInfoPtr_set_HorizontalSpeed_Public_set_Void_Single_0;

		// Token: 0x040024F0 RID: 9456
		private static readonly IntPtr NativeMethodInfoPtr_get_VerticalSpeed_Public_get_Single_0;

		// Token: 0x040024F1 RID: 9457
		private static readonly IntPtr NativeMethodInfoPtr_set_VerticalSpeed_Public_set_Void_Single_0;

		// Token: 0x040024F2 RID: 9458
		private static readonly IntPtr NativeMethodInfoPtr_get_ScrollSensitivity_Public_get_Single_0;

		// Token: 0x040024F3 RID: 9459
		private static readonly IntPtr NativeMethodInfoPtr_set_ScrollSensitivity_Public_set_Void_Single_0;

		// Token: 0x040024F4 RID: 9460
		private static readonly IntPtr NativeMethodInfoPtr_get_ClipThroughWalls_Public_get_Boolean_0;

		// Token: 0x040024F5 RID: 9461
		private static readonly IntPtr NativeMethodInfoPtr_set_ClipThroughWalls_Public_set_Void_Boolean_0;

		// Token: 0x040024F6 RID: 9462
		private static readonly IntPtr NativeMethodInfoPtr_get_FlySpeed_Public_get_Single_0;

		// Token: 0x040024F7 RID: 9463
		private static readonly IntPtr NativeMethodInfoPtr_set_FlySpeed_Public_set_Void_Single_0;

		// Token: 0x040024F8 RID: 9464
		private static readonly IntPtr NativeMethodInfoPtr_get_FastFlySpeed_Public_get_Single_0;

		// Token: 0x040024F9 RID: 9465
		private static readonly IntPtr NativeMethodInfoPtr_set_FastFlySpeed_Public_set_Void_Single_0;

		// Token: 0x040024FA RID: 9466
		private static readonly IntPtr NativeMethodInfoPtr_get_FreeLookSensitivity_Public_get_Single_0;

		// Token: 0x040024FB RID: 9467
		private static readonly IntPtr NativeMethodInfoPtr_set_FreeLookSensitivity_Public_set_Void_Single_0;

		// Token: 0x040024FC RID: 9468
		private static readonly IntPtr NativeMethodInfoPtr_get_LerpSpeed_Public_get_Single_0;

		// Token: 0x040024FD RID: 9469
		private static readonly IntPtr NativeMethodInfoPtr_set_LerpSpeed_Public_set_Void_Single_0;

		// Token: 0x040024FE RID: 9470
		private static readonly IntPtr NativeMethodInfoPtr_get_FollowLerp_Public_get_Boolean_0;

		// Token: 0x040024FF RID: 9471
		private static readonly IntPtr NativeMethodInfoPtr_set_FollowLerp_Public_set_Void_Boolean_0;

		// Token: 0x04002500 RID: 9472
		private static readonly IntPtr NativeMethodInfoPtr_get_CanLock_Public_get_Boolean_0;

		// Token: 0x04002501 RID: 9473
		private static readonly IntPtr NativeMethodInfoPtr_set_CanLock_Public_set_Void_Boolean_0;

		// Token: 0x04002502 RID: 9474
		private static readonly IntPtr NativeMethodInfoPtr_get_CtrlLocked_Public_get_Boolean_0;

		// Token: 0x04002503 RID: 9475
		private static readonly IntPtr NativeMethodInfoPtr_set_CtrlLocked_Public_set_Void_Boolean_0;

		// Token: 0x04002504 RID: 9476
		private static readonly IntPtr NativeMethodInfoPtr_get_SensitivityMultiplier_Public_get_Single_0;

		// Token: 0x04002505 RID: 9477
		private static readonly IntPtr NativeMethodInfoPtr_set_SensitivityMultiplier_Public_set_Void_Single_0;

		// Token: 0x04002506 RID: 9478
		private static readonly IntPtr NativeMethodInfoPtr_get_PositionOffset_Public_get_Vector3_0;

		// Token: 0x04002507 RID: 9479
		private static readonly IntPtr NativeMethodInfoPtr_set_PositionOffset_Public_set_Void_Vector3_0;

		// Token: 0x04002508 RID: 9480
		private static readonly IntPtr NativeMethodInfoPtr_get_RotationOffset_Public_get_Vector3_0;

		// Token: 0x04002509 RID: 9481
		private static readonly IntPtr NativeMethodInfoPtr_set_RotationOffset_Public_set_Void_Vector3_0;

		// Token: 0x0400250A RID: 9482
		private static readonly IntPtr NativeMethodInfoPtr_get_IsFirstPerson_Public_get_Boolean_0;

		// Token: 0x0400250B RID: 9483
		private static readonly IntPtr NativeMethodInfoPtr_get_DoTransformSync_Protected_Virtual_get_Boolean_0;

		// Token: 0x0400250C RID: 9484
		private static readonly IntPtr NativeMethodInfoPtr_get_FollowTarget_Public_get_DynamicInstance_0;

		// Token: 0x0400250D RID: 9485
		private static readonly IntPtr NativeMethodInfoPtr_set_FollowTarget_Public_set_Void_DynamicInstance_0;

		// Token: 0x0400250E RID: 9486
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400250F RID: 9487
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04002510 RID: 9488
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04002511 RID: 9489
		private static readonly IntPtr NativeMethodInfoPtr_SetFollowTarget_Private_Void_DynamicInstance_0;

		// Token: 0x04002512 RID: 9490
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04002513 RID: 9491
		private static readonly IntPtr NativeMethodInfoPtr_UpdateFollow_Private_Void_0;

		// Token: 0x04002514 RID: 9492
		private static readonly IntPtr NativeMethodInfoPtr_UpdateFollowTarget_Private_Void_0;

		// Token: 0x04002515 RID: 9493
		private static readonly IntPtr NativeMethodInfoPtr_UpdateFollowMode_Private_Void_Transform_0;

		// Token: 0x04002516 RID: 9494
		private static readonly IntPtr NativeMethodInfoPtr_HandleLockInput_Private_Void_0;

		// Token: 0x04002517 RID: 9495
		private static readonly IntPtr NativeMethodInfoPtr_HandleScrollInput_Private_Single_0;

		// Token: 0x04002518 RID: 9496
		private static readonly IntPtr NativeMethodInfoPtr_HandleFirstPersonRendering_Private_Void_0;

		// Token: 0x04002519 RID: 9497
		private static readonly IntPtr NativeMethodInfoPtr_ShouldProcessCameraInput_Private_Boolean_0;

		// Token: 0x0400251A RID: 9498
		private static readonly IntPtr NativeMethodInfoPtr_HandleCursorLocking_Private_Void_0;

		// Token: 0x0400251B RID: 9499
		private static readonly IntPtr NativeMethodInfoPtr_HandleCameraRotation_Private_Void_0;

		// Token: 0x0400251C RID: 9500
		private static readonly IntPtr NativeMethodInfoPtr_HandleScrollZoom_Private_Void_Single_0;

		// Token: 0x0400251D RID: 9501
		private static readonly IntPtr NativeMethodInfoPtr_ApplyCameraTransform_Private_Void_Transform_0;

		// Token: 0x0400251E RID: 9502
		private static readonly IntPtr NativeMethodInfoPtr_ClampDistance_Private_Void_0;

		// Token: 0x0400251F RID: 9503
		private static readonly IntPtr NativeMethodInfoPtr_CalculateWallClipping_Private_Void_Transform_0;

		// Token: 0x04002520 RID: 9504
		private static readonly IntPtr NativeMethodInfoPtr_UpdateFree_Private_Void_0;

		// Token: 0x04002521 RID: 9505
		private static readonly IntPtr NativeMethodInfoPtr_HandleFreeMovement_Private_Void_0;

		// Token: 0x04002522 RID: 9506
		private static readonly IntPtr NativeMethodInfoPtr_HandleFreeLook_Private_Void_0;

		// Token: 0x04002523 RID: 9507
		private static readonly IntPtr NativeMethodInfoPtr_HandleFreeZoom_Private_Void_0;

		// Token: 0x04002524 RID: 9508
		private static readonly IntPtr NativeMethodInfoPtr_HandleFreeLookToggle_Private_Void_0;

		// Token: 0x04002525 RID: 9509
		private static readonly IntPtr NativeMethodInfoPtr_StartLooking_Private_Void_0;

		// Token: 0x04002526 RID: 9510
		private static readonly IntPtr NativeMethodInfoPtr_StopLooking_Private_Void_0;

		// Token: 0x04002527 RID: 9511
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04002528 RID: 9512
		private static readonly IntPtr NativeMethodInfoPtr_ClampAngle_Private_Static_Single_Single_Single_Single_0;

		// Token: 0x04002529 RID: 9513
		private static readonly IntPtr NativeMethodInfoPtr_SetTarget_Public_Void_Transform_0;

		// Token: 0x0400252A RID: 9514
		private static readonly IntPtr NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0;
	}
}
