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
	// Token: 0x020000E0 RID: 224
	[Serializable]
	public class ObjectTransformGizmo : GizmoBehaviour
	{
		// Token: 0x060012F3 RID: 4851 RVA: 0x00068FA0 File Offset: 0x000671A0
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectTransformGizmo()
		{
			Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "ObjectTransformGizmo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr);
			ObjectTransformGizmo.NativeFieldInfoPtr__targetObjectMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr, "_targetObjectMode");
			ObjectTransformGizmo.NativeFieldInfoPtr__transformChannelFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr, "_transformChannelFlags");
			ObjectTransformGizmo.NativeFieldInfoPtr__targetObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr, "_targetObjects");
			ObjectTransformGizmo.NativeFieldInfoPtr__targetPivotObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr, "_targetPivotObject");
			ObjectTransformGizmo.NativeFieldInfoPtr__preTransformSnapshots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr, "_preTransformSnapshots");
			ObjectTransformGizmo.NativeFieldInfoPtr__transformableParents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr, "_transformableParents");
			ObjectTransformGizmo.NativeFieldInfoPtr__targetGroupAABBOnDragBegin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr, "_targetGroupAABBOnDragBegin");
			ObjectTransformGizmo.NativeFieldInfoPtr__transformSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr, "_transformSpace");
			ObjectTransformGizmo.NativeFieldInfoPtr__isTransformSpacePermanent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr, "_isTransformSpacePermanent");
			ObjectTransformGizmo.NativeFieldInfoPtr__transformPivot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr, "_transformPivot");
			ObjectTransformGizmo.NativeFieldInfoPtr__isTransformPivotPermanent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr, "_isTransformPivotPermanent");
			ObjectTransformGizmo.NativeFieldInfoPtr__scaleConstraintEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr, "_scaleConstraintEnabled");
			ObjectTransformGizmo.NativeFieldInfoPtr__minPositiveScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr, "_minPositiveScale");
			ObjectTransformGizmo.NativeFieldInfoPtr__customWorldPivot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr, "_customWorldPivot");
			ObjectTransformGizmo.NativeFieldInfoPtr__objectToCustomLocalPivot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr, "_objectToCustomLocalPivot");
			ObjectTransformGizmo.NativeFieldInfoPtr__objectToRestrictions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr, "_objectToRestrictions");
			ObjectTransformGizmo.NativeFieldInfoPtr__settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr, "_settings");
			ObjectTransformGizmo.NativeFieldInfoPtr__sharedSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr, "_sharedSettings");
			ObjectTransformGizmo.NativeMethodInfoPtr_get_TransformPivot_Public_get_GizmoObjectTransformPivot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr, 100665945);
			ObjectTransformGizmo.NativeMethodInfoPtr_get_IsTransformPivotPermanent_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr, 100665946);
			ObjectTransformGizmo.NativeMethodInfoPtr_get_TransformSpace_Public_get_GizmoSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr, 100665947);
			ObjectTransformGizmo.NativeMethodInfoPtr_get_IsTransformSpacePermanent_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr, 100665948);
			ObjectTransformGizmo.NativeMethodInfoPtr_get_TransformChannelFlags_Public_get_Channels_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr, 100665949);
			ObjectTransformGizmo.NativeMethodInfoPtr_get_CanAffectPosition_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr, 100665950);
			ObjectTransformGizmo.NativeMethodInfoPtr_get_CanAffectRotation_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr, 100665951);
			ObjectTransformGizmo.NativeMethodInfoPtr_get_CanAffectScale_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr, 100665952);
			ObjectTransformGizmo.NativeMethodInfoPtr_get_CustomWorldPivot_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr, 100665953);
			ObjectTransformGizmo.NativeMethodInfoPtr_get_Settings_Public_get_ObjectTransformGizmoSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr, 100665954);
			ObjectTransformGizmo.NativeMethodInfoPtr_get_SharedSettings_Public_get_ObjectTransformGizmoSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr, 100665955);
			ObjectTransformGizmo.NativeMethodInfoPtr_set_SharedSettings_Public_set_Void_ObjectTransformGizmoSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr, 100665956);
			ObjectTransformGizmo.NativeMethodInfoPtr_get_ScaleConstraintEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr, 100665957);
			ObjectTransformGizmo.NativeMethodInfoPtr_set_ScaleConstraintEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr, 100665958);
			ObjectTransformGizmo.NativeMethodInfoPtr_get_MinPositiveScale_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr, 100665959);
			ObjectTransformGizmo.NativeMethodInfoPtr_set_MinPositiveScale_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr, 100665960);
			ObjectTransformGizmo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr, 100665999);
			ObjectTransformGizmo.NativeMethodInfoPtr_OnAttached_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr, 100665961);
			ObjectTransformGizmo.NativeMethodInfoPtr_OnDetached_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr, 100665962);
			ObjectTransformGizmo.NativeMethodInfoPtr_MakeTransformSpacePermanent_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr, 100665963);
			ObjectTransformGizmo.NativeMethodInfoPtr_MakeTransformPivotPermanent_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr, 100665964);
			ObjectTransformGizmo.NativeMethodInfoPtr_ContainsRestrictionsForObject_Public_Boolean_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr, 100665965);
			ObjectTransformGizmo.NativeMethodInfoPtr_RegisterObjectRestrictions_Public_Void_GameObject_ObjectRestrictions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr, 100665966);
			ObjectTransformGizmo.NativeMethodInfoPtr_RegisterObjectRestrictions_Public_Void_List_1_GameObject_ObjectRestrictions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr, 100665967);
			ObjectTransformGizmo.NativeMethodInfoPtr_UnregisterObjectRestrictions_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr, 100665968);
			ObjectTransformGizmo.NativeMethodInfoPtr_GetObjectRestrictions_Public_ObjectRestrictions_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr, 100665969);
			ObjectTransformGizmo.NativeMethodInfoPtr_SetTransformChannelFlags_Public_Void_Channels_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr, 100665970);
			ObjectTransformGizmo.NativeMethodInfoPtr_SetCanAffectPosition_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr, 100665971);
			ObjectTransformGizmo.NativeMethodInfoPtr_SetCanAffectRotation_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr, 100665972);
			ObjectTransformGizmo.NativeMethodInfoPtr_SetCanAffectScale_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr, 100665973);
			ObjectTransformGizmo.NativeMethodInfoPtr_SetTargetPivotObject_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr, 100665974);
			ObjectTransformGizmo.NativeMethodInfoPtr_SetTargetObjects_Public_Void_IEnumerable_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr, 100665975);
			ObjectTransformGizmo.NativeMethodInfoPtr_SetTargetObject_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr, 100665976);
			ObjectTransformGizmo.NativeMethodInfoPtr_SetTransformPivot_Public_Void_GizmoObjectTransformPivot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr, 100665977);
			ObjectTransformGizmo.NativeMethodInfoPtr_SetCustomWorldPivot_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr, 100665978);
			ObjectTransformGizmo.NativeMethodInfoPtr_SetObjectCustomLocalPivot_Public_Void_GameObject_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr, 100665979);
			ObjectTransformGizmo.NativeMethodInfoPtr_GetObjectCustomLocalPivot_Public_Vector3_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr, 100665980);
			ObjectTransformGizmo.NativeMethodInfoPtr_SetTransformSpace_Public_Void_GizmoSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr, 100665981);
			ObjectTransformGizmo.NativeMethodInfoPtr_GetTargetObjectGroupWorldAABB_Public_AABB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr, 100665982);
			ObjectTransformGizmo.NativeMethodInfoPtr_GetNumTransformableParentObjects_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr, 100665983);
			ObjectTransformGizmo.NativeMethodInfoPtr_RefreshPosition_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr, 100665984);
			ObjectTransformGizmo.NativeMethodInfoPtr_RefreshRotation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr, 100665985);
			ObjectTransformGizmo.NativeMethodInfoPtr_RefreshPositionAndRotation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr, 100665986);
			ObjectTransformGizmo.NativeMethodInfoPtr_OnGizmoDragBegin_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr, 100665987);
			ObjectTransformGizmo.NativeMethodInfoPtr_OnGizmoDragUpdate_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr, 100665988);
			ObjectTransformGizmo.NativeMethodInfoPtr_OnGizmoDragEnd_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr, 100665989);
			ObjectTransformGizmo.NativeMethodInfoPtr_GetTransformableParentObjects_Private_List_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr, 100665990);
			ObjectTransformGizmo.NativeMethodInfoPtr_OnUndoRedoEnd_Private_Void_IUndoRedoAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr, 100665991);
			ObjectTransformGizmo.NativeMethodInfoPtr_MoveObjects_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr, 100665992);
			ObjectTransformGizmo.NativeMethodInfoPtr_MoveObject_Private_Void_GameObject_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr, 100665993);
			ObjectTransformGizmo.NativeMethodInfoPtr_RotateObjects_Private_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr, 100665994);
			ObjectTransformGizmo.NativeMethodInfoPtr_RotateObject_Private_Void_GameObject_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr, 100665995);
			ObjectTransformGizmo.NativeMethodInfoPtr_ScaleObjects_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr, 100665996);
			ObjectTransformGizmo.NativeMethodInfoPtr_ScaleObject_Private_Void_GameObject_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr, 100665997);
			ObjectTransformGizmo.NativeMethodInfoPtr_GetObjectBoundsQConfig_Private_QueryConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr, 100665998);
		}

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x060012F4 RID: 4852 RVA: 0x00069584 File Offset: 0x00067784
		public unsafe GizmoObjectTransformPivot TransformPivot
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70573, RefRangeEnd = 70574, XrefRangeStart = 70573, XrefRangeEnd = 70573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectTransformGizmo.NativeMethodInfoPtr_get_TransformPivot_Public_get_GizmoObjectTransformPivot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoObjectTransformPivot>(intPtr3) : null;
			}
		}

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x060012F5 RID: 4853 RVA: 0x000695C4 File Offset: 0x000677C4
		public unsafe bool IsTransformPivotPermanent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectTransformGizmo.NativeMethodInfoPtr_get_IsTransformPivotPermanent_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x060012F6 RID: 4854 RVA: 0x00069600 File Offset: 0x00067800
		public unsafe GizmoSpace TransformSpace
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectTransformGizmo.NativeMethodInfoPtr_get_TransformSpace_Public_get_GizmoSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoSpace>(intPtr3) : null;
			}
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x060012F7 RID: 4855 RVA: 0x00069640 File Offset: 0x00067840
		public unsafe bool IsTransformSpacePermanent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectTransformGizmo.NativeMethodInfoPtr_get_IsTransformSpacePermanent_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x060012F8 RID: 4856 RVA: 0x0006967C File Offset: 0x0006787C
		public unsafe ObjectTransformGizmo.Channels TransformChannelFlags
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectTransformGizmo.NativeMethodInfoPtr_get_TransformChannelFlags_Public_get_Channels_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x060012F9 RID: 4857 RVA: 0x000696B8 File Offset: 0x000678B8
		public unsafe bool CanAffectPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectTransformGizmo.NativeMethodInfoPtr_get_CanAffectPosition_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x060012FA RID: 4858 RVA: 0x000696F4 File Offset: 0x000678F4
		public unsafe bool CanAffectRotation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectTransformGizmo.NativeMethodInfoPtr_get_CanAffectRotation_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x060012FB RID: 4859 RVA: 0x00069730 File Offset: 0x00067930
		public unsafe bool CanAffectScale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectTransformGizmo.NativeMethodInfoPtr_get_CanAffectScale_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x060012FC RID: 4860 RVA: 0x0006976C File Offset: 0x0006796C
		public unsafe Vector3 CustomWorldPivot
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectTransformGizmo.NativeMethodInfoPtr_get_CustomWorldPivot_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x060012FD RID: 4861 RVA: 0x000697AC File Offset: 0x000679AC
		public unsafe ObjectTransformGizmoSettings Settings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectTransformGizmo.NativeMethodInfoPtr_get_Settings_Public_get_ObjectTransformGizmoSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectTransformGizmoSettings>(intPtr3) : null;
			}
		}

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x060012FE RID: 4862 RVA: 0x000697EC File Offset: 0x000679EC
		// (set) Token: 0x060012FF RID: 4863 RVA: 0x0006982C File Offset: 0x00067A2C
		public unsafe ObjectTransformGizmoSettings SharedSettings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectTransformGizmo.NativeMethodInfoPtr_get_SharedSettings_Public_get_ObjectTransformGizmoSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectTransformGizmoSettings>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectTransformGizmo.NativeMethodInfoPtr_set_SharedSettings_Public_set_Void_ObjectTransformGizmoSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x06001300 RID: 4864 RVA: 0x00069870 File Offset: 0x00067A70
		// (set) Token: 0x06001301 RID: 4865 RVA: 0x000698AC File Offset: 0x00067AAC
		public unsafe bool ScaleConstraintEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectTransformGizmo.NativeMethodInfoPtr_get_ScaleConstraintEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectTransformGizmo.NativeMethodInfoPtr_set_ScaleConstraintEnabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x06001302 RID: 4866 RVA: 0x000698EC File Offset: 0x00067AEC
		// (set) Token: 0x06001303 RID: 4867 RVA: 0x0006992C File Offset: 0x00067B2C
		public unsafe Vector3 MinPositiveScale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectTransformGizmo.NativeMethodInfoPtr_get_MinPositiveScale_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70574, XrefRangeEnd = 70575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectTransformGizmo.NativeMethodInfoPtr_set_MinPositiveScale_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001304 RID: 4868 RVA: 0x00069970 File Offset: 0x00067B70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70575, XrefRangeEnd = 70603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectTransformGizmo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectTransformGizmo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001305 RID: 4869 RVA: 0x000699AC File Offset: 0x00067BAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70603, XrefRangeEnd = 70625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnAttached()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectTransformGizmo.NativeMethodInfoPtr_OnAttached_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001306 RID: 4870 RVA: 0x000699E8 File Offset: 0x00067BE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70625, XrefRangeEnd = 70647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDetached()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectTransformGizmo.NativeMethodInfoPtr_OnDetached_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001307 RID: 4871 RVA: 0x00069A24 File Offset: 0x00067C24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 70647, RefRangeEnd = 70648, XrefRangeStart = 70647, XrefRangeEnd = 70647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MakeTransformSpacePermanent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectTransformGizmo.NativeMethodInfoPtr_MakeTransformSpacePermanent_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001308 RID: 4872 RVA: 0x00069A58 File Offset: 0x00067C58
		[CallerCount(0)]
		public unsafe void MakeTransformPivotPermanent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectTransformGizmo.NativeMethodInfoPtr_MakeTransformPivotPermanent_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001309 RID: 4873 RVA: 0x00069A8C File Offset: 0x00067C8C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 70653, RefRangeEnd = 70657, XrefRangeStart = 70648, XrefRangeEnd = 70653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ContainsRestrictionsForObject(GameObject targetObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectTransformGizmo.NativeMethodInfoPtr_ContainsRestrictionsForObject_Public_Boolean_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600130A RID: 4874 RVA: 0x00069ADC File Offset: 0x00067CDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70657, XrefRangeEnd = 70661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterObjectRestrictions(GameObject targetObject, ObjectTransformGizmo.ObjectRestrictions restrictions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(restrictions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectTransformGizmo.NativeMethodInfoPtr_RegisterObjectRestrictions_Public_Void_GameObject_ObjectRestrictions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600130B RID: 4875 RVA: 0x00069B30 File Offset: 0x00067D30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70661, XrefRangeEnd = 70679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterObjectRestrictions(List<GameObject> targetObjects, ObjectTransformGizmo.ObjectRestrictions restrictions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetObjects);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(restrictions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectTransformGizmo.NativeMethodInfoPtr_RegisterObjectRestrictions_Public_Void_List_1_GameObject_ObjectRestrictions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600130C RID: 4876 RVA: 0x00069B84 File Offset: 0x00067D84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70679, XrefRangeEnd = 70683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnregisterObjectRestrictions(GameObject targetObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectTransformGizmo.NativeMethodInfoPtr_UnregisterObjectRestrictions_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600130D RID: 4877 RVA: 0x00069BC8 File Offset: 0x00067DC8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 70685, RefRangeEnd = 70688, XrefRangeStart = 70683, XrefRangeEnd = 70685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectTransformGizmo.ObjectRestrictions GetObjectRestrictions(GameObject targetObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectTransformGizmo.NativeMethodInfoPtr_GetObjectRestrictions_Public_ObjectRestrictions_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectTransformGizmo.ObjectRestrictions>(intPtr3) : null;
			}
		}

		// Token: 0x0600130E RID: 4878 RVA: 0x00069C18 File Offset: 0x00067E18
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 70689, RefRangeEnd = 70693, XrefRangeStart = 70688, XrefRangeEnd = 70689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTransformChannelFlags(ObjectTransformGizmo.Channels flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectTransformGizmo.NativeMethodInfoPtr_SetTransformChannelFlags_Public_Void_Channels_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600130F RID: 4879 RVA: 0x00069C58 File Offset: 0x00067E58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70693, XrefRangeEnd = 70694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCanAffectPosition(bool affectPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref affectPosition;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectTransformGizmo.NativeMethodInfoPtr_SetCanAffectPosition_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001310 RID: 4880 RVA: 0x00069C98 File Offset: 0x00067E98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70694, XrefRangeEnd = 70695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCanAffectRotation(bool affectRotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref affectRotation;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectTransformGizmo.NativeMethodInfoPtr_SetCanAffectRotation_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001311 RID: 4881 RVA: 0x00069CD8 File Offset: 0x00067ED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70695, XrefRangeEnd = 70696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCanAffectScale(bool affectScale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref affectScale;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectTransformGizmo.NativeMethodInfoPtr_SetCanAffectScale_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001312 RID: 4882 RVA: 0x00069D18 File Offset: 0x00067F18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 70700, RefRangeEnd = 70701, XrefRangeStart = 70696, XrefRangeEnd = 70700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTargetPivotObject(GameObject targetPivotObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetPivotObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectTransformGizmo.NativeMethodInfoPtr_SetTargetPivotObject_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001313 RID: 4883 RVA: 0x00069D5C File Offset: 0x00067F5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 70705, RefRangeEnd = 70706, XrefRangeStart = 70701, XrefRangeEnd = 70705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTargetObjects(IEnumerable<GameObject> targetObjects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetObjects);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectTransformGizmo.NativeMethodInfoPtr_SetTargetObjects_Public_Void_IEnumerable_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001314 RID: 4884 RVA: 0x00069DA0 File Offset: 0x00067FA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70706, XrefRangeEnd = 70720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTargetObject(GameObject targetObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectTransformGizmo.NativeMethodInfoPtr_SetTargetObject_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001315 RID: 4885 RVA: 0x00069DE4 File Offset: 0x00067FE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 70722, RefRangeEnd = 70723, XrefRangeStart = 70720, XrefRangeEnd = 70722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTransformPivot(GizmoObjectTransformPivot transformPivot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transformPivot);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectTransformGizmo.NativeMethodInfoPtr_SetTransformPivot_Public_Void_GizmoObjectTransformPivot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001316 RID: 4886 RVA: 0x00069E28 File Offset: 0x00068028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70723, XrefRangeEnd = 70725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCustomWorldPivot(Vector3 pivot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pivot);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectTransformGizmo.NativeMethodInfoPtr_SetCustomWorldPivot_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001317 RID: 4887 RVA: 0x00069E6C File Offset: 0x0006806C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70725, XrefRangeEnd = 70741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetObjectCustomLocalPivot(GameObject gameObj, Vector3 pivot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pivot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectTransformGizmo.NativeMethodInfoPtr_SetObjectCustomLocalPivot_Public_Void_GameObject_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001318 RID: 4888 RVA: 0x00069EC0 File Offset: 0x000680C0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 70758, RefRangeEnd = 70761, XrefRangeStart = 70741, XrefRangeEnd = 70758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetObjectCustomLocalPivot(GameObject gameObj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectTransformGizmo.NativeMethodInfoPtr_GetObjectCustomLocalPivot_Public_Vector3_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x06001319 RID: 4889 RVA: 0x00069F10 File Offset: 0x00068110
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 70763, RefRangeEnd = 70765, XrefRangeStart = 70761, XrefRangeEnd = 70763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTransformSpace(GizmoSpace transformSpace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transformSpace);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectTransformGizmo.NativeMethodInfoPtr_SetTransformSpace_Public_Void_GizmoSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600131A RID: 4890 RVA: 0x00069F54 File Offset: 0x00068154
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 70794, RefRangeEnd = 70797, XrefRangeStart = 70765, XrefRangeEnd = 70794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AABB GetTargetObjectGroupWorldAABB()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectTransformGizmo.NativeMethodInfoPtr_GetTargetObjectGroupWorldAABB_Public_AABB_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AABB>(intPtr3) : null;
		}

		// Token: 0x0600131B RID: 4891 RVA: 0x00069F94 File Offset: 0x00068194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70797, XrefRangeEnd = 70799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetNumTransformableParentObjects()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectTransformGizmo.NativeMethodInfoPtr_GetNumTransformableParentObjects_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600131C RID: 4892 RVA: 0x00069FD0 File Offset: 0x000681D0
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 70831, RefRangeEnd = 70840, XrefRangeStart = 70799, XrefRangeEnd = 70831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshPosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectTransformGizmo.NativeMethodInfoPtr_RefreshPosition_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600131D RID: 4893 RVA: 0x0006A004 File Offset: 0x00068204
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 70851, RefRangeEnd = 70858, XrefRangeStart = 70840, XrefRangeEnd = 70851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshRotation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectTransformGizmo.NativeMethodInfoPtr_RefreshRotation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600131E RID: 4894 RVA: 0x0006A038 File Offset: 0x00068238
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 70860, RefRangeEnd = 70861, XrefRangeStart = 70858, XrefRangeEnd = 70860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshPositionAndRotation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectTransformGizmo.NativeMethodInfoPtr_RefreshPositionAndRotation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600131F RID: 4895 RVA: 0x0006A06C File Offset: 0x0006826C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70861, XrefRangeEnd = 70866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnGizmoDragBegin(int handleId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handleId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectTransformGizmo.NativeMethodInfoPtr_OnGizmoDragBegin_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001320 RID: 4896 RVA: 0x0006A0B8 File Offset: 0x000682B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70866, XrefRangeEnd = 70874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnGizmoDragUpdate(int handleId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handleId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectTransformGizmo.NativeMethodInfoPtr_OnGizmoDragUpdate_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001321 RID: 4897 RVA: 0x0006A104 File Offset: 0x00068304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70874, XrefRangeEnd = 70884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnGizmoDragEnd(int handleId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handleId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectTransformGizmo.NativeMethodInfoPtr_OnGizmoDragEnd_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001322 RID: 4898 RVA: 0x0006A150 File Offset: 0x00068350
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 70920, RefRangeEnd = 70922, XrefRangeStart = 70884, XrefRangeEnd = 70920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<GameObject> GetTransformableParentObjects()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectTransformGizmo.NativeMethodInfoPtr_GetTransformableParentObjects_Private_List_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr3) : null;
		}

		// Token: 0x06001323 RID: 4899 RVA: 0x0006A190 File Offset: 0x00068390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70922, XrefRangeEnd = 70926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnUndoRedoEnd(IUndoRedoAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectTransformGizmo.NativeMethodInfoPtr_OnUndoRedoEnd_Private_Void_IUndoRedoAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001324 RID: 4900 RVA: 0x0006A1D4 File Offset: 0x000683D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 70941, RefRangeEnd = 70942, XrefRangeStart = 70926, XrefRangeEnd = 70941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveObjects(Vector3 moveVector)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(moveVector);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectTransformGizmo.NativeMethodInfoPtr_MoveObjects_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001325 RID: 4901 RVA: 0x0006A218 File Offset: 0x00068418
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 70956, RefRangeEnd = 70957, XrefRangeStart = 70942, XrefRangeEnd = 70956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveObject(GameObject gameObject, Vector3 moveVector)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(moveVector);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectTransformGizmo.NativeMethodInfoPtr_MoveObject_Private_Void_GameObject_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001326 RID: 4902 RVA: 0x0006A26C File Offset: 0x0006846C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 71026, RefRangeEnd = 71027, XrefRangeStart = 70957, XrefRangeEnd = 71026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RotateObjects(Quaternion rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rotation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectTransformGizmo.NativeMethodInfoPtr_RotateObjects_Private_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001327 RID: 4903 RVA: 0x0006A2B0 File Offset: 0x000684B0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 71040, RefRangeEnd = 71045, XrefRangeStart = 71027, XrefRangeEnd = 71040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RotateObject(GameObject gameObject, Quaternion rotation, Vector3 rotationPivot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rotation);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rotationPivot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectTransformGizmo.NativeMethodInfoPtr_RotateObject_Private_Void_GameObject_Quaternion_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001328 RID: 4904 RVA: 0x0006A318 File Offset: 0x00068518
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 71114, RefRangeEnd = 71115, XrefRangeStart = 71045, XrefRangeEnd = 71114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScaleObjects()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectTransformGizmo.NativeMethodInfoPtr_ScaleObjects_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001329 RID: 4905 RVA: 0x0006A34C File Offset: 0x0006854C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 71134, RefRangeEnd = 71139, XrefRangeStart = 71115, XrefRangeEnd = 71134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScaleObject(GameObject gameObject, Vector3 scalePivot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scalePivot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectTransformGizmo.NativeMethodInfoPtr_ScaleObject_Private_Void_GameObject_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600132A RID: 4906 RVA: 0x0006A3A0 File Offset: 0x000685A0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 71147, RefRangeEnd = 71151, XrefRangeStart = 71139, XrefRangeEnd = 71147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectBounds.QueryConfig GetObjectBoundsQConfig()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectTransformGizmo.NativeMethodInfoPtr_GetObjectBoundsQConfig_Private_QueryConfig_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600132B RID: 4907 RVA: 0x00009340 File Offset: 0x00007540
		public ObjectTransformGizmo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x0600132C RID: 4908 RVA: 0x0006A3DC File Offset: 0x000685DC
		// (set) Token: 0x0600132D RID: 4909 RVA: 0x00009349 File Offset: 0x00007549
		public unsafe ObjectTransformGizmo.TargetObjectMode _targetObjectMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectTransformGizmo.NativeFieldInfoPtr__targetObjectMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectTransformGizmo.NativeFieldInfoPtr__targetObjectMode)) = value;
			}
		}

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x0600132E RID: 4910 RVA: 0x0006A404 File Offset: 0x00068604
		// (set) Token: 0x0600132F RID: 4911 RVA: 0x00009364 File Offset: 0x00007564
		public unsafe ObjectTransformGizmo.Channels _transformChannelFlags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectTransformGizmo.NativeFieldInfoPtr__transformChannelFlags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectTransformGizmo.NativeFieldInfoPtr__transformChannelFlags)) = value;
			}
		}

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x06001330 RID: 4912 RVA: 0x0006A42C File Offset: 0x0006862C
		// (set) Token: 0x06001331 RID: 4913 RVA: 0x0000937F File Offset: 0x0000757F
		public unsafe IEnumerable<GameObject> _targetObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectTransformGizmo.NativeFieldInfoPtr__targetObjects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectTransformGizmo.NativeFieldInfoPtr__targetObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x06001332 RID: 4914 RVA: 0x0006A45C File Offset: 0x0006865C
		// (set) Token: 0x06001333 RID: 4915 RVA: 0x0000939E File Offset: 0x0000759E
		public unsafe GameObject _targetPivotObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectTransformGizmo.NativeFieldInfoPtr__targetPivotObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectTransformGizmo.NativeFieldInfoPtr__targetPivotObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x06001334 RID: 4916 RVA: 0x0006A48C File Offset: 0x0006868C
		// (set) Token: 0x06001335 RID: 4917 RVA: 0x000093BD File Offset: 0x000075BD
		public unsafe List<LocalTransformSnapshot> _preTransformSnapshots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectTransformGizmo.NativeFieldInfoPtr__preTransformSnapshots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LocalTransformSnapshot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectTransformGizmo.NativeFieldInfoPtr__preTransformSnapshots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x06001336 RID: 4918 RVA: 0x0006A4BC File Offset: 0x000686BC
		// (set) Token: 0x06001337 RID: 4919 RVA: 0x000093DC File Offset: 0x000075DC
		public unsafe List<GameObject> _transformableParents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectTransformGizmo.NativeFieldInfoPtr__transformableParents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectTransformGizmo.NativeFieldInfoPtr__transformableParents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x06001338 RID: 4920 RVA: 0x0006A4EC File Offset: 0x000686EC
		// (set) Token: 0x06001339 RID: 4921 RVA: 0x000093FB File Offset: 0x000075FB
		public unsafe AABB _targetGroupAABBOnDragBegin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectTransformGizmo.NativeFieldInfoPtr__targetGroupAABBOnDragBegin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AABB>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectTransformGizmo.NativeFieldInfoPtr__targetGroupAABBOnDragBegin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x0600133A RID: 4922 RVA: 0x0006A51C File Offset: 0x0006871C
		// (set) Token: 0x0600133B RID: 4923 RVA: 0x0000941A File Offset: 0x0000761A
		public unsafe GizmoSpace _transformSpace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectTransformGizmo.NativeFieldInfoPtr__transformSpace);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoSpace>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectTransformGizmo.NativeFieldInfoPtr__transformSpace), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x0600133C RID: 4924 RVA: 0x0006A54C File Offset: 0x0006874C
		// (set) Token: 0x0600133D RID: 4925 RVA: 0x00009439 File Offset: 0x00007639
		public unsafe bool _isTransformSpacePermanent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectTransformGizmo.NativeFieldInfoPtr__isTransformSpacePermanent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectTransformGizmo.NativeFieldInfoPtr__isTransformSpacePermanent)) = value;
			}
		}

		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x0600133E RID: 4926 RVA: 0x0006A574 File Offset: 0x00068774
		// (set) Token: 0x0600133F RID: 4927 RVA: 0x00009454 File Offset: 0x00007654
		public unsafe GizmoObjectTransformPivot _transformPivot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectTransformGizmo.NativeFieldInfoPtr__transformPivot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoObjectTransformPivot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectTransformGizmo.NativeFieldInfoPtr__transformPivot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x06001340 RID: 4928 RVA: 0x0006A5A4 File Offset: 0x000687A4
		// (set) Token: 0x06001341 RID: 4929 RVA: 0x00009473 File Offset: 0x00007673
		public unsafe bool _isTransformPivotPermanent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectTransformGizmo.NativeFieldInfoPtr__isTransformPivotPermanent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectTransformGizmo.NativeFieldInfoPtr__isTransformPivotPermanent)) = value;
			}
		}

		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x06001342 RID: 4930 RVA: 0x0006A5CC File Offset: 0x000687CC
		// (set) Token: 0x06001343 RID: 4931 RVA: 0x0000948E File Offset: 0x0000768E
		public unsafe bool _scaleConstraintEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectTransformGizmo.NativeFieldInfoPtr__scaleConstraintEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectTransformGizmo.NativeFieldInfoPtr__scaleConstraintEnabled)) = value;
			}
		}

		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x06001344 RID: 4932 RVA: 0x0006A5F4 File Offset: 0x000687F4
		// (set) Token: 0x06001345 RID: 4933 RVA: 0x000094A9 File Offset: 0x000076A9
		public unsafe Vector3 _minPositiveScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectTransformGizmo.NativeFieldInfoPtr__minPositiveScale);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectTransformGizmo.NativeFieldInfoPtr__minPositiveScale), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x06001346 RID: 4934 RVA: 0x0006A624 File Offset: 0x00068824
		// (set) Token: 0x06001347 RID: 4935 RVA: 0x000094C8 File Offset: 0x000076C8
		public unsafe Vector3 _customWorldPivot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectTransformGizmo.NativeFieldInfoPtr__customWorldPivot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectTransformGizmo.NativeFieldInfoPtr__customWorldPivot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x06001348 RID: 4936 RVA: 0x0006A654 File Offset: 0x00068854
		// (set) Token: 0x06001349 RID: 4937 RVA: 0x000094E7 File Offset: 0x000076E7
		public unsafe Dictionary<GameObject, Vector3> _objectToCustomLocalPivot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectTransformGizmo.NativeFieldInfoPtr__objectToCustomLocalPivot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<GameObject, Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectTransformGizmo.NativeFieldInfoPtr__objectToCustomLocalPivot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x0600134A RID: 4938 RVA: 0x0006A684 File Offset: 0x00068884
		// (set) Token: 0x0600134B RID: 4939 RVA: 0x00009506 File Offset: 0x00007706
		public unsafe Dictionary<GameObject, ObjectTransformGizmo.ObjectRestrictions> _objectToRestrictions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectTransformGizmo.NativeFieldInfoPtr__objectToRestrictions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<GameObject, ObjectTransformGizmo.ObjectRestrictions>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectTransformGizmo.NativeFieldInfoPtr__objectToRestrictions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x0600134C RID: 4940 RVA: 0x0006A6B4 File Offset: 0x000688B4
		// (set) Token: 0x0600134D RID: 4941 RVA: 0x00009525 File Offset: 0x00007725
		public unsafe ObjectTransformGizmoSettings _settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectTransformGizmo.NativeFieldInfoPtr__settings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectTransformGizmoSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectTransformGizmo.NativeFieldInfoPtr__settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x0600134E RID: 4942 RVA: 0x0006A6E4 File Offset: 0x000688E4
		// (set) Token: 0x0600134F RID: 4943 RVA: 0x00009544 File Offset: 0x00007744
		public unsafe ObjectTransformGizmoSettings _sharedSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectTransformGizmo.NativeFieldInfoPtr__sharedSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectTransformGizmoSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectTransformGizmo.NativeFieldInfoPtr__sharedSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E1B RID: 3611
		private static readonly IntPtr NativeFieldInfoPtr__targetObjectMode;

		// Token: 0x04000E1C RID: 3612
		private static readonly IntPtr NativeFieldInfoPtr__transformChannelFlags;

		// Token: 0x04000E1D RID: 3613
		private static readonly IntPtr NativeFieldInfoPtr__targetObjects;

		// Token: 0x04000E1E RID: 3614
		private static readonly IntPtr NativeFieldInfoPtr__targetPivotObject;

		// Token: 0x04000E1F RID: 3615
		private static readonly IntPtr NativeFieldInfoPtr__preTransformSnapshots;

		// Token: 0x04000E20 RID: 3616
		private static readonly IntPtr NativeFieldInfoPtr__transformableParents;

		// Token: 0x04000E21 RID: 3617
		private static readonly IntPtr NativeFieldInfoPtr__targetGroupAABBOnDragBegin;

		// Token: 0x04000E22 RID: 3618
		private static readonly IntPtr NativeFieldInfoPtr__transformSpace;

		// Token: 0x04000E23 RID: 3619
		private static readonly IntPtr NativeFieldInfoPtr__isTransformSpacePermanent;

		// Token: 0x04000E24 RID: 3620
		private static readonly IntPtr NativeFieldInfoPtr__transformPivot;

		// Token: 0x04000E25 RID: 3621
		private static readonly IntPtr NativeFieldInfoPtr__isTransformPivotPermanent;

		// Token: 0x04000E26 RID: 3622
		private static readonly IntPtr NativeFieldInfoPtr__scaleConstraintEnabled;

		// Token: 0x04000E27 RID: 3623
		private static readonly IntPtr NativeFieldInfoPtr__minPositiveScale;

		// Token: 0x04000E28 RID: 3624
		private static readonly IntPtr NativeFieldInfoPtr__customWorldPivot;

		// Token: 0x04000E29 RID: 3625
		private static readonly IntPtr NativeFieldInfoPtr__objectToCustomLocalPivot;

		// Token: 0x04000E2A RID: 3626
		private static readonly IntPtr NativeFieldInfoPtr__objectToRestrictions;

		// Token: 0x04000E2B RID: 3627
		private static readonly IntPtr NativeFieldInfoPtr__settings;

		// Token: 0x04000E2C RID: 3628
		private static readonly IntPtr NativeFieldInfoPtr__sharedSettings;

		// Token: 0x04000E2D RID: 3629
		private static readonly IntPtr NativeMethodInfoPtr_get_TransformPivot_Public_get_GizmoObjectTransformPivot_0;

		// Token: 0x04000E2E RID: 3630
		private static readonly IntPtr NativeMethodInfoPtr_get_IsTransformPivotPermanent_Public_get_Boolean_0;

		// Token: 0x04000E2F RID: 3631
		private static readonly IntPtr NativeMethodInfoPtr_get_TransformSpace_Public_get_GizmoSpace_0;

		// Token: 0x04000E30 RID: 3632
		private static readonly IntPtr NativeMethodInfoPtr_get_IsTransformSpacePermanent_Public_get_Boolean_0;

		// Token: 0x04000E31 RID: 3633
		private static readonly IntPtr NativeMethodInfoPtr_get_TransformChannelFlags_Public_get_Channels_0;

		// Token: 0x04000E32 RID: 3634
		private static readonly IntPtr NativeMethodInfoPtr_get_CanAffectPosition_Public_get_Boolean_0;

		// Token: 0x04000E33 RID: 3635
		private static readonly IntPtr NativeMethodInfoPtr_get_CanAffectRotation_Public_get_Boolean_0;

		// Token: 0x04000E34 RID: 3636
		private static readonly IntPtr NativeMethodInfoPtr_get_CanAffectScale_Public_get_Boolean_0;

		// Token: 0x04000E35 RID: 3637
		private static readonly IntPtr NativeMethodInfoPtr_get_CustomWorldPivot_Public_get_Vector3_0;

		// Token: 0x04000E36 RID: 3638
		private static readonly IntPtr NativeMethodInfoPtr_get_Settings_Public_get_ObjectTransformGizmoSettings_0;

		// Token: 0x04000E37 RID: 3639
		private static readonly IntPtr NativeMethodInfoPtr_get_SharedSettings_Public_get_ObjectTransformGizmoSettings_0;

		// Token: 0x04000E38 RID: 3640
		private static readonly IntPtr NativeMethodInfoPtr_set_SharedSettings_Public_set_Void_ObjectTransformGizmoSettings_0;

		// Token: 0x04000E39 RID: 3641
		private static readonly IntPtr NativeMethodInfoPtr_get_ScaleConstraintEnabled_Public_get_Boolean_0;

		// Token: 0x04000E3A RID: 3642
		private static readonly IntPtr NativeMethodInfoPtr_set_ScaleConstraintEnabled_Public_set_Void_Boolean_0;

		// Token: 0x04000E3B RID: 3643
		private static readonly IntPtr NativeMethodInfoPtr_get_MinPositiveScale_Public_get_Vector3_0;

		// Token: 0x04000E3C RID: 3644
		private static readonly IntPtr NativeMethodInfoPtr_set_MinPositiveScale_Public_set_Void_Vector3_0;

		// Token: 0x04000E3D RID: 3645
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000E3E RID: 3646
		private static readonly IntPtr NativeMethodInfoPtr_OnAttached_Public_Virtual_Void_0;

		// Token: 0x04000E3F RID: 3647
		private static readonly IntPtr NativeMethodInfoPtr_OnDetached_Public_Virtual_Void_0;

		// Token: 0x04000E40 RID: 3648
		private static readonly IntPtr NativeMethodInfoPtr_MakeTransformSpacePermanent_Public_Void_0;

		// Token: 0x04000E41 RID: 3649
		private static readonly IntPtr NativeMethodInfoPtr_MakeTransformPivotPermanent_Public_Void_0;

		// Token: 0x04000E42 RID: 3650
		private static readonly IntPtr NativeMethodInfoPtr_ContainsRestrictionsForObject_Public_Boolean_GameObject_0;

		// Token: 0x04000E43 RID: 3651
		private static readonly IntPtr NativeMethodInfoPtr_RegisterObjectRestrictions_Public_Void_GameObject_ObjectRestrictions_0;

		// Token: 0x04000E44 RID: 3652
		private static readonly IntPtr NativeMethodInfoPtr_RegisterObjectRestrictions_Public_Void_List_1_GameObject_ObjectRestrictions_0;

		// Token: 0x04000E45 RID: 3653
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterObjectRestrictions_Public_Void_GameObject_0;

		// Token: 0x04000E46 RID: 3654
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectRestrictions_Public_ObjectRestrictions_GameObject_0;

		// Token: 0x04000E47 RID: 3655
		private static readonly IntPtr NativeMethodInfoPtr_SetTransformChannelFlags_Public_Void_Channels_0;

		// Token: 0x04000E48 RID: 3656
		private static readonly IntPtr NativeMethodInfoPtr_SetCanAffectPosition_Public_Void_Boolean_0;

		// Token: 0x04000E49 RID: 3657
		private static readonly IntPtr NativeMethodInfoPtr_SetCanAffectRotation_Public_Void_Boolean_0;

		// Token: 0x04000E4A RID: 3658
		private static readonly IntPtr NativeMethodInfoPtr_SetCanAffectScale_Public_Void_Boolean_0;

		// Token: 0x04000E4B RID: 3659
		private static readonly IntPtr NativeMethodInfoPtr_SetTargetPivotObject_Public_Void_GameObject_0;

		// Token: 0x04000E4C RID: 3660
		private static readonly IntPtr NativeMethodInfoPtr_SetTargetObjects_Public_Void_IEnumerable_1_GameObject_0;

		// Token: 0x04000E4D RID: 3661
		private static readonly IntPtr NativeMethodInfoPtr_SetTargetObject_Public_Void_GameObject_0;

		// Token: 0x04000E4E RID: 3662
		private static readonly IntPtr NativeMethodInfoPtr_SetTransformPivot_Public_Void_GizmoObjectTransformPivot_0;

		// Token: 0x04000E4F RID: 3663
		private static readonly IntPtr NativeMethodInfoPtr_SetCustomWorldPivot_Public_Void_Vector3_0;

		// Token: 0x04000E50 RID: 3664
		private static readonly IntPtr NativeMethodInfoPtr_SetObjectCustomLocalPivot_Public_Void_GameObject_Vector3_0;

		// Token: 0x04000E51 RID: 3665
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectCustomLocalPivot_Public_Vector3_GameObject_0;

		// Token: 0x04000E52 RID: 3666
		private static readonly IntPtr NativeMethodInfoPtr_SetTransformSpace_Public_Void_GizmoSpace_0;

		// Token: 0x04000E53 RID: 3667
		private static readonly IntPtr NativeMethodInfoPtr_GetTargetObjectGroupWorldAABB_Public_AABB_0;

		// Token: 0x04000E54 RID: 3668
		private static readonly IntPtr NativeMethodInfoPtr_GetNumTransformableParentObjects_Public_Int32_0;

		// Token: 0x04000E55 RID: 3669
		private static readonly IntPtr NativeMethodInfoPtr_RefreshPosition_Public_Void_0;

		// Token: 0x04000E56 RID: 3670
		private static readonly IntPtr NativeMethodInfoPtr_RefreshRotation_Public_Void_0;

		// Token: 0x04000E57 RID: 3671
		private static readonly IntPtr NativeMethodInfoPtr_RefreshPositionAndRotation_Public_Void_0;

		// Token: 0x04000E58 RID: 3672
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoDragBegin_Public_Virtual_Void_Int32_0;

		// Token: 0x04000E59 RID: 3673
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoDragUpdate_Public_Virtual_Void_Int32_0;

		// Token: 0x04000E5A RID: 3674
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoDragEnd_Public_Virtual_Void_Int32_0;

		// Token: 0x04000E5B RID: 3675
		private static readonly IntPtr NativeMethodInfoPtr_GetTransformableParentObjects_Private_List_1_GameObject_0;

		// Token: 0x04000E5C RID: 3676
		private static readonly IntPtr NativeMethodInfoPtr_OnUndoRedoEnd_Private_Void_IUndoRedoAction_0;

		// Token: 0x04000E5D RID: 3677
		private static readonly IntPtr NativeMethodInfoPtr_MoveObjects_Private_Void_Vector3_0;

		// Token: 0x04000E5E RID: 3678
		private static readonly IntPtr NativeMethodInfoPtr_MoveObject_Private_Void_GameObject_Vector3_0;

		// Token: 0x04000E5F RID: 3679
		private static readonly IntPtr NativeMethodInfoPtr_RotateObjects_Private_Void_Quaternion_0;

		// Token: 0x04000E60 RID: 3680
		private static readonly IntPtr NativeMethodInfoPtr_RotateObject_Private_Void_GameObject_Quaternion_Vector3_0;

		// Token: 0x04000E61 RID: 3681
		private static readonly IntPtr NativeMethodInfoPtr_ScaleObjects_Private_Void_0;

		// Token: 0x04000E62 RID: 3682
		private static readonly IntPtr NativeMethodInfoPtr_ScaleObject_Private_Void_GameObject_Vector3_0;

		// Token: 0x04000E63 RID: 3683
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectBoundsQConfig_Private_QueryConfig_0;

		// Token: 0x02000375 RID: 885
		public class ObjectRestrictions : global::Il2CppSystem.Object
		{
			// Token: 0x06004A16 RID: 18966 RVA: 0x00146818 File Offset: 0x00144A18
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectRestrictions()
			{
				Il2CppClassPointerStore<ObjectTransformGizmo.ObjectRestrictions>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ObjectTransformGizmo>.NativeClassPtr, "ObjectRestrictions");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectTransformGizmo.ObjectRestrictions>.NativeClassPtr);
				ObjectTransformGizmo.ObjectRestrictions.NativeFieldInfoPtr__moveAxesMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectTransformGizmo.ObjectRestrictions>.NativeClassPtr, "_moveAxesMask");
				ObjectTransformGizmo.ObjectRestrictions.NativeFieldInfoPtr__scaleAxesMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectTransformGizmo.ObjectRestrictions>.NativeClassPtr, "_scaleAxesMask");
				ObjectTransformGizmo.ObjectRestrictions.NativeFieldInfoPtr__handleMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectTransformGizmo.ObjectRestrictions>.NativeClassPtr, "_handleMask");
				ObjectTransformGizmo.ObjectRestrictions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTransformGizmo.ObjectRestrictions>.NativeClassPtr, 100666010);
				ObjectTransformGizmo.ObjectRestrictions.NativeMethodInfoPtr_CanMoveAlongAllAxes_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTransformGizmo.ObjectRestrictions>.NativeClassPtr, 100666000);
				ObjectTransformGizmo.ObjectRestrictions.NativeMethodInfoPtr_CanScaleAlongAllAxes_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTransformGizmo.ObjectRestrictions>.NativeClassPtr, 100666001);
				ObjectTransformGizmo.ObjectRestrictions.NativeMethodInfoPtr_CanMoveAlongAxis_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTransformGizmo.ObjectRestrictions>.NativeClassPtr, 100666002);
				ObjectTransformGizmo.ObjectRestrictions.NativeMethodInfoPtr_CanScaleAlongAxis_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTransformGizmo.ObjectRestrictions>.NativeClassPtr, 100666003);
				ObjectTransformGizmo.ObjectRestrictions.NativeMethodInfoPtr_SetCanMoveAlongAxis_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTransformGizmo.ObjectRestrictions>.NativeClassPtr, 100666004);
				ObjectTransformGizmo.ObjectRestrictions.NativeMethodInfoPtr_SetCanScaleAlongAxis_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTransformGizmo.ObjectRestrictions>.NativeClassPtr, 100666005);
				ObjectTransformGizmo.ObjectRestrictions.NativeMethodInfoPtr_IsAffectedByHandle_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTransformGizmo.ObjectRestrictions>.NativeClassPtr, 100666006);
				ObjectTransformGizmo.ObjectRestrictions.NativeMethodInfoPtr_SetIsAffectedByHandle_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTransformGizmo.ObjectRestrictions>.NativeClassPtr, 100666007);
				ObjectTransformGizmo.ObjectRestrictions.NativeMethodInfoPtr_AdjustMoveVector_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTransformGizmo.ObjectRestrictions>.NativeClassPtr, 100666008);
				ObjectTransformGizmo.ObjectRestrictions.NativeMethodInfoPtr_AdjustScaleVector_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTransformGizmo.ObjectRestrictions>.NativeClassPtr, 100666009);
			}

			// Token: 0x06004A17 RID: 18967 RVA: 0x0014695C File Offset: 0x00144B5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70543, XrefRangeEnd = 70563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectRestrictions()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectTransformGizmo.ObjectRestrictions>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectTransformGizmo.ObjectRestrictions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004A18 RID: 18968 RVA: 0x00146998 File Offset: 0x00144B98
			[CallerCount(0)]
			public unsafe bool CanMoveAlongAllAxes()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectTransformGizmo.ObjectRestrictions.NativeMethodInfoPtr_CanMoveAlongAllAxes_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004A19 RID: 18969 RVA: 0x001469D4 File Offset: 0x00144BD4
			[CallerCount(0)]
			public unsafe bool CanScaleAlongAllAxes()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectTransformGizmo.ObjectRestrictions.NativeMethodInfoPtr_CanScaleAlongAllAxes_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004A1A RID: 18970 RVA: 0x00146A10 File Offset: 0x00144C10
			[CallerCount(0)]
			public unsafe bool CanMoveAlongAxis(int axisIndex)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref axisIndex;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectTransformGizmo.ObjectRestrictions.NativeMethodInfoPtr_CanMoveAlongAxis_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004A1B RID: 18971 RVA: 0x00146A5C File Offset: 0x00144C5C
			[CallerCount(0)]
			public unsafe bool CanScaleAlongAxis(int axisIndex)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref axisIndex;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectTransformGizmo.ObjectRestrictions.NativeMethodInfoPtr_CanScaleAlongAxis_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004A1C RID: 18972 RVA: 0x00146AA8 File Offset: 0x00144CA8
			[CallerCount(0)]
			public unsafe void SetCanMoveAlongAxis(int axisIndex, bool canMove)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref axisIndex;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref canMove;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectTransformGizmo.ObjectRestrictions.NativeMethodInfoPtr_SetCanMoveAlongAxis_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004A1D RID: 18973 RVA: 0x00146AF4 File Offset: 0x00144CF4
			[CallerCount(0)]
			public unsafe void SetCanScaleAlongAxis(int axisIndex, bool canScale)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref axisIndex;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref canScale;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectTransformGizmo.ObjectRestrictions.NativeMethodInfoPtr_SetCanScaleAlongAxis_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004A1E RID: 18974 RVA: 0x00146B40 File Offset: 0x00144D40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70563, XrefRangeEnd = 70566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool IsAffectedByHandle(int handleId)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref handleId;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectTransformGizmo.ObjectRestrictions.NativeMethodInfoPtr_IsAffectedByHandle_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004A1F RID: 18975 RVA: 0x00146B8C File Offset: 0x00144D8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70566, XrefRangeEnd = 70573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetIsAffectedByHandle(int handleId, bool isAffected)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref handleId;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isAffected;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectTransformGizmo.ObjectRestrictions.NativeMethodInfoPtr_SetIsAffectedByHandle_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004A20 RID: 18976 RVA: 0x00146BD8 File Offset: 0x00144DD8
			[CallerCount(0)]
			public unsafe Vector3 AdjustMoveVector(Vector3 moveVector)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(moveVector);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectTransformGizmo.ObjectRestrictions.NativeMethodInfoPtr_AdjustMoveVector_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
				}
			}

			// Token: 0x06004A21 RID: 18977 RVA: 0x00146C28 File Offset: 0x00144E28
			[CallerCount(0)]
			public unsafe Vector3 AdjustScaleVector(Vector3 scaleVector)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(scaleVector);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectTransformGizmo.ObjectRestrictions.NativeMethodInfoPtr_AdjustScaleVector_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
				}
			}

			// Token: 0x06004A22 RID: 18978 RVA: 0x0001B961 File Offset: 0x00019B61
			public ObjectRestrictions(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001910 RID: 6416
			// (get) Token: 0x06004A23 RID: 18979 RVA: 0x00146C78 File Offset: 0x00144E78
			// (set) Token: 0x06004A24 RID: 18980 RVA: 0x0001B96A File Offset: 0x00019B6A
			public unsafe Il2CppStructArray<bool> _moveAxesMask
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectTransformGizmo.ObjectRestrictions.NativeFieldInfoPtr__moveAxesMask);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectTransformGizmo.ObjectRestrictions.NativeFieldInfoPtr__moveAxesMask), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001911 RID: 6417
			// (get) Token: 0x06004A25 RID: 18981 RVA: 0x00146CA8 File Offset: 0x00144EA8
			// (set) Token: 0x06004A26 RID: 18982 RVA: 0x0001B989 File Offset: 0x00019B89
			public unsafe Il2CppStructArray<bool> _scaleAxesMask
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectTransformGizmo.ObjectRestrictions.NativeFieldInfoPtr__scaleAxesMask);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectTransformGizmo.ObjectRestrictions.NativeFieldInfoPtr__scaleAxesMask), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001912 RID: 6418
			// (get) Token: 0x06004A27 RID: 18983 RVA: 0x00146CD8 File Offset: 0x00144ED8
			// (set) Token: 0x06004A28 RID: 18984 RVA: 0x0001B9A8 File Offset: 0x00019BA8
			public unsafe HashSet<int> _handleMask
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectTransformGizmo.ObjectRestrictions.NativeFieldInfoPtr__handleMask);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectTransformGizmo.ObjectRestrictions.NativeFieldInfoPtr__handleMask), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003984 RID: 14724
			private static readonly IntPtr NativeFieldInfoPtr__moveAxesMask;

			// Token: 0x04003985 RID: 14725
			private static readonly IntPtr NativeFieldInfoPtr__scaleAxesMask;

			// Token: 0x04003986 RID: 14726
			private static readonly IntPtr NativeFieldInfoPtr__handleMask;

			// Token: 0x04003987 RID: 14727
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003988 RID: 14728
			private static readonly IntPtr NativeMethodInfoPtr_CanMoveAlongAllAxes_Public_Boolean_0;

			// Token: 0x04003989 RID: 14729
			private static readonly IntPtr NativeMethodInfoPtr_CanScaleAlongAllAxes_Public_Boolean_0;

			// Token: 0x0400398A RID: 14730
			private static readonly IntPtr NativeMethodInfoPtr_CanMoveAlongAxis_Public_Boolean_Int32_0;

			// Token: 0x0400398B RID: 14731
			private static readonly IntPtr NativeMethodInfoPtr_CanScaleAlongAxis_Public_Boolean_Int32_0;

			// Token: 0x0400398C RID: 14732
			private static readonly IntPtr NativeMethodInfoPtr_SetCanMoveAlongAxis_Public_Void_Int32_Boolean_0;

			// Token: 0x0400398D RID: 14733
			private static readonly IntPtr NativeMethodInfoPtr_SetCanScaleAlongAxis_Public_Void_Int32_Boolean_0;

			// Token: 0x0400398E RID: 14734
			private static readonly IntPtr NativeMethodInfoPtr_IsAffectedByHandle_Public_Boolean_Int32_0;

			// Token: 0x0400398F RID: 14735
			private static readonly IntPtr NativeMethodInfoPtr_SetIsAffectedByHandle_Public_Void_Int32_Boolean_0;

			// Token: 0x04003990 RID: 14736
			private static readonly IntPtr NativeMethodInfoPtr_AdjustMoveVector_Public_Vector3_Vector3_0;

			// Token: 0x04003991 RID: 14737
			private static readonly IntPtr NativeMethodInfoPtr_AdjustScaleVector_Public_Vector3_Vector3_0;
		}

		// Token: 0x02000376 RID: 886
		[Flags]
		public enum Channels
		{
			// Token: 0x04003993 RID: 14739
			None = 0,
			// Token: 0x04003994 RID: 14740
			Position = 1,
			// Token: 0x04003995 RID: 14741
			Rotation = 2,
			// Token: 0x04003996 RID: 14742
			Scale = 4,
			// Token: 0x04003997 RID: 14743
			All = 7
		}

		// Token: 0x02000377 RID: 887
		public enum TargetObjectMode
		{
			// Token: 0x04003999 RID: 14745
			Multiple,
			// Token: 0x0400399A RID: 14746
			Single
		}
	}
}
