using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200005B RID: 91
	[Serializable]
	public class Gizmo : global::Il2CppSystem.Object
	{
		// Token: 0x06000574 RID: 1396 RVA: 0x00035E40 File Offset: 0x00034040
		// Note: this type is marked as 'beforefieldinit'.
		static Gizmo()
		{
			Il2CppClassPointerStore<Gizmo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "Gizmo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Gizmo>.NativeClassPtr);
			Gizmo.NativeFieldInfoPtr_PostEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, "PostEnabled");
			Gizmo.NativeFieldInfoPtr_PostDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, "PostDisabled");
			Gizmo.NativeFieldInfoPtr_PreUpdateBegin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, "PreUpdateBegin");
			Gizmo.NativeFieldInfoPtr_PostUpdateEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, "PostUpdateEnd");
			Gizmo.NativeFieldInfoPtr_PreHoverEnter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, "PreHoverEnter");
			Gizmo.NativeFieldInfoPtr_PostHoverEnter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, "PostHoverEnter");
			Gizmo.NativeFieldInfoPtr_PreHoverExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, "PreHoverExit");
			Gizmo.NativeFieldInfoPtr_PostHoverExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, "PostHoverExit");
			Gizmo.NativeFieldInfoPtr_PreDragBegin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, "PreDragBegin");
			Gizmo.NativeFieldInfoPtr_PostDragBegin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, "PostDragBegin");
			Gizmo.NativeFieldInfoPtr_PreDragEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, "PreDragEnd");
			Gizmo.NativeFieldInfoPtr_PostDragEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, "PostDragEnd");
			Gizmo.NativeFieldInfoPtr_PreDragUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, "PreDragUpdate");
			Gizmo.NativeFieldInfoPtr_PostDragUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, "PostDragUpdate");
			Gizmo.NativeFieldInfoPtr_PreHandlePicked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, "PreHandlePicked");
			Gizmo.NativeFieldInfoPtr_PostHandlePicked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, "PostHandlePicked");
			Gizmo.NativeFieldInfoPtr_PreDragBeginAttempt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, "PreDragBeginAttempt");
			Gizmo.NativeFieldInfoPtr_PostDragBeginAttempt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, "PostDragBeginAttempt");
			Gizmo.NativeFieldInfoPtr__isEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, "_isEnabled");
			Gizmo.NativeFieldInfoPtr__handles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, "_handles");
			Gizmo.NativeFieldInfoPtr__behaviours = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, "_behaviours");
			Gizmo.NativeFieldInfoPtr__hoverInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, "_hoverInfo");
			Gizmo.NativeFieldInfoPtr__dragInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, "_dragInfo");
			Gizmo.NativeFieldInfoPtr__hoveredHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, "_hoveredHandle");
			Gizmo.NativeFieldInfoPtr__genericHoverPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, "_genericHoverPriority");
			Gizmo.NativeFieldInfoPtr__hoverPriority3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, "_hoverPriority3D");
			Gizmo.NativeFieldInfoPtr__hoverPriority2D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, "_hoverPriority2D");
			Gizmo.NativeFieldInfoPtr__activeDragSession = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, "_activeDragSession");
			Gizmo.NativeFieldInfoPtr__transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, "_transform");
			Gizmo.NativeFieldInfoPtr__moveGizmo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, "_moveGizmo");
			Gizmo.NativeFieldInfoPtr__rotationGizmo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, "_rotationGizmo");
			Gizmo.NativeFieldInfoPtr__scaleGizmo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, "_scaleGizmo");
			Gizmo.NativeFieldInfoPtr__universalGizmo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, "_universalGizmo");
			Gizmo.NativeFieldInfoPtr__objectTransformGizmo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, "_objectTransformGizmo");
			Gizmo.NativeFieldInfoPtr__boxGizmo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, "_boxGizmo");
			Gizmo.NativeFieldInfoPtr__objectExtrudeGizmo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, "_objectExtrudeGizmo");
			Gizmo.NativeFieldInfoPtr__sceneGizmo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, "_sceneGizmo");
			Gizmo.NativeMethodInfoPtr_get_InputDeviceDragButtonIndex_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664113);
			Gizmo.NativeMethodInfoPtr_get_NumHandles_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664114);
			Gizmo.NativeMethodInfoPtr_get_FocusCamera_Public_get_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664115);
			Gizmo.NativeMethodInfoPtr_get_IsEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664116);
			Gizmo.NativeMethodInfoPtr_get_GenericHoverPriority_Public_get_Priority_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664117);
			Gizmo.NativeMethodInfoPtr_get_HoverPriority3D_Public_get_Priority_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664118);
			Gizmo.NativeMethodInfoPtr_get_HoverPriority2D_Public_get_Priority_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664119);
			Gizmo.NativeMethodInfoPtr_get_Transform_Public_get_GizmoTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664120);
			Gizmo.NativeMethodInfoPtr_get_HoverInfo_Public_get_GizmoHoverInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664121);
			Gizmo.NativeMethodInfoPtr_get_IsHovered_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664122);
			Gizmo.NativeMethodInfoPtr_get_HoverHandleId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664123);
			Gizmo.NativeMethodInfoPtr_get_HoverHandleDimension_Public_get_GizmoDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664124);
			Gizmo.NativeMethodInfoPtr_get_HoverPoint_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664125);
			Gizmo.NativeMethodInfoPtr_get_DragInfo_Public_get_GizmoDragInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664126);
			Gizmo.NativeMethodInfoPtr_get_IsDragged_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664127);
			Gizmo.NativeMethodInfoPtr_get_ActiveDragChannel_Public_get_GizmoDragChannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664128);
			Gizmo.NativeMethodInfoPtr_get_DragHandleId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664129);
			Gizmo.NativeMethodInfoPtr_get_DragBeginPoint_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664130);
			Gizmo.NativeMethodInfoPtr_get_DragHandleDimension_Public_get_GizmoDimension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664131);
			Gizmo.NativeMethodInfoPtr_get_TotalDragOffset_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664132);
			Gizmo.NativeMethodInfoPtr_get_TotalDragRotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664133);
			Gizmo.NativeMethodInfoPtr_get_TotalDragScale_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664134);
			Gizmo.NativeMethodInfoPtr_get_RelativeDragOffset_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664135);
			Gizmo.NativeMethodInfoPtr_get_RelativeDragRotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664136);
			Gizmo.NativeMethodInfoPtr_get_RelativeDragScale_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664137);
			Gizmo.NativeMethodInfoPtr_get_MoveGizmo_Public_get_MoveGizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664138);
			Gizmo.NativeMethodInfoPtr_get_RotationGizmo_Public_get_RotationGizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664139);
			Gizmo.NativeMethodInfoPtr_get_ScaleGizmo_Public_get_ScaleGizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664140);
			Gizmo.NativeMethodInfoPtr_get_UniversalGizmo_Public_get_UniversalGizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664141);
			Gizmo.NativeMethodInfoPtr_get_ObjectTransformGizmo_Public_get_ObjectTransformGizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664142);
			Gizmo.NativeMethodInfoPtr_get_BoxGizmo_Public_get_BoxGizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664143);
			Gizmo.NativeMethodInfoPtr_get_ObjectExtrudeGizmo_Public_get_ObjectExtrudeGizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664144);
			Gizmo.NativeMethodInfoPtr_get_SceneGizmo_Public_get_SceneGizmo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664145);
			Gizmo.NativeMethodInfoPtr_add_PostEnabled_Public_add_Void_GizmoPostEnabledHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664077);
			Gizmo.NativeMethodInfoPtr_remove_PostEnabled_Public_rem_Void_GizmoPostEnabledHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664078);
			Gizmo.NativeMethodInfoPtr_add_PostDisabled_Public_add_Void_GizmoPostDisabledHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664079);
			Gizmo.NativeMethodInfoPtr_remove_PostDisabled_Public_rem_Void_GizmoPostDisabledHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664080);
			Gizmo.NativeMethodInfoPtr_add_PreUpdateBegin_Public_add_Void_GizmoPreUpdateBeginHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664081);
			Gizmo.NativeMethodInfoPtr_remove_PreUpdateBegin_Public_rem_Void_GizmoPreUpdateBeginHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664082);
			Gizmo.NativeMethodInfoPtr_add_PostUpdateEnd_Public_add_Void_GizmoPostUpdateEndHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664083);
			Gizmo.NativeMethodInfoPtr_remove_PostUpdateEnd_Public_rem_Void_GizmoPostUpdateEndHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664084);
			Gizmo.NativeMethodInfoPtr_add_PreHoverEnter_Public_add_Void_GizmoPreHoverEnterHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664085);
			Gizmo.NativeMethodInfoPtr_remove_PreHoverEnter_Public_rem_Void_GizmoPreHoverEnterHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664086);
			Gizmo.NativeMethodInfoPtr_add_PostHoverEnter_Public_add_Void_GizmoPostHoverEnterHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664087);
			Gizmo.NativeMethodInfoPtr_remove_PostHoverEnter_Public_rem_Void_GizmoPostHoverEnterHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664088);
			Gizmo.NativeMethodInfoPtr_add_PreHoverExit_Public_add_Void_GizmoPreHoverExitHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664089);
			Gizmo.NativeMethodInfoPtr_remove_PreHoverExit_Public_rem_Void_GizmoPreHoverExitHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664090);
			Gizmo.NativeMethodInfoPtr_add_PostHoverExit_Public_add_Void_GizmoPostHoverExitHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664091);
			Gizmo.NativeMethodInfoPtr_remove_PostHoverExit_Public_rem_Void_GizmoPostHoverExitHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664092);
			Gizmo.NativeMethodInfoPtr_add_PreDragBegin_Public_add_Void_GizmoPreDragBeginHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664093);
			Gizmo.NativeMethodInfoPtr_remove_PreDragBegin_Public_rem_Void_GizmoPreDragBeginHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664094);
			Gizmo.NativeMethodInfoPtr_add_PostDragBegin_Public_add_Void_GizmoPostDragBeginHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664095);
			Gizmo.NativeMethodInfoPtr_remove_PostDragBegin_Public_rem_Void_GizmoPostDragBeginHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664096);
			Gizmo.NativeMethodInfoPtr_add_PreDragEnd_Public_add_Void_GizmoPreDragEndHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664097);
			Gizmo.NativeMethodInfoPtr_remove_PreDragEnd_Public_rem_Void_GizmoPreDragEndHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664098);
			Gizmo.NativeMethodInfoPtr_add_PostDragEnd_Public_add_Void_GizmoPostDragEndHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664099);
			Gizmo.NativeMethodInfoPtr_remove_PostDragEnd_Public_rem_Void_GizmoPostDragEndHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664100);
			Gizmo.NativeMethodInfoPtr_add_PreDragUpdate_Public_add_Void_GizmoPreDragUpdateHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664101);
			Gizmo.NativeMethodInfoPtr_remove_PreDragUpdate_Public_rem_Void_GizmoPreDragUpdateHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664102);
			Gizmo.NativeMethodInfoPtr_add_PostDragUpdate_Public_add_Void_GizmoPostDragUpdateHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664103);
			Gizmo.NativeMethodInfoPtr_remove_PostDragUpdate_Public_rem_Void_GizmoPostDragUpdateHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664104);
			Gizmo.NativeMethodInfoPtr_add_PreHandlePicked_Public_add_Void_GizmoPreHandlePickedHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664105);
			Gizmo.NativeMethodInfoPtr_remove_PreHandlePicked_Public_rem_Void_GizmoPreHandlePickedHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664106);
			Gizmo.NativeMethodInfoPtr_add_PostHandlePicked_Public_add_Void_GizmoPostHandlePickedHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664107);
			Gizmo.NativeMethodInfoPtr_remove_PostHandlePicked_Public_rem_Void_GizmoPostHandlePickedHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664108);
			Gizmo.NativeMethodInfoPtr_add_PreDragBeginAttempt_Public_add_Void_GizmoPreDragBeginAttemptHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664109);
			Gizmo.NativeMethodInfoPtr_remove_PreDragBeginAttempt_Public_rem_Void_GizmoPreDragBeginAttemptHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664110);
			Gizmo.NativeMethodInfoPtr_add_PostDragBeginAttempt_Public_add_Void_GizmoPostDragBeginAttemptHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664111);
			Gizmo.NativeMethodInfoPtr_remove_PostDragBeginAttempt_Public_rem_Void_GizmoPostDragBeginAttemptHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664112);
			Gizmo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664146);
			Gizmo.NativeMethodInfoPtr_GetWorkCamera_Public_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664147);
			Gizmo.NativeMethodInfoPtr_CreateHandle_Public_GizmoHandle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664148);
			Gizmo.NativeMethodInfoPtr_SetEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664149);
			Gizmo.NativeMethodInfoPtr_AddBehaviour_Public_BehaviourType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664150);
			Gizmo.NativeMethodInfoPtr_AddBehaviour_Public_Boolean_IGizmoBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664151);
			Gizmo.NativeMethodInfoPtr_RemoveBehaviour_Public_Boolean_IGizmoBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664152);
			Gizmo.NativeMethodInfoPtr_GetBehavioursOfType_Public_List_1_BehaviourType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664153);
			Gizmo.NativeMethodInfoPtr_GetFirstBehaviourOfType_Public_BehaviourType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664154);
			Gizmo.NativeMethodInfoPtr_GetFirstBehaviourOfType_Public_IGizmoBehaviour_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664155);
			Gizmo.NativeMethodInfoPtr_GetAllHandlesHoverData_Public_List_1_GizmoHandleHoverData_Ray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664156);
			Gizmo.NativeMethodInfoPtr_GetHandleById_SystemCall_Public_IGizmoHandle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664157);
			Gizmo.NativeMethodInfoPtr_OnGUI_SystemCall_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664158);
			Gizmo.NativeMethodInfoPtr_OnUpdateBegin_SystemCall_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664159);
			Gizmo.NativeMethodInfoPtr_OnUpdateEnd_SystemCall_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664160);
			Gizmo.NativeMethodInfoPtr_UpdateHandleHoverInfo_SystemCall_Public_Void_GizmoHoverInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664161);
			Gizmo.NativeMethodInfoPtr_Render_SystemCall_Public_Void_Camera_Il2CppStructArray_1_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664162);
			Gizmo.NativeMethodInfoPtr_HandleInputDeviceEvents_SystemCall_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664163);
			Gizmo.NativeMethodInfoPtr_OnInputDevicePickButtonDown_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664164);
			Gizmo.NativeMethodInfoPtr_OnInputDevicePickButtonUp_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664165);
			Gizmo.NativeMethodInfoPtr_EndDragSession_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664166);
			Gizmo.NativeMethodInfoPtr_OnInputDeviceMoved_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664167);
			Gizmo.NativeMethodInfoPtr_TryActivateDragSession_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gizmo>.NativeClassPtr, 100664168);
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06000575 RID: 1397 RVA: 0x00036884 File Offset: 0x00034A84
		public unsafe static int InputDeviceDragButtonIndex
		{
			[CallerCount(44)]
			[CachedScanResults(RefRangeStart = 18186, RefRangeEnd = 18230, XrefRangeStart = 18186, XrefRangeEnd = 18230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_get_InputDeviceDragButtonIndex_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000576 RID: 1398 RVA: 0x000368B4 File Offset: 0x00034AB4
		public unsafe int NumHandles
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59840, XrefRangeEnd = 59841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_get_NumHandles_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000577 RID: 1399 RVA: 0x000368F0 File Offset: 0x00034AF0
		public unsafe Camera FocusCamera
		{
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 59847, RefRangeEnd = 59872, XrefRangeStart = 59841, XrefRangeEnd = 59847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_get_FocusCamera_Public_get_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr3) : null;
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06000578 RID: 1400 RVA: 0x00036930 File Offset: 0x00034B30
		public unsafe bool IsEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_get_IsEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06000579 RID: 1401 RVA: 0x0003696C File Offset: 0x00034B6C
		public unsafe Priority GenericHoverPriority
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 59872, RefRangeEnd = 59873, XrefRangeStart = 59872, XrefRangeEnd = 59872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_get_GenericHoverPriority_Public_get_Priority_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Priority>(intPtr3) : null;
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x0600057A RID: 1402 RVA: 0x000369AC File Offset: 0x00034BAC
		public unsafe Priority HoverPriority3D
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_get_HoverPriority3D_Public_get_Priority_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Priority>(intPtr3) : null;
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x0600057B RID: 1403 RVA: 0x000369EC File Offset: 0x00034BEC
		public unsafe Priority HoverPriority2D
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_get_HoverPriority2D_Public_get_Priority_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Priority>(intPtr3) : null;
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x0600057C RID: 1404 RVA: 0x00036A2C File Offset: 0x00034C2C
		public unsafe GizmoTransform Transform
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_get_Transform_Public_get_GizmoTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoTransform>(intPtr3) : null;
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x0600057D RID: 1405 RVA: 0x00036A6C File Offset: 0x00034C6C
		public unsafe GizmoHoverInfo HoverInfo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_get_HoverInfo_Public_get_GizmoHoverInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoHoverInfo>(intPtr3) : null;
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x0600057E RID: 1406 RVA: 0x00036AAC File Offset: 0x00034CAC
		public unsafe bool IsHovered
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 25668, RefRangeEnd = 25669, XrefRangeStart = 25668, XrefRangeEnd = 25669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_get_IsHovered_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x0600057F RID: 1407 RVA: 0x00036AE8 File Offset: 0x00034CE8
		public unsafe int HoverHandleId
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 59873, RefRangeEnd = 59887, XrefRangeStart = 59873, XrefRangeEnd = 59873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_get_HoverHandleId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000580 RID: 1408 RVA: 0x00036B24 File Offset: 0x00034D24
		public unsafe GizmoDimension HoverHandleDimension
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_get_HoverHandleDimension_Public_get_GizmoDimension_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoDimension>(intPtr3) : null;
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000581 RID: 1409 RVA: 0x00036B64 File Offset: 0x00034D64
		public unsafe Vector3 HoverPoint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_get_HoverPoint_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06000582 RID: 1410 RVA: 0x00036BA4 File Offset: 0x00034DA4
		public unsafe GizmoDragInfo DragInfo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_get_DragInfo_Public_get_GizmoDragInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoDragInfo>(intPtr3) : null;
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06000583 RID: 1411 RVA: 0x00036BE4 File Offset: 0x00034DE4
		public unsafe bool IsDragged
		{
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 59887, RefRangeEnd = 59929, XrefRangeStart = 59887, XrefRangeEnd = 59887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_get_IsDragged_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06000584 RID: 1412 RVA: 0x00036C20 File Offset: 0x00034E20
		public unsafe GizmoDragChannel ActiveDragChannel
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 59929, RefRangeEnd = 59932, XrefRangeStart = 59929, XrefRangeEnd = 59929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_get_ActiveDragChannel_Public_get_GizmoDragChannel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoDragChannel>(intPtr3) : null;
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06000585 RID: 1413 RVA: 0x00036C60 File Offset: 0x00034E60
		public unsafe int DragHandleId
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 59932, RefRangeEnd = 59943, XrefRangeStart = 59932, XrefRangeEnd = 59932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_get_DragHandleId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06000586 RID: 1414 RVA: 0x00036C9C File Offset: 0x00034E9C
		public unsafe Vector3 DragBeginPoint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_get_DragBeginPoint_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000587 RID: 1415 RVA: 0x00036CDC File Offset: 0x00034EDC
		public unsafe GizmoDimension DragHandleDimension
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_get_DragHandleDimension_Public_get_GizmoDimension_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoDimension>(intPtr3) : null;
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06000588 RID: 1416 RVA: 0x00036D1C File Offset: 0x00034F1C
		public unsafe Vector3 TotalDragOffset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_get_TotalDragOffset_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x06000589 RID: 1417 RVA: 0x00036D5C File Offset: 0x00034F5C
		public unsafe Quaternion TotalDragRotation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_get_TotalDragRotation_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr3) : null;
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x0600058A RID: 1418 RVA: 0x00036D9C File Offset: 0x00034F9C
		public unsafe Vector3 TotalDragScale
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 59943, RefRangeEnd = 59946, XrefRangeStart = 59943, XrefRangeEnd = 59943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_get_TotalDragScale_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x0600058B RID: 1419 RVA: 0x00036DDC File Offset: 0x00034FDC
		public unsafe Vector3 RelativeDragOffset
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 59946, RefRangeEnd = 59949, XrefRangeStart = 59946, XrefRangeEnd = 59946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_get_RelativeDragOffset_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x0600058C RID: 1420 RVA: 0x00036E1C File Offset: 0x0003501C
		public unsafe Quaternion RelativeDragRotation
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 59949, RefRangeEnd = 59951, XrefRangeStart = 59949, XrefRangeEnd = 59949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_get_RelativeDragRotation_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr3) : null;
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x0600058D RID: 1421 RVA: 0x00036E5C File Offset: 0x0003505C
		public unsafe Vector3 RelativeDragScale
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 59951, RefRangeEnd = 59952, XrefRangeStart = 59951, XrefRangeEnd = 59951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_get_RelativeDragScale_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x0600058E RID: 1422 RVA: 0x00036E9C File Offset: 0x0003509C
		public unsafe MoveGizmo MoveGizmo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_get_MoveGizmo_Public_get_MoveGizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MoveGizmo>(intPtr3) : null;
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x0600058F RID: 1423 RVA: 0x00036EDC File Offset: 0x000350DC
		public unsafe RotationGizmo RotationGizmo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_get_RotationGizmo_Public_get_RotationGizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RotationGizmo>(intPtr3) : null;
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000590 RID: 1424 RVA: 0x00036F1C File Offset: 0x0003511C
		public unsafe ScaleGizmo ScaleGizmo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_get_ScaleGizmo_Public_get_ScaleGizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScaleGizmo>(intPtr3) : null;
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000591 RID: 1425 RVA: 0x00036F5C File Offset: 0x0003515C
		public unsafe UniversalGizmo UniversalGizmo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_get_UniversalGizmo_Public_get_UniversalGizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UniversalGizmo>(intPtr3) : null;
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x06000592 RID: 1426 RVA: 0x00036F9C File Offset: 0x0003519C
		public unsafe ObjectTransformGizmo ObjectTransformGizmo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_get_ObjectTransformGizmo_Public_get_ObjectTransformGizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectTransformGizmo>(intPtr3) : null;
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x06000593 RID: 1427 RVA: 0x00036FDC File Offset: 0x000351DC
		public unsafe BoxGizmo BoxGizmo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_get_BoxGizmo_Public_get_BoxGizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BoxGizmo>(intPtr3) : null;
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06000594 RID: 1428 RVA: 0x0003701C File Offset: 0x0003521C
		public unsafe ObjectExtrudeGizmo ObjectExtrudeGizmo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_get_ObjectExtrudeGizmo_Public_get_ObjectExtrudeGizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectExtrudeGizmo>(intPtr3) : null;
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06000595 RID: 1429 RVA: 0x0003705C File Offset: 0x0003525C
		public unsafe SceneGizmo SceneGizmo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_get_SceneGizmo_Public_get_SceneGizmo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SceneGizmo>(intPtr3) : null;
			}
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x0003709C File Offset: 0x0003529C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 59956, RefRangeEnd = 59963, XrefRangeStart = 59952, XrefRangeEnd = 59956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_PostEnabled(GizmoPostEnabledHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_add_PostEnabled_Public_add_Void_GizmoPostEnabledHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x000370E0 File Offset: 0x000352E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59963, XrefRangeEnd = 59967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_PostEnabled(GizmoPostEnabledHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_remove_PostEnabled_Public_rem_Void_GizmoPostEnabledHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x00037124 File Offset: 0x00035324
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 59971, RefRangeEnd = 59973, XrefRangeStart = 59967, XrefRangeEnd = 59971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_PostDisabled(GizmoPostDisabledHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_add_PostDisabled_Public_add_Void_GizmoPostDisabledHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x00037168 File Offset: 0x00035368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59973, XrefRangeEnd = 59977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_PostDisabled(GizmoPostDisabledHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_remove_PostDisabled_Public_rem_Void_GizmoPostDisabledHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x000371AC File Offset: 0x000353AC
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 59981, RefRangeEnd = 59998, XrefRangeStart = 59977, XrefRangeEnd = 59981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_PreUpdateBegin(GizmoPreUpdateBeginHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_add_PreUpdateBegin_Public_add_Void_GizmoPreUpdateBeginHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x000371F0 File Offset: 0x000353F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59998, XrefRangeEnd = 60002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_PreUpdateBegin(GizmoPreUpdateBeginHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_remove_PreUpdateBegin_Public_rem_Void_GizmoPreUpdateBeginHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x00037234 File Offset: 0x00035434
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60002, XrefRangeEnd = 60006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_PostUpdateEnd(GizmoPostUpdateEndHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_add_PostUpdateEnd_Public_add_Void_GizmoPostUpdateEndHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x00037278 File Offset: 0x00035478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60006, XrefRangeEnd = 60010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_PostUpdateEnd(GizmoPostUpdateEndHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_remove_PostUpdateEnd_Public_rem_Void_GizmoPostUpdateEndHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x000372BC File Offset: 0x000354BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 60014, RefRangeEnd = 60016, XrefRangeStart = 60010, XrefRangeEnd = 60014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_PreHoverEnter(GizmoPreHoverEnterHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_add_PreHoverEnter_Public_add_Void_GizmoPreHoverEnterHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x00037300 File Offset: 0x00035500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60016, XrefRangeEnd = 60020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_PreHoverEnter(GizmoPreHoverEnterHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_remove_PreHoverEnter_Public_rem_Void_GizmoPreHoverEnterHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x00037344 File Offset: 0x00035544
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60020, XrefRangeEnd = 60024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_PostHoverEnter(GizmoPostHoverEnterHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_add_PostHoverEnter_Public_add_Void_GizmoPostHoverEnterHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x00037388 File Offset: 0x00035588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60024, XrefRangeEnd = 60028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_PostHoverEnter(GizmoPostHoverEnterHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_remove_PostHoverEnter_Public_rem_Void_GizmoPostHoverEnterHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x000373CC File Offset: 0x000355CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 60032, RefRangeEnd = 60034, XrefRangeStart = 60028, XrefRangeEnd = 60032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_PreHoverExit(GizmoPreHoverExitHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_add_PreHoverExit_Public_add_Void_GizmoPreHoverExitHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x00037410 File Offset: 0x00035610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60034, XrefRangeEnd = 60038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_PreHoverExit(GizmoPreHoverExitHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_remove_PreHoverExit_Public_rem_Void_GizmoPreHoverExitHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x00037454 File Offset: 0x00035654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60038, XrefRangeEnd = 60042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_PostHoverExit(GizmoPostHoverExitHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_add_PostHoverExit_Public_add_Void_GizmoPostHoverExitHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x00037498 File Offset: 0x00035698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60042, XrefRangeEnd = 60046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_PostHoverExit(GizmoPostHoverExitHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_remove_PostHoverExit_Public_rem_Void_GizmoPostHoverExitHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x000374DC File Offset: 0x000356DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60046, XrefRangeEnd = 60050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_PreDragBegin(GizmoPreDragBeginHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_add_PreDragBegin_Public_add_Void_GizmoPreDragBeginHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x00037520 File Offset: 0x00035720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60050, XrefRangeEnd = 60054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_PreDragBegin(GizmoPreDragBeginHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_remove_PreDragBegin_Public_rem_Void_GizmoPreDragBeginHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x00037564 File Offset: 0x00035764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60054, XrefRangeEnd = 60058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_PostDragBegin(GizmoPostDragBeginHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_add_PostDragBegin_Public_add_Void_GizmoPostDragBeginHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x000375A8 File Offset: 0x000357A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60058, XrefRangeEnd = 60062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_PostDragBegin(GizmoPostDragBeginHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_remove_PostDragBegin_Public_rem_Void_GizmoPostDragBeginHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x000375EC File Offset: 0x000357EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60062, XrefRangeEnd = 60066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_PreDragEnd(GizmoPreDragEndHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_add_PreDragEnd_Public_add_Void_GizmoPreDragEndHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x00037630 File Offset: 0x00035830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60066, XrefRangeEnd = 60070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_PreDragEnd(GizmoPreDragEndHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_remove_PreDragEnd_Public_rem_Void_GizmoPreDragEndHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x00037674 File Offset: 0x00035874
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 60074, RefRangeEnd = 60077, XrefRangeStart = 60070, XrefRangeEnd = 60074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_PostDragEnd(GizmoPostDragEndHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_add_PostDragEnd_Public_add_Void_GizmoPostDragEndHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x000376B8 File Offset: 0x000358B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60077, XrefRangeEnd = 60081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_PostDragEnd(GizmoPostDragEndHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_remove_PostDragEnd_Public_rem_Void_GizmoPostDragEndHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x000376FC File Offset: 0x000358FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 60085, RefRangeEnd = 60087, XrefRangeStart = 60081, XrefRangeEnd = 60085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_PreDragUpdate(GizmoPreDragUpdateHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_add_PreDragUpdate_Public_add_Void_GizmoPreDragUpdateHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x00037740 File Offset: 0x00035940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60087, XrefRangeEnd = 60091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_PreDragUpdate(GizmoPreDragUpdateHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_remove_PreDragUpdate_Public_rem_Void_GizmoPreDragUpdateHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x00037784 File Offset: 0x00035984
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60091, XrefRangeEnd = 60095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_PostDragUpdate(GizmoPostDragUpdateHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_add_PostDragUpdate_Public_add_Void_GizmoPostDragUpdateHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x000377C8 File Offset: 0x000359C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60095, XrefRangeEnd = 60099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_PostDragUpdate(GizmoPostDragUpdateHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_remove_PostDragUpdate_Public_rem_Void_GizmoPostDragUpdateHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x0003780C File Offset: 0x00035A0C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 60103, RefRangeEnd = 60108, XrefRangeStart = 60099, XrefRangeEnd = 60103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_PreHandlePicked(GizmoPreHandlePickedHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_add_PreHandlePicked_Public_add_Void_GizmoPreHandlePickedHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x00037850 File Offset: 0x00035A50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60108, XrefRangeEnd = 60112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_PreHandlePicked(GizmoPreHandlePickedHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_remove_PreHandlePicked_Public_rem_Void_GizmoPreHandlePickedHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x00037894 File Offset: 0x00035A94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60112, XrefRangeEnd = 60116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_PostHandlePicked(GizmoPostHandlePickedHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_add_PostHandlePicked_Public_add_Void_GizmoPostHandlePickedHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x000378D8 File Offset: 0x00035AD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60116, XrefRangeEnd = 60120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_PostHandlePicked(GizmoPostHandlePickedHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_remove_PostHandlePicked_Public_rem_Void_GizmoPostHandlePickedHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x0003791C File Offset: 0x00035B1C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 60124, RefRangeEnd = 60128, XrefRangeStart = 60120, XrefRangeEnd = 60124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_PreDragBeginAttempt(GizmoPreDragBeginAttemptHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_add_PreDragBeginAttempt_Public_add_Void_GizmoPreDragBeginAttemptHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x00037960 File Offset: 0x00035B60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60128, XrefRangeEnd = 60132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_PreDragBeginAttempt(GizmoPreDragBeginAttemptHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_remove_PreDragBeginAttempt_Public_rem_Void_GizmoPreDragBeginAttemptHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x000379A4 File Offset: 0x00035BA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60132, XrefRangeEnd = 60136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_PostDragBeginAttempt(GizmoPostDragBeginAttemptHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_add_PostDragBeginAttempt_Public_add_Void_GizmoPostDragBeginAttemptHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x000379E8 File Offset: 0x00035BE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60136, XrefRangeEnd = 60140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_PostDragBeginAttempt(GizmoPostDragBeginAttemptHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_remove_PostDragBeginAttempt_Public_rem_Void_GizmoPostDragBeginAttemptHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x00037A2C File Offset: 0x00035C2C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 60186, RefRangeEnd = 60198, XrefRangeStart = 60140, XrefRangeEnd = 60186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Gizmo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Gizmo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x00037A68 File Offset: 0x00035C68
		[CallerCount(38)]
		[CachedScanResults(RefRangeStart = 60214, RefRangeEnd = 60252, XrefRangeStart = 60198, XrefRangeEnd = 60214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Camera GetWorkCamera()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_GetWorkCamera_Public_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr3) : null;
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x00037AA8 File Offset: 0x00035CA8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 60307, RefRangeEnd = 60313, XrefRangeStart = 60252, XrefRangeEnd = 60307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GizmoHandle CreateHandle(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_CreateHandle_Public_GizmoHandle_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoHandle>(intPtr3) : null;
			}
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x00037AF4 File Offset: 0x00035CF4
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 60355, RefRangeEnd = 60370, XrefRangeStart = 60313, XrefRangeEnd = 60355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEnabled(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref enabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_SetEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x00037B34 File Offset: 0x00035D34
		[CallerCount(0)]
		public unsafe BehaviourType AddBehaviour<BehaviourType>() where BehaviourType : class, new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.MethodInfoStoreGeneric_AddBehaviour_Public_BehaviourType_0<BehaviourType>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<BehaviourType>(intPtr, false, true);
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x00037B70 File Offset: 0x00035D70
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 60463, RefRangeEnd = 60473, XrefRangeStart = 60370, XrefRangeEnd = 60463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AddBehaviour(IGizmoBehaviour behaviour)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(behaviour);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_AddBehaviour_Public_Boolean_IGizmoBehaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x00037BC0 File Offset: 0x00035DC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60473, XrefRangeEnd = 60482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool RemoveBehaviour(IGizmoBehaviour behaviour)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(behaviour);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_RemoveBehaviour_Public_Boolean_IGizmoBehaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x00037C10 File Offset: 0x00035E10
		[CallerCount(0)]
		public unsafe List<BehaviourType> GetBehavioursOfType<BehaviourType>() where BehaviourType : class
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.MethodInfoStoreGeneric_GetBehavioursOfType_Public_List_1_BehaviourType_0<BehaviourType>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<BehaviourType>>(intPtr3) : null;
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x00037C50 File Offset: 0x00035E50
		[CallerCount(0)]
		public unsafe BehaviourType GetFirstBehaviourOfType<BehaviourType>() where BehaviourType : class
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.MethodInfoStoreGeneric_GetFirstBehaviourOfType_Public_BehaviourType_0<BehaviourType>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<BehaviourType>(intPtr, false, true);
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x00037C8C File Offset: 0x00035E8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 60484, RefRangeEnd = 60485, XrefRangeStart = 60482, XrefRangeEnd = 60484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IGizmoBehaviour GetFirstBehaviourOfType(Type behaviourType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(behaviourType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_GetFirstBehaviourOfType_Public_IGizmoBehaviour_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IGizmoBehaviour>(intPtr3) : null;
			}
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x00037CDC File Offset: 0x00035EDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60485, XrefRangeEnd = 60486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<GizmoHandleHoverData> GetAllHandlesHoverData(Ray hoverRay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hoverRay);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_GetAllHandlesHoverData_Public_List_1_GizmoHandleHoverData_Ray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<GizmoHandleHoverData>>(intPtr3) : null;
			}
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x00037D2C File Offset: 0x00035F2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60486, XrefRangeEnd = 60490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IGizmoHandle GetHandleById_SystemCall(int handleId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handleId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_GetHandleById_SystemCall_Public_IGizmoHandle_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IGizmoHandle>(intPtr3) : null;
			}
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x00037D78 File Offset: 0x00035F78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 60511, RefRangeEnd = 60512, XrefRangeStart = 60490, XrefRangeEnd = 60511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGUI_SystemCall()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_OnGUI_SystemCall_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x00037DAC File Offset: 0x00035FAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 60533, RefRangeEnd = 60534, XrefRangeStart = 60512, XrefRangeEnd = 60533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnUpdateBegin_SystemCall()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_OnUpdateBegin_SystemCall_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x00037DE0 File Offset: 0x00035FE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 60555, RefRangeEnd = 60556, XrefRangeStart = 60534, XrefRangeEnd = 60555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnUpdateEnd_SystemCall()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_OnUpdateEnd_SystemCall_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x00037E14 File Offset: 0x00036014
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 60579, RefRangeEnd = 60580, XrefRangeStart = 60556, XrefRangeEnd = 60579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateHandleHoverInfo_SystemCall(GizmoHoverInfo hoverInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hoverInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_UpdateHandleHoverInfo_SystemCall_Public_Void_GizmoHoverInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x00037E58 File Offset: 0x00036058
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 60607, RefRangeEnd = 60609, XrefRangeStart = 60580, XrefRangeEnd = 60607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Render_SystemCall(Camera camera, Il2CppStructArray<Plane> worldFrustumPlanes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(worldFrustumPlanes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_Render_SystemCall_Public_Void_Camera_Il2CppStructArray_1_Plane_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x00037EAC File Offset: 0x000360AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60609, XrefRangeEnd = 60626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleInputDeviceEvents_SystemCall()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_HandleInputDeviceEvents_SystemCall_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x00037EE0 File Offset: 0x000360E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 60655, RefRangeEnd = 60657, XrefRangeStart = 60626, XrefRangeEnd = 60655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnInputDevicePickButtonDown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_OnInputDevicePickButtonDown_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x00037F14 File Offset: 0x00036114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60657, XrefRangeEnd = 60658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnInputDevicePickButtonUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_OnInputDevicePickButtonUp_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x00037F48 File Offset: 0x00036148
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 60684, RefRangeEnd = 60688, XrefRangeStart = 60658, XrefRangeEnd = 60684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndDragSession()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_EndDragSession_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x00037F7C File Offset: 0x0003617C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 60733, RefRangeEnd = 60735, XrefRangeStart = 60688, XrefRangeEnd = 60733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnInputDeviceMoved()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_OnInputDeviceMoved_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x00037FB0 File Offset: 0x000361B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 60809, RefRangeEnd = 60810, XrefRangeStart = 60735, XrefRangeEnd = 60809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryActivateDragSession()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Gizmo.NativeMethodInfoPtr_TryActivateDragSession_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x00003EB7 File Offset: 0x000020B7
		public Gizmo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x060005D2 RID: 1490 RVA: 0x00037FE4 File Offset: 0x000361E4
		// (set) Token: 0x060005D3 RID: 1491 RVA: 0x00003EC0 File Offset: 0x000020C0
		public unsafe GizmoPostEnabledHandler PostEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gizmo.NativeFieldInfoPtr_PostEnabled);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPostEnabledHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gizmo.NativeFieldInfoPtr_PostEnabled), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x060005D4 RID: 1492 RVA: 0x00038014 File Offset: 0x00036214
		// (set) Token: 0x060005D5 RID: 1493 RVA: 0x00003EDF File Offset: 0x000020DF
		public unsafe GizmoPostDisabledHandler PostDisabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gizmo.NativeFieldInfoPtr_PostDisabled);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPostDisabledHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gizmo.NativeFieldInfoPtr_PostDisabled), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x060005D6 RID: 1494 RVA: 0x00038044 File Offset: 0x00036244
		// (set) Token: 0x060005D7 RID: 1495 RVA: 0x00003EFE File Offset: 0x000020FE
		public unsafe GizmoPreUpdateBeginHandler PreUpdateBegin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gizmo.NativeFieldInfoPtr_PreUpdateBegin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPreUpdateBeginHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gizmo.NativeFieldInfoPtr_PreUpdateBegin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x060005D8 RID: 1496 RVA: 0x00038074 File Offset: 0x00036274
		// (set) Token: 0x060005D9 RID: 1497 RVA: 0x00003F1D File Offset: 0x0000211D
		public unsafe GizmoPostUpdateEndHandler PostUpdateEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gizmo.NativeFieldInfoPtr_PostUpdateEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPostUpdateEndHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gizmo.NativeFieldInfoPtr_PostUpdateEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x060005DA RID: 1498 RVA: 0x000380A4 File Offset: 0x000362A4
		// (set) Token: 0x060005DB RID: 1499 RVA: 0x00003F3C File Offset: 0x0000213C
		public unsafe GizmoPreHoverEnterHandler PreHoverEnter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gizmo.NativeFieldInfoPtr_PreHoverEnter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPreHoverEnterHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gizmo.NativeFieldInfoPtr_PreHoverEnter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x060005DC RID: 1500 RVA: 0x000380D4 File Offset: 0x000362D4
		// (set) Token: 0x060005DD RID: 1501 RVA: 0x00003F5B File Offset: 0x0000215B
		public unsafe GizmoPostHoverEnterHandler PostHoverEnter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gizmo.NativeFieldInfoPtr_PostHoverEnter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPostHoverEnterHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gizmo.NativeFieldInfoPtr_PostHoverEnter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x060005DE RID: 1502 RVA: 0x00038104 File Offset: 0x00036304
		// (set) Token: 0x060005DF RID: 1503 RVA: 0x00003F7A File Offset: 0x0000217A
		public unsafe GizmoPreHoverExitHandler PreHoverExit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gizmo.NativeFieldInfoPtr_PreHoverExit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPreHoverExitHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gizmo.NativeFieldInfoPtr_PreHoverExit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x060005E0 RID: 1504 RVA: 0x00038134 File Offset: 0x00036334
		// (set) Token: 0x060005E1 RID: 1505 RVA: 0x00003F99 File Offset: 0x00002199
		public unsafe GizmoPostHoverExitHandler PostHoverExit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gizmo.NativeFieldInfoPtr_PostHoverExit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPostHoverExitHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gizmo.NativeFieldInfoPtr_PostHoverExit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x060005E2 RID: 1506 RVA: 0x00038164 File Offset: 0x00036364
		// (set) Token: 0x060005E3 RID: 1507 RVA: 0x00003FB8 File Offset: 0x000021B8
		public unsafe GizmoPreDragBeginHandler PreDragBegin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gizmo.NativeFieldInfoPtr_PreDragBegin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPreDragBeginHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gizmo.NativeFieldInfoPtr_PreDragBegin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x060005E4 RID: 1508 RVA: 0x00038194 File Offset: 0x00036394
		// (set) Token: 0x060005E5 RID: 1509 RVA: 0x00003FD7 File Offset: 0x000021D7
		public unsafe GizmoPostDragBeginHandler PostDragBegin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gizmo.NativeFieldInfoPtr_PostDragBegin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPostDragBeginHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gizmo.NativeFieldInfoPtr_PostDragBegin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x060005E6 RID: 1510 RVA: 0x000381C4 File Offset: 0x000363C4
		// (set) Token: 0x060005E7 RID: 1511 RVA: 0x00003FF6 File Offset: 0x000021F6
		public unsafe GizmoPreDragEndHandler PreDragEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gizmo.NativeFieldInfoPtr_PreDragEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPreDragEndHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gizmo.NativeFieldInfoPtr_PreDragEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x060005E8 RID: 1512 RVA: 0x000381F4 File Offset: 0x000363F4
		// (set) Token: 0x060005E9 RID: 1513 RVA: 0x00004015 File Offset: 0x00002215
		public unsafe GizmoPostDragEndHandler PostDragEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gizmo.NativeFieldInfoPtr_PostDragEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPostDragEndHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gizmo.NativeFieldInfoPtr_PostDragEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x060005EA RID: 1514 RVA: 0x00038224 File Offset: 0x00036424
		// (set) Token: 0x060005EB RID: 1515 RVA: 0x00004034 File Offset: 0x00002234
		public unsafe GizmoPreDragUpdateHandler PreDragUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gizmo.NativeFieldInfoPtr_PreDragUpdate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPreDragUpdateHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gizmo.NativeFieldInfoPtr_PreDragUpdate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x060005EC RID: 1516 RVA: 0x00038254 File Offset: 0x00036454
		// (set) Token: 0x060005ED RID: 1517 RVA: 0x00004053 File Offset: 0x00002253
		public unsafe GizmoPostDragUpdateHandler PostDragUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gizmo.NativeFieldInfoPtr_PostDragUpdate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPostDragUpdateHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gizmo.NativeFieldInfoPtr_PostDragUpdate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x060005EE RID: 1518 RVA: 0x00038284 File Offset: 0x00036484
		// (set) Token: 0x060005EF RID: 1519 RVA: 0x00004072 File Offset: 0x00002272
		public unsafe GizmoPreHandlePickedHandler PreHandlePicked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gizmo.NativeFieldInfoPtr_PreHandlePicked);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPreHandlePickedHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gizmo.NativeFieldInfoPtr_PreHandlePicked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x060005F0 RID: 1520 RVA: 0x000382B4 File Offset: 0x000364B4
		// (set) Token: 0x060005F1 RID: 1521 RVA: 0x00004091 File Offset: 0x00002291
		public unsafe GizmoPostHandlePickedHandler PostHandlePicked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gizmo.NativeFieldInfoPtr_PostHandlePicked);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPostHandlePickedHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gizmo.NativeFieldInfoPtr_PostHandlePicked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x060005F2 RID: 1522 RVA: 0x000382E4 File Offset: 0x000364E4
		// (set) Token: 0x060005F3 RID: 1523 RVA: 0x000040B0 File Offset: 0x000022B0
		public unsafe GizmoPreDragBeginAttemptHandler PreDragBeginAttempt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gizmo.NativeFieldInfoPtr_PreDragBeginAttempt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPreDragBeginAttemptHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gizmo.NativeFieldInfoPtr_PreDragBeginAttempt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x060005F4 RID: 1524 RVA: 0x00038314 File Offset: 0x00036514
		// (set) Token: 0x060005F5 RID: 1525 RVA: 0x000040CF File Offset: 0x000022CF
		public unsafe GizmoPostDragBeginAttemptHandler PostDragBeginAttempt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gizmo.NativeFieldInfoPtr_PostDragBeginAttempt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoPostDragBeginAttemptHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gizmo.NativeFieldInfoPtr_PostDragBeginAttempt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x060005F6 RID: 1526 RVA: 0x00038344 File Offset: 0x00036544
		// (set) Token: 0x060005F7 RID: 1527 RVA: 0x000040EE File Offset: 0x000022EE
		public unsafe bool _isEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gizmo.NativeFieldInfoPtr__isEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gizmo.NativeFieldInfoPtr__isEnabled)) = value;
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x060005F8 RID: 1528 RVA: 0x0003836C File Offset: 0x0003656C
		// (set) Token: 0x060005F9 RID: 1529 RVA: 0x00004109 File Offset: 0x00002309
		public unsafe GizmoHandleCollection _handles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gizmo.NativeFieldInfoPtr__handles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoHandleCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gizmo.NativeFieldInfoPtr__handles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x060005FA RID: 1530 RVA: 0x0003839C File Offset: 0x0003659C
		// (set) Token: 0x060005FB RID: 1531 RVA: 0x00004128 File Offset: 0x00002328
		public unsafe GizmoBehaviourCollection _behaviours
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gizmo.NativeFieldInfoPtr__behaviours);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoBehaviourCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gizmo.NativeFieldInfoPtr__behaviours), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x060005FC RID: 1532 RVA: 0x000383CC File Offset: 0x000365CC
		// (set) Token: 0x060005FD RID: 1533 RVA: 0x00004147 File Offset: 0x00002347
		public unsafe GizmoHoverInfo _hoverInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gizmo.NativeFieldInfoPtr__hoverInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoHoverInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gizmo.NativeFieldInfoPtr__hoverInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x060005FE RID: 1534 RVA: 0x000383FC File Offset: 0x000365FC
		// (set) Token: 0x060005FF RID: 1535 RVA: 0x00004166 File Offset: 0x00002366
		public unsafe GizmoDragInfo _dragInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gizmo.NativeFieldInfoPtr__dragInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoDragInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gizmo.NativeFieldInfoPtr__dragInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000600 RID: 1536 RVA: 0x0003842C File Offset: 0x0003662C
		// (set) Token: 0x06000601 RID: 1537 RVA: 0x00004185 File Offset: 0x00002385
		public unsafe IGizmoHandle _hoveredHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gizmo.NativeFieldInfoPtr__hoveredHandle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGizmoHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gizmo.NativeFieldInfoPtr__hoveredHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06000602 RID: 1538 RVA: 0x0003845C File Offset: 0x0003665C
		// (set) Token: 0x06000603 RID: 1539 RVA: 0x000041A4 File Offset: 0x000023A4
		public unsafe Priority _genericHoverPriority
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gizmo.NativeFieldInfoPtr__genericHoverPriority);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Priority>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gizmo.NativeFieldInfoPtr__genericHoverPriority), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x06000604 RID: 1540 RVA: 0x0003848C File Offset: 0x0003668C
		// (set) Token: 0x06000605 RID: 1541 RVA: 0x000041C3 File Offset: 0x000023C3
		public unsafe Priority _hoverPriority3D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gizmo.NativeFieldInfoPtr__hoverPriority3D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Priority>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gizmo.NativeFieldInfoPtr__hoverPriority3D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x06000606 RID: 1542 RVA: 0x000384BC File Offset: 0x000366BC
		// (set) Token: 0x06000607 RID: 1543 RVA: 0x000041E2 File Offset: 0x000023E2
		public unsafe Priority _hoverPriority2D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gizmo.NativeFieldInfoPtr__hoverPriority2D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Priority>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gizmo.NativeFieldInfoPtr__hoverPriority2D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06000608 RID: 1544 RVA: 0x000384EC File Offset: 0x000366EC
		// (set) Token: 0x06000609 RID: 1545 RVA: 0x00004201 File Offset: 0x00002401
		public unsafe IGizmoDragSession _activeDragSession
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gizmo.NativeFieldInfoPtr__activeDragSession);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGizmoDragSession>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gizmo.NativeFieldInfoPtr__activeDragSession), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x0600060A RID: 1546 RVA: 0x0003851C File Offset: 0x0003671C
		// (set) Token: 0x0600060B RID: 1547 RVA: 0x00004220 File Offset: 0x00002420
		public unsafe GizmoTransform _transform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gizmo.NativeFieldInfoPtr__transform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gizmo.NativeFieldInfoPtr__transform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x0600060C RID: 1548 RVA: 0x0003854C File Offset: 0x0003674C
		// (set) Token: 0x0600060D RID: 1549 RVA: 0x0000423F File Offset: 0x0000243F
		public unsafe MoveGizmo _moveGizmo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gizmo.NativeFieldInfoPtr__moveGizmo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MoveGizmo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gizmo.NativeFieldInfoPtr__moveGizmo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x0600060E RID: 1550 RVA: 0x0003857C File Offset: 0x0003677C
		// (set) Token: 0x0600060F RID: 1551 RVA: 0x0000425E File Offset: 0x0000245E
		public unsafe RotationGizmo _rotationGizmo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gizmo.NativeFieldInfoPtr__rotationGizmo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RotationGizmo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gizmo.NativeFieldInfoPtr__rotationGizmo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000610 RID: 1552 RVA: 0x000385AC File Offset: 0x000367AC
		// (set) Token: 0x06000611 RID: 1553 RVA: 0x0000427D File Offset: 0x0000247D
		public unsafe ScaleGizmo _scaleGizmo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gizmo.NativeFieldInfoPtr__scaleGizmo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScaleGizmo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gizmo.NativeFieldInfoPtr__scaleGizmo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06000612 RID: 1554 RVA: 0x000385DC File Offset: 0x000367DC
		// (set) Token: 0x06000613 RID: 1555 RVA: 0x0000429C File Offset: 0x0000249C
		public unsafe UniversalGizmo _universalGizmo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gizmo.NativeFieldInfoPtr__universalGizmo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UniversalGizmo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gizmo.NativeFieldInfoPtr__universalGizmo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06000614 RID: 1556 RVA: 0x0003860C File Offset: 0x0003680C
		// (set) Token: 0x06000615 RID: 1557 RVA: 0x000042BB File Offset: 0x000024BB
		public unsafe ObjectTransformGizmo _objectTransformGizmo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gizmo.NativeFieldInfoPtr__objectTransformGizmo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectTransformGizmo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gizmo.NativeFieldInfoPtr__objectTransformGizmo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000616 RID: 1558 RVA: 0x0003863C File Offset: 0x0003683C
		// (set) Token: 0x06000617 RID: 1559 RVA: 0x000042DA File Offset: 0x000024DA
		public unsafe BoxGizmo _boxGizmo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gizmo.NativeFieldInfoPtr__boxGizmo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxGizmo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gizmo.NativeFieldInfoPtr__boxGizmo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000618 RID: 1560 RVA: 0x0003866C File Offset: 0x0003686C
		// (set) Token: 0x06000619 RID: 1561 RVA: 0x000042F9 File Offset: 0x000024F9
		public unsafe ObjectExtrudeGizmo _objectExtrudeGizmo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gizmo.NativeFieldInfoPtr__objectExtrudeGizmo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectExtrudeGizmo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gizmo.NativeFieldInfoPtr__objectExtrudeGizmo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x0600061A RID: 1562 RVA: 0x0003869C File Offset: 0x0003689C
		// (set) Token: 0x0600061B RID: 1563 RVA: 0x00004318 File Offset: 0x00002518
		public unsafe SceneGizmo _sceneGizmo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gizmo.NativeFieldInfoPtr__sceneGizmo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneGizmo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Gizmo.NativeFieldInfoPtr__sceneGizmo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400041F RID: 1055
		private static readonly IntPtr NativeFieldInfoPtr_PostEnabled;

		// Token: 0x04000420 RID: 1056
		private static readonly IntPtr NativeFieldInfoPtr_PostDisabled;

		// Token: 0x04000421 RID: 1057
		private static readonly IntPtr NativeFieldInfoPtr_PreUpdateBegin;

		// Token: 0x04000422 RID: 1058
		private static readonly IntPtr NativeFieldInfoPtr_PostUpdateEnd;

		// Token: 0x04000423 RID: 1059
		private static readonly IntPtr NativeFieldInfoPtr_PreHoverEnter;

		// Token: 0x04000424 RID: 1060
		private static readonly IntPtr NativeFieldInfoPtr_PostHoverEnter;

		// Token: 0x04000425 RID: 1061
		private static readonly IntPtr NativeFieldInfoPtr_PreHoverExit;

		// Token: 0x04000426 RID: 1062
		private static readonly IntPtr NativeFieldInfoPtr_PostHoverExit;

		// Token: 0x04000427 RID: 1063
		private static readonly IntPtr NativeFieldInfoPtr_PreDragBegin;

		// Token: 0x04000428 RID: 1064
		private static readonly IntPtr NativeFieldInfoPtr_PostDragBegin;

		// Token: 0x04000429 RID: 1065
		private static readonly IntPtr NativeFieldInfoPtr_PreDragEnd;

		// Token: 0x0400042A RID: 1066
		private static readonly IntPtr NativeFieldInfoPtr_PostDragEnd;

		// Token: 0x0400042B RID: 1067
		private static readonly IntPtr NativeFieldInfoPtr_PreDragUpdate;

		// Token: 0x0400042C RID: 1068
		private static readonly IntPtr NativeFieldInfoPtr_PostDragUpdate;

		// Token: 0x0400042D RID: 1069
		private static readonly IntPtr NativeFieldInfoPtr_PreHandlePicked;

		// Token: 0x0400042E RID: 1070
		private static readonly IntPtr NativeFieldInfoPtr_PostHandlePicked;

		// Token: 0x0400042F RID: 1071
		private static readonly IntPtr NativeFieldInfoPtr_PreDragBeginAttempt;

		// Token: 0x04000430 RID: 1072
		private static readonly IntPtr NativeFieldInfoPtr_PostDragBeginAttempt;

		// Token: 0x04000431 RID: 1073
		private static readonly IntPtr NativeFieldInfoPtr__isEnabled;

		// Token: 0x04000432 RID: 1074
		private static readonly IntPtr NativeFieldInfoPtr__handles;

		// Token: 0x04000433 RID: 1075
		private static readonly IntPtr NativeFieldInfoPtr__behaviours;

		// Token: 0x04000434 RID: 1076
		private static readonly IntPtr NativeFieldInfoPtr__hoverInfo;

		// Token: 0x04000435 RID: 1077
		private static readonly IntPtr NativeFieldInfoPtr__dragInfo;

		// Token: 0x04000436 RID: 1078
		private static readonly IntPtr NativeFieldInfoPtr__hoveredHandle;

		// Token: 0x04000437 RID: 1079
		private static readonly IntPtr NativeFieldInfoPtr__genericHoverPriority;

		// Token: 0x04000438 RID: 1080
		private static readonly IntPtr NativeFieldInfoPtr__hoverPriority3D;

		// Token: 0x04000439 RID: 1081
		private static readonly IntPtr NativeFieldInfoPtr__hoverPriority2D;

		// Token: 0x0400043A RID: 1082
		private static readonly IntPtr NativeFieldInfoPtr__activeDragSession;

		// Token: 0x0400043B RID: 1083
		private static readonly IntPtr NativeFieldInfoPtr__transform;

		// Token: 0x0400043C RID: 1084
		private static readonly IntPtr NativeFieldInfoPtr__moveGizmo;

		// Token: 0x0400043D RID: 1085
		private static readonly IntPtr NativeFieldInfoPtr__rotationGizmo;

		// Token: 0x0400043E RID: 1086
		private static readonly IntPtr NativeFieldInfoPtr__scaleGizmo;

		// Token: 0x0400043F RID: 1087
		private static readonly IntPtr NativeFieldInfoPtr__universalGizmo;

		// Token: 0x04000440 RID: 1088
		private static readonly IntPtr NativeFieldInfoPtr__objectTransformGizmo;

		// Token: 0x04000441 RID: 1089
		private static readonly IntPtr NativeFieldInfoPtr__boxGizmo;

		// Token: 0x04000442 RID: 1090
		private static readonly IntPtr NativeFieldInfoPtr__objectExtrudeGizmo;

		// Token: 0x04000443 RID: 1091
		private static readonly IntPtr NativeFieldInfoPtr__sceneGizmo;

		// Token: 0x04000444 RID: 1092
		private static readonly IntPtr NativeMethodInfoPtr_get_InputDeviceDragButtonIndex_Public_Static_get_Int32_0;

		// Token: 0x04000445 RID: 1093
		private static readonly IntPtr NativeMethodInfoPtr_get_NumHandles_Public_get_Int32_0;

		// Token: 0x04000446 RID: 1094
		private static readonly IntPtr NativeMethodInfoPtr_get_FocusCamera_Public_get_Camera_0;

		// Token: 0x04000447 RID: 1095
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEnabled_Public_get_Boolean_0;

		// Token: 0x04000448 RID: 1096
		private static readonly IntPtr NativeMethodInfoPtr_get_GenericHoverPriority_Public_get_Priority_0;

		// Token: 0x04000449 RID: 1097
		private static readonly IntPtr NativeMethodInfoPtr_get_HoverPriority3D_Public_get_Priority_0;

		// Token: 0x0400044A RID: 1098
		private static readonly IntPtr NativeMethodInfoPtr_get_HoverPriority2D_Public_get_Priority_0;

		// Token: 0x0400044B RID: 1099
		private static readonly IntPtr NativeMethodInfoPtr_get_Transform_Public_get_GizmoTransform_0;

		// Token: 0x0400044C RID: 1100
		private static readonly IntPtr NativeMethodInfoPtr_get_HoverInfo_Public_get_GizmoHoverInfo_0;

		// Token: 0x0400044D RID: 1101
		private static readonly IntPtr NativeMethodInfoPtr_get_IsHovered_Public_get_Boolean_0;

		// Token: 0x0400044E RID: 1102
		private static readonly IntPtr NativeMethodInfoPtr_get_HoverHandleId_Public_get_Int32_0;

		// Token: 0x0400044F RID: 1103
		private static readonly IntPtr NativeMethodInfoPtr_get_HoverHandleDimension_Public_get_GizmoDimension_0;

		// Token: 0x04000450 RID: 1104
		private static readonly IntPtr NativeMethodInfoPtr_get_HoverPoint_Public_get_Vector3_0;

		// Token: 0x04000451 RID: 1105
		private static readonly IntPtr NativeMethodInfoPtr_get_DragInfo_Public_get_GizmoDragInfo_0;

		// Token: 0x04000452 RID: 1106
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDragged_Public_get_Boolean_0;

		// Token: 0x04000453 RID: 1107
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveDragChannel_Public_get_GizmoDragChannel_0;

		// Token: 0x04000454 RID: 1108
		private static readonly IntPtr NativeMethodInfoPtr_get_DragHandleId_Public_get_Int32_0;

		// Token: 0x04000455 RID: 1109
		private static readonly IntPtr NativeMethodInfoPtr_get_DragBeginPoint_Public_get_Vector3_0;

		// Token: 0x04000456 RID: 1110
		private static readonly IntPtr NativeMethodInfoPtr_get_DragHandleDimension_Public_get_GizmoDimension_0;

		// Token: 0x04000457 RID: 1111
		private static readonly IntPtr NativeMethodInfoPtr_get_TotalDragOffset_Public_get_Vector3_0;

		// Token: 0x04000458 RID: 1112
		private static readonly IntPtr NativeMethodInfoPtr_get_TotalDragRotation_Public_get_Quaternion_0;

		// Token: 0x04000459 RID: 1113
		private static readonly IntPtr NativeMethodInfoPtr_get_TotalDragScale_Public_get_Vector3_0;

		// Token: 0x0400045A RID: 1114
		private static readonly IntPtr NativeMethodInfoPtr_get_RelativeDragOffset_Public_get_Vector3_0;

		// Token: 0x0400045B RID: 1115
		private static readonly IntPtr NativeMethodInfoPtr_get_RelativeDragRotation_Public_get_Quaternion_0;

		// Token: 0x0400045C RID: 1116
		private static readonly IntPtr NativeMethodInfoPtr_get_RelativeDragScale_Public_get_Vector3_0;

		// Token: 0x0400045D RID: 1117
		private static readonly IntPtr NativeMethodInfoPtr_get_MoveGizmo_Public_get_MoveGizmo_0;

		// Token: 0x0400045E RID: 1118
		private static readonly IntPtr NativeMethodInfoPtr_get_RotationGizmo_Public_get_RotationGizmo_0;

		// Token: 0x0400045F RID: 1119
		private static readonly IntPtr NativeMethodInfoPtr_get_ScaleGizmo_Public_get_ScaleGizmo_0;

		// Token: 0x04000460 RID: 1120
		private static readonly IntPtr NativeMethodInfoPtr_get_UniversalGizmo_Public_get_UniversalGizmo_0;

		// Token: 0x04000461 RID: 1121
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectTransformGizmo_Public_get_ObjectTransformGizmo_0;

		// Token: 0x04000462 RID: 1122
		private static readonly IntPtr NativeMethodInfoPtr_get_BoxGizmo_Public_get_BoxGizmo_0;

		// Token: 0x04000463 RID: 1123
		private static readonly IntPtr NativeMethodInfoPtr_get_ObjectExtrudeGizmo_Public_get_ObjectExtrudeGizmo_0;

		// Token: 0x04000464 RID: 1124
		private static readonly IntPtr NativeMethodInfoPtr_get_SceneGizmo_Public_get_SceneGizmo_0;

		// Token: 0x04000465 RID: 1125
		private static readonly IntPtr NativeMethodInfoPtr_add_PostEnabled_Public_add_Void_GizmoPostEnabledHandler_0;

		// Token: 0x04000466 RID: 1126
		private static readonly IntPtr NativeMethodInfoPtr_remove_PostEnabled_Public_rem_Void_GizmoPostEnabledHandler_0;

		// Token: 0x04000467 RID: 1127
		private static readonly IntPtr NativeMethodInfoPtr_add_PostDisabled_Public_add_Void_GizmoPostDisabledHandler_0;

		// Token: 0x04000468 RID: 1128
		private static readonly IntPtr NativeMethodInfoPtr_remove_PostDisabled_Public_rem_Void_GizmoPostDisabledHandler_0;

		// Token: 0x04000469 RID: 1129
		private static readonly IntPtr NativeMethodInfoPtr_add_PreUpdateBegin_Public_add_Void_GizmoPreUpdateBeginHandler_0;

		// Token: 0x0400046A RID: 1130
		private static readonly IntPtr NativeMethodInfoPtr_remove_PreUpdateBegin_Public_rem_Void_GizmoPreUpdateBeginHandler_0;

		// Token: 0x0400046B RID: 1131
		private static readonly IntPtr NativeMethodInfoPtr_add_PostUpdateEnd_Public_add_Void_GizmoPostUpdateEndHandler_0;

		// Token: 0x0400046C RID: 1132
		private static readonly IntPtr NativeMethodInfoPtr_remove_PostUpdateEnd_Public_rem_Void_GizmoPostUpdateEndHandler_0;

		// Token: 0x0400046D RID: 1133
		private static readonly IntPtr NativeMethodInfoPtr_add_PreHoverEnter_Public_add_Void_GizmoPreHoverEnterHandler_0;

		// Token: 0x0400046E RID: 1134
		private static readonly IntPtr NativeMethodInfoPtr_remove_PreHoverEnter_Public_rem_Void_GizmoPreHoverEnterHandler_0;

		// Token: 0x0400046F RID: 1135
		private static readonly IntPtr NativeMethodInfoPtr_add_PostHoverEnter_Public_add_Void_GizmoPostHoverEnterHandler_0;

		// Token: 0x04000470 RID: 1136
		private static readonly IntPtr NativeMethodInfoPtr_remove_PostHoverEnter_Public_rem_Void_GizmoPostHoverEnterHandler_0;

		// Token: 0x04000471 RID: 1137
		private static readonly IntPtr NativeMethodInfoPtr_add_PreHoverExit_Public_add_Void_GizmoPreHoverExitHandler_0;

		// Token: 0x04000472 RID: 1138
		private static readonly IntPtr NativeMethodInfoPtr_remove_PreHoverExit_Public_rem_Void_GizmoPreHoverExitHandler_0;

		// Token: 0x04000473 RID: 1139
		private static readonly IntPtr NativeMethodInfoPtr_add_PostHoverExit_Public_add_Void_GizmoPostHoverExitHandler_0;

		// Token: 0x04000474 RID: 1140
		private static readonly IntPtr NativeMethodInfoPtr_remove_PostHoverExit_Public_rem_Void_GizmoPostHoverExitHandler_0;

		// Token: 0x04000475 RID: 1141
		private static readonly IntPtr NativeMethodInfoPtr_add_PreDragBegin_Public_add_Void_GizmoPreDragBeginHandler_0;

		// Token: 0x04000476 RID: 1142
		private static readonly IntPtr NativeMethodInfoPtr_remove_PreDragBegin_Public_rem_Void_GizmoPreDragBeginHandler_0;

		// Token: 0x04000477 RID: 1143
		private static readonly IntPtr NativeMethodInfoPtr_add_PostDragBegin_Public_add_Void_GizmoPostDragBeginHandler_0;

		// Token: 0x04000478 RID: 1144
		private static readonly IntPtr NativeMethodInfoPtr_remove_PostDragBegin_Public_rem_Void_GizmoPostDragBeginHandler_0;

		// Token: 0x04000479 RID: 1145
		private static readonly IntPtr NativeMethodInfoPtr_add_PreDragEnd_Public_add_Void_GizmoPreDragEndHandler_0;

		// Token: 0x0400047A RID: 1146
		private static readonly IntPtr NativeMethodInfoPtr_remove_PreDragEnd_Public_rem_Void_GizmoPreDragEndHandler_0;

		// Token: 0x0400047B RID: 1147
		private static readonly IntPtr NativeMethodInfoPtr_add_PostDragEnd_Public_add_Void_GizmoPostDragEndHandler_0;

		// Token: 0x0400047C RID: 1148
		private static readonly IntPtr NativeMethodInfoPtr_remove_PostDragEnd_Public_rem_Void_GizmoPostDragEndHandler_0;

		// Token: 0x0400047D RID: 1149
		private static readonly IntPtr NativeMethodInfoPtr_add_PreDragUpdate_Public_add_Void_GizmoPreDragUpdateHandler_0;

		// Token: 0x0400047E RID: 1150
		private static readonly IntPtr NativeMethodInfoPtr_remove_PreDragUpdate_Public_rem_Void_GizmoPreDragUpdateHandler_0;

		// Token: 0x0400047F RID: 1151
		private static readonly IntPtr NativeMethodInfoPtr_add_PostDragUpdate_Public_add_Void_GizmoPostDragUpdateHandler_0;

		// Token: 0x04000480 RID: 1152
		private static readonly IntPtr NativeMethodInfoPtr_remove_PostDragUpdate_Public_rem_Void_GizmoPostDragUpdateHandler_0;

		// Token: 0x04000481 RID: 1153
		private static readonly IntPtr NativeMethodInfoPtr_add_PreHandlePicked_Public_add_Void_GizmoPreHandlePickedHandler_0;

		// Token: 0x04000482 RID: 1154
		private static readonly IntPtr NativeMethodInfoPtr_remove_PreHandlePicked_Public_rem_Void_GizmoPreHandlePickedHandler_0;

		// Token: 0x04000483 RID: 1155
		private static readonly IntPtr NativeMethodInfoPtr_add_PostHandlePicked_Public_add_Void_GizmoPostHandlePickedHandler_0;

		// Token: 0x04000484 RID: 1156
		private static readonly IntPtr NativeMethodInfoPtr_remove_PostHandlePicked_Public_rem_Void_GizmoPostHandlePickedHandler_0;

		// Token: 0x04000485 RID: 1157
		private static readonly IntPtr NativeMethodInfoPtr_add_PreDragBeginAttempt_Public_add_Void_GizmoPreDragBeginAttemptHandler_0;

		// Token: 0x04000486 RID: 1158
		private static readonly IntPtr NativeMethodInfoPtr_remove_PreDragBeginAttempt_Public_rem_Void_GizmoPreDragBeginAttemptHandler_0;

		// Token: 0x04000487 RID: 1159
		private static readonly IntPtr NativeMethodInfoPtr_add_PostDragBeginAttempt_Public_add_Void_GizmoPostDragBeginAttemptHandler_0;

		// Token: 0x04000488 RID: 1160
		private static readonly IntPtr NativeMethodInfoPtr_remove_PostDragBeginAttempt_Public_rem_Void_GizmoPostDragBeginAttemptHandler_0;

		// Token: 0x04000489 RID: 1161
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400048A RID: 1162
		private static readonly IntPtr NativeMethodInfoPtr_GetWorkCamera_Public_Camera_0;

		// Token: 0x0400048B RID: 1163
		private static readonly IntPtr NativeMethodInfoPtr_CreateHandle_Public_GizmoHandle_Int32_0;

		// Token: 0x0400048C RID: 1164
		private static readonly IntPtr NativeMethodInfoPtr_SetEnabled_Public_Void_Boolean_0;

		// Token: 0x0400048D RID: 1165
		private static readonly IntPtr NativeMethodInfoPtr_AddBehaviour_Public_BehaviourType_0;

		// Token: 0x0400048E RID: 1166
		private static readonly IntPtr NativeMethodInfoPtr_AddBehaviour_Public_Boolean_IGizmoBehaviour_0;

		// Token: 0x0400048F RID: 1167
		private static readonly IntPtr NativeMethodInfoPtr_RemoveBehaviour_Public_Boolean_IGizmoBehaviour_0;

		// Token: 0x04000490 RID: 1168
		private static readonly IntPtr NativeMethodInfoPtr_GetBehavioursOfType_Public_List_1_BehaviourType_0;

		// Token: 0x04000491 RID: 1169
		private static readonly IntPtr NativeMethodInfoPtr_GetFirstBehaviourOfType_Public_BehaviourType_0;

		// Token: 0x04000492 RID: 1170
		private static readonly IntPtr NativeMethodInfoPtr_GetFirstBehaviourOfType_Public_IGizmoBehaviour_Type_0;

		// Token: 0x04000493 RID: 1171
		private static readonly IntPtr NativeMethodInfoPtr_GetAllHandlesHoverData_Public_List_1_GizmoHandleHoverData_Ray_0;

		// Token: 0x04000494 RID: 1172
		private static readonly IntPtr NativeMethodInfoPtr_GetHandleById_SystemCall_Public_IGizmoHandle_Int32_0;

		// Token: 0x04000495 RID: 1173
		private static readonly IntPtr NativeMethodInfoPtr_OnGUI_SystemCall_Public_Void_0;

		// Token: 0x04000496 RID: 1174
		private static readonly IntPtr NativeMethodInfoPtr_OnUpdateBegin_SystemCall_Public_Void_0;

		// Token: 0x04000497 RID: 1175
		private static readonly IntPtr NativeMethodInfoPtr_OnUpdateEnd_SystemCall_Public_Void_0;

		// Token: 0x04000498 RID: 1176
		private static readonly IntPtr NativeMethodInfoPtr_UpdateHandleHoverInfo_SystemCall_Public_Void_GizmoHoverInfo_0;

		// Token: 0x04000499 RID: 1177
		private static readonly IntPtr NativeMethodInfoPtr_Render_SystemCall_Public_Void_Camera_Il2CppStructArray_1_Plane_0;

		// Token: 0x0400049A RID: 1178
		private static readonly IntPtr NativeMethodInfoPtr_HandleInputDeviceEvents_SystemCall_Public_Void_0;

		// Token: 0x0400049B RID: 1179
		private static readonly IntPtr NativeMethodInfoPtr_OnInputDevicePickButtonDown_Private_Void_0;

		// Token: 0x0400049C RID: 1180
		private static readonly IntPtr NativeMethodInfoPtr_OnInputDevicePickButtonUp_Private_Void_0;

		// Token: 0x0400049D RID: 1181
		private static readonly IntPtr NativeMethodInfoPtr_EndDragSession_Private_Void_0;

		// Token: 0x0400049E RID: 1182
		private static readonly IntPtr NativeMethodInfoPtr_OnInputDeviceMoved_Private_Void_0;

		// Token: 0x0400049F RID: 1183
		private static readonly IntPtr NativeMethodInfoPtr_TryActivateDragSession_Private_Void_0;

		// Token: 0x0200035C RID: 860
		private sealed class MethodInfoStoreGeneric_AddBehaviour_Public_BehaviourType_0<BehaviourType>
		{
			// Token: 0x04003935 RID: 14645
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Gizmo.NativeMethodInfoPtr_AddBehaviour_Public_BehaviourType_0, Il2CppClassPointerStore<Gizmo>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<BehaviourType>.NativeClassPtr)) }))));
		}

		// Token: 0x0200035D RID: 861
		private sealed class MethodInfoStoreGeneric_GetBehavioursOfType_Public_List_1_BehaviourType_0<BehaviourType>
		{
			// Token: 0x04003936 RID: 14646
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Gizmo.NativeMethodInfoPtr_GetBehavioursOfType_Public_List_1_BehaviourType_0, Il2CppClassPointerStore<Gizmo>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<BehaviourType>.NativeClassPtr)) }))));
		}

		// Token: 0x0200035E RID: 862
		private sealed class MethodInfoStoreGeneric_GetFirstBehaviourOfType_Public_BehaviourType_0<BehaviourType>
		{
			// Token: 0x04003937 RID: 14647
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Gizmo.NativeMethodInfoPtr_GetFirstBehaviourOfType_Public_BehaviourType_0, Il2CppClassPointerStore<Gizmo>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<BehaviourType>.NativeClassPtr)) }))));
		}
	}
}
