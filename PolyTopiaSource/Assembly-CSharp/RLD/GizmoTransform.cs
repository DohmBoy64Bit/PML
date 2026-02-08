using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x02000033 RID: 51
	public class GizmoTransform : global::Il2CppSystem.Object
	{
		// Token: 0x060002AB RID: 683 RVA: 0x0002B5F4 File Offset: 0x000297F4
		// Note: this type is marked as 'beforefieldinit'.
		static GizmoTransform()
		{
			Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "GizmoTransform");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr);
			GizmoTransform.NativeFieldInfoPtr_Changed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, "Changed");
			GizmoTransform.NativeFieldInfoPtr__firingChanged3DEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, "_firingChanged3DEvent");
			GizmoTransform.NativeFieldInfoPtr__firingChanged2DEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, "_firingChanged2DEvent");
			GizmoTransform.NativeFieldInfoPtr__position3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, "_position3D");
			GizmoTransform.NativeFieldInfoPtr__localPosition3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, "_localPosition3D");
			GizmoTransform.NativeFieldInfoPtr__rotation3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, "_rotation3D");
			GizmoTransform.NativeFieldInfoPtr__localRotation3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, "_localRotation3D");
			GizmoTransform.NativeFieldInfoPtr__position2D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, "_position2D");
			GizmoTransform.NativeFieldInfoPtr__localPosition2D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, "_localPosition2D");
			GizmoTransform.NativeFieldInfoPtr__rotation2DDegrees = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, "_rotation2DDegrees");
			GizmoTransform.NativeFieldInfoPtr__rotation2D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, "_rotation2D");
			GizmoTransform.NativeFieldInfoPtr__localRotation2DDegrees = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, "_localRotation2DDegrees");
			GizmoTransform.NativeFieldInfoPtr__localRotation2D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, "_localRotation2D");
			GizmoTransform.NativeFieldInfoPtr__axes3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, "_axes3D");
			GizmoTransform.NativeFieldInfoPtr__axes2D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, "_axes2D");
			GizmoTransform.NativeFieldInfoPtr__parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, "_parent");
			GizmoTransform.NativeFieldInfoPtr__children = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, "_children");
			GizmoTransform.NativeMethodInfoPtr_get_CanChange3D_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663690);
			GizmoTransform.NativeMethodInfoPtr_get_CanChange2D_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663691);
			GizmoTransform.NativeMethodInfoPtr_get_Parent_Public_get_GizmoTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663692);
			GizmoTransform.NativeMethodInfoPtr_get_NumChildren_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663693);
			GizmoTransform.NativeMethodInfoPtr_get_Children_Public_get_List_1_GizmoTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663694);
			GizmoTransform.NativeMethodInfoPtr_get_Right3D_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663695);
			GizmoTransform.NativeMethodInfoPtr_get_Up3D_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663696);
			GizmoTransform.NativeMethodInfoPtr_get_Look3D_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663697);
			GizmoTransform.NativeMethodInfoPtr_get_Right2D_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663698);
			GizmoTransform.NativeMethodInfoPtr_get_Up2D_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663699);
			GizmoTransform.NativeMethodInfoPtr_get_Position3D_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663700);
			GizmoTransform.NativeMethodInfoPtr_set_Position3D_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663701);
			GizmoTransform.NativeMethodInfoPtr_get_Position2D_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663702);
			GizmoTransform.NativeMethodInfoPtr_set_Position2D_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663703);
			GizmoTransform.NativeMethodInfoPtr_get_Rotation3D_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663704);
			GizmoTransform.NativeMethodInfoPtr_set_Rotation3D_Public_set_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663705);
			GizmoTransform.NativeMethodInfoPtr_get_Rotation2D_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663706);
			GizmoTransform.NativeMethodInfoPtr_get_Rotation2DDegrees_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663707);
			GizmoTransform.NativeMethodInfoPtr_set_Rotation2DDegrees_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663708);
			GizmoTransform.NativeMethodInfoPtr_get_LocalPosition3D_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663709);
			GizmoTransform.NativeMethodInfoPtr_set_LocalPosition3D_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663710);
			GizmoTransform.NativeMethodInfoPtr_get_LocalPosition2D_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663711);
			GizmoTransform.NativeMethodInfoPtr_set_LocalPosition2D_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663712);
			GizmoTransform.NativeMethodInfoPtr_get_LocalRotation3D_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663713);
			GizmoTransform.NativeMethodInfoPtr_set_LocalRotation3D_Public_set_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663714);
			GizmoTransform.NativeMethodInfoPtr_get_LocalRotation2D_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663715);
			GizmoTransform.NativeMethodInfoPtr_get_LocalRotation2DDegrees_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663716);
			GizmoTransform.NativeMethodInfoPtr_set_LocalRotation2DDegrees_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663717);
			GizmoTransform.NativeMethodInfoPtr_add_Changed_Public_add_Void_GizmoEntityTransformChangedHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663688);
			GizmoTransform.NativeMethodInfoPtr_remove_Changed_Public_rem_Void_GizmoEntityTransformChangedHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663689);
			GizmoTransform.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663718);
			GizmoTransform.NativeMethodInfoPtr_FilterParentsOnly_Public_Static_List_1_GizmoTransform_IEnumerable_1_GizmoTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663719);
			GizmoTransform.NativeMethodInfoPtr_Get3DQuadrantFacingCamera_Public_PlaneQuadrantId_PlaneId_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663720);
			GizmoTransform.NativeMethodInfoPtr_Rotate3D_Public_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663721);
			GizmoTransform.NativeMethodInfoPtr_Rotate2D_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663722);
			GizmoTransform.NativeMethodInfoPtr_Rotate2D_Public_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663723);
			GizmoTransform.NativeMethodInfoPtr_TransformVector3D_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663724);
			GizmoTransform.NativeMethodInfoPtr_TransformVector2D_Public_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663725);
			GizmoTransform.NativeMethodInfoPtr_TransformNormal3D_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663726);
			GizmoTransform.NativeMethodInfoPtr_TransformNormal2D_Public_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663727);
			GizmoTransform.NativeMethodInfoPtr_InverseTransformNormal3D_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663728);
			GizmoTransform.NativeMethodInfoPtr_InverseTransformNormal2D_Public_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663729);
			GizmoTransform.NativeMethodInfoPtr_TransformPoint3D_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663730);
			GizmoTransform.NativeMethodInfoPtr_TransformPoint2D_Public_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663731);
			GizmoTransform.NativeMethodInfoPtr_InverseTransformPoint3D_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663732);
			GizmoTransform.NativeMethodInfoPtr_InverseTransformPoint2D_Public_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663733);
			GizmoTransform.NativeMethodInfoPtr_AlignAxis3D_Public_Void_Int32_AxisSign_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663734);
			GizmoTransform.NativeMethodInfoPtr_AlignAxis2D_Public_Void_Int32_AxisSign_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663735);
			GizmoTransform.NativeMethodInfoPtr_IsChildOf_Public_Boolean_GizmoTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663736);
			GizmoTransform.NativeMethodInfoPtr_SetParent_Public_Void_GizmoTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663737);
			GizmoTransform.NativeMethodInfoPtr_GetAxis3D_Public_Vector3_AxisDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663738);
			GizmoTransform.NativeMethodInfoPtr_GetAxis3D_Public_Vector3_Int32_AxisSign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663739);
			GizmoTransform.NativeMethodInfoPtr_GetAxis2D_Public_Vector2_AxisDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663740);
			GizmoTransform.NativeMethodInfoPtr_GetAxis2D_Public_Vector2_Int32_AxisSign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663741);
			GizmoTransform.NativeMethodInfoPtr_GetAxes3D_Public_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663742);
			GizmoTransform.NativeMethodInfoPtr_GetAxes2D_Public_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663743);
			GizmoTransform.NativeMethodInfoPtr_GetPlane3D_Public_Plane_PlaneId_PlaneQuadrantId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663744);
			GizmoTransform.NativeMethodInfoPtr_GetPlane3D_Public_Plane_PlaneDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663745);
			GizmoTransform.NativeMethodInfoPtr_ChangePosition3D_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663746);
			GizmoTransform.NativeMethodInfoPtr_ChangePosition2D_Private_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663747);
			GizmoTransform.NativeMethodInfoPtr_ChangeRotation3D_Private_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663748);
			GizmoTransform.NativeMethodInfoPtr_ChangeRotation2D_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663749);
			GizmoTransform.NativeMethodInfoPtr_ChangeRotation2D_Private_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663750);
			GizmoTransform.NativeMethodInfoPtr_ChangeLocalPosition3D_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663751);
			GizmoTransform.NativeMethodInfoPtr_ChangeLocalPosition2D_Private_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663752);
			GizmoTransform.NativeMethodInfoPtr_ChangeLocalRotation3D_Private_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663753);
			GizmoTransform.NativeMethodInfoPtr_ChangeLocalRotation2D_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663754);
			GizmoTransform.NativeMethodInfoPtr_ChangeLocalRotation2D_Private_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663755);
			GizmoTransform.NativeMethodInfoPtr_OnParentChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663756);
			GizmoTransform.NativeMethodInfoPtr_OnPosition3DChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663757);
			GizmoTransform.NativeMethodInfoPtr_OnPosition2DChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663758);
			GizmoTransform.NativeMethodInfoPtr_OnLocalPosition3DChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663759);
			GizmoTransform.NativeMethodInfoPtr_OnLocalPosition2DChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663760);
			GizmoTransform.NativeMethodInfoPtr_OnRotation3DChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663761);
			GizmoTransform.NativeMethodInfoPtr_OnRotation2DChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663762);
			GizmoTransform.NativeMethodInfoPtr_OnLocalRotation3DChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663763);
			GizmoTransform.NativeMethodInfoPtr_OnLocalRotation2DChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663764);
			GizmoTransform.NativeMethodInfoPtr_UpdateChildTransforms3D_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663765);
			GizmoTransform.NativeMethodInfoPtr_UpdateChildTransforms2D_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663766);
			GizmoTransform.NativeMethodInfoPtr_OnChanged_Private_Void_ChangeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663767);
			GizmoTransform.NativeMethodInfoPtr_Update3DAxes_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663768);
			GizmoTransform.NativeMethodInfoPtr_Update2DAxes_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, 100663769);
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060002AC RID: 684 RVA: 0x0002BDE0 File Offset: 0x00029FE0
		public unsafe bool CanChange3D
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_get_CanChange3D_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060002AD RID: 685 RVA: 0x0002BE1C File Offset: 0x0002A01C
		public unsafe bool CanChange2D
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_get_CanChange2D_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060002AE RID: 686 RVA: 0x0002BE58 File Offset: 0x0002A058
		public unsafe GizmoTransform Parent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_get_Parent_Public_get_GizmoTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoTransform>(intPtr3) : null;
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060002AF RID: 687 RVA: 0x0002BE98 File Offset: 0x0002A098
		public unsafe int NumChildren
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58260, XrefRangeEnd = 58261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_get_NumChildren_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060002B0 RID: 688 RVA: 0x0002BED4 File Offset: 0x0002A0D4
		public unsafe List<GizmoTransform> Children
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58261, XrefRangeEnd = 58267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_get_Children_Public_get_List_1_GizmoTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<GizmoTransform>>(intPtr3) : null;
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060002B1 RID: 689 RVA: 0x0002BF14 File Offset: 0x0002A114
		public unsafe Vector3 Right3D
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_get_Right3D_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060002B2 RID: 690 RVA: 0x0002BF54 File Offset: 0x0002A154
		public unsafe Vector3 Up3D
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_get_Up3D_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060002B3 RID: 691 RVA: 0x0002BF94 File Offset: 0x0002A194
		public unsafe Vector3 Look3D
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_get_Look3D_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060002B4 RID: 692 RVA: 0x0002BFD4 File Offset: 0x0002A1D4
		public unsafe Vector2 Right2D
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_get_Right2D_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060002B5 RID: 693 RVA: 0x0002C014 File Offset: 0x0002A214
		public unsafe Vector2 Up2D
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_get_Up2D_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060002B6 RID: 694 RVA: 0x0002C054 File Offset: 0x0002A254
		// (set) Token: 0x060002B7 RID: 695 RVA: 0x0002C094 File Offset: 0x0002A294
		public unsafe Vector3 Position3D
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_get_Position3D_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(28)]
			[CachedScanResults(RefRangeStart = 58271, RefRangeEnd = 58299, XrefRangeStart = 58267, XrefRangeEnd = 58271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_set_Position3D_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060002B8 RID: 696 RVA: 0x0002C0D8 File Offset: 0x0002A2D8
		// (set) Token: 0x060002B9 RID: 697 RVA: 0x0002C118 File Offset: 0x0002A318
		public unsafe Vector2 Position2D
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_get_Position2D_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 58303, RefRangeEnd = 58315, XrefRangeStart = 58299, XrefRangeEnd = 58303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_set_Position2D_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060002BA RID: 698 RVA: 0x0002C15C File Offset: 0x0002A35C
		// (set) Token: 0x060002BB RID: 699 RVA: 0x0002C19C File Offset: 0x0002A39C
		public unsafe Quaternion Rotation3D
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_get_Rotation3D_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr3) : null;
			}
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 58321, RefRangeEnd = 58336, XrefRangeStart = 58315, XrefRangeEnd = 58321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_set_Rotation3D_Public_set_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060002BC RID: 700 RVA: 0x0002C1E0 File Offset: 0x0002A3E0
		public unsafe Quaternion Rotation2D
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_get_Rotation2D_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr3) : null;
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060002BD RID: 701 RVA: 0x0002C220 File Offset: 0x0002A420
		// (set) Token: 0x060002BE RID: 702 RVA: 0x0002C25C File Offset: 0x0002A45C
		public unsafe float Rotation2DDegrees
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_get_Rotation2DDegrees_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 58337, RefRangeEnd = 58338, XrefRangeStart = 58336, XrefRangeEnd = 58337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_set_Rotation2DDegrees_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060002BF RID: 703 RVA: 0x0002C29C File Offset: 0x0002A49C
		// (set) Token: 0x060002C0 RID: 704 RVA: 0x0002C2DC File Offset: 0x0002A4DC
		public unsafe Vector3 LocalPosition3D
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_get_LocalPosition3D_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58338, XrefRangeEnd = 58341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_set_LocalPosition3D_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060002C1 RID: 705 RVA: 0x0002C320 File Offset: 0x0002A520
		// (set) Token: 0x060002C2 RID: 706 RVA: 0x0002C360 File Offset: 0x0002A560
		public unsafe Vector2 LocalPosition2D
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_get_LocalPosition2D_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58341, XrefRangeEnd = 58344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_set_LocalPosition2D_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060002C3 RID: 707 RVA: 0x0002C3A4 File Offset: 0x0002A5A4
		// (set) Token: 0x060002C4 RID: 708 RVA: 0x0002C3E4 File Offset: 0x0002A5E4
		public unsafe Quaternion LocalRotation3D
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_get_LocalRotation3D_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 58350, RefRangeEnd = 58351, XrefRangeStart = 58344, XrefRangeEnd = 58350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_set_LocalRotation3D_Public_set_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060002C5 RID: 709 RVA: 0x0002C428 File Offset: 0x0002A628
		public unsafe Quaternion LocalRotation2D
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_get_LocalRotation2D_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr3) : null;
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060002C6 RID: 710 RVA: 0x0002C468 File Offset: 0x0002A668
		// (set) Token: 0x060002C7 RID: 711 RVA: 0x0002C4A4 File Offset: 0x0002A6A4
		public unsafe float LocalRotation2DDegrees
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_get_LocalRotation2DDegrees_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58351, XrefRangeEnd = 58356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_set_LocalRotation2DDegrees_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x0002C4E4 File Offset: 0x0002A6E4
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 58360, RefRangeEnd = 58371, XrefRangeStart = 58356, XrefRangeEnd = 58360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_Changed(GizmoEntityTransformChangedHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_add_Changed_Public_add_Void_GizmoEntityTransformChangedHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x0002C528 File Offset: 0x0002A728
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 58375, RefRangeEnd = 58385, XrefRangeStart = 58371, XrefRangeEnd = 58375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_Changed(GizmoEntityTransformChangedHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_remove_Changed_Public_rem_Void_GizmoEntityTransformChangedHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002CA RID: 714 RVA: 0x0002C56C File Offset: 0x0002A76C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 58411, RefRangeEnd = 58419, XrefRangeStart = 58385, XrefRangeEnd = 58411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoTransform()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002CB RID: 715 RVA: 0x0002C5A8 File Offset: 0x0002A7A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 58459, RefRangeEnd = 58460, XrefRangeStart = 58419, XrefRangeEnd = 58459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<GizmoTransform> FilterParentsOnly(IEnumerable<GizmoTransform> transforms)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transforms);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_FilterParentsOnly_Public_Static_List_1_GizmoTransform_IEnumerable_1_GizmoTransform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<GizmoTransform>>(intPtr3) : null;
			}
		}

		// Token: 0x060002CC RID: 716 RVA: 0x0002C5EC File Offset: 0x0002A7EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 58477, RefRangeEnd = 58478, XrefRangeStart = 58460, XrefRangeEnd = 58477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlaneQuadrantId Get3DQuadrantFacingCamera(PlaneId planeId, Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(planeId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_Get3DQuadrantFacingCamera_Public_PlaneQuadrantId_PlaneId_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlaneQuadrantId>(intPtr3) : null;
		}

		// Token: 0x060002CD RID: 717 RVA: 0x0002C650 File Offset: 0x0002A850
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 58479, RefRangeEnd = 58480, XrefRangeStart = 58478, XrefRangeEnd = 58479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Rotate3D(Quaternion rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rotation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_Rotate3D_Public_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002CE RID: 718 RVA: 0x0002C694 File Offset: 0x0002A894
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 58481, RefRangeEnd = 58482, XrefRangeStart = 58480, XrefRangeEnd = 58481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Rotate2D(float rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rotation;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_Rotate2D_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002CF RID: 719 RVA: 0x0002C6D4 File Offset: 0x0002A8D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 58484, RefRangeEnd = 58485, XrefRangeStart = 58482, XrefRangeEnd = 58484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Rotate2D(Quaternion rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rotation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_Rotate2D_Public_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x0002C718 File Offset: 0x0002A918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58485, XrefRangeEnd = 58486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 TransformVector3D(Vector3 vec)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vec);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_TransformVector3D_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x0002C768 File Offset: 0x0002A968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58486, XrefRangeEnd = 58487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 TransformVector2D(Vector2 vec)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vec);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_TransformVector2D_Public_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x0002C7B8 File Offset: 0x0002A9B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58487, XrefRangeEnd = 58492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 TransformNormal3D(Vector3 normal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(normal);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_TransformNormal3D_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x0002C808 File Offset: 0x0002AA08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58492, XrefRangeEnd = 58497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 TransformNormal2D(Vector2 normal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(normal);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_TransformNormal2D_Public_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x0002C858 File Offset: 0x0002AA58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58497, XrefRangeEnd = 58503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 InverseTransformNormal3D(Vector3 normal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(normal);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_InverseTransformNormal3D_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x0002C8A8 File Offset: 0x0002AAA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58503, XrefRangeEnd = 58509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 InverseTransformNormal2D(Vector2 normal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(normal);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_InverseTransformNormal2D_Public_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x0002C8F8 File Offset: 0x0002AAF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58509, XrefRangeEnd = 58510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 TransformPoint3D(Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_TransformPoint3D_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x0002C948 File Offset: 0x0002AB48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58510, XrefRangeEnd = 58511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 TransformPoint2D(Vector2 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_TransformPoint2D_Public_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x0002C998 File Offset: 0x0002AB98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58511, XrefRangeEnd = 58513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 InverseTransformPoint3D(Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_InverseTransformPoint3D_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x0002C9E8 File Offset: 0x0002ABE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58513, XrefRangeEnd = 58515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 InverseTransformPoint2D(Vector2 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_InverseTransformPoint2D_Public_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
		}

		// Token: 0x060002DA RID: 730 RVA: 0x0002CA38 File Offset: 0x0002AC38
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 58517, RefRangeEnd = 58528, XrefRangeStart = 58515, XrefRangeEnd = 58517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AlignAxis3D(int axisIndex, AxisSign axisSign, Vector3 axis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axisIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(axisSign);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(axis);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_AlignAxis3D_Public_Void_Int32_AxisSign_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002DB RID: 731 RVA: 0x0002CA9C File Offset: 0x0002AC9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58528, XrefRangeEnd = 58531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AlignAxis2D(int axisIndex, AxisSign axisSign, Vector2 axis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axisIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(axisSign);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(axis);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_AlignAxis2D_Public_Void_Int32_AxisSign_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002DC RID: 732 RVA: 0x0002CB00 File Offset: 0x0002AD00
		[CallerCount(0)]
		public unsafe bool IsChildOf(GizmoTransform transform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_IsChildOf_Public_Boolean_GizmoTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002DD RID: 733 RVA: 0x0002CB50 File Offset: 0x0002AD50
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 58539, RefRangeEnd = 58545, XrefRangeStart = 58531, XrefRangeEnd = 58539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetParent(GizmoTransform newParent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newParent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_SetParent_Public_Void_GizmoTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002DE RID: 734 RVA: 0x0002CB94 File Offset: 0x0002AD94
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 58546, RefRangeEnd = 58555, XrefRangeStart = 58545, XrefRangeEnd = 58546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetAxis3D(AxisDescriptor axisDesc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(axisDesc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_GetAxis3D_Public_Vector3_AxisDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x060002DF RID: 735 RVA: 0x0002CBE4 File Offset: 0x0002ADE4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 58555, RefRangeEnd = 58562, XrefRangeStart = 58555, XrefRangeEnd = 58555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetAxis3D(int axisIndex, AxisSign axisSign)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_GetAxis3D_Public_Vector3_Int32_AxisSign_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x0002CC44 File Offset: 0x0002AE44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58562, XrefRangeEnd = 58563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetAxis2D(AxisDescriptor axisDesc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(axisDesc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_GetAxis2D_Public_Vector2_AxisDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x0002CC94 File Offset: 0x0002AE94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 58563, RefRangeEnd = 58565, XrefRangeStart = 58563, XrefRangeEnd = 58563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetAxis2D(int axisIndex, AxisSign axisSign)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_GetAxis2D_Public_Vector2_Int32_AxisSign_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x0002CCF4 File Offset: 0x0002AEF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58565, XrefRangeEnd = 58570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<Vector3> GetAxes3D()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_GetAxes3D_Public_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr3) : null;
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x0002CD34 File Offset: 0x0002AF34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58570, XrefRangeEnd = 58575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<Vector2> GetAxes2D()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_GetAxes2D_Public_Il2CppStructArray_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr3) : null;
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x0002CD74 File Offset: 0x0002AF74
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 58584, RefRangeEnd = 58586, XrefRangeStart = 58575, XrefRangeEnd = 58584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Plane GetPlane3D(PlaneId planeId, PlaneQuadrantId planeQuadrantId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(planeId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(planeQuadrantId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_GetPlane3D_Public_Plane_PlaneId_PlaneQuadrantId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Plane>(intPtr3) : null;
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x0002CDD8 File Offset: 0x0002AFD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58586, XrefRangeEnd = 58594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Plane GetPlane3D(PlaneDescriptor planeDesc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(planeDesc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_GetPlane3D_Public_Plane_PlaneDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Plane>(intPtr3) : null;
			}
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x0002CE28 File Offset: 0x0002B028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58594, XrefRangeEnd = 58598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangePosition3D(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(position);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_ChangePosition3D_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x0002CE6C File Offset: 0x0002B06C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58598, XrefRangeEnd = 58602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangePosition2D(Vector2 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(position);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_ChangePosition2D_Private_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x0002CEB0 File Offset: 0x0002B0B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58602, XrefRangeEnd = 58604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeRotation3D(Quaternion rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rotation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_ChangeRotation3D_Private_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x0002CEF4 File Offset: 0x0002B0F4
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 58610, RefRangeEnd = 58624, XrefRangeStart = 58604, XrefRangeEnd = 58610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeRotation2D(float rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rotation;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_ChangeRotation2D_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002EA RID: 746 RVA: 0x0002CF34 File Offset: 0x0002B134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58624, XrefRangeEnd = 58626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeRotation2D(Quaternion rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rotation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_ChangeRotation2D_Private_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002EB RID: 747 RVA: 0x0002CF78 File Offset: 0x0002B178
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58626, XrefRangeEnd = 58629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeLocalPosition3D(Vector3 localPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(localPosition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_ChangeLocalPosition3D_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002EC RID: 748 RVA: 0x0002CFBC File Offset: 0x0002B1BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58629, XrefRangeEnd = 58632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeLocalPosition2D(Vector2 localPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(localPosition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_ChangeLocalPosition2D_Private_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002ED RID: 749 RVA: 0x0002D000 File Offset: 0x0002B200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58632, XrefRangeEnd = 58634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeLocalRotation3D(Quaternion localRotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(localRotation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_ChangeLocalRotation3D_Private_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002EE RID: 750 RVA: 0x0002D044 File Offset: 0x0002B244
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58634, XrefRangeEnd = 58639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeLocalRotation2D(float localRotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref localRotation;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_ChangeLocalRotation2D_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002EF RID: 751 RVA: 0x0002D084 File Offset: 0x0002B284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58639, XrefRangeEnd = 58641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeLocalRotation2D(Quaternion localRotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(localRotation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_ChangeLocalRotation2D_Private_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x0002D0C8 File Offset: 0x0002B2C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 58654, RefRangeEnd = 58655, XrefRangeStart = 58641, XrefRangeEnd = 58654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnParentChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_OnParentChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x0002D0FC File Offset: 0x0002B2FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58655, XrefRangeEnd = 58659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPosition3DChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_OnPosition3DChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x0002D130 File Offset: 0x0002B330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58659, XrefRangeEnd = 58663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPosition2DChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_OnPosition2DChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x0002D164 File Offset: 0x0002B364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58663, XrefRangeEnd = 58666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnLocalPosition3DChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_OnLocalPosition3DChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x0002D198 File Offset: 0x0002B398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58666, XrefRangeEnd = 58668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnLocalPosition2DChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_OnLocalPosition2DChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x0002D1CC File Offset: 0x0002B3CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 58673, RefRangeEnd = 58675, XrefRangeStart = 58668, XrefRangeEnd = 58673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnRotation3DChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_OnRotation3DChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x0002D200 File Offset: 0x0002B400
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 58681, RefRangeEnd = 58683, XrefRangeStart = 58675, XrefRangeEnd = 58681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnRotation2DChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_OnRotation2DChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x0002D234 File Offset: 0x0002B434
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 58687, RefRangeEnd = 58690, XrefRangeStart = 58683, XrefRangeEnd = 58687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnLocalRotation3DChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_OnLocalRotation3DChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x0002D268 File Offset: 0x0002B468
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 58695, RefRangeEnd = 58699, XrefRangeStart = 58690, XrefRangeEnd = 58695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnLocalRotation2DChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_OnLocalRotation2DChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x0002D29C File Offset: 0x0002B49C
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 58718, RefRangeEnd = 58729, XrefRangeStart = 58699, XrefRangeEnd = 58718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateChildTransforms3D()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_UpdateChildTransforms3D_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002FA RID: 762 RVA: 0x0002D2D0 File Offset: 0x0002B4D0
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 58749, RefRangeEnd = 58760, XrefRangeStart = 58729, XrefRangeEnd = 58749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateChildTransforms2D()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_UpdateChildTransforms2D_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002FB RID: 763 RVA: 0x0002D304 File Offset: 0x0002B504
		[CallerCount(0)]
		public unsafe void OnChanged(GizmoTransform.ChangeData changeData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref changeData;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_OnChanged_Private_Void_ChangeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002FC RID: 764 RVA: 0x0002D344 File Offset: 0x0002B544
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 58768, RefRangeEnd = 58772, XrefRangeStart = 58760, XrefRangeEnd = 58768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update3DAxes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_Update3DAxes_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002FD RID: 765 RVA: 0x0002D378 File Offset: 0x0002B578
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 58779, RefRangeEnd = 58783, XrefRangeStart = 58772, XrefRangeEnd = 58779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update2DAxes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.NativeMethodInfoPtr_Update2DAxes_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00002F3D File Offset: 0x0000113D
		public GizmoTransform(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060002FF RID: 767 RVA: 0x0002D3AC File Offset: 0x0002B5AC
		// (set) Token: 0x06000300 RID: 768 RVA: 0x00002F46 File Offset: 0x00001146
		public unsafe GizmoEntityTransformChangedHandler Changed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoTransform.NativeFieldInfoPtr_Changed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoEntityTransformChangedHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoTransform.NativeFieldInfoPtr_Changed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000301 RID: 769 RVA: 0x0002D3DC File Offset: 0x0002B5DC
		// (set) Token: 0x06000302 RID: 770 RVA: 0x00002F65 File Offset: 0x00001165
		public unsafe bool _firingChanged3DEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoTransform.NativeFieldInfoPtr__firingChanged3DEvent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoTransform.NativeFieldInfoPtr__firingChanged3DEvent)) = value;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000303 RID: 771 RVA: 0x0002D404 File Offset: 0x0002B604
		// (set) Token: 0x06000304 RID: 772 RVA: 0x00002F80 File Offset: 0x00001180
		public unsafe bool _firingChanged2DEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoTransform.NativeFieldInfoPtr__firingChanged2DEvent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoTransform.NativeFieldInfoPtr__firingChanged2DEvent)) = value;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000305 RID: 773 RVA: 0x0002D42C File Offset: 0x0002B62C
		// (set) Token: 0x06000306 RID: 774 RVA: 0x00002F9B File Offset: 0x0000119B
		public unsafe Vector3 _position3D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoTransform.NativeFieldInfoPtr__position3D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoTransform.NativeFieldInfoPtr__position3D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000307 RID: 775 RVA: 0x0002D45C File Offset: 0x0002B65C
		// (set) Token: 0x06000308 RID: 776 RVA: 0x00002FBA File Offset: 0x000011BA
		public unsafe Vector3 _localPosition3D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoTransform.NativeFieldInfoPtr__localPosition3D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoTransform.NativeFieldInfoPtr__localPosition3D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000309 RID: 777 RVA: 0x0002D48C File Offset: 0x0002B68C
		// (set) Token: 0x0600030A RID: 778 RVA: 0x00002FD9 File Offset: 0x000011D9
		public unsafe Quaternion _rotation3D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoTransform.NativeFieldInfoPtr__rotation3D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoTransform.NativeFieldInfoPtr__rotation3D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x0600030B RID: 779 RVA: 0x0002D4BC File Offset: 0x0002B6BC
		// (set) Token: 0x0600030C RID: 780 RVA: 0x00002FF8 File Offset: 0x000011F8
		public unsafe Quaternion _localRotation3D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoTransform.NativeFieldInfoPtr__localRotation3D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoTransform.NativeFieldInfoPtr__localRotation3D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x0600030D RID: 781 RVA: 0x0002D4EC File Offset: 0x0002B6EC
		// (set) Token: 0x0600030E RID: 782 RVA: 0x00003017 File Offset: 0x00001217
		public unsafe Vector2 _position2D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoTransform.NativeFieldInfoPtr__position2D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoTransform.NativeFieldInfoPtr__position2D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x0600030F RID: 783 RVA: 0x0002D51C File Offset: 0x0002B71C
		// (set) Token: 0x06000310 RID: 784 RVA: 0x00003036 File Offset: 0x00001236
		public unsafe Vector2 _localPosition2D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoTransform.NativeFieldInfoPtr__localPosition2D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoTransform.NativeFieldInfoPtr__localPosition2D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000311 RID: 785 RVA: 0x0002D54C File Offset: 0x0002B74C
		// (set) Token: 0x06000312 RID: 786 RVA: 0x00003055 File Offset: 0x00001255
		public unsafe float _rotation2DDegrees
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoTransform.NativeFieldInfoPtr__rotation2DDegrees);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoTransform.NativeFieldInfoPtr__rotation2DDegrees)) = value;
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000313 RID: 787 RVA: 0x0002D574 File Offset: 0x0002B774
		// (set) Token: 0x06000314 RID: 788 RVA: 0x00003070 File Offset: 0x00001270
		public unsafe Quaternion _rotation2D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoTransform.NativeFieldInfoPtr__rotation2D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoTransform.NativeFieldInfoPtr__rotation2D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000315 RID: 789 RVA: 0x0002D5A4 File Offset: 0x0002B7A4
		// (set) Token: 0x06000316 RID: 790 RVA: 0x0000308F File Offset: 0x0000128F
		public unsafe float _localRotation2DDegrees
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoTransform.NativeFieldInfoPtr__localRotation2DDegrees);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoTransform.NativeFieldInfoPtr__localRotation2DDegrees)) = value;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000317 RID: 791 RVA: 0x0002D5CC File Offset: 0x0002B7CC
		// (set) Token: 0x06000318 RID: 792 RVA: 0x000030AA File Offset: 0x000012AA
		public unsafe Quaternion _localRotation2D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoTransform.NativeFieldInfoPtr__localRotation2D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoTransform.NativeFieldInfoPtr__localRotation2D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000319 RID: 793 RVA: 0x0002D5FC File Offset: 0x0002B7FC
		// (set) Token: 0x0600031A RID: 794 RVA: 0x000030C9 File Offset: 0x000012C9
		public unsafe Il2CppStructArray<Vector3> _axes3D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoTransform.NativeFieldInfoPtr__axes3D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoTransform.NativeFieldInfoPtr__axes3D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x0600031B RID: 795 RVA: 0x0002D62C File Offset: 0x0002B82C
		// (set) Token: 0x0600031C RID: 796 RVA: 0x000030E8 File Offset: 0x000012E8
		public unsafe Il2CppStructArray<Vector2> _axes2D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoTransform.NativeFieldInfoPtr__axes2D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoTransform.NativeFieldInfoPtr__axes2D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x0600031D RID: 797 RVA: 0x0002D65C File Offset: 0x0002B85C
		// (set) Token: 0x0600031E RID: 798 RVA: 0x00003107 File Offset: 0x00001307
		public unsafe GizmoTransform _parent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoTransform.NativeFieldInfoPtr__parent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoTransform.NativeFieldInfoPtr__parent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x0600031F RID: 799 RVA: 0x0002D68C File Offset: 0x0002B88C
		// (set) Token: 0x06000320 RID: 800 RVA: 0x00003126 File Offset: 0x00001326
		public unsafe List<GizmoTransform> _children
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoTransform.NativeFieldInfoPtr__children);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GizmoTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GizmoTransform.NativeFieldInfoPtr__children), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000238 RID: 568
		private static readonly IntPtr NativeFieldInfoPtr_Changed;

		// Token: 0x04000239 RID: 569
		private static readonly IntPtr NativeFieldInfoPtr__firingChanged3DEvent;

		// Token: 0x0400023A RID: 570
		private static readonly IntPtr NativeFieldInfoPtr__firingChanged2DEvent;

		// Token: 0x0400023B RID: 571
		private static readonly IntPtr NativeFieldInfoPtr__position3D;

		// Token: 0x0400023C RID: 572
		private static readonly IntPtr NativeFieldInfoPtr__localPosition3D;

		// Token: 0x0400023D RID: 573
		private static readonly IntPtr NativeFieldInfoPtr__rotation3D;

		// Token: 0x0400023E RID: 574
		private static readonly IntPtr NativeFieldInfoPtr__localRotation3D;

		// Token: 0x0400023F RID: 575
		private static readonly IntPtr NativeFieldInfoPtr__position2D;

		// Token: 0x04000240 RID: 576
		private static readonly IntPtr NativeFieldInfoPtr__localPosition2D;

		// Token: 0x04000241 RID: 577
		private static readonly IntPtr NativeFieldInfoPtr__rotation2DDegrees;

		// Token: 0x04000242 RID: 578
		private static readonly IntPtr NativeFieldInfoPtr__rotation2D;

		// Token: 0x04000243 RID: 579
		private static readonly IntPtr NativeFieldInfoPtr__localRotation2DDegrees;

		// Token: 0x04000244 RID: 580
		private static readonly IntPtr NativeFieldInfoPtr__localRotation2D;

		// Token: 0x04000245 RID: 581
		private static readonly IntPtr NativeFieldInfoPtr__axes3D;

		// Token: 0x04000246 RID: 582
		private static readonly IntPtr NativeFieldInfoPtr__axes2D;

		// Token: 0x04000247 RID: 583
		private static readonly IntPtr NativeFieldInfoPtr__parent;

		// Token: 0x04000248 RID: 584
		private static readonly IntPtr NativeFieldInfoPtr__children;

		// Token: 0x04000249 RID: 585
		private static readonly IntPtr NativeMethodInfoPtr_get_CanChange3D_Public_get_Boolean_0;

		// Token: 0x0400024A RID: 586
		private static readonly IntPtr NativeMethodInfoPtr_get_CanChange2D_Public_get_Boolean_0;

		// Token: 0x0400024B RID: 587
		private static readonly IntPtr NativeMethodInfoPtr_get_Parent_Public_get_GizmoTransform_0;

		// Token: 0x0400024C RID: 588
		private static readonly IntPtr NativeMethodInfoPtr_get_NumChildren_Public_get_Int32_0;

		// Token: 0x0400024D RID: 589
		private static readonly IntPtr NativeMethodInfoPtr_get_Children_Public_get_List_1_GizmoTransform_0;

		// Token: 0x0400024E RID: 590
		private static readonly IntPtr NativeMethodInfoPtr_get_Right3D_Public_get_Vector3_0;

		// Token: 0x0400024F RID: 591
		private static readonly IntPtr NativeMethodInfoPtr_get_Up3D_Public_get_Vector3_0;

		// Token: 0x04000250 RID: 592
		private static readonly IntPtr NativeMethodInfoPtr_get_Look3D_Public_get_Vector3_0;

		// Token: 0x04000251 RID: 593
		private static readonly IntPtr NativeMethodInfoPtr_get_Right2D_Public_get_Vector2_0;

		// Token: 0x04000252 RID: 594
		private static readonly IntPtr NativeMethodInfoPtr_get_Up2D_Public_get_Vector2_0;

		// Token: 0x04000253 RID: 595
		private static readonly IntPtr NativeMethodInfoPtr_get_Position3D_Public_get_Vector3_0;

		// Token: 0x04000254 RID: 596
		private static readonly IntPtr NativeMethodInfoPtr_set_Position3D_Public_set_Void_Vector3_0;

		// Token: 0x04000255 RID: 597
		private static readonly IntPtr NativeMethodInfoPtr_get_Position2D_Public_get_Vector2_0;

		// Token: 0x04000256 RID: 598
		private static readonly IntPtr NativeMethodInfoPtr_set_Position2D_Public_set_Void_Vector2_0;

		// Token: 0x04000257 RID: 599
		private static readonly IntPtr NativeMethodInfoPtr_get_Rotation3D_Public_get_Quaternion_0;

		// Token: 0x04000258 RID: 600
		private static readonly IntPtr NativeMethodInfoPtr_set_Rotation3D_Public_set_Void_Quaternion_0;

		// Token: 0x04000259 RID: 601
		private static readonly IntPtr NativeMethodInfoPtr_get_Rotation2D_Public_get_Quaternion_0;

		// Token: 0x0400025A RID: 602
		private static readonly IntPtr NativeMethodInfoPtr_get_Rotation2DDegrees_Public_get_Single_0;

		// Token: 0x0400025B RID: 603
		private static readonly IntPtr NativeMethodInfoPtr_set_Rotation2DDegrees_Public_set_Void_Single_0;

		// Token: 0x0400025C RID: 604
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalPosition3D_Public_get_Vector3_0;

		// Token: 0x0400025D RID: 605
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalPosition3D_Public_set_Void_Vector3_0;

		// Token: 0x0400025E RID: 606
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalPosition2D_Public_get_Vector2_0;

		// Token: 0x0400025F RID: 607
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalPosition2D_Public_set_Void_Vector2_0;

		// Token: 0x04000260 RID: 608
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalRotation3D_Public_get_Quaternion_0;

		// Token: 0x04000261 RID: 609
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalRotation3D_Public_set_Void_Quaternion_0;

		// Token: 0x04000262 RID: 610
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalRotation2D_Public_get_Quaternion_0;

		// Token: 0x04000263 RID: 611
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalRotation2DDegrees_Public_get_Single_0;

		// Token: 0x04000264 RID: 612
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalRotation2DDegrees_Public_set_Void_Single_0;

		// Token: 0x04000265 RID: 613
		private static readonly IntPtr NativeMethodInfoPtr_add_Changed_Public_add_Void_GizmoEntityTransformChangedHandler_0;

		// Token: 0x04000266 RID: 614
		private static readonly IntPtr NativeMethodInfoPtr_remove_Changed_Public_rem_Void_GizmoEntityTransformChangedHandler_0;

		// Token: 0x04000267 RID: 615
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000268 RID: 616
		private static readonly IntPtr NativeMethodInfoPtr_FilterParentsOnly_Public_Static_List_1_GizmoTransform_IEnumerable_1_GizmoTransform_0;

		// Token: 0x04000269 RID: 617
		private static readonly IntPtr NativeMethodInfoPtr_Get3DQuadrantFacingCamera_Public_PlaneQuadrantId_PlaneId_Camera_0;

		// Token: 0x0400026A RID: 618
		private static readonly IntPtr NativeMethodInfoPtr_Rotate3D_Public_Void_Quaternion_0;

		// Token: 0x0400026B RID: 619
		private static readonly IntPtr NativeMethodInfoPtr_Rotate2D_Public_Void_Single_0;

		// Token: 0x0400026C RID: 620
		private static readonly IntPtr NativeMethodInfoPtr_Rotate2D_Public_Void_Quaternion_0;

		// Token: 0x0400026D RID: 621
		private static readonly IntPtr NativeMethodInfoPtr_TransformVector3D_Public_Vector3_Vector3_0;

		// Token: 0x0400026E RID: 622
		private static readonly IntPtr NativeMethodInfoPtr_TransformVector2D_Public_Vector2_Vector2_0;

		// Token: 0x0400026F RID: 623
		private static readonly IntPtr NativeMethodInfoPtr_TransformNormal3D_Public_Vector3_Vector3_0;

		// Token: 0x04000270 RID: 624
		private static readonly IntPtr NativeMethodInfoPtr_TransformNormal2D_Public_Vector2_Vector2_0;

		// Token: 0x04000271 RID: 625
		private static readonly IntPtr NativeMethodInfoPtr_InverseTransformNormal3D_Public_Vector3_Vector3_0;

		// Token: 0x04000272 RID: 626
		private static readonly IntPtr NativeMethodInfoPtr_InverseTransformNormal2D_Public_Vector2_Vector2_0;

		// Token: 0x04000273 RID: 627
		private static readonly IntPtr NativeMethodInfoPtr_TransformPoint3D_Public_Vector3_Vector3_0;

		// Token: 0x04000274 RID: 628
		private static readonly IntPtr NativeMethodInfoPtr_TransformPoint2D_Public_Vector2_Vector2_0;

		// Token: 0x04000275 RID: 629
		private static readonly IntPtr NativeMethodInfoPtr_InverseTransformPoint3D_Public_Vector3_Vector3_0;

		// Token: 0x04000276 RID: 630
		private static readonly IntPtr NativeMethodInfoPtr_InverseTransformPoint2D_Public_Vector2_Vector2_0;

		// Token: 0x04000277 RID: 631
		private static readonly IntPtr NativeMethodInfoPtr_AlignAxis3D_Public_Void_Int32_AxisSign_Vector3_0;

		// Token: 0x04000278 RID: 632
		private static readonly IntPtr NativeMethodInfoPtr_AlignAxis2D_Public_Void_Int32_AxisSign_Vector2_0;

		// Token: 0x04000279 RID: 633
		private static readonly IntPtr NativeMethodInfoPtr_IsChildOf_Public_Boolean_GizmoTransform_0;

		// Token: 0x0400027A RID: 634
		private static readonly IntPtr NativeMethodInfoPtr_SetParent_Public_Void_GizmoTransform_0;

		// Token: 0x0400027B RID: 635
		private static readonly IntPtr NativeMethodInfoPtr_GetAxis3D_Public_Vector3_AxisDescriptor_0;

		// Token: 0x0400027C RID: 636
		private static readonly IntPtr NativeMethodInfoPtr_GetAxis3D_Public_Vector3_Int32_AxisSign_0;

		// Token: 0x0400027D RID: 637
		private static readonly IntPtr NativeMethodInfoPtr_GetAxis2D_Public_Vector2_AxisDescriptor_0;

		// Token: 0x0400027E RID: 638
		private static readonly IntPtr NativeMethodInfoPtr_GetAxis2D_Public_Vector2_Int32_AxisSign_0;

		// Token: 0x0400027F RID: 639
		private static readonly IntPtr NativeMethodInfoPtr_GetAxes3D_Public_Il2CppStructArray_1_Vector3_0;

		// Token: 0x04000280 RID: 640
		private static readonly IntPtr NativeMethodInfoPtr_GetAxes2D_Public_Il2CppStructArray_1_Vector2_0;

		// Token: 0x04000281 RID: 641
		private static readonly IntPtr NativeMethodInfoPtr_GetPlane3D_Public_Plane_PlaneId_PlaneQuadrantId_0;

		// Token: 0x04000282 RID: 642
		private static readonly IntPtr NativeMethodInfoPtr_GetPlane3D_Public_Plane_PlaneDescriptor_0;

		// Token: 0x04000283 RID: 643
		private static readonly IntPtr NativeMethodInfoPtr_ChangePosition3D_Private_Void_Vector3_0;

		// Token: 0x04000284 RID: 644
		private static readonly IntPtr NativeMethodInfoPtr_ChangePosition2D_Private_Void_Vector2_0;

		// Token: 0x04000285 RID: 645
		private static readonly IntPtr NativeMethodInfoPtr_ChangeRotation3D_Private_Void_Quaternion_0;

		// Token: 0x04000286 RID: 646
		private static readonly IntPtr NativeMethodInfoPtr_ChangeRotation2D_Private_Void_Single_0;

		// Token: 0x04000287 RID: 647
		private static readonly IntPtr NativeMethodInfoPtr_ChangeRotation2D_Private_Void_Quaternion_0;

		// Token: 0x04000288 RID: 648
		private static readonly IntPtr NativeMethodInfoPtr_ChangeLocalPosition3D_Private_Void_Vector3_0;

		// Token: 0x04000289 RID: 649
		private static readonly IntPtr NativeMethodInfoPtr_ChangeLocalPosition2D_Private_Void_Vector2_0;

		// Token: 0x0400028A RID: 650
		private static readonly IntPtr NativeMethodInfoPtr_ChangeLocalRotation3D_Private_Void_Quaternion_0;

		// Token: 0x0400028B RID: 651
		private static readonly IntPtr NativeMethodInfoPtr_ChangeLocalRotation2D_Private_Void_Single_0;

		// Token: 0x0400028C RID: 652
		private static readonly IntPtr NativeMethodInfoPtr_ChangeLocalRotation2D_Private_Void_Quaternion_0;

		// Token: 0x0400028D RID: 653
		private static readonly IntPtr NativeMethodInfoPtr_OnParentChanged_Private_Void_0;

		// Token: 0x0400028E RID: 654
		private static readonly IntPtr NativeMethodInfoPtr_OnPosition3DChanged_Private_Void_0;

		// Token: 0x0400028F RID: 655
		private static readonly IntPtr NativeMethodInfoPtr_OnPosition2DChanged_Private_Void_0;

		// Token: 0x04000290 RID: 656
		private static readonly IntPtr NativeMethodInfoPtr_OnLocalPosition3DChanged_Private_Void_0;

		// Token: 0x04000291 RID: 657
		private static readonly IntPtr NativeMethodInfoPtr_OnLocalPosition2DChanged_Private_Void_0;

		// Token: 0x04000292 RID: 658
		private static readonly IntPtr NativeMethodInfoPtr_OnRotation3DChanged_Private_Void_0;

		// Token: 0x04000293 RID: 659
		private static readonly IntPtr NativeMethodInfoPtr_OnRotation2DChanged_Private_Void_0;

		// Token: 0x04000294 RID: 660
		private static readonly IntPtr NativeMethodInfoPtr_OnLocalRotation3DChanged_Private_Void_0;

		// Token: 0x04000295 RID: 661
		private static readonly IntPtr NativeMethodInfoPtr_OnLocalRotation2DChanged_Private_Void_0;

		// Token: 0x04000296 RID: 662
		private static readonly IntPtr NativeMethodInfoPtr_UpdateChildTransforms3D_Private_Void_0;

		// Token: 0x04000297 RID: 663
		private static readonly IntPtr NativeMethodInfoPtr_UpdateChildTransforms2D_Private_Void_0;

		// Token: 0x04000298 RID: 664
		private static readonly IntPtr NativeMethodInfoPtr_OnChanged_Private_Void_ChangeData_0;

		// Token: 0x04000299 RID: 665
		private static readonly IntPtr NativeMethodInfoPtr_Update3DAxes_Private_Void_0;

		// Token: 0x0400029A RID: 666
		private static readonly IntPtr NativeMethodInfoPtr_Update2DAxes_Private_Void_0;

		// Token: 0x0200034F RID: 847
		public enum ChangeReason
		{
			// Token: 0x040038DF RID: 14559
			TRSChange,
			// Token: 0x040038E0 RID: 14560
			ParentChange
		}

		// Token: 0x02000350 RID: 848
		[StructLayout(2)]
		public struct ChangeData
		{
			// Token: 0x0600497C RID: 18812 RVA: 0x00144990 File Offset: 0x00142B90
			// Note: this type is marked as 'beforefieldinit'.
			static ChangeData()
			{
				Il2CppClassPointerStore<GizmoTransform.ChangeData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GizmoTransform>.NativeClassPtr, "ChangeData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GizmoTransform.ChangeData>.NativeClassPtr);
				GizmoTransform.ChangeData.NativeFieldInfoPtr_ChangeReason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoTransform.ChangeData>.NativeClassPtr, "ChangeReason");
				GizmoTransform.ChangeData.NativeFieldInfoPtr_TRSDimension = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GizmoTransform.ChangeData>.NativeClassPtr, "TRSDimension");
				GizmoTransform.ChangeData.NativeMethodInfoPtr__ctor_Public_Void_ChangeReason_GizmoDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GizmoTransform.ChangeData>.NativeClassPtr, 100663770);
			}

			// Token: 0x0600497D RID: 18813 RVA: 0x001449F8 File Offset: 0x00142BF8
			[CallerCount(46)]
			[CachedScanResults(RefRangeStart = 58214, RefRangeEnd = 58260, XrefRangeStart = 58214, XrefRangeEnd = 58214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ChangeData(GizmoTransform.ChangeReason changeReason, GizmoDimension trsDimension)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref changeReason;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(trsDimension);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GizmoTransform.ChangeData.NativeMethodInfoPtr__ctor_Public_Void_ChangeReason_GizmoDimension_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600497E RID: 18814 RVA: 0x0001B501 File Offset: 0x00019701
			public global::Il2CppSystem.Object BoxIl2CppObject()
			{
				return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GizmoTransform.ChangeData>.NativeClassPtr, ref this));
			}

			// Token: 0x040038E1 RID: 14561
			private static readonly IntPtr NativeFieldInfoPtr_ChangeReason;

			// Token: 0x040038E2 RID: 14562
			private static readonly IntPtr NativeFieldInfoPtr_TRSDimension;

			// Token: 0x040038E3 RID: 14563
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ChangeReason_GizmoDimension_0;

			// Token: 0x040038E4 RID: 14564
			[FieldOffset(0)]
			public GizmoTransform.ChangeReason ChangeReason;

			// Token: 0x040038E5 RID: 14565
			[FieldOffset(4)]
			public IntPtr TRSDimension;
		}
	}
}
