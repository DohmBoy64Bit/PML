using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Mirror;
using Polytoria.Controllers;
using Polytoria.Lua;
using UnityEngine;
using UnityEngine.AI;

namespace Polytoria.Datamodel
{
	// Token: 0x02000295 RID: 661
	public class NPC : DynamicInstance
	{
		// Token: 0x0600349C RID: 13468 RVA: 0x000EFE60 File Offset: 0x000EE060
		// Note: this type is marked as 'beforefieldinit'.
		static NPC()
		{
			Il2CppClassPointerStore<NPC>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel", "NPC");
			NPC.NativeFieldInfoPtr_ignoreLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "ignoreLayer");
			NPC.NativeFieldInfoPtr_head = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "head");
			NPC.NativeFieldInfoPtr_torso = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "torso");
			NPC.NativeFieldInfoPtr_leftArm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "leftArm");
			NPC.NativeFieldInfoPtr_rightArm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "rightArm");
			NPC.NativeFieldInfoPtr_leftLeg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "leftLeg");
			NPC.NativeFieldInfoPtr_rightLeg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "rightLeg");
			NPC.NativeFieldInfoPtr_deathBodyParts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "deathBodyParts");
			NPC.NativeFieldInfoPtr_toolAttachPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "toolAttachPoint");
			NPC.NativeFieldInfoPtr_maxHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "maxHealth");
			NPC.NativeFieldInfoPtr_health = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "health");
			NPC.NativeFieldInfoPtr_walkSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "walkSpeed");
			NPC.NativeFieldInfoPtr_jumpPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "jumpPower");
			NPC.NativeFieldInfoPtr_shirtID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "shirtID");
			NPC.NativeFieldInfoPtr_pantsID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "pantsID");
			NPC.NativeFieldInfoPtr_faceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "faceID");
			NPC.NativeFieldInfoPtr_anchored = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "anchored");
			NPC.NativeFieldInfoPtr_grounded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "grounded");
			NPC.NativeFieldInfoPtr_rb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "rb");
			NPC.NativeFieldInfoPtr_col = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "col");
			NPC.NativeFieldInfoPtr_anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "anim");
			NPC.NativeFieldInfoPtr_netAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "netAnim");
			NPC.NativeFieldInfoPtr_appearance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "appearance");
			NPC.NativeFieldInfoPtr_agent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "agent");
			NPC.NativeFieldInfoPtr_maxStepHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "maxStepHeight");
			NPC.NativeFieldInfoPtr_stepSearchOvershoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "stepSearchOvershoot");
			NPC.NativeFieldInfoPtr_airMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "airMaterial");
			NPC.NativeFieldInfoPtr_groundMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "groundMaterial");
			NPC.NativeFieldInfoPtr_jumpCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "jumpCooldown");
			NPC.NativeFieldInfoPtr_allCPs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "allCPs");
			NPC.NativeFieldInfoPtr_lastVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "lastVelocity");
			NPC.NativeFieldInfoPtr_defaultBodyPartPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "defaultBodyPartPos");
			NPC.NativeFieldInfoPtr_moveTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "moveTarget");
			NPC.NativeFieldInfoPtr_Died = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "Died");
			NPC.NativeFieldInfoPtr_isDead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC>.NativeClassPtr, "isDead");
			NPC.NativeMethodInfoPtr_get_ToolAttachmentPoint_Public_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671252);
			NPC.NativeMethodInfoPtr_get_MoveTarget_Public_get_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671253);
			NPC.NativeMethodInfoPtr_set_MoveTarget_Public_set_Void_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671254);
			NPC.NativeMethodInfoPtr_get_HeadColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671255);
			NPC.NativeMethodInfoPtr_set_HeadColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671256);
			NPC.NativeMethodInfoPtr_get_TorsoColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671257);
			NPC.NativeMethodInfoPtr_set_TorsoColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671258);
			NPC.NativeMethodInfoPtr_get_LeftArmColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671259);
			NPC.NativeMethodInfoPtr_set_LeftArmColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671260);
			NPC.NativeMethodInfoPtr_get_RightArmColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671261);
			NPC.NativeMethodInfoPtr_set_RightArmColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671262);
			NPC.NativeMethodInfoPtr_get_LeftLegColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671263);
			NPC.NativeMethodInfoPtr_set_LeftLegColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671264);
			NPC.NativeMethodInfoPtr_get_RightLegColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671265);
			NPC.NativeMethodInfoPtr_set_RightLegColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671266);
			NPC.NativeMethodInfoPtr_get_Anchored_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671267);
			NPC.NativeMethodInfoPtr_set_Anchored_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671268);
			NPC.NativeMethodInfoPtr_get_NavDestinationDistance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671269);
			NPC.NativeMethodInfoPtr_get_NavDestinationReached_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671270);
			NPC.NativeMethodInfoPtr_get_NavDestinationValid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671271);
			NPC.NativeMethodInfoPtr_get_Health_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671272);
			NPC.NativeMethodInfoPtr_set_Health_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671273);
			NPC.NativeMethodInfoPtr_get_MaxHealth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671274);
			NPC.NativeMethodInfoPtr_set_MaxHealth_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671275);
			NPC.NativeMethodInfoPtr_get_WalkSpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671276);
			NPC.NativeMethodInfoPtr_set_WalkSpeed_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671277);
			NPC.NativeMethodInfoPtr_get_JumpPower_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671278);
			NPC.NativeMethodInfoPtr_set_JumpPower_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671279);
			NPC.NativeMethodInfoPtr_get_ShirtID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671280);
			NPC.NativeMethodInfoPtr_set_ShirtID_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671281);
			NPC.NativeMethodInfoPtr_get_PantsID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671282);
			NPC.NativeMethodInfoPtr_set_PantsID_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671283);
			NPC.NativeMethodInfoPtr_get_FaceID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671284);
			NPC.NativeMethodInfoPtr_set_FaceID_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671285);
			NPC.NativeMethodInfoPtr_get_Velocity_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671286);
			NPC.NativeMethodInfoPtr_set_Velocity_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671287);
			NPC.NativeMethodInfoPtr_get_Grounded_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671289);
			NPC.NativeMethodInfoPtr_get_NetworkmaxHealth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671326);
			NPC.NativeMethodInfoPtr_set_NetworkmaxHealth_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671327);
			NPC.NativeMethodInfoPtr_get_Networkhealth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671328);
			NPC.NativeMethodInfoPtr_set_Networkhealth_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671329);
			NPC.NativeMethodInfoPtr_get_NetworkwalkSpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671330);
			NPC.NativeMethodInfoPtr_set_NetworkwalkSpeed_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671331);
			NPC.NativeMethodInfoPtr_get_NetworkjumpPower_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671332);
			NPC.NativeMethodInfoPtr_set_NetworkjumpPower_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671333);
			NPC.NativeMethodInfoPtr_get_Networkanchored_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671334);
			NPC.NativeMethodInfoPtr_set_Networkanchored_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671335);
			NPC.NativeMethodInfoPtr_get_Networkgrounded_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671336);
			NPC.NativeMethodInfoPtr_set_Networkgrounded_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671337);
			NPC.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671320);
			NPC.NativeMethodInfoPtr_RpcSetWalkSpeed_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671288);
			NPC.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671290);
			NPC.NativeMethodInfoPtr_OnNetworkStart_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671291);
			NPC.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671292);
			NPC.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671293);
			NPC.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671294);
			NPC.NativeMethodInfoPtr_SetNavDestination_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671295);
			NPC.NativeMethodInfoPtr_Die_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671296);
			NPC.NativeMethodInfoPtr_RpcSetAnimatorActive_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671297);
			NPC.NativeMethodInfoPtr_SetAnimatorActive_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671298);
			NPC.NativeMethodInfoPtr_Respawn_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671299);
			NPC.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671300);
			NPC.NativeMethodInfoPtr_MoveDirection_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671301);
			NPC.NativeMethodInfoPtr_OnCollisionStay_Private_Void_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671302);
			NPC.NativeMethodInfoPtr_FindGround_Private_Boolean_byref_ContactPoint_List_1_ContactPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671303);
			NPC.NativeMethodInfoPtr_FindStep_Private_Boolean_byref_Vector3_List_1_ContactPoint_ContactPoint_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671304);
			NPC.NativeMethodInfoPtr_ResolveStepUp_Private_Boolean_byref_Vector3_ContactPoint_ContactPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671305);
			NPC.NativeMethodInfoPtr_IsGrounded_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671306);
			NPC.NativeMethodInfoPtr_Jump_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671307);
			NPC.NativeMethodInfoPtr_LoadAppearance_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671308);
			NPC.NativeMethodInfoPtr_ClearAppearance_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671309);
			NPC.NativeMethodInfoPtr_GetEquippedTool_Public_Tool_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671310);
			NPC.NativeMethodInfoPtr_EquipTool_Public_Void_Tool_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671311);
			NPC.NativeMethodInfoPtr_DropTool_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671312);
			NPC.NativeMethodInfoPtr_PlayAnim_Public_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671313);
			NPC.NativeMethodInfoPtr_PlayAnimTargetRpc_Public_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671314);
			NPC.NativeMethodInfoPtr_RpcJumpSound_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671315);
			NPC.NativeMethodInfoPtr_CopyProperties_Protected_Virtual_Void_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671316);
			NPC.NativeMethodInfoPtr_RpcSetAnchored_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671317);
			NPC.NativeMethodInfoPtr_OnHide_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671318);
			NPC.NativeMethodInfoPtr_OnShow_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671319);
			NPC.NativeMethodInfoPtr__set_ShirtID_b__79_0_Private_Void_ImageCacheKey_ImageCacheEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671321);
			NPC.NativeMethodInfoPtr__set_PantsID_b__82_0_Private_Void_ImageCacheKey_ImageCacheEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671322);
			NPC.NativeMethodInfoPtr__set_FaceID_b__85_0_Private_Void_ImageCacheKey_ImageCacheEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671323);
			NPC.NativeMethodInfoPtr_Method_Private_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671324);
			NPC.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671325);
			NPC.NativeMethodInfoPtr_UserCode_RpcSetWalkSpeed__Single_Protected_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671338);
			NPC.NativeMethodInfoPtr_InvokeUserCode_RpcSetWalkSpeed__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671339);
			NPC.NativeMethodInfoPtr_UserCode_RpcSetAnimatorActive__Boolean_Protected_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671340);
			NPC.NativeMethodInfoPtr_InvokeUserCode_RpcSetAnimatorActive__Boolean_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671341);
			NPC.NativeMethodInfoPtr_UserCode_PlayAnimTargetRpc__String_Protected_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671342);
			NPC.NativeMethodInfoPtr_InvokeUserCode_PlayAnimTargetRpc__String_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671343);
			NPC.NativeMethodInfoPtr_UserCode_RpcJumpSound_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671344);
			NPC.NativeMethodInfoPtr_InvokeUserCode_RpcJumpSound_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671345);
			NPC.NativeMethodInfoPtr_UserCode_RpcSetAnchored__Boolean_Protected_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671346);
			NPC.NativeMethodInfoPtr_InvokeUserCode_RpcSetAnchored__Boolean_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671347);
			NPC.NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671349);
			NPC.NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC>.NativeClassPtr, 100671350);
		}

		// Token: 0x17001265 RID: 4709
		// (get) Token: 0x0600349D RID: 13469 RVA: 0x000F08EC File Offset: 0x000EEAEC
		public unsafe virtual Transform ToolAttachmentPoint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_get_ToolAttachmentPoint_Public_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x17001266 RID: 4710
		// (get) Token: 0x0600349E RID: 13470 RVA: 0x000F092C File Offset: 0x000EEB2C
		// (set) Token: 0x0600349F RID: 13471 RVA: 0x000F096C File Offset: 0x000EEB6C
		public unsafe Instance MoveTarget
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_get_MoveTarget_Public_get_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instance>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 107312, RefRangeEnd = 107313, XrefRangeStart = 107309, XrefRangeEnd = 107312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_set_MoveTarget_Public_set_Void_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001267 RID: 4711
		// (get) Token: 0x060034A0 RID: 13472 RVA: 0x000F09B0 File Offset: 0x000EEBB0
		// (set) Token: 0x060034A1 RID: 13473 RVA: 0x000F09F0 File Offset: 0x000EEBF0
		public unsafe Color HeadColor
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 107318, RefRangeEnd = 107319, XrefRangeStart = 107313, XrefRangeEnd = 107318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_get_HeadColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 107325, RefRangeEnd = 107328, XrefRangeStart = 107319, XrefRangeEnd = 107325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_set_HeadColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001268 RID: 4712
		// (get) Token: 0x060034A2 RID: 13474 RVA: 0x000F0A34 File Offset: 0x000EEC34
		// (set) Token: 0x060034A3 RID: 13475 RVA: 0x000F0A74 File Offset: 0x000EEC74
		public unsafe Color TorsoColor
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 107333, RefRangeEnd = 107334, XrefRangeStart = 107328, XrefRangeEnd = 107333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_get_TorsoColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 107340, RefRangeEnd = 107343, XrefRangeStart = 107334, XrefRangeEnd = 107340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_set_TorsoColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001269 RID: 4713
		// (get) Token: 0x060034A4 RID: 13476 RVA: 0x000F0AB8 File Offset: 0x000EECB8
		// (set) Token: 0x060034A5 RID: 13477 RVA: 0x000F0AF8 File Offset: 0x000EECF8
		public unsafe Color LeftArmColor
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 107348, RefRangeEnd = 107349, XrefRangeStart = 107343, XrefRangeEnd = 107348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_get_LeftArmColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 107355, RefRangeEnd = 107358, XrefRangeStart = 107349, XrefRangeEnd = 107355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_set_LeftArmColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700126A RID: 4714
		// (get) Token: 0x060034A6 RID: 13478 RVA: 0x000F0B3C File Offset: 0x000EED3C
		// (set) Token: 0x060034A7 RID: 13479 RVA: 0x000F0B7C File Offset: 0x000EED7C
		public unsafe Color RightArmColor
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 107363, RefRangeEnd = 107364, XrefRangeStart = 107358, XrefRangeEnd = 107363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_get_RightArmColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 107370, RefRangeEnd = 107373, XrefRangeStart = 107364, XrefRangeEnd = 107370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_set_RightArmColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700126B RID: 4715
		// (get) Token: 0x060034A8 RID: 13480 RVA: 0x000F0BC0 File Offset: 0x000EEDC0
		// (set) Token: 0x060034A9 RID: 13481 RVA: 0x000F0C00 File Offset: 0x000EEE00
		public unsafe Color LeftLegColor
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 107378, RefRangeEnd = 107379, XrefRangeStart = 107373, XrefRangeEnd = 107378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_get_LeftLegColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 107385, RefRangeEnd = 107388, XrefRangeStart = 107379, XrefRangeEnd = 107385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_set_LeftLegColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700126C RID: 4716
		// (get) Token: 0x060034AA RID: 13482 RVA: 0x000F0C44 File Offset: 0x000EEE44
		// (set) Token: 0x060034AB RID: 13483 RVA: 0x000F0C84 File Offset: 0x000EEE84
		public unsafe Color RightLegColor
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 107393, RefRangeEnd = 107394, XrefRangeStart = 107388, XrefRangeEnd = 107393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_get_RightLegColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 107400, RefRangeEnd = 107403, XrefRangeStart = 107394, XrefRangeEnd = 107400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_set_RightLegColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700126D RID: 4717
		// (get) Token: 0x060034AC RID: 13484 RVA: 0x000F0CC8 File Offset: 0x000EEEC8
		// (set) Token: 0x060034AD RID: 13485 RVA: 0x000F0D04 File Offset: 0x000EEF04
		public unsafe bool Anchored
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_get_Anchored_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 107438, RefRangeEnd = 107444, XrefRangeStart = 107403, XrefRangeEnd = 107438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_set_Anchored_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700126E RID: 4718
		// (get) Token: 0x060034AE RID: 13486 RVA: 0x000F0D44 File Offset: 0x000EEF44
		public unsafe float NavDestinationDistance
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 107448, RefRangeEnd = 107449, XrefRangeStart = 107444, XrefRangeEnd = 107448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_get_NavDestinationDistance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700126F RID: 4719
		// (get) Token: 0x060034AF RID: 13487 RVA: 0x000F0D80 File Offset: 0x000EEF80
		public unsafe bool NavDestinationReached
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 107455, RefRangeEnd = 107456, XrefRangeStart = 107449, XrefRangeEnd = 107455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_get_NavDestinationReached_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001270 RID: 4720
		// (get) Token: 0x060034B0 RID: 13488 RVA: 0x000F0DBC File Offset: 0x000EEFBC
		public unsafe bool NavDestinationValid
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 107464, RefRangeEnd = 107465, XrefRangeStart = 107456, XrefRangeEnd = 107464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_get_NavDestinationValid_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001271 RID: 4721
		// (get) Token: 0x060034B1 RID: 13489 RVA: 0x000F0DF8 File Offset: 0x000EEFF8
		// (set) Token: 0x060034B2 RID: 13490 RVA: 0x000F0E34 File Offset: 0x000EF034
		public unsafe float Health
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_get_Health_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 107471, RefRangeEnd = 107475, XrefRangeStart = 107465, XrefRangeEnd = 107471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_set_Health_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001272 RID: 4722
		// (get) Token: 0x060034B3 RID: 13491 RVA: 0x000F0E74 File Offset: 0x000EF074
		// (set) Token: 0x060034B4 RID: 13492 RVA: 0x000F0EB0 File Offset: 0x000EF0B0
		public unsafe float MaxHealth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_get_MaxHealth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 107481, RefRangeEnd = 107482, XrefRangeStart = 107475, XrefRangeEnd = 107481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_set_MaxHealth_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001273 RID: 4723
		// (get) Token: 0x060034B5 RID: 13493 RVA: 0x000F0EF0 File Offset: 0x000EF0F0
		// (set) Token: 0x060034B6 RID: 13494 RVA: 0x000F0F2C File Offset: 0x000EF12C
		public unsafe float WalkSpeed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_get_WalkSpeed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 107509, RefRangeEnd = 107513, XrefRangeStart = 107482, XrefRangeEnd = 107509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_set_WalkSpeed_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001274 RID: 4724
		// (get) Token: 0x060034B7 RID: 13495 RVA: 0x000F0F6C File Offset: 0x000EF16C
		// (set) Token: 0x060034B8 RID: 13496 RVA: 0x000F0FA8 File Offset: 0x000EF1A8
		public unsafe float JumpPower
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_get_JumpPower_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 107519, RefRangeEnd = 107520, XrefRangeStart = 107513, XrefRangeEnd = 107519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_set_JumpPower_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001275 RID: 4725
		// (get) Token: 0x060034B9 RID: 13497 RVA: 0x000F0FE8 File Offset: 0x000EF1E8
		// (set) Token: 0x060034BA RID: 13498 RVA: 0x000F1024 File Offset: 0x000EF224
		public unsafe int ShirtID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_get_ShirtID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 107540, RefRangeEnd = 107544, XrefRangeStart = 107520, XrefRangeEnd = 107540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_set_ShirtID_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001276 RID: 4726
		// (get) Token: 0x060034BB RID: 13499 RVA: 0x000F1064 File Offset: 0x000EF264
		// (set) Token: 0x060034BC RID: 13500 RVA: 0x000F10A0 File Offset: 0x000EF2A0
		public unsafe int PantsID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_get_PantsID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 107564, RefRangeEnd = 107568, XrefRangeStart = 107544, XrefRangeEnd = 107564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_set_PantsID_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001277 RID: 4727
		// (get) Token: 0x060034BD RID: 13501 RVA: 0x000F10E0 File Offset: 0x000EF2E0
		// (set) Token: 0x060034BE RID: 13502 RVA: 0x000F111C File Offset: 0x000EF31C
		public unsafe int FaceID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_get_FaceID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 107588, RefRangeEnd = 107592, XrefRangeStart = 107568, XrefRangeEnd = 107588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_set_FaceID_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001278 RID: 4728
		// (get) Token: 0x060034BF RID: 13503 RVA: 0x000F115C File Offset: 0x000EF35C
		// (set) Token: 0x060034C0 RID: 13504 RVA: 0x000F119C File Offset: 0x000EF39C
		public unsafe Vector3 Velocity
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 107593, RefRangeEnd = 107594, XrefRangeStart = 107592, XrefRangeEnd = 107593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_get_Velocity_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 107595, RefRangeEnd = 107596, XrefRangeStart = 107594, XrefRangeEnd = 107595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_set_Velocity_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001279 RID: 4729
		// (get) Token: 0x060034C1 RID: 13505 RVA: 0x000F11E0 File Offset: 0x000EF3E0
		public unsafe bool Grounded
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_get_Grounded_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700127A RID: 4730
		// (get) Token: 0x060034C2 RID: 13506 RVA: 0x000F121C File Offset: 0x000EF41C
		// (set) Token: 0x060034C3 RID: 13507 RVA: 0x000F1258 File Offset: 0x000EF458
		public unsafe float NetworkmaxHealth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_get_NetworkmaxHealth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 107481, RefRangeEnd = 107482, XrefRangeStart = 107481, XrefRangeEnd = 107482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_set_NetworkmaxHealth_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700127B RID: 4731
		// (get) Token: 0x060034C4 RID: 13508 RVA: 0x000F1298 File Offset: 0x000EF498
		// (set) Token: 0x060034C5 RID: 13509 RVA: 0x000F12D4 File Offset: 0x000EF4D4
		public unsafe float Networkhealth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_get_Networkhealth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 107471, RefRangeEnd = 107475, XrefRangeStart = 107471, XrefRangeEnd = 107475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_set_Networkhealth_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700127C RID: 4732
		// (get) Token: 0x060034C6 RID: 13510 RVA: 0x000F1314 File Offset: 0x000EF514
		// (set) Token: 0x060034C7 RID: 13511 RVA: 0x000F1350 File Offset: 0x000EF550
		public unsafe float NetworkwalkSpeed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_get_NetworkwalkSpeed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107596, XrefRangeEnd = 107602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_set_NetworkwalkSpeed_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700127D RID: 4733
		// (get) Token: 0x060034C8 RID: 13512 RVA: 0x000F1390 File Offset: 0x000EF590
		// (set) Token: 0x060034C9 RID: 13513 RVA: 0x000F13CC File Offset: 0x000EF5CC
		public unsafe float NetworkjumpPower
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_get_NetworkjumpPower_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 107519, RefRangeEnd = 107520, XrefRangeStart = 107519, XrefRangeEnd = 107520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_set_NetworkjumpPower_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700127E RID: 4734
		// (get) Token: 0x060034CA RID: 13514 RVA: 0x000F140C File Offset: 0x000EF60C
		// (set) Token: 0x060034CB RID: 13515 RVA: 0x000F1448 File Offset: 0x000EF648
		public unsafe bool Networkanchored
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_get_Networkanchored_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107602, XrefRangeEnd = 107608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_set_Networkanchored_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700127F RID: 4735
		// (get) Token: 0x060034CC RID: 13516 RVA: 0x000F1488 File Offset: 0x000EF688
		// (set) Token: 0x060034CD RID: 13517 RVA: 0x000F14C4 File Offset: 0x000EF6C4
		public unsafe bool Networkgrounded
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_get_Networkgrounded_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107608, XrefRangeEnd = 107614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_set_Networkgrounded_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060034CE RID: 13518 RVA: 0x000F1504 File Offset: 0x000EF704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107614, XrefRangeEnd = 107637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPC()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPC>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034CF RID: 13519 RVA: 0x000F1540 File Offset: 0x000EF740
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107637, XrefRangeEnd = 107658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcSetWalkSpeed(float walkSpeed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref walkSpeed;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcSetWalkSpeed_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034D0 RID: 13520 RVA: 0x000F1580 File Offset: 0x000EF780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107658, XrefRangeEnd = 107683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPC.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034D1 RID: 13521 RVA: 0x000F15BC File Offset: 0x000EF7BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107683, XrefRangeEnd = 107714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnNetworkStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPC.NativeMethodInfoPtr_OnNetworkStart_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034D2 RID: 13522 RVA: 0x000F15F8 File Offset: 0x000EF7F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107714, XrefRangeEnd = 107764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPC.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034D3 RID: 13523 RVA: 0x000F1634 File Offset: 0x000EF834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107764, XrefRangeEnd = 107767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPC.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034D4 RID: 13524 RVA: 0x000F1670 File Offset: 0x000EF870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107767, XrefRangeEnd = 107797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPC.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034D5 RID: 13525 RVA: 0x000F16AC File Offset: 0x000EF8AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 107803, RefRangeEnd = 107804, XrefRangeStart = 107797, XrefRangeEnd = 107803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNavDestination(Vector3 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_SetNavDestination_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034D6 RID: 13526 RVA: 0x000F16F0 File Offset: 0x000EF8F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 107863, RefRangeEnd = 107864, XrefRangeStart = 107804, XrefRangeEnd = 107863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Die()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_Die_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034D7 RID: 13527 RVA: 0x000F1724 File Offset: 0x000EF924
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 107885, RefRangeEnd = 107887, XrefRangeStart = 107864, XrefRangeEnd = 107885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcSetAnimatorActive(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref active;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcSetAnimatorActive_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034D8 RID: 13528 RVA: 0x000F1764 File Offset: 0x000EF964
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 107932, RefRangeEnd = 107935, XrefRangeStart = 107887, XrefRangeEnd = 107932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAnimatorActive(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref active;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_SetAnimatorActive_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034D9 RID: 13529 RVA: 0x000F17A4 File Offset: 0x000EF9A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 107985, RefRangeEnd = 107986, XrefRangeStart = 107935, XrefRangeEnd = 107985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Respawn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_Respawn_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034DA RID: 13530 RVA: 0x000F17D8 File Offset: 0x000EF9D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107986, XrefRangeEnd = 107998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034DB RID: 13531 RVA: 0x000F180C File Offset: 0x000EFA0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107998, XrefRangeEnd = 108024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveDirection(Vector3 dir)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dir);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_MoveDirection_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034DC RID: 13532 RVA: 0x000F1850 File Offset: 0x000EFA50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108024, XrefRangeEnd = 108029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCollisionStay(Collision col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(col);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_OnCollisionStay_Private_Void_Collision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034DD RID: 13533 RVA: 0x000F1894 File Offset: 0x000EFA94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108029, XrefRangeEnd = 108046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool FindGround(out ContactPoint groundCP, List<ContactPoint> allCPs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &groundCP;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(allCPs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_FindGround_Private_Boolean_byref_ContactPoint_List_1_ContactPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060034DE RID: 13534 RVA: 0x000F18F0 File Offset: 0x000EFAF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108046, XrefRangeEnd = 108063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool FindStep(out Vector3 stepUpOffset, List<ContactPoint> allCPs, ContactPoint groundCP, Vector3 currVelocity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &stepUpOffset;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(allCPs);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(groundCP);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(currVelocity);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_FindStep_Private_Boolean_byref_Vector3_List_1_ContactPoint_ContactPoint_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060034DF RID: 13535 RVA: 0x000F1970 File Offset: 0x000EFB70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 108088, RefRangeEnd = 108089, XrefRangeStart = 108063, XrefRangeEnd = 108088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ResolveStepUp(out Vector3 stepUpOffset, ContactPoint stepTestCP, ContactPoint groundCP)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &stepUpOffset;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stepTestCP);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(groundCP);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_ResolveStepUp_Private_Boolean_byref_Vector3_ContactPoint_ContactPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060034E0 RID: 13536 RVA: 0x000F19E0 File Offset: 0x000EFBE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 108137, RefRangeEnd = 108138, XrefRangeStart = 108089, XrefRangeEnd = 108137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsGrounded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_IsGrounded_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060034E1 RID: 13537 RVA: 0x000F1A1C File Offset: 0x000EFC1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 108159, RefRangeEnd = 108160, XrefRangeStart = 108138, XrefRangeEnd = 108159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Jump()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_Jump_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034E2 RID: 13538 RVA: 0x000F1A50 File Offset: 0x000EFC50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 108162, RefRangeEnd = 108163, XrefRangeStart = 108160, XrefRangeEnd = 108162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadAppearance(int userID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref userID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_LoadAppearance_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034E3 RID: 13539 RVA: 0x000F1A90 File Offset: 0x000EFC90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 108164, RefRangeEnd = 108165, XrefRangeStart = 108163, XrefRangeEnd = 108164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearAppearance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_ClearAppearance_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034E4 RID: 13540 RVA: 0x000F1AC4 File Offset: 0x000EFCC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108165, XrefRangeEnd = 108168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Tool GetEquippedTool()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_GetEquippedTool_Public_Tool_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tool>(intPtr3) : null;
		}

		// Token: 0x060034E5 RID: 13541 RVA: 0x000F1B04 File Offset: 0x000EFD04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 108187, RefRangeEnd = 108188, XrefRangeStart = 108168, XrefRangeEnd = 108187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EquipTool(Tool tool)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tool);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_EquipTool_Public_Void_Tool_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034E6 RID: 13542 RVA: 0x000F1B48 File Offset: 0x000EFD48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 108208, RefRangeEnd = 108209, XrefRangeStart = 108188, XrefRangeEnd = 108208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DropTool()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_DropTool_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034E7 RID: 13543 RVA: 0x000F1B7C File Offset: 0x000EFD7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108209, XrefRangeEnd = 108225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PlayAnim(string _anim)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(_anim);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_PlayAnim_Public_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034E8 RID: 13544 RVA: 0x000F1BC0 File Offset: 0x000EFDC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108225, XrefRangeEnd = 108246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PlayAnimTargetRpc(string _anim)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(_anim);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_PlayAnimTargetRpc_Public_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034E9 RID: 13545 RVA: 0x000F1C04 File Offset: 0x000EFE04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108246, XrefRangeEnd = 108266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcJumpSound()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcJumpSound_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034EA RID: 13546 RVA: 0x000F1C38 File Offset: 0x000EFE38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108266, XrefRangeEnd = 108353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CopyProperties(Instance clone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clone);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPC.NativeMethodInfoPtr_CopyProperties_Protected_Virtual_Void_Instance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034EB RID: 13547 RVA: 0x000F1C88 File Offset: 0x000EFE88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108353, XrefRangeEnd = 108374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcSetAnchored(bool a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_RpcSetAnchored_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034EC RID: 13548 RVA: 0x000F1CC8 File Offset: 0x000EFEC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108374, XrefRangeEnd = 108400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnHide()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPC.NativeMethodInfoPtr_OnHide_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034ED RID: 13549 RVA: 0x000F1D04 File Offset: 0x000EFF04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108400, XrefRangeEnd = 108427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnShow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPC.NativeMethodInfoPtr_OnShow_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034EE RID: 13550 RVA: 0x000F1D40 File Offset: 0x000EFF40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108427, XrefRangeEnd = 108442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _set_ShirtID_b__79_0(ImageCacheKey key, ImageCacheEntry entry)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(entry);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr__set_ShirtID_b__79_0_Private_Void_ImageCacheKey_ImageCacheEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034EF RID: 13551 RVA: 0x000F1D94 File Offset: 0x000EFF94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108442, XrefRangeEnd = 108453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _set_PantsID_b__82_0(ImageCacheKey key, ImageCacheEntry entry)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(entry);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr__set_PantsID_b__82_0_Private_Void_ImageCacheKey_ImageCacheEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034F0 RID: 13552 RVA: 0x000F1DE8 File Offset: 0x000EFFE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108453, XrefRangeEnd = 108465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _set_FaceID_b__85_0(ImageCacheKey key, ImageCacheEntry entry)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(entry);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr__set_FaceID_b__85_0_Private_Void_ImageCacheKey_ImageCacheEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034F1 RID: 13553 RVA: 0x000F1E3C File Offset: 0x000F003C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108465, XrefRangeEnd = 108481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_Method_Private_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034F2 RID: 13554 RVA: 0x000F1E70 File Offset: 0x000F0070
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 20124, RefRangeEnd = 20136, XrefRangeStart = 20124, XrefRangeEnd = 20136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Weaved()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPC.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060034F3 RID: 13555 RVA: 0x000F1EB8 File Offset: 0x000F00B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108481, XrefRangeEnd = 108483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcSetWalkSpeed__Single(float walkSpeed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref walkSpeed;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_UserCode_RpcSetWalkSpeed__Single_Protected_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034F4 RID: 13556 RVA: 0x000F1EF8 File Offset: 0x000F00F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108483, XrefRangeEnd = 108494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RpcSetWalkSpeed__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_InvokeUserCode_RpcSetWalkSpeed__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034F5 RID: 13557 RVA: 0x000F1F54 File Offset: 0x000F0154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108494, XrefRangeEnd = 108496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcSetAnimatorActive__Boolean(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref active;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_UserCode_RpcSetAnimatorActive__Boolean_Protected_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034F6 RID: 13558 RVA: 0x000F1F94 File Offset: 0x000F0194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108496, XrefRangeEnd = 108511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RpcSetAnimatorActive__Boolean(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_InvokeUserCode_RpcSetAnimatorActive__Boolean_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034F7 RID: 13559 RVA: 0x000F1FF0 File Offset: 0x000F01F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UserCode_PlayAnimTargetRpc__String(string _anim)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(_anim);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_UserCode_PlayAnimTargetRpc__String_Protected_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034F8 RID: 13560 RVA: 0x000F2034 File Offset: 0x000F0234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108511, XrefRangeEnd = 108540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_PlayAnimTargetRpc__String(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_InvokeUserCode_PlayAnimTargetRpc__String_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034F9 RID: 13561 RVA: 0x000F2090 File Offset: 0x000F0290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108540, XrefRangeEnd = 108547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcJumpSound()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_UserCode_RpcJumpSound_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034FA RID: 13562 RVA: 0x000F20C4 File Offset: 0x000F02C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108547, XrefRangeEnd = 108567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RpcJumpSound(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_InvokeUserCode_RpcJumpSound_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034FB RID: 13563 RVA: 0x000F2120 File Offset: 0x000F0320
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108567, XrefRangeEnd = 108569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcSetAnchored__Boolean(bool a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_UserCode_RpcSetAnchored__Boolean_Protected_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034FC RID: 13564 RVA: 0x000F2160 File Offset: 0x000F0360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108569, XrefRangeEnd = 108584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RpcSetAnchored__Boolean(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.NativeMethodInfoPtr_InvokeUserCode_RpcSetAnchored__Boolean_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034FD RID: 13565 RVA: 0x000F21BC File Offset: 0x000F03BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108584, XrefRangeEnd = 108598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPC.NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034FE RID: 13566 RVA: 0x000F2218 File Offset: 0x000F0418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108598, XrefRangeEnd = 108636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPC.NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034FF RID: 13567 RVA: 0x00014B47 File Offset: 0x00012D47
		public NPC(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001242 RID: 4674
		// (get) Token: 0x06003500 RID: 13568 RVA: 0x000F2274 File Offset: 0x000F0474
		// (set) Token: 0x06003501 RID: 13569 RVA: 0x00014B50 File Offset: 0x00012D50
		public unsafe LayerMask ignoreLayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_ignoreLayer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LayerMask>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_ignoreLayer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001243 RID: 4675
		// (get) Token: 0x06003502 RID: 13570 RVA: 0x000F22A4 File Offset: 0x000F04A4
		// (set) Token: 0x06003503 RID: 13571 RVA: 0x00014B6F File Offset: 0x00012D6F
		public unsafe GameObject head
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_head);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_head), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001244 RID: 4676
		// (get) Token: 0x06003504 RID: 13572 RVA: 0x000F22D4 File Offset: 0x000F04D4
		// (set) Token: 0x06003505 RID: 13573 RVA: 0x00014B8E File Offset: 0x00012D8E
		public unsafe GameObject torso
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_torso);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_torso), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001245 RID: 4677
		// (get) Token: 0x06003506 RID: 13574 RVA: 0x000F2304 File Offset: 0x000F0504
		// (set) Token: 0x06003507 RID: 13575 RVA: 0x00014BAD File Offset: 0x00012DAD
		public unsafe GameObject leftArm
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_leftArm);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_leftArm), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001246 RID: 4678
		// (get) Token: 0x06003508 RID: 13576 RVA: 0x000F2334 File Offset: 0x000F0534
		// (set) Token: 0x06003509 RID: 13577 RVA: 0x00014BCC File Offset: 0x00012DCC
		public unsafe GameObject rightArm
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_rightArm);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_rightArm), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001247 RID: 4679
		// (get) Token: 0x0600350A RID: 13578 RVA: 0x000F2364 File Offset: 0x000F0564
		// (set) Token: 0x0600350B RID: 13579 RVA: 0x00014BEB File Offset: 0x00012DEB
		public unsafe GameObject leftLeg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_leftLeg);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_leftLeg), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001248 RID: 4680
		// (get) Token: 0x0600350C RID: 13580 RVA: 0x000F2394 File Offset: 0x000F0594
		// (set) Token: 0x0600350D RID: 13581 RVA: 0x00014C0A File Offset: 0x00012E0A
		public unsafe GameObject rightLeg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_rightLeg);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_rightLeg), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001249 RID: 4681
		// (get) Token: 0x0600350E RID: 13582 RVA: 0x000F23C4 File Offset: 0x000F05C4
		// (set) Token: 0x0600350F RID: 13583 RVA: 0x00014C29 File Offset: 0x00012E29
		public unsafe List<Rigidbody> deathBodyParts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_deathBodyParts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Rigidbody>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_deathBodyParts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700124A RID: 4682
		// (get) Token: 0x06003510 RID: 13584 RVA: 0x000F23F4 File Offset: 0x000F05F4
		// (set) Token: 0x06003511 RID: 13585 RVA: 0x00014C48 File Offset: 0x00012E48
		public unsafe Transform toolAttachPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_toolAttachPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_toolAttachPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700124B RID: 4683
		// (get) Token: 0x06003512 RID: 13586 RVA: 0x000F2424 File Offset: 0x000F0624
		// (set) Token: 0x06003513 RID: 13587 RVA: 0x00014C67 File Offset: 0x00012E67
		public unsafe float maxHealth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_maxHealth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_maxHealth)) = value;
			}
		}

		// Token: 0x1700124C RID: 4684
		// (get) Token: 0x06003514 RID: 13588 RVA: 0x000F244C File Offset: 0x000F064C
		// (set) Token: 0x06003515 RID: 13589 RVA: 0x00014C82 File Offset: 0x00012E82
		public unsafe float health
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_health);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_health)) = value;
			}
		}

		// Token: 0x1700124D RID: 4685
		// (get) Token: 0x06003516 RID: 13590 RVA: 0x000F2474 File Offset: 0x000F0674
		// (set) Token: 0x06003517 RID: 13591 RVA: 0x00014C9D File Offset: 0x00012E9D
		public unsafe float walkSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_walkSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_walkSpeed)) = value;
			}
		}

		// Token: 0x1700124E RID: 4686
		// (get) Token: 0x06003518 RID: 13592 RVA: 0x000F249C File Offset: 0x000F069C
		// (set) Token: 0x06003519 RID: 13593 RVA: 0x00014CB8 File Offset: 0x00012EB8
		public unsafe float jumpPower
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_jumpPower);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_jumpPower)) = value;
			}
		}

		// Token: 0x1700124F RID: 4687
		// (get) Token: 0x0600351A RID: 13594 RVA: 0x000F24C4 File Offset: 0x000F06C4
		// (set) Token: 0x0600351B RID: 13595 RVA: 0x00014CD3 File Offset: 0x00012ED3
		public unsafe int shirtID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_shirtID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_shirtID)) = value;
			}
		}

		// Token: 0x17001250 RID: 4688
		// (get) Token: 0x0600351C RID: 13596 RVA: 0x000F24EC File Offset: 0x000F06EC
		// (set) Token: 0x0600351D RID: 13597 RVA: 0x00014CEE File Offset: 0x00012EEE
		public unsafe int pantsID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_pantsID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_pantsID)) = value;
			}
		}

		// Token: 0x17001251 RID: 4689
		// (get) Token: 0x0600351E RID: 13598 RVA: 0x000F2514 File Offset: 0x000F0714
		// (set) Token: 0x0600351F RID: 13599 RVA: 0x00014D09 File Offset: 0x00012F09
		public unsafe int faceID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_faceID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_faceID)) = value;
			}
		}

		// Token: 0x17001252 RID: 4690
		// (get) Token: 0x06003520 RID: 13600 RVA: 0x000F253C File Offset: 0x000F073C
		// (set) Token: 0x06003521 RID: 13601 RVA: 0x00014D24 File Offset: 0x00012F24
		public unsafe bool anchored
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_anchored);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_anchored)) = value;
			}
		}

		// Token: 0x17001253 RID: 4691
		// (get) Token: 0x06003522 RID: 13602 RVA: 0x000F2564 File Offset: 0x000F0764
		// (set) Token: 0x06003523 RID: 13603 RVA: 0x00014D3F File Offset: 0x00012F3F
		public unsafe bool grounded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_grounded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_grounded)) = value;
			}
		}

		// Token: 0x17001254 RID: 4692
		// (get) Token: 0x06003524 RID: 13604 RVA: 0x000F258C File Offset: 0x000F078C
		// (set) Token: 0x06003525 RID: 13605 RVA: 0x00014D5A File Offset: 0x00012F5A
		public unsafe Rigidbody rb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_rb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_rb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001255 RID: 4693
		// (get) Token: 0x06003526 RID: 13606 RVA: 0x000F25BC File Offset: 0x000F07BC
		// (set) Token: 0x06003527 RID: 13607 RVA: 0x00014D79 File Offset: 0x00012F79
		public unsafe Collider col
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_col);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_col), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001256 RID: 4694
		// (get) Token: 0x06003528 RID: 13608 RVA: 0x000F25EC File Offset: 0x000F07EC
		// (set) Token: 0x06003529 RID: 13609 RVA: 0x00014D98 File Offset: 0x00012F98
		public unsafe Animator anim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_anim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001257 RID: 4695
		// (get) Token: 0x0600352A RID: 13610 RVA: 0x000F261C File Offset: 0x000F081C
		// (set) Token: 0x0600352B RID: 13611 RVA: 0x00014DB7 File Offset: 0x00012FB7
		public unsafe NetworkAnimator netAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_netAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkAnimator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_netAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001258 RID: 4696
		// (get) Token: 0x0600352C RID: 13612 RVA: 0x000F264C File Offset: 0x000F084C
		// (set) Token: 0x0600352D RID: 13613 RVA: 0x00014DD6 File Offset: 0x00012FD6
		public unsafe NPCAppearance appearance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_appearance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCAppearance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_appearance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001259 RID: 4697
		// (get) Token: 0x0600352E RID: 13614 RVA: 0x000F267C File Offset: 0x000F087C
		// (set) Token: 0x0600352F RID: 13615 RVA: 0x00014DF5 File Offset: 0x00012FF5
		public unsafe NavMeshAgent agent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_agent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NavMeshAgent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_agent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700125A RID: 4698
		// (get) Token: 0x06003530 RID: 13616 RVA: 0x000F26AC File Offset: 0x000F08AC
		// (set) Token: 0x06003531 RID: 13617 RVA: 0x00014E14 File Offset: 0x00013014
		public unsafe float maxStepHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_maxStepHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_maxStepHeight)) = value;
			}
		}

		// Token: 0x1700125B RID: 4699
		// (get) Token: 0x06003532 RID: 13618 RVA: 0x000F26D4 File Offset: 0x000F08D4
		// (set) Token: 0x06003533 RID: 13619 RVA: 0x00014E2F File Offset: 0x0001302F
		public unsafe float stepSearchOvershoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_stepSearchOvershoot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_stepSearchOvershoot)) = value;
			}
		}

		// Token: 0x1700125C RID: 4700
		// (get) Token: 0x06003534 RID: 13620 RVA: 0x000F26FC File Offset: 0x000F08FC
		// (set) Token: 0x06003535 RID: 13621 RVA: 0x00014E4A File Offset: 0x0001304A
		public unsafe PhysicsMaterial airMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_airMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhysicsMaterial>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_airMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700125D RID: 4701
		// (get) Token: 0x06003536 RID: 13622 RVA: 0x000F272C File Offset: 0x000F092C
		// (set) Token: 0x06003537 RID: 13623 RVA: 0x00014E69 File Offset: 0x00013069
		public unsafe PhysicsMaterial groundMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_groundMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhysicsMaterial>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_groundMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700125E RID: 4702
		// (get) Token: 0x06003538 RID: 13624 RVA: 0x000F275C File Offset: 0x000F095C
		// (set) Token: 0x06003539 RID: 13625 RVA: 0x00014E88 File Offset: 0x00013088
		public unsafe float jumpCooldown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_jumpCooldown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_jumpCooldown)) = value;
			}
		}

		// Token: 0x1700125F RID: 4703
		// (get) Token: 0x0600353A RID: 13626 RVA: 0x000F2784 File Offset: 0x000F0984
		// (set) Token: 0x0600353B RID: 13627 RVA: 0x00014EA3 File Offset: 0x000130A3
		public unsafe List<ContactPoint> allCPs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_allCPs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ContactPoint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_allCPs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001260 RID: 4704
		// (get) Token: 0x0600353C RID: 13628 RVA: 0x000F27B4 File Offset: 0x000F09B4
		// (set) Token: 0x0600353D RID: 13629 RVA: 0x00014EC2 File Offset: 0x000130C2
		public unsafe Vector3 lastVelocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_lastVelocity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_lastVelocity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001261 RID: 4705
		// (get) Token: 0x0600353E RID: 13630 RVA: 0x000F27E4 File Offset: 0x000F09E4
		// (set) Token: 0x0600353F RID: 13631 RVA: 0x00014EE1 File Offset: 0x000130E1
		public unsafe Dictionary<Rigidbody, Vector3> defaultBodyPartPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_defaultBodyPartPos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Rigidbody, Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_defaultBodyPartPos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001262 RID: 4706
		// (get) Token: 0x06003540 RID: 13632 RVA: 0x000F2814 File Offset: 0x000F0A14
		// (set) Token: 0x06003541 RID: 13633 RVA: 0x00014F00 File Offset: 0x00013100
		public unsafe Instance moveTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_moveTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_moveTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001263 RID: 4707
		// (get) Token: 0x06003542 RID: 13634 RVA: 0x000F2844 File Offset: 0x000F0A44
		// (set) Token: 0x06003543 RID: 13635 RVA: 0x00014F1F File Offset: 0x0001311F
		public unsafe LuaEvent Died
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_Died);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LuaEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_Died), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001264 RID: 4708
		// (get) Token: 0x06003544 RID: 13636 RVA: 0x000F2874 File Offset: 0x000F0A74
		// (set) Token: 0x06003545 RID: 13637 RVA: 0x00014F3E File Offset: 0x0001313E
		public unsafe bool isDead
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_isDead);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPC.NativeFieldInfoPtr_isDead)) = value;
			}
		}

		// Token: 0x04002871 RID: 10353
		private static readonly IntPtr NativeFieldInfoPtr_ignoreLayer;

		// Token: 0x04002872 RID: 10354
		private static readonly IntPtr NativeFieldInfoPtr_head;

		// Token: 0x04002873 RID: 10355
		private static readonly IntPtr NativeFieldInfoPtr_torso;

		// Token: 0x04002874 RID: 10356
		private static readonly IntPtr NativeFieldInfoPtr_leftArm;

		// Token: 0x04002875 RID: 10357
		private static readonly IntPtr NativeFieldInfoPtr_rightArm;

		// Token: 0x04002876 RID: 10358
		private static readonly IntPtr NativeFieldInfoPtr_leftLeg;

		// Token: 0x04002877 RID: 10359
		private static readonly IntPtr NativeFieldInfoPtr_rightLeg;

		// Token: 0x04002878 RID: 10360
		private static readonly IntPtr NativeFieldInfoPtr_deathBodyParts;

		// Token: 0x04002879 RID: 10361
		private static readonly IntPtr NativeFieldInfoPtr_toolAttachPoint;

		// Token: 0x0400287A RID: 10362
		private static readonly IntPtr NativeFieldInfoPtr_maxHealth;

		// Token: 0x0400287B RID: 10363
		private static readonly IntPtr NativeFieldInfoPtr_health;

		// Token: 0x0400287C RID: 10364
		private static readonly IntPtr NativeFieldInfoPtr_walkSpeed;

		// Token: 0x0400287D RID: 10365
		private static readonly IntPtr NativeFieldInfoPtr_jumpPower;

		// Token: 0x0400287E RID: 10366
		private static readonly IntPtr NativeFieldInfoPtr_shirtID;

		// Token: 0x0400287F RID: 10367
		private static readonly IntPtr NativeFieldInfoPtr_pantsID;

		// Token: 0x04002880 RID: 10368
		private static readonly IntPtr NativeFieldInfoPtr_faceID;

		// Token: 0x04002881 RID: 10369
		private static readonly IntPtr NativeFieldInfoPtr_anchored;

		// Token: 0x04002882 RID: 10370
		private static readonly IntPtr NativeFieldInfoPtr_grounded;

		// Token: 0x04002883 RID: 10371
		private static readonly IntPtr NativeFieldInfoPtr_rb;

		// Token: 0x04002884 RID: 10372
		private static readonly IntPtr NativeFieldInfoPtr_col;

		// Token: 0x04002885 RID: 10373
		private static readonly IntPtr NativeFieldInfoPtr_anim;

		// Token: 0x04002886 RID: 10374
		private static readonly IntPtr NativeFieldInfoPtr_netAnim;

		// Token: 0x04002887 RID: 10375
		private static readonly IntPtr NativeFieldInfoPtr_appearance;

		// Token: 0x04002888 RID: 10376
		private static readonly IntPtr NativeFieldInfoPtr_agent;

		// Token: 0x04002889 RID: 10377
		private static readonly IntPtr NativeFieldInfoPtr_maxStepHeight;

		// Token: 0x0400288A RID: 10378
		private static readonly IntPtr NativeFieldInfoPtr_stepSearchOvershoot;

		// Token: 0x0400288B RID: 10379
		private static readonly IntPtr NativeFieldInfoPtr_airMaterial;

		// Token: 0x0400288C RID: 10380
		private static readonly IntPtr NativeFieldInfoPtr_groundMaterial;

		// Token: 0x0400288D RID: 10381
		private static readonly IntPtr NativeFieldInfoPtr_jumpCooldown;

		// Token: 0x0400288E RID: 10382
		private static readonly IntPtr NativeFieldInfoPtr_allCPs;

		// Token: 0x0400288F RID: 10383
		private static readonly IntPtr NativeFieldInfoPtr_lastVelocity;

		// Token: 0x04002890 RID: 10384
		private static readonly IntPtr NativeFieldInfoPtr_defaultBodyPartPos;

		// Token: 0x04002891 RID: 10385
		private static readonly IntPtr NativeFieldInfoPtr_moveTarget;

		// Token: 0x04002892 RID: 10386
		private static readonly IntPtr NativeFieldInfoPtr_Died;

		// Token: 0x04002893 RID: 10387
		private static readonly IntPtr NativeFieldInfoPtr_isDead;

		// Token: 0x04002894 RID: 10388
		private static readonly IntPtr NativeMethodInfoPtr_get_ToolAttachmentPoint_Public_Virtual_Final_New_get_Transform_0;

		// Token: 0x04002895 RID: 10389
		private static readonly IntPtr NativeMethodInfoPtr_get_MoveTarget_Public_get_Instance_0;

		// Token: 0x04002896 RID: 10390
		private static readonly IntPtr NativeMethodInfoPtr_set_MoveTarget_Public_set_Void_Instance_0;

		// Token: 0x04002897 RID: 10391
		private static readonly IntPtr NativeMethodInfoPtr_get_HeadColor_Public_get_Color_0;

		// Token: 0x04002898 RID: 10392
		private static readonly IntPtr NativeMethodInfoPtr_set_HeadColor_Public_set_Void_Color_0;

		// Token: 0x04002899 RID: 10393
		private static readonly IntPtr NativeMethodInfoPtr_get_TorsoColor_Public_get_Color_0;

		// Token: 0x0400289A RID: 10394
		private static readonly IntPtr NativeMethodInfoPtr_set_TorsoColor_Public_set_Void_Color_0;

		// Token: 0x0400289B RID: 10395
		private static readonly IntPtr NativeMethodInfoPtr_get_LeftArmColor_Public_get_Color_0;

		// Token: 0x0400289C RID: 10396
		private static readonly IntPtr NativeMethodInfoPtr_set_LeftArmColor_Public_set_Void_Color_0;

		// Token: 0x0400289D RID: 10397
		private static readonly IntPtr NativeMethodInfoPtr_get_RightArmColor_Public_get_Color_0;

		// Token: 0x0400289E RID: 10398
		private static readonly IntPtr NativeMethodInfoPtr_set_RightArmColor_Public_set_Void_Color_0;

		// Token: 0x0400289F RID: 10399
		private static readonly IntPtr NativeMethodInfoPtr_get_LeftLegColor_Public_get_Color_0;

		// Token: 0x040028A0 RID: 10400
		private static readonly IntPtr NativeMethodInfoPtr_set_LeftLegColor_Public_set_Void_Color_0;

		// Token: 0x040028A1 RID: 10401
		private static readonly IntPtr NativeMethodInfoPtr_get_RightLegColor_Public_get_Color_0;

		// Token: 0x040028A2 RID: 10402
		private static readonly IntPtr NativeMethodInfoPtr_set_RightLegColor_Public_set_Void_Color_0;

		// Token: 0x040028A3 RID: 10403
		private static readonly IntPtr NativeMethodInfoPtr_get_Anchored_Public_get_Boolean_0;

		// Token: 0x040028A4 RID: 10404
		private static readonly IntPtr NativeMethodInfoPtr_set_Anchored_Public_set_Void_Boolean_0;

		// Token: 0x040028A5 RID: 10405
		private static readonly IntPtr NativeMethodInfoPtr_get_NavDestinationDistance_Public_get_Single_0;

		// Token: 0x040028A6 RID: 10406
		private static readonly IntPtr NativeMethodInfoPtr_get_NavDestinationReached_Public_get_Boolean_0;

		// Token: 0x040028A7 RID: 10407
		private static readonly IntPtr NativeMethodInfoPtr_get_NavDestinationValid_Public_get_Boolean_0;

		// Token: 0x040028A8 RID: 10408
		private static readonly IntPtr NativeMethodInfoPtr_get_Health_Public_get_Single_0;

		// Token: 0x040028A9 RID: 10409
		private static readonly IntPtr NativeMethodInfoPtr_set_Health_Public_set_Void_Single_0;

		// Token: 0x040028AA RID: 10410
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxHealth_Public_get_Single_0;

		// Token: 0x040028AB RID: 10411
		private static readonly IntPtr NativeMethodInfoPtr_set_MaxHealth_Public_set_Void_Single_0;

		// Token: 0x040028AC RID: 10412
		private static readonly IntPtr NativeMethodInfoPtr_get_WalkSpeed_Public_get_Single_0;

		// Token: 0x040028AD RID: 10413
		private static readonly IntPtr NativeMethodInfoPtr_set_WalkSpeed_Public_set_Void_Single_0;

		// Token: 0x040028AE RID: 10414
		private static readonly IntPtr NativeMethodInfoPtr_get_JumpPower_Public_get_Single_0;

		// Token: 0x040028AF RID: 10415
		private static readonly IntPtr NativeMethodInfoPtr_set_JumpPower_Public_set_Void_Single_0;

		// Token: 0x040028B0 RID: 10416
		private static readonly IntPtr NativeMethodInfoPtr_get_ShirtID_Public_get_Int32_0;

		// Token: 0x040028B1 RID: 10417
		private static readonly IntPtr NativeMethodInfoPtr_set_ShirtID_Public_set_Void_Int32_0;

		// Token: 0x040028B2 RID: 10418
		private static readonly IntPtr NativeMethodInfoPtr_get_PantsID_Public_get_Int32_0;

		// Token: 0x040028B3 RID: 10419
		private static readonly IntPtr NativeMethodInfoPtr_set_PantsID_Public_set_Void_Int32_0;

		// Token: 0x040028B4 RID: 10420
		private static readonly IntPtr NativeMethodInfoPtr_get_FaceID_Public_get_Int32_0;

		// Token: 0x040028B5 RID: 10421
		private static readonly IntPtr NativeMethodInfoPtr_set_FaceID_Public_set_Void_Int32_0;

		// Token: 0x040028B6 RID: 10422
		private static readonly IntPtr NativeMethodInfoPtr_get_Velocity_Public_get_Vector3_0;

		// Token: 0x040028B7 RID: 10423
		private static readonly IntPtr NativeMethodInfoPtr_set_Velocity_Public_set_Void_Vector3_0;

		// Token: 0x040028B8 RID: 10424
		private static readonly IntPtr NativeMethodInfoPtr_get_Grounded_Public_get_Boolean_0;

		// Token: 0x040028B9 RID: 10425
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkmaxHealth_Public_get_Single_0;

		// Token: 0x040028BA RID: 10426
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkmaxHealth_Public_set_Void_Single_0;

		// Token: 0x040028BB RID: 10427
		private static readonly IntPtr NativeMethodInfoPtr_get_Networkhealth_Public_get_Single_0;

		// Token: 0x040028BC RID: 10428
		private static readonly IntPtr NativeMethodInfoPtr_set_Networkhealth_Public_set_Void_Single_0;

		// Token: 0x040028BD RID: 10429
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkwalkSpeed_Public_get_Single_0;

		// Token: 0x040028BE RID: 10430
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkwalkSpeed_Public_set_Void_Single_0;

		// Token: 0x040028BF RID: 10431
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkjumpPower_Public_get_Single_0;

		// Token: 0x040028C0 RID: 10432
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkjumpPower_Public_set_Void_Single_0;

		// Token: 0x040028C1 RID: 10433
		private static readonly IntPtr NativeMethodInfoPtr_get_Networkanchored_Public_get_Boolean_0;

		// Token: 0x040028C2 RID: 10434
		private static readonly IntPtr NativeMethodInfoPtr_set_Networkanchored_Public_set_Void_Boolean_0;

		// Token: 0x040028C3 RID: 10435
		private static readonly IntPtr NativeMethodInfoPtr_get_Networkgrounded_Public_get_Boolean_0;

		// Token: 0x040028C4 RID: 10436
		private static readonly IntPtr NativeMethodInfoPtr_set_Networkgrounded_Public_set_Void_Boolean_0;

		// Token: 0x040028C5 RID: 10437
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040028C6 RID: 10438
		private static readonly IntPtr NativeMethodInfoPtr_RpcSetWalkSpeed_Private_Void_Single_0;

		// Token: 0x040028C7 RID: 10439
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040028C8 RID: 10440
		private static readonly IntPtr NativeMethodInfoPtr_OnNetworkStart_Protected_Virtual_Void_0;

		// Token: 0x040028C9 RID: 10441
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040028CA RID: 10442
		private static readonly IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0;

		// Token: 0x040028CB RID: 10443
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x040028CC RID: 10444
		private static readonly IntPtr NativeMethodInfoPtr_SetNavDestination_Public_Void_Vector3_0;

		// Token: 0x040028CD RID: 10445
		private static readonly IntPtr NativeMethodInfoPtr_Die_Private_Void_0;

		// Token: 0x040028CE RID: 10446
		private static readonly IntPtr NativeMethodInfoPtr_RpcSetAnimatorActive_Private_Void_Boolean_0;

		// Token: 0x040028CF RID: 10447
		private static readonly IntPtr NativeMethodInfoPtr_SetAnimatorActive_Private_Void_Boolean_0;

		// Token: 0x040028D0 RID: 10448
		private static readonly IntPtr NativeMethodInfoPtr_Respawn_Public_Void_0;

		// Token: 0x040028D1 RID: 10449
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x040028D2 RID: 10450
		private static readonly IntPtr NativeMethodInfoPtr_MoveDirection_Private_Void_Vector3_0;

		// Token: 0x040028D3 RID: 10451
		private static readonly IntPtr NativeMethodInfoPtr_OnCollisionStay_Private_Void_Collision_0;

		// Token: 0x040028D4 RID: 10452
		private static readonly IntPtr NativeMethodInfoPtr_FindGround_Private_Boolean_byref_ContactPoint_List_1_ContactPoint_0;

		// Token: 0x040028D5 RID: 10453
		private static readonly IntPtr NativeMethodInfoPtr_FindStep_Private_Boolean_byref_Vector3_List_1_ContactPoint_ContactPoint_Vector3_0;

		// Token: 0x040028D6 RID: 10454
		private static readonly IntPtr NativeMethodInfoPtr_ResolveStepUp_Private_Boolean_byref_Vector3_ContactPoint_ContactPoint_0;

		// Token: 0x040028D7 RID: 10455
		private static readonly IntPtr NativeMethodInfoPtr_IsGrounded_Private_Boolean_0;

		// Token: 0x040028D8 RID: 10456
		private static readonly IntPtr NativeMethodInfoPtr_Jump_Public_Void_0;

		// Token: 0x040028D9 RID: 10457
		private static readonly IntPtr NativeMethodInfoPtr_LoadAppearance_Public_Void_Int32_0;

		// Token: 0x040028DA RID: 10458
		private static readonly IntPtr NativeMethodInfoPtr_ClearAppearance_Public_Void_0;

		// Token: 0x040028DB RID: 10459
		private static readonly IntPtr NativeMethodInfoPtr_GetEquippedTool_Public_Tool_0;

		// Token: 0x040028DC RID: 10460
		private static readonly IntPtr NativeMethodInfoPtr_EquipTool_Public_Void_Tool_0;

		// Token: 0x040028DD RID: 10461
		private static readonly IntPtr NativeMethodInfoPtr_DropTool_Public_Void_0;

		// Token: 0x040028DE RID: 10462
		private static readonly IntPtr NativeMethodInfoPtr_PlayAnim_Public_Virtual_Final_New_Void_String_0;

		// Token: 0x040028DF RID: 10463
		private static readonly IntPtr NativeMethodInfoPtr_PlayAnimTargetRpc_Public_Virtual_Final_New_Void_String_0;

		// Token: 0x040028E0 RID: 10464
		private static readonly IntPtr NativeMethodInfoPtr_RpcJumpSound_Private_Void_0;

		// Token: 0x040028E1 RID: 10465
		private static readonly IntPtr NativeMethodInfoPtr_CopyProperties_Protected_Virtual_Void_Instance_0;

		// Token: 0x040028E2 RID: 10466
		private static readonly IntPtr NativeMethodInfoPtr_RpcSetAnchored_Private_Void_Boolean_0;

		// Token: 0x040028E3 RID: 10467
		private static readonly IntPtr NativeMethodInfoPtr_OnHide_Protected_Virtual_Void_0;

		// Token: 0x040028E4 RID: 10468
		private static readonly IntPtr NativeMethodInfoPtr_OnShow_Protected_Virtual_Void_0;

		// Token: 0x040028E5 RID: 10469
		private static readonly IntPtr NativeMethodInfoPtr__set_ShirtID_b__79_0_Private_Void_ImageCacheKey_ImageCacheEntry_0;

		// Token: 0x040028E6 RID: 10470
		private static readonly IntPtr NativeMethodInfoPtr__set_PantsID_b__82_0_Private_Void_ImageCacheKey_ImageCacheEntry_0;

		// Token: 0x040028E7 RID: 10471
		private static readonly IntPtr NativeMethodInfoPtr__set_FaceID_b__85_0_Private_Void_ImageCacheKey_ImageCacheEntry_0;

		// Token: 0x040028E8 RID: 10472
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_PDM_0;

		// Token: 0x040028E9 RID: 10473
		private static readonly IntPtr NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0;

		// Token: 0x040028EA RID: 10474
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcSetWalkSpeed__Single_Protected_Void_Single_0;

		// Token: 0x040028EB RID: 10475
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcSetWalkSpeed__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x040028EC RID: 10476
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcSetAnimatorActive__Boolean_Protected_Void_Boolean_0;

		// Token: 0x040028ED RID: 10477
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcSetAnimatorActive__Boolean_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x040028EE RID: 10478
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_PlayAnimTargetRpc__String_Protected_Virtual_Final_New_Void_String_0;

		// Token: 0x040028EF RID: 10479
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_PlayAnimTargetRpc__String_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x040028F0 RID: 10480
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcJumpSound_Protected_Void_0;

		// Token: 0x040028F1 RID: 10481
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcJumpSound_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x040028F2 RID: 10482
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcSetAnchored__Boolean_Protected_Void_Boolean_0;

		// Token: 0x040028F3 RID: 10483
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcSetAnchored__Boolean_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x040028F4 RID: 10484
		private static readonly IntPtr NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0;

		// Token: 0x040028F5 RID: 10485
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0;

		// Token: 0x020003F8 RID: 1016
		[ObfuscatedName("Polytoria.Datamodel.NPC+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06004E19 RID: 19993 RVA: 0x00152400 File Offset: 0x00150600
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<NPC.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPC>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPC.__c>.NativeClassPtr);
				NPC.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC.__c>.NativeClassPtr, "<>9");
				NPC.__c.NativeFieldInfoPtr___9__110_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPC.__c>.NativeClassPtr, "<>9__110_0");
				NPC.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC.__c>.NativeClassPtr, 100671352);
				NPC.__c.NativeMethodInfoPtr__IsGrounded_b__110_0_Internal_Boolean_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPC.__c>.NativeClassPtr, 100671353);
			}

			// Token: 0x06004E1A RID: 19994 RVA: 0x0015247C File Offset: 0x0015067C
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPC.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004E1B RID: 19995 RVA: 0x001524B8 File Offset: 0x001506B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107308, XrefRangeEnd = 107309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _IsGrounded_b__110_0(Collider i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(i);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPC.__c.NativeMethodInfoPtr__IsGrounded_b__110_0_Internal_Boolean_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004E1C RID: 19996 RVA: 0x0001D99A File Offset: 0x0001BB9A
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001A50 RID: 6736
			// (get) Token: 0x06004E1D RID: 19997 RVA: 0x00152508 File Offset: 0x00150708
			// (set) Token: 0x06004E1E RID: 19998 RVA: 0x0001D9A3 File Offset: 0x0001BBA3
			public unsafe static NPC.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NPC.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NPC.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A51 RID: 6737
			// (get) Token: 0x06004E1F RID: 19999 RVA: 0x00152530 File Offset: 0x00150730
			// (set) Token: 0x06004E20 RID: 20000 RVA: 0x0001D9B5 File Offset: 0x0001BBB5
			public unsafe static Func<Collider, bool> __9__110_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NPC.__c.NativeFieldInfoPtr___9__110_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Collider, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NPC.__c.NativeFieldInfoPtr___9__110_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003C8A RID: 15498
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04003C8B RID: 15499
			private static readonly IntPtr NativeFieldInfoPtr___9__110_0;

			// Token: 0x04003C8C RID: 15500
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003C8D RID: 15501
			private static readonly IntPtr NativeMethodInfoPtr__IsGrounded_b__110_0_Internal_Boolean_Collider_0;
		}
	}
}
