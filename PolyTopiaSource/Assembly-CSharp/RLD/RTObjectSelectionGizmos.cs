using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200023C RID: 572
	[Serializable]
	public class RTObjectSelectionGizmos : MonoSingleton<RTObjectSelectionGizmos>
	{
		// Token: 0x06002C59 RID: 11353 RVA: 0x000CFFB0 File Offset: 0x000CE1B0
		// Note: this type is marked as 'beforefieldinit'.
		static RTObjectSelectionGizmos()
		{
			Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "RTObjectSelectionGizmos");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr);
			RTObjectSelectionGizmos.NativeFieldInfoPtr__mainToolbar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, "_mainToolbar");
			RTObjectSelectionGizmos.NativeFieldInfoPtr__universalGizmoConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, "_universalGizmoConfig");
			RTObjectSelectionGizmos.NativeFieldInfoPtr__gizmosEnabledStateSnapshot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, "_gizmosEnabledStateSnapshot");
			RTObjectSelectionGizmos.NativeFieldInfoPtr__allGizmos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, "_allGizmos");
			RTObjectSelectionGizmos.NativeFieldInfoPtr__objectTransformGizmos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, "_objectTransformGizmos");
			RTObjectSelectionGizmos.NativeFieldInfoPtr__workGizmoId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, "_workGizmoId");
			RTObjectSelectionGizmos.NativeFieldInfoPtr__workGizmo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, "_workGizmo");
			RTObjectSelectionGizmos.NativeFieldInfoPtr__areGizmosVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, "_areGizmosVisible");
			RTObjectSelectionGizmos.NativeFieldInfoPtr__transformSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, "_transformSpace");
			RTObjectSelectionGizmos.NativeFieldInfoPtr__pivotObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, "_pivotObject");
			RTObjectSelectionGizmos.NativeFieldInfoPtr__targetObjectCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, "_targetObjectCollection");
			RTObjectSelectionGizmos.NativeFieldInfoPtr__hotkeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, "_hotkeys");
			RTObjectSelectionGizmos.NativeFieldInfoPtr__moveGizmoSettings2D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, "_moveGizmoSettings2D");
			RTObjectSelectionGizmos.NativeFieldInfoPtr__moveGizmoSettings3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, "_moveGizmoSettings3D");
			RTObjectSelectionGizmos.NativeFieldInfoPtr__moveGizmoLookAndFeel2D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, "_moveGizmoLookAndFeel2D");
			RTObjectSelectionGizmos.NativeFieldInfoPtr__moveGizmoLookAndFeel3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, "_moveGizmoLookAndFeel3D");
			RTObjectSelectionGizmos.NativeFieldInfoPtr__moveGizmoHotkeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, "_moveGizmoHotkeys");
			RTObjectSelectionGizmos.NativeFieldInfoPtr__objectMoveGizmoSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, "_objectMoveGizmoSettings");
			RTObjectSelectionGizmos.NativeFieldInfoPtr__rotationGizmoSettings3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, "_rotationGizmoSettings3D");
			RTObjectSelectionGizmos.NativeFieldInfoPtr__rotationGizmoLookAndFeel3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, "_rotationGizmoLookAndFeel3D");
			RTObjectSelectionGizmos.NativeFieldInfoPtr__rotationGizmoHotkeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, "_rotationGizmoHotkeys");
			RTObjectSelectionGizmos.NativeFieldInfoPtr__objectRotationGizmoSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, "_objectRotationGizmoSettings");
			RTObjectSelectionGizmos.NativeFieldInfoPtr__scaleGizmoSettings3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, "_scaleGizmoSettings3D");
			RTObjectSelectionGizmos.NativeFieldInfoPtr__scaleGizmoLookAndFeel3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, "_scaleGizmoLookAndFeel3D");
			RTObjectSelectionGizmos.NativeFieldInfoPtr__scaleGizmoHotkeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, "_scaleGizmoHotkeys");
			RTObjectSelectionGizmos.NativeFieldInfoPtr__objectScaleGizmoSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, "_objectScaleGizmoSettings");
			RTObjectSelectionGizmos.NativeFieldInfoPtr__universalGizmoSettings2D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, "_universalGizmoSettings2D");
			RTObjectSelectionGizmos.NativeFieldInfoPtr__universalGizmoSettings3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, "_universalGizmoSettings3D");
			RTObjectSelectionGizmos.NativeFieldInfoPtr__universalGizmoLookAndFeel2D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, "_universalGizmoLookAndFeel2D");
			RTObjectSelectionGizmos.NativeFieldInfoPtr__universalGizmoLookAndFeel3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, "_universalGizmoLookAndFeel3D");
			RTObjectSelectionGizmos.NativeFieldInfoPtr__universalGizmoHotkeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, "_universalGizmoHotkeys");
			RTObjectSelectionGizmos.NativeFieldInfoPtr__objectUniversalGizmoSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, "_objectUniversalGizmoSettings");
			RTObjectSelectionGizmos.NativeFieldInfoPtr__boxScaleGizmoSettings3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, "_boxScaleGizmoSettings3D");
			RTObjectSelectionGizmos.NativeFieldInfoPtr__boxScaleGizmoLookAndFeel3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, "_boxScaleGizmoLookAndFeel3D");
			RTObjectSelectionGizmos.NativeFieldInfoPtr__boxScaleGizmoHotkeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, "_boxScaleGizmoHotkeys");
			RTObjectSelectionGizmos.NativeFieldInfoPtr__extrudeGizmoLookAndFeel3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, "_extrudeGizmoLookAndFeel3D");
			RTObjectSelectionGizmos.NativeFieldInfoPtr__extrudeGizmoHotkeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, "_extrudeGizmoHotkeys");
			RTObjectSelectionGizmos.NativeMethodInfoPtr_get_AreGizmosVisible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, 100670008);
			RTObjectSelectionGizmos.NativeMethodInfoPtr_get_PivotObject_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, 100670009);
			RTObjectSelectionGizmos.NativeMethodInfoPtr_get_WorkGizmo_Public_get_Gizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, 100670010);
			RTObjectSelectionGizmos.NativeMethodInfoPtr_get_Hotkeys_Public_get_ObjectSelectionGizmosHotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, 100670011);
			RTObjectSelectionGizmos.NativeMethodInfoPtr_get_MoveGizmoSettings2D_Public_get_MoveGizmoSettings2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, 100670012);
			RTObjectSelectionGizmos.NativeMethodInfoPtr_get_MoveGizmoSettings3D_Public_get_MoveGizmoSettings3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, 100670013);
			RTObjectSelectionGizmos.NativeMethodInfoPtr_get_MoveGizmoLookAndFeel2D_Public_get_MoveGizmoLookAndFeel2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, 100670014);
			RTObjectSelectionGizmos.NativeMethodInfoPtr_get_MoveGizmoLookAndFeel3D_Public_get_MoveGizmoLookAndFeel3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, 100670015);
			RTObjectSelectionGizmos.NativeMethodInfoPtr_get_MoveGizmoHotkeys_Public_get_MoveGizmoHotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, 100670016);
			RTObjectSelectionGizmos.NativeMethodInfoPtr_get_ObjectMoveGizmoSettings_Public_get_ObjectTransformGizmoSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, 100670017);
			RTObjectSelectionGizmos.NativeMethodInfoPtr_get_RotationGizmoSettings3D_Public_get_RotationGizmoSettings3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, 100670018);
			RTObjectSelectionGizmos.NativeMethodInfoPtr_get_RotationGizmoLookAndFeel3D_Public_get_RotationGizmoLookAndFeel3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, 100670019);
			RTObjectSelectionGizmos.NativeMethodInfoPtr_get_RotationGizmoHotkeys_Public_get_RotationGizmoHotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, 100670020);
			RTObjectSelectionGizmos.NativeMethodInfoPtr_get_ObjectRotationGizmoSettings_Public_get_ObjectTransformGizmoSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, 100670021);
			RTObjectSelectionGizmos.NativeMethodInfoPtr_get_ScaleGizmoSettings3D_Public_get_ScaleGizmoSettings3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, 100670022);
			RTObjectSelectionGizmos.NativeMethodInfoPtr_get_ScaleGizmoLookAndFeel3D_Public_get_ScaleGizmoLookAndFeel3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, 100670023);
			RTObjectSelectionGizmos.NativeMethodInfoPtr_get_ScaleGizmoHotkeys_Public_get_ScaleGizmoHotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, 100670024);
			RTObjectSelectionGizmos.NativeMethodInfoPtr_get_ObjectScaleGizmoSettings_Public_get_ObjectTransformGizmoSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, 100670025);
			RTObjectSelectionGizmos.NativeMethodInfoPtr_get_UniversalGizmoSettings2D_Public_get_UniversalGizmoSettings2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, 100670026);
			RTObjectSelectionGizmos.NativeMethodInfoPtr_get_UniversalGizmoSettings3D_Public_get_UniversalGizmoSettings3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, 100670027);
			RTObjectSelectionGizmos.NativeMethodInfoPtr_get_UniversalGizmoLookAndFeel2D_Public_get_UniversalGizmoLookAndFeel2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, 100670028);
			RTObjectSelectionGizmos.NativeMethodInfoPtr_get_UniversalGizmoLookAndFeel3D_Public_get_UniversalGizmoLookAndFeel3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, 100670029);
			RTObjectSelectionGizmos.NativeMethodInfoPtr_get_UniversalGizmoHotkeys_Public_get_UniversalGizmoHotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, 100670030);
			RTObjectSelectionGizmos.NativeMethodInfoPtr_get_ObjectUniversalGizmoSettings_Public_get_ObjectTransformGizmoSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, 100670031);
			RTObjectSelectionGizmos.NativeMethodInfoPtr_get_BoxScaleGizmoSettings3D_Public_get_BoxGizmoSettings3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, 100670032);
			RTObjectSelectionGizmos.NativeMethodInfoPtr_get_BoxScaleGizmoLookAndFeel3D_Public_get_BoxGizmoLookAndFeel3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, 100670033);
			RTObjectSelectionGizmos.NativeMethodInfoPtr_get_BoxScaleGizmoHotkeys_Public_get_BoxGizmoHotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, 100670034);
			RTObjectSelectionGizmos.NativeMethodInfoPtr_get_ExtrudeGizmoLookAndFeel3D_Public_get_ObjectExtrudeGizmoLookAndFeel3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, 100670035);
			RTObjectSelectionGizmos.NativeMethodInfoPtr_get_ExtrudeGozmoHotkeys_Public_get_ObjectExtrudeGizmoHotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, 100670036);
			RTObjectSelectionGizmos.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, 100670063);
			RTObjectSelectionGizmos.NativeMethodInfoPtr_SetTargetObjectCollection_Public_Virtual_Final_New_Void_IEnumerable_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, 100670037);
			RTObjectSelectionGizmos.NativeMethodInfoPtr_Initialize_SystemCall_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, 100670038);
			RTObjectSelectionGizmos.NativeMethodInfoPtr_SetGizmoUsable_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, 100670039);
			RTObjectSelectionGizmos.NativeMethodInfoPtr_GetGizmoById_Public_Gizmo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, 100670040);
			RTObjectSelectionGizmos.NativeMethodInfoPtr_GetAllGizmos_Public_List_1_Gizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, 100670041);
			RTObjectSelectionGizmos.NativeMethodInfoPtr_GetGizmoId_Public_Int32_Gizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, 100670042);
			RTObjectSelectionGizmos.NativeMethodInfoPtr_GetTransformGizmoById_Public_ObjectTransformGizmo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, 100670043);
			RTObjectSelectionGizmos.NativeMethodInfoPtr_SetTransformPivot_Public_Void_GizmoObjectTransformPivot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, 100670044);
			RTObjectSelectionGizmos.NativeMethodInfoPtr_SetTransformSpace_Public_Void_GizmoSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, 100670045);
			RTObjectSelectionGizmos.NativeMethodInfoPtr_SetWorkGizmo_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, 100670046);
			RTObjectSelectionGizmos.NativeMethodInfoPtr_SetGizmosVisisble_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, 100670047);
			RTObjectSelectionGizmos.NativeMethodInfoPtr_Update_SystemCall_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, 100670048);
			RTObjectSelectionGizmos.NativeMethodInfoPtr_OnObjectSelectionChanged_Private_Void_ObjectSelectionChangedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, 100670049);
			RTObjectSelectionGizmos.NativeMethodInfoPtr_OnUndoRedo_Private_Void_IUndoRedoAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, 100670050);
			RTObjectSelectionGizmos.NativeMethodInfoPtr_OnGizmoPostEnabled_Private_Void_Gizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, 100670051);
			RTObjectSelectionGizmos.NativeMethodInfoPtr_OnTargetObjectGroupUpdated_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, 100670052);
			RTObjectSelectionGizmos.NativeMethodInfoPtr_OnObjectSelectionManipSessionBegin_Private_Void_ObjectSelectionManipSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, 100670053);
			RTObjectSelectionGizmos.NativeMethodInfoPtr_OnObjectSelectionManipSessionEnd_Private_Void_ObjectSelectionManipSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, 100670054);
			RTObjectSelectionGizmos.NativeMethodInfoPtr_OnObjectSelectionRotated_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, 100670055);
			RTObjectSelectionGizmos.NativeMethodInfoPtr_OnObjectSelectionEnabled_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, 100670056);
			RTObjectSelectionGizmos.NativeMethodInfoPtr_OnObjectSelectionDisabled_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, 100670057);
			RTObjectSelectionGizmos.NativeMethodInfoPtr_GetObjectSelectionGizmo_Private_ObjectSelectionGizmo_Gizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, 100670058);
			RTObjectSelectionGizmos.NativeMethodInfoPtr_GetObjectSelectionGizmo_Private_ObjectSelectionGizmo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, 100670059);
			RTObjectSelectionGizmos.NativeMethodInfoPtr_IsGizmoRegistered_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, 100670060);
			RTObjectSelectionGizmos.NativeMethodInfoPtr_IsGizmoRegistered_Private_Boolean_Gizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, 100670061);
			RTObjectSelectionGizmos.NativeMethodInfoPtr_RegisterGizmo_Private_Boolean_Int32_Gizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, 100670062);
		}

		// Token: 0x17000FEC RID: 4076
		// (get) Token: 0x06002C5A RID: 11354 RVA: 0x000D0724 File Offset: 0x000CE924
		public unsafe bool AreGizmosVisible
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelectionGizmos.NativeMethodInfoPtr_get_AreGizmosVisible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000FED RID: 4077
		// (get) Token: 0x06002C5B RID: 11355 RVA: 0x000D0760 File Offset: 0x000CE960
		public unsafe GameObject PivotObject
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelectionGizmos.NativeMethodInfoPtr_get_PivotObject_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x17000FEE RID: 4078
		// (get) Token: 0x06002C5C RID: 11356 RVA: 0x000D07A0 File Offset: 0x000CE9A0
		public unsafe Gizmo WorkGizmo
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 95849, RefRangeEnd = 95851, XrefRangeStart = 95849, XrefRangeEnd = 95849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelectionGizmos.NativeMethodInfoPtr_get_WorkGizmo_Public_get_Gizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Gizmo>(intPtr3) : null;
			}
		}

		// Token: 0x17000FEF RID: 4079
		// (get) Token: 0x06002C5D RID: 11357 RVA: 0x000D07E0 File Offset: 0x000CE9E0
		public unsafe ObjectSelectionGizmosHotkeys Hotkeys
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelectionGizmos.NativeMethodInfoPtr_get_Hotkeys_Public_get_ObjectSelectionGizmosHotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectSelectionGizmosHotkeys>(intPtr3) : null;
			}
		}

		// Token: 0x17000FF0 RID: 4080
		// (get) Token: 0x06002C5E RID: 11358 RVA: 0x000D0820 File Offset: 0x000CEA20
		public unsafe MoveGizmoSettings2D MoveGizmoSettings2D
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelectionGizmos.NativeMethodInfoPtr_get_MoveGizmoSettings2D_Public_get_MoveGizmoSettings2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MoveGizmoSettings2D>(intPtr3) : null;
			}
		}

		// Token: 0x17000FF1 RID: 4081
		// (get) Token: 0x06002C5F RID: 11359 RVA: 0x000D0860 File Offset: 0x000CEA60
		public unsafe MoveGizmoSettings3D MoveGizmoSettings3D
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelectionGizmos.NativeMethodInfoPtr_get_MoveGizmoSettings3D_Public_get_MoveGizmoSettings3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MoveGizmoSettings3D>(intPtr3) : null;
			}
		}

		// Token: 0x17000FF2 RID: 4082
		// (get) Token: 0x06002C60 RID: 11360 RVA: 0x000D08A0 File Offset: 0x000CEAA0
		public unsafe MoveGizmoLookAndFeel2D MoveGizmoLookAndFeel2D
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelectionGizmos.NativeMethodInfoPtr_get_MoveGizmoLookAndFeel2D_Public_get_MoveGizmoLookAndFeel2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MoveGizmoLookAndFeel2D>(intPtr3) : null;
			}
		}

		// Token: 0x17000FF3 RID: 4083
		// (get) Token: 0x06002C61 RID: 11361 RVA: 0x000D08E0 File Offset: 0x000CEAE0
		public unsafe MoveGizmoLookAndFeel3D MoveGizmoLookAndFeel3D
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelectionGizmos.NativeMethodInfoPtr_get_MoveGizmoLookAndFeel3D_Public_get_MoveGizmoLookAndFeel3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MoveGizmoLookAndFeel3D>(intPtr3) : null;
			}
		}

		// Token: 0x17000FF4 RID: 4084
		// (get) Token: 0x06002C62 RID: 11362 RVA: 0x000D0920 File Offset: 0x000CEB20
		public unsafe MoveGizmoHotkeys MoveGizmoHotkeys
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelectionGizmos.NativeMethodInfoPtr_get_MoveGizmoHotkeys_Public_get_MoveGizmoHotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MoveGizmoHotkeys>(intPtr3) : null;
			}
		}

		// Token: 0x17000FF5 RID: 4085
		// (get) Token: 0x06002C63 RID: 11363 RVA: 0x000D0960 File Offset: 0x000CEB60
		public unsafe ObjectTransformGizmoSettings ObjectMoveGizmoSettings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelectionGizmos.NativeMethodInfoPtr_get_ObjectMoveGizmoSettings_Public_get_ObjectTransformGizmoSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectTransformGizmoSettings>(intPtr3) : null;
			}
		}

		// Token: 0x17000FF6 RID: 4086
		// (get) Token: 0x06002C64 RID: 11364 RVA: 0x000D09A0 File Offset: 0x000CEBA0
		public unsafe RotationGizmoSettings3D RotationGizmoSettings3D
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelectionGizmos.NativeMethodInfoPtr_get_RotationGizmoSettings3D_Public_get_RotationGizmoSettings3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RotationGizmoSettings3D>(intPtr3) : null;
			}
		}

		// Token: 0x17000FF7 RID: 4087
		// (get) Token: 0x06002C65 RID: 11365 RVA: 0x000D09E0 File Offset: 0x000CEBE0
		public unsafe RotationGizmoLookAndFeel3D RotationGizmoLookAndFeel3D
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelectionGizmos.NativeMethodInfoPtr_get_RotationGizmoLookAndFeel3D_Public_get_RotationGizmoLookAndFeel3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RotationGizmoLookAndFeel3D>(intPtr3) : null;
			}
		}

		// Token: 0x17000FF8 RID: 4088
		// (get) Token: 0x06002C66 RID: 11366 RVA: 0x000D0A20 File Offset: 0x000CEC20
		public unsafe RotationGizmoHotkeys RotationGizmoHotkeys
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelectionGizmos.NativeMethodInfoPtr_get_RotationGizmoHotkeys_Public_get_RotationGizmoHotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RotationGizmoHotkeys>(intPtr3) : null;
			}
		}

		// Token: 0x17000FF9 RID: 4089
		// (get) Token: 0x06002C67 RID: 11367 RVA: 0x000D0A60 File Offset: 0x000CEC60
		public unsafe ObjectTransformGizmoSettings ObjectRotationGizmoSettings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelectionGizmos.NativeMethodInfoPtr_get_ObjectRotationGizmoSettings_Public_get_ObjectTransformGizmoSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectTransformGizmoSettings>(intPtr3) : null;
			}
		}

		// Token: 0x17000FFA RID: 4090
		// (get) Token: 0x06002C68 RID: 11368 RVA: 0x000D0AA0 File Offset: 0x000CECA0
		public unsafe ScaleGizmoSettings3D ScaleGizmoSettings3D
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelectionGizmos.NativeMethodInfoPtr_get_ScaleGizmoSettings3D_Public_get_ScaleGizmoSettings3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScaleGizmoSettings3D>(intPtr3) : null;
			}
		}

		// Token: 0x17000FFB RID: 4091
		// (get) Token: 0x06002C69 RID: 11369 RVA: 0x000D0AE0 File Offset: 0x000CECE0
		public unsafe ScaleGizmoLookAndFeel3D ScaleGizmoLookAndFeel3D
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelectionGizmos.NativeMethodInfoPtr_get_ScaleGizmoLookAndFeel3D_Public_get_ScaleGizmoLookAndFeel3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScaleGizmoLookAndFeel3D>(intPtr3) : null;
			}
		}

		// Token: 0x17000FFC RID: 4092
		// (get) Token: 0x06002C6A RID: 11370 RVA: 0x000D0B20 File Offset: 0x000CED20
		public unsafe ScaleGizmoHotkeys ScaleGizmoHotkeys
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelectionGizmos.NativeMethodInfoPtr_get_ScaleGizmoHotkeys_Public_get_ScaleGizmoHotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScaleGizmoHotkeys>(intPtr3) : null;
			}
		}

		// Token: 0x17000FFD RID: 4093
		// (get) Token: 0x06002C6B RID: 11371 RVA: 0x000D0B60 File Offset: 0x000CED60
		public unsafe ObjectTransformGizmoSettings ObjectScaleGizmoSettings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelectionGizmos.NativeMethodInfoPtr_get_ObjectScaleGizmoSettings_Public_get_ObjectTransformGizmoSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectTransformGizmoSettings>(intPtr3) : null;
			}
		}

		// Token: 0x17000FFE RID: 4094
		// (get) Token: 0x06002C6C RID: 11372 RVA: 0x000D0BA0 File Offset: 0x000CEDA0
		public unsafe UniversalGizmoSettings2D UniversalGizmoSettings2D
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelectionGizmos.NativeMethodInfoPtr_get_UniversalGizmoSettings2D_Public_get_UniversalGizmoSettings2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UniversalGizmoSettings2D>(intPtr3) : null;
			}
		}

		// Token: 0x17000FFF RID: 4095
		// (get) Token: 0x06002C6D RID: 11373 RVA: 0x000D0BE0 File Offset: 0x000CEDE0
		public unsafe UniversalGizmoSettings3D UniversalGizmoSettings3D
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelectionGizmos.NativeMethodInfoPtr_get_UniversalGizmoSettings3D_Public_get_UniversalGizmoSettings3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UniversalGizmoSettings3D>(intPtr3) : null;
			}
		}

		// Token: 0x17001000 RID: 4096
		// (get) Token: 0x06002C6E RID: 11374 RVA: 0x000D0C20 File Offset: 0x000CEE20
		public unsafe UniversalGizmoLookAndFeel2D UniversalGizmoLookAndFeel2D
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelectionGizmos.NativeMethodInfoPtr_get_UniversalGizmoLookAndFeel2D_Public_get_UniversalGizmoLookAndFeel2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UniversalGizmoLookAndFeel2D>(intPtr3) : null;
			}
		}

		// Token: 0x17001001 RID: 4097
		// (get) Token: 0x06002C6F RID: 11375 RVA: 0x000D0C60 File Offset: 0x000CEE60
		public unsafe UniversalGizmoLookAndFeel3D UniversalGizmoLookAndFeel3D
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelectionGizmos.NativeMethodInfoPtr_get_UniversalGizmoLookAndFeel3D_Public_get_UniversalGizmoLookAndFeel3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UniversalGizmoLookAndFeel3D>(intPtr3) : null;
			}
		}

		// Token: 0x17001002 RID: 4098
		// (get) Token: 0x06002C70 RID: 11376 RVA: 0x000D0CA0 File Offset: 0x000CEEA0
		public unsafe UniversalGizmoHotkeys UniversalGizmoHotkeys
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelectionGizmos.NativeMethodInfoPtr_get_UniversalGizmoHotkeys_Public_get_UniversalGizmoHotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UniversalGizmoHotkeys>(intPtr3) : null;
			}
		}

		// Token: 0x17001003 RID: 4099
		// (get) Token: 0x06002C71 RID: 11377 RVA: 0x000D0CE0 File Offset: 0x000CEEE0
		public unsafe ObjectTransformGizmoSettings ObjectUniversalGizmoSettings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelectionGizmos.NativeMethodInfoPtr_get_ObjectUniversalGizmoSettings_Public_get_ObjectTransformGizmoSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectTransformGizmoSettings>(intPtr3) : null;
			}
		}

		// Token: 0x17001004 RID: 4100
		// (get) Token: 0x06002C72 RID: 11378 RVA: 0x000D0D20 File Offset: 0x000CEF20
		public unsafe BoxGizmoSettings3D BoxScaleGizmoSettings3D
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelectionGizmos.NativeMethodInfoPtr_get_BoxScaleGizmoSettings3D_Public_get_BoxGizmoSettings3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BoxGizmoSettings3D>(intPtr3) : null;
			}
		}

		// Token: 0x17001005 RID: 4101
		// (get) Token: 0x06002C73 RID: 11379 RVA: 0x000D0D60 File Offset: 0x000CEF60
		public unsafe BoxGizmoLookAndFeel3D BoxScaleGizmoLookAndFeel3D
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelectionGizmos.NativeMethodInfoPtr_get_BoxScaleGizmoLookAndFeel3D_Public_get_BoxGizmoLookAndFeel3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BoxGizmoLookAndFeel3D>(intPtr3) : null;
			}
		}

		// Token: 0x17001006 RID: 4102
		// (get) Token: 0x06002C74 RID: 11380 RVA: 0x000D0DA0 File Offset: 0x000CEFA0
		public unsafe BoxGizmoHotkeys BoxScaleGizmoHotkeys
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelectionGizmos.NativeMethodInfoPtr_get_BoxScaleGizmoHotkeys_Public_get_BoxGizmoHotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BoxGizmoHotkeys>(intPtr3) : null;
			}
		}

		// Token: 0x17001007 RID: 4103
		// (get) Token: 0x06002C75 RID: 11381 RVA: 0x000D0DE0 File Offset: 0x000CEFE0
		public unsafe ObjectExtrudeGizmoLookAndFeel3D ExtrudeGizmoLookAndFeel3D
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelectionGizmos.NativeMethodInfoPtr_get_ExtrudeGizmoLookAndFeel3D_Public_get_ObjectExtrudeGizmoLookAndFeel3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectExtrudeGizmoLookAndFeel3D>(intPtr3) : null;
			}
		}

		// Token: 0x17001008 RID: 4104
		// (get) Token: 0x06002C76 RID: 11382 RVA: 0x000D0E20 File Offset: 0x000CF020
		public unsafe ObjectExtrudeGizmoHotkeys ExtrudeGozmoHotkeys
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelectionGizmos.NativeMethodInfoPtr_get_ExtrudeGozmoHotkeys_Public_get_ObjectExtrudeGizmoHotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectExtrudeGizmoHotkeys>(intPtr3) : null;
			}
		}

		// Token: 0x06002C77 RID: 11383 RVA: 0x000D0E60 File Offset: 0x000CF060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95851, XrefRangeEnd = 96096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RTObjectSelectionGizmos()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelectionGizmos.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C78 RID: 11384 RVA: 0x000D0E9C File Offset: 0x000CF09C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetTargetObjectCollection(IEnumerable<GameObject> targetObjectCollection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetObjectCollection);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelectionGizmos.NativeMethodInfoPtr_SetTargetObjectCollection_Public_Virtual_Final_New_Void_IEnumerable_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C79 RID: 11385 RVA: 0x000D0EE0 File Offset: 0x000CF0E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 96257, RefRangeEnd = 96258, XrefRangeStart = 96096, XrefRangeEnd = 96257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize_SystemCall()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelectionGizmos.NativeMethodInfoPtr_Initialize_SystemCall_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C7A RID: 11386 RVA: 0x000D0F14 File Offset: 0x000CF114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96258, XrefRangeEnd = 96260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGizmoUsable(int gizmoId, bool isUsable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref gizmoId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isUsable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelectionGizmos.NativeMethodInfoPtr_SetGizmoUsable_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C7B RID: 11387 RVA: 0x000D0F60 File Offset: 0x000CF160
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 96261, RefRangeEnd = 96265, XrefRangeStart = 96260, XrefRangeEnd = 96261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Gizmo GetGizmoById(int gizmoId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref gizmoId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelectionGizmos.NativeMethodInfoPtr_GetGizmoById_Public_Gizmo_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Gizmo>(intPtr3) : null;
			}
		}

		// Token: 0x06002C7C RID: 11388 RVA: 0x000D0FAC File Offset: 0x000CF1AC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 96292, RefRangeEnd = 96295, XrefRangeStart = 96265, XrefRangeEnd = 96292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Gizmo> GetAllGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelectionGizmos.NativeMethodInfoPtr_GetAllGizmos_Public_List_1_Gizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Gizmo>>(intPtr3) : null;
		}

		// Token: 0x06002C7D RID: 11389 RVA: 0x000D0FEC File Offset: 0x000CF1EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96295, XrefRangeEnd = 96313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetGizmoId(Gizmo gizmo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gizmo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelectionGizmos.NativeMethodInfoPtr_GetGizmoId_Public_Int32_Gizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C7E RID: 11390 RVA: 0x000D103C File Offset: 0x000CF23C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96313, XrefRangeEnd = 96333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectTransformGizmo GetTransformGizmoById(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelectionGizmos.NativeMethodInfoPtr_GetTransformGizmoById_Public_ObjectTransformGizmo_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectTransformGizmo>(intPtr3) : null;
			}
		}

		// Token: 0x06002C7F RID: 11391 RVA: 0x000D1088 File Offset: 0x000CF288
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 96348, RefRangeEnd = 96349, XrefRangeStart = 96333, XrefRangeEnd = 96348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTransformPivot(GizmoObjectTransformPivot transformPivot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transformPivot);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelectionGizmos.NativeMethodInfoPtr_SetTransformPivot_Public_Void_GizmoObjectTransformPivot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C80 RID: 11392 RVA: 0x000D10CC File Offset: 0x000CF2CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 96366, RefRangeEnd = 96368, XrefRangeStart = 96349, XrefRangeEnd = 96366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTransformSpace(GizmoSpace transformSpace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transformSpace);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelectionGizmos.NativeMethodInfoPtr_SetTransformSpace_Public_Void_GizmoSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C81 RID: 11393 RVA: 0x000D1110 File Offset: 0x000CF310
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 96369, RefRangeEnd = 96370, XrefRangeStart = 96368, XrefRangeEnd = 96369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetWorkGizmo(int gizmoId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref gizmoId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelectionGizmos.NativeMethodInfoPtr_SetWorkGizmo_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C82 RID: 11394 RVA: 0x000D1150 File Offset: 0x000CF350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96370, XrefRangeEnd = 96387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGizmosVisisble(bool visible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref visible;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelectionGizmos.NativeMethodInfoPtr_SetGizmosVisisble_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C83 RID: 11395 RVA: 0x000D1190 File Offset: 0x000CF390
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 96417, RefRangeEnd = 96418, XrefRangeStart = 96387, XrefRangeEnd = 96417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update_SystemCall()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelectionGizmos.NativeMethodInfoPtr_Update_SystemCall_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C84 RID: 11396 RVA: 0x000D11C4 File Offset: 0x000CF3C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96418, XrefRangeEnd = 96451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnObjectSelectionChanged(ObjectSelectionChangedEventArgs args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelectionGizmos.NativeMethodInfoPtr_OnObjectSelectionChanged_Private_Void_ObjectSelectionChangedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C85 RID: 11397 RVA: 0x000D1208 File Offset: 0x000CF408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96451, XrefRangeEnd = 96452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnUndoRedo(IUndoRedoAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelectionGizmos.NativeMethodInfoPtr_OnUndoRedo_Private_Void_IUndoRedoAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C86 RID: 11398 RVA: 0x000D124C File Offset: 0x000CF44C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96452, XrefRangeEnd = 96454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGizmoPostEnabled(Gizmo gizmo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gizmo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelectionGizmos.NativeMethodInfoPtr_OnGizmoPostEnabled_Private_Void_Gizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C87 RID: 11399 RVA: 0x000D1290 File Offset: 0x000CF490
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 96476, RefRangeEnd = 96479, XrefRangeStart = 96454, XrefRangeEnd = 96476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTargetObjectGroupUpdated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelectionGizmos.NativeMethodInfoPtr_OnTargetObjectGroupUpdated_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C88 RID: 11400 RVA: 0x000D12C4 File Offset: 0x000CF4C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96479, XrefRangeEnd = 96496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnObjectSelectionManipSessionBegin(ObjectSelectionManipSession manipSession)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(manipSession);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelectionGizmos.NativeMethodInfoPtr_OnObjectSelectionManipSessionBegin_Private_Void_ObjectSelectionManipSession_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C89 RID: 11401 RVA: 0x000D1308 File Offset: 0x000CF508
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96496, XrefRangeEnd = 96498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnObjectSelectionManipSessionEnd(ObjectSelectionManipSession manipSession)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(manipSession);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelectionGizmos.NativeMethodInfoPtr_OnObjectSelectionManipSessionEnd_Private_Void_ObjectSelectionManipSession_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C8A RID: 11402 RVA: 0x000D134C File Offset: 0x000CF54C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96498, XrefRangeEnd = 96517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnObjectSelectionRotated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelectionGizmos.NativeMethodInfoPtr_OnObjectSelectionRotated_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C8B RID: 11403 RVA: 0x000D1380 File Offset: 0x000CF580
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnObjectSelectionEnabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelectionGizmos.NativeMethodInfoPtr_OnObjectSelectionEnabled_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C8C RID: 11404 RVA: 0x000D13B4 File Offset: 0x000CF5B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96517, XrefRangeEnd = 96534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnObjectSelectionDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelectionGizmos.NativeMethodInfoPtr_OnObjectSelectionDisabled_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C8D RID: 11405 RVA: 0x000D13E8 File Offset: 0x000CF5E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 96544, RefRangeEnd = 96546, XrefRangeStart = 96534, XrefRangeEnd = 96544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RTObjectSelectionGizmos.ObjectSelectionGizmo GetObjectSelectionGizmo(Gizmo gizmo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gizmo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelectionGizmos.NativeMethodInfoPtr_GetObjectSelectionGizmo_Private_ObjectSelectionGizmo_Gizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTObjectSelectionGizmos.ObjectSelectionGizmo>(intPtr3) : null;
			}
		}

		// Token: 0x06002C8E RID: 11406 RVA: 0x000D1438 File Offset: 0x000CF638
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 96556, RefRangeEnd = 96558, XrefRangeStart = 96546, XrefRangeEnd = 96556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RTObjectSelectionGizmos.ObjectSelectionGizmo GetObjectSelectionGizmo(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelectionGizmos.NativeMethodInfoPtr_GetObjectSelectionGizmo_Private_ObjectSelectionGizmo_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTObjectSelectionGizmos.ObjectSelectionGizmo>(intPtr3) : null;
			}
		}

		// Token: 0x06002C8F RID: 11407 RVA: 0x000D1484 File Offset: 0x000CF684
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 96572, RefRangeEnd = 96574, XrefRangeStart = 96558, XrefRangeEnd = 96572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsGizmoRegistered(int gizmoId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref gizmoId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelectionGizmos.NativeMethodInfoPtr_IsGizmoRegistered_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C90 RID: 11408 RVA: 0x000D14D0 File Offset: 0x000CF6D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96574, XrefRangeEnd = 96589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsGizmoRegistered(Gizmo gizmo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gizmo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelectionGizmos.NativeMethodInfoPtr_IsGizmoRegistered_Private_Boolean_Gizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C91 RID: 11409 RVA: 0x000D1520 File Offset: 0x000CF720
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 96692, RefRangeEnd = 96698, XrefRangeStart = 96589, XrefRangeEnd = 96692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool RegisterGizmo(int gizmoId, Gizmo gizmo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref gizmoId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(gizmo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelectionGizmos.NativeMethodInfoPtr_RegisterGizmo_Private_Boolean_Int32_Gizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C92 RID: 11410 RVA: 0x000118BF File Offset: 0x0000FABF
		public RTObjectSelectionGizmos(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000FC7 RID: 4039
		// (get) Token: 0x06002C93 RID: 11411 RVA: 0x000D157C File Offset: 0x000CF77C
		// (set) Token: 0x06002C94 RID: 11412 RVA: 0x000118C8 File Offset: 0x0000FAC8
		public unsafe EditorToolbar _mainToolbar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.NativeFieldInfoPtr__mainToolbar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EditorToolbar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.NativeFieldInfoPtr__mainToolbar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FC8 RID: 4040
		// (get) Token: 0x06002C95 RID: 11413 RVA: 0x000D15AC File Offset: 0x000CF7AC
		// (set) Token: 0x06002C96 RID: 11414 RVA: 0x000118E7 File Offset: 0x0000FAE7
		public unsafe UniversalGizmoConfig _universalGizmoConfig
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.NativeFieldInfoPtr__universalGizmoConfig);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UniversalGizmoConfig>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.NativeFieldInfoPtr__universalGizmoConfig), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FC9 RID: 4041
		// (get) Token: 0x06002C97 RID: 11415 RVA: 0x000D15DC File Offset: 0x000CF7DC
		// (set) Token: 0x06002C98 RID: 11416 RVA: 0x00011906 File Offset: 0x0000FB06
		public unsafe GizmoCollectionEnabledStateSnapshot _gizmosEnabledStateSnapshot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.NativeFieldInfoPtr__gizmosEnabledStateSnapshot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoCollectionEnabledStateSnapshot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.NativeFieldInfoPtr__gizmosEnabledStateSnapshot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FCA RID: 4042
		// (get) Token: 0x06002C99 RID: 11417 RVA: 0x000D160C File Offset: 0x000CF80C
		// (set) Token: 0x06002C9A RID: 11418 RVA: 0x00011925 File Offset: 0x0000FB25
		public unsafe List<RTObjectSelectionGizmos.ObjectSelectionGizmo> _allGizmos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.NativeFieldInfoPtr__allGizmos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RTObjectSelectionGizmos.ObjectSelectionGizmo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.NativeFieldInfoPtr__allGizmos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FCB RID: 4043
		// (get) Token: 0x06002C9B RID: 11419 RVA: 0x000D163C File Offset: 0x000CF83C
		// (set) Token: 0x06002C9C RID: 11420 RVA: 0x00011944 File Offset: 0x0000FB44
		public unsafe List<ObjectTransformGizmo> _objectTransformGizmos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.NativeFieldInfoPtr__objectTransformGizmos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ObjectTransformGizmo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.NativeFieldInfoPtr__objectTransformGizmos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FCC RID: 4044
		// (get) Token: 0x06002C9D RID: 11421 RVA: 0x000D166C File Offset: 0x000CF86C
		// (set) Token: 0x06002C9E RID: 11422 RVA: 0x00011963 File Offset: 0x0000FB63
		public unsafe int _workGizmoId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.NativeFieldInfoPtr__workGizmoId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.NativeFieldInfoPtr__workGizmoId)) = value;
			}
		}

		// Token: 0x17000FCD RID: 4045
		// (get) Token: 0x06002C9F RID: 11423 RVA: 0x000D1694 File Offset: 0x000CF894
		// (set) Token: 0x06002CA0 RID: 11424 RVA: 0x0001197E File Offset: 0x0000FB7E
		public unsafe RTObjectSelectionGizmos.ObjectSelectionGizmo _workGizmo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.NativeFieldInfoPtr__workGizmo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTObjectSelectionGizmos.ObjectSelectionGizmo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.NativeFieldInfoPtr__workGizmo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FCE RID: 4046
		// (get) Token: 0x06002CA1 RID: 11425 RVA: 0x000D16C4 File Offset: 0x000CF8C4
		// (set) Token: 0x06002CA2 RID: 11426 RVA: 0x0001199D File Offset: 0x0000FB9D
		public unsafe bool _areGizmosVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.NativeFieldInfoPtr__areGizmosVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.NativeFieldInfoPtr__areGizmosVisible)) = value;
			}
		}

		// Token: 0x17000FCF RID: 4047
		// (get) Token: 0x06002CA3 RID: 11427 RVA: 0x000D16EC File Offset: 0x000CF8EC
		// (set) Token: 0x06002CA4 RID: 11428 RVA: 0x000119B8 File Offset: 0x0000FBB8
		public unsafe GizmoSpace _transformSpace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.NativeFieldInfoPtr__transformSpace);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoSpace>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.NativeFieldInfoPtr__transformSpace), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FD0 RID: 4048
		// (get) Token: 0x06002CA5 RID: 11429 RVA: 0x000D171C File Offset: 0x000CF91C
		// (set) Token: 0x06002CA6 RID: 11430 RVA: 0x000119D7 File Offset: 0x0000FBD7
		public unsafe GameObject _pivotObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.NativeFieldInfoPtr__pivotObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.NativeFieldInfoPtr__pivotObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FD1 RID: 4049
		// (get) Token: 0x06002CA7 RID: 11431 RVA: 0x000D174C File Offset: 0x000CF94C
		// (set) Token: 0x06002CA8 RID: 11432 RVA: 0x000119F6 File Offset: 0x0000FBF6
		public unsafe IEnumerable<GameObject> _targetObjectCollection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.NativeFieldInfoPtr__targetObjectCollection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.NativeFieldInfoPtr__targetObjectCollection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FD2 RID: 4050
		// (get) Token: 0x06002CA9 RID: 11433 RVA: 0x000D177C File Offset: 0x000CF97C
		// (set) Token: 0x06002CAA RID: 11434 RVA: 0x00011A15 File Offset: 0x0000FC15
		public unsafe ObjectSelectionGizmosHotkeys _hotkeys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.NativeFieldInfoPtr__hotkeys);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectSelectionGizmosHotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.NativeFieldInfoPtr__hotkeys), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FD3 RID: 4051
		// (get) Token: 0x06002CAB RID: 11435 RVA: 0x000D17AC File Offset: 0x000CF9AC
		// (set) Token: 0x06002CAC RID: 11436 RVA: 0x00011A34 File Offset: 0x0000FC34
		public unsafe MoveGizmoSettings2D _moveGizmoSettings2D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.NativeFieldInfoPtr__moveGizmoSettings2D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MoveGizmoSettings2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.NativeFieldInfoPtr__moveGizmoSettings2D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FD4 RID: 4052
		// (get) Token: 0x06002CAD RID: 11437 RVA: 0x000D17DC File Offset: 0x000CF9DC
		// (set) Token: 0x06002CAE RID: 11438 RVA: 0x00011A53 File Offset: 0x0000FC53
		public unsafe MoveGizmoSettings3D _moveGizmoSettings3D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.NativeFieldInfoPtr__moveGizmoSettings3D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MoveGizmoSettings3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.NativeFieldInfoPtr__moveGizmoSettings3D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FD5 RID: 4053
		// (get) Token: 0x06002CAF RID: 11439 RVA: 0x000D180C File Offset: 0x000CFA0C
		// (set) Token: 0x06002CB0 RID: 11440 RVA: 0x00011A72 File Offset: 0x0000FC72
		public unsafe MoveGizmoLookAndFeel2D _moveGizmoLookAndFeel2D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.NativeFieldInfoPtr__moveGizmoLookAndFeel2D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MoveGizmoLookAndFeel2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.NativeFieldInfoPtr__moveGizmoLookAndFeel2D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FD6 RID: 4054
		// (get) Token: 0x06002CB1 RID: 11441 RVA: 0x000D183C File Offset: 0x000CFA3C
		// (set) Token: 0x06002CB2 RID: 11442 RVA: 0x00011A91 File Offset: 0x0000FC91
		public unsafe MoveGizmoLookAndFeel3D _moveGizmoLookAndFeel3D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.NativeFieldInfoPtr__moveGizmoLookAndFeel3D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MoveGizmoLookAndFeel3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.NativeFieldInfoPtr__moveGizmoLookAndFeel3D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FD7 RID: 4055
		// (get) Token: 0x06002CB3 RID: 11443 RVA: 0x000D186C File Offset: 0x000CFA6C
		// (set) Token: 0x06002CB4 RID: 11444 RVA: 0x00011AB0 File Offset: 0x0000FCB0
		public unsafe MoveGizmoHotkeys _moveGizmoHotkeys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.NativeFieldInfoPtr__moveGizmoHotkeys);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MoveGizmoHotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.NativeFieldInfoPtr__moveGizmoHotkeys), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FD8 RID: 4056
		// (get) Token: 0x06002CB5 RID: 11445 RVA: 0x000D189C File Offset: 0x000CFA9C
		// (set) Token: 0x06002CB6 RID: 11446 RVA: 0x00011ACF File Offset: 0x0000FCCF
		public unsafe ObjectTransformGizmoSettings _objectMoveGizmoSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.NativeFieldInfoPtr__objectMoveGizmoSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectTransformGizmoSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.NativeFieldInfoPtr__objectMoveGizmoSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FD9 RID: 4057
		// (get) Token: 0x06002CB7 RID: 11447 RVA: 0x000D18CC File Offset: 0x000CFACC
		// (set) Token: 0x06002CB8 RID: 11448 RVA: 0x00011AEE File Offset: 0x0000FCEE
		public unsafe RotationGizmoSettings3D _rotationGizmoSettings3D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.NativeFieldInfoPtr__rotationGizmoSettings3D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RotationGizmoSettings3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.NativeFieldInfoPtr__rotationGizmoSettings3D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FDA RID: 4058
		// (get) Token: 0x06002CB9 RID: 11449 RVA: 0x000D18FC File Offset: 0x000CFAFC
		// (set) Token: 0x06002CBA RID: 11450 RVA: 0x00011B0D File Offset: 0x0000FD0D
		public unsafe RotationGizmoLookAndFeel3D _rotationGizmoLookAndFeel3D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.NativeFieldInfoPtr__rotationGizmoLookAndFeel3D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RotationGizmoLookAndFeel3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.NativeFieldInfoPtr__rotationGizmoLookAndFeel3D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FDB RID: 4059
		// (get) Token: 0x06002CBB RID: 11451 RVA: 0x000D192C File Offset: 0x000CFB2C
		// (set) Token: 0x06002CBC RID: 11452 RVA: 0x00011B2C File Offset: 0x0000FD2C
		public unsafe RotationGizmoHotkeys _rotationGizmoHotkeys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.NativeFieldInfoPtr__rotationGizmoHotkeys);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RotationGizmoHotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.NativeFieldInfoPtr__rotationGizmoHotkeys), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FDC RID: 4060
		// (get) Token: 0x06002CBD RID: 11453 RVA: 0x000D195C File Offset: 0x000CFB5C
		// (set) Token: 0x06002CBE RID: 11454 RVA: 0x00011B4B File Offset: 0x0000FD4B
		public unsafe ObjectTransformGizmoSettings _objectRotationGizmoSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.NativeFieldInfoPtr__objectRotationGizmoSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectTransformGizmoSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.NativeFieldInfoPtr__objectRotationGizmoSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FDD RID: 4061
		// (get) Token: 0x06002CBF RID: 11455 RVA: 0x000D198C File Offset: 0x000CFB8C
		// (set) Token: 0x06002CC0 RID: 11456 RVA: 0x00011B6A File Offset: 0x0000FD6A
		public unsafe ScaleGizmoSettings3D _scaleGizmoSettings3D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.NativeFieldInfoPtr__scaleGizmoSettings3D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScaleGizmoSettings3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.NativeFieldInfoPtr__scaleGizmoSettings3D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FDE RID: 4062
		// (get) Token: 0x06002CC1 RID: 11457 RVA: 0x000D19BC File Offset: 0x000CFBBC
		// (set) Token: 0x06002CC2 RID: 11458 RVA: 0x00011B89 File Offset: 0x0000FD89
		public unsafe ScaleGizmoLookAndFeel3D _scaleGizmoLookAndFeel3D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.NativeFieldInfoPtr__scaleGizmoLookAndFeel3D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScaleGizmoLookAndFeel3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.NativeFieldInfoPtr__scaleGizmoLookAndFeel3D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FDF RID: 4063
		// (get) Token: 0x06002CC3 RID: 11459 RVA: 0x000D19EC File Offset: 0x000CFBEC
		// (set) Token: 0x06002CC4 RID: 11460 RVA: 0x00011BA8 File Offset: 0x0000FDA8
		public unsafe ScaleGizmoHotkeys _scaleGizmoHotkeys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.NativeFieldInfoPtr__scaleGizmoHotkeys);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScaleGizmoHotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.NativeFieldInfoPtr__scaleGizmoHotkeys), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FE0 RID: 4064
		// (get) Token: 0x06002CC5 RID: 11461 RVA: 0x000D1A1C File Offset: 0x000CFC1C
		// (set) Token: 0x06002CC6 RID: 11462 RVA: 0x00011BC7 File Offset: 0x0000FDC7
		public unsafe ObjectTransformGizmoSettings _objectScaleGizmoSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.NativeFieldInfoPtr__objectScaleGizmoSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectTransformGizmoSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.NativeFieldInfoPtr__objectScaleGizmoSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FE1 RID: 4065
		// (get) Token: 0x06002CC7 RID: 11463 RVA: 0x000D1A4C File Offset: 0x000CFC4C
		// (set) Token: 0x06002CC8 RID: 11464 RVA: 0x00011BE6 File Offset: 0x0000FDE6
		public unsafe UniversalGizmoSettings2D _universalGizmoSettings2D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.NativeFieldInfoPtr__universalGizmoSettings2D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UniversalGizmoSettings2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.NativeFieldInfoPtr__universalGizmoSettings2D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FE2 RID: 4066
		// (get) Token: 0x06002CC9 RID: 11465 RVA: 0x000D1A7C File Offset: 0x000CFC7C
		// (set) Token: 0x06002CCA RID: 11466 RVA: 0x00011C05 File Offset: 0x0000FE05
		public unsafe UniversalGizmoSettings3D _universalGizmoSettings3D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.NativeFieldInfoPtr__universalGizmoSettings3D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UniversalGizmoSettings3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.NativeFieldInfoPtr__universalGizmoSettings3D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FE3 RID: 4067
		// (get) Token: 0x06002CCB RID: 11467 RVA: 0x000D1AAC File Offset: 0x000CFCAC
		// (set) Token: 0x06002CCC RID: 11468 RVA: 0x00011C24 File Offset: 0x0000FE24
		public unsafe UniversalGizmoLookAndFeel2D _universalGizmoLookAndFeel2D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.NativeFieldInfoPtr__universalGizmoLookAndFeel2D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UniversalGizmoLookAndFeel2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.NativeFieldInfoPtr__universalGizmoLookAndFeel2D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FE4 RID: 4068
		// (get) Token: 0x06002CCD RID: 11469 RVA: 0x000D1ADC File Offset: 0x000CFCDC
		// (set) Token: 0x06002CCE RID: 11470 RVA: 0x00011C43 File Offset: 0x0000FE43
		public unsafe UniversalGizmoLookAndFeel3D _universalGizmoLookAndFeel3D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.NativeFieldInfoPtr__universalGizmoLookAndFeel3D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UniversalGizmoLookAndFeel3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.NativeFieldInfoPtr__universalGizmoLookAndFeel3D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FE5 RID: 4069
		// (get) Token: 0x06002CCF RID: 11471 RVA: 0x000D1B0C File Offset: 0x000CFD0C
		// (set) Token: 0x06002CD0 RID: 11472 RVA: 0x00011C62 File Offset: 0x0000FE62
		public unsafe UniversalGizmoHotkeys _universalGizmoHotkeys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.NativeFieldInfoPtr__universalGizmoHotkeys);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UniversalGizmoHotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.NativeFieldInfoPtr__universalGizmoHotkeys), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FE6 RID: 4070
		// (get) Token: 0x06002CD1 RID: 11473 RVA: 0x000D1B3C File Offset: 0x000CFD3C
		// (set) Token: 0x06002CD2 RID: 11474 RVA: 0x00011C81 File Offset: 0x0000FE81
		public unsafe ObjectTransformGizmoSettings _objectUniversalGizmoSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.NativeFieldInfoPtr__objectUniversalGizmoSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectTransformGizmoSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.NativeFieldInfoPtr__objectUniversalGizmoSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FE7 RID: 4071
		// (get) Token: 0x06002CD3 RID: 11475 RVA: 0x000D1B6C File Offset: 0x000CFD6C
		// (set) Token: 0x06002CD4 RID: 11476 RVA: 0x00011CA0 File Offset: 0x0000FEA0
		public unsafe BoxGizmoSettings3D _boxScaleGizmoSettings3D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.NativeFieldInfoPtr__boxScaleGizmoSettings3D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxGizmoSettings3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.NativeFieldInfoPtr__boxScaleGizmoSettings3D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FE8 RID: 4072
		// (get) Token: 0x06002CD5 RID: 11477 RVA: 0x000D1B9C File Offset: 0x000CFD9C
		// (set) Token: 0x06002CD6 RID: 11478 RVA: 0x00011CBF File Offset: 0x0000FEBF
		public unsafe BoxGizmoLookAndFeel3D _boxScaleGizmoLookAndFeel3D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.NativeFieldInfoPtr__boxScaleGizmoLookAndFeel3D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxGizmoLookAndFeel3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.NativeFieldInfoPtr__boxScaleGizmoLookAndFeel3D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FE9 RID: 4073
		// (get) Token: 0x06002CD7 RID: 11479 RVA: 0x000D1BCC File Offset: 0x000CFDCC
		// (set) Token: 0x06002CD8 RID: 11480 RVA: 0x00011CDE File Offset: 0x0000FEDE
		public unsafe BoxGizmoHotkeys _boxScaleGizmoHotkeys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.NativeFieldInfoPtr__boxScaleGizmoHotkeys);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxGizmoHotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.NativeFieldInfoPtr__boxScaleGizmoHotkeys), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FEA RID: 4074
		// (get) Token: 0x06002CD9 RID: 11481 RVA: 0x000D1BFC File Offset: 0x000CFDFC
		// (set) Token: 0x06002CDA RID: 11482 RVA: 0x00011CFD File Offset: 0x0000FEFD
		public unsafe ObjectExtrudeGizmoLookAndFeel3D _extrudeGizmoLookAndFeel3D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.NativeFieldInfoPtr__extrudeGizmoLookAndFeel3D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectExtrudeGizmoLookAndFeel3D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.NativeFieldInfoPtr__extrudeGizmoLookAndFeel3D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FEB RID: 4075
		// (get) Token: 0x06002CDB RID: 11483 RVA: 0x000D1C2C File Offset: 0x000CFE2C
		// (set) Token: 0x06002CDC RID: 11484 RVA: 0x00011D1C File Offset: 0x0000FF1C
		public unsafe ObjectExtrudeGizmoHotkeys _extrudeGizmoHotkeys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.NativeFieldInfoPtr__extrudeGizmoHotkeys);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectExtrudeGizmoHotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.NativeFieldInfoPtr__extrudeGizmoHotkeys), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400222B RID: 8747
		private static readonly IntPtr NativeFieldInfoPtr__mainToolbar;

		// Token: 0x0400222C RID: 8748
		private static readonly IntPtr NativeFieldInfoPtr__universalGizmoConfig;

		// Token: 0x0400222D RID: 8749
		private static readonly IntPtr NativeFieldInfoPtr__gizmosEnabledStateSnapshot;

		// Token: 0x0400222E RID: 8750
		private static readonly IntPtr NativeFieldInfoPtr__allGizmos;

		// Token: 0x0400222F RID: 8751
		private static readonly IntPtr NativeFieldInfoPtr__objectTransformGizmos;

		// Token: 0x04002230 RID: 8752
		private static readonly IntPtr NativeFieldInfoPtr__workGizmoId;

		// Token: 0x04002231 RID: 8753
		private static readonly IntPtr NativeFieldInfoPtr__workGizmo;

		// Token: 0x04002232 RID: 8754
		private static readonly IntPtr NativeFieldInfoPtr__areGizmosVisible;

		// Token: 0x04002233 RID: 8755
		private static readonly IntPtr NativeFieldInfoPtr__transformSpace;

		// Token: 0x04002234 RID: 8756
		private static readonly IntPtr NativeFieldInfoPtr__pivotObject;

		// Token: 0x04002235 RID: 8757
		private static readonly IntPtr NativeFieldInfoPtr__targetObjectCollection;

		// Token: 0x04002236 RID: 8758
		private static readonly IntPtr NativeFieldInfoPtr__hotkeys;

		// Token: 0x04002237 RID: 8759
		private static readonly IntPtr NativeFieldInfoPtr__moveGizmoSettings2D;

		// Token: 0x04002238 RID: 8760
		private static readonly IntPtr NativeFieldInfoPtr__moveGizmoSettings3D;

		// Token: 0x04002239 RID: 8761
		private static readonly IntPtr NativeFieldInfoPtr__moveGizmoLookAndFeel2D;

		// Token: 0x0400223A RID: 8762
		private static readonly IntPtr NativeFieldInfoPtr__moveGizmoLookAndFeel3D;

		// Token: 0x0400223B RID: 8763
		private static readonly IntPtr NativeFieldInfoPtr__moveGizmoHotkeys;

		// Token: 0x0400223C RID: 8764
		private static readonly IntPtr NativeFieldInfoPtr__objectMoveGizmoSettings;

		// Token: 0x0400223D RID: 8765
		private static readonly IntPtr NativeFieldInfoPtr__rotationGizmoSettings3D;

		// Token: 0x0400223E RID: 8766
		private static readonly IntPtr NativeFieldInfoPtr__rotationGizmoLookAndFeel3D;

		// Token: 0x0400223F RID: 8767
		private static readonly IntPtr NativeFieldInfoPtr__rotationGizmoHotkeys;

		// Token: 0x04002240 RID: 8768
		private static readonly IntPtr NativeFieldInfoPtr__objectRotationGizmoSettings;

		// Token: 0x04002241 RID: 8769
		private static readonly IntPtr NativeFieldInfoPtr__scaleGizmoSettings3D;

		// Token: 0x04002242 RID: 8770
		private static readonly IntPtr NativeFieldInfoPtr__scaleGizmoLookAndFeel3D;

		// Token: 0x04002243 RID: 8771
		private static readonly IntPtr NativeFieldInfoPtr__scaleGizmoHotkeys;

		// Token: 0x04002244 RID: 8772
		private static readonly IntPtr NativeFieldInfoPtr__objectScaleGizmoSettings;

		// Token: 0x04002245 RID: 8773
		private static readonly IntPtr NativeFieldInfoPtr__universalGizmoSettings2D;

		// Token: 0x04002246 RID: 8774
		private static readonly IntPtr NativeFieldInfoPtr__universalGizmoSettings3D;

		// Token: 0x04002247 RID: 8775
		private static readonly IntPtr NativeFieldInfoPtr__universalGizmoLookAndFeel2D;

		// Token: 0x04002248 RID: 8776
		private static readonly IntPtr NativeFieldInfoPtr__universalGizmoLookAndFeel3D;

		// Token: 0x04002249 RID: 8777
		private static readonly IntPtr NativeFieldInfoPtr__universalGizmoHotkeys;

		// Token: 0x0400224A RID: 8778
		private static readonly IntPtr NativeFieldInfoPtr__objectUniversalGizmoSettings;

		// Token: 0x0400224B RID: 8779
		private static readonly IntPtr NativeFieldInfoPtr__boxScaleGizmoSettings3D;

		// Token: 0x0400224C RID: 8780
		private static readonly IntPtr NativeFieldInfoPtr__boxScaleGizmoLookAndFeel3D;

		// Token: 0x0400224D RID: 8781
		private static readonly IntPtr NativeFieldInfoPtr__boxScaleGizmoHotkeys;

		// Token: 0x0400224E RID: 8782
		private static readonly IntPtr NativeFieldInfoPtr__extrudeGizmoLookAndFeel3D;

		// Token: 0x0400224F RID: 8783
		private static readonly IntPtr NativeFieldInfoPtr__extrudeGizmoHotkeys;

		// Token: 0x04002250 RID: 8784
		private static readonly IntPtr NativeMethodInfoPtr_get_AreGizmosVisible_Public_get_Boolean_0;

		// Token: 0x04002251 RID: 8785
		private static readonly IntPtr NativeMethodInfoPtr_get_PivotObject_Public_get_GameObject_0;

		// Token: 0x04002252 RID: 8786
		private static readonly IntPtr NativeMethodInfoPtr_get_WorkGizmo_Public_get_Gizmo_0;

		// Token: 0x04002253 RID: 8787
		private static readonly IntPtr NativeMethodInfoPtr_get_Hotkeys_Public_get_ObjectSelectionGizmosHotkeys_0;

		// Token: 0x04002254 RID: 8788
		private static readonly IntPtr NativeMethodInfoPtr_get_MoveGizmoSettings2D_Public_get_MoveGizmoSettings2D_0;

		// Token: 0x04002255 RID: 8789
		private static readonly IntPtr NativeMethodInfoPtr_get_MoveGizmoSettings3D_Public_get_MoveGizmoSettings3D_0;

		// Token: 0x04002256 RID: 8790
		private static readonly IntPtr NativeMethodInfoPtr_get_MoveGizmoLookAndFeel2D_Public_get_MoveGizmoLookAndFeel2D_0;

		// Token: 0x04002257 RID: 8791
		private static readonly IntPtr NativeMethodInfoPtr_get_MoveGizmoLookAndFeel3D_Public_get_MoveGizmoLookAndFeel3D_0;

		// Token: 0x04002258 RID: 8792
		private static readonly IntPtr NativeMethodInfoPtr_get_MoveGizmoHotkeys_Public_get_MoveGizmoHotkeys_0;

		// Token: 0x04002259 RID: 8793
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectMoveGizmoSettings_Public_get_ObjectTransformGizmoSettings_0;

		// Token: 0x0400225A RID: 8794
		private static readonly IntPtr NativeMethodInfoPtr_get_RotationGizmoSettings3D_Public_get_RotationGizmoSettings3D_0;

		// Token: 0x0400225B RID: 8795
		private static readonly IntPtr NativeMethodInfoPtr_get_RotationGizmoLookAndFeel3D_Public_get_RotationGizmoLookAndFeel3D_0;

		// Token: 0x0400225C RID: 8796
		private static readonly IntPtr NativeMethodInfoPtr_get_RotationGizmoHotkeys_Public_get_RotationGizmoHotkeys_0;

		// Token: 0x0400225D RID: 8797
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectRotationGizmoSettings_Public_get_ObjectTransformGizmoSettings_0;

		// Token: 0x0400225E RID: 8798
		private static readonly IntPtr NativeMethodInfoPtr_get_ScaleGizmoSettings3D_Public_get_ScaleGizmoSettings3D_0;

		// Token: 0x0400225F RID: 8799
		private static readonly IntPtr NativeMethodInfoPtr_get_ScaleGizmoLookAndFeel3D_Public_get_ScaleGizmoLookAndFeel3D_0;

		// Token: 0x04002260 RID: 8800
		private static readonly IntPtr NativeMethodInfoPtr_get_ScaleGizmoHotkeys_Public_get_ScaleGizmoHotkeys_0;

		// Token: 0x04002261 RID: 8801
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectScaleGizmoSettings_Public_get_ObjectTransformGizmoSettings_0;

		// Token: 0x04002262 RID: 8802
		private static readonly IntPtr NativeMethodInfoPtr_get_UniversalGizmoSettings2D_Public_get_UniversalGizmoSettings2D_0;

		// Token: 0x04002263 RID: 8803
		private static readonly IntPtr NativeMethodInfoPtr_get_UniversalGizmoSettings3D_Public_get_UniversalGizmoSettings3D_0;

		// Token: 0x04002264 RID: 8804
		private static readonly IntPtr NativeMethodInfoPtr_get_UniversalGizmoLookAndFeel2D_Public_get_UniversalGizmoLookAndFeel2D_0;

		// Token: 0x04002265 RID: 8805
		private static readonly IntPtr NativeMethodInfoPtr_get_UniversalGizmoLookAndFeel3D_Public_get_UniversalGizmoLookAndFeel3D_0;

		// Token: 0x04002266 RID: 8806
		private static readonly IntPtr NativeMethodInfoPtr_get_UniversalGizmoHotkeys_Public_get_UniversalGizmoHotkeys_0;

		// Token: 0x04002267 RID: 8807
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectUniversalGizmoSettings_Public_get_ObjectTransformGizmoSettings_0;

		// Token: 0x04002268 RID: 8808
		private static readonly IntPtr NativeMethodInfoPtr_get_BoxScaleGizmoSettings3D_Public_get_BoxGizmoSettings3D_0;

		// Token: 0x04002269 RID: 8809
		private static readonly IntPtr NativeMethodInfoPtr_get_BoxScaleGizmoLookAndFeel3D_Public_get_BoxGizmoLookAndFeel3D_0;

		// Token: 0x0400226A RID: 8810
		private static readonly IntPtr NativeMethodInfoPtr_get_BoxScaleGizmoHotkeys_Public_get_BoxGizmoHotkeys_0;

		// Token: 0x0400226B RID: 8811
		private static readonly IntPtr NativeMethodInfoPtr_get_ExtrudeGizmoLookAndFeel3D_Public_get_ObjectExtrudeGizmoLookAndFeel3D_0;

		// Token: 0x0400226C RID: 8812
		private static readonly IntPtr NativeMethodInfoPtr_get_ExtrudeGozmoHotkeys_Public_get_ObjectExtrudeGizmoHotkeys_0;

		// Token: 0x0400226D RID: 8813
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400226E RID: 8814
		private static readonly IntPtr NativeMethodInfoPtr_SetTargetObjectCollection_Public_Virtual_Final_New_Void_IEnumerable_1_GameObject_0;

		// Token: 0x0400226F RID: 8815
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_SystemCall_Public_Void_0;

		// Token: 0x04002270 RID: 8816
		private static readonly IntPtr NativeMethodInfoPtr_SetGizmoUsable_Public_Void_Int32_Boolean_0;

		// Token: 0x04002271 RID: 8817
		private static readonly IntPtr NativeMethodInfoPtr_GetGizmoById_Public_Gizmo_Int32_0;

		// Token: 0x04002272 RID: 8818
		private static readonly IntPtr NativeMethodInfoPtr_GetAllGizmos_Public_List_1_Gizmo_0;

		// Token: 0x04002273 RID: 8819
		private static readonly IntPtr NativeMethodInfoPtr_GetGizmoId_Public_Int32_Gizmo_0;

		// Token: 0x04002274 RID: 8820
		private static readonly IntPtr NativeMethodInfoPtr_GetTransformGizmoById_Public_ObjectTransformGizmo_Int32_0;

		// Token: 0x04002275 RID: 8821
		private static readonly IntPtr NativeMethodInfoPtr_SetTransformPivot_Public_Void_GizmoObjectTransformPivot_0;

		// Token: 0x04002276 RID: 8822
		private static readonly IntPtr NativeMethodInfoPtr_SetTransformSpace_Public_Void_GizmoSpace_0;

		// Token: 0x04002277 RID: 8823
		private static readonly IntPtr NativeMethodInfoPtr_SetWorkGizmo_Public_Void_Int32_0;

		// Token: 0x04002278 RID: 8824
		private static readonly IntPtr NativeMethodInfoPtr_SetGizmosVisisble_Public_Void_Boolean_0;

		// Token: 0x04002279 RID: 8825
		private static readonly IntPtr NativeMethodInfoPtr_Update_SystemCall_Public_Void_0;

		// Token: 0x0400227A RID: 8826
		private static readonly IntPtr NativeMethodInfoPtr_OnObjectSelectionChanged_Private_Void_ObjectSelectionChangedEventArgs_0;

		// Token: 0x0400227B RID: 8827
		private static readonly IntPtr NativeMethodInfoPtr_OnUndoRedo_Private_Void_IUndoRedoAction_0;

		// Token: 0x0400227C RID: 8828
		private static readonly IntPtr NativeMethodInfoPtr_OnGizmoPostEnabled_Private_Void_Gizmo_0;

		// Token: 0x0400227D RID: 8829
		private static readonly IntPtr NativeMethodInfoPtr_OnTargetObjectGroupUpdated_Private_Void_0;

		// Token: 0x0400227E RID: 8830
		private static readonly IntPtr NativeMethodInfoPtr_OnObjectSelectionManipSessionBegin_Private_Void_ObjectSelectionManipSession_0;

		// Token: 0x0400227F RID: 8831
		private static readonly IntPtr NativeMethodInfoPtr_OnObjectSelectionManipSessionEnd_Private_Void_ObjectSelectionManipSession_0;

		// Token: 0x04002280 RID: 8832
		private static readonly IntPtr NativeMethodInfoPtr_OnObjectSelectionRotated_Private_Void_0;

		// Token: 0x04002281 RID: 8833
		private static readonly IntPtr NativeMethodInfoPtr_OnObjectSelectionEnabled_Private_Void_0;

		// Token: 0x04002282 RID: 8834
		private static readonly IntPtr NativeMethodInfoPtr_OnObjectSelectionDisabled_Private_Void_0;

		// Token: 0x04002283 RID: 8835
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectSelectionGizmo_Private_ObjectSelectionGizmo_Gizmo_0;

		// Token: 0x04002284 RID: 8836
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectSelectionGizmo_Private_ObjectSelectionGizmo_Int32_0;

		// Token: 0x04002285 RID: 8837
		private static readonly IntPtr NativeMethodInfoPtr_IsGizmoRegistered_Private_Boolean_Int32_0;

		// Token: 0x04002286 RID: 8838
		private static readonly IntPtr NativeMethodInfoPtr_IsGizmoRegistered_Private_Boolean_Gizmo_0;

		// Token: 0x04002287 RID: 8839
		private static readonly IntPtr NativeMethodInfoPtr_RegisterGizmo_Private_Boolean_Int32_Gizmo_0;

		// Token: 0x020003D8 RID: 984
		public class ObjectSelectionGizmo : global::Il2CppSystem.Object
		{
			// Token: 0x06004CE7 RID: 19687 RVA: 0x0014EB48 File Offset: 0x0014CD48
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectSelectionGizmo()
			{
				Il2CppClassPointerStore<RTObjectSelectionGizmos.ObjectSelectionGizmo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, "ObjectSelectionGizmo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTObjectSelectionGizmos.ObjectSelectionGizmo>.NativeClassPtr);
				RTObjectSelectionGizmos.ObjectSelectionGizmo.NativeFieldInfoPtr__id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelectionGizmos.ObjectSelectionGizmo>.NativeClassPtr, "_id");
				RTObjectSelectionGizmos.ObjectSelectionGizmo.NativeFieldInfoPtr__gizmo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelectionGizmos.ObjectSelectionGizmo>.NativeClassPtr, "_gizmo");
				RTObjectSelectionGizmos.ObjectSelectionGizmo.NativeFieldInfoPtr__boxScaleGizmo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelectionGizmos.ObjectSelectionGizmo>.NativeClassPtr, "_boxScaleGizmo");
				RTObjectSelectionGizmos.ObjectSelectionGizmo.NativeFieldInfoPtr__transformGizmo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelectionGizmos.ObjectSelectionGizmo>.NativeClassPtr, "_transformGizmo");
				RTObjectSelectionGizmos.ObjectSelectionGizmo.NativeFieldInfoPtr__extrudeGizmo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelectionGizmos.ObjectSelectionGizmo>.NativeClassPtr, "_extrudeGizmo");
				RTObjectSelectionGizmos.ObjectSelectionGizmo.NativeFieldInfoPtr__isUsable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelectionGizmos.ObjectSelectionGizmo>.NativeClassPtr, "_isUsable");
				RTObjectSelectionGizmos.ObjectSelectionGizmo.NativeMethodInfoPtr_get_Id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelectionGizmos.ObjectSelectionGizmo>.NativeClassPtr, 100670064);
				RTObjectSelectionGizmos.ObjectSelectionGizmo.NativeMethodInfoPtr_get_Gizmo_Public_get_Gizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelectionGizmos.ObjectSelectionGizmo>.NativeClassPtr, 100670065);
				RTObjectSelectionGizmos.ObjectSelectionGizmo.NativeMethodInfoPtr_get_BoxScaleGizmo_Public_get_BoxGizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelectionGizmos.ObjectSelectionGizmo>.NativeClassPtr, 100670066);
				RTObjectSelectionGizmos.ObjectSelectionGizmo.NativeMethodInfoPtr_get_IsBoxScaleGizmo_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelectionGizmos.ObjectSelectionGizmo>.NativeClassPtr, 100670067);
				RTObjectSelectionGizmos.ObjectSelectionGizmo.NativeMethodInfoPtr_get_TransformGizmo_Public_get_ObjectTransformGizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelectionGizmos.ObjectSelectionGizmo>.NativeClassPtr, 100670068);
				RTObjectSelectionGizmos.ObjectSelectionGizmo.NativeMethodInfoPtr_get_IsTransformGizmo_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelectionGizmos.ObjectSelectionGizmo>.NativeClassPtr, 100670069);
				RTObjectSelectionGizmos.ObjectSelectionGizmo.NativeMethodInfoPtr_get_ExtrudeGizmo_Public_get_ObjectExtrudeGizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelectionGizmos.ObjectSelectionGizmo>.NativeClassPtr, 100670070);
				RTObjectSelectionGizmos.ObjectSelectionGizmo.NativeMethodInfoPtr_get_IsExtrudeGizmo_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelectionGizmos.ObjectSelectionGizmo>.NativeClassPtr, 100670071);
				RTObjectSelectionGizmos.ObjectSelectionGizmo.NativeMethodInfoPtr_get_IsUsable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelectionGizmos.ObjectSelectionGizmo>.NativeClassPtr, 100670072);
				RTObjectSelectionGizmos.ObjectSelectionGizmo.NativeMethodInfoPtr_set_IsUsable_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelectionGizmos.ObjectSelectionGizmo>.NativeClassPtr, 100670073);
				RTObjectSelectionGizmos.ObjectSelectionGizmo.NativeMethodInfoPtr__ctor_Public_Void_Int32_Gizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelectionGizmos.ObjectSelectionGizmo>.NativeClassPtr, 100670074);
			}

			// Token: 0x170019ED RID: 6637
			// (get) Token: 0x06004CE8 RID: 19688 RVA: 0x0014ECC8 File Offset: 0x0014CEC8
			public unsafe int Id
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelectionGizmos.ObjectSelectionGizmo.NativeMethodInfoPtr_get_Id_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170019EE RID: 6638
			// (get) Token: 0x06004CE9 RID: 19689 RVA: 0x0014ED04 File Offset: 0x0014CF04
			public unsafe Gizmo Gizmo
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelectionGizmos.ObjectSelectionGizmo.NativeMethodInfoPtr_get_Gizmo_Public_get_Gizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Gizmo>(intPtr3) : null;
				}
			}

			// Token: 0x170019EF RID: 6639
			// (get) Token: 0x06004CEA RID: 19690 RVA: 0x0014ED44 File Offset: 0x0014CF44
			public unsafe BoxGizmo BoxScaleGizmo
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 21282, RefRangeEnd = 21289, XrefRangeStart = 21282, XrefRangeEnd = 21289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelectionGizmos.ObjectSelectionGizmo.NativeMethodInfoPtr_get_BoxScaleGizmo_Public_get_BoxGizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<BoxGizmo>(intPtr3) : null;
				}
			}

			// Token: 0x170019F0 RID: 6640
			// (get) Token: 0x06004CEB RID: 19691 RVA: 0x0014ED84 File Offset: 0x0014CF84
			public unsafe bool IsBoxScaleGizmo
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 58783, RefRangeEnd = 58797, XrefRangeStart = 58783, XrefRangeEnd = 58797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelectionGizmos.ObjectSelectionGizmo.NativeMethodInfoPtr_get_IsBoxScaleGizmo_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170019F1 RID: 6641
			// (get) Token: 0x06004CEC RID: 19692 RVA: 0x0014EDC0 File Offset: 0x0014CFC0
			public unsafe ObjectTransformGizmo TransformGizmo
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 21306, RefRangeEnd = 21309, XrefRangeStart = 21306, XrefRangeEnd = 21309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelectionGizmos.ObjectSelectionGizmo.NativeMethodInfoPtr_get_TransformGizmo_Public_get_ObjectTransformGizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectTransformGizmo>(intPtr3) : null;
				}
			}

			// Token: 0x170019F2 RID: 6642
			// (get) Token: 0x06004CED RID: 19693 RVA: 0x0014EE00 File Offset: 0x0014D000
			public unsafe bool IsTransformGizmo
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 58825, RefRangeEnd = 58826, XrefRangeStart = 58825, XrefRangeEnd = 58826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelectionGizmos.ObjectSelectionGizmo.NativeMethodInfoPtr_get_IsTransformGizmo_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170019F3 RID: 6643
			// (get) Token: 0x06004CEE RID: 19694 RVA: 0x0014EE3C File Offset: 0x0014D03C
			public unsafe ObjectExtrudeGizmo ExtrudeGizmo
			{
				[CallerCount(11)]
				[CachedScanResults(RefRangeStart = 21537, RefRangeEnd = 21548, XrefRangeStart = 21537, XrefRangeEnd = 21548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelectionGizmos.ObjectSelectionGizmo.NativeMethodInfoPtr_get_ExtrudeGizmo_Public_get_ObjectExtrudeGizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectExtrudeGizmo>(intPtr3) : null;
				}
			}

			// Token: 0x170019F4 RID: 6644
			// (get) Token: 0x06004CEF RID: 19695 RVA: 0x0014EE7C File Offset: 0x0014D07C
			public unsafe bool IsExtrudeGizmo
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 95834, RefRangeEnd = 95835, XrefRangeStart = 95834, XrefRangeEnd = 95834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelectionGizmos.ObjectSelectionGizmo.NativeMethodInfoPtr_get_IsExtrudeGizmo_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170019F5 RID: 6645
			// (get) Token: 0x06004CF0 RID: 19696 RVA: 0x0014EEB8 File Offset: 0x0014D0B8
			// (set) Token: 0x06004CF1 RID: 19697 RVA: 0x0014EEF4 File Offset: 0x0014D0F4
			public unsafe bool IsUsable
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelectionGizmos.ObjectSelectionGizmo.NativeMethodInfoPtr_get_IsUsable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelectionGizmos.ObjectSelectionGizmo.NativeMethodInfoPtr_set_IsUsable_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06004CF2 RID: 19698 RVA: 0x0014EF34 File Offset: 0x0014D134
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95835, XrefRangeEnd = 95849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectSelectionGizmo(int id, Gizmo gizmo)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTObjectSelectionGizmos.ObjectSelectionGizmo>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref id;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(gizmo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelectionGizmos.ObjectSelectionGizmo.NativeMethodInfoPtr__ctor_Public_Void_Int32_Gizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004CF3 RID: 19699 RVA: 0x0001CFEE File Offset: 0x0001B1EE
			public ObjectSelectionGizmo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170019E7 RID: 6631
			// (get) Token: 0x06004CF4 RID: 19700 RVA: 0x0014EF90 File Offset: 0x0014D190
			// (set) Token: 0x06004CF5 RID: 19701 RVA: 0x0001CFF7 File Offset: 0x0001B1F7
			public unsafe int _id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.ObjectSelectionGizmo.NativeFieldInfoPtr__id);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.ObjectSelectionGizmo.NativeFieldInfoPtr__id)) = value;
				}
			}

			// Token: 0x170019E8 RID: 6632
			// (get) Token: 0x06004CF6 RID: 19702 RVA: 0x0014EFB8 File Offset: 0x0014D1B8
			// (set) Token: 0x06004CF7 RID: 19703 RVA: 0x0001D012 File Offset: 0x0001B212
			public unsafe Gizmo _gizmo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.ObjectSelectionGizmo.NativeFieldInfoPtr__gizmo);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gizmo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.ObjectSelectionGizmo.NativeFieldInfoPtr__gizmo), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019E9 RID: 6633
			// (get) Token: 0x06004CF8 RID: 19704 RVA: 0x0014EFE8 File Offset: 0x0014D1E8
			// (set) Token: 0x06004CF9 RID: 19705 RVA: 0x0001D031 File Offset: 0x0001B231
			public unsafe BoxGizmo _boxScaleGizmo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.ObjectSelectionGizmo.NativeFieldInfoPtr__boxScaleGizmo);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxGizmo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.ObjectSelectionGizmo.NativeFieldInfoPtr__boxScaleGizmo), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019EA RID: 6634
			// (get) Token: 0x06004CFA RID: 19706 RVA: 0x0014F018 File Offset: 0x0014D218
			// (set) Token: 0x06004CFB RID: 19707 RVA: 0x0001D050 File Offset: 0x0001B250
			public unsafe ObjectTransformGizmo _transformGizmo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.ObjectSelectionGizmo.NativeFieldInfoPtr__transformGizmo);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectTransformGizmo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.ObjectSelectionGizmo.NativeFieldInfoPtr__transformGizmo), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019EB RID: 6635
			// (get) Token: 0x06004CFC RID: 19708 RVA: 0x0014F048 File Offset: 0x0014D248
			// (set) Token: 0x06004CFD RID: 19709 RVA: 0x0001D06F File Offset: 0x0001B26F
			public unsafe ObjectExtrudeGizmo _extrudeGizmo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.ObjectSelectionGizmo.NativeFieldInfoPtr__extrudeGizmo);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectExtrudeGizmo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.ObjectSelectionGizmo.NativeFieldInfoPtr__extrudeGizmo), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019EC RID: 6636
			// (get) Token: 0x06004CFE RID: 19710 RVA: 0x0014F078 File Offset: 0x0014D278
			// (set) Token: 0x06004CFF RID: 19711 RVA: 0x0001D08E File Offset: 0x0001B28E
			public unsafe bool _isUsable
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.ObjectSelectionGizmo.NativeFieldInfoPtr__isUsable);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.ObjectSelectionGizmo.NativeFieldInfoPtr__isUsable)) = value;
				}
			}

			// Token: 0x04003BCB RID: 15307
			private static readonly IntPtr NativeFieldInfoPtr__id;

			// Token: 0x04003BCC RID: 15308
			private static readonly IntPtr NativeFieldInfoPtr__gizmo;

			// Token: 0x04003BCD RID: 15309
			private static readonly IntPtr NativeFieldInfoPtr__boxScaleGizmo;

			// Token: 0x04003BCE RID: 15310
			private static readonly IntPtr NativeFieldInfoPtr__transformGizmo;

			// Token: 0x04003BCF RID: 15311
			private static readonly IntPtr NativeFieldInfoPtr__extrudeGizmo;

			// Token: 0x04003BD0 RID: 15312
			private static readonly IntPtr NativeFieldInfoPtr__isUsable;

			// Token: 0x04003BD1 RID: 15313
			private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_get_Int32_0;

			// Token: 0x04003BD2 RID: 15314
			private static readonly IntPtr NativeMethodInfoPtr_get_Gizmo_Public_get_Gizmo_0;

			// Token: 0x04003BD3 RID: 15315
			private static readonly IntPtr NativeMethodInfoPtr_get_BoxScaleGizmo_Public_get_BoxGizmo_0;

			// Token: 0x04003BD4 RID: 15316
			private static readonly IntPtr NativeMethodInfoPtr_get_IsBoxScaleGizmo_Public_get_Boolean_0;

			// Token: 0x04003BD5 RID: 15317
			private static readonly IntPtr NativeMethodInfoPtr_get_TransformGizmo_Public_get_ObjectTransformGizmo_0;

			// Token: 0x04003BD6 RID: 15318
			private static readonly IntPtr NativeMethodInfoPtr_get_IsTransformGizmo_Public_get_Boolean_0;

			// Token: 0x04003BD7 RID: 15319
			private static readonly IntPtr NativeMethodInfoPtr_get_ExtrudeGizmo_Public_get_ObjectExtrudeGizmo_0;

			// Token: 0x04003BD8 RID: 15320
			private static readonly IntPtr NativeMethodInfoPtr_get_IsExtrudeGizmo_Public_get_Boolean_0;

			// Token: 0x04003BD9 RID: 15321
			private static readonly IntPtr NativeMethodInfoPtr_get_IsUsable_Public_get_Boolean_0;

			// Token: 0x04003BDA RID: 15322
			private static readonly IntPtr NativeMethodInfoPtr_set_IsUsable_Public_set_Void_Boolean_0;

			// Token: 0x04003BDB RID: 15323
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Gizmo_0;
		}

		// Token: 0x020003D9 RID: 985
		[ObfuscatedName("RLD.RTObjectSelectionGizmos+<>c__DisplayClass101_0")]
		public sealed class __c__DisplayClass101_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06004D00 RID: 19712 RVA: 0x0014F0A0 File Offset: 0x0014D2A0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass101_0()
			{
				Il2CppClassPointerStore<RTObjectSelectionGizmos.__c__DisplayClass101_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, "<>c__DisplayClass101_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTObjectSelectionGizmos.__c__DisplayClass101_0>.NativeClassPtr);
				RTObjectSelectionGizmos.__c__DisplayClass101_0.NativeFieldInfoPtr_gizmo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelectionGizmos.__c__DisplayClass101_0>.NativeClassPtr, "gizmo");
				RTObjectSelectionGizmos.__c__DisplayClass101_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelectionGizmos.__c__DisplayClass101_0>.NativeClassPtr, 100670075);
				RTObjectSelectionGizmos.__c__DisplayClass101_0.NativeMethodInfoPtr__GetGizmoId_b__0_Internal_Boolean_ObjectSelectionGizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelectionGizmos.__c__DisplayClass101_0>.NativeClassPtr, 100670076);
			}

			// Token: 0x06004D01 RID: 19713 RVA: 0x0014F108 File Offset: 0x0014D308
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass101_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTObjectSelectionGizmos.__c__DisplayClass101_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelectionGizmos.__c__DisplayClass101_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004D02 RID: 19714 RVA: 0x0014F144 File Offset: 0x0014D344
			[CallerCount(0)]
			public unsafe bool _GetGizmoId_b__0(RTObjectSelectionGizmos.ObjectSelectionGizmo item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelectionGizmos.__c__DisplayClass101_0.NativeMethodInfoPtr__GetGizmoId_b__0_Internal_Boolean_ObjectSelectionGizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004D03 RID: 19715 RVA: 0x0001D0A9 File Offset: 0x0001B2A9
			public __c__DisplayClass101_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170019F6 RID: 6646
			// (get) Token: 0x06004D04 RID: 19716 RVA: 0x0014F194 File Offset: 0x0014D394
			// (set) Token: 0x06004D05 RID: 19717 RVA: 0x0001D0B2 File Offset: 0x0001B2B2
			public unsafe Gizmo gizmo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.__c__DisplayClass101_0.NativeFieldInfoPtr_gizmo);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gizmo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.__c__DisplayClass101_0.NativeFieldInfoPtr_gizmo), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003BDC RID: 15324
			private static readonly IntPtr NativeFieldInfoPtr_gizmo;

			// Token: 0x04003BDD RID: 15325
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003BDE RID: 15326
			private static readonly IntPtr NativeMethodInfoPtr__GetGizmoId_b__0_Internal_Boolean_ObjectSelectionGizmo_0;
		}

		// Token: 0x020003DA RID: 986
		[ObfuscatedName("RLD.RTObjectSelectionGizmos+<>c__DisplayClass102_0")]
		public sealed class __c__DisplayClass102_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06004D06 RID: 19718 RVA: 0x0014F1C4 File Offset: 0x0014D3C4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass102_0()
			{
				Il2CppClassPointerStore<RTObjectSelectionGizmos.__c__DisplayClass102_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, "<>c__DisplayClass102_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTObjectSelectionGizmos.__c__DisplayClass102_0>.NativeClassPtr);
				RTObjectSelectionGizmos.__c__DisplayClass102_0.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelectionGizmos.__c__DisplayClass102_0>.NativeClassPtr, "id");
				RTObjectSelectionGizmos.__c__DisplayClass102_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelectionGizmos.__c__DisplayClass102_0>.NativeClassPtr, 100670077);
				RTObjectSelectionGizmos.__c__DisplayClass102_0.NativeMethodInfoPtr__GetTransformGizmoById_b__0_Internal_Boolean_ObjectSelectionGizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelectionGizmos.__c__DisplayClass102_0>.NativeClassPtr, 100670078);
			}

			// Token: 0x06004D07 RID: 19719 RVA: 0x0014F22C File Offset: 0x0014D42C
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass102_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTObjectSelectionGizmos.__c__DisplayClass102_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelectionGizmos.__c__DisplayClass102_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004D08 RID: 19720 RVA: 0x0014F268 File Offset: 0x0014D468
			[CallerCount(0)]
			public unsafe bool _GetTransformGizmoById_b__0(RTObjectSelectionGizmos.ObjectSelectionGizmo item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelectionGizmos.__c__DisplayClass102_0.NativeMethodInfoPtr__GetTransformGizmoById_b__0_Internal_Boolean_ObjectSelectionGizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004D09 RID: 19721 RVA: 0x0001D0D1 File Offset: 0x0001B2D1
			public __c__DisplayClass102_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170019F7 RID: 6647
			// (get) Token: 0x06004D0A RID: 19722 RVA: 0x0014F2B8 File Offset: 0x0014D4B8
			// (set) Token: 0x06004D0B RID: 19723 RVA: 0x0001D0DA File Offset: 0x0001B2DA
			public unsafe int id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.__c__DisplayClass102_0.NativeFieldInfoPtr_id);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.__c__DisplayClass102_0.NativeFieldInfoPtr_id)) = value;
				}
			}

			// Token: 0x04003BDF RID: 15327
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x04003BE0 RID: 15328
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003BE1 RID: 15329
			private static readonly IntPtr NativeMethodInfoPtr__GetTransformGizmoById_b__0_Internal_Boolean_ObjectSelectionGizmo_0;
		}

		// Token: 0x020003DB RID: 987
		[ObfuscatedName("RLD.RTObjectSelectionGizmos+<>c__DisplayClass119_0")]
		public sealed class __c__DisplayClass119_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06004D0C RID: 19724 RVA: 0x0014F2E0 File Offset: 0x0014D4E0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass119_0()
			{
				Il2CppClassPointerStore<RTObjectSelectionGizmos.__c__DisplayClass119_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, "<>c__DisplayClass119_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTObjectSelectionGizmos.__c__DisplayClass119_0>.NativeClassPtr);
				RTObjectSelectionGizmos.__c__DisplayClass119_0.NativeFieldInfoPtr_gizmoId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelectionGizmos.__c__DisplayClass119_0>.NativeClassPtr, "gizmoId");
				RTObjectSelectionGizmos.__c__DisplayClass119_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelectionGizmos.__c__DisplayClass119_0>.NativeClassPtr, 100670079);
				RTObjectSelectionGizmos.__c__DisplayClass119_0.NativeMethodInfoPtr__IsGizmoRegistered_b__0_Internal_Boolean_ObjectSelectionGizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelectionGizmos.__c__DisplayClass119_0>.NativeClassPtr, 100670080);
			}

			// Token: 0x06004D0D RID: 19725 RVA: 0x0014F348 File Offset: 0x0014D548
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass119_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTObjectSelectionGizmos.__c__DisplayClass119_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelectionGizmos.__c__DisplayClass119_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004D0E RID: 19726 RVA: 0x0014F384 File Offset: 0x0014D584
			[CallerCount(0)]
			public unsafe bool _IsGizmoRegistered_b__0(RTObjectSelectionGizmos.ObjectSelectionGizmo item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelectionGizmos.__c__DisplayClass119_0.NativeMethodInfoPtr__IsGizmoRegistered_b__0_Internal_Boolean_ObjectSelectionGizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004D0F RID: 19727 RVA: 0x0001D0F5 File Offset: 0x0001B2F5
			public __c__DisplayClass119_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170019F8 RID: 6648
			// (get) Token: 0x06004D10 RID: 19728 RVA: 0x0014F3D4 File Offset: 0x0014D5D4
			// (set) Token: 0x06004D11 RID: 19729 RVA: 0x0001D0FE File Offset: 0x0001B2FE
			public unsafe int gizmoId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.__c__DisplayClass119_0.NativeFieldInfoPtr_gizmoId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.__c__DisplayClass119_0.NativeFieldInfoPtr_gizmoId)) = value;
				}
			}

			// Token: 0x04003BE2 RID: 15330
			private static readonly IntPtr NativeFieldInfoPtr_gizmoId;

			// Token: 0x04003BE3 RID: 15331
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003BE4 RID: 15332
			private static readonly IntPtr NativeMethodInfoPtr__IsGizmoRegistered_b__0_Internal_Boolean_ObjectSelectionGizmo_0;
		}

		// Token: 0x020003DC RID: 988
		[ObfuscatedName("RLD.RTObjectSelectionGizmos+<>c__DisplayClass120_0")]
		public sealed class __c__DisplayClass120_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06004D12 RID: 19730 RVA: 0x0014F3FC File Offset: 0x0014D5FC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass120_0()
			{
				Il2CppClassPointerStore<RTObjectSelectionGizmos.__c__DisplayClass120_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RTObjectSelectionGizmos>.NativeClassPtr, "<>c__DisplayClass120_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTObjectSelectionGizmos.__c__DisplayClass120_0>.NativeClassPtr);
				RTObjectSelectionGizmos.__c__DisplayClass120_0.NativeFieldInfoPtr_gizmo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelectionGizmos.__c__DisplayClass120_0>.NativeClassPtr, "gizmo");
				RTObjectSelectionGizmos.__c__DisplayClass120_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelectionGizmos.__c__DisplayClass120_0>.NativeClassPtr, 100670081);
				RTObjectSelectionGizmos.__c__DisplayClass120_0.NativeMethodInfoPtr__IsGizmoRegistered_b__0_Internal_Boolean_ObjectSelectionGizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelectionGizmos.__c__DisplayClass120_0>.NativeClassPtr, 100670082);
			}

			// Token: 0x06004D13 RID: 19731 RVA: 0x0014F464 File Offset: 0x0014D664
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass120_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTObjectSelectionGizmos.__c__DisplayClass120_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelectionGizmos.__c__DisplayClass120_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004D14 RID: 19732 RVA: 0x0014F4A0 File Offset: 0x0014D6A0
			[CallerCount(0)]
			public unsafe bool _IsGizmoRegistered_b__0(RTObjectSelectionGizmos.ObjectSelectionGizmo item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelectionGizmos.__c__DisplayClass120_0.NativeMethodInfoPtr__IsGizmoRegistered_b__0_Internal_Boolean_ObjectSelectionGizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004D15 RID: 19733 RVA: 0x0001D119 File Offset: 0x0001B319
			public __c__DisplayClass120_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170019F9 RID: 6649
			// (get) Token: 0x06004D16 RID: 19734 RVA: 0x0014F4F0 File Offset: 0x0014D6F0
			// (set) Token: 0x06004D17 RID: 19735 RVA: 0x0001D122 File Offset: 0x0001B322
			public unsafe Gizmo gizmo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.__c__DisplayClass120_0.NativeFieldInfoPtr_gizmo);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gizmo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelectionGizmos.__c__DisplayClass120_0.NativeFieldInfoPtr_gizmo), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003BE5 RID: 15333
			private static readonly IntPtr NativeFieldInfoPtr_gizmo;

			// Token: 0x04003BE6 RID: 15334
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003BE7 RID: 15335
			private static readonly IntPtr NativeMethodInfoPtr__IsGizmoRegistered_b__0_Internal_Boolean_ObjectSelectionGizmo_0;
		}
	}
}
