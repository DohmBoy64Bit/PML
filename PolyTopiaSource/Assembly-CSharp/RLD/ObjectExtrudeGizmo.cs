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
	// Token: 0x0200006C RID: 108
	[Serializable]
	public class ObjectExtrudeGizmo : GizmoBehaviour
	{
		// Token: 0x0600079D RID: 1949 RVA: 0x0003ED08 File Offset: 0x0003CF08
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectExtrudeGizmo()
		{
			Il2CppClassPointerStore<ObjectExtrudeGizmo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "ObjectExtrudeGizmo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectExtrudeGizmo>.NativeClassPtr);
			ObjectExtrudeGizmo.NativeFieldInfoPtr_ExtrudeUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectExtrudeGizmo>.NativeClassPtr, "ExtrudeUpdate");
			ObjectExtrudeGizmo.NativeFieldInfoPtr__objectBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectExtrudeGizmo>.NativeClassPtr, "_objectBuffer");
			ObjectExtrudeGizmo.NativeFieldInfoPtr__boxSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectExtrudeGizmo>.NativeClassPtr, "_boxSize");
			ObjectExtrudeGizmo.NativeFieldInfoPtr__extrudeSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectExtrudeGizmo>.NativeClassPtr, "_extrudeSpace");
			ObjectExtrudeGizmo.NativeFieldInfoPtr__targetParents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectExtrudeGizmo>.NativeClassPtr, "_targetParents");
			ObjectExtrudeGizmo.NativeFieldInfoPtr__ignoredParentObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectExtrudeGizmo>.NativeClassPtr, "_ignoredParentObjects");
			ObjectExtrudeGizmo.NativeFieldInfoPtr__boundsQConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectExtrudeGizmo>.NativeClassPtr, "_boundsQConfig");
			ObjectExtrudeGizmo.NativeFieldInfoPtr__sceneOverlapFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectExtrudeGizmo>.NativeClassPtr, "_sceneOverlapFilter");
			ObjectExtrudeGizmo.NativeFieldInfoPtr__dragEndAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectExtrudeGizmo>.NativeClassPtr, "_dragEndAction");
			ObjectExtrudeGizmo.NativeFieldInfoPtr__handleDragExtrData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectExtrudeGizmo>.NativeClassPtr, "_handleDragExtrData");
			ObjectExtrudeGizmo.NativeFieldInfoPtr__rightExtrude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectExtrudeGizmo>.NativeClassPtr, "_rightExtrude");
			ObjectExtrudeGizmo.NativeFieldInfoPtr__upExtrude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectExtrudeGizmo>.NativeClassPtr, "_upExtrude");
			ObjectExtrudeGizmo.NativeFieldInfoPtr__frontExtrude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectExtrudeGizmo>.NativeClassPtr, "_frontExtrude");
			ObjectExtrudeGizmo.NativeFieldInfoPtr__leftExtrude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectExtrudeGizmo>.NativeClassPtr, "_leftExtrude");
			ObjectExtrudeGizmo.NativeFieldInfoPtr__bottomExtrude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectExtrudeGizmo>.NativeClassPtr, "_bottomExtrude");
			ObjectExtrudeGizmo.NativeFieldInfoPtr__backExtrude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectExtrudeGizmo>.NativeClassPtr, "_backExtrude");
			ObjectExtrudeGizmo.NativeFieldInfoPtr__extrudeSliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectExtrudeGizmo>.NativeClassPtr, "_extrudeSliders");
			ObjectExtrudeGizmo.NativeFieldInfoPtr__lookAndFeel3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectExtrudeGizmo>.NativeClassPtr, "_lookAndFeel3D");
			ObjectExtrudeGizmo.NativeFieldInfoPtr__sharedLookAndFeel3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectExtrudeGizmo>.NativeClassPtr, "_sharedLookAndFeel3D");
			ObjectExtrudeGizmo.NativeFieldInfoPtr__hotkeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectExtrudeGizmo>.NativeClassPtr, "_hotkeys");
			ObjectExtrudeGizmo.NativeFieldInfoPtr__sharedHotkeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectExtrudeGizmo>.NativeClassPtr, "_sharedHotkeys");
			ObjectExtrudeGizmo.NativeMethodInfoPtr_get_LookAndFeel3D_Public_get_ObjectExtrudeGizmoLookAndFeel3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmo>.NativeClassPtr, 100664450);
			ObjectExtrudeGizmo.NativeMethodInfoPtr_get_SharedLookAndFeel3D_Public_get_ObjectExtrudeGizmoLookAndFeel3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmo>.NativeClassPtr, 100664451);
			ObjectExtrudeGizmo.NativeMethodInfoPtr_set_SharedLookAndFeel3D_Public_set_Void_ObjectExtrudeGizmoLookAndFeel3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmo>.NativeClassPtr, 100664452);
			ObjectExtrudeGizmo.NativeMethodInfoPtr_get_Hotkeys_Public_get_ObjectExtrudeGizmoHotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmo>.NativeClassPtr, 100664453);
			ObjectExtrudeGizmo.NativeMethodInfoPtr_get_SharedHotkeys_Public_get_ObjectExtrudeGizmoHotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmo>.NativeClassPtr, 100664454);
			ObjectExtrudeGizmo.NativeMethodInfoPtr_set_SharedHotkeys_Public_set_Void_ObjectExtrudeGizmoHotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmo>.NativeClassPtr, 100664455);
			ObjectExtrudeGizmo.NativeMethodInfoPtr_get_BoxCenter_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmo>.NativeClassPtr, 100664456);
			ObjectExtrudeGizmo.NativeMethodInfoPtr_get_BoxRotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmo>.NativeClassPtr, 100664457);
			ObjectExtrudeGizmo.NativeMethodInfoPtr_get_BoxSize_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmo>.NativeClassPtr, 100664458);
			ObjectExtrudeGizmo.NativeMethodInfoPtr_get_BoxRight_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmo>.NativeClassPtr, 100664459);
			ObjectExtrudeGizmo.NativeMethodInfoPtr_get_BoxUp_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmo>.NativeClassPtr, 100664460);
			ObjectExtrudeGizmo.NativeMethodInfoPtr_get_BoxLook_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmo>.NativeClassPtr, 100664461);
			ObjectExtrudeGizmo.NativeMethodInfoPtr_get_OBB_Public_get_OBB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmo>.NativeClassPtr, 100664462);
			ObjectExtrudeGizmo.NativeMethodInfoPtr_get_ExtrudeSpace_Public_get_GizmoSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmo>.NativeClassPtr, 100664463);
			ObjectExtrudeGizmo.NativeMethodInfoPtr_get_NumTargetParents_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmo>.NativeClassPtr, 100664464);
			ObjectExtrudeGizmo.NativeMethodInfoPtr_add_ExtrudeUpdate_Public_add_Void_ObjectExtrudeGizmoExtrudeUpdateHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmo>.NativeClassPtr, 100664448);
			ObjectExtrudeGizmo.NativeMethodInfoPtr_remove_ExtrudeUpdate_Public_rem_Void_ObjectExtrudeGizmoExtrudeUpdateHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmo>.NativeClassPtr, 100664449);
			ObjectExtrudeGizmo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmo>.NativeClassPtr, 100664494);
			ObjectExtrudeGizmo.NativeMethodInfoPtr_OwnsHandle_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmo>.NativeClassPtr, 100664465);
			ObjectExtrudeGizmo.NativeMethodInfoPtr_IsRightExtrudeHandle_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmo>.NativeClassPtr, 100664466);
			ObjectExtrudeGizmo.NativeMethodInfoPtr_IsLeftExtrudeHandle_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmo>.NativeClassPtr, 100664467);
			ObjectExtrudeGizmo.NativeMethodInfoPtr_IsTopExtrudeHandle_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmo>.NativeClassPtr, 100664468);
			ObjectExtrudeGizmo.NativeMethodInfoPtr_IsBottomExtrudeHandle_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmo>.NativeClassPtr, 100664469);
			ObjectExtrudeGizmo.NativeMethodInfoPtr_IsFrontExtrudeHandle_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmo>.NativeClassPtr, 100664470);
			ObjectExtrudeGizmo.NativeMethodInfoPtr_IsBackExtrudeHandle_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmo>.NativeClassPtr, 100664471);
			ObjectExtrudeGizmo.NativeMethodInfoPtr_SetIgnoredParentObjects_Public_Void_IEnumerable_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmo>.NativeClassPtr, 100664472);
			ObjectExtrudeGizmo.NativeMethodInfoPtr_SetExtrudeSpace_Public_Void_GizmoSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmo>.NativeClassPtr, 100664473);
			ObjectExtrudeGizmo.NativeMethodInfoPtr_SetExtrudeTargets_Public_Void_IEnumerable_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmo>.NativeClassPtr, 100664474);
			ObjectExtrudeGizmo.NativeMethodInfoPtr_FitBoxToTargets_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmo>.NativeClassPtr, 100664475);
			ObjectExtrudeGizmo.NativeMethodInfoPtr_OnDetached_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmo>.NativeClassPtr, 100664476);
			ObjectExtrudeGizmo.NativeMethodInfoPtr_OnEnabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmo>.NativeClassPtr, 100664477);
			ObjectExtrudeGizmo.NativeMethodInfoPtr_OnDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmo>.NativeClassPtr, 100664478);
			ObjectExtrudeGizmo.NativeMethodInfoPtr_OnGizmoEnabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmo>.NativeClassPtr, 100664479);
			ObjectExtrudeGizmo.NativeMethodInfoPtr_OnAttached_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmo>.NativeClassPtr, 100664480);
			ObjectExtrudeGizmo.NativeMethodInfoPtr_OnGizmoUpdateBegin_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmo>.NativeClassPtr, 100664481);
			ObjectExtrudeGizmo.NativeMethodInfoPtr_OnGizmoRender_Public_Virtual_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmo>.NativeClassPtr, 100664482);
			ObjectExtrudeGizmo.NativeMethodInfoPtr_OnGizmoDragBegin_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmo>.NativeClassPtr, 100664483);
			ObjectExtrudeGizmo.NativeMethodInfoPtr_OnGizmoDragUpdate_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmo>.NativeClassPtr, 100664484);
			ObjectExtrudeGizmo.NativeMethodInfoPtr_OnGizmoDragEnd_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmo>.NativeClassPtr, 100664485);
			ObjectExtrudeGizmo.NativeMethodInfoPtr_UpdateExtrudeSliderTransforms_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmo>.NativeClassPtr, 100664486);
			ObjectExtrudeGizmo.NativeMethodInfoPtr_OnGizmoTransformChanged_Private_Void_GizmoTransform_ChangeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmo>.NativeClassPtr, 100664487);
			ObjectExtrudeGizmo.NativeMethodInfoPtr_SetAABB_Private_Void_AABB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmo>.NativeClassPtr, 100664488);
			ObjectExtrudeGizmo.NativeMethodInfoPtr_SetOBB_Private_Void_OBB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmo>.NativeClassPtr, 100664489);
			ObjectExtrudeGizmo.NativeMethodInfoPtr_UpdateSnapSteps_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmo>.NativeClassPtr, 100664490);
			ObjectExtrudeGizmo.NativeMethodInfoPtr_ValidateBoxSize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmo>.NativeClassPtr, 100664491);
			ObjectExtrudeGizmo.NativeMethodInfoPtr_SetupSharedLookAndFeel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmo>.NativeClassPtr, 100664492);
			ObjectExtrudeGizmo.NativeMethodInfoPtr_OnUndoRedoEnd_Private_Void_IUndoRedoAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmo>.NativeClassPtr, 100664493);
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x0600079E RID: 1950 RVA: 0x0003F288 File Offset: 0x0003D488
		public unsafe ObjectExtrudeGizmoLookAndFeel3D LookAndFeel3D
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 62245, RefRangeEnd = 62251, XrefRangeStart = 62245, XrefRangeEnd = 62245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmo.NativeMethodInfoPtr_get_LookAndFeel3D_Public_get_ObjectExtrudeGizmoLookAndFeel3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectExtrudeGizmoLookAndFeel3D>(intPtr3) : null;
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x0600079F RID: 1951 RVA: 0x0003F2C8 File Offset: 0x0003D4C8
		// (set) Token: 0x060007A0 RID: 1952 RVA: 0x0003F308 File Offset: 0x0003D508
		public unsafe ObjectExtrudeGizmoLookAndFeel3D SharedLookAndFeel3D
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmo.NativeMethodInfoPtr_get_SharedLookAndFeel3D_Public_get_ObjectExtrudeGizmoLookAndFeel3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectExtrudeGizmoLookAndFeel3D>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 62253, RefRangeEnd = 62254, XrefRangeStart = 62251, XrefRangeEnd = 62253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmo.NativeMethodInfoPtr_set_SharedLookAndFeel3D_Public_set_Void_ObjectExtrudeGizmoLookAndFeel3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x060007A1 RID: 1953 RVA: 0x0003F34C File Offset: 0x0003D54C
		public unsafe ObjectExtrudeGizmoHotkeys Hotkeys
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmo.NativeMethodInfoPtr_get_Hotkeys_Public_get_ObjectExtrudeGizmoHotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectExtrudeGizmoHotkeys>(intPtr3) : null;
			}
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x060007A2 RID: 1954 RVA: 0x0003F38C File Offset: 0x0003D58C
		// (set) Token: 0x060007A3 RID: 1955 RVA: 0x0003F3CC File Offset: 0x0003D5CC
		public unsafe ObjectExtrudeGizmoHotkeys SharedHotkeys
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmo.NativeMethodInfoPtr_get_SharedHotkeys_Public_get_ObjectExtrudeGizmoHotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectExtrudeGizmoHotkeys>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmo.NativeMethodInfoPtr_set_SharedHotkeys_Public_set_Void_ObjectExtrudeGizmoHotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x060007A4 RID: 1956 RVA: 0x0003F410 File Offset: 0x0003D610
		public unsafe Vector3 BoxCenter
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmo.NativeMethodInfoPtr_get_BoxCenter_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x060007A5 RID: 1957 RVA: 0x0003F450 File Offset: 0x0003D650
		public unsafe Quaternion BoxRotation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmo.NativeMethodInfoPtr_get_BoxRotation_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr3) : null;
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x060007A6 RID: 1958 RVA: 0x0003F490 File Offset: 0x0003D690
		public unsafe Vector3 BoxSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmo.NativeMethodInfoPtr_get_BoxSize_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x060007A7 RID: 1959 RVA: 0x0003F4D0 File Offset: 0x0003D6D0
		public unsafe Vector3 BoxRight
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 62257, RefRangeEnd = 62259, XrefRangeStart = 62254, XrefRangeEnd = 62257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmo.NativeMethodInfoPtr_get_BoxRight_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x060007A8 RID: 1960 RVA: 0x0003F510 File Offset: 0x0003D710
		public unsafe Vector3 BoxUp
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 62262, RefRangeEnd = 62264, XrefRangeStart = 62259, XrefRangeEnd = 62262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmo.NativeMethodInfoPtr_get_BoxUp_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x060007A9 RID: 1961 RVA: 0x0003F550 File Offset: 0x0003D750
		public unsafe Vector3 BoxLook
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 62267, RefRangeEnd = 62271, XrefRangeStart = 62264, XrefRangeEnd = 62267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmo.NativeMethodInfoPtr_get_BoxLook_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x060007AA RID: 1962 RVA: 0x0003F590 File Offset: 0x0003D790
		public unsafe OBB OBB
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62271, XrefRangeEnd = 62272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmo.NativeMethodInfoPtr_get_OBB_Public_get_OBB_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<OBB>(intPtr3) : null;
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x060007AB RID: 1963 RVA: 0x0003F5D0 File Offset: 0x0003D7D0
		public unsafe GizmoSpace ExtrudeSpace
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmo.NativeMethodInfoPtr_get_ExtrudeSpace_Public_get_GizmoSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoSpace>(intPtr3) : null;
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x060007AC RID: 1964 RVA: 0x0003F610 File Offset: 0x0003D810
		public unsafe int NumTargetParents
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 62273, RefRangeEnd = 62274, XrefRangeStart = 62272, XrefRangeEnd = 62273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmo.NativeMethodInfoPtr_get_NumTargetParents_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x0003F64C File Offset: 0x0003D84C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62274, XrefRangeEnd = 62278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_ExtrudeUpdate(ObjectExtrudeGizmoExtrudeUpdateHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmo.NativeMethodInfoPtr_add_ExtrudeUpdate_Public_add_Void_ObjectExtrudeGizmoExtrudeUpdateHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x0003F690 File Offset: 0x0003D890
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62278, XrefRangeEnd = 62282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_ExtrudeUpdate(ObjectExtrudeGizmoExtrudeUpdateHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmo.NativeMethodInfoPtr_remove_ExtrudeUpdate_Public_rem_Void_ObjectExtrudeGizmoExtrudeUpdateHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x0003F6D4 File Offset: 0x0003D8D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 62332, RefRangeEnd = 62333, XrefRangeStart = 62282, XrefRangeEnd = 62332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectExtrudeGizmo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectExtrudeGizmo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x0003F710 File Offset: 0x0003D910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62333, XrefRangeEnd = 62334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool OwnsHandle(int handleId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handleId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmo.NativeMethodInfoPtr_OwnsHandle_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x0003F75C File Offset: 0x0003D95C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62334, XrefRangeEnd = 62335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsRightExtrudeHandle(int handleId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handleId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmo.NativeMethodInfoPtr_IsRightExtrudeHandle_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x0003F7A8 File Offset: 0x0003D9A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62335, XrefRangeEnd = 62336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsLeftExtrudeHandle(int handleId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handleId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmo.NativeMethodInfoPtr_IsLeftExtrudeHandle_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x0003F7F4 File Offset: 0x0003D9F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62336, XrefRangeEnd = 62337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTopExtrudeHandle(int handleId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handleId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmo.NativeMethodInfoPtr_IsTopExtrudeHandle_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x0003F840 File Offset: 0x0003DA40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62337, XrefRangeEnd = 62338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsBottomExtrudeHandle(int handleId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handleId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmo.NativeMethodInfoPtr_IsBottomExtrudeHandle_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x0003F88C File Offset: 0x0003DA8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62338, XrefRangeEnd = 62339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsFrontExtrudeHandle(int handleId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handleId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmo.NativeMethodInfoPtr_IsFrontExtrudeHandle_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x0003F8D8 File Offset: 0x0003DAD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62339, XrefRangeEnd = 62340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsBackExtrudeHandle(int handleId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handleId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmo.NativeMethodInfoPtr_IsBackExtrudeHandle_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x0003F924 File Offset: 0x0003DB24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62340, XrefRangeEnd = 62363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIgnoredParentObjects(IEnumerable<GameObject> ignoredParentObjects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ignoredParentObjects);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmo.NativeMethodInfoPtr_SetIgnoredParentObjects_Public_Void_IEnumerable_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x0003F968 File Offset: 0x0003DB68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 62364, RefRangeEnd = 62365, XrefRangeStart = 62363, XrefRangeEnd = 62364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetExtrudeSpace(GizmoSpace extrudeSpace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(extrudeSpace);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmo.NativeMethodInfoPtr_SetExtrudeSpace_Public_Void_GizmoSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x0003F9AC File Offset: 0x0003DBAC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 62390, RefRangeEnd = 62393, XrefRangeStart = 62365, XrefRangeEnd = 62390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetExtrudeTargets(IEnumerable<GameObject> extrudeTargets)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(extrudeTargets);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmo.NativeMethodInfoPtr_SetExtrudeTargets_Public_Void_IEnumerable_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x0003F9F0 File Offset: 0x0003DBF0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 62428, RefRangeEnd = 62432, XrefRangeStart = 62393, XrefRangeEnd = 62428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FitBoxToTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmo.NativeMethodInfoPtr_FitBoxToTargets_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x0003FA24 File Offset: 0x0003DC24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62432, XrefRangeEnd = 62461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDetached()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectExtrudeGizmo.NativeMethodInfoPtr_OnDetached_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x0003FA60 File Offset: 0x0003DC60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62461, XrefRangeEnd = 62469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectExtrudeGizmo.NativeMethodInfoPtr_OnEnabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x0003FA9C File Offset: 0x0003DC9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62469, XrefRangeEnd = 62477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectExtrudeGizmo.NativeMethodInfoPtr_OnDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x0003FAD8 File Offset: 0x0003DCD8
		[CallerCount(0)]
		public unsafe override void OnGizmoEnabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectExtrudeGizmo.NativeMethodInfoPtr_OnGizmoEnabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007BF RID: 1983 RVA: 0x0003FB14 File Offset: 0x0003DD14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62477, XrefRangeEnd = 62549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnAttached()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectExtrudeGizmo.NativeMethodInfoPtr_OnAttached_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x0003FB50 File Offset: 0x0003DD50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62549, XrefRangeEnd = 62557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnGizmoUpdateBegin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectExtrudeGizmo.NativeMethodInfoPtr_OnGizmoUpdateBegin_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007C1 RID: 1985 RVA: 0x0003FB8C File Offset: 0x0003DD8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62557, XrefRangeEnd = 62596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnGizmoRender(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectExtrudeGizmo.NativeMethodInfoPtr_OnGizmoRender_Public_Virtual_Void_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007C2 RID: 1986 RVA: 0x0003FBDC File Offset: 0x0003DDDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62596, XrefRangeEnd = 62643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnGizmoDragBegin(int handleId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handleId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectExtrudeGizmo.NativeMethodInfoPtr_OnGizmoDragBegin_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007C3 RID: 1987 RVA: 0x0003FC28 File Offset: 0x0003DE28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62643, XrefRangeEnd = 62755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnGizmoDragUpdate(int handleId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handleId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectExtrudeGizmo.NativeMethodInfoPtr_OnGizmoDragUpdate_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x0003FC74 File Offset: 0x0003DE74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62755, XrefRangeEnd = 62759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnGizmoDragEnd(int handleId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handleId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectExtrudeGizmo.NativeMethodInfoPtr_OnGizmoDragEnd_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x0003FCC0 File Offset: 0x0003DEC0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 62798, RefRangeEnd = 62801, XrefRangeStart = 62759, XrefRangeEnd = 62798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateExtrudeSliderTransforms()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmo.NativeMethodInfoPtr_UpdateExtrudeSliderTransforms_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x0003FCF4 File Offset: 0x0003DEF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62801, XrefRangeEnd = 62802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGizmoTransformChanged(GizmoTransform gizmoTransform, GizmoTransform.ChangeData changeData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gizmoTransform);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref changeData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmo.NativeMethodInfoPtr_OnGizmoTransformChanged_Private_Void_GizmoTransform_ChangeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x0003FD44 File Offset: 0x0003DF44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62802, XrefRangeEnd = 62807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAABB(AABB aabb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(aabb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmo.NativeMethodInfoPtr_SetAABB_Private_Void_AABB_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007C8 RID: 1992 RVA: 0x0003FD88 File Offset: 0x0003DF88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 62810, RefRangeEnd = 62811, XrefRangeStart = 62807, XrefRangeEnd = 62810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOBB(OBB obb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmo.NativeMethodInfoPtr_SetOBB_Private_Void_OBB_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x0003FDCC File Offset: 0x0003DFCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 62824, RefRangeEnd = 62825, XrefRangeStart = 62811, XrefRangeEnd = 62824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSnapSteps()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmo.NativeMethodInfoPtr_UpdateSnapSteps_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x0003FE00 File Offset: 0x0003E000
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 62838, RefRangeEnd = 62840, XrefRangeStart = 62825, XrefRangeEnd = 62838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateBoxSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmo.NativeMethodInfoPtr_ValidateBoxSize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007CB RID: 1995 RVA: 0x0003FE34 File Offset: 0x0003E034
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 62848, RefRangeEnd = 62850, XrefRangeStart = 62840, XrefRangeEnd = 62848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupSharedLookAndFeel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmo.NativeMethodInfoPtr_SetupSharedLookAndFeel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x0003FE68 File Offset: 0x0003E068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62850, XrefRangeEnd = 62853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnUndoRedoEnd(IUndoRedoAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmo.NativeMethodInfoPtr_OnUndoRedoEnd_Private_Void_IUndoRedoAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x0000487B File Offset: 0x00002A7B
		public ObjectExtrudeGizmo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x060007CE RID: 1998 RVA: 0x0003FEAC File Offset: 0x0003E0AC
		// (set) Token: 0x060007CF RID: 1999 RVA: 0x00004884 File Offset: 0x00002A84
		public unsafe ObjectExtrudeGizmoExtrudeUpdateHandler ExtrudeUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectExtrudeGizmo.NativeFieldInfoPtr_ExtrudeUpdate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectExtrudeGizmoExtrudeUpdateHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectExtrudeGizmo.NativeFieldInfoPtr_ExtrudeUpdate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x060007D0 RID: 2000 RVA: 0x0003FEDC File Offset: 0x0003E0DC
		// (set) Token: 0x060007D1 RID: 2001 RVA: 0x000048A3 File Offset: 0x00002AA3
		public unsafe List<GameObject> _objectBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectExtrudeGizmo.NativeFieldInfoPtr__objectBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectExtrudeGizmo.NativeFieldInfoPtr__objectBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x060007D2 RID: 2002 RVA: 0x0003FF0C File Offset: 0x0003E10C
		// (set) Token: 0x060007D3 RID: 2003 RVA: 0x000048C2 File Offset: 0x00002AC2
		public unsafe Vector3 _boxSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectExtrudeGizmo.NativeFieldInfoPtr__boxSize);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectExtrudeGizmo.NativeFieldInfoPtr__boxSize), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x060007D4 RID: 2004 RVA: 0x0003FF3C File Offset: 0x0003E13C
		// (set) Token: 0x060007D5 RID: 2005 RVA: 0x000048E1 File Offset: 0x00002AE1
		public unsafe GizmoSpace _extrudeSpace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectExtrudeGizmo.NativeFieldInfoPtr__extrudeSpace);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoSpace>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectExtrudeGizmo.NativeFieldInfoPtr__extrudeSpace), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x060007D6 RID: 2006 RVA: 0x0003FF6C File Offset: 0x0003E16C
		// (set) Token: 0x060007D7 RID: 2007 RVA: 0x00004900 File Offset: 0x00002B00
		public unsafe List<GameObject> _targetParents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectExtrudeGizmo.NativeFieldInfoPtr__targetParents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectExtrudeGizmo.NativeFieldInfoPtr__targetParents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x060007D8 RID: 2008 RVA: 0x0003FF9C File Offset: 0x0003E19C
		// (set) Token: 0x060007D9 RID: 2009 RVA: 0x0000491F File Offset: 0x00002B1F
		public unsafe HashSet<GameObject> _ignoredParentObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectExtrudeGizmo.NativeFieldInfoPtr__ignoredParentObjects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectExtrudeGizmo.NativeFieldInfoPtr__ignoredParentObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x060007DA RID: 2010 RVA: 0x0003FFCC File Offset: 0x0003E1CC
		// (set) Token: 0x060007DB RID: 2011 RVA: 0x0000493E File Offset: 0x00002B3E
		public unsafe ObjectBounds.QueryConfig _boundsQConfig
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectExtrudeGizmo.NativeFieldInfoPtr__boundsQConfig);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectExtrudeGizmo.NativeFieldInfoPtr__boundsQConfig)) = value;
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x060007DC RID: 2012 RVA: 0x0003FFF4 File Offset: 0x0003E1F4
		// (set) Token: 0x060007DD RID: 2013 RVA: 0x00004959 File Offset: 0x00002B59
		public unsafe SceneOverlapFilter _sceneOverlapFilter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectExtrudeGizmo.NativeFieldInfoPtr__sceneOverlapFilter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneOverlapFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectExtrudeGizmo.NativeFieldInfoPtr__sceneOverlapFilter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x060007DE RID: 2014 RVA: 0x00040024 File Offset: 0x0003E224
		// (set) Token: 0x060007DF RID: 2015 RVA: 0x00004978 File Offset: 0x00002B78
		public unsafe ObjectExtrudeGizmoDragEnd _dragEndAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectExtrudeGizmo.NativeFieldInfoPtr__dragEndAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectExtrudeGizmoDragEnd>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectExtrudeGizmo.NativeFieldInfoPtr__dragEndAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x060007E0 RID: 2016 RVA: 0x00040054 File Offset: 0x0003E254
		// (set) Token: 0x060007E1 RID: 2017 RVA: 0x00004997 File Offset: 0x00002B97
		public unsafe ObjectExtrudeGizmo.HandleDragExtrudeData _handleDragExtrData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectExtrudeGizmo.NativeFieldInfoPtr__handleDragExtrData);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectExtrudeGizmo.NativeFieldInfoPtr__handleDragExtrData)) = value;
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x060007E2 RID: 2018 RVA: 0x0004007C File Offset: 0x0003E27C
		// (set) Token: 0x060007E3 RID: 2019 RVA: 0x000049B2 File Offset: 0x00002BB2
		public unsafe GizmoLineSlider3D _rightExtrude
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectExtrudeGizmo.NativeFieldInfoPtr__rightExtrude);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoLineSlider3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectExtrudeGizmo.NativeFieldInfoPtr__rightExtrude), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x060007E4 RID: 2020 RVA: 0x000400AC File Offset: 0x0003E2AC
		// (set) Token: 0x060007E5 RID: 2021 RVA: 0x000049D1 File Offset: 0x00002BD1
		public unsafe GizmoLineSlider3D _upExtrude
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectExtrudeGizmo.NativeFieldInfoPtr__upExtrude);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoLineSlider3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectExtrudeGizmo.NativeFieldInfoPtr__upExtrude), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x060007E6 RID: 2022 RVA: 0x000400DC File Offset: 0x0003E2DC
		// (set) Token: 0x060007E7 RID: 2023 RVA: 0x000049F0 File Offset: 0x00002BF0
		public unsafe GizmoLineSlider3D _frontExtrude
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectExtrudeGizmo.NativeFieldInfoPtr__frontExtrude);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoLineSlider3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectExtrudeGizmo.NativeFieldInfoPtr__frontExtrude), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x060007E8 RID: 2024 RVA: 0x0004010C File Offset: 0x0003E30C
		// (set) Token: 0x060007E9 RID: 2025 RVA: 0x00004A0F File Offset: 0x00002C0F
		public unsafe GizmoLineSlider3D _leftExtrude
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectExtrudeGizmo.NativeFieldInfoPtr__leftExtrude);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoLineSlider3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectExtrudeGizmo.NativeFieldInfoPtr__leftExtrude), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x060007EA RID: 2026 RVA: 0x0004013C File Offset: 0x0003E33C
		// (set) Token: 0x060007EB RID: 2027 RVA: 0x00004A2E File Offset: 0x00002C2E
		public unsafe GizmoLineSlider3D _bottomExtrude
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectExtrudeGizmo.NativeFieldInfoPtr__bottomExtrude);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoLineSlider3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectExtrudeGizmo.NativeFieldInfoPtr__bottomExtrude), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x060007EC RID: 2028 RVA: 0x0004016C File Offset: 0x0003E36C
		// (set) Token: 0x060007ED RID: 2029 RVA: 0x00004A4D File Offset: 0x00002C4D
		public unsafe GizmoLineSlider3D _backExtrude
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectExtrudeGizmo.NativeFieldInfoPtr__backExtrude);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoLineSlider3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectExtrudeGizmo.NativeFieldInfoPtr__backExtrude), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x060007EE RID: 2030 RVA: 0x0004019C File Offset: 0x0003E39C
		// (set) Token: 0x060007EF RID: 2031 RVA: 0x00004A6C File Offset: 0x00002C6C
		public unsafe GizmoLineSlider3DCollection _extrudeSliders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectExtrudeGizmo.NativeFieldInfoPtr__extrudeSliders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoLineSlider3DCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectExtrudeGizmo.NativeFieldInfoPtr__extrudeSliders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x060007F0 RID: 2032 RVA: 0x000401CC File Offset: 0x0003E3CC
		// (set) Token: 0x060007F1 RID: 2033 RVA: 0x00004A8B File Offset: 0x00002C8B
		public unsafe ObjectExtrudeGizmoLookAndFeel3D _lookAndFeel3D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectExtrudeGizmo.NativeFieldInfoPtr__lookAndFeel3D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectExtrudeGizmoLookAndFeel3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectExtrudeGizmo.NativeFieldInfoPtr__lookAndFeel3D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x060007F2 RID: 2034 RVA: 0x000401FC File Offset: 0x0003E3FC
		// (set) Token: 0x060007F3 RID: 2035 RVA: 0x00004AAA File Offset: 0x00002CAA
		public unsafe ObjectExtrudeGizmoLookAndFeel3D _sharedLookAndFeel3D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectExtrudeGizmo.NativeFieldInfoPtr__sharedLookAndFeel3D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectExtrudeGizmoLookAndFeel3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectExtrudeGizmo.NativeFieldInfoPtr__sharedLookAndFeel3D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x060007F4 RID: 2036 RVA: 0x0004022C File Offset: 0x0003E42C
		// (set) Token: 0x060007F5 RID: 2037 RVA: 0x00004AC9 File Offset: 0x00002CC9
		public unsafe ObjectExtrudeGizmoHotkeys _hotkeys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectExtrudeGizmo.NativeFieldInfoPtr__hotkeys);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectExtrudeGizmoHotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectExtrudeGizmo.NativeFieldInfoPtr__hotkeys), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x060007F6 RID: 2038 RVA: 0x0004025C File Offset: 0x0003E45C
		// (set) Token: 0x060007F7 RID: 2039 RVA: 0x00004AE8 File Offset: 0x00002CE8
		public unsafe ObjectExtrudeGizmoHotkeys _sharedHotkeys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectExtrudeGizmo.NativeFieldInfoPtr__sharedHotkeys);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectExtrudeGizmoHotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectExtrudeGizmo.NativeFieldInfoPtr__sharedHotkeys), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005D5 RID: 1493
		private static readonly IntPtr NativeFieldInfoPtr_ExtrudeUpdate;

		// Token: 0x040005D6 RID: 1494
		private static readonly IntPtr NativeFieldInfoPtr__objectBuffer;

		// Token: 0x040005D7 RID: 1495
		private static readonly IntPtr NativeFieldInfoPtr__boxSize;

		// Token: 0x040005D8 RID: 1496
		private static readonly IntPtr NativeFieldInfoPtr__extrudeSpace;

		// Token: 0x040005D9 RID: 1497
		private static readonly IntPtr NativeFieldInfoPtr__targetParents;

		// Token: 0x040005DA RID: 1498
		private static readonly IntPtr NativeFieldInfoPtr__ignoredParentObjects;

		// Token: 0x040005DB RID: 1499
		private static readonly IntPtr NativeFieldInfoPtr__boundsQConfig;

		// Token: 0x040005DC RID: 1500
		private static readonly IntPtr NativeFieldInfoPtr__sceneOverlapFilter;

		// Token: 0x040005DD RID: 1501
		private static readonly IntPtr NativeFieldInfoPtr__dragEndAction;

		// Token: 0x040005DE RID: 1502
		private static readonly IntPtr NativeFieldInfoPtr__handleDragExtrData;

		// Token: 0x040005DF RID: 1503
		private static readonly IntPtr NativeFieldInfoPtr__rightExtrude;

		// Token: 0x040005E0 RID: 1504
		private static readonly IntPtr NativeFieldInfoPtr__upExtrude;

		// Token: 0x040005E1 RID: 1505
		private static readonly IntPtr NativeFieldInfoPtr__frontExtrude;

		// Token: 0x040005E2 RID: 1506
		private static readonly IntPtr NativeFieldInfoPtr__leftExtrude;

		// Token: 0x040005E3 RID: 1507
		private static readonly IntPtr NativeFieldInfoPtr__bottomExtrude;

		// Token: 0x040005E4 RID: 1508
		private static readonly IntPtr NativeFieldInfoPtr__backExtrude;

		// Token: 0x040005E5 RID: 1509
		private static readonly IntPtr NativeFieldInfoPtr__extrudeSliders;

		// Token: 0x040005E6 RID: 1510
		private static readonly IntPtr NativeFieldInfoPtr__lookAndFeel3D;

		// Token: 0x040005E7 RID: 1511
		private static readonly IntPtr NativeFieldInfoPtr__sharedLookAndFeel3D;

		// Token: 0x040005E8 RID: 1512
		private static readonly IntPtr NativeFieldInfoPtr__hotkeys;

		// Token: 0x040005E9 RID: 1513
		private static readonly IntPtr NativeFieldInfoPtr__sharedHotkeys;

		// Token: 0x040005EA RID: 1514
		private static readonly IntPtr NativeMethodInfoPtr_get_LookAndFeel3D_Public_get_ObjectExtrudeGizmoLookAndFeel3D_0;

		// Token: 0x040005EB RID: 1515
		private static readonly IntPtr NativeMethodInfoPtr_get_SharedLookAndFeel3D_Public_get_ObjectExtrudeGizmoLookAndFeel3D_0;

		// Token: 0x040005EC RID: 1516
		private static readonly IntPtr NativeMethodInfoPtr_set_SharedLookAndFeel3D_Public_set_Void_ObjectExtrudeGizmoLookAndFeel3D_0;

		// Token: 0x040005ED RID: 1517
		private static readonly IntPtr NativeMethodInfoPtr_get_Hotkeys_Public_get_ObjectExtrudeGizmoHotkeys_0;

		// Token: 0x040005EE RID: 1518
		private static readonly IntPtr NativeMethodInfoPtr_get_SharedHotkeys_Public_get_ObjectExtrudeGizmoHotkeys_0;

		// Token: 0x040005EF RID: 1519
		private static readonly IntPtr NativeMethodInfoPtr_set_SharedHotkeys_Public_set_Void_ObjectExtrudeGizmoHotkeys_0;

		// Token: 0x040005F0 RID: 1520
		private static readonly IntPtr NativeMethodInfoPtr_get_BoxCenter_Public_get_Vector3_0;

		// Token: 0x040005F1 RID: 1521
		private static readonly IntPtr NativeMethodInfoPtr_get_BoxRotation_Public_get_Quaternion_0;

		// Token: 0x040005F2 RID: 1522
		private static readonly IntPtr NativeMethodInfoPtr_get_BoxSize_Public_get_Vector3_0;

		// Token: 0x040005F3 RID: 1523
		private static readonly IntPtr NativeMethodInfoPtr_get_BoxRight_Public_get_Vector3_0;

		// Token: 0x040005F4 RID: 1524
		private static readonly IntPtr NativeMethodInfoPtr_get_BoxUp_Public_get_Vector3_0;

		// Token: 0x040005F5 RID: 1525
		private static readonly IntPtr NativeMethodInfoPtr_get_BoxLook_Public_get_Vector3_0;

		// Token: 0x040005F6 RID: 1526
		private static readonly IntPtr NativeMethodInfoPtr_get_OBB_Public_get_OBB_0;

		// Token: 0x040005F7 RID: 1527
		private static readonly IntPtr NativeMethodInfoPtr_get_ExtrudeSpace_Public_get_GizmoSpace_0;

		// Token: 0x040005F8 RID: 1528
		private static readonly IntPtr NativeMethodInfoPtr_get_NumTargetParents_Public_get_Int32_0;

		// Token: 0x040005F9 RID: 1529
		private static readonly IntPtr NativeMethodInfoPtr_add_ExtrudeUpdate_Public_add_Void_ObjectExtrudeGizmoExtrudeUpdateHandler_0;

		// Token: 0x040005FA RID: 1530
		private static readonly IntPtr NativeMethodInfoPtr_remove_ExtrudeUpdate_Public_rem_Void_ObjectExtrudeGizmoExtrudeUpdateHandler_0;

		// Token: 0x040005FB RID: 1531
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040005FC RID: 1532
		private static readonly IntPtr NativeMethodInfoPtr_OwnsHandle_Public_Boolean_Int32_0;

		// Token: 0x040005FD RID: 1533
		private static readonly IntPtr NativeMethodInfoPtr_IsRightExtrudeHandle_Public_Boolean_Int32_0;

		// Token: 0x040005FE RID: 1534
		private static readonly IntPtr NativeMethodInfoPtr_IsLeftExtrudeHandle_Public_Boolean_Int32_0;

		// Token: 0x040005FF RID: 1535
		private static readonly IntPtr NativeMethodInfoPtr_IsTopExtrudeHandle_Public_Boolean_Int32_0;

		// Token: 0x04000600 RID: 1536
		private static readonly IntPtr NativeMethodInfoPtr_IsBottomExtrudeHandle_Public_Boolean_Int32_0;

		// Token: 0x04000601 RID: 1537
		private static readonly IntPtr NativeMethodInfoPtr_IsFrontExtrudeHandle_Public_Boolean_Int32_0;

		// Token: 0x04000602 RID: 1538
		private static readonly IntPtr NativeMethodInfoPtr_IsBackExtrudeHandle_Public_Boolean_Int32_0;

		// Token: 0x04000603 RID: 1539
		private static readonly IntPtr NativeMethodInfoPtr_SetIgnoredParentObjects_Public_Void_IEnumerable_1_GameObject_0;

		// Token: 0x04000604 RID: 1540
		private static readonly IntPtr NativeMethodInfoPtr_SetExtrudeSpace_Public_Void_GizmoSpace_0;

		// Token: 0x04000605 RID: 1541
		private static readonly IntPtr NativeMethodInfoPtr_SetExtrudeTargets_Public_Void_IEnumerable_1_GameObject_0;

		// Token: 0x04000606 RID: 1542
		private static readonly IntPtr NativeMethodInfoPtr_FitBoxToTargets_Public_Void_0;

		// Token: 0x04000607 RID: 1543
		private static readonly IntPtr NativeMethodInfoPtr_OnDetached_Public_Virtual_Void_0;

		// Token: 0x04000608 RID: 1544
		private static readonly IntPtr NativeMethodInfoPtr_OnEnabled_Public_Virtual_Void_0;

		// Token: 0x04000609 RID: 1545
		private static readonly IntPtr NativeMethodInfoPtr_OnDisabled_Public_Virtual_Void_0;

		// Token: 0x0400060A RID: 1546
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoEnabled_Public_Virtual_Void_0;

		// Token: 0x0400060B RID: 1547
		private static readonly IntPtr NativeMethodInfoPtr_OnAttached_Public_Virtual_Void_0;

		// Token: 0x0400060C RID: 1548
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoUpdateBegin_Public_Virtual_Void_0;

		// Token: 0x0400060D RID: 1549
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoRender_Public_Virtual_Void_Camera_0;

		// Token: 0x0400060E RID: 1550
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoDragBegin_Public_Virtual_Void_Int32_0;

		// Token: 0x0400060F RID: 1551
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoDragUpdate_Public_Virtual_Void_Int32_0;

		// Token: 0x04000610 RID: 1552
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoDragEnd_Public_Virtual_Void_Int32_0;

		// Token: 0x04000611 RID: 1553
		private static readonly IntPtr NativeMethodInfoPtr_UpdateExtrudeSliderTransforms_Private_Void_0;

		// Token: 0x04000612 RID: 1554
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoTransformChanged_Private_Void_GizmoTransform_ChangeData_0;

		// Token: 0x04000613 RID: 1555
		private static readonly IntPtr NativeMethodInfoPtr_SetAABB_Private_Void_AABB_0;

		// Token: 0x04000614 RID: 1556
		private static readonly IntPtr NativeMethodInfoPtr_SetOBB_Private_Void_OBB_0;

		// Token: 0x04000615 RID: 1557
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSnapSteps_Private_Void_0;

		// Token: 0x04000616 RID: 1558
		private static readonly IntPtr NativeMethodInfoPtr_ValidateBoxSize_Private_Void_0;

		// Token: 0x04000617 RID: 1559
		private static readonly IntPtr NativeMethodInfoPtr_SetupSharedLookAndFeel_Private_Void_0;

		// Token: 0x04000618 RID: 1560
		private static readonly IntPtr NativeMethodInfoPtr_OnUndoRedoEnd_Private_Void_IUndoRedoAction_0;

		// Token: 0x02000364 RID: 868
		[StructLayout(2)]
		public struct HandleDragExtrudeData
		{
			// Token: 0x060049BC RID: 18876 RVA: 0x00145758 File Offset: 0x00143958
			// Note: this type is marked as 'beforefieldinit'.
			static HandleDragExtrudeData()
			{
				Il2CppClassPointerStore<ObjectExtrudeGizmo.HandleDragExtrudeData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ObjectExtrudeGizmo>.NativeClassPtr, "HandleDragExtrudeData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectExtrudeGizmo.HandleDragExtrudeData>.NativeClassPtr);
				ObjectExtrudeGizmo.HandleDragExtrudeData.NativeFieldInfoPtr_ExtrudeDir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectExtrudeGizmo.HandleDragExtrudeData>.NativeClassPtr, "ExtrudeDir");
				ObjectExtrudeGizmo.HandleDragExtrudeData.NativeFieldInfoPtr_ExtrudeCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectExtrudeGizmo.HandleDragExtrudeData>.NativeClassPtr, "ExtrudeCenter");
				ObjectExtrudeGizmo.HandleDragExtrudeData.NativeFieldInfoPtr_AxisIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectExtrudeGizmo.HandleDragExtrudeData>.NativeClassPtr, "AxisIndex");
			}

			// Token: 0x060049BD RID: 18877 RVA: 0x0001B6DA File Offset: 0x000198DA
			public global::Il2CppSystem.Object BoxIl2CppObject()
			{
				return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ObjectExtrudeGizmo.HandleDragExtrudeData>.NativeClassPtr, ref this));
			}

			// Token: 0x04003948 RID: 14664
			private static readonly IntPtr NativeFieldInfoPtr_ExtrudeDir;

			// Token: 0x04003949 RID: 14665
			private static readonly IntPtr NativeFieldInfoPtr_ExtrudeCenter;

			// Token: 0x0400394A RID: 14666
			private static readonly IntPtr NativeFieldInfoPtr_AxisIndex;

			// Token: 0x0400394B RID: 14667
			[FieldOffset(0)]
			public IntPtr ExtrudeDir;

			// Token: 0x0400394C RID: 14668
			[FieldOffset(12)]
			public IntPtr ExtrudeCenter;

			// Token: 0x0400394D RID: 14669
			[FieldOffset(24)]
			public int AxisIndex;
		}

		// Token: 0x02000365 RID: 869
		[ObfuscatedName("RLD.ObjectExtrudeGizmo+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x060049BE RID: 18878 RVA: 0x001457C0 File Offset: 0x001439C0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ObjectExtrudeGizmo.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ObjectExtrudeGizmo>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectExtrudeGizmo.__c>.NativeClassPtr);
				ObjectExtrudeGizmo.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectExtrudeGizmo.__c>.NativeClassPtr, "<>9");
				ObjectExtrudeGizmo.__c.NativeFieldInfoPtr___9__61_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectExtrudeGizmo.__c>.NativeClassPtr, "<>9__61_0");
				ObjectExtrudeGizmo.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmo.__c>.NativeClassPtr, 100664496);
				ObjectExtrudeGizmo.__c.NativeMethodInfoPtr__SetExtrudeTargets_b__61_0_Internal_Boolean_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectExtrudeGizmo.__c>.NativeClassPtr, 100664497);
			}

			// Token: 0x060049BF RID: 18879 RVA: 0x0014583C File Offset: 0x00143A3C
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectExtrudeGizmo.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmo.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060049C0 RID: 18880 RVA: 0x00145878 File Offset: 0x00143A78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62241, XrefRangeEnd = 62245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SetExtrudeTargets_b__61_0(GameObject item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectExtrudeGizmo.__c.NativeMethodInfoPtr__SetExtrudeTargets_b__61_0_Internal_Boolean_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060049C1 RID: 18881 RVA: 0x0001B6EC File Offset: 0x000198EC
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170018FE RID: 6398
			// (get) Token: 0x060049C2 RID: 18882 RVA: 0x001458C8 File Offset: 0x00143AC8
			// (set) Token: 0x060049C3 RID: 18883 RVA: 0x0001B6F5 File Offset: 0x000198F5
			public unsafe static ObjectExtrudeGizmo.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ObjectExtrudeGizmo.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectExtrudeGizmo.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ObjectExtrudeGizmo.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170018FF RID: 6399
			// (get) Token: 0x060049C4 RID: 18884 RVA: 0x001458F0 File Offset: 0x00143AF0
			// (set) Token: 0x060049C5 RID: 18885 RVA: 0x0001B707 File Offset: 0x00019907
			public unsafe static Predicate<GameObject> __9__61_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ObjectExtrudeGizmo.__c.NativeFieldInfoPtr___9__61_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<GameObject>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ObjectExtrudeGizmo.__c.NativeFieldInfoPtr___9__61_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400394E RID: 14670
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400394F RID: 14671
			private static readonly IntPtr NativeFieldInfoPtr___9__61_0;

			// Token: 0x04003950 RID: 14672
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003951 RID: 14673
			private static readonly IntPtr NativeMethodInfoPtr__SetExtrudeTargets_b__61_0_Internal_Boolean_GameObject_0;
		}
	}
}
