using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000085 RID: 133
	public class GizmoLineSlider2D : GizmoSlider
	{
		// Token: 0x06000A13 RID: 2579 RVA: 0x00048614 File Offset: 0x00046814
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoLineSlider2D()
		{
			Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoLineSlider2D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr);
			GizmoLineSlider2D.NativeFieldInfoPtr__segment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, "_segment");
			GizmoLineSlider2D.NativeFieldInfoPtr__quad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, "_quad");
			GizmoLineSlider2D.NativeFieldInfoPtr__segmentIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, "_segmentIndex");
			GizmoLineSlider2D.NativeFieldInfoPtr__quadIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, "_quadIndex");
			GizmoLineSlider2D.NativeFieldInfoPtr__dragChannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, "_dragChannel");
			GizmoLineSlider2D.NativeFieldInfoPtr__offsetDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, "_offsetDrag");
			GizmoLineSlider2D.NativeFieldInfoPtr__offsetDragOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, "_offsetDragOrigin");
			GizmoLineSlider2D.NativeFieldInfoPtr__rotationDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, "_rotationDrag");
			GizmoLineSlider2D.NativeFieldInfoPtr__rotationArc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, "_rotationArc");
			GizmoLineSlider2D.NativeFieldInfoPtr__scaleDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, "_scaleDrag");
			GizmoLineSlider2D.NativeFieldInfoPtr__scaleDragOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, "_scaleDragOrigin");
			GizmoLineSlider2D.NativeFieldInfoPtr__scaleAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, "_scaleAxis");
			GizmoLineSlider2D.NativeFieldInfoPtr__scaleDragAxisIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, "_scaleDragAxisIndex");
			GizmoLineSlider2D.NativeFieldInfoPtr__selectedDragSession = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, "_selectedDragSession");
			GizmoLineSlider2D.NativeFieldInfoPtr__cap2D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, "_cap2D");
			GizmoLineSlider2D.NativeFieldInfoPtr__transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, "_transform");
			GizmoLineSlider2D.NativeFieldInfoPtr__directionAxisMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, "_directionAxisMap");
			GizmoLineSlider2D.NativeFieldInfoPtr__overrideFillColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, "_overrideFillColor");
			GizmoLineSlider2D.NativeFieldInfoPtr__overrideBorderColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, "_overrideBorderColor");
			GizmoLineSlider2D.NativeFieldInfoPtr__controllerData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, "_controllerData");
			GizmoLineSlider2D.NativeFieldInfoPtr__controllers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, "_controllers");
			GizmoLineSlider2D.NativeFieldInfoPtr__settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, "_settings");
			GizmoLineSlider2D.NativeFieldInfoPtr__sharedSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, "_sharedSettings");
			GizmoLineSlider2D.NativeFieldInfoPtr__lookAndFeel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, "_lookAndFeel");
			GizmoLineSlider2D.NativeFieldInfoPtr__sharedLookAndFeel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, "_sharedLookAndFeel");
			GizmoLineSlider2D.NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, 100664811);
			GizmoLineSlider2D.NativeMethodInfoPtr_get_RotationDegrees_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, 100664812);
			GizmoLineSlider2D.NativeMethodInfoPtr_get_StartPosition_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, 100664813);
			GizmoLineSlider2D.NativeMethodInfoPtr_set_StartPosition_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, 100664814);
			GizmoLineSlider2D.NativeMethodInfoPtr_get_Direction_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, 100664815);
			GizmoLineSlider2D.NativeMethodInfoPtr_get_OffsetDragOrigin_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, 100664816);
			GizmoLineSlider2D.NativeMethodInfoPtr_set_OffsetDragOrigin_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, 100664817);
			GizmoLineSlider2D.NativeMethodInfoPtr_get_ScaleDragOrigin_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, 100664818);
			GizmoLineSlider2D.NativeMethodInfoPtr_set_ScaleDragOrigin_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, 100664819);
			GizmoLineSlider2D.NativeMethodInfoPtr_get_ScaleDragAxisIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, 100664820);
			GizmoLineSlider2D.NativeMethodInfoPtr_set_ScaleDragAxisIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, 100664821);
			GizmoLineSlider2D.NativeMethodInfoPtr_get_Cap2DHandleId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, 100664822);
			GizmoLineSlider2D.NativeMethodInfoPtr_get_IsDragged_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, 100664823);
			GizmoLineSlider2D.NativeMethodInfoPtr_get_IsMoving_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, 100664824);
			GizmoLineSlider2D.NativeMethodInfoPtr_get_IsRotating_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, 100664825);
			GizmoLineSlider2D.NativeMethodInfoPtr_get_IsScaling_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, 100664826);
			GizmoLineSlider2D.NativeMethodInfoPtr_get_Is2DCapVisible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, 100664827);
			GizmoLineSlider2D.NativeMethodInfoPtr_get_Is2DCapHoverable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, 100664828);
			GizmoLineSlider2D.NativeMethodInfoPtr_get_TotalDragOffset_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, 100664829);
			GizmoLineSlider2D.NativeMethodInfoPtr_get_RelativeDragOffset_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, 100664830);
			GizmoLineSlider2D.NativeMethodInfoPtr_get_TotalDragRotation_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, 100664831);
			GizmoLineSlider2D.NativeMethodInfoPtr_get_RelativeDragRotation_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, 100664832);
			GizmoLineSlider2D.NativeMethodInfoPtr_get_TotalDragScale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, 100664833);
			GizmoLineSlider2D.NativeMethodInfoPtr_get_RelativeDragScale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, 100664834);
			GizmoLineSlider2D.NativeMethodInfoPtr_get_OverrideFillColor_Public_get_GizmoOverrideColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, 100664835);
			GizmoLineSlider2D.NativeMethodInfoPtr_get_OverrideBorderColor_Public_get_GizmoOverrideColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, 100664836);
			GizmoLineSlider2D.NativeMethodInfoPtr_get_Settings_Public_get_GizmoLineSlider2DSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, 100664837);
			GizmoLineSlider2D.NativeMethodInfoPtr_get_SharedSettings_Public_get_GizmoLineSlider2DSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, 100664838);
			GizmoLineSlider2D.NativeMethodInfoPtr_set_SharedSettings_Public_set_Void_GizmoLineSlider2DSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, 100664839);
			GizmoLineSlider2D.NativeMethodInfoPtr_get_LookAndFeel_Public_get_GizmoLineSlider2DLookAndFeel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, 100664840);
			GizmoLineSlider2D.NativeMethodInfoPtr_get_SharedLookAndFeel_Public_get_GizmoLineSlider2DLookAndFeel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, 100664841);
			GizmoLineSlider2D.NativeMethodInfoPtr_set_SharedLookAndFeel_Public_set_Void_GizmoLineSlider2DLookAndFeel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, 100664842);
			GizmoLineSlider2D.NativeMethodInfoPtr__ctor_Public_Void_Gizmo_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, 100664843);
			GizmoLineSlider2D.NativeMethodInfoPtr_SetSnapEnabled_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, 100664844);
			GizmoLineSlider2D.NativeMethodInfoPtr_Set2DCapVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, 100664845);
			GizmoLineSlider2D.NativeMethodInfoPtr_Set2DCapHoverable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, 100664846);
			GizmoLineSlider2D.NativeMethodInfoPtr_GetRealDirection_Public_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, 100664847);
			GizmoLineSlider2D.NativeMethodInfoPtr_GetRealLength_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, 100664848);
			GizmoLineSlider2D.NativeMethodInfoPtr_GetRealEndPosition_Public_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, 100664849);
			GizmoLineSlider2D.NativeMethodInfoPtr_GetRealBoxThickness_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, 100664850);
			GizmoLineSlider2D.NativeMethodInfoPtr_MapDirection_Public_Void_Int32_AxisSign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, 100664851);
			GizmoLineSlider2D.NativeMethodInfoPtr_SetDirection_Public_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, 100664852);
			GizmoLineSlider2D.NativeMethodInfoPtr_AddTargetTransform_Public_Void_GizmoTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, 100664853);
			GizmoLineSlider2D.NativeMethodInfoPtr_AddTargetTransform_Public_Void_GizmoTransform_GizmoDragChannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, 100664854);
			GizmoLineSlider2D.NativeMethodInfoPtr_RemoveTargetTransform_Public_Void_GizmoTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, 100664855);
			GizmoLineSlider2D.NativeMethodInfoPtr_RemoveTargetTransform_Public_Void_GizmoTransform_GizmoDragChannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, 100664856);
			GizmoLineSlider2D.NativeMethodInfoPtr_SetDragChannel_Public_Void_GizmoDragChannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, 100664857);
			GizmoLineSlider2D.NativeMethodInfoPtr_Render_Public_Virtual_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, 100664858);
			GizmoLineSlider2D.NativeMethodInfoPtr_Refresh_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, 100664859);
			GizmoLineSlider2D.NativeMethodInfoPtr_OnVisibilityStateChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, 100664860);
			GizmoLineSlider2D.NativeMethodInfoPtr_OnHoverableStateChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, 100664861);
			GizmoLineSlider2D.NativeMethodInfoPtr_OnGizmoPreUpdateBegin_Private_Void_Gizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, 100664862);
			GizmoLineSlider2D.NativeMethodInfoPtr_OnGizmoAttemptHandleDragBegin_Private_Void_Gizmo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, 100664863);
			GizmoLineSlider2D.NativeMethodInfoPtr_OnTransformChanged_Private_Void_GizmoTransform_ChangeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, 100664864);
			GizmoLineSlider2D.NativeMethodInfoPtr_OnGizmoHandleHoverEnter_Private_Void_Gizmo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, 100664865);
			GizmoLineSlider2D.NativeMethodInfoPtr_OnGizmoHandleHoverExit_Private_Void_Gizmo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, 100664866);
			GizmoLineSlider2D.NativeMethodInfoPtr_OnGizmoHandleDragUpdate_Private_Void_Gizmo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, 100664867);
			GizmoLineSlider2D.NativeMethodInfoPtr_SetupSharedLookAndFeel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, 100664868);
			GizmoLineSlider2D.NativeMethodInfoPtr_OnGizmoPostEnabled_Private_Void_Gizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr, 100664869);
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06000A14 RID: 2580 RVA: 0x00048CD4 File Offset: 0x00046ED4
		public unsafe Quaternion Rotation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2D.NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr3) : null;
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06000A15 RID: 2581 RVA: 0x00048D14 File Offset: 0x00046F14
		public unsafe float RotationDegrees
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2D.NativeMethodInfoPtr_get_RotationDegrees_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06000A16 RID: 2582 RVA: 0x00048D50 File Offset: 0x00046F50
		// (set) Token: 0x06000A17 RID: 2583 RVA: 0x00048D90 File Offset: 0x00046F90
		public unsafe Vector2 StartPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2D.NativeMethodInfoPtr_get_StartPosition_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 65106, RefRangeEnd = 65120, XrefRangeStart = 65104, XrefRangeEnd = 65106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2D.NativeMethodInfoPtr_set_StartPosition_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06000A18 RID: 2584 RVA: 0x00048DD4 File Offset: 0x00046FD4
		public unsafe Vector2 Direction
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65120, XrefRangeEnd = 65122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2D.NativeMethodInfoPtr_get_Direction_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06000A19 RID: 2585 RVA: 0x00048E14 File Offset: 0x00047014
		// (set) Token: 0x06000A1A RID: 2586 RVA: 0x00048E54 File Offset: 0x00047054
		public unsafe Vector3 OffsetDragOrigin
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2D.NativeMethodInfoPtr_get_OffsetDragOrigin_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2D.NativeMethodInfoPtr_set_OffsetDragOrigin_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06000A1B RID: 2587 RVA: 0x00048E98 File Offset: 0x00047098
		// (set) Token: 0x06000A1C RID: 2588 RVA: 0x00048ED8 File Offset: 0x000470D8
		public unsafe Vector3 ScaleDragOrigin
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2D.NativeMethodInfoPtr_get_ScaleDragOrigin_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2D.NativeMethodInfoPtr_set_ScaleDragOrigin_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06000A1D RID: 2589 RVA: 0x00048F1C File Offset: 0x0004711C
		// (set) Token: 0x06000A1E RID: 2590 RVA: 0x00048F58 File Offset: 0x00047158
		public unsafe int ScaleDragAxisIndex
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 24691, RefRangeEnd = 24697, XrefRangeStart = 24691, XrefRangeEnd = 24697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2D.NativeMethodInfoPtr_get_ScaleDragAxisIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2D.NativeMethodInfoPtr_set_ScaleDragAxisIndex_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06000A1F RID: 2591 RVA: 0x00048F98 File Offset: 0x00047198
		public unsafe int Cap2DHandleId
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 65124, RefRangeEnd = 65130, XrefRangeStart = 65122, XrefRangeEnd = 65124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2D.NativeMethodInfoPtr_get_Cap2DHandleId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06000A20 RID: 2592 RVA: 0x00048FD4 File Offset: 0x000471D4
		public unsafe bool IsDragged
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 65131, RefRangeEnd = 65139, XrefRangeStart = 65130, XrefRangeEnd = 65131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2D.NativeMethodInfoPtr_get_IsDragged_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06000A21 RID: 2593 RVA: 0x00049010 File Offset: 0x00047210
		public unsafe bool IsMoving
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65139, XrefRangeEnd = 65140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2D.NativeMethodInfoPtr_get_IsMoving_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06000A22 RID: 2594 RVA: 0x0004904C File Offset: 0x0004724C
		public unsafe bool IsRotating
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65140, XrefRangeEnd = 65141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2D.NativeMethodInfoPtr_get_IsRotating_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06000A23 RID: 2595 RVA: 0x00049088 File Offset: 0x00047288
		public unsafe bool IsScaling
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65141, XrefRangeEnd = 65142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2D.NativeMethodInfoPtr_get_IsScaling_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06000A24 RID: 2596 RVA: 0x000490C4 File Offset: 0x000472C4
		public unsafe bool Is2DCapVisible
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2D.NativeMethodInfoPtr_get_Is2DCapVisible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06000A25 RID: 2597 RVA: 0x00049100 File Offset: 0x00047300
		public unsafe bool Is2DCapHoverable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2D.NativeMethodInfoPtr_get_Is2DCapHoverable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06000A26 RID: 2598 RVA: 0x0004913C File Offset: 0x0004733C
		public unsafe Vector3 TotalDragOffset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2D.NativeMethodInfoPtr_get_TotalDragOffset_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06000A27 RID: 2599 RVA: 0x0004917C File Offset: 0x0004737C
		public unsafe Vector3 RelativeDragOffset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2D.NativeMethodInfoPtr_get_RelativeDragOffset_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06000A28 RID: 2600 RVA: 0x000491BC File Offset: 0x000473BC
		public unsafe float TotalDragRotation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2D.NativeMethodInfoPtr_get_TotalDragRotation_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x06000A29 RID: 2601 RVA: 0x000491F8 File Offset: 0x000473F8
		public unsafe float RelativeDragRotation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2D.NativeMethodInfoPtr_get_RelativeDragRotation_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06000A2A RID: 2602 RVA: 0x00049234 File Offset: 0x00047434
		public unsafe float TotalDragScale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2D.NativeMethodInfoPtr_get_TotalDragScale_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06000A2B RID: 2603 RVA: 0x00049270 File Offset: 0x00047470
		public unsafe float RelativeDragScale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2D.NativeMethodInfoPtr_get_RelativeDragScale_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06000A2C RID: 2604 RVA: 0x000492AC File Offset: 0x000474AC
		public unsafe GizmoOverrideColor OverrideFillColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2D.NativeMethodInfoPtr_get_OverrideFillColor_Public_get_GizmoOverrideColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoOverrideColor>(intPtr3) : null;
			}
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06000A2D RID: 2605 RVA: 0x000492EC File Offset: 0x000474EC
		public unsafe GizmoOverrideColor OverrideBorderColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2D.NativeMethodInfoPtr_get_OverrideBorderColor_Public_get_GizmoOverrideColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoOverrideColor>(intPtr3) : null;
			}
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06000A2E RID: 2606 RVA: 0x0004932C File Offset: 0x0004752C
		public unsafe GizmoLineSlider2DSettings Settings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2D.NativeMethodInfoPtr_get_Settings_Public_get_GizmoLineSlider2DSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoLineSlider2DSettings>(intPtr3) : null;
			}
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06000A2F RID: 2607 RVA: 0x0004936C File Offset: 0x0004756C
		// (set) Token: 0x06000A30 RID: 2608 RVA: 0x000493AC File Offset: 0x000475AC
		public unsafe GizmoLineSlider2DSettings SharedSettings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2D.NativeMethodInfoPtr_get_SharedSettings_Public_get_GizmoLineSlider2DSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoLineSlider2DSettings>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2D.NativeMethodInfoPtr_set_SharedSettings_Public_set_Void_GizmoLineSlider2DSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06000A31 RID: 2609 RVA: 0x000493F0 File Offset: 0x000475F0
		public unsafe GizmoLineSlider2DLookAndFeel LookAndFeel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2D.NativeMethodInfoPtr_get_LookAndFeel_Public_get_GizmoLineSlider2DLookAndFeel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoLineSlider2DLookAndFeel>(intPtr3) : null;
			}
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06000A32 RID: 2610 RVA: 0x00049430 File Offset: 0x00047630
		// (set) Token: 0x06000A33 RID: 2611 RVA: 0x00049470 File Offset: 0x00047670
		public unsafe GizmoLineSlider2DLookAndFeel SharedLookAndFeel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2D.NativeMethodInfoPtr_get_SharedLookAndFeel_Public_get_GizmoLineSlider2DLookAndFeel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoLineSlider2DLookAndFeel>(intPtr3) : null;
			}
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 65145, RefRangeEnd = 65155, XrefRangeStart = 65142, XrefRangeEnd = 65145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2D.NativeMethodInfoPtr_set_SharedLookAndFeel_Public_set_Void_GizmoLineSlider2DLookAndFeel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000A34 RID: 2612 RVA: 0x000494B4 File Offset: 0x000476B4
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 65339, RefRangeEnd = 65347, XrefRangeStart = 65155, XrefRangeEnd = 65339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoLineSlider2D(Gizmo gizmo, int handleId, int capHandleId)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoLineSlider2D>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2D.NativeMethodInfoPtr__ctor_Public_Void_Gizmo_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A35 RID: 2613 RVA: 0x0004951C File Offset: 0x0004771C
		[CallerCount(0)]
		public unsafe override void SetSnapEnabled(bool isEnabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isEnabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoLineSlider2D.NativeMethodInfoPtr_SetSnapEnabled_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A36 RID: 2614 RVA: 0x00049568 File Offset: 0x00047768
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 65349, RefRangeEnd = 65386, XrefRangeStart = 65347, XrefRangeEnd = 65349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set2DCapVisible(bool isVisible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isVisible;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2D.NativeMethodInfoPtr_Set2DCapVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A37 RID: 2615 RVA: 0x000495A8 File Offset: 0x000477A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65386, XrefRangeEnd = 65388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set2DCapHoverable(bool isHoverable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isHoverable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2D.NativeMethodInfoPtr_Set2DCapHoverable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x000495E8 File Offset: 0x000477E8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 65390, RefRangeEnd = 65396, XrefRangeStart = 65388, XrefRangeEnd = 65390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetRealDirection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2D.NativeMethodInfoPtr_GetRealDirection_Public_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x00049628 File Offset: 0x00047828
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 65400, RefRangeEnd = 65403, XrefRangeStart = 65396, XrefRangeEnd = 65400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetRealLength()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2D.NativeMethodInfoPtr_GetRealLength_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x00049664 File Offset: 0x00047864
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 65405, RefRangeEnd = 65411, XrefRangeStart = 65403, XrefRangeEnd = 65405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetRealEndPosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2D.NativeMethodInfoPtr_GetRealEndPosition_Public_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x000496A4 File Offset: 0x000478A4
		[CallerCount(0)]
		public unsafe float GetRealBoxThickness()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2D.NativeMethodInfoPtr_GetRealBoxThickness_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A3C RID: 2620 RVA: 0x000496E0 File Offset: 0x000478E0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 65413, RefRangeEnd = 65421, XrefRangeStart = 65411, XrefRangeEnd = 65413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2D.NativeMethodInfoPtr_MapDirection_Public_Void_Int32_AxisSign_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A3D RID: 2621 RVA: 0x00049730 File Offset: 0x00047930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65421, XrefRangeEnd = 65423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDirection(Vector2 directionAxis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(directionAxis);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2D.NativeMethodInfoPtr_SetDirection_Public_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A3E RID: 2622 RVA: 0x00049774 File Offset: 0x00047974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65423, XrefRangeEnd = 65427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddTargetTransform(GizmoTransform transform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2D.NativeMethodInfoPtr_AddTargetTransform_Public_Void_GizmoTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A3F RID: 2623 RVA: 0x000497B8 File Offset: 0x000479B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65427, XrefRangeEnd = 65428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2D.NativeMethodInfoPtr_AddTargetTransform_Public_Void_GizmoTransform_GizmoDragChannel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A40 RID: 2624 RVA: 0x0004980C File Offset: 0x00047A0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65428, XrefRangeEnd = 65432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveTargetTransform(GizmoTransform transform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2D.NativeMethodInfoPtr_RemoveTargetTransform_Public_Void_GizmoTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A41 RID: 2625 RVA: 0x00049850 File Offset: 0x00047A50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65432, XrefRangeEnd = 65433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2D.NativeMethodInfoPtr_RemoveTargetTransform_Public_Void_GizmoTransform_GizmoDragChannel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x000498A4 File Offset: 0x00047AA4
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 65439, RefRangeEnd = 65447, XrefRangeStart = 65433, XrefRangeEnd = 65439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDragChannel(GizmoDragChannel dragChannel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dragChannel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2D.NativeMethodInfoPtr_SetDragChannel_Public_Void_GizmoDragChannel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x000498E8 File Offset: 0x00047AE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65447, XrefRangeEnd = 65476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Render(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoLineSlider2D.NativeMethodInfoPtr_Render_Public_Virtual_Void_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x00049938 File Offset: 0x00047B38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65476, XrefRangeEnd = 65488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Refresh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2D.NativeMethodInfoPtr_Refresh_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x0004996C File Offset: 0x00047B6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65488, XrefRangeEnd = 65500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnVisibilityStateChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoLineSlider2D.NativeMethodInfoPtr_OnVisibilityStateChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A46 RID: 2630 RVA: 0x000499A8 File Offset: 0x00047BA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65500, XrefRangeEnd = 65502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnHoverableStateChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GizmoLineSlider2D.NativeMethodInfoPtr_OnHoverableStateChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A47 RID: 2631 RVA: 0x000499E4 File Offset: 0x00047BE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65502, XrefRangeEnd = 65522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGizmoPreUpdateBegin(Gizmo gizmo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gizmo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2D.NativeMethodInfoPtr_OnGizmoPreUpdateBegin_Private_Void_Gizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x00049A28 File Offset: 0x00047C28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65522, XrefRangeEnd = 65528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2D.NativeMethodInfoPtr_OnGizmoAttemptHandleDragBegin_Private_Void_Gizmo_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x00049A78 File Offset: 0x00047C78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65528, XrefRangeEnd = 65534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2D.NativeMethodInfoPtr_OnTransformChanged_Private_Void_GizmoTransform_ChangeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x00049AC8 File Offset: 0x00047CC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65534, XrefRangeEnd = 65536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2D.NativeMethodInfoPtr_OnGizmoHandleHoverEnter_Private_Void_Gizmo_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x00049B18 File Offset: 0x00047D18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65536, XrefRangeEnd = 65538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2D.NativeMethodInfoPtr_OnGizmoHandleHoverExit_Private_Void_Gizmo_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A4C RID: 2636 RVA: 0x00049B68 File Offset: 0x00047D68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65538, XrefRangeEnd = 65542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2D.NativeMethodInfoPtr_OnGizmoHandleDragUpdate_Private_Void_Gizmo_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x00049BB8 File Offset: 0x00047DB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65542, XrefRangeEnd = 65544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupSharedLookAndFeel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2D.NativeMethodInfoPtr_SetupSharedLookAndFeel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x00049BEC File Offset: 0x00047DEC
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoLineSlider2D.NativeMethodInfoPtr_OnGizmoPostEnabled_Private_Void_Gizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x0000571F File Offset: 0x0000391F
		public GizmoLineSlider2D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06000A50 RID: 2640 RVA: 0x00049C30 File Offset: 0x00047E30
		// (set) Token: 0x06000A51 RID: 2641 RVA: 0x00005728 File Offset: 0x00003928
		public unsafe SegmentShape2D _segment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2D.NativeFieldInfoPtr__segment);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SegmentShape2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2D.NativeFieldInfoPtr__segment), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06000A52 RID: 2642 RVA: 0x00049C60 File Offset: 0x00047E60
		// (set) Token: 0x06000A53 RID: 2643 RVA: 0x00005747 File Offset: 0x00003947
		public unsafe QuadShape2D _quad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2D.NativeFieldInfoPtr__quad);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuadShape2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2D.NativeFieldInfoPtr__quad), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06000A54 RID: 2644 RVA: 0x00049C90 File Offset: 0x00047E90
		// (set) Token: 0x06000A55 RID: 2645 RVA: 0x00005766 File Offset: 0x00003966
		public unsafe int _segmentIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2D.NativeFieldInfoPtr__segmentIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2D.NativeFieldInfoPtr__segmentIndex)) = value;
			}
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06000A56 RID: 2646 RVA: 0x00049CB8 File Offset: 0x00047EB8
		// (set) Token: 0x06000A57 RID: 2647 RVA: 0x00005781 File Offset: 0x00003981
		public unsafe int _quadIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2D.NativeFieldInfoPtr__quadIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2D.NativeFieldInfoPtr__quadIndex)) = value;
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06000A58 RID: 2648 RVA: 0x00049CE0 File Offset: 0x00047EE0
		// (set) Token: 0x06000A59 RID: 2649 RVA: 0x0000579C File Offset: 0x0000399C
		public unsafe GizmoDragChannel _dragChannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2D.NativeFieldInfoPtr__dragChannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoDragChannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2D.NativeFieldInfoPtr__dragChannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06000A5A RID: 2650 RVA: 0x00049D10 File Offset: 0x00047F10
		// (set) Token: 0x06000A5B RID: 2651 RVA: 0x000057BB File Offset: 0x000039BB
		public unsafe GizmoSglAxisOffsetDrag3D _offsetDrag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2D.NativeFieldInfoPtr__offsetDrag);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoSglAxisOffsetDrag3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2D.NativeFieldInfoPtr__offsetDrag), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06000A5C RID: 2652 RVA: 0x00049D40 File Offset: 0x00047F40
		// (set) Token: 0x06000A5D RID: 2653 RVA: 0x000057DA File Offset: 0x000039DA
		public unsafe Vector3 _offsetDragOrigin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2D.NativeFieldInfoPtr__offsetDragOrigin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2D.NativeFieldInfoPtr__offsetDragOrigin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06000A5E RID: 2654 RVA: 0x00049D70 File Offset: 0x00047F70
		// (set) Token: 0x06000A5F RID: 2655 RVA: 0x000057F9 File Offset: 0x000039F9
		public unsafe GizmoSglAxisRotationDrag3D _rotationDrag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2D.NativeFieldInfoPtr__rotationDrag);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoSglAxisRotationDrag3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2D.NativeFieldInfoPtr__rotationDrag), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06000A60 RID: 2656 RVA: 0x00049DA0 File Offset: 0x00047FA0
		// (set) Token: 0x06000A61 RID: 2657 RVA: 0x00005818 File Offset: 0x00003A18
		public unsafe GizmoRotationArc2D _rotationArc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2D.NativeFieldInfoPtr__rotationArc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoRotationArc2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2D.NativeFieldInfoPtr__rotationArc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06000A62 RID: 2658 RVA: 0x00049DD0 File Offset: 0x00047FD0
		// (set) Token: 0x06000A63 RID: 2659 RVA: 0x00005837 File Offset: 0x00003A37
		public unsafe GizmoSglAxisScaleDrag3D _scaleDrag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2D.NativeFieldInfoPtr__scaleDrag);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoSglAxisScaleDrag3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2D.NativeFieldInfoPtr__scaleDrag), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06000A64 RID: 2660 RVA: 0x00049E00 File Offset: 0x00048000
		// (set) Token: 0x06000A65 RID: 2661 RVA: 0x00005856 File Offset: 0x00003A56
		public unsafe Vector3 _scaleDragOrigin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2D.NativeFieldInfoPtr__scaleDragOrigin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2D.NativeFieldInfoPtr__scaleDragOrigin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06000A66 RID: 2662 RVA: 0x00049E30 File Offset: 0x00048030
		// (set) Token: 0x06000A67 RID: 2663 RVA: 0x00005875 File Offset: 0x00003A75
		public unsafe Vector3 _scaleAxis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2D.NativeFieldInfoPtr__scaleAxis);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2D.NativeFieldInfoPtr__scaleAxis), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06000A68 RID: 2664 RVA: 0x00049E60 File Offset: 0x00048060
		// (set) Token: 0x06000A69 RID: 2665 RVA: 0x00005894 File Offset: 0x00003A94
		public unsafe int _scaleDragAxisIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2D.NativeFieldInfoPtr__scaleDragAxisIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2D.NativeFieldInfoPtr__scaleDragAxisIndex)) = value;
			}
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06000A6A RID: 2666 RVA: 0x00049E88 File Offset: 0x00048088
		// (set) Token: 0x06000A6B RID: 2667 RVA: 0x000058AF File Offset: 0x00003AAF
		public unsafe IGizmoDragSession _selectedDragSession
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2D.NativeFieldInfoPtr__selectedDragSession);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGizmoDragSession>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2D.NativeFieldInfoPtr__selectedDragSession), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06000A6C RID: 2668 RVA: 0x00049EB8 File Offset: 0x000480B8
		// (set) Token: 0x06000A6D RID: 2669 RVA: 0x000058CE File Offset: 0x00003ACE
		public unsafe GizmoCap2D _cap2D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2D.NativeFieldInfoPtr__cap2D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoCap2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2D.NativeFieldInfoPtr__cap2D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06000A6E RID: 2670 RVA: 0x00049EE8 File Offset: 0x000480E8
		// (set) Token: 0x06000A6F RID: 2671 RVA: 0x000058ED File Offset: 0x00003AED
		public unsafe GizmoTransform _transform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2D.NativeFieldInfoPtr__transform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2D.NativeFieldInfoPtr__transform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06000A70 RID: 2672 RVA: 0x00049F18 File Offset: 0x00048118
		// (set) Token: 0x06000A71 RID: 2673 RVA: 0x0000590C File Offset: 0x00003B0C
		public unsafe GizmoTransformAxisMap2D _directionAxisMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2D.NativeFieldInfoPtr__directionAxisMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoTransformAxisMap2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2D.NativeFieldInfoPtr__directionAxisMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06000A72 RID: 2674 RVA: 0x00049F48 File Offset: 0x00048148
		// (set) Token: 0x06000A73 RID: 2675 RVA: 0x0000592B File Offset: 0x00003B2B
		public unsafe GizmoOverrideColor _overrideFillColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2D.NativeFieldInfoPtr__overrideFillColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoOverrideColor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2D.NativeFieldInfoPtr__overrideFillColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06000A74 RID: 2676 RVA: 0x00049F78 File Offset: 0x00048178
		// (set) Token: 0x06000A75 RID: 2677 RVA: 0x0000594A File Offset: 0x00003B4A
		public unsafe GizmoOverrideColor _overrideBorderColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2D.NativeFieldInfoPtr__overrideBorderColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoOverrideColor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2D.NativeFieldInfoPtr__overrideBorderColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06000A76 RID: 2678 RVA: 0x00049FA8 File Offset: 0x000481A8
		// (set) Token: 0x06000A77 RID: 2679 RVA: 0x00005969 File Offset: 0x00003B69
		public unsafe GizmoLineSlider2DControllerData _controllerData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2D.NativeFieldInfoPtr__controllerData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoLineSlider2DControllerData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2D.NativeFieldInfoPtr__controllerData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06000A78 RID: 2680 RVA: 0x00049FD8 File Offset: 0x000481D8
		// (set) Token: 0x06000A79 RID: 2681 RVA: 0x00005988 File Offset: 0x00003B88
		public unsafe Il2CppReferenceArray<IGizmoLineSlider2DController> _controllers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2D.NativeFieldInfoPtr__controllers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IGizmoLineSlider2DController>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2D.NativeFieldInfoPtr__controllers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06000A7A RID: 2682 RVA: 0x0004A008 File Offset: 0x00048208
		// (set) Token: 0x06000A7B RID: 2683 RVA: 0x000059A7 File Offset: 0x00003BA7
		public unsafe GizmoLineSlider2DSettings _settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2D.NativeFieldInfoPtr__settings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoLineSlider2DSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2D.NativeFieldInfoPtr__settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06000A7C RID: 2684 RVA: 0x0004A038 File Offset: 0x00048238
		// (set) Token: 0x06000A7D RID: 2685 RVA: 0x000059C6 File Offset: 0x00003BC6
		public unsafe GizmoLineSlider2DSettings _sharedSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2D.NativeFieldInfoPtr__sharedSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoLineSlider2DSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2D.NativeFieldInfoPtr__sharedSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06000A7E RID: 2686 RVA: 0x0004A068 File Offset: 0x00048268
		// (set) Token: 0x06000A7F RID: 2687 RVA: 0x000059E5 File Offset: 0x00003BE5
		public unsafe GizmoLineSlider2DLookAndFeel _lookAndFeel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2D.NativeFieldInfoPtr__lookAndFeel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoLineSlider2DLookAndFeel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2D.NativeFieldInfoPtr__lookAndFeel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06000A80 RID: 2688 RVA: 0x0004A098 File Offset: 0x00048298
		// (set) Token: 0x06000A81 RID: 2689 RVA: 0x00005A04 File Offset: 0x00003C04
		public unsafe GizmoLineSlider2DLookAndFeel _sharedLookAndFeel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2D.NativeFieldInfoPtr__sharedLookAndFeel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoLineSlider2DLookAndFeel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoLineSlider2D.NativeFieldInfoPtr__sharedLookAndFeel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040007B3 RID: 1971
		private static readonly IntPtr NativeFieldInfoPtr__segment;

		// Token: 0x040007B4 RID: 1972
		private static readonly IntPtr NativeFieldInfoPtr__quad;

		// Token: 0x040007B5 RID: 1973
		private static readonly IntPtr NativeFieldInfoPtr__segmentIndex;

		// Token: 0x040007B6 RID: 1974
		private static readonly IntPtr NativeFieldInfoPtr__quadIndex;

		// Token: 0x040007B7 RID: 1975
		private static readonly IntPtr NativeFieldInfoPtr__dragChannel;

		// Token: 0x040007B8 RID: 1976
		private static readonly IntPtr NativeFieldInfoPtr__offsetDrag;

		// Token: 0x040007B9 RID: 1977
		private static readonly IntPtr NativeFieldInfoPtr__offsetDragOrigin;

		// Token: 0x040007BA RID: 1978
		private static readonly IntPtr NativeFieldInfoPtr__rotationDrag;

		// Token: 0x040007BB RID: 1979
		private static readonly IntPtr NativeFieldInfoPtr__rotationArc;

		// Token: 0x040007BC RID: 1980
		private static readonly IntPtr NativeFieldInfoPtr__scaleDrag;

		// Token: 0x040007BD RID: 1981
		private static readonly IntPtr NativeFieldInfoPtr__scaleDragOrigin;

		// Token: 0x040007BE RID: 1982
		private static readonly IntPtr NativeFieldInfoPtr__scaleAxis;

		// Token: 0x040007BF RID: 1983
		private static readonly IntPtr NativeFieldInfoPtr__scaleDragAxisIndex;

		// Token: 0x040007C0 RID: 1984
		private static readonly IntPtr NativeFieldInfoPtr__selectedDragSession;

		// Token: 0x040007C1 RID: 1985
		private static readonly IntPtr NativeFieldInfoPtr__cap2D;

		// Token: 0x040007C2 RID: 1986
		private static readonly IntPtr NativeFieldInfoPtr__transform;

		// Token: 0x040007C3 RID: 1987
		private static readonly IntPtr NativeFieldInfoPtr__directionAxisMap;

		// Token: 0x040007C4 RID: 1988
		private static readonly IntPtr NativeFieldInfoPtr__overrideFillColor;

		// Token: 0x040007C5 RID: 1989
		private static readonly IntPtr NativeFieldInfoPtr__overrideBorderColor;

		// Token: 0x040007C6 RID: 1990
		private static readonly IntPtr NativeFieldInfoPtr__controllerData;

		// Token: 0x040007C7 RID: 1991
		private static readonly IntPtr NativeFieldInfoPtr__controllers;

		// Token: 0x040007C8 RID: 1992
		private static readonly IntPtr NativeFieldInfoPtr__settings;

		// Token: 0x040007C9 RID: 1993
		private static readonly IntPtr NativeFieldInfoPtr__sharedSettings;

		// Token: 0x040007CA RID: 1994
		private static readonly IntPtr NativeFieldInfoPtr__lookAndFeel;

		// Token: 0x040007CB RID: 1995
		private static readonly IntPtr NativeFieldInfoPtr__sharedLookAndFeel;

		// Token: 0x040007CC RID: 1996
		private static readonly IntPtr NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0;

		// Token: 0x040007CD RID: 1997
		private static readonly IntPtr NativeMethodInfoPtr_get_RotationDegrees_Public_get_Single_0;

		// Token: 0x040007CE RID: 1998
		private static readonly IntPtr NativeMethodInfoPtr_get_StartPosition_Public_get_Vector2_0;

		// Token: 0x040007CF RID: 1999
		private static readonly IntPtr NativeMethodInfoPtr_set_StartPosition_Public_set_Void_Vector2_0;

		// Token: 0x040007D0 RID: 2000
		private static readonly IntPtr NativeMethodInfoPtr_get_Direction_Public_get_Vector2_0;

		// Token: 0x040007D1 RID: 2001
		private static readonly IntPtr NativeMethodInfoPtr_get_OffsetDragOrigin_Public_get_Vector3_0;

		// Token: 0x040007D2 RID: 2002
		private static readonly IntPtr NativeMethodInfoPtr_set_OffsetDragOrigin_Public_set_Void_Vector3_0;

		// Token: 0x040007D3 RID: 2003
		private static readonly IntPtr NativeMethodInfoPtr_get_ScaleDragOrigin_Public_get_Vector3_0;

		// Token: 0x040007D4 RID: 2004
		private static readonly IntPtr NativeMethodInfoPtr_set_ScaleDragOrigin_Public_set_Void_Vector3_0;

		// Token: 0x040007D5 RID: 2005
		private static readonly IntPtr NativeMethodInfoPtr_get_ScaleDragAxisIndex_Public_get_Int32_0;

		// Token: 0x040007D6 RID: 2006
		private static readonly IntPtr NativeMethodInfoPtr_set_ScaleDragAxisIndex_Public_set_Void_Int32_0;

		// Token: 0x040007D7 RID: 2007
		private static readonly IntPtr NativeMethodInfoPtr_get_Cap2DHandleId_Public_get_Int32_0;

		// Token: 0x040007D8 RID: 2008
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDragged_Public_get_Boolean_0;

		// Token: 0x040007D9 RID: 2009
		private static readonly IntPtr NativeMethodInfoPtr_get_IsMoving_Public_get_Boolean_0;

		// Token: 0x040007DA RID: 2010
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRotating_Public_get_Boolean_0;

		// Token: 0x040007DB RID: 2011
		private static readonly IntPtr NativeMethodInfoPtr_get_IsScaling_Public_get_Boolean_0;

		// Token: 0x040007DC RID: 2012
		private static readonly IntPtr NativeMethodInfoPtr_get_Is2DCapVisible_Public_get_Boolean_0;

		// Token: 0x040007DD RID: 2013
		private static readonly IntPtr NativeMethodInfoPtr_get_Is2DCapHoverable_Public_get_Boolean_0;

		// Token: 0x040007DE RID: 2014
		private static readonly IntPtr NativeMethodInfoPtr_get_TotalDragOffset_Public_get_Vector3_0;

		// Token: 0x040007DF RID: 2015
		private static readonly IntPtr NativeMethodInfoPtr_get_RelativeDragOffset_Public_get_Vector3_0;

		// Token: 0x040007E0 RID: 2016
		private static readonly IntPtr NativeMethodInfoPtr_get_TotalDragRotation_Public_get_Single_0;

		// Token: 0x040007E1 RID: 2017
		private static readonly IntPtr NativeMethodInfoPtr_get_RelativeDragRotation_Public_get_Single_0;

		// Token: 0x040007E2 RID: 2018
		private static readonly IntPtr NativeMethodInfoPtr_get_TotalDragScale_Public_get_Single_0;

		// Token: 0x040007E3 RID: 2019
		private static readonly IntPtr NativeMethodInfoPtr_get_RelativeDragScale_Public_get_Single_0;

		// Token: 0x040007E4 RID: 2020
		private static readonly IntPtr NativeMethodInfoPtr_get_OverrideFillColor_Public_get_GizmoOverrideColor_0;

		// Token: 0x040007E5 RID: 2021
		private static readonly IntPtr NativeMethodInfoPtr_get_OverrideBorderColor_Public_get_GizmoOverrideColor_0;

		// Token: 0x040007E6 RID: 2022
		private static readonly IntPtr NativeMethodInfoPtr_get_Settings_Public_get_GizmoLineSlider2DSettings_0;

		// Token: 0x040007E7 RID: 2023
		private static readonly IntPtr NativeMethodInfoPtr_get_SharedSettings_Public_get_GizmoLineSlider2DSettings_0;

		// Token: 0x040007E8 RID: 2024
		private static readonly IntPtr NativeMethodInfoPtr_set_SharedSettings_Public_set_Void_GizmoLineSlider2DSettings_0;

		// Token: 0x040007E9 RID: 2025
		private static readonly IntPtr NativeMethodInfoPtr_get_LookAndFeel_Public_get_GizmoLineSlider2DLookAndFeel_0;

		// Token: 0x040007EA RID: 2026
		private static readonly IntPtr NativeMethodInfoPtr_get_SharedLookAndFeel_Public_get_GizmoLineSlider2DLookAndFeel_0;

		// Token: 0x040007EB RID: 2027
		private static readonly IntPtr NativeMethodInfoPtr_set_SharedLookAndFeel_Public_set_Void_GizmoLineSlider2DLookAndFeel_0;

		// Token: 0x040007EC RID: 2028
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Gizmo_Int32_Int32_0;

		// Token: 0x040007ED RID: 2029
		private static readonly IntPtr NativeMethodInfoPtr_SetSnapEnabled_Public_Virtual_Void_Boolean_0;

		// Token: 0x040007EE RID: 2030
		private static readonly IntPtr NativeMethodInfoPtr_Set2DCapVisible_Public_Void_Boolean_0;

		// Token: 0x040007EF RID: 2031
		private static readonly IntPtr NativeMethodInfoPtr_Set2DCapHoverable_Public_Void_Boolean_0;

		// Token: 0x040007F0 RID: 2032
		private static readonly IntPtr NativeMethodInfoPtr_GetRealDirection_Public_Vector2_0;

		// Token: 0x040007F1 RID: 2033
		private static readonly IntPtr NativeMethodInfoPtr_GetRealLength_Public_Single_0;

		// Token: 0x040007F2 RID: 2034
		private static readonly IntPtr NativeMethodInfoPtr_GetRealEndPosition_Public_Vector2_0;

		// Token: 0x040007F3 RID: 2035
		private static readonly IntPtr NativeMethodInfoPtr_GetRealBoxThickness_Public_Single_0;

		// Token: 0x040007F4 RID: 2036
		private static readonly IntPtr NativeMethodInfoPtr_MapDirection_Public_Void_Int32_AxisSign_0;

		// Token: 0x040007F5 RID: 2037
		private static readonly IntPtr NativeMethodInfoPtr_SetDirection_Public_Void_Vector2_0;

		// Token: 0x040007F6 RID: 2038
		private static readonly IntPtr NativeMethodInfoPtr_AddTargetTransform_Public_Void_GizmoTransform_0;

		// Token: 0x040007F7 RID: 2039
		private static readonly IntPtr NativeMethodInfoPtr_AddTargetTransform_Public_Void_GizmoTransform_GizmoDragChannel_0;

		// Token: 0x040007F8 RID: 2040
		private static readonly IntPtr NativeMethodInfoPtr_RemoveTargetTransform_Public_Void_GizmoTransform_0;

		// Token: 0x040007F9 RID: 2041
		private static readonly IntPtr NativeMethodInfoPtr_RemoveTargetTransform_Public_Void_GizmoTransform_GizmoDragChannel_0;

		// Token: 0x040007FA RID: 2042
		private static readonly IntPtr NativeMethodInfoPtr_SetDragChannel_Public_Void_GizmoDragChannel_0;

		// Token: 0x040007FB RID: 2043
		private static readonly IntPtr NativeMethodInfoPtr_Render_Public_Virtual_Void_Camera_0;

		// Token: 0x040007FC RID: 2044
		private static readonly IntPtr NativeMethodInfoPtr_Refresh_Public_Void_0;

		// Token: 0x040007FD RID: 2045
		private static readonly IntPtr NativeMethodInfoPtr_OnVisibilityStateChanged_Protected_Virtual_Void_0;

		// Token: 0x040007FE RID: 2046
		private static readonly IntPtr NativeMethodInfoPtr_OnHoverableStateChanged_Protected_Virtual_Void_0;

		// Token: 0x040007FF RID: 2047
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoPreUpdateBegin_Private_Void_Gizmo_0;

		// Token: 0x04000800 RID: 2048
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoAttemptHandleDragBegin_Private_Void_Gizmo_Int32_0;

		// Token: 0x04000801 RID: 2049
		private static readonly IntPtr NativeMethodInfoPtr_OnTransformChanged_Private_Void_GizmoTransform_ChangeData_0;

		// Token: 0x04000802 RID: 2050
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoHandleHoverEnter_Private_Void_Gizmo_Int32_0;

		// Token: 0x04000803 RID: 2051
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoHandleHoverExit_Private_Void_Gizmo_Int32_0;

		// Token: 0x04000804 RID: 2052
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoHandleDragUpdate_Private_Void_Gizmo_Int32_0;

		// Token: 0x04000805 RID: 2053
		private static readonly IntPtr NativeMethodInfoPtr_SetupSharedLookAndFeel_Private_Void_0;

		// Token: 0x04000806 RID: 2054
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoPostEnabled_Private_Void_Gizmo_0;
	}
}
