using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x020000DA RID: 218
	[Serializable]
	public class MoveGizmo : GizmoBehaviour
	{
		// Token: 0x0600115C RID: 4444 RVA: 0x00062048 File Offset: 0x00060248
		// Note: this type is marked as 'beforefieldinit'.
		static MoveGizmo()
		{
			Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "MoveGizmo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr);
			MoveGizmo.NativeFieldInfoPtr__pXSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, "_pXSlider");
			MoveGizmo.NativeFieldInfoPtr__pYSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, "_pYSlider");
			MoveGizmo.NativeFieldInfoPtr__pZSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, "_pZSlider");
			MoveGizmo.NativeFieldInfoPtr__nXSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, "_nXSlider");
			MoveGizmo.NativeFieldInfoPtr__nYSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, "_nYSlider");
			MoveGizmo.NativeFieldInfoPtr__nZSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, "_nZSlider");
			MoveGizmo.NativeFieldInfoPtr__axesSliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, "_axesSliders");
			MoveGizmo.NativeFieldInfoPtr__xySlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, "_xySlider");
			MoveGizmo.NativeFieldInfoPtr__yzSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, "_yzSlider");
			MoveGizmo.NativeFieldInfoPtr__zxSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, "_zxSlider");
			MoveGizmo.NativeFieldInfoPtr__dblSliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, "_dblSliders");
			MoveGizmo.NativeFieldInfoPtr__midCap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, "_midCap");
			MoveGizmo.NativeFieldInfoPtr__isVertexSnapEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, "_isVertexSnapEnabled");
			MoveGizmo.NativeFieldInfoPtr__vertSnapCap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, "_vertSnapCap");
			MoveGizmo.NativeFieldInfoPtr__vertexSnapDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, "_vertexSnapDrag");
			MoveGizmo.NativeFieldInfoPtr__postVSnapPosRestore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, "_postVSnapPosRestore");
			MoveGizmo.NativeFieldInfoPtr__is2DModeEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, "_is2DModeEnabled");
			MoveGizmo.NativeFieldInfoPtr__p2DModeXSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, "_p2DModeXSlider");
			MoveGizmo.NativeFieldInfoPtr__p2DModeYSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, "_p2DModeYSlider");
			MoveGizmo.NativeFieldInfoPtr__n2DModeXSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, "_n2DModeXSlider");
			MoveGizmo.NativeFieldInfoPtr__n2DModeYSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, "_n2DModeYSlider");
			MoveGizmo.NativeFieldInfoPtr__2DModeSliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, "_2DModeSliders");
			MoveGizmo.NativeFieldInfoPtr__2DModeDblSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, "_2DModeDblSlider");
			MoveGizmo.NativeFieldInfoPtr__useSnapEnableHotkey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, "_useSnapEnableHotkey");
			MoveGizmo.NativeFieldInfoPtr__useVertSnapEnableHotkey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, "_useVertSnapEnableHotkey");
			MoveGizmo.NativeFieldInfoPtr__use2DModeEnableHotkey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, "_use2DModeEnableHotkey");
			MoveGizmo.NativeFieldInfoPtr__hotkeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, "_hotkeys");
			MoveGizmo.NativeFieldInfoPtr__settings2D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, "_settings2D");
			MoveGizmo.NativeFieldInfoPtr__settings3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, "_settings3D");
			MoveGizmo.NativeFieldInfoPtr__lookAndFeel2D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, "_lookAndFeel2D");
			MoveGizmo.NativeFieldInfoPtr__lookAndFeel3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, "_lookAndFeel3D");
			MoveGizmo.NativeFieldInfoPtr__sharedHotkeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, "_sharedHotkeys");
			MoveGizmo.NativeFieldInfoPtr__sharedSettings2D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, "_sharedSettings2D");
			MoveGizmo.NativeFieldInfoPtr__sharedSettings3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, "_sharedSettings3D");
			MoveGizmo.NativeFieldInfoPtr__sharedLookAndFeel2D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, "_sharedLookAndFeel2D");
			MoveGizmo.NativeFieldInfoPtr__sharedLookAndFeel3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, "_sharedLookAndFeel3D");
			MoveGizmo.NativeMethodInfoPtr_get_Settings2D_Public_get_MoveGizmoSettings2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, 100665664);
			MoveGizmo.NativeMethodInfoPtr_get_Settings3D_Public_get_MoveGizmoSettings3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, 100665665);
			MoveGizmo.NativeMethodInfoPtr_get_LookAndFeel2D_Public_get_MoveGizmoLookAndFeel2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, 100665666);
			MoveGizmo.NativeMethodInfoPtr_get_LookAndFeel3D_Public_get_MoveGizmoLookAndFeel3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, 100665667);
			MoveGizmo.NativeMethodInfoPtr_get_Hotkeys_Public_get_MoveGizmoHotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, 100665668);
			MoveGizmo.NativeMethodInfoPtr_get_SharedSettings2D_Public_get_MoveGizmoSettings2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, 100665669);
			MoveGizmo.NativeMethodInfoPtr_set_SharedSettings2D_Public_set_Void_MoveGizmoSettings2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, 100665670);
			MoveGizmo.NativeMethodInfoPtr_get_SharedSettings3D_Public_get_MoveGizmoSettings3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, 100665671);
			MoveGizmo.NativeMethodInfoPtr_set_SharedSettings3D_Public_set_Void_MoveGizmoSettings3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, 100665672);
			MoveGizmo.NativeMethodInfoPtr_get_SharedLookAndFeel2D_Public_get_MoveGizmoLookAndFeel2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, 100665673);
			MoveGizmo.NativeMethodInfoPtr_set_SharedLookAndFeel2D_Public_set_Void_MoveGizmoLookAndFeel2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, 100665674);
			MoveGizmo.NativeMethodInfoPtr_get_SharedLookAndFeel3D_Public_get_MoveGizmoLookAndFeel3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, 100665675);
			MoveGizmo.NativeMethodInfoPtr_set_SharedLookAndFeel3D_Public_set_Void_MoveGizmoLookAndFeel3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, 100665676);
			MoveGizmo.NativeMethodInfoPtr_get_SharedHotkeys_Public_get_MoveGizmoHotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, 100665677);
			MoveGizmo.NativeMethodInfoPtr_set_SharedHotkeys_Public_set_Void_MoveGizmoHotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, 100665678);
			MoveGizmo.NativeMethodInfoPtr_get_UseSnapEnableHotkey_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, 100665679);
			MoveGizmo.NativeMethodInfoPtr_set_UseSnapEnableHotkey_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, 100665680);
			MoveGizmo.NativeMethodInfoPtr_get_UseVertSnapEnableHotkey_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, 100665681);
			MoveGizmo.NativeMethodInfoPtr_set_UseVertSnapEnableHotkey_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, 100665682);
			MoveGizmo.NativeMethodInfoPtr_get_Use2DModeEnableHotkey_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, 100665683);
			MoveGizmo.NativeMethodInfoPtr_set_Use2DModeEnableHotkey_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, 100665684);
			MoveGizmo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, 100665709);
			MoveGizmo.NativeMethodInfoPtr_GetVertexSnapState_Public_VertexSnapState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, 100665685);
			MoveGizmo.NativeMethodInfoPtr_GetZoomFactor_Public_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, 100665686);
			MoveGizmo.NativeMethodInfoPtr_GetZoomFactor_Public_Single_Vector3_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, 100665687);
			MoveGizmo.NativeMethodInfoPtr_OwnsHandle_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, 100665688);
			MoveGizmo.NativeMethodInfoPtr_SetAxesLinesHoverable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, 100665689);
			MoveGizmo.NativeMethodInfoPtr_SetSnapEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, 100665690);
			MoveGizmo.NativeMethodInfoPtr_SetVertexSnapEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, 100665691);
			MoveGizmo.NativeMethodInfoPtr_Set2DModeEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, 100665692);
			MoveGizmo.NativeMethodInfoPtr_SetVertexSnapTargetObjects_Public_Void_IEnumerable_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, 100665693);
			MoveGizmo.NativeMethodInfoPtr_OnAttached_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, 100665694);
			MoveGizmo.NativeMethodInfoPtr_OnDetached_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, 100665695);
			MoveGizmo.NativeMethodInfoPtr_OnEnabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, 100665696);
			MoveGizmo.NativeMethodInfoPtr_OnDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, 100665697);
			MoveGizmo.NativeMethodInfoPtr_OnGizmoEnabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, 100665698);
			MoveGizmo.NativeMethodInfoPtr_OnGizmoUpdateBegin_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, 100665699);
			MoveGizmo.NativeMethodInfoPtr_OnGizmoRender_Public_Virtual_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, 100665700);
			MoveGizmo.NativeMethodInfoPtr_OnGizmoDragUpdate_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, 100665701);
			MoveGizmo.NativeMethodInfoPtr_PlaceDblSlidersInSliderPlanes_Private_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, 100665702);
			MoveGizmo.NativeMethodInfoPtr_SetupSharedLookAndFeel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, 100665703);
			MoveGizmo.NativeMethodInfoPtr_SetupSharedSettings_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, 100665704);
			MoveGizmo.NativeMethodInfoPtr_Update2DGizmoPosition_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, 100665705);
			MoveGizmo.NativeMethodInfoPtr_Update2DModeHandlePositions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, 100665706);
			MoveGizmo.NativeMethodInfoPtr_OnGizmoTransformChanged_Private_Void_GizmoTransform_ChangeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, 100665707);
			MoveGizmo.NativeMethodInfoPtr_Hide2DModeHandles_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr, 100665708);
		}

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x0600115D RID: 4445 RVA: 0x000626E0 File Offset: 0x000608E0
		public unsafe MoveGizmoSettings2D Settings2D
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmo.NativeMethodInfoPtr_get_Settings2D_Public_get_MoveGizmoSettings2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MoveGizmoSettings2D>(intPtr3) : null;
			}
		}

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x0600115E RID: 4446 RVA: 0x00062720 File Offset: 0x00060920
		public unsafe MoveGizmoSettings3D Settings3D
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmo.NativeMethodInfoPtr_get_Settings3D_Public_get_MoveGizmoSettings3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MoveGizmoSettings3D>(intPtr3) : null;
			}
		}

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x0600115F RID: 4447 RVA: 0x00062760 File Offset: 0x00060960
		public unsafe MoveGizmoLookAndFeel2D LookAndFeel2D
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmo.NativeMethodInfoPtr_get_LookAndFeel2D_Public_get_MoveGizmoLookAndFeel2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MoveGizmoLookAndFeel2D>(intPtr3) : null;
			}
		}

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x06001160 RID: 4448 RVA: 0x000627A0 File Offset: 0x000609A0
		public unsafe MoveGizmoLookAndFeel3D LookAndFeel3D
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmo.NativeMethodInfoPtr_get_LookAndFeel3D_Public_get_MoveGizmoLookAndFeel3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MoveGizmoLookAndFeel3D>(intPtr3) : null;
			}
		}

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x06001161 RID: 4449 RVA: 0x000627E0 File Offset: 0x000609E0
		public unsafe MoveGizmoHotkeys Hotkeys
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmo.NativeMethodInfoPtr_get_Hotkeys_Public_get_MoveGizmoHotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MoveGizmoHotkeys>(intPtr3) : null;
			}
		}

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x06001162 RID: 4450 RVA: 0x00062820 File Offset: 0x00060A20
		// (set) Token: 0x06001163 RID: 4451 RVA: 0x00062860 File Offset: 0x00060A60
		public unsafe MoveGizmoSettings2D SharedSettings2D
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmo.NativeMethodInfoPtr_get_SharedSettings2D_Public_get_MoveGizmoSettings2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MoveGizmoSettings2D>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 69572, RefRangeEnd = 69573, XrefRangeStart = 69570, XrefRangeEnd = 69572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmo.NativeMethodInfoPtr_set_SharedSettings2D_Public_set_Void_MoveGizmoSettings2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x06001164 RID: 4452 RVA: 0x000628A4 File Offset: 0x00060AA4
		// (set) Token: 0x06001165 RID: 4453 RVA: 0x000628E4 File Offset: 0x00060AE4
		public unsafe MoveGizmoSettings3D SharedSettings3D
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmo.NativeMethodInfoPtr_get_SharedSettings3D_Public_get_MoveGizmoSettings3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MoveGizmoSettings3D>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 69575, RefRangeEnd = 69576, XrefRangeStart = 69573, XrefRangeEnd = 69575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmo.NativeMethodInfoPtr_set_SharedSettings3D_Public_set_Void_MoveGizmoSettings3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x06001166 RID: 4454 RVA: 0x00062928 File Offset: 0x00060B28
		// (set) Token: 0x06001167 RID: 4455 RVA: 0x00062968 File Offset: 0x00060B68
		public unsafe MoveGizmoLookAndFeel2D SharedLookAndFeel2D
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmo.NativeMethodInfoPtr_get_SharedLookAndFeel2D_Public_get_MoveGizmoLookAndFeel2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MoveGizmoLookAndFeel2D>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 69578, RefRangeEnd = 69579, XrefRangeStart = 69576, XrefRangeEnd = 69578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmo.NativeMethodInfoPtr_set_SharedLookAndFeel2D_Public_set_Void_MoveGizmoLookAndFeel2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x06001168 RID: 4456 RVA: 0x000629AC File Offset: 0x00060BAC
		// (set) Token: 0x06001169 RID: 4457 RVA: 0x000629EC File Offset: 0x00060BEC
		public unsafe MoveGizmoLookAndFeel3D SharedLookAndFeel3D
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmo.NativeMethodInfoPtr_get_SharedLookAndFeel3D_Public_get_MoveGizmoLookAndFeel3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MoveGizmoLookAndFeel3D>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 69581, RefRangeEnd = 69582, XrefRangeStart = 69579, XrefRangeEnd = 69581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmo.NativeMethodInfoPtr_set_SharedLookAndFeel3D_Public_set_Void_MoveGizmoLookAndFeel3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x0600116A RID: 4458 RVA: 0x00062A30 File Offset: 0x00060C30
		// (set) Token: 0x0600116B RID: 4459 RVA: 0x00062A70 File Offset: 0x00060C70
		public unsafe MoveGizmoHotkeys SharedHotkeys
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmo.NativeMethodInfoPtr_get_SharedHotkeys_Public_get_MoveGizmoHotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MoveGizmoHotkeys>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69582, XrefRangeEnd = 69583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmo.NativeMethodInfoPtr_set_SharedHotkeys_Public_set_Void_MoveGizmoHotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x0600116C RID: 4460 RVA: 0x00062AB4 File Offset: 0x00060CB4
		// (set) Token: 0x0600116D RID: 4461 RVA: 0x00062AF0 File Offset: 0x00060CF0
		public unsafe bool UseSnapEnableHotkey
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmo.NativeMethodInfoPtr_get_UseSnapEnableHotkey_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmo.NativeMethodInfoPtr_set_UseSnapEnableHotkey_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x0600116E RID: 4462 RVA: 0x00062B30 File Offset: 0x00060D30
		// (set) Token: 0x0600116F RID: 4463 RVA: 0x00062B6C File Offset: 0x00060D6C
		public unsafe bool UseVertSnapEnableHotkey
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmo.NativeMethodInfoPtr_get_UseVertSnapEnableHotkey_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmo.NativeMethodInfoPtr_set_UseVertSnapEnableHotkey_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x06001170 RID: 4464 RVA: 0x00062BAC File Offset: 0x00060DAC
		// (set) Token: 0x06001171 RID: 4465 RVA: 0x00062BE8 File Offset: 0x00060DE8
		public unsafe bool Use2DModeEnableHotkey
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmo.NativeMethodInfoPtr_get_Use2DModeEnableHotkey_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmo.NativeMethodInfoPtr_set_Use2DModeEnableHotkey_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001172 RID: 4466 RVA: 0x00062C28 File Offset: 0x00060E28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 69671, RefRangeEnd = 69673, XrefRangeStart = 69583, XrefRangeEnd = 69671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MoveGizmo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoveGizmo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001173 RID: 4467 RVA: 0x00062C64 File Offset: 0x00060E64
		[CallerCount(0)]
		public unsafe MoveGizmo.VertexSnapState GetVertexSnapState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmo.NativeMethodInfoPtr_GetVertexSnapState_Public_VertexSnapState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001174 RID: 4468 RVA: 0x00062CA0 File Offset: 0x00060EA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69673, XrefRangeEnd = 69678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetZoomFactor(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(position);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmo.NativeMethodInfoPtr_GetZoomFactor_Public_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001175 RID: 4469 RVA: 0x00062CF0 File Offset: 0x00060EF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69678, XrefRangeEnd = 69682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetZoomFactor(Vector3 position, Camera camera)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmo.NativeMethodInfoPtr_GetZoomFactor_Public_Single_Vector3_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001176 RID: 4470 RVA: 0x00062D50 File Offset: 0x00060F50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69682, XrefRangeEnd = 69688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool OwnsHandle(int handleId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handleId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmo.NativeMethodInfoPtr_OwnsHandle_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001177 RID: 4471 RVA: 0x00062D9C File Offset: 0x00060F9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69688, XrefRangeEnd = 69689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAxesLinesHoverable(bool hoverable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hoverable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmo.NativeMethodInfoPtr_SetAxesLinesHoverable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001178 RID: 4472 RVA: 0x00062DDC File Offset: 0x00060FDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69689, XrefRangeEnd = 69693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSnapEnabled(bool isEnabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isEnabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmo.NativeMethodInfoPtr_SetSnapEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001179 RID: 4473 RVA: 0x00062E1C File Offset: 0x0006101C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69693, XrefRangeEnd = 69695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVertexSnapEnabled(bool isEnabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isEnabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmo.NativeMethodInfoPtr_SetVertexSnapEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600117A RID: 4474 RVA: 0x00062E5C File Offset: 0x0006105C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 69697, RefRangeEnd = 69698, XrefRangeStart = 69695, XrefRangeEnd = 69697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set2DModeEnabled(bool isEnabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isEnabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmo.NativeMethodInfoPtr_Set2DModeEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600117B RID: 4475 RVA: 0x00062E9C File Offset: 0x0006109C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 69700, RefRangeEnd = 69701, XrefRangeStart = 69698, XrefRangeEnd = 69700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVertexSnapTargetObjects(IEnumerable<GameObject> targetObjects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetObjects);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmo.NativeMethodInfoPtr_SetVertexSnapTargetObjects_Public_Void_IEnumerable_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600117C RID: 4476 RVA: 0x00062EE0 File Offset: 0x000610E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69701, XrefRangeEnd = 69846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnAttached()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoveGizmo.NativeMethodInfoPtr_OnAttached_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600117D RID: 4477 RVA: 0x00062F1C File Offset: 0x0006111C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69846, XrefRangeEnd = 69854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDetached()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoveGizmo.NativeMethodInfoPtr_OnDetached_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600117E RID: 4478 RVA: 0x00062F58 File Offset: 0x00061158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69854, XrefRangeEnd = 69862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoveGizmo.NativeMethodInfoPtr_OnEnabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600117F RID: 4479 RVA: 0x00062F94 File Offset: 0x00061194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69862, XrefRangeEnd = 69870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoveGizmo.NativeMethodInfoPtr_OnDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001180 RID: 4480 RVA: 0x00062FD0 File Offset: 0x000611D0
		[CallerCount(0)]
		public unsafe override void OnGizmoEnabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoveGizmo.NativeMethodInfoPtr_OnGizmoEnabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001181 RID: 4481 RVA: 0x0006300C File Offset: 0x0006120C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69870, XrefRangeEnd = 69897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnGizmoUpdateBegin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoveGizmo.NativeMethodInfoPtr_OnGizmoUpdateBegin_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001182 RID: 4482 RVA: 0x00063048 File Offset: 0x00061248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69897, XrefRangeEnd = 69926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnGizmoRender(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoveGizmo.NativeMethodInfoPtr_OnGizmoRender_Public_Virtual_Void_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001183 RID: 4483 RVA: 0x00063098 File Offset: 0x00061298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69926, XrefRangeEnd = 69927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnGizmoDragUpdate(int handleId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handleId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MoveGizmo.NativeMethodInfoPtr_OnGizmoDragUpdate_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001184 RID: 4484 RVA: 0x000630E4 File Offset: 0x000612E4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 69930, RefRangeEnd = 69934, XrefRangeStart = 69927, XrefRangeEnd = 69930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlaceDblSlidersInSliderPlanes(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmo.NativeMethodInfoPtr_PlaceDblSlidersInSliderPlanes_Private_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001185 RID: 4485 RVA: 0x00063128 File Offset: 0x00061328
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 69952, RefRangeEnd = 69955, XrefRangeStart = 69934, XrefRangeEnd = 69952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupSharedLookAndFeel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmo.NativeMethodInfoPtr_SetupSharedLookAndFeel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001186 RID: 4486 RVA: 0x0006315C File Offset: 0x0006135C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 69972, RefRangeEnd = 69975, XrefRangeStart = 69955, XrefRangeEnd = 69972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupSharedSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmo.NativeMethodInfoPtr_SetupSharedSettings_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001187 RID: 4487 RVA: 0x00063190 File Offset: 0x00061390
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 69979, RefRangeEnd = 69985, XrefRangeStart = 69975, XrefRangeEnd = 69979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update2DGizmoPosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmo.NativeMethodInfoPtr_Update2DGizmoPosition_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001188 RID: 4488 RVA: 0x000631C4 File Offset: 0x000613C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 69998, RefRangeEnd = 69999, XrefRangeStart = 69985, XrefRangeEnd = 69998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update2DModeHandlePositions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmo.NativeMethodInfoPtr_Update2DModeHandlePositions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001189 RID: 4489 RVA: 0x000631F8 File Offset: 0x000613F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69999, XrefRangeEnd = 70000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmo.NativeMethodInfoPtr_OnGizmoTransformChanged_Private_Void_GizmoTransform_ChangeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600118A RID: 4490 RVA: 0x00063248 File Offset: 0x00061448
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 70004, RefRangeEnd = 70006, XrefRangeStart = 70000, XrefRangeEnd = 70004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hide2DModeHandles()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmo.NativeMethodInfoPtr_Hide2DModeHandles_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600118B RID: 4491 RVA: 0x00008C3F File Offset: 0x00006E3F
		public MoveGizmo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x0600118C RID: 4492 RVA: 0x0006327C File Offset: 0x0006147C
		// (set) Token: 0x0600118D RID: 4493 RVA: 0x00008C48 File Offset: 0x00006E48
		public unsafe GizmoLineSlider3D _pXSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmo.NativeFieldInfoPtr__pXSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoLineSlider3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmo.NativeFieldInfoPtr__pXSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x0600118E RID: 4494 RVA: 0x000632AC File Offset: 0x000614AC
		// (set) Token: 0x0600118F RID: 4495 RVA: 0x00008C67 File Offset: 0x00006E67
		public unsafe GizmoLineSlider3D _pYSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmo.NativeFieldInfoPtr__pYSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoLineSlider3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmo.NativeFieldInfoPtr__pYSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x06001190 RID: 4496 RVA: 0x000632DC File Offset: 0x000614DC
		// (set) Token: 0x06001191 RID: 4497 RVA: 0x00008C86 File Offset: 0x00006E86
		public unsafe GizmoLineSlider3D _pZSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmo.NativeFieldInfoPtr__pZSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoLineSlider3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmo.NativeFieldInfoPtr__pZSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x06001192 RID: 4498 RVA: 0x0006330C File Offset: 0x0006150C
		// (set) Token: 0x06001193 RID: 4499 RVA: 0x00008CA5 File Offset: 0x00006EA5
		public unsafe GizmoLineSlider3D _nXSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmo.NativeFieldInfoPtr__nXSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoLineSlider3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmo.NativeFieldInfoPtr__nXSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x06001194 RID: 4500 RVA: 0x0006333C File Offset: 0x0006153C
		// (set) Token: 0x06001195 RID: 4501 RVA: 0x00008CC4 File Offset: 0x00006EC4
		public unsafe GizmoLineSlider3D _nYSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmo.NativeFieldInfoPtr__nYSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoLineSlider3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmo.NativeFieldInfoPtr__nYSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x06001196 RID: 4502 RVA: 0x0006336C File Offset: 0x0006156C
		// (set) Token: 0x06001197 RID: 4503 RVA: 0x00008CE3 File Offset: 0x00006EE3
		public unsafe GizmoLineSlider3D _nZSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmo.NativeFieldInfoPtr__nZSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoLineSlider3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmo.NativeFieldInfoPtr__nZSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x06001198 RID: 4504 RVA: 0x0006339C File Offset: 0x0006159C
		// (set) Token: 0x06001199 RID: 4505 RVA: 0x00008D02 File Offset: 0x00006F02
		public unsafe GizmoLineSlider3DCollection _axesSliders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmo.NativeFieldInfoPtr__axesSliders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoLineSlider3DCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmo.NativeFieldInfoPtr__axesSliders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x0600119A RID: 4506 RVA: 0x000633CC File Offset: 0x000615CC
		// (set) Token: 0x0600119B RID: 4507 RVA: 0x00008D21 File Offset: 0x00006F21
		public unsafe GizmoPlaneSlider3D _xySlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmo.NativeFieldInfoPtr__xySlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPlaneSlider3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmo.NativeFieldInfoPtr__xySlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x0600119C RID: 4508 RVA: 0x000633FC File Offset: 0x000615FC
		// (set) Token: 0x0600119D RID: 4509 RVA: 0x00008D40 File Offset: 0x00006F40
		public unsafe GizmoPlaneSlider3D _yzSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmo.NativeFieldInfoPtr__yzSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPlaneSlider3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmo.NativeFieldInfoPtr__yzSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x0600119E RID: 4510 RVA: 0x0006342C File Offset: 0x0006162C
		// (set) Token: 0x0600119F RID: 4511 RVA: 0x00008D5F File Offset: 0x00006F5F
		public unsafe GizmoPlaneSlider3D _zxSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmo.NativeFieldInfoPtr__zxSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPlaneSlider3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmo.NativeFieldInfoPtr__zxSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x060011A0 RID: 4512 RVA: 0x0006345C File Offset: 0x0006165C
		// (set) Token: 0x060011A1 RID: 4513 RVA: 0x00008D7E File Offset: 0x00006F7E
		public unsafe GizmoPlaneSlider3DCollection _dblSliders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmo.NativeFieldInfoPtr__dblSliders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPlaneSlider3DCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmo.NativeFieldInfoPtr__dblSliders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x060011A2 RID: 4514 RVA: 0x0006348C File Offset: 0x0006168C
		// (set) Token: 0x060011A3 RID: 4515 RVA: 0x00008D9D File Offset: 0x00006F9D
		public unsafe GizmoCap3D _midCap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmo.NativeFieldInfoPtr__midCap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoCap3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmo.NativeFieldInfoPtr__midCap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x060011A4 RID: 4516 RVA: 0x000634BC File Offset: 0x000616BC
		// (set) Token: 0x060011A5 RID: 4517 RVA: 0x00008DBC File Offset: 0x00006FBC
		public unsafe bool _isVertexSnapEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmo.NativeFieldInfoPtr__isVertexSnapEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmo.NativeFieldInfoPtr__isVertexSnapEnabled)) = value;
			}
		}

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x060011A6 RID: 4518 RVA: 0x000634E4 File Offset: 0x000616E4
		// (set) Token: 0x060011A7 RID: 4519 RVA: 0x00008DD7 File Offset: 0x00006FD7
		public unsafe GizmoCap2D _vertSnapCap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmo.NativeFieldInfoPtr__vertSnapCap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoCap2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmo.NativeFieldInfoPtr__vertSnapCap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x060011A8 RID: 4520 RVA: 0x00063514 File Offset: 0x00061714
		// (set) Token: 0x060011A9 RID: 4521 RVA: 0x00008DF6 File Offset: 0x00006FF6
		public unsafe GizmoObjectVertexSnapDrag3D _vertexSnapDrag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmo.NativeFieldInfoPtr__vertexSnapDrag);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoObjectVertexSnapDrag3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmo.NativeFieldInfoPtr__vertexSnapDrag), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x060011AA RID: 4522 RVA: 0x00063544 File Offset: 0x00061744
		// (set) Token: 0x060011AB RID: 4523 RVA: 0x00008E15 File Offset: 0x00007015
		public unsafe Vector3 _postVSnapPosRestore
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmo.NativeFieldInfoPtr__postVSnapPosRestore);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmo.NativeFieldInfoPtr__postVSnapPosRestore), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x060011AC RID: 4524 RVA: 0x00063574 File Offset: 0x00061774
		// (set) Token: 0x060011AD RID: 4525 RVA: 0x00008E34 File Offset: 0x00007034
		public unsafe bool _is2DModeEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmo.NativeFieldInfoPtr__is2DModeEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmo.NativeFieldInfoPtr__is2DModeEnabled)) = value;
			}
		}

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x060011AE RID: 4526 RVA: 0x0006359C File Offset: 0x0006179C
		// (set) Token: 0x060011AF RID: 4527 RVA: 0x00008E4F File Offset: 0x0000704F
		public unsafe GizmoLineSlider2D _p2DModeXSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmo.NativeFieldInfoPtr__p2DModeXSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoLineSlider2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmo.NativeFieldInfoPtr__p2DModeXSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x060011B0 RID: 4528 RVA: 0x000635CC File Offset: 0x000617CC
		// (set) Token: 0x060011B1 RID: 4529 RVA: 0x00008E6E File Offset: 0x0000706E
		public unsafe GizmoLineSlider2D _p2DModeYSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmo.NativeFieldInfoPtr__p2DModeYSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoLineSlider2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmo.NativeFieldInfoPtr__p2DModeYSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x060011B2 RID: 4530 RVA: 0x000635FC File Offset: 0x000617FC
		// (set) Token: 0x060011B3 RID: 4531 RVA: 0x00008E8D File Offset: 0x0000708D
		public unsafe GizmoLineSlider2D _n2DModeXSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmo.NativeFieldInfoPtr__n2DModeXSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoLineSlider2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmo.NativeFieldInfoPtr__n2DModeXSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x060011B4 RID: 4532 RVA: 0x0006362C File Offset: 0x0006182C
		// (set) Token: 0x060011B5 RID: 4533 RVA: 0x00008EAC File Offset: 0x000070AC
		public unsafe GizmoLineSlider2D _n2DModeYSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmo.NativeFieldInfoPtr__n2DModeYSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoLineSlider2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmo.NativeFieldInfoPtr__n2DModeYSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x060011B6 RID: 4534 RVA: 0x0006365C File Offset: 0x0006185C
		// (set) Token: 0x060011B7 RID: 4535 RVA: 0x00008ECB File Offset: 0x000070CB
		public unsafe GizmoLineSlider2DCollection _2DModeSliders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmo.NativeFieldInfoPtr__2DModeSliders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoLineSlider2DCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmo.NativeFieldInfoPtr__2DModeSliders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x060011B8 RID: 4536 RVA: 0x0006368C File Offset: 0x0006188C
		// (set) Token: 0x060011B9 RID: 4537 RVA: 0x00008EEA File Offset: 0x000070EA
		public unsafe GizmoPlaneSlider2D _2DModeDblSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmo.NativeFieldInfoPtr__2DModeDblSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPlaneSlider2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmo.NativeFieldInfoPtr__2DModeDblSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x060011BA RID: 4538 RVA: 0x000636BC File Offset: 0x000618BC
		// (set) Token: 0x060011BB RID: 4539 RVA: 0x00008F09 File Offset: 0x00007109
		public unsafe bool _useSnapEnableHotkey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmo.NativeFieldInfoPtr__useSnapEnableHotkey);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmo.NativeFieldInfoPtr__useSnapEnableHotkey)) = value;
			}
		}

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x060011BC RID: 4540 RVA: 0x000636E4 File Offset: 0x000618E4
		// (set) Token: 0x060011BD RID: 4541 RVA: 0x00008F24 File Offset: 0x00007124
		public unsafe bool _useVertSnapEnableHotkey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmo.NativeFieldInfoPtr__useVertSnapEnableHotkey);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmo.NativeFieldInfoPtr__useVertSnapEnableHotkey)) = value;
			}
		}

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x060011BE RID: 4542 RVA: 0x0006370C File Offset: 0x0006190C
		// (set) Token: 0x060011BF RID: 4543 RVA: 0x00008F3F File Offset: 0x0000713F
		public unsafe bool _use2DModeEnableHotkey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmo.NativeFieldInfoPtr__use2DModeEnableHotkey);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmo.NativeFieldInfoPtr__use2DModeEnableHotkey)) = value;
			}
		}

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x060011C0 RID: 4544 RVA: 0x00063734 File Offset: 0x00061934
		// (set) Token: 0x060011C1 RID: 4545 RVA: 0x00008F5A File Offset: 0x0000715A
		public unsafe MoveGizmoHotkeys _hotkeys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmo.NativeFieldInfoPtr__hotkeys);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MoveGizmoHotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmo.NativeFieldInfoPtr__hotkeys), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x060011C2 RID: 4546 RVA: 0x00063764 File Offset: 0x00061964
		// (set) Token: 0x060011C3 RID: 4547 RVA: 0x00008F79 File Offset: 0x00007179
		public unsafe MoveGizmoSettings2D _settings2D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmo.NativeFieldInfoPtr__settings2D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MoveGizmoSettings2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmo.NativeFieldInfoPtr__settings2D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x060011C4 RID: 4548 RVA: 0x00063794 File Offset: 0x00061994
		// (set) Token: 0x060011C5 RID: 4549 RVA: 0x00008F98 File Offset: 0x00007198
		public unsafe MoveGizmoSettings3D _settings3D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmo.NativeFieldInfoPtr__settings3D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MoveGizmoSettings3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmo.NativeFieldInfoPtr__settings3D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x060011C6 RID: 4550 RVA: 0x000637C4 File Offset: 0x000619C4
		// (set) Token: 0x060011C7 RID: 4551 RVA: 0x00008FB7 File Offset: 0x000071B7
		public unsafe MoveGizmoLookAndFeel2D _lookAndFeel2D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmo.NativeFieldInfoPtr__lookAndFeel2D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MoveGizmoLookAndFeel2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmo.NativeFieldInfoPtr__lookAndFeel2D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x060011C8 RID: 4552 RVA: 0x000637F4 File Offset: 0x000619F4
		// (set) Token: 0x060011C9 RID: 4553 RVA: 0x00008FD6 File Offset: 0x000071D6
		public unsafe MoveGizmoLookAndFeel3D _lookAndFeel3D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmo.NativeFieldInfoPtr__lookAndFeel3D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MoveGizmoLookAndFeel3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmo.NativeFieldInfoPtr__lookAndFeel3D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x060011CA RID: 4554 RVA: 0x00063824 File Offset: 0x00061A24
		// (set) Token: 0x060011CB RID: 4555 RVA: 0x00008FF5 File Offset: 0x000071F5
		public unsafe MoveGizmoHotkeys _sharedHotkeys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmo.NativeFieldInfoPtr__sharedHotkeys);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MoveGizmoHotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmo.NativeFieldInfoPtr__sharedHotkeys), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x060011CC RID: 4556 RVA: 0x00063854 File Offset: 0x00061A54
		// (set) Token: 0x060011CD RID: 4557 RVA: 0x00009014 File Offset: 0x00007214
		public unsafe MoveGizmoSettings2D _sharedSettings2D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmo.NativeFieldInfoPtr__sharedSettings2D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MoveGizmoSettings2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmo.NativeFieldInfoPtr__sharedSettings2D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x060011CE RID: 4558 RVA: 0x00063884 File Offset: 0x00061A84
		// (set) Token: 0x060011CF RID: 4559 RVA: 0x00009033 File Offset: 0x00007233
		public unsafe MoveGizmoSettings3D _sharedSettings3D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmo.NativeFieldInfoPtr__sharedSettings3D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MoveGizmoSettings3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmo.NativeFieldInfoPtr__sharedSettings3D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x060011D0 RID: 4560 RVA: 0x000638B4 File Offset: 0x00061AB4
		// (set) Token: 0x060011D1 RID: 4561 RVA: 0x00009052 File Offset: 0x00007252
		public unsafe MoveGizmoLookAndFeel2D _sharedLookAndFeel2D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmo.NativeFieldInfoPtr__sharedLookAndFeel2D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MoveGizmoLookAndFeel2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmo.NativeFieldInfoPtr__sharedLookAndFeel2D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x060011D2 RID: 4562 RVA: 0x000638E4 File Offset: 0x00061AE4
		// (set) Token: 0x060011D3 RID: 4563 RVA: 0x00009071 File Offset: 0x00007271
		public unsafe MoveGizmoLookAndFeel3D _sharedLookAndFeel3D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmo.NativeFieldInfoPtr__sharedLookAndFeel3D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MoveGizmoLookAndFeel3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmo.NativeFieldInfoPtr__sharedLookAndFeel3D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000CC9 RID: 3273
		private static readonly IntPtr NativeFieldInfoPtr__pXSlider;

		// Token: 0x04000CCA RID: 3274
		private static readonly IntPtr NativeFieldInfoPtr__pYSlider;

		// Token: 0x04000CCB RID: 3275
		private static readonly IntPtr NativeFieldInfoPtr__pZSlider;

		// Token: 0x04000CCC RID: 3276
		private static readonly IntPtr NativeFieldInfoPtr__nXSlider;

		// Token: 0x04000CCD RID: 3277
		private static readonly IntPtr NativeFieldInfoPtr__nYSlider;

		// Token: 0x04000CCE RID: 3278
		private static readonly IntPtr NativeFieldInfoPtr__nZSlider;

		// Token: 0x04000CCF RID: 3279
		private static readonly IntPtr NativeFieldInfoPtr__axesSliders;

		// Token: 0x04000CD0 RID: 3280
		private static readonly IntPtr NativeFieldInfoPtr__xySlider;

		// Token: 0x04000CD1 RID: 3281
		private static readonly IntPtr NativeFieldInfoPtr__yzSlider;

		// Token: 0x04000CD2 RID: 3282
		private static readonly IntPtr NativeFieldInfoPtr__zxSlider;

		// Token: 0x04000CD3 RID: 3283
		private static readonly IntPtr NativeFieldInfoPtr__dblSliders;

		// Token: 0x04000CD4 RID: 3284
		private static readonly IntPtr NativeFieldInfoPtr__midCap;

		// Token: 0x04000CD5 RID: 3285
		private static readonly IntPtr NativeFieldInfoPtr__isVertexSnapEnabled;

		// Token: 0x04000CD6 RID: 3286
		private static readonly IntPtr NativeFieldInfoPtr__vertSnapCap;

		// Token: 0x04000CD7 RID: 3287
		private static readonly IntPtr NativeFieldInfoPtr__vertexSnapDrag;

		// Token: 0x04000CD8 RID: 3288
		private static readonly IntPtr NativeFieldInfoPtr__postVSnapPosRestore;

		// Token: 0x04000CD9 RID: 3289
		private static readonly IntPtr NativeFieldInfoPtr__is2DModeEnabled;

		// Token: 0x04000CDA RID: 3290
		private static readonly IntPtr NativeFieldInfoPtr__p2DModeXSlider;

		// Token: 0x04000CDB RID: 3291
		private static readonly IntPtr NativeFieldInfoPtr__p2DModeYSlider;

		// Token: 0x04000CDC RID: 3292
		private static readonly IntPtr NativeFieldInfoPtr__n2DModeXSlider;

		// Token: 0x04000CDD RID: 3293
		private static readonly IntPtr NativeFieldInfoPtr__n2DModeYSlider;

		// Token: 0x04000CDE RID: 3294
		private static readonly IntPtr NativeFieldInfoPtr__2DModeSliders;

		// Token: 0x04000CDF RID: 3295
		private static readonly IntPtr NativeFieldInfoPtr__2DModeDblSlider;

		// Token: 0x04000CE0 RID: 3296
		private static readonly IntPtr NativeFieldInfoPtr__useSnapEnableHotkey;

		// Token: 0x04000CE1 RID: 3297
		private static readonly IntPtr NativeFieldInfoPtr__useVertSnapEnableHotkey;

		// Token: 0x04000CE2 RID: 3298
		private static readonly IntPtr NativeFieldInfoPtr__use2DModeEnableHotkey;

		// Token: 0x04000CE3 RID: 3299
		private static readonly IntPtr NativeFieldInfoPtr__hotkeys;

		// Token: 0x04000CE4 RID: 3300
		private static readonly IntPtr NativeFieldInfoPtr__settings2D;

		// Token: 0x04000CE5 RID: 3301
		private static readonly IntPtr NativeFieldInfoPtr__settings3D;

		// Token: 0x04000CE6 RID: 3302
		private static readonly IntPtr NativeFieldInfoPtr__lookAndFeel2D;

		// Token: 0x04000CE7 RID: 3303
		private static readonly IntPtr NativeFieldInfoPtr__lookAndFeel3D;

		// Token: 0x04000CE8 RID: 3304
		private static readonly IntPtr NativeFieldInfoPtr__sharedHotkeys;

		// Token: 0x04000CE9 RID: 3305
		private static readonly IntPtr NativeFieldInfoPtr__sharedSettings2D;

		// Token: 0x04000CEA RID: 3306
		private static readonly IntPtr NativeFieldInfoPtr__sharedSettings3D;

		// Token: 0x04000CEB RID: 3307
		private static readonly IntPtr NativeFieldInfoPtr__sharedLookAndFeel2D;

		// Token: 0x04000CEC RID: 3308
		private static readonly IntPtr NativeFieldInfoPtr__sharedLookAndFeel3D;

		// Token: 0x04000CED RID: 3309
		private static readonly IntPtr NativeMethodInfoPtr_get_Settings2D_Public_get_MoveGizmoSettings2D_0;

		// Token: 0x04000CEE RID: 3310
		private static readonly IntPtr NativeMethodInfoPtr_get_Settings3D_Public_get_MoveGizmoSettings3D_0;

		// Token: 0x04000CEF RID: 3311
		private static readonly IntPtr NativeMethodInfoPtr_get_LookAndFeel2D_Public_get_MoveGizmoLookAndFeel2D_0;

		// Token: 0x04000CF0 RID: 3312
		private static readonly IntPtr NativeMethodInfoPtr_get_LookAndFeel3D_Public_get_MoveGizmoLookAndFeel3D_0;

		// Token: 0x04000CF1 RID: 3313
		private static readonly IntPtr NativeMethodInfoPtr_get_Hotkeys_Public_get_MoveGizmoHotkeys_0;

		// Token: 0x04000CF2 RID: 3314
		private static readonly IntPtr NativeMethodInfoPtr_get_SharedSettings2D_Public_get_MoveGizmoSettings2D_0;

		// Token: 0x04000CF3 RID: 3315
		private static readonly IntPtr NativeMethodInfoPtr_set_SharedSettings2D_Public_set_Void_MoveGizmoSettings2D_0;

		// Token: 0x04000CF4 RID: 3316
		private static readonly IntPtr NativeMethodInfoPtr_get_SharedSettings3D_Public_get_MoveGizmoSettings3D_0;

		// Token: 0x04000CF5 RID: 3317
		private static readonly IntPtr NativeMethodInfoPtr_set_SharedSettings3D_Public_set_Void_MoveGizmoSettings3D_0;

		// Token: 0x04000CF6 RID: 3318
		private static readonly IntPtr NativeMethodInfoPtr_get_SharedLookAndFeel2D_Public_get_MoveGizmoLookAndFeel2D_0;

		// Token: 0x04000CF7 RID: 3319
		private static readonly IntPtr NativeMethodInfoPtr_set_SharedLookAndFeel2D_Public_set_Void_MoveGizmoLookAndFeel2D_0;

		// Token: 0x04000CF8 RID: 3320
		private static readonly IntPtr NativeMethodInfoPtr_get_SharedLookAndFeel3D_Public_get_MoveGizmoLookAndFeel3D_0;

		// Token: 0x04000CF9 RID: 3321
		private static readonly IntPtr NativeMethodInfoPtr_set_SharedLookAndFeel3D_Public_set_Void_MoveGizmoLookAndFeel3D_0;

		// Token: 0x04000CFA RID: 3322
		private static readonly IntPtr NativeMethodInfoPtr_get_SharedHotkeys_Public_get_MoveGizmoHotkeys_0;

		// Token: 0x04000CFB RID: 3323
		private static readonly IntPtr NativeMethodInfoPtr_set_SharedHotkeys_Public_set_Void_MoveGizmoHotkeys_0;

		// Token: 0x04000CFC RID: 3324
		private static readonly IntPtr NativeMethodInfoPtr_get_UseSnapEnableHotkey_Public_get_Boolean_0;

		// Token: 0x04000CFD RID: 3325
		private static readonly IntPtr NativeMethodInfoPtr_set_UseSnapEnableHotkey_Public_set_Void_Boolean_0;

		// Token: 0x04000CFE RID: 3326
		private static readonly IntPtr NativeMethodInfoPtr_get_UseVertSnapEnableHotkey_Public_get_Boolean_0;

		// Token: 0x04000CFF RID: 3327
		private static readonly IntPtr NativeMethodInfoPtr_set_UseVertSnapEnableHotkey_Public_set_Void_Boolean_0;

		// Token: 0x04000D00 RID: 3328
		private static readonly IntPtr NativeMethodInfoPtr_get_Use2DModeEnableHotkey_Public_get_Boolean_0;

		// Token: 0x04000D01 RID: 3329
		private static readonly IntPtr NativeMethodInfoPtr_set_Use2DModeEnableHotkey_Public_set_Void_Boolean_0;

		// Token: 0x04000D02 RID: 3330
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000D03 RID: 3331
		private static readonly IntPtr NativeMethodInfoPtr_GetVertexSnapState_Public_VertexSnapState_0;

		// Token: 0x04000D04 RID: 3332
		private static readonly IntPtr NativeMethodInfoPtr_GetZoomFactor_Public_Single_Vector3_0;

		// Token: 0x04000D05 RID: 3333
		private static readonly IntPtr NativeMethodInfoPtr_GetZoomFactor_Public_Single_Vector3_Camera_0;

		// Token: 0x04000D06 RID: 3334
		private static readonly IntPtr NativeMethodInfoPtr_OwnsHandle_Public_Boolean_Int32_0;

		// Token: 0x04000D07 RID: 3335
		private static readonly IntPtr NativeMethodInfoPtr_SetAxesLinesHoverable_Public_Void_Boolean_0;

		// Token: 0x04000D08 RID: 3336
		private static readonly IntPtr NativeMethodInfoPtr_SetSnapEnabled_Public_Void_Boolean_0;

		// Token: 0x04000D09 RID: 3337
		private static readonly IntPtr NativeMethodInfoPtr_SetVertexSnapEnabled_Public_Void_Boolean_0;

		// Token: 0x04000D0A RID: 3338
		private static readonly IntPtr NativeMethodInfoPtr_Set2DModeEnabled_Public_Void_Boolean_0;

		// Token: 0x04000D0B RID: 3339
		private static readonly IntPtr NativeMethodInfoPtr_SetVertexSnapTargetObjects_Public_Void_IEnumerable_1_GameObject_0;

		// Token: 0x04000D0C RID: 3340
		private static readonly IntPtr NativeMethodInfoPtr_OnAttached_Public_Virtual_Void_0;

		// Token: 0x04000D0D RID: 3341
		private static readonly IntPtr NativeMethodInfoPtr_OnDetached_Public_Virtual_Void_0;

		// Token: 0x04000D0E RID: 3342
		private static readonly IntPtr NativeMethodInfoPtr_OnEnabled_Public_Virtual_Void_0;

		// Token: 0x04000D0F RID: 3343
		private static readonly IntPtr NativeMethodInfoPtr_OnDisabled_Public_Virtual_Void_0;

		// Token: 0x04000D10 RID: 3344
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoEnabled_Public_Virtual_Void_0;

		// Token: 0x04000D11 RID: 3345
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoUpdateBegin_Public_Virtual_Void_0;

		// Token: 0x04000D12 RID: 3346
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoRender_Public_Virtual_Void_Camera_0;

		// Token: 0x04000D13 RID: 3347
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoDragUpdate_Public_Virtual_Void_Int32_0;

		// Token: 0x04000D14 RID: 3348
		private static readonly IntPtr NativeMethodInfoPtr_PlaceDblSlidersInSliderPlanes_Private_Void_Camera_0;

		// Token: 0x04000D15 RID: 3349
		private static readonly IntPtr NativeMethodInfoPtr_SetupSharedLookAndFeel_Private_Void_0;

		// Token: 0x04000D16 RID: 3350
		private static readonly IntPtr NativeMethodInfoPtr_SetupSharedSettings_Private_Void_0;

		// Token: 0x04000D17 RID: 3351
		private static readonly IntPtr NativeMethodInfoPtr_Update2DGizmoPosition_Private_Void_0;

		// Token: 0x04000D18 RID: 3352
		private static readonly IntPtr NativeMethodInfoPtr_Update2DModeHandlePositions_Private_Void_0;

		// Token: 0x04000D19 RID: 3353
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoTransformChanged_Private_Void_GizmoTransform_ChangeData_0;

		// Token: 0x04000D1A RID: 3354
		private static readonly IntPtr NativeMethodInfoPtr_Hide2DModeHandles_Private_Void_0;

		// Token: 0x02000374 RID: 884
		public enum VertexSnapState
		{
			// Token: 0x04003981 RID: 14721
			SelectingPivot,
			// Token: 0x04003982 RID: 14722
			Snapping,
			// Token: 0x04003983 RID: 14723
			Inactive
		}
	}
}
