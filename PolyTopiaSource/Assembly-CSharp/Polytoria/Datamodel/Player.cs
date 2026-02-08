using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Mirror;
using MoonSharp.Interpreter;
using Polytoria.Controllers;
using Polytoria.Datamodel.Services;
using Polytoria.Lua;
using Polytoria.Types;
using TMPro;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Networking;

namespace Polytoria.Datamodel
{
	// Token: 0x0200029E RID: 670
	public class Player : Instance
	{
		// Token: 0x06003714 RID: 14100 RVA: 0x000FA208 File Offset: 0x000F8408
		// Note: this type is marked as 'beforefieldinit'.
		static Player()
		{
			Il2CppClassPointerStore<Player>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel", "Player");
			Player.NativeFieldInfoPtr_kicked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "kicked");
			Player.NativeFieldInfoPtr_maxRequestsPerMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "maxRequestsPerMin");
			Player.NativeFieldInfoPtr_hatCheckCacheLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "hatCheckCacheLength");
			Player.NativeFieldInfoPtr_keyCodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "keyCodes");
			Player.NativeFieldInfoPtr_footstepSounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "footstepSounds");
			Player.NativeFieldInfoPtr_footstepInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "footstepInterval");
			Player.NativeFieldInfoPtr_footstepTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "footstepTimer");
			Player.NativeFieldInfoPtr_footstepIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "footstepIndex");
			Player.NativeFieldInfoPtr_footstepPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "footstepPlayer");
			Player.NativeFieldInfoPtr_parentConstraint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "parentConstraint");
			Player.NativeFieldInfoPtr_maxHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "maxHealth");
			Player.NativeFieldInfoPtr_walkSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "walkSpeed");
			Player.NativeFieldInfoPtr_sprintSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "sprintSpeed");
			Player.NativeFieldInfoPtr_health = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "health");
			Player.NativeFieldInfoPtr_isSprinting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "isSprinting");
			Player.NativeFieldInfoPtr_sprintExhausted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "sprintExhausted");
			Player.NativeFieldInfoPtr_staminaEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "staminaEnabled");
			Player.NativeFieldInfoPtr_stamina = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "stamina");
			Player.NativeFieldInfoPtr_maxStamina = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "maxStamina");
			Player.NativeFieldInfoPtr_staminaRegen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "staminaRegen");
			Player.NativeFieldInfoPtr_jumpPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "jumpPower");
			Player.NativeFieldInfoPtr_respawnTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "respawnTime");
			Player.NativeFieldInfoPtr_userID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "userID");
			Player.NativeFieldInfoPtr_loaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "loaded");
			Player.NativeFieldInfoPtr_isCreator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "isCreator");
			Player.NativeFieldInfoPtr_isAdmin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "isAdmin");
			Player.NativeFieldInfoPtr_chatColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "chatColor");
			Player.NativeFieldInfoPtr_avatarHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "avatarHash");
			Player.NativeFieldInfoPtr_canMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "canMove");
			Player.NativeFieldInfoPtr_anchored = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "anchored");
			Player.NativeFieldInfoPtr_LeaderboardBadgeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "LeaderboardBadgeId");
			Player.NativeFieldInfoPtr_canChat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "canChat");
			Player.NativeFieldInfoPtr_isAgeRestricted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "isAgeRestricted");
			Player.NativeFieldInfoPtr_turnSmoothing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "turnSmoothing");
			Player.NativeFieldInfoPtr_ignoreLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "ignoreLayer");
			Player.NativeFieldInfoPtr_anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "anim");
			Player.NativeFieldInfoPtr_rb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "rb");
			Player.NativeFieldInfoPtr_disableOnFP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "disableOnFP");
			Player.NativeFieldInfoPtr_deathBodyParts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "deathBodyParts");
			Player.NativeFieldInfoPtr_toolAttachPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "toolAttachPoint");
			Player.NativeFieldInfoPtr_camAttachment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "camAttachment");
			Player.NativeFieldInfoPtr_shirtID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "shirtID");
			Player.NativeFieldInfoPtr_pantsID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "pantsID");
			Player.NativeFieldInfoPtr_faceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "faceID");
			Player.NativeFieldInfoPtr_coyoteTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "coyoteTime");
			Player.NativeFieldInfoPtr_coyoteTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "coyoteTimer");
			Player.NativeFieldInfoPtr_col = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "col");
			Player.NativeFieldInfoPtr_airMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "airMaterial");
			Player.NativeFieldInfoPtr_groundMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "groundMaterial");
			Player.NativeFieldInfoPtr_defaultBodyPartPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "defaultBodyPartPos");
			Player.NativeFieldInfoPtr_head = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "head");
			Player.NativeFieldInfoPtr_leftArm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "leftArm");
			Player.NativeFieldInfoPtr_rightArm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "rightArm");
			Player.NativeFieldInfoPtr_torso = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "torso");
			Player.NativeFieldInfoPtr_leftLeg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "leftLeg");
			Player.NativeFieldInfoPtr_rightLeg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "rightLeg");
			Player.NativeFieldInfoPtr_netAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "netAnim");
			Player.NativeFieldInfoPtr_maxStepHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "maxStepHeight");
			Player.NativeFieldInfoPtr_stepSearchOvershoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "stepSearchOvershoot");
			Player.NativeFieldInfoPtr_allCPs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "allCPs");
			Player.NativeFieldInfoPtr_lastVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "lastVelocity");
			Player.NativeFieldInfoPtr_afkTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "afkTimer");
			Player.NativeFieldInfoPtr_maxAfkTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "maxAfkTime");
			Player.NativeFieldInfoPtr_isDead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "isDead");
			Player.NativeFieldInfoPtr_jumpCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "jumpCooldown");
			Player.NativeFieldInfoPtr_currentSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "currentSpeed");
			Player.NativeFieldInfoPtr_nametag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "nametag");
			Player.NativeFieldInfoPtr_oldPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "oldPos");
			Player.NativeFieldInfoPtr_sittingIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "sittingIn");
			Player.NativeFieldInfoPtr_Chatted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "Chatted");
			Player.NativeFieldInfoPtr_Died = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "Died");
			Player.NativeFieldInfoPtr_Respawned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "Respawned");
			Player.NativeFieldInfoPtr__env = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "_env");
			Player.NativeFieldInfoPtr_assetOwnCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "assetOwnCache");
			Player.NativeFieldInfoPtr_assetCacheCheckTimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "assetCacheCheckTimes");
			Player.NativeFieldInfoPtr_assetCheckCounts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "assetCheckCounts");
			Player.NativeFieldInfoPtr_defaultFov = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "defaultFov");
			Player.NativeFieldInfoPtr_sprintFov = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "sprintFov");
			Player.NativeFieldInfoPtr_appearance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "appearance");
			Player.NativeFieldInfoPtr_cam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "cam");
			Player.NativeFieldInfoPtr_climbing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "climbing");
			Player.NativeFieldInfoPtr_isEmote = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "isEmote");
			Player.NativeFieldInfoPtr____sittingInNetId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player>.NativeClassPtr, "___sittingInNetId");
			Player.NativeMethodInfoPtr_get_IsLocalPlayer_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671644);
			Player.NativeMethodInfoPtr_get_IsLoaded_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671645);
			Player.NativeMethodInfoPtr_get_RespawnTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671646);
			Player.NativeMethodInfoPtr_set_RespawnTime_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671647);
			Player.NativeMethodInfoPtr_get_Velocity_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671648);
			Player.NativeMethodInfoPtr_set_Velocity_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671649);
			Player.NativeMethodInfoPtr_get_MaxHealth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671650);
			Player.NativeMethodInfoPtr_set_MaxHealth_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671651);
			Player.NativeMethodInfoPtr_get_Health_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671652);
			Player.NativeMethodInfoPtr_set_Health_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671653);
			Player.NativeMethodInfoPtr_get_WalkSpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671654);
			Player.NativeMethodInfoPtr_set_WalkSpeed_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671655);
			Player.NativeMethodInfoPtr_get_SprintSpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671656);
			Player.NativeMethodInfoPtr_set_SprintSpeed_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671657);
			Player.NativeMethodInfoPtr_get_StaminaEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671658);
			Player.NativeMethodInfoPtr_set_StaminaEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671659);
			Player.NativeMethodInfoPtr_get_Stamina_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671660);
			Player.NativeMethodInfoPtr_set_Stamina_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671661);
			Player.NativeMethodInfoPtr_get_MaxStamina_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671662);
			Player.NativeMethodInfoPtr_set_MaxStamina_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671663);
			Player.NativeMethodInfoPtr_get_StaminaRegen_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671664);
			Player.NativeMethodInfoPtr_set_StaminaRegen_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671665);
			Player.NativeMethodInfoPtr_get_JumpPower_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671666);
			Player.NativeMethodInfoPtr_set_JumpPower_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671667);
			Player.NativeMethodInfoPtr_get_Position_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671668);
			Player.NativeMethodInfoPtr_set_Position_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671669);
			Player.NativeMethodInfoPtr_get_Rotation_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671670);
			Player.NativeMethodInfoPtr_set_Rotation_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671671);
			Player.NativeMethodInfoPtr_get_Size_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671672);
			Player.NativeMethodInfoPtr_set_Size_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671673);
			Player.NativeMethodInfoPtr_get_ChatColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671674);
			Player.NativeMethodInfoPtr_set_ChatColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671675);
			Player.NativeMethodInfoPtr_get_CanMove_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671676);
			Player.NativeMethodInfoPtr_set_CanMove_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671677);
			Player.NativeMethodInfoPtr_get_Anchored_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671678);
			Player.NativeMethodInfoPtr_set_Anchored_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671679);
			Player.NativeMethodInfoPtr_get_IsInputFocused_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671680);
			Player.NativeMethodInfoPtr_get_AvatarHash_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671681);
			Player.NativeMethodInfoPtr_get_SittingIn_Public_get_Seat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671682);
			Player.NativeMethodInfoPtr_get_Forward_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671683);
			Player.NativeMethodInfoPtr_get_Right_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671684);
			Player.NativeMethodInfoPtr_get_IsAdmin_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671685);
			Player.NativeMethodInfoPtr_get_IsCreator_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671686);
			Player.NativeMethodInfoPtr_get_IsSitting_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671687);
			Player.NativeMethodInfoPtr_get_IsMovementAllowed_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671688);
			Player.NativeMethodInfoPtr_get_UserID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671689);
			Player.NativeMethodInfoPtr_set_UserID_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671690);
			Player.NativeMethodInfoPtr_get_HeadColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671691);
			Player.NativeMethodInfoPtr_set_HeadColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671692);
			Player.NativeMethodInfoPtr_get_TorsoColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671693);
			Player.NativeMethodInfoPtr_set_TorsoColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671694);
			Player.NativeMethodInfoPtr_get_LeftArmColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671695);
			Player.NativeMethodInfoPtr_set_LeftArmColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671696);
			Player.NativeMethodInfoPtr_get_RightArmColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671697);
			Player.NativeMethodInfoPtr_set_RightArmColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671698);
			Player.NativeMethodInfoPtr_get_LeftLegColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671699);
			Player.NativeMethodInfoPtr_set_LeftLegColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671700);
			Player.NativeMethodInfoPtr_get_RightLegColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671701);
			Player.NativeMethodInfoPtr_set_RightLegColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671702);
			Player.NativeMethodInfoPtr_get_ShirtID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671703);
			Player.NativeMethodInfoPtr_set_ShirtID_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671704);
			Player.NativeMethodInfoPtr_get_PantsID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671705);
			Player.NativeMethodInfoPtr_set_PantsID_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671706);
			Player.NativeMethodInfoPtr_get_FaceID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671707);
			Player.NativeMethodInfoPtr_set_FaceID_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671708);
			Player.NativeMethodInfoPtr_get_ToolAttachmentPoint_Public_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671709);
			Player.NativeMethodInfoPtr_get_Camera_Private_get_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671710);
			Player.NativeMethodInfoPtr_set_Camera_Private_set_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671711);
			Player.NativeMethodInfoPtr_get_NetworkwalkSpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671811);
			Player.NativeMethodInfoPtr_set_NetworkwalkSpeed_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671812);
			Player.NativeMethodInfoPtr_get_NetworksprintSpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671813);
			Player.NativeMethodInfoPtr_set_NetworksprintSpeed_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671814);
			Player.NativeMethodInfoPtr_get_Networkhealth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671815);
			Player.NativeMethodInfoPtr_set_Networkhealth_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671816);
			Player.NativeMethodInfoPtr_get_NetworkstaminaEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671817);
			Player.NativeMethodInfoPtr_set_NetworkstaminaEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671818);
			Player.NativeMethodInfoPtr_get_Networkstamina_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671819);
			Player.NativeMethodInfoPtr_set_Networkstamina_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671820);
			Player.NativeMethodInfoPtr_get_NetworkmaxStamina_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671821);
			Player.NativeMethodInfoPtr_set_NetworkmaxStamina_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671822);
			Player.NativeMethodInfoPtr_get_NetworkstaminaRegen_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671823);
			Player.NativeMethodInfoPtr_set_NetworkstaminaRegen_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671824);
			Player.NativeMethodInfoPtr_get_NetworkrespawnTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671825);
			Player.NativeMethodInfoPtr_set_NetworkrespawnTime_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671826);
			Player.NativeMethodInfoPtr_get_NetworkuserID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671827);
			Player.NativeMethodInfoPtr_set_NetworkuserID_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671828);
			Player.NativeMethodInfoPtr_get_Networkloaded_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671829);
			Player.NativeMethodInfoPtr_set_Networkloaded_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671830);
			Player.NativeMethodInfoPtr_get_NetworkisCreator_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671831);
			Player.NativeMethodInfoPtr_set_NetworkisCreator_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671832);
			Player.NativeMethodInfoPtr_get_NetworkisAdmin_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671833);
			Player.NativeMethodInfoPtr_set_NetworkisAdmin_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671834);
			Player.NativeMethodInfoPtr_get_NetworkchatColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671835);
			Player.NativeMethodInfoPtr_set_NetworkchatColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671836);
			Player.NativeMethodInfoPtr_get_NetworkavatarHash_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671837);
			Player.NativeMethodInfoPtr_set_NetworkavatarHash_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671838);
			Player.NativeMethodInfoPtr_get_NetworkcanMove_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671839);
			Player.NativeMethodInfoPtr_set_NetworkcanMove_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671840);
			Player.NativeMethodInfoPtr_get_Networkanchored_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671841);
			Player.NativeMethodInfoPtr_set_Networkanchored_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671842);
			Player.NativeMethodInfoPtr_get_NetworkLeaderboardBadgeId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671843);
			Player.NativeMethodInfoPtr_set_NetworkLeaderboardBadgeId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671844);
			Player.NativeMethodInfoPtr_get_NetworkcanChat_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671845);
			Player.NativeMethodInfoPtr_set_NetworkcanChat_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671846);
			Player.NativeMethodInfoPtr_get_NetworkisAgeRestricted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671847);
			Player.NativeMethodInfoPtr_set_NetworkisAgeRestricted_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671848);
			Player.NativeMethodInfoPtr_get_NetworksittingIn_Public_get_Seat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671849);
			Player.NativeMethodInfoPtr_set_NetworksittingIn_Public_set_Void_Seat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671850);
			Player.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671799);
			Player.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671712);
			Player.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671713);
			Player.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671714);
			Player.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671715);
			Player.NativeMethodInfoPtr_Move_Private_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671716);
			Player.NativeMethodInfoPtr_PlayAnim_Public_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671717);
			Player.NativeMethodInfoPtr_PlayAnimTargetRpc_Public_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671718);
			Player.NativeMethodInfoPtr_SetChildLayers_Private_Void_Transform_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671719);
			Player.NativeMethodInfoPtr_PostPlayerLoad_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671720);
			Player.NativeMethodInfoPtr_DiscordLoop_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671721);
			Player.NativeMethodInfoPtr_NotifyJoin_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671722);
			Player.NativeMethodInfoPtr_OwnsItem_Public_Void_Int32_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671723);
			Player.NativeMethodInfoPtr_OnCollisionStay_Private_Void_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671724);
			Player.NativeMethodInfoPtr_OnCollisionExit_Protected_Virtual_Void_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671725);
			Player.NativeMethodInfoPtr_FindGround_Private_Boolean_byref_ContactPoint_List_1_ContactPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671726);
			Player.NativeMethodInfoPtr_FindStep_Private_Boolean_byref_Vector3_List_1_ContactPoint_ContactPoint_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671727);
			Player.NativeMethodInfoPtr_ResolveStepUp_Private_Boolean_byref_Vector3_ContactPoint_ContactPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671728);
			Player.NativeMethodInfoPtr_SetLoaded_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671729);
			Player.NativeMethodInfoPtr_LoadMetadata_Private_IEnumerator_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671730);
			Player.NativeMethodInfoPtr_CheckOwnsItemFromAPI_Private_IEnumerator_Int32_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671731);
			Player.NativeMethodInfoPtr_SendChat_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671732);
			Player.NativeMethodInfoPtr_StopScream_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671733);
			Player.NativeMethodInfoPtr_UpdateFootsteps_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671734);
			Player.NativeMethodInfoPtr_DoFootstep_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671735);
			Player.NativeMethodInfoPtr_Die_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671736);
			Player.NativeMethodInfoPtr_CmdDied_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671737);
			Player.NativeMethodInfoPtr_DropTools_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671738);
			Player.NativeMethodInfoPtr_CmdDropTools_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671739);
			Player.NativeMethodInfoPtr_DoDropTools_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671740);
			Player.NativeMethodInfoPtr_EquipTool_Public_Void_Tool_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671741);
			Player.NativeMethodInfoPtr_RpcSetAnimatorActive_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671742);
			Player.NativeMethodInfoPtr_SetTransformAttrTargetRpc_Public_Void_String_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671743);
			Player.NativeMethodInfoPtr_DoDie_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671744);
			Player.NativeMethodInfoPtr_SetUserID_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671745);
			Player.NativeMethodInfoPtr_LoadAppearance_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671746);
			Player.NativeMethodInfoPtr_ClearAppearance_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671747);
			Player.NativeMethodInfoPtr_ResetAppearance_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671748);
			Player.NativeMethodInfoPtr_IsGrounded_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671749);
			Player.NativeMethodInfoPtr_OnCollisionEnter_Protected_Virtual_Void_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671750);
			Player.NativeMethodInfoPtr_OnTriggerEnter_Protected_Virtual_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671751);
			Player.NativeMethodInfoPtr_OnTriggerExit_Protected_Virtual_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671752);
			Player.NativeMethodInfoPtr_CmdTouched_Private_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671753);
			Player.NativeMethodInfoPtr_CmdTouchEnded_Private_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671754);
			Player.NativeMethodInfoPtr_PressingMovementKeys_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671755);
			Player.NativeMethodInfoPtr_UpdateFov_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671756);
			Player.NativeMethodInfoPtr_CmdJumpSound_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671757);
			Player.NativeMethodInfoPtr_RpcJumpSound_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671758);
			Player.NativeMethodInfoPtr_DoJumpSound_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671759);
			Player.NativeMethodInfoPtr_Kick_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671760);
			Player.NativeMethodInfoPtr_DelayedDisconnect_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671761);
			Player.NativeMethodInfoPtr_SendDisconnectMessageTargetRpc_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671762);
			Player.NativeMethodInfoPtr_Sit_Public_Void_Seat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671763);
			Player.NativeMethodInfoPtr_UnsitTargetRpc_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671764);
			Player.NativeMethodInfoPtr_Unsit_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671765);
			Player.NativeMethodInfoPtr_CmdSetSittingIn_Public_Void_Seat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671766);
			Player.NativeMethodInfoPtr_SetSittingIn_Private_Void_Seat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671767);
			Player.NativeMethodInfoPtr_CmdNotifyRespawn_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671768);
			Player.NativeMethodInfoPtr_ServerRespawn_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671769);
			Player.NativeMethodInfoPtr_Respawn_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671770);
			Player.NativeMethodInfoPtr_LookAt_Public_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671771);
			Player.NativeMethodInfoPtr_LookAt_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671772);
			Player.NativeMethodInfoPtr_LookAt_Public_Void_DynamicInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671773);
			Player.NativeMethodInfoPtr_Translate_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671774);
			Player.NativeMethodInfoPtr_RotateAround_Public_Void_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671775);
			Player.NativeMethodInfoPtr_Rotate_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671776);
			Player.NativeMethodInfoPtr_InverseTransformPoint_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671777);
			Player.NativeMethodInfoPtr_TransformPoint_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671778);
			Player.NativeMethodInfoPtr_InverseTransformDirection_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671779);
			Player.NativeMethodInfoPtr_TransformDirection_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671780);
			Player.NativeMethodInfoPtr_InverseTransformVector_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671781);
			Player.NativeMethodInfoPtr_TransformVector_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671782);
			Player.NativeMethodInfoPtr_TargetSetPosition_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671783);
			Player.NativeMethodInfoPtr_RpcSetRespawnTime_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671784);
			Player.NativeMethodInfoPtr_RpcSetMaxHealth_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671785);
			Player.NativeMethodInfoPtr_RpcSetHealth_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671786);
			Player.NativeMethodInfoPtr_CmdSetHealth_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671787);
			Player.NativeMethodInfoPtr_RpcSetWalkSpeed_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671788);
			Player.NativeMethodInfoPtr_RpcSetSprintSpeed_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671789);
			Player.NativeMethodInfoPtr_RpcSetMaxStamina_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671790);
			Player.NativeMethodInfoPtr_RpcSetStamina_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671791);
			Player.NativeMethodInfoPtr_RpcSetStaminaRegen_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671792);
			Player.NativeMethodInfoPtr_RpcSetStaminaEnabled_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671793);
			Player.NativeMethodInfoPtr_RpcSetJumpPower_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671794);
			Player.NativeMethodInfoPtr_RpcSetChatColor_Private_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671795);
			Player.NativeMethodInfoPtr_RpcSetCanMove_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671796);
			Player.NativeMethodInfoPtr_RpcSetAnchored_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671797);
			Player.NativeMethodInfoPtr_RpcSetColor_Private_Void_BodyPart_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671798);
			Player.NativeMethodInfoPtr__set_ShirtID_b__165_0_Private_Void_ImageCacheKey_ImageCacheEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671801);
			Player.NativeMethodInfoPtr__set_PantsID_b__168_0_Private_Void_ImageCacheKey_ImageCacheEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671802);
			Player.NativeMethodInfoPtr__set_FaceID_b__171_0_Private_Void_ImageCacheKey_ImageCacheEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671803);
			Player.NativeMethodInfoPtr__Start_b__189_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671804);
			Player.NativeMethodInfoPtr__Start_b__189_1_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671805);
			Player.NativeMethodInfoPtr__Start_b__189_2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671806);
			Player.NativeMethodInfoPtr__IsGrounded_b__227_1_Private_Boolean_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671807);
			Player.NativeMethodInfoPtr__UpdateFov_b__234_0_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671808);
			Player.NativeMethodInfoPtr__UpdateFov_b__234_1_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671809);
			Player.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671810);
			Player.NativeMethodInfoPtr_UserCode_PlayAnimTargetRpc__String_Protected_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671851);
			Player.NativeMethodInfoPtr_InvokeUserCode_PlayAnimTargetRpc__String_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671852);
			Player.NativeMethodInfoPtr_UserCode_NotifyJoin_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671853);
			Player.NativeMethodInfoPtr_InvokeUserCode_NotifyJoin_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671854);
			Player.NativeMethodInfoPtr_UserCode_CmdDied_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671855);
			Player.NativeMethodInfoPtr_InvokeUserCode_CmdDied_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671856);
			Player.NativeMethodInfoPtr_UserCode_CmdDropTools_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671857);
			Player.NativeMethodInfoPtr_InvokeUserCode_CmdDropTools_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671858);
			Player.NativeMethodInfoPtr_UserCode_EquipTool__Tool_Protected_Void_Tool_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671859);
			Player.NativeMethodInfoPtr_InvokeUserCode_EquipTool__Tool_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671860);
			Player.NativeMethodInfoPtr_UserCode_RpcSetAnimatorActive__Boolean_Protected_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671861);
			Player.NativeMethodInfoPtr_InvokeUserCode_RpcSetAnimatorActive__Boolean_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671862);
			Player.NativeMethodInfoPtr_UserCode_SetTransformAttrTargetRpc__String__Vector3_Protected_Void_String_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671863);
			Player.NativeMethodInfoPtr_InvokeUserCode_SetTransformAttrTargetRpc__String__Vector3_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671864);
			Player.NativeMethodInfoPtr_UserCode_CmdTouched__GameObject_Protected_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671865);
			Player.NativeMethodInfoPtr_InvokeUserCode_CmdTouched__GameObject_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671866);
			Player.NativeMethodInfoPtr_UserCode_CmdTouchEnded__GameObject_Protected_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671867);
			Player.NativeMethodInfoPtr_InvokeUserCode_CmdTouchEnded__GameObject_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671868);
			Player.NativeMethodInfoPtr_UserCode_CmdJumpSound_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671869);
			Player.NativeMethodInfoPtr_InvokeUserCode_CmdJumpSound_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671870);
			Player.NativeMethodInfoPtr_UserCode_RpcJumpSound_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671871);
			Player.NativeMethodInfoPtr_InvokeUserCode_RpcJumpSound_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671872);
			Player.NativeMethodInfoPtr_UserCode_SendDisconnectMessageTargetRpc__String_Protected_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671873);
			Player.NativeMethodInfoPtr_InvokeUserCode_SendDisconnectMessageTargetRpc__String_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671874);
			Player.NativeMethodInfoPtr_UserCode_UnsitTargetRpc__Boolean_Protected_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671875);
			Player.NativeMethodInfoPtr_InvokeUserCode_UnsitTargetRpc__Boolean_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671876);
			Player.NativeMethodInfoPtr_UserCode_CmdSetSittingIn__Seat_Protected_Void_Seat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671877);
			Player.NativeMethodInfoPtr_InvokeUserCode_CmdSetSittingIn__Seat_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671878);
			Player.NativeMethodInfoPtr_UserCode_CmdNotifyRespawn_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671879);
			Player.NativeMethodInfoPtr_InvokeUserCode_CmdNotifyRespawn_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671880);
			Player.NativeMethodInfoPtr_UserCode_TargetSetPosition__Vector3_Protected_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671881);
			Player.NativeMethodInfoPtr_InvokeUserCode_TargetSetPosition__Vector3_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671882);
			Player.NativeMethodInfoPtr_UserCode_RpcSetRespawnTime__Single_Protected_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671883);
			Player.NativeMethodInfoPtr_InvokeUserCode_RpcSetRespawnTime__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671884);
			Player.NativeMethodInfoPtr_UserCode_RpcSetMaxHealth__Single_Protected_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671885);
			Player.NativeMethodInfoPtr_InvokeUserCode_RpcSetMaxHealth__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671886);
			Player.NativeMethodInfoPtr_UserCode_RpcSetHealth__Single_Protected_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671887);
			Player.NativeMethodInfoPtr_InvokeUserCode_RpcSetHealth__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671888);
			Player.NativeMethodInfoPtr_UserCode_CmdSetHealth__Single_Protected_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671889);
			Player.NativeMethodInfoPtr_InvokeUserCode_CmdSetHealth__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671890);
			Player.NativeMethodInfoPtr_UserCode_RpcSetWalkSpeed__Single_Protected_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671891);
			Player.NativeMethodInfoPtr_InvokeUserCode_RpcSetWalkSpeed__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671892);
			Player.NativeMethodInfoPtr_UserCode_RpcSetSprintSpeed__Single_Protected_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671893);
			Player.NativeMethodInfoPtr_InvokeUserCode_RpcSetSprintSpeed__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671894);
			Player.NativeMethodInfoPtr_UserCode_RpcSetMaxStamina__Single_Protected_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671895);
			Player.NativeMethodInfoPtr_InvokeUserCode_RpcSetMaxStamina__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671896);
			Player.NativeMethodInfoPtr_UserCode_RpcSetStamina__Single_Protected_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671897);
			Player.NativeMethodInfoPtr_InvokeUserCode_RpcSetStamina__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671898);
			Player.NativeMethodInfoPtr_UserCode_RpcSetStaminaRegen__Single_Protected_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671899);
			Player.NativeMethodInfoPtr_InvokeUserCode_RpcSetStaminaRegen__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671900);
			Player.NativeMethodInfoPtr_UserCode_RpcSetStaminaEnabled__Boolean_Protected_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671901);
			Player.NativeMethodInfoPtr_InvokeUserCode_RpcSetStaminaEnabled__Boolean_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671902);
			Player.NativeMethodInfoPtr_UserCode_RpcSetJumpPower__Single_Protected_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671903);
			Player.NativeMethodInfoPtr_InvokeUserCode_RpcSetJumpPower__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671904);
			Player.NativeMethodInfoPtr_UserCode_RpcSetChatColor__Color_Protected_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671905);
			Player.NativeMethodInfoPtr_InvokeUserCode_RpcSetChatColor__Color_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671906);
			Player.NativeMethodInfoPtr_UserCode_RpcSetCanMove__Boolean_Protected_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671907);
			Player.NativeMethodInfoPtr_InvokeUserCode_RpcSetCanMove__Boolean_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671908);
			Player.NativeMethodInfoPtr_UserCode_RpcSetAnchored__Boolean_Protected_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671909);
			Player.NativeMethodInfoPtr_InvokeUserCode_RpcSetAnchored__Boolean_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671910);
			Player.NativeMethodInfoPtr_UserCode_RpcSetColor__BodyPart__Color_Protected_Void_BodyPart_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671911);
			Player.NativeMethodInfoPtr_InvokeUserCode_RpcSetColor__BodyPart__Color_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671912);
			Player.NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671913);
			Player.NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player>.NativeClassPtr, 100671914);
		}

		// Token: 0x17001378 RID: 4984
		// (get) Token: 0x06003715 RID: 14101 RVA: 0x000FBDC4 File Offset: 0x000F9FC4
		public unsafe bool IsLocalPlayer
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 112130, RefRangeEnd = 112133, XrefRangeStart = 112128, XrefRangeEnd = 112130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_IsLocalPlayer_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001379 RID: 4985
		// (get) Token: 0x06003716 RID: 14102 RVA: 0x000FBE00 File Offset: 0x000FA000
		public unsafe bool IsLoaded
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_IsLoaded_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700137A RID: 4986
		// (get) Token: 0x06003717 RID: 14103 RVA: 0x000FBE3C File Offset: 0x000FA03C
		// (set) Token: 0x06003718 RID: 14104 RVA: 0x000FBE78 File Offset: 0x000FA078
		public unsafe float RespawnTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_RespawnTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 112155, RefRangeEnd = 112158, XrefRangeStart = 112133, XrefRangeEnd = 112155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_RespawnTime_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700137B RID: 4987
		// (get) Token: 0x06003719 RID: 14105 RVA: 0x000FBEB8 File Offset: 0x000FA0B8
		// (set) Token: 0x0600371A RID: 14106 RVA: 0x000FBEF8 File Offset: 0x000FA0F8
		public unsafe Vector3 Velocity
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 112159, RefRangeEnd = 112160, XrefRangeStart = 112158, XrefRangeEnd = 112159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_Velocity_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 112161, RefRangeEnd = 112162, XrefRangeStart = 112160, XrefRangeEnd = 112161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_Velocity_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700137C RID: 4988
		// (get) Token: 0x0600371B RID: 14107 RVA: 0x000FBF3C File Offset: 0x000FA13C
		// (set) Token: 0x0600371C RID: 14108 RVA: 0x000FBF78 File Offset: 0x000FA178
		public unsafe float MaxHealth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_MaxHealth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 112178, RefRangeEnd = 112179, XrefRangeStart = 112162, XrefRangeEnd = 112178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_MaxHealth_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700137D RID: 4989
		// (get) Token: 0x0600371D RID: 14109 RVA: 0x000FBFB8 File Offset: 0x000FA1B8
		// (set) Token: 0x0600371E RID: 14110 RVA: 0x000FBFF4 File Offset: 0x000FA1F4
		public unsafe float Health
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_Health_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 112198, RefRangeEnd = 112206, XrefRangeStart = 112179, XrefRangeEnd = 112198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_Health_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700137E RID: 4990
		// (get) Token: 0x0600371F RID: 14111 RVA: 0x000FC034 File Offset: 0x000FA234
		// (set) Token: 0x06003720 RID: 14112 RVA: 0x000FC070 File Offset: 0x000FA270
		public unsafe float WalkSpeed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_WalkSpeed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 112228, RefRangeEnd = 112231, XrefRangeStart = 112206, XrefRangeEnd = 112228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_WalkSpeed_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700137F RID: 4991
		// (get) Token: 0x06003721 RID: 14113 RVA: 0x000FC0B0 File Offset: 0x000FA2B0
		// (set) Token: 0x06003722 RID: 14114 RVA: 0x000FC0EC File Offset: 0x000FA2EC
		public unsafe float SprintSpeed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_SprintSpeed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 112253, RefRangeEnd = 112256, XrefRangeStart = 112231, XrefRangeEnd = 112253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_SprintSpeed_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001380 RID: 4992
		// (get) Token: 0x06003723 RID: 14115 RVA: 0x000FC12C File Offset: 0x000FA32C
		// (set) Token: 0x06003724 RID: 14116 RVA: 0x000FC168 File Offset: 0x000FA368
		public unsafe bool StaminaEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_StaminaEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 112278, RefRangeEnd = 112281, XrefRangeStart = 112256, XrefRangeEnd = 112278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_StaminaEnabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001381 RID: 4993
		// (get) Token: 0x06003725 RID: 14117 RVA: 0x000FC1A8 File Offset: 0x000FA3A8
		// (set) Token: 0x06003726 RID: 14118 RVA: 0x000FC1E4 File Offset: 0x000FA3E4
		public unsafe float Stamina
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_Stamina_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 112298, RefRangeEnd = 112304, XrefRangeStart = 112281, XrefRangeEnd = 112298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_Stamina_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001382 RID: 4994
		// (get) Token: 0x06003727 RID: 14119 RVA: 0x000FC224 File Offset: 0x000FA424
		// (set) Token: 0x06003728 RID: 14120 RVA: 0x000FC260 File Offset: 0x000FA460
		public unsafe float MaxStamina
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_MaxStamina_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 112326, RefRangeEnd = 112329, XrefRangeStart = 112304, XrefRangeEnd = 112326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_MaxStamina_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001383 RID: 4995
		// (get) Token: 0x06003729 RID: 14121 RVA: 0x000FC2A0 File Offset: 0x000FA4A0
		// (set) Token: 0x0600372A RID: 14122 RVA: 0x000FC2DC File Offset: 0x000FA4DC
		public unsafe float StaminaRegen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_StaminaRegen_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 112351, RefRangeEnd = 112354, XrefRangeStart = 112329, XrefRangeEnd = 112351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_StaminaRegen_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001384 RID: 4996
		// (get) Token: 0x0600372B RID: 14123 RVA: 0x000FC31C File Offset: 0x000FA51C
		// (set) Token: 0x0600372C RID: 14124 RVA: 0x000FC358 File Offset: 0x000FA558
		public unsafe float JumpPower
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_JumpPower_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 112370, RefRangeEnd = 112371, XrefRangeStart = 112354, XrefRangeEnd = 112370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_JumpPower_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001385 RID: 4997
		// (get) Token: 0x0600372D RID: 14125 RVA: 0x000FC398 File Offset: 0x000FA598
		// (set) Token: 0x0600372E RID: 14126 RVA: 0x000FC3D8 File Offset: 0x000FA5D8
		public unsafe Vector3 Position
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 112373, RefRangeEnd = 112374, XrefRangeStart = 112371, XrefRangeEnd = 112373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_Position_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 112388, RefRangeEnd = 112391, XrefRangeStart = 112374, XrefRangeEnd = 112388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_Position_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001386 RID: 4998
		// (get) Token: 0x0600372F RID: 14127 RVA: 0x000FC41C File Offset: 0x000FA61C
		// (set) Token: 0x06003730 RID: 14128 RVA: 0x000FC45C File Offset: 0x000FA65C
		public unsafe Vector3 Rotation
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 112393, RefRangeEnd = 112394, XrefRangeStart = 112391, XrefRangeEnd = 112393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_Rotation_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 112400, RefRangeEnd = 112401, XrefRangeStart = 112394, XrefRangeEnd = 112400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_Rotation_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001387 RID: 4999
		// (get) Token: 0x06003731 RID: 14129 RVA: 0x000FC4A0 File Offset: 0x000FA6A0
		// (set) Token: 0x06003732 RID: 14130 RVA: 0x000FC4E0 File Offset: 0x000FA6E0
		public unsafe Vector3 Size
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 112403, RefRangeEnd = 112404, XrefRangeStart = 112401, XrefRangeEnd = 112403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_Size_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 112410, RefRangeEnd = 112411, XrefRangeStart = 112404, XrefRangeEnd = 112410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_Size_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001388 RID: 5000
		// (get) Token: 0x06003733 RID: 14131 RVA: 0x000FC524 File Offset: 0x000FA724
		// (set) Token: 0x06003734 RID: 14132 RVA: 0x000FC564 File Offset: 0x000FA764
		public unsafe Color ChatColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_ChatColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 112433, RefRangeEnd = 112436, XrefRangeStart = 112411, XrefRangeEnd = 112433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_ChatColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001389 RID: 5001
		// (get) Token: 0x06003735 RID: 14133 RVA: 0x000FC5A8 File Offset: 0x000FA7A8
		// (set) Token: 0x06003736 RID: 14134 RVA: 0x000FC5E4 File Offset: 0x000FA7E4
		public unsafe bool CanMove
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_CanMove_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 112458, RefRangeEnd = 112461, XrefRangeStart = 112436, XrefRangeEnd = 112458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_CanMove_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700138A RID: 5002
		// (get) Token: 0x06003737 RID: 14135 RVA: 0x000FC624 File Offset: 0x000FA824
		// (set) Token: 0x06003738 RID: 14136 RVA: 0x000FC660 File Offset: 0x000FA860
		public unsafe bool Anchored
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_Anchored_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 112484, RefRangeEnd = 112487, XrefRangeStart = 112461, XrefRangeEnd = 112484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_Anchored_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700138B RID: 5003
		// (get) Token: 0x06003739 RID: 14137 RVA: 0x000FC6A0 File Offset: 0x000FA8A0
		public unsafe bool IsInputFocused
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 112491, RefRangeEnd = 112492, XrefRangeStart = 112487, XrefRangeEnd = 112491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_IsInputFocused_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700138C RID: 5004
		// (get) Token: 0x0600373A RID: 14138 RVA: 0x000FC6DC File Offset: 0x000FA8DC
		public unsafe string AvatarHash
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_AvatarHash_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700138D RID: 5005
		// (get) Token: 0x0600373B RID: 14139 RVA: 0x000FC714 File Offset: 0x000FA914
		public unsafe Seat SittingIn
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 112495, RefRangeEnd = 112496, XrefRangeStart = 112492, XrefRangeEnd = 112495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_SittingIn_Public_get_Seat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Seat>(intPtr3) : null;
			}
		}

		// Token: 0x1700138E RID: 5006
		// (get) Token: 0x0600373C RID: 14140 RVA: 0x000FC754 File Offset: 0x000FA954
		public unsafe Vector3 Forward
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 112498, RefRangeEnd = 112499, XrefRangeStart = 112496, XrefRangeEnd = 112498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_Forward_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x1700138F RID: 5007
		// (get) Token: 0x0600373D RID: 14141 RVA: 0x000FC794 File Offset: 0x000FA994
		public unsafe Vector3 Right
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 112501, RefRangeEnd = 112502, XrefRangeStart = 112499, XrefRangeEnd = 112501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_Right_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x17001390 RID: 5008
		// (get) Token: 0x0600373E RID: 14142 RVA: 0x000FC7D4 File Offset: 0x000FA9D4
		public unsafe bool IsAdmin
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_IsAdmin_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001391 RID: 5009
		// (get) Token: 0x0600373F RID: 14143 RVA: 0x000FC810 File Offset: 0x000FAA10
		public unsafe bool IsCreator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_IsCreator_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001392 RID: 5010
		// (get) Token: 0x06003740 RID: 14144 RVA: 0x000FC84C File Offset: 0x000FAA4C
		public unsafe bool IsSitting
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112502, XrefRangeEnd = 112509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_IsSitting_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001393 RID: 5011
		// (get) Token: 0x06003741 RID: 14145 RVA: 0x000FC888 File Offset: 0x000FAA88
		public unsafe bool IsMovementAllowed
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 112524, RefRangeEnd = 112525, XrefRangeStart = 112509, XrefRangeEnd = 112524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_IsMovementAllowed_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001394 RID: 5012
		// (get) Token: 0x06003742 RID: 14146 RVA: 0x000FC8C4 File Offset: 0x000FAAC4
		// (set) Token: 0x06003743 RID: 14147 RVA: 0x000FC900 File Offset: 0x000FAB00
		public unsafe int UserID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_UserID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112525, XrefRangeEnd = 112531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_UserID_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001395 RID: 5013
		// (get) Token: 0x06003744 RID: 14148 RVA: 0x000FC940 File Offset: 0x000FAB40
		// (set) Token: 0x06003745 RID: 14149 RVA: 0x000FC980 File Offset: 0x000FAB80
		public unsafe Color HeadColor
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 112536, RefRangeEnd = 112537, XrefRangeStart = 112531, XrefRangeEnd = 112536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_HeadColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 112543, RefRangeEnd = 112546, XrefRangeStart = 112537, XrefRangeEnd = 112543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_HeadColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001396 RID: 5014
		// (get) Token: 0x06003746 RID: 14150 RVA: 0x000FC9C4 File Offset: 0x000FABC4
		// (set) Token: 0x06003747 RID: 14151 RVA: 0x000FCA04 File Offset: 0x000FAC04
		public unsafe Color TorsoColor
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 112551, RefRangeEnd = 112552, XrefRangeStart = 112546, XrefRangeEnd = 112551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_TorsoColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 112558, RefRangeEnd = 112561, XrefRangeStart = 112552, XrefRangeEnd = 112558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_TorsoColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001397 RID: 5015
		// (get) Token: 0x06003748 RID: 14152 RVA: 0x000FCA48 File Offset: 0x000FAC48
		// (set) Token: 0x06003749 RID: 14153 RVA: 0x000FCA88 File Offset: 0x000FAC88
		public unsafe Color LeftArmColor
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 112566, RefRangeEnd = 112567, XrefRangeStart = 112561, XrefRangeEnd = 112566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_LeftArmColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 112573, RefRangeEnd = 112576, XrefRangeStart = 112567, XrefRangeEnd = 112573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_LeftArmColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001398 RID: 5016
		// (get) Token: 0x0600374A RID: 14154 RVA: 0x000FCACC File Offset: 0x000FACCC
		// (set) Token: 0x0600374B RID: 14155 RVA: 0x000FCB0C File Offset: 0x000FAD0C
		public unsafe Color RightArmColor
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 112581, RefRangeEnd = 112582, XrefRangeStart = 112576, XrefRangeEnd = 112581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_RightArmColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 112588, RefRangeEnd = 112591, XrefRangeStart = 112582, XrefRangeEnd = 112588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_RightArmColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001399 RID: 5017
		// (get) Token: 0x0600374C RID: 14156 RVA: 0x000FCB50 File Offset: 0x000FAD50
		// (set) Token: 0x0600374D RID: 14157 RVA: 0x000FCB90 File Offset: 0x000FAD90
		public unsafe Color LeftLegColor
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 112596, RefRangeEnd = 112597, XrefRangeStart = 112591, XrefRangeEnd = 112596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_LeftLegColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 112603, RefRangeEnd = 112606, XrefRangeStart = 112597, XrefRangeEnd = 112603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_LeftLegColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700139A RID: 5018
		// (get) Token: 0x0600374E RID: 14158 RVA: 0x000FCBD4 File Offset: 0x000FADD4
		// (set) Token: 0x0600374F RID: 14159 RVA: 0x000FCC14 File Offset: 0x000FAE14
		public unsafe Color RightLegColor
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 112611, RefRangeEnd = 112612, XrefRangeStart = 112606, XrefRangeEnd = 112611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_RightLegColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 112618, RefRangeEnd = 112621, XrefRangeStart = 112612, XrefRangeEnd = 112618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_RightLegColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700139B RID: 5019
		// (get) Token: 0x06003750 RID: 14160 RVA: 0x000FCC58 File Offset: 0x000FAE58
		// (set) Token: 0x06003751 RID: 14161 RVA: 0x000FCC94 File Offset: 0x000FAE94
		public unsafe int ShirtID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_ShirtID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 112641, RefRangeEnd = 112644, XrefRangeStart = 112621, XrefRangeEnd = 112641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_ShirtID_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700139C RID: 5020
		// (get) Token: 0x06003752 RID: 14162 RVA: 0x000FCCD4 File Offset: 0x000FAED4
		// (set) Token: 0x06003753 RID: 14163 RVA: 0x000FCD10 File Offset: 0x000FAF10
		public unsafe int PantsID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_PantsID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 112664, RefRangeEnd = 112667, XrefRangeStart = 112644, XrefRangeEnd = 112664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_PantsID_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700139D RID: 5021
		// (get) Token: 0x06003754 RID: 14164 RVA: 0x000FCD50 File Offset: 0x000FAF50
		// (set) Token: 0x06003755 RID: 14165 RVA: 0x000FCD8C File Offset: 0x000FAF8C
		public unsafe int FaceID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_FaceID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 112687, RefRangeEnd = 112690, XrefRangeStart = 112667, XrefRangeEnd = 112687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_FaceID_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700139E RID: 5022
		// (get) Token: 0x06003756 RID: 14166 RVA: 0x000FCDCC File Offset: 0x000FAFCC
		public unsafe virtual Transform ToolAttachmentPoint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_ToolAttachmentPoint_Public_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x1700139F RID: 5023
		// (get) Token: 0x06003757 RID: 14167 RVA: 0x000FCE0C File Offset: 0x000FB00C
		// (set) Token: 0x06003758 RID: 14168 RVA: 0x000FCE4C File Offset: 0x000FB04C
		public unsafe Camera Camera
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_Camera_Private_get_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112690, XrefRangeEnd = 112708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_Camera_Private_set_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170013A0 RID: 5024
		// (get) Token: 0x06003759 RID: 14169 RVA: 0x000FCE90 File Offset: 0x000FB090
		// (set) Token: 0x0600375A RID: 14170 RVA: 0x000FCECC File Offset: 0x000FB0CC
		public unsafe float NetworkwalkSpeed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_NetworkwalkSpeed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112708, XrefRangeEnd = 112714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_NetworkwalkSpeed_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170013A1 RID: 5025
		// (get) Token: 0x0600375B RID: 14171 RVA: 0x000FCF0C File Offset: 0x000FB10C
		// (set) Token: 0x0600375C RID: 14172 RVA: 0x000FCF48 File Offset: 0x000FB148
		public unsafe float NetworksprintSpeed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_NetworksprintSpeed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112714, XrefRangeEnd = 112720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_NetworksprintSpeed_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170013A2 RID: 5026
		// (get) Token: 0x0600375D RID: 14173 RVA: 0x000FCF88 File Offset: 0x000FB188
		// (set) Token: 0x0600375E RID: 14174 RVA: 0x000FCFC4 File Offset: 0x000FB1C4
		public unsafe float Networkhealth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_Networkhealth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 112726, RefRangeEnd = 112729, XrefRangeStart = 112720, XrefRangeEnd = 112726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_Networkhealth_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170013A3 RID: 5027
		// (get) Token: 0x0600375F RID: 14175 RVA: 0x000FD004 File Offset: 0x000FB204
		// (set) Token: 0x06003760 RID: 14176 RVA: 0x000FD040 File Offset: 0x000FB240
		public unsafe bool NetworkstaminaEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_NetworkstaminaEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112729, XrefRangeEnd = 112735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_NetworkstaminaEnabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170013A4 RID: 5028
		// (get) Token: 0x06003761 RID: 14177 RVA: 0x000FD080 File Offset: 0x000FB280
		// (set) Token: 0x06003762 RID: 14178 RVA: 0x000FD0BC File Offset: 0x000FB2BC
		public unsafe float Networkstamina
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_Networkstamina_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 112741, RefRangeEnd = 112742, XrefRangeStart = 112735, XrefRangeEnd = 112741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_Networkstamina_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170013A5 RID: 5029
		// (get) Token: 0x06003763 RID: 14179 RVA: 0x000FD0FC File Offset: 0x000FB2FC
		// (set) Token: 0x06003764 RID: 14180 RVA: 0x000FD138 File Offset: 0x000FB338
		public unsafe float NetworkmaxStamina
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_NetworkmaxStamina_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112742, XrefRangeEnd = 112748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_NetworkmaxStamina_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170013A6 RID: 5030
		// (get) Token: 0x06003765 RID: 14181 RVA: 0x000FD178 File Offset: 0x000FB378
		// (set) Token: 0x06003766 RID: 14182 RVA: 0x000FD1B4 File Offset: 0x000FB3B4
		public unsafe float NetworkstaminaRegen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_NetworkstaminaRegen_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112748, XrefRangeEnd = 112754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_NetworkstaminaRegen_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170013A7 RID: 5031
		// (get) Token: 0x06003767 RID: 14183 RVA: 0x000FD1F4 File Offset: 0x000FB3F4
		// (set) Token: 0x06003768 RID: 14184 RVA: 0x000FD230 File Offset: 0x000FB430
		public unsafe float NetworkrespawnTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_NetworkrespawnTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112754, XrefRangeEnd = 112760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_NetworkrespawnTime_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170013A8 RID: 5032
		// (get) Token: 0x06003769 RID: 14185 RVA: 0x000FD270 File Offset: 0x000FB470
		// (set) Token: 0x0600376A RID: 14186 RVA: 0x000FD2AC File Offset: 0x000FB4AC
		public unsafe int NetworkuserID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_NetworkuserID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_NetworkuserID_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170013A9 RID: 5033
		// (get) Token: 0x0600376B RID: 14187 RVA: 0x000FD2EC File Offset: 0x000FB4EC
		// (set) Token: 0x0600376C RID: 14188 RVA: 0x000FD328 File Offset: 0x000FB528
		public unsafe bool Networkloaded
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_Networkloaded_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112760, XrefRangeEnd = 112766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_Networkloaded_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170013AA RID: 5034
		// (get) Token: 0x0600376D RID: 14189 RVA: 0x000FD368 File Offset: 0x000FB568
		// (set) Token: 0x0600376E RID: 14190 RVA: 0x000FD3A4 File Offset: 0x000FB5A4
		public unsafe bool NetworkisCreator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_NetworkisCreator_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 112772, RefRangeEnd = 112773, XrefRangeStart = 112766, XrefRangeEnd = 112772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_NetworkisCreator_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170013AB RID: 5035
		// (get) Token: 0x0600376F RID: 14191 RVA: 0x000FD3E4 File Offset: 0x000FB5E4
		// (set) Token: 0x06003770 RID: 14192 RVA: 0x000FD420 File Offset: 0x000FB620
		public unsafe bool NetworkisAdmin
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_NetworkisAdmin_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 112779, RefRangeEnd = 112780, XrefRangeStart = 112773, XrefRangeEnd = 112779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_NetworkisAdmin_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170013AC RID: 5036
		// (get) Token: 0x06003771 RID: 14193 RVA: 0x000FD460 File Offset: 0x000FB660
		// (set) Token: 0x06003772 RID: 14194 RVA: 0x000FD4A0 File Offset: 0x000FB6A0
		public unsafe Color NetworkchatColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_NetworkchatColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112780, XrefRangeEnd = 112786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_NetworkchatColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170013AD RID: 5037
		// (get) Token: 0x06003773 RID: 14195 RVA: 0x000FD4E4 File Offset: 0x000FB6E4
		// (set) Token: 0x06003774 RID: 14196 RVA: 0x000FD51C File Offset: 0x000FB71C
		public unsafe string NetworkavatarHash
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_NetworkavatarHash_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 112792, RefRangeEnd = 112793, XrefRangeStart = 112786, XrefRangeEnd = 112792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_NetworkavatarHash_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170013AE RID: 5038
		// (get) Token: 0x06003775 RID: 14197 RVA: 0x000FD560 File Offset: 0x000FB760
		// (set) Token: 0x06003776 RID: 14198 RVA: 0x000FD59C File Offset: 0x000FB79C
		public unsafe bool NetworkcanMove
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_NetworkcanMove_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112793, XrefRangeEnd = 112799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_NetworkcanMove_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170013AF RID: 5039
		// (get) Token: 0x06003777 RID: 14199 RVA: 0x000FD5DC File Offset: 0x000FB7DC
		// (set) Token: 0x06003778 RID: 14200 RVA: 0x000FD618 File Offset: 0x000FB818
		public unsafe bool Networkanchored
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_Networkanchored_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112799, XrefRangeEnd = 112805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_Networkanchored_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170013B0 RID: 5040
		// (get) Token: 0x06003779 RID: 14201 RVA: 0x000FD658 File Offset: 0x000FB858
		// (set) Token: 0x0600377A RID: 14202 RVA: 0x000FD690 File Offset: 0x000FB890
		public unsafe string NetworkLeaderboardBadgeId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_NetworkLeaderboardBadgeId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 112811, RefRangeEnd = 112812, XrefRangeStart = 112805, XrefRangeEnd = 112811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_NetworkLeaderboardBadgeId_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170013B1 RID: 5041
		// (get) Token: 0x0600377B RID: 14203 RVA: 0x000FD6D4 File Offset: 0x000FB8D4
		// (set) Token: 0x0600377C RID: 14204 RVA: 0x000FD710 File Offset: 0x000FB910
		public unsafe bool NetworkcanChat
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_NetworkcanChat_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 112818, RefRangeEnd = 112819, XrefRangeStart = 112812, XrefRangeEnd = 112818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_NetworkcanChat_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170013B2 RID: 5042
		// (get) Token: 0x0600377D RID: 14205 RVA: 0x000FD750 File Offset: 0x000FB950
		// (set) Token: 0x0600377E RID: 14206 RVA: 0x000FD78C File Offset: 0x000FB98C
		public unsafe bool NetworkisAgeRestricted
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_NetworkisAgeRestricted_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 112825, RefRangeEnd = 112826, XrefRangeStart = 112819, XrefRangeEnd = 112825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_NetworkisAgeRestricted_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170013B3 RID: 5043
		// (get) Token: 0x0600377F RID: 14207 RVA: 0x000FD7CC File Offset: 0x000FB9CC
		// (set) Token: 0x06003780 RID: 14208 RVA: 0x000FD80C File Offset: 0x000FBA0C
		public unsafe Seat NetworksittingIn
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 112495, RefRangeEnd = 112496, XrefRangeStart = 112495, XrefRangeEnd = 112496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_get_NetworksittingIn_Public_get_Seat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Seat>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112826, XrefRangeEnd = 112832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_set_NetworksittingIn_Public_set_Void_Seat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003781 RID: 14209 RVA: 0x000FD850 File Offset: 0x000FBA50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112832, XrefRangeEnd = 112886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Player()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Player>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003782 RID: 14210 RVA: 0x000FD88C File Offset: 0x000FBA8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112886, XrefRangeEnd = 112988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Player.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003783 RID: 14211 RVA: 0x000FD8C8 File Offset: 0x000FBAC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112988, XrefRangeEnd = 113089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Player.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003784 RID: 14212 RVA: 0x000FD904 File Offset: 0x000FBB04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113089, XrefRangeEnd = 113168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003785 RID: 14213 RVA: 0x000FD938 File Offset: 0x000FBB38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113168, XrefRangeEnd = 113226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003786 RID: 14214 RVA: 0x000FD96C File Offset: 0x000FBB6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 113303, RefRangeEnd = 113304, XrefRangeStart = 113226, XrefRangeEnd = 113303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Move(float hor, float ver)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hor;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ver;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_Move_Private_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003787 RID: 14215 RVA: 0x000FD9B8 File Offset: 0x000FBBB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113304, XrefRangeEnd = 113320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PlayAnim(string _anim)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(_anim);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_PlayAnim_Public_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003788 RID: 14216 RVA: 0x000FD9FC File Offset: 0x000FBBFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113320, XrefRangeEnd = 113341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PlayAnimTargetRpc(string _anim)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(_anim);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_PlayAnimTargetRpc_Public_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003789 RID: 14217 RVA: 0x000FDA40 File Offset: 0x000FBC40
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 113363, RefRangeEnd = 113365, XrefRangeStart = 113341, XrefRangeEnd = 113363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetChildLayers(Transform root, LayerMask layer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(layer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SetChildLayers_Private_Void_Transform_LayerMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600378A RID: 14218 RVA: 0x000FDA94 File Offset: 0x000FBC94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113365, XrefRangeEnd = 113370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator PostPlayerLoad()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_PostPlayerLoad_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600378B RID: 14219 RVA: 0x000FDAD4 File Offset: 0x000FBCD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 113374, RefRangeEnd = 113375, XrefRangeStart = 113370, XrefRangeEnd = 113374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DiscordLoop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_DiscordLoop_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600378C RID: 14220 RVA: 0x000FDB14 File Offset: 0x000FBD14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 113395, RefRangeEnd = 113396, XrefRangeStart = 113375, XrefRangeEnd = 113395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifyJoin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_NotifyJoin_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600378D RID: 14221 RVA: 0x000FDB48 File Offset: 0x000FBD48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 113410, RefRangeEnd = 113411, XrefRangeStart = 113396, XrefRangeEnd = 113410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OwnsItem(int assetId, DynValue callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref assetId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_OwnsItem_Public_Void_Int32_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600378E RID: 14222 RVA: 0x000FDB98 File Offset: 0x000FBD98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113411, XrefRangeEnd = 113421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCollisionStay(Collision col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(col);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_OnCollisionStay_Private_Void_Collision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600378F RID: 14223 RVA: 0x000FDBDC File Offset: 0x000FBDDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113421, XrefRangeEnd = 113448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnCollisionExit(Collision col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(col);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Player.NativeMethodInfoPtr_OnCollisionExit_Protected_Virtual_Void_Collision_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003790 RID: 14224 RVA: 0x000FDC2C File Offset: 0x000FBE2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 113465, RefRangeEnd = 113466, XrefRangeStart = 113448, XrefRangeEnd = 113465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_FindGround_Private_Boolean_byref_ContactPoint_List_1_ContactPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003791 RID: 14225 RVA: 0x000FDC88 File Offset: 0x000FBE88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 113483, RefRangeEnd = 113484, XrefRangeStart = 113466, XrefRangeEnd = 113483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_FindStep_Private_Boolean_byref_Vector3_List_1_ContactPoint_ContactPoint_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003792 RID: 14226 RVA: 0x000FDD08 File Offset: 0x000FBF08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 113509, RefRangeEnd = 113510, XrefRangeStart = 113484, XrefRangeEnd = 113509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_ResolveStepUp_Private_Boolean_byref_Vector3_ContactPoint_ContactPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003793 RID: 14227 RVA: 0x000FDD78 File Offset: 0x000FBF78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 113524, RefRangeEnd = 113525, XrefRangeStart = 113510, XrefRangeEnd = 113524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLoaded(string authToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(authToken);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SetLoaded_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003794 RID: 14228 RVA: 0x000FDDBC File Offset: 0x000FBFBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113525, XrefRangeEnd = 113531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator LoadMetadata(string authToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(authToken);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_LoadMetadata_Private_IEnumerator_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06003795 RID: 14229 RVA: 0x000FDE0C File Offset: 0x000FC00C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 113537, RefRangeEnd = 113538, XrefRangeStart = 113531, XrefRangeEnd = 113537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator CheckOwnsItemFromAPI(int assetId, DynValue callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref assetId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_CheckOwnsItemFromAPI_Private_IEnumerator_Int32_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06003796 RID: 14230 RVA: 0x000FDE6C File Offset: 0x000FC06C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 113592, RefRangeEnd = 113593, XrefRangeStart = 113538, XrefRangeEnd = 113592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendChat()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SendChat_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003797 RID: 14231 RVA: 0x000FDEA0 File Offset: 0x000FC0A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113593, XrefRangeEnd = 113598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator StopScream()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_StopScream_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06003798 RID: 14232 RVA: 0x000FDEE0 File Offset: 0x000FC0E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113598, XrefRangeEnd = 113608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateFootsteps()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_UpdateFootsteps_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003799 RID: 14233 RVA: 0x000FDF14 File Offset: 0x000FC114
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 113683, RefRangeEnd = 113685, XrefRangeStart = 113608, XrefRangeEnd = 113683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoFootstep()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_DoFootstep_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600379A RID: 14234 RVA: 0x000FDF48 File Offset: 0x000FC148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113685, XrefRangeEnd = 113723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Die()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_Die_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600379B RID: 14235 RVA: 0x000FDF7C File Offset: 0x000FC17C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113723, XrefRangeEnd = 113743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CmdDied()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_CmdDied_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600379C RID: 14236 RVA: 0x000FDFB0 File Offset: 0x000FC1B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113743, XrefRangeEnd = 113777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DropTools()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_DropTools_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600379D RID: 14237 RVA: 0x000FDFE4 File Offset: 0x000FC1E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113777, XrefRangeEnd = 113797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CmdDropTools()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_CmdDropTools_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600379E RID: 14238 RVA: 0x000FE018 File Offset: 0x000FC218
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 113817, RefRangeEnd = 113820, XrefRangeStart = 113797, XrefRangeEnd = 113817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoDropTools()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_DoDropTools_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600379F RID: 14239 RVA: 0x000FE04C File Offset: 0x000FC24C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 113841, RefRangeEnd = 113842, XrefRangeStart = 113820, XrefRangeEnd = 113841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EquipTool(Tool tool)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tool);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_EquipTool_Public_Void_Tool_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060037A0 RID: 14240 RVA: 0x000FE090 File Offset: 0x000FC290
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 113863, RefRangeEnd = 113865, XrefRangeStart = 113842, XrefRangeEnd = 113863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcSetAnimatorActive(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref active;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcSetAnimatorActive_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060037A1 RID: 14241 RVA: 0x000FE0D0 File Offset: 0x000FC2D0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 113887, RefRangeEnd = 113894, XrefRangeStart = 113865, XrefRangeEnd = 113887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTransformAttrTargetRpc(string attr, Vector3 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(attr);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SetTransformAttrTargetRpc_Public_Void_String_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037A2 RID: 14242 RVA: 0x000FE124 File Offset: 0x000FC324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113894, XrefRangeEnd = 113899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DoDie()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_DoDie_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060037A3 RID: 14243 RVA: 0x000FE164 File Offset: 0x000FC364
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 113911, RefRangeEnd = 113914, XrefRangeStart = 113899, XrefRangeEnd = 113911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUserID(int userID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref userID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SetUserID_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060037A4 RID: 14244 RVA: 0x000FE1A4 File Offset: 0x000FC3A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 113916, RefRangeEnd = 113917, XrefRangeStart = 113914, XrefRangeEnd = 113916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadAppearance(int userID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref userID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_LoadAppearance_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060037A5 RID: 14245 RVA: 0x000FE1E4 File Offset: 0x000FC3E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 113918, RefRangeEnd = 113919, XrefRangeStart = 113917, XrefRangeEnd = 113918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearAppearance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_ClearAppearance_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037A6 RID: 14246 RVA: 0x000FE218 File Offset: 0x000FC418
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 113921, RefRangeEnd = 113922, XrefRangeStart = 113919, XrefRangeEnd = 113921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetAppearance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_ResetAppearance_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037A7 RID: 14247 RVA: 0x000FE24C File Offset: 0x000FC44C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 113973, RefRangeEnd = 113977, XrefRangeStart = 113922, XrefRangeEnd = 113973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsGrounded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_IsGrounded_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060037A8 RID: 14248 RVA: 0x000FE288 File Offset: 0x000FC488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113977, XrefRangeEnd = 113999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnCollisionEnter(Collision collision)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collision);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Player.NativeMethodInfoPtr_OnCollisionEnter_Protected_Virtual_Void_Collision_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060037A9 RID: 14249 RVA: 0x000FE2D8 File Offset: 0x000FC4D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113999, XrefRangeEnd = 114021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnTriggerEnter(Collider collider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Player.NativeMethodInfoPtr_OnTriggerEnter_Protected_Virtual_Void_Collider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060037AA RID: 14250 RVA: 0x000FE328 File Offset: 0x000FC528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114021, XrefRangeEnd = 114043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnTriggerExit(Collider collider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Player.NativeMethodInfoPtr_OnTriggerExit_Protected_Virtual_Void_Collider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060037AB RID: 14251 RVA: 0x000FE378 File Offset: 0x000FC578
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 114064, RefRangeEnd = 114066, XrefRangeStart = 114043, XrefRangeEnd = 114064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CmdTouched(GameObject other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_CmdTouched_Private_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060037AC RID: 14252 RVA: 0x000FE3BC File Offset: 0x000FC5BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 114087, RefRangeEnd = 114089, XrefRangeStart = 114066, XrefRangeEnd = 114087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CmdTouchEnded(GameObject other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_CmdTouchEnded_Private_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060037AD RID: 14253 RVA: 0x000FE400 File Offset: 0x000FC600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114089, XrefRangeEnd = 114099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool PressingMovementKeys()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_PressingMovementKeys_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060037AE RID: 14254 RVA: 0x000FE43C File Offset: 0x000FC63C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114099, XrefRangeEnd = 114112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateFov(bool sprinting)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sprinting;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_UpdateFov_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060037AF RID: 14255 RVA: 0x000FE47C File Offset: 0x000FC67C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114112, XrefRangeEnd = 114132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CmdJumpSound()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_CmdJumpSound_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037B0 RID: 14256 RVA: 0x000FE4B0 File Offset: 0x000FC6B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114132, XrefRangeEnd = 114152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcJumpSound()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcJumpSound_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037B1 RID: 14257 RVA: 0x000FE4E4 File Offset: 0x000FC6E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 114159, RefRangeEnd = 114161, XrefRangeStart = 114152, XrefRangeEnd = 114159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoJumpSound()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_DoJumpSound_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037B2 RID: 14258 RVA: 0x000FE518 File Offset: 0x000FC718
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 114199, RefRangeEnd = 114203, XrefRangeStart = 114161, XrefRangeEnd = 114199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Kick(string reason = "You have been kicked from the server.")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(reason);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_Kick_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060037B3 RID: 14259 RVA: 0x000FE55C File Offset: 0x000FC75C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114203, XrefRangeEnd = 114208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DelayedDisconnect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_DelayedDisconnect_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060037B4 RID: 14260 RVA: 0x000FE59C File Offset: 0x000FC79C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114208, XrefRangeEnd = 114229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendDisconnectMessageTargetRpc(string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SendDisconnectMessageTargetRpc_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060037B5 RID: 14261 RVA: 0x000FE5E0 File Offset: 0x000FC7E0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 114275, RefRangeEnd = 114278, XrefRangeStart = 114229, XrefRangeEnd = 114275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Sit(Seat seat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(seat);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_Sit_Public_Void_Seat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060037B6 RID: 14262 RVA: 0x000FE624 File Offset: 0x000FC824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114278, XrefRangeEnd = 114299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnsitTargetRpc(bool addForce)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref addForce;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_UnsitTargetRpc_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060037B7 RID: 14263 RVA: 0x000FE664 File Offset: 0x000FC864
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 114318, RefRangeEnd = 114323, XrefRangeStart = 114299, XrefRangeEnd = 114318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Unsit(bool addForce = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref addForce;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_Unsit_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060037B8 RID: 14264 RVA: 0x000FE6A4 File Offset: 0x000FC8A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114323, XrefRangeEnd = 114344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CmdSetSittingIn(Seat seat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(seat);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_CmdSetSittingIn_Public_Void_Seat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060037B9 RID: 14265 RVA: 0x000FE6E8 File Offset: 0x000FC8E8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 114367, RefRangeEnd = 114370, XrefRangeStart = 114344, XrefRangeEnd = 114367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSittingIn(Seat seat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(seat);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_SetSittingIn_Private_Void_Seat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060037BA RID: 14266 RVA: 0x000FE72C File Offset: 0x000FC92C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114370, XrefRangeEnd = 114390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CmdNotifyRespawn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_CmdNotifyRespawn_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037BB RID: 14267 RVA: 0x000FE760 File Offset: 0x000FC960
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 114444, RefRangeEnd = 114447, XrefRangeStart = 114390, XrefRangeEnd = 114444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ServerRespawn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_ServerRespawn_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037BC RID: 14268 RVA: 0x000FE794 File Offset: 0x000FC994
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 114543, RefRangeEnd = 114546, XrefRangeStart = 114447, XrefRangeEnd = 114543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Respawn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_Respawn_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037BD RID: 14269 RVA: 0x000FE7C8 File Offset: 0x000FC9C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 114558, RefRangeEnd = 114559, XrefRangeStart = 114546, XrefRangeEnd = 114558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_LookAt_Public_Void_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037BE RID: 14270 RVA: 0x000FE81C File Offset: 0x000FCA1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 114573, RefRangeEnd = 114574, XrefRangeStart = 114559, XrefRangeEnd = 114573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LookAt(Vector3 target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_LookAt_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060037BF RID: 14271 RVA: 0x000FE860 File Offset: 0x000FCA60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 114589, RefRangeEnd = 114590, XrefRangeStart = 114574, XrefRangeEnd = 114589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LookAt(DynamicInstance target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_LookAt_Public_Void_DynamicInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060037C0 RID: 14272 RVA: 0x000FE8A4 File Offset: 0x000FCAA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 114592, RefRangeEnd = 114593, XrefRangeStart = 114590, XrefRangeEnd = 114592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Translate(Vector3 translation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(translation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_Translate_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060037C1 RID: 14273 RVA: 0x000FE8E8 File Offset: 0x000FCAE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 114595, RefRangeEnd = 114596, XrefRangeStart = 114593, XrefRangeEnd = 114595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RotateAround_Public_Void_Vector3_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037C2 RID: 14274 RVA: 0x000FE94C File Offset: 0x000FCB4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 114598, RefRangeEnd = 114599, XrefRangeStart = 114596, XrefRangeEnd = 114598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Rotate(Vector3 eulerAngles)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eulerAngles);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_Rotate_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060037C3 RID: 14275 RVA: 0x000FE990 File Offset: 0x000FCB90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 114601, RefRangeEnd = 114602, XrefRangeStart = 114599, XrefRangeEnd = 114601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 InverseTransformPoint(Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_InverseTransformPoint_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x060037C4 RID: 14276 RVA: 0x000FE9E0 File Offset: 0x000FCBE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 114604, RefRangeEnd = 114605, XrefRangeStart = 114602, XrefRangeEnd = 114604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 TransformPoint(Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_TransformPoint_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x060037C5 RID: 14277 RVA: 0x000FEA30 File Offset: 0x000FCC30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 114607, RefRangeEnd = 114608, XrefRangeStart = 114605, XrefRangeEnd = 114607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 InverseTransformDirection(Vector3 direction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(direction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_InverseTransformDirection_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x060037C6 RID: 14278 RVA: 0x000FEA80 File Offset: 0x000FCC80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 114610, RefRangeEnd = 114611, XrefRangeStart = 114608, XrefRangeEnd = 114610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 TransformDirection(Vector3 direction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(direction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_TransformDirection_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x060037C7 RID: 14279 RVA: 0x000FEAD0 File Offset: 0x000FCCD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 114613, RefRangeEnd = 114614, XrefRangeStart = 114611, XrefRangeEnd = 114613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 InverseTransformVector(Vector3 vector)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vector);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_InverseTransformVector_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x060037C8 RID: 14280 RVA: 0x000FEB20 File Offset: 0x000FCD20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 114616, RefRangeEnd = 114617, XrefRangeStart = 114614, XrefRangeEnd = 114616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 TransformVector(Vector3 vector)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vector);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_TransformVector_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x060037C9 RID: 14281 RVA: 0x000FEB70 File Offset: 0x000FCD70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114617, XrefRangeEnd = 114638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TargetSetPosition(Vector3 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_TargetSetPosition_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060037CA RID: 14282 RVA: 0x000FEBB4 File Offset: 0x000FCDB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114638, XrefRangeEnd = 114659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcSetRespawnTime(float time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcSetRespawnTime_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060037CB RID: 14283 RVA: 0x000FEBF4 File Offset: 0x000FCDF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114659, XrefRangeEnd = 114680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcSetMaxHealth(float maxHealth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref maxHealth;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcSetMaxHealth_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060037CC RID: 14284 RVA: 0x000FEC34 File Offset: 0x000FCE34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114680, XrefRangeEnd = 114701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcSetHealth(float health)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref health;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcSetHealth_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060037CD RID: 14285 RVA: 0x000FEC74 File Offset: 0x000FCE74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114701, XrefRangeEnd = 114722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CmdSetHealth(float health)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref health;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_CmdSetHealth_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060037CE RID: 14286 RVA: 0x000FECB4 File Offset: 0x000FCEB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114722, XrefRangeEnd = 114743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcSetWalkSpeed(float walkSpeed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref walkSpeed;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcSetWalkSpeed_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060037CF RID: 14287 RVA: 0x000FECF4 File Offset: 0x000FCEF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114743, XrefRangeEnd = 114764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcSetSprintSpeed(float sprintSpeed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sprintSpeed;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcSetSprintSpeed_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060037D0 RID: 14288 RVA: 0x000FED34 File Offset: 0x000FCF34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114764, XrefRangeEnd = 114785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcSetMaxStamina(float val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcSetMaxStamina_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060037D1 RID: 14289 RVA: 0x000FED74 File Offset: 0x000FCF74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114785, XrefRangeEnd = 114806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcSetStamina(float val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcSetStamina_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060037D2 RID: 14290 RVA: 0x000FEDB4 File Offset: 0x000FCFB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114806, XrefRangeEnd = 114827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcSetStaminaRegen(float val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcSetStaminaRegen_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060037D3 RID: 14291 RVA: 0x000FEDF4 File Offset: 0x000FCFF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114827, XrefRangeEnd = 114848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcSetStaminaEnabled(bool val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcSetStaminaEnabled_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060037D4 RID: 14292 RVA: 0x000FEE34 File Offset: 0x000FD034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114848, XrefRangeEnd = 114869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcSetJumpPower(float jumpPower)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref jumpPower;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcSetJumpPower_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060037D5 RID: 14293 RVA: 0x000FEE74 File Offset: 0x000FD074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114869, XrefRangeEnd = 114890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcSetChatColor(Color col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(col);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcSetChatColor_Private_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060037D6 RID: 14294 RVA: 0x000FEEB8 File Offset: 0x000FD0B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114890, XrefRangeEnd = 114911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcSetCanMove(bool canMove)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref canMove;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcSetCanMove_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060037D7 RID: 14295 RVA: 0x000FEEF8 File Offset: 0x000FD0F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114911, XrefRangeEnd = 114932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcSetAnchored(bool anchored)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref anchored;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcSetAnchored_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060037D8 RID: 14296 RVA: 0x000FEF38 File Offset: 0x000FD138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114932, XrefRangeEnd = 114954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcSetColor(BodyPart bodyPart, Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bodyPart);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(color);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_RpcSetColor_Private_Void_BodyPart_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037D9 RID: 14297 RVA: 0x000FEF8C File Offset: 0x000FD18C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114954, XrefRangeEnd = 114969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _set_ShirtID_b__165_0(ImageCacheKey key, ImageCacheEntry entry)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr__set_ShirtID_b__165_0_Private_Void_ImageCacheKey_ImageCacheEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037DA RID: 14298 RVA: 0x000FEFE0 File Offset: 0x000FD1E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114969, XrefRangeEnd = 114980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _set_PantsID_b__168_0(ImageCacheKey key, ImageCacheEntry entry)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr__set_PantsID_b__168_0_Private_Void_ImageCacheKey_ImageCacheEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037DB RID: 14299 RVA: 0x000FF034 File Offset: 0x000FD234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114980, XrefRangeEnd = 114992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _set_FaceID_b__171_0(ImageCacheKey key, ImageCacheEntry entry)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr__set_FaceID_b__171_0_Private_Void_ImageCacheKey_ImageCacheEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037DC RID: 14300 RVA: 0x000FF088 File Offset: 0x000FD288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114992, XrefRangeEnd = 114993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__189_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr__Start_b__189_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037DD RID: 14301 RVA: 0x000FF0BC File Offset: 0x000FD2BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114993, XrefRangeEnd = 115008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__189_1(string <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr__Start_b__189_1_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060037DE RID: 14302 RVA: 0x000FF100 File Offset: 0x000FD300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115008, XrefRangeEnd = 115013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__189_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr__Start_b__189_2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037DF RID: 14303 RVA: 0x000FF134 File Offset: 0x000FD334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115013, XrefRangeEnd = 115016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _IsGrounded_b__227_1(Collider i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(i);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr__IsGrounded_b__227_1_Private_Boolean_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060037E0 RID: 14304 RVA: 0x000FF184 File Offset: 0x000FD384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115016, XrefRangeEnd = 115018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _UpdateFov_b__234_0(float fov)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fov;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr__UpdateFov_b__234_0_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060037E1 RID: 14305 RVA: 0x000FF1C4 File Offset: 0x000FD3C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _UpdateFov_b__234_1(float fov)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fov;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr__UpdateFov_b__234_1_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060037E2 RID: 14306 RVA: 0x000FF204 File Offset: 0x000FD404
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 20124, RefRangeEnd = 20136, XrefRangeStart = 20124, XrefRangeEnd = 20136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Weaved()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Player.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060037E3 RID: 14307 RVA: 0x000FF24C File Offset: 0x000FD44C
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_UserCode_PlayAnimTargetRpc__String_Protected_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060037E4 RID: 14308 RVA: 0x000FF290 File Offset: 0x000FD490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115018, XrefRangeEnd = 115047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_InvokeUserCode_PlayAnimTargetRpc__String_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037E5 RID: 14309 RVA: 0x000FF2EC File Offset: 0x000FD4EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115047, XrefRangeEnd = 115051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_NotifyJoin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_UserCode_NotifyJoin_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037E6 RID: 14310 RVA: 0x000FF320 File Offset: 0x000FD520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115051, XrefRangeEnd = 115070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_NotifyJoin(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_InvokeUserCode_NotifyJoin_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037E7 RID: 14311 RVA: 0x000FF37C File Offset: 0x000FD57C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 115108, RefRangeEnd = 115109, XrefRangeStart = 115070, XrefRangeEnd = 115108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_CmdDied()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_UserCode_CmdDied_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037E8 RID: 14312 RVA: 0x000FF3B0 File Offset: 0x000FD5B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115109, XrefRangeEnd = 115127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_CmdDied(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_InvokeUserCode_CmdDied_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037E9 RID: 14313 RVA: 0x000FF40C File Offset: 0x000FD60C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115127, XrefRangeEnd = 115128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_CmdDropTools()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_UserCode_CmdDropTools_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037EA RID: 14314 RVA: 0x000FF440 File Offset: 0x000FD640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115128, XrefRangeEnd = 115146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_CmdDropTools(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_InvokeUserCode_CmdDropTools_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037EB RID: 14315 RVA: 0x000FF49C File Offset: 0x000FD69C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115146, XrefRangeEnd = 115169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_EquipTool__Tool(Tool tool)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tool);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_UserCode_EquipTool__Tool_Protected_Void_Tool_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060037EC RID: 14316 RVA: 0x000FF4E0 File Offset: 0x000FD6E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115169, XrefRangeEnd = 115206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_EquipTool__Tool(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_InvokeUserCode_EquipTool__Tool_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037ED RID: 14317 RVA: 0x000FF53C File Offset: 0x000FD73C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115206, XrefRangeEnd = 115215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcSetAnimatorActive__Boolean(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref active;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_UserCode_RpcSetAnimatorActive__Boolean_Protected_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060037EE RID: 14318 RVA: 0x000FF57C File Offset: 0x000FD77C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115215, XrefRangeEnd = 115233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_InvokeUserCode_RpcSetAnimatorActive__Boolean_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037EF RID: 14319 RVA: 0x000FF5D8 File Offset: 0x000FD7D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115233, XrefRangeEnd = 115240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_SetTransformAttrTargetRpc__String__Vector3(string attr, Vector3 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(attr);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_UserCode_SetTransformAttrTargetRpc__String__Vector3_Protected_Void_String_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037F0 RID: 14320 RVA: 0x000FF62C File Offset: 0x000FD82C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115240, XrefRangeEnd = 115257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_SetTransformAttrTargetRpc__String__Vector3(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_InvokeUserCode_SetTransformAttrTargetRpc__String__Vector3_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037F1 RID: 14321 RVA: 0x000FF688 File Offset: 0x000FD888
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 115278, RefRangeEnd = 115279, XrefRangeStart = 115257, XrefRangeEnd = 115278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_CmdTouched__GameObject(GameObject other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_UserCode_CmdTouched__GameObject_Protected_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060037F2 RID: 14322 RVA: 0x000FF6CC File Offset: 0x000FD8CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115279, XrefRangeEnd = 115298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_CmdTouched__GameObject(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_InvokeUserCode_CmdTouched__GameObject_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037F3 RID: 14323 RVA: 0x000FF728 File Offset: 0x000FD928
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 115319, RefRangeEnd = 115320, XrefRangeStart = 115298, XrefRangeEnd = 115319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_CmdTouchEnded__GameObject(GameObject other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_UserCode_CmdTouchEnded__GameObject_Protected_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060037F4 RID: 14324 RVA: 0x000FF76C File Offset: 0x000FD96C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115320, XrefRangeEnd = 115339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_CmdTouchEnded__GameObject(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_InvokeUserCode_CmdTouchEnded__GameObject_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037F5 RID: 14325 RVA: 0x000FF7C8 File Offset: 0x000FD9C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_CmdJumpSound()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_UserCode_CmdJumpSound_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037F6 RID: 14326 RVA: 0x000FF7FC File Offset: 0x000FD9FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115339, XrefRangeEnd = 115375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_CmdJumpSound(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_InvokeUserCode_CmdJumpSound_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037F7 RID: 14327 RVA: 0x000FF858 File Offset: 0x000FDA58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115375, XrefRangeEnd = 115377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcJumpSound()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_UserCode_RpcJumpSound_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037F8 RID: 14328 RVA: 0x000FF88C File Offset: 0x000FDA8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115377, XrefRangeEnd = 115391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_InvokeUserCode_RpcJumpSound_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037F9 RID: 14329 RVA: 0x000FF8E8 File Offset: 0x000FDAE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115391, XrefRangeEnd = 115401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_SendDisconnectMessageTargetRpc__String(string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_UserCode_SendDisconnectMessageTargetRpc__String_Protected_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060037FA RID: 14330 RVA: 0x000FF92C File Offset: 0x000FDB2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115401, XrefRangeEnd = 115425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_SendDisconnectMessageTargetRpc__String(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_InvokeUserCode_SendDisconnectMessageTargetRpc__String_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037FB RID: 14331 RVA: 0x000FF988 File Offset: 0x000FDB88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115425, XrefRangeEnd = 115427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_UnsitTargetRpc__Boolean(bool addForce)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref addForce;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_UserCode_UnsitTargetRpc__Boolean_Protected_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060037FC RID: 14332 RVA: 0x000FF9C8 File Offset: 0x000FDBC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115427, XrefRangeEnd = 115442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_UnsitTargetRpc__Boolean(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_InvokeUserCode_UnsitTargetRpc__Boolean_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037FD RID: 14333 RVA: 0x000FFA24 File Offset: 0x000FDC24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115442, XrefRangeEnd = 115443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_CmdSetSittingIn__Seat(Seat seat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(seat);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_UserCode_CmdSetSittingIn__Seat_Protected_Void_Seat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060037FE RID: 14334 RVA: 0x000FFA68 File Offset: 0x000FDC68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115443, XrefRangeEnd = 115464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_CmdSetSittingIn__Seat(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_InvokeUserCode_CmdSetSittingIn__Seat_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037FF RID: 14335 RVA: 0x000FFAC4 File Offset: 0x000FDCC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115464, XrefRangeEnd = 115465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_CmdNotifyRespawn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_UserCode_CmdNotifyRespawn_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003800 RID: 14336 RVA: 0x000FFAF8 File Offset: 0x000FDCF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115465, XrefRangeEnd = 115483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_CmdNotifyRespawn(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_InvokeUserCode_CmdNotifyRespawn_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003801 RID: 14337 RVA: 0x000FFB54 File Offset: 0x000FDD54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115483, XrefRangeEnd = 115485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_TargetSetPosition__Vector3(Vector3 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pos);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_UserCode_TargetSetPosition__Vector3_Protected_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003802 RID: 14338 RVA: 0x000FFB98 File Offset: 0x000FDD98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115485, XrefRangeEnd = 115496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_TargetSetPosition__Vector3(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_InvokeUserCode_TargetSetPosition__Vector3_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003803 RID: 14339 RVA: 0x000FFBF4 File Offset: 0x000FDDF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115496, XrefRangeEnd = 115498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcSetRespawnTime__Single(float time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_UserCode_RpcSetRespawnTime__Single_Protected_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003804 RID: 14340 RVA: 0x000FFC34 File Offset: 0x000FDE34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115498, XrefRangeEnd = 115509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RpcSetRespawnTime__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_InvokeUserCode_RpcSetRespawnTime__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003805 RID: 14341 RVA: 0x000FFC90 File Offset: 0x000FDE90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115509, XrefRangeEnd = 115526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcSetMaxHealth__Single(float maxHealth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref maxHealth;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_UserCode_RpcSetMaxHealth__Single_Protected_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003806 RID: 14342 RVA: 0x000FFCD0 File Offset: 0x000FDED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115526, XrefRangeEnd = 115552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RpcSetMaxHealth__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_InvokeUserCode_RpcSetMaxHealth__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003807 RID: 14343 RVA: 0x000FFD2C File Offset: 0x000FDF2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115552, XrefRangeEnd = 115554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcSetHealth__Single(float health)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref health;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_UserCode_RpcSetHealth__Single_Protected_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003808 RID: 14344 RVA: 0x000FFD6C File Offset: 0x000FDF6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115554, XrefRangeEnd = 115565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RpcSetHealth__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_InvokeUserCode_RpcSetHealth__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003809 RID: 14345 RVA: 0x000FFDC8 File Offset: 0x000FDFC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115565, XrefRangeEnd = 115579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_CmdSetHealth__Single(float health)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref health;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_UserCode_CmdSetHealth__Single_Protected_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600380A RID: 14346 RVA: 0x000FFE08 File Offset: 0x000FE008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115579, XrefRangeEnd = 115611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_CmdSetHealth__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_InvokeUserCode_CmdSetHealth__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600380B RID: 14347 RVA: 0x000FFE64 File Offset: 0x000FE064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115611, XrefRangeEnd = 115613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcSetWalkSpeed__Single(float walkSpeed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref walkSpeed;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_UserCode_RpcSetWalkSpeed__Single_Protected_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600380C RID: 14348 RVA: 0x000FFEA4 File Offset: 0x000FE0A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115613, XrefRangeEnd = 115624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_InvokeUserCode_RpcSetWalkSpeed__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600380D RID: 14349 RVA: 0x000FFF00 File Offset: 0x000FE100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115624, XrefRangeEnd = 115626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcSetSprintSpeed__Single(float sprintSpeed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sprintSpeed;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_UserCode_RpcSetSprintSpeed__Single_Protected_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600380E RID: 14350 RVA: 0x000FFF40 File Offset: 0x000FE140
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115626, XrefRangeEnd = 115637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RpcSetSprintSpeed__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_InvokeUserCode_RpcSetSprintSpeed__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600380F RID: 14351 RVA: 0x000FFF9C File Offset: 0x000FE19C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115637, XrefRangeEnd = 115639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcSetMaxStamina__Single(float val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_UserCode_RpcSetMaxStamina__Single_Protected_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003810 RID: 14352 RVA: 0x000FFFDC File Offset: 0x000FE1DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115639, XrefRangeEnd = 115650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RpcSetMaxStamina__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_InvokeUserCode_RpcSetMaxStamina__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003811 RID: 14353 RVA: 0x00100038 File Offset: 0x000FE238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115650, XrefRangeEnd = 115652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcSetStamina__Single(float val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_UserCode_RpcSetStamina__Single_Protected_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003812 RID: 14354 RVA: 0x00100078 File Offset: 0x000FE278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115652, XrefRangeEnd = 115663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RpcSetStamina__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_InvokeUserCode_RpcSetStamina__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003813 RID: 14355 RVA: 0x001000D4 File Offset: 0x000FE2D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115663, XrefRangeEnd = 115665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcSetStaminaRegen__Single(float val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_UserCode_RpcSetStaminaRegen__Single_Protected_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003814 RID: 14356 RVA: 0x00100114 File Offset: 0x000FE314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115665, XrefRangeEnd = 115676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RpcSetStaminaRegen__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_InvokeUserCode_RpcSetStaminaRegen__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003815 RID: 14357 RVA: 0x00100170 File Offset: 0x000FE370
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115676, XrefRangeEnd = 115678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcSetStaminaEnabled__Boolean(bool val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_UserCode_RpcSetStaminaEnabled__Boolean_Protected_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003816 RID: 14358 RVA: 0x001001B0 File Offset: 0x000FE3B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115678, XrefRangeEnd = 115693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RpcSetStaminaEnabled__Boolean(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_InvokeUserCode_RpcSetStaminaEnabled__Boolean_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003817 RID: 14359 RVA: 0x0010020C File Offset: 0x000FE40C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115693, XrefRangeEnd = 115710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcSetJumpPower__Single(float jumpPower)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref jumpPower;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_UserCode_RpcSetJumpPower__Single_Protected_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003818 RID: 14360 RVA: 0x0010024C File Offset: 0x000FE44C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115710, XrefRangeEnd = 115736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RpcSetJumpPower__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_InvokeUserCode_RpcSetJumpPower__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003819 RID: 14361 RVA: 0x001002A8 File Offset: 0x000FE4A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115736, XrefRangeEnd = 115738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcSetChatColor__Color(Color col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(col);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_UserCode_RpcSetChatColor__Color_Protected_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600381A RID: 14362 RVA: 0x001002EC File Offset: 0x000FE4EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115738, XrefRangeEnd = 115749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RpcSetChatColor__Color(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_InvokeUserCode_RpcSetChatColor__Color_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600381B RID: 14363 RVA: 0x00100348 File Offset: 0x000FE548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115749, XrefRangeEnd = 115751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcSetCanMove__Boolean(bool canMove)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref canMove;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_UserCode_RpcSetCanMove__Boolean_Protected_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600381C RID: 14364 RVA: 0x00100388 File Offset: 0x000FE588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115751, XrefRangeEnd = 115766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RpcSetCanMove__Boolean(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_InvokeUserCode_RpcSetCanMove__Boolean_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600381D RID: 14365 RVA: 0x001003E4 File Offset: 0x000FE5E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115766, XrefRangeEnd = 115768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcSetAnchored__Boolean(bool anchored)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref anchored;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_UserCode_RpcSetAnchored__Boolean_Protected_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600381E RID: 14366 RVA: 0x00100424 File Offset: 0x000FE624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115768, XrefRangeEnd = 115783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_InvokeUserCode_RpcSetAnchored__Boolean_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600381F RID: 14367 RVA: 0x00100480 File Offset: 0x000FE680
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 115802, RefRangeEnd = 115803, XrefRangeStart = 115783, XrefRangeEnd = 115802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcSetColor__BodyPart__Color(BodyPart bodyPart, Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bodyPart);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(color);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_UserCode_RpcSetColor__BodyPart__Color_Protected_Void_BodyPart_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003820 RID: 14368 RVA: 0x001004D4 File Offset: 0x000FE6D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115803, XrefRangeEnd = 115814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RpcSetColor__BodyPart__Color(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.NativeMethodInfoPtr_InvokeUserCode_RpcSetColor__BodyPart__Color_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003821 RID: 14369 RVA: 0x00100530 File Offset: 0x000FE730
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115814, XrefRangeEnd = 115859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Player.NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003822 RID: 14370 RVA: 0x0010058C File Offset: 0x000FE78C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115859, XrefRangeEnd = 115984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Player.NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003823 RID: 14371 RVA: 0x00015932 File Offset: 0x00013B32
		public Player(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001325 RID: 4901
		// (get) Token: 0x06003824 RID: 14372 RVA: 0x001005E8 File Offset: 0x000FE7E8
		// (set) Token: 0x06003825 RID: 14373 RVA: 0x0001593B File Offset: 0x00013B3B
		public unsafe static bool kicked
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Player.NativeFieldInfoPtr_kicked, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Player.NativeFieldInfoPtr_kicked, (void*)(&value));
			}
		}

		// Token: 0x17001326 RID: 4902
		// (get) Token: 0x06003826 RID: 14374 RVA: 0x00100604 File Offset: 0x000FE804
		// (set) Token: 0x06003827 RID: 14375 RVA: 0x00015949 File Offset: 0x00013B49
		public unsafe static int maxRequestsPerMin
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Player.NativeFieldInfoPtr_maxRequestsPerMin, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Player.NativeFieldInfoPtr_maxRequestsPerMin, (void*)(&value));
			}
		}

		// Token: 0x17001327 RID: 4903
		// (get) Token: 0x06003828 RID: 14376 RVA: 0x00100620 File Offset: 0x000FE820
		// (set) Token: 0x06003829 RID: 14377 RVA: 0x00015957 File Offset: 0x00013B57
		public unsafe static int hatCheckCacheLength
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Player.NativeFieldInfoPtr_hatCheckCacheLength, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Player.NativeFieldInfoPtr_hatCheckCacheLength, (void*)(&value));
			}
		}

		// Token: 0x17001328 RID: 4904
		// (get) Token: 0x0600382A RID: 14378 RVA: 0x0010063C File Offset: 0x000FE83C
		// (set) Token: 0x0600382B RID: 14379 RVA: 0x00015965 File Offset: 0x00013B65
		public unsafe Array keyCodes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_keyCodes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Array>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_keyCodes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001329 RID: 4905
		// (get) Token: 0x0600382C RID: 14380 RVA: 0x0010066C File Offset: 0x000FE86C
		// (set) Token: 0x0600382D RID: 14381 RVA: 0x00015984 File Offset: 0x00013B84
		public unsafe static FootstepCollection footstepSounds
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Player.NativeFieldInfoPtr_footstepSounds, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FootstepCollection>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Player.NativeFieldInfoPtr_footstepSounds, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700132A RID: 4906
		// (get) Token: 0x0600382E RID: 14382 RVA: 0x00100694 File Offset: 0x000FE894
		// (set) Token: 0x0600382F RID: 14383 RVA: 0x00015996 File Offset: 0x00013B96
		public unsafe static float footstepInterval
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Player.NativeFieldInfoPtr_footstepInterval, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Player.NativeFieldInfoPtr_footstepInterval, (void*)(&value));
			}
		}

		// Token: 0x1700132B RID: 4907
		// (get) Token: 0x06003830 RID: 14384 RVA: 0x001006B0 File Offset: 0x000FE8B0
		// (set) Token: 0x06003831 RID: 14385 RVA: 0x000159A4 File Offset: 0x00013BA4
		public unsafe float footstepTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_footstepTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_footstepTimer)) = value;
			}
		}

		// Token: 0x1700132C RID: 4908
		// (get) Token: 0x06003832 RID: 14386 RVA: 0x001006D8 File Offset: 0x000FE8D8
		// (set) Token: 0x06003833 RID: 14387 RVA: 0x000159BF File Offset: 0x00013BBF
		public unsafe int footstepIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_footstepIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_footstepIndex)) = value;
			}
		}

		// Token: 0x1700132D RID: 4909
		// (get) Token: 0x06003834 RID: 14388 RVA: 0x00100700 File Offset: 0x000FE900
		// (set) Token: 0x06003835 RID: 14389 RVA: 0x000159DA File Offset: 0x00013BDA
		public unsafe AudioSource footstepPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_footstepPlayer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_footstepPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700132E RID: 4910
		// (get) Token: 0x06003836 RID: 14390 RVA: 0x00100730 File Offset: 0x000FE930
		// (set) Token: 0x06003837 RID: 14391 RVA: 0x000159F9 File Offset: 0x00013BF9
		public unsafe ParentConstraint parentConstraint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_parentConstraint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParentConstraint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_parentConstraint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700132F RID: 4911
		// (get) Token: 0x06003838 RID: 14392 RVA: 0x00100760 File Offset: 0x000FE960
		// (set) Token: 0x06003839 RID: 14393 RVA: 0x00015A18 File Offset: 0x00013C18
		public unsafe float maxHealth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_maxHealth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_maxHealth)) = value;
			}
		}

		// Token: 0x17001330 RID: 4912
		// (get) Token: 0x0600383A RID: 14394 RVA: 0x00100788 File Offset: 0x000FE988
		// (set) Token: 0x0600383B RID: 14395 RVA: 0x00015A33 File Offset: 0x00013C33
		public unsafe float walkSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_walkSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_walkSpeed)) = value;
			}
		}

		// Token: 0x17001331 RID: 4913
		// (get) Token: 0x0600383C RID: 14396 RVA: 0x001007B0 File Offset: 0x000FE9B0
		// (set) Token: 0x0600383D RID: 14397 RVA: 0x00015A4E File Offset: 0x00013C4E
		public unsafe float sprintSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_sprintSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_sprintSpeed)) = value;
			}
		}

		// Token: 0x17001332 RID: 4914
		// (get) Token: 0x0600383E RID: 14398 RVA: 0x001007D8 File Offset: 0x000FE9D8
		// (set) Token: 0x0600383F RID: 14399 RVA: 0x00015A69 File Offset: 0x00013C69
		public unsafe float health
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_health);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_health)) = value;
			}
		}

		// Token: 0x17001333 RID: 4915
		// (get) Token: 0x06003840 RID: 14400 RVA: 0x00100800 File Offset: 0x000FEA00
		// (set) Token: 0x06003841 RID: 14401 RVA: 0x00015A84 File Offset: 0x00013C84
		public unsafe bool isSprinting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_isSprinting);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_isSprinting)) = value;
			}
		}

		// Token: 0x17001334 RID: 4916
		// (get) Token: 0x06003842 RID: 14402 RVA: 0x00100828 File Offset: 0x000FEA28
		// (set) Token: 0x06003843 RID: 14403 RVA: 0x00015A9F File Offset: 0x00013C9F
		public unsafe bool sprintExhausted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_sprintExhausted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_sprintExhausted)) = value;
			}
		}

		// Token: 0x17001335 RID: 4917
		// (get) Token: 0x06003844 RID: 14404 RVA: 0x00100850 File Offset: 0x000FEA50
		// (set) Token: 0x06003845 RID: 14405 RVA: 0x00015ABA File Offset: 0x00013CBA
		public unsafe bool staminaEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_staminaEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_staminaEnabled)) = value;
			}
		}

		// Token: 0x17001336 RID: 4918
		// (get) Token: 0x06003846 RID: 14406 RVA: 0x00100878 File Offset: 0x000FEA78
		// (set) Token: 0x06003847 RID: 14407 RVA: 0x00015AD5 File Offset: 0x00013CD5
		public unsafe float stamina
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_stamina);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_stamina)) = value;
			}
		}

		// Token: 0x17001337 RID: 4919
		// (get) Token: 0x06003848 RID: 14408 RVA: 0x001008A0 File Offset: 0x000FEAA0
		// (set) Token: 0x06003849 RID: 14409 RVA: 0x00015AF0 File Offset: 0x00013CF0
		public unsafe float maxStamina
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_maxStamina);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_maxStamina)) = value;
			}
		}

		// Token: 0x17001338 RID: 4920
		// (get) Token: 0x0600384A RID: 14410 RVA: 0x001008C8 File Offset: 0x000FEAC8
		// (set) Token: 0x0600384B RID: 14411 RVA: 0x00015B0B File Offset: 0x00013D0B
		public unsafe float staminaRegen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_staminaRegen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_staminaRegen)) = value;
			}
		}

		// Token: 0x17001339 RID: 4921
		// (get) Token: 0x0600384C RID: 14412 RVA: 0x001008F0 File Offset: 0x000FEAF0
		// (set) Token: 0x0600384D RID: 14413 RVA: 0x00015B26 File Offset: 0x00013D26
		public unsafe float jumpPower
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_jumpPower);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_jumpPower)) = value;
			}
		}

		// Token: 0x1700133A RID: 4922
		// (get) Token: 0x0600384E RID: 14414 RVA: 0x00100918 File Offset: 0x000FEB18
		// (set) Token: 0x0600384F RID: 14415 RVA: 0x00015B41 File Offset: 0x00013D41
		public unsafe float respawnTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_respawnTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_respawnTime)) = value;
			}
		}

		// Token: 0x1700133B RID: 4923
		// (get) Token: 0x06003850 RID: 14416 RVA: 0x00100940 File Offset: 0x000FEB40
		// (set) Token: 0x06003851 RID: 14417 RVA: 0x00015B5C File Offset: 0x00013D5C
		public unsafe int userID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_userID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_userID)) = value;
			}
		}

		// Token: 0x1700133C RID: 4924
		// (get) Token: 0x06003852 RID: 14418 RVA: 0x00100968 File Offset: 0x000FEB68
		// (set) Token: 0x06003853 RID: 14419 RVA: 0x00015B77 File Offset: 0x00013D77
		public unsafe bool loaded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_loaded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_loaded)) = value;
			}
		}

		// Token: 0x1700133D RID: 4925
		// (get) Token: 0x06003854 RID: 14420 RVA: 0x00100990 File Offset: 0x000FEB90
		// (set) Token: 0x06003855 RID: 14421 RVA: 0x00015B92 File Offset: 0x00013D92
		public unsafe bool isCreator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_isCreator);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_isCreator)) = value;
			}
		}

		// Token: 0x1700133E RID: 4926
		// (get) Token: 0x06003856 RID: 14422 RVA: 0x001009B8 File Offset: 0x000FEBB8
		// (set) Token: 0x06003857 RID: 14423 RVA: 0x00015BAD File Offset: 0x00013DAD
		public unsafe bool isAdmin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_isAdmin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_isAdmin)) = value;
			}
		}

		// Token: 0x1700133F RID: 4927
		// (get) Token: 0x06003858 RID: 14424 RVA: 0x001009E0 File Offset: 0x000FEBE0
		// (set) Token: 0x06003859 RID: 14425 RVA: 0x00015BC8 File Offset: 0x00013DC8
		public unsafe Color chatColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_chatColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_chatColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001340 RID: 4928
		// (get) Token: 0x0600385A RID: 14426 RVA: 0x00100A10 File Offset: 0x000FEC10
		// (set) Token: 0x0600385B RID: 14427 RVA: 0x00015BE7 File Offset: 0x00013DE7
		public unsafe string avatarHash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_avatarHash);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_avatarHash), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001341 RID: 4929
		// (get) Token: 0x0600385C RID: 14428 RVA: 0x00100A38 File Offset: 0x000FEC38
		// (set) Token: 0x0600385D RID: 14429 RVA: 0x00015C06 File Offset: 0x00013E06
		public unsafe bool canMove
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_canMove);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_canMove)) = value;
			}
		}

		// Token: 0x17001342 RID: 4930
		// (get) Token: 0x0600385E RID: 14430 RVA: 0x00100A60 File Offset: 0x000FEC60
		// (set) Token: 0x0600385F RID: 14431 RVA: 0x00015C21 File Offset: 0x00013E21
		public unsafe bool anchored
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_anchored);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_anchored)) = value;
			}
		}

		// Token: 0x17001343 RID: 4931
		// (get) Token: 0x06003860 RID: 14432 RVA: 0x00100A88 File Offset: 0x000FEC88
		// (set) Token: 0x06003861 RID: 14433 RVA: 0x00015C3C File Offset: 0x00013E3C
		public unsafe string LeaderboardBadgeId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_LeaderboardBadgeId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_LeaderboardBadgeId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001344 RID: 4932
		// (get) Token: 0x06003862 RID: 14434 RVA: 0x00100AB0 File Offset: 0x000FECB0
		// (set) Token: 0x06003863 RID: 14435 RVA: 0x00015C5B File Offset: 0x00013E5B
		public unsafe bool canChat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_canChat);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_canChat)) = value;
			}
		}

		// Token: 0x17001345 RID: 4933
		// (get) Token: 0x06003864 RID: 14436 RVA: 0x00100AD8 File Offset: 0x000FECD8
		// (set) Token: 0x06003865 RID: 14437 RVA: 0x00015C76 File Offset: 0x00013E76
		public unsafe bool isAgeRestricted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_isAgeRestricted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_isAgeRestricted)) = value;
			}
		}

		// Token: 0x17001346 RID: 4934
		// (get) Token: 0x06003866 RID: 14438 RVA: 0x00100B00 File Offset: 0x000FED00
		// (set) Token: 0x06003867 RID: 14439 RVA: 0x00015C91 File Offset: 0x00013E91
		public unsafe float turnSmoothing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_turnSmoothing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_turnSmoothing)) = value;
			}
		}

		// Token: 0x17001347 RID: 4935
		// (get) Token: 0x06003868 RID: 14440 RVA: 0x00100B28 File Offset: 0x000FED28
		// (set) Token: 0x06003869 RID: 14441 RVA: 0x00015CAC File Offset: 0x00013EAC
		public unsafe LayerMask ignoreLayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_ignoreLayer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LayerMask>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_ignoreLayer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001348 RID: 4936
		// (get) Token: 0x0600386A RID: 14442 RVA: 0x00100B58 File Offset: 0x000FED58
		// (set) Token: 0x0600386B RID: 14443 RVA: 0x00015CCB File Offset: 0x00013ECB
		public unsafe Animator anim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_anim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001349 RID: 4937
		// (get) Token: 0x0600386C RID: 14444 RVA: 0x00100B88 File Offset: 0x000FED88
		// (set) Token: 0x0600386D RID: 14445 RVA: 0x00015CEA File Offset: 0x00013EEA
		public unsafe Rigidbody rb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_rb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_rb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700134A RID: 4938
		// (get) Token: 0x0600386E RID: 14446 RVA: 0x00100BB8 File Offset: 0x000FEDB8
		// (set) Token: 0x0600386F RID: 14447 RVA: 0x00015D09 File Offset: 0x00013F09
		public unsafe List<MeshRenderer> disableOnFP
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_disableOnFP);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_disableOnFP), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700134B RID: 4939
		// (get) Token: 0x06003870 RID: 14448 RVA: 0x00100BE8 File Offset: 0x000FEDE8
		// (set) Token: 0x06003871 RID: 14449 RVA: 0x00015D28 File Offset: 0x00013F28
		public unsafe List<Rigidbody> deathBodyParts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_deathBodyParts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Rigidbody>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_deathBodyParts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700134C RID: 4940
		// (get) Token: 0x06003872 RID: 14450 RVA: 0x00100C18 File Offset: 0x000FEE18
		// (set) Token: 0x06003873 RID: 14451 RVA: 0x00015D47 File Offset: 0x00013F47
		public unsafe Transform toolAttachPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_toolAttachPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_toolAttachPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700134D RID: 4941
		// (get) Token: 0x06003874 RID: 14452 RVA: 0x00100C48 File Offset: 0x000FEE48
		// (set) Token: 0x06003875 RID: 14453 RVA: 0x00015D66 File Offset: 0x00013F66
		public unsafe Transform camAttachment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_camAttachment);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_camAttachment), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700134E RID: 4942
		// (get) Token: 0x06003876 RID: 14454 RVA: 0x00100C78 File Offset: 0x000FEE78
		// (set) Token: 0x06003877 RID: 14455 RVA: 0x00015D85 File Offset: 0x00013F85
		public unsafe int shirtID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_shirtID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_shirtID)) = value;
			}
		}

		// Token: 0x1700134F RID: 4943
		// (get) Token: 0x06003878 RID: 14456 RVA: 0x00100CA0 File Offset: 0x000FEEA0
		// (set) Token: 0x06003879 RID: 14457 RVA: 0x00015DA0 File Offset: 0x00013FA0
		public unsafe int pantsID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_pantsID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_pantsID)) = value;
			}
		}

		// Token: 0x17001350 RID: 4944
		// (get) Token: 0x0600387A RID: 14458 RVA: 0x00100CC8 File Offset: 0x000FEEC8
		// (set) Token: 0x0600387B RID: 14459 RVA: 0x00015DBB File Offset: 0x00013FBB
		public unsafe int faceID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_faceID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_faceID)) = value;
			}
		}

		// Token: 0x17001351 RID: 4945
		// (get) Token: 0x0600387C RID: 14460 RVA: 0x00100CF0 File Offset: 0x000FEEF0
		// (set) Token: 0x0600387D RID: 14461 RVA: 0x00015DD6 File Offset: 0x00013FD6
		public unsafe float coyoteTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_coyoteTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_coyoteTime)) = value;
			}
		}

		// Token: 0x17001352 RID: 4946
		// (get) Token: 0x0600387E RID: 14462 RVA: 0x00100D18 File Offset: 0x000FEF18
		// (set) Token: 0x0600387F RID: 14463 RVA: 0x00015DF1 File Offset: 0x00013FF1
		public unsafe float coyoteTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_coyoteTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_coyoteTimer)) = value;
			}
		}

		// Token: 0x17001353 RID: 4947
		// (get) Token: 0x06003880 RID: 14464 RVA: 0x00100D40 File Offset: 0x000FEF40
		// (set) Token: 0x06003881 RID: 14465 RVA: 0x00015E0C File Offset: 0x0001400C
		public unsafe Collider col
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_col);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_col), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001354 RID: 4948
		// (get) Token: 0x06003882 RID: 14466 RVA: 0x00100D70 File Offset: 0x000FEF70
		// (set) Token: 0x06003883 RID: 14467 RVA: 0x00015E2B File Offset: 0x0001402B
		public unsafe PhysicsMaterial airMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_airMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhysicsMaterial>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_airMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001355 RID: 4949
		// (get) Token: 0x06003884 RID: 14468 RVA: 0x00100DA0 File Offset: 0x000FEFA0
		// (set) Token: 0x06003885 RID: 14469 RVA: 0x00015E4A File Offset: 0x0001404A
		public unsafe PhysicsMaterial groundMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_groundMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhysicsMaterial>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_groundMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001356 RID: 4950
		// (get) Token: 0x06003886 RID: 14470 RVA: 0x00100DD0 File Offset: 0x000FEFD0
		// (set) Token: 0x06003887 RID: 14471 RVA: 0x00015E69 File Offset: 0x00014069
		public unsafe Dictionary<Rigidbody, Vector3> defaultBodyPartPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_defaultBodyPartPos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Rigidbody, Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_defaultBodyPartPos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001357 RID: 4951
		// (get) Token: 0x06003888 RID: 14472 RVA: 0x00100E00 File Offset: 0x000FF000
		// (set) Token: 0x06003889 RID: 14473 RVA: 0x00015E88 File Offset: 0x00014088
		public unsafe Transform head
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_head);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_head), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001358 RID: 4952
		// (get) Token: 0x0600388A RID: 14474 RVA: 0x00100E30 File Offset: 0x000FF030
		// (set) Token: 0x0600388B RID: 14475 RVA: 0x00015EA7 File Offset: 0x000140A7
		public unsafe Transform leftArm
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_leftArm);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_leftArm), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001359 RID: 4953
		// (get) Token: 0x0600388C RID: 14476 RVA: 0x00100E60 File Offset: 0x000FF060
		// (set) Token: 0x0600388D RID: 14477 RVA: 0x00015EC6 File Offset: 0x000140C6
		public unsafe Transform rightArm
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_rightArm);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_rightArm), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700135A RID: 4954
		// (get) Token: 0x0600388E RID: 14478 RVA: 0x00100E90 File Offset: 0x000FF090
		// (set) Token: 0x0600388F RID: 14479 RVA: 0x00015EE5 File Offset: 0x000140E5
		public unsafe Transform torso
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_torso);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_torso), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700135B RID: 4955
		// (get) Token: 0x06003890 RID: 14480 RVA: 0x00100EC0 File Offset: 0x000FF0C0
		// (set) Token: 0x06003891 RID: 14481 RVA: 0x00015F04 File Offset: 0x00014104
		public unsafe Transform leftLeg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_leftLeg);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_leftLeg), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700135C RID: 4956
		// (get) Token: 0x06003892 RID: 14482 RVA: 0x00100EF0 File Offset: 0x000FF0F0
		// (set) Token: 0x06003893 RID: 14483 RVA: 0x00015F23 File Offset: 0x00014123
		public unsafe Transform rightLeg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_rightLeg);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_rightLeg), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700135D RID: 4957
		// (get) Token: 0x06003894 RID: 14484 RVA: 0x00100F20 File Offset: 0x000FF120
		// (set) Token: 0x06003895 RID: 14485 RVA: 0x00015F42 File Offset: 0x00014142
		public unsafe NetworkAnimator netAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_netAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkAnimator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_netAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700135E RID: 4958
		// (get) Token: 0x06003896 RID: 14486 RVA: 0x00100F50 File Offset: 0x000FF150
		// (set) Token: 0x06003897 RID: 14487 RVA: 0x00015F61 File Offset: 0x00014161
		public unsafe float maxStepHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_maxStepHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_maxStepHeight)) = value;
			}
		}

		// Token: 0x1700135F RID: 4959
		// (get) Token: 0x06003898 RID: 14488 RVA: 0x00100F78 File Offset: 0x000FF178
		// (set) Token: 0x06003899 RID: 14489 RVA: 0x00015F7C File Offset: 0x0001417C
		public unsafe float stepSearchOvershoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_stepSearchOvershoot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_stepSearchOvershoot)) = value;
			}
		}

		// Token: 0x17001360 RID: 4960
		// (get) Token: 0x0600389A RID: 14490 RVA: 0x00100FA0 File Offset: 0x000FF1A0
		// (set) Token: 0x0600389B RID: 14491 RVA: 0x00015F97 File Offset: 0x00014197
		public unsafe List<ContactPoint> allCPs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_allCPs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ContactPoint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_allCPs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001361 RID: 4961
		// (get) Token: 0x0600389C RID: 14492 RVA: 0x00100FD0 File Offset: 0x000FF1D0
		// (set) Token: 0x0600389D RID: 14493 RVA: 0x00015FB6 File Offset: 0x000141B6
		public unsafe Vector3 lastVelocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_lastVelocity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_lastVelocity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001362 RID: 4962
		// (get) Token: 0x0600389E RID: 14494 RVA: 0x00101000 File Offset: 0x000FF200
		// (set) Token: 0x0600389F RID: 14495 RVA: 0x00015FD5 File Offset: 0x000141D5
		public unsafe float afkTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_afkTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_afkTimer)) = value;
			}
		}

		// Token: 0x17001363 RID: 4963
		// (get) Token: 0x060038A0 RID: 14496 RVA: 0x00101028 File Offset: 0x000FF228
		// (set) Token: 0x060038A1 RID: 14497 RVA: 0x00015FF0 File Offset: 0x000141F0
		public unsafe float maxAfkTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_maxAfkTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_maxAfkTime)) = value;
			}
		}

		// Token: 0x17001364 RID: 4964
		// (get) Token: 0x060038A2 RID: 14498 RVA: 0x00101050 File Offset: 0x000FF250
		// (set) Token: 0x060038A3 RID: 14499 RVA: 0x0001600B File Offset: 0x0001420B
		public unsafe bool isDead
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_isDead);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_isDead)) = value;
			}
		}

		// Token: 0x17001365 RID: 4965
		// (get) Token: 0x060038A4 RID: 14500 RVA: 0x00101078 File Offset: 0x000FF278
		// (set) Token: 0x060038A5 RID: 14501 RVA: 0x00016026 File Offset: 0x00014226
		public unsafe float jumpCooldown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_jumpCooldown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_jumpCooldown)) = value;
			}
		}

		// Token: 0x17001366 RID: 4966
		// (get) Token: 0x060038A6 RID: 14502 RVA: 0x001010A0 File Offset: 0x000FF2A0
		// (set) Token: 0x060038A7 RID: 14503 RVA: 0x00016041 File Offset: 0x00014241
		public unsafe float currentSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_currentSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_currentSpeed)) = value;
			}
		}

		// Token: 0x17001367 RID: 4967
		// (get) Token: 0x060038A8 RID: 14504 RVA: 0x001010C8 File Offset: 0x000FF2C8
		// (set) Token: 0x060038A9 RID: 14505 RVA: 0x0001605C File Offset: 0x0001425C
		public unsafe TMP_Text nametag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_nametag);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_nametag), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001368 RID: 4968
		// (get) Token: 0x060038AA RID: 14506 RVA: 0x001010F8 File Offset: 0x000FF2F8
		// (set) Token: 0x060038AB RID: 14507 RVA: 0x0001607B File Offset: 0x0001427B
		public unsafe Vector3 oldPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_oldPos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_oldPos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001369 RID: 4969
		// (get) Token: 0x060038AC RID: 14508 RVA: 0x00101128 File Offset: 0x000FF328
		// (set) Token: 0x060038AD RID: 14509 RVA: 0x0001609A File Offset: 0x0001429A
		public unsafe Seat sittingIn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_sittingIn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Seat>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_sittingIn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700136A RID: 4970
		// (get) Token: 0x060038AE RID: 14510 RVA: 0x00101158 File Offset: 0x000FF358
		// (set) Token: 0x060038AF RID: 14511 RVA: 0x000160B9 File Offset: 0x000142B9
		public unsafe LuaEvent Chatted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_Chatted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LuaEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_Chatted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700136B RID: 4971
		// (get) Token: 0x060038B0 RID: 14512 RVA: 0x00101188 File Offset: 0x000FF388
		// (set) Token: 0x060038B1 RID: 14513 RVA: 0x000160D8 File Offset: 0x000142D8
		public unsafe LuaEvent Died
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_Died);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LuaEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_Died), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700136C RID: 4972
		// (get) Token: 0x060038B2 RID: 14514 RVA: 0x001011B8 File Offset: 0x000FF3B8
		// (set) Token: 0x060038B3 RID: 14515 RVA: 0x000160F7 File Offset: 0x000142F7
		public unsafe LuaEvent Respawned
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_Respawned);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LuaEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_Respawned), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700136D RID: 4973
		// (get) Token: 0x060038B4 RID: 14516 RVA: 0x001011E8 File Offset: 0x000FF3E8
		// (set) Token: 0x060038B5 RID: 14517 RVA: 0x00016116 File Offset: 0x00014316
		public unsafe Environment _env
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__env);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Environment>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr__env), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700136E RID: 4974
		// (get) Token: 0x060038B6 RID: 14518 RVA: 0x00101218 File Offset: 0x000FF418
		// (set) Token: 0x060038B7 RID: 14519 RVA: 0x00016135 File Offset: 0x00014335
		public unsafe Dictionary<int, bool> assetOwnCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_assetOwnCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_assetOwnCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700136F RID: 4975
		// (get) Token: 0x060038B8 RID: 14520 RVA: 0x00101248 File Offset: 0x000FF448
		// (set) Token: 0x060038B9 RID: 14521 RVA: 0x00016154 File Offset: 0x00014354
		public unsafe Dictionary<int, int> assetCacheCheckTimes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_assetCacheCheckTimes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_assetCacheCheckTimes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001370 RID: 4976
		// (get) Token: 0x060038BA RID: 14522 RVA: 0x00101278 File Offset: 0x000FF478
		// (set) Token: 0x060038BB RID: 14523 RVA: 0x00016173 File Offset: 0x00014373
		public unsafe static Dictionary<int, int> assetCheckCounts
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Player.NativeFieldInfoPtr_assetCheckCounts, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Player.NativeFieldInfoPtr_assetCheckCounts, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001371 RID: 4977
		// (get) Token: 0x060038BC RID: 14524 RVA: 0x001012A0 File Offset: 0x000FF4A0
		// (set) Token: 0x060038BD RID: 14525 RVA: 0x00016185 File Offset: 0x00014385
		public unsafe float defaultFov
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_defaultFov);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_defaultFov)) = value;
			}
		}

		// Token: 0x17001372 RID: 4978
		// (get) Token: 0x060038BE RID: 14526 RVA: 0x001012C8 File Offset: 0x000FF4C8
		// (set) Token: 0x060038BF RID: 14527 RVA: 0x000161A0 File Offset: 0x000143A0
		public unsafe float sprintFov
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_sprintFov);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_sprintFov)) = value;
			}
		}

		// Token: 0x17001373 RID: 4979
		// (get) Token: 0x060038C0 RID: 14528 RVA: 0x001012F0 File Offset: 0x000FF4F0
		// (set) Token: 0x060038C1 RID: 14529 RVA: 0x000161BB File Offset: 0x000143BB
		public unsafe AppearanceLoaderBase appearance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_appearance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AppearanceLoaderBase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_appearance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001374 RID: 4980
		// (get) Token: 0x060038C2 RID: 14530 RVA: 0x00101320 File Offset: 0x000FF520
		// (set) Token: 0x060038C3 RID: 14531 RVA: 0x000161DA File Offset: 0x000143DA
		public unsafe Camera cam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_cam);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_cam), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001375 RID: 4981
		// (get) Token: 0x060038C4 RID: 14532 RVA: 0x00101350 File Offset: 0x000FF550
		// (set) Token: 0x060038C5 RID: 14533 RVA: 0x000161F9 File Offset: 0x000143F9
		public unsafe bool climbing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_climbing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_climbing)) = value;
			}
		}

		// Token: 0x17001376 RID: 4982
		// (get) Token: 0x060038C6 RID: 14534 RVA: 0x00101378 File Offset: 0x000FF578
		// (set) Token: 0x060038C7 RID: 14535 RVA: 0x00016214 File Offset: 0x00014414
		public unsafe bool isEmote
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_isEmote);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr_isEmote)) = value;
			}
		}

		// Token: 0x17001377 RID: 4983
		// (get) Token: 0x060038C8 RID: 14536 RVA: 0x001013A0 File Offset: 0x000FF5A0
		// (set) Token: 0x060038C9 RID: 14537 RVA: 0x0001622F File Offset: 0x0001442F
		public unsafe NetworkBehaviourSyncVar ___sittingInNetId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr____sittingInNetId);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkBehaviourSyncVar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player.NativeFieldInfoPtr____sittingInNetId), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002A9D RID: 10909
		private static readonly IntPtr NativeFieldInfoPtr_kicked;

		// Token: 0x04002A9E RID: 10910
		private static readonly IntPtr NativeFieldInfoPtr_maxRequestsPerMin;

		// Token: 0x04002A9F RID: 10911
		private static readonly IntPtr NativeFieldInfoPtr_hatCheckCacheLength;

		// Token: 0x04002AA0 RID: 10912
		private static readonly IntPtr NativeFieldInfoPtr_keyCodes;

		// Token: 0x04002AA1 RID: 10913
		private static readonly IntPtr NativeFieldInfoPtr_footstepSounds;

		// Token: 0x04002AA2 RID: 10914
		private static readonly IntPtr NativeFieldInfoPtr_footstepInterval;

		// Token: 0x04002AA3 RID: 10915
		private static readonly IntPtr NativeFieldInfoPtr_footstepTimer;

		// Token: 0x04002AA4 RID: 10916
		private static readonly IntPtr NativeFieldInfoPtr_footstepIndex;

		// Token: 0x04002AA5 RID: 10917
		private static readonly IntPtr NativeFieldInfoPtr_footstepPlayer;

		// Token: 0x04002AA6 RID: 10918
		private static readonly IntPtr NativeFieldInfoPtr_parentConstraint;

		// Token: 0x04002AA7 RID: 10919
		private static readonly IntPtr NativeFieldInfoPtr_maxHealth;

		// Token: 0x04002AA8 RID: 10920
		private static readonly IntPtr NativeFieldInfoPtr_walkSpeed;

		// Token: 0x04002AA9 RID: 10921
		private static readonly IntPtr NativeFieldInfoPtr_sprintSpeed;

		// Token: 0x04002AAA RID: 10922
		private static readonly IntPtr NativeFieldInfoPtr_health;

		// Token: 0x04002AAB RID: 10923
		private static readonly IntPtr NativeFieldInfoPtr_isSprinting;

		// Token: 0x04002AAC RID: 10924
		private static readonly IntPtr NativeFieldInfoPtr_sprintExhausted;

		// Token: 0x04002AAD RID: 10925
		private static readonly IntPtr NativeFieldInfoPtr_staminaEnabled;

		// Token: 0x04002AAE RID: 10926
		private static readonly IntPtr NativeFieldInfoPtr_stamina;

		// Token: 0x04002AAF RID: 10927
		private static readonly IntPtr NativeFieldInfoPtr_maxStamina;

		// Token: 0x04002AB0 RID: 10928
		private static readonly IntPtr NativeFieldInfoPtr_staminaRegen;

		// Token: 0x04002AB1 RID: 10929
		private static readonly IntPtr NativeFieldInfoPtr_jumpPower;

		// Token: 0x04002AB2 RID: 10930
		private static readonly IntPtr NativeFieldInfoPtr_respawnTime;

		// Token: 0x04002AB3 RID: 10931
		private static readonly IntPtr NativeFieldInfoPtr_userID;

		// Token: 0x04002AB4 RID: 10932
		private static readonly IntPtr NativeFieldInfoPtr_loaded;

		// Token: 0x04002AB5 RID: 10933
		private static readonly IntPtr NativeFieldInfoPtr_isCreator;

		// Token: 0x04002AB6 RID: 10934
		private static readonly IntPtr NativeFieldInfoPtr_isAdmin;

		// Token: 0x04002AB7 RID: 10935
		private static readonly IntPtr NativeFieldInfoPtr_chatColor;

		// Token: 0x04002AB8 RID: 10936
		private static readonly IntPtr NativeFieldInfoPtr_avatarHash;

		// Token: 0x04002AB9 RID: 10937
		private static readonly IntPtr NativeFieldInfoPtr_canMove;

		// Token: 0x04002ABA RID: 10938
		private static readonly IntPtr NativeFieldInfoPtr_anchored;

		// Token: 0x04002ABB RID: 10939
		private static readonly IntPtr NativeFieldInfoPtr_LeaderboardBadgeId;

		// Token: 0x04002ABC RID: 10940
		private static readonly IntPtr NativeFieldInfoPtr_canChat;

		// Token: 0x04002ABD RID: 10941
		private static readonly IntPtr NativeFieldInfoPtr_isAgeRestricted;

		// Token: 0x04002ABE RID: 10942
		private static readonly IntPtr NativeFieldInfoPtr_turnSmoothing;

		// Token: 0x04002ABF RID: 10943
		private static readonly IntPtr NativeFieldInfoPtr_ignoreLayer;

		// Token: 0x04002AC0 RID: 10944
		private static readonly IntPtr NativeFieldInfoPtr_anim;

		// Token: 0x04002AC1 RID: 10945
		private static readonly IntPtr NativeFieldInfoPtr_rb;

		// Token: 0x04002AC2 RID: 10946
		private static readonly IntPtr NativeFieldInfoPtr_disableOnFP;

		// Token: 0x04002AC3 RID: 10947
		private static readonly IntPtr NativeFieldInfoPtr_deathBodyParts;

		// Token: 0x04002AC4 RID: 10948
		private static readonly IntPtr NativeFieldInfoPtr_toolAttachPoint;

		// Token: 0x04002AC5 RID: 10949
		private static readonly IntPtr NativeFieldInfoPtr_camAttachment;

		// Token: 0x04002AC6 RID: 10950
		private static readonly IntPtr NativeFieldInfoPtr_shirtID;

		// Token: 0x04002AC7 RID: 10951
		private static readonly IntPtr NativeFieldInfoPtr_pantsID;

		// Token: 0x04002AC8 RID: 10952
		private static readonly IntPtr NativeFieldInfoPtr_faceID;

		// Token: 0x04002AC9 RID: 10953
		private static readonly IntPtr NativeFieldInfoPtr_coyoteTime;

		// Token: 0x04002ACA RID: 10954
		private static readonly IntPtr NativeFieldInfoPtr_coyoteTimer;

		// Token: 0x04002ACB RID: 10955
		private static readonly IntPtr NativeFieldInfoPtr_col;

		// Token: 0x04002ACC RID: 10956
		private static readonly IntPtr NativeFieldInfoPtr_airMaterial;

		// Token: 0x04002ACD RID: 10957
		private static readonly IntPtr NativeFieldInfoPtr_groundMaterial;

		// Token: 0x04002ACE RID: 10958
		private static readonly IntPtr NativeFieldInfoPtr_defaultBodyPartPos;

		// Token: 0x04002ACF RID: 10959
		private static readonly IntPtr NativeFieldInfoPtr_head;

		// Token: 0x04002AD0 RID: 10960
		private static readonly IntPtr NativeFieldInfoPtr_leftArm;

		// Token: 0x04002AD1 RID: 10961
		private static readonly IntPtr NativeFieldInfoPtr_rightArm;

		// Token: 0x04002AD2 RID: 10962
		private static readonly IntPtr NativeFieldInfoPtr_torso;

		// Token: 0x04002AD3 RID: 10963
		private static readonly IntPtr NativeFieldInfoPtr_leftLeg;

		// Token: 0x04002AD4 RID: 10964
		private static readonly IntPtr NativeFieldInfoPtr_rightLeg;

		// Token: 0x04002AD5 RID: 10965
		private static readonly IntPtr NativeFieldInfoPtr_netAnim;

		// Token: 0x04002AD6 RID: 10966
		private static readonly IntPtr NativeFieldInfoPtr_maxStepHeight;

		// Token: 0x04002AD7 RID: 10967
		private static readonly IntPtr NativeFieldInfoPtr_stepSearchOvershoot;

		// Token: 0x04002AD8 RID: 10968
		private static readonly IntPtr NativeFieldInfoPtr_allCPs;

		// Token: 0x04002AD9 RID: 10969
		private static readonly IntPtr NativeFieldInfoPtr_lastVelocity;

		// Token: 0x04002ADA RID: 10970
		private static readonly IntPtr NativeFieldInfoPtr_afkTimer;

		// Token: 0x04002ADB RID: 10971
		private static readonly IntPtr NativeFieldInfoPtr_maxAfkTime;

		// Token: 0x04002ADC RID: 10972
		private static readonly IntPtr NativeFieldInfoPtr_isDead;

		// Token: 0x04002ADD RID: 10973
		private static readonly IntPtr NativeFieldInfoPtr_jumpCooldown;

		// Token: 0x04002ADE RID: 10974
		private static readonly IntPtr NativeFieldInfoPtr_currentSpeed;

		// Token: 0x04002ADF RID: 10975
		private static readonly IntPtr NativeFieldInfoPtr_nametag;

		// Token: 0x04002AE0 RID: 10976
		private static readonly IntPtr NativeFieldInfoPtr_oldPos;

		// Token: 0x04002AE1 RID: 10977
		private static readonly IntPtr NativeFieldInfoPtr_sittingIn;

		// Token: 0x04002AE2 RID: 10978
		private static readonly IntPtr NativeFieldInfoPtr_Chatted;

		// Token: 0x04002AE3 RID: 10979
		private static readonly IntPtr NativeFieldInfoPtr_Died;

		// Token: 0x04002AE4 RID: 10980
		private static readonly IntPtr NativeFieldInfoPtr_Respawned;

		// Token: 0x04002AE5 RID: 10981
		private static readonly IntPtr NativeFieldInfoPtr__env;

		// Token: 0x04002AE6 RID: 10982
		private static readonly IntPtr NativeFieldInfoPtr_assetOwnCache;

		// Token: 0x04002AE7 RID: 10983
		private static readonly IntPtr NativeFieldInfoPtr_assetCacheCheckTimes;

		// Token: 0x04002AE8 RID: 10984
		private static readonly IntPtr NativeFieldInfoPtr_assetCheckCounts;

		// Token: 0x04002AE9 RID: 10985
		private static readonly IntPtr NativeFieldInfoPtr_defaultFov;

		// Token: 0x04002AEA RID: 10986
		private static readonly IntPtr NativeFieldInfoPtr_sprintFov;

		// Token: 0x04002AEB RID: 10987
		private static readonly IntPtr NativeFieldInfoPtr_appearance;

		// Token: 0x04002AEC RID: 10988
		private static readonly IntPtr NativeFieldInfoPtr_cam;

		// Token: 0x04002AED RID: 10989
		private static readonly IntPtr NativeFieldInfoPtr_climbing;

		// Token: 0x04002AEE RID: 10990
		private static readonly IntPtr NativeFieldInfoPtr_isEmote;

		// Token: 0x04002AEF RID: 10991
		private static readonly IntPtr NativeFieldInfoPtr____sittingInNetId;

		// Token: 0x04002AF0 RID: 10992
		private static readonly IntPtr NativeMethodInfoPtr_get_IsLocalPlayer_Public_get_Boolean_0;

		// Token: 0x04002AF1 RID: 10993
		private static readonly IntPtr NativeMethodInfoPtr_get_IsLoaded_Public_get_Boolean_0;

		// Token: 0x04002AF2 RID: 10994
		private static readonly IntPtr NativeMethodInfoPtr_get_RespawnTime_Public_get_Single_0;

		// Token: 0x04002AF3 RID: 10995
		private static readonly IntPtr NativeMethodInfoPtr_set_RespawnTime_Public_set_Void_Single_0;

		// Token: 0x04002AF4 RID: 10996
		private static readonly IntPtr NativeMethodInfoPtr_get_Velocity_Public_get_Vector3_0;

		// Token: 0x04002AF5 RID: 10997
		private static readonly IntPtr NativeMethodInfoPtr_set_Velocity_Public_set_Void_Vector3_0;

		// Token: 0x04002AF6 RID: 10998
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxHealth_Public_get_Single_0;

		// Token: 0x04002AF7 RID: 10999
		private static readonly IntPtr NativeMethodInfoPtr_set_MaxHealth_Public_set_Void_Single_0;

		// Token: 0x04002AF8 RID: 11000
		private static readonly IntPtr NativeMethodInfoPtr_get_Health_Public_get_Single_0;

		// Token: 0x04002AF9 RID: 11001
		private static readonly IntPtr NativeMethodInfoPtr_set_Health_Public_set_Void_Single_0;

		// Token: 0x04002AFA RID: 11002
		private static readonly IntPtr NativeMethodInfoPtr_get_WalkSpeed_Public_get_Single_0;

		// Token: 0x04002AFB RID: 11003
		private static readonly IntPtr NativeMethodInfoPtr_set_WalkSpeed_Public_set_Void_Single_0;

		// Token: 0x04002AFC RID: 11004
		private static readonly IntPtr NativeMethodInfoPtr_get_SprintSpeed_Public_get_Single_0;

		// Token: 0x04002AFD RID: 11005
		private static readonly IntPtr NativeMethodInfoPtr_set_SprintSpeed_Public_set_Void_Single_0;

		// Token: 0x04002AFE RID: 11006
		private static readonly IntPtr NativeMethodInfoPtr_get_StaminaEnabled_Public_get_Boolean_0;

		// Token: 0x04002AFF RID: 11007
		private static readonly IntPtr NativeMethodInfoPtr_set_StaminaEnabled_Public_set_Void_Boolean_0;

		// Token: 0x04002B00 RID: 11008
		private static readonly IntPtr NativeMethodInfoPtr_get_Stamina_Public_get_Single_0;

		// Token: 0x04002B01 RID: 11009
		private static readonly IntPtr NativeMethodInfoPtr_set_Stamina_Public_set_Void_Single_0;

		// Token: 0x04002B02 RID: 11010
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxStamina_Public_get_Single_0;

		// Token: 0x04002B03 RID: 11011
		private static readonly IntPtr NativeMethodInfoPtr_set_MaxStamina_Public_set_Void_Single_0;

		// Token: 0x04002B04 RID: 11012
		private static readonly IntPtr NativeMethodInfoPtr_get_StaminaRegen_Public_get_Single_0;

		// Token: 0x04002B05 RID: 11013
		private static readonly IntPtr NativeMethodInfoPtr_set_StaminaRegen_Public_set_Void_Single_0;

		// Token: 0x04002B06 RID: 11014
		private static readonly IntPtr NativeMethodInfoPtr_get_JumpPower_Public_get_Single_0;

		// Token: 0x04002B07 RID: 11015
		private static readonly IntPtr NativeMethodInfoPtr_set_JumpPower_Public_set_Void_Single_0;

		// Token: 0x04002B08 RID: 11016
		private static readonly IntPtr NativeMethodInfoPtr_get_Position_Public_get_Vector3_0;

		// Token: 0x04002B09 RID: 11017
		private static readonly IntPtr NativeMethodInfoPtr_set_Position_Public_set_Void_Vector3_0;

		// Token: 0x04002B0A RID: 11018
		private static readonly IntPtr NativeMethodInfoPtr_get_Rotation_Public_get_Vector3_0;

		// Token: 0x04002B0B RID: 11019
		private static readonly IntPtr NativeMethodInfoPtr_set_Rotation_Public_set_Void_Vector3_0;

		// Token: 0x04002B0C RID: 11020
		private static readonly IntPtr NativeMethodInfoPtr_get_Size_Public_get_Vector3_0;

		// Token: 0x04002B0D RID: 11021
		private static readonly IntPtr NativeMethodInfoPtr_set_Size_Public_set_Void_Vector3_0;

		// Token: 0x04002B0E RID: 11022
		private static readonly IntPtr NativeMethodInfoPtr_get_ChatColor_Public_get_Color_0;

		// Token: 0x04002B0F RID: 11023
		private static readonly IntPtr NativeMethodInfoPtr_set_ChatColor_Public_set_Void_Color_0;

		// Token: 0x04002B10 RID: 11024
		private static readonly IntPtr NativeMethodInfoPtr_get_CanMove_Public_get_Boolean_0;

		// Token: 0x04002B11 RID: 11025
		private static readonly IntPtr NativeMethodInfoPtr_set_CanMove_Public_set_Void_Boolean_0;

		// Token: 0x04002B12 RID: 11026
		private static readonly IntPtr NativeMethodInfoPtr_get_Anchored_Public_get_Boolean_0;

		// Token: 0x04002B13 RID: 11027
		private static readonly IntPtr NativeMethodInfoPtr_set_Anchored_Public_set_Void_Boolean_0;

		// Token: 0x04002B14 RID: 11028
		private static readonly IntPtr NativeMethodInfoPtr_get_IsInputFocused_Public_get_Boolean_0;

		// Token: 0x04002B15 RID: 11029
		private static readonly IntPtr NativeMethodInfoPtr_get_AvatarHash_Public_get_String_0;

		// Token: 0x04002B16 RID: 11030
		private static readonly IntPtr NativeMethodInfoPtr_get_SittingIn_Public_get_Seat_0;

		// Token: 0x04002B17 RID: 11031
		private static readonly IntPtr NativeMethodInfoPtr_get_Forward_Public_get_Vector3_0;

		// Token: 0x04002B18 RID: 11032
		private static readonly IntPtr NativeMethodInfoPtr_get_Right_Public_get_Vector3_0;

		// Token: 0x04002B19 RID: 11033
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAdmin_Public_get_Boolean_0;

		// Token: 0x04002B1A RID: 11034
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCreator_Public_get_Boolean_0;

		// Token: 0x04002B1B RID: 11035
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSitting_Private_get_Boolean_0;

		// Token: 0x04002B1C RID: 11036
		private static readonly IntPtr NativeMethodInfoPtr_get_IsMovementAllowed_Private_get_Boolean_0;

		// Token: 0x04002B1D RID: 11037
		private static readonly IntPtr NativeMethodInfoPtr_get_UserID_Public_get_Int32_0;

		// Token: 0x04002B1E RID: 11038
		private static readonly IntPtr NativeMethodInfoPtr_set_UserID_Private_set_Void_Int32_0;

		// Token: 0x04002B1F RID: 11039
		private static readonly IntPtr NativeMethodInfoPtr_get_HeadColor_Public_get_Color_0;

		// Token: 0x04002B20 RID: 11040
		private static readonly IntPtr NativeMethodInfoPtr_set_HeadColor_Public_set_Void_Color_0;

		// Token: 0x04002B21 RID: 11041
		private static readonly IntPtr NativeMethodInfoPtr_get_TorsoColor_Public_get_Color_0;

		// Token: 0x04002B22 RID: 11042
		private static readonly IntPtr NativeMethodInfoPtr_set_TorsoColor_Public_set_Void_Color_0;

		// Token: 0x04002B23 RID: 11043
		private static readonly IntPtr NativeMethodInfoPtr_get_LeftArmColor_Public_get_Color_0;

		// Token: 0x04002B24 RID: 11044
		private static readonly IntPtr NativeMethodInfoPtr_set_LeftArmColor_Public_set_Void_Color_0;

		// Token: 0x04002B25 RID: 11045
		private static readonly IntPtr NativeMethodInfoPtr_get_RightArmColor_Public_get_Color_0;

		// Token: 0x04002B26 RID: 11046
		private static readonly IntPtr NativeMethodInfoPtr_set_RightArmColor_Public_set_Void_Color_0;

		// Token: 0x04002B27 RID: 11047
		private static readonly IntPtr NativeMethodInfoPtr_get_LeftLegColor_Public_get_Color_0;

		// Token: 0x04002B28 RID: 11048
		private static readonly IntPtr NativeMethodInfoPtr_set_LeftLegColor_Public_set_Void_Color_0;

		// Token: 0x04002B29 RID: 11049
		private static readonly IntPtr NativeMethodInfoPtr_get_RightLegColor_Public_get_Color_0;

		// Token: 0x04002B2A RID: 11050
		private static readonly IntPtr NativeMethodInfoPtr_set_RightLegColor_Public_set_Void_Color_0;

		// Token: 0x04002B2B RID: 11051
		private static readonly IntPtr NativeMethodInfoPtr_get_ShirtID_Public_get_Int32_0;

		// Token: 0x04002B2C RID: 11052
		private static readonly IntPtr NativeMethodInfoPtr_set_ShirtID_Public_set_Void_Int32_0;

		// Token: 0x04002B2D RID: 11053
		private static readonly IntPtr NativeMethodInfoPtr_get_PantsID_Public_get_Int32_0;

		// Token: 0x04002B2E RID: 11054
		private static readonly IntPtr NativeMethodInfoPtr_set_PantsID_Public_set_Void_Int32_0;

		// Token: 0x04002B2F RID: 11055
		private static readonly IntPtr NativeMethodInfoPtr_get_FaceID_Public_get_Int32_0;

		// Token: 0x04002B30 RID: 11056
		private static readonly IntPtr NativeMethodInfoPtr_set_FaceID_Public_set_Void_Int32_0;

		// Token: 0x04002B31 RID: 11057
		private static readonly IntPtr NativeMethodInfoPtr_get_ToolAttachmentPoint_Public_Virtual_Final_New_get_Transform_0;

		// Token: 0x04002B32 RID: 11058
		private static readonly IntPtr NativeMethodInfoPtr_get_Camera_Private_get_Camera_0;

		// Token: 0x04002B33 RID: 11059
		private static readonly IntPtr NativeMethodInfoPtr_set_Camera_Private_set_Void_Camera_0;

		// Token: 0x04002B34 RID: 11060
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkwalkSpeed_Public_get_Single_0;

		// Token: 0x04002B35 RID: 11061
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkwalkSpeed_Public_set_Void_Single_0;

		// Token: 0x04002B36 RID: 11062
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworksprintSpeed_Public_get_Single_0;

		// Token: 0x04002B37 RID: 11063
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworksprintSpeed_Public_set_Void_Single_0;

		// Token: 0x04002B38 RID: 11064
		private static readonly IntPtr NativeMethodInfoPtr_get_Networkhealth_Public_get_Single_0;

		// Token: 0x04002B39 RID: 11065
		private static readonly IntPtr NativeMethodInfoPtr_set_Networkhealth_Public_set_Void_Single_0;

		// Token: 0x04002B3A RID: 11066
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkstaminaEnabled_Public_get_Boolean_0;

		// Token: 0x04002B3B RID: 11067
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkstaminaEnabled_Public_set_Void_Boolean_0;

		// Token: 0x04002B3C RID: 11068
		private static readonly IntPtr NativeMethodInfoPtr_get_Networkstamina_Public_get_Single_0;

		// Token: 0x04002B3D RID: 11069
		private static readonly IntPtr NativeMethodInfoPtr_set_Networkstamina_Public_set_Void_Single_0;

		// Token: 0x04002B3E RID: 11070
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkmaxStamina_Public_get_Single_0;

		// Token: 0x04002B3F RID: 11071
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkmaxStamina_Public_set_Void_Single_0;

		// Token: 0x04002B40 RID: 11072
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkstaminaRegen_Public_get_Single_0;

		// Token: 0x04002B41 RID: 11073
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkstaminaRegen_Public_set_Void_Single_0;

		// Token: 0x04002B42 RID: 11074
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkrespawnTime_Public_get_Single_0;

		// Token: 0x04002B43 RID: 11075
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkrespawnTime_Public_set_Void_Single_0;

		// Token: 0x04002B44 RID: 11076
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkuserID_Public_get_Int32_0;

		// Token: 0x04002B45 RID: 11077
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkuserID_Public_set_Void_Int32_0;

		// Token: 0x04002B46 RID: 11078
		private static readonly IntPtr NativeMethodInfoPtr_get_Networkloaded_Public_get_Boolean_0;

		// Token: 0x04002B47 RID: 11079
		private static readonly IntPtr NativeMethodInfoPtr_set_Networkloaded_Public_set_Void_Boolean_0;

		// Token: 0x04002B48 RID: 11080
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkisCreator_Public_get_Boolean_0;

		// Token: 0x04002B49 RID: 11081
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkisCreator_Public_set_Void_Boolean_0;

		// Token: 0x04002B4A RID: 11082
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkisAdmin_Public_get_Boolean_0;

		// Token: 0x04002B4B RID: 11083
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkisAdmin_Public_set_Void_Boolean_0;

		// Token: 0x04002B4C RID: 11084
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkchatColor_Public_get_Color_0;

		// Token: 0x04002B4D RID: 11085
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkchatColor_Public_set_Void_Color_0;

		// Token: 0x04002B4E RID: 11086
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkavatarHash_Public_get_String_0;

		// Token: 0x04002B4F RID: 11087
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkavatarHash_Public_set_Void_String_0;

		// Token: 0x04002B50 RID: 11088
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkcanMove_Public_get_Boolean_0;

		// Token: 0x04002B51 RID: 11089
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkcanMove_Public_set_Void_Boolean_0;

		// Token: 0x04002B52 RID: 11090
		private static readonly IntPtr NativeMethodInfoPtr_get_Networkanchored_Public_get_Boolean_0;

		// Token: 0x04002B53 RID: 11091
		private static readonly IntPtr NativeMethodInfoPtr_set_Networkanchored_Public_set_Void_Boolean_0;

		// Token: 0x04002B54 RID: 11092
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkLeaderboardBadgeId_Public_get_String_0;

		// Token: 0x04002B55 RID: 11093
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkLeaderboardBadgeId_Public_set_Void_String_0;

		// Token: 0x04002B56 RID: 11094
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkcanChat_Public_get_Boolean_0;

		// Token: 0x04002B57 RID: 11095
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkcanChat_Public_set_Void_Boolean_0;

		// Token: 0x04002B58 RID: 11096
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkisAgeRestricted_Public_get_Boolean_0;

		// Token: 0x04002B59 RID: 11097
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkisAgeRestricted_Public_set_Void_Boolean_0;

		// Token: 0x04002B5A RID: 11098
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworksittingIn_Public_get_Seat_0;

		// Token: 0x04002B5B RID: 11099
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworksittingIn_Public_set_Void_Seat_0;

		// Token: 0x04002B5C RID: 11100
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002B5D RID: 11101
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04002B5E RID: 11102
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04002B5F RID: 11103
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04002B60 RID: 11104
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x04002B61 RID: 11105
		private static readonly IntPtr NativeMethodInfoPtr_Move_Private_Void_Single_Single_0;

		// Token: 0x04002B62 RID: 11106
		private static readonly IntPtr NativeMethodInfoPtr_PlayAnim_Public_Virtual_Final_New_Void_String_0;

		// Token: 0x04002B63 RID: 11107
		private static readonly IntPtr NativeMethodInfoPtr_PlayAnimTargetRpc_Public_Virtual_Final_New_Void_String_0;

		// Token: 0x04002B64 RID: 11108
		private static readonly IntPtr NativeMethodInfoPtr_SetChildLayers_Private_Void_Transform_LayerMask_0;

		// Token: 0x04002B65 RID: 11109
		private static readonly IntPtr NativeMethodInfoPtr_PostPlayerLoad_Private_IEnumerator_0;

		// Token: 0x04002B66 RID: 11110
		private static readonly IntPtr NativeMethodInfoPtr_DiscordLoop_Private_IEnumerator_0;

		// Token: 0x04002B67 RID: 11111
		private static readonly IntPtr NativeMethodInfoPtr_NotifyJoin_Private_Void_0;

		// Token: 0x04002B68 RID: 11112
		private static readonly IntPtr NativeMethodInfoPtr_OwnsItem_Public_Void_Int32_DynValue_0;

		// Token: 0x04002B69 RID: 11113
		private static readonly IntPtr NativeMethodInfoPtr_OnCollisionStay_Private_Void_Collision_0;

		// Token: 0x04002B6A RID: 11114
		private static readonly IntPtr NativeMethodInfoPtr_OnCollisionExit_Protected_Virtual_Void_Collision_0;

		// Token: 0x04002B6B RID: 11115
		private static readonly IntPtr NativeMethodInfoPtr_FindGround_Private_Boolean_byref_ContactPoint_List_1_ContactPoint_0;

		// Token: 0x04002B6C RID: 11116
		private static readonly IntPtr NativeMethodInfoPtr_FindStep_Private_Boolean_byref_Vector3_List_1_ContactPoint_ContactPoint_Vector3_0;

		// Token: 0x04002B6D RID: 11117
		private static readonly IntPtr NativeMethodInfoPtr_ResolveStepUp_Private_Boolean_byref_Vector3_ContactPoint_ContactPoint_0;

		// Token: 0x04002B6E RID: 11118
		private static readonly IntPtr NativeMethodInfoPtr_SetLoaded_Public_Void_String_0;

		// Token: 0x04002B6F RID: 11119
		private static readonly IntPtr NativeMethodInfoPtr_LoadMetadata_Private_IEnumerator_String_0;

		// Token: 0x04002B70 RID: 11120
		private static readonly IntPtr NativeMethodInfoPtr_CheckOwnsItemFromAPI_Private_IEnumerator_Int32_DynValue_0;

		// Token: 0x04002B71 RID: 11121
		private static readonly IntPtr NativeMethodInfoPtr_SendChat_Private_Void_0;

		// Token: 0x04002B72 RID: 11122
		private static readonly IntPtr NativeMethodInfoPtr_StopScream_Private_IEnumerator_0;

		// Token: 0x04002B73 RID: 11123
		private static readonly IntPtr NativeMethodInfoPtr_UpdateFootsteps_Private_Void_0;

		// Token: 0x04002B74 RID: 11124
		private static readonly IntPtr NativeMethodInfoPtr_DoFootstep_Private_Void_0;

		// Token: 0x04002B75 RID: 11125
		private static readonly IntPtr NativeMethodInfoPtr_Die_Private_Void_0;

		// Token: 0x04002B76 RID: 11126
		private static readonly IntPtr NativeMethodInfoPtr_CmdDied_Private_Void_0;

		// Token: 0x04002B77 RID: 11127
		private static readonly IntPtr NativeMethodInfoPtr_DropTools_Private_Void_0;

		// Token: 0x04002B78 RID: 11128
		private static readonly IntPtr NativeMethodInfoPtr_CmdDropTools_Private_Void_0;

		// Token: 0x04002B79 RID: 11129
		private static readonly IntPtr NativeMethodInfoPtr_DoDropTools_Private_Void_0;

		// Token: 0x04002B7A RID: 11130
		private static readonly IntPtr NativeMethodInfoPtr_EquipTool_Public_Void_Tool_0;

		// Token: 0x04002B7B RID: 11131
		private static readonly IntPtr NativeMethodInfoPtr_RpcSetAnimatorActive_Private_Void_Boolean_0;

		// Token: 0x04002B7C RID: 11132
		private static readonly IntPtr NativeMethodInfoPtr_SetTransformAttrTargetRpc_Public_Void_String_Vector3_0;

		// Token: 0x04002B7D RID: 11133
		private static readonly IntPtr NativeMethodInfoPtr_DoDie_Private_IEnumerator_0;

		// Token: 0x04002B7E RID: 11134
		private static readonly IntPtr NativeMethodInfoPtr_SetUserID_Public_Void_Int32_0;

		// Token: 0x04002B7F RID: 11135
		private static readonly IntPtr NativeMethodInfoPtr_LoadAppearance_Public_Void_Int32_0;

		// Token: 0x04002B80 RID: 11136
		private static readonly IntPtr NativeMethodInfoPtr_ClearAppearance_Public_Void_0;

		// Token: 0x04002B81 RID: 11137
		private static readonly IntPtr NativeMethodInfoPtr_ResetAppearance_Public_Void_0;

		// Token: 0x04002B82 RID: 11138
		private static readonly IntPtr NativeMethodInfoPtr_IsGrounded_Private_Boolean_0;

		// Token: 0x04002B83 RID: 11139
		private static readonly IntPtr NativeMethodInfoPtr_OnCollisionEnter_Protected_Virtual_Void_Collision_0;

		// Token: 0x04002B84 RID: 11140
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerEnter_Protected_Virtual_Void_Collider_0;

		// Token: 0x04002B85 RID: 11141
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerExit_Protected_Virtual_Void_Collider_0;

		// Token: 0x04002B86 RID: 11142
		private static readonly IntPtr NativeMethodInfoPtr_CmdTouched_Private_Void_GameObject_0;

		// Token: 0x04002B87 RID: 11143
		private static readonly IntPtr NativeMethodInfoPtr_CmdTouchEnded_Private_Void_GameObject_0;

		// Token: 0x04002B88 RID: 11144
		private static readonly IntPtr NativeMethodInfoPtr_PressingMovementKeys_Private_Boolean_0;

		// Token: 0x04002B89 RID: 11145
		private static readonly IntPtr NativeMethodInfoPtr_UpdateFov_Private_Void_Boolean_0;

		// Token: 0x04002B8A RID: 11146
		private static readonly IntPtr NativeMethodInfoPtr_CmdJumpSound_Private_Void_0;

		// Token: 0x04002B8B RID: 11147
		private static readonly IntPtr NativeMethodInfoPtr_RpcJumpSound_Private_Void_0;

		// Token: 0x04002B8C RID: 11148
		private static readonly IntPtr NativeMethodInfoPtr_DoJumpSound_Private_Void_0;

		// Token: 0x04002B8D RID: 11149
		private static readonly IntPtr NativeMethodInfoPtr_Kick_Public_Void_String_0;

		// Token: 0x04002B8E RID: 11150
		private static readonly IntPtr NativeMethodInfoPtr_DelayedDisconnect_Private_IEnumerator_0;

		// Token: 0x04002B8F RID: 11151
		private static readonly IntPtr NativeMethodInfoPtr_SendDisconnectMessageTargetRpc_Private_Void_String_0;

		// Token: 0x04002B90 RID: 11152
		private static readonly IntPtr NativeMethodInfoPtr_Sit_Public_Void_Seat_0;

		// Token: 0x04002B91 RID: 11153
		private static readonly IntPtr NativeMethodInfoPtr_UnsitTargetRpc_Private_Void_Boolean_0;

		// Token: 0x04002B92 RID: 11154
		private static readonly IntPtr NativeMethodInfoPtr_Unsit_Public_Void_Boolean_0;

		// Token: 0x04002B93 RID: 11155
		private static readonly IntPtr NativeMethodInfoPtr_CmdSetSittingIn_Public_Void_Seat_0;

		// Token: 0x04002B94 RID: 11156
		private static readonly IntPtr NativeMethodInfoPtr_SetSittingIn_Private_Void_Seat_0;

		// Token: 0x04002B95 RID: 11157
		private static readonly IntPtr NativeMethodInfoPtr_CmdNotifyRespawn_Private_Void_0;

		// Token: 0x04002B96 RID: 11158
		private static readonly IntPtr NativeMethodInfoPtr_ServerRespawn_Private_Void_0;

		// Token: 0x04002B97 RID: 11159
		private static readonly IntPtr NativeMethodInfoPtr_Respawn_Public_Void_0;

		// Token: 0x04002B98 RID: 11160
		private static readonly IntPtr NativeMethodInfoPtr_LookAt_Public_Void_Vector3_Vector3_0;

		// Token: 0x04002B99 RID: 11161
		private static readonly IntPtr NativeMethodInfoPtr_LookAt_Public_Void_Vector3_0;

		// Token: 0x04002B9A RID: 11162
		private static readonly IntPtr NativeMethodInfoPtr_LookAt_Public_Void_DynamicInstance_0;

		// Token: 0x04002B9B RID: 11163
		private static readonly IntPtr NativeMethodInfoPtr_Translate_Public_Void_Vector3_0;

		// Token: 0x04002B9C RID: 11164
		private static readonly IntPtr NativeMethodInfoPtr_RotateAround_Public_Void_Vector3_Vector3_Single_0;

		// Token: 0x04002B9D RID: 11165
		private static readonly IntPtr NativeMethodInfoPtr_Rotate_Public_Void_Vector3_0;

		// Token: 0x04002B9E RID: 11166
		private static readonly IntPtr NativeMethodInfoPtr_InverseTransformPoint_Public_Vector3_Vector3_0;

		// Token: 0x04002B9F RID: 11167
		private static readonly IntPtr NativeMethodInfoPtr_TransformPoint_Public_Vector3_Vector3_0;

		// Token: 0x04002BA0 RID: 11168
		private static readonly IntPtr NativeMethodInfoPtr_InverseTransformDirection_Public_Vector3_Vector3_0;

		// Token: 0x04002BA1 RID: 11169
		private static readonly IntPtr NativeMethodInfoPtr_TransformDirection_Public_Vector3_Vector3_0;

		// Token: 0x04002BA2 RID: 11170
		private static readonly IntPtr NativeMethodInfoPtr_InverseTransformVector_Public_Vector3_Vector3_0;

		// Token: 0x04002BA3 RID: 11171
		private static readonly IntPtr NativeMethodInfoPtr_TransformVector_Public_Vector3_Vector3_0;

		// Token: 0x04002BA4 RID: 11172
		private static readonly IntPtr NativeMethodInfoPtr_TargetSetPosition_Public_Void_Vector3_0;

		// Token: 0x04002BA5 RID: 11173
		private static readonly IntPtr NativeMethodInfoPtr_RpcSetRespawnTime_Private_Void_Single_0;

		// Token: 0x04002BA6 RID: 11174
		private static readonly IntPtr NativeMethodInfoPtr_RpcSetMaxHealth_Private_Void_Single_0;

		// Token: 0x04002BA7 RID: 11175
		private static readonly IntPtr NativeMethodInfoPtr_RpcSetHealth_Private_Void_Single_0;

		// Token: 0x04002BA8 RID: 11176
		private static readonly IntPtr NativeMethodInfoPtr_CmdSetHealth_Private_Void_Single_0;

		// Token: 0x04002BA9 RID: 11177
		private static readonly IntPtr NativeMethodInfoPtr_RpcSetWalkSpeed_Private_Void_Single_0;

		// Token: 0x04002BAA RID: 11178
		private static readonly IntPtr NativeMethodInfoPtr_RpcSetSprintSpeed_Private_Void_Single_0;

		// Token: 0x04002BAB RID: 11179
		private static readonly IntPtr NativeMethodInfoPtr_RpcSetMaxStamina_Private_Void_Single_0;

		// Token: 0x04002BAC RID: 11180
		private static readonly IntPtr NativeMethodInfoPtr_RpcSetStamina_Private_Void_Single_0;

		// Token: 0x04002BAD RID: 11181
		private static readonly IntPtr NativeMethodInfoPtr_RpcSetStaminaRegen_Private_Void_Single_0;

		// Token: 0x04002BAE RID: 11182
		private static readonly IntPtr NativeMethodInfoPtr_RpcSetStaminaEnabled_Private_Void_Boolean_0;

		// Token: 0x04002BAF RID: 11183
		private static readonly IntPtr NativeMethodInfoPtr_RpcSetJumpPower_Private_Void_Single_0;

		// Token: 0x04002BB0 RID: 11184
		private static readonly IntPtr NativeMethodInfoPtr_RpcSetChatColor_Private_Void_Color_0;

		// Token: 0x04002BB1 RID: 11185
		private static readonly IntPtr NativeMethodInfoPtr_RpcSetCanMove_Private_Void_Boolean_0;

		// Token: 0x04002BB2 RID: 11186
		private static readonly IntPtr NativeMethodInfoPtr_RpcSetAnchored_Private_Void_Boolean_0;

		// Token: 0x04002BB3 RID: 11187
		private static readonly IntPtr NativeMethodInfoPtr_RpcSetColor_Private_Void_BodyPart_Color_0;

		// Token: 0x04002BB4 RID: 11188
		private static readonly IntPtr NativeMethodInfoPtr__set_ShirtID_b__165_0_Private_Void_ImageCacheKey_ImageCacheEntry_0;

		// Token: 0x04002BB5 RID: 11189
		private static readonly IntPtr NativeMethodInfoPtr__set_PantsID_b__168_0_Private_Void_ImageCacheKey_ImageCacheEntry_0;

		// Token: 0x04002BB6 RID: 11190
		private static readonly IntPtr NativeMethodInfoPtr__set_FaceID_b__171_0_Private_Void_ImageCacheKey_ImageCacheEntry_0;

		// Token: 0x04002BB7 RID: 11191
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__189_0_Private_Void_0;

		// Token: 0x04002BB8 RID: 11192
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__189_1_Private_Void_String_0;

		// Token: 0x04002BB9 RID: 11193
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__189_2_Private_Void_0;

		// Token: 0x04002BBA RID: 11194
		private static readonly IntPtr NativeMethodInfoPtr__IsGrounded_b__227_1_Private_Boolean_Collider_0;

		// Token: 0x04002BBB RID: 11195
		private static readonly IntPtr NativeMethodInfoPtr__UpdateFov_b__234_0_Private_Void_Single_0;

		// Token: 0x04002BBC RID: 11196
		private static readonly IntPtr NativeMethodInfoPtr__UpdateFov_b__234_1_Private_Void_Single_0;

		// Token: 0x04002BBD RID: 11197
		private static readonly IntPtr NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0;

		// Token: 0x04002BBE RID: 11198
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_PlayAnimTargetRpc__String_Protected_Virtual_Final_New_Void_String_0;

		// Token: 0x04002BBF RID: 11199
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_PlayAnimTargetRpc__String_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002BC0 RID: 11200
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_NotifyJoin_Protected_Void_0;

		// Token: 0x04002BC1 RID: 11201
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_NotifyJoin_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002BC2 RID: 11202
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_CmdDied_Protected_Void_0;

		// Token: 0x04002BC3 RID: 11203
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_CmdDied_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002BC4 RID: 11204
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_CmdDropTools_Protected_Void_0;

		// Token: 0x04002BC5 RID: 11205
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_CmdDropTools_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002BC6 RID: 11206
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_EquipTool__Tool_Protected_Void_Tool_0;

		// Token: 0x04002BC7 RID: 11207
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_EquipTool__Tool_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002BC8 RID: 11208
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcSetAnimatorActive__Boolean_Protected_Void_Boolean_0;

		// Token: 0x04002BC9 RID: 11209
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcSetAnimatorActive__Boolean_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002BCA RID: 11210
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_SetTransformAttrTargetRpc__String__Vector3_Protected_Void_String_Vector3_0;

		// Token: 0x04002BCB RID: 11211
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_SetTransformAttrTargetRpc__String__Vector3_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002BCC RID: 11212
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_CmdTouched__GameObject_Protected_Void_GameObject_0;

		// Token: 0x04002BCD RID: 11213
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_CmdTouched__GameObject_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002BCE RID: 11214
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_CmdTouchEnded__GameObject_Protected_Void_GameObject_0;

		// Token: 0x04002BCF RID: 11215
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_CmdTouchEnded__GameObject_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002BD0 RID: 11216
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_CmdJumpSound_Protected_Void_0;

		// Token: 0x04002BD1 RID: 11217
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_CmdJumpSound_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002BD2 RID: 11218
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcJumpSound_Protected_Void_0;

		// Token: 0x04002BD3 RID: 11219
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcJumpSound_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002BD4 RID: 11220
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_SendDisconnectMessageTargetRpc__String_Protected_Void_String_0;

		// Token: 0x04002BD5 RID: 11221
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_SendDisconnectMessageTargetRpc__String_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002BD6 RID: 11222
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_UnsitTargetRpc__Boolean_Protected_Void_Boolean_0;

		// Token: 0x04002BD7 RID: 11223
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_UnsitTargetRpc__Boolean_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002BD8 RID: 11224
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_CmdSetSittingIn__Seat_Protected_Void_Seat_0;

		// Token: 0x04002BD9 RID: 11225
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_CmdSetSittingIn__Seat_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002BDA RID: 11226
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_CmdNotifyRespawn_Protected_Void_0;

		// Token: 0x04002BDB RID: 11227
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_CmdNotifyRespawn_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002BDC RID: 11228
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_TargetSetPosition__Vector3_Protected_Void_Vector3_0;

		// Token: 0x04002BDD RID: 11229
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_TargetSetPosition__Vector3_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002BDE RID: 11230
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcSetRespawnTime__Single_Protected_Void_Single_0;

		// Token: 0x04002BDF RID: 11231
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcSetRespawnTime__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002BE0 RID: 11232
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcSetMaxHealth__Single_Protected_Void_Single_0;

		// Token: 0x04002BE1 RID: 11233
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcSetMaxHealth__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002BE2 RID: 11234
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcSetHealth__Single_Protected_Void_Single_0;

		// Token: 0x04002BE3 RID: 11235
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcSetHealth__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002BE4 RID: 11236
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_CmdSetHealth__Single_Protected_Void_Single_0;

		// Token: 0x04002BE5 RID: 11237
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_CmdSetHealth__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002BE6 RID: 11238
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcSetWalkSpeed__Single_Protected_Void_Single_0;

		// Token: 0x04002BE7 RID: 11239
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcSetWalkSpeed__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002BE8 RID: 11240
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcSetSprintSpeed__Single_Protected_Void_Single_0;

		// Token: 0x04002BE9 RID: 11241
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcSetSprintSpeed__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002BEA RID: 11242
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcSetMaxStamina__Single_Protected_Void_Single_0;

		// Token: 0x04002BEB RID: 11243
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcSetMaxStamina__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002BEC RID: 11244
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcSetStamina__Single_Protected_Void_Single_0;

		// Token: 0x04002BED RID: 11245
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcSetStamina__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002BEE RID: 11246
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcSetStaminaRegen__Single_Protected_Void_Single_0;

		// Token: 0x04002BEF RID: 11247
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcSetStaminaRegen__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002BF0 RID: 11248
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcSetStaminaEnabled__Boolean_Protected_Void_Boolean_0;

		// Token: 0x04002BF1 RID: 11249
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcSetStaminaEnabled__Boolean_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002BF2 RID: 11250
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcSetJumpPower__Single_Protected_Void_Single_0;

		// Token: 0x04002BF3 RID: 11251
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcSetJumpPower__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002BF4 RID: 11252
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcSetChatColor__Color_Protected_Void_Color_0;

		// Token: 0x04002BF5 RID: 11253
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcSetChatColor__Color_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002BF6 RID: 11254
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcSetCanMove__Boolean_Protected_Void_Boolean_0;

		// Token: 0x04002BF7 RID: 11255
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcSetCanMove__Boolean_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002BF8 RID: 11256
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcSetAnchored__Boolean_Protected_Void_Boolean_0;

		// Token: 0x04002BF9 RID: 11257
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcSetAnchored__Boolean_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002BFA RID: 11258
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcSetColor__BodyPart__Color_Protected_Void_BodyPart_Color_0;

		// Token: 0x04002BFB RID: 11259
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcSetColor__BodyPart__Color_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002BFC RID: 11260
		private static readonly IntPtr NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0;

		// Token: 0x04002BFD RID: 11261
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0;

		// Token: 0x020003F9 RID: 1017
		[ObfuscatedName("Polytoria.Datamodel.Player+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06004E21 RID: 20001 RVA: 0x00152558 File Offset: 0x00150758
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Player.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Player>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Player.__c>.NativeClassPtr);
				Player.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player.__c>.NativeClassPtr, "<>9");
				Player.__c.NativeFieldInfoPtr___9__213_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player.__c>.NativeClassPtr, "<>9__213_0");
				Player.__c.NativeFieldInfoPtr___9__213_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player.__c>.NativeClassPtr, "<>9__213_1");
				Player.__c.NativeFieldInfoPtr___9__227_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player.__c>.NativeClassPtr, "<>9__227_0");
				Player.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player.__c>.NativeClassPtr, 100671916);
				Player.__c.NativeMethodInfoPtr__DoFootstep_b__213_0_Internal_Boolean_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player.__c>.NativeClassPtr, 100671917);
				Player.__c.NativeMethodInfoPtr__DoFootstep_b__213_1_Internal_Instance_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player.__c>.NativeClassPtr, 100671918);
				Player.__c.NativeMethodInfoPtr__IsGrounded_b__227_0_Internal_Boolean_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player.__c>.NativeClassPtr, 100671919);
			}

			// Token: 0x06004E22 RID: 20002 RVA: 0x00152624 File Offset: 0x00150824
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Player.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004E23 RID: 20003 RVA: 0x00152660 File Offset: 0x00150860
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DoFootstep_b__213_0(Collider i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(i);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.__c.NativeMethodInfoPtr__DoFootstep_b__213_0_Internal_Boolean_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004E24 RID: 20004 RVA: 0x001526B0 File Offset: 0x001508B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111695, XrefRangeEnd = 111699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Instance _DoFootstep_b__213_1(Collider i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(i);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.__c.NativeMethodInfoPtr__DoFootstep_b__213_1_Internal_Instance_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instance>(intPtr3) : null;
				}
			}

			// Token: 0x06004E25 RID: 20005 RVA: 0x00152700 File Offset: 0x00150900
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _IsGrounded_b__227_0(Collider i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(i);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player.__c.NativeMethodInfoPtr__IsGrounded_b__227_0_Internal_Boolean_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004E26 RID: 20006 RVA: 0x0001D9C7 File Offset: 0x0001BBC7
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001A52 RID: 6738
			// (get) Token: 0x06004E27 RID: 20007 RVA: 0x00152750 File Offset: 0x00150950
			// (set) Token: 0x06004E28 RID: 20008 RVA: 0x0001D9D0 File Offset: 0x0001BBD0
			public unsafe static Player.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Player.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Player.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A53 RID: 6739
			// (get) Token: 0x06004E29 RID: 20009 RVA: 0x00152778 File Offset: 0x00150978
			// (set) Token: 0x06004E2A RID: 20010 RVA: 0x0001D9E2 File Offset: 0x0001BBE2
			public unsafe static Func<Collider, bool> __9__213_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Player.__c.NativeFieldInfoPtr___9__213_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Collider, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Player.__c.NativeFieldInfoPtr___9__213_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A54 RID: 6740
			// (get) Token: 0x06004E2B RID: 20011 RVA: 0x001527A0 File Offset: 0x001509A0
			// (set) Token: 0x06004E2C RID: 20012 RVA: 0x0001D9F4 File Offset: 0x0001BBF4
			public unsafe static Func<Collider, Instance> __9__213_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Player.__c.NativeFieldInfoPtr___9__213_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Collider, Instance>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Player.__c.NativeFieldInfoPtr___9__213_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A55 RID: 6741
			// (get) Token: 0x06004E2D RID: 20013 RVA: 0x001527C8 File Offset: 0x001509C8
			// (set) Token: 0x06004E2E RID: 20014 RVA: 0x0001DA06 File Offset: 0x0001BC06
			public unsafe static Func<Collider, bool> __9__227_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Player.__c.NativeFieldInfoPtr___9__227_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Collider, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Player.__c.NativeFieldInfoPtr___9__227_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003C8E RID: 15502
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04003C8F RID: 15503
			private static readonly IntPtr NativeFieldInfoPtr___9__213_0;

			// Token: 0x04003C90 RID: 15504
			private static readonly IntPtr NativeFieldInfoPtr___9__213_1;

			// Token: 0x04003C91 RID: 15505
			private static readonly IntPtr NativeFieldInfoPtr___9__227_0;

			// Token: 0x04003C92 RID: 15506
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003C93 RID: 15507
			private static readonly IntPtr NativeMethodInfoPtr__DoFootstep_b__213_0_Internal_Boolean_Collider_0;

			// Token: 0x04003C94 RID: 15508
			private static readonly IntPtr NativeMethodInfoPtr__DoFootstep_b__213_1_Internal_Instance_Collider_0;

			// Token: 0x04003C95 RID: 15509
			private static readonly IntPtr NativeMethodInfoPtr__IsGrounded_b__227_0_Internal_Boolean_Collider_0;
		}

		// Token: 0x020003FA RID: 1018
		[ObfuscatedName("Polytoria.Datamodel.Player+<CheckOwnsItemFromAPI>d__208")]
		public sealed class _CheckOwnsItemFromAPI_d__208 : global::Il2CppSystem.Object
		{
			// Token: 0x06004E2F RID: 20015 RVA: 0x001527F0 File Offset: 0x001509F0
			// Note: this type is marked as 'beforefieldinit'.
			static _CheckOwnsItemFromAPI_d__208()
			{
				Il2CppClassPointerStore<Player._CheckOwnsItemFromAPI_d__208>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Player>.NativeClassPtr, "<CheckOwnsItemFromAPI>d__208");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Player._CheckOwnsItemFromAPI_d__208>.NativeClassPtr);
				Player._CheckOwnsItemFromAPI_d__208.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player._CheckOwnsItemFromAPI_d__208>.NativeClassPtr, "<>1__state");
				Player._CheckOwnsItemFromAPI_d__208.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player._CheckOwnsItemFromAPI_d__208>.NativeClassPtr, "<>2__current");
				Player._CheckOwnsItemFromAPI_d__208.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player._CheckOwnsItemFromAPI_d__208>.NativeClassPtr, "callback");
				Player._CheckOwnsItemFromAPI_d__208.NativeFieldInfoPtr_assetId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player._CheckOwnsItemFromAPI_d__208>.NativeClassPtr, "assetId");
				Player._CheckOwnsItemFromAPI_d__208.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player._CheckOwnsItemFromAPI_d__208>.NativeClassPtr, "<>4__this");
				Player._CheckOwnsItemFromAPI_d__208.NativeFieldInfoPtr__ss_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player._CheckOwnsItemFromAPI_d__208>.NativeClassPtr, "<ss>5__2");
				Player._CheckOwnsItemFromAPI_d__208.NativeFieldInfoPtr__uwr_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player._CheckOwnsItemFromAPI_d__208>.NativeClassPtr, "<uwr>5__3");
				Player._CheckOwnsItemFromAPI_d__208.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player._CheckOwnsItemFromAPI_d__208>.NativeClassPtr, 100671924);
				Player._CheckOwnsItemFromAPI_d__208.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player._CheckOwnsItemFromAPI_d__208>.NativeClassPtr, 100671926);
				Player._CheckOwnsItemFromAPI_d__208.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player._CheckOwnsItemFromAPI_d__208>.NativeClassPtr, 100671920);
				Player._CheckOwnsItemFromAPI_d__208.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player._CheckOwnsItemFromAPI_d__208>.NativeClassPtr, 100671921);
				Player._CheckOwnsItemFromAPI_d__208.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player._CheckOwnsItemFromAPI_d__208>.NativeClassPtr, 100671922);
				Player._CheckOwnsItemFromAPI_d__208.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player._CheckOwnsItemFromAPI_d__208>.NativeClassPtr, 100671923);
				Player._CheckOwnsItemFromAPI_d__208.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player._CheckOwnsItemFromAPI_d__208>.NativeClassPtr, 100671925);
			}

			// Token: 0x17001A5D RID: 6749
			// (get) Token: 0x06004E30 RID: 20016 RVA: 0x00152934 File Offset: 0x00150B34
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player._CheckOwnsItemFromAPI_d__208.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001A5E RID: 6750
			// (get) Token: 0x06004E31 RID: 20017 RVA: 0x00152974 File Offset: 0x00150B74
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player._CheckOwnsItemFromAPI_d__208.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004E32 RID: 20018 RVA: 0x001529B4 File Offset: 0x00150BB4
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 10168, RefRangeEnd = 10216, XrefRangeStart = 10168, XrefRangeEnd = 10216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _CheckOwnsItemFromAPI_d__208(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Player._CheckOwnsItemFromAPI_d__208>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player._CheckOwnsItemFromAPI_d__208.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004E33 RID: 20019 RVA: 0x001529FC File Offset: 0x00150BFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111699, XrefRangeEnd = 111704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player._CheckOwnsItemFromAPI_d__208.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004E34 RID: 20020 RVA: 0x00152A30 File Offset: 0x00150C30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111704, XrefRangeEnd = 111840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player._CheckOwnsItemFromAPI_d__208.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004E35 RID: 20021 RVA: 0x00152A6C File Offset: 0x00150C6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111840, XrefRangeEnd = 111843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player._CheckOwnsItemFromAPI_d__208.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004E36 RID: 20022 RVA: 0x00152AA0 File Offset: 0x00150CA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111843, XrefRangeEnd = 111848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player._CheckOwnsItemFromAPI_d__208.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004E37 RID: 20023 RVA: 0x0001DA18 File Offset: 0x0001BC18
			public _CheckOwnsItemFromAPI_d__208(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001A56 RID: 6742
			// (get) Token: 0x06004E38 RID: 20024 RVA: 0x00152AD4 File Offset: 0x00150CD4
			// (set) Token: 0x06004E39 RID: 20025 RVA: 0x0001DA21 File Offset: 0x0001BC21
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player._CheckOwnsItemFromAPI_d__208.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player._CheckOwnsItemFromAPI_d__208.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001A57 RID: 6743
			// (get) Token: 0x06004E3A RID: 20026 RVA: 0x00152AFC File Offset: 0x00150CFC
			// (set) Token: 0x06004E3B RID: 20027 RVA: 0x0001DA3C File Offset: 0x0001BC3C
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player._CheckOwnsItemFromAPI_d__208.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player._CheckOwnsItemFromAPI_d__208.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A58 RID: 6744
			// (get) Token: 0x06004E3C RID: 20028 RVA: 0x00152B2C File Offset: 0x00150D2C
			// (set) Token: 0x06004E3D RID: 20029 RVA: 0x0001DA5B File Offset: 0x0001BC5B
			public unsafe DynValue callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player._CheckOwnsItemFromAPI_d__208.NativeFieldInfoPtr_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynValue>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player._CheckOwnsItemFromAPI_d__208.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A59 RID: 6745
			// (get) Token: 0x06004E3E RID: 20030 RVA: 0x00152B5C File Offset: 0x00150D5C
			// (set) Token: 0x06004E3F RID: 20031 RVA: 0x0001DA7A File Offset: 0x0001BC7A
			public unsafe int assetId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player._CheckOwnsItemFromAPI_d__208.NativeFieldInfoPtr_assetId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player._CheckOwnsItemFromAPI_d__208.NativeFieldInfoPtr_assetId)) = value;
				}
			}

			// Token: 0x17001A5A RID: 6746
			// (get) Token: 0x06004E40 RID: 20032 RVA: 0x00152B84 File Offset: 0x00150D84
			// (set) Token: 0x06004E41 RID: 20033 RVA: 0x0001DA95 File Offset: 0x0001BC95
			public unsafe Player __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player._CheckOwnsItemFromAPI_d__208.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player._CheckOwnsItemFromAPI_d__208.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A5B RID: 6747
			// (get) Token: 0x06004E42 RID: 20034 RVA: 0x00152BB4 File Offset: 0x00150DB4
			// (set) Token: 0x06004E43 RID: 20035 RVA: 0x0001DAB4 File Offset: 0x0001BCB4
			public unsafe ScriptService _ss_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player._CheckOwnsItemFromAPI_d__208.NativeFieldInfoPtr__ss_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptService>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player._CheckOwnsItemFromAPI_d__208.NativeFieldInfoPtr__ss_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A5C RID: 6748
			// (get) Token: 0x06004E44 RID: 20036 RVA: 0x00152BE4 File Offset: 0x00150DE4
			// (set) Token: 0x06004E45 RID: 20037 RVA: 0x0001DAD3 File Offset: 0x0001BCD3
			public unsafe UnityWebRequest _uwr_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player._CheckOwnsItemFromAPI_d__208.NativeFieldInfoPtr__uwr_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player._CheckOwnsItemFromAPI_d__208.NativeFieldInfoPtr__uwr_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003C96 RID: 15510
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003C97 RID: 15511
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003C98 RID: 15512
			private static readonly IntPtr NativeFieldInfoPtr_callback;

			// Token: 0x04003C99 RID: 15513
			private static readonly IntPtr NativeFieldInfoPtr_assetId;

			// Token: 0x04003C9A RID: 15514
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003C9B RID: 15515
			private static readonly IntPtr NativeFieldInfoPtr__ss_5__2;

			// Token: 0x04003C9C RID: 15516
			private static readonly IntPtr NativeFieldInfoPtr__uwr_5__3;

			// Token: 0x04003C9D RID: 15517
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003C9E RID: 15518
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003C9F RID: 15519
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003CA0 RID: 15520
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003CA1 RID: 15521
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003CA2 RID: 15522
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04003CA3 RID: 15523
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}

		// Token: 0x020003FB RID: 1019
		[ObfuscatedName("Polytoria.Datamodel.Player+<DelayedDisconnect>d__239")]
		public sealed class _DelayedDisconnect_d__239 : global::Il2CppSystem.Object
		{
			// Token: 0x06004E46 RID: 20038 RVA: 0x00152C14 File Offset: 0x00150E14
			// Note: this type is marked as 'beforefieldinit'.
			static _DelayedDisconnect_d__239()
			{
				Il2CppClassPointerStore<Player._DelayedDisconnect_d__239>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Player>.NativeClassPtr, "<DelayedDisconnect>d__239");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Player._DelayedDisconnect_d__239>.NativeClassPtr);
				Player._DelayedDisconnect_d__239.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player._DelayedDisconnect_d__239>.NativeClassPtr, "<>1__state");
				Player._DelayedDisconnect_d__239.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player._DelayedDisconnect_d__239>.NativeClassPtr, "<>2__current");
				Player._DelayedDisconnect_d__239.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player._DelayedDisconnect_d__239>.NativeClassPtr, "<>4__this");
				Player._DelayedDisconnect_d__239.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player._DelayedDisconnect_d__239>.NativeClassPtr, 100671930);
				Player._DelayedDisconnect_d__239.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player._DelayedDisconnect_d__239>.NativeClassPtr, 100671932);
				Player._DelayedDisconnect_d__239.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player._DelayedDisconnect_d__239>.NativeClassPtr, 100671927);
				Player._DelayedDisconnect_d__239.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player._DelayedDisconnect_d__239>.NativeClassPtr, 100671928);
				Player._DelayedDisconnect_d__239.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player._DelayedDisconnect_d__239>.NativeClassPtr, 100671929);
				Player._DelayedDisconnect_d__239.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player._DelayedDisconnect_d__239>.NativeClassPtr, 100671931);
			}

			// Token: 0x17001A62 RID: 6754
			// (get) Token: 0x06004E47 RID: 20039 RVA: 0x00152CF4 File Offset: 0x00150EF4
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player._DelayedDisconnect_d__239.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001A63 RID: 6755
			// (get) Token: 0x06004E48 RID: 20040 RVA: 0x00152D34 File Offset: 0x00150F34
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player._DelayedDisconnect_d__239.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004E49 RID: 20041 RVA: 0x00152D74 File Offset: 0x00150F74
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 10168, RefRangeEnd = 10216, XrefRangeStart = 10168, XrefRangeEnd = 10216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DelayedDisconnect_d__239(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Player._DelayedDisconnect_d__239>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player._DelayedDisconnect_d__239.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004E4A RID: 20042 RVA: 0x00152DBC File Offset: 0x00150FBC
			[CallerCount(7535)]
			[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player._DelayedDisconnect_d__239.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004E4B RID: 20043 RVA: 0x00152DF0 File Offset: 0x00150FF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111848, XrefRangeEnd = 111854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player._DelayedDisconnect_d__239.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004E4C RID: 20044 RVA: 0x00152E2C File Offset: 0x0015102C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111854, XrefRangeEnd = 111859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player._DelayedDisconnect_d__239.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004E4D RID: 20045 RVA: 0x0001DAF2 File Offset: 0x0001BCF2
			public _DelayedDisconnect_d__239(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001A5F RID: 6751
			// (get) Token: 0x06004E4E RID: 20046 RVA: 0x00152E60 File Offset: 0x00151060
			// (set) Token: 0x06004E4F RID: 20047 RVA: 0x0001DAFB File Offset: 0x0001BCFB
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player._DelayedDisconnect_d__239.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player._DelayedDisconnect_d__239.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001A60 RID: 6752
			// (get) Token: 0x06004E50 RID: 20048 RVA: 0x00152E88 File Offset: 0x00151088
			// (set) Token: 0x06004E51 RID: 20049 RVA: 0x0001DB16 File Offset: 0x0001BD16
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player._DelayedDisconnect_d__239.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player._DelayedDisconnect_d__239.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A61 RID: 6753
			// (get) Token: 0x06004E52 RID: 20050 RVA: 0x00152EB8 File Offset: 0x001510B8
			// (set) Token: 0x06004E53 RID: 20051 RVA: 0x0001DB35 File Offset: 0x0001BD35
			public unsafe Player __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player._DelayedDisconnect_d__239.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player._DelayedDisconnect_d__239.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003CA4 RID: 15524
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003CA5 RID: 15525
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003CA6 RID: 15526
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003CA7 RID: 15527
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003CA8 RID: 15528
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003CA9 RID: 15529
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003CAA RID: 15530
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003CAB RID: 15531
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003CAC RID: 15532
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}

		// Token: 0x020003FC RID: 1020
		[ObfuscatedName("Polytoria.Datamodel.Player+<DiscordLoop>d__197")]
		public sealed class _DiscordLoop_d__197 : global::Il2CppSystem.Object
		{
			// Token: 0x06004E54 RID: 20052 RVA: 0x00152EE8 File Offset: 0x001510E8
			// Note: this type is marked as 'beforefieldinit'.
			static _DiscordLoop_d__197()
			{
				Il2CppClassPointerStore<Player._DiscordLoop_d__197>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Player>.NativeClassPtr, "<DiscordLoop>d__197");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Player._DiscordLoop_d__197>.NativeClassPtr);
				Player._DiscordLoop_d__197.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player._DiscordLoop_d__197>.NativeClassPtr, "<>1__state");
				Player._DiscordLoop_d__197.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player._DiscordLoop_d__197>.NativeClassPtr, "<>2__current");
				Player._DiscordLoop_d__197.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player._DiscordLoop_d__197>.NativeClassPtr, 100671936);
				Player._DiscordLoop_d__197.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player._DiscordLoop_d__197>.NativeClassPtr, 100671938);
				Player._DiscordLoop_d__197.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player._DiscordLoop_d__197>.NativeClassPtr, 100671933);
				Player._DiscordLoop_d__197.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player._DiscordLoop_d__197>.NativeClassPtr, 100671934);
				Player._DiscordLoop_d__197.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player._DiscordLoop_d__197>.NativeClassPtr, 100671935);
				Player._DiscordLoop_d__197.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player._DiscordLoop_d__197>.NativeClassPtr, 100671937);
			}

			// Token: 0x17001A66 RID: 6758
			// (get) Token: 0x06004E55 RID: 20053 RVA: 0x00152FB4 File Offset: 0x001511B4
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player._DiscordLoop_d__197.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001A67 RID: 6759
			// (get) Token: 0x06004E56 RID: 20054 RVA: 0x00152FF4 File Offset: 0x001511F4
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player._DiscordLoop_d__197.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004E57 RID: 20055 RVA: 0x00153034 File Offset: 0x00151234
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 10168, RefRangeEnd = 10216, XrefRangeStart = 10168, XrefRangeEnd = 10216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DiscordLoop_d__197(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Player._DiscordLoop_d__197>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player._DiscordLoop_d__197.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004E58 RID: 20056 RVA: 0x0015307C File Offset: 0x0015127C
			[CallerCount(7535)]
			[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player._DiscordLoop_d__197.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004E59 RID: 20057 RVA: 0x001530B0 File Offset: 0x001512B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111859, XrefRangeEnd = 111864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player._DiscordLoop_d__197.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004E5A RID: 20058 RVA: 0x001530EC File Offset: 0x001512EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111864, XrefRangeEnd = 111869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player._DiscordLoop_d__197.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004E5B RID: 20059 RVA: 0x0001DB54 File Offset: 0x0001BD54
			public _DiscordLoop_d__197(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001A64 RID: 6756
			// (get) Token: 0x06004E5C RID: 20060 RVA: 0x00153120 File Offset: 0x00151320
			// (set) Token: 0x06004E5D RID: 20061 RVA: 0x0001DB5D File Offset: 0x0001BD5D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player._DiscordLoop_d__197.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player._DiscordLoop_d__197.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001A65 RID: 6757
			// (get) Token: 0x06004E5E RID: 20062 RVA: 0x00153148 File Offset: 0x00151348
			// (set) Token: 0x06004E5F RID: 20063 RVA: 0x0001DB78 File Offset: 0x0001BD78
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player._DiscordLoop_d__197.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player._DiscordLoop_d__197.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003CAD RID: 15533
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003CAE RID: 15534
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003CAF RID: 15535
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003CB0 RID: 15536
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003CB1 RID: 15537
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003CB2 RID: 15538
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003CB3 RID: 15539
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003CB4 RID: 15540
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}

		// Token: 0x020003FD RID: 1021
		[ObfuscatedName("Polytoria.Datamodel.Player+<DoDie>d__222")]
		public sealed class _DoDie_d__222 : global::Il2CppSystem.Object
		{
			// Token: 0x06004E60 RID: 20064 RVA: 0x00153178 File Offset: 0x00151378
			// Note: this type is marked as 'beforefieldinit'.
			static _DoDie_d__222()
			{
				Il2CppClassPointerStore<Player._DoDie_d__222>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Player>.NativeClassPtr, "<DoDie>d__222");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Player._DoDie_d__222>.NativeClassPtr);
				Player._DoDie_d__222.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player._DoDie_d__222>.NativeClassPtr, "<>1__state");
				Player._DoDie_d__222.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player._DoDie_d__222>.NativeClassPtr, "<>2__current");
				Player._DoDie_d__222.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player._DoDie_d__222>.NativeClassPtr, "<>4__this");
				Player._DoDie_d__222.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player._DoDie_d__222>.NativeClassPtr, 100671942);
				Player._DoDie_d__222.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player._DoDie_d__222>.NativeClassPtr, 100671944);
				Player._DoDie_d__222.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player._DoDie_d__222>.NativeClassPtr, 100671939);
				Player._DoDie_d__222.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player._DoDie_d__222>.NativeClassPtr, 100671940);
				Player._DoDie_d__222.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player._DoDie_d__222>.NativeClassPtr, 100671941);
				Player._DoDie_d__222.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player._DoDie_d__222>.NativeClassPtr, 100671943);
			}

			// Token: 0x17001A6B RID: 6763
			// (get) Token: 0x06004E61 RID: 20065 RVA: 0x00153258 File Offset: 0x00151458
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player._DoDie_d__222.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001A6C RID: 6764
			// (get) Token: 0x06004E62 RID: 20066 RVA: 0x00153298 File Offset: 0x00151498
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player._DoDie_d__222.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004E63 RID: 20067 RVA: 0x001532D8 File Offset: 0x001514D8
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 10168, RefRangeEnd = 10216, XrefRangeStart = 10168, XrefRangeEnd = 10216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DoDie_d__222(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Player._DoDie_d__222>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player._DoDie_d__222.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004E64 RID: 20068 RVA: 0x00153320 File Offset: 0x00151520
			[CallerCount(7535)]
			[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player._DoDie_d__222.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004E65 RID: 20069 RVA: 0x00153354 File Offset: 0x00151554
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111869, XrefRangeEnd = 111908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player._DoDie_d__222.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004E66 RID: 20070 RVA: 0x00153390 File Offset: 0x00151590
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111908, XrefRangeEnd = 111913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player._DoDie_d__222.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004E67 RID: 20071 RVA: 0x0001DB97 File Offset: 0x0001BD97
			public _DoDie_d__222(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001A68 RID: 6760
			// (get) Token: 0x06004E68 RID: 20072 RVA: 0x001533C4 File Offset: 0x001515C4
			// (set) Token: 0x06004E69 RID: 20073 RVA: 0x0001DBA0 File Offset: 0x0001BDA0
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player._DoDie_d__222.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player._DoDie_d__222.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001A69 RID: 6761
			// (get) Token: 0x06004E6A RID: 20074 RVA: 0x001533EC File Offset: 0x001515EC
			// (set) Token: 0x06004E6B RID: 20075 RVA: 0x0001DBBB File Offset: 0x0001BDBB
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player._DoDie_d__222.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player._DoDie_d__222.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A6A RID: 6762
			// (get) Token: 0x06004E6C RID: 20076 RVA: 0x0015341C File Offset: 0x0015161C
			// (set) Token: 0x06004E6D RID: 20077 RVA: 0x0001DBDA File Offset: 0x0001BDDA
			public unsafe Player __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player._DoDie_d__222.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player._DoDie_d__222.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003CB5 RID: 15541
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003CB6 RID: 15542
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003CB7 RID: 15543
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003CB8 RID: 15544
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003CB9 RID: 15545
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003CBA RID: 15546
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003CBB RID: 15547
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003CBC RID: 15548
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003CBD RID: 15549
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}

		// Token: 0x020003FE RID: 1022
		[ObfuscatedName("Polytoria.Datamodel.Player+<LoadMetadata>d__207")]
		public sealed class _LoadMetadata_d__207 : global::Il2CppSystem.Object
		{
			// Token: 0x06004E6E RID: 20078 RVA: 0x0015344C File Offset: 0x0015164C
			// Note: this type is marked as 'beforefieldinit'.
			static _LoadMetadata_d__207()
			{
				Il2CppClassPointerStore<Player._LoadMetadata_d__207>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Player>.NativeClassPtr, "<LoadMetadata>d__207");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Player._LoadMetadata_d__207>.NativeClassPtr);
				Player._LoadMetadata_d__207.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player._LoadMetadata_d__207>.NativeClassPtr, "<>1__state");
				Player._LoadMetadata_d__207.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player._LoadMetadata_d__207>.NativeClassPtr, "<>2__current");
				Player._LoadMetadata_d__207.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player._LoadMetadata_d__207>.NativeClassPtr, "<>4__this");
				Player._LoadMetadata_d__207.NativeFieldInfoPtr_authToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player._LoadMetadata_d__207>.NativeClassPtr, "authToken");
				Player._LoadMetadata_d__207.NativeFieldInfoPtr__uwr_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player._LoadMetadata_d__207>.NativeClassPtr, "<uwr>5__2");
				Player._LoadMetadata_d__207.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player._LoadMetadata_d__207>.NativeClassPtr, 100671949);
				Player._LoadMetadata_d__207.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player._LoadMetadata_d__207>.NativeClassPtr, 100671951);
				Player._LoadMetadata_d__207.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player._LoadMetadata_d__207>.NativeClassPtr, 100671945);
				Player._LoadMetadata_d__207.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player._LoadMetadata_d__207>.NativeClassPtr, 100671946);
				Player._LoadMetadata_d__207.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player._LoadMetadata_d__207>.NativeClassPtr, 100671947);
				Player._LoadMetadata_d__207.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player._LoadMetadata_d__207>.NativeClassPtr, 100671948);
				Player._LoadMetadata_d__207.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player._LoadMetadata_d__207>.NativeClassPtr, 100671950);
			}

			// Token: 0x17001A72 RID: 6770
			// (get) Token: 0x06004E6F RID: 20079 RVA: 0x00153568 File Offset: 0x00151768
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player._LoadMetadata_d__207.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001A73 RID: 6771
			// (get) Token: 0x06004E70 RID: 20080 RVA: 0x001535A8 File Offset: 0x001517A8
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player._LoadMetadata_d__207.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004E71 RID: 20081 RVA: 0x001535E8 File Offset: 0x001517E8
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 10168, RefRangeEnd = 10216, XrefRangeStart = 10168, XrefRangeEnd = 10216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _LoadMetadata_d__207(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Player._LoadMetadata_d__207>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player._LoadMetadata_d__207.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004E72 RID: 20082 RVA: 0x00153630 File Offset: 0x00151830
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111913, XrefRangeEnd = 111918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player._LoadMetadata_d__207.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004E73 RID: 20083 RVA: 0x00153664 File Offset: 0x00151864
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111918, XrefRangeEnd = 111982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player._LoadMetadata_d__207.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004E74 RID: 20084 RVA: 0x001536A0 File Offset: 0x001518A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111982, XrefRangeEnd = 111985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player._LoadMetadata_d__207.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004E75 RID: 20085 RVA: 0x001536D4 File Offset: 0x001518D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111985, XrefRangeEnd = 111990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player._LoadMetadata_d__207.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004E76 RID: 20086 RVA: 0x0001DBF9 File Offset: 0x0001BDF9
			public _LoadMetadata_d__207(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001A6D RID: 6765
			// (get) Token: 0x06004E77 RID: 20087 RVA: 0x00153708 File Offset: 0x00151908
			// (set) Token: 0x06004E78 RID: 20088 RVA: 0x0001DC02 File Offset: 0x0001BE02
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player._LoadMetadata_d__207.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player._LoadMetadata_d__207.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001A6E RID: 6766
			// (get) Token: 0x06004E79 RID: 20089 RVA: 0x00153730 File Offset: 0x00151930
			// (set) Token: 0x06004E7A RID: 20090 RVA: 0x0001DC1D File Offset: 0x0001BE1D
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player._LoadMetadata_d__207.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player._LoadMetadata_d__207.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A6F RID: 6767
			// (get) Token: 0x06004E7B RID: 20091 RVA: 0x00153760 File Offset: 0x00151960
			// (set) Token: 0x06004E7C RID: 20092 RVA: 0x0001DC3C File Offset: 0x0001BE3C
			public unsafe Player __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player._LoadMetadata_d__207.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player._LoadMetadata_d__207.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A70 RID: 6768
			// (get) Token: 0x06004E7D RID: 20093 RVA: 0x00153790 File Offset: 0x00151990
			// (set) Token: 0x06004E7E RID: 20094 RVA: 0x0001DC5B File Offset: 0x0001BE5B
			public unsafe string authToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player._LoadMetadata_d__207.NativeFieldInfoPtr_authToken);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player._LoadMetadata_d__207.NativeFieldInfoPtr_authToken), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001A71 RID: 6769
			// (get) Token: 0x06004E7F RID: 20095 RVA: 0x001537B8 File Offset: 0x001519B8
			// (set) Token: 0x06004E80 RID: 20096 RVA: 0x0001DC7A File Offset: 0x0001BE7A
			public unsafe UnityWebRequest _uwr_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player._LoadMetadata_d__207.NativeFieldInfoPtr__uwr_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player._LoadMetadata_d__207.NativeFieldInfoPtr__uwr_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003CBE RID: 15550
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003CBF RID: 15551
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003CC0 RID: 15552
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003CC1 RID: 15553
			private static readonly IntPtr NativeFieldInfoPtr_authToken;

			// Token: 0x04003CC2 RID: 15554
			private static readonly IntPtr NativeFieldInfoPtr__uwr_5__2;

			// Token: 0x04003CC3 RID: 15555
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003CC4 RID: 15556
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003CC5 RID: 15557
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003CC6 RID: 15558
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003CC7 RID: 15559
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003CC8 RID: 15560
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04003CC9 RID: 15561
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}

		// Token: 0x020003FF RID: 1023
		[ObfuscatedName("Polytoria.Datamodel.Player+<PostPlayerLoad>d__196")]
		public sealed class _PostPlayerLoad_d__196 : global::Il2CppSystem.Object
		{
			// Token: 0x06004E81 RID: 20097 RVA: 0x001537E8 File Offset: 0x001519E8
			// Note: this type is marked as 'beforefieldinit'.
			static _PostPlayerLoad_d__196()
			{
				Il2CppClassPointerStore<Player._PostPlayerLoad_d__196>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Player>.NativeClassPtr, "<PostPlayerLoad>d__196");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Player._PostPlayerLoad_d__196>.NativeClassPtr);
				Player._PostPlayerLoad_d__196.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player._PostPlayerLoad_d__196>.NativeClassPtr, "<>1__state");
				Player._PostPlayerLoad_d__196.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player._PostPlayerLoad_d__196>.NativeClassPtr, "<>2__current");
				Player._PostPlayerLoad_d__196.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player._PostPlayerLoad_d__196>.NativeClassPtr, "<>4__this");
				Player._PostPlayerLoad_d__196.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player._PostPlayerLoad_d__196>.NativeClassPtr, 100671955);
				Player._PostPlayerLoad_d__196.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player._PostPlayerLoad_d__196>.NativeClassPtr, 100671957);
				Player._PostPlayerLoad_d__196.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player._PostPlayerLoad_d__196>.NativeClassPtr, 100671952);
				Player._PostPlayerLoad_d__196.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player._PostPlayerLoad_d__196>.NativeClassPtr, 100671953);
				Player._PostPlayerLoad_d__196.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player._PostPlayerLoad_d__196>.NativeClassPtr, 100671954);
				Player._PostPlayerLoad_d__196.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player._PostPlayerLoad_d__196>.NativeClassPtr, 100671956);
			}

			// Token: 0x17001A77 RID: 6775
			// (get) Token: 0x06004E82 RID: 20098 RVA: 0x001538C8 File Offset: 0x00151AC8
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player._PostPlayerLoad_d__196.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001A78 RID: 6776
			// (get) Token: 0x06004E83 RID: 20099 RVA: 0x00153908 File Offset: 0x00151B08
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player._PostPlayerLoad_d__196.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004E84 RID: 20100 RVA: 0x00153948 File Offset: 0x00151B48
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 10168, RefRangeEnd = 10216, XrefRangeStart = 10168, XrefRangeEnd = 10216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _PostPlayerLoad_d__196(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Player._PostPlayerLoad_d__196>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player._PostPlayerLoad_d__196.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004E85 RID: 20101 RVA: 0x00153990 File Offset: 0x00151B90
			[CallerCount(7535)]
			[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player._PostPlayerLoad_d__196.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004E86 RID: 20102 RVA: 0x001539C4 File Offset: 0x00151BC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111990, XrefRangeEnd = 112112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player._PostPlayerLoad_d__196.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004E87 RID: 20103 RVA: 0x00153A00 File Offset: 0x00151C00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112112, XrefRangeEnd = 112117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player._PostPlayerLoad_d__196.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004E88 RID: 20104 RVA: 0x0001DC99 File Offset: 0x0001BE99
			public _PostPlayerLoad_d__196(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001A74 RID: 6772
			// (get) Token: 0x06004E89 RID: 20105 RVA: 0x00153A34 File Offset: 0x00151C34
			// (set) Token: 0x06004E8A RID: 20106 RVA: 0x0001DCA2 File Offset: 0x0001BEA2
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player._PostPlayerLoad_d__196.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player._PostPlayerLoad_d__196.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001A75 RID: 6773
			// (get) Token: 0x06004E8B RID: 20107 RVA: 0x00153A5C File Offset: 0x00151C5C
			// (set) Token: 0x06004E8C RID: 20108 RVA: 0x0001DCBD File Offset: 0x0001BEBD
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player._PostPlayerLoad_d__196.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player._PostPlayerLoad_d__196.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A76 RID: 6774
			// (get) Token: 0x06004E8D RID: 20109 RVA: 0x00153A8C File Offset: 0x00151C8C
			// (set) Token: 0x06004E8E RID: 20110 RVA: 0x0001DCDC File Offset: 0x0001BEDC
			public unsafe Player __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player._PostPlayerLoad_d__196.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player._PostPlayerLoad_d__196.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003CCA RID: 15562
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003CCB RID: 15563
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003CCC RID: 15564
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003CCD RID: 15565
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003CCE RID: 15566
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003CCF RID: 15567
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003CD0 RID: 15568
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003CD1 RID: 15569
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003CD2 RID: 15570
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}

		// Token: 0x02000400 RID: 1024
		[ObfuscatedName("Polytoria.Datamodel.Player+<StopScream>d__211")]
		public sealed class _StopScream_d__211 : global::Il2CppSystem.Object
		{
			// Token: 0x06004E8F RID: 20111 RVA: 0x00153ABC File Offset: 0x00151CBC
			// Note: this type is marked as 'beforefieldinit'.
			static _StopScream_d__211()
			{
				Il2CppClassPointerStore<Player._StopScream_d__211>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Player>.NativeClassPtr, "<StopScream>d__211");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Player._StopScream_d__211>.NativeClassPtr);
				Player._StopScream_d__211.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player._StopScream_d__211>.NativeClassPtr, "<>1__state");
				Player._StopScream_d__211.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player._StopScream_d__211>.NativeClassPtr, "<>2__current");
				Player._StopScream_d__211.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Player._StopScream_d__211>.NativeClassPtr, "<>4__this");
				Player._StopScream_d__211.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player._StopScream_d__211>.NativeClassPtr, 100671961);
				Player._StopScream_d__211.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player._StopScream_d__211>.NativeClassPtr, 100671963);
				Player._StopScream_d__211.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player._StopScream_d__211>.NativeClassPtr, 100671958);
				Player._StopScream_d__211.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player._StopScream_d__211>.NativeClassPtr, 100671959);
				Player._StopScream_d__211.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player._StopScream_d__211>.NativeClassPtr, 100671960);
				Player._StopScream_d__211.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Player._StopScream_d__211>.NativeClassPtr, 100671962);
			}

			// Token: 0x17001A7C RID: 6780
			// (get) Token: 0x06004E90 RID: 20112 RVA: 0x00153B9C File Offset: 0x00151D9C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player._StopScream_d__211.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001A7D RID: 6781
			// (get) Token: 0x06004E91 RID: 20113 RVA: 0x00153BDC File Offset: 0x00151DDC
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player._StopScream_d__211.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004E92 RID: 20114 RVA: 0x00153C1C File Offset: 0x00151E1C
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 10168, RefRangeEnd = 10216, XrefRangeStart = 10168, XrefRangeEnd = 10216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _StopScream_d__211(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Player._StopScream_d__211>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player._StopScream_d__211.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004E93 RID: 20115 RVA: 0x00153C64 File Offset: 0x00151E64
			[CallerCount(7535)]
			[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player._StopScream_d__211.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004E94 RID: 20116 RVA: 0x00153C98 File Offset: 0x00151E98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112117, XrefRangeEnd = 112123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player._StopScream_d__211.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004E95 RID: 20117 RVA: 0x00153CD4 File Offset: 0x00151ED4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112123, XrefRangeEnd = 112128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Player._StopScream_d__211.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004E96 RID: 20118 RVA: 0x0001DCFB File Offset: 0x0001BEFB
			public _StopScream_d__211(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001A79 RID: 6777
			// (get) Token: 0x06004E97 RID: 20119 RVA: 0x00153D08 File Offset: 0x00151F08
			// (set) Token: 0x06004E98 RID: 20120 RVA: 0x0001DD04 File Offset: 0x0001BF04
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player._StopScream_d__211.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player._StopScream_d__211.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001A7A RID: 6778
			// (get) Token: 0x06004E99 RID: 20121 RVA: 0x00153D30 File Offset: 0x00151F30
			// (set) Token: 0x06004E9A RID: 20122 RVA: 0x0001DD1F File Offset: 0x0001BF1F
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player._StopScream_d__211.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player._StopScream_d__211.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A7B RID: 6779
			// (get) Token: 0x06004E9B RID: 20123 RVA: 0x00153D60 File Offset: 0x00151F60
			// (set) Token: 0x06004E9C RID: 20124 RVA: 0x0001DD3E File Offset: 0x0001BF3E
			public unsafe Player __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player._StopScream_d__211.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Player._StopScream_d__211.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003CD3 RID: 15571
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003CD4 RID: 15572
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003CD5 RID: 15573
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003CD6 RID: 15574
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003CD7 RID: 15575
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003CD8 RID: 15576
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003CD9 RID: 15577
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003CDA RID: 15578
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003CDB RID: 15579
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}
	}
}
