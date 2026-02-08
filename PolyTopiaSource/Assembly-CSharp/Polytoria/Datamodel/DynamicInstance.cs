using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Mirror;
using UnityEngine;

namespace Polytoria.Datamodel
{
	// Token: 0x02000276 RID: 630
	public class DynamicInstance : Instance
	{
		// Token: 0x0600310F RID: 12559 RVA: 0x000E13CC File Offset: 0x000DF5CC
		// Note: this type is marked as 'beforefieldinit'.
		static DynamicInstance()
		{
			Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel", "DynamicInstance");
			DynamicInstance.NativeFieldInfoPtr_transformSyncInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, "transformSyncInterval");
			DynamicInstance.NativeFieldInfoPtr_positionThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, "positionThreshold");
			DynamicInstance.NativeFieldInfoPtr_rotationThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, "rotationThreshold");
			DynamicInstance.NativeFieldInfoPtr_scaleThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, "scaleThreshold");
			DynamicInstance.NativeFieldInfoPtr__rb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, "_rb");
			DynamicInstance.NativeFieldInfoPtr__SyncMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, "<SyncMode>k__BackingField");
			DynamicInstance.NativeFieldInfoPtr_syncVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, "syncVelocity");
			DynamicInstance.NativeFieldInfoPtr_velocitySensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, "velocitySensitivity");
			DynamicInstance.NativeFieldInfoPtr_syncAngularVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, "syncAngularVelocity");
			DynamicInstance.NativeFieldInfoPtr_angularVelocitySensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, "angularVelocitySensitivity");
			DynamicInstance.NativeFieldInfoPtr_timeAlive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, "timeAlive");
			DynamicInstance.NativeFieldInfoPtr_first = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, "first");
			DynamicInstance.NativeFieldInfoPtr_requestedTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, "requestedTransform");
			DynamicInstance.NativeFieldInfoPtr_MIN_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, "MIN_SIZE");
			DynamicInstance.NativeFieldInfoPtr_lastServerSendTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, "lastServerSendTime");
			DynamicInstance.NativeFieldInfoPtr__velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, "_velocity");
			DynamicInstance.NativeFieldInfoPtr__angularVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, "_angularVelocity");
			DynamicInstance.NativeFieldInfoPtr__isKinematic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, "_isKinematic");
			DynamicInstance.NativeFieldInfoPtr__useGravity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, "_useGravity");
			DynamicInstance.NativeFieldInfoPtr__drag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, "_drag");
			DynamicInstance.NativeFieldInfoPtr__angularDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, "_angularDrag");
			DynamicInstance.NativeFieldInfoPtr_previousValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, "previousValue");
			DynamicInstance.NativeFieldInfoPtr_lastPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, "lastPos");
			DynamicInstance.NativeFieldInfoPtr_lastSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, "lastSize");
			DynamicInstance.NativeFieldInfoPtr_lastRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, "lastRot");
			DynamicInstance.NativeFieldInfoPtr_serverPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, "serverPosition");
			DynamicInstance.NativeFieldInfoPtr_serverSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, "serverSize");
			DynamicInstance.NativeFieldInfoPtr_serverRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, "serverRotation");
			DynamicInstance.NativeFieldInfoPtr_isDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, "isDirty");
			DynamicInstance.NativeFieldInfoPtr_isChildOfPlayerTool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, "isChildOfPlayerTool");
			DynamicInstance.NativeFieldInfoPtr_players = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, "players");
			DynamicInstance.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate__velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, "_Mirror_SyncVarHookDelegate__velocity");
			DynamicInstance.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate__angularVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, "_Mirror_SyncVarHookDelegate__angularVelocity");
			DynamicInstance.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate__isKinematic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, "_Mirror_SyncVarHookDelegate__isKinematic");
			DynamicInstance.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate__useGravity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, "_Mirror_SyncVarHookDelegate__useGravity");
			DynamicInstance.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate__drag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, "_Mirror_SyncVarHookDelegate__drag");
			DynamicInstance.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate__angularDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, "_Mirror_SyncVarHookDelegate__angularDrag");
			DynamicInstance.NativeMethodInfoPtr_get_DoTransformSync_Protected_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670677);
			DynamicInstance.NativeMethodInfoPtr_get_SyncMode_Public_get_SyncMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670678);
			DynamicInstance.NativeMethodInfoPtr_set_SyncMode_Public_set_Void_SyncMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670679);
			DynamicInstance.NativeMethodInfoPtr_get_Position_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670680);
			DynamicInstance.NativeMethodInfoPtr_set_Position_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670681);
			DynamicInstance.NativeMethodInfoPtr_get_Rotation_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670682);
			DynamicInstance.NativeMethodInfoPtr_set_Rotation_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670683);
			DynamicInstance.NativeMethodInfoPtr_get_LocalPosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670684);
			DynamicInstance.NativeMethodInfoPtr_set_LocalPosition_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670685);
			DynamicInstance.NativeMethodInfoPtr_get_LocalRotation_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670686);
			DynamicInstance.NativeMethodInfoPtr_set_LocalRotation_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670687);
			DynamicInstance.NativeMethodInfoPtr_get_Size_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670688);
			DynamicInstance.NativeMethodInfoPtr_set_Size_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670689);
			DynamicInstance.NativeMethodInfoPtr_get_LocalSize_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670690);
			DynamicInstance.NativeMethodInfoPtr_set_LocalSize_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670691);
			DynamicInstance.NativeMethodInfoPtr_get_Quaternion_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670692);
			DynamicInstance.NativeMethodInfoPtr_set_Quaternion_Public_set_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670693);
			DynamicInstance.NativeMethodInfoPtr_get_LocalQuaternion_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670694);
			DynamicInstance.NativeMethodInfoPtr_set_LocalQuaternion_Public_set_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670695);
			DynamicInstance.NativeMethodInfoPtr_get_Forward_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670696);
			DynamicInstance.NativeMethodInfoPtr_get_Right_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670697);
			DynamicInstance.NativeMethodInfoPtr_get_Up_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670698);
			DynamicInstance.NativeMethodInfoPtr_get_IgnoreSync_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670699);
			DynamicInstance.NativeMethodInfoPtr_get_Network_velocity_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670741);
			DynamicInstance.NativeMethodInfoPtr_set_Network_velocity_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670742);
			DynamicInstance.NativeMethodInfoPtr_get_Network_angularVelocity_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670743);
			DynamicInstance.NativeMethodInfoPtr_set_Network_angularVelocity_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670744);
			DynamicInstance.NativeMethodInfoPtr_get_Network_isKinematic_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670745);
			DynamicInstance.NativeMethodInfoPtr_set_Network_isKinematic_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670746);
			DynamicInstance.NativeMethodInfoPtr_get_Network_useGravity_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670747);
			DynamicInstance.NativeMethodInfoPtr_set_Network_useGravity_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670748);
			DynamicInstance.NativeMethodInfoPtr_get_Network_drag_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670749);
			DynamicInstance.NativeMethodInfoPtr_set_Network_drag_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670750);
			DynamicInstance.NativeMethodInfoPtr_get_Network_angularDrag_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670751);
			DynamicInstance.NativeMethodInfoPtr_set_Network_angularDrag_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670752);
			DynamicInstance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670738);
			DynamicInstance.NativeMethodInfoPtr_OnVelocityChanged_Private_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670700);
			DynamicInstance.NativeMethodInfoPtr_OnAngularVelocityChanged_Private_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670701);
			DynamicInstance.NativeMethodInfoPtr_OnIsKinematicChanged_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670702);
			DynamicInstance.NativeMethodInfoPtr_OnUseGravityChanged_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670703);
			DynamicInstance.NativeMethodInfoPtr_OnDragChanged_Private_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670704);
			DynamicInstance.NativeMethodInfoPtr_OnAngularDragChanged_Private_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670705);
			DynamicInstance.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670706);
			DynamicInstance.NativeMethodInfoPtr_OnGameLoadedLocally_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670707);
			DynamicInstance.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670708);
			DynamicInstance.NativeMethodInfoPtr_RequestTransform_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670709);
			DynamicInstance.NativeMethodInfoPtr_ApplyTransform_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670710);
			DynamicInstance.NativeMethodInfoPtr_CheckIfChildOfPlayerTool_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670711);
			DynamicInstance.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670712);
			DynamicInstance.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670713);
			DynamicInstance.NativeMethodInfoPtr_UpdateServer_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670714);
			DynamicInstance.NativeMethodInfoPtr_UpdateClient_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670715);
			DynamicInstance.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670716);
			DynamicInstance.NativeMethodInfoPtr_HasTransformChanged_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670717);
			DynamicInstance.NativeMethodInfoPtr_CacheTransform_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670718);
			DynamicInstance.NativeMethodInfoPtr_CopyProperties_Protected_Virtual_Void_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670719);
			DynamicInstance.NativeMethodInfoPtr_SyncPhysics_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670720);
			DynamicInstance.NativeMethodInfoPtr_UpdateTransform_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670721);
			DynamicInstance.NativeMethodInfoPtr_SyncTransformRecursively_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670722);
			DynamicInstance.NativeMethodInfoPtr_RpcSyncTransform_Protected_Void_Vector3_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670723);
			DynamicInstance.NativeMethodInfoPtr_CmdRequestTransform_Private_Void_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670724);
			DynamicInstance.NativeMethodInfoPtr_SetTransformTargetRpc_Private_Void_NetworkConnection_Vector3_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670725);
			DynamicInstance.NativeMethodInfoPtr_LookAt_Public_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670726);
			DynamicInstance.NativeMethodInfoPtr_LookAt_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670727);
			DynamicInstance.NativeMethodInfoPtr_LookAt_Public_Void_DynamicInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670728);
			DynamicInstance.NativeMethodInfoPtr_Translate_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670729);
			DynamicInstance.NativeMethodInfoPtr_RotateAround_Public_Void_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670730);
			DynamicInstance.NativeMethodInfoPtr_Rotate_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670731);
			DynamicInstance.NativeMethodInfoPtr_InverseTransformPoint_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670732);
			DynamicInstance.NativeMethodInfoPtr_TransformPoint_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670733);
			DynamicInstance.NativeMethodInfoPtr_InverseTransformDirection_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670734);
			DynamicInstance.NativeMethodInfoPtr_TransformDirection_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670735);
			DynamicInstance.NativeMethodInfoPtr_InverseTransformVector_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670736);
			DynamicInstance.NativeMethodInfoPtr_TransformVector_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670737);
			DynamicInstance.NativeMethodInfoPtr__Awake_b__74_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670739);
			DynamicInstance.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670740);
			DynamicInstance.NativeMethodInfoPtr_UserCode_RpcSyncTransform__Vector3__Quaternion__Vector3_Protected_Void_Vector3_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670753);
			DynamicInstance.NativeMethodInfoPtr_InvokeUserCode_RpcSyncTransform__Vector3__Quaternion__Vector3_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670754);
			DynamicInstance.NativeMethodInfoPtr_UserCode_CmdRequestTransform__NetworkConnectionToClient_Protected_Void_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670755);
			DynamicInstance.NativeMethodInfoPtr_InvokeUserCode_CmdRequestTransform__NetworkConnectionToClient_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670756);
			DynamicInstance.NativeMethodInfoPtr_UserCode_SetTransformTargetRpc__NetworkConnection__Vector3__Quaternion__Vector3_Protected_Void_NetworkConnection_Vector3_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670757);
			DynamicInstance.NativeMethodInfoPtr_InvokeUserCode_SetTransformTargetRpc__NetworkConnection__Vector3__Quaternion__Vector3_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670758);
			DynamicInstance.NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670760);
			DynamicInstance.NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr, 100670761);
		}

		// Token: 0x1700114E RID: 4430
		// (get) Token: 0x06003110 RID: 12560 RVA: 0x000E1D68 File Offset: 0x000DFF68
		public unsafe virtual bool DoTransformSync
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101505, XrefRangeEnd = 101506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicInstance.NativeMethodInfoPtr_get_DoTransformSync_Protected_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700114F RID: 4431
		// (get) Token: 0x06003111 RID: 12561 RVA: 0x000E1DB0 File Offset: 0x000DFFB0
		// (set) Token: 0x06003112 RID: 12562 RVA: 0x000E1DF0 File Offset: 0x000DFFF0
		public unsafe SyncMode SyncMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicInstance.NativeMethodInfoPtr_get_SyncMode_Public_get_SyncMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SyncMode>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicInstance.NativeMethodInfoPtr_set_SyncMode_Public_set_Void_SyncMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001150 RID: 4432
		// (get) Token: 0x06003113 RID: 12563 RVA: 0x000E1E34 File Offset: 0x000E0034
		// (set) Token: 0x06003114 RID: 12564 RVA: 0x000E1E74 File Offset: 0x000E0074
		public unsafe Vector3 Position
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 101507, RefRangeEnd = 101513, XrefRangeStart = 101506, XrefRangeEnd = 101507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicInstance.NativeMethodInfoPtr_get_Position_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 101514, RefRangeEnd = 101521, XrefRangeStart = 101513, XrefRangeEnd = 101514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicInstance.NativeMethodInfoPtr_set_Position_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001151 RID: 4433
		// (get) Token: 0x06003115 RID: 12565 RVA: 0x000E1EB8 File Offset: 0x000E00B8
		// (set) Token: 0x06003116 RID: 12566 RVA: 0x000E1EF8 File Offset: 0x000E00F8
		public unsafe Vector3 Rotation
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 101522, RefRangeEnd = 101525, XrefRangeStart = 101521, XrefRangeEnd = 101522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicInstance.NativeMethodInfoPtr_get_Rotation_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 101526, RefRangeEnd = 101529, XrefRangeStart = 101525, XrefRangeEnd = 101526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicInstance.NativeMethodInfoPtr_set_Rotation_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001152 RID: 4434
		// (get) Token: 0x06003117 RID: 12567 RVA: 0x000E1F3C File Offset: 0x000E013C
		// (set) Token: 0x06003118 RID: 12568 RVA: 0x000E1F7C File Offset: 0x000E017C
		public unsafe Vector3 LocalPosition
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 101530, RefRangeEnd = 101531, XrefRangeStart = 101529, XrefRangeEnd = 101530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicInstance.NativeMethodInfoPtr_get_LocalPosition_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 101532, RefRangeEnd = 101533, XrefRangeStart = 101531, XrefRangeEnd = 101532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicInstance.NativeMethodInfoPtr_set_LocalPosition_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001153 RID: 4435
		// (get) Token: 0x06003119 RID: 12569 RVA: 0x000E1FC0 File Offset: 0x000E01C0
		// (set) Token: 0x0600311A RID: 12570 RVA: 0x000E2000 File Offset: 0x000E0200
		public unsafe Vector3 LocalRotation
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 101534, RefRangeEnd = 101535, XrefRangeStart = 101533, XrefRangeEnd = 101534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicInstance.NativeMethodInfoPtr_get_LocalRotation_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 101536, RefRangeEnd = 101537, XrefRangeStart = 101535, XrefRangeEnd = 101536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicInstance.NativeMethodInfoPtr_set_LocalRotation_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001154 RID: 4436
		// (get) Token: 0x0600311B RID: 12571 RVA: 0x000E2044 File Offset: 0x000E0244
		// (set) Token: 0x0600311C RID: 12572 RVA: 0x000E2084 File Offset: 0x000E0284
		public unsafe Vector3 Size
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 101538, RefRangeEnd = 101554, XrefRangeStart = 101537, XrefRangeEnd = 101538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicInstance.NativeMethodInfoPtr_get_Size_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 101561, RefRangeEnd = 101564, XrefRangeStart = 101554, XrefRangeEnd = 101561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicInstance.NativeMethodInfoPtr_set_Size_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001155 RID: 4437
		// (get) Token: 0x0600311D RID: 12573 RVA: 0x000E20C8 File Offset: 0x000E02C8
		// (set) Token: 0x0600311E RID: 12574 RVA: 0x000E2108 File Offset: 0x000E0308
		public unsafe Vector3 LocalSize
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 101565, RefRangeEnd = 101566, XrefRangeStart = 101564, XrefRangeEnd = 101565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicInstance.NativeMethodInfoPtr_get_LocalSize_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 101567, RefRangeEnd = 101568, XrefRangeStart = 101566, XrefRangeEnd = 101567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicInstance.NativeMethodInfoPtr_set_LocalSize_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001156 RID: 4438
		// (get) Token: 0x0600311F RID: 12575 RVA: 0x000E214C File Offset: 0x000E034C
		// (set) Token: 0x06003120 RID: 12576 RVA: 0x000E218C File Offset: 0x000E038C
		public unsafe Quaternion Quaternion
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 101569, RefRangeEnd = 101570, XrefRangeStart = 101568, XrefRangeEnd = 101569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicInstance.NativeMethodInfoPtr_get_Quaternion_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 101571, RefRangeEnd = 101572, XrefRangeStart = 101570, XrefRangeEnd = 101571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicInstance.NativeMethodInfoPtr_set_Quaternion_Public_set_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001157 RID: 4439
		// (get) Token: 0x06003121 RID: 12577 RVA: 0x000E21D0 File Offset: 0x000E03D0
		// (set) Token: 0x06003122 RID: 12578 RVA: 0x000E2210 File Offset: 0x000E0410
		public unsafe Quaternion LocalQuaternion
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 101573, RefRangeEnd = 101574, XrefRangeStart = 101572, XrefRangeEnd = 101573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicInstance.NativeMethodInfoPtr_get_LocalQuaternion_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 101575, RefRangeEnd = 101576, XrefRangeStart = 101574, XrefRangeEnd = 101575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicInstance.NativeMethodInfoPtr_set_LocalQuaternion_Public_set_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001158 RID: 4440
		// (get) Token: 0x06003123 RID: 12579 RVA: 0x000E2254 File Offset: 0x000E0454
		public unsafe Vector3 Forward
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 101577, RefRangeEnd = 101578, XrefRangeStart = 101576, XrefRangeEnd = 101577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicInstance.NativeMethodInfoPtr_get_Forward_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17001159 RID: 4441
		// (get) Token: 0x06003124 RID: 12580 RVA: 0x000E2294 File Offset: 0x000E0494
		public unsafe Vector3 Right
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 101579, RefRangeEnd = 101580, XrefRangeStart = 101578, XrefRangeEnd = 101579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicInstance.NativeMethodInfoPtr_get_Right_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x1700115A RID: 4442
		// (get) Token: 0x06003125 RID: 12581 RVA: 0x000E22D4 File Offset: 0x000E04D4
		public unsafe Vector3 Up
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 101581, RefRangeEnd = 101582, XrefRangeStart = 101580, XrefRangeEnd = 101581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicInstance.NativeMethodInfoPtr_get_Up_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x1700115B RID: 4443
		// (get) Token: 0x06003126 RID: 12582 RVA: 0x000E2314 File Offset: 0x000E0514
		public unsafe bool IgnoreSync
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101582, XrefRangeEnd = 101583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicInstance.NativeMethodInfoPtr_get_IgnoreSync_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700115C RID: 4444
		// (get) Token: 0x06003127 RID: 12583 RVA: 0x000E2350 File Offset: 0x000E0550
		// (set) Token: 0x06003128 RID: 12584 RVA: 0x000E2390 File Offset: 0x000E0590
		public unsafe Vector3 Network_velocity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicInstance.NativeMethodInfoPtr_get_Network_velocity_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101583, XrefRangeEnd = 101586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicInstance.NativeMethodInfoPtr_set_Network_velocity_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700115D RID: 4445
		// (get) Token: 0x06003129 RID: 12585 RVA: 0x000E23D4 File Offset: 0x000E05D4
		// (set) Token: 0x0600312A RID: 12586 RVA: 0x000E2414 File Offset: 0x000E0614
		public unsafe Vector3 Network_angularVelocity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicInstance.NativeMethodInfoPtr_get_Network_angularVelocity_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101586, XrefRangeEnd = 101589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicInstance.NativeMethodInfoPtr_set_Network_angularVelocity_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700115E RID: 4446
		// (get) Token: 0x0600312B RID: 12587 RVA: 0x000E2458 File Offset: 0x000E0658
		// (set) Token: 0x0600312C RID: 12588 RVA: 0x000E2494 File Offset: 0x000E0694
		public unsafe bool Network_isKinematic
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicInstance.NativeMethodInfoPtr_get_Network_isKinematic_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101589, XrefRangeEnd = 101592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicInstance.NativeMethodInfoPtr_set_Network_isKinematic_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700115F RID: 4447
		// (get) Token: 0x0600312D RID: 12589 RVA: 0x000E24D4 File Offset: 0x000E06D4
		// (set) Token: 0x0600312E RID: 12590 RVA: 0x000E2510 File Offset: 0x000E0710
		public unsafe bool Network_useGravity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicInstance.NativeMethodInfoPtr_get_Network_useGravity_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101592, XrefRangeEnd = 101595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicInstance.NativeMethodInfoPtr_set_Network_useGravity_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001160 RID: 4448
		// (get) Token: 0x0600312F RID: 12591 RVA: 0x000E2550 File Offset: 0x000E0750
		// (set) Token: 0x06003130 RID: 12592 RVA: 0x000E258C File Offset: 0x000E078C
		public unsafe float Network_drag
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicInstance.NativeMethodInfoPtr_get_Network_drag_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101595, XrefRangeEnd = 101598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicInstance.NativeMethodInfoPtr_set_Network_drag_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001161 RID: 4449
		// (get) Token: 0x06003131 RID: 12593 RVA: 0x000E25CC File Offset: 0x000E07CC
		// (set) Token: 0x06003132 RID: 12594 RVA: 0x000E2608 File Offset: 0x000E0808
		public unsafe float Network_angularDrag
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicInstance.NativeMethodInfoPtr_get_Network_angularDrag_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101598, XrefRangeEnd = 101601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicInstance.NativeMethodInfoPtr_set_Network_angularDrag_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003133 RID: 12595 RVA: 0x000E2648 File Offset: 0x000E0848
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 101644, RefRangeEnd = 101656, XrefRangeStart = 101601, XrefRangeEnd = 101644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynamicInstance()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicInstance>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicInstance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003134 RID: 12596 RVA: 0x000E2684 File Offset: 0x000E0884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101656, XrefRangeEnd = 101666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnVelocityChanged(Vector3 _, Vector3 newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicInstance.NativeMethodInfoPtr_OnVelocityChanged_Private_Void_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003135 RID: 12597 RVA: 0x000E26D8 File Offset: 0x000E08D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101666, XrefRangeEnd = 101676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnAngularVelocityChanged(Vector3 _, Vector3 newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicInstance.NativeMethodInfoPtr_OnAngularVelocityChanged_Private_Void_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003136 RID: 12598 RVA: 0x000E272C File Offset: 0x000E092C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101676, XrefRangeEnd = 101685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnIsKinematicChanged(bool _, bool newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref _;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicInstance.NativeMethodInfoPtr_OnIsKinematicChanged_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003137 RID: 12599 RVA: 0x000E2778 File Offset: 0x000E0978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101685, XrefRangeEnd = 101694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnUseGravityChanged(bool _, bool newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref _;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicInstance.NativeMethodInfoPtr_OnUseGravityChanged_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003138 RID: 12600 RVA: 0x000E27C4 File Offset: 0x000E09C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101694, XrefRangeEnd = 101703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDragChanged(float _, float newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref _;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicInstance.NativeMethodInfoPtr_OnDragChanged_Private_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003139 RID: 12601 RVA: 0x000E2810 File Offset: 0x000E0A10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101703, XrefRangeEnd = 101712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnAngularDragChanged(float _, float newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref _;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicInstance.NativeMethodInfoPtr_OnAngularDragChanged_Private_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600313A RID: 12602 RVA: 0x000E285C File Offset: 0x000E0A5C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 101729, RefRangeEnd = 101738, XrefRangeStart = 101712, XrefRangeEnd = 101729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicInstance.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600313B RID: 12603 RVA: 0x000E2898 File Offset: 0x000E0A98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101738, XrefRangeEnd = 101747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGameLoadedLocally()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicInstance.NativeMethodInfoPtr_OnGameLoadedLocally_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600313C RID: 12604 RVA: 0x000E28CC File Offset: 0x000E0ACC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 101761, RefRangeEnd = 101762, XrefRangeStart = 101747, XrefRangeEnd = 101761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicInstance.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600313D RID: 12605 RVA: 0x000E2908 File Offset: 0x000E0B08
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 101793, RefRangeEnd = 101795, XrefRangeStart = 101762, XrefRangeEnd = 101793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RequestTransform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicInstance.NativeMethodInfoPtr_RequestTransform_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600313E RID: 12606 RVA: 0x000E293C File Offset: 0x000E0B3C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 101805, RefRangeEnd = 101807, XrefRangeStart = 101795, XrefRangeEnd = 101805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyTransform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicInstance.NativeMethodInfoPtr_ApplyTransform_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600313F RID: 12607 RVA: 0x000E2970 File Offset: 0x000E0B70
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 101833, RefRangeEnd = 101836, XrefRangeStart = 101807, XrefRangeEnd = 101833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckIfChildOfPlayerTool()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicInstance.NativeMethodInfoPtr_CheckIfChildOfPlayerTool_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003140 RID: 12608 RVA: 0x000E29A4 File Offset: 0x000E0BA4
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicInstance.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003141 RID: 12609 RVA: 0x000E29E0 File Offset: 0x000E0BE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 101838, RefRangeEnd = 101839, XrefRangeStart = 101836, XrefRangeEnd = 101838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicInstance.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003142 RID: 12610 RVA: 0x000E2A1C File Offset: 0x000E0C1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101839, XrefRangeEnd = 101848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateServer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicInstance.NativeMethodInfoPtr_UpdateServer_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003143 RID: 12611 RVA: 0x000E2A50 File Offset: 0x000E0C50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 101864, RefRangeEnd = 101865, XrefRangeStart = 101848, XrefRangeEnd = 101864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateClient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicInstance.NativeMethodInfoPtr_UpdateClient_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003144 RID: 12612 RVA: 0x000E2A84 File Offset: 0x000E0C84
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 101895, RefRangeEnd = 101901, XrefRangeStart = 101865, XrefRangeEnd = 101895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicInstance.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003145 RID: 12613 RVA: 0x000E2AC0 File Offset: 0x000E0CC0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 101906, RefRangeEnd = 101908, XrefRangeStart = 101901, XrefRangeEnd = 101906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasTransformChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicInstance.NativeMethodInfoPtr_HasTransformChanged_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003146 RID: 12614 RVA: 0x000E2AFC File Offset: 0x000E0CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101908, XrefRangeEnd = 101911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CacheTransform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicInstance.NativeMethodInfoPtr_CacheTransform_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003147 RID: 12615 RVA: 0x000E2B30 File Offset: 0x000E0D30
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 101920, RefRangeEnd = 101928, XrefRangeStart = 101911, XrefRangeEnd = 101920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CopyProperties(Instance clone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clone);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicInstance.NativeMethodInfoPtr_CopyProperties_Protected_Virtual_Void_Instance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003148 RID: 12616 RVA: 0x000E2B80 File Offset: 0x000E0D80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 101958, RefRangeEnd = 101959, XrefRangeStart = 101928, XrefRangeEnd = 101958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SyncPhysics()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicInstance.NativeMethodInfoPtr_SyncPhysics_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003149 RID: 12617 RVA: 0x000E2BB4 File Offset: 0x000E0DB4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 102002, RefRangeEnd = 102005, XrefRangeStart = 101959, XrefRangeEnd = 102002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTransform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicInstance.NativeMethodInfoPtr_UpdateTransform_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600314A RID: 12618 RVA: 0x000E2BE8 File Offset: 0x000E0DE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 102012, RefRangeEnd = 102013, XrefRangeStart = 102005, XrefRangeEnd = 102012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SyncTransformRecursively()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicInstance.NativeMethodInfoPtr_SyncTransformRecursively_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600314B RID: 12619 RVA: 0x000E2C1C File Offset: 0x000E0E1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102013, XrefRangeEnd = 102036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcSyncTransform(Vector3 position, Quaternion rotation, Vector3 size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(position);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rotation);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(size);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicInstance.NativeMethodInfoPtr_RpcSyncTransform_Protected_Void_Vector3_Quaternion_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600314C RID: 12620 RVA: 0x000E2C84 File Offset: 0x000E0E84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102036, XrefRangeEnd = 102056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CmdRequestTransform(NetworkConnectionToClient sender = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicInstance.NativeMethodInfoPtr_CmdRequestTransform_Private_Void_NetworkConnectionToClient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600314D RID: 12621 RVA: 0x000E2CC8 File Offset: 0x000E0EC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102056, XrefRangeEnd = 102079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTransformTargetRpc(NetworkConnection target, Vector3 position, Quaternion rotation, Vector3 size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(position);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rotation);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(size);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicInstance.NativeMethodInfoPtr_SetTransformTargetRpc_Private_Void_NetworkConnection_Vector3_Quaternion_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600314E RID: 12622 RVA: 0x000E2D44 File Offset: 0x000E0F44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 102084, RefRangeEnd = 102085, XrefRangeStart = 102079, XrefRangeEnd = 102084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LookAt(Vector3 target, Vector3 worldUp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(worldUp);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicInstance.NativeMethodInfoPtr_LookAt_Public_Void_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600314F RID: 12623 RVA: 0x000E2D98 File Offset: 0x000E0F98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 102092, RefRangeEnd = 102093, XrefRangeStart = 102085, XrefRangeEnd = 102092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LookAt(Vector3 target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicInstance.NativeMethodInfoPtr_LookAt_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003150 RID: 12624 RVA: 0x000E2DDC File Offset: 0x000E0FDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 102101, RefRangeEnd = 102102, XrefRangeStart = 102093, XrefRangeEnd = 102101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LookAt(DynamicInstance target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicInstance.NativeMethodInfoPtr_LookAt_Public_Void_DynamicInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003151 RID: 12625 RVA: 0x000E2E20 File Offset: 0x000E1020
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 102103, RefRangeEnd = 102104, XrefRangeStart = 102102, XrefRangeEnd = 102103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Translate(Vector3 translation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(translation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicInstance.NativeMethodInfoPtr_Translate_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003152 RID: 12626 RVA: 0x000E2E64 File Offset: 0x000E1064
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 102105, RefRangeEnd = 102106, XrefRangeStart = 102104, XrefRangeEnd = 102105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RotateAround(Vector3 point, Vector3 axis, float angle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(axis);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref angle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicInstance.NativeMethodInfoPtr_RotateAround_Public_Void_Vector3_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003153 RID: 12627 RVA: 0x000E2EC8 File Offset: 0x000E10C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 102107, RefRangeEnd = 102108, XrefRangeStart = 102106, XrefRangeEnd = 102107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Rotate(Vector3 eulerAngles)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eulerAngles);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicInstance.NativeMethodInfoPtr_Rotate_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003154 RID: 12628 RVA: 0x000E2F0C File Offset: 0x000E110C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 102109, RefRangeEnd = 102110, XrefRangeStart = 102108, XrefRangeEnd = 102109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 InverseTransformPoint(Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicInstance.NativeMethodInfoPtr_InverseTransformPoint_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x06003155 RID: 12629 RVA: 0x000E2F5C File Offset: 0x000E115C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 102111, RefRangeEnd = 102112, XrefRangeStart = 102110, XrefRangeEnd = 102111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 TransformPoint(Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicInstance.NativeMethodInfoPtr_TransformPoint_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x06003156 RID: 12630 RVA: 0x000E2FAC File Offset: 0x000E11AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 102113, RefRangeEnd = 102114, XrefRangeStart = 102112, XrefRangeEnd = 102113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 InverseTransformDirection(Vector3 direction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(direction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicInstance.NativeMethodInfoPtr_InverseTransformDirection_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x06003157 RID: 12631 RVA: 0x000E2FFC File Offset: 0x000E11FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 102115, RefRangeEnd = 102116, XrefRangeStart = 102114, XrefRangeEnd = 102115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 TransformDirection(Vector3 direction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(direction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicInstance.NativeMethodInfoPtr_TransformDirection_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x06003158 RID: 12632 RVA: 0x000E304C File Offset: 0x000E124C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 102117, RefRangeEnd = 102118, XrefRangeStart = 102116, XrefRangeEnd = 102117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 InverseTransformVector(Vector3 vector)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vector);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicInstance.NativeMethodInfoPtr_InverseTransformVector_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x06003159 RID: 12633 RVA: 0x000E309C File Offset: 0x000E129C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 102119, RefRangeEnd = 102120, XrefRangeStart = 102118, XrefRangeEnd = 102119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 TransformVector(Vector3 vector)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vector);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicInstance.NativeMethodInfoPtr_TransformVector_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x0600315A RID: 12634 RVA: 0x000E30EC File Offset: 0x000E12EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102120, XrefRangeEnd = 102121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__74_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicInstance.NativeMethodInfoPtr__Awake_b__74_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600315B RID: 12635 RVA: 0x000E3120 File Offset: 0x000E1320
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 20124, RefRangeEnd = 20136, XrefRangeStart = 20124, XrefRangeEnd = 20136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Weaved()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicInstance.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600315C RID: 12636 RVA: 0x000E3168 File Offset: 0x000E1368
		[CallerCount(0)]
		public unsafe void UserCode_RpcSyncTransform__Vector3__Quaternion__Vector3(Vector3 position, Quaternion rotation, Vector3 size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(position);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rotation);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(size);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicInstance.NativeMethodInfoPtr_UserCode_RpcSyncTransform__Vector3__Quaternion__Vector3_Protected_Void_Vector3_Quaternion_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600315D RID: 12637 RVA: 0x000E31D0 File Offset: 0x000E13D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102121, XrefRangeEnd = 102132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RpcSyncTransform__Vector3__Quaternion__Vector3(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reader);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(senderConnection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicInstance.NativeMethodInfoPtr_InvokeUserCode_RpcSyncTransform__Vector3__Quaternion__Vector3_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600315E RID: 12638 RVA: 0x000E322C File Offset: 0x000E142C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 102158, RefRangeEnd = 102159, XrefRangeStart = 102132, XrefRangeEnd = 102158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_CmdRequestTransform__NetworkConnectionToClient(NetworkConnectionToClient sender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicInstance.NativeMethodInfoPtr_UserCode_CmdRequestTransform__NetworkConnectionToClient_Protected_Void_NetworkConnectionToClient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600315F RID: 12639 RVA: 0x000E3270 File Offset: 0x000E1470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102159, XrefRangeEnd = 102177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_CmdRequestTransform__NetworkConnectionToClient(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reader);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(senderConnection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicInstance.NativeMethodInfoPtr_InvokeUserCode_CmdRequestTransform__NetworkConnectionToClient_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003160 RID: 12640 RVA: 0x000E32CC File Offset: 0x000E14CC
		[CallerCount(0)]
		public unsafe void UserCode_SetTransformTargetRpc__NetworkConnection__Vector3__Quaternion__Vector3(NetworkConnection target, Vector3 position, Quaternion rotation, Vector3 size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(position);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rotation);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(size);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicInstance.NativeMethodInfoPtr_UserCode_SetTransformTargetRpc__NetworkConnection__Vector3__Quaternion__Vector3_Protected_Void_NetworkConnection_Vector3_Quaternion_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003161 RID: 12641 RVA: 0x000E3348 File Offset: 0x000E1548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102177, XrefRangeEnd = 102188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_SetTransformTargetRpc__NetworkConnection__Vector3__Quaternion__Vector3(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reader);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(senderConnection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicInstance.NativeMethodInfoPtr_InvokeUserCode_SetTransformTargetRpc__NetworkConnection__Vector3__Quaternion__Vector3_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003162 RID: 12642 RVA: 0x000E33A4 File Offset: 0x000E15A4
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 102202, RefRangeEnd = 102211, XrefRangeStart = 102188, XrefRangeEnd = 102202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceAll;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicInstance.NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003163 RID: 12643 RVA: 0x000E3400 File Offset: 0x000E1600
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 102250, RefRangeEnd = 102260, XrefRangeStart = 102211, XrefRangeEnd = 102250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DeserializeSyncVars(NetworkReader reader, bool initialState)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicInstance.NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003164 RID: 12644 RVA: 0x00013811 File Offset: 0x00011A11
		public DynamicInstance(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001129 RID: 4393
		// (get) Token: 0x06003165 RID: 12645 RVA: 0x000E345C File Offset: 0x000E165C
		// (set) Token: 0x06003166 RID: 12646 RVA: 0x0001381A File Offset: 0x00011A1A
		public unsafe float transformSyncInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicInstance.NativeFieldInfoPtr_transformSyncInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicInstance.NativeFieldInfoPtr_transformSyncInterval)) = value;
			}
		}

		// Token: 0x1700112A RID: 4394
		// (get) Token: 0x06003167 RID: 12647 RVA: 0x000E3484 File Offset: 0x000E1684
		// (set) Token: 0x06003168 RID: 12648 RVA: 0x00013835 File Offset: 0x00011A35
		public unsafe float positionThreshold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicInstance.NativeFieldInfoPtr_positionThreshold);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicInstance.NativeFieldInfoPtr_positionThreshold)) = value;
			}
		}

		// Token: 0x1700112B RID: 4395
		// (get) Token: 0x06003169 RID: 12649 RVA: 0x000E34AC File Offset: 0x000E16AC
		// (set) Token: 0x0600316A RID: 12650 RVA: 0x00013850 File Offset: 0x00011A50
		public unsafe float rotationThreshold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicInstance.NativeFieldInfoPtr_rotationThreshold);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicInstance.NativeFieldInfoPtr_rotationThreshold)) = value;
			}
		}

		// Token: 0x1700112C RID: 4396
		// (get) Token: 0x0600316B RID: 12651 RVA: 0x000E34D4 File Offset: 0x000E16D4
		// (set) Token: 0x0600316C RID: 12652 RVA: 0x0001386B File Offset: 0x00011A6B
		public unsafe float scaleThreshold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicInstance.NativeFieldInfoPtr_scaleThreshold);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicInstance.NativeFieldInfoPtr_scaleThreshold)) = value;
			}
		}

		// Token: 0x1700112D RID: 4397
		// (get) Token: 0x0600316D RID: 12653 RVA: 0x000E34FC File Offset: 0x000E16FC
		// (set) Token: 0x0600316E RID: 12654 RVA: 0x00013886 File Offset: 0x00011A86
		public unsafe Rigidbody _rb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicInstance.NativeFieldInfoPtr__rb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicInstance.NativeFieldInfoPtr__rb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700112E RID: 4398
		// (get) Token: 0x0600316F RID: 12655 RVA: 0x000E352C File Offset: 0x000E172C
		// (set) Token: 0x06003170 RID: 12656 RVA: 0x000138A5 File Offset: 0x00011AA5
		public unsafe SyncMode _SyncMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicInstance.NativeFieldInfoPtr__SyncMode_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncMode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicInstance.NativeFieldInfoPtr__SyncMode_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700112F RID: 4399
		// (get) Token: 0x06003171 RID: 12657 RVA: 0x000E355C File Offset: 0x000E175C
		// (set) Token: 0x06003172 RID: 12658 RVA: 0x000138C4 File Offset: 0x00011AC4
		public unsafe bool syncVelocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicInstance.NativeFieldInfoPtr_syncVelocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicInstance.NativeFieldInfoPtr_syncVelocity)) = value;
			}
		}

		// Token: 0x17001130 RID: 4400
		// (get) Token: 0x06003173 RID: 12659 RVA: 0x000E3584 File Offset: 0x000E1784
		// (set) Token: 0x06003174 RID: 12660 RVA: 0x000138DF File Offset: 0x00011ADF
		public unsafe float velocitySensitivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicInstance.NativeFieldInfoPtr_velocitySensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicInstance.NativeFieldInfoPtr_velocitySensitivity)) = value;
			}
		}

		// Token: 0x17001131 RID: 4401
		// (get) Token: 0x06003175 RID: 12661 RVA: 0x000E35AC File Offset: 0x000E17AC
		// (set) Token: 0x06003176 RID: 12662 RVA: 0x000138FA File Offset: 0x00011AFA
		public unsafe bool syncAngularVelocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicInstance.NativeFieldInfoPtr_syncAngularVelocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicInstance.NativeFieldInfoPtr_syncAngularVelocity)) = value;
			}
		}

		// Token: 0x17001132 RID: 4402
		// (get) Token: 0x06003177 RID: 12663 RVA: 0x000E35D4 File Offset: 0x000E17D4
		// (set) Token: 0x06003178 RID: 12664 RVA: 0x00013915 File Offset: 0x00011B15
		public unsafe float angularVelocitySensitivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicInstance.NativeFieldInfoPtr_angularVelocitySensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicInstance.NativeFieldInfoPtr_angularVelocitySensitivity)) = value;
			}
		}

		// Token: 0x17001133 RID: 4403
		// (get) Token: 0x06003179 RID: 12665 RVA: 0x000E35FC File Offset: 0x000E17FC
		// (set) Token: 0x0600317A RID: 12666 RVA: 0x00013930 File Offset: 0x00011B30
		public unsafe float timeAlive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicInstance.NativeFieldInfoPtr_timeAlive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicInstance.NativeFieldInfoPtr_timeAlive)) = value;
			}
		}

		// Token: 0x17001134 RID: 4404
		// (get) Token: 0x0600317B RID: 12667 RVA: 0x000E3624 File Offset: 0x000E1824
		// (set) Token: 0x0600317C RID: 12668 RVA: 0x0001394B File Offset: 0x00011B4B
		public unsafe bool first
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicInstance.NativeFieldInfoPtr_first);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicInstance.NativeFieldInfoPtr_first)) = value;
			}
		}

		// Token: 0x17001135 RID: 4405
		// (get) Token: 0x0600317D RID: 12669 RVA: 0x000E364C File Offset: 0x000E184C
		// (set) Token: 0x0600317E RID: 12670 RVA: 0x00013966 File Offset: 0x00011B66
		public unsafe bool requestedTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicInstance.NativeFieldInfoPtr_requestedTransform);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicInstance.NativeFieldInfoPtr_requestedTransform)) = value;
			}
		}

		// Token: 0x17001136 RID: 4406
		// (get) Token: 0x0600317F RID: 12671 RVA: 0x000E3674 File Offset: 0x000E1874
		// (set) Token: 0x06003180 RID: 12672 RVA: 0x00013981 File Offset: 0x00011B81
		public unsafe static float MIN_SIZE
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(DynamicInstance.NativeFieldInfoPtr_MIN_SIZE, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DynamicInstance.NativeFieldInfoPtr_MIN_SIZE, (void*)(&value));
			}
		}

		// Token: 0x17001137 RID: 4407
		// (get) Token: 0x06003181 RID: 12673 RVA: 0x000E3690 File Offset: 0x000E1890
		// (set) Token: 0x06003182 RID: 12674 RVA: 0x0001398F File Offset: 0x00011B8F
		public unsafe double lastServerSendTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicInstance.NativeFieldInfoPtr_lastServerSendTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicInstance.NativeFieldInfoPtr_lastServerSendTime)) = value;
			}
		}

		// Token: 0x17001138 RID: 4408
		// (get) Token: 0x06003183 RID: 12675 RVA: 0x000E36B8 File Offset: 0x000E18B8
		// (set) Token: 0x06003184 RID: 12676 RVA: 0x000139AA File Offset: 0x00011BAA
		public unsafe Vector3 _velocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicInstance.NativeFieldInfoPtr__velocity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicInstance.NativeFieldInfoPtr__velocity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001139 RID: 4409
		// (get) Token: 0x06003185 RID: 12677 RVA: 0x000E36E8 File Offset: 0x000E18E8
		// (set) Token: 0x06003186 RID: 12678 RVA: 0x000139C9 File Offset: 0x00011BC9
		public unsafe Vector3 _angularVelocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicInstance.NativeFieldInfoPtr__angularVelocity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicInstance.NativeFieldInfoPtr__angularVelocity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700113A RID: 4410
		// (get) Token: 0x06003187 RID: 12679 RVA: 0x000E3718 File Offset: 0x000E1918
		// (set) Token: 0x06003188 RID: 12680 RVA: 0x000139E8 File Offset: 0x00011BE8
		public unsafe bool _isKinematic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicInstance.NativeFieldInfoPtr__isKinematic);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicInstance.NativeFieldInfoPtr__isKinematic)) = value;
			}
		}

		// Token: 0x1700113B RID: 4411
		// (get) Token: 0x06003189 RID: 12681 RVA: 0x000E3740 File Offset: 0x000E1940
		// (set) Token: 0x0600318A RID: 12682 RVA: 0x00013A03 File Offset: 0x00011C03
		public unsafe bool _useGravity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicInstance.NativeFieldInfoPtr__useGravity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicInstance.NativeFieldInfoPtr__useGravity)) = value;
			}
		}

		// Token: 0x1700113C RID: 4412
		// (get) Token: 0x0600318B RID: 12683 RVA: 0x000E3768 File Offset: 0x000E1968
		// (set) Token: 0x0600318C RID: 12684 RVA: 0x00013A1E File Offset: 0x00011C1E
		public unsafe float _drag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicInstance.NativeFieldInfoPtr__drag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicInstance.NativeFieldInfoPtr__drag)) = value;
			}
		}

		// Token: 0x1700113D RID: 4413
		// (get) Token: 0x0600318D RID: 12685 RVA: 0x000E3790 File Offset: 0x000E1990
		// (set) Token: 0x0600318E RID: 12686 RVA: 0x00013A39 File Offset: 0x00011C39
		public unsafe float _angularDrag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicInstance.NativeFieldInfoPtr__angularDrag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicInstance.NativeFieldInfoPtr__angularDrag)) = value;
			}
		}

		// Token: 0x1700113E RID: 4414
		// (get) Token: 0x0600318F RID: 12687 RVA: 0x000E37B8 File Offset: 0x000E19B8
		// (set) Token: 0x06003190 RID: 12688 RVA: 0x00013A54 File Offset: 0x00011C54
		public unsafe ClientSyncState previousValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicInstance.NativeFieldInfoPtr_previousValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientSyncState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicInstance.NativeFieldInfoPtr_previousValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700113F RID: 4415
		// (get) Token: 0x06003191 RID: 12689 RVA: 0x000E37E8 File Offset: 0x000E19E8
		// (set) Token: 0x06003192 RID: 12690 RVA: 0x00013A73 File Offset: 0x00011C73
		public unsafe Vector3 lastPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicInstance.NativeFieldInfoPtr_lastPos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicInstance.NativeFieldInfoPtr_lastPos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001140 RID: 4416
		// (get) Token: 0x06003193 RID: 12691 RVA: 0x000E3818 File Offset: 0x000E1A18
		// (set) Token: 0x06003194 RID: 12692 RVA: 0x00013A92 File Offset: 0x00011C92
		public unsafe Vector3 lastSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicInstance.NativeFieldInfoPtr_lastSize);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicInstance.NativeFieldInfoPtr_lastSize), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001141 RID: 4417
		// (get) Token: 0x06003195 RID: 12693 RVA: 0x000E3848 File Offset: 0x000E1A48
		// (set) Token: 0x06003196 RID: 12694 RVA: 0x00013AB1 File Offset: 0x00011CB1
		public unsafe Quaternion lastRot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicInstance.NativeFieldInfoPtr_lastRot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicInstance.NativeFieldInfoPtr_lastRot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001142 RID: 4418
		// (get) Token: 0x06003197 RID: 12695 RVA: 0x000E3878 File Offset: 0x000E1A78
		// (set) Token: 0x06003198 RID: 12696 RVA: 0x00013AD0 File Offset: 0x00011CD0
		public unsafe Vector3 serverPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicInstance.NativeFieldInfoPtr_serverPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicInstance.NativeFieldInfoPtr_serverPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001143 RID: 4419
		// (get) Token: 0x06003199 RID: 12697 RVA: 0x000E38A8 File Offset: 0x000E1AA8
		// (set) Token: 0x0600319A RID: 12698 RVA: 0x00013AEF File Offset: 0x00011CEF
		public unsafe Vector3 serverSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicInstance.NativeFieldInfoPtr_serverSize);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicInstance.NativeFieldInfoPtr_serverSize), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001144 RID: 4420
		// (get) Token: 0x0600319B RID: 12699 RVA: 0x000E38D8 File Offset: 0x000E1AD8
		// (set) Token: 0x0600319C RID: 12700 RVA: 0x00013B0E File Offset: 0x00011D0E
		public unsafe Quaternion serverRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicInstance.NativeFieldInfoPtr_serverRotation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Quaternion>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicInstance.NativeFieldInfoPtr_serverRotation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001145 RID: 4421
		// (get) Token: 0x0600319D RID: 12701 RVA: 0x000E3908 File Offset: 0x000E1B08
		// (set) Token: 0x0600319E RID: 12702 RVA: 0x00013B2D File Offset: 0x00011D2D
		public unsafe bool isDirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicInstance.NativeFieldInfoPtr_isDirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicInstance.NativeFieldInfoPtr_isDirty)) = value;
			}
		}

		// Token: 0x17001146 RID: 4422
		// (get) Token: 0x0600319F RID: 12703 RVA: 0x000E3930 File Offset: 0x000E1B30
		// (set) Token: 0x060031A0 RID: 12704 RVA: 0x00013B48 File Offset: 0x00011D48
		public unsafe bool isChildOfPlayerTool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicInstance.NativeFieldInfoPtr_isChildOfPlayerTool);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicInstance.NativeFieldInfoPtr_isChildOfPlayerTool)) = value;
			}
		}

		// Token: 0x17001147 RID: 4423
		// (get) Token: 0x060031A1 RID: 12705 RVA: 0x000E3958 File Offset: 0x000E1B58
		// (set) Token: 0x060031A2 RID: 12706 RVA: 0x00013B63 File Offset: 0x00011D63
		public unsafe Players players
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicInstance.NativeFieldInfoPtr_players);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Players>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicInstance.NativeFieldInfoPtr_players), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001148 RID: 4424
		// (get) Token: 0x060031A3 RID: 12707 RVA: 0x000E3988 File Offset: 0x000E1B88
		// (set) Token: 0x060031A4 RID: 12708 RVA: 0x00013B82 File Offset: 0x00011D82
		public unsafe Action<Vector3, Vector3> _Mirror_SyncVarHookDelegate__velocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicInstance.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate__velocity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Vector3, Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicInstance.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate__velocity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001149 RID: 4425
		// (get) Token: 0x060031A5 RID: 12709 RVA: 0x000E39B8 File Offset: 0x000E1BB8
		// (set) Token: 0x060031A6 RID: 12710 RVA: 0x00013BA1 File Offset: 0x00011DA1
		public unsafe Action<Vector3, Vector3> _Mirror_SyncVarHookDelegate__angularVelocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicInstance.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate__angularVelocity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Vector3, Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicInstance.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate__angularVelocity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700114A RID: 4426
		// (get) Token: 0x060031A7 RID: 12711 RVA: 0x000E39E8 File Offset: 0x000E1BE8
		// (set) Token: 0x060031A8 RID: 12712 RVA: 0x00013BC0 File Offset: 0x00011DC0
		public unsafe Action<bool, bool> _Mirror_SyncVarHookDelegate__isKinematic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicInstance.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate__isKinematic);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicInstance.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate__isKinematic), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700114B RID: 4427
		// (get) Token: 0x060031A9 RID: 12713 RVA: 0x000E3A18 File Offset: 0x000E1C18
		// (set) Token: 0x060031AA RID: 12714 RVA: 0x00013BDF File Offset: 0x00011DDF
		public unsafe Action<bool, bool> _Mirror_SyncVarHookDelegate__useGravity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicInstance.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate__useGravity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicInstance.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate__useGravity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700114C RID: 4428
		// (get) Token: 0x060031AB RID: 12715 RVA: 0x000E3A48 File Offset: 0x000E1C48
		// (set) Token: 0x060031AC RID: 12716 RVA: 0x00013BFE File Offset: 0x00011DFE
		public unsafe Action<float, float> _Mirror_SyncVarHookDelegate__drag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicInstance.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate__drag);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicInstance.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate__drag), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700114D RID: 4429
		// (get) Token: 0x060031AD RID: 12717 RVA: 0x000E3A78 File Offset: 0x000E1C78
		// (set) Token: 0x060031AE RID: 12718 RVA: 0x00013C1D File Offset: 0x00011E1D
		public unsafe Action<float, float> _Mirror_SyncVarHookDelegate__angularDrag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicInstance.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate__angularDrag);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicInstance.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate__angularDrag), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002583 RID: 9603
		private static readonly IntPtr NativeFieldInfoPtr_transformSyncInterval;

		// Token: 0x04002584 RID: 9604
		private static readonly IntPtr NativeFieldInfoPtr_positionThreshold;

		// Token: 0x04002585 RID: 9605
		private static readonly IntPtr NativeFieldInfoPtr_rotationThreshold;

		// Token: 0x04002586 RID: 9606
		private static readonly IntPtr NativeFieldInfoPtr_scaleThreshold;

		// Token: 0x04002587 RID: 9607
		private static readonly IntPtr NativeFieldInfoPtr__rb;

		// Token: 0x04002588 RID: 9608
		private static readonly IntPtr NativeFieldInfoPtr__SyncMode_k__BackingField;

		// Token: 0x04002589 RID: 9609
		private static readonly IntPtr NativeFieldInfoPtr_syncVelocity;

		// Token: 0x0400258A RID: 9610
		private static readonly IntPtr NativeFieldInfoPtr_velocitySensitivity;

		// Token: 0x0400258B RID: 9611
		private static readonly IntPtr NativeFieldInfoPtr_syncAngularVelocity;

		// Token: 0x0400258C RID: 9612
		private static readonly IntPtr NativeFieldInfoPtr_angularVelocitySensitivity;

		// Token: 0x0400258D RID: 9613
		private static readonly IntPtr NativeFieldInfoPtr_timeAlive;

		// Token: 0x0400258E RID: 9614
		private static readonly IntPtr NativeFieldInfoPtr_first;

		// Token: 0x0400258F RID: 9615
		private static readonly IntPtr NativeFieldInfoPtr_requestedTransform;

		// Token: 0x04002590 RID: 9616
		private static readonly IntPtr NativeFieldInfoPtr_MIN_SIZE;

		// Token: 0x04002591 RID: 9617
		private static readonly IntPtr NativeFieldInfoPtr_lastServerSendTime;

		// Token: 0x04002592 RID: 9618
		private static readonly IntPtr NativeFieldInfoPtr__velocity;

		// Token: 0x04002593 RID: 9619
		private static readonly IntPtr NativeFieldInfoPtr__angularVelocity;

		// Token: 0x04002594 RID: 9620
		private static readonly IntPtr NativeFieldInfoPtr__isKinematic;

		// Token: 0x04002595 RID: 9621
		private static readonly IntPtr NativeFieldInfoPtr__useGravity;

		// Token: 0x04002596 RID: 9622
		private static readonly IntPtr NativeFieldInfoPtr__drag;

		// Token: 0x04002597 RID: 9623
		private static readonly IntPtr NativeFieldInfoPtr__angularDrag;

		// Token: 0x04002598 RID: 9624
		private static readonly IntPtr NativeFieldInfoPtr_previousValue;

		// Token: 0x04002599 RID: 9625
		private static readonly IntPtr NativeFieldInfoPtr_lastPos;

		// Token: 0x0400259A RID: 9626
		private static readonly IntPtr NativeFieldInfoPtr_lastSize;

		// Token: 0x0400259B RID: 9627
		private static readonly IntPtr NativeFieldInfoPtr_lastRot;

		// Token: 0x0400259C RID: 9628
		private static readonly IntPtr NativeFieldInfoPtr_serverPosition;

		// Token: 0x0400259D RID: 9629
		private static readonly IntPtr NativeFieldInfoPtr_serverSize;

		// Token: 0x0400259E RID: 9630
		private static readonly IntPtr NativeFieldInfoPtr_serverRotation;

		// Token: 0x0400259F RID: 9631
		private static readonly IntPtr NativeFieldInfoPtr_isDirty;

		// Token: 0x040025A0 RID: 9632
		private static readonly IntPtr NativeFieldInfoPtr_isChildOfPlayerTool;

		// Token: 0x040025A1 RID: 9633
		private static readonly IntPtr NativeFieldInfoPtr_players;

		// Token: 0x040025A2 RID: 9634
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate__velocity;

		// Token: 0x040025A3 RID: 9635
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate__angularVelocity;

		// Token: 0x040025A4 RID: 9636
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate__isKinematic;

		// Token: 0x040025A5 RID: 9637
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate__useGravity;

		// Token: 0x040025A6 RID: 9638
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate__drag;

		// Token: 0x040025A7 RID: 9639
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate__angularDrag;

		// Token: 0x040025A8 RID: 9640
		private static readonly IntPtr NativeMethodInfoPtr_get_DoTransformSync_Protected_Virtual_New_get_Boolean_0;

		// Token: 0x040025A9 RID: 9641
		private static readonly IntPtr NativeMethodInfoPtr_get_SyncMode_Public_get_SyncMode_0;

		// Token: 0x040025AA RID: 9642
		private static readonly IntPtr NativeMethodInfoPtr_set_SyncMode_Public_set_Void_SyncMode_0;

		// Token: 0x040025AB RID: 9643
		private static readonly IntPtr NativeMethodInfoPtr_get_Position_Public_get_Vector3_0;

		// Token: 0x040025AC RID: 9644
		private static readonly IntPtr NativeMethodInfoPtr_set_Position_Public_set_Void_Vector3_0;

		// Token: 0x040025AD RID: 9645
		private static readonly IntPtr NativeMethodInfoPtr_get_Rotation_Public_get_Vector3_0;

		// Token: 0x040025AE RID: 9646
		private static readonly IntPtr NativeMethodInfoPtr_set_Rotation_Public_set_Void_Vector3_0;

		// Token: 0x040025AF RID: 9647
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalPosition_Public_get_Vector3_0;

		// Token: 0x040025B0 RID: 9648
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalPosition_Public_set_Void_Vector3_0;

		// Token: 0x040025B1 RID: 9649
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalRotation_Public_get_Vector3_0;

		// Token: 0x040025B2 RID: 9650
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalRotation_Public_set_Void_Vector3_0;

		// Token: 0x040025B3 RID: 9651
		private static readonly IntPtr NativeMethodInfoPtr_get_Size_Public_get_Vector3_0;

		// Token: 0x040025B4 RID: 9652
		private static readonly IntPtr NativeMethodInfoPtr_set_Size_Public_set_Void_Vector3_0;

		// Token: 0x040025B5 RID: 9653
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalSize_Public_get_Vector3_0;

		// Token: 0x040025B6 RID: 9654
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalSize_Public_set_Void_Vector3_0;

		// Token: 0x040025B7 RID: 9655
		private static readonly IntPtr NativeMethodInfoPtr_get_Quaternion_Public_get_Quaternion_0;

		// Token: 0x040025B8 RID: 9656
		private static readonly IntPtr NativeMethodInfoPtr_set_Quaternion_Public_set_Void_Quaternion_0;

		// Token: 0x040025B9 RID: 9657
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalQuaternion_Public_get_Quaternion_0;

		// Token: 0x040025BA RID: 9658
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalQuaternion_Public_set_Void_Quaternion_0;

		// Token: 0x040025BB RID: 9659
		private static readonly IntPtr NativeMethodInfoPtr_get_Forward_Public_get_Vector3_0;

		// Token: 0x040025BC RID: 9660
		private static readonly IntPtr NativeMethodInfoPtr_get_Right_Public_get_Vector3_0;

		// Token: 0x040025BD RID: 9661
		private static readonly IntPtr NativeMethodInfoPtr_get_Up_Public_get_Vector3_0;

		// Token: 0x040025BE RID: 9662
		private static readonly IntPtr NativeMethodInfoPtr_get_IgnoreSync_Private_get_Boolean_0;

		// Token: 0x040025BF RID: 9663
		private static readonly IntPtr NativeMethodInfoPtr_get_Network_velocity_Public_get_Vector3_0;

		// Token: 0x040025C0 RID: 9664
		private static readonly IntPtr NativeMethodInfoPtr_set_Network_velocity_Public_set_Void_Vector3_0;

		// Token: 0x040025C1 RID: 9665
		private static readonly IntPtr NativeMethodInfoPtr_get_Network_angularVelocity_Public_get_Vector3_0;

		// Token: 0x040025C2 RID: 9666
		private static readonly IntPtr NativeMethodInfoPtr_set_Network_angularVelocity_Public_set_Void_Vector3_0;

		// Token: 0x040025C3 RID: 9667
		private static readonly IntPtr NativeMethodInfoPtr_get_Network_isKinematic_Public_get_Boolean_0;

		// Token: 0x040025C4 RID: 9668
		private static readonly IntPtr NativeMethodInfoPtr_set_Network_isKinematic_Public_set_Void_Boolean_0;

		// Token: 0x040025C5 RID: 9669
		private static readonly IntPtr NativeMethodInfoPtr_get_Network_useGravity_Public_get_Boolean_0;

		// Token: 0x040025C6 RID: 9670
		private static readonly IntPtr NativeMethodInfoPtr_set_Network_useGravity_Public_set_Void_Boolean_0;

		// Token: 0x040025C7 RID: 9671
		private static readonly IntPtr NativeMethodInfoPtr_get_Network_drag_Public_get_Single_0;

		// Token: 0x040025C8 RID: 9672
		private static readonly IntPtr NativeMethodInfoPtr_set_Network_drag_Public_set_Void_Single_0;

		// Token: 0x040025C9 RID: 9673
		private static readonly IntPtr NativeMethodInfoPtr_get_Network_angularDrag_Public_get_Single_0;

		// Token: 0x040025CA RID: 9674
		private static readonly IntPtr NativeMethodInfoPtr_set_Network_angularDrag_Public_set_Void_Single_0;

		// Token: 0x040025CB RID: 9675
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040025CC RID: 9676
		private static readonly IntPtr NativeMethodInfoPtr_OnVelocityChanged_Private_Void_Vector3_Vector3_0;

		// Token: 0x040025CD RID: 9677
		private static readonly IntPtr NativeMethodInfoPtr_OnAngularVelocityChanged_Private_Void_Vector3_Vector3_0;

		// Token: 0x040025CE RID: 9678
		private static readonly IntPtr NativeMethodInfoPtr_OnIsKinematicChanged_Private_Void_Boolean_Boolean_0;

		// Token: 0x040025CF RID: 9679
		private static readonly IntPtr NativeMethodInfoPtr_OnUseGravityChanged_Private_Void_Boolean_Boolean_0;

		// Token: 0x040025D0 RID: 9680
		private static readonly IntPtr NativeMethodInfoPtr_OnDragChanged_Private_Void_Single_Single_0;

		// Token: 0x040025D1 RID: 9681
		private static readonly IntPtr NativeMethodInfoPtr_OnAngularDragChanged_Private_Void_Single_Single_0;

		// Token: 0x040025D2 RID: 9682
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040025D3 RID: 9683
		private static readonly IntPtr NativeMethodInfoPtr_OnGameLoadedLocally_Private_Void_0;

		// Token: 0x040025D4 RID: 9684
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x040025D5 RID: 9685
		private static readonly IntPtr NativeMethodInfoPtr_RequestTransform_Private_Void_0;

		// Token: 0x040025D6 RID: 9686
		private static readonly IntPtr NativeMethodInfoPtr_ApplyTransform_Public_Void_0;

		// Token: 0x040025D7 RID: 9687
		private static readonly IntPtr NativeMethodInfoPtr_CheckIfChildOfPlayerTool_Public_Void_0;

		// Token: 0x040025D8 RID: 9688
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040025D9 RID: 9689
		private static readonly IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0;

		// Token: 0x040025DA RID: 9690
		private static readonly IntPtr NativeMethodInfoPtr_UpdateServer_Private_Void_0;

		// Token: 0x040025DB RID: 9691
		private static readonly IntPtr NativeMethodInfoPtr_UpdateClient_Private_Void_0;

		// Token: 0x040025DC RID: 9692
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x040025DD RID: 9693
		private static readonly IntPtr NativeMethodInfoPtr_HasTransformChanged_Private_Boolean_0;

		// Token: 0x040025DE RID: 9694
		private static readonly IntPtr NativeMethodInfoPtr_CacheTransform_Private_Void_0;

		// Token: 0x040025DF RID: 9695
		private static readonly IntPtr NativeMethodInfoPtr_CopyProperties_Protected_Virtual_Void_Instance_0;

		// Token: 0x040025E0 RID: 9696
		private static readonly IntPtr NativeMethodInfoPtr_SyncPhysics_Private_Void_0;

		// Token: 0x040025E1 RID: 9697
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTransform_Private_Void_0;

		// Token: 0x040025E2 RID: 9698
		private static readonly IntPtr NativeMethodInfoPtr_SyncTransformRecursively_Public_Void_0;

		// Token: 0x040025E3 RID: 9699
		private static readonly IntPtr NativeMethodInfoPtr_RpcSyncTransform_Protected_Void_Vector3_Quaternion_Vector3_0;

		// Token: 0x040025E4 RID: 9700
		private static readonly IntPtr NativeMethodInfoPtr_CmdRequestTransform_Private_Void_NetworkConnectionToClient_0;

		// Token: 0x040025E5 RID: 9701
		private static readonly IntPtr NativeMethodInfoPtr_SetTransformTargetRpc_Private_Void_NetworkConnection_Vector3_Quaternion_Vector3_0;

		// Token: 0x040025E6 RID: 9702
		private static readonly IntPtr NativeMethodInfoPtr_LookAt_Public_Void_Vector3_Vector3_0;

		// Token: 0x040025E7 RID: 9703
		private static readonly IntPtr NativeMethodInfoPtr_LookAt_Public_Void_Vector3_0;

		// Token: 0x040025E8 RID: 9704
		private static readonly IntPtr NativeMethodInfoPtr_LookAt_Public_Void_DynamicInstance_0;

		// Token: 0x040025E9 RID: 9705
		private static readonly IntPtr NativeMethodInfoPtr_Translate_Public_Void_Vector3_0;

		// Token: 0x040025EA RID: 9706
		private static readonly IntPtr NativeMethodInfoPtr_RotateAround_Public_Void_Vector3_Vector3_Single_0;

		// Token: 0x040025EB RID: 9707
		private static readonly IntPtr NativeMethodInfoPtr_Rotate_Public_Void_Vector3_0;

		// Token: 0x040025EC RID: 9708
		private static readonly IntPtr NativeMethodInfoPtr_InverseTransformPoint_Public_Vector3_Vector3_0;

		// Token: 0x040025ED RID: 9709
		private static readonly IntPtr NativeMethodInfoPtr_TransformPoint_Public_Vector3_Vector3_0;

		// Token: 0x040025EE RID: 9710
		private static readonly IntPtr NativeMethodInfoPtr_InverseTransformDirection_Public_Vector3_Vector3_0;

		// Token: 0x040025EF RID: 9711
		private static readonly IntPtr NativeMethodInfoPtr_TransformDirection_Public_Vector3_Vector3_0;

		// Token: 0x040025F0 RID: 9712
		private static readonly IntPtr NativeMethodInfoPtr_InverseTransformVector_Public_Vector3_Vector3_0;

		// Token: 0x040025F1 RID: 9713
		private static readonly IntPtr NativeMethodInfoPtr_TransformVector_Public_Vector3_Vector3_0;

		// Token: 0x040025F2 RID: 9714
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__74_0_Private_Void_0;

		// Token: 0x040025F3 RID: 9715
		private static readonly IntPtr NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0;

		// Token: 0x040025F4 RID: 9716
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcSyncTransform__Vector3__Quaternion__Vector3_Protected_Void_Vector3_Quaternion_Vector3_0;

		// Token: 0x040025F5 RID: 9717
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcSyncTransform__Vector3__Quaternion__Vector3_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x040025F6 RID: 9718
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_CmdRequestTransform__NetworkConnectionToClient_Protected_Void_NetworkConnectionToClient_0;

		// Token: 0x040025F7 RID: 9719
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_CmdRequestTransform__NetworkConnectionToClient_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x040025F8 RID: 9720
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_SetTransformTargetRpc__NetworkConnection__Vector3__Quaternion__Vector3_Protected_Void_NetworkConnection_Vector3_Quaternion_Vector3_0;

		// Token: 0x040025F9 RID: 9721
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_SetTransformTargetRpc__NetworkConnection__Vector3__Quaternion__Vector3_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x040025FA RID: 9722
		private static readonly IntPtr NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0;

		// Token: 0x040025FB RID: 9723
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0;
	}
}
