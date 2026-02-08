using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200023B RID: 571
	[Serializable]
	public class RTObjectSelection : MonoSingleton<RTObjectSelection>
	{
		// Token: 0x06002B9A RID: 11162 RVA: 0x000CD28C File Offset: 0x000CB48C
		// Note: this type is marked as 'beforefieldinit'.
		static RTObjectSelection()
		{
			Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "RTObjectSelection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr);
			RTObjectSelection.NativeFieldInfoPtr__objectPickDeviceBtnIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, "_objectPickDeviceBtnIndex");
			RTObjectSelection.NativeFieldInfoPtr_ManipSessionBegin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, "ManipSessionBegin");
			RTObjectSelection.NativeFieldInfoPtr_ManipSessionEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, "ManipSessionEnd");
			RTObjectSelection.NativeFieldInfoPtr_CanClickSelectDeselect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, "CanClickSelectDeselect");
			RTObjectSelection.NativeFieldInfoPtr_CanMultiSelectDeselect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, "CanMultiSelectDeselect");
			RTObjectSelection.NativeFieldInfoPtr_Changed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, "Changed");
			RTObjectSelection.NativeFieldInfoPtr_WillBeDeleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, "WillBeDeleted");
			RTObjectSelection.NativeFieldInfoPtr_Deleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, "Deleted");
			RTObjectSelection.NativeFieldInfoPtr_WillBeDuplicated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, "WillBeDuplicated");
			RTObjectSelection.NativeFieldInfoPtr_Duplicated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, "Duplicated");
			RTObjectSelection.NativeFieldInfoPtr_Rotated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, "Rotated");
			RTObjectSelection.NativeFieldInfoPtr_PreSelectCustomize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, "PreSelectCustomize");
			RTObjectSelection.NativeFieldInfoPtr_PreDeselectCustomize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, "PreDeselectCustomize");
			RTObjectSelection.NativeFieldInfoPtr_Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, "Enabled");
			RTObjectSelection.NativeFieldInfoPtr_Disabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, "Disabled");
			RTObjectSelection.NativeFieldInfoPtr__visibleObjectBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, "_visibleObjectBuffer");
			RTObjectSelection.NativeFieldInfoPtr__overlappedObjectBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, "_overlappedObjectBuffer");
			RTObjectSelection.NativeFieldInfoPtr__objectHitBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, "_objectHitBuffer");
			RTObjectSelection.NativeFieldInfoPtr__isEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, "_isEnabled");
			RTObjectSelection.NativeFieldInfoPtr__renderIgnoreCameras = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, "_renderIgnoreCameras");
			RTObjectSelection.NativeFieldInfoPtr__selectedObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, "_selectedObjects");
			RTObjectSelection.NativeFieldInfoPtr__multiSelectShape = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, "_multiSelectShape");
			RTObjectSelection.NativeFieldInfoPtr__multiSelectPreChangeSnapshot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, "_multiSelectPreChangeSnapshot");
			RTObjectSelection.NativeFieldInfoPtr__wasSelectionChangedViaMultiSelectShape = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, "_wasSelectionChangedViaMultiSelectShape");
			RTObjectSelection.NativeFieldInfoPtr__willBeDeleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, "_willBeDeleted");
			RTObjectSelection.NativeFieldInfoPtr__doingPreSelectCustomize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, "_doingPreSelectCustomize");
			RTObjectSelection.NativeFieldInfoPtr__doingPreDeselectCustomize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, "_doingPreDeselectCustomize");
			RTObjectSelection.NativeFieldInfoPtr__firingSelectionChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, "_firingSelectionChanged");
			RTObjectSelection.NativeFieldInfoPtr__activeManipSession = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, "_activeManipSession");
			RTObjectSelection.NativeFieldInfoPtr__cyclicalClickSelectInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, "_cyclicalClickSelectInfo");
			RTObjectSelection.NativeFieldInfoPtr__hotkeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, "_hotkeys");
			RTObjectSelection.NativeFieldInfoPtr__settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, "_settings");
			RTObjectSelection.NativeFieldInfoPtr__lookAndFeel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, "_lookAndFeel");
			RTObjectSelection.NativeFieldInfoPtr__rotationSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, "_rotationSettings");
			RTObjectSelection.NativeFieldInfoPtr__rotationHotkeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, "_rotationHotkeys");
			RTObjectSelection.NativeFieldInfoPtr__grabSession = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, "_grabSession");
			RTObjectSelection.NativeFieldInfoPtr__grabSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, "_grabSettings");
			RTObjectSelection.NativeFieldInfoPtr__grabLookAndFeel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, "_grabLookAndFeel");
			RTObjectSelection.NativeFieldInfoPtr__grabHotkeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, "_grabHotkeys");
			RTObjectSelection.NativeFieldInfoPtr__gridSnapSession = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, "_gridSnapSession");
			RTObjectSelection.NativeFieldInfoPtr__gridSnapLookAndFeel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, "_gridSnapLookAndFeel");
			RTObjectSelection.NativeFieldInfoPtr__gridSnapHotkeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, "_gridSnapHotkeys");
			RTObjectSelection.NativeFieldInfoPtr__object2ObjectSnapSession = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, "_object2ObjectSnapSession");
			RTObjectSelection.NativeFieldInfoPtr__object2ObjectSnapSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, "_object2ObjectSnapSettings");
			RTObjectSelection.NativeFieldInfoPtr__object2ObjectSnapHotkeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, "_object2ObjectSnapHotkeys");
			RTObjectSelection.NativeFieldInfoPtr__settingsToolbar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, "_settingsToolbar");
			RTObjectSelection.NativeMethodInfoPtr_get_IsEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669933);
			RTObjectSelection.NativeMethodInfoPtr_get_IsMultiSelectShapeVisible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669934);
			RTObjectSelection.NativeMethodInfoPtr_get_NumSelectedObjects_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669935);
			RTObjectSelection.NativeMethodInfoPtr_get_Hotkeys_Public_get_ObjectSelectionHotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669936);
			RTObjectSelection.NativeMethodInfoPtr_get_Settings_Public_get_ObjectSelectionSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669937);
			RTObjectSelection.NativeMethodInfoPtr_get_LookAndFeel_Public_get_ObjectSelectionLookAndFeel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669938);
			RTObjectSelection.NativeMethodInfoPtr_get_RotationSettings_Public_get_ObjectSelectionRotationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669939);
			RTObjectSelection.NativeMethodInfoPtr_get_RotationHotkeys_Public_get_ObjectSelectionRotationHotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669940);
			RTObjectSelection.NativeMethodInfoPtr_get_GrabSettings_Public_get_ObjectGrabSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669941);
			RTObjectSelection.NativeMethodInfoPtr_get_GrabHotkeys_Public_get_ObjectGrabHotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669942);
			RTObjectSelection.NativeMethodInfoPtr_get_GrabLookAndFeel_Public_get_ObjectGrabLookAndFeel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669943);
			RTObjectSelection.NativeMethodInfoPtr_get_GridSnapLookAndFeel_Public_get_ObjectGridSnapLookAndFeel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669944);
			RTObjectSelection.NativeMethodInfoPtr_get_GridSnapHotkeys_Public_get_ObjectGridSnapHotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669945);
			RTObjectSelection.NativeMethodInfoPtr_get_Object2ObjectSnapSettings_Public_get_Object2ObjectSnapSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669946);
			RTObjectSelection.NativeMethodInfoPtr_get_Object2ObjectSnapHotkeys_Public_get_Object2ObjectSnapHotkeys_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669947);
			RTObjectSelection.NativeMethodInfoPtr_get_IsManipSessionActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669948);
			RTObjectSelection.NativeMethodInfoPtr_get_ActiveManipSession_Public_get_ObjectSelectionManipSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669949);
			RTObjectSelection.NativeMethodInfoPtr_get_IsGrabSessionActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669950);
			RTObjectSelection.NativeMethodInfoPtr_get_IsGridSnapSessionActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669951);
			RTObjectSelection.NativeMethodInfoPtr_get_IsObject2ObjectSnapSessionActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669952);
			RTObjectSelection.NativeMethodInfoPtr_get_SelectedObjects_Public_get_List_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669953);
			RTObjectSelection.NativeMethodInfoPtr_add_ManipSessionBegin_Public_add_Void_ObjectSelectionManipSessionBeginHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669905);
			RTObjectSelection.NativeMethodInfoPtr_remove_ManipSessionBegin_Public_rem_Void_ObjectSelectionManipSessionBeginHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669906);
			RTObjectSelection.NativeMethodInfoPtr_add_ManipSessionEnd_Public_add_Void_ObjectSelectionManipSessionEndHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669907);
			RTObjectSelection.NativeMethodInfoPtr_remove_ManipSessionEnd_Public_rem_Void_ObjectSelectionManipSessionEndHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669908);
			RTObjectSelection.NativeMethodInfoPtr_add_CanClickSelectDeselect_Public_add_Void_ObjectSelectionCanClickSelectDeselectHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669909);
			RTObjectSelection.NativeMethodInfoPtr_remove_CanClickSelectDeselect_Public_rem_Void_ObjectSelectionCanClickSelectDeselectHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669910);
			RTObjectSelection.NativeMethodInfoPtr_add_CanMultiSelectDeselect_Public_add_Void_ObjectSelectionCanMultiSelectDeselectHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669911);
			RTObjectSelection.NativeMethodInfoPtr_remove_CanMultiSelectDeselect_Public_rem_Void_ObjectSelectionCanMultiSelectDeselectHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669912);
			RTObjectSelection.NativeMethodInfoPtr_add_Changed_Public_add_Void_ObjectSelectionChangedHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669913);
			RTObjectSelection.NativeMethodInfoPtr_remove_Changed_Public_rem_Void_ObjectSelectionChangedHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669914);
			RTObjectSelection.NativeMethodInfoPtr_add_WillBeDeleted_Public_add_Void_ObjectSelectionWillBeDeletedHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669915);
			RTObjectSelection.NativeMethodInfoPtr_remove_WillBeDeleted_Public_rem_Void_ObjectSelectionWillBeDeletedHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669916);
			RTObjectSelection.NativeMethodInfoPtr_add_Deleted_Public_add_Void_ObjectSelectionDeletedHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669917);
			RTObjectSelection.NativeMethodInfoPtr_remove_Deleted_Public_rem_Void_ObjectSelectionDeletedHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669918);
			RTObjectSelection.NativeMethodInfoPtr_add_WillBeDuplicated_Public_add_Void_ObjectSelectionWillBeDuplicatedHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669919);
			RTObjectSelection.NativeMethodInfoPtr_remove_WillBeDuplicated_Public_rem_Void_ObjectSelectionWillBeDuplicatedHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669920);
			RTObjectSelection.NativeMethodInfoPtr_add_Duplicated_Public_add_Void_ObjectSelectionDuplicatedHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669921);
			RTObjectSelection.NativeMethodInfoPtr_remove_Duplicated_Public_rem_Void_ObjectSelectionDuplicatedHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669922);
			RTObjectSelection.NativeMethodInfoPtr_add_Rotated_Public_add_Void_ObjectSelectionRotatedHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669923);
			RTObjectSelection.NativeMethodInfoPtr_remove_Rotated_Public_rem_Void_ObjectSelectionRotatedHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669924);
			RTObjectSelection.NativeMethodInfoPtr_add_PreSelectCustomize_Public_add_Void_ObjectSelectionPreSelectCustomizeHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669925);
			RTObjectSelection.NativeMethodInfoPtr_remove_PreSelectCustomize_Public_rem_Void_ObjectSelectionPreSelectCustomizeHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669926);
			RTObjectSelection.NativeMethodInfoPtr_add_PreDeselectCustomize_Public_add_Void_ObjectSelectionPreDeselectCustomizeHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669927);
			RTObjectSelection.NativeMethodInfoPtr_remove_PreDeselectCustomize_Public_rem_Void_ObjectSelectionPreDeselectCustomizeHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669928);
			RTObjectSelection.NativeMethodInfoPtr_add_Enabled_Public_add_Void_ObjectSelectionEnabled_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669929);
			RTObjectSelection.NativeMethodInfoPtr_remove_Enabled_Public_rem_Void_ObjectSelectionEnabled_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669930);
			RTObjectSelection.NativeMethodInfoPtr_add_Disabled_Public_add_Void_ObjectSelectionDisabled_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669931);
			RTObjectSelection.NativeMethodInfoPtr_remove_Disabled_Public_rem_Void_ObjectSelectionDisabled_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669932);
			RTObjectSelection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100670001);
			RTObjectSelection.NativeMethodInfoPtr_Initialize_SystemCall_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669954);
			RTObjectSelection.NativeMethodInfoPtr_AttachGizmoController_Public_Void_IObjectCollectionGizmoController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669955);
			RTObjectSelection.NativeMethodInfoPtr_IsRenderIgnoreCamera_Public_Boolean_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669956);
			RTObjectSelection.NativeMethodInfoPtr_AddRenderIgnoreCamera_Public_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669957);
			RTObjectSelection.NativeMethodInfoPtr_RemoveRenderIgnoreCamera_Public_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669958);
			RTObjectSelection.NativeMethodInfoPtr_SetEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669959);
			RTObjectSelection.NativeMethodInfoPtr_SetRotation_Public_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669960);
			RTObjectSelection.NativeMethodInfoPtr_Rotate_Public_Void_Axis_Single_ObjectRotationPivot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669961);
			RTObjectSelection.NativeMethodInfoPtr_AppendObjects_Public_Void_List_1_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669962);
			RTObjectSelection.NativeMethodInfoPtr_RemoveObjects_Public_Void_List_1_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669963);
			RTObjectSelection.NativeMethodInfoPtr_SetSelectedObjects_Public_Void_List_1_GameObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669964);
			RTObjectSelection.NativeMethodInfoPtr_ClearSelection_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669965);
			RTObjectSelection.NativeMethodInfoPtr_Delete_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669966);
			RTObjectSelection.NativeMethodInfoPtr_ForceDelete_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669967);
			RTObjectSelection.NativeMethodInfoPtr_CanBeDeleted_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669968);
			RTObjectSelection.NativeMethodInfoPtr_CanBeDuplicated_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669969);
			RTObjectSelection.NativeMethodInfoPtr_CanBeModifiedByAPI_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669970);
			RTObjectSelection.NativeMethodInfoPtr_Duplicate_Public_ObjectSelectionDuplicationResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669971);
			RTObjectSelection.NativeMethodInfoPtr_IsSelectionExactMatch_Public_Boolean_List_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669972);
			RTObjectSelection.NativeMethodInfoPtr_IsObjectSelected_Public_Boolean_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669973);
			RTObjectSelection.NativeMethodInfoPtr_GetWorldAABB_Public_AABB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669974);
			RTObjectSelection.NativeMethodInfoPtr_Update_SystemCall_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669975);
			RTObjectSelection.NativeMethodInfoPtr_Render_SystemCall_Public_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669976);
			RTObjectSelection.NativeMethodInfoPtr_OnInputDevicePickButtonDown_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669977);
			RTObjectSelection.NativeMethodInfoPtr_OnInputDevicePickButtonUp_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669978);
			RTObjectSelection.NativeMethodInfoPtr_OnInputDeviceWasMoved_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669979);
			RTObjectSelection.NativeMethodInfoPtr_PerformMultiSelect_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669980);
			RTObjectSelection.NativeMethodInfoPtr_PerformClickSelect_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669981);
			RTObjectSelection.NativeMethodInfoPtr_DoPreSelectCustomize_Private_ObjectPreSelectCustomizeInfo_List_1_GameObject_ObjectSelectReason_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669982);
			RTObjectSelection.NativeMethodInfoPtr_DoPreDeselectCustomize_Private_List_1_GameObject_List_1_GameObject_ObjectDeselectReason_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669983);
			RTObjectSelection.NativeMethodInfoPtr_FilterByRestrictions_Private_List_1_GameObject_IEnumerable_1_GameObject_SelectRestrictFlags_ObjectSelectReason_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669984);
			RTObjectSelection.NativeMethodInfoPtr_FilterByRestrictions_Private_List_1_GameObjectRayHit_List_1_GameObjectRayHit_SelectRestrictFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669985);
			RTObjectSelection.NativeMethodInfoPtr_CanSelectObject_Private_Boolean_GameObject_SelectRestrictFlags_ObjectSelectReason_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669986);
			RTObjectSelection.NativeMethodInfoPtr_SelectObject_Private_Void_GameObject_ObjectSelectReason_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669987);
			RTObjectSelection.NativeMethodInfoPtr_DeselectObject_Private_Void_GameObject_ObjectDeselectReason_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669988);
			RTObjectSelection.NativeMethodInfoPtr_ClearSelection_Private_Void_ObjectDeselectReason_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669989);
			RTObjectSelection.NativeMethodInfoPtr_OnSelectionChanged_Private_Void_ObjectSelectionChangedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669990);
			RTObjectSelection.NativeMethodInfoPtr_RemoveNullAndInactiveObjectRefs_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669991);
			RTObjectSelection.NativeMethodInfoPtr_OnUndoEnd_Private_Void_IUndoRedoAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669992);
			RTObjectSelection.NativeMethodInfoPtr_OnRedoEnd_Private_Void_IUndoRedoAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669993);
			RTObjectSelection.NativeMethodInfoPtr_HandleUndoRedo_Private_Void_ObjectSelectionSnapshot_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669994);
			RTObjectSelection.NativeMethodInfoPtr_OnGrabSessionBegin_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669995);
			RTObjectSelection.NativeMethodInfoPtr_OnGrabSessionEnd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669996);
			RTObjectSelection.NativeMethodInfoPtr_OnGridSnapSessionBegin_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669997);
			RTObjectSelection.NativeMethodInfoPtr_OnGridSnapSessionEnd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669998);
			RTObjectSelection.NativeMethodInfoPtr_OnObject2ObjectSnapSessionBegin_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100669999);
			RTObjectSelection.NativeMethodInfoPtr_OnObject2ObjectSnapSessionEnd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, 100670000);
		}

		// Token: 0x17000FB2 RID: 4018
		// (get) Token: 0x06002B9B RID: 11163 RVA: 0x000CDDE8 File Offset: 0x000CBFE8
		public unsafe bool IsEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_get_IsEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000FB3 RID: 4019
		// (get) Token: 0x06002B9C RID: 11164 RVA: 0x000CDE24 File Offset: 0x000CC024
		public unsafe bool IsMultiSelectShapeVisible
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 93928, RefRangeEnd = 93930, XrefRangeStart = 93928, XrefRangeEnd = 93928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_get_IsMultiSelectShapeVisible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000FB4 RID: 4020
		// (get) Token: 0x06002B9D RID: 11165 RVA: 0x000CDE60 File Offset: 0x000CC060
		public unsafe int NumSelectedObjects
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 93931, RefRangeEnd = 93936, XrefRangeStart = 93930, XrefRangeEnd = 93931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_get_NumSelectedObjects_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000FB5 RID: 4021
		// (get) Token: 0x06002B9E RID: 11166 RVA: 0x000CDE9C File Offset: 0x000CC09C
		public unsafe ObjectSelectionHotkeys Hotkeys
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_get_Hotkeys_Public_get_ObjectSelectionHotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectSelectionHotkeys>(intPtr3) : null;
			}
		}

		// Token: 0x17000FB6 RID: 4022
		// (get) Token: 0x06002B9F RID: 11167 RVA: 0x000CDEDC File Offset: 0x000CC0DC
		public unsafe ObjectSelectionSettings Settings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_get_Settings_Public_get_ObjectSelectionSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectSelectionSettings>(intPtr3) : null;
			}
		}

		// Token: 0x17000FB7 RID: 4023
		// (get) Token: 0x06002BA0 RID: 11168 RVA: 0x000CDF1C File Offset: 0x000CC11C
		public unsafe ObjectSelectionLookAndFeel LookAndFeel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_get_LookAndFeel_Public_get_ObjectSelectionLookAndFeel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectSelectionLookAndFeel>(intPtr3) : null;
			}
		}

		// Token: 0x17000FB8 RID: 4024
		// (get) Token: 0x06002BA1 RID: 11169 RVA: 0x000CDF5C File Offset: 0x000CC15C
		public unsafe ObjectSelectionRotationSettings RotationSettings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_get_RotationSettings_Public_get_ObjectSelectionRotationSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectSelectionRotationSettings>(intPtr3) : null;
			}
		}

		// Token: 0x17000FB9 RID: 4025
		// (get) Token: 0x06002BA2 RID: 11170 RVA: 0x000CDF9C File Offset: 0x000CC19C
		public unsafe ObjectSelectionRotationHotkeys RotationHotkeys
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_get_RotationHotkeys_Public_get_ObjectSelectionRotationHotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectSelectionRotationHotkeys>(intPtr3) : null;
			}
		}

		// Token: 0x17000FBA RID: 4026
		// (get) Token: 0x06002BA3 RID: 11171 RVA: 0x000CDFDC File Offset: 0x000CC1DC
		public unsafe ObjectGrabSettings GrabSettings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_get_GrabSettings_Public_get_ObjectGrabSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectGrabSettings>(intPtr3) : null;
			}
		}

		// Token: 0x17000FBB RID: 4027
		// (get) Token: 0x06002BA4 RID: 11172 RVA: 0x000CE01C File Offset: 0x000CC21C
		public unsafe ObjectGrabHotkeys GrabHotkeys
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_get_GrabHotkeys_Public_get_ObjectGrabHotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectGrabHotkeys>(intPtr3) : null;
			}
		}

		// Token: 0x17000FBC RID: 4028
		// (get) Token: 0x06002BA5 RID: 11173 RVA: 0x000CE05C File Offset: 0x000CC25C
		public unsafe ObjectGrabLookAndFeel GrabLookAndFeel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_get_GrabLookAndFeel_Public_get_ObjectGrabLookAndFeel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectGrabLookAndFeel>(intPtr3) : null;
			}
		}

		// Token: 0x17000FBD RID: 4029
		// (get) Token: 0x06002BA6 RID: 11174 RVA: 0x000CE09C File Offset: 0x000CC29C
		public unsafe ObjectGridSnapLookAndFeel GridSnapLookAndFeel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_get_GridSnapLookAndFeel_Public_get_ObjectGridSnapLookAndFeel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectGridSnapLookAndFeel>(intPtr3) : null;
			}
		}

		// Token: 0x17000FBE RID: 4030
		// (get) Token: 0x06002BA7 RID: 11175 RVA: 0x000CE0DC File Offset: 0x000CC2DC
		public unsafe ObjectGridSnapHotkeys GridSnapHotkeys
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 59872, RefRangeEnd = 59873, XrefRangeStart = 59872, XrefRangeEnd = 59873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_get_GridSnapHotkeys_Public_get_ObjectGridSnapHotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectGridSnapHotkeys>(intPtr3) : null;
			}
		}

		// Token: 0x17000FBF RID: 4031
		// (get) Token: 0x06002BA8 RID: 11176 RVA: 0x000CE11C File Offset: 0x000CC31C
		public unsafe Object2ObjectSnapSettings Object2ObjectSnapSettings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_get_Object2ObjectSnapSettings_Public_get_Object2ObjectSnapSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object2ObjectSnapSettings>(intPtr3) : null;
			}
		}

		// Token: 0x17000FC0 RID: 4032
		// (get) Token: 0x06002BA9 RID: 11177 RVA: 0x000CE15C File Offset: 0x000CC35C
		public unsafe Object2ObjectSnapHotkeys Object2ObjectSnapHotkeys
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_get_Object2ObjectSnapHotkeys_Public_get_Object2ObjectSnapHotkeys_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object2ObjectSnapHotkeys>(intPtr3) : null;
			}
		}

		// Token: 0x17000FC1 RID: 4033
		// (get) Token: 0x06002BAA RID: 11178 RVA: 0x000CE19C File Offset: 0x000CC39C
		public unsafe bool IsManipSessionActive
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 93936, RefRangeEnd = 93937, XrefRangeStart = 93936, XrefRangeEnd = 93936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_get_IsManipSessionActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000FC2 RID: 4034
		// (get) Token: 0x06002BAB RID: 11179 RVA: 0x000CE1D8 File Offset: 0x000CC3D8
		public unsafe ObjectSelectionManipSession ActiveManipSession
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_get_ActiveManipSession_Public_get_ObjectSelectionManipSession_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectSelectionManipSession>(intPtr3) : null;
			}
		}

		// Token: 0x17000FC3 RID: 4035
		// (get) Token: 0x06002BAC RID: 11180 RVA: 0x000CE218 File Offset: 0x000CC418
		public unsafe bool IsGrabSessionActive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_get_IsGrabSessionActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000FC4 RID: 4036
		// (get) Token: 0x06002BAD RID: 11181 RVA: 0x000CE254 File Offset: 0x000CC454
		public unsafe bool IsGridSnapSessionActive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_get_IsGridSnapSessionActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000FC5 RID: 4037
		// (get) Token: 0x06002BAE RID: 11182 RVA: 0x000CE290 File Offset: 0x000CC490
		public unsafe bool IsObject2ObjectSnapSessionActive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_get_IsObject2ObjectSnapSessionActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000FC6 RID: 4038
		// (get) Token: 0x06002BAF RID: 11183 RVA: 0x000CE2CC File Offset: 0x000CC4CC
		public unsafe List<GameObject> SelectedObjects
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 93943, RefRangeEnd = 93952, XrefRangeStart = 93937, XrefRangeEnd = 93943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_get_SelectedObjects_Public_get_List_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr3) : null;
			}
		}

		// Token: 0x06002BB0 RID: 11184 RVA: 0x000CE30C File Offset: 0x000CC50C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93952, XrefRangeEnd = 93956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_ManipSessionBegin(ObjectSelectionManipSessionBeginHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_add_ManipSessionBegin_Public_add_Void_ObjectSelectionManipSessionBeginHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BB1 RID: 11185 RVA: 0x000CE350 File Offset: 0x000CC550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93956, XrefRangeEnd = 93960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_ManipSessionBegin(ObjectSelectionManipSessionBeginHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_remove_ManipSessionBegin_Public_rem_Void_ObjectSelectionManipSessionBeginHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BB2 RID: 11186 RVA: 0x000CE394 File Offset: 0x000CC594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93960, XrefRangeEnd = 93964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_ManipSessionEnd(ObjectSelectionManipSessionEndHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_add_ManipSessionEnd_Public_add_Void_ObjectSelectionManipSessionEndHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BB3 RID: 11187 RVA: 0x000CE3D8 File Offset: 0x000CC5D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93964, XrefRangeEnd = 93968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_ManipSessionEnd(ObjectSelectionManipSessionEndHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_remove_ManipSessionEnd_Public_rem_Void_ObjectSelectionManipSessionEndHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BB4 RID: 11188 RVA: 0x000CE41C File Offset: 0x000CC61C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 93972, RefRangeEnd = 93974, XrefRangeStart = 93968, XrefRangeEnd = 93972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_CanClickSelectDeselect(ObjectSelectionCanClickSelectDeselectHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_add_CanClickSelectDeselect_Public_add_Void_ObjectSelectionCanClickSelectDeselectHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BB5 RID: 11189 RVA: 0x000CE460 File Offset: 0x000CC660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93974, XrefRangeEnd = 93978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_CanClickSelectDeselect(ObjectSelectionCanClickSelectDeselectHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_remove_CanClickSelectDeselect_Public_rem_Void_ObjectSelectionCanClickSelectDeselectHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BB6 RID: 11190 RVA: 0x000CE4A4 File Offset: 0x000CC6A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 93982, RefRangeEnd = 93984, XrefRangeStart = 93978, XrefRangeEnd = 93982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_CanMultiSelectDeselect(ObjectSelectionCanMultiSelectDeselectHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_add_CanMultiSelectDeselect_Public_add_Void_ObjectSelectionCanMultiSelectDeselectHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BB7 RID: 11191 RVA: 0x000CE4E8 File Offset: 0x000CC6E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93984, XrefRangeEnd = 93988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_CanMultiSelectDeselect(ObjectSelectionCanMultiSelectDeselectHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_remove_CanMultiSelectDeselect_Public_rem_Void_ObjectSelectionCanMultiSelectDeselectHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BB8 RID: 11192 RVA: 0x000CE52C File Offset: 0x000CC72C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 93992, RefRangeEnd = 93993, XrefRangeStart = 93988, XrefRangeEnd = 93992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_Changed(ObjectSelectionChangedHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_add_Changed_Public_add_Void_ObjectSelectionChangedHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BB9 RID: 11193 RVA: 0x000CE570 File Offset: 0x000CC770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93993, XrefRangeEnd = 93997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_Changed(ObjectSelectionChangedHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_remove_Changed_Public_rem_Void_ObjectSelectionChangedHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BBA RID: 11194 RVA: 0x000CE5B4 File Offset: 0x000CC7B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93997, XrefRangeEnd = 94001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_WillBeDeleted(ObjectSelectionWillBeDeletedHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_add_WillBeDeleted_Public_add_Void_ObjectSelectionWillBeDeletedHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BBB RID: 11195 RVA: 0x000CE5F8 File Offset: 0x000CC7F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94001, XrefRangeEnd = 94005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_WillBeDeleted(ObjectSelectionWillBeDeletedHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_remove_WillBeDeleted_Public_rem_Void_ObjectSelectionWillBeDeletedHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BBC RID: 11196 RVA: 0x000CE63C File Offset: 0x000CC83C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94005, XrefRangeEnd = 94009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_Deleted(ObjectSelectionDeletedHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_add_Deleted_Public_add_Void_ObjectSelectionDeletedHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BBD RID: 11197 RVA: 0x000CE680 File Offset: 0x000CC880
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94009, XrefRangeEnd = 94013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_Deleted(ObjectSelectionDeletedHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_remove_Deleted_Public_rem_Void_ObjectSelectionDeletedHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BBE RID: 11198 RVA: 0x000CE6C4 File Offset: 0x000CC8C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94013, XrefRangeEnd = 94017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_WillBeDuplicated(ObjectSelectionWillBeDuplicatedHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_add_WillBeDuplicated_Public_add_Void_ObjectSelectionWillBeDuplicatedHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BBF RID: 11199 RVA: 0x000CE708 File Offset: 0x000CC908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94017, XrefRangeEnd = 94021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_WillBeDuplicated(ObjectSelectionWillBeDuplicatedHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_remove_WillBeDuplicated_Public_rem_Void_ObjectSelectionWillBeDuplicatedHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BC0 RID: 11200 RVA: 0x000CE74C File Offset: 0x000CC94C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94021, XrefRangeEnd = 94025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_Duplicated(ObjectSelectionDuplicatedHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_add_Duplicated_Public_add_Void_ObjectSelectionDuplicatedHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BC1 RID: 11201 RVA: 0x000CE790 File Offset: 0x000CC990
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94025, XrefRangeEnd = 94029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_Duplicated(ObjectSelectionDuplicatedHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_remove_Duplicated_Public_rem_Void_ObjectSelectionDuplicatedHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BC2 RID: 11202 RVA: 0x000CE7D4 File Offset: 0x000CC9D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94029, XrefRangeEnd = 94033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_Rotated(ObjectSelectionRotatedHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_add_Rotated_Public_add_Void_ObjectSelectionRotatedHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BC3 RID: 11203 RVA: 0x000CE818 File Offset: 0x000CCA18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94033, XrefRangeEnd = 94037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_Rotated(ObjectSelectionRotatedHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_remove_Rotated_Public_rem_Void_ObjectSelectionRotatedHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BC4 RID: 11204 RVA: 0x000CE85C File Offset: 0x000CCA5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94037, XrefRangeEnd = 94041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_PreSelectCustomize(ObjectSelectionPreSelectCustomizeHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_add_PreSelectCustomize_Public_add_Void_ObjectSelectionPreSelectCustomizeHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BC5 RID: 11205 RVA: 0x000CE8A0 File Offset: 0x000CCAA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94041, XrefRangeEnd = 94045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_PreSelectCustomize(ObjectSelectionPreSelectCustomizeHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_remove_PreSelectCustomize_Public_rem_Void_ObjectSelectionPreSelectCustomizeHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BC6 RID: 11206 RVA: 0x000CE8E4 File Offset: 0x000CCAE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94045, XrefRangeEnd = 94049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_PreDeselectCustomize(ObjectSelectionPreDeselectCustomizeHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_add_PreDeselectCustomize_Public_add_Void_ObjectSelectionPreDeselectCustomizeHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BC7 RID: 11207 RVA: 0x000CE928 File Offset: 0x000CCB28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94049, XrefRangeEnd = 94053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_PreDeselectCustomize(ObjectSelectionPreDeselectCustomizeHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_remove_PreDeselectCustomize_Public_rem_Void_ObjectSelectionPreDeselectCustomizeHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BC8 RID: 11208 RVA: 0x000CE96C File Offset: 0x000CCB6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94053, XrefRangeEnd = 94057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_Enabled(ObjectSelectionEnabled value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_add_Enabled_Public_add_Void_ObjectSelectionEnabled_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BC9 RID: 11209 RVA: 0x000CE9B0 File Offset: 0x000CCBB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94057, XrefRangeEnd = 94061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_Enabled(ObjectSelectionEnabled value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_remove_Enabled_Public_rem_Void_ObjectSelectionEnabled_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BCA RID: 11210 RVA: 0x000CE9F4 File Offset: 0x000CCBF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94061, XrefRangeEnd = 94065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_Disabled(ObjectSelectionDisabled value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_add_Disabled_Public_add_Void_ObjectSelectionDisabled_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BCB RID: 11211 RVA: 0x000CEA38 File Offset: 0x000CCC38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94065, XrefRangeEnd = 94069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_Disabled(ObjectSelectionDisabled value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_remove_Disabled_Public_rem_Void_ObjectSelectionDisabled_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BCC RID: 11212 RVA: 0x000CEA7C File Offset: 0x000CCC7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94069, XrefRangeEnd = 94278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RTObjectSelection()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BCD RID: 11213 RVA: 0x000CEAB8 File Offset: 0x000CCCB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 94350, RefRangeEnd = 94351, XrefRangeStart = 94278, XrefRangeEnd = 94350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize_SystemCall()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_Initialize_SystemCall_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BCE RID: 11214 RVA: 0x000CEAEC File Offset: 0x000CCCEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 94356, RefRangeEnd = 94357, XrefRangeStart = 94351, XrefRangeEnd = 94356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AttachGizmoController(IObjectCollectionGizmoController gizmoController)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gizmoController);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_AttachGizmoController_Public_Void_IObjectCollectionGizmoController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BCF RID: 11215 RVA: 0x000CEB30 File Offset: 0x000CCD30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94357, XrefRangeEnd = 94361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsRenderIgnoreCamera(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_IsRenderIgnoreCamera_Public_Boolean_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002BD0 RID: 11216 RVA: 0x000CEB80 File Offset: 0x000CCD80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 94367, RefRangeEnd = 94368, XrefRangeStart = 94361, XrefRangeEnd = 94367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddRenderIgnoreCamera(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_AddRenderIgnoreCamera_Public_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BD1 RID: 11217 RVA: 0x000CEBC4 File Offset: 0x000CCDC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94368, XrefRangeEnd = 94372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveRenderIgnoreCamera(Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_RemoveRenderIgnoreCamera_Public_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BD2 RID: 11218 RVA: 0x000CEC08 File Offset: 0x000CCE08
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 94372, RefRangeEnd = 94377, XrefRangeStart = 94372, XrefRangeEnd = 94372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEnabled(bool isEnabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isEnabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_SetEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BD3 RID: 11219 RVA: 0x000CEC48 File Offset: 0x000CCE48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 94404, RefRangeEnd = 94405, XrefRangeStart = 94377, XrefRangeEnd = 94404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRotation(Quaternion rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rotation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_SetRotation_Public_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BD4 RID: 11220 RVA: 0x000CEC8C File Offset: 0x000CCE8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 94487, RefRangeEnd = 94488, XrefRangeStart = 94405, XrefRangeEnd = 94487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Rotate(Axis axis, float rotationAngle, ObjectRotationPivot rotationPivot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(axis);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotationAngle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rotationPivot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_Rotate_Public_Void_Axis_Single_ObjectRotationPivot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BD5 RID: 11221 RVA: 0x000CECF0 File Offset: 0x000CCEF0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 94535, RefRangeEnd = 94539, XrefRangeStart = 94488, XrefRangeEnd = 94535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AppendObjects(List<GameObject> gameObjects, bool allowUndoRedo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObjects);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowUndoRedo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_AppendObjects_Public_Void_List_1_GameObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BD6 RID: 11222 RVA: 0x000CED40 File Offset: 0x000CCF40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94539, XrefRangeEnd = 94585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveObjects(List<GameObject> gameObjects, bool allowUndoRedo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObjects);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowUndoRedo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_RemoveObjects_Public_Void_List_1_GameObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BD7 RID: 11223 RVA: 0x000CED90 File Offset: 0x000CCF90
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 94658, RefRangeEnd = 94664, XrefRangeStart = 94585, XrefRangeEnd = 94658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSelectedObjects(List<GameObject> gameObjects, bool allowUndoRedo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObjects);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowUndoRedo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_SetSelectedObjects_Public_Void_List_1_GameObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BD8 RID: 11224 RVA: 0x000CEDE0 File Offset: 0x000CCFE0
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 94701, RefRangeEnd = 94715, XrefRangeStart = 94664, XrefRangeEnd = 94701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearSelection(bool allowUndoRedo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref allowUndoRedo;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_ClearSelection_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BD9 RID: 11225 RVA: 0x000CEE20 File Offset: 0x000CD020
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94715, XrefRangeEnd = 94783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Delete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_Delete_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BDA RID: 11226 RVA: 0x000CEE54 File Offset: 0x000CD054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94783, XrefRangeEnd = 94845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ForceDelete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_ForceDelete_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BDB RID: 11227 RVA: 0x000CEE88 File Offset: 0x000CD088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94845, XrefRangeEnd = 94846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanBeDeleted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_CanBeDeleted_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002BDC RID: 11228 RVA: 0x000CEEC4 File Offset: 0x000CD0C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94846, XrefRangeEnd = 94847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanBeDuplicated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_CanBeDuplicated_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002BDD RID: 11229 RVA: 0x000CEF00 File Offset: 0x000CD100
		[CallerCount(0)]
		public unsafe bool CanBeModifiedByAPI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_CanBeModifiedByAPI_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002BDE RID: 11230 RVA: 0x000CEF3C File Offset: 0x000CD13C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94847, XrefRangeEnd = 94892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectSelectionDuplicationResult Duplicate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_Duplicate_Public_ObjectSelectionDuplicationResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectSelectionDuplicationResult>(intPtr3) : null;
		}

		// Token: 0x06002BDF RID: 11231 RVA: 0x000CEF7C File Offset: 0x000CD17C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 94911, RefRangeEnd = 94912, XrefRangeStart = 94892, XrefRangeEnd = 94911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsSelectionExactMatch(List<GameObject> gameObjectsToMatch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObjectsToMatch);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_IsSelectionExactMatch_Public_Boolean_List_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002BE0 RID: 11232 RVA: 0x000CEFCC File Offset: 0x000CD1CC
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 94919, RefRangeEnd = 94932, XrefRangeStart = 94912, XrefRangeEnd = 94919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsObjectSelected(GameObject gameObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_IsObjectSelected_Public_Boolean_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002BE1 RID: 11233 RVA: 0x000CF01C File Offset: 0x000CD21C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 94947, RefRangeEnd = 94953, XrefRangeStart = 94932, XrefRangeEnd = 94947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AABB GetWorldAABB()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_GetWorldAABB_Public_AABB_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AABB>(intPtr3) : null;
		}

		// Token: 0x06002BE2 RID: 11234 RVA: 0x000CF05C File Offset: 0x000CD25C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 95020, RefRangeEnd = 95021, XrefRangeStart = 94953, XrefRangeEnd = 95020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update_SystemCall()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_Update_SystemCall_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BE3 RID: 11235 RVA: 0x000CF090 File Offset: 0x000CD290
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 95121, RefRangeEnd = 95122, XrefRangeStart = 95021, XrefRangeEnd = 95121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Render_SystemCall(Camera renderCamera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderCamera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_Render_SystemCall_Public_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BE4 RID: 11236 RVA: 0x000CF0D4 File Offset: 0x000CD2D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 95158, RefRangeEnd = 95159, XrefRangeStart = 95122, XrefRangeEnd = 95158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnInputDevicePickButtonDown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_OnInputDevicePickButtonDown_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BE5 RID: 11237 RVA: 0x000CF108 File Offset: 0x000CD308
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 95188, RefRangeEnd = 95189, XrefRangeStart = 95159, XrefRangeEnd = 95188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnInputDevicePickButtonUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_OnInputDevicePickButtonUp_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BE6 RID: 11238 RVA: 0x000CF13C File Offset: 0x000CD33C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95189, XrefRangeEnd = 95207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnInputDeviceWasMoved()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_OnInputDeviceWasMoved_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BE7 RID: 11239 RVA: 0x000CF170 File Offset: 0x000CD370
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 95331, RefRangeEnd = 95333, XrefRangeStart = 95207, XrefRangeEnd = 95331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PerformMultiSelect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_PerformMultiSelect_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BE8 RID: 11240 RVA: 0x000CF1A4 File Offset: 0x000CD3A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 95492, RefRangeEnd = 95493, XrefRangeStart = 95333, XrefRangeEnd = 95492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PerformClickSelect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_PerformClickSelect_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BE9 RID: 11241 RVA: 0x000CF1D8 File Offset: 0x000CD3D8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 95505, RefRangeEnd = 95509, XrefRangeStart = 95493, XrefRangeEnd = 95505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectPreSelectCustomizeInfo DoPreSelectCustomize(List<GameObject> toBeSelected, ObjectSelectReason selectReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toBeSelected);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selectReason);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_DoPreSelectCustomize_Private_ObjectPreSelectCustomizeInfo_List_1_GameObject_ObjectSelectReason_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectPreSelectCustomizeInfo>(intPtr3) : null;
		}

		// Token: 0x06002BEA RID: 11242 RVA: 0x000CF23C File Offset: 0x000CD43C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 95527, RefRangeEnd = 95530, XrefRangeStart = 95509, XrefRangeEnd = 95527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<GameObject> DoPreDeselectCustomize(List<GameObject> toBeDeselected, ObjectDeselectReason deselectReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toBeDeselected);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(deselectReason);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_DoPreDeselectCustomize_Private_List_1_GameObject_List_1_GameObject_ObjectDeselectReason_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr3) : null;
		}

		// Token: 0x06002BEB RID: 11243 RVA: 0x000CF2A0 File Offset: 0x000CD4A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 95557, RefRangeEnd = 95559, XrefRangeStart = 95530, XrefRangeEnd = 95557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<GameObject> FilterByRestrictions(IEnumerable<GameObject> gameObjects, RTObjectSelection.SelectRestrictFlags restrictFlags, ObjectSelectReason selectReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObjects);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref restrictFlags;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selectReason);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_FilterByRestrictions_Private_List_1_GameObject_IEnumerable_1_GameObject_SelectRestrictFlags_ObjectSelectReason_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr3) : null;
		}

		// Token: 0x06002BEC RID: 11244 RVA: 0x000CF310 File Offset: 0x000CD510
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 95583, RefRangeEnd = 95584, XrefRangeStart = 95559, XrefRangeEnd = 95583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<GameObjectRayHit> FilterByRestrictions(List<GameObjectRayHit> objectHits, RTObjectSelection.SelectRestrictFlags restrictFlags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectHits);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref restrictFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_FilterByRestrictions_Private_List_1_GameObjectRayHit_List_1_GameObjectRayHit_SelectRestrictFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<GameObjectRayHit>>(intPtr3) : null;
		}

		// Token: 0x06002BED RID: 11245 RVA: 0x000CF370 File Offset: 0x000CD570
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 95632, RefRangeEnd = 95636, XrefRangeStart = 95584, XrefRangeEnd = 95632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanSelectObject(GameObject gameObject, RTObjectSelection.SelectRestrictFlags restrictFlags, ObjectSelectReason selectReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref restrictFlags;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selectReason);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_CanSelectObject_Private_Boolean_GameObject_SelectRestrictFlags_ObjectSelectReason_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002BEE RID: 11246 RVA: 0x000CF3E0 File Offset: 0x000CD5E0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 95651, RefRangeEnd = 95658, XrefRangeStart = 95636, XrefRangeEnd = 95651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectObject(GameObject gameObject, ObjectSelectReason selectReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selectReason);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_SelectObject_Private_Void_GameObject_ObjectSelectReason_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BEF RID: 11247 RVA: 0x000CF434 File Offset: 0x000CD634
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 95671, RefRangeEnd = 95680, XrefRangeStart = 95658, XrefRangeEnd = 95671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeselectObject(GameObject gameObject, ObjectDeselectReason deselectReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(deselectReason);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_DeselectObject_Private_Void_GameObject_ObjectDeselectReason_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BF0 RID: 11248 RVA: 0x000CF488 File Offset: 0x000CD688
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 95708, RefRangeEnd = 95710, XrefRangeStart = 95680, XrefRangeEnd = 95708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearSelection(ObjectDeselectReason deselectReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(deselectReason);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_ClearSelection_Private_Void_ObjectDeselectReason_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BF1 RID: 11249 RVA: 0x000CF4CC File Offset: 0x000CD6CC
		[CallerCount(0)]
		public unsafe void OnSelectionChanged(ObjectSelectionChangedEventArgs args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_OnSelectionChanged_Private_Void_ObjectSelectionChangedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BF2 RID: 11250 RVA: 0x000CF510 File Offset: 0x000CD710
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 95767, RefRangeEnd = 95768, XrefRangeStart = 95710, XrefRangeEnd = 95767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveNullAndInactiveObjectRefs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_RemoveNullAndInactiveObjectRefs_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BF3 RID: 11251 RVA: 0x000CF544 File Offset: 0x000CD744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95768, XrefRangeEnd = 95772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnUndoEnd(IUndoRedoAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_OnUndoEnd_Private_Void_IUndoRedoAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BF4 RID: 11252 RVA: 0x000CF588 File Offset: 0x000CD788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95772, XrefRangeEnd = 95776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnRedoEnd(IUndoRedoAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_OnRedoEnd_Private_Void_IUndoRedoAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BF5 RID: 11253 RVA: 0x000CF5CC File Offset: 0x000CD7CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 95832, RefRangeEnd = 95834, XrefRangeStart = 95776, XrefRangeEnd = 95832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleUndoRedo(ObjectSelectionSnapshot undoRedoSnapshot, bool isUndo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(undoRedoSnapshot);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isUndo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_HandleUndoRedo_Private_Void_ObjectSelectionSnapshot_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BF6 RID: 11254 RVA: 0x000CF61C File Offset: 0x000CD81C
		[CallerCount(0)]
		public unsafe void OnGrabSessionBegin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_OnGrabSessionBegin_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BF7 RID: 11255 RVA: 0x000CF650 File Offset: 0x000CD850
		[CallerCount(0)]
		public unsafe void OnGrabSessionEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_OnGrabSessionEnd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BF8 RID: 11256 RVA: 0x000CF684 File Offset: 0x000CD884
		[CallerCount(0)]
		public unsafe void OnGridSnapSessionBegin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_OnGridSnapSessionBegin_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BF9 RID: 11257 RVA: 0x000CF6B8 File Offset: 0x000CD8B8
		[CallerCount(0)]
		public unsafe void OnGridSnapSessionEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_OnGridSnapSessionEnd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BFA RID: 11258 RVA: 0x000CF6EC File Offset: 0x000CD8EC
		[CallerCount(0)]
		public unsafe void OnObject2ObjectSnapSessionBegin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_OnObject2ObjectSnapSessionBegin_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BFB RID: 11259 RVA: 0x000CF720 File Offset: 0x000CD920
		[CallerCount(0)]
		public unsafe void OnObject2ObjectSnapSessionEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.NativeMethodInfoPtr_OnObject2ObjectSnapSessionEnd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BFC RID: 11260 RVA: 0x0001133E File Offset: 0x0000F53E
		public RTObjectSelection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F84 RID: 3972
		// (get) Token: 0x06002BFD RID: 11261 RVA: 0x000CF754 File Offset: 0x000CD954
		// (set) Token: 0x06002BFE RID: 11262 RVA: 0x00011347 File Offset: 0x0000F547
		public unsafe static int _objectPickDeviceBtnIndex
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RTObjectSelection.NativeFieldInfoPtr__objectPickDeviceBtnIndex, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RTObjectSelection.NativeFieldInfoPtr__objectPickDeviceBtnIndex, (void*)(&value));
			}
		}

		// Token: 0x17000F85 RID: 3973
		// (get) Token: 0x06002BFF RID: 11263 RVA: 0x000CF770 File Offset: 0x000CD970
		// (set) Token: 0x06002C00 RID: 11264 RVA: 0x00011355 File Offset: 0x0000F555
		public unsafe ObjectSelectionManipSessionBeginHandler ManipSessionBegin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr_ManipSessionBegin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectSelectionManipSessionBeginHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr_ManipSessionBegin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F86 RID: 3974
		// (get) Token: 0x06002C01 RID: 11265 RVA: 0x000CF7A0 File Offset: 0x000CD9A0
		// (set) Token: 0x06002C02 RID: 11266 RVA: 0x00011374 File Offset: 0x0000F574
		public unsafe ObjectSelectionManipSessionEndHandler ManipSessionEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr_ManipSessionEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectSelectionManipSessionEndHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr_ManipSessionEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F87 RID: 3975
		// (get) Token: 0x06002C03 RID: 11267 RVA: 0x000CF7D0 File Offset: 0x000CD9D0
		// (set) Token: 0x06002C04 RID: 11268 RVA: 0x00011393 File Offset: 0x0000F593
		public unsafe ObjectSelectionCanClickSelectDeselectHandler CanClickSelectDeselect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr_CanClickSelectDeselect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectSelectionCanClickSelectDeselectHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr_CanClickSelectDeselect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F88 RID: 3976
		// (get) Token: 0x06002C05 RID: 11269 RVA: 0x000CF800 File Offset: 0x000CDA00
		// (set) Token: 0x06002C06 RID: 11270 RVA: 0x000113B2 File Offset: 0x0000F5B2
		public unsafe ObjectSelectionCanMultiSelectDeselectHandler CanMultiSelectDeselect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr_CanMultiSelectDeselect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectSelectionCanMultiSelectDeselectHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr_CanMultiSelectDeselect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F89 RID: 3977
		// (get) Token: 0x06002C07 RID: 11271 RVA: 0x000CF830 File Offset: 0x000CDA30
		// (set) Token: 0x06002C08 RID: 11272 RVA: 0x000113D1 File Offset: 0x0000F5D1
		public unsafe ObjectSelectionChangedHandler Changed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr_Changed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectSelectionChangedHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr_Changed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F8A RID: 3978
		// (get) Token: 0x06002C09 RID: 11273 RVA: 0x000CF860 File Offset: 0x000CDA60
		// (set) Token: 0x06002C0A RID: 11274 RVA: 0x000113F0 File Offset: 0x0000F5F0
		public unsafe ObjectSelectionWillBeDeletedHandler WillBeDeleted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr_WillBeDeleted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectSelectionWillBeDeletedHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr_WillBeDeleted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F8B RID: 3979
		// (get) Token: 0x06002C0B RID: 11275 RVA: 0x000CF890 File Offset: 0x000CDA90
		// (set) Token: 0x06002C0C RID: 11276 RVA: 0x0001140F File Offset: 0x0000F60F
		public unsafe ObjectSelectionDeletedHandler Deleted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr_Deleted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectSelectionDeletedHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr_Deleted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F8C RID: 3980
		// (get) Token: 0x06002C0D RID: 11277 RVA: 0x000CF8C0 File Offset: 0x000CDAC0
		// (set) Token: 0x06002C0E RID: 11278 RVA: 0x0001142E File Offset: 0x0000F62E
		public unsafe ObjectSelectionWillBeDuplicatedHandler WillBeDuplicated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr_WillBeDuplicated);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectSelectionWillBeDuplicatedHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr_WillBeDuplicated), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F8D RID: 3981
		// (get) Token: 0x06002C0F RID: 11279 RVA: 0x000CF8F0 File Offset: 0x000CDAF0
		// (set) Token: 0x06002C10 RID: 11280 RVA: 0x0001144D File Offset: 0x0000F64D
		public unsafe ObjectSelectionDuplicatedHandler Duplicated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr_Duplicated);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectSelectionDuplicatedHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr_Duplicated), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F8E RID: 3982
		// (get) Token: 0x06002C11 RID: 11281 RVA: 0x000CF920 File Offset: 0x000CDB20
		// (set) Token: 0x06002C12 RID: 11282 RVA: 0x0001146C File Offset: 0x0000F66C
		public unsafe ObjectSelectionRotatedHandler Rotated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr_Rotated);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectSelectionRotatedHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr_Rotated), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F8F RID: 3983
		// (get) Token: 0x06002C13 RID: 11283 RVA: 0x000CF950 File Offset: 0x000CDB50
		// (set) Token: 0x06002C14 RID: 11284 RVA: 0x0001148B File Offset: 0x0000F68B
		public unsafe ObjectSelectionPreSelectCustomizeHandler PreSelectCustomize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr_PreSelectCustomize);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectSelectionPreSelectCustomizeHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr_PreSelectCustomize), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F90 RID: 3984
		// (get) Token: 0x06002C15 RID: 11285 RVA: 0x000CF980 File Offset: 0x000CDB80
		// (set) Token: 0x06002C16 RID: 11286 RVA: 0x000114AA File Offset: 0x0000F6AA
		public unsafe ObjectSelectionPreDeselectCustomizeHandler PreDeselectCustomize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr_PreDeselectCustomize);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectSelectionPreDeselectCustomizeHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr_PreDeselectCustomize), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F91 RID: 3985
		// (get) Token: 0x06002C17 RID: 11287 RVA: 0x000CF9B0 File Offset: 0x000CDBB0
		// (set) Token: 0x06002C18 RID: 11288 RVA: 0x000114C9 File Offset: 0x0000F6C9
		public unsafe ObjectSelectionEnabled Enabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr_Enabled);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectSelectionEnabled>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr_Enabled), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F92 RID: 3986
		// (get) Token: 0x06002C19 RID: 11289 RVA: 0x000CF9E0 File Offset: 0x000CDBE0
		// (set) Token: 0x06002C1A RID: 11290 RVA: 0x000114E8 File Offset: 0x0000F6E8
		public unsafe ObjectSelectionDisabled Disabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr_Disabled);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectSelectionDisabled>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr_Disabled), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F93 RID: 3987
		// (get) Token: 0x06002C1B RID: 11291 RVA: 0x000CFA10 File Offset: 0x000CDC10
		// (set) Token: 0x06002C1C RID: 11292 RVA: 0x00011507 File Offset: 0x0000F707
		public unsafe List<GameObject> _visibleObjectBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr__visibleObjectBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr__visibleObjectBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F94 RID: 3988
		// (get) Token: 0x06002C1D RID: 11293 RVA: 0x000CFA40 File Offset: 0x000CDC40
		// (set) Token: 0x06002C1E RID: 11294 RVA: 0x00011526 File Offset: 0x0000F726
		public unsafe List<GameObject> _overlappedObjectBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr__overlappedObjectBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr__overlappedObjectBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F95 RID: 3989
		// (get) Token: 0x06002C1F RID: 11295 RVA: 0x000CFA70 File Offset: 0x000CDC70
		// (set) Token: 0x06002C20 RID: 11296 RVA: 0x00011545 File Offset: 0x0000F745
		public unsafe List<GameObjectRayHit> _objectHitBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr__objectHitBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObjectRayHit>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr__objectHitBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F96 RID: 3990
		// (get) Token: 0x06002C21 RID: 11297 RVA: 0x000CFAA0 File Offset: 0x000CDCA0
		// (set) Token: 0x06002C22 RID: 11298 RVA: 0x00011564 File Offset: 0x0000F764
		public unsafe bool _isEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr__isEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr__isEnabled)) = value;
			}
		}

		// Token: 0x17000F97 RID: 3991
		// (get) Token: 0x06002C23 RID: 11299 RVA: 0x000CFAC8 File Offset: 0x000CDCC8
		// (set) Token: 0x06002C24 RID: 11300 RVA: 0x0001157F File Offset: 0x0000F77F
		public unsafe List<Camera> _renderIgnoreCameras
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr__renderIgnoreCameras);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Camera>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr__renderIgnoreCameras), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F98 RID: 3992
		// (get) Token: 0x06002C25 RID: 11301 RVA: 0x000CFAF8 File Offset: 0x000CDCF8
		// (set) Token: 0x06002C26 RID: 11302 RVA: 0x0001159E File Offset: 0x0000F79E
		public unsafe List<GameObject> _selectedObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr__selectedObjects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr__selectedObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F99 RID: 3993
		// (get) Token: 0x06002C27 RID: 11303 RVA: 0x000CFB28 File Offset: 0x000CDD28
		// (set) Token: 0x06002C28 RID: 11304 RVA: 0x000115BD File Offset: 0x0000F7BD
		public unsafe MultiSelectShape _multiSelectShape
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr__multiSelectShape);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultiSelectShape>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr__multiSelectShape), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F9A RID: 3994
		// (get) Token: 0x06002C29 RID: 11305 RVA: 0x000CFB58 File Offset: 0x000CDD58
		// (set) Token: 0x06002C2A RID: 11306 RVA: 0x000115DC File Offset: 0x0000F7DC
		public unsafe ObjectSelectionSnapshot _multiSelectPreChangeSnapshot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr__multiSelectPreChangeSnapshot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectSelectionSnapshot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr__multiSelectPreChangeSnapshot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F9B RID: 3995
		// (get) Token: 0x06002C2B RID: 11307 RVA: 0x000CFB88 File Offset: 0x000CDD88
		// (set) Token: 0x06002C2C RID: 11308 RVA: 0x000115FB File Offset: 0x0000F7FB
		public unsafe bool _wasSelectionChangedViaMultiSelectShape
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr__wasSelectionChangedViaMultiSelectShape);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr__wasSelectionChangedViaMultiSelectShape)) = value;
			}
		}

		// Token: 0x17000F9C RID: 3996
		// (get) Token: 0x06002C2D RID: 11309 RVA: 0x000CFBB0 File Offset: 0x000CDDB0
		// (set) Token: 0x06002C2E RID: 11310 RVA: 0x00011616 File Offset: 0x0000F816
		public unsafe bool _willBeDeleted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr__willBeDeleted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr__willBeDeleted)) = value;
			}
		}

		// Token: 0x17000F9D RID: 3997
		// (get) Token: 0x06002C2F RID: 11311 RVA: 0x000CFBD8 File Offset: 0x000CDDD8
		// (set) Token: 0x06002C30 RID: 11312 RVA: 0x00011631 File Offset: 0x0000F831
		public unsafe bool _doingPreSelectCustomize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr__doingPreSelectCustomize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr__doingPreSelectCustomize)) = value;
			}
		}

		// Token: 0x17000F9E RID: 3998
		// (get) Token: 0x06002C31 RID: 11313 RVA: 0x000CFC00 File Offset: 0x000CDE00
		// (set) Token: 0x06002C32 RID: 11314 RVA: 0x0001164C File Offset: 0x0000F84C
		public unsafe bool _doingPreDeselectCustomize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr__doingPreDeselectCustomize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr__doingPreDeselectCustomize)) = value;
			}
		}

		// Token: 0x17000F9F RID: 3999
		// (get) Token: 0x06002C33 RID: 11315 RVA: 0x000CFC28 File Offset: 0x000CDE28
		// (set) Token: 0x06002C34 RID: 11316 RVA: 0x00011667 File Offset: 0x0000F867
		public unsafe bool _firingSelectionChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr__firingSelectionChanged);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr__firingSelectionChanged)) = value;
			}
		}

		// Token: 0x17000FA0 RID: 4000
		// (get) Token: 0x06002C35 RID: 11317 RVA: 0x000CFC50 File Offset: 0x000CDE50
		// (set) Token: 0x06002C36 RID: 11318 RVA: 0x00011682 File Offset: 0x0000F882
		public unsafe ObjectSelectionManipSession _activeManipSession
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr__activeManipSession);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectSelectionManipSession>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr__activeManipSession), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FA1 RID: 4001
		// (get) Token: 0x06002C37 RID: 11319 RVA: 0x000CFC80 File Offset: 0x000CDE80
		// (set) Token: 0x06002C38 RID: 11320 RVA: 0x000116A1 File Offset: 0x0000F8A1
		public RTObjectSelection.CyclicalClickSelectInfo _cyclicalClickSelectInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr__cyclicalClickSelectInfo);
				return new RTObjectSelection.CyclicalClickSelectInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RTObjectSelection.CyclicalClickSelectInfo>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr__cyclicalClickSelectInfo), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RTObjectSelection.CyclicalClickSelectInfo>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000FA2 RID: 4002
		// (get) Token: 0x06002C39 RID: 11321 RVA: 0x000CFCB0 File Offset: 0x000CDEB0
		// (set) Token: 0x06002C3A RID: 11322 RVA: 0x000116CF File Offset: 0x0000F8CF
		public unsafe ObjectSelectionHotkeys _hotkeys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr__hotkeys);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectSelectionHotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr__hotkeys), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FA3 RID: 4003
		// (get) Token: 0x06002C3B RID: 11323 RVA: 0x000CFCE0 File Offset: 0x000CDEE0
		// (set) Token: 0x06002C3C RID: 11324 RVA: 0x000116EE File Offset: 0x0000F8EE
		public unsafe ObjectSelectionSettings _settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr__settings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectSelectionSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr__settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FA4 RID: 4004
		// (get) Token: 0x06002C3D RID: 11325 RVA: 0x000CFD10 File Offset: 0x000CDF10
		// (set) Token: 0x06002C3E RID: 11326 RVA: 0x0001170D File Offset: 0x0000F90D
		public unsafe ObjectSelectionLookAndFeel _lookAndFeel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr__lookAndFeel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectSelectionLookAndFeel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr__lookAndFeel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FA5 RID: 4005
		// (get) Token: 0x06002C3F RID: 11327 RVA: 0x000CFD40 File Offset: 0x000CDF40
		// (set) Token: 0x06002C40 RID: 11328 RVA: 0x0001172C File Offset: 0x0000F92C
		public unsafe ObjectSelectionRotationSettings _rotationSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr__rotationSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectSelectionRotationSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr__rotationSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FA6 RID: 4006
		// (get) Token: 0x06002C41 RID: 11329 RVA: 0x000CFD70 File Offset: 0x000CDF70
		// (set) Token: 0x06002C42 RID: 11330 RVA: 0x0001174B File Offset: 0x0000F94B
		public unsafe ObjectSelectionRotationHotkeys _rotationHotkeys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr__rotationHotkeys);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectSelectionRotationHotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr__rotationHotkeys), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FA7 RID: 4007
		// (get) Token: 0x06002C43 RID: 11331 RVA: 0x000CFDA0 File Offset: 0x000CDFA0
		// (set) Token: 0x06002C44 RID: 11332 RVA: 0x0001176A File Offset: 0x0000F96A
		public unsafe DeviceObjectGrabSession _grabSession
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr__grabSession);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeviceObjectGrabSession>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr__grabSession), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FA8 RID: 4008
		// (get) Token: 0x06002C45 RID: 11333 RVA: 0x000CFDD0 File Offset: 0x000CDFD0
		// (set) Token: 0x06002C46 RID: 11334 RVA: 0x00011789 File Offset: 0x0000F989
		public unsafe ObjectGrabSettings _grabSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr__grabSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectGrabSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr__grabSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FA9 RID: 4009
		// (get) Token: 0x06002C47 RID: 11335 RVA: 0x000CFE00 File Offset: 0x000CE000
		// (set) Token: 0x06002C48 RID: 11336 RVA: 0x000117A8 File Offset: 0x0000F9A8
		public unsafe ObjectGrabLookAndFeel _grabLookAndFeel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr__grabLookAndFeel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectGrabLookAndFeel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr__grabLookAndFeel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FAA RID: 4010
		// (get) Token: 0x06002C49 RID: 11337 RVA: 0x000CFE30 File Offset: 0x000CE030
		// (set) Token: 0x06002C4A RID: 11338 RVA: 0x000117C7 File Offset: 0x0000F9C7
		public unsafe ObjectGrabHotkeys _grabHotkeys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr__grabHotkeys);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectGrabHotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr__grabHotkeys), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FAB RID: 4011
		// (get) Token: 0x06002C4B RID: 11339 RVA: 0x000CFE60 File Offset: 0x000CE060
		// (set) Token: 0x06002C4C RID: 11340 RVA: 0x000117E6 File Offset: 0x0000F9E6
		public unsafe ObjectGridSnapSession _gridSnapSession
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr__gridSnapSession);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectGridSnapSession>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr__gridSnapSession), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FAC RID: 4012
		// (get) Token: 0x06002C4D RID: 11341 RVA: 0x000CFE90 File Offset: 0x000CE090
		// (set) Token: 0x06002C4E RID: 11342 RVA: 0x00011805 File Offset: 0x0000FA05
		public unsafe ObjectGridSnapLookAndFeel _gridSnapLookAndFeel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr__gridSnapLookAndFeel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectGridSnapLookAndFeel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr__gridSnapLookAndFeel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FAD RID: 4013
		// (get) Token: 0x06002C4F RID: 11343 RVA: 0x000CFEC0 File Offset: 0x000CE0C0
		// (set) Token: 0x06002C50 RID: 11344 RVA: 0x00011824 File Offset: 0x0000FA24
		public unsafe ObjectGridSnapHotkeys _gridSnapHotkeys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr__gridSnapHotkeys);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectGridSnapHotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr__gridSnapHotkeys), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FAE RID: 4014
		// (get) Token: 0x06002C51 RID: 11345 RVA: 0x000CFEF0 File Offset: 0x000CE0F0
		// (set) Token: 0x06002C52 RID: 11346 RVA: 0x00011843 File Offset: 0x0000FA43
		public unsafe Object2ObjectSnapSession _object2ObjectSnapSession
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr__object2ObjectSnapSession);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object2ObjectSnapSession>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr__object2ObjectSnapSession), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FAF RID: 4015
		// (get) Token: 0x06002C53 RID: 11347 RVA: 0x000CFF20 File Offset: 0x000CE120
		// (set) Token: 0x06002C54 RID: 11348 RVA: 0x00011862 File Offset: 0x0000FA62
		public unsafe Object2ObjectSnapSettings _object2ObjectSnapSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr__object2ObjectSnapSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object2ObjectSnapSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr__object2ObjectSnapSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FB0 RID: 4016
		// (get) Token: 0x06002C55 RID: 11349 RVA: 0x000CFF50 File Offset: 0x000CE150
		// (set) Token: 0x06002C56 RID: 11350 RVA: 0x00011881 File Offset: 0x0000FA81
		public unsafe Object2ObjectSnapHotkeys _object2ObjectSnapHotkeys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr__object2ObjectSnapHotkeys);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object2ObjectSnapHotkeys>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr__object2ObjectSnapHotkeys), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FB1 RID: 4017
		// (get) Token: 0x06002C57 RID: 11351 RVA: 0x000CFF80 File Offset: 0x000CE180
		// (set) Token: 0x06002C58 RID: 11352 RVA: 0x000118A0 File Offset: 0x0000FAA0
		public unsafe EditorToolbar _settingsToolbar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr__settingsToolbar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EditorToolbar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.NativeFieldInfoPtr__settingsToolbar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400219C RID: 8604
		private static readonly IntPtr NativeFieldInfoPtr__objectPickDeviceBtnIndex;

		// Token: 0x0400219D RID: 8605
		private static readonly IntPtr NativeFieldInfoPtr_ManipSessionBegin;

		// Token: 0x0400219E RID: 8606
		private static readonly IntPtr NativeFieldInfoPtr_ManipSessionEnd;

		// Token: 0x0400219F RID: 8607
		private static readonly IntPtr NativeFieldInfoPtr_CanClickSelectDeselect;

		// Token: 0x040021A0 RID: 8608
		private static readonly IntPtr NativeFieldInfoPtr_CanMultiSelectDeselect;

		// Token: 0x040021A1 RID: 8609
		private static readonly IntPtr NativeFieldInfoPtr_Changed;

		// Token: 0x040021A2 RID: 8610
		private static readonly IntPtr NativeFieldInfoPtr_WillBeDeleted;

		// Token: 0x040021A3 RID: 8611
		private static readonly IntPtr NativeFieldInfoPtr_Deleted;

		// Token: 0x040021A4 RID: 8612
		private static readonly IntPtr NativeFieldInfoPtr_WillBeDuplicated;

		// Token: 0x040021A5 RID: 8613
		private static readonly IntPtr NativeFieldInfoPtr_Duplicated;

		// Token: 0x040021A6 RID: 8614
		private static readonly IntPtr NativeFieldInfoPtr_Rotated;

		// Token: 0x040021A7 RID: 8615
		private static readonly IntPtr NativeFieldInfoPtr_PreSelectCustomize;

		// Token: 0x040021A8 RID: 8616
		private static readonly IntPtr NativeFieldInfoPtr_PreDeselectCustomize;

		// Token: 0x040021A9 RID: 8617
		private static readonly IntPtr NativeFieldInfoPtr_Enabled;

		// Token: 0x040021AA RID: 8618
		private static readonly IntPtr NativeFieldInfoPtr_Disabled;

		// Token: 0x040021AB RID: 8619
		private static readonly IntPtr NativeFieldInfoPtr__visibleObjectBuffer;

		// Token: 0x040021AC RID: 8620
		private static readonly IntPtr NativeFieldInfoPtr__overlappedObjectBuffer;

		// Token: 0x040021AD RID: 8621
		private static readonly IntPtr NativeFieldInfoPtr__objectHitBuffer;

		// Token: 0x040021AE RID: 8622
		private static readonly IntPtr NativeFieldInfoPtr__isEnabled;

		// Token: 0x040021AF RID: 8623
		private static readonly IntPtr NativeFieldInfoPtr__renderIgnoreCameras;

		// Token: 0x040021B0 RID: 8624
		private static readonly IntPtr NativeFieldInfoPtr__selectedObjects;

		// Token: 0x040021B1 RID: 8625
		private static readonly IntPtr NativeFieldInfoPtr__multiSelectShape;

		// Token: 0x040021B2 RID: 8626
		private static readonly IntPtr NativeFieldInfoPtr__multiSelectPreChangeSnapshot;

		// Token: 0x040021B3 RID: 8627
		private static readonly IntPtr NativeFieldInfoPtr__wasSelectionChangedViaMultiSelectShape;

		// Token: 0x040021B4 RID: 8628
		private static readonly IntPtr NativeFieldInfoPtr__willBeDeleted;

		// Token: 0x040021B5 RID: 8629
		private static readonly IntPtr NativeFieldInfoPtr__doingPreSelectCustomize;

		// Token: 0x040021B6 RID: 8630
		private static readonly IntPtr NativeFieldInfoPtr__doingPreDeselectCustomize;

		// Token: 0x040021B7 RID: 8631
		private static readonly IntPtr NativeFieldInfoPtr__firingSelectionChanged;

		// Token: 0x040021B8 RID: 8632
		private static readonly IntPtr NativeFieldInfoPtr__activeManipSession;

		// Token: 0x040021B9 RID: 8633
		private static readonly IntPtr NativeFieldInfoPtr__cyclicalClickSelectInfo;

		// Token: 0x040021BA RID: 8634
		private static readonly IntPtr NativeFieldInfoPtr__hotkeys;

		// Token: 0x040021BB RID: 8635
		private static readonly IntPtr NativeFieldInfoPtr__settings;

		// Token: 0x040021BC RID: 8636
		private static readonly IntPtr NativeFieldInfoPtr__lookAndFeel;

		// Token: 0x040021BD RID: 8637
		private static readonly IntPtr NativeFieldInfoPtr__rotationSettings;

		// Token: 0x040021BE RID: 8638
		private static readonly IntPtr NativeFieldInfoPtr__rotationHotkeys;

		// Token: 0x040021BF RID: 8639
		private static readonly IntPtr NativeFieldInfoPtr__grabSession;

		// Token: 0x040021C0 RID: 8640
		private static readonly IntPtr NativeFieldInfoPtr__grabSettings;

		// Token: 0x040021C1 RID: 8641
		private static readonly IntPtr NativeFieldInfoPtr__grabLookAndFeel;

		// Token: 0x040021C2 RID: 8642
		private static readonly IntPtr NativeFieldInfoPtr__grabHotkeys;

		// Token: 0x040021C3 RID: 8643
		private static readonly IntPtr NativeFieldInfoPtr__gridSnapSession;

		// Token: 0x040021C4 RID: 8644
		private static readonly IntPtr NativeFieldInfoPtr__gridSnapLookAndFeel;

		// Token: 0x040021C5 RID: 8645
		private static readonly IntPtr NativeFieldInfoPtr__gridSnapHotkeys;

		// Token: 0x040021C6 RID: 8646
		private static readonly IntPtr NativeFieldInfoPtr__object2ObjectSnapSession;

		// Token: 0x040021C7 RID: 8647
		private static readonly IntPtr NativeFieldInfoPtr__object2ObjectSnapSettings;

		// Token: 0x040021C8 RID: 8648
		private static readonly IntPtr NativeFieldInfoPtr__object2ObjectSnapHotkeys;

		// Token: 0x040021C9 RID: 8649
		private static readonly IntPtr NativeFieldInfoPtr__settingsToolbar;

		// Token: 0x040021CA RID: 8650
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEnabled_Public_get_Boolean_0;

		// Token: 0x040021CB RID: 8651
		private static readonly IntPtr NativeMethodInfoPtr_get_IsMultiSelectShapeVisible_Public_get_Boolean_0;

		// Token: 0x040021CC RID: 8652
		private static readonly IntPtr NativeMethodInfoPtr_get_NumSelectedObjects_Public_get_Int32_0;

		// Token: 0x040021CD RID: 8653
		private static readonly IntPtr NativeMethodInfoPtr_get_Hotkeys_Public_get_ObjectSelectionHotkeys_0;

		// Token: 0x040021CE RID: 8654
		private static readonly IntPtr NativeMethodInfoPtr_get_Settings_Public_get_ObjectSelectionSettings_0;

		// Token: 0x040021CF RID: 8655
		private static readonly IntPtr NativeMethodInfoPtr_get_LookAndFeel_Public_get_ObjectSelectionLookAndFeel_0;

		// Token: 0x040021D0 RID: 8656
		private static readonly IntPtr NativeMethodInfoPtr_get_RotationSettings_Public_get_ObjectSelectionRotationSettings_0;

		// Token: 0x040021D1 RID: 8657
		private static readonly IntPtr NativeMethodInfoPtr_get_RotationHotkeys_Public_get_ObjectSelectionRotationHotkeys_0;

		// Token: 0x040021D2 RID: 8658
		private static readonly IntPtr NativeMethodInfoPtr_get_GrabSettings_Public_get_ObjectGrabSettings_0;

		// Token: 0x040021D3 RID: 8659
		private static readonly IntPtr NativeMethodInfoPtr_get_GrabHotkeys_Public_get_ObjectGrabHotkeys_0;

		// Token: 0x040021D4 RID: 8660
		private static readonly IntPtr NativeMethodInfoPtr_get_GrabLookAndFeel_Public_get_ObjectGrabLookAndFeel_0;

		// Token: 0x040021D5 RID: 8661
		private static readonly IntPtr NativeMethodInfoPtr_get_GridSnapLookAndFeel_Public_get_ObjectGridSnapLookAndFeel_0;

		// Token: 0x040021D6 RID: 8662
		private static readonly IntPtr NativeMethodInfoPtr_get_GridSnapHotkeys_Public_get_ObjectGridSnapHotkeys_0;

		// Token: 0x040021D7 RID: 8663
		private static readonly IntPtr NativeMethodInfoPtr_get_Object2ObjectSnapSettings_Public_get_Object2ObjectSnapSettings_0;

		// Token: 0x040021D8 RID: 8664
		private static readonly IntPtr NativeMethodInfoPtr_get_Object2ObjectSnapHotkeys_Public_get_Object2ObjectSnapHotkeys_0;

		// Token: 0x040021D9 RID: 8665
		private static readonly IntPtr NativeMethodInfoPtr_get_IsManipSessionActive_Public_get_Boolean_0;

		// Token: 0x040021DA RID: 8666
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveManipSession_Public_get_ObjectSelectionManipSession_0;

		// Token: 0x040021DB RID: 8667
		private static readonly IntPtr NativeMethodInfoPtr_get_IsGrabSessionActive_Public_get_Boolean_0;

		// Token: 0x040021DC RID: 8668
		private static readonly IntPtr NativeMethodInfoPtr_get_IsGridSnapSessionActive_Public_get_Boolean_0;

		// Token: 0x040021DD RID: 8669
		private static readonly IntPtr NativeMethodInfoPtr_get_IsObject2ObjectSnapSessionActive_Public_get_Boolean_0;

		// Token: 0x040021DE RID: 8670
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectedObjects_Public_get_List_1_GameObject_0;

		// Token: 0x040021DF RID: 8671
		private static readonly IntPtr NativeMethodInfoPtr_add_ManipSessionBegin_Public_add_Void_ObjectSelectionManipSessionBeginHandler_0;

		// Token: 0x040021E0 RID: 8672
		private static readonly IntPtr NativeMethodInfoPtr_remove_ManipSessionBegin_Public_rem_Void_ObjectSelectionManipSessionBeginHandler_0;

		// Token: 0x040021E1 RID: 8673
		private static readonly IntPtr NativeMethodInfoPtr_add_ManipSessionEnd_Public_add_Void_ObjectSelectionManipSessionEndHandler_0;

		// Token: 0x040021E2 RID: 8674
		private static readonly IntPtr NativeMethodInfoPtr_remove_ManipSessionEnd_Public_rem_Void_ObjectSelectionManipSessionEndHandler_0;

		// Token: 0x040021E3 RID: 8675
		private static readonly IntPtr NativeMethodInfoPtr_add_CanClickSelectDeselect_Public_add_Void_ObjectSelectionCanClickSelectDeselectHandler_0;

		// Token: 0x040021E4 RID: 8676
		private static readonly IntPtr NativeMethodInfoPtr_remove_CanClickSelectDeselect_Public_rem_Void_ObjectSelectionCanClickSelectDeselectHandler_0;

		// Token: 0x040021E5 RID: 8677
		private static readonly IntPtr NativeMethodInfoPtr_add_CanMultiSelectDeselect_Public_add_Void_ObjectSelectionCanMultiSelectDeselectHandler_0;

		// Token: 0x040021E6 RID: 8678
		private static readonly IntPtr NativeMethodInfoPtr_remove_CanMultiSelectDeselect_Public_rem_Void_ObjectSelectionCanMultiSelectDeselectHandler_0;

		// Token: 0x040021E7 RID: 8679
		private static readonly IntPtr NativeMethodInfoPtr_add_Changed_Public_add_Void_ObjectSelectionChangedHandler_0;

		// Token: 0x040021E8 RID: 8680
		private static readonly IntPtr NativeMethodInfoPtr_remove_Changed_Public_rem_Void_ObjectSelectionChangedHandler_0;

		// Token: 0x040021E9 RID: 8681
		private static readonly IntPtr NativeMethodInfoPtr_add_WillBeDeleted_Public_add_Void_ObjectSelectionWillBeDeletedHandler_0;

		// Token: 0x040021EA RID: 8682
		private static readonly IntPtr NativeMethodInfoPtr_remove_WillBeDeleted_Public_rem_Void_ObjectSelectionWillBeDeletedHandler_0;

		// Token: 0x040021EB RID: 8683
		private static readonly IntPtr NativeMethodInfoPtr_add_Deleted_Public_add_Void_ObjectSelectionDeletedHandler_0;

		// Token: 0x040021EC RID: 8684
		private static readonly IntPtr NativeMethodInfoPtr_remove_Deleted_Public_rem_Void_ObjectSelectionDeletedHandler_0;

		// Token: 0x040021ED RID: 8685
		private static readonly IntPtr NativeMethodInfoPtr_add_WillBeDuplicated_Public_add_Void_ObjectSelectionWillBeDuplicatedHandler_0;

		// Token: 0x040021EE RID: 8686
		private static readonly IntPtr NativeMethodInfoPtr_remove_WillBeDuplicated_Public_rem_Void_ObjectSelectionWillBeDuplicatedHandler_0;

		// Token: 0x040021EF RID: 8687
		private static readonly IntPtr NativeMethodInfoPtr_add_Duplicated_Public_add_Void_ObjectSelectionDuplicatedHandler_0;

		// Token: 0x040021F0 RID: 8688
		private static readonly IntPtr NativeMethodInfoPtr_remove_Duplicated_Public_rem_Void_ObjectSelectionDuplicatedHandler_0;

		// Token: 0x040021F1 RID: 8689
		private static readonly IntPtr NativeMethodInfoPtr_add_Rotated_Public_add_Void_ObjectSelectionRotatedHandler_0;

		// Token: 0x040021F2 RID: 8690
		private static readonly IntPtr NativeMethodInfoPtr_remove_Rotated_Public_rem_Void_ObjectSelectionRotatedHandler_0;

		// Token: 0x040021F3 RID: 8691
		private static readonly IntPtr NativeMethodInfoPtr_add_PreSelectCustomize_Public_add_Void_ObjectSelectionPreSelectCustomizeHandler_0;

		// Token: 0x040021F4 RID: 8692
		private static readonly IntPtr NativeMethodInfoPtr_remove_PreSelectCustomize_Public_rem_Void_ObjectSelectionPreSelectCustomizeHandler_0;

		// Token: 0x040021F5 RID: 8693
		private static readonly IntPtr NativeMethodInfoPtr_add_PreDeselectCustomize_Public_add_Void_ObjectSelectionPreDeselectCustomizeHandler_0;

		// Token: 0x040021F6 RID: 8694
		private static readonly IntPtr NativeMethodInfoPtr_remove_PreDeselectCustomize_Public_rem_Void_ObjectSelectionPreDeselectCustomizeHandler_0;

		// Token: 0x040021F7 RID: 8695
		private static readonly IntPtr NativeMethodInfoPtr_add_Enabled_Public_add_Void_ObjectSelectionEnabled_0;

		// Token: 0x040021F8 RID: 8696
		private static readonly IntPtr NativeMethodInfoPtr_remove_Enabled_Public_rem_Void_ObjectSelectionEnabled_0;

		// Token: 0x040021F9 RID: 8697
		private static readonly IntPtr NativeMethodInfoPtr_add_Disabled_Public_add_Void_ObjectSelectionDisabled_0;

		// Token: 0x040021FA RID: 8698
		private static readonly IntPtr NativeMethodInfoPtr_remove_Disabled_Public_rem_Void_ObjectSelectionDisabled_0;

		// Token: 0x040021FB RID: 8699
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040021FC RID: 8700
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_SystemCall_Public_Void_0;

		// Token: 0x040021FD RID: 8701
		private static readonly IntPtr NativeMethodInfoPtr_AttachGizmoController_Public_Void_IObjectCollectionGizmoController_0;

		// Token: 0x040021FE RID: 8702
		private static readonly IntPtr NativeMethodInfoPtr_IsRenderIgnoreCamera_Public_Boolean_Camera_0;

		// Token: 0x040021FF RID: 8703
		private static readonly IntPtr NativeMethodInfoPtr_AddRenderIgnoreCamera_Public_Void_Camera_0;

		// Token: 0x04002200 RID: 8704
		private static readonly IntPtr NativeMethodInfoPtr_RemoveRenderIgnoreCamera_Public_Void_Camera_0;

		// Token: 0x04002201 RID: 8705
		private static readonly IntPtr NativeMethodInfoPtr_SetEnabled_Public_Void_Boolean_0;

		// Token: 0x04002202 RID: 8706
		private static readonly IntPtr NativeMethodInfoPtr_SetRotation_Public_Void_Quaternion_0;

		// Token: 0x04002203 RID: 8707
		private static readonly IntPtr NativeMethodInfoPtr_Rotate_Public_Void_Axis_Single_ObjectRotationPivot_0;

		// Token: 0x04002204 RID: 8708
		private static readonly IntPtr NativeMethodInfoPtr_AppendObjects_Public_Void_List_1_GameObject_Boolean_0;

		// Token: 0x04002205 RID: 8709
		private static readonly IntPtr NativeMethodInfoPtr_RemoveObjects_Public_Void_List_1_GameObject_Boolean_0;

		// Token: 0x04002206 RID: 8710
		private static readonly IntPtr NativeMethodInfoPtr_SetSelectedObjects_Public_Void_List_1_GameObject_Boolean_0;

		// Token: 0x04002207 RID: 8711
		private static readonly IntPtr NativeMethodInfoPtr_ClearSelection_Public_Void_Boolean_0;

		// Token: 0x04002208 RID: 8712
		private static readonly IntPtr NativeMethodInfoPtr_Delete_Public_Void_0;

		// Token: 0x04002209 RID: 8713
		private static readonly IntPtr NativeMethodInfoPtr_ForceDelete_Public_Void_0;

		// Token: 0x0400220A RID: 8714
		private static readonly IntPtr NativeMethodInfoPtr_CanBeDeleted_Public_Boolean_0;

		// Token: 0x0400220B RID: 8715
		private static readonly IntPtr NativeMethodInfoPtr_CanBeDuplicated_Public_Boolean_0;

		// Token: 0x0400220C RID: 8716
		private static readonly IntPtr NativeMethodInfoPtr_CanBeModifiedByAPI_Public_Boolean_0;

		// Token: 0x0400220D RID: 8717
		private static readonly IntPtr NativeMethodInfoPtr_Duplicate_Public_ObjectSelectionDuplicationResult_0;

		// Token: 0x0400220E RID: 8718
		private static readonly IntPtr NativeMethodInfoPtr_IsSelectionExactMatch_Public_Boolean_List_1_GameObject_0;

		// Token: 0x0400220F RID: 8719
		private static readonly IntPtr NativeMethodInfoPtr_IsObjectSelected_Public_Boolean_GameObject_0;

		// Token: 0x04002210 RID: 8720
		private static readonly IntPtr NativeMethodInfoPtr_GetWorldAABB_Public_AABB_0;

		// Token: 0x04002211 RID: 8721
		private static readonly IntPtr NativeMethodInfoPtr_Update_SystemCall_Public_Void_0;

		// Token: 0x04002212 RID: 8722
		private static readonly IntPtr NativeMethodInfoPtr_Render_SystemCall_Public_Void_Camera_0;

		// Token: 0x04002213 RID: 8723
		private static readonly IntPtr NativeMethodInfoPtr_OnInputDevicePickButtonDown_Private_Void_0;

		// Token: 0x04002214 RID: 8724
		private static readonly IntPtr NativeMethodInfoPtr_OnInputDevicePickButtonUp_Private_Void_0;

		// Token: 0x04002215 RID: 8725
		private static readonly IntPtr NativeMethodInfoPtr_OnInputDeviceWasMoved_Private_Void_0;

		// Token: 0x04002216 RID: 8726
		private static readonly IntPtr NativeMethodInfoPtr_PerformMultiSelect_Private_Void_0;

		// Token: 0x04002217 RID: 8727
		private static readonly IntPtr NativeMethodInfoPtr_PerformClickSelect_Private_Void_0;

		// Token: 0x04002218 RID: 8728
		private static readonly IntPtr NativeMethodInfoPtr_DoPreSelectCustomize_Private_ObjectPreSelectCustomizeInfo_List_1_GameObject_ObjectSelectReason_0;

		// Token: 0x04002219 RID: 8729
		private static readonly IntPtr NativeMethodInfoPtr_DoPreDeselectCustomize_Private_List_1_GameObject_List_1_GameObject_ObjectDeselectReason_0;

		// Token: 0x0400221A RID: 8730
		private static readonly IntPtr NativeMethodInfoPtr_FilterByRestrictions_Private_List_1_GameObject_IEnumerable_1_GameObject_SelectRestrictFlags_ObjectSelectReason_0;

		// Token: 0x0400221B RID: 8731
		private static readonly IntPtr NativeMethodInfoPtr_FilterByRestrictions_Private_List_1_GameObjectRayHit_List_1_GameObjectRayHit_SelectRestrictFlags_0;

		// Token: 0x0400221C RID: 8732
		private static readonly IntPtr NativeMethodInfoPtr_CanSelectObject_Private_Boolean_GameObject_SelectRestrictFlags_ObjectSelectReason_0;

		// Token: 0x0400221D RID: 8733
		private static readonly IntPtr NativeMethodInfoPtr_SelectObject_Private_Void_GameObject_ObjectSelectReason_0;

		// Token: 0x0400221E RID: 8734
		private static readonly IntPtr NativeMethodInfoPtr_DeselectObject_Private_Void_GameObject_ObjectDeselectReason_0;

		// Token: 0x0400221F RID: 8735
		private static readonly IntPtr NativeMethodInfoPtr_ClearSelection_Private_Void_ObjectDeselectReason_0;

		// Token: 0x04002220 RID: 8736
		private static readonly IntPtr NativeMethodInfoPtr_OnSelectionChanged_Private_Void_ObjectSelectionChangedEventArgs_0;

		// Token: 0x04002221 RID: 8737
		private static readonly IntPtr NativeMethodInfoPtr_RemoveNullAndInactiveObjectRefs_Private_Void_0;

		// Token: 0x04002222 RID: 8738
		private static readonly IntPtr NativeMethodInfoPtr_OnUndoEnd_Private_Void_IUndoRedoAction_0;

		// Token: 0x04002223 RID: 8739
		private static readonly IntPtr NativeMethodInfoPtr_OnRedoEnd_Private_Void_IUndoRedoAction_0;

		// Token: 0x04002224 RID: 8740
		private static readonly IntPtr NativeMethodInfoPtr_HandleUndoRedo_Private_Void_ObjectSelectionSnapshot_Boolean_0;

		// Token: 0x04002225 RID: 8741
		private static readonly IntPtr NativeMethodInfoPtr_OnGrabSessionBegin_Private_Void_0;

		// Token: 0x04002226 RID: 8742
		private static readonly IntPtr NativeMethodInfoPtr_OnGrabSessionEnd_Private_Void_0;

		// Token: 0x04002227 RID: 8743
		private static readonly IntPtr NativeMethodInfoPtr_OnGridSnapSessionBegin_Private_Void_0;

		// Token: 0x04002228 RID: 8744
		private static readonly IntPtr NativeMethodInfoPtr_OnGridSnapSessionEnd_Private_Void_0;

		// Token: 0x04002229 RID: 8745
		private static readonly IntPtr NativeMethodInfoPtr_OnObject2ObjectSnapSessionBegin_Private_Void_0;

		// Token: 0x0400222A RID: 8746
		private static readonly IntPtr NativeMethodInfoPtr_OnObject2ObjectSnapSessionEnd_Private_Void_0;

		// Token: 0x020003D4 RID: 980
		[Flags]
		public enum SelectRestrictFlags
		{
			// Token: 0x04003BB9 RID: 15289
			None = 0,
			// Token: 0x04003BBA RID: 15290
			ObjectLayer = 1,
			// Token: 0x04003BBB RID: 15291
			ObjectType = 2,
			// Token: 0x04003BBC RID: 15292
			Object = 4,
			// Token: 0x04003BBD RID: 15293
			SelectionListener = 8,
			// Token: 0x04003BBE RID: 15294
			All = 15
		}

		// Token: 0x020003D5 RID: 981
		public sealed class CyclicalClickSelectInfo : ValueType
		{
			// Token: 0x06004CCD RID: 19661 RVA: 0x0014E744 File Offset: 0x0014C944
			// Note: this type is marked as 'beforefieldinit'.
			static CyclicalClickSelectInfo()
			{
				Il2CppClassPointerStore<RTObjectSelection.CyclicalClickSelectInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, "CyclicalClickSelectInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTObjectSelection.CyclicalClickSelectInfo>.NativeClassPtr);
				RTObjectSelection.CyclicalClickSelectInfo.NativeFieldInfoPtr_LastSelectedIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelection.CyclicalClickSelectInfo>.NativeClassPtr, "LastSelectedIndex");
				RTObjectSelection.CyclicalClickSelectInfo.NativeFieldInfoPtr_LastPickedObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelection.CyclicalClickSelectInfo>.NativeClassPtr, "LastPickedObject");
			}

			// Token: 0x06004CCE RID: 19662 RVA: 0x0001CF17 File Offset: 0x0001B117
			public CyclicalClickSelectInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06004CCF RID: 19663 RVA: 0x0001CF20 File Offset: 0x0001B120
			public CyclicalClickSelectInfo()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTObjectSelection.CyclicalClickSelectInfo>.NativeClassPtr))
			{
			}

			// Token: 0x170019E0 RID: 6624
			// (get) Token: 0x06004CD0 RID: 19664 RVA: 0x0014E798 File Offset: 0x0014C998
			// (set) Token: 0x06004CD1 RID: 19665 RVA: 0x0001CF32 File Offset: 0x0001B132
			public unsafe int LastSelectedIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.CyclicalClickSelectInfo.NativeFieldInfoPtr_LastSelectedIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.CyclicalClickSelectInfo.NativeFieldInfoPtr_LastSelectedIndex)) = value;
				}
			}

			// Token: 0x170019E1 RID: 6625
			// (get) Token: 0x06004CD2 RID: 19666 RVA: 0x0014E7C0 File Offset: 0x0014C9C0
			// (set) Token: 0x06004CD3 RID: 19667 RVA: 0x0001CF4D File Offset: 0x0001B14D
			public unsafe GameObject LastPickedObject
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.CyclicalClickSelectInfo.NativeFieldInfoPtr_LastPickedObject);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.CyclicalClickSelectInfo.NativeFieldInfoPtr_LastPickedObject), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003BBF RID: 15295
			private static readonly IntPtr NativeFieldInfoPtr_LastSelectedIndex;

			// Token: 0x04003BC0 RID: 15296
			private static readonly IntPtr NativeFieldInfoPtr_LastPickedObject;
		}

		// Token: 0x020003D6 RID: 982
		[ObfuscatedName("RLD.RTObjectSelection+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06004CD4 RID: 19668 RVA: 0x0014E7F0 File Offset: 0x0014C9F0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<RTObjectSelection.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTObjectSelection.__c>.NativeClassPtr);
				RTObjectSelection.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelection.__c>.NativeClassPtr, "<>9");
				RTObjectSelection.__c.NativeFieldInfoPtr___9__155_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelection.__c>.NativeClassPtr, "<>9__155_0");
				RTObjectSelection.__c.NativeFieldInfoPtr___9__155_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelection.__c>.NativeClassPtr, "<>9__155_1");
				RTObjectSelection.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection.__c>.NativeClassPtr, 100670003);
				RTObjectSelection.__c.NativeMethodInfoPtr__RemoveNullAndInactiveObjectRefs_b__155_0_Internal_Boolean_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection.__c>.NativeClassPtr, 100670004);
				RTObjectSelection.__c.NativeMethodInfoPtr__RemoveNullAndInactiveObjectRefs_b__155_1_Internal_Boolean_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection.__c>.NativeClassPtr, 100670005);
			}

			// Token: 0x06004CD5 RID: 19669 RVA: 0x0014E894 File Offset: 0x0014CA94
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTObjectSelection.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004CD6 RID: 19670 RVA: 0x0014E8D0 File Offset: 0x0014CAD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93913, XrefRangeEnd = 93917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RemoveNullAndInactiveObjectRefs_b__155_0(GameObject item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.__c.NativeMethodInfoPtr__RemoveNullAndInactiveObjectRefs_b__155_0_Internal_Boolean_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004CD7 RID: 19671 RVA: 0x0014E920 File Offset: 0x0014CB20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93917, XrefRangeEnd = 93921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RemoveNullAndInactiveObjectRefs_b__155_1(GameObject item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.__c.NativeMethodInfoPtr__RemoveNullAndInactiveObjectRefs_b__155_1_Internal_Boolean_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004CD8 RID: 19672 RVA: 0x0001CF6C File Offset: 0x0001B16C
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170019E2 RID: 6626
			// (get) Token: 0x06004CD9 RID: 19673 RVA: 0x0014E970 File Offset: 0x0014CB70
			// (set) Token: 0x06004CDA RID: 19674 RVA: 0x0001CF75 File Offset: 0x0001B175
			public unsafe static RTObjectSelection.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RTObjectSelection.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTObjectSelection.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RTObjectSelection.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019E3 RID: 6627
			// (get) Token: 0x06004CDB RID: 19675 RVA: 0x0014E998 File Offset: 0x0014CB98
			// (set) Token: 0x06004CDC RID: 19676 RVA: 0x0001CF87 File Offset: 0x0001B187
			public unsafe static Predicate<GameObject> __9__155_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RTObjectSelection.__c.NativeFieldInfoPtr___9__155_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<GameObject>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RTObjectSelection.__c.NativeFieldInfoPtr___9__155_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019E4 RID: 6628
			// (get) Token: 0x06004CDD RID: 19677 RVA: 0x0014E9C0 File Offset: 0x0014CBC0
			// (set) Token: 0x06004CDE RID: 19678 RVA: 0x0001CF99 File Offset: 0x0001B199
			public unsafe static Predicate<GameObject> __9__155_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RTObjectSelection.__c.NativeFieldInfoPtr___9__155_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<GameObject>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RTObjectSelection.__c.NativeFieldInfoPtr___9__155_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003BC1 RID: 15297
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04003BC2 RID: 15298
			private static readonly IntPtr NativeFieldInfoPtr___9__155_0;

			// Token: 0x04003BC3 RID: 15299
			private static readonly IntPtr NativeFieldInfoPtr___9__155_1;

			// Token: 0x04003BC4 RID: 15300
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003BC5 RID: 15301
			private static readonly IntPtr NativeMethodInfoPtr__RemoveNullAndInactiveObjectRefs_b__155_0_Internal_Boolean_GameObject_0;

			// Token: 0x04003BC6 RID: 15302
			private static readonly IntPtr NativeMethodInfoPtr__RemoveNullAndInactiveObjectRefs_b__155_1_Internal_Boolean_GameObject_0;
		}

		// Token: 0x020003D7 RID: 983
		[ObfuscatedName("RLD.RTObjectSelection+<>c__DisplayClass144_0")]
		public sealed class __c__DisplayClass144_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06004CDF RID: 19679 RVA: 0x0014E9E8 File Offset: 0x0014CBE8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass144_0()
			{
				Il2CppClassPointerStore<RTObjectSelection.__c__DisplayClass144_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RTObjectSelection>.NativeClassPtr, "<>c__DisplayClass144_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTObjectSelection.__c__DisplayClass144_0>.NativeClassPtr);
				RTObjectSelection.__c__DisplayClass144_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelection.__c__DisplayClass144_0>.NativeClassPtr, "<>4__this");
				RTObjectSelection.__c__DisplayClass144_0.NativeFieldInfoPtr_boundsQConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTObjectSelection.__c__DisplayClass144_0>.NativeClassPtr, "boundsQConfig");
				RTObjectSelection.__c__DisplayClass144_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection.__c__DisplayClass144_0>.NativeClassPtr, 100670006);
				RTObjectSelection.__c__DisplayClass144_0.NativeMethodInfoPtr__PerformMultiSelect_b__0_Internal_Boolean_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTObjectSelection.__c__DisplayClass144_0>.NativeClassPtr, 100670007);
			}

			// Token: 0x06004CE0 RID: 19680 RVA: 0x0014EA64 File Offset: 0x0014CC64
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass144_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTObjectSelection.__c__DisplayClass144_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.__c__DisplayClass144_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004CE1 RID: 19681 RVA: 0x0014EAA0 File Offset: 0x0014CCA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93921, XrefRangeEnd = 93928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _PerformMultiSelect_b__0(GameObject item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTObjectSelection.__c__DisplayClass144_0.NativeMethodInfoPtr__PerformMultiSelect_b__0_Internal_Boolean_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004CE2 RID: 19682 RVA: 0x0001CFAB File Offset: 0x0001B1AB
			public __c__DisplayClass144_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170019E5 RID: 6629
			// (get) Token: 0x06004CE3 RID: 19683 RVA: 0x0014EAF0 File Offset: 0x0014CCF0
			// (set) Token: 0x06004CE4 RID: 19684 RVA: 0x0001CFB4 File Offset: 0x0001B1B4
			public unsafe RTObjectSelection __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.__c__DisplayClass144_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTObjectSelection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.__c__DisplayClass144_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019E6 RID: 6630
			// (get) Token: 0x06004CE5 RID: 19685 RVA: 0x0014EB20 File Offset: 0x0014CD20
			// (set) Token: 0x06004CE6 RID: 19686 RVA: 0x0001CFD3 File Offset: 0x0001B1D3
			public unsafe ObjectBounds.QueryConfig boundsQConfig
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.__c__DisplayClass144_0.NativeFieldInfoPtr_boundsQConfig);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTObjectSelection.__c__DisplayClass144_0.NativeFieldInfoPtr_boundsQConfig)) = value;
				}
			}

			// Token: 0x04003BC7 RID: 15303
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003BC8 RID: 15304
			private static readonly IntPtr NativeFieldInfoPtr_boundsQConfig;

			// Token: 0x04003BC9 RID: 15305
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003BCA RID: 15306
			private static readonly IntPtr NativeMethodInfoPtr__PerformMultiSelect_b__0_Internal_Boolean_GameObject_0;
		}
	}
}
