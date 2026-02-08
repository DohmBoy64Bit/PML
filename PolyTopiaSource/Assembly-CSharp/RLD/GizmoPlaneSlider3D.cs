using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace RLD
{
	// Token: 0x020000A5 RID: 165
	public class GizmoPlaneSlider3D : GizmoSlider
	{
		// Token: 0x06000D7C RID: 3452 RVA: 0x00055034 File Offset: 0x00053234
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoPlaneSlider3D()
		{
			Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoPlaneSlider3D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr);
			GizmoPlaneSlider3D.NativeFieldInfoPtr__quadIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, "_quadIndex");
			GizmoPlaneSlider3D.NativeFieldInfoPtr__raTriangleIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, "_raTriangleIndex");
			GizmoPlaneSlider3D.NativeFieldInfoPtr__circleIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, "_circleIndex");
			GizmoPlaneSlider3D.NativeFieldInfoPtr__quad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, "_quad");
			GizmoPlaneSlider3D.NativeFieldInfoPtr__raTriangle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, "_raTriangle");
			GizmoPlaneSlider3D.NativeFieldInfoPtr__circle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, "_circle");
			GizmoPlaneSlider3D.NativeFieldInfoPtr__quadBorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, "_quadBorder");
			GizmoPlaneSlider3D.NativeFieldInfoPtr__raTriangleBorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, "_raTriangleBorder");
			GizmoPlaneSlider3D.NativeFieldInfoPtr__circleBorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, "_circleBorder");
			GizmoPlaneSlider3D.NativeFieldInfoPtr__isBorderHoverable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, "_isBorderHoverable");
			GizmoPlaneSlider3D.NativeFieldInfoPtr__isBorderVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, "_isBorderVisible");
			GizmoPlaneSlider3D.NativeFieldInfoPtr__transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, "_transform");
			GizmoPlaneSlider3D.NativeFieldInfoPtr__dragChannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, "_dragChannel");
			GizmoPlaneSlider3D.NativeFieldInfoPtr__selectedDragSession = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, "_selectedDragSession");
			GizmoPlaneSlider3D.NativeFieldInfoPtr__dblAxisOffsetDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, "_dblAxisOffsetDrag");
			GizmoPlaneSlider3D.NativeFieldInfoPtr__rotationDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, "_rotationDrag");
			GizmoPlaneSlider3D.NativeFieldInfoPtr__rotationArc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, "_rotationArc");
			GizmoPlaneSlider3D.NativeFieldInfoPtr__scaleDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, "_scaleDrag");
			GizmoPlaneSlider3D.NativeFieldInfoPtr__scaleDragAxisIndexRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, "_scaleDragAxisIndexRight");
			GizmoPlaneSlider3D.NativeFieldInfoPtr__scaleDragAxisIndexUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, "_scaleDragAxisIndexUp");
			GizmoPlaneSlider3D.NativeFieldInfoPtr__controllerData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, "_controllerData");
			GizmoPlaneSlider3D.NativeFieldInfoPtr__controllers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, "_controllers");
			GizmoPlaneSlider3D.NativeFieldInfoPtr__settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, "_settings");
			GizmoPlaneSlider3D.NativeFieldInfoPtr__sharedSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, "_sharedSettings");
			GizmoPlaneSlider3D.NativeFieldInfoPtr__lookAndFeel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, "_lookAndFeel");
			GizmoPlaneSlider3D.NativeFieldInfoPtr__sharedLookAndFeel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, "_sharedLookAndFeel");
			GizmoPlaneSlider3D.NativeMethodInfoPtr_get_Settings_Public_get_GizmoPlaneSlider3DSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, 100665262);
			GizmoPlaneSlider3D.NativeMethodInfoPtr_get_SharedSettings_Public_get_GizmoPlaneSlider3DSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, 100665263);
			GizmoPlaneSlider3D.NativeMethodInfoPtr_set_SharedSettings_Public_set_Void_GizmoPlaneSlider3DSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, 100665264);
			GizmoPlaneSlider3D.NativeMethodInfoPtr_get_LookAndFeel_Public_get_GizmoPlaneSlider3DLookAndFeel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, 100665265);
			GizmoPlaneSlider3D.NativeMethodInfoPtr_get_SharedLookAndFeel_Public_get_GizmoPlaneSlider3DLookAndFeel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, 100665266);
			GizmoPlaneSlider3D.NativeMethodInfoPtr_set_SharedLookAndFeel_Public_set_Void_GizmoPlaneSlider3DLookAndFeel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, 100665267);
			GizmoPlaneSlider3D.NativeMethodInfoPtr_get_Plane_Public_get_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, 100665268);
			GizmoPlaneSlider3D.NativeMethodInfoPtr_get_Position_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, 100665269);
			GizmoPlaneSlider3D.NativeMethodInfoPtr_set_Position_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, 100665270);
			GizmoPlaneSlider3D.NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, 100665271);
			GizmoPlaneSlider3D.NativeMethodInfoPtr_set_Rotation_Public_set_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, 100665272);
			GizmoPlaneSlider3D.NativeMethodInfoPtr_get_LocalRotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, 100665273);
			GizmoPlaneSlider3D.NativeMethodInfoPtr_set_LocalRotation_Public_set_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, 100665274);
			GizmoPlaneSlider3D.NativeMethodInfoPtr_get_Right_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, 100665275);
			GizmoPlaneSlider3D.NativeMethodInfoPtr_get_Up_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, 100665276);
			GizmoPlaneSlider3D.NativeMethodInfoPtr_get_Look_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, 100665277);
			GizmoPlaneSlider3D.NativeMethodInfoPtr_get_Normal_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, 100665278);
			GizmoPlaneSlider3D.NativeMethodInfoPtr_get_DragChannel_Public_get_GizmoDragChannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, 100665279);
			GizmoPlaneSlider3D.NativeMethodInfoPtr_get_ScaleDragAxisIndexRight_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, 100665280);
			GizmoPlaneSlider3D.NativeMethodInfoPtr_set_ScaleDragAxisIndexRight_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, 100665281);
			GizmoPlaneSlider3D.NativeMethodInfoPtr_get_ScaleDragAxisIndexUp_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, 100665282);
			GizmoPlaneSlider3D.NativeMethodInfoPtr_set_ScaleDragAxisIndexUp_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, 100665283);
			GizmoPlaneSlider3D.NativeMethodInfoPtr_get_TotalDragOffset_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, 100665284);
			GizmoPlaneSlider3D.NativeMethodInfoPtr_get_RelativeDragOffset_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, 100665285);
			GizmoPlaneSlider3D.NativeMethodInfoPtr_get_TotalDragRotation_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, 100665286);
			GizmoPlaneSlider3D.NativeMethodInfoPtr_get_RelativeDragRotation_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, 100665287);
			GizmoPlaneSlider3D.NativeMethodInfoPtr_get_TotalDragScaleRight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, 100665288);
			GizmoPlaneSlider3D.NativeMethodInfoPtr_get_RelativeDragScaleRight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, 100665289);
			GizmoPlaneSlider3D.NativeMethodInfoPtr_get_TotalDragScaleUp_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, 100665290);
			GizmoPlaneSlider3D.NativeMethodInfoPtr_get_RelativeDragScaleUp_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, 100665291);
			GizmoPlaneSlider3D.NativeMethodInfoPtr_get_IsBorderVisible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, 100665292);
			GizmoPlaneSlider3D.NativeMethodInfoPtr_get_IsBorderHoverable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, 100665293);
			GizmoPlaneSlider3D.NativeMethodInfoPtr_get_IsDragged_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, 100665294);
			GizmoPlaneSlider3D.NativeMethodInfoPtr_get_IsMoving_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, 100665295);
			GizmoPlaneSlider3D.NativeMethodInfoPtr_get_IsRotating_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, 100665296);
			GizmoPlaneSlider3D.NativeMethodInfoPtr_get_IsScaling_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, 100665297);
			GizmoPlaneSlider3D.NativeMethodInfoPtr__ctor_Public_Void_Gizmo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, 100665298);
			GizmoPlaneSlider3D.NativeMethodInfoPtr_SetBorderVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, 100665299);
			GizmoPlaneSlider3D.NativeMethodInfoPtr_SetBorderHoverable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, 100665300);
			GizmoPlaneSlider3D.NativeMethodInfoPtr_SetSnapEnabled_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, 100665301);
			GizmoPlaneSlider3D.NativeMethodInfoPtr_SetZoomFactorTransform_Public_Void_GizmoTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, 100665302);
			GizmoPlaneSlider3D.NativeMethodInfoPtr_GetZoomFactor_Public_Single_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, 100665303);
			GizmoPlaneSlider3D.NativeMethodInfoPtr_GetRealQuadWidth_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, 100665304);
			GizmoPlaneSlider3D.NativeMethodInfoPtr_GetRealQuadHeight_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, 100665305);
			GizmoPlaneSlider3D.NativeMethodInfoPtr_GetRealQuadSize_Public_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, 100665306);
			GizmoPlaneSlider3D.NativeMethodInfoPtr_GetRealCircleRadius_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, 100665307);
			GizmoPlaneSlider3D.NativeMethodInfoPtr_GetRealRATriXLength_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, 100665308);
			GizmoPlaneSlider3D.NativeMethodInfoPtr_GetRealRATriYLength_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, 100665309);
			GizmoPlaneSlider3D.NativeMethodInfoPtr_GetRealRATriSize_Public_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, 100665310);
			GizmoPlaneSlider3D.NativeMethodInfoPtr_AlignToQuadrant_Public_Void_GizmoTransform_PlaneId_PlaneQuadrantId_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, 100665311);
			GizmoPlaneSlider3D.NativeMethodInfoPtr_MakeSliderPlane_Public_Void_GizmoTransform_PlaneId_GizmoLineSlider3D_GizmoLineSlider3D_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, 100665312);
			GizmoPlaneSlider3D.NativeMethodInfoPtr_GetQuadCornerPosition_Public_Vector3_QuadCorner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, 100665313);
			GizmoPlaneSlider3D.NativeMethodInfoPtr_SetQuadCornerPosition_Public_Void_QuadCorner_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, 100665314);
			GizmoPlaneSlider3D.NativeMethodInfoPtr_ApplyZoomFactor_Public_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, 100665315);
			GizmoPlaneSlider3D.NativeMethodInfoPtr_SetDragChannel_Public_Void_GizmoDragChannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, 100665316);
			GizmoPlaneSlider3D.NativeMethodInfoPtr_AddTargetTransform_Public_Void_GizmoTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, 100665317);
			GizmoPlaneSlider3D.NativeMethodInfoPtr_AddTargetTransform_Public_Void_GizmoTransform_GizmoDragChannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, 100665318);
			GizmoPlaneSlider3D.NativeMethodInfoPtr_RemoveTargetTransform_Public_Void_GizmoTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, 100665319);
			GizmoPlaneSlider3D.NativeMethodInfoPtr_RemoveTargetTransform_Public_Void_GizmoTransform_GizmoDragChannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, 100665320);
			GizmoPlaneSlider3D.NativeMethodInfoPtr_Render_Public_Virtual_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, 100665321);
			GizmoPlaneSlider3D.NativeMethodInfoPtr_Refresh_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, 100665322);
			GizmoPlaneSlider3D.NativeMethodInfoPtr_OnVisibilityStateChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, 100665323);
			GizmoPlaneSlider3D.NativeMethodInfoPtr_OnHoverableStateChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, 100665324);
			GizmoPlaneSlider3D.NativeMethodInfoPtr_OnGizmoPreUpdateBegin_Private_Void_Gizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, 100665325);
			GizmoPlaneSlider3D.NativeMethodInfoPtr_OnTransformChanged_Private_Void_GizmoTransform_ChangeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, 100665326);
			GizmoPlaneSlider3D.NativeMethodInfoPtr_OnGizmoAttemptHandleDragBegin_Private_Void_Gizmo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, 100665327);
			GizmoPlaneSlider3D.NativeMethodInfoPtr_OnCanHoverHandle_Private_Void_Int32_Gizmo_GizmoHandleHoverData_YesNoAnswer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, 100665328);
			GizmoPlaneSlider3D.NativeMethodInfoPtr_OnGizmoPostEnabled_Private_Void_Gizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr, 100665329);
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06000D7D RID: 3453 RVA: 0x000557BC File Offset: 0x000539BC
		public unsafe GizmoPlaneSlider3DSettings Settings
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 67364, RefRangeEnd = 67370, XrefRangeStart = 67364, XrefRangeEnd = 67364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3D.NativeMethodInfoPtr_get_Settings_Public_get_GizmoPlaneSlider3DSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoPlaneSlider3DSettings>(intPtr3) : null;
			}
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06000D7E RID: 3454 RVA: 0x000557FC File Offset: 0x000539FC
		// (set) Token: 0x06000D7F RID: 3455 RVA: 0x0005583C File Offset: 0x00053A3C
		public unsafe GizmoPlaneSlider3DSettings SharedSettings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3D.NativeMethodInfoPtr_get_SharedSettings_Public_get_GizmoPlaneSlider3DSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoPlaneSlider3DSettings>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3D.NativeMethodInfoPtr_set_SharedSettings_Public_set_Void_GizmoPlaneSlider3DSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06000D80 RID: 3456 RVA: 0x00055880 File Offset: 0x00053A80
		public unsafe GizmoPlaneSlider3DLookAndFeel LookAndFeel
		{
			[CallerCount(55)]
			[CachedScanResults(RefRangeStart = 67370, RefRangeEnd = 67425, XrefRangeStart = 67370, XrefRangeEnd = 67370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3D.NativeMethodInfoPtr_get_LookAndFeel_Public_get_GizmoPlaneSlider3DLookAndFeel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoPlaneSlider3DLookAndFeel>(intPtr3) : null;
			}
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06000D81 RID: 3457 RVA: 0x000558C0 File Offset: 0x00053AC0
		// (set) Token: 0x06000D82 RID: 3458 RVA: 0x00055900 File Offset: 0x00053B00
		public unsafe GizmoPlaneSlider3DLookAndFeel SharedLookAndFeel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3D.NativeMethodInfoPtr_get_SharedLookAndFeel_Public_get_GizmoPlaneSlider3DLookAndFeel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoPlaneSlider3DLookAndFeel>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3D.NativeMethodInfoPtr_set_SharedLookAndFeel_Public_set_Void_GizmoPlaneSlider3DLookAndFeel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x06000D83 RID: 3459 RVA: 0x00055944 File Offset: 0x00053B44
		public unsafe Plane Plane
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67425, XrefRangeEnd = 67428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3D.NativeMethodInfoPtr_get_Plane_Public_get_Plane_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Plane>(intPtr3) : null;
			}
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x06000D84 RID: 3460 RVA: 0x00055984 File Offset: 0x00053B84
		// (set) Token: 0x06000D85 RID: 3461 RVA: 0x000559C4 File Offset: 0x00053BC4
		public unsafe Vector3 Position
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3D.NativeMethodInfoPtr_get_Position_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67428, XrefRangeEnd = 67429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3D.NativeMethodInfoPtr_set_Position_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06000D86 RID: 3462 RVA: 0x00055A08 File Offset: 0x00053C08
		// (set) Token: 0x06000D87 RID: 3463 RVA: 0x00055A48 File Offset: 0x00053C48
		public unsafe Quaternion Rotation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3D.NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67429, XrefRangeEnd = 67430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3D.NativeMethodInfoPtr_set_Rotation_Public_set_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x06000D88 RID: 3464 RVA: 0x00055A8C File Offset: 0x00053C8C
		// (set) Token: 0x06000D89 RID: 3465 RVA: 0x00055ACC File Offset: 0x00053CCC
		public unsafe Quaternion LocalRotation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3D.NativeMethodInfoPtr_get_LocalRotation_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr3) : null;
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 67431, RefRangeEnd = 67435, XrefRangeStart = 67430, XrefRangeEnd = 67431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3D.NativeMethodInfoPtr_set_LocalRotation_Public_set_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x06000D8A RID: 3466 RVA: 0x00055B10 File Offset: 0x00053D10
		public unsafe Vector3 Right
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67435, XrefRangeEnd = 67436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3D.NativeMethodInfoPtr_get_Right_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06000D8B RID: 3467 RVA: 0x00055B50 File Offset: 0x00053D50
		public unsafe Vector3 Up
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67436, XrefRangeEnd = 67437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3D.NativeMethodInfoPtr_get_Up_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06000D8C RID: 3468 RVA: 0x00055B90 File Offset: 0x00053D90
		public unsafe Vector3 Look
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67437, XrefRangeEnd = 67438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3D.NativeMethodInfoPtr_get_Look_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06000D8D RID: 3469 RVA: 0x00055BD0 File Offset: 0x00053DD0
		public unsafe Vector3 Normal
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3D.NativeMethodInfoPtr_get_Normal_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06000D8E RID: 3470 RVA: 0x00055C10 File Offset: 0x00053E10
		public unsafe GizmoDragChannel DragChannel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3D.NativeMethodInfoPtr_get_DragChannel_Public_get_GizmoDragChannel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoDragChannel>(intPtr3) : null;
			}
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06000D8F RID: 3471 RVA: 0x00055C50 File Offset: 0x00053E50
		// (set) Token: 0x06000D90 RID: 3472 RVA: 0x00055C8C File Offset: 0x00053E8C
		public unsafe int ScaleDragAxisIndexRight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3D.NativeMethodInfoPtr_get_ScaleDragAxisIndexRight_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 67438, RefRangeEnd = 67441, XrefRangeStart = 67438, XrefRangeEnd = 67438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3D.NativeMethodInfoPtr_set_ScaleDragAxisIndexRight_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x06000D91 RID: 3473 RVA: 0x00055CCC File Offset: 0x00053ECC
		// (set) Token: 0x06000D92 RID: 3474 RVA: 0x00055D08 File Offset: 0x00053F08
		public unsafe int ScaleDragAxisIndexUp
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3D.NativeMethodInfoPtr_get_ScaleDragAxisIndexUp_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 67441, RefRangeEnd = 67444, XrefRangeStart = 67441, XrefRangeEnd = 67441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3D.NativeMethodInfoPtr_set_ScaleDragAxisIndexUp_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x06000D93 RID: 3475 RVA: 0x00055D48 File Offset: 0x00053F48
		public unsafe Vector3 TotalDragOffset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3D.NativeMethodInfoPtr_get_TotalDragOffset_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06000D94 RID: 3476 RVA: 0x00055D88 File Offset: 0x00053F88
		public unsafe Vector3 RelativeDragOffset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3D.NativeMethodInfoPtr_get_RelativeDragOffset_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06000D95 RID: 3477 RVA: 0x00055DC8 File Offset: 0x00053FC8
		public unsafe float TotalDragRotation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3D.NativeMethodInfoPtr_get_TotalDragRotation_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06000D96 RID: 3478 RVA: 0x00055E04 File Offset: 0x00054004
		public unsafe float RelativeDragRotation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3D.NativeMethodInfoPtr_get_RelativeDragRotation_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06000D97 RID: 3479 RVA: 0x00055E40 File Offset: 0x00054040
		public unsafe float TotalDragScaleRight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3D.NativeMethodInfoPtr_get_TotalDragScaleRight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06000D98 RID: 3480 RVA: 0x00055E7C File Offset: 0x0005407C
		public unsafe float RelativeDragScaleRight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3D.NativeMethodInfoPtr_get_RelativeDragScaleRight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06000D99 RID: 3481 RVA: 0x00055EB8 File Offset: 0x000540B8
		public unsafe float TotalDragScaleUp
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3D.NativeMethodInfoPtr_get_TotalDragScaleUp_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06000D9A RID: 3482 RVA: 0x00055EF4 File Offset: 0x000540F4
		public unsafe float RelativeDragScaleUp
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3D.NativeMethodInfoPtr_get_RelativeDragScaleUp_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06000D9B RID: 3483 RVA: 0x00055F30 File Offset: 0x00054130
		public unsafe bool IsBorderVisible
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3D.NativeMethodInfoPtr_get_IsBorderVisible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06000D9C RID: 3484 RVA: 0x00055F6C File Offset: 0x0005416C
		public unsafe bool IsBorderHoverable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3D.NativeMethodInfoPtr_get_IsBorderHoverable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x06000D9D RID: 3485 RVA: 0x00055FA8 File Offset: 0x000541A8
		public unsafe bool IsDragged
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3D.NativeMethodInfoPtr_get_IsDragged_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x06000D9E RID: 3486 RVA: 0x00055FE4 File Offset: 0x000541E4
		public unsafe bool IsMoving
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3D.NativeMethodInfoPtr_get_IsMoving_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x06000D9F RID: 3487 RVA: 0x00056020 File Offset: 0x00054220
		public unsafe bool IsRotating
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67444, XrefRangeEnd = 67445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3D.NativeMethodInfoPtr_get_IsRotating_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x06000DA0 RID: 3488 RVA: 0x0005605C File Offset: 0x0005425C
		public unsafe bool IsScaling
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3D.NativeMethodInfoPtr_get_IsScaling_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DA1 RID: 3489 RVA: 0x00056098 File Offset: 0x00054298
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 67627, RefRangeEnd = 67642, XrefRangeStart = 67445, XrefRangeEnd = 67627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoPlaneSlider3D(Gizmo gizmo, int handleId)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoPlaneSlider3D>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gizmo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handleId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3D.NativeMethodInfoPtr__ctor_Public_Void_Gizmo_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DA2 RID: 3490 RVA: 0x000560F4 File Offset: 0x000542F4
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 67645, RefRangeEnd = 67662, XrefRangeStart = 67642, XrefRangeEnd = 67645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBorderVisible(bool isVisible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isVisible;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3D.NativeMethodInfoPtr_SetBorderVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DA3 RID: 3491 RVA: 0x00056134 File Offset: 0x00054334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67662, XrefRangeEnd = 67666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBorderHoverable(bool isHoverable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isHoverable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3D.NativeMethodInfoPtr_SetBorderHoverable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DA4 RID: 3492 RVA: 0x00056174 File Offset: 0x00054374
		[CallerCount(0)]
		public unsafe override void SetSnapEnabled(bool isEnabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isEnabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoPlaneSlider3D.NativeMethodInfoPtr_SetSnapEnabled_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DA5 RID: 3493 RVA: 0x000561C0 File Offset: 0x000543C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetZoomFactorTransform(GizmoTransform transform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3D.NativeMethodInfoPtr_SetZoomFactorTransform_Public_Void_GizmoTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DA6 RID: 3494 RVA: 0x00056204 File Offset: 0x00054404
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 67667, RefRangeEnd = 67684, XrefRangeStart = 67666, XrefRangeEnd = 67667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetZoomFactor(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3D.NativeMethodInfoPtr_GetZoomFactor_Public_Single_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DA7 RID: 3495 RVA: 0x00056254 File Offset: 0x00054454
		[CallerCount(0)]
		public unsafe float GetRealQuadWidth(float zoomFactor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref zoomFactor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3D.NativeMethodInfoPtr_GetRealQuadWidth_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DA8 RID: 3496 RVA: 0x000562A0 File Offset: 0x000544A0
		[CallerCount(0)]
		public unsafe float GetRealQuadHeight(float zoomFactor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref zoomFactor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3D.NativeMethodInfoPtr_GetRealQuadHeight_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DA9 RID: 3497 RVA: 0x000562EC File Offset: 0x000544EC
		[CallerCount(0)]
		public unsafe Vector2 GetRealQuadSize(float zoomFactor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref zoomFactor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3D.NativeMethodInfoPtr_GetRealQuadSize_Public_Vector2_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
		}

		// Token: 0x06000DAA RID: 3498 RVA: 0x00056338 File Offset: 0x00054538
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 67684, RefRangeEnd = 67686, XrefRangeStart = 67684, XrefRangeEnd = 67684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetRealCircleRadius(float zoomFactor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref zoomFactor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3D.NativeMethodInfoPtr_GetRealCircleRadius_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DAB RID: 3499 RVA: 0x00056384 File Offset: 0x00054584
		[CallerCount(0)]
		public unsafe float GetRealRATriXLength(float zoomFactor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref zoomFactor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3D.NativeMethodInfoPtr_GetRealRATriXLength_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DAC RID: 3500 RVA: 0x000563D0 File Offset: 0x000545D0
		[CallerCount(0)]
		public unsafe float GetRealRATriYLength(float zoomFactor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref zoomFactor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3D.NativeMethodInfoPtr_GetRealRATriYLength_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DAD RID: 3501 RVA: 0x0005641C File Offset: 0x0005461C
		[CallerCount(0)]
		public unsafe Vector2 GetRealRATriSize(float zoomFactor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref zoomFactor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3D.NativeMethodInfoPtr_GetRealRATriSize_Public_Vector2_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
		}

		// Token: 0x06000DAE RID: 3502 RVA: 0x00056468 File Offset: 0x00054668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67686, XrefRangeEnd = 67698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AlignToQuadrant(GizmoTransform transform, PlaneId planeId, PlaneQuadrantId quadrantId, bool alignXToFirstAxis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(planeId);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(quadrantId);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alignXToFirstAxis;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3D.NativeMethodInfoPtr_AlignToQuadrant_Public_Void_GizmoTransform_PlaneId_PlaneQuadrantId_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DAF RID: 3503 RVA: 0x000564DC File Offset: 0x000546DC
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 67718, RefRangeEnd = 67727, XrefRangeStart = 67698, XrefRangeEnd = 67718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MakeSliderPlane(GizmoTransform sliderPlaneTransform, PlaneId planeId, GizmoLineSlider3D firstAxisSlider, GizmoLineSlider3D secondAxisSlider, Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sliderPlaneTransform);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(planeId);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(firstAxisSlider);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(secondAxisSlider);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3D.NativeMethodInfoPtr_MakeSliderPlane_Public_Void_GizmoTransform_PlaneId_GizmoLineSlider3D_GizmoLineSlider3D_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DB0 RID: 3504 RVA: 0x00056568 File Offset: 0x00054768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67727, XrefRangeEnd = 67728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetQuadCornerPosition(QuadCorner corner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(corner);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3D.NativeMethodInfoPtr_GetQuadCornerPosition_Public_Vector3_QuadCorner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x06000DB1 RID: 3505 RVA: 0x000565B8 File Offset: 0x000547B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67728, XrefRangeEnd = 67730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetQuadCornerPosition(QuadCorner corner, Vector3 cornerPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(corner);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cornerPosition);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3D.NativeMethodInfoPtr_SetQuadCornerPosition_Public_Void_QuadCorner_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DB2 RID: 3506 RVA: 0x0005660C File Offset: 0x0005480C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67730, XrefRangeEnd = 67734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyZoomFactor(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3D.NativeMethodInfoPtr_ApplyZoomFactor_Public_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DB3 RID: 3507 RVA: 0x00056650 File Offset: 0x00054850
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 67739, RefRangeEnd = 67748, XrefRangeStart = 67734, XrefRangeEnd = 67739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDragChannel(GizmoDragChannel dragChannel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dragChannel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3D.NativeMethodInfoPtr_SetDragChannel_Public_Void_GizmoDragChannel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DB4 RID: 3508 RVA: 0x00056694 File Offset: 0x00054894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67748, XrefRangeEnd = 67752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddTargetTransform(GizmoTransform transform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3D.NativeMethodInfoPtr_AddTargetTransform_Public_Void_GizmoTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DB5 RID: 3509 RVA: 0x000566D8 File Offset: 0x000548D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67752, XrefRangeEnd = 67753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3D.NativeMethodInfoPtr_AddTargetTransform_Public_Void_GizmoTransform_GizmoDragChannel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DB6 RID: 3510 RVA: 0x0005672C File Offset: 0x0005492C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67753, XrefRangeEnd = 67757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveTargetTransform(GizmoTransform transform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3D.NativeMethodInfoPtr_RemoveTargetTransform_Public_Void_GizmoTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DB7 RID: 3511 RVA: 0x00056770 File Offset: 0x00054970
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67757, XrefRangeEnd = 67758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3D.NativeMethodInfoPtr_RemoveTargetTransform_Public_Void_GizmoTransform_GizmoDragChannel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DB8 RID: 3512 RVA: 0x000567C4 File Offset: 0x000549C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67758, XrefRangeEnd = 67784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Render(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoPlaneSlider3D.NativeMethodInfoPtr_Render_Public_Virtual_Void_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DB9 RID: 3513 RVA: 0x00056814 File Offset: 0x00054A14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 67796, RefRangeEnd = 67797, XrefRangeStart = 67784, XrefRangeEnd = 67796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Refresh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3D.NativeMethodInfoPtr_Refresh_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DBA RID: 3514 RVA: 0x00056848 File Offset: 0x00054A48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67797, XrefRangeEnd = 67809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnVisibilityStateChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoPlaneSlider3D.NativeMethodInfoPtr_OnVisibilityStateChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DBB RID: 3515 RVA: 0x00056884 File Offset: 0x00054A84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67809, XrefRangeEnd = 67813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnHoverableStateChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoPlaneSlider3D.NativeMethodInfoPtr_OnHoverableStateChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DBC RID: 3516 RVA: 0x000568C0 File Offset: 0x00054AC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67813, XrefRangeEnd = 67828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGizmoPreUpdateBegin(Gizmo gizmo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gizmo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3D.NativeMethodInfoPtr_OnGizmoPreUpdateBegin_Private_Void_Gizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DBD RID: 3517 RVA: 0x00056904 File Offset: 0x00054B04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67828, XrefRangeEnd = 67834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3D.NativeMethodInfoPtr_OnTransformChanged_Private_Void_GizmoTransform_ChangeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DBE RID: 3518 RVA: 0x00056954 File Offset: 0x00054B54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67834, XrefRangeEnd = 67838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3D.NativeMethodInfoPtr_OnGizmoAttemptHandleDragBegin_Private_Void_Gizmo_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DBF RID: 3519 RVA: 0x000569A4 File Offset: 0x00054BA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67838, XrefRangeEnd = 67849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCanHoverHandle(int handleId, Gizmo gizmo, GizmoHandleHoverData hoverData, YesNoAnswer answer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handleId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(gizmo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(hoverData);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(answer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3D.NativeMethodInfoPtr_OnCanHoverHandle_Private_Void_Int32_Gizmo_GizmoHandleHoverData_YesNoAnswer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DC0 RID: 3520 RVA: 0x00056A1C File Offset: 0x00054C1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67849, XrefRangeEnd = 67850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGizmoPostEnabled(Gizmo gizmo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gizmo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoPlaneSlider3D.NativeMethodInfoPtr_OnGizmoPostEnabled_Private_Void_Gizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DC1 RID: 3521 RVA: 0x00006DEE File Offset: 0x00004FEE
		public GizmoPlaneSlider3D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06000DC2 RID: 3522 RVA: 0x00056A60 File Offset: 0x00054C60
		// (set) Token: 0x06000DC3 RID: 3523 RVA: 0x00006DF7 File Offset: 0x00004FF7
		public unsafe int _quadIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3D.NativeFieldInfoPtr__quadIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3D.NativeFieldInfoPtr__quadIndex)) = value;
			}
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06000DC4 RID: 3524 RVA: 0x00056A88 File Offset: 0x00054C88
		// (set) Token: 0x06000DC5 RID: 3525 RVA: 0x00006E12 File Offset: 0x00005012
		public unsafe int _raTriangleIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3D.NativeFieldInfoPtr__raTriangleIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3D.NativeFieldInfoPtr__raTriangleIndex)) = value;
			}
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x06000DC6 RID: 3526 RVA: 0x00056AB0 File Offset: 0x00054CB0
		// (set) Token: 0x06000DC7 RID: 3527 RVA: 0x00006E2D File Offset: 0x0000502D
		public unsafe int _circleIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3D.NativeFieldInfoPtr__circleIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3D.NativeFieldInfoPtr__circleIndex)) = value;
			}
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x06000DC8 RID: 3528 RVA: 0x00056AD8 File Offset: 0x00054CD8
		// (set) Token: 0x06000DC9 RID: 3529 RVA: 0x00006E48 File Offset: 0x00005048
		public unsafe QuadShape3D _quad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3D.NativeFieldInfoPtr__quad);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuadShape3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3D.NativeFieldInfoPtr__quad), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x06000DCA RID: 3530 RVA: 0x00056B08 File Offset: 0x00054D08
		// (set) Token: 0x06000DCB RID: 3531 RVA: 0x00006E67 File Offset: 0x00005067
		public unsafe RightAngTriangle3D _raTriangle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3D.NativeFieldInfoPtr__raTriangle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RightAngTriangle3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3D.NativeFieldInfoPtr__raTriangle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x06000DCC RID: 3532 RVA: 0x00056B38 File Offset: 0x00054D38
		// (set) Token: 0x06000DCD RID: 3533 RVA: 0x00006E86 File Offset: 0x00005086
		public unsafe CircleShape3D _circle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3D.NativeFieldInfoPtr__circle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CircleShape3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3D.NativeFieldInfoPtr__circle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06000DCE RID: 3534 RVA: 0x00056B68 File Offset: 0x00054D68
		// (set) Token: 0x06000DCF RID: 3535 RVA: 0x00006EA5 File Offset: 0x000050A5
		public unsafe GizmoQuad3DBorder _quadBorder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3D.NativeFieldInfoPtr__quadBorder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoQuad3DBorder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3D.NativeFieldInfoPtr__quadBorder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06000DD0 RID: 3536 RVA: 0x00056B98 File Offset: 0x00054D98
		// (set) Token: 0x06000DD1 RID: 3537 RVA: 0x00006EC4 File Offset: 0x000050C4
		public unsafe GizmoRATriangle3DBorder _raTriangleBorder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3D.NativeFieldInfoPtr__raTriangleBorder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoRATriangle3DBorder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3D.NativeFieldInfoPtr__raTriangleBorder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06000DD2 RID: 3538 RVA: 0x00056BC8 File Offset: 0x00054DC8
		// (set) Token: 0x06000DD3 RID: 3539 RVA: 0x00006EE3 File Offset: 0x000050E3
		public unsafe GizmoCircle3DBorder _circleBorder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3D.NativeFieldInfoPtr__circleBorder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoCircle3DBorder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3D.NativeFieldInfoPtr__circleBorder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06000DD4 RID: 3540 RVA: 0x00056BF8 File Offset: 0x00054DF8
		// (set) Token: 0x06000DD5 RID: 3541 RVA: 0x00006F02 File Offset: 0x00005102
		public unsafe bool _isBorderHoverable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3D.NativeFieldInfoPtr__isBorderHoverable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3D.NativeFieldInfoPtr__isBorderHoverable)) = value;
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06000DD6 RID: 3542 RVA: 0x00056C20 File Offset: 0x00054E20
		// (set) Token: 0x06000DD7 RID: 3543 RVA: 0x00006F1D File Offset: 0x0000511D
		public unsafe bool _isBorderVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3D.NativeFieldInfoPtr__isBorderVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3D.NativeFieldInfoPtr__isBorderVisible)) = value;
			}
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06000DD8 RID: 3544 RVA: 0x00056C48 File Offset: 0x00054E48
		// (set) Token: 0x06000DD9 RID: 3545 RVA: 0x00006F38 File Offset: 0x00005138
		public unsafe GizmoTransform _transform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3D.NativeFieldInfoPtr__transform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3D.NativeFieldInfoPtr__transform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06000DDA RID: 3546 RVA: 0x00056C78 File Offset: 0x00054E78
		// (set) Token: 0x06000DDB RID: 3547 RVA: 0x00006F57 File Offset: 0x00005157
		public unsafe GizmoDragChannel _dragChannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3D.NativeFieldInfoPtr__dragChannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoDragChannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3D.NativeFieldInfoPtr__dragChannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06000DDC RID: 3548 RVA: 0x00056CA8 File Offset: 0x00054EA8
		// (set) Token: 0x06000DDD RID: 3549 RVA: 0x00006F76 File Offset: 0x00005176
		public unsafe IGizmoDragSession _selectedDragSession
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3D.NativeFieldInfoPtr__selectedDragSession);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGizmoDragSession>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3D.NativeFieldInfoPtr__selectedDragSession), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06000DDE RID: 3550 RVA: 0x00056CD8 File Offset: 0x00054ED8
		// (set) Token: 0x06000DDF RID: 3551 RVA: 0x00006F95 File Offset: 0x00005195
		public unsafe GizmoDblAxisOffsetDrag3D _dblAxisOffsetDrag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3D.NativeFieldInfoPtr__dblAxisOffsetDrag);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoDblAxisOffsetDrag3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3D.NativeFieldInfoPtr__dblAxisOffsetDrag), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06000DE0 RID: 3552 RVA: 0x00056D08 File Offset: 0x00054F08
		// (set) Token: 0x06000DE1 RID: 3553 RVA: 0x00006FB4 File Offset: 0x000051B4
		public unsafe GizmoSglAxisRotationDrag3D _rotationDrag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3D.NativeFieldInfoPtr__rotationDrag);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoSglAxisRotationDrag3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3D.NativeFieldInfoPtr__rotationDrag), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06000DE2 RID: 3554 RVA: 0x00056D38 File Offset: 0x00054F38
		// (set) Token: 0x06000DE3 RID: 3555 RVA: 0x00006FD3 File Offset: 0x000051D3
		public unsafe GizmoRotationArc3D _rotationArc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3D.NativeFieldInfoPtr__rotationArc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoRotationArc3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3D.NativeFieldInfoPtr__rotationArc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06000DE4 RID: 3556 RVA: 0x00056D68 File Offset: 0x00054F68
		// (set) Token: 0x06000DE5 RID: 3557 RVA: 0x00006FF2 File Offset: 0x000051F2
		public unsafe GizmoDblAxisScaleDrag3D _scaleDrag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3D.NativeFieldInfoPtr__scaleDrag);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoDblAxisScaleDrag3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3D.NativeFieldInfoPtr__scaleDrag), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06000DE6 RID: 3558 RVA: 0x00056D98 File Offset: 0x00054F98
		// (set) Token: 0x06000DE7 RID: 3559 RVA: 0x00007011 File Offset: 0x00005211
		public unsafe int _scaleDragAxisIndexRight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3D.NativeFieldInfoPtr__scaleDragAxisIndexRight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3D.NativeFieldInfoPtr__scaleDragAxisIndexRight)) = value;
			}
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06000DE8 RID: 3560 RVA: 0x00056DC0 File Offset: 0x00054FC0
		// (set) Token: 0x06000DE9 RID: 3561 RVA: 0x0000702C File Offset: 0x0000522C
		public unsafe int _scaleDragAxisIndexUp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3D.NativeFieldInfoPtr__scaleDragAxisIndexUp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3D.NativeFieldInfoPtr__scaleDragAxisIndexUp)) = value;
			}
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06000DEA RID: 3562 RVA: 0x00056DE8 File Offset: 0x00054FE8
		// (set) Token: 0x06000DEB RID: 3563 RVA: 0x00007047 File Offset: 0x00005247
		public unsafe GizmoPlaneSlider3DControllerData _controllerData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3D.NativeFieldInfoPtr__controllerData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPlaneSlider3DControllerData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3D.NativeFieldInfoPtr__controllerData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06000DEC RID: 3564 RVA: 0x00056E18 File Offset: 0x00055018
		// (set) Token: 0x06000DED RID: 3565 RVA: 0x00007066 File Offset: 0x00005266
		public unsafe Il2CppReferenceArray<IGizmoPlaneSlider3DController> _controllers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3D.NativeFieldInfoPtr__controllers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IGizmoPlaneSlider3DController>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3D.NativeFieldInfoPtr__controllers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06000DEE RID: 3566 RVA: 0x00056E48 File Offset: 0x00055048
		// (set) Token: 0x06000DEF RID: 3567 RVA: 0x00007085 File Offset: 0x00005285
		public unsafe GizmoPlaneSlider3DSettings _settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3D.NativeFieldInfoPtr__settings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPlaneSlider3DSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3D.NativeFieldInfoPtr__settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06000DF0 RID: 3568 RVA: 0x00056E78 File Offset: 0x00055078
		// (set) Token: 0x06000DF1 RID: 3569 RVA: 0x000070A4 File Offset: 0x000052A4
		public unsafe GizmoPlaneSlider3DSettings _sharedSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3D.NativeFieldInfoPtr__sharedSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPlaneSlider3DSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3D.NativeFieldInfoPtr__sharedSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06000DF2 RID: 3570 RVA: 0x00056EA8 File Offset: 0x000550A8
		// (set) Token: 0x06000DF3 RID: 3571 RVA: 0x000070C3 File Offset: 0x000052C3
		public unsafe GizmoPlaneSlider3DLookAndFeel _lookAndFeel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3D.NativeFieldInfoPtr__lookAndFeel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPlaneSlider3DLookAndFeel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3D.NativeFieldInfoPtr__lookAndFeel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06000DF4 RID: 3572 RVA: 0x00056ED8 File Offset: 0x000550D8
		// (set) Token: 0x06000DF5 RID: 3573 RVA: 0x000070E2 File Offset: 0x000052E2
		public unsafe GizmoPlaneSlider3DLookAndFeel _sharedLookAndFeel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3D.NativeFieldInfoPtr__sharedLookAndFeel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPlaneSlider3DLookAndFeel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoPlaneSlider3D.NativeFieldInfoPtr__sharedLookAndFeel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A32 RID: 2610
		private static readonly IntPtr NativeFieldInfoPtr__quadIndex;

		// Token: 0x04000A33 RID: 2611
		private static readonly IntPtr NativeFieldInfoPtr__raTriangleIndex;

		// Token: 0x04000A34 RID: 2612
		private static readonly IntPtr NativeFieldInfoPtr__circleIndex;

		// Token: 0x04000A35 RID: 2613
		private static readonly IntPtr NativeFieldInfoPtr__quad;

		// Token: 0x04000A36 RID: 2614
		private static readonly IntPtr NativeFieldInfoPtr__raTriangle;

		// Token: 0x04000A37 RID: 2615
		private static readonly IntPtr NativeFieldInfoPtr__circle;

		// Token: 0x04000A38 RID: 2616
		private static readonly IntPtr NativeFieldInfoPtr__quadBorder;

		// Token: 0x04000A39 RID: 2617
		private static readonly IntPtr NativeFieldInfoPtr__raTriangleBorder;

		// Token: 0x04000A3A RID: 2618
		private static readonly IntPtr NativeFieldInfoPtr__circleBorder;

		// Token: 0x04000A3B RID: 2619
		private static readonly IntPtr NativeFieldInfoPtr__isBorderHoverable;

		// Token: 0x04000A3C RID: 2620
		private static readonly IntPtr NativeFieldInfoPtr__isBorderVisible;

		// Token: 0x04000A3D RID: 2621
		private static readonly IntPtr NativeFieldInfoPtr__transform;

		// Token: 0x04000A3E RID: 2622
		private static readonly IntPtr NativeFieldInfoPtr__dragChannel;

		// Token: 0x04000A3F RID: 2623
		private static readonly IntPtr NativeFieldInfoPtr__selectedDragSession;

		// Token: 0x04000A40 RID: 2624
		private static readonly IntPtr NativeFieldInfoPtr__dblAxisOffsetDrag;

		// Token: 0x04000A41 RID: 2625
		private static readonly IntPtr NativeFieldInfoPtr__rotationDrag;

		// Token: 0x04000A42 RID: 2626
		private static readonly IntPtr NativeFieldInfoPtr__rotationArc;

		// Token: 0x04000A43 RID: 2627
		private static readonly IntPtr NativeFieldInfoPtr__scaleDrag;

		// Token: 0x04000A44 RID: 2628
		private static readonly IntPtr NativeFieldInfoPtr__scaleDragAxisIndexRight;

		// Token: 0x04000A45 RID: 2629
		private static readonly IntPtr NativeFieldInfoPtr__scaleDragAxisIndexUp;

		// Token: 0x04000A46 RID: 2630
		private static readonly IntPtr NativeFieldInfoPtr__controllerData;

		// Token: 0x04000A47 RID: 2631
		private static readonly IntPtr NativeFieldInfoPtr__controllers;

		// Token: 0x04000A48 RID: 2632
		private static readonly IntPtr NativeFieldInfoPtr__settings;

		// Token: 0x04000A49 RID: 2633
		private static readonly IntPtr NativeFieldInfoPtr__sharedSettings;

		// Token: 0x04000A4A RID: 2634
		private static readonly IntPtr NativeFieldInfoPtr__lookAndFeel;

		// Token: 0x04000A4B RID: 2635
		private static readonly IntPtr NativeFieldInfoPtr__sharedLookAndFeel;

		// Token: 0x04000A4C RID: 2636
		private static readonly IntPtr NativeMethodInfoPtr_get_Settings_Public_get_GizmoPlaneSlider3DSettings_0;

		// Token: 0x04000A4D RID: 2637
		private static readonly IntPtr NativeMethodInfoPtr_get_SharedSettings_Public_get_GizmoPlaneSlider3DSettings_0;

		// Token: 0x04000A4E RID: 2638
		private static readonly IntPtr NativeMethodInfoPtr_set_SharedSettings_Public_set_Void_GizmoPlaneSlider3DSettings_0;

		// Token: 0x04000A4F RID: 2639
		private static readonly IntPtr NativeMethodInfoPtr_get_LookAndFeel_Public_get_GizmoPlaneSlider3DLookAndFeel_0;

		// Token: 0x04000A50 RID: 2640
		private static readonly IntPtr NativeMethodInfoPtr_get_SharedLookAndFeel_Public_get_GizmoPlaneSlider3DLookAndFeel_0;

		// Token: 0x04000A51 RID: 2641
		private static readonly IntPtr NativeMethodInfoPtr_set_SharedLookAndFeel_Public_set_Void_GizmoPlaneSlider3DLookAndFeel_0;

		// Token: 0x04000A52 RID: 2642
		private static readonly IntPtr NativeMethodInfoPtr_get_Plane_Public_get_Plane_0;

		// Token: 0x04000A53 RID: 2643
		private static readonly IntPtr NativeMethodInfoPtr_get_Position_Public_get_Vector3_0;

		// Token: 0x04000A54 RID: 2644
		private static readonly IntPtr NativeMethodInfoPtr_set_Position_Public_set_Void_Vector3_0;

		// Token: 0x04000A55 RID: 2645
		private static readonly IntPtr NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0;

		// Token: 0x04000A56 RID: 2646
		private static readonly IntPtr NativeMethodInfoPtr_set_Rotation_Public_set_Void_Quaternion_0;

		// Token: 0x04000A57 RID: 2647
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalRotation_Public_get_Quaternion_0;

		// Token: 0x04000A58 RID: 2648
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalRotation_Public_set_Void_Quaternion_0;

		// Token: 0x04000A59 RID: 2649
		private static readonly IntPtr NativeMethodInfoPtr_get_Right_Public_get_Vector3_0;

		// Token: 0x04000A5A RID: 2650
		private static readonly IntPtr NativeMethodInfoPtr_get_Up_Public_get_Vector3_0;

		// Token: 0x04000A5B RID: 2651
		private static readonly IntPtr NativeMethodInfoPtr_get_Look_Public_get_Vector3_0;

		// Token: 0x04000A5C RID: 2652
		private static readonly IntPtr NativeMethodInfoPtr_get_Normal_Public_get_Vector3_0;

		// Token: 0x04000A5D RID: 2653
		private static readonly IntPtr NativeMethodInfoPtr_get_DragChannel_Public_get_GizmoDragChannel_0;

		// Token: 0x04000A5E RID: 2654
		private static readonly IntPtr NativeMethodInfoPtr_get_ScaleDragAxisIndexRight_Public_get_Int32_0;

		// Token: 0x04000A5F RID: 2655
		private static readonly IntPtr NativeMethodInfoPtr_set_ScaleDragAxisIndexRight_Public_set_Void_Int32_0;

		// Token: 0x04000A60 RID: 2656
		private static readonly IntPtr NativeMethodInfoPtr_get_ScaleDragAxisIndexUp_Public_get_Int32_0;

		// Token: 0x04000A61 RID: 2657
		private static readonly IntPtr NativeMethodInfoPtr_set_ScaleDragAxisIndexUp_Public_set_Void_Int32_0;

		// Token: 0x04000A62 RID: 2658
		private static readonly IntPtr NativeMethodInfoPtr_get_TotalDragOffset_Public_get_Vector3_0;

		// Token: 0x04000A63 RID: 2659
		private static readonly IntPtr NativeMethodInfoPtr_get_RelativeDragOffset_Public_get_Vector3_0;

		// Token: 0x04000A64 RID: 2660
		private static readonly IntPtr NativeMethodInfoPtr_get_TotalDragRotation_Public_get_Single_0;

		// Token: 0x04000A65 RID: 2661
		private static readonly IntPtr NativeMethodInfoPtr_get_RelativeDragRotation_Public_get_Single_0;

		// Token: 0x04000A66 RID: 2662
		private static readonly IntPtr NativeMethodInfoPtr_get_TotalDragScaleRight_Public_get_Single_0;

		// Token: 0x04000A67 RID: 2663
		private static readonly IntPtr NativeMethodInfoPtr_get_RelativeDragScaleRight_Public_get_Single_0;

		// Token: 0x04000A68 RID: 2664
		private static readonly IntPtr NativeMethodInfoPtr_get_TotalDragScaleUp_Public_get_Single_0;

		// Token: 0x04000A69 RID: 2665
		private static readonly IntPtr NativeMethodInfoPtr_get_RelativeDragScaleUp_Public_get_Single_0;

		// Token: 0x04000A6A RID: 2666
		private static readonly IntPtr NativeMethodInfoPtr_get_IsBorderVisible_Public_get_Boolean_0;

		// Token: 0x04000A6B RID: 2667
		private static readonly IntPtr NativeMethodInfoPtr_get_IsBorderHoverable_Public_get_Boolean_0;

		// Token: 0x04000A6C RID: 2668
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDragged_Public_get_Boolean_0;

		// Token: 0x04000A6D RID: 2669
		private static readonly IntPtr NativeMethodInfoPtr_get_IsMoving_Public_get_Boolean_0;

		// Token: 0x04000A6E RID: 2670
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRotating_Public_get_Boolean_0;

		// Token: 0x04000A6F RID: 2671
		private static readonly IntPtr NativeMethodInfoPtr_get_IsScaling_Public_get_Boolean_0;

		// Token: 0x04000A70 RID: 2672
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Gizmo_Int32_0;

		// Token: 0x04000A71 RID: 2673
		private static readonly IntPtr NativeMethodInfoPtr_SetBorderVisible_Public_Void_Boolean_0;

		// Token: 0x04000A72 RID: 2674
		private static readonly IntPtr NativeMethodInfoPtr_SetBorderHoverable_Public_Void_Boolean_0;

		// Token: 0x04000A73 RID: 2675
		private static readonly IntPtr NativeMethodInfoPtr_SetSnapEnabled_Public_Virtual_Void_Boolean_0;

		// Token: 0x04000A74 RID: 2676
		private static readonly IntPtr NativeMethodInfoPtr_SetZoomFactorTransform_Public_Void_GizmoTransform_0;

		// Token: 0x04000A75 RID: 2677
		private static readonly IntPtr NativeMethodInfoPtr_GetZoomFactor_Public_Single_Camera_0;

		// Token: 0x04000A76 RID: 2678
		private static readonly IntPtr NativeMethodInfoPtr_GetRealQuadWidth_Public_Single_Single_0;

		// Token: 0x04000A77 RID: 2679
		private static readonly IntPtr NativeMethodInfoPtr_GetRealQuadHeight_Public_Single_Single_0;

		// Token: 0x04000A78 RID: 2680
		private static readonly IntPtr NativeMethodInfoPtr_GetRealQuadSize_Public_Vector2_Single_0;

		// Token: 0x04000A79 RID: 2681
		private static readonly IntPtr NativeMethodInfoPtr_GetRealCircleRadius_Public_Single_Single_0;

		// Token: 0x04000A7A RID: 2682
		private static readonly IntPtr NativeMethodInfoPtr_GetRealRATriXLength_Public_Single_Single_0;

		// Token: 0x04000A7B RID: 2683
		private static readonly IntPtr NativeMethodInfoPtr_GetRealRATriYLength_Public_Single_Single_0;

		// Token: 0x04000A7C RID: 2684
		private static readonly IntPtr NativeMethodInfoPtr_GetRealRATriSize_Public_Vector2_Single_0;

		// Token: 0x04000A7D RID: 2685
		private static readonly IntPtr NativeMethodInfoPtr_AlignToQuadrant_Public_Void_GizmoTransform_PlaneId_PlaneQuadrantId_Boolean_0;

		// Token: 0x04000A7E RID: 2686
		private static readonly IntPtr NativeMethodInfoPtr_MakeSliderPlane_Public_Void_GizmoTransform_PlaneId_GizmoLineSlider3D_GizmoLineSlider3D_Camera_0;

		// Token: 0x04000A7F RID: 2687
		private static readonly IntPtr NativeMethodInfoPtr_GetQuadCornerPosition_Public_Vector3_QuadCorner_0;

		// Token: 0x04000A80 RID: 2688
		private static readonly IntPtr NativeMethodInfoPtr_SetQuadCornerPosition_Public_Void_QuadCorner_Vector3_0;

		// Token: 0x04000A81 RID: 2689
		private static readonly IntPtr NativeMethodInfoPtr_ApplyZoomFactor_Public_Void_Camera_0;

		// Token: 0x04000A82 RID: 2690
		private static readonly IntPtr NativeMethodInfoPtr_SetDragChannel_Public_Void_GizmoDragChannel_0;

		// Token: 0x04000A83 RID: 2691
		private static readonly IntPtr NativeMethodInfoPtr_AddTargetTransform_Public_Void_GizmoTransform_0;

		// Token: 0x04000A84 RID: 2692
		private static readonly IntPtr NativeMethodInfoPtr_AddTargetTransform_Public_Void_GizmoTransform_GizmoDragChannel_0;

		// Token: 0x04000A85 RID: 2693
		private static readonly IntPtr NativeMethodInfoPtr_RemoveTargetTransform_Public_Void_GizmoTransform_0;

		// Token: 0x04000A86 RID: 2694
		private static readonly IntPtr NativeMethodInfoPtr_RemoveTargetTransform_Public_Void_GizmoTransform_GizmoDragChannel_0;

		// Token: 0x04000A87 RID: 2695
		private static readonly IntPtr NativeMethodInfoPtr_Render_Public_Virtual_Void_Camera_0;

		// Token: 0x04000A88 RID: 2696
		private static readonly IntPtr NativeMethodInfoPtr_Refresh_Public_Void_0;

		// Token: 0x04000A89 RID: 2697
		private static readonly IntPtr NativeMethodInfoPtr_OnVisibilityStateChanged_Protected_Virtual_Void_0;

		// Token: 0x04000A8A RID: 2698
		private static readonly IntPtr NativeMethodInfoPtr_OnHoverableStateChanged_Protected_Virtual_Void_0;

		// Token: 0x04000A8B RID: 2699
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoPreUpdateBegin_Private_Void_Gizmo_0;

		// Token: 0x04000A8C RID: 2700
		private static readonly IntPtr NativeMethodInfoPtr_OnTransformChanged_Private_Void_GizmoTransform_ChangeData_0;

		// Token: 0x04000A8D RID: 2701
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoAttemptHandleDragBegin_Private_Void_Gizmo_Int32_0;

		// Token: 0x04000A8E RID: 2702
		private static readonly IntPtr NativeMethodInfoPtr_OnCanHoverHandle_Private_Void_Int32_Gizmo_GizmoHandleHoverData_YesNoAnswer_0;

		// Token: 0x04000A8F RID: 2703
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoPostEnabled_Private_Void_Gizmo_0;
	}
}
