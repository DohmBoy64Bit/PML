using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200008F RID: 143
	public class GizmoPlaneSlider2D : GizmoSlider
	{
		// Token: 0x06000B1A RID: 2842 RVA: 0x0004C288 File Offset: 0x0004A488
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoPlaneSlider2D()
		{
			Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoPlaneSlider2D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr);
			GizmoPlaneSlider2D.NativeFieldInfoPtr__quadIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, "_quadIndex");
			GizmoPlaneSlider2D.NativeFieldInfoPtr__circleIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, "_circleIndex");
			GizmoPlaneSlider2D.NativeFieldInfoPtr__polygonIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, "_polygonIndex");
			GizmoPlaneSlider2D.NativeFieldInfoPtr__quad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, "_quad");
			GizmoPlaneSlider2D.NativeFieldInfoPtr__circle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, "_circle");
			GizmoPlaneSlider2D.NativeFieldInfoPtr__polygon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, "_polygon");
			GizmoPlaneSlider2D.NativeFieldInfoPtr__quadBorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, "_quadBorder");
			GizmoPlaneSlider2D.NativeFieldInfoPtr__circleBorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, "_circleBorder");
			GizmoPlaneSlider2D.NativeFieldInfoPtr__polygonBorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, "_polygonBorder");
			GizmoPlaneSlider2D.NativeFieldInfoPtr__isBorderVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, "_isBorderVisible");
			GizmoPlaneSlider2D.NativeFieldInfoPtr__isBorderHoverable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, "_isBorderHoverable");
			GizmoPlaneSlider2D.NativeFieldInfoPtr__transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, "_transform");
			GizmoPlaneSlider2D.NativeFieldInfoPtr__dragChannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, "_dragChannel");
			GizmoPlaneSlider2D.NativeFieldInfoPtr__selectedDragSession = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, "_selectedDragSession");
			GizmoPlaneSlider2D.NativeFieldInfoPtr__offsetDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, "_offsetDrag");
			GizmoPlaneSlider2D.NativeFieldInfoPtr__offsetDragOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, "_offsetDragOrigin");
			GizmoPlaneSlider2D.NativeFieldInfoPtr__rotationDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, "_rotationDrag");
			GizmoPlaneSlider2D.NativeFieldInfoPtr__rotationArc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, "_rotationArc");
			GizmoPlaneSlider2D.NativeFieldInfoPtr__scaleDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, "_scaleDrag");
			GizmoPlaneSlider2D.NativeFieldInfoPtr__scaleDragOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, "_scaleDragOrigin");
			GizmoPlaneSlider2D.NativeFieldInfoPtr__scaleAxisRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, "_scaleAxisRight");
			GizmoPlaneSlider2D.NativeFieldInfoPtr__scaleAxisUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, "_scaleAxisUp");
			GizmoPlaneSlider2D.NativeFieldInfoPtr__scaleDragAxisIndexRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, "_scaleDragAxisIndexRight");
			GizmoPlaneSlider2D.NativeFieldInfoPtr__scaleDragAxisIndexUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, "_scaleDragAxisIndexUp");
			GizmoPlaneSlider2D.NativeFieldInfoPtr__controllerData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, "_controllerData");
			GizmoPlaneSlider2D.NativeFieldInfoPtr__controllers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, "_controllers");
			GizmoPlaneSlider2D.NativeFieldInfoPtr__settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, "_settings");
			GizmoPlaneSlider2D.NativeFieldInfoPtr__sharedSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, "_sharedSettings");
			GizmoPlaneSlider2D.NativeFieldInfoPtr__lookAndFeel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, "_lookAndFeel");
			GizmoPlaneSlider2D.NativeFieldInfoPtr__sharedLookAndFeel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, "_sharedLookAndFeel");
			GizmoPlaneSlider2D.NativeMethodInfoPtr_get_Settings_Public_get_GizmoPlaneSlider2DSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, 100664946);
			GizmoPlaneSlider2D.NativeMethodInfoPtr_get_SharedSettings_Public_get_GizmoPlaneSlider2DSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, 100664947);
			GizmoPlaneSlider2D.NativeMethodInfoPtr_set_SharedSettings_Public_set_Void_GizmoPlaneSlider2DSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, 100664948);
			GizmoPlaneSlider2D.NativeMethodInfoPtr_get_LookAndFeel_Public_get_GizmoPlaneSlider2DLookAndFeel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, 100664949);
			GizmoPlaneSlider2D.NativeMethodInfoPtr_get_SharedLookAndFeel_Public_get_GizmoPlaneSlider2DLookAndFeel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, 100664950);
			GizmoPlaneSlider2D.NativeMethodInfoPtr_set_SharedLookAndFeel_Public_set_Void_GizmoPlaneSlider2DLookAndFeel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, 100664951);
			GizmoPlaneSlider2D.NativeMethodInfoPtr_get_Position_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, 100664952);
			GizmoPlaneSlider2D.NativeMethodInfoPtr_set_Position_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, 100664953);
			GizmoPlaneSlider2D.NativeMethodInfoPtr_get_PolyCenter_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, 100664954);
			GizmoPlaneSlider2D.NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, 100664955);
			GizmoPlaneSlider2D.NativeMethodInfoPtr_get_RotationDegrees_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, 100664956);
			GizmoPlaneSlider2D.NativeMethodInfoPtr_set_RotationDegrees_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, 100664957);
			GizmoPlaneSlider2D.NativeMethodInfoPtr_get_Right_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, 100664958);
			GizmoPlaneSlider2D.NativeMethodInfoPtr_get_Up_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, 100664959);
			GizmoPlaneSlider2D.NativeMethodInfoPtr_get_OffsetDragOrigin_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, 100664960);
			GizmoPlaneSlider2D.NativeMethodInfoPtr_set_OffsetDragOrigin_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, 100664961);
			GizmoPlaneSlider2D.NativeMethodInfoPtr_get_DragChannel_Public_get_GizmoDragChannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, 100664962);
			GizmoPlaneSlider2D.NativeMethodInfoPtr_get_ScaleDragOrigin_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, 100664963);
			GizmoPlaneSlider2D.NativeMethodInfoPtr_set_ScaleDragOrigin_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, 100664964);
			GizmoPlaneSlider2D.NativeMethodInfoPtr_get_ScaleDragAxisIndexRight_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, 100664965);
			GizmoPlaneSlider2D.NativeMethodInfoPtr_set_ScaleDragAxisIndexRight_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, 100664966);
			GizmoPlaneSlider2D.NativeMethodInfoPtr_get_ScaleDragAxisIndexUp_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, 100664967);
			GizmoPlaneSlider2D.NativeMethodInfoPtr_set_ScaleDragAxisIndexUp_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, 100664968);
			GizmoPlaneSlider2D.NativeMethodInfoPtr_get_TotalDragOffset_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, 100664969);
			GizmoPlaneSlider2D.NativeMethodInfoPtr_get_RelativeDragOffset_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, 100664970);
			GizmoPlaneSlider2D.NativeMethodInfoPtr_get_TotalDragRotation_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, 100664971);
			GizmoPlaneSlider2D.NativeMethodInfoPtr_get_RelativeDragRotation_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, 100664972);
			GizmoPlaneSlider2D.NativeMethodInfoPtr_get_TotalDragScaleRight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, 100664973);
			GizmoPlaneSlider2D.NativeMethodInfoPtr_get_RelativeDragScaleRight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, 100664974);
			GizmoPlaneSlider2D.NativeMethodInfoPtr_get_TotalDragScaleUp_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, 100664975);
			GizmoPlaneSlider2D.NativeMethodInfoPtr_get_RelativeDragScaleUp_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, 100664976);
			GizmoPlaneSlider2D.NativeMethodInfoPtr_get_IsBorderVisible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, 100664977);
			GizmoPlaneSlider2D.NativeMethodInfoPtr_get_IsBorderHoverable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, 100664978);
			GizmoPlaneSlider2D.NativeMethodInfoPtr_get_IsDragged_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, 100664979);
			GizmoPlaneSlider2D.NativeMethodInfoPtr_get_IsMoving_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, 100664980);
			GizmoPlaneSlider2D.NativeMethodInfoPtr_get_IsRotating_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, 100664981);
			GizmoPlaneSlider2D.NativeMethodInfoPtr_get_IsScaling_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, 100664982);
			GizmoPlaneSlider2D.NativeMethodInfoPtr__ctor_Public_Void_Gizmo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, 100664983);
			GizmoPlaneSlider2D.NativeMethodInfoPtr_SetBorderVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, 100664984);
			GizmoPlaneSlider2D.NativeMethodInfoPtr_SetBorderHoverable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, 100664985);
			GizmoPlaneSlider2D.NativeMethodInfoPtr_SetSnapEnabled_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, 100664986);
			GizmoPlaneSlider2D.NativeMethodInfoPtr_SetPolyCwPoints_Public_Void_List_1_Vector2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, 100664987);
			GizmoPlaneSlider2D.NativeMethodInfoPtr_MakePolySphereBorder_Public_Void_Vector3_Single_Int32_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, 100664988);
			GizmoPlaneSlider2D.NativeMethodInfoPtr_GetRealQuadWidth_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, 100664989);
			GizmoPlaneSlider2D.NativeMethodInfoPtr_GetRealQuadHeight_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, 100664990);
			GizmoPlaneSlider2D.NativeMethodInfoPtr_GetRealQuadSize_Public_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, 100664991);
			GizmoPlaneSlider2D.NativeMethodInfoPtr_GetRealCircleRadius_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, 100664992);
			GizmoPlaneSlider2D.NativeMethodInfoPtr_GetRealExtentPoint_Public_Vector2_Shape2DExtentPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, 100664993);
			GizmoPlaneSlider2D.NativeMethodInfoPtr_SetDragChannel_Public_Void_GizmoDragChannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, 100664994);
			GizmoPlaneSlider2D.NativeMethodInfoPtr_AddTargetTransform_Public_Void_GizmoTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, 100664995);
			GizmoPlaneSlider2D.NativeMethodInfoPtr_AddTargetTransform_Public_Void_GizmoTransform_GizmoDragChannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, 100664996);
			GizmoPlaneSlider2D.NativeMethodInfoPtr_RemoveTargetTransform_Public_Void_GizmoTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, 100664997);
			GizmoPlaneSlider2D.NativeMethodInfoPtr_RemoveTargetTransform_Public_Void_GizmoTransform_GizmoDragChannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, 100664998);
			GizmoPlaneSlider2D.NativeMethodInfoPtr_Render_Public_Virtual_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, 100664999);
			GizmoPlaneSlider2D.NativeMethodInfoPtr_Refresh_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, 100665000);
			GizmoPlaneSlider2D.NativeMethodInfoPtr_OnVisibilityStateChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, 100665001);
			GizmoPlaneSlider2D.NativeMethodInfoPtr_OnHoverableStateChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, 100665002);
			GizmoPlaneSlider2D.NativeMethodInfoPtr_OnGizmoPreUpdateBegin_Private_Void_Gizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, 100665003);
			GizmoPlaneSlider2D.NativeMethodInfoPtr_OnTransformChanged_Private_Void_GizmoTransform_ChangeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, 100665004);
			GizmoPlaneSlider2D.NativeMethodInfoPtr_OnGizmoAttemptHandleDragBegin_Private_Void_Gizmo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, 100665005);
			GizmoPlaneSlider2D.NativeMethodInfoPtr_OnGizmoHandleDragUpdate_Private_Void_Gizmo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, 100665006);
			GizmoPlaneSlider2D.NativeMethodInfoPtr_OnGizmoPostEnabled_Private_Void_Gizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr, 100665007);
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06000B1B RID: 2843 RVA: 0x0004C9E8 File Offset: 0x0004ABE8
		public unsafe GizmoPlaneSlider2DSettings Settings
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 65864, RefRangeEnd = 65868, XrefRangeStart = 65864, XrefRangeEnd = 65864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2D.NativeMethodInfoPtr_get_Settings_Public_get_GizmoPlaneSlider2DSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoPlaneSlider2DSettings>(intPtr3) : null;
			}
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06000B1C RID: 2844 RVA: 0x0004CA28 File Offset: 0x0004AC28
		// (set) Token: 0x06000B1D RID: 2845 RVA: 0x0004CA68 File Offset: 0x0004AC68
		public unsafe GizmoPlaneSlider2DSettings SharedSettings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2D.NativeMethodInfoPtr_get_SharedSettings_Public_get_GizmoPlaneSlider2DSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoPlaneSlider2DSettings>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65868, XrefRangeEnd = 65869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2D.NativeMethodInfoPtr_set_SharedSettings_Public_set_Void_GizmoPlaneSlider2DSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06000B1E RID: 2846 RVA: 0x0004CAAC File Offset: 0x0004ACAC
		public unsafe GizmoPlaneSlider2DLookAndFeel LookAndFeel
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 65869, RefRangeEnd = 65888, XrefRangeStart = 65869, XrefRangeEnd = 65869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2D.NativeMethodInfoPtr_get_LookAndFeel_Public_get_GizmoPlaneSlider2DLookAndFeel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoPlaneSlider2DLookAndFeel>(intPtr3) : null;
			}
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06000B1F RID: 2847 RVA: 0x0004CAEC File Offset: 0x0004ACEC
		// (set) Token: 0x06000B20 RID: 2848 RVA: 0x0004CB2C File Offset: 0x0004AD2C
		public unsafe GizmoPlaneSlider2DLookAndFeel SharedLookAndFeel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2D.NativeMethodInfoPtr_get_SharedLookAndFeel_Public_get_GizmoPlaneSlider2DLookAndFeel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoPlaneSlider2DLookAndFeel>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65888, XrefRangeEnd = 65889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2D.NativeMethodInfoPtr_set_SharedLookAndFeel_Public_set_Void_GizmoPlaneSlider2DLookAndFeel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06000B21 RID: 2849 RVA: 0x0004CB70 File Offset: 0x0004AD70
		// (set) Token: 0x06000B22 RID: 2850 RVA: 0x0004CBB0 File Offset: 0x0004ADB0
		public unsafe Vector2 Position
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2D.NativeMethodInfoPtr_get_Position_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65889, XrefRangeEnd = 65891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2D.NativeMethodInfoPtr_set_Position_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06000B23 RID: 2851 RVA: 0x0004CBF4 File Offset: 0x0004ADF4
		public unsafe Vector2 PolyCenter
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65891, XrefRangeEnd = 65894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2D.NativeMethodInfoPtr_get_PolyCenter_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06000B24 RID: 2852 RVA: 0x0004CC34 File Offset: 0x0004AE34
		public unsafe Quaternion Rotation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2D.NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr3) : null;
			}
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06000B25 RID: 2853 RVA: 0x0004CC74 File Offset: 0x0004AE74
		// (set) Token: 0x06000B26 RID: 2854 RVA: 0x0004CCB0 File Offset: 0x0004AEB0
		public unsafe float RotationDegrees
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2D.NativeMethodInfoPtr_get_RotationDegrees_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65894, XrefRangeEnd = 65896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2D.NativeMethodInfoPtr_set_RotationDegrees_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06000B27 RID: 2855 RVA: 0x0004CCF0 File Offset: 0x0004AEF0
		public unsafe Vector2 Right
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65896, XrefRangeEnd = 65898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2D.NativeMethodInfoPtr_get_Right_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06000B28 RID: 2856 RVA: 0x0004CD30 File Offset: 0x0004AF30
		public unsafe Vector2 Up
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65898, XrefRangeEnd = 65900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2D.NativeMethodInfoPtr_get_Up_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06000B29 RID: 2857 RVA: 0x0004CD70 File Offset: 0x0004AF70
		// (set) Token: 0x06000B2A RID: 2858 RVA: 0x0004CDB0 File Offset: 0x0004AFB0
		public unsafe Vector3 OffsetDragOrigin
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2D.NativeMethodInfoPtr_get_OffsetDragOrigin_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2D.NativeMethodInfoPtr_set_OffsetDragOrigin_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06000B2B RID: 2859 RVA: 0x0004CDF4 File Offset: 0x0004AFF4
		public unsafe GizmoDragChannel DragChannel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2D.NativeMethodInfoPtr_get_DragChannel_Public_get_GizmoDragChannel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoDragChannel>(intPtr3) : null;
			}
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06000B2C RID: 2860 RVA: 0x0004CE34 File Offset: 0x0004B034
		// (set) Token: 0x06000B2D RID: 2861 RVA: 0x0004CE74 File Offset: 0x0004B074
		public unsafe Vector3 ScaleDragOrigin
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2D.NativeMethodInfoPtr_get_ScaleDragOrigin_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2D.NativeMethodInfoPtr_set_ScaleDragOrigin_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06000B2E RID: 2862 RVA: 0x0004CEB8 File Offset: 0x0004B0B8
		// (set) Token: 0x06000B2F RID: 2863 RVA: 0x0004CEF4 File Offset: 0x0004B0F4
		public unsafe int ScaleDragAxisIndexRight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2D.NativeMethodInfoPtr_get_ScaleDragAxisIndexRight_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2D.NativeMethodInfoPtr_set_ScaleDragAxisIndexRight_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06000B30 RID: 2864 RVA: 0x0004CF34 File Offset: 0x0004B134
		// (set) Token: 0x06000B31 RID: 2865 RVA: 0x0004CF70 File Offset: 0x0004B170
		public unsafe int ScaleDragAxisIndexUp
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2D.NativeMethodInfoPtr_get_ScaleDragAxisIndexUp_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2D.NativeMethodInfoPtr_set_ScaleDragAxisIndexUp_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06000B32 RID: 2866 RVA: 0x0004CFB0 File Offset: 0x0004B1B0
		public unsafe Vector3 TotalDragOffset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2D.NativeMethodInfoPtr_get_TotalDragOffset_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06000B33 RID: 2867 RVA: 0x0004CFF0 File Offset: 0x0004B1F0
		public unsafe Vector3 RelativeDragOffset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2D.NativeMethodInfoPtr_get_RelativeDragOffset_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06000B34 RID: 2868 RVA: 0x0004D030 File Offset: 0x0004B230
		public unsafe float TotalDragRotation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2D.NativeMethodInfoPtr_get_TotalDragRotation_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06000B35 RID: 2869 RVA: 0x0004D06C File Offset: 0x0004B26C
		public unsafe float RelativeDragRotation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2D.NativeMethodInfoPtr_get_RelativeDragRotation_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06000B36 RID: 2870 RVA: 0x0004D0A8 File Offset: 0x0004B2A8
		public unsafe float TotalDragScaleRight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2D.NativeMethodInfoPtr_get_TotalDragScaleRight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06000B37 RID: 2871 RVA: 0x0004D0E4 File Offset: 0x0004B2E4
		public unsafe float RelativeDragScaleRight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2D.NativeMethodInfoPtr_get_RelativeDragScaleRight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06000B38 RID: 2872 RVA: 0x0004D120 File Offset: 0x0004B320
		public unsafe float TotalDragScaleUp
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2D.NativeMethodInfoPtr_get_TotalDragScaleUp_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06000B39 RID: 2873 RVA: 0x0004D15C File Offset: 0x0004B35C
		public unsafe float RelativeDragScaleUp
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2D.NativeMethodInfoPtr_get_RelativeDragScaleUp_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06000B3A RID: 2874 RVA: 0x0004D198 File Offset: 0x0004B398
		public unsafe bool IsBorderVisible
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2D.NativeMethodInfoPtr_get_IsBorderVisible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06000B3B RID: 2875 RVA: 0x0004D1D4 File Offset: 0x0004B3D4
		public unsafe bool IsBorderHoverable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2D.NativeMethodInfoPtr_get_IsBorderHoverable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06000B3C RID: 2876 RVA: 0x0004D210 File Offset: 0x0004B410
		public unsafe bool IsDragged
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65900, XrefRangeEnd = 65901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2D.NativeMethodInfoPtr_get_IsDragged_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06000B3D RID: 2877 RVA: 0x0004D24C File Offset: 0x0004B44C
		public unsafe bool IsMoving
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65901, XrefRangeEnd = 65902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2D.NativeMethodInfoPtr_get_IsMoving_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06000B3E RID: 2878 RVA: 0x0004D288 File Offset: 0x0004B488
		public unsafe bool IsRotating
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65902, XrefRangeEnd = 65903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2D.NativeMethodInfoPtr_get_IsRotating_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06000B3F RID: 2879 RVA: 0x0004D2C4 File Offset: 0x0004B4C4
		public unsafe bool IsScaling
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65903, XrefRangeEnd = 65904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2D.NativeMethodInfoPtr_get_IsScaling_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B40 RID: 2880 RVA: 0x0004D300 File Offset: 0x0004B500
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 66080, RefRangeEnd = 66084, XrefRangeStart = 65904, XrefRangeEnd = 66080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoPlaneSlider2D(Gizmo gizmo, int handleId)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoPlaneSlider2D>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gizmo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handleId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2D.NativeMethodInfoPtr__ctor_Public_Void_Gizmo_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B41 RID: 2881 RVA: 0x0004D35C File Offset: 0x0004B55C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 66087, RefRangeEnd = 66094, XrefRangeStart = 66084, XrefRangeEnd = 66087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBorderVisible(bool isVisible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isVisible;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2D.NativeMethodInfoPtr_SetBorderVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B42 RID: 2882 RVA: 0x0004D39C File Offset: 0x0004B59C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66094, XrefRangeEnd = 66098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBorderHoverable(bool isHoverable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isHoverable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2D.NativeMethodInfoPtr_SetBorderHoverable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B43 RID: 2883 RVA: 0x0004D3DC File Offset: 0x0004B5DC
		[CallerCount(0)]
		public unsafe override void SetSnapEnabled(bool isEnabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isEnabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoPlaneSlider2D.NativeMethodInfoPtr_SetSnapEnabled_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B44 RID: 2884 RVA: 0x0004D428 File Offset: 0x0004B628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66098, XrefRangeEnd = 66102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPolyCwPoints(List<Vector2> cwPoints, bool isClosed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cwPoints);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isClosed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2D.NativeMethodInfoPtr_SetPolyCwPoints_Public_Void_List_1_Vector2_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B45 RID: 2885 RVA: 0x0004D478 File Offset: 0x0004B678
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 66106, RefRangeEnd = 66108, XrefRangeStart = 66102, XrefRangeEnd = 66106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MakePolySphereBorder(Vector3 sphereCenter, float sphereRadius, int numPoints, Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sphereCenter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sphereRadius;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numPoints;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2D.NativeMethodInfoPtr_MakePolySphereBorder_Public_Void_Vector3_Single_Int32_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B46 RID: 2886 RVA: 0x0004D4EC File Offset: 0x0004B6EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 66112, RefRangeEnd = 66114, XrefRangeStart = 66108, XrefRangeEnd = 66112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetRealQuadWidth()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2D.NativeMethodInfoPtr_GetRealQuadWidth_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B47 RID: 2887 RVA: 0x0004D528 File Offset: 0x0004B728
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 66118, RefRangeEnd = 66120, XrefRangeStart = 66114, XrefRangeEnd = 66118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetRealQuadHeight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2D.NativeMethodInfoPtr_GetRealQuadHeight_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B48 RID: 2888 RVA: 0x0004D564 File Offset: 0x0004B764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66120, XrefRangeEnd = 66122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetRealQuadSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2D.NativeMethodInfoPtr_GetRealQuadSize_Public_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
		}

		// Token: 0x06000B49 RID: 2889 RVA: 0x0004D5A4 File Offset: 0x0004B7A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 66126, RefRangeEnd = 66127, XrefRangeStart = 66122, XrefRangeEnd = 66126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetRealCircleRadius()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2D.NativeMethodInfoPtr_GetRealCircleRadius_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B4A RID: 2890 RVA: 0x0004D5E0 File Offset: 0x0004B7E0
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 66133, RefRangeEnd = 66143, XrefRangeStart = 66127, XrefRangeEnd = 66133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetRealExtentPoint(Shape2DExtentPoint extentPt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(extentPt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2D.NativeMethodInfoPtr_GetRealExtentPoint_Public_Vector2_Shape2DExtentPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
		}

		// Token: 0x06000B4B RID: 2891 RVA: 0x0004D630 File Offset: 0x0004B830
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 66148, RefRangeEnd = 66152, XrefRangeStart = 66143, XrefRangeEnd = 66148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDragChannel(GizmoDragChannel dragChannel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dragChannel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2D.NativeMethodInfoPtr_SetDragChannel_Public_Void_GizmoDragChannel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B4C RID: 2892 RVA: 0x0004D674 File Offset: 0x0004B874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66152, XrefRangeEnd = 66156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddTargetTransform(GizmoTransform transform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2D.NativeMethodInfoPtr_AddTargetTransform_Public_Void_GizmoTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B4D RID: 2893 RVA: 0x0004D6B8 File Offset: 0x0004B8B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66156, XrefRangeEnd = 66157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2D.NativeMethodInfoPtr_AddTargetTransform_Public_Void_GizmoTransform_GizmoDragChannel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B4E RID: 2894 RVA: 0x0004D70C File Offset: 0x0004B90C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66157, XrefRangeEnd = 66161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveTargetTransform(GizmoTransform transform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2D.NativeMethodInfoPtr_RemoveTargetTransform_Public_Void_GizmoTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B4F RID: 2895 RVA: 0x0004D750 File Offset: 0x0004B950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66161, XrefRangeEnd = 66162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2D.NativeMethodInfoPtr_RemoveTargetTransform_Public_Void_GizmoTransform_GizmoDragChannel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B50 RID: 2896 RVA: 0x0004D7A4 File Offset: 0x0004B9A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66162, XrefRangeEnd = 66183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Render(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoPlaneSlider2D.NativeMethodInfoPtr_Render_Public_Virtual_Void_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B51 RID: 2897 RVA: 0x0004D7F4 File Offset: 0x0004B9F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66183, XrefRangeEnd = 66192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Refresh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2D.NativeMethodInfoPtr_Refresh_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x0004D828 File Offset: 0x0004BA28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66192, XrefRangeEnd = 66201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnVisibilityStateChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoPlaneSlider2D.NativeMethodInfoPtr_OnVisibilityStateChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x0004D864 File Offset: 0x0004BA64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66201, XrefRangeEnd = 66204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnHoverableStateChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoPlaneSlider2D.NativeMethodInfoPtr_OnHoverableStateChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x0004D8A0 File Offset: 0x0004BAA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66204, XrefRangeEnd = 66216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGizmoPreUpdateBegin(Gizmo gizmo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gizmo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2D.NativeMethodInfoPtr_OnGizmoPreUpdateBegin_Private_Void_Gizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B55 RID: 2901 RVA: 0x0004D8E4 File Offset: 0x0004BAE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66216, XrefRangeEnd = 66219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2D.NativeMethodInfoPtr_OnTransformChanged_Private_Void_GizmoTransform_ChangeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x0004D934 File Offset: 0x0004BB34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66219, XrefRangeEnd = 66229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2D.NativeMethodInfoPtr_OnGizmoAttemptHandleDragBegin_Private_Void_Gizmo_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x0004D984 File Offset: 0x0004BB84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66229, XrefRangeEnd = 66231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGizmoHandleDragUpdate(Gizmo gizmo, int handleId)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2D.NativeMethodInfoPtr_OnGizmoHandleDragUpdate_Private_Void_Gizmo_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B58 RID: 2904 RVA: 0x0004D9D4 File Offset: 0x0004BBD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGizmoPostEnabled(Gizmo gizmo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gizmo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider2D.NativeMethodInfoPtr_OnGizmoPostEnabled_Private_Void_Gizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B59 RID: 2905 RVA: 0x00005DF4 File Offset: 0x00003FF4
		public GizmoPlaneSlider2D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06000B5A RID: 2906 RVA: 0x0004DA18 File Offset: 0x0004BC18
		// (set) Token: 0x06000B5B RID: 2907 RVA: 0x00005DFD File Offset: 0x00003FFD
		public unsafe int _quadIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2D.NativeFieldInfoPtr__quadIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2D.NativeFieldInfoPtr__quadIndex)) = value;
			}
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06000B5C RID: 2908 RVA: 0x0004DA40 File Offset: 0x0004BC40
		// (set) Token: 0x06000B5D RID: 2909 RVA: 0x00005E18 File Offset: 0x00004018
		public unsafe int _circleIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2D.NativeFieldInfoPtr__circleIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2D.NativeFieldInfoPtr__circleIndex)) = value;
			}
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06000B5E RID: 2910 RVA: 0x0004DA68 File Offset: 0x0004BC68
		// (set) Token: 0x06000B5F RID: 2911 RVA: 0x00005E33 File Offset: 0x00004033
		public unsafe int _polygonIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2D.NativeFieldInfoPtr__polygonIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2D.NativeFieldInfoPtr__polygonIndex)) = value;
			}
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06000B60 RID: 2912 RVA: 0x0004DA90 File Offset: 0x0004BC90
		// (set) Token: 0x06000B61 RID: 2913 RVA: 0x00005E4E File Offset: 0x0000404E
		public unsafe QuadShape2D _quad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2D.NativeFieldInfoPtr__quad);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuadShape2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2D.NativeFieldInfoPtr__quad), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06000B62 RID: 2914 RVA: 0x0004DAC0 File Offset: 0x0004BCC0
		// (set) Token: 0x06000B63 RID: 2915 RVA: 0x00005E6D File Offset: 0x0000406D
		public unsafe CircleShape2D _circle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2D.NativeFieldInfoPtr__circle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CircleShape2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2D.NativeFieldInfoPtr__circle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06000B64 RID: 2916 RVA: 0x0004DAF0 File Offset: 0x0004BCF0
		// (set) Token: 0x06000B65 RID: 2917 RVA: 0x00005E8C File Offset: 0x0000408C
		public unsafe PolygonShape2D _polygon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2D.NativeFieldInfoPtr__polygon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PolygonShape2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2D.NativeFieldInfoPtr__polygon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06000B66 RID: 2918 RVA: 0x0004DB20 File Offset: 0x0004BD20
		// (set) Token: 0x06000B67 RID: 2919 RVA: 0x00005EAB File Offset: 0x000040AB
		public unsafe GizmoQuad2DBorder _quadBorder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2D.NativeFieldInfoPtr__quadBorder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoQuad2DBorder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2D.NativeFieldInfoPtr__quadBorder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06000B68 RID: 2920 RVA: 0x0004DB50 File Offset: 0x0004BD50
		// (set) Token: 0x06000B69 RID: 2921 RVA: 0x00005ECA File Offset: 0x000040CA
		public unsafe GizmoCircle2DBorder _circleBorder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2D.NativeFieldInfoPtr__circleBorder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoCircle2DBorder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2D.NativeFieldInfoPtr__circleBorder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06000B6A RID: 2922 RVA: 0x0004DB80 File Offset: 0x0004BD80
		// (set) Token: 0x06000B6B RID: 2923 RVA: 0x00005EE9 File Offset: 0x000040E9
		public unsafe GizmoPolygon2DBorder _polygonBorder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2D.NativeFieldInfoPtr__polygonBorder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPolygon2DBorder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2D.NativeFieldInfoPtr__polygonBorder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06000B6C RID: 2924 RVA: 0x0004DBB0 File Offset: 0x0004BDB0
		// (set) Token: 0x06000B6D RID: 2925 RVA: 0x00005F08 File Offset: 0x00004108
		public unsafe bool _isBorderVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2D.NativeFieldInfoPtr__isBorderVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2D.NativeFieldInfoPtr__isBorderVisible)) = value;
			}
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06000B6E RID: 2926 RVA: 0x0004DBD8 File Offset: 0x0004BDD8
		// (set) Token: 0x06000B6F RID: 2927 RVA: 0x00005F23 File Offset: 0x00004123
		public unsafe bool _isBorderHoverable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2D.NativeFieldInfoPtr__isBorderHoverable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2D.NativeFieldInfoPtr__isBorderHoverable)) = value;
			}
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06000B70 RID: 2928 RVA: 0x0004DC00 File Offset: 0x0004BE00
		// (set) Token: 0x06000B71 RID: 2929 RVA: 0x00005F3E File Offset: 0x0000413E
		public unsafe GizmoTransform _transform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2D.NativeFieldInfoPtr__transform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2D.NativeFieldInfoPtr__transform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06000B72 RID: 2930 RVA: 0x0004DC30 File Offset: 0x0004BE30
		// (set) Token: 0x06000B73 RID: 2931 RVA: 0x00005F5D File Offset: 0x0000415D
		public unsafe GizmoDragChannel _dragChannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2D.NativeFieldInfoPtr__dragChannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoDragChannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2D.NativeFieldInfoPtr__dragChannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06000B74 RID: 2932 RVA: 0x0004DC60 File Offset: 0x0004BE60
		// (set) Token: 0x06000B75 RID: 2933 RVA: 0x00005F7C File Offset: 0x0000417C
		public unsafe IGizmoDragSession _selectedDragSession
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2D.NativeFieldInfoPtr__selectedDragSession);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGizmoDragSession>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2D.NativeFieldInfoPtr__selectedDragSession), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06000B76 RID: 2934 RVA: 0x0004DC90 File Offset: 0x0004BE90
		// (set) Token: 0x06000B77 RID: 2935 RVA: 0x00005F9B File Offset: 0x0000419B
		public unsafe GizmoDblAxisOffsetDrag3D _offsetDrag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2D.NativeFieldInfoPtr__offsetDrag);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoDblAxisOffsetDrag3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2D.NativeFieldInfoPtr__offsetDrag), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06000B78 RID: 2936 RVA: 0x0004DCC0 File Offset: 0x0004BEC0
		// (set) Token: 0x06000B79 RID: 2937 RVA: 0x00005FBA File Offset: 0x000041BA
		public unsafe Vector3 _offsetDragOrigin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2D.NativeFieldInfoPtr__offsetDragOrigin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2D.NativeFieldInfoPtr__offsetDragOrigin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06000B7A RID: 2938 RVA: 0x0004DCF0 File Offset: 0x0004BEF0
		// (set) Token: 0x06000B7B RID: 2939 RVA: 0x00005FD9 File Offset: 0x000041D9
		public unsafe GizmoSglAxisRotationDrag3D _rotationDrag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2D.NativeFieldInfoPtr__rotationDrag);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoSglAxisRotationDrag3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2D.NativeFieldInfoPtr__rotationDrag), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06000B7C RID: 2940 RVA: 0x0004DD20 File Offset: 0x0004BF20
		// (set) Token: 0x06000B7D RID: 2941 RVA: 0x00005FF8 File Offset: 0x000041F8
		public unsafe GizmoRotationArc2D _rotationArc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2D.NativeFieldInfoPtr__rotationArc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoRotationArc2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2D.NativeFieldInfoPtr__rotationArc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06000B7E RID: 2942 RVA: 0x0004DD50 File Offset: 0x0004BF50
		// (set) Token: 0x06000B7F RID: 2943 RVA: 0x00006017 File Offset: 0x00004217
		public unsafe GizmoDblAxisScaleDrag3D _scaleDrag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2D.NativeFieldInfoPtr__scaleDrag);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoDblAxisScaleDrag3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2D.NativeFieldInfoPtr__scaleDrag), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06000B80 RID: 2944 RVA: 0x0004DD80 File Offset: 0x0004BF80
		// (set) Token: 0x06000B81 RID: 2945 RVA: 0x00006036 File Offset: 0x00004236
		public unsafe Vector3 _scaleDragOrigin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2D.NativeFieldInfoPtr__scaleDragOrigin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2D.NativeFieldInfoPtr__scaleDragOrigin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06000B82 RID: 2946 RVA: 0x0004DDB0 File Offset: 0x0004BFB0
		// (set) Token: 0x06000B83 RID: 2947 RVA: 0x00006055 File Offset: 0x00004255
		public unsafe Vector3 _scaleAxisRight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2D.NativeFieldInfoPtr__scaleAxisRight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2D.NativeFieldInfoPtr__scaleAxisRight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06000B84 RID: 2948 RVA: 0x0004DDE0 File Offset: 0x0004BFE0
		// (set) Token: 0x06000B85 RID: 2949 RVA: 0x00006074 File Offset: 0x00004274
		public unsafe Vector3 _scaleAxisUp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2D.NativeFieldInfoPtr__scaleAxisUp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2D.NativeFieldInfoPtr__scaleAxisUp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06000B86 RID: 2950 RVA: 0x0004DE10 File Offset: 0x0004C010
		// (set) Token: 0x06000B87 RID: 2951 RVA: 0x00006093 File Offset: 0x00004293
		public unsafe int _scaleDragAxisIndexRight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2D.NativeFieldInfoPtr__scaleDragAxisIndexRight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2D.NativeFieldInfoPtr__scaleDragAxisIndexRight)) = value;
			}
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06000B88 RID: 2952 RVA: 0x0004DE38 File Offset: 0x0004C038
		// (set) Token: 0x06000B89 RID: 2953 RVA: 0x000060AE File Offset: 0x000042AE
		public unsafe int _scaleDragAxisIndexUp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2D.NativeFieldInfoPtr__scaleDragAxisIndexUp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2D.NativeFieldInfoPtr__scaleDragAxisIndexUp)) = value;
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06000B8A RID: 2954 RVA: 0x0004DE60 File Offset: 0x0004C060
		// (set) Token: 0x06000B8B RID: 2955 RVA: 0x000060C9 File Offset: 0x000042C9
		public unsafe GizmoPlaneSlider2DControllerData _controllerData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2D.NativeFieldInfoPtr__controllerData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPlaneSlider2DControllerData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2D.NativeFieldInfoPtr__controllerData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06000B8C RID: 2956 RVA: 0x0004DE90 File Offset: 0x0004C090
		// (set) Token: 0x06000B8D RID: 2957 RVA: 0x000060E8 File Offset: 0x000042E8
		public unsafe Il2CppReferenceArray<IGizmoPlaneSlider2DController> _controllers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2D.NativeFieldInfoPtr__controllers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IGizmoPlaneSlider2DController>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2D.NativeFieldInfoPtr__controllers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06000B8E RID: 2958 RVA: 0x0004DEC0 File Offset: 0x0004C0C0
		// (set) Token: 0x06000B8F RID: 2959 RVA: 0x00006107 File Offset: 0x00004307
		public unsafe GizmoPlaneSlider2DSettings _settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2D.NativeFieldInfoPtr__settings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPlaneSlider2DSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2D.NativeFieldInfoPtr__settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06000B90 RID: 2960 RVA: 0x0004DEF0 File Offset: 0x0004C0F0
		// (set) Token: 0x06000B91 RID: 2961 RVA: 0x00006126 File Offset: 0x00004326
		public unsafe GizmoPlaneSlider2DSettings _sharedSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2D.NativeFieldInfoPtr__sharedSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPlaneSlider2DSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2D.NativeFieldInfoPtr__sharedSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06000B92 RID: 2962 RVA: 0x0004DF20 File Offset: 0x0004C120
		// (set) Token: 0x06000B93 RID: 2963 RVA: 0x00006145 File Offset: 0x00004345
		public unsafe GizmoPlaneSlider2DLookAndFeel _lookAndFeel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2D.NativeFieldInfoPtr__lookAndFeel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPlaneSlider2DLookAndFeel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2D.NativeFieldInfoPtr__lookAndFeel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06000B94 RID: 2964 RVA: 0x0004DF50 File Offset: 0x0004C150
		// (set) Token: 0x06000B95 RID: 2965 RVA: 0x00006164 File Offset: 0x00004364
		public unsafe GizmoPlaneSlider2DLookAndFeel _sharedLookAndFeel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2D.NativeFieldInfoPtr__sharedLookAndFeel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPlaneSlider2DLookAndFeel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider2D.NativeFieldInfoPtr__sharedLookAndFeel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000872 RID: 2162
		private static readonly IntPtr NativeFieldInfoPtr__quadIndex;

		// Token: 0x04000873 RID: 2163
		private static readonly IntPtr NativeFieldInfoPtr__circleIndex;

		// Token: 0x04000874 RID: 2164
		private static readonly IntPtr NativeFieldInfoPtr__polygonIndex;

		// Token: 0x04000875 RID: 2165
		private static readonly IntPtr NativeFieldInfoPtr__quad;

		// Token: 0x04000876 RID: 2166
		private static readonly IntPtr NativeFieldInfoPtr__circle;

		// Token: 0x04000877 RID: 2167
		private static readonly IntPtr NativeFieldInfoPtr__polygon;

		// Token: 0x04000878 RID: 2168
		private static readonly IntPtr NativeFieldInfoPtr__quadBorder;

		// Token: 0x04000879 RID: 2169
		private static readonly IntPtr NativeFieldInfoPtr__circleBorder;

		// Token: 0x0400087A RID: 2170
		private static readonly IntPtr NativeFieldInfoPtr__polygonBorder;

		// Token: 0x0400087B RID: 2171
		private static readonly IntPtr NativeFieldInfoPtr__isBorderVisible;

		// Token: 0x0400087C RID: 2172
		private static readonly IntPtr NativeFieldInfoPtr__isBorderHoverable;

		// Token: 0x0400087D RID: 2173
		private static readonly IntPtr NativeFieldInfoPtr__transform;

		// Token: 0x0400087E RID: 2174
		private static readonly IntPtr NativeFieldInfoPtr__dragChannel;

		// Token: 0x0400087F RID: 2175
		private static readonly IntPtr NativeFieldInfoPtr__selectedDragSession;

		// Token: 0x04000880 RID: 2176
		private static readonly IntPtr NativeFieldInfoPtr__offsetDrag;

		// Token: 0x04000881 RID: 2177
		private static readonly IntPtr NativeFieldInfoPtr__offsetDragOrigin;

		// Token: 0x04000882 RID: 2178
		private static readonly IntPtr NativeFieldInfoPtr__rotationDrag;

		// Token: 0x04000883 RID: 2179
		private static readonly IntPtr NativeFieldInfoPtr__rotationArc;

		// Token: 0x04000884 RID: 2180
		private static readonly IntPtr NativeFieldInfoPtr__scaleDrag;

		// Token: 0x04000885 RID: 2181
		private static readonly IntPtr NativeFieldInfoPtr__scaleDragOrigin;

		// Token: 0x04000886 RID: 2182
		private static readonly IntPtr NativeFieldInfoPtr__scaleAxisRight;

		// Token: 0x04000887 RID: 2183
		private static readonly IntPtr NativeFieldInfoPtr__scaleAxisUp;

		// Token: 0x04000888 RID: 2184
		private static readonly IntPtr NativeFieldInfoPtr__scaleDragAxisIndexRight;

		// Token: 0x04000889 RID: 2185
		private static readonly IntPtr NativeFieldInfoPtr__scaleDragAxisIndexUp;

		// Token: 0x0400088A RID: 2186
		private static readonly IntPtr NativeFieldInfoPtr__controllerData;

		// Token: 0x0400088B RID: 2187
		private static readonly IntPtr NativeFieldInfoPtr__controllers;

		// Token: 0x0400088C RID: 2188
		private static readonly IntPtr NativeFieldInfoPtr__settings;

		// Token: 0x0400088D RID: 2189
		private static readonly IntPtr NativeFieldInfoPtr__sharedSettings;

		// Token: 0x0400088E RID: 2190
		private static readonly IntPtr NativeFieldInfoPtr__lookAndFeel;

		// Token: 0x0400088F RID: 2191
		private static readonly IntPtr NativeFieldInfoPtr__sharedLookAndFeel;

		// Token: 0x04000890 RID: 2192
		private static readonly IntPtr NativeMethodInfoPtr_get_Settings_Public_get_GizmoPlaneSlider2DSettings_0;

		// Token: 0x04000891 RID: 2193
		private static readonly IntPtr NativeMethodInfoPtr_get_SharedSettings_Public_get_GizmoPlaneSlider2DSettings_0;

		// Token: 0x04000892 RID: 2194
		private static readonly IntPtr NativeMethodInfoPtr_set_SharedSettings_Public_set_Void_GizmoPlaneSlider2DSettings_0;

		// Token: 0x04000893 RID: 2195
		private static readonly IntPtr NativeMethodInfoPtr_get_LookAndFeel_Public_get_GizmoPlaneSlider2DLookAndFeel_0;

		// Token: 0x04000894 RID: 2196
		private static readonly IntPtr NativeMethodInfoPtr_get_SharedLookAndFeel_Public_get_GizmoPlaneSlider2DLookAndFeel_0;

		// Token: 0x04000895 RID: 2197
		private static readonly IntPtr NativeMethodInfoPtr_set_SharedLookAndFeel_Public_set_Void_GizmoPlaneSlider2DLookAndFeel_0;

		// Token: 0x04000896 RID: 2198
		private static readonly IntPtr NativeMethodInfoPtr_get_Position_Public_get_Vector2_0;

		// Token: 0x04000897 RID: 2199
		private static readonly IntPtr NativeMethodInfoPtr_set_Position_Public_set_Void_Vector2_0;

		// Token: 0x04000898 RID: 2200
		private static readonly IntPtr NativeMethodInfoPtr_get_PolyCenter_Public_get_Vector2_0;

		// Token: 0x04000899 RID: 2201
		private static readonly IntPtr NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0;

		// Token: 0x0400089A RID: 2202
		private static readonly IntPtr NativeMethodInfoPtr_get_RotationDegrees_Public_get_Single_0;

		// Token: 0x0400089B RID: 2203
		private static readonly IntPtr NativeMethodInfoPtr_set_RotationDegrees_Public_set_Void_Single_0;

		// Token: 0x0400089C RID: 2204
		private static readonly IntPtr NativeMethodInfoPtr_get_Right_Public_get_Vector2_0;

		// Token: 0x0400089D RID: 2205
		private static readonly IntPtr NativeMethodInfoPtr_get_Up_Public_get_Vector2_0;

		// Token: 0x0400089E RID: 2206
		private static readonly IntPtr NativeMethodInfoPtr_get_OffsetDragOrigin_Public_get_Vector3_0;

		// Token: 0x0400089F RID: 2207
		private static readonly IntPtr NativeMethodInfoPtr_set_OffsetDragOrigin_Public_set_Void_Vector3_0;

		// Token: 0x040008A0 RID: 2208
		private static readonly IntPtr NativeMethodInfoPtr_get_DragChannel_Public_get_GizmoDragChannel_0;

		// Token: 0x040008A1 RID: 2209
		private static readonly IntPtr NativeMethodInfoPtr_get_ScaleDragOrigin_Public_get_Vector3_0;

		// Token: 0x040008A2 RID: 2210
		private static readonly IntPtr NativeMethodInfoPtr_set_ScaleDragOrigin_Public_set_Void_Vector3_0;

		// Token: 0x040008A3 RID: 2211
		private static readonly IntPtr NativeMethodInfoPtr_get_ScaleDragAxisIndexRight_Public_get_Int32_0;

		// Token: 0x040008A4 RID: 2212
		private static readonly IntPtr NativeMethodInfoPtr_set_ScaleDragAxisIndexRight_Public_set_Void_Int32_0;

		// Token: 0x040008A5 RID: 2213
		private static readonly IntPtr NativeMethodInfoPtr_get_ScaleDragAxisIndexUp_Public_get_Int32_0;

		// Token: 0x040008A6 RID: 2214
		private static readonly IntPtr NativeMethodInfoPtr_set_ScaleDragAxisIndexUp_Public_set_Void_Int32_0;

		// Token: 0x040008A7 RID: 2215
		private static readonly IntPtr NativeMethodInfoPtr_get_TotalDragOffset_Public_get_Vector3_0;

		// Token: 0x040008A8 RID: 2216
		private static readonly IntPtr NativeMethodInfoPtr_get_RelativeDragOffset_Public_get_Vector3_0;

		// Token: 0x040008A9 RID: 2217
		private static readonly IntPtr NativeMethodInfoPtr_get_TotalDragRotation_Public_get_Single_0;

		// Token: 0x040008AA RID: 2218
		private static readonly IntPtr NativeMethodInfoPtr_get_RelativeDragRotation_Public_get_Single_0;

		// Token: 0x040008AB RID: 2219
		private static readonly IntPtr NativeMethodInfoPtr_get_TotalDragScaleRight_Public_get_Single_0;

		// Token: 0x040008AC RID: 2220
		private static readonly IntPtr NativeMethodInfoPtr_get_RelativeDragScaleRight_Public_get_Single_0;

		// Token: 0x040008AD RID: 2221
		private static readonly IntPtr NativeMethodInfoPtr_get_TotalDragScaleUp_Public_get_Single_0;

		// Token: 0x040008AE RID: 2222
		private static readonly IntPtr NativeMethodInfoPtr_get_RelativeDragScaleUp_Public_get_Single_0;

		// Token: 0x040008AF RID: 2223
		private static readonly IntPtr NativeMethodInfoPtr_get_IsBorderVisible_Public_get_Boolean_0;

		// Token: 0x040008B0 RID: 2224
		private static readonly IntPtr NativeMethodInfoPtr_get_IsBorderHoverable_Public_get_Boolean_0;

		// Token: 0x040008B1 RID: 2225
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDragged_Public_get_Boolean_0;

		// Token: 0x040008B2 RID: 2226
		private static readonly IntPtr NativeMethodInfoPtr_get_IsMoving_Public_get_Boolean_0;

		// Token: 0x040008B3 RID: 2227
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRotating_Public_get_Boolean_0;

		// Token: 0x040008B4 RID: 2228
		private static readonly IntPtr NativeMethodInfoPtr_get_IsScaling_Public_get_Boolean_0;

		// Token: 0x040008B5 RID: 2229
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Gizmo_Int32_0;

		// Token: 0x040008B6 RID: 2230
		private static readonly IntPtr NativeMethodInfoPtr_SetBorderVisible_Public_Void_Boolean_0;

		// Token: 0x040008B7 RID: 2231
		private static readonly IntPtr NativeMethodInfoPtr_SetBorderHoverable_Public_Void_Boolean_0;

		// Token: 0x040008B8 RID: 2232
		private static readonly IntPtr NativeMethodInfoPtr_SetSnapEnabled_Public_Virtual_Void_Boolean_0;

		// Token: 0x040008B9 RID: 2233
		private static readonly IntPtr NativeMethodInfoPtr_SetPolyCwPoints_Public_Void_List_1_Vector2_Boolean_0;

		// Token: 0x040008BA RID: 2234
		private static readonly IntPtr NativeMethodInfoPtr_MakePolySphereBorder_Public_Void_Vector3_Single_Int32_Camera_0;

		// Token: 0x040008BB RID: 2235
		private static readonly IntPtr NativeMethodInfoPtr_GetRealQuadWidth_Public_Single_0;

		// Token: 0x040008BC RID: 2236
		private static readonly IntPtr NativeMethodInfoPtr_GetRealQuadHeight_Public_Single_0;

		// Token: 0x040008BD RID: 2237
		private static readonly IntPtr NativeMethodInfoPtr_GetRealQuadSize_Public_Vector2_0;

		// Token: 0x040008BE RID: 2238
		private static readonly IntPtr NativeMethodInfoPtr_GetRealCircleRadius_Public_Single_0;

		// Token: 0x040008BF RID: 2239
		private static readonly IntPtr NativeMethodInfoPtr_GetRealExtentPoint_Public_Vector2_Shape2DExtentPoint_0;

		// Token: 0x040008C0 RID: 2240
		private static readonly IntPtr NativeMethodInfoPtr_SetDragChannel_Public_Void_GizmoDragChannel_0;

		// Token: 0x040008C1 RID: 2241
		private static readonly IntPtr NativeMethodInfoPtr_AddTargetTransform_Public_Void_GizmoTransform_0;

		// Token: 0x040008C2 RID: 2242
		private static readonly IntPtr NativeMethodInfoPtr_AddTargetTransform_Public_Void_GizmoTransform_GizmoDragChannel_0;

		// Token: 0x040008C3 RID: 2243
		private static readonly IntPtr NativeMethodInfoPtr_RemoveTargetTransform_Public_Void_GizmoTransform_0;

		// Token: 0x040008C4 RID: 2244
		private static readonly IntPtr NativeMethodInfoPtr_RemoveTargetTransform_Public_Void_GizmoTransform_GizmoDragChannel_0;

		// Token: 0x040008C5 RID: 2245
		private static readonly IntPtr NativeMethodInfoPtr_Render_Public_Virtual_Void_Camera_0;

		// Token: 0x040008C6 RID: 2246
		private static readonly IntPtr NativeMethodInfoPtr_Refresh_Public_Void_0;

		// Token: 0x040008C7 RID: 2247
		private static readonly IntPtr NativeMethodInfoPtr_OnVisibilityStateChanged_Protected_Virtual_Void_0;

		// Token: 0x040008C8 RID: 2248
		private static readonly IntPtr NativeMethodInfoPtr_OnHoverableStateChanged_Protected_Virtual_Void_0;

		// Token: 0x040008C9 RID: 2249
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoPreUpdateBegin_Private_Void_Gizmo_0;

		// Token: 0x040008CA RID: 2250
		private static readonly IntPtr NativeMethodInfoPtr_OnTransformChanged_Private_Void_GizmoTransform_ChangeData_0;

		// Token: 0x040008CB RID: 2251
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoAttemptHandleDragBegin_Private_Void_Gizmo_Int32_0;

		// Token: 0x040008CC RID: 2252
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoHandleDragUpdate_Private_Void_Gizmo_Int32_0;

		// Token: 0x040008CD RID: 2253
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoPostEnabled_Private_Void_Gizmo_0;
	}
}
