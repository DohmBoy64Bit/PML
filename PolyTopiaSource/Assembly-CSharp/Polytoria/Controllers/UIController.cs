using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Polytoria.Datamodel;
using Polytoria.UI;
using SimpleJSON;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

namespace Polytoria.Controllers
{
	// Token: 0x0200033C RID: 828
	public class UIController : MonoBehaviour
	{
		// Token: 0x060046EE RID: 18158 RVA: 0x0013B4C8 File Offset: 0x001396C8
		// Note: this type is marked as 'beforefieldinit'.
		static UIController()
		{
			Il2CppClassPointerStore<UIController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Controllers", "UIController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIController>.NativeClassPtr);
			UIController.NativeFieldInfoPtr_maxDebugLogLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIController>.NativeClassPtr, "maxDebugLogLength");
			UIController.NativeFieldInfoPtr_singleton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIController>.NativeClassPtr, "singleton");
			UIController.NativeFieldInfoPtr_Resetted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIController>.NativeClassPtr, "Resetted");
			UIController.NativeFieldInfoPtr_selectedBtnColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIController>.NativeClassPtr, "selectedBtnColor");
			UIController.NativeFieldInfoPtr_unselectedBtnColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIController>.NativeClassPtr, "unselectedBtnColor");
			UIController.NativeFieldInfoPtr_healthBarGreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIController>.NativeClassPtr, "healthBarGreen");
			UIController.NativeFieldInfoPtr_healthBarRed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIController>.NativeClassPtr, "healthBarRed");
			UIController.NativeFieldInfoPtr_tabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIController>.NativeClassPtr, "tabs");
			UIController.NativeFieldInfoPtr_GameName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIController>.NativeClassPtr, "GameName");
			UIController.NativeFieldInfoPtr_timeWhenStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIController>.NativeClassPtr, "timeWhenStarted");
			UIController.NativeFieldInfoPtr__Leaderboard_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIController>.NativeClassPtr, "<Leaderboard>k__BackingField");
			UIController.NativeFieldInfoPtr__LeaderboardContent_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIController>.NativeClassPtr, "<LeaderboardContent>k__BackingField");
			UIController.NativeFieldInfoPtr__UserTag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIController>.NativeClassPtr, "<UserTag>k__BackingField");
			UIController.NativeFieldInfoPtr__PauseMenu_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIController>.NativeClassPtr, "<PauseMenu>k__BackingField");
			UIController.NativeFieldInfoPtr__ChatButton_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIController>.NativeClassPtr, "<ChatButton>k__BackingField");
			UIController.NativeFieldInfoPtr__InventoryButton_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIController>.NativeClassPtr, "<InventoryButton>k__BackingField");
			UIController.NativeFieldInfoPtr__DebugConsole_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIController>.NativeClassPtr, "<DebugConsole>k__BackingField");
			UIController.NativeFieldInfoPtr__PauseMenuImg_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIController>.NativeClassPtr, "<PauseMenuImg>k__BackingField");
			UIController.NativeFieldInfoPtr__PauseMenuChild_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIController>.NativeClassPtr, "<PauseMenuChild>k__BackingField");
			UIController.NativeFieldInfoPtr__Canvas_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIController>.NativeClassPtr, "<Canvas>k__BackingField");
			UIController.NativeFieldInfoPtr__ChatBar_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIController>.NativeClassPtr, "<ChatBar>k__BackingField");
			UIController.NativeFieldInfoPtr__Paused_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIController>.NativeClassPtr, "<Paused>k__BackingField");
			UIController.NativeFieldInfoPtr__ConsoleOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIController>.NativeClassPtr, "<ConsoleOpen>k__BackingField");
			UIController.NativeFieldInfoPtr__HealthbarCont_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIController>.NativeClassPtr, "<HealthbarCont>k__BackingField");
			UIController.NativeFieldInfoPtr__Healthbar_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIController>.NativeClassPtr, "<Healthbar>k__BackingField");
			UIController.NativeFieldInfoPtr__HealthbarHeart_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIController>.NativeClassPtr, "<HealthbarHeart>k__BackingField");
			UIController.NativeFieldInfoPtr__HealthbarHeartText_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIController>.NativeClassPtr, "<HealthbarHeartText>k__BackingField");
			UIController.NativeFieldInfoPtr__StaminaBar_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIController>.NativeClassPtr, "<StaminaBar>k__BackingField");
			UIController.NativeFieldInfoPtr_leaderboardEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIController>.NativeClassPtr, "leaderboardEntry");
			UIController.NativeFieldInfoPtr_main = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIController>.NativeClassPtr, "main");
			UIController.NativeFieldInfoPtr_alwaysOnTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIController>.NativeClassPtr, "alwaysOnTop");
			UIController.NativeFieldInfoPtr_logsParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIController>.NativeClassPtr, "logsParent");
			UIController.NativeFieldInfoPtr_playerListMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIController>.NativeClassPtr, "playerListMenu");
			UIController.NativeFieldInfoPtr_playerListMenuEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIController>.NativeClassPtr, "playerListMenuEntry");
			UIController.NativeFieldInfoPtr_debugLogMessageTemplate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIController>.NativeClassPtr, "debugLogMessageTemplate");
			UIController.NativeFieldInfoPtr_menuController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIController>.NativeClassPtr, "menuController");
			UIController.NativeFieldInfoPtr_overviewUsername = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIController>.NativeClassPtr, "overviewUsername");
			UIController.NativeFieldInfoPtr_timePlaying = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIController>.NativeClassPtr, "timePlaying");
			UIController.NativeFieldInfoPtr_playerCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIController>.NativeClassPtr, "playerCount");
			UIController.NativeFieldInfoPtr_instanceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIController>.NativeClassPtr, "instanceCount");
			UIController.NativeFieldInfoPtr_debugLogs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIController>.NativeClassPtr, "debugLogs");
			UIController.NativeFieldInfoPtr_localText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIController>.NativeClassPtr, "localText");
			UIController.NativeFieldInfoPtr_pauseMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIController>.NativeClassPtr, "pauseMenu");
			UIController.NativeFieldInfoPtr_disconnectScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIController>.NativeClassPtr, "disconnectScreen");
			UIController.NativeFieldInfoPtr_lockState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIController>.NativeClassPtr, "lockState");
			UIController.NativeFieldInfoPtr_localUsername = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIController>.NativeClassPtr, "localUsername");
			UIController.NativeFieldInfoPtr_lbOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIController>.NativeClassPtr, "lbOpen");
			UIController.NativeFieldInfoPtr_PauseDebounce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIController>.NativeClassPtr, "PauseDebounce");
			UIController.NativeFieldInfoPtr_badgeIcons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIController>.NativeClassPtr, "badgeIcons");
			UIController.NativeFieldInfoPtr_LeaderboardUsers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIController>.NativeClassPtr, "LeaderboardUsers");
			UIController.NativeFieldInfoPtr_PlayerListUsers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIController>.NativeClassPtr, "PlayerListUsers");
			UIController.NativeFieldInfoPtr_ConsoleDebounce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIController>.NativeClassPtr, "ConsoleDebounce");
			UIController.NativeMethodInfoPtr_get_Leaderboard_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController>.NativeClassPtr, 100674541);
			UIController.NativeMethodInfoPtr_set_Leaderboard_Private_set_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController>.NativeClassPtr, 100674542);
			UIController.NativeMethodInfoPtr_get_LeaderboardContent_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController>.NativeClassPtr, 100674543);
			UIController.NativeMethodInfoPtr_set_LeaderboardContent_Private_set_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController>.NativeClassPtr, 100674544);
			UIController.NativeMethodInfoPtr_get_UserTag_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController>.NativeClassPtr, 100674545);
			UIController.NativeMethodInfoPtr_set_UserTag_Private_set_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController>.NativeClassPtr, 100674546);
			UIController.NativeMethodInfoPtr_get_PauseMenu_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController>.NativeClassPtr, 100674547);
			UIController.NativeMethodInfoPtr_set_PauseMenu_Private_set_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController>.NativeClassPtr, 100674548);
			UIController.NativeMethodInfoPtr_get_ChatButton_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController>.NativeClassPtr, 100674549);
			UIController.NativeMethodInfoPtr_set_ChatButton_Private_set_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController>.NativeClassPtr, 100674550);
			UIController.NativeMethodInfoPtr_get_InventoryButton_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController>.NativeClassPtr, 100674551);
			UIController.NativeMethodInfoPtr_set_InventoryButton_Private_set_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController>.NativeClassPtr, 100674552);
			UIController.NativeMethodInfoPtr_get_DebugConsole_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController>.NativeClassPtr, 100674553);
			UIController.NativeMethodInfoPtr_set_DebugConsole_Private_set_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController>.NativeClassPtr, 100674554);
			UIController.NativeMethodInfoPtr_get_PauseMenuImg_Public_get_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController>.NativeClassPtr, 100674555);
			UIController.NativeMethodInfoPtr_set_PauseMenuImg_Private_set_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController>.NativeClassPtr, 100674556);
			UIController.NativeMethodInfoPtr_get_PauseMenuChild_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController>.NativeClassPtr, 100674557);
			UIController.NativeMethodInfoPtr_set_PauseMenuChild_Private_set_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController>.NativeClassPtr, 100674558);
			UIController.NativeMethodInfoPtr_get_Canvas_Public_get_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController>.NativeClassPtr, 100674559);
			UIController.NativeMethodInfoPtr_set_Canvas_Private_set_Void_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController>.NativeClassPtr, 100674560);
			UIController.NativeMethodInfoPtr_get_ChatBar_Public_get_TMP_InputField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController>.NativeClassPtr, 100674561);
			UIController.NativeMethodInfoPtr_set_ChatBar_Private_set_Void_TMP_InputField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController>.NativeClassPtr, 100674562);
			UIController.NativeMethodInfoPtr_get_Paused_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController>.NativeClassPtr, 100674563);
			UIController.NativeMethodInfoPtr_set_Paused_Private_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController>.NativeClassPtr, 100674564);
			UIController.NativeMethodInfoPtr_get_ConsoleOpen_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController>.NativeClassPtr, 100674565);
			UIController.NativeMethodInfoPtr_set_ConsoleOpen_Private_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController>.NativeClassPtr, 100674566);
			UIController.NativeMethodInfoPtr_get_HealthbarCont_Public_get_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController>.NativeClassPtr, 100674567);
			UIController.NativeMethodInfoPtr_set_HealthbarCont_Private_set_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController>.NativeClassPtr, 100674568);
			UIController.NativeMethodInfoPtr_get_Healthbar_Public_get_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController>.NativeClassPtr, 100674569);
			UIController.NativeMethodInfoPtr_set_Healthbar_Private_set_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController>.NativeClassPtr, 100674570);
			UIController.NativeMethodInfoPtr_get_HealthbarHeart_Public_get_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController>.NativeClassPtr, 100674571);
			UIController.NativeMethodInfoPtr_set_HealthbarHeart_Private_set_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController>.NativeClassPtr, 100674572);
			UIController.NativeMethodInfoPtr_get_HealthbarHeartText_Public_get_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController>.NativeClassPtr, 100674573);
			UIController.NativeMethodInfoPtr_set_HealthbarHeartText_Private_set_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController>.NativeClassPtr, 100674574);
			UIController.NativeMethodInfoPtr_get_StaminaBar_Public_get_UIStaminaBar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController>.NativeClassPtr, 100674575);
			UIController.NativeMethodInfoPtr_set_StaminaBar_Private_set_Void_UIStaminaBar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController>.NativeClassPtr, 100674576);
			UIController.NativeMethodInfoPtr_add_Resetted_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController>.NativeClassPtr, 100674539);
			UIController.NativeMethodInfoPtr_remove_Resetted_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController>.NativeClassPtr, 100674540);
			UIController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController>.NativeClassPtr, 100674605);
			UIController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController>.NativeClassPtr, 100674577);
			UIController.NativeMethodInfoPtr_SetActiveMenuTab_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController>.NativeClassPtr, 100674578);
			UIController.NativeMethodInfoPtr_SetButtonFocused_Public_Void_HudButton_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController>.NativeClassPtr, 100674579);
			UIController.NativeMethodInfoPtr_ToggleLeaderboard_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController>.NativeClassPtr, 100674580);
			UIController.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController>.NativeClassPtr, 100674581);
			UIController.NativeMethodInfoPtr_UpdateInstanceCount_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController>.NativeClassPtr, 100674582);
			UIController.NativeMethodInfoPtr_UpdateTimer_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController>.NativeClassPtr, 100674583);
			UIController.NativeMethodInfoPtr_UpdatePlayerCount_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController>.NativeClassPtr, 100674584);
			UIController.NativeMethodInfoPtr_ResetCharacter_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController>.NativeClassPtr, 100674585);
			UIController.NativeMethodInfoPtr_ExitGame_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController>.NativeClassPtr, 100674586);
			UIController.NativeMethodInfoPtr_TogglePaused_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController>.NativeClassPtr, 100674587);
			UIController.NativeMethodInfoPtr_SetPaused_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController>.NativeClassPtr, 100674588);
			UIController.NativeMethodInfoPtr_SetGameInfo_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController>.NativeClassPtr, 100674589);
			UIController.NativeMethodInfoPtr_GetLeaderboardBadgeIcon_Public_Sprite_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController>.NativeClassPtr, 100674590);
			UIController.NativeMethodInfoPtr_AddLeaderboardUser_Public_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController>.NativeClassPtr, 100674591);
			UIController.NativeMethodInfoPtr_LoadLeaderboardThumbnail_Private_IEnumerator_RectTransform_RectTransform_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController>.NativeClassPtr, 100674592);
			UIController.NativeMethodInfoPtr_RemoveLeaderboardUser_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController>.NativeClassPtr, 100674593);
			UIController.NativeMethodInfoPtr_SetUserCard_Public_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController>.NativeClassPtr, 100674594);
			UIController.NativeMethodInfoPtr_ReceiveChat_Public_Void_String_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController>.NativeClassPtr, 100674595);
			UIController.NativeMethodInfoPtr_DebugLog_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController>.NativeClassPtr, 100674596);
			UIController.NativeMethodInfoPtr_SetHealthFilled_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController>.NativeClassPtr, 100674597);
			UIController.NativeMethodInfoPtr_SetStaminaFilled_Public_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController>.NativeClassPtr, 100674598);
			UIController.NativeMethodInfoPtr_ToggleConsole_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController>.NativeClassPtr, 100674599);
			UIController.NativeMethodInfoPtr_OpenConsoleFromPauseMenu_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController>.NativeClassPtr, 100674600);
			UIController.NativeMethodInfoPtr_SetConsoleOpen_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController>.NativeClassPtr, 100674601);
			UIController.NativeMethodInfoPtr_LoadThumbnail_Private_IEnumerator_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController>.NativeClassPtr, 100674602);
			UIController.NativeMethodInfoPtr_FlipTexture_Private_Texture2D_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController>.NativeClassPtr, 100674603);
			UIController.NativeMethodInfoPtr_ShowDisconnectMessage_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController>.NativeClassPtr, 100674604);
			UIController.NativeMethodInfoPtr_Method_Private_Void_Single_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController>.NativeClassPtr, 100674607);
			UIController.NativeMethodInfoPtr__SetPaused_b__116_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController>.NativeClassPtr, 100674608);
			UIController.NativeMethodInfoPtr__SetPaused_b__116_2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController>.NativeClassPtr, 100674609);
			UIController.NativeMethodInfoPtr__SetConsoleOpen_b__133_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController>.NativeClassPtr, 100674610);
			UIController.NativeMethodInfoPtr__SetConsoleOpen_b__133_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController>.NativeClassPtr, 100674611);
		}

		// Token: 0x17001879 RID: 6265
		// (get) Token: 0x060046EF RID: 18159 RVA: 0x0013BEA8 File Offset: 0x0013A0A8
		// (set) Token: 0x060046F0 RID: 18160 RVA: 0x0013BEE8 File Offset: 0x0013A0E8
		public unsafe RectTransform Leaderboard
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.NativeMethodInfoPtr_get_Leaderboard_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.NativeMethodInfoPtr_set_Leaderboard_Private_set_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700187A RID: 6266
		// (get) Token: 0x060046F1 RID: 18161 RVA: 0x0013BF2C File Offset: 0x0013A12C
		// (set) Token: 0x060046F2 RID: 18162 RVA: 0x0013BF6C File Offset: 0x0013A16C
		public unsafe RectTransform LeaderboardContent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.NativeMethodInfoPtr_get_LeaderboardContent_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.NativeMethodInfoPtr_set_LeaderboardContent_Private_set_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700187B RID: 6267
		// (get) Token: 0x060046F3 RID: 18163 RVA: 0x0013BFB0 File Offset: 0x0013A1B0
		// (set) Token: 0x060046F4 RID: 18164 RVA: 0x0013BFF0 File Offset: 0x0013A1F0
		public unsafe RectTransform UserTag
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.NativeMethodInfoPtr_get_UserTag_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.NativeMethodInfoPtr_set_UserTag_Private_set_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700187C RID: 6268
		// (get) Token: 0x060046F5 RID: 18165 RVA: 0x0013C034 File Offset: 0x0013A234
		// (set) Token: 0x060046F6 RID: 18166 RVA: 0x0013C074 File Offset: 0x0013A274
		public unsafe RectTransform PauseMenu
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.NativeMethodInfoPtr_get_PauseMenu_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.NativeMethodInfoPtr_set_PauseMenu_Private_set_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700187D RID: 6269
		// (get) Token: 0x060046F7 RID: 18167 RVA: 0x0013C0B8 File Offset: 0x0013A2B8
		// (set) Token: 0x060046F8 RID: 18168 RVA: 0x0013C0F8 File Offset: 0x0013A2F8
		public unsafe RectTransform ChatButton
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.NativeMethodInfoPtr_get_ChatButton_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.NativeMethodInfoPtr_set_ChatButton_Private_set_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700187E RID: 6270
		// (get) Token: 0x060046F9 RID: 18169 RVA: 0x0013C13C File Offset: 0x0013A33C
		// (set) Token: 0x060046FA RID: 18170 RVA: 0x0013C17C File Offset: 0x0013A37C
		public unsafe RectTransform InventoryButton
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.NativeMethodInfoPtr_get_InventoryButton_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.NativeMethodInfoPtr_set_InventoryButton_Private_set_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700187F RID: 6271
		// (get) Token: 0x060046FB RID: 18171 RVA: 0x0013C1C0 File Offset: 0x0013A3C0
		// (set) Token: 0x060046FC RID: 18172 RVA: 0x0013C200 File Offset: 0x0013A400
		public unsafe RectTransform DebugConsole
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.NativeMethodInfoPtr_get_DebugConsole_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.NativeMethodInfoPtr_set_DebugConsole_Private_set_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001880 RID: 6272
		// (get) Token: 0x060046FD RID: 18173 RVA: 0x0013C244 File Offset: 0x0013A444
		// (set) Token: 0x060046FE RID: 18174 RVA: 0x0013C284 File Offset: 0x0013A484
		public unsafe Image PauseMenuImg
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.NativeMethodInfoPtr_get_PauseMenuImg_Public_get_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Image>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.NativeMethodInfoPtr_set_PauseMenuImg_Private_set_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001881 RID: 6273
		// (get) Token: 0x060046FF RID: 18175 RVA: 0x0013C2C8 File Offset: 0x0013A4C8
		// (set) Token: 0x06004700 RID: 18176 RVA: 0x0013C308 File Offset: 0x0013A508
		public unsafe RectTransform PauseMenuChild
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.NativeMethodInfoPtr_get_PauseMenuChild_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.NativeMethodInfoPtr_set_PauseMenuChild_Private_set_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001882 RID: 6274
		// (get) Token: 0x06004701 RID: 18177 RVA: 0x0013C34C File Offset: 0x0013A54C
		// (set) Token: 0x06004702 RID: 18178 RVA: 0x0013C38C File Offset: 0x0013A58C
		public unsafe Canvas Canvas
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.NativeMethodInfoPtr_get_Canvas_Public_get_Canvas_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.NativeMethodInfoPtr_set_Canvas_Private_set_Void_Canvas_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001883 RID: 6275
		// (get) Token: 0x06004703 RID: 18179 RVA: 0x0013C3D0 File Offset: 0x0013A5D0
		// (set) Token: 0x06004704 RID: 18180 RVA: 0x0013C410 File Offset: 0x0013A610
		public unsafe TMP_InputField ChatBar
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.NativeMethodInfoPtr_get_ChatBar_Public_get_TMP_InputField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17932, RefRangeEnd = 17933, XrefRangeStart = 17932, XrefRangeEnd = 17933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.NativeMethodInfoPtr_set_ChatBar_Private_set_Void_TMP_InputField_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001884 RID: 6276
		// (get) Token: 0x06004705 RID: 18181 RVA: 0x0013C454 File Offset: 0x0013A654
		// (set) Token: 0x06004706 RID: 18182 RVA: 0x0013C484 File Offset: 0x0013A684
		public unsafe static bool Paused
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138280, XrefRangeEnd = 138284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.NativeMethodInfoPtr_get_Paused_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138284, XrefRangeEnd = 138288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.NativeMethodInfoPtr_set_Paused_Private_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001885 RID: 6277
		// (get) Token: 0x06004707 RID: 18183 RVA: 0x0013C4B8 File Offset: 0x0013A6B8
		// (set) Token: 0x06004708 RID: 18184 RVA: 0x0013C4E8 File Offset: 0x0013A6E8
		public unsafe static bool ConsoleOpen
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138288, XrefRangeEnd = 138292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.NativeMethodInfoPtr_get_ConsoleOpen_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138292, XrefRangeEnd = 138296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.NativeMethodInfoPtr_set_ConsoleOpen_Private_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001886 RID: 6278
		// (get) Token: 0x06004709 RID: 18185 RVA: 0x0013C51C File Offset: 0x0013A71C
		// (set) Token: 0x0600470A RID: 18186 RVA: 0x0013C55C File Offset: 0x0013A75C
		public unsafe Image HealthbarCont
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.NativeMethodInfoPtr_get_HealthbarCont_Public_get_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Image>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.NativeMethodInfoPtr_set_HealthbarCont_Private_set_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001887 RID: 6279
		// (get) Token: 0x0600470B RID: 18187 RVA: 0x0013C5A0 File Offset: 0x0013A7A0
		// (set) Token: 0x0600470C RID: 18188 RVA: 0x0013C5E0 File Offset: 0x0013A7E0
		public unsafe Image Healthbar
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.NativeMethodInfoPtr_get_Healthbar_Public_get_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Image>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.NativeMethodInfoPtr_set_Healthbar_Private_set_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001888 RID: 6280
		// (get) Token: 0x0600470D RID: 18189 RVA: 0x0013C624 File Offset: 0x0013A824
		// (set) Token: 0x0600470E RID: 18190 RVA: 0x0013C664 File Offset: 0x0013A864
		public unsafe Image HealthbarHeart
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.NativeMethodInfoPtr_get_HealthbarHeart_Public_get_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Image>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.NativeMethodInfoPtr_set_HealthbarHeart_Private_set_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001889 RID: 6281
		// (get) Token: 0x0600470F RID: 18191 RVA: 0x0013C6A8 File Offset: 0x0013A8A8
		// (set) Token: 0x06004710 RID: 18192 RVA: 0x0013C6E8 File Offset: 0x0013A8E8
		public unsafe TMP_Text HealthbarHeartText
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.NativeMethodInfoPtr_get_HealthbarHeartText_Public_get_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.NativeMethodInfoPtr_set_HealthbarHeartText_Private_set_Void_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700188A RID: 6282
		// (get) Token: 0x06004711 RID: 18193 RVA: 0x0013C72C File Offset: 0x0013A92C
		// (set) Token: 0x06004712 RID: 18194 RVA: 0x0013C76C File Offset: 0x0013A96C
		public unsafe UIStaminaBar StaminaBar
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.NativeMethodInfoPtr_get_StaminaBar_Public_get_UIStaminaBar_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UIStaminaBar>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138296, XrefRangeEnd = 138304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.NativeMethodInfoPtr_set_StaminaBar_Private_set_Void_UIStaminaBar_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06004713 RID: 18195 RVA: 0x0013C7B0 File Offset: 0x0013A9B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 138308, RefRangeEnd = 138309, XrefRangeStart = 138304, XrefRangeEnd = 138308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_Resetted(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.NativeMethodInfoPtr_add_Resetted_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004714 RID: 18196 RVA: 0x0013C7F4 File Offset: 0x0013A9F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138309, XrefRangeEnd = 138313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_Resetted(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.NativeMethodInfoPtr_remove_Resetted_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004715 RID: 18197 RVA: 0x0013C838 File Offset: 0x0013AA38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138313, XrefRangeEnd = 138337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIController()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004716 RID: 18198 RVA: 0x0013C874 File Offset: 0x0013AA74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138337, XrefRangeEnd = 138557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004717 RID: 18199 RVA: 0x0013C8A8 File Offset: 0x0013AAA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 138569, RefRangeEnd = 138571, XrefRangeStart = 138557, XrefRangeEnd = 138569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetActiveMenuTab(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.NativeMethodInfoPtr_SetActiveMenuTab_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004718 RID: 18200 RVA: 0x0013C8E8 File Offset: 0x0013AAE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 138579, RefRangeEnd = 138580, XrefRangeStart = 138571, XrefRangeEnd = 138579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetButtonFocused(UIController.HudButton type, bool focused)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref focused;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.NativeMethodInfoPtr_SetButtonFocused_Public_Void_HudButton_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004719 RID: 18201 RVA: 0x0013C934 File Offset: 0x0013AB34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138580, XrefRangeEnd = 138594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ToggleLeaderboard()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.NativeMethodInfoPtr_ToggleLeaderboard_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600471A RID: 18202 RVA: 0x0013C968 File Offset: 0x0013AB68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138594, XrefRangeEnd = 138656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600471B RID: 18203 RVA: 0x0013C99C File Offset: 0x0013AB9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138656, XrefRangeEnd = 138669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInstanceCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.NativeMethodInfoPtr_UpdateInstanceCount_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600471C RID: 18204 RVA: 0x0013C9D0 File Offset: 0x0013ABD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 138703, RefRangeEnd = 138704, XrefRangeStart = 138669, XrefRangeEnd = 138703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTimer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.NativeMethodInfoPtr_UpdateTimer_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600471D RID: 18205 RVA: 0x0013CA04 File Offset: 0x0013AC04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138704, XrefRangeEnd = 138718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePlayerCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.NativeMethodInfoPtr_UpdatePlayerCount_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600471E RID: 18206 RVA: 0x0013CA38 File Offset: 0x0013AC38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138718, XrefRangeEnd = 138719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetCharacter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.NativeMethodInfoPtr_ResetCharacter_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600471F RID: 18207 RVA: 0x0013CA6C File Offset: 0x0013AC6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138719, XrefRangeEnd = 138723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExitGame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.NativeMethodInfoPtr_ExitGame_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004720 RID: 18208 RVA: 0x0013CAA0 File Offset: 0x0013ACA0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 138731, RefRangeEnd = 138735, XrefRangeStart = 138723, XrefRangeEnd = 138731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TogglePaused()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.NativeMethodInfoPtr_TogglePaused_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004721 RID: 18209 RVA: 0x0013CAD4 File Offset: 0x0013ACD4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 138811, RefRangeEnd = 138813, XrefRangeStart = 138735, XrefRangeEnd = 138811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPaused(bool paused)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref paused;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.NativeMethodInfoPtr_SetPaused_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004722 RID: 18210 RVA: 0x0013CB14 File Offset: 0x0013AD14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 138814, RefRangeEnd = 138815, XrefRangeStart = 138813, XrefRangeEnd = 138814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGameInfo(string gameName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(gameName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.NativeMethodInfoPtr_SetGameInfo_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004723 RID: 18211 RVA: 0x0013CB58 File Offset: 0x0013AD58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138815, XrefRangeEnd = 138828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Sprite GetLeaderboardBadgeIcon(string badgeName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(badgeName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.NativeMethodInfoPtr_GetLeaderboardBadgeIcon_Public_Sprite_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}
		}

		// Token: 0x06004724 RID: 18212 RVA: 0x0013CBA8 File Offset: 0x0013ADA8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 138911, RefRangeEnd = 138914, XrefRangeStart = 138828, XrefRangeEnd = 138911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddLeaderboardUser(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.NativeMethodInfoPtr_AddLeaderboardUser_Public_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004725 RID: 18213 RVA: 0x0013CBEC File Offset: 0x0013ADEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138914, XrefRangeEnd = 138922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator LoadLeaderboardThumbnail(RectTransform _lbEntry, RectTransform _plEntry, Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_lbEntry);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_plEntry);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.NativeMethodInfoPtr_LoadLeaderboardThumbnail_Private_IEnumerator_RectTransform_RectTransform_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004726 RID: 18214 RVA: 0x0013CC60 File Offset: 0x0013AE60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 138944, RefRangeEnd = 138946, XrefRangeStart = 138922, XrefRangeEnd = 138944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveLeaderboardUser(string username)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(username);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.NativeMethodInfoPtr_RemoveLeaderboardUser_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004727 RID: 18215 RVA: 0x0013CCA4 File Offset: 0x0013AEA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 138985, RefRangeEnd = 138986, XrefRangeStart = 138946, XrefRangeEnd = 138985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUserCard(int userId, string username)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref userId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(username);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.NativeMethodInfoPtr_SetUserCard_Public_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004728 RID: 18216 RVA: 0x0013CCF4 File Offset: 0x0013AEF4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 138989, RefRangeEnd = 138993, XrefRangeStart = 138986, XrefRangeEnd = 138989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveChat(string username, string message, Color usernameColor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(username);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(usernameColor);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.NativeMethodInfoPtr_ReceiveChat_Public_Void_String_String_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004729 RID: 18217 RVA: 0x0013CD5C File Offset: 0x0013AF5C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 139026, RefRangeEnd = 139029, XrefRangeStart = 138993, XrefRangeEnd = 139026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DebugLog(string message, bool error)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref error;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.NativeMethodInfoPtr_DebugLog_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600472A RID: 18218 RVA: 0x0013CDAC File Offset: 0x0013AFAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139029, XrefRangeEnd = 139033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHealthFilled(float fill)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fill;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.NativeMethodInfoPtr_SetHealthFilled_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600472B RID: 18219 RVA: 0x0013CDEC File Offset: 0x0013AFEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139033, XrefRangeEnd = 139035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStaminaFilled(float fill, bool exhausted)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fill;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exhausted;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.NativeMethodInfoPtr_SetStaminaFilled_Public_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600472C RID: 18220 RVA: 0x0013CE38 File Offset: 0x0013B038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139035, XrefRangeEnd = 139043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ToggleConsole()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.NativeMethodInfoPtr_ToggleConsole_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600472D RID: 18221 RVA: 0x0013CE6C File Offset: 0x0013B06C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139043, XrefRangeEnd = 139045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenConsoleFromPauseMenu()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.NativeMethodInfoPtr_OpenConsoleFromPauseMenu_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600472E RID: 18222 RVA: 0x0013CEA0 File Offset: 0x0013B0A0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 139063, RefRangeEnd = 139068, XrefRangeStart = 139045, XrefRangeEnd = 139063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetConsoleOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref open;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.NativeMethodInfoPtr_SetConsoleOpen_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600472F RID: 18223 RVA: 0x0013CEE0 File Offset: 0x0013B0E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139068, XrefRangeEnd = 139073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator LoadThumbnail(int userId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref userId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.NativeMethodInfoPtr_LoadThumbnail_Private_IEnumerator_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06004730 RID: 18224 RVA: 0x0013CF2C File Offset: 0x0013B12C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139073, XrefRangeEnd = 139080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2D FlipTexture(Texture2D original)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(original);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.NativeMethodInfoPtr_FlipTexture_Private_Texture2D_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
			}
		}

		// Token: 0x06004731 RID: 18225 RVA: 0x0013CF7C File Offset: 0x0013B17C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 139089, RefRangeEnd = 139093, XrefRangeStart = 139080, XrefRangeEnd = 139089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowDisconnectMessage(string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(reason);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.NativeMethodInfoPtr_ShowDisconnectMessage_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004732 RID: 18226 RVA: 0x0013CFC0 File Offset: 0x0013B1C0
		[CallerCount(0)]
		public unsafe void Method_Private_Void_Single_PDM_0(float val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.NativeMethodInfoPtr_Method_Private_Void_Single_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004733 RID: 18227 RVA: 0x0013D000 File Offset: 0x0013B200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139093, XrefRangeEnd = 139100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _SetPaused_b__116_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.NativeMethodInfoPtr__SetPaused_b__116_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004734 RID: 18228 RVA: 0x0013D034 File Offset: 0x0013B234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139100, XrefRangeEnd = 139109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _SetPaused_b__116_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.NativeMethodInfoPtr__SetPaused_b__116_2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004735 RID: 18229 RVA: 0x0013D068 File Offset: 0x0013B268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139109, XrefRangeEnd = 139116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _SetConsoleOpen_b__133_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.NativeMethodInfoPtr__SetConsoleOpen_b__133_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004736 RID: 18230 RVA: 0x0013D09C File Offset: 0x0013B29C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139116, XrefRangeEnd = 139125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _SetConsoleOpen_b__133_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.NativeMethodInfoPtr__SetConsoleOpen_b__133_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004737 RID: 18231 RVA: 0x0001A45D File Offset: 0x0001865D
		public UIController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001845 RID: 6213
		// (get) Token: 0x06004738 RID: 18232 RVA: 0x0013D0D0 File Offset: 0x0013B2D0
		// (set) Token: 0x06004739 RID: 18233 RVA: 0x0001A466 File Offset: 0x00018666
		public unsafe static int maxDebugLogLength
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(UIController.NativeFieldInfoPtr_maxDebugLogLength, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIController.NativeFieldInfoPtr_maxDebugLogLength, (void*)(&value));
			}
		}

		// Token: 0x17001846 RID: 6214
		// (get) Token: 0x0600473A RID: 18234 RVA: 0x0013D0EC File Offset: 0x0013B2EC
		// (set) Token: 0x0600473B RID: 18235 RVA: 0x0001A474 File Offset: 0x00018674
		public unsafe static UIController singleton
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UIController.NativeFieldInfoPtr_singleton, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIController>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIController.NativeFieldInfoPtr_singleton, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001847 RID: 6215
		// (get) Token: 0x0600473C RID: 18236 RVA: 0x0013D114 File Offset: 0x0013B314
		// (set) Token: 0x0600473D RID: 18237 RVA: 0x0001A486 File Offset: 0x00018686
		public unsafe Action Resetted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr_Resetted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr_Resetted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001848 RID: 6216
		// (get) Token: 0x0600473E RID: 18238 RVA: 0x0013D144 File Offset: 0x0013B344
		// (set) Token: 0x0600473F RID: 18239 RVA: 0x0001A4A5 File Offset: 0x000186A5
		public unsafe Color selectedBtnColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr_selectedBtnColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr_selectedBtnColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001849 RID: 6217
		// (get) Token: 0x06004740 RID: 18240 RVA: 0x0013D174 File Offset: 0x0013B374
		// (set) Token: 0x06004741 RID: 18241 RVA: 0x0001A4C4 File Offset: 0x000186C4
		public unsafe Color unselectedBtnColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr_unselectedBtnColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr_unselectedBtnColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700184A RID: 6218
		// (get) Token: 0x06004742 RID: 18242 RVA: 0x0013D1A4 File Offset: 0x0013B3A4
		// (set) Token: 0x06004743 RID: 18243 RVA: 0x0001A4E3 File Offset: 0x000186E3
		public unsafe Color healthBarGreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr_healthBarGreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr_healthBarGreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700184B RID: 6219
		// (get) Token: 0x06004744 RID: 18244 RVA: 0x0013D1D4 File Offset: 0x0013B3D4
		// (set) Token: 0x06004745 RID: 18245 RVA: 0x0001A502 File Offset: 0x00018702
		public unsafe Color healthBarRed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr_healthBarRed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr_healthBarRed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700184C RID: 6220
		// (get) Token: 0x06004746 RID: 18246 RVA: 0x0013D204 File Offset: 0x0013B404
		// (set) Token: 0x06004747 RID: 18247 RVA: 0x0001A521 File Offset: 0x00018721
		public unsafe Il2CppReferenceArray<MenuTabPair> tabs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr_tabs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MenuTabPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr_tabs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700184D RID: 6221
		// (get) Token: 0x06004748 RID: 18248 RVA: 0x0013D234 File Offset: 0x0013B434
		// (set) Token: 0x06004749 RID: 18249 RVA: 0x0001A540 File Offset: 0x00018740
		public unsafe TMP_Text GameName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr_GameName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr_GameName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700184E RID: 6222
		// (get) Token: 0x0600474A RID: 18250 RVA: 0x0013D264 File Offset: 0x0013B464
		// (set) Token: 0x0600474B RID: 18251 RVA: 0x0001A55F File Offset: 0x0001875F
		public unsafe DateTime timeWhenStarted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr_timeWhenStarted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DateTime>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr_timeWhenStarted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700184F RID: 6223
		// (get) Token: 0x0600474C RID: 18252 RVA: 0x0013D294 File Offset: 0x0013B494
		// (set) Token: 0x0600474D RID: 18253 RVA: 0x0001A57E File Offset: 0x0001877E
		public unsafe RectTransform _Leaderboard_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr__Leaderboard_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr__Leaderboard_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001850 RID: 6224
		// (get) Token: 0x0600474E RID: 18254 RVA: 0x0013D2C4 File Offset: 0x0013B4C4
		// (set) Token: 0x0600474F RID: 18255 RVA: 0x0001A59D File Offset: 0x0001879D
		public unsafe RectTransform _LeaderboardContent_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr__LeaderboardContent_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr__LeaderboardContent_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001851 RID: 6225
		// (get) Token: 0x06004750 RID: 18256 RVA: 0x0013D2F4 File Offset: 0x0013B4F4
		// (set) Token: 0x06004751 RID: 18257 RVA: 0x0001A5BC File Offset: 0x000187BC
		public unsafe RectTransform _UserTag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr__UserTag_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr__UserTag_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001852 RID: 6226
		// (get) Token: 0x06004752 RID: 18258 RVA: 0x0013D324 File Offset: 0x0013B524
		// (set) Token: 0x06004753 RID: 18259 RVA: 0x0001A5DB File Offset: 0x000187DB
		public unsafe RectTransform _PauseMenu_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr__PauseMenu_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr__PauseMenu_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001853 RID: 6227
		// (get) Token: 0x06004754 RID: 18260 RVA: 0x0013D354 File Offset: 0x0013B554
		// (set) Token: 0x06004755 RID: 18261 RVA: 0x0001A5FA File Offset: 0x000187FA
		public unsafe RectTransform _ChatButton_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr__ChatButton_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr__ChatButton_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001854 RID: 6228
		// (get) Token: 0x06004756 RID: 18262 RVA: 0x0013D384 File Offset: 0x0013B584
		// (set) Token: 0x06004757 RID: 18263 RVA: 0x0001A619 File Offset: 0x00018819
		public unsafe RectTransform _InventoryButton_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr__InventoryButton_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr__InventoryButton_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001855 RID: 6229
		// (get) Token: 0x06004758 RID: 18264 RVA: 0x0013D3B4 File Offset: 0x0013B5B4
		// (set) Token: 0x06004759 RID: 18265 RVA: 0x0001A638 File Offset: 0x00018838
		public unsafe RectTransform _DebugConsole_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr__DebugConsole_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr__DebugConsole_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001856 RID: 6230
		// (get) Token: 0x0600475A RID: 18266 RVA: 0x0013D3E4 File Offset: 0x0013B5E4
		// (set) Token: 0x0600475B RID: 18267 RVA: 0x0001A657 File Offset: 0x00018857
		public unsafe Image _PauseMenuImg_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr__PauseMenuImg_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr__PauseMenuImg_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001857 RID: 6231
		// (get) Token: 0x0600475C RID: 18268 RVA: 0x0013D414 File Offset: 0x0013B614
		// (set) Token: 0x0600475D RID: 18269 RVA: 0x0001A676 File Offset: 0x00018876
		public unsafe RectTransform _PauseMenuChild_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr__PauseMenuChild_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr__PauseMenuChild_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001858 RID: 6232
		// (get) Token: 0x0600475E RID: 18270 RVA: 0x0013D444 File Offset: 0x0013B644
		// (set) Token: 0x0600475F RID: 18271 RVA: 0x0001A695 File Offset: 0x00018895
		public unsafe Canvas _Canvas_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr__Canvas_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr__Canvas_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001859 RID: 6233
		// (get) Token: 0x06004760 RID: 18272 RVA: 0x0013D474 File Offset: 0x0013B674
		// (set) Token: 0x06004761 RID: 18273 RVA: 0x0001A6B4 File Offset: 0x000188B4
		public unsafe TMP_InputField _ChatBar_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr__ChatBar_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr__ChatBar_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700185A RID: 6234
		// (get) Token: 0x06004762 RID: 18274 RVA: 0x0013D4A4 File Offset: 0x0013B6A4
		// (set) Token: 0x06004763 RID: 18275 RVA: 0x0001A6D3 File Offset: 0x000188D3
		public unsafe static bool _Paused_k__BackingField
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(UIController.NativeFieldInfoPtr__Paused_k__BackingField, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIController.NativeFieldInfoPtr__Paused_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x1700185B RID: 6235
		// (get) Token: 0x06004764 RID: 18276 RVA: 0x0013D4C0 File Offset: 0x0013B6C0
		// (set) Token: 0x06004765 RID: 18277 RVA: 0x0001A6E1 File Offset: 0x000188E1
		public unsafe static bool _ConsoleOpen_k__BackingField
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(UIController.NativeFieldInfoPtr__ConsoleOpen_k__BackingField, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIController.NativeFieldInfoPtr__ConsoleOpen_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x1700185C RID: 6236
		// (get) Token: 0x06004766 RID: 18278 RVA: 0x0013D4DC File Offset: 0x0013B6DC
		// (set) Token: 0x06004767 RID: 18279 RVA: 0x0001A6EF File Offset: 0x000188EF
		public unsafe Image _HealthbarCont_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr__HealthbarCont_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr__HealthbarCont_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700185D RID: 6237
		// (get) Token: 0x06004768 RID: 18280 RVA: 0x0013D50C File Offset: 0x0013B70C
		// (set) Token: 0x06004769 RID: 18281 RVA: 0x0001A70E File Offset: 0x0001890E
		public unsafe Image _Healthbar_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr__Healthbar_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr__Healthbar_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700185E RID: 6238
		// (get) Token: 0x0600476A RID: 18282 RVA: 0x0013D53C File Offset: 0x0013B73C
		// (set) Token: 0x0600476B RID: 18283 RVA: 0x0001A72D File Offset: 0x0001892D
		public unsafe Image _HealthbarHeart_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr__HealthbarHeart_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr__HealthbarHeart_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700185F RID: 6239
		// (get) Token: 0x0600476C RID: 18284 RVA: 0x0013D56C File Offset: 0x0013B76C
		// (set) Token: 0x0600476D RID: 18285 RVA: 0x0001A74C File Offset: 0x0001894C
		public unsafe TMP_Text _HealthbarHeartText_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr__HealthbarHeartText_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr__HealthbarHeartText_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001860 RID: 6240
		// (get) Token: 0x0600476E RID: 18286 RVA: 0x0013D59C File Offset: 0x0013B79C
		// (set) Token: 0x0600476F RID: 18287 RVA: 0x0001A76B File Offset: 0x0001896B
		public unsafe UIStaminaBar _StaminaBar_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr__StaminaBar_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIStaminaBar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr__StaminaBar_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001861 RID: 6241
		// (get) Token: 0x06004770 RID: 18288 RVA: 0x0013D5CC File Offset: 0x0013B7CC
		// (set) Token: 0x06004771 RID: 18289 RVA: 0x0001A78A File Offset: 0x0001898A
		public unsafe RectTransform leaderboardEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr_leaderboardEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr_leaderboardEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001862 RID: 6242
		// (get) Token: 0x06004772 RID: 18290 RVA: 0x0013D5FC File Offset: 0x0013B7FC
		// (set) Token: 0x06004773 RID: 18291 RVA: 0x0001A7A9 File Offset: 0x000189A9
		public unsafe RectTransform main
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr_main);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr_main), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001863 RID: 6243
		// (get) Token: 0x06004774 RID: 18292 RVA: 0x0013D62C File Offset: 0x0013B82C
		// (set) Token: 0x06004775 RID: 18293 RVA: 0x0001A7C8 File Offset: 0x000189C8
		public unsafe RectTransform alwaysOnTop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr_alwaysOnTop);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr_alwaysOnTop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001864 RID: 6244
		// (get) Token: 0x06004776 RID: 18294 RVA: 0x0013D65C File Offset: 0x0013B85C
		// (set) Token: 0x06004777 RID: 18295 RVA: 0x0001A7E7 File Offset: 0x000189E7
		public unsafe RectTransform logsParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr_logsParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr_logsParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001865 RID: 6245
		// (get) Token: 0x06004778 RID: 18296 RVA: 0x0013D68C File Offset: 0x0013B88C
		// (set) Token: 0x06004779 RID: 18297 RVA: 0x0001A806 File Offset: 0x00018A06
		public unsafe RectTransform playerListMenu
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr_playerListMenu);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr_playerListMenu), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001866 RID: 6246
		// (get) Token: 0x0600477A RID: 18298 RVA: 0x0013D6BC File Offset: 0x0013B8BC
		// (set) Token: 0x0600477B RID: 18299 RVA: 0x0001A825 File Offset: 0x00018A25
		public unsafe GameObject playerListMenuEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr_playerListMenuEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr_playerListMenuEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001867 RID: 6247
		// (get) Token: 0x0600477C RID: 18300 RVA: 0x0013D6EC File Offset: 0x0013B8EC
		// (set) Token: 0x0600477D RID: 18301 RVA: 0x0001A844 File Offset: 0x00018A44
		public unsafe GameObject debugLogMessageTemplate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr_debugLogMessageTemplate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr_debugLogMessageTemplate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001868 RID: 6248
		// (get) Token: 0x0600477E RID: 18302 RVA: 0x0013D71C File Offset: 0x0013B91C
		// (set) Token: 0x0600477F RID: 18303 RVA: 0x0001A863 File Offset: 0x00018A63
		public unsafe MenuButtonAnimation menuController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr_menuController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MenuButtonAnimation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr_menuController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001869 RID: 6249
		// (get) Token: 0x06004780 RID: 18304 RVA: 0x0013D74C File Offset: 0x0013B94C
		// (set) Token: 0x06004781 RID: 18305 RVA: 0x0001A882 File Offset: 0x00018A82
		public unsafe TMP_Text overviewUsername
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr_overviewUsername);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr_overviewUsername), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700186A RID: 6250
		// (get) Token: 0x06004782 RID: 18306 RVA: 0x0013D77C File Offset: 0x0013B97C
		// (set) Token: 0x06004783 RID: 18307 RVA: 0x0001A8A1 File Offset: 0x00018AA1
		public unsafe TMP_Text timePlaying
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr_timePlaying);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr_timePlaying), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700186B RID: 6251
		// (get) Token: 0x06004784 RID: 18308 RVA: 0x0013D7AC File Offset: 0x0013B9AC
		// (set) Token: 0x06004785 RID: 18309 RVA: 0x0001A8C0 File Offset: 0x00018AC0
		public unsafe TMP_Text playerCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr_playerCount);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr_playerCount), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700186C RID: 6252
		// (get) Token: 0x06004786 RID: 18310 RVA: 0x0013D7DC File Offset: 0x0013B9DC
		// (set) Token: 0x06004787 RID: 18311 RVA: 0x0001A8DF File Offset: 0x00018ADF
		public unsafe TMP_Text instanceCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr_instanceCount);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr_instanceCount), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700186D RID: 6253
		// (get) Token: 0x06004788 RID: 18312 RVA: 0x0013D80C File Offset: 0x0013BA0C
		// (set) Token: 0x06004789 RID: 18313 RVA: 0x0001A8FE File Offset: 0x00018AFE
		public unsafe TMP_Text debugLogs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr_debugLogs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr_debugLogs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700186E RID: 6254
		// (get) Token: 0x0600478A RID: 18314 RVA: 0x0013D83C File Offset: 0x0013BA3C
		// (set) Token: 0x0600478B RID: 18315 RVA: 0x0001A91D File Offset: 0x00018B1D
		public unsafe TMP_Text localText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr_localText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr_localText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700186F RID: 6255
		// (get) Token: 0x0600478C RID: 18316 RVA: 0x0013D86C File Offset: 0x0013BA6C
		// (set) Token: 0x0600478D RID: 18317 RVA: 0x0001A93C File Offset: 0x00018B3C
		public unsafe RectTransform pauseMenu
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr_pauseMenu);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr_pauseMenu), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001870 RID: 6256
		// (get) Token: 0x0600478E RID: 18318 RVA: 0x0013D89C File Offset: 0x0013BA9C
		// (set) Token: 0x0600478F RID: 18319 RVA: 0x0001A95B File Offset: 0x00018B5B
		public unsafe RectTransform disconnectScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr_disconnectScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr_disconnectScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001871 RID: 6257
		// (get) Token: 0x06004790 RID: 18320 RVA: 0x0013D8CC File Offset: 0x0013BACC
		// (set) Token: 0x06004791 RID: 18321 RVA: 0x0001A97A File Offset: 0x00018B7A
		public unsafe CursorLockMode lockState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr_lockState);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CursorLockMode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr_lockState), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001872 RID: 6258
		// (get) Token: 0x06004792 RID: 18322 RVA: 0x0013D8FC File Offset: 0x0013BAFC
		// (set) Token: 0x06004793 RID: 18323 RVA: 0x0001A999 File Offset: 0x00018B99
		public unsafe string localUsername
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr_localUsername);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr_localUsername), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001873 RID: 6259
		// (get) Token: 0x06004794 RID: 18324 RVA: 0x0013D924 File Offset: 0x0013BB24
		// (set) Token: 0x06004795 RID: 18325 RVA: 0x0001A9B8 File Offset: 0x00018BB8
		public unsafe bool lbOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr_lbOpen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr_lbOpen)) = value;
			}
		}

		// Token: 0x17001874 RID: 6260
		// (get) Token: 0x06004796 RID: 18326 RVA: 0x0013D94C File Offset: 0x0013BB4C
		// (set) Token: 0x06004797 RID: 18327 RVA: 0x0001A9D3 File Offset: 0x00018BD3
		public unsafe bool PauseDebounce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr_PauseDebounce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr_PauseDebounce)) = value;
			}
		}

		// Token: 0x17001875 RID: 6261
		// (get) Token: 0x06004798 RID: 18328 RVA: 0x0013D974 File Offset: 0x0013BB74
		// (set) Token: 0x06004799 RID: 18329 RVA: 0x0001A9EE File Offset: 0x00018BEE
		public unsafe Dictionary<string, Sprite> badgeIcons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr_badgeIcons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Sprite>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr_badgeIcons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001876 RID: 6262
		// (get) Token: 0x0600479A RID: 18330 RVA: 0x0013D9A4 File Offset: 0x0013BBA4
		// (set) Token: 0x0600479B RID: 18331 RVA: 0x0001AA0D File Offset: 0x00018C0D
		public unsafe Dictionary<string, GameObject> LeaderboardUsers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr_LeaderboardUsers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr_LeaderboardUsers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001877 RID: 6263
		// (get) Token: 0x0600479C RID: 18332 RVA: 0x0013D9D4 File Offset: 0x0013BBD4
		// (set) Token: 0x0600479D RID: 18333 RVA: 0x0001AA2C File Offset: 0x00018C2C
		public unsafe Dictionary<string, GameObject> PlayerListUsers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr_PlayerListUsers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr_PlayerListUsers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001878 RID: 6264
		// (get) Token: 0x0600479E RID: 18334 RVA: 0x0013DA04 File Offset: 0x0013BC04
		// (set) Token: 0x0600479F RID: 18335 RVA: 0x0001AA4B File Offset: 0x00018C4B
		public unsafe bool ConsoleDebounce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr_ConsoleDebounce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.NativeFieldInfoPtr_ConsoleDebounce)) = value;
			}
		}

		// Token: 0x040036F7 RID: 14071
		private static readonly IntPtr NativeFieldInfoPtr_maxDebugLogLength;

		// Token: 0x040036F8 RID: 14072
		private static readonly IntPtr NativeFieldInfoPtr_singleton;

		// Token: 0x040036F9 RID: 14073
		private static readonly IntPtr NativeFieldInfoPtr_Resetted;

		// Token: 0x040036FA RID: 14074
		private static readonly IntPtr NativeFieldInfoPtr_selectedBtnColor;

		// Token: 0x040036FB RID: 14075
		private static readonly IntPtr NativeFieldInfoPtr_unselectedBtnColor;

		// Token: 0x040036FC RID: 14076
		private static readonly IntPtr NativeFieldInfoPtr_healthBarGreen;

		// Token: 0x040036FD RID: 14077
		private static readonly IntPtr NativeFieldInfoPtr_healthBarRed;

		// Token: 0x040036FE RID: 14078
		private static readonly IntPtr NativeFieldInfoPtr_tabs;

		// Token: 0x040036FF RID: 14079
		private static readonly IntPtr NativeFieldInfoPtr_GameName;

		// Token: 0x04003700 RID: 14080
		private static readonly IntPtr NativeFieldInfoPtr_timeWhenStarted;

		// Token: 0x04003701 RID: 14081
		private static readonly IntPtr NativeFieldInfoPtr__Leaderboard_k__BackingField;

		// Token: 0x04003702 RID: 14082
		private static readonly IntPtr NativeFieldInfoPtr__LeaderboardContent_k__BackingField;

		// Token: 0x04003703 RID: 14083
		private static readonly IntPtr NativeFieldInfoPtr__UserTag_k__BackingField;

		// Token: 0x04003704 RID: 14084
		private static readonly IntPtr NativeFieldInfoPtr__PauseMenu_k__BackingField;

		// Token: 0x04003705 RID: 14085
		private static readonly IntPtr NativeFieldInfoPtr__ChatButton_k__BackingField;

		// Token: 0x04003706 RID: 14086
		private static readonly IntPtr NativeFieldInfoPtr__InventoryButton_k__BackingField;

		// Token: 0x04003707 RID: 14087
		private static readonly IntPtr NativeFieldInfoPtr__DebugConsole_k__BackingField;

		// Token: 0x04003708 RID: 14088
		private static readonly IntPtr NativeFieldInfoPtr__PauseMenuImg_k__BackingField;

		// Token: 0x04003709 RID: 14089
		private static readonly IntPtr NativeFieldInfoPtr__PauseMenuChild_k__BackingField;

		// Token: 0x0400370A RID: 14090
		private static readonly IntPtr NativeFieldInfoPtr__Canvas_k__BackingField;

		// Token: 0x0400370B RID: 14091
		private static readonly IntPtr NativeFieldInfoPtr__ChatBar_k__BackingField;

		// Token: 0x0400370C RID: 14092
		private static readonly IntPtr NativeFieldInfoPtr__Paused_k__BackingField;

		// Token: 0x0400370D RID: 14093
		private static readonly IntPtr NativeFieldInfoPtr__ConsoleOpen_k__BackingField;

		// Token: 0x0400370E RID: 14094
		private static readonly IntPtr NativeFieldInfoPtr__HealthbarCont_k__BackingField;

		// Token: 0x0400370F RID: 14095
		private static readonly IntPtr NativeFieldInfoPtr__Healthbar_k__BackingField;

		// Token: 0x04003710 RID: 14096
		private static readonly IntPtr NativeFieldInfoPtr__HealthbarHeart_k__BackingField;

		// Token: 0x04003711 RID: 14097
		private static readonly IntPtr NativeFieldInfoPtr__HealthbarHeartText_k__BackingField;

		// Token: 0x04003712 RID: 14098
		private static readonly IntPtr NativeFieldInfoPtr__StaminaBar_k__BackingField;

		// Token: 0x04003713 RID: 14099
		private static readonly IntPtr NativeFieldInfoPtr_leaderboardEntry;

		// Token: 0x04003714 RID: 14100
		private static readonly IntPtr NativeFieldInfoPtr_main;

		// Token: 0x04003715 RID: 14101
		private static readonly IntPtr NativeFieldInfoPtr_alwaysOnTop;

		// Token: 0x04003716 RID: 14102
		private static readonly IntPtr NativeFieldInfoPtr_logsParent;

		// Token: 0x04003717 RID: 14103
		private static readonly IntPtr NativeFieldInfoPtr_playerListMenu;

		// Token: 0x04003718 RID: 14104
		private static readonly IntPtr NativeFieldInfoPtr_playerListMenuEntry;

		// Token: 0x04003719 RID: 14105
		private static readonly IntPtr NativeFieldInfoPtr_debugLogMessageTemplate;

		// Token: 0x0400371A RID: 14106
		private static readonly IntPtr NativeFieldInfoPtr_menuController;

		// Token: 0x0400371B RID: 14107
		private static readonly IntPtr NativeFieldInfoPtr_overviewUsername;

		// Token: 0x0400371C RID: 14108
		private static readonly IntPtr NativeFieldInfoPtr_timePlaying;

		// Token: 0x0400371D RID: 14109
		private static readonly IntPtr NativeFieldInfoPtr_playerCount;

		// Token: 0x0400371E RID: 14110
		private static readonly IntPtr NativeFieldInfoPtr_instanceCount;

		// Token: 0x0400371F RID: 14111
		private static readonly IntPtr NativeFieldInfoPtr_debugLogs;

		// Token: 0x04003720 RID: 14112
		private static readonly IntPtr NativeFieldInfoPtr_localText;

		// Token: 0x04003721 RID: 14113
		private static readonly IntPtr NativeFieldInfoPtr_pauseMenu;

		// Token: 0x04003722 RID: 14114
		private static readonly IntPtr NativeFieldInfoPtr_disconnectScreen;

		// Token: 0x04003723 RID: 14115
		private static readonly IntPtr NativeFieldInfoPtr_lockState;

		// Token: 0x04003724 RID: 14116
		private static readonly IntPtr NativeFieldInfoPtr_localUsername;

		// Token: 0x04003725 RID: 14117
		private static readonly IntPtr NativeFieldInfoPtr_lbOpen;

		// Token: 0x04003726 RID: 14118
		private static readonly IntPtr NativeFieldInfoPtr_PauseDebounce;

		// Token: 0x04003727 RID: 14119
		private static readonly IntPtr NativeFieldInfoPtr_badgeIcons;

		// Token: 0x04003728 RID: 14120
		private static readonly IntPtr NativeFieldInfoPtr_LeaderboardUsers;

		// Token: 0x04003729 RID: 14121
		private static readonly IntPtr NativeFieldInfoPtr_PlayerListUsers;

		// Token: 0x0400372A RID: 14122
		private static readonly IntPtr NativeFieldInfoPtr_ConsoleDebounce;

		// Token: 0x0400372B RID: 14123
		private static readonly IntPtr NativeMethodInfoPtr_get_Leaderboard_Public_get_RectTransform_0;

		// Token: 0x0400372C RID: 14124
		private static readonly IntPtr NativeMethodInfoPtr_set_Leaderboard_Private_set_Void_RectTransform_0;

		// Token: 0x0400372D RID: 14125
		private static readonly IntPtr NativeMethodInfoPtr_get_LeaderboardContent_Public_get_RectTransform_0;

		// Token: 0x0400372E RID: 14126
		private static readonly IntPtr NativeMethodInfoPtr_set_LeaderboardContent_Private_set_Void_RectTransform_0;

		// Token: 0x0400372F RID: 14127
		private static readonly IntPtr NativeMethodInfoPtr_get_UserTag_Public_get_RectTransform_0;

		// Token: 0x04003730 RID: 14128
		private static readonly IntPtr NativeMethodInfoPtr_set_UserTag_Private_set_Void_RectTransform_0;

		// Token: 0x04003731 RID: 14129
		private static readonly IntPtr NativeMethodInfoPtr_get_PauseMenu_Public_get_RectTransform_0;

		// Token: 0x04003732 RID: 14130
		private static readonly IntPtr NativeMethodInfoPtr_set_PauseMenu_Private_set_Void_RectTransform_0;

		// Token: 0x04003733 RID: 14131
		private static readonly IntPtr NativeMethodInfoPtr_get_ChatButton_Public_get_RectTransform_0;

		// Token: 0x04003734 RID: 14132
		private static readonly IntPtr NativeMethodInfoPtr_set_ChatButton_Private_set_Void_RectTransform_0;

		// Token: 0x04003735 RID: 14133
		private static readonly IntPtr NativeMethodInfoPtr_get_InventoryButton_Public_get_RectTransform_0;

		// Token: 0x04003736 RID: 14134
		private static readonly IntPtr NativeMethodInfoPtr_set_InventoryButton_Private_set_Void_RectTransform_0;

		// Token: 0x04003737 RID: 14135
		private static readonly IntPtr NativeMethodInfoPtr_get_DebugConsole_Public_get_RectTransform_0;

		// Token: 0x04003738 RID: 14136
		private static readonly IntPtr NativeMethodInfoPtr_set_DebugConsole_Private_set_Void_RectTransform_0;

		// Token: 0x04003739 RID: 14137
		private static readonly IntPtr NativeMethodInfoPtr_get_PauseMenuImg_Public_get_Image_0;

		// Token: 0x0400373A RID: 14138
		private static readonly IntPtr NativeMethodInfoPtr_set_PauseMenuImg_Private_set_Void_Image_0;

		// Token: 0x0400373B RID: 14139
		private static readonly IntPtr NativeMethodInfoPtr_get_PauseMenuChild_Public_get_RectTransform_0;

		// Token: 0x0400373C RID: 14140
		private static readonly IntPtr NativeMethodInfoPtr_set_PauseMenuChild_Private_set_Void_RectTransform_0;

		// Token: 0x0400373D RID: 14141
		private static readonly IntPtr NativeMethodInfoPtr_get_Canvas_Public_get_Canvas_0;

		// Token: 0x0400373E RID: 14142
		private static readonly IntPtr NativeMethodInfoPtr_set_Canvas_Private_set_Void_Canvas_0;

		// Token: 0x0400373F RID: 14143
		private static readonly IntPtr NativeMethodInfoPtr_get_ChatBar_Public_get_TMP_InputField_0;

		// Token: 0x04003740 RID: 14144
		private static readonly IntPtr NativeMethodInfoPtr_set_ChatBar_Private_set_Void_TMP_InputField_0;

		// Token: 0x04003741 RID: 14145
		private static readonly IntPtr NativeMethodInfoPtr_get_Paused_Public_Static_get_Boolean_0;

		// Token: 0x04003742 RID: 14146
		private static readonly IntPtr NativeMethodInfoPtr_set_Paused_Private_Static_set_Void_Boolean_0;

		// Token: 0x04003743 RID: 14147
		private static readonly IntPtr NativeMethodInfoPtr_get_ConsoleOpen_Public_Static_get_Boolean_0;

		// Token: 0x04003744 RID: 14148
		private static readonly IntPtr NativeMethodInfoPtr_set_ConsoleOpen_Private_Static_set_Void_Boolean_0;

		// Token: 0x04003745 RID: 14149
		private static readonly IntPtr NativeMethodInfoPtr_get_HealthbarCont_Public_get_Image_0;

		// Token: 0x04003746 RID: 14150
		private static readonly IntPtr NativeMethodInfoPtr_set_HealthbarCont_Private_set_Void_Image_0;

		// Token: 0x04003747 RID: 14151
		private static readonly IntPtr NativeMethodInfoPtr_get_Healthbar_Public_get_Image_0;

		// Token: 0x04003748 RID: 14152
		private static readonly IntPtr NativeMethodInfoPtr_set_Healthbar_Private_set_Void_Image_0;

		// Token: 0x04003749 RID: 14153
		private static readonly IntPtr NativeMethodInfoPtr_get_HealthbarHeart_Public_get_Image_0;

		// Token: 0x0400374A RID: 14154
		private static readonly IntPtr NativeMethodInfoPtr_set_HealthbarHeart_Private_set_Void_Image_0;

		// Token: 0x0400374B RID: 14155
		private static readonly IntPtr NativeMethodInfoPtr_get_HealthbarHeartText_Public_get_TMP_Text_0;

		// Token: 0x0400374C RID: 14156
		private static readonly IntPtr NativeMethodInfoPtr_set_HealthbarHeartText_Private_set_Void_TMP_Text_0;

		// Token: 0x0400374D RID: 14157
		private static readonly IntPtr NativeMethodInfoPtr_get_StaminaBar_Public_get_UIStaminaBar_0;

		// Token: 0x0400374E RID: 14158
		private static readonly IntPtr NativeMethodInfoPtr_set_StaminaBar_Private_set_Void_UIStaminaBar_0;

		// Token: 0x0400374F RID: 14159
		private static readonly IntPtr NativeMethodInfoPtr_add_Resetted_Public_add_Void_Action_0;

		// Token: 0x04003750 RID: 14160
		private static readonly IntPtr NativeMethodInfoPtr_remove_Resetted_Public_rem_Void_Action_0;

		// Token: 0x04003751 RID: 14161
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003752 RID: 14162
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04003753 RID: 14163
		private static readonly IntPtr NativeMethodInfoPtr_SetActiveMenuTab_Public_Void_Int32_0;

		// Token: 0x04003754 RID: 14164
		private static readonly IntPtr NativeMethodInfoPtr_SetButtonFocused_Public_Void_HudButton_Boolean_0;

		// Token: 0x04003755 RID: 14165
		private static readonly IntPtr NativeMethodInfoPtr_ToggleLeaderboard_Private_Void_0;

		// Token: 0x04003756 RID: 14166
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04003757 RID: 14167
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInstanceCount_Private_Void_0;

		// Token: 0x04003758 RID: 14168
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTimer_Private_Void_0;

		// Token: 0x04003759 RID: 14169
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePlayerCount_Private_Void_0;

		// Token: 0x0400375A RID: 14170
		private static readonly IntPtr NativeMethodInfoPtr_ResetCharacter_Public_Void_0;

		// Token: 0x0400375B RID: 14171
		private static readonly IntPtr NativeMethodInfoPtr_ExitGame_Public_Void_0;

		// Token: 0x0400375C RID: 14172
		private static readonly IntPtr NativeMethodInfoPtr_TogglePaused_Public_Void_0;

		// Token: 0x0400375D RID: 14173
		private static readonly IntPtr NativeMethodInfoPtr_SetPaused_Public_Void_Boolean_0;

		// Token: 0x0400375E RID: 14174
		private static readonly IntPtr NativeMethodInfoPtr_SetGameInfo_Public_Void_String_0;

		// Token: 0x0400375F RID: 14175
		private static readonly IntPtr NativeMethodInfoPtr_GetLeaderboardBadgeIcon_Public_Sprite_String_0;

		// Token: 0x04003760 RID: 14176
		private static readonly IntPtr NativeMethodInfoPtr_AddLeaderboardUser_Public_Void_Player_0;

		// Token: 0x04003761 RID: 14177
		private static readonly IntPtr NativeMethodInfoPtr_LoadLeaderboardThumbnail_Private_IEnumerator_RectTransform_RectTransform_Player_0;

		// Token: 0x04003762 RID: 14178
		private static readonly IntPtr NativeMethodInfoPtr_RemoveLeaderboardUser_Public_Void_String_0;

		// Token: 0x04003763 RID: 14179
		private static readonly IntPtr NativeMethodInfoPtr_SetUserCard_Public_Void_Int32_String_0;

		// Token: 0x04003764 RID: 14180
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveChat_Public_Void_String_String_Color_0;

		// Token: 0x04003765 RID: 14181
		private static readonly IntPtr NativeMethodInfoPtr_DebugLog_Public_Void_String_Boolean_0;

		// Token: 0x04003766 RID: 14182
		private static readonly IntPtr NativeMethodInfoPtr_SetHealthFilled_Public_Void_Single_0;

		// Token: 0x04003767 RID: 14183
		private static readonly IntPtr NativeMethodInfoPtr_SetStaminaFilled_Public_Void_Single_Boolean_0;

		// Token: 0x04003768 RID: 14184
		private static readonly IntPtr NativeMethodInfoPtr_ToggleConsole_Public_Void_0;

		// Token: 0x04003769 RID: 14185
		private static readonly IntPtr NativeMethodInfoPtr_OpenConsoleFromPauseMenu_Public_Void_0;

		// Token: 0x0400376A RID: 14186
		private static readonly IntPtr NativeMethodInfoPtr_SetConsoleOpen_Public_Void_Boolean_0;

		// Token: 0x0400376B RID: 14187
		private static readonly IntPtr NativeMethodInfoPtr_LoadThumbnail_Private_IEnumerator_Int32_0;

		// Token: 0x0400376C RID: 14188
		private static readonly IntPtr NativeMethodInfoPtr_FlipTexture_Private_Texture2D_Texture2D_0;

		// Token: 0x0400376D RID: 14189
		private static readonly IntPtr NativeMethodInfoPtr_ShowDisconnectMessage_Public_Void_String_0;

		// Token: 0x0400376E RID: 14190
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_Single_PDM_0;

		// Token: 0x0400376F RID: 14191
		private static readonly IntPtr NativeMethodInfoPtr__SetPaused_b__116_1_Private_Void_0;

		// Token: 0x04003770 RID: 14192
		private static readonly IntPtr NativeMethodInfoPtr__SetPaused_b__116_2_Private_Void_0;

		// Token: 0x04003771 RID: 14193
		private static readonly IntPtr NativeMethodInfoPtr__SetConsoleOpen_b__133_0_Private_Void_0;

		// Token: 0x04003772 RID: 14194
		private static readonly IntPtr NativeMethodInfoPtr__SetConsoleOpen_b__133_1_Private_Void_0;

		// Token: 0x0200043D RID: 1085
		public enum HudButton
		{
			// Token: 0x04003F68 RID: 16232
			Chat,
			// Token: 0x04003F69 RID: 16233
			Inventory
		}

		// Token: 0x0200043E RID: 1086
		[ObfuscatedName("Polytoria.Controllers.UIController+<>c__DisplayClass120_0")]
		public sealed class __c__DisplayClass120_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060052E4 RID: 21220 RVA: 0x001604BC File Offset: 0x0015E6BC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass120_0()
			{
				Il2CppClassPointerStore<UIController.__c__DisplayClass120_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIController>.NativeClassPtr, "<>c__DisplayClass120_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIController.__c__DisplayClass120_0>.NativeClassPtr);
				UIController.__c__DisplayClass120_0.NativeFieldInfoPtr_userId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIController.__c__DisplayClass120_0>.NativeClassPtr, "userId");
				UIController.__c__DisplayClass120_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController.__c__DisplayClass120_0>.NativeClassPtr, 100674612);
				UIController.__c__DisplayClass120_0.NativeMethodInfoPtr__AddLeaderboardUser_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController.__c__DisplayClass120_0>.NativeClassPtr, 100674613);
				UIController.__c__DisplayClass120_0.NativeMethodInfoPtr__AddLeaderboardUser_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController.__c__DisplayClass120_0>.NativeClassPtr, 100674614);
				UIController.__c__DisplayClass120_0.NativeMethodInfoPtr__AddLeaderboardUser_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController.__c__DisplayClass120_0>.NativeClassPtr, 100674615);
			}

			// Token: 0x060052E5 RID: 21221 RVA: 0x0016054C File Offset: 0x0015E74C
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass120_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIController.__c__DisplayClass120_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.__c__DisplayClass120_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060052E6 RID: 21222 RVA: 0x00160588 File Offset: 0x0015E788
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137788, XrefRangeEnd = 137796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _AddLeaderboardUser_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.__c__DisplayClass120_0.NativeMethodInfoPtr__AddLeaderboardUser_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060052E7 RID: 21223 RVA: 0x001605BC File Offset: 0x0015E7BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137796, XrefRangeEnd = 137804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _AddLeaderboardUser_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.__c__DisplayClass120_0.NativeMethodInfoPtr__AddLeaderboardUser_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060052E8 RID: 21224 RVA: 0x001605F0 File Offset: 0x0015E7F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137804, XrefRangeEnd = 137812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _AddLeaderboardUser_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.__c__DisplayClass120_0.NativeMethodInfoPtr__AddLeaderboardUser_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060052E9 RID: 21225 RVA: 0x000201D1 File Offset: 0x0001E3D1
			public __c__DisplayClass120_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001BF9 RID: 7161
			// (get) Token: 0x060052EA RID: 21226 RVA: 0x00160624 File Offset: 0x0015E824
			// (set) Token: 0x060052EB RID: 21227 RVA: 0x000201DA File Offset: 0x0001E3DA
			public unsafe int userId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.__c__DisplayClass120_0.NativeFieldInfoPtr_userId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.__c__DisplayClass120_0.NativeFieldInfoPtr_userId)) = value;
				}
			}

			// Token: 0x04003F6A RID: 16234
			private static readonly IntPtr NativeFieldInfoPtr_userId;

			// Token: 0x04003F6B RID: 16235
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003F6C RID: 16236
			private static readonly IntPtr NativeMethodInfoPtr__AddLeaderboardUser_b__0_Internal_Void_0;

			// Token: 0x04003F6D RID: 16237
			private static readonly IntPtr NativeMethodInfoPtr__AddLeaderboardUser_b__1_Internal_Void_0;

			// Token: 0x04003F6E RID: 16238
			private static readonly IntPtr NativeMethodInfoPtr__AddLeaderboardUser_b__2_Internal_Void_0;
		}

		// Token: 0x0200043F RID: 1087
		[ObfuscatedName("Polytoria.Controllers.UIController+<>c__DisplayClass121_0")]
		public sealed class __c__DisplayClass121_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060052EC RID: 21228 RVA: 0x0016064C File Offset: 0x0015E84C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass121_0()
			{
				Il2CppClassPointerStore<UIController.__c__DisplayClass121_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIController>.NativeClassPtr, "<>c__DisplayClass121_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIController.__c__DisplayClass121_0>.NativeClassPtr);
				UIController.__c__DisplayClass121_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIController.__c__DisplayClass121_0>.NativeClassPtr, "player");
				UIController.__c__DisplayClass121_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController.__c__DisplayClass121_0>.NativeClassPtr, 100674616);
				UIController.__c__DisplayClass121_0.NativeMethodInfoPtr__LoadLeaderboardThumbnail_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController.__c__DisplayClass121_0>.NativeClassPtr, 100674617);
				UIController.__c__DisplayClass121_0.NativeMethodInfoPtr__LoadLeaderboardThumbnail_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController.__c__DisplayClass121_0>.NativeClassPtr, 100674618);
				UIController.__c__DisplayClass121_0.NativeMethodInfoPtr__LoadLeaderboardThumbnail_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController.__c__DisplayClass121_0>.NativeClassPtr, 100674619);
				UIController.__c__DisplayClass121_0.NativeMethodInfoPtr__LoadLeaderboardThumbnail_b__3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController.__c__DisplayClass121_0>.NativeClassPtr, 100674620);
			}

			// Token: 0x060052ED RID: 21229 RVA: 0x001606F0 File Offset: 0x0015E8F0
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass121_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIController.__c__DisplayClass121_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.__c__DisplayClass121_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060052EE RID: 21230 RVA: 0x0016072C File Offset: 0x0015E92C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137812, XrefRangeEnd = 137820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _LoadLeaderboardThumbnail_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.__c__DisplayClass121_0.NativeMethodInfoPtr__LoadLeaderboardThumbnail_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060052EF RID: 21231 RVA: 0x00160760 File Offset: 0x0015E960
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137820, XrefRangeEnd = 137828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _LoadLeaderboardThumbnail_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.__c__DisplayClass121_0.NativeMethodInfoPtr__LoadLeaderboardThumbnail_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060052F0 RID: 21232 RVA: 0x00160794 File Offset: 0x0015E994
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137828, XrefRangeEnd = 137836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _LoadLeaderboardThumbnail_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.__c__DisplayClass121_0.NativeMethodInfoPtr__LoadLeaderboardThumbnail_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060052F1 RID: 21233 RVA: 0x001607C8 File Offset: 0x0015E9C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137836, XrefRangeEnd = 137844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _LoadLeaderboardThumbnail_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController.__c__DisplayClass121_0.NativeMethodInfoPtr__LoadLeaderboardThumbnail_b__3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060052F2 RID: 21234 RVA: 0x000201F5 File Offset: 0x0001E3F5
			public __c__DisplayClass121_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001BFA RID: 7162
			// (get) Token: 0x060052F3 RID: 21235 RVA: 0x001607FC File Offset: 0x0015E9FC
			// (set) Token: 0x060052F4 RID: 21236 RVA: 0x000201FE File Offset: 0x0001E3FE
			public unsafe Player player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.__c__DisplayClass121_0.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController.__c__DisplayClass121_0.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003F6F RID: 16239
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04003F70 RID: 16240
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003F71 RID: 16241
			private static readonly IntPtr NativeMethodInfoPtr__LoadLeaderboardThumbnail_b__0_Internal_Void_0;

			// Token: 0x04003F72 RID: 16242
			private static readonly IntPtr NativeMethodInfoPtr__LoadLeaderboardThumbnail_b__1_Internal_Void_0;

			// Token: 0x04003F73 RID: 16243
			private static readonly IntPtr NativeMethodInfoPtr__LoadLeaderboardThumbnail_b__2_Internal_Void_0;

			// Token: 0x04003F74 RID: 16244
			private static readonly IntPtr NativeMethodInfoPtr__LoadLeaderboardThumbnail_b__3_Internal_Void_0;
		}

		// Token: 0x02000440 RID: 1088
		[ObfuscatedName("Polytoria.Controllers.UIController+<LoadLeaderboardThumbnail>d__121")]
		public sealed class _LoadLeaderboardThumbnail_d__121 : global::Il2CppSystem.Object
		{
			// Token: 0x060052F5 RID: 21237 RVA: 0x0016082C File Offset: 0x0015EA2C
			// Note: this type is marked as 'beforefieldinit'.
			static _LoadLeaderboardThumbnail_d__121()
			{
				Il2CppClassPointerStore<UIController._LoadLeaderboardThumbnail_d__121>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIController>.NativeClassPtr, "<LoadLeaderboardThumbnail>d__121");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIController._LoadLeaderboardThumbnail_d__121>.NativeClassPtr);
				UIController._LoadLeaderboardThumbnail_d__121.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIController._LoadLeaderboardThumbnail_d__121>.NativeClassPtr, "<>1__state");
				UIController._LoadLeaderboardThumbnail_d__121.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIController._LoadLeaderboardThumbnail_d__121>.NativeClassPtr, "<>2__current");
				UIController._LoadLeaderboardThumbnail_d__121.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIController._LoadLeaderboardThumbnail_d__121>.NativeClassPtr, "player");
				UIController._LoadLeaderboardThumbnail_d__121.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIController._LoadLeaderboardThumbnail_d__121>.NativeClassPtr, "<>8__1");
				UIController._LoadLeaderboardThumbnail_d__121.NativeFieldInfoPtr__plEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIController._LoadLeaderboardThumbnail_d__121>.NativeClassPtr, "_plEntry");
				UIController._LoadLeaderboardThumbnail_d__121.NativeFieldInfoPtr__lbEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIController._LoadLeaderboardThumbnail_d__121>.NativeClassPtr, "_lbEntry");
				UIController._LoadLeaderboardThumbnail_d__121.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIController._LoadLeaderboardThumbnail_d__121>.NativeClassPtr, "<>4__this");
				UIController._LoadLeaderboardThumbnail_d__121.NativeFieldInfoPtr__uwr_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIController._LoadLeaderboardThumbnail_d__121>.NativeClassPtr, "<uwr>5__2");
				UIController._LoadLeaderboardThumbnail_d__121.NativeFieldInfoPtr__token_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIController._LoadLeaderboardThumbnail_d__121>.NativeClassPtr, "<token>5__3");
				UIController._LoadLeaderboardThumbnail_d__121.NativeFieldInfoPtr__reportBtn_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIController._LoadLeaderboardThumbnail_d__121>.NativeClassPtr, "<reportBtn>5__4");
				UIController._LoadLeaderboardThumbnail_d__121.NativeFieldInfoPtr__twr_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIController._LoadLeaderboardThumbnail_d__121>.NativeClassPtr, "<twr>5__5");
				UIController._LoadLeaderboardThumbnail_d__121.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController._LoadLeaderboardThumbnail_d__121>.NativeClassPtr, 100674626);
				UIController._LoadLeaderboardThumbnail_d__121.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController._LoadLeaderboardThumbnail_d__121>.NativeClassPtr, 100674628);
				UIController._LoadLeaderboardThumbnail_d__121.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController._LoadLeaderboardThumbnail_d__121>.NativeClassPtr, 100674621);
				UIController._LoadLeaderboardThumbnail_d__121.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController._LoadLeaderboardThumbnail_d__121>.NativeClassPtr, 100674622);
				UIController._LoadLeaderboardThumbnail_d__121.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController._LoadLeaderboardThumbnail_d__121>.NativeClassPtr, 100674623);
				UIController._LoadLeaderboardThumbnail_d__121.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController._LoadLeaderboardThumbnail_d__121>.NativeClassPtr, 100674624);
				UIController._LoadLeaderboardThumbnail_d__121.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController._LoadLeaderboardThumbnail_d__121>.NativeClassPtr, 100674625);
				UIController._LoadLeaderboardThumbnail_d__121.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController._LoadLeaderboardThumbnail_d__121>.NativeClassPtr, 100674627);
			}

			// Token: 0x17001C06 RID: 7174
			// (get) Token: 0x060052F6 RID: 21238 RVA: 0x001609D4 File Offset: 0x0015EBD4
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController._LoadLeaderboardThumbnail_d__121.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001C07 RID: 7175
			// (get) Token: 0x060052F7 RID: 21239 RVA: 0x00160A14 File Offset: 0x0015EC14
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController._LoadLeaderboardThumbnail_d__121.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060052F8 RID: 21240 RVA: 0x00160A54 File Offset: 0x0015EC54
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 10168, RefRangeEnd = 10216, XrefRangeStart = 10168, XrefRangeEnd = 10216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _LoadLeaderboardThumbnail_d__121(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIController._LoadLeaderboardThumbnail_d__121>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController._LoadLeaderboardThumbnail_d__121.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060052F9 RID: 21241 RVA: 0x00160A9C File Offset: 0x0015EC9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137844, XrefRangeEnd = 137854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController._LoadLeaderboardThumbnail_d__121.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060052FA RID: 21242 RVA: 0x00160AD0 File Offset: 0x0015ECD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137854, XrefRangeEnd = 138087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController._LoadLeaderboardThumbnail_d__121.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060052FB RID: 21243 RVA: 0x00160B0C File Offset: 0x0015ED0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138087, XrefRangeEnd = 138090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController._LoadLeaderboardThumbnail_d__121.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060052FC RID: 21244 RVA: 0x00160B40 File Offset: 0x0015ED40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138090, XrefRangeEnd = 138093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController._LoadLeaderboardThumbnail_d__121.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060052FD RID: 21245 RVA: 0x00160B74 File Offset: 0x0015ED74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138093, XrefRangeEnd = 138098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController._LoadLeaderboardThumbnail_d__121.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060052FE RID: 21246 RVA: 0x0002021D File Offset: 0x0001E41D
			public _LoadLeaderboardThumbnail_d__121(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001BFB RID: 7163
			// (get) Token: 0x060052FF RID: 21247 RVA: 0x00160BA8 File Offset: 0x0015EDA8
			// (set) Token: 0x06005300 RID: 21248 RVA: 0x00020226 File Offset: 0x0001E426
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController._LoadLeaderboardThumbnail_d__121.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController._LoadLeaderboardThumbnail_d__121.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001BFC RID: 7164
			// (get) Token: 0x06005301 RID: 21249 RVA: 0x00160BD0 File Offset: 0x0015EDD0
			// (set) Token: 0x06005302 RID: 21250 RVA: 0x00020241 File Offset: 0x0001E441
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController._LoadLeaderboardThumbnail_d__121.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController._LoadLeaderboardThumbnail_d__121.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BFD RID: 7165
			// (get) Token: 0x06005303 RID: 21251 RVA: 0x00160C00 File Offset: 0x0015EE00
			// (set) Token: 0x06005304 RID: 21252 RVA: 0x00020260 File Offset: 0x0001E460
			public unsafe Player player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController._LoadLeaderboardThumbnail_d__121.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController._LoadLeaderboardThumbnail_d__121.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BFE RID: 7166
			// (get) Token: 0x06005305 RID: 21253 RVA: 0x00160C30 File Offset: 0x0015EE30
			// (set) Token: 0x06005306 RID: 21254 RVA: 0x0002027F File Offset: 0x0001E47F
			public unsafe UIController.__c__DisplayClass121_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController._LoadLeaderboardThumbnail_d__121.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIController.__c__DisplayClass121_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController._LoadLeaderboardThumbnail_d__121.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BFF RID: 7167
			// (get) Token: 0x06005307 RID: 21255 RVA: 0x00160C60 File Offset: 0x0015EE60
			// (set) Token: 0x06005308 RID: 21256 RVA: 0x0002029E File Offset: 0x0001E49E
			public unsafe RectTransform _plEntry
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController._LoadLeaderboardThumbnail_d__121.NativeFieldInfoPtr__plEntry);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController._LoadLeaderboardThumbnail_d__121.NativeFieldInfoPtr__plEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C00 RID: 7168
			// (get) Token: 0x06005309 RID: 21257 RVA: 0x00160C90 File Offset: 0x0015EE90
			// (set) Token: 0x0600530A RID: 21258 RVA: 0x000202BD File Offset: 0x0001E4BD
			public unsafe RectTransform _lbEntry
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController._LoadLeaderboardThumbnail_d__121.NativeFieldInfoPtr__lbEntry);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController._LoadLeaderboardThumbnail_d__121.NativeFieldInfoPtr__lbEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C01 RID: 7169
			// (get) Token: 0x0600530B RID: 21259 RVA: 0x00160CC0 File Offset: 0x0015EEC0
			// (set) Token: 0x0600530C RID: 21260 RVA: 0x000202DC File Offset: 0x0001E4DC
			public unsafe UIController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController._LoadLeaderboardThumbnail_d__121.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController._LoadLeaderboardThumbnail_d__121.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C02 RID: 7170
			// (get) Token: 0x0600530D RID: 21261 RVA: 0x00160CF0 File Offset: 0x0015EEF0
			// (set) Token: 0x0600530E RID: 21262 RVA: 0x000202FB File Offset: 0x0001E4FB
			public unsafe UnityWebRequest _uwr_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController._LoadLeaderboardThumbnail_d__121.NativeFieldInfoPtr__uwr_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController._LoadLeaderboardThumbnail_d__121.NativeFieldInfoPtr__uwr_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C03 RID: 7171
			// (get) Token: 0x0600530F RID: 21263 RVA: 0x00160D20 File Offset: 0x0015EF20
			// (set) Token: 0x06005310 RID: 21264 RVA: 0x0002031A File Offset: 0x0001E51A
			public unsafe string _token_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController._LoadLeaderboardThumbnail_d__121.NativeFieldInfoPtr__token_5__3);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController._LoadLeaderboardThumbnail_d__121.NativeFieldInfoPtr__token_5__3), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001C04 RID: 7172
			// (get) Token: 0x06005311 RID: 21265 RVA: 0x00160D48 File Offset: 0x0015EF48
			// (set) Token: 0x06005312 RID: 21266 RVA: 0x00020339 File Offset: 0x0001E539
			public unsafe Button _reportBtn_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController._LoadLeaderboardThumbnail_d__121.NativeFieldInfoPtr__reportBtn_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController._LoadLeaderboardThumbnail_d__121.NativeFieldInfoPtr__reportBtn_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C05 RID: 7173
			// (get) Token: 0x06005313 RID: 21267 RVA: 0x00160D78 File Offset: 0x0015EF78
			// (set) Token: 0x06005314 RID: 21268 RVA: 0x00020358 File Offset: 0x0001E558
			public unsafe UnityWebRequest _twr_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController._LoadLeaderboardThumbnail_d__121.NativeFieldInfoPtr__twr_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController._LoadLeaderboardThumbnail_d__121.NativeFieldInfoPtr__twr_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003F75 RID: 16245
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003F76 RID: 16246
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003F77 RID: 16247
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04003F78 RID: 16248
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04003F79 RID: 16249
			private static readonly IntPtr NativeFieldInfoPtr__plEntry;

			// Token: 0x04003F7A RID: 16250
			private static readonly IntPtr NativeFieldInfoPtr__lbEntry;

			// Token: 0x04003F7B RID: 16251
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003F7C RID: 16252
			private static readonly IntPtr NativeFieldInfoPtr__uwr_5__2;

			// Token: 0x04003F7D RID: 16253
			private static readonly IntPtr NativeFieldInfoPtr__token_5__3;

			// Token: 0x04003F7E RID: 16254
			private static readonly IntPtr NativeFieldInfoPtr__reportBtn_5__4;

			// Token: 0x04003F7F RID: 16255
			private static readonly IntPtr NativeFieldInfoPtr__twr_5__5;

			// Token: 0x04003F80 RID: 16256
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003F81 RID: 16257
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003F82 RID: 16258
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003F83 RID: 16259
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003F84 RID: 16260
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003F85 RID: 16261
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04003F86 RID: 16262
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x04003F87 RID: 16263
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}

		// Token: 0x02000441 RID: 1089
		[ObfuscatedName("Polytoria.Controllers.UIController+<LoadThumbnail>d__134")]
		public sealed class _LoadThumbnail_d__134 : global::Il2CppSystem.Object
		{
			// Token: 0x06005315 RID: 21269 RVA: 0x00160DA8 File Offset: 0x0015EFA8
			// Note: this type is marked as 'beforefieldinit'.
			static _LoadThumbnail_d__134()
			{
				Il2CppClassPointerStore<UIController._LoadThumbnail_d__134>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIController>.NativeClassPtr, "<LoadThumbnail>d__134");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIController._LoadThumbnail_d__134>.NativeClassPtr);
				UIController._LoadThumbnail_d__134.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIController._LoadThumbnail_d__134>.NativeClassPtr, "<>1__state");
				UIController._LoadThumbnail_d__134.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIController._LoadThumbnail_d__134>.NativeClassPtr, "<>2__current");
				UIController._LoadThumbnail_d__134.NativeFieldInfoPtr_userId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIController._LoadThumbnail_d__134>.NativeClassPtr, "userId");
				UIController._LoadThumbnail_d__134.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIController._LoadThumbnail_d__134>.NativeClassPtr, "<>4__this");
				UIController._LoadThumbnail_d__134.NativeFieldInfoPtr__uwr_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIController._LoadThumbnail_d__134>.NativeClassPtr, "<uwr>5__2");
				UIController._LoadThumbnail_d__134.NativeFieldInfoPtr__token_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIController._LoadThumbnail_d__134>.NativeClassPtr, "<token>5__3");
				UIController._LoadThumbnail_d__134.NativeFieldInfoPtr__user_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIController._LoadThumbnail_d__134>.NativeClassPtr, "<user>5__4");
				UIController._LoadThumbnail_d__134.NativeFieldInfoPtr__twr_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIController._LoadThumbnail_d__134>.NativeClassPtr, "<twr>5__5");
				UIController._LoadThumbnail_d__134.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController._LoadThumbnail_d__134>.NativeClassPtr, 100674635);
				UIController._LoadThumbnail_d__134.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController._LoadThumbnail_d__134>.NativeClassPtr, 100674637);
				UIController._LoadThumbnail_d__134.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController._LoadThumbnail_d__134>.NativeClassPtr, 100674629);
				UIController._LoadThumbnail_d__134.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController._LoadThumbnail_d__134>.NativeClassPtr, 100674630);
				UIController._LoadThumbnail_d__134.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController._LoadThumbnail_d__134>.NativeClassPtr, 100674631);
				UIController._LoadThumbnail_d__134.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController._LoadThumbnail_d__134>.NativeClassPtr, 100674632);
				UIController._LoadThumbnail_d__134.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController._LoadThumbnail_d__134>.NativeClassPtr, 100674633);
				UIController._LoadThumbnail_d__134.NativeMethodInfoPtr___m__Finally3_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController._LoadThumbnail_d__134>.NativeClassPtr, 100674634);
				UIController._LoadThumbnail_d__134.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIController._LoadThumbnail_d__134>.NativeClassPtr, 100674636);
			}

			// Token: 0x17001C10 RID: 7184
			// (get) Token: 0x06005316 RID: 21270 RVA: 0x00160F28 File Offset: 0x0015F128
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController._LoadThumbnail_d__134.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001C11 RID: 7185
			// (get) Token: 0x06005317 RID: 21271 RVA: 0x00160F68 File Offset: 0x0015F168
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController._LoadThumbnail_d__134.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005318 RID: 21272 RVA: 0x00160FA8 File Offset: 0x0015F1A8
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 10168, RefRangeEnd = 10216, XrefRangeStart = 10168, XrefRangeEnd = 10216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _LoadThumbnail_d__134(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIController._LoadThumbnail_d__134>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController._LoadThumbnail_d__134.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005319 RID: 21273 RVA: 0x00160FF0 File Offset: 0x0015F1F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138098, XrefRangeEnd = 138119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController._LoadThumbnail_d__134.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600531A RID: 21274 RVA: 0x00161024 File Offset: 0x0015F224
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138119, XrefRangeEnd = 138266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController._LoadThumbnail_d__134.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600531B RID: 21275 RVA: 0x00161060 File Offset: 0x0015F260
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138266, XrefRangeEnd = 138269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController._LoadThumbnail_d__134.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600531C RID: 21276 RVA: 0x00161094 File Offset: 0x0015F294
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138269, XrefRangeEnd = 138272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController._LoadThumbnail_d__134.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600531D RID: 21277 RVA: 0x001610C8 File Offset: 0x0015F2C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138272, XrefRangeEnd = 138275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController._LoadThumbnail_d__134.NativeMethodInfoPtr___m__Finally3_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600531E RID: 21278 RVA: 0x001610FC File Offset: 0x0015F2FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138275, XrefRangeEnd = 138280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIController._LoadThumbnail_d__134.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600531F RID: 21279 RVA: 0x00020377 File Offset: 0x0001E577
			public _LoadThumbnail_d__134(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001C08 RID: 7176
			// (get) Token: 0x06005320 RID: 21280 RVA: 0x00161130 File Offset: 0x0015F330
			// (set) Token: 0x06005321 RID: 21281 RVA: 0x00020380 File Offset: 0x0001E580
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController._LoadThumbnail_d__134.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController._LoadThumbnail_d__134.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001C09 RID: 7177
			// (get) Token: 0x06005322 RID: 21282 RVA: 0x00161158 File Offset: 0x0015F358
			// (set) Token: 0x06005323 RID: 21283 RVA: 0x0002039B File Offset: 0x0001E59B
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController._LoadThumbnail_d__134.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController._LoadThumbnail_d__134.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C0A RID: 7178
			// (get) Token: 0x06005324 RID: 21284 RVA: 0x00161188 File Offset: 0x0015F388
			// (set) Token: 0x06005325 RID: 21285 RVA: 0x000203BA File Offset: 0x0001E5BA
			public unsafe int userId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController._LoadThumbnail_d__134.NativeFieldInfoPtr_userId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController._LoadThumbnail_d__134.NativeFieldInfoPtr_userId)) = value;
				}
			}

			// Token: 0x17001C0B RID: 7179
			// (get) Token: 0x06005326 RID: 21286 RVA: 0x001611B0 File Offset: 0x0015F3B0
			// (set) Token: 0x06005327 RID: 21287 RVA: 0x000203D5 File Offset: 0x0001E5D5
			public unsafe UIController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController._LoadThumbnail_d__134.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController._LoadThumbnail_d__134.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C0C RID: 7180
			// (get) Token: 0x06005328 RID: 21288 RVA: 0x001611E0 File Offset: 0x0015F3E0
			// (set) Token: 0x06005329 RID: 21289 RVA: 0x000203F4 File Offset: 0x0001E5F4
			public unsafe UnityWebRequest _uwr_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController._LoadThumbnail_d__134.NativeFieldInfoPtr__uwr_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController._LoadThumbnail_d__134.NativeFieldInfoPtr__uwr_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C0D RID: 7181
			// (get) Token: 0x0600532A RID: 21290 RVA: 0x00161210 File Offset: 0x0015F410
			// (set) Token: 0x0600532B RID: 21291 RVA: 0x00020413 File Offset: 0x0001E613
			public unsafe string _token_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController._LoadThumbnail_d__134.NativeFieldInfoPtr__token_5__3);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController._LoadThumbnail_d__134.NativeFieldInfoPtr__token_5__3), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001C0E RID: 7182
			// (get) Token: 0x0600532C RID: 21292 RVA: 0x00161238 File Offset: 0x0015F438
			// (set) Token: 0x0600532D RID: 21293 RVA: 0x00020432 File Offset: 0x0001E632
			public unsafe JSONNode _user_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController._LoadThumbnail_d__134.NativeFieldInfoPtr__user_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController._LoadThumbnail_d__134.NativeFieldInfoPtr__user_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C0F RID: 7183
			// (get) Token: 0x0600532E RID: 21294 RVA: 0x00161268 File Offset: 0x0015F468
			// (set) Token: 0x0600532F RID: 21295 RVA: 0x00020451 File Offset: 0x0001E651
			public unsafe UnityWebRequest _twr_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController._LoadThumbnail_d__134.NativeFieldInfoPtr__twr_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIController._LoadThumbnail_d__134.NativeFieldInfoPtr__twr_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003F88 RID: 16264
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003F89 RID: 16265
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003F8A RID: 16266
			private static readonly IntPtr NativeFieldInfoPtr_userId;

			// Token: 0x04003F8B RID: 16267
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003F8C RID: 16268
			private static readonly IntPtr NativeFieldInfoPtr__uwr_5__2;

			// Token: 0x04003F8D RID: 16269
			private static readonly IntPtr NativeFieldInfoPtr__token_5__3;

			// Token: 0x04003F8E RID: 16270
			private static readonly IntPtr NativeFieldInfoPtr__user_5__4;

			// Token: 0x04003F8F RID: 16271
			private static readonly IntPtr NativeFieldInfoPtr__twr_5__5;

			// Token: 0x04003F90 RID: 16272
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003F91 RID: 16273
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003F92 RID: 16274
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003F93 RID: 16275
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003F94 RID: 16276
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003F95 RID: 16277
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04003F96 RID: 16278
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x04003F97 RID: 16279
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally3_Private_Void_0;

			// Token: 0x04003F98 RID: 16280
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}
	}
}
