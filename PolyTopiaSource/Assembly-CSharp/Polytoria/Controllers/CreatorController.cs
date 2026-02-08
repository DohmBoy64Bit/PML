using System;
using Battlehub.UIControls;
using HSVPicker;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using Il2CppSystem.Reflection;
using Mirror;
using Polytoria.Creator.PropertyGrid;
using Polytoria.Datamodel;
using RLD;
using SimpleJSON;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

namespace Polytoria.Controllers
{
	// Token: 0x0200033E RID: 830
	public class CreatorController : NetworkBehaviour
	{
		// Token: 0x060047A7 RID: 18343 RVA: 0x0013DAE4 File Offset: 0x0013BCE4
		// Note: this type is marked as 'beforefieldinit'.
		static CreatorController()
		{
			Il2CppClassPointerStore<CreatorController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Controllers", "CreatorController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreatorController>.NativeClassPtr);
			CreatorController.NativeFieldInfoPtr_testCreatorToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, "testCreatorToken");
			CreatorController.NativeFieldInfoPtr_singleton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, "singleton");
			CreatorController.NativeFieldInfoPtr_IsCreator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, "IsCreator");
			CreatorController.NativeFieldInfoPtr_externalScriptFolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, "externalScriptFolder");
			CreatorController.NativeFieldInfoPtr_random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, "random");
			CreatorController.NativeFieldInfoPtr_TreeView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, "TreeView");
			CreatorController.NativeFieldInfoPtr_PropertyGrid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, "PropertyGrid");
			CreatorController.NativeFieldInfoPtr_activateButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, "activateButtons");
			CreatorController.NativeFieldInfoPtr_colorPicker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, "colorPicker");
			CreatorController.NativeFieldInfoPtr_colorDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, "colorDisplay");
			CreatorController.NativeFieldInfoPtr_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, "canvas");
			CreatorController.NativeFieldInfoPtr_landing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, "landing");
			CreatorController.NativeFieldInfoPtr_materialSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, "materialSelector");
			CreatorController.NativeFieldInfoPtr_publishModal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, "publishModal");
			CreatorController.NativeFieldInfoPtr_contextMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, "contextMenu");
			CreatorController.NativeFieldInfoPtr_propertyColorPicker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, "propertyColorPicker");
			CreatorController.NativeFieldInfoPtr_statusBar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, "statusBar");
			CreatorController.NativeFieldInfoPtr_confirmExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, "confirmExit");
			CreatorController.NativeFieldInfoPtr_moveSnap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, "moveSnap");
			CreatorController.NativeFieldInfoPtr_rotateSnap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, "rotateSnap");
			CreatorController.NativeFieldInfoPtr_moveSnapEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, "moveSnapEnabled");
			CreatorController.NativeFieldInfoPtr_rotateSnapEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, "rotateSnapEnabled");
			CreatorController.NativeFieldInfoPtr_autoSaveInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, "autoSaveInterval");
			CreatorController.NativeFieldInfoPtr_paintType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, "paintType");
			CreatorController.NativeFieldInfoPtr_defaultButtonClr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, "defaultButtonClr");
			CreatorController.NativeFieldInfoPtr_externalScriptFiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, "externalScriptFiles");
			CreatorController.NativeFieldInfoPtr_watcher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, "watcher");
			CreatorController.NativeFieldInfoPtr_paintColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, "paintColor");
			CreatorController.NativeFieldInfoPtr_paintMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, "paintMaterial");
			CreatorController.NativeFieldInfoPtr_userID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, "userID");
			CreatorController.NativeFieldInfoPtr_gameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, "gameID");
			CreatorController.NativeFieldInfoPtr_saveLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, "saveLocation");
			CreatorController.NativeFieldInfoPtr_mouseDownPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, "mouseDownPosition");
			CreatorController.NativeFieldInfoPtr__CreatorToken_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, "<CreatorToken>k__BackingField");
			CreatorController.NativeFieldInfoPtr_selectionQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, "selectionQueue");
			CreatorController.NativeMethodInfoPtr_get_CreatorToken_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674638);
			CreatorController.NativeMethodInfoPtr_set_CreatorToken_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674639);
			CreatorController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674735);
			CreatorController.NativeMethodInfoPtr_WantsToQuit_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674640);
			CreatorController.NativeMethodInfoPtr_PromptExit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674641);
			CreatorController.NativeMethodInfoPtr_DoExit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674642);
			CreatorController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674643);
			CreatorController.NativeMethodInfoPtr_OnPostDragEnd_Private_Void_Gizmo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674644);
			CreatorController.NativeMethodInfoPtr_PropertyGrid_ValueChanged_Private_Void_Object_PropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674645);
			CreatorController.NativeMethodInfoPtr_GameLoaded_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674646);
			CreatorController.NativeMethodInfoPtr_OnAppInitialized_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674647);
			CreatorController.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674648);
			CreatorController.NativeMethodInfoPtr_DeleteSelection_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674649);
			CreatorController.NativeMethodInfoPtr_DuplicateSelection_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674650);
			CreatorController.NativeMethodInfoPtr_SetStatusBarMessage_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674651);
			CreatorController.NativeMethodInfoPtr_CheckToken_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674652);
			CreatorController.NativeMethodInfoPtr_GetCommandLineArgs_Private_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674653);
			CreatorController.NativeMethodInfoPtr_RelaunchCreator_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674654);
			CreatorController.NativeMethodInfoPtr_GroupSelection_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674655);
			CreatorController.NativeMethodInfoPtr_UngroupSelection_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674656);
			CreatorController.NativeMethodInfoPtr_ExportModel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674657);
			CreatorController.NativeMethodInfoPtr_ShowExportModelDialog_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674658);
			CreatorController.NativeMethodInfoPtr_DoExportModel_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674659);
			CreatorController.NativeMethodInfoPtr_ExportGLTF_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674660);
			CreatorController.NativeMethodInfoPtr_ShowExportGLTFDialog_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674661);
			CreatorController.NativeMethodInfoPtr_DoExportGLTF_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674662);
			CreatorController.NativeMethodInfoPtr_PublishModel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674663);
			CreatorController.NativeMethodInfoPtr_DoPublishModel_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674664);
			CreatorController.NativeMethodInfoPtr_ImportModel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674665);
			CreatorController.NativeMethodInfoPtr_ShowImportModelDialog_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674666);
			CreatorController.NativeMethodInfoPtr_DoImportModel_Private_Static_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674667);
			CreatorController.NativeMethodInfoPtr_ToolboxModelAdded_Public_Void_Model_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674668);
			CreatorController.NativeMethodInfoPtr_GetSelectedInstances_Public_Static_List_1_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674669);
			CreatorController.NativeMethodInfoPtr_LoadStarterPlaces_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674670);
			CreatorController.NativeMethodInfoPtr_ClearWorkspace_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674671);
			CreatorController.NativeMethodInfoPtr_CloseStartScreen_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674672);
			CreatorController.NativeMethodInfoPtr_ScriptEditedExternally_Private_Void_Object_FileSystemEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674673);
			CreatorController.NativeMethodInfoPtr_EditScript_Private_Void_BaseScript_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674674);
			CreatorController.NativeMethodInfoPtr_PublishGame_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674675);
			CreatorController.NativeMethodInfoPtr_DoPublish_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674676);
			CreatorController.NativeMethodInfoPtr_LoadThumbnailImages_Private_IEnumerator_List_1_ThumbnailImageTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674677);
			CreatorController.NativeMethodInfoPtr_SetPublishModalSelectedGame_Public_Void_JSONNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674678);
			CreatorController.NativeMethodInfoPtr_LoadThumbnailImage_Private_IEnumerator_String_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674679);
			CreatorController.NativeMethodInfoPtr_chmod_Private_Static_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674680);
			CreatorController.NativeMethodInfoPtr_TestGame_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674681);
			CreatorController.NativeMethodInfoPtr_PublishGameOverwrite_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674682);
			CreatorController.NativeMethodInfoPtr_PublishLevelToID_Private_IEnumerator_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674683);
			CreatorController.NativeMethodInfoPtr_RandomString_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674684);
			CreatorController.NativeMethodInfoPtr_FileOpen_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674685);
			CreatorController.NativeMethodInfoPtr_ShowOpenDialog_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674686);
			CreatorController.NativeMethodInfoPtr_AutoSaveLoop_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674687);
			CreatorController.NativeMethodInfoPtr_DoLoadMap_Private_Static_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674688);
			CreatorController.NativeMethodInfoPtr_LoadMapFromFile_Private_IEnumerator_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674689);
			CreatorController.NativeMethodInfoPtr_FileSave_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674690);
			CreatorController.NativeMethodInfoPtr_ShowSaveDialog_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674691);
			CreatorController.NativeMethodInfoPtr_DoSaveFile_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674692);
			CreatorController.NativeMethodInfoPtr_SetMoveSnapEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674693);
			CreatorController.NativeMethodInfoPtr_SetMoveSnapSize_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674694);
			CreatorController.NativeMethodInfoPtr_SetRotateSnapEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674695);
			CreatorController.NativeMethodInfoPtr_SetRotateSnapSize_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674696);
			CreatorController.NativeMethodInfoPtr_SetActiveGizmo_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674697);
			CreatorController.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674698);
			CreatorController.NativeMethodInfoPtr_IsEditingTextField_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674699);
			CreatorController.NativeMethodInfoPtr_GetSelectedInstancesTreeView_Public_List_1_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674700);
			CreatorController.NativeMethodInfoPtr_CopySelectionToClipboard_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674701);
			CreatorController.NativeMethodInfoPtr_CutSelectionToClipboard_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674702);
			CreatorController.NativeMethodInfoPtr_PasteFromClipboard_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674703);
			CreatorController.NativeMethodInfoPtr_ShowContextMenu_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674704);
			CreatorController.NativeMethodInfoPtr_SetPaintColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674705);
			CreatorController.NativeMethodInfoPtr_ToggleColorPicker_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674706);
			CreatorController.NativeMethodInfoPtr_ToggleMaterialPicker_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674707);
			CreatorController.NativeMethodInfoPtr_OnItemDataBinding_Private_Void_Object_VirtualizingTreeViewItemDataBindingArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674708);
			CreatorController.NativeMethodInfoPtr_OnItemBeginDrop_Private_Void_Object_ItemDropCancelArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674709);
			CreatorController.NativeMethodInfoPtr_OnItemBeginDrag_Private_Void_Object_ItemArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674710);
			CreatorController.NativeMethodInfoPtr_OnItemEndDrag_Private_Void_Object_ItemArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674711);
			CreatorController.NativeMethodInfoPtr_OnItemExpanding_Private_Void_Object_VirtualizingItemExpandingArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674712);
			CreatorController.NativeMethodInfoPtr_OnTreeSelectionChanged_Private_Void_Object_SelectionChangedArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674713);
			CreatorController.NativeMethodInfoPtr_ChildrenOf_Private_List_1_Instance_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674714);
			CreatorController.NativeMethodInfoPtr_OnItemDrop_Private_Void_Object_ItemDropArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674715);
			CreatorController.NativeMethodInfoPtr_OnItemDoubleClick_Private_Void_Object_ItemArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674716);
			CreatorController.NativeMethodInfoPtr_OnObjectSelectionChanged_Private_Void_ObjectSelectionChangedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674717);
			CreatorController.NativeMethodInfoPtr_CloseContextMenu_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674718);
			CreatorController.NativeMethodInfoPtr_AddPart_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674719);
			CreatorController.NativeMethodInfoPtr_SelectChildren_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674720);
			CreatorController.NativeMethodInfoPtr_Undo_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674721);
			CreatorController.NativeMethodInfoPtr_Redo_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674722);
			CreatorController.NativeMethodInfoPtr_AddTruss_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674723);
			CreatorController.NativeMethodInfoPtr_AddInstance_Public_Instance_String_Instance_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674724);
			CreatorController.NativeMethodInfoPtr_AddPart_Public_Void_PartShape_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674725);
			CreatorController.NativeMethodInfoPtr_AddScript_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674726);
			CreatorController.NativeMethodInfoPtr_AddSound_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674727);
			CreatorController.NativeMethodInfoPtr_AddLocalScript_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674728);
			CreatorController.NativeMethodInfoPtr_AddModuleScript_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674729);
			CreatorController.NativeMethodInfoPtr_AddRemoteEvent_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674730);
			CreatorController.NativeMethodInfoPtr_Add_Public_Instance_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674731);
			CreatorController.NativeMethodInfoPtr_AddUI_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674732);
			CreatorController.NativeMethodInfoPtr_AddSeat_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674733);
			CreatorController.NativeMethodInfoPtr_IsPointerOverUIObject_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674734);
			CreatorController.NativeMethodInfoPtr__CheckToken_b__50_0_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674737);
			CreatorController.NativeMethodInfoPtr__LoadMapFromFile_b__87_0_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674738);
			CreatorController.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, 100674739);
		}

		// Token: 0x170018B0 RID: 6320
		// (get) Token: 0x060047A8 RID: 18344 RVA: 0x0013E5B4 File Offset: 0x0013C7B4
		// (set) Token: 0x060047A9 RID: 18345 RVA: 0x0013E5EC File Offset: 0x0013C7EC
		public unsafe string CreatorToken
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_get_CreatorToken_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140112, XrefRangeEnd = 140113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_set_CreatorToken_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060047AA RID: 18346 RVA: 0x0013E630 File Offset: 0x0013C830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140113, XrefRangeEnd = 140128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CreatorController()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreatorController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047AB RID: 18347 RVA: 0x0013E66C File Offset: 0x0013C86C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 20124, RefRangeEnd = 20136, XrefRangeStart = 20124, XrefRangeEnd = 20136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool WantsToQuit()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_WantsToQuit_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060047AC RID: 18348 RVA: 0x0013E69C File Offset: 0x0013C89C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140128, XrefRangeEnd = 140130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PromptExit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_PromptExit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047AD RID: 18349 RVA: 0x0013E6D0 File Offset: 0x0013C8D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140130, XrefRangeEnd = 140134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoExit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_DoExit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047AE RID: 18350 RVA: 0x0013E704 File Offset: 0x0013C904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140134, XrefRangeEnd = 140190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047AF RID: 18351 RVA: 0x0013E738 File Offset: 0x0013C938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140190, XrefRangeEnd = 140235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPostDragEnd(Gizmo gizmo, int handleId)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_OnPostDragEnd_Private_Void_Gizmo_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047B0 RID: 18352 RVA: 0x0013E788 File Offset: 0x0013C988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140235, XrefRangeEnd = 140282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PropertyGrid_ValueChanged(global::Il2CppSystem.Object obj, PropertyInfo propertyInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(propertyInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_PropertyGrid_ValueChanged_Private_Void_Object_PropertyInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047B1 RID: 18353 RVA: 0x0013E7DC File Offset: 0x0013C9DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140282, XrefRangeEnd = 140316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GameLoaded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_GameLoaded_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047B2 RID: 18354 RVA: 0x0013E810 File Offset: 0x0013CA10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140316, XrefRangeEnd = 140350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnAppInitialized()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_OnAppInitialized_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047B3 RID: 18355 RVA: 0x0013E844 File Offset: 0x0013CA44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140350, XrefRangeEnd = 140607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047B4 RID: 18356 RVA: 0x0013E878 File Offset: 0x0013CA78
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 140680, RefRangeEnd = 140684, XrefRangeStart = 140607, XrefRangeEnd = 140680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeleteSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_DeleteSelection_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047B5 RID: 18357 RVA: 0x0013E8AC File Offset: 0x0013CAAC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 140728, RefRangeEnd = 140730, XrefRangeStart = 140684, XrefRangeEnd = 140728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DuplicateSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_DuplicateSelection_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047B6 RID: 18358 RVA: 0x0013E8E0 File Offset: 0x0013CAE0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 140731, RefRangeEnd = 140738, XrefRangeStart = 140730, XrefRangeEnd = 140731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStatusBarMessage(string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_SetStatusBarMessage_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060047B7 RID: 18359 RVA: 0x0013E924 File Offset: 0x0013CB24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140738, XrefRangeEnd = 140743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator CheckToken()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_CheckToken_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060047B8 RID: 18360 RVA: 0x0013E964 File Offset: 0x0013CB64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140743, XrefRangeEnd = 140764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dictionary<string, string> GetCommandLineArgs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_GetCommandLineArgs_Private_Dictionary_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr3) : null;
		}

		// Token: 0x060047B9 RID: 18361 RVA: 0x0013E9A4 File Offset: 0x0013CBA4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 140777, RefRangeEnd = 140780, XrefRangeStart = 140764, XrefRangeEnd = 140777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RelaunchCreator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_RelaunchCreator_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047BA RID: 18362 RVA: 0x0013E9D8 File Offset: 0x0013CBD8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 140899, RefRangeEnd = 140901, XrefRangeStart = 140780, XrefRangeEnd = 140899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GroupSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_GroupSelection_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047BB RID: 18363 RVA: 0x0013EA0C File Offset: 0x0013CC0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 140984, RefRangeEnd = 140986, XrefRangeStart = 140901, XrefRangeEnd = 140984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UngroupSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_UngroupSelection_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047BC RID: 18364 RVA: 0x0013EA40 File Offset: 0x0013CC40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 141029, RefRangeEnd = 141030, XrefRangeStart = 140986, XrefRangeEnd = 141029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExportModel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_ExportModel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047BD RID: 18365 RVA: 0x0013EA74 File Offset: 0x0013CC74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 141034, RefRangeEnd = 141035, XrefRangeStart = 141030, XrefRangeEnd = 141034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ShowExportModelDialog()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_ShowExportModelDialog_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060047BE RID: 18366 RVA: 0x0013EAB4 File Offset: 0x0013CCB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141035, XrefRangeEnd = 141068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DoExportModel(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_DoExportModel_Private_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060047BF RID: 18367 RVA: 0x0013EAEC File Offset: 0x0013CCEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 141096, RefRangeEnd = 141097, XrefRangeStart = 141068, XrefRangeEnd = 141096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExportGLTF()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_ExportGLTF_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047C0 RID: 18368 RVA: 0x0013EB20 File Offset: 0x0013CD20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141097, XrefRangeEnd = 141101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ShowExportGLTFDialog()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_ShowExportGLTFDialog_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060047C1 RID: 18369 RVA: 0x0013EB60 File Offset: 0x0013CD60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141101, XrefRangeEnd = 141115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DoExportGLTF(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_DoExportGLTF_Private_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060047C2 RID: 18370 RVA: 0x0013EB98 File Offset: 0x0013CD98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 141121, RefRangeEnd = 141122, XrefRangeStart = 141115, XrefRangeEnd = 141121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PublishModel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_PublishModel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047C3 RID: 18371 RVA: 0x0013EBCC File Offset: 0x0013CDCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141122, XrefRangeEnd = 141127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DoPublishModel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_DoPublishModel_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060047C4 RID: 18372 RVA: 0x0013EC0C File Offset: 0x0013CE0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 141155, RefRangeEnd = 141156, XrefRangeStart = 141127, XrefRangeEnd = 141155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ImportModel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_ImportModel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047C5 RID: 18373 RVA: 0x0013EC40 File Offset: 0x0013CE40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141156, XrefRangeEnd = 141160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ShowImportModelDialog()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_ShowImportModelDialog_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060047C6 RID: 18374 RVA: 0x0013EC80 File Offset: 0x0013CE80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141160, XrefRangeEnd = 141207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DoImportModel(Il2CppStringArray paths)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(paths);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_DoImportModel_Private_Static_Void_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060047C7 RID: 18375 RVA: 0x0013ECB8 File Offset: 0x0013CEB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 141245, RefRangeEnd = 141246, XrefRangeStart = 141207, XrefRangeEnd = 141245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ToolboxModelAdded(Model i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(i);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_ToolboxModelAdded_Public_Void_Model_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060047C8 RID: 18376 RVA: 0x0013ECFC File Offset: 0x0013CEFC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 141283, RefRangeEnd = 141289, XrefRangeStart = 141246, XrefRangeEnd = 141283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Instance> GetSelectedInstances()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_GetSelectedInstances_Public_Static_List_1_Instance_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Instance>>(intPtr3) : null;
		}

		// Token: 0x060047C9 RID: 18377 RVA: 0x0013ED30 File Offset: 0x0013CF30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141289, XrefRangeEnd = 141294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator LoadStarterPlaces()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_LoadStarterPlaces_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060047CA RID: 18378 RVA: 0x0013ED70 File Offset: 0x0013CF70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 141341, RefRangeEnd = 141342, XrefRangeStart = 141294, XrefRangeEnd = 141341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearWorkspace()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_ClearWorkspace_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047CB RID: 18379 RVA: 0x0013EDA4 File Offset: 0x0013CFA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141342, XrefRangeEnd = 141345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloseStartScreen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_CloseStartScreen_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047CC RID: 18380 RVA: 0x0013EDD8 File Offset: 0x0013CFD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141345, XrefRangeEnd = 141363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScriptEditedExternally(global::Il2CppSystem.Object sender, FileSystemEventArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_ScriptEditedExternally_Private_Void_Object_FileSystemEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047CD RID: 18381 RVA: 0x0013EE2C File Offset: 0x0013D02C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 141443, RefRangeEnd = 141444, XrefRangeStart = 141363, XrefRangeEnd = 141443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EditScript(BaseScript script)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(script);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_EditScript_Private_Void_BaseScript_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060047CE RID: 18382 RVA: 0x0013EE70 File Offset: 0x0013D070
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 141450, RefRangeEnd = 141451, XrefRangeStart = 141444, XrefRangeEnd = 141450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PublishGame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_PublishGame_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047CF RID: 18383 RVA: 0x0013EEA4 File Offset: 0x0013D0A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141451, XrefRangeEnd = 141456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DoPublish()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_DoPublish_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060047D0 RID: 18384 RVA: 0x0013EEE4 File Offset: 0x0013D0E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 141461, RefRangeEnd = 141462, XrefRangeStart = 141456, XrefRangeEnd = 141461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator LoadThumbnailImages(List<CreatorController.ThumbnailImageTarget> thumbnails)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(thumbnails);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_LoadThumbnailImages_Private_IEnumerator_List_1_ThumbnailImageTarget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x060047D1 RID: 18385 RVA: 0x0013EF34 File Offset: 0x0013D134
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 141551, RefRangeEnd = 141553, XrefRangeStart = 141462, XrefRangeEnd = 141551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPublishModalSelectedGame(JSONNode game)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(game);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_SetPublishModalSelectedGame_Public_Void_JSONNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060047D2 RID: 18386 RVA: 0x0013EF78 File Offset: 0x0013D178
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141553, XrefRangeEnd = 141559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator LoadThumbnailImage(string src, Image target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(src);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_LoadThumbnailImage_Private_IEnumerator_String_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060047D3 RID: 18387 RVA: 0x0013EFDC File Offset: 0x0013D1DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141559, XrefRangeEnd = 141564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int chmod(string path, int mode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_chmod_Private_Static_Int32_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060047D4 RID: 18388 RVA: 0x0013F02C File Offset: 0x0013D22C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 141619, RefRangeEnd = 141621, XrefRangeStart = 141564, XrefRangeEnd = 141619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TestGame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_TestGame_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047D5 RID: 18389 RVA: 0x0013F060 File Offset: 0x0013D260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141621, XrefRangeEnd = 141628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PublishGameOverwrite(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_PublishGameOverwrite_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060047D6 RID: 18390 RVA: 0x0013F0A0 File Offset: 0x0013D2A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141628, XrefRangeEnd = 141633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator PublishLevelToID(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_PublishLevelToID_Private_IEnumerator_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x060047D7 RID: 18391 RVA: 0x0013F0EC File Offset: 0x0013D2EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141633, XrefRangeEnd = 141660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string RandomString(int length)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref length;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_RandomString_Public_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060047D8 RID: 18392 RVA: 0x0013F124 File Offset: 0x0013D324
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 141706, RefRangeEnd = 141708, XrefRangeStart = 141660, XrefRangeEnd = 141706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FileOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_FileOpen_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047D9 RID: 18393 RVA: 0x0013F158 File Offset: 0x0013D358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141708, XrefRangeEnd = 141712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ShowOpenDialog()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_ShowOpenDialog_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060047DA RID: 18394 RVA: 0x0013F198 File Offset: 0x0013D398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141712, XrefRangeEnd = 141717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator AutoSaveLoop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_AutoSaveLoop_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060047DB RID: 18395 RVA: 0x0013F1D8 File Offset: 0x0013D3D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141717, XrefRangeEnd = 141765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DoLoadMap(Il2CppStringArray paths)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(paths);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_DoLoadMap_Private_Static_Void_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060047DC RID: 18396 RVA: 0x0013F210 File Offset: 0x0013D410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141765, XrefRangeEnd = 141771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator LoadMapFromFile(string path)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_LoadMapFromFile_Private_IEnumerator_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x060047DD RID: 18397 RVA: 0x0013F260 File Offset: 0x0013D460
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 141810, RefRangeEnd = 141813, XrefRangeStart = 141771, XrefRangeEnd = 141810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FileSave(bool saveAs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref saveAs;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_FileSave_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060047DE RID: 18398 RVA: 0x0013F2A0 File Offset: 0x0013D4A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141813, XrefRangeEnd = 141817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ShowSaveDialog()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_ShowSaveDialog_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060047DF RID: 18399 RVA: 0x0013F2E0 File Offset: 0x0013D4E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141817, XrefRangeEnd = 141873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DoSaveFile(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_DoSaveFile_Private_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060047E0 RID: 18400 RVA: 0x0013F318 File Offset: 0x0013D518
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 141896, RefRangeEnd = 141897, XrefRangeStart = 141873, XrefRangeEnd = 141896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMoveSnapEnabled(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref enabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_SetMoveSnapEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060047E1 RID: 18401 RVA: 0x0013F358 File Offset: 0x0013D558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141897, XrefRangeEnd = 141899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMoveSnapSize(string snapString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(snapString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_SetMoveSnapSize_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060047E2 RID: 18402 RVA: 0x0013F39C File Offset: 0x0013D59C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141899, XrefRangeEnd = 141913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRotateSnapEnabled(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref enabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_SetRotateSnapEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060047E3 RID: 18403 RVA: 0x0013F3DC File Offset: 0x0013D5DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141913, XrefRangeEnd = 141928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRotateSnapSize(string snapString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(snapString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_SetRotateSnapSize_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060047E4 RID: 18404 RVA: 0x0013F420 File Offset: 0x0013D620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141928, XrefRangeEnd = 141992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetActiveGizmo(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_SetActiveGizmo_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060047E5 RID: 18405 RVA: 0x0013F464 File Offset: 0x0013D664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141992, XrefRangeEnd = 142127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047E6 RID: 18406 RVA: 0x0013F498 File Offset: 0x0013D698
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 142180, RefRangeEnd = 142181, XrefRangeStart = 142127, XrefRangeEnd = 142180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsEditingTextField()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_IsEditingTextField_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060047E7 RID: 18407 RVA: 0x0013F4D4 File Offset: 0x0013D6D4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 142212, RefRangeEnd = 142216, XrefRangeStart = 142181, XrefRangeEnd = 142212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Instance> GetSelectedInstancesTreeView()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_GetSelectedInstancesTreeView_Public_List_1_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Instance>>(intPtr3) : null;
		}

		// Token: 0x060047E8 RID: 18408 RVA: 0x0013F514 File Offset: 0x0013D714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142216, XrefRangeEnd = 142224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopySelectionToClipboard()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_CopySelectionToClipboard_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047E9 RID: 18409 RVA: 0x0013F548 File Offset: 0x0013D748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142224, XrefRangeEnd = 142237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CutSelectionToClipboard()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_CutSelectionToClipboard_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047EA RID: 18410 RVA: 0x0013F57C File Offset: 0x0013D77C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142237, XrefRangeEnd = 142254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PasteFromClipboard()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_PasteFromClipboard_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047EB RID: 18411 RVA: 0x0013F5B0 File Offset: 0x0013D7B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142254, XrefRangeEnd = 142261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowContextMenu()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_ShowContextMenu_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047EC RID: 18412 RVA: 0x0013F5E4 File Offset: 0x0013D7E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142261, XrefRangeEnd = 142262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPaintColor(Color c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_SetPaintColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060047ED RID: 18413 RVA: 0x0013F628 File Offset: 0x0013D828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142262, XrefRangeEnd = 142266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ToggleColorPicker()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_ToggleColorPicker_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047EE RID: 18414 RVA: 0x0013F65C File Offset: 0x0013D85C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142266, XrefRangeEnd = 142270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ToggleMaterialPicker()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_ToggleMaterialPicker_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047EF RID: 18415 RVA: 0x0013F690 File Offset: 0x0013D890
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142270, XrefRangeEnd = 142294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnItemDataBinding(global::Il2CppSystem.Object sender, VirtualizingTreeViewItemDataBindingArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_OnItemDataBinding_Private_Void_Object_VirtualizingTreeViewItemDataBindingArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047F0 RID: 18416 RVA: 0x0013F6E4 File Offset: 0x0013D8E4
		[CallerCount(7535)]
		[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnItemBeginDrop(global::Il2CppSystem.Object sender, ItemDropCancelArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_OnItemBeginDrop_Private_Void_Object_ItemDropCancelArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047F1 RID: 18417 RVA: 0x0013F738 File Offset: 0x0013D938
		[CallerCount(7535)]
		[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnItemBeginDrag(global::Il2CppSystem.Object sender, ItemArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_OnItemBeginDrag_Private_Void_Object_ItemArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047F2 RID: 18418 RVA: 0x0013F78C File Offset: 0x0013D98C
		[CallerCount(7535)]
		[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnItemEndDrag(global::Il2CppSystem.Object sender, ItemArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_OnItemEndDrag_Private_Void_Object_ItemArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047F3 RID: 18419 RVA: 0x0013F7E0 File Offset: 0x0013D9E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142294, XrefRangeEnd = 142299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnItemExpanding(global::Il2CppSystem.Object sender, VirtualizingItemExpandingArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_OnItemExpanding_Private_Void_Object_VirtualizingItemExpandingArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047F4 RID: 18420 RVA: 0x0013F834 File Offset: 0x0013DA34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142299, XrefRangeEnd = 142357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTreeSelectionChanged(global::Il2CppSystem.Object sender, SelectionChangedArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_OnTreeSelectionChanged_Private_Void_Object_SelectionChangedArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047F5 RID: 18421 RVA: 0x0013F888 File Offset: 0x0013DA88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142357, XrefRangeEnd = 142369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Instance> ChildrenOf(Instance parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_ChildrenOf_Private_List_1_Instance_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Instance>>(intPtr3) : null;
			}
		}

		// Token: 0x060047F6 RID: 18422 RVA: 0x0013F8D8 File Offset: 0x0013DAD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142369, XrefRangeEnd = 142431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnItemDrop(global::Il2CppSystem.Object sender, ItemDropArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_OnItemDrop_Private_Void_Object_ItemDropArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047F7 RID: 18423 RVA: 0x0013F92C File Offset: 0x0013DB2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142431, XrefRangeEnd = 142438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnItemDoubleClick(global::Il2CppSystem.Object sender, ItemArgs e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_OnItemDoubleClick_Private_Void_Object_ItemArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047F8 RID: 18424 RVA: 0x0013F980 File Offset: 0x0013DB80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142438, XrefRangeEnd = 142495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnObjectSelectionChanged(ObjectSelectionChangedEventArgs args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_OnObjectSelectionChanged_Private_Void_ObjectSelectionChangedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060047F9 RID: 18425 RVA: 0x0013F9C4 File Offset: 0x0013DBC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142495, XrefRangeEnd = 142498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloseContextMenu()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_CloseContextMenu_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047FA RID: 18426 RVA: 0x0013F9F8 File Offset: 0x0013DBF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142498, XrefRangeEnd = 142515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPart(string shape)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(shape);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_AddPart_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060047FB RID: 18427 RVA: 0x0013FA3C File Offset: 0x0013DC3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142515, XrefRangeEnd = 142546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectChildren()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_SelectChildren_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047FC RID: 18428 RVA: 0x0013FA70 File Offset: 0x0013DC70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142546, XrefRangeEnd = 142554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Undo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_Undo_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047FD RID: 18429 RVA: 0x0013FAA4 File Offset: 0x0013DCA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142554, XrefRangeEnd = 142562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Redo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_Redo_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047FE RID: 18430 RVA: 0x0013FAD8 File Offset: 0x0013DCD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142562, XrefRangeEnd = 142565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddTruss()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_AddTruss_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047FF RID: 18431 RVA: 0x0013FB0C File Offset: 0x0013DD0C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 142651, RefRangeEnd = 142661, XrefRangeStart = 142565, XrefRangeEnd = 142651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Instance AddInstance(string className, Instance parent = null, bool ignorePlacement = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(className);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignorePlacement;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_AddInstance_Public_Instance_String_Instance_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instance>(intPtr3) : null;
		}

		// Token: 0x06004800 RID: 18432 RVA: 0x0013FB7C File Offset: 0x0013DD7C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 142747, RefRangeEnd = 142752, XrefRangeStart = 142661, XrefRangeEnd = 142747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPart(PartShape shape = PartShape.Brick, string name = "Brick")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(shape);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_AddPart_Public_Void_PartShape_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004801 RID: 18433 RVA: 0x0013FBD0 File Offset: 0x0013DDD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 142760, RefRangeEnd = 142761, XrefRangeStart = 142752, XrefRangeEnd = 142760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddScript()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_AddScript_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004802 RID: 18434 RVA: 0x0013FC04 File Offset: 0x0013DE04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142761, XrefRangeEnd = 142764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddSound()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_AddSound_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004803 RID: 18435 RVA: 0x0013FC38 File Offset: 0x0013DE38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 142772, RefRangeEnd = 142773, XrefRangeStart = 142764, XrefRangeEnd = 142772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddLocalScript()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_AddLocalScript_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004804 RID: 18436 RVA: 0x0013FC6C File Offset: 0x0013DE6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 142781, RefRangeEnd = 142782, XrefRangeStart = 142773, XrefRangeEnd = 142781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddModuleScript()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_AddModuleScript_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004805 RID: 18437 RVA: 0x0013FCA0 File Offset: 0x0013DEA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 142790, RefRangeEnd = 142791, XrefRangeStart = 142782, XrefRangeEnd = 142790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddRemoteEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_AddRemoteEvent_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004806 RID: 18438 RVA: 0x0013FCD4 File Offset: 0x0013DED4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 142795, RefRangeEnd = 142796, XrefRangeStart = 142791, XrefRangeEnd = 142795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Instance Add(string instanceClass, string parentClass)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(instanceClass);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(parentClass);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_Add_Public_Instance_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instance>(intPtr3) : null;
		}

		// Token: 0x06004807 RID: 18439 RVA: 0x0013FD38 File Offset: 0x0013DF38
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 142826, RefRangeEnd = 142833, XrefRangeStart = 142796, XrefRangeEnd = 142826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddUI(string instanceClass)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(instanceClass);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_AddUI_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004808 RID: 18440 RVA: 0x0013FD7C File Offset: 0x0013DF7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142833, XrefRangeEnd = 142917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddSeat(string name = "Seat")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_AddSeat_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004809 RID: 18441 RVA: 0x0013FDC0 File Offset: 0x0013DFC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142917, XrefRangeEnd = 142936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsPointerOverUIObject()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr_IsPointerOverUIObject_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600480A RID: 18442 RVA: 0x0013FDF0 File Offset: 0x0013DFF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142936, XrefRangeEnd = 142939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _CheckToken_b__50_0(bool result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref result;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr__CheckToken_b__50_0_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600480B RID: 18443 RVA: 0x0013FE30 File Offset: 0x0013E030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142939, XrefRangeEnd = 142942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _LoadMapFromFile_b__87_0(bool r)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref r;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.NativeMethodInfoPtr__LoadMapFromFile_b__87_0_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600480C RID: 18444 RVA: 0x0013FE70 File Offset: 0x0013E070
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 20124, RefRangeEnd = 20136, XrefRangeStart = 20124, XrefRangeEnd = 20136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Weaved()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CreatorController.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600480D RID: 18445 RVA: 0x0001AABF File Offset: 0x00018CBF
		public CreatorController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700188D RID: 6285
		// (get) Token: 0x0600480E RID: 18446 RVA: 0x0013FEB8 File Offset: 0x0013E0B8
		// (set) Token: 0x0600480F RID: 18447 RVA: 0x0001AAC8 File Offset: 0x00018CC8
		public unsafe string testCreatorToken
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.NativeFieldInfoPtr_testCreatorToken);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.NativeFieldInfoPtr_testCreatorToken), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700188E RID: 6286
		// (get) Token: 0x06004810 RID: 18448 RVA: 0x0013FEE0 File Offset: 0x0013E0E0
		// (set) Token: 0x06004811 RID: 18449 RVA: 0x0001AAE7 File Offset: 0x00018CE7
		public unsafe static CreatorController singleton
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CreatorController.NativeFieldInfoPtr_singleton, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CreatorController>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CreatorController.NativeFieldInfoPtr_singleton, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700188F RID: 6287
		// (get) Token: 0x06004812 RID: 18450 RVA: 0x0013FF08 File Offset: 0x0013E108
		// (set) Token: 0x06004813 RID: 18451 RVA: 0x0001AAF9 File Offset: 0x00018CF9
		public unsafe static bool IsCreator
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(CreatorController.NativeFieldInfoPtr_IsCreator, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CreatorController.NativeFieldInfoPtr_IsCreator, (void*)(&value));
			}
		}

		// Token: 0x17001890 RID: 6288
		// (get) Token: 0x06004814 RID: 18452 RVA: 0x0013FF24 File Offset: 0x0013E124
		// (set) Token: 0x06004815 RID: 18453 RVA: 0x0001AB07 File Offset: 0x00018D07
		public unsafe static string externalScriptFolder
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CreatorController.NativeFieldInfoPtr_externalScriptFolder, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CreatorController.NativeFieldInfoPtr_externalScriptFolder, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001891 RID: 6289
		// (get) Token: 0x06004816 RID: 18454 RVA: 0x0013FF44 File Offset: 0x0013E144
		// (set) Token: 0x06004817 RID: 18455 RVA: 0x0001AB19 File Offset: 0x00018D19
		public unsafe static global::Il2CppSystem.Random random
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CreatorController.NativeFieldInfoPtr_random, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Random>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CreatorController.NativeFieldInfoPtr_random, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001892 RID: 6290
		// (get) Token: 0x06004818 RID: 18456 RVA: 0x0013FF6C File Offset: 0x0013E16C
		// (set) Token: 0x06004819 RID: 18457 RVA: 0x0001AB2B File Offset: 0x00018D2B
		public unsafe VirtualizingTreeView TreeView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.NativeFieldInfoPtr_TreeView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VirtualizingTreeView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.NativeFieldInfoPtr_TreeView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001893 RID: 6291
		// (get) Token: 0x0600481A RID: 18458 RVA: 0x0013FF9C File Offset: 0x0013E19C
		// (set) Token: 0x0600481B RID: 18459 RVA: 0x0001AB4A File Offset: 0x00018D4A
		public unsafe CreatorPropertyGrid PropertyGrid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.NativeFieldInfoPtr_PropertyGrid);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CreatorPropertyGrid>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.NativeFieldInfoPtr_PropertyGrid), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001894 RID: 6292
		// (get) Token: 0x0600481C RID: 18460 RVA: 0x0013FFCC File Offset: 0x0013E1CC
		// (set) Token: 0x0600481D RID: 18461 RVA: 0x0001AB69 File Offset: 0x00018D69
		public unsafe Il2CppReferenceArray<Image> activateButtons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.NativeFieldInfoPtr_activateButtons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Image>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.NativeFieldInfoPtr_activateButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001895 RID: 6293
		// (get) Token: 0x0600481E RID: 18462 RVA: 0x0013FFFC File Offset: 0x0013E1FC
		// (set) Token: 0x0600481F RID: 18463 RVA: 0x0001AB88 File Offset: 0x00018D88
		public unsafe ColorPicker colorPicker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.NativeFieldInfoPtr_colorPicker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorPicker>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.NativeFieldInfoPtr_colorPicker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001896 RID: 6294
		// (get) Token: 0x06004820 RID: 18464 RVA: 0x0014002C File Offset: 0x0013E22C
		// (set) Token: 0x06004821 RID: 18465 RVA: 0x0001ABA7 File Offset: 0x00018DA7
		public unsafe Il2CppReferenceArray<Image> colorDisplay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.NativeFieldInfoPtr_colorDisplay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Image>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.NativeFieldInfoPtr_colorDisplay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001897 RID: 6295
		// (get) Token: 0x06004822 RID: 18466 RVA: 0x0014005C File Offset: 0x0013E25C
		// (set) Token: 0x06004823 RID: 18467 RVA: 0x0001ABC6 File Offset: 0x00018DC6
		public unsafe Canvas canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.NativeFieldInfoPtr_canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.NativeFieldInfoPtr_canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001898 RID: 6296
		// (get) Token: 0x06004824 RID: 18468 RVA: 0x0014008C File Offset: 0x0013E28C
		// (set) Token: 0x06004825 RID: 18469 RVA: 0x0001ABE5 File Offset: 0x00018DE5
		public unsafe RectTransform landing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.NativeFieldInfoPtr_landing);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.NativeFieldInfoPtr_landing), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001899 RID: 6297
		// (get) Token: 0x06004826 RID: 18470 RVA: 0x001400BC File Offset: 0x0013E2BC
		// (set) Token: 0x06004827 RID: 18471 RVA: 0x0001AC04 File Offset: 0x00018E04
		public unsafe RectTransform materialSelector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.NativeFieldInfoPtr_materialSelector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.NativeFieldInfoPtr_materialSelector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700189A RID: 6298
		// (get) Token: 0x06004828 RID: 18472 RVA: 0x001400EC File Offset: 0x0013E2EC
		// (set) Token: 0x06004829 RID: 18473 RVA: 0x0001AC23 File Offset: 0x00018E23
		public unsafe RectTransform publishModal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.NativeFieldInfoPtr_publishModal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.NativeFieldInfoPtr_publishModal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700189B RID: 6299
		// (get) Token: 0x0600482A RID: 18474 RVA: 0x0014011C File Offset: 0x0013E31C
		// (set) Token: 0x0600482B RID: 18475 RVA: 0x0001AC42 File Offset: 0x00018E42
		public unsafe RectTransform contextMenu
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.NativeFieldInfoPtr_contextMenu);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.NativeFieldInfoPtr_contextMenu), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700189C RID: 6300
		// (get) Token: 0x0600482C RID: 18476 RVA: 0x0014014C File Offset: 0x0013E34C
		// (set) Token: 0x0600482D RID: 18477 RVA: 0x0001AC61 File Offset: 0x00018E61
		public unsafe ColorPicker propertyColorPicker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.NativeFieldInfoPtr_propertyColorPicker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorPicker>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.NativeFieldInfoPtr_propertyColorPicker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700189D RID: 6301
		// (get) Token: 0x0600482E RID: 18478 RVA: 0x0014017C File Offset: 0x0013E37C
		// (set) Token: 0x0600482F RID: 18479 RVA: 0x0001AC80 File Offset: 0x00018E80
		public unsafe TMP_Text statusBar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.NativeFieldInfoPtr_statusBar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.NativeFieldInfoPtr_statusBar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700189E RID: 6302
		// (get) Token: 0x06004830 RID: 18480 RVA: 0x001401AC File Offset: 0x0013E3AC
		// (set) Token: 0x06004831 RID: 18481 RVA: 0x0001AC9F File Offset: 0x00018E9F
		public unsafe GameObject confirmExit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.NativeFieldInfoPtr_confirmExit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.NativeFieldInfoPtr_confirmExit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700189F RID: 6303
		// (get) Token: 0x06004832 RID: 18482 RVA: 0x001401DC File Offset: 0x0013E3DC
		// (set) Token: 0x06004833 RID: 18483 RVA: 0x0001ACBE File Offset: 0x00018EBE
		public unsafe float moveSnap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.NativeFieldInfoPtr_moveSnap);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.NativeFieldInfoPtr_moveSnap)) = value;
			}
		}

		// Token: 0x170018A0 RID: 6304
		// (get) Token: 0x06004834 RID: 18484 RVA: 0x00140204 File Offset: 0x0013E404
		// (set) Token: 0x06004835 RID: 18485 RVA: 0x0001ACD9 File Offset: 0x00018ED9
		public unsafe float rotateSnap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.NativeFieldInfoPtr_rotateSnap);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.NativeFieldInfoPtr_rotateSnap)) = value;
			}
		}

		// Token: 0x170018A1 RID: 6305
		// (get) Token: 0x06004836 RID: 18486 RVA: 0x0014022C File Offset: 0x0013E42C
		// (set) Token: 0x06004837 RID: 18487 RVA: 0x0001ACF4 File Offset: 0x00018EF4
		public unsafe bool moveSnapEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.NativeFieldInfoPtr_moveSnapEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.NativeFieldInfoPtr_moveSnapEnabled)) = value;
			}
		}

		// Token: 0x170018A2 RID: 6306
		// (get) Token: 0x06004838 RID: 18488 RVA: 0x00140254 File Offset: 0x0013E454
		// (set) Token: 0x06004839 RID: 18489 RVA: 0x0001AD0F File Offset: 0x00018F0F
		public unsafe bool rotateSnapEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.NativeFieldInfoPtr_rotateSnapEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.NativeFieldInfoPtr_rotateSnapEnabled)) = value;
			}
		}

		// Token: 0x170018A3 RID: 6307
		// (get) Token: 0x0600483A RID: 18490 RVA: 0x0014027C File Offset: 0x0013E47C
		// (set) Token: 0x0600483B RID: 18491 RVA: 0x0001AD2A File Offset: 0x00018F2A
		public unsafe float autoSaveInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.NativeFieldInfoPtr_autoSaveInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.NativeFieldInfoPtr_autoSaveInterval)) = value;
			}
		}

		// Token: 0x170018A4 RID: 6308
		// (get) Token: 0x0600483C RID: 18492 RVA: 0x001402A4 File Offset: 0x0013E4A4
		// (set) Token: 0x0600483D RID: 18493 RVA: 0x0001AD45 File Offset: 0x00018F45
		public unsafe CreatorController.PaintType paintType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.NativeFieldInfoPtr_paintType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.NativeFieldInfoPtr_paintType)) = value;
			}
		}

		// Token: 0x170018A5 RID: 6309
		// (get) Token: 0x0600483E RID: 18494 RVA: 0x001402CC File Offset: 0x0013E4CC
		// (set) Token: 0x0600483F RID: 18495 RVA: 0x0001AD60 File Offset: 0x00018F60
		public unsafe Color defaultButtonClr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.NativeFieldInfoPtr_defaultButtonClr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.NativeFieldInfoPtr_defaultButtonClr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018A6 RID: 6310
		// (get) Token: 0x06004840 RID: 18496 RVA: 0x001402FC File Offset: 0x0013E4FC
		// (set) Token: 0x06004841 RID: 18497 RVA: 0x0001AD7F File Offset: 0x00018F7F
		public unsafe Dictionary<string, BaseScript> externalScriptFiles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.NativeFieldInfoPtr_externalScriptFiles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, BaseScript>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.NativeFieldInfoPtr_externalScriptFiles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018A7 RID: 6311
		// (get) Token: 0x06004842 RID: 18498 RVA: 0x0014032C File Offset: 0x0013E52C
		// (set) Token: 0x06004843 RID: 18499 RVA: 0x0001AD9E File Offset: 0x00018F9E
		public unsafe FileSystemWatcher watcher
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.NativeFieldInfoPtr_watcher);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FileSystemWatcher>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.NativeFieldInfoPtr_watcher), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018A8 RID: 6312
		// (get) Token: 0x06004844 RID: 18500 RVA: 0x0014035C File Offset: 0x0013E55C
		// (set) Token: 0x06004845 RID: 18501 RVA: 0x0001ADBD File Offset: 0x00018FBD
		public unsafe Color paintColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.NativeFieldInfoPtr_paintColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.NativeFieldInfoPtr_paintColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018A9 RID: 6313
		// (get) Token: 0x06004846 RID: 18502 RVA: 0x0014038C File Offset: 0x0013E58C
		// (set) Token: 0x06004847 RID: 18503 RVA: 0x0001ADDC File Offset: 0x00018FDC
		public unsafe PartMaterial paintMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.NativeFieldInfoPtr_paintMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartMaterial>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.NativeFieldInfoPtr_paintMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018AA RID: 6314
		// (get) Token: 0x06004848 RID: 18504 RVA: 0x001403BC File Offset: 0x0013E5BC
		// (set) Token: 0x06004849 RID: 18505 RVA: 0x0001ADFB File Offset: 0x00018FFB
		public unsafe int userID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.NativeFieldInfoPtr_userID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.NativeFieldInfoPtr_userID)) = value;
			}
		}

		// Token: 0x170018AB RID: 6315
		// (get) Token: 0x0600484A RID: 18506 RVA: 0x001403E4 File Offset: 0x0013E5E4
		// (set) Token: 0x0600484B RID: 18507 RVA: 0x0001AE16 File Offset: 0x00019016
		public unsafe int gameID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.NativeFieldInfoPtr_gameID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.NativeFieldInfoPtr_gameID)) = value;
			}
		}

		// Token: 0x170018AC RID: 6316
		// (get) Token: 0x0600484C RID: 18508 RVA: 0x0014040C File Offset: 0x0013E60C
		// (set) Token: 0x0600484D RID: 18509 RVA: 0x0001AE31 File Offset: 0x00019031
		public unsafe static string saveLocation
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CreatorController.NativeFieldInfoPtr_saveLocation, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CreatorController.NativeFieldInfoPtr_saveLocation, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170018AD RID: 6317
		// (get) Token: 0x0600484E RID: 18510 RVA: 0x0014042C File Offset: 0x0013E62C
		// (set) Token: 0x0600484F RID: 18511 RVA: 0x0001AE43 File Offset: 0x00019043
		public unsafe Vector3 mouseDownPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.NativeFieldInfoPtr_mouseDownPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.NativeFieldInfoPtr_mouseDownPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018AE RID: 6318
		// (get) Token: 0x06004850 RID: 18512 RVA: 0x0014045C File Offset: 0x0013E65C
		// (set) Token: 0x06004851 RID: 18513 RVA: 0x0001AE62 File Offset: 0x00019062
		public unsafe string _CreatorToken_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.NativeFieldInfoPtr__CreatorToken_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.NativeFieldInfoPtr__CreatorToken_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170018AF RID: 6319
		// (get) Token: 0x06004852 RID: 18514 RVA: 0x00140484 File Offset: 0x0013E684
		// (set) Token: 0x06004853 RID: 18515 RVA: 0x0001AE81 File Offset: 0x00019081
		public unsafe List<Instance> selectionQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.NativeFieldInfoPtr_selectionQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Instance>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.NativeFieldInfoPtr_selectionQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003775 RID: 14197
		private static readonly IntPtr NativeFieldInfoPtr_testCreatorToken;

		// Token: 0x04003776 RID: 14198
		private static readonly IntPtr NativeFieldInfoPtr_singleton;

		// Token: 0x04003777 RID: 14199
		private static readonly IntPtr NativeFieldInfoPtr_IsCreator;

		// Token: 0x04003778 RID: 14200
		private static readonly IntPtr NativeFieldInfoPtr_externalScriptFolder;

		// Token: 0x04003779 RID: 14201
		private static readonly IntPtr NativeFieldInfoPtr_random;

		// Token: 0x0400377A RID: 14202
		private static readonly IntPtr NativeFieldInfoPtr_TreeView;

		// Token: 0x0400377B RID: 14203
		private static readonly IntPtr NativeFieldInfoPtr_PropertyGrid;

		// Token: 0x0400377C RID: 14204
		private static readonly IntPtr NativeFieldInfoPtr_activateButtons;

		// Token: 0x0400377D RID: 14205
		private static readonly IntPtr NativeFieldInfoPtr_colorPicker;

		// Token: 0x0400377E RID: 14206
		private static readonly IntPtr NativeFieldInfoPtr_colorDisplay;

		// Token: 0x0400377F RID: 14207
		private static readonly IntPtr NativeFieldInfoPtr_canvas;

		// Token: 0x04003780 RID: 14208
		private static readonly IntPtr NativeFieldInfoPtr_landing;

		// Token: 0x04003781 RID: 14209
		private static readonly IntPtr NativeFieldInfoPtr_materialSelector;

		// Token: 0x04003782 RID: 14210
		private static readonly IntPtr NativeFieldInfoPtr_publishModal;

		// Token: 0x04003783 RID: 14211
		private static readonly IntPtr NativeFieldInfoPtr_contextMenu;

		// Token: 0x04003784 RID: 14212
		private static readonly IntPtr NativeFieldInfoPtr_propertyColorPicker;

		// Token: 0x04003785 RID: 14213
		private static readonly IntPtr NativeFieldInfoPtr_statusBar;

		// Token: 0x04003786 RID: 14214
		private static readonly IntPtr NativeFieldInfoPtr_confirmExit;

		// Token: 0x04003787 RID: 14215
		private static readonly IntPtr NativeFieldInfoPtr_moveSnap;

		// Token: 0x04003788 RID: 14216
		private static readonly IntPtr NativeFieldInfoPtr_rotateSnap;

		// Token: 0x04003789 RID: 14217
		private static readonly IntPtr NativeFieldInfoPtr_moveSnapEnabled;

		// Token: 0x0400378A RID: 14218
		private static readonly IntPtr NativeFieldInfoPtr_rotateSnapEnabled;

		// Token: 0x0400378B RID: 14219
		private static readonly IntPtr NativeFieldInfoPtr_autoSaveInterval;

		// Token: 0x0400378C RID: 14220
		private static readonly IntPtr NativeFieldInfoPtr_paintType;

		// Token: 0x0400378D RID: 14221
		private static readonly IntPtr NativeFieldInfoPtr_defaultButtonClr;

		// Token: 0x0400378E RID: 14222
		private static readonly IntPtr NativeFieldInfoPtr_externalScriptFiles;

		// Token: 0x0400378F RID: 14223
		private static readonly IntPtr NativeFieldInfoPtr_watcher;

		// Token: 0x04003790 RID: 14224
		private static readonly IntPtr NativeFieldInfoPtr_paintColor;

		// Token: 0x04003791 RID: 14225
		private static readonly IntPtr NativeFieldInfoPtr_paintMaterial;

		// Token: 0x04003792 RID: 14226
		private static readonly IntPtr NativeFieldInfoPtr_userID;

		// Token: 0x04003793 RID: 14227
		private static readonly IntPtr NativeFieldInfoPtr_gameID;

		// Token: 0x04003794 RID: 14228
		private static readonly IntPtr NativeFieldInfoPtr_saveLocation;

		// Token: 0x04003795 RID: 14229
		private static readonly IntPtr NativeFieldInfoPtr_mouseDownPosition;

		// Token: 0x04003796 RID: 14230
		private static readonly IntPtr NativeFieldInfoPtr__CreatorToken_k__BackingField;

		// Token: 0x04003797 RID: 14231
		private static readonly IntPtr NativeFieldInfoPtr_selectionQueue;

		// Token: 0x04003798 RID: 14232
		private static readonly IntPtr NativeMethodInfoPtr_get_CreatorToken_Public_get_String_0;

		// Token: 0x04003799 RID: 14233
		private static readonly IntPtr NativeMethodInfoPtr_set_CreatorToken_Private_set_Void_String_0;

		// Token: 0x0400379A RID: 14234
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400379B RID: 14235
		private static readonly IntPtr NativeMethodInfoPtr_WantsToQuit_Private_Static_Boolean_0;

		// Token: 0x0400379C RID: 14236
		private static readonly IntPtr NativeMethodInfoPtr_PromptExit_Public_Void_0;

		// Token: 0x0400379D RID: 14237
		private static readonly IntPtr NativeMethodInfoPtr_DoExit_Public_Void_0;

		// Token: 0x0400379E RID: 14238
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400379F RID: 14239
		private static readonly IntPtr NativeMethodInfoPtr_OnPostDragEnd_Private_Void_Gizmo_Int32_0;

		// Token: 0x040037A0 RID: 14240
		private static readonly IntPtr NativeMethodInfoPtr_PropertyGrid_ValueChanged_Private_Void_Object_PropertyInfo_0;

		// Token: 0x040037A1 RID: 14241
		private static readonly IntPtr NativeMethodInfoPtr_GameLoaded_Private_Void_0;

		// Token: 0x040037A2 RID: 14242
		private static readonly IntPtr NativeMethodInfoPtr_OnAppInitialized_Private_Void_0;

		// Token: 0x040037A3 RID: 14243
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040037A4 RID: 14244
		private static readonly IntPtr NativeMethodInfoPtr_DeleteSelection_Public_Void_0;

		// Token: 0x040037A5 RID: 14245
		private static readonly IntPtr NativeMethodInfoPtr_DuplicateSelection_Public_Void_0;

		// Token: 0x040037A6 RID: 14246
		private static readonly IntPtr NativeMethodInfoPtr_SetStatusBarMessage_Public_Void_String_0;

		// Token: 0x040037A7 RID: 14247
		private static readonly IntPtr NativeMethodInfoPtr_CheckToken_Private_IEnumerator_0;

		// Token: 0x040037A8 RID: 14248
		private static readonly IntPtr NativeMethodInfoPtr_GetCommandLineArgs_Private_Dictionary_2_String_String_0;

		// Token: 0x040037A9 RID: 14249
		private static readonly IntPtr NativeMethodInfoPtr_RelaunchCreator_Private_Void_0;

		// Token: 0x040037AA RID: 14250
		private static readonly IntPtr NativeMethodInfoPtr_GroupSelection_Public_Void_0;

		// Token: 0x040037AB RID: 14251
		private static readonly IntPtr NativeMethodInfoPtr_UngroupSelection_Public_Void_0;

		// Token: 0x040037AC RID: 14252
		private static readonly IntPtr NativeMethodInfoPtr_ExportModel_Public_Void_0;

		// Token: 0x040037AD RID: 14253
		private static readonly IntPtr NativeMethodInfoPtr_ShowExportModelDialog_Private_IEnumerator_0;

		// Token: 0x040037AE RID: 14254
		private static readonly IntPtr NativeMethodInfoPtr_DoExportModel_Private_Static_Void_String_0;

		// Token: 0x040037AF RID: 14255
		private static readonly IntPtr NativeMethodInfoPtr_ExportGLTF_Public_Void_0;

		// Token: 0x040037B0 RID: 14256
		private static readonly IntPtr NativeMethodInfoPtr_ShowExportGLTFDialog_Private_IEnumerator_0;

		// Token: 0x040037B1 RID: 14257
		private static readonly IntPtr NativeMethodInfoPtr_DoExportGLTF_Private_Static_Void_String_0;

		// Token: 0x040037B2 RID: 14258
		private static readonly IntPtr NativeMethodInfoPtr_PublishModel_Public_Void_0;

		// Token: 0x040037B3 RID: 14259
		private static readonly IntPtr NativeMethodInfoPtr_DoPublishModel_Private_IEnumerator_0;

		// Token: 0x040037B4 RID: 14260
		private static readonly IntPtr NativeMethodInfoPtr_ImportModel_Public_Void_0;

		// Token: 0x040037B5 RID: 14261
		private static readonly IntPtr NativeMethodInfoPtr_ShowImportModelDialog_Private_IEnumerator_0;

		// Token: 0x040037B6 RID: 14262
		private static readonly IntPtr NativeMethodInfoPtr_DoImportModel_Private_Static_Void_Il2CppStringArray_0;

		// Token: 0x040037B7 RID: 14263
		private static readonly IntPtr NativeMethodInfoPtr_ToolboxModelAdded_Public_Void_Model_0;

		// Token: 0x040037B8 RID: 14264
		private static readonly IntPtr NativeMethodInfoPtr_GetSelectedInstances_Public_Static_List_1_Instance_0;

		// Token: 0x040037B9 RID: 14265
		private static readonly IntPtr NativeMethodInfoPtr_LoadStarterPlaces_Private_IEnumerator_0;

		// Token: 0x040037BA RID: 14266
		private static readonly IntPtr NativeMethodInfoPtr_ClearWorkspace_Public_Void_0;

		// Token: 0x040037BB RID: 14267
		private static readonly IntPtr NativeMethodInfoPtr_CloseStartScreen_Public_Void_0;

		// Token: 0x040037BC RID: 14268
		private static readonly IntPtr NativeMethodInfoPtr_ScriptEditedExternally_Private_Void_Object_FileSystemEventArgs_0;

		// Token: 0x040037BD RID: 14269
		private static readonly IntPtr NativeMethodInfoPtr_EditScript_Private_Void_BaseScript_0;

		// Token: 0x040037BE RID: 14270
		private static readonly IntPtr NativeMethodInfoPtr_PublishGame_Public_Void_0;

		// Token: 0x040037BF RID: 14271
		private static readonly IntPtr NativeMethodInfoPtr_DoPublish_Private_IEnumerator_0;

		// Token: 0x040037C0 RID: 14272
		private static readonly IntPtr NativeMethodInfoPtr_LoadThumbnailImages_Private_IEnumerator_List_1_ThumbnailImageTarget_0;

		// Token: 0x040037C1 RID: 14273
		private static readonly IntPtr NativeMethodInfoPtr_SetPublishModalSelectedGame_Public_Void_JSONNode_0;

		// Token: 0x040037C2 RID: 14274
		private static readonly IntPtr NativeMethodInfoPtr_LoadThumbnailImage_Private_IEnumerator_String_Image_0;

		// Token: 0x040037C3 RID: 14275
		private static readonly IntPtr NativeMethodInfoPtr_chmod_Private_Static_Int32_String_Int32_0;

		// Token: 0x040037C4 RID: 14276
		private static readonly IntPtr NativeMethodInfoPtr_TestGame_Public_Void_0;

		// Token: 0x040037C5 RID: 14277
		private static readonly IntPtr NativeMethodInfoPtr_PublishGameOverwrite_Public_Void_Int32_0;

		// Token: 0x040037C6 RID: 14278
		private static readonly IntPtr NativeMethodInfoPtr_PublishLevelToID_Private_IEnumerator_Int32_0;

		// Token: 0x040037C7 RID: 14279
		private static readonly IntPtr NativeMethodInfoPtr_RandomString_Public_Static_String_Int32_0;

		// Token: 0x040037C8 RID: 14280
		private static readonly IntPtr NativeMethodInfoPtr_FileOpen_Public_Void_0;

		// Token: 0x040037C9 RID: 14281
		private static readonly IntPtr NativeMethodInfoPtr_ShowOpenDialog_Private_IEnumerator_0;

		// Token: 0x040037CA RID: 14282
		private static readonly IntPtr NativeMethodInfoPtr_AutoSaveLoop_Private_IEnumerator_0;

		// Token: 0x040037CB RID: 14283
		private static readonly IntPtr NativeMethodInfoPtr_DoLoadMap_Private_Static_Void_Il2CppStringArray_0;

		// Token: 0x040037CC RID: 14284
		private static readonly IntPtr NativeMethodInfoPtr_LoadMapFromFile_Private_IEnumerator_String_0;

		// Token: 0x040037CD RID: 14285
		private static readonly IntPtr NativeMethodInfoPtr_FileSave_Public_Void_Boolean_0;

		// Token: 0x040037CE RID: 14286
		private static readonly IntPtr NativeMethodInfoPtr_ShowSaveDialog_Private_IEnumerator_0;

		// Token: 0x040037CF RID: 14287
		private static readonly IntPtr NativeMethodInfoPtr_DoSaveFile_Private_Static_Void_String_0;

		// Token: 0x040037D0 RID: 14288
		private static readonly IntPtr NativeMethodInfoPtr_SetMoveSnapEnabled_Public_Void_Boolean_0;

		// Token: 0x040037D1 RID: 14289
		private static readonly IntPtr NativeMethodInfoPtr_SetMoveSnapSize_Public_Void_String_0;

		// Token: 0x040037D2 RID: 14290
		private static readonly IntPtr NativeMethodInfoPtr_SetRotateSnapEnabled_Public_Void_Boolean_0;

		// Token: 0x040037D3 RID: 14291
		private static readonly IntPtr NativeMethodInfoPtr_SetRotateSnapSize_Public_Void_String_0;

		// Token: 0x040037D4 RID: 14292
		private static readonly IntPtr NativeMethodInfoPtr_SetActiveGizmo_Public_Void_String_0;

		// Token: 0x040037D5 RID: 14293
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040037D6 RID: 14294
		private static readonly IntPtr NativeMethodInfoPtr_IsEditingTextField_Private_Boolean_0;

		// Token: 0x040037D7 RID: 14295
		private static readonly IntPtr NativeMethodInfoPtr_GetSelectedInstancesTreeView_Public_List_1_Instance_0;

		// Token: 0x040037D8 RID: 14296
		private static readonly IntPtr NativeMethodInfoPtr_CopySelectionToClipboard_Public_Void_0;

		// Token: 0x040037D9 RID: 14297
		private static readonly IntPtr NativeMethodInfoPtr_CutSelectionToClipboard_Public_Void_0;

		// Token: 0x040037DA RID: 14298
		private static readonly IntPtr NativeMethodInfoPtr_PasteFromClipboard_Public_Void_0;

		// Token: 0x040037DB RID: 14299
		private static readonly IntPtr NativeMethodInfoPtr_ShowContextMenu_Private_Void_0;

		// Token: 0x040037DC RID: 14300
		private static readonly IntPtr NativeMethodInfoPtr_SetPaintColor_Public_Void_Color_0;

		// Token: 0x040037DD RID: 14301
		private static readonly IntPtr NativeMethodInfoPtr_ToggleColorPicker_Public_Void_0;

		// Token: 0x040037DE RID: 14302
		private static readonly IntPtr NativeMethodInfoPtr_ToggleMaterialPicker_Public_Void_0;

		// Token: 0x040037DF RID: 14303
		private static readonly IntPtr NativeMethodInfoPtr_OnItemDataBinding_Private_Void_Object_VirtualizingTreeViewItemDataBindingArgs_0;

		// Token: 0x040037E0 RID: 14304
		private static readonly IntPtr NativeMethodInfoPtr_OnItemBeginDrop_Private_Void_Object_ItemDropCancelArgs_0;

		// Token: 0x040037E1 RID: 14305
		private static readonly IntPtr NativeMethodInfoPtr_OnItemBeginDrag_Private_Void_Object_ItemArgs_0;

		// Token: 0x040037E2 RID: 14306
		private static readonly IntPtr NativeMethodInfoPtr_OnItemEndDrag_Private_Void_Object_ItemArgs_0;

		// Token: 0x040037E3 RID: 14307
		private static readonly IntPtr NativeMethodInfoPtr_OnItemExpanding_Private_Void_Object_VirtualizingItemExpandingArgs_0;

		// Token: 0x040037E4 RID: 14308
		private static readonly IntPtr NativeMethodInfoPtr_OnTreeSelectionChanged_Private_Void_Object_SelectionChangedArgs_0;

		// Token: 0x040037E5 RID: 14309
		private static readonly IntPtr NativeMethodInfoPtr_ChildrenOf_Private_List_1_Instance_Instance_0;

		// Token: 0x040037E6 RID: 14310
		private static readonly IntPtr NativeMethodInfoPtr_OnItemDrop_Private_Void_Object_ItemDropArgs_0;

		// Token: 0x040037E7 RID: 14311
		private static readonly IntPtr NativeMethodInfoPtr_OnItemDoubleClick_Private_Void_Object_ItemArgs_0;

		// Token: 0x040037E8 RID: 14312
		private static readonly IntPtr NativeMethodInfoPtr_OnObjectSelectionChanged_Private_Void_ObjectSelectionChangedEventArgs_0;

		// Token: 0x040037E9 RID: 14313
		private static readonly IntPtr NativeMethodInfoPtr_CloseContextMenu_Public_Void_0;

		// Token: 0x040037EA RID: 14314
		private static readonly IntPtr NativeMethodInfoPtr_AddPart_Public_Void_String_0;

		// Token: 0x040037EB RID: 14315
		private static readonly IntPtr NativeMethodInfoPtr_SelectChildren_Public_Void_0;

		// Token: 0x040037EC RID: 14316
		private static readonly IntPtr NativeMethodInfoPtr_Undo_Public_Void_0;

		// Token: 0x040037ED RID: 14317
		private static readonly IntPtr NativeMethodInfoPtr_Redo_Public_Void_0;

		// Token: 0x040037EE RID: 14318
		private static readonly IntPtr NativeMethodInfoPtr_AddTruss_Public_Void_0;

		// Token: 0x040037EF RID: 14319
		private static readonly IntPtr NativeMethodInfoPtr_AddInstance_Public_Instance_String_Instance_Boolean_0;

		// Token: 0x040037F0 RID: 14320
		private static readonly IntPtr NativeMethodInfoPtr_AddPart_Public_Void_PartShape_String_0;

		// Token: 0x040037F1 RID: 14321
		private static readonly IntPtr NativeMethodInfoPtr_AddScript_Public_Void_0;

		// Token: 0x040037F2 RID: 14322
		private static readonly IntPtr NativeMethodInfoPtr_AddSound_Public_Void_0;

		// Token: 0x040037F3 RID: 14323
		private static readonly IntPtr NativeMethodInfoPtr_AddLocalScript_Public_Void_0;

		// Token: 0x040037F4 RID: 14324
		private static readonly IntPtr NativeMethodInfoPtr_AddModuleScript_Public_Void_0;

		// Token: 0x040037F5 RID: 14325
		private static readonly IntPtr NativeMethodInfoPtr_AddRemoteEvent_Public_Void_0;

		// Token: 0x040037F6 RID: 14326
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Instance_String_String_0;

		// Token: 0x040037F7 RID: 14327
		private static readonly IntPtr NativeMethodInfoPtr_AddUI_Public_Void_String_0;

		// Token: 0x040037F8 RID: 14328
		private static readonly IntPtr NativeMethodInfoPtr_AddSeat_Public_Void_String_0;

		// Token: 0x040037F9 RID: 14329
		private static readonly IntPtr NativeMethodInfoPtr_IsPointerOverUIObject_Public_Static_Boolean_0;

		// Token: 0x040037FA RID: 14330
		private static readonly IntPtr NativeMethodInfoPtr__CheckToken_b__50_0_Private_Void_Boolean_0;

		// Token: 0x040037FB RID: 14331
		private static readonly IntPtr NativeMethodInfoPtr__LoadMapFromFile_b__87_0_Private_Void_Boolean_0;

		// Token: 0x040037FC RID: 14332
		private static readonly IntPtr NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0;

		// Token: 0x02000442 RID: 1090
		public enum PaintType
		{
			// Token: 0x04003F9A RID: 16282
			None,
			// Token: 0x04003F9B RID: 16283
			Color,
			// Token: 0x04003F9C RID: 16284
			Material
		}

		// Token: 0x02000443 RID: 1091
		public sealed class ThumbnailImageTarget : ValueType
		{
			// Token: 0x06005330 RID: 21296 RVA: 0x00161298 File Offset: 0x0015F498
			// Note: this type is marked as 'beforefieldinit'.
			static ThumbnailImageTarget()
			{
				Il2CppClassPointerStore<CreatorController.ThumbnailImageTarget>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, "ThumbnailImageTarget");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreatorController.ThumbnailImageTarget>.NativeClassPtr);
				CreatorController.ThumbnailImageTarget.NativeFieldInfoPtr__Url_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController.ThumbnailImageTarget>.NativeClassPtr, "<Url>k__BackingField");
				CreatorController.ThumbnailImageTarget.NativeFieldInfoPtr__Target_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController.ThumbnailImageTarget>.NativeClassPtr, "<Target>k__BackingField");
				CreatorController.ThumbnailImageTarget.NativeMethodInfoPtr_get_Url_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController.ThumbnailImageTarget>.NativeClassPtr, 100674740);
				CreatorController.ThumbnailImageTarget.NativeMethodInfoPtr_set_Url_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController.ThumbnailImageTarget>.NativeClassPtr, 100674741);
				CreatorController.ThumbnailImageTarget.NativeMethodInfoPtr_get_Target_Public_get_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController.ThumbnailImageTarget>.NativeClassPtr, 100674742);
				CreatorController.ThumbnailImageTarget.NativeMethodInfoPtr_set_Target_Public_set_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController.ThumbnailImageTarget>.NativeClassPtr, 100674743);
			}

			// Token: 0x17001C14 RID: 7188
			// (get) Token: 0x06005331 RID: 21297 RVA: 0x0016133C File Offset: 0x0015F53C
			// (set) Token: 0x06005332 RID: 21298 RVA: 0x00161378 File Offset: 0x0015F578
			public unsafe string Url
			{
				[CallerCount(116)]
				[CachedScanResults(RefRangeStart = 24169, RefRangeEnd = 24285, XrefRangeStart = 24169, XrefRangeEnd = 24285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.ThumbnailImageTarget.NativeMethodInfoPtr_get_Url_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 104073, RefRangeEnd = 104083, XrefRangeStart = 104073, XrefRangeEnd = 104083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.ThumbnailImageTarget.NativeMethodInfoPtr_set_Url_Public_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17001C15 RID: 7189
			// (get) Token: 0x06005333 RID: 21299 RVA: 0x001613C0 File Offset: 0x0015F5C0
			// (set) Token: 0x06005334 RID: 21300 RVA: 0x00161404 File Offset: 0x0015F604
			public unsafe Image Target
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.ThumbnailImageTarget.NativeMethodInfoPtr_get_Target_Public_get_Image_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.ThumbnailImageTarget.NativeMethodInfoPtr_set_Target_Public_set_Void_Image_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06005335 RID: 21301 RVA: 0x00020470 File Offset: 0x0001E670
			public ThumbnailImageTarget(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06005336 RID: 21302 RVA: 0x00020479 File Offset: 0x0001E679
			public ThumbnailImageTarget()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreatorController.ThumbnailImageTarget>.NativeClassPtr))
			{
			}

			// Token: 0x17001C12 RID: 7186
			// (get) Token: 0x06005337 RID: 21303 RVA: 0x0016144C File Offset: 0x0015F64C
			// (set) Token: 0x06005338 RID: 21304 RVA: 0x0002048B File Offset: 0x0001E68B
			public unsafe string _Url_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.ThumbnailImageTarget.NativeFieldInfoPtr__Url_k__BackingField);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.ThumbnailImageTarget.NativeFieldInfoPtr__Url_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001C13 RID: 7187
			// (get) Token: 0x06005339 RID: 21305 RVA: 0x00161474 File Offset: 0x0015F674
			// (set) Token: 0x0600533A RID: 21306 RVA: 0x000204AA File Offset: 0x0001E6AA
			public unsafe Image _Target_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.ThumbnailImageTarget.NativeFieldInfoPtr__Target_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.ThumbnailImageTarget.NativeFieldInfoPtr__Target_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003F9D RID: 16285
			private static readonly IntPtr NativeFieldInfoPtr__Url_k__BackingField;

			// Token: 0x04003F9E RID: 16286
			private static readonly IntPtr NativeFieldInfoPtr__Target_k__BackingField;

			// Token: 0x04003F9F RID: 16287
			private static readonly IntPtr NativeMethodInfoPtr_get_Url_Public_get_String_0;

			// Token: 0x04003FA0 RID: 16288
			private static readonly IntPtr NativeMethodInfoPtr_set_Url_Public_set_Void_String_0;

			// Token: 0x04003FA1 RID: 16289
			private static readonly IntPtr NativeMethodInfoPtr_get_Target_Public_get_Image_0;

			// Token: 0x04003FA2 RID: 16290
			private static readonly IntPtr NativeMethodInfoPtr_set_Target_Public_set_Void_Image_0;
		}

		// Token: 0x02000444 RID: 1092
		[ObfuscatedName("Polytoria.Controllers.CreatorController+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x0600533B RID: 21307 RVA: 0x001614A4 File Offset: 0x0015F6A4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<CreatorController.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreatorController.__c>.NativeClassPtr);
				CreatorController.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController.__c>.NativeClassPtr, "<>9");
				CreatorController.__c.NativeFieldInfoPtr___9__57_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController.__c>.NativeClassPtr, "<>9__57_0");
				CreatorController.__c.NativeFieldInfoPtr___9__79_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController.__c>.NativeClassPtr, "<>9__79_0");
				CreatorController.__c.NativeFieldInfoPtr___9__82_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController.__c>.NativeClassPtr, "<>9__82_0");
				CreatorController.__c.NativeFieldInfoPtr___9__96_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController.__c>.NativeClassPtr, "<>9__96_0");
				CreatorController.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController.__c>.NativeClassPtr, 100674745);
				CreatorController.__c.NativeMethodInfoPtr__DoExportModel_b__57_0_Internal_Boolean_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController.__c>.NativeClassPtr, 100674746);
				CreatorController.__c.NativeMethodInfoPtr__TestGame_b__79_0_Internal_Char_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController.__c>.NativeClassPtr, 100674747);
				CreatorController.__c.NativeMethodInfoPtr__RandomString_b__82_0_Internal_Char_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController.__c>.NativeClassPtr, 100674748);
				CreatorController.__c.NativeMethodInfoPtr__Update_b__96_0_Internal_GameObject_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController.__c>.NativeClassPtr, 100674749);
			}

			// Token: 0x0600533C RID: 21308 RVA: 0x00161598 File Offset: 0x0015F798
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreatorController.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600533D RID: 21309 RVA: 0x001615D4 File Offset: 0x0015F7D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139125, XrefRangeEnd = 139127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DoExportModel_b__57_0(Instance i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(i);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.__c.NativeMethodInfoPtr__DoExportModel_b__57_0_Internal_Boolean_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600533E RID: 21310 RVA: 0x00161624 File Offset: 0x0015F824
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139127, XrefRangeEnd = 139133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe char _TestGame_b__79_0(string s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.__c.NativeMethodInfoPtr__TestGame_b__79_0_Internal_Char_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600533F RID: 21311 RVA: 0x00161674 File Offset: 0x0015F874
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139133, XrefRangeEnd = 139139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe char _RandomString_b__82_0(string s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.__c.NativeMethodInfoPtr__RandomString_b__82_0_Internal_Char_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005340 RID: 21312 RVA: 0x001616C4 File Offset: 0x0015F8C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139139, XrefRangeEnd = 139141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GameObject _Update_b__96_0(Instance i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(i);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.__c.NativeMethodInfoPtr__Update_b__96_0_Internal_GameObject_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
				}
			}

			// Token: 0x06005341 RID: 21313 RVA: 0x000204C9 File Offset: 0x0001E6C9
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001C16 RID: 7190
			// (get) Token: 0x06005342 RID: 21314 RVA: 0x00161714 File Offset: 0x0015F914
			// (set) Token: 0x06005343 RID: 21315 RVA: 0x000204D2 File Offset: 0x0001E6D2
			public unsafe static CreatorController.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CreatorController.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CreatorController.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CreatorController.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C17 RID: 7191
			// (get) Token: 0x06005344 RID: 21316 RVA: 0x0016173C File Offset: 0x0015F93C
			// (set) Token: 0x06005345 RID: 21317 RVA: 0x000204E4 File Offset: 0x0001E6E4
			public unsafe static Func<Instance, bool> __9__57_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CreatorController.__c.NativeFieldInfoPtr___9__57_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Instance, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CreatorController.__c.NativeFieldInfoPtr___9__57_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C18 RID: 7192
			// (get) Token: 0x06005346 RID: 21318 RVA: 0x00161764 File Offset: 0x0015F964
			// (set) Token: 0x06005347 RID: 21319 RVA: 0x000204F6 File Offset: 0x0001E6F6
			public unsafe static Func<string, char> __9__79_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CreatorController.__c.NativeFieldInfoPtr___9__79_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, char>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CreatorController.__c.NativeFieldInfoPtr___9__79_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C19 RID: 7193
			// (get) Token: 0x06005348 RID: 21320 RVA: 0x0016178C File Offset: 0x0015F98C
			// (set) Token: 0x06005349 RID: 21321 RVA: 0x00020508 File Offset: 0x0001E708
			public unsafe static Func<string, char> __9__82_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CreatorController.__c.NativeFieldInfoPtr___9__82_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, char>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CreatorController.__c.NativeFieldInfoPtr___9__82_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C1A RID: 7194
			// (get) Token: 0x0600534A RID: 21322 RVA: 0x001617B4 File Offset: 0x0015F9B4
			// (set) Token: 0x0600534B RID: 21323 RVA: 0x0002051A File Offset: 0x0001E71A
			public unsafe static Func<Instance, GameObject> __9__96_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CreatorController.__c.NativeFieldInfoPtr___9__96_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Instance, GameObject>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CreatorController.__c.NativeFieldInfoPtr___9__96_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003FA3 RID: 16291
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04003FA4 RID: 16292
			private static readonly IntPtr NativeFieldInfoPtr___9__57_0;

			// Token: 0x04003FA5 RID: 16293
			private static readonly IntPtr NativeFieldInfoPtr___9__79_0;

			// Token: 0x04003FA6 RID: 16294
			private static readonly IntPtr NativeFieldInfoPtr___9__82_0;

			// Token: 0x04003FA7 RID: 16295
			private static readonly IntPtr NativeFieldInfoPtr___9__96_0;

			// Token: 0x04003FA8 RID: 16296
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003FA9 RID: 16297
			private static readonly IntPtr NativeMethodInfoPtr__DoExportModel_b__57_0_Internal_Boolean_Instance_0;

			// Token: 0x04003FAA RID: 16298
			private static readonly IntPtr NativeMethodInfoPtr__TestGame_b__79_0_Internal_Char_String_0;

			// Token: 0x04003FAB RID: 16299
			private static readonly IntPtr NativeMethodInfoPtr__RandomString_b__82_0_Internal_Char_String_0;

			// Token: 0x04003FAC RID: 16300
			private static readonly IntPtr NativeMethodInfoPtr__Update_b__96_0_Internal_GameObject_Instance_0;
		}

		// Token: 0x02000445 RID: 1093
		[ObfuscatedName("Polytoria.Controllers.CreatorController+<>c__DisplayClass46_0")]
		public sealed class __c__DisplayClass46_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600534C RID: 21324 RVA: 0x001617DC File Offset: 0x0015F9DC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass46_0()
			{
				Il2CppClassPointerStore<CreatorController.__c__DisplayClass46_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, "<>c__DisplayClass46_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreatorController.__c__DisplayClass46_0>.NativeClassPtr);
				CreatorController.__c__DisplayClass46_0.NativeFieldInfoPtr_mat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController.__c__DisplayClass46_0>.NativeClassPtr, "mat");
				CreatorController.__c__DisplayClass46_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController.__c__DisplayClass46_0>.NativeClassPtr, "<>4__this");
				CreatorController.__c__DisplayClass46_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController.__c__DisplayClass46_0>.NativeClassPtr, 100674750);
				CreatorController.__c__DisplayClass46_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController.__c__DisplayClass46_0>.NativeClassPtr, 100674751);
			}

			// Token: 0x0600534D RID: 21325 RVA: 0x00161858 File Offset: 0x0015FA58
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass46_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreatorController.__c__DisplayClass46_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.__c__DisplayClass46_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600534E RID: 21326 RVA: 0x00161894 File Offset: 0x0015FA94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139141, XrefRangeEnd = 139156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.__c__DisplayClass46_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600534F RID: 21327 RVA: 0x0002052C File Offset: 0x0001E72C
			public __c__DisplayClass46_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001C1B RID: 7195
			// (get) Token: 0x06005350 RID: 21328 RVA: 0x001618C8 File Offset: 0x0015FAC8
			// (set) Token: 0x06005351 RID: 21329 RVA: 0x00020535 File Offset: 0x0001E735
			public unsafe string mat
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.__c__DisplayClass46_0.NativeFieldInfoPtr_mat);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.__c__DisplayClass46_0.NativeFieldInfoPtr_mat), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001C1C RID: 7196
			// (get) Token: 0x06005352 RID: 21330 RVA: 0x001618F0 File Offset: 0x0015FAF0
			// (set) Token: 0x06005353 RID: 21331 RVA: 0x00020554 File Offset: 0x0001E754
			public unsafe CreatorController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.__c__DisplayClass46_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CreatorController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.__c__DisplayClass46_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003FAD RID: 16301
			private static readonly IntPtr NativeFieldInfoPtr_mat;

			// Token: 0x04003FAE RID: 16302
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003FAF RID: 16303
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003FB0 RID: 16304
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__0_Internal_Void_0;
		}

		// Token: 0x02000446 RID: 1094
		[ObfuscatedName("Polytoria.Controllers.CreatorController+<>c__DisplayClass53_0")]
		public sealed class __c__DisplayClass53_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06005354 RID: 21332 RVA: 0x00161920 File Offset: 0x0015FB20
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass53_0()
			{
				Il2CppClassPointerStore<CreatorController.__c__DisplayClass53_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, "<>c__DisplayClass53_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreatorController.__c__DisplayClass53_0>.NativeClassPtr);
				CreatorController.__c__DisplayClass53_0.NativeFieldInfoPtr_lowestLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController.__c__DisplayClass53_0>.NativeClassPtr, "lowestLevel");
				CreatorController.__c__DisplayClass53_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController.__c__DisplayClass53_0>.NativeClassPtr, 100674752);
				CreatorController.__c__DisplayClass53_0.NativeMethodInfoPtr__GroupSelection_b__0_Internal_Boolean_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController.__c__DisplayClass53_0>.NativeClassPtr, 100674753);
			}

			// Token: 0x06005355 RID: 21333 RVA: 0x00161988 File Offset: 0x0015FB88
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass53_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreatorController.__c__DisplayClass53_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.__c__DisplayClass53_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005356 RID: 21334 RVA: 0x001619C4 File Offset: 0x0015FBC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GroupSelection_b__0(Instance i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(i);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.__c__DisplayClass53_0.NativeMethodInfoPtr__GroupSelection_b__0_Internal_Boolean_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005357 RID: 21335 RVA: 0x00020573 File Offset: 0x0001E773
			public __c__DisplayClass53_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001C1D RID: 7197
			// (get) Token: 0x06005358 RID: 21336 RVA: 0x00161A14 File Offset: 0x0015FC14
			// (set) Token: 0x06005359 RID: 21337 RVA: 0x0002057C File Offset: 0x0001E77C
			public unsafe int lowestLevel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.__c__DisplayClass53_0.NativeFieldInfoPtr_lowestLevel);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.__c__DisplayClass53_0.NativeFieldInfoPtr_lowestLevel)) = value;
				}
			}

			// Token: 0x04003FB1 RID: 16305
			private static readonly IntPtr NativeFieldInfoPtr_lowestLevel;

			// Token: 0x04003FB2 RID: 16306
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003FB3 RID: 16307
			private static readonly IntPtr NativeMethodInfoPtr__GroupSelection_b__0_Internal_Boolean_Instance_0;
		}

		// Token: 0x02000447 RID: 1095
		[ObfuscatedName("Polytoria.Controllers.CreatorController+<>c__DisplayClass54_0")]
		public sealed class __c__DisplayClass54_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600535A RID: 21338 RVA: 0x00161A3C File Offset: 0x0015FC3C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass54_0()
			{
				Il2CppClassPointerStore<CreatorController.__c__DisplayClass54_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, "<>c__DisplayClass54_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreatorController.__c__DisplayClass54_0>.NativeClassPtr);
				CreatorController.__c__DisplayClass54_0.NativeFieldInfoPtr_lowestLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController.__c__DisplayClass54_0>.NativeClassPtr, "lowestLevel");
				CreatorController.__c__DisplayClass54_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController.__c__DisplayClass54_0>.NativeClassPtr, 100674754);
				CreatorController.__c__DisplayClass54_0.NativeMethodInfoPtr__UngroupSelection_b__0_Internal_Boolean_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController.__c__DisplayClass54_0>.NativeClassPtr, 100674755);
			}

			// Token: 0x0600535B RID: 21339 RVA: 0x00161AA4 File Offset: 0x0015FCA4
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass54_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreatorController.__c__DisplayClass54_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.__c__DisplayClass54_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600535C RID: 21340 RVA: 0x00161AE0 File Offset: 0x0015FCE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UngroupSelection_b__0(Instance i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(i);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.__c__DisplayClass54_0.NativeMethodInfoPtr__UngroupSelection_b__0_Internal_Boolean_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600535D RID: 21341 RVA: 0x00020597 File Offset: 0x0001E797
			public __c__DisplayClass54_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001C1E RID: 7198
			// (get) Token: 0x0600535E RID: 21342 RVA: 0x00161B30 File Offset: 0x0015FD30
			// (set) Token: 0x0600535F RID: 21343 RVA: 0x000205A0 File Offset: 0x0001E7A0
			public unsafe int lowestLevel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.__c__DisplayClass54_0.NativeFieldInfoPtr_lowestLevel);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.__c__DisplayClass54_0.NativeFieldInfoPtr_lowestLevel)) = value;
				}
			}

			// Token: 0x04003FB4 RID: 16308
			private static readonly IntPtr NativeFieldInfoPtr_lowestLevel;

			// Token: 0x04003FB5 RID: 16309
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003FB6 RID: 16310
			private static readonly IntPtr NativeMethodInfoPtr__UngroupSelection_b__0_Internal_Boolean_Instance_0;
		}

		// Token: 0x02000448 RID: 1096
		[ObfuscatedName("Polytoria.Controllers.CreatorController+<>c__DisplayClass68_0")]
		public sealed class __c__DisplayClass68_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06005360 RID: 21344 RVA: 0x00161B58 File Offset: 0x0015FD58
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass68_0()
			{
				Il2CppClassPointerStore<CreatorController.__c__DisplayClass68_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, "<>c__DisplayClass68_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreatorController.__c__DisplayClass68_0>.NativeClassPtr);
				CreatorController.__c__DisplayClass68_0.NativeFieldInfoPtr_node = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController.__c__DisplayClass68_0>.NativeClassPtr, "node");
				CreatorController.__c__DisplayClass68_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController.__c__DisplayClass68_0>.NativeClassPtr, "<>4__this");
				CreatorController.__c__DisplayClass68_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController.__c__DisplayClass68_0>.NativeClassPtr, 100674756);
				CreatorController.__c__DisplayClass68_0.NativeMethodInfoPtr__LoadStarterPlaces_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController.__c__DisplayClass68_0>.NativeClassPtr, 100674757);
			}

			// Token: 0x06005361 RID: 21345 RVA: 0x00161BD4 File Offset: 0x0015FDD4
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass68_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreatorController.__c__DisplayClass68_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.__c__DisplayClass68_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005362 RID: 21346 RVA: 0x00161C10 File Offset: 0x0015FE10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139156, XrefRangeEnd = 139165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _LoadStarterPlaces_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.__c__DisplayClass68_0.NativeMethodInfoPtr__LoadStarterPlaces_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005363 RID: 21347 RVA: 0x000205BB File Offset: 0x0001E7BB
			public __c__DisplayClass68_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001C1F RID: 7199
			// (get) Token: 0x06005364 RID: 21348 RVA: 0x00161C44 File Offset: 0x0015FE44
			// (set) Token: 0x06005365 RID: 21349 RVA: 0x000205C4 File Offset: 0x0001E7C4
			public unsafe JSONNode node
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.__c__DisplayClass68_0.NativeFieldInfoPtr_node);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.__c__DisplayClass68_0.NativeFieldInfoPtr_node), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C20 RID: 7200
			// (get) Token: 0x06005366 RID: 21350 RVA: 0x00161C74 File Offset: 0x0015FE74
			// (set) Token: 0x06005367 RID: 21351 RVA: 0x000205E3 File Offset: 0x0001E7E3
			public unsafe CreatorController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.__c__DisplayClass68_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CreatorController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.__c__DisplayClass68_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003FB7 RID: 16311
			private static readonly IntPtr NativeFieldInfoPtr_node;

			// Token: 0x04003FB8 RID: 16312
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003FB9 RID: 16313
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003FBA RID: 16314
			private static readonly IntPtr NativeMethodInfoPtr__LoadStarterPlaces_b__0_Internal_Void_0;
		}

		// Token: 0x02000449 RID: 1097
		[ObfuscatedName("Polytoria.Controllers.CreatorController+<>c__DisplayClass68_1")]
		public sealed class __c__DisplayClass68_1 : global::Il2CppSystem.Object
		{
			// Token: 0x06005368 RID: 21352 RVA: 0x00161CA4 File Offset: 0x0015FEA4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass68_1()
			{
				Il2CppClassPointerStore<CreatorController.__c__DisplayClass68_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, "<>c__DisplayClass68_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreatorController.__c__DisplayClass68_1>.NativeClassPtr);
				CreatorController.__c__DisplayClass68_1.NativeFieldInfoPtr_node = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController.__c__DisplayClass68_1>.NativeClassPtr, "node");
				CreatorController.__c__DisplayClass68_1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController.__c__DisplayClass68_1>.NativeClassPtr, "<>4__this");
				CreatorController.__c__DisplayClass68_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController.__c__DisplayClass68_1>.NativeClassPtr, 100674758);
				CreatorController.__c__DisplayClass68_1.NativeMethodInfoPtr__LoadStarterPlaces_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController.__c__DisplayClass68_1>.NativeClassPtr, 100674759);
			}

			// Token: 0x06005369 RID: 21353 RVA: 0x00161D20 File Offset: 0x0015FF20
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass68_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreatorController.__c__DisplayClass68_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.__c__DisplayClass68_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600536A RID: 21354 RVA: 0x00161D5C File Offset: 0x0015FF5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139165, XrefRangeEnd = 139174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _LoadStarterPlaces_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.__c__DisplayClass68_1.NativeMethodInfoPtr__LoadStarterPlaces_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600536B RID: 21355 RVA: 0x00020602 File Offset: 0x0001E802
			public __c__DisplayClass68_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001C21 RID: 7201
			// (get) Token: 0x0600536C RID: 21356 RVA: 0x00161D90 File Offset: 0x0015FF90
			// (set) Token: 0x0600536D RID: 21357 RVA: 0x0002060B File Offset: 0x0001E80B
			public unsafe JSONNode node
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.__c__DisplayClass68_1.NativeFieldInfoPtr_node);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.__c__DisplayClass68_1.NativeFieldInfoPtr_node), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C22 RID: 7202
			// (get) Token: 0x0600536E RID: 21358 RVA: 0x00161DC0 File Offset: 0x0015FFC0
			// (set) Token: 0x0600536F RID: 21359 RVA: 0x0002062A File Offset: 0x0001E82A
			public unsafe CreatorController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.__c__DisplayClass68_1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CreatorController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.__c__DisplayClass68_1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003FBB RID: 16315
			private static readonly IntPtr NativeFieldInfoPtr_node;

			// Token: 0x04003FBC RID: 16316
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003FBD RID: 16317
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003FBE RID: 16318
			private static readonly IntPtr NativeMethodInfoPtr__LoadStarterPlaces_b__1_Internal_Void_0;
		}

		// Token: 0x0200044A RID: 1098
		[ObfuscatedName("Polytoria.Controllers.CreatorController+<>c__DisplayClass74_0")]
		public sealed class __c__DisplayClass74_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06005370 RID: 21360 RVA: 0x00161DF0 File Offset: 0x0015FFF0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass74_0()
			{
				Il2CppClassPointerStore<CreatorController.__c__DisplayClass74_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, "<>c__DisplayClass74_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreatorController.__c__DisplayClass74_0>.NativeClassPtr);
				CreatorController.__c__DisplayClass74_0.NativeFieldInfoPtr_game = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController.__c__DisplayClass74_0>.NativeClassPtr, "game");
				CreatorController.__c__DisplayClass74_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController.__c__DisplayClass74_0>.NativeClassPtr, "<>4__this");
				CreatorController.__c__DisplayClass74_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController.__c__DisplayClass74_0>.NativeClassPtr, 100674760);
				CreatorController.__c__DisplayClass74_0.NativeMethodInfoPtr__DoPublish_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController.__c__DisplayClass74_0>.NativeClassPtr, 100674761);
			}

			// Token: 0x06005371 RID: 21361 RVA: 0x00161E6C File Offset: 0x0016006C
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass74_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreatorController.__c__DisplayClass74_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.__c__DisplayClass74_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005372 RID: 21362 RVA: 0x00161EA8 File Offset: 0x001600A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139174, XrefRangeEnd = 139176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DoPublish_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.__c__DisplayClass74_0.NativeMethodInfoPtr__DoPublish_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005373 RID: 21363 RVA: 0x00020649 File Offset: 0x0001E849
			public __c__DisplayClass74_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001C23 RID: 7203
			// (get) Token: 0x06005374 RID: 21364 RVA: 0x00161EDC File Offset: 0x001600DC
			// (set) Token: 0x06005375 RID: 21365 RVA: 0x00020652 File Offset: 0x0001E852
			public unsafe JSONNode game
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.__c__DisplayClass74_0.NativeFieldInfoPtr_game);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.__c__DisplayClass74_0.NativeFieldInfoPtr_game), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C24 RID: 7204
			// (get) Token: 0x06005376 RID: 21366 RVA: 0x00161F0C File Offset: 0x0016010C
			// (set) Token: 0x06005377 RID: 21367 RVA: 0x00020671 File Offset: 0x0001E871
			public unsafe CreatorController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.__c__DisplayClass74_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CreatorController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.__c__DisplayClass74_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003FBF RID: 16319
			private static readonly IntPtr NativeFieldInfoPtr_game;

			// Token: 0x04003FC0 RID: 16320
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003FC1 RID: 16321
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003FC2 RID: 16322
			private static readonly IntPtr NativeMethodInfoPtr__DoPublish_b__0_Internal_Void_0;
		}

		// Token: 0x0200044B RID: 1099
		[ObfuscatedName("Polytoria.Controllers.CreatorController+<>c__DisplayClass76_0")]
		public sealed class __c__DisplayClass76_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06005378 RID: 21368 RVA: 0x00161F3C File Offset: 0x0016013C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass76_0()
			{
				Il2CppClassPointerStore<CreatorController.__c__DisplayClass76_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, "<>c__DisplayClass76_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreatorController.__c__DisplayClass76_0>.NativeClassPtr);
				CreatorController.__c__DisplayClass76_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController.__c__DisplayClass76_0>.NativeClassPtr, "<>4__this");
				CreatorController.__c__DisplayClass76_0.NativeFieldInfoPtr_game = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController.__c__DisplayClass76_0>.NativeClassPtr, "game");
				CreatorController.__c__DisplayClass76_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController.__c__DisplayClass76_0>.NativeClassPtr, 100674762);
				CreatorController.__c__DisplayClass76_0.NativeMethodInfoPtr__SetPublishModalSelectedGame_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController.__c__DisplayClass76_0>.NativeClassPtr, 100674763);
			}

			// Token: 0x06005379 RID: 21369 RVA: 0x00161FB8 File Offset: 0x001601B8
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass76_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreatorController.__c__DisplayClass76_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.__c__DisplayClass76_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600537A RID: 21370 RVA: 0x00161FF4 File Offset: 0x001601F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139176, XrefRangeEnd = 139200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SetPublishModalSelectedGame_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController.__c__DisplayClass76_0.NativeMethodInfoPtr__SetPublishModalSelectedGame_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600537B RID: 21371 RVA: 0x00020690 File Offset: 0x0001E890
			public __c__DisplayClass76_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001C25 RID: 7205
			// (get) Token: 0x0600537C RID: 21372 RVA: 0x00162028 File Offset: 0x00160228
			// (set) Token: 0x0600537D RID: 21373 RVA: 0x00020699 File Offset: 0x0001E899
			public unsafe CreatorController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.__c__DisplayClass76_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CreatorController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.__c__DisplayClass76_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C26 RID: 7206
			// (get) Token: 0x0600537E RID: 21374 RVA: 0x00162058 File Offset: 0x00160258
			// (set) Token: 0x0600537F RID: 21375 RVA: 0x000206B8 File Offset: 0x0001E8B8
			public unsafe JSONNode game
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.__c__DisplayClass76_0.NativeFieldInfoPtr_game);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JSONNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController.__c__DisplayClass76_0.NativeFieldInfoPtr_game), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003FC3 RID: 16323
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003FC4 RID: 16324
			private static readonly IntPtr NativeFieldInfoPtr_game;

			// Token: 0x04003FC5 RID: 16325
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003FC6 RID: 16326
			private static readonly IntPtr NativeMethodInfoPtr__SetPublishModalSelectedGame_b__0_Internal_Void_0;
		}

		// Token: 0x0200044C RID: 1100
		[ObfuscatedName("Polytoria.Controllers.CreatorController+<AutoSaveLoop>d__85")]
		public sealed class _AutoSaveLoop_d__85 : global::Il2CppSystem.Object
		{
			// Token: 0x06005380 RID: 21376 RVA: 0x00162088 File Offset: 0x00160288
			// Note: this type is marked as 'beforefieldinit'.
			static _AutoSaveLoop_d__85()
			{
				Il2CppClassPointerStore<CreatorController._AutoSaveLoop_d__85>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, "<AutoSaveLoop>d__85");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreatorController._AutoSaveLoop_d__85>.NativeClassPtr);
				CreatorController._AutoSaveLoop_d__85.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController._AutoSaveLoop_d__85>.NativeClassPtr, "<>1__state");
				CreatorController._AutoSaveLoop_d__85.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController._AutoSaveLoop_d__85>.NativeClassPtr, "<>2__current");
				CreatorController._AutoSaveLoop_d__85.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController._AutoSaveLoop_d__85>.NativeClassPtr, "<>4__this");
				CreatorController._AutoSaveLoop_d__85.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._AutoSaveLoop_d__85>.NativeClassPtr, 100674767);
				CreatorController._AutoSaveLoop_d__85.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._AutoSaveLoop_d__85>.NativeClassPtr, 100674769);
				CreatorController._AutoSaveLoop_d__85.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._AutoSaveLoop_d__85>.NativeClassPtr, 100674764);
				CreatorController._AutoSaveLoop_d__85.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._AutoSaveLoop_d__85>.NativeClassPtr, 100674765);
				CreatorController._AutoSaveLoop_d__85.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._AutoSaveLoop_d__85>.NativeClassPtr, 100674766);
				CreatorController._AutoSaveLoop_d__85.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._AutoSaveLoop_d__85>.NativeClassPtr, 100674768);
			}

			// Token: 0x17001C2A RID: 7210
			// (get) Token: 0x06005381 RID: 21377 RVA: 0x00162168 File Offset: 0x00160368
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._AutoSaveLoop_d__85.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001C2B RID: 7211
			// (get) Token: 0x06005382 RID: 21378 RVA: 0x001621A8 File Offset: 0x001603A8
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._AutoSaveLoop_d__85.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005383 RID: 21379 RVA: 0x001621E8 File Offset: 0x001603E8
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 10168, RefRangeEnd = 10216, XrefRangeStart = 10168, XrefRangeEnd = 10216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _AutoSaveLoop_d__85(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreatorController._AutoSaveLoop_d__85>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._AutoSaveLoop_d__85.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005384 RID: 21380 RVA: 0x00162230 File Offset: 0x00160430
			[CallerCount(7535)]
			[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._AutoSaveLoop_d__85.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005385 RID: 21381 RVA: 0x00162264 File Offset: 0x00160464
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139200, XrefRangeEnd = 139215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._AutoSaveLoop_d__85.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005386 RID: 21382 RVA: 0x001622A0 File Offset: 0x001604A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139215, XrefRangeEnd = 139220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._AutoSaveLoop_d__85.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005387 RID: 21383 RVA: 0x000206D7 File Offset: 0x0001E8D7
			public _AutoSaveLoop_d__85(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001C27 RID: 7207
			// (get) Token: 0x06005388 RID: 21384 RVA: 0x001622D4 File Offset: 0x001604D4
			// (set) Token: 0x06005389 RID: 21385 RVA: 0x000206E0 File Offset: 0x0001E8E0
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._AutoSaveLoop_d__85.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._AutoSaveLoop_d__85.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001C28 RID: 7208
			// (get) Token: 0x0600538A RID: 21386 RVA: 0x001622FC File Offset: 0x001604FC
			// (set) Token: 0x0600538B RID: 21387 RVA: 0x000206FB File Offset: 0x0001E8FB
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._AutoSaveLoop_d__85.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._AutoSaveLoop_d__85.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C29 RID: 7209
			// (get) Token: 0x0600538C RID: 21388 RVA: 0x0016232C File Offset: 0x0016052C
			// (set) Token: 0x0600538D RID: 21389 RVA: 0x0002071A File Offset: 0x0001E91A
			public unsafe CreatorController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._AutoSaveLoop_d__85.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CreatorController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._AutoSaveLoop_d__85.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003FC7 RID: 16327
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003FC8 RID: 16328
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003FC9 RID: 16329
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003FCA RID: 16330
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003FCB RID: 16331
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003FCC RID: 16332
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003FCD RID: 16333
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003FCE RID: 16334
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003FCF RID: 16335
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}

		// Token: 0x0200044D RID: 1101
		[ObfuscatedName("Polytoria.Controllers.CreatorController+<CheckToken>d__50")]
		public sealed class _CheckToken_d__50 : global::Il2CppSystem.Object
		{
			// Token: 0x0600538E RID: 21390 RVA: 0x0016235C File Offset: 0x0016055C
			// Note: this type is marked as 'beforefieldinit'.
			static _CheckToken_d__50()
			{
				Il2CppClassPointerStore<CreatorController._CheckToken_d__50>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, "<CheckToken>d__50");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreatorController._CheckToken_d__50>.NativeClassPtr);
				CreatorController._CheckToken_d__50.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController._CheckToken_d__50>.NativeClassPtr, "<>1__state");
				CreatorController._CheckToken_d__50.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController._CheckToken_d__50>.NativeClassPtr, "<>2__current");
				CreatorController._CheckToken_d__50.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController._CheckToken_d__50>.NativeClassPtr, "<>4__this");
				CreatorController._CheckToken_d__50.NativeFieldInfoPtr__uwr_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController._CheckToken_d__50>.NativeClassPtr, "<uwr>5__2");
				CreatorController._CheckToken_d__50.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._CheckToken_d__50>.NativeClassPtr, 100674774);
				CreatorController._CheckToken_d__50.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._CheckToken_d__50>.NativeClassPtr, 100674776);
				CreatorController._CheckToken_d__50.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._CheckToken_d__50>.NativeClassPtr, 100674770);
				CreatorController._CheckToken_d__50.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._CheckToken_d__50>.NativeClassPtr, 100674771);
				CreatorController._CheckToken_d__50.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._CheckToken_d__50>.NativeClassPtr, 100674772);
				CreatorController._CheckToken_d__50.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._CheckToken_d__50>.NativeClassPtr, 100674773);
				CreatorController._CheckToken_d__50.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._CheckToken_d__50>.NativeClassPtr, 100674775);
			}

			// Token: 0x17001C30 RID: 7216
			// (get) Token: 0x0600538F RID: 21391 RVA: 0x00162464 File Offset: 0x00160664
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._CheckToken_d__50.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001C31 RID: 7217
			// (get) Token: 0x06005390 RID: 21392 RVA: 0x001624A4 File Offset: 0x001606A4
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._CheckToken_d__50.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005391 RID: 21393 RVA: 0x001624E4 File Offset: 0x001606E4
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 10168, RefRangeEnd = 10216, XrefRangeStart = 10168, XrefRangeEnd = 10216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _CheckToken_d__50(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreatorController._CheckToken_d__50>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._CheckToken_d__50.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005392 RID: 21394 RVA: 0x0016252C File Offset: 0x0016072C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139220, XrefRangeEnd = 139225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._CheckToken_d__50.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005393 RID: 21395 RVA: 0x00162560 File Offset: 0x00160760
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139225, XrefRangeEnd = 139304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._CheckToken_d__50.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005394 RID: 21396 RVA: 0x0016259C File Offset: 0x0016079C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 139307, RefRangeEnd = 139308, XrefRangeStart = 139304, XrefRangeEnd = 139307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._CheckToken_d__50.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005395 RID: 21397 RVA: 0x001625D0 File Offset: 0x001607D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139308, XrefRangeEnd = 139313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._CheckToken_d__50.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005396 RID: 21398 RVA: 0x00020739 File Offset: 0x0001E939
			public _CheckToken_d__50(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001C2C RID: 7212
			// (get) Token: 0x06005397 RID: 21399 RVA: 0x00162604 File Offset: 0x00160804
			// (set) Token: 0x06005398 RID: 21400 RVA: 0x00020742 File Offset: 0x0001E942
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._CheckToken_d__50.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._CheckToken_d__50.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001C2D RID: 7213
			// (get) Token: 0x06005399 RID: 21401 RVA: 0x0016262C File Offset: 0x0016082C
			// (set) Token: 0x0600539A RID: 21402 RVA: 0x0002075D File Offset: 0x0001E95D
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._CheckToken_d__50.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._CheckToken_d__50.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C2E RID: 7214
			// (get) Token: 0x0600539B RID: 21403 RVA: 0x0016265C File Offset: 0x0016085C
			// (set) Token: 0x0600539C RID: 21404 RVA: 0x0002077C File Offset: 0x0001E97C
			public unsafe CreatorController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._CheckToken_d__50.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CreatorController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._CheckToken_d__50.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C2F RID: 7215
			// (get) Token: 0x0600539D RID: 21405 RVA: 0x0016268C File Offset: 0x0016088C
			// (set) Token: 0x0600539E RID: 21406 RVA: 0x0002079B File Offset: 0x0001E99B
			public unsafe UnityWebRequest _uwr_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._CheckToken_d__50.NativeFieldInfoPtr__uwr_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._CheckToken_d__50.NativeFieldInfoPtr__uwr_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003FD0 RID: 16336
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003FD1 RID: 16337
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003FD2 RID: 16338
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003FD3 RID: 16339
			private static readonly IntPtr NativeFieldInfoPtr__uwr_5__2;

			// Token: 0x04003FD4 RID: 16340
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003FD5 RID: 16341
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003FD6 RID: 16342
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003FD7 RID: 16343
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003FD8 RID: 16344
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003FD9 RID: 16345
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04003FDA RID: 16346
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}

		// Token: 0x0200044E RID: 1102
		[ObfuscatedName("Polytoria.Controllers.CreatorController+<DoPublish>d__74")]
		public sealed class _DoPublish_d__74 : global::Il2CppSystem.Object
		{
			// Token: 0x0600539F RID: 21407 RVA: 0x001626BC File Offset: 0x001608BC
			// Note: this type is marked as 'beforefieldinit'.
			static _DoPublish_d__74()
			{
				Il2CppClassPointerStore<CreatorController._DoPublish_d__74>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, "<DoPublish>d__74");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreatorController._DoPublish_d__74>.NativeClassPtr);
				CreatorController._DoPublish_d__74.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController._DoPublish_d__74>.NativeClassPtr, "<>1__state");
				CreatorController._DoPublish_d__74.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController._DoPublish_d__74>.NativeClassPtr, "<>2__current");
				CreatorController._DoPublish_d__74.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController._DoPublish_d__74>.NativeClassPtr, "<>4__this");
				CreatorController._DoPublish_d__74.NativeFieldInfoPtr__uwr_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController._DoPublish_d__74>.NativeClassPtr, "<uwr>5__2");
				CreatorController._DoPublish_d__74.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._DoPublish_d__74>.NativeClassPtr, 100674781);
				CreatorController._DoPublish_d__74.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._DoPublish_d__74>.NativeClassPtr, 100674783);
				CreatorController._DoPublish_d__74.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._DoPublish_d__74>.NativeClassPtr, 100674777);
				CreatorController._DoPublish_d__74.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._DoPublish_d__74>.NativeClassPtr, 100674778);
				CreatorController._DoPublish_d__74.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._DoPublish_d__74>.NativeClassPtr, 100674779);
				CreatorController._DoPublish_d__74.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._DoPublish_d__74>.NativeClassPtr, 100674780);
				CreatorController._DoPublish_d__74.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._DoPublish_d__74>.NativeClassPtr, 100674782);
			}

			// Token: 0x17001C36 RID: 7222
			// (get) Token: 0x060053A0 RID: 21408 RVA: 0x001627C4 File Offset: 0x001609C4
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._DoPublish_d__74.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001C37 RID: 7223
			// (get) Token: 0x060053A1 RID: 21409 RVA: 0x00162804 File Offset: 0x00160A04
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._DoPublish_d__74.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060053A2 RID: 21410 RVA: 0x00162844 File Offset: 0x00160A44
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 10168, RefRangeEnd = 10216, XrefRangeStart = 10168, XrefRangeEnd = 10216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DoPublish_d__74(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreatorController._DoPublish_d__74>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._DoPublish_d__74.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060053A3 RID: 21411 RVA: 0x0016288C File Offset: 0x00160A8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139313, XrefRangeEnd = 139318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._DoPublish_d__74.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060053A4 RID: 21412 RVA: 0x001628C0 File Offset: 0x00160AC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139318, XrefRangeEnd = 139449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._DoPublish_d__74.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060053A5 RID: 21413 RVA: 0x001628FC File Offset: 0x00160AFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139449, XrefRangeEnd = 139452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._DoPublish_d__74.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060053A6 RID: 21414 RVA: 0x00162930 File Offset: 0x00160B30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139452, XrefRangeEnd = 139457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._DoPublish_d__74.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060053A7 RID: 21415 RVA: 0x000207BA File Offset: 0x0001E9BA
			public _DoPublish_d__74(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001C32 RID: 7218
			// (get) Token: 0x060053A8 RID: 21416 RVA: 0x00162964 File Offset: 0x00160B64
			// (set) Token: 0x060053A9 RID: 21417 RVA: 0x000207C3 File Offset: 0x0001E9C3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._DoPublish_d__74.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._DoPublish_d__74.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001C33 RID: 7219
			// (get) Token: 0x060053AA RID: 21418 RVA: 0x0016298C File Offset: 0x00160B8C
			// (set) Token: 0x060053AB RID: 21419 RVA: 0x000207DE File Offset: 0x0001E9DE
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._DoPublish_d__74.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._DoPublish_d__74.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C34 RID: 7220
			// (get) Token: 0x060053AC RID: 21420 RVA: 0x001629BC File Offset: 0x00160BBC
			// (set) Token: 0x060053AD RID: 21421 RVA: 0x000207FD File Offset: 0x0001E9FD
			public unsafe CreatorController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._DoPublish_d__74.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CreatorController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._DoPublish_d__74.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C35 RID: 7221
			// (get) Token: 0x060053AE RID: 21422 RVA: 0x001629EC File Offset: 0x00160BEC
			// (set) Token: 0x060053AF RID: 21423 RVA: 0x0002081C File Offset: 0x0001EA1C
			public unsafe UnityWebRequest _uwr_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._DoPublish_d__74.NativeFieldInfoPtr__uwr_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._DoPublish_d__74.NativeFieldInfoPtr__uwr_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003FDB RID: 16347
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003FDC RID: 16348
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003FDD RID: 16349
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003FDE RID: 16350
			private static readonly IntPtr NativeFieldInfoPtr__uwr_5__2;

			// Token: 0x04003FDF RID: 16351
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003FE0 RID: 16352
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003FE1 RID: 16353
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003FE2 RID: 16354
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003FE3 RID: 16355
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003FE4 RID: 16356
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04003FE5 RID: 16357
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}

		// Token: 0x0200044F RID: 1103
		[ObfuscatedName("Polytoria.Controllers.CreatorController+<DoPublishModel>d__62")]
		public sealed class _DoPublishModel_d__62 : global::Il2CppSystem.Object
		{
			// Token: 0x060053B0 RID: 21424 RVA: 0x00162A1C File Offset: 0x00160C1C
			// Note: this type is marked as 'beforefieldinit'.
			static _DoPublishModel_d__62()
			{
				Il2CppClassPointerStore<CreatorController._DoPublishModel_d__62>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, "<DoPublishModel>d__62");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreatorController._DoPublishModel_d__62>.NativeClassPtr);
				CreatorController._DoPublishModel_d__62.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController._DoPublishModel_d__62>.NativeClassPtr, "<>1__state");
				CreatorController._DoPublishModel_d__62.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController._DoPublishModel_d__62>.NativeClassPtr, "<>2__current");
				CreatorController._DoPublishModel_d__62.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController._DoPublishModel_d__62>.NativeClassPtr, "<>4__this");
				CreatorController._DoPublishModel_d__62.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController._DoPublishModel_d__62>.NativeClassPtr, "<>7__wrap1");
				CreatorController._DoPublishModel_d__62.NativeFieldInfoPtr__uwr_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController._DoPublishModel_d__62>.NativeClassPtr, "<uwr>5__3");
				CreatorController._DoPublishModel_d__62.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._DoPublishModel_d__62>.NativeClassPtr, 100674789);
				CreatorController._DoPublishModel_d__62.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._DoPublishModel_d__62>.NativeClassPtr, 100674791);
				CreatorController._DoPublishModel_d__62.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._DoPublishModel_d__62>.NativeClassPtr, 100674784);
				CreatorController._DoPublishModel_d__62.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._DoPublishModel_d__62>.NativeClassPtr, 100674785);
				CreatorController._DoPublishModel_d__62.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._DoPublishModel_d__62>.NativeClassPtr, 100674786);
				CreatorController._DoPublishModel_d__62.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._DoPublishModel_d__62>.NativeClassPtr, 100674787);
				CreatorController._DoPublishModel_d__62.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._DoPublishModel_d__62>.NativeClassPtr, 100674788);
				CreatorController._DoPublishModel_d__62.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._DoPublishModel_d__62>.NativeClassPtr, 100674790);
			}

			// Token: 0x17001C3D RID: 7229
			// (get) Token: 0x060053B1 RID: 21425 RVA: 0x00162B4C File Offset: 0x00160D4C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._DoPublishModel_d__62.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001C3E RID: 7230
			// (get) Token: 0x060053B2 RID: 21426 RVA: 0x00162B8C File Offset: 0x00160D8C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._DoPublishModel_d__62.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060053B3 RID: 21427 RVA: 0x00162BCC File Offset: 0x00160DCC
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 10168, RefRangeEnd = 10216, XrefRangeStart = 10168, XrefRangeEnd = 10216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DoPublishModel_d__62(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreatorController._DoPublishModel_d__62>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._DoPublishModel_d__62.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060053B4 RID: 21428 RVA: 0x00162C14 File Offset: 0x00160E14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139457, XrefRangeEnd = 139470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._DoPublishModel_d__62.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060053B5 RID: 21429 RVA: 0x00162C48 File Offset: 0x00160E48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139470, XrefRangeEnd = 139559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._DoPublishModel_d__62.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060053B6 RID: 21430 RVA: 0x00162C84 File Offset: 0x00160E84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139559, XrefRangeEnd = 139562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._DoPublishModel_d__62.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060053B7 RID: 21431 RVA: 0x00162CB8 File Offset: 0x00160EB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139562, XrefRangeEnd = 139565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._DoPublishModel_d__62.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060053B8 RID: 21432 RVA: 0x00162CEC File Offset: 0x00160EEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139565, XrefRangeEnd = 139570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._DoPublishModel_d__62.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060053B9 RID: 21433 RVA: 0x0002083B File Offset: 0x0001EA3B
			public _DoPublishModel_d__62(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001C38 RID: 7224
			// (get) Token: 0x060053BA RID: 21434 RVA: 0x00162D20 File Offset: 0x00160F20
			// (set) Token: 0x060053BB RID: 21435 RVA: 0x00020844 File Offset: 0x0001EA44
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._DoPublishModel_d__62.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._DoPublishModel_d__62.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001C39 RID: 7225
			// (get) Token: 0x060053BC RID: 21436 RVA: 0x00162D48 File Offset: 0x00160F48
			// (set) Token: 0x060053BD RID: 21437 RVA: 0x0002085F File Offset: 0x0001EA5F
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._DoPublishModel_d__62.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._DoPublishModel_d__62.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C3A RID: 7226
			// (get) Token: 0x060053BE RID: 21438 RVA: 0x00162D78 File Offset: 0x00160F78
			// (set) Token: 0x060053BF RID: 21439 RVA: 0x0002087E File Offset: 0x0001EA7E
			public unsafe CreatorController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._DoPublishModel_d__62.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CreatorController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._DoPublishModel_d__62.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C3B RID: 7227
			// (get) Token: 0x060053C0 RID: 21440 RVA: 0x00162DA8 File Offset: 0x00160FA8
			// (set) Token: 0x060053C1 RID: 21441 RVA: 0x0002089D File Offset: 0x0001EA9D
			public unsafe List<Instance>.Enumerator __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._DoPublishModel_d__62.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Instance>.Enumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._DoPublishModel_d__62.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C3C RID: 7228
			// (get) Token: 0x060053C2 RID: 21442 RVA: 0x00162DD8 File Offset: 0x00160FD8
			// (set) Token: 0x060053C3 RID: 21443 RVA: 0x000208BC File Offset: 0x0001EABC
			public unsafe UnityWebRequest _uwr_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._DoPublishModel_d__62.NativeFieldInfoPtr__uwr_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._DoPublishModel_d__62.NativeFieldInfoPtr__uwr_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003FE6 RID: 16358
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003FE7 RID: 16359
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003FE8 RID: 16360
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003FE9 RID: 16361
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04003FEA RID: 16362
			private static readonly IntPtr NativeFieldInfoPtr__uwr_5__3;

			// Token: 0x04003FEB RID: 16363
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003FEC RID: 16364
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003FED RID: 16365
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003FEE RID: 16366
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003FEF RID: 16367
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003FF0 RID: 16368
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04003FF1 RID: 16369
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x04003FF2 RID: 16370
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}

		// Token: 0x02000450 RID: 1104
		[ObfuscatedName("Polytoria.Controllers.CreatorController+<LoadMapFromFile>d__87")]
		public sealed class _LoadMapFromFile_d__87 : global::Il2CppSystem.Object
		{
			// Token: 0x060053C4 RID: 21444 RVA: 0x00162E08 File Offset: 0x00161008
			// Note: this type is marked as 'beforefieldinit'.
			static _LoadMapFromFile_d__87()
			{
				Il2CppClassPointerStore<CreatorController._LoadMapFromFile_d__87>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, "<LoadMapFromFile>d__87");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreatorController._LoadMapFromFile_d__87>.NativeClassPtr);
				CreatorController._LoadMapFromFile_d__87.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController._LoadMapFromFile_d__87>.NativeClassPtr, "<>1__state");
				CreatorController._LoadMapFromFile_d__87.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController._LoadMapFromFile_d__87>.NativeClassPtr, "<>2__current");
				CreatorController._LoadMapFromFile_d__87.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController._LoadMapFromFile_d__87>.NativeClassPtr, "<>4__this");
				CreatorController._LoadMapFromFile_d__87.NativeFieldInfoPtr_path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController._LoadMapFromFile_d__87>.NativeClassPtr, "path");
				CreatorController._LoadMapFromFile_d__87.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._LoadMapFromFile_d__87>.NativeClassPtr, 100674795);
				CreatorController._LoadMapFromFile_d__87.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._LoadMapFromFile_d__87>.NativeClassPtr, 100674797);
				CreatorController._LoadMapFromFile_d__87.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._LoadMapFromFile_d__87>.NativeClassPtr, 100674792);
				CreatorController._LoadMapFromFile_d__87.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._LoadMapFromFile_d__87>.NativeClassPtr, 100674793);
				CreatorController._LoadMapFromFile_d__87.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._LoadMapFromFile_d__87>.NativeClassPtr, 100674794);
				CreatorController._LoadMapFromFile_d__87.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._LoadMapFromFile_d__87>.NativeClassPtr, 100674796);
			}

			// Token: 0x17001C43 RID: 7235
			// (get) Token: 0x060053C5 RID: 21445 RVA: 0x00162EFC File Offset: 0x001610FC
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._LoadMapFromFile_d__87.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001C44 RID: 7236
			// (get) Token: 0x060053C6 RID: 21446 RVA: 0x00162F3C File Offset: 0x0016113C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._LoadMapFromFile_d__87.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060053C7 RID: 21447 RVA: 0x00162F7C File Offset: 0x0016117C
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 10168, RefRangeEnd = 10216, XrefRangeStart = 10168, XrefRangeEnd = 10216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _LoadMapFromFile_d__87(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreatorController._LoadMapFromFile_d__87>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._LoadMapFromFile_d__87.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060053C8 RID: 21448 RVA: 0x00162FC4 File Offset: 0x001611C4
			[CallerCount(7535)]
			[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._LoadMapFromFile_d__87.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060053C9 RID: 21449 RVA: 0x00162FF8 File Offset: 0x001611F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139570, XrefRangeEnd = 139593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._LoadMapFromFile_d__87.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060053CA RID: 21450 RVA: 0x00163034 File Offset: 0x00161234
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139593, XrefRangeEnd = 139598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._LoadMapFromFile_d__87.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060053CB RID: 21451 RVA: 0x000208DB File Offset: 0x0001EADB
			public _LoadMapFromFile_d__87(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001C3F RID: 7231
			// (get) Token: 0x060053CC RID: 21452 RVA: 0x00163068 File Offset: 0x00161268
			// (set) Token: 0x060053CD RID: 21453 RVA: 0x000208E4 File Offset: 0x0001EAE4
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._LoadMapFromFile_d__87.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._LoadMapFromFile_d__87.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001C40 RID: 7232
			// (get) Token: 0x060053CE RID: 21454 RVA: 0x00163090 File Offset: 0x00161290
			// (set) Token: 0x060053CF RID: 21455 RVA: 0x000208FF File Offset: 0x0001EAFF
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._LoadMapFromFile_d__87.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._LoadMapFromFile_d__87.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C41 RID: 7233
			// (get) Token: 0x060053D0 RID: 21456 RVA: 0x001630C0 File Offset: 0x001612C0
			// (set) Token: 0x060053D1 RID: 21457 RVA: 0x0002091E File Offset: 0x0001EB1E
			public unsafe CreatorController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._LoadMapFromFile_d__87.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CreatorController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._LoadMapFromFile_d__87.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C42 RID: 7234
			// (get) Token: 0x060053D2 RID: 21458 RVA: 0x001630F0 File Offset: 0x001612F0
			// (set) Token: 0x060053D3 RID: 21459 RVA: 0x0002093D File Offset: 0x0001EB3D
			public unsafe string path
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._LoadMapFromFile_d__87.NativeFieldInfoPtr_path);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._LoadMapFromFile_d__87.NativeFieldInfoPtr_path), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04003FF3 RID: 16371
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003FF4 RID: 16372
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003FF5 RID: 16373
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003FF6 RID: 16374
			private static readonly IntPtr NativeFieldInfoPtr_path;

			// Token: 0x04003FF7 RID: 16375
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003FF8 RID: 16376
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003FF9 RID: 16377
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003FFA RID: 16378
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003FFB RID: 16379
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003FFC RID: 16380
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}

		// Token: 0x02000451 RID: 1105
		[ObfuscatedName("Polytoria.Controllers.CreatorController+<LoadStarterPlaces>d__68")]
		public sealed class _LoadStarterPlaces_d__68 : global::Il2CppSystem.Object
		{
			// Token: 0x060053D4 RID: 21460 RVA: 0x00163118 File Offset: 0x00161318
			// Note: this type is marked as 'beforefieldinit'.
			static _LoadStarterPlaces_d__68()
			{
				Il2CppClassPointerStore<CreatorController._LoadStarterPlaces_d__68>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, "<LoadStarterPlaces>d__68");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreatorController._LoadStarterPlaces_d__68>.NativeClassPtr);
				CreatorController._LoadStarterPlaces_d__68.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController._LoadStarterPlaces_d__68>.NativeClassPtr, "<>1__state");
				CreatorController._LoadStarterPlaces_d__68.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController._LoadStarterPlaces_d__68>.NativeClassPtr, "<>2__current");
				CreatorController._LoadStarterPlaces_d__68.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController._LoadStarterPlaces_d__68>.NativeClassPtr, "<>4__this");
				CreatorController._LoadStarterPlaces_d__68.NativeFieldInfoPtr__images_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController._LoadStarterPlaces_d__68>.NativeClassPtr, "<images>5__2");
				CreatorController._LoadStarterPlaces_d__68.NativeFieldInfoPtr__template_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController._LoadStarterPlaces_d__68>.NativeClassPtr, "<template>5__3");
				CreatorController._LoadStarterPlaces_d__68.NativeFieldInfoPtr__uwr_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController._LoadStarterPlaces_d__68>.NativeClassPtr, "<uwr>5__4");
				CreatorController._LoadStarterPlaces_d__68.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._LoadStarterPlaces_d__68>.NativeClassPtr, 100674803);
				CreatorController._LoadStarterPlaces_d__68.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._LoadStarterPlaces_d__68>.NativeClassPtr, 100674805);
				CreatorController._LoadStarterPlaces_d__68.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._LoadStarterPlaces_d__68>.NativeClassPtr, 100674798);
				CreatorController._LoadStarterPlaces_d__68.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._LoadStarterPlaces_d__68>.NativeClassPtr, 100674799);
				CreatorController._LoadStarterPlaces_d__68.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._LoadStarterPlaces_d__68>.NativeClassPtr, 100674800);
				CreatorController._LoadStarterPlaces_d__68.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._LoadStarterPlaces_d__68>.NativeClassPtr, 100674801);
				CreatorController._LoadStarterPlaces_d__68.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._LoadStarterPlaces_d__68>.NativeClassPtr, 100674802);
				CreatorController._LoadStarterPlaces_d__68.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._LoadStarterPlaces_d__68>.NativeClassPtr, 100674804);
			}

			// Token: 0x17001C4B RID: 7243
			// (get) Token: 0x060053D5 RID: 21461 RVA: 0x0016325C File Offset: 0x0016145C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._LoadStarterPlaces_d__68.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001C4C RID: 7244
			// (get) Token: 0x060053D6 RID: 21462 RVA: 0x0016329C File Offset: 0x0016149C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._LoadStarterPlaces_d__68.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060053D7 RID: 21463 RVA: 0x001632DC File Offset: 0x001614DC
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 10168, RefRangeEnd = 10216, XrefRangeStart = 10168, XrefRangeEnd = 10216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _LoadStarterPlaces_d__68(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreatorController._LoadStarterPlaces_d__68>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._LoadStarterPlaces_d__68.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060053D8 RID: 21464 RVA: 0x00163324 File Offset: 0x00161524
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139598, XrefRangeEnd = 139608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._LoadStarterPlaces_d__68.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060053D9 RID: 21465 RVA: 0x00163358 File Offset: 0x00161558
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139608, XrefRangeEnd = 139783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._LoadStarterPlaces_d__68.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060053DA RID: 21466 RVA: 0x00163394 File Offset: 0x00161594
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139783, XrefRangeEnd = 139786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._LoadStarterPlaces_d__68.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060053DB RID: 21467 RVA: 0x001633C8 File Offset: 0x001615C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139786, XrefRangeEnd = 139789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._LoadStarterPlaces_d__68.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060053DC RID: 21468 RVA: 0x001633FC File Offset: 0x001615FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139789, XrefRangeEnd = 139794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._LoadStarterPlaces_d__68.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060053DD RID: 21469 RVA: 0x0002095C File Offset: 0x0001EB5C
			public _LoadStarterPlaces_d__68(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001C45 RID: 7237
			// (get) Token: 0x060053DE RID: 21470 RVA: 0x00163430 File Offset: 0x00161630
			// (set) Token: 0x060053DF RID: 21471 RVA: 0x00020965 File Offset: 0x0001EB65
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._LoadStarterPlaces_d__68.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._LoadStarterPlaces_d__68.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001C46 RID: 7238
			// (get) Token: 0x060053E0 RID: 21472 RVA: 0x00163458 File Offset: 0x00161658
			// (set) Token: 0x060053E1 RID: 21473 RVA: 0x00020980 File Offset: 0x0001EB80
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._LoadStarterPlaces_d__68.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._LoadStarterPlaces_d__68.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C47 RID: 7239
			// (get) Token: 0x060053E2 RID: 21474 RVA: 0x00163488 File Offset: 0x00161688
			// (set) Token: 0x060053E3 RID: 21475 RVA: 0x0002099F File Offset: 0x0001EB9F
			public unsafe CreatorController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._LoadStarterPlaces_d__68.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CreatorController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._LoadStarterPlaces_d__68.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C48 RID: 7240
			// (get) Token: 0x060053E4 RID: 21476 RVA: 0x001634B8 File Offset: 0x001616B8
			// (set) Token: 0x060053E5 RID: 21477 RVA: 0x000209BE File Offset: 0x0001EBBE
			public unsafe List<CreatorController.ThumbnailImageTarget> _images_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._LoadStarterPlaces_d__68.NativeFieldInfoPtr__images_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CreatorController.ThumbnailImageTarget>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._LoadStarterPlaces_d__68.NativeFieldInfoPtr__images_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C49 RID: 7241
			// (get) Token: 0x060053E6 RID: 21478 RVA: 0x001634E8 File Offset: 0x001616E8
			// (set) Token: 0x060053E7 RID: 21479 RVA: 0x000209DD File Offset: 0x0001EBDD
			public unsafe RectTransform _template_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._LoadStarterPlaces_d__68.NativeFieldInfoPtr__template_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._LoadStarterPlaces_d__68.NativeFieldInfoPtr__template_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C4A RID: 7242
			// (get) Token: 0x060053E8 RID: 21480 RVA: 0x00163518 File Offset: 0x00161718
			// (set) Token: 0x060053E9 RID: 21481 RVA: 0x000209FC File Offset: 0x0001EBFC
			public unsafe UnityWebRequest _uwr_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._LoadStarterPlaces_d__68.NativeFieldInfoPtr__uwr_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._LoadStarterPlaces_d__68.NativeFieldInfoPtr__uwr_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003FFD RID: 16381
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003FFE RID: 16382
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003FFF RID: 16383
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04004000 RID: 16384
			private static readonly IntPtr NativeFieldInfoPtr__images_5__2;

			// Token: 0x04004001 RID: 16385
			private static readonly IntPtr NativeFieldInfoPtr__template_5__3;

			// Token: 0x04004002 RID: 16386
			private static readonly IntPtr NativeFieldInfoPtr__uwr_5__4;

			// Token: 0x04004003 RID: 16387
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004004 RID: 16388
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004005 RID: 16389
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04004006 RID: 16390
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004007 RID: 16391
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04004008 RID: 16392
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04004009 RID: 16393
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x0400400A RID: 16394
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}

		// Token: 0x02000452 RID: 1106
		[ObfuscatedName("Polytoria.Controllers.CreatorController+<LoadThumbnailImage>d__77")]
		public sealed class _LoadThumbnailImage_d__77 : global::Il2CppSystem.Object
		{
			// Token: 0x060053EA RID: 21482 RVA: 0x00163548 File Offset: 0x00161748
			// Note: this type is marked as 'beforefieldinit'.
			static _LoadThumbnailImage_d__77()
			{
				Il2CppClassPointerStore<CreatorController._LoadThumbnailImage_d__77>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, "<LoadThumbnailImage>d__77");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreatorController._LoadThumbnailImage_d__77>.NativeClassPtr);
				CreatorController._LoadThumbnailImage_d__77.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController._LoadThumbnailImage_d__77>.NativeClassPtr, "<>1__state");
				CreatorController._LoadThumbnailImage_d__77.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController._LoadThumbnailImage_d__77>.NativeClassPtr, "<>2__current");
				CreatorController._LoadThumbnailImage_d__77.NativeFieldInfoPtr_src = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController._LoadThumbnailImage_d__77>.NativeClassPtr, "src");
				CreatorController._LoadThumbnailImage_d__77.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController._LoadThumbnailImage_d__77>.NativeClassPtr, "target");
				CreatorController._LoadThumbnailImage_d__77.NativeFieldInfoPtr__twr_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController._LoadThumbnailImage_d__77>.NativeClassPtr, "<twr>5__2");
				CreatorController._LoadThumbnailImage_d__77.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._LoadThumbnailImage_d__77>.NativeClassPtr, 100674810);
				CreatorController._LoadThumbnailImage_d__77.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._LoadThumbnailImage_d__77>.NativeClassPtr, 100674812);
				CreatorController._LoadThumbnailImage_d__77.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._LoadThumbnailImage_d__77>.NativeClassPtr, 100674806);
				CreatorController._LoadThumbnailImage_d__77.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._LoadThumbnailImage_d__77>.NativeClassPtr, 100674807);
				CreatorController._LoadThumbnailImage_d__77.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._LoadThumbnailImage_d__77>.NativeClassPtr, 100674808);
				CreatorController._LoadThumbnailImage_d__77.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._LoadThumbnailImage_d__77>.NativeClassPtr, 100674809);
				CreatorController._LoadThumbnailImage_d__77.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._LoadThumbnailImage_d__77>.NativeClassPtr, 100674811);
			}

			// Token: 0x17001C52 RID: 7250
			// (get) Token: 0x060053EB RID: 21483 RVA: 0x00163664 File Offset: 0x00161864
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._LoadThumbnailImage_d__77.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001C53 RID: 7251
			// (get) Token: 0x060053EC RID: 21484 RVA: 0x001636A4 File Offset: 0x001618A4
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._LoadThumbnailImage_d__77.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060053ED RID: 21485 RVA: 0x001636E4 File Offset: 0x001618E4
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 10168, RefRangeEnd = 10216, XrefRangeStart = 10168, XrefRangeEnd = 10216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _LoadThumbnailImage_d__77(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreatorController._LoadThumbnailImage_d__77>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._LoadThumbnailImage_d__77.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060053EE RID: 21486 RVA: 0x0016372C File Offset: 0x0016192C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139794, XrefRangeEnd = 139799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._LoadThumbnailImage_d__77.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060053EF RID: 21487 RVA: 0x00163760 File Offset: 0x00161960
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139799, XrefRangeEnd = 139845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._LoadThumbnailImage_d__77.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060053F0 RID: 21488 RVA: 0x0016379C File Offset: 0x0016199C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139845, XrefRangeEnd = 139848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._LoadThumbnailImage_d__77.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060053F1 RID: 21489 RVA: 0x001637D0 File Offset: 0x001619D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139848, XrefRangeEnd = 139853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._LoadThumbnailImage_d__77.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060053F2 RID: 21490 RVA: 0x00020A1B File Offset: 0x0001EC1B
			public _LoadThumbnailImage_d__77(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001C4D RID: 7245
			// (get) Token: 0x060053F3 RID: 21491 RVA: 0x00163804 File Offset: 0x00161A04
			// (set) Token: 0x060053F4 RID: 21492 RVA: 0x00020A24 File Offset: 0x0001EC24
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._LoadThumbnailImage_d__77.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._LoadThumbnailImage_d__77.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001C4E RID: 7246
			// (get) Token: 0x060053F5 RID: 21493 RVA: 0x0016382C File Offset: 0x00161A2C
			// (set) Token: 0x060053F6 RID: 21494 RVA: 0x00020A3F File Offset: 0x0001EC3F
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._LoadThumbnailImage_d__77.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._LoadThumbnailImage_d__77.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C4F RID: 7247
			// (get) Token: 0x060053F7 RID: 21495 RVA: 0x0016385C File Offset: 0x00161A5C
			// (set) Token: 0x060053F8 RID: 21496 RVA: 0x00020A5E File Offset: 0x0001EC5E
			public unsafe string src
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._LoadThumbnailImage_d__77.NativeFieldInfoPtr_src);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._LoadThumbnailImage_d__77.NativeFieldInfoPtr_src), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001C50 RID: 7248
			// (get) Token: 0x060053F9 RID: 21497 RVA: 0x00163884 File Offset: 0x00161A84
			// (set) Token: 0x060053FA RID: 21498 RVA: 0x00020A7D File Offset: 0x0001EC7D
			public unsafe Image target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._LoadThumbnailImage_d__77.NativeFieldInfoPtr_target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._LoadThumbnailImage_d__77.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C51 RID: 7249
			// (get) Token: 0x060053FB RID: 21499 RVA: 0x001638B4 File Offset: 0x00161AB4
			// (set) Token: 0x060053FC RID: 21500 RVA: 0x00020A9C File Offset: 0x0001EC9C
			public unsafe UnityWebRequest _twr_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._LoadThumbnailImage_d__77.NativeFieldInfoPtr__twr_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._LoadThumbnailImage_d__77.NativeFieldInfoPtr__twr_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400400B RID: 16395
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400400C RID: 16396
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400400D RID: 16397
			private static readonly IntPtr NativeFieldInfoPtr_src;

			// Token: 0x0400400E RID: 16398
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x0400400F RID: 16399
			private static readonly IntPtr NativeFieldInfoPtr__twr_5__2;

			// Token: 0x04004010 RID: 16400
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004011 RID: 16401
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004012 RID: 16402
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04004013 RID: 16403
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004014 RID: 16404
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04004015 RID: 16405
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04004016 RID: 16406
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}

		// Token: 0x02000453 RID: 1107
		[ObfuscatedName("Polytoria.Controllers.CreatorController+<LoadThumbnailImages>d__75")]
		public sealed class _LoadThumbnailImages_d__75 : global::Il2CppSystem.Object
		{
			// Token: 0x060053FD RID: 21501 RVA: 0x001638E4 File Offset: 0x00161AE4
			// Note: this type is marked as 'beforefieldinit'.
			static _LoadThumbnailImages_d__75()
			{
				Il2CppClassPointerStore<CreatorController._LoadThumbnailImages_d__75>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, "<LoadThumbnailImages>d__75");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreatorController._LoadThumbnailImages_d__75>.NativeClassPtr);
				CreatorController._LoadThumbnailImages_d__75.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController._LoadThumbnailImages_d__75>.NativeClassPtr, "<>1__state");
				CreatorController._LoadThumbnailImages_d__75.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController._LoadThumbnailImages_d__75>.NativeClassPtr, "<>2__current");
				CreatorController._LoadThumbnailImages_d__75.NativeFieldInfoPtr_thumbnails = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController._LoadThumbnailImages_d__75>.NativeClassPtr, "thumbnails");
				CreatorController._LoadThumbnailImages_d__75.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController._LoadThumbnailImages_d__75>.NativeClassPtr, "<>7__wrap1");
				CreatorController._LoadThumbnailImages_d__75.NativeFieldInfoPtr__target_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController._LoadThumbnailImages_d__75>.NativeClassPtr, "<target>5__3");
				CreatorController._LoadThumbnailImages_d__75.NativeFieldInfoPtr__twr_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController._LoadThumbnailImages_d__75>.NativeClassPtr, "<twr>5__4");
				CreatorController._LoadThumbnailImages_d__75.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._LoadThumbnailImages_d__75>.NativeClassPtr, 100674818);
				CreatorController._LoadThumbnailImages_d__75.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._LoadThumbnailImages_d__75>.NativeClassPtr, 100674820);
				CreatorController._LoadThumbnailImages_d__75.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._LoadThumbnailImages_d__75>.NativeClassPtr, 100674813);
				CreatorController._LoadThumbnailImages_d__75.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._LoadThumbnailImages_d__75>.NativeClassPtr, 100674814);
				CreatorController._LoadThumbnailImages_d__75.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._LoadThumbnailImages_d__75>.NativeClassPtr, 100674815);
				CreatorController._LoadThumbnailImages_d__75.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._LoadThumbnailImages_d__75>.NativeClassPtr, 100674816);
				CreatorController._LoadThumbnailImages_d__75.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._LoadThumbnailImages_d__75>.NativeClassPtr, 100674817);
				CreatorController._LoadThumbnailImages_d__75.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._LoadThumbnailImages_d__75>.NativeClassPtr, 100674819);
			}

			// Token: 0x17001C5A RID: 7258
			// (get) Token: 0x060053FE RID: 21502 RVA: 0x00163A28 File Offset: 0x00161C28
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._LoadThumbnailImages_d__75.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001C5B RID: 7259
			// (get) Token: 0x060053FF RID: 21503 RVA: 0x00163A68 File Offset: 0x00161C68
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._LoadThumbnailImages_d__75.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005400 RID: 21504 RVA: 0x00163AA8 File Offset: 0x00161CA8
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 10168, RefRangeEnd = 10216, XrefRangeStart = 10168, XrefRangeEnd = 10216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _LoadThumbnailImages_d__75(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreatorController._LoadThumbnailImages_d__75>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._LoadThumbnailImages_d__75.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005401 RID: 21505 RVA: 0x00163AF0 File Offset: 0x00161CF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139853, XrefRangeEnd = 139866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._LoadThumbnailImages_d__75.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005402 RID: 21506 RVA: 0x00163B24 File Offset: 0x00161D24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139866, XrefRangeEnd = 139926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._LoadThumbnailImages_d__75.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005403 RID: 21507 RVA: 0x00163B60 File Offset: 0x00161D60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139926, XrefRangeEnd = 139929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._LoadThumbnailImages_d__75.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005404 RID: 21508 RVA: 0x00163B94 File Offset: 0x00161D94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139929, XrefRangeEnd = 139932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._LoadThumbnailImages_d__75.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005405 RID: 21509 RVA: 0x00163BC8 File Offset: 0x00161DC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139932, XrefRangeEnd = 139937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._LoadThumbnailImages_d__75.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005406 RID: 21510 RVA: 0x00020ABB File Offset: 0x0001ECBB
			public _LoadThumbnailImages_d__75(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001C54 RID: 7252
			// (get) Token: 0x06005407 RID: 21511 RVA: 0x00163BFC File Offset: 0x00161DFC
			// (set) Token: 0x06005408 RID: 21512 RVA: 0x00020AC4 File Offset: 0x0001ECC4
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._LoadThumbnailImages_d__75.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._LoadThumbnailImages_d__75.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001C55 RID: 7253
			// (get) Token: 0x06005409 RID: 21513 RVA: 0x00163C24 File Offset: 0x00161E24
			// (set) Token: 0x0600540A RID: 21514 RVA: 0x00020ADF File Offset: 0x0001ECDF
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._LoadThumbnailImages_d__75.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._LoadThumbnailImages_d__75.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C56 RID: 7254
			// (get) Token: 0x0600540B RID: 21515 RVA: 0x00163C54 File Offset: 0x00161E54
			// (set) Token: 0x0600540C RID: 21516 RVA: 0x00020AFE File Offset: 0x0001ECFE
			public unsafe List<CreatorController.ThumbnailImageTarget> thumbnails
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._LoadThumbnailImages_d__75.NativeFieldInfoPtr_thumbnails);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CreatorController.ThumbnailImageTarget>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._LoadThumbnailImages_d__75.NativeFieldInfoPtr_thumbnails), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C57 RID: 7255
			// (get) Token: 0x0600540D RID: 21517 RVA: 0x00163C84 File Offset: 0x00161E84
			// (set) Token: 0x0600540E RID: 21518 RVA: 0x00020B1D File Offset: 0x0001ED1D
			public unsafe List<CreatorController.ThumbnailImageTarget>.Enumerator __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._LoadThumbnailImages_d__75.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CreatorController.ThumbnailImageTarget>.Enumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._LoadThumbnailImages_d__75.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C58 RID: 7256
			// (get) Token: 0x0600540F RID: 21519 RVA: 0x00163CB4 File Offset: 0x00161EB4
			// (set) Token: 0x06005410 RID: 21520 RVA: 0x00020B3C File Offset: 0x0001ED3C
			public unsafe Image _target_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._LoadThumbnailImages_d__75.NativeFieldInfoPtr__target_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._LoadThumbnailImages_d__75.NativeFieldInfoPtr__target_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C59 RID: 7257
			// (get) Token: 0x06005411 RID: 21521 RVA: 0x00163CE4 File Offset: 0x00161EE4
			// (set) Token: 0x06005412 RID: 21522 RVA: 0x00020B5B File Offset: 0x0001ED5B
			public unsafe UnityWebRequest _twr_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._LoadThumbnailImages_d__75.NativeFieldInfoPtr__twr_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._LoadThumbnailImages_d__75.NativeFieldInfoPtr__twr_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004017 RID: 16407
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004018 RID: 16408
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04004019 RID: 16409
			private static readonly IntPtr NativeFieldInfoPtr_thumbnails;

			// Token: 0x0400401A RID: 16410
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x0400401B RID: 16411
			private static readonly IntPtr NativeFieldInfoPtr__target_5__3;

			// Token: 0x0400401C RID: 16412
			private static readonly IntPtr NativeFieldInfoPtr__twr_5__4;

			// Token: 0x0400401D RID: 16413
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400401E RID: 16414
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400401F RID: 16415
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04004020 RID: 16416
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004021 RID: 16417
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04004022 RID: 16418
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04004023 RID: 16419
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x04004024 RID: 16420
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}

		// Token: 0x02000454 RID: 1108
		[ObfuscatedName("Polytoria.Controllers.CreatorController+<PublishLevelToID>d__81")]
		public sealed class _PublishLevelToID_d__81 : global::Il2CppSystem.Object
		{
			// Token: 0x06005413 RID: 21523 RVA: 0x00163D14 File Offset: 0x00161F14
			// Note: this type is marked as 'beforefieldinit'.
			static _PublishLevelToID_d__81()
			{
				Il2CppClassPointerStore<CreatorController._PublishLevelToID_d__81>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, "<PublishLevelToID>d__81");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreatorController._PublishLevelToID_d__81>.NativeClassPtr);
				CreatorController._PublishLevelToID_d__81.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController._PublishLevelToID_d__81>.NativeClassPtr, "<>1__state");
				CreatorController._PublishLevelToID_d__81.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController._PublishLevelToID_d__81>.NativeClassPtr, "<>2__current");
				CreatorController._PublishLevelToID_d__81.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController._PublishLevelToID_d__81>.NativeClassPtr, "<>4__this");
				CreatorController._PublishLevelToID_d__81.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController._PublishLevelToID_d__81>.NativeClassPtr, "id");
				CreatorController._PublishLevelToID_d__81.NativeFieldInfoPtr__uwr_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController._PublishLevelToID_d__81>.NativeClassPtr, "<uwr>5__2");
				CreatorController._PublishLevelToID_d__81.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._PublishLevelToID_d__81>.NativeClassPtr, 100674825);
				CreatorController._PublishLevelToID_d__81.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._PublishLevelToID_d__81>.NativeClassPtr, 100674827);
				CreatorController._PublishLevelToID_d__81.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._PublishLevelToID_d__81>.NativeClassPtr, 100674821);
				CreatorController._PublishLevelToID_d__81.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._PublishLevelToID_d__81>.NativeClassPtr, 100674822);
				CreatorController._PublishLevelToID_d__81.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._PublishLevelToID_d__81>.NativeClassPtr, 100674823);
				CreatorController._PublishLevelToID_d__81.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._PublishLevelToID_d__81>.NativeClassPtr, 100674824);
				CreatorController._PublishLevelToID_d__81.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._PublishLevelToID_d__81>.NativeClassPtr, 100674826);
			}

			// Token: 0x17001C61 RID: 7265
			// (get) Token: 0x06005414 RID: 21524 RVA: 0x00163E30 File Offset: 0x00162030
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._PublishLevelToID_d__81.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001C62 RID: 7266
			// (get) Token: 0x06005415 RID: 21525 RVA: 0x00163E70 File Offset: 0x00162070
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._PublishLevelToID_d__81.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005416 RID: 21526 RVA: 0x00163EB0 File Offset: 0x001620B0
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 10168, RefRangeEnd = 10216, XrefRangeStart = 10168, XrefRangeEnd = 10216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _PublishLevelToID_d__81(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreatorController._PublishLevelToID_d__81>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._PublishLevelToID_d__81.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005417 RID: 21527 RVA: 0x00163EF8 File Offset: 0x001620F8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 139942, RefRangeEnd = 139943, XrefRangeStart = 139937, XrefRangeEnd = 139942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._PublishLevelToID_d__81.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005418 RID: 21528 RVA: 0x00163F2C File Offset: 0x0016212C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139943, XrefRangeEnd = 140033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._PublishLevelToID_d__81.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005419 RID: 21529 RVA: 0x00163F68 File Offset: 0x00162168
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140033, XrefRangeEnd = 140036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._PublishLevelToID_d__81.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600541A RID: 21530 RVA: 0x00163F9C File Offset: 0x0016219C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140036, XrefRangeEnd = 140041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._PublishLevelToID_d__81.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600541B RID: 21531 RVA: 0x00020B7A File Offset: 0x0001ED7A
			public _PublishLevelToID_d__81(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001C5C RID: 7260
			// (get) Token: 0x0600541C RID: 21532 RVA: 0x00163FD0 File Offset: 0x001621D0
			// (set) Token: 0x0600541D RID: 21533 RVA: 0x00020B83 File Offset: 0x0001ED83
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._PublishLevelToID_d__81.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._PublishLevelToID_d__81.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001C5D RID: 7261
			// (get) Token: 0x0600541E RID: 21534 RVA: 0x00163FF8 File Offset: 0x001621F8
			// (set) Token: 0x0600541F RID: 21535 RVA: 0x00020B9E File Offset: 0x0001ED9E
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._PublishLevelToID_d__81.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._PublishLevelToID_d__81.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C5E RID: 7262
			// (get) Token: 0x06005420 RID: 21536 RVA: 0x00164028 File Offset: 0x00162228
			// (set) Token: 0x06005421 RID: 21537 RVA: 0x00020BBD File Offset: 0x0001EDBD
			public unsafe CreatorController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._PublishLevelToID_d__81.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CreatorController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._PublishLevelToID_d__81.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C5F RID: 7263
			// (get) Token: 0x06005422 RID: 21538 RVA: 0x00164058 File Offset: 0x00162258
			// (set) Token: 0x06005423 RID: 21539 RVA: 0x00020BDC File Offset: 0x0001EDDC
			public unsafe int id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._PublishLevelToID_d__81.NativeFieldInfoPtr_id);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._PublishLevelToID_d__81.NativeFieldInfoPtr_id)) = value;
				}
			}

			// Token: 0x17001C60 RID: 7264
			// (get) Token: 0x06005424 RID: 21540 RVA: 0x00164080 File Offset: 0x00162280
			// (set) Token: 0x06005425 RID: 21541 RVA: 0x00020BF7 File Offset: 0x0001EDF7
			public unsafe UnityWebRequest _uwr_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._PublishLevelToID_d__81.NativeFieldInfoPtr__uwr_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._PublishLevelToID_d__81.NativeFieldInfoPtr__uwr_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004025 RID: 16421
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004026 RID: 16422
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04004027 RID: 16423
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04004028 RID: 16424
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x04004029 RID: 16425
			private static readonly IntPtr NativeFieldInfoPtr__uwr_5__2;

			// Token: 0x0400402A RID: 16426
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400402B RID: 16427
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400402C RID: 16428
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400402D RID: 16429
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400402E RID: 16430
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400402F RID: 16431
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04004030 RID: 16432
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}

		// Token: 0x02000455 RID: 1109
		[ObfuscatedName("Polytoria.Controllers.CreatorController+<ShowExportGLTFDialog>d__59")]
		public sealed class _ShowExportGLTFDialog_d__59 : global::Il2CppSystem.Object
		{
			// Token: 0x06005426 RID: 21542 RVA: 0x001640B0 File Offset: 0x001622B0
			// Note: this type is marked as 'beforefieldinit'.
			static _ShowExportGLTFDialog_d__59()
			{
				Il2CppClassPointerStore<CreatorController._ShowExportGLTFDialog_d__59>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, "<ShowExportGLTFDialog>d__59");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreatorController._ShowExportGLTFDialog_d__59>.NativeClassPtr);
				CreatorController._ShowExportGLTFDialog_d__59.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController._ShowExportGLTFDialog_d__59>.NativeClassPtr, "<>1__state");
				CreatorController._ShowExportGLTFDialog_d__59.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController._ShowExportGLTFDialog_d__59>.NativeClassPtr, "<>2__current");
				CreatorController._ShowExportGLTFDialog_d__59.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._ShowExportGLTFDialog_d__59>.NativeClassPtr, 100674831);
				CreatorController._ShowExportGLTFDialog_d__59.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._ShowExportGLTFDialog_d__59>.NativeClassPtr, 100674833);
				CreatorController._ShowExportGLTFDialog_d__59.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._ShowExportGLTFDialog_d__59>.NativeClassPtr, 100674828);
				CreatorController._ShowExportGLTFDialog_d__59.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._ShowExportGLTFDialog_d__59>.NativeClassPtr, 100674829);
				CreatorController._ShowExportGLTFDialog_d__59.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._ShowExportGLTFDialog_d__59>.NativeClassPtr, 100674830);
				CreatorController._ShowExportGLTFDialog_d__59.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._ShowExportGLTFDialog_d__59>.NativeClassPtr, 100674832);
			}

			// Token: 0x17001C65 RID: 7269
			// (get) Token: 0x06005427 RID: 21543 RVA: 0x0016417C File Offset: 0x0016237C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._ShowExportGLTFDialog_d__59.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001C66 RID: 7270
			// (get) Token: 0x06005428 RID: 21544 RVA: 0x001641BC File Offset: 0x001623BC
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._ShowExportGLTFDialog_d__59.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005429 RID: 21545 RVA: 0x001641FC File Offset: 0x001623FC
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 10168, RefRangeEnd = 10216, XrefRangeStart = 10168, XrefRangeEnd = 10216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ShowExportGLTFDialog_d__59(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreatorController._ShowExportGLTFDialog_d__59>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._ShowExportGLTFDialog_d__59.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600542A RID: 21546 RVA: 0x00164244 File Offset: 0x00162444
			[CallerCount(7535)]
			[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._ShowExportGLTFDialog_d__59.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600542B RID: 21547 RVA: 0x00164278 File Offset: 0x00162478
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140041, XrefRangeEnd = 140051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._ShowExportGLTFDialog_d__59.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600542C RID: 21548 RVA: 0x001642B4 File Offset: 0x001624B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140051, XrefRangeEnd = 140056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._ShowExportGLTFDialog_d__59.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600542D RID: 21549 RVA: 0x00020C16 File Offset: 0x0001EE16
			public _ShowExportGLTFDialog_d__59(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001C63 RID: 7267
			// (get) Token: 0x0600542E RID: 21550 RVA: 0x001642E8 File Offset: 0x001624E8
			// (set) Token: 0x0600542F RID: 21551 RVA: 0x00020C1F File Offset: 0x0001EE1F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._ShowExportGLTFDialog_d__59.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._ShowExportGLTFDialog_d__59.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001C64 RID: 7268
			// (get) Token: 0x06005430 RID: 21552 RVA: 0x00164310 File Offset: 0x00162510
			// (set) Token: 0x06005431 RID: 21553 RVA: 0x00020C3A File Offset: 0x0001EE3A
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._ShowExportGLTFDialog_d__59.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._ShowExportGLTFDialog_d__59.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004031 RID: 16433
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004032 RID: 16434
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04004033 RID: 16435
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004034 RID: 16436
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004035 RID: 16437
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04004036 RID: 16438
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004037 RID: 16439
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04004038 RID: 16440
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}

		// Token: 0x02000456 RID: 1110
		[ObfuscatedName("Polytoria.Controllers.CreatorController+<ShowExportModelDialog>d__56")]
		public sealed class _ShowExportModelDialog_d__56 : global::Il2CppSystem.Object
		{
			// Token: 0x06005432 RID: 21554 RVA: 0x00164340 File Offset: 0x00162540
			// Note: this type is marked as 'beforefieldinit'.
			static _ShowExportModelDialog_d__56()
			{
				Il2CppClassPointerStore<CreatorController._ShowExportModelDialog_d__56>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, "<ShowExportModelDialog>d__56");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreatorController._ShowExportModelDialog_d__56>.NativeClassPtr);
				CreatorController._ShowExportModelDialog_d__56.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController._ShowExportModelDialog_d__56>.NativeClassPtr, "<>1__state");
				CreatorController._ShowExportModelDialog_d__56.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController._ShowExportModelDialog_d__56>.NativeClassPtr, "<>2__current");
				CreatorController._ShowExportModelDialog_d__56.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._ShowExportModelDialog_d__56>.NativeClassPtr, 100674837);
				CreatorController._ShowExportModelDialog_d__56.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._ShowExportModelDialog_d__56>.NativeClassPtr, 100674839);
				CreatorController._ShowExportModelDialog_d__56.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._ShowExportModelDialog_d__56>.NativeClassPtr, 100674834);
				CreatorController._ShowExportModelDialog_d__56.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._ShowExportModelDialog_d__56>.NativeClassPtr, 100674835);
				CreatorController._ShowExportModelDialog_d__56.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._ShowExportModelDialog_d__56>.NativeClassPtr, 100674836);
				CreatorController._ShowExportModelDialog_d__56.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._ShowExportModelDialog_d__56>.NativeClassPtr, 100674838);
			}

			// Token: 0x17001C69 RID: 7273
			// (get) Token: 0x06005433 RID: 21555 RVA: 0x0016440C File Offset: 0x0016260C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._ShowExportModelDialog_d__56.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001C6A RID: 7274
			// (get) Token: 0x06005434 RID: 21556 RVA: 0x0016444C File Offset: 0x0016264C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._ShowExportModelDialog_d__56.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005435 RID: 21557 RVA: 0x0016448C File Offset: 0x0016268C
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 10168, RefRangeEnd = 10216, XrefRangeStart = 10168, XrefRangeEnd = 10216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ShowExportModelDialog_d__56(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreatorController._ShowExportModelDialog_d__56>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._ShowExportModelDialog_d__56.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005436 RID: 21558 RVA: 0x001644D4 File Offset: 0x001626D4
			[CallerCount(7535)]
			[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._ShowExportModelDialog_d__56.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005437 RID: 21559 RVA: 0x00164508 File Offset: 0x00162708
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140056, XrefRangeEnd = 140066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._ShowExportModelDialog_d__56.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005438 RID: 21560 RVA: 0x00164544 File Offset: 0x00162744
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140066, XrefRangeEnd = 140071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._ShowExportModelDialog_d__56.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005439 RID: 21561 RVA: 0x00020C59 File Offset: 0x0001EE59
			public _ShowExportModelDialog_d__56(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001C67 RID: 7271
			// (get) Token: 0x0600543A RID: 21562 RVA: 0x00164578 File Offset: 0x00162778
			// (set) Token: 0x0600543B RID: 21563 RVA: 0x00020C62 File Offset: 0x0001EE62
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._ShowExportModelDialog_d__56.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._ShowExportModelDialog_d__56.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001C68 RID: 7272
			// (get) Token: 0x0600543C RID: 21564 RVA: 0x001645A0 File Offset: 0x001627A0
			// (set) Token: 0x0600543D RID: 21565 RVA: 0x00020C7D File Offset: 0x0001EE7D
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._ShowExportModelDialog_d__56.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._ShowExportModelDialog_d__56.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004039 RID: 16441
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400403A RID: 16442
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400403B RID: 16443
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400403C RID: 16444
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400403D RID: 16445
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400403E RID: 16446
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400403F RID: 16447
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04004040 RID: 16448
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}

		// Token: 0x02000457 RID: 1111
		[ObfuscatedName("Polytoria.Controllers.CreatorController+<ShowImportModelDialog>d__64")]
		public sealed class _ShowImportModelDialog_d__64 : global::Il2CppSystem.Object
		{
			// Token: 0x0600543E RID: 21566 RVA: 0x001645D0 File Offset: 0x001627D0
			// Note: this type is marked as 'beforefieldinit'.
			static _ShowImportModelDialog_d__64()
			{
				Il2CppClassPointerStore<CreatorController._ShowImportModelDialog_d__64>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, "<ShowImportModelDialog>d__64");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreatorController._ShowImportModelDialog_d__64>.NativeClassPtr);
				CreatorController._ShowImportModelDialog_d__64.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController._ShowImportModelDialog_d__64>.NativeClassPtr, "<>1__state");
				CreatorController._ShowImportModelDialog_d__64.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController._ShowImportModelDialog_d__64>.NativeClassPtr, "<>2__current");
				CreatorController._ShowImportModelDialog_d__64.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._ShowImportModelDialog_d__64>.NativeClassPtr, 100674843);
				CreatorController._ShowImportModelDialog_d__64.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._ShowImportModelDialog_d__64>.NativeClassPtr, 100674845);
				CreatorController._ShowImportModelDialog_d__64.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._ShowImportModelDialog_d__64>.NativeClassPtr, 100674840);
				CreatorController._ShowImportModelDialog_d__64.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._ShowImportModelDialog_d__64>.NativeClassPtr, 100674841);
				CreatorController._ShowImportModelDialog_d__64.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._ShowImportModelDialog_d__64>.NativeClassPtr, 100674842);
				CreatorController._ShowImportModelDialog_d__64.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._ShowImportModelDialog_d__64>.NativeClassPtr, 100674844);
			}

			// Token: 0x17001C6D RID: 7277
			// (get) Token: 0x0600543F RID: 21567 RVA: 0x0016469C File Offset: 0x0016289C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._ShowImportModelDialog_d__64.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001C6E RID: 7278
			// (get) Token: 0x06005440 RID: 21568 RVA: 0x001646DC File Offset: 0x001628DC
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._ShowImportModelDialog_d__64.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005441 RID: 21569 RVA: 0x0016471C File Offset: 0x0016291C
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 10168, RefRangeEnd = 10216, XrefRangeStart = 10168, XrefRangeEnd = 10216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ShowImportModelDialog_d__64(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreatorController._ShowImportModelDialog_d__64>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._ShowImportModelDialog_d__64.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005442 RID: 21570 RVA: 0x00164764 File Offset: 0x00162964
			[CallerCount(7535)]
			[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._ShowImportModelDialog_d__64.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005443 RID: 21571 RVA: 0x00164798 File Offset: 0x00162998
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140071, XrefRangeEnd = 140081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._ShowImportModelDialog_d__64.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005444 RID: 21572 RVA: 0x001647D4 File Offset: 0x001629D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140081, XrefRangeEnd = 140086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._ShowImportModelDialog_d__64.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005445 RID: 21573 RVA: 0x00020C9C File Offset: 0x0001EE9C
			public _ShowImportModelDialog_d__64(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001C6B RID: 7275
			// (get) Token: 0x06005446 RID: 21574 RVA: 0x00164808 File Offset: 0x00162A08
			// (set) Token: 0x06005447 RID: 21575 RVA: 0x00020CA5 File Offset: 0x0001EEA5
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._ShowImportModelDialog_d__64.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._ShowImportModelDialog_d__64.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001C6C RID: 7276
			// (get) Token: 0x06005448 RID: 21576 RVA: 0x00164830 File Offset: 0x00162A30
			// (set) Token: 0x06005449 RID: 21577 RVA: 0x00020CC0 File Offset: 0x0001EEC0
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._ShowImportModelDialog_d__64.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._ShowImportModelDialog_d__64.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004041 RID: 16449
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004042 RID: 16450
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04004043 RID: 16451
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004044 RID: 16452
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004045 RID: 16453
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04004046 RID: 16454
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004047 RID: 16455
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04004048 RID: 16456
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}

		// Token: 0x02000458 RID: 1112
		[ObfuscatedName("Polytoria.Controllers.CreatorController+<ShowOpenDialog>d__84")]
		public sealed class _ShowOpenDialog_d__84 : global::Il2CppSystem.Object
		{
			// Token: 0x0600544A RID: 21578 RVA: 0x00164860 File Offset: 0x00162A60
			// Note: this type is marked as 'beforefieldinit'.
			static _ShowOpenDialog_d__84()
			{
				Il2CppClassPointerStore<CreatorController._ShowOpenDialog_d__84>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, "<ShowOpenDialog>d__84");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreatorController._ShowOpenDialog_d__84>.NativeClassPtr);
				CreatorController._ShowOpenDialog_d__84.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController._ShowOpenDialog_d__84>.NativeClassPtr, "<>1__state");
				CreatorController._ShowOpenDialog_d__84.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController._ShowOpenDialog_d__84>.NativeClassPtr, "<>2__current");
				CreatorController._ShowOpenDialog_d__84.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._ShowOpenDialog_d__84>.NativeClassPtr, 100674849);
				CreatorController._ShowOpenDialog_d__84.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._ShowOpenDialog_d__84>.NativeClassPtr, 100674851);
				CreatorController._ShowOpenDialog_d__84.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._ShowOpenDialog_d__84>.NativeClassPtr, 100674846);
				CreatorController._ShowOpenDialog_d__84.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._ShowOpenDialog_d__84>.NativeClassPtr, 100674847);
				CreatorController._ShowOpenDialog_d__84.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._ShowOpenDialog_d__84>.NativeClassPtr, 100674848);
				CreatorController._ShowOpenDialog_d__84.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._ShowOpenDialog_d__84>.NativeClassPtr, 100674850);
			}

			// Token: 0x17001C71 RID: 7281
			// (get) Token: 0x0600544B RID: 21579 RVA: 0x0016492C File Offset: 0x00162B2C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._ShowOpenDialog_d__84.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001C72 RID: 7282
			// (get) Token: 0x0600544C RID: 21580 RVA: 0x0016496C File Offset: 0x00162B6C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._ShowOpenDialog_d__84.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600544D RID: 21581 RVA: 0x001649AC File Offset: 0x00162BAC
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 10168, RefRangeEnd = 10216, XrefRangeStart = 10168, XrefRangeEnd = 10216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ShowOpenDialog_d__84(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreatorController._ShowOpenDialog_d__84>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._ShowOpenDialog_d__84.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600544E RID: 21582 RVA: 0x001649F4 File Offset: 0x00162BF4
			[CallerCount(7535)]
			[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._ShowOpenDialog_d__84.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600544F RID: 21583 RVA: 0x00164A28 File Offset: 0x00162C28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140086, XrefRangeEnd = 140094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._ShowOpenDialog_d__84.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005450 RID: 21584 RVA: 0x00164A64 File Offset: 0x00162C64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140094, XrefRangeEnd = 140099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._ShowOpenDialog_d__84.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005451 RID: 21585 RVA: 0x00020CDF File Offset: 0x0001EEDF
			public _ShowOpenDialog_d__84(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001C6F RID: 7279
			// (get) Token: 0x06005452 RID: 21586 RVA: 0x00164A98 File Offset: 0x00162C98
			// (set) Token: 0x06005453 RID: 21587 RVA: 0x00020CE8 File Offset: 0x0001EEE8
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._ShowOpenDialog_d__84.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._ShowOpenDialog_d__84.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001C70 RID: 7280
			// (get) Token: 0x06005454 RID: 21588 RVA: 0x00164AC0 File Offset: 0x00162CC0
			// (set) Token: 0x06005455 RID: 21589 RVA: 0x00020D03 File Offset: 0x0001EF03
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._ShowOpenDialog_d__84.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._ShowOpenDialog_d__84.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004049 RID: 16457
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400404A RID: 16458
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400404B RID: 16459
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400404C RID: 16460
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400404D RID: 16461
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400404E RID: 16462
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400404F RID: 16463
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04004050 RID: 16464
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}

		// Token: 0x02000459 RID: 1113
		[ObfuscatedName("Polytoria.Controllers.CreatorController+<ShowSaveDialog>d__89")]
		public sealed class _ShowSaveDialog_d__89 : global::Il2CppSystem.Object
		{
			// Token: 0x06005456 RID: 21590 RVA: 0x00164AF0 File Offset: 0x00162CF0
			// Note: this type is marked as 'beforefieldinit'.
			static _ShowSaveDialog_d__89()
			{
				Il2CppClassPointerStore<CreatorController._ShowSaveDialog_d__89>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CreatorController>.NativeClassPtr, "<ShowSaveDialog>d__89");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreatorController._ShowSaveDialog_d__89>.NativeClassPtr);
				CreatorController._ShowSaveDialog_d__89.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController._ShowSaveDialog_d__89>.NativeClassPtr, "<>1__state");
				CreatorController._ShowSaveDialog_d__89.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorController._ShowSaveDialog_d__89>.NativeClassPtr, "<>2__current");
				CreatorController._ShowSaveDialog_d__89.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._ShowSaveDialog_d__89>.NativeClassPtr, 100674855);
				CreatorController._ShowSaveDialog_d__89.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._ShowSaveDialog_d__89>.NativeClassPtr, 100674857);
				CreatorController._ShowSaveDialog_d__89.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._ShowSaveDialog_d__89>.NativeClassPtr, 100674852);
				CreatorController._ShowSaveDialog_d__89.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._ShowSaveDialog_d__89>.NativeClassPtr, 100674853);
				CreatorController._ShowSaveDialog_d__89.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._ShowSaveDialog_d__89>.NativeClassPtr, 100674854);
				CreatorController._ShowSaveDialog_d__89.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorController._ShowSaveDialog_d__89>.NativeClassPtr, 100674856);
			}

			// Token: 0x17001C75 RID: 7285
			// (get) Token: 0x06005457 RID: 21591 RVA: 0x00164BBC File Offset: 0x00162DBC
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._ShowSaveDialog_d__89.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001C76 RID: 7286
			// (get) Token: 0x06005458 RID: 21592 RVA: 0x00164BFC File Offset: 0x00162DFC
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._ShowSaveDialog_d__89.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005459 RID: 21593 RVA: 0x00164C3C File Offset: 0x00162E3C
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 10168, RefRangeEnd = 10216, XrefRangeStart = 10168, XrefRangeEnd = 10216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ShowSaveDialog_d__89(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreatorController._ShowSaveDialog_d__89>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._ShowSaveDialog_d__89.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600545A RID: 21594 RVA: 0x00164C84 File Offset: 0x00162E84
			[CallerCount(7535)]
			[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._ShowSaveDialog_d__89.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600545B RID: 21595 RVA: 0x00164CB8 File Offset: 0x00162EB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140099, XrefRangeEnd = 140107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._ShowSaveDialog_d__89.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600545C RID: 21596 RVA: 0x00164CF4 File Offset: 0x00162EF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140107, XrefRangeEnd = 140112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorController._ShowSaveDialog_d__89.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600545D RID: 21597 RVA: 0x00020D22 File Offset: 0x0001EF22
			public _ShowSaveDialog_d__89(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001C73 RID: 7283
			// (get) Token: 0x0600545E RID: 21598 RVA: 0x00164D28 File Offset: 0x00162F28
			// (set) Token: 0x0600545F RID: 21599 RVA: 0x00020D2B File Offset: 0x0001EF2B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._ShowSaveDialog_d__89.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._ShowSaveDialog_d__89.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001C74 RID: 7284
			// (get) Token: 0x06005460 RID: 21600 RVA: 0x00164D50 File Offset: 0x00162F50
			// (set) Token: 0x06005461 RID: 21601 RVA: 0x00020D46 File Offset: 0x0001EF46
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._ShowSaveDialog_d__89.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorController._ShowSaveDialog_d__89.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004051 RID: 16465
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004052 RID: 16466
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04004053 RID: 16467
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004054 RID: 16468
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004055 RID: 16469
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04004056 RID: 16470
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004057 RID: 16471
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04004058 RID: 16472
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}
	}
}
