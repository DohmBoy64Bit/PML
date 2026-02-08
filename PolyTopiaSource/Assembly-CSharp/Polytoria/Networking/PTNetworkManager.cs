using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Mirror;
using Polytoria.Datamodel;
using UnityEngine.Networking;

namespace Polytoria.Networking
{
	// Token: 0x0200025F RID: 607
	public class PTNetworkManager : NetworkManager
	{
		// Token: 0x06002EE8 RID: 12008 RVA: 0x000D8458 File Offset: 0x000D6658
		// Note: this type is marked as 'beforefieldinit'.
		static PTNetworkManager()
		{
			Il2CppClassPointerStore<PTNetworkManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Networking", "PTNetworkManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PTNetworkManager>.NativeClassPtr);
			PTNetworkManager.NativeFieldInfoPtr_playerConnData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PTNetworkManager>.NativeClassPtr, "playerConnData");
			PTNetworkManager.NativeFieldInfoPtr_playerPrefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PTNetworkManager>.NativeClassPtr, "playerPrefabs");
			PTNetworkManager.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PTNetworkManager>.NativeClassPtr, "instance");
			PTNetworkManager.NativeFieldInfoPtr_serverHeartbeatRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PTNetworkManager>.NativeClassPtr, "serverHeartbeatRate");
			PTNetworkManager.NativeFieldInfoPtr_maxServerTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PTNetworkManager>.NativeClassPtr, "maxServerTimeout");
			PTNetworkManager.NativeFieldInfoPtr_emptyServerPings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PTNetworkManager>.NativeClassPtr, "emptyServerPings");
			PTNetworkManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PTNetworkManager>.NativeClassPtr, 100670352);
			PTNetworkManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PTNetworkManager>.NativeClassPtr, 100670316);
			PTNetworkManager.NativeMethodInfoPtr_OnValidate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PTNetworkManager>.NativeClassPtr, 100670317);
			PTNetworkManager.NativeMethodInfoPtr_Start_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PTNetworkManager>.NativeClassPtr, 100670318);
			PTNetworkManager.NativeMethodInfoPtr_LateUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PTNetworkManager>.NativeClassPtr, 100670319);
			PTNetworkManager.NativeMethodInfoPtr_OnDestroy_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PTNetworkManager>.NativeClassPtr, 100670320);
			PTNetworkManager.NativeMethodInfoPtr_ConfigureHeadlessFrameRate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PTNetworkManager>.NativeClassPtr, 100670321);
			PTNetworkManager.NativeMethodInfoPtr_OnApplicationQuit_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PTNetworkManager>.NativeClassPtr, 100670322);
			PTNetworkManager.NativeMethodInfoPtr_ServerChangeScene_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PTNetworkManager>.NativeClassPtr, 100670323);
			PTNetworkManager.NativeMethodInfoPtr_OnServerChangeScene_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PTNetworkManager>.NativeClassPtr, 100670324);
			PTNetworkManager.NativeMethodInfoPtr_OnServerSceneChanged_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PTNetworkManager>.NativeClassPtr, 100670325);
			PTNetworkManager.NativeMethodInfoPtr_OnClientChangeScene_Public_Virtual_Void_String_SceneOperation_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PTNetworkManager>.NativeClassPtr, 100670326);
			PTNetworkManager.NativeMethodInfoPtr_OnClientSceneChanged_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PTNetworkManager>.NativeClassPtr, 100670327);
			PTNetworkManager.NativeMethodInfoPtr_OnServerConnect_Public_Virtual_Void_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PTNetworkManager>.NativeClassPtr, 100670328);
			PTNetworkManager.NativeMethodInfoPtr_OnServerReady_Public_Virtual_Void_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PTNetworkManager>.NativeClassPtr, 100670329);
			PTNetworkManager.NativeMethodInfoPtr_OnServerAddPlayer_Public_Virtual_Void_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PTNetworkManager>.NativeClassPtr, 100670330);
			PTNetworkManager.NativeMethodInfoPtr_OnServerDisconnect_Public_Virtual_Void_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PTNetworkManager>.NativeClassPtr, 100670331);
			PTNetworkManager.NativeMethodInfoPtr_OnServerError_Public_Virtual_Void_NetworkConnectionToClient_TransportError_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PTNetworkManager>.NativeClassPtr, 100670332);
			PTNetworkManager.NativeMethodInfoPtr_OnClientConnect_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PTNetworkManager>.NativeClassPtr, 100670333);
			PTNetworkManager.NativeMethodInfoPtr_OnClientDisconnect_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PTNetworkManager>.NativeClassPtr, 100670334);
			PTNetworkManager.NativeMethodInfoPtr_OnClientNotReady_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PTNetworkManager>.NativeClassPtr, 100670335);
			PTNetworkManager.NativeMethodInfoPtr_OnClientError_Public_Virtual_Void_TransportError_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PTNetworkManager>.NativeClassPtr, 100670336);
			PTNetworkManager.NativeMethodInfoPtr_OnStartHost_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PTNetworkManager>.NativeClassPtr, 100670337);
			PTNetworkManager.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PTNetworkManager>.NativeClassPtr, 100670338);
			PTNetworkManager.NativeMethodInfoPtr_ClientConnected_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PTNetworkManager>.NativeClassPtr, 100670339);
			PTNetworkManager.NativeMethodInfoPtr_ClientDisconnected_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PTNetworkManager>.NativeClassPtr, 100670340);
			PTNetworkManager.NativeMethodInfoPtr_ShutdownServer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PTNetworkManager>.NativeClassPtr, 100670341);
			PTNetworkManager.NativeMethodInfoPtr_LogEvent_Private_IEnumerator_ServerEventType_Dictionary_2_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PTNetworkManager>.NativeClassPtr, 100670342);
			PTNetworkManager.NativeMethodInfoPtr_HeartbeatLoop_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PTNetworkManager>.NativeClassPtr, 100670343);
			PTNetworkManager.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PTNetworkManager>.NativeClassPtr, 100670344);
			PTNetworkManager.NativeMethodInfoPtr_OnStopHost_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PTNetworkManager>.NativeClassPtr, 100670345);
			PTNetworkManager.NativeMethodInfoPtr_OnStopServer_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PTNetworkManager>.NativeClassPtr, 100670346);
			PTNetworkManager.NativeMethodInfoPtr_OnStopClient_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PTNetworkManager>.NativeClassPtr, 100670347);
			PTNetworkManager.NativeMethodInfoPtr_GetPlayerPrefab_Public_Player_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PTNetworkManager>.NativeClassPtr, 100670348);
			PTNetworkManager.NativeMethodInfoPtr_AddUserForConnID_Public_Void_Int32_AuthUserData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PTNetworkManager>.NativeClassPtr, 100670349);
			PTNetworkManager.NativeMethodInfoPtr_GetUserDataFromConnID_Public_AuthUserData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PTNetworkManager>.NativeClassPtr, 100670350);
			PTNetworkManager.NativeMethodInfoPtr_GetConnectedUserIDs_Public_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PTNetworkManager>.NativeClassPtr, 100670351);
		}

		// Token: 0x06002EE9 RID: 12009 RVA: 0x000D87E4 File Offset: 0x000D69E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99672, XrefRangeEnd = 99690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PTNetworkManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PTNetworkManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PTNetworkManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EEA RID: 12010 RVA: 0x000D8820 File Offset: 0x000D6A20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99690, XrefRangeEnd = 99701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PTNetworkManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EEB RID: 12011 RVA: 0x000D885C File Offset: 0x000D6A5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99701, XrefRangeEnd = 99702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PTNetworkManager.NativeMethodInfoPtr_OnValidate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EEC RID: 12012 RVA: 0x000D8898 File Offset: 0x000D6A98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99702, XrefRangeEnd = 99703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PTNetworkManager.NativeMethodInfoPtr_Start_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EED RID: 12013 RVA: 0x000D88D4 File Offset: 0x000D6AD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99703, XrefRangeEnd = 99704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PTNetworkManager.NativeMethodInfoPtr_LateUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EEE RID: 12014 RVA: 0x000D8910 File Offset: 0x000D6B10
		[CallerCount(2275)]
		[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PTNetworkManager.NativeMethodInfoPtr_OnDestroy_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EEF RID: 12015 RVA: 0x000D894C File Offset: 0x000D6B4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99704, XrefRangeEnd = 99705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ConfigureHeadlessFrameRate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PTNetworkManager.NativeMethodInfoPtr_ConfigureHeadlessFrameRate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EF0 RID: 12016 RVA: 0x000D8988 File Offset: 0x000D6B88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99705, XrefRangeEnd = 99706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnApplicationQuit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PTNetworkManager.NativeMethodInfoPtr_OnApplicationQuit_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EF1 RID: 12017 RVA: 0x000D89C4 File Offset: 0x000D6BC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99706, XrefRangeEnd = 99707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ServerChangeScene(string newSceneName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(newSceneName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PTNetworkManager.NativeMethodInfoPtr_ServerChangeScene_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002EF2 RID: 12018 RVA: 0x000D8A14 File Offset: 0x000D6C14
		[CallerCount(7535)]
		[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnServerChangeScene(string newSceneName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(newSceneName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PTNetworkManager.NativeMethodInfoPtr_OnServerChangeScene_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002EF3 RID: 12019 RVA: 0x000D8A64 File Offset: 0x000D6C64
		[CallerCount(7535)]
		[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnServerSceneChanged(string sceneName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sceneName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PTNetworkManager.NativeMethodInfoPtr_OnServerSceneChanged_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002EF4 RID: 12020 RVA: 0x000D8AB4 File Offset: 0x000D6CB4
		[CallerCount(7535)]
		[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnClientChangeScene(string newSceneName, SceneOperation sceneOperation, bool customHandling)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(newSceneName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sceneOperation);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref customHandling;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PTNetworkManager.NativeMethodInfoPtr_OnClientChangeScene_Public_Virtual_Void_String_SceneOperation_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EF5 RID: 12021 RVA: 0x000D8B24 File Offset: 0x000D6D24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99707, XrefRangeEnd = 99708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnClientSceneChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PTNetworkManager.NativeMethodInfoPtr_OnClientSceneChanged_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EF6 RID: 12022 RVA: 0x000D8B60 File Offset: 0x000D6D60
		[CallerCount(7535)]
		[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnServerConnect(NetworkConnectionToClient conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PTNetworkManager.NativeMethodInfoPtr_OnServerConnect_Public_Virtual_Void_NetworkConnectionToClient_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002EF7 RID: 12023 RVA: 0x000D8BB0 File Offset: 0x000D6DB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99708, XrefRangeEnd = 99709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnServerReady(NetworkConnectionToClient conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PTNetworkManager.NativeMethodInfoPtr_OnServerReady_Public_Virtual_Void_NetworkConnectionToClient_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002EF8 RID: 12024 RVA: 0x000D8C00 File Offset: 0x000D6E00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99709, XrefRangeEnd = 99838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnServerAddPlayer(NetworkConnectionToClient conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PTNetworkManager.NativeMethodInfoPtr_OnServerAddPlayer_Public_Virtual_Void_NetworkConnectionToClient_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002EF9 RID: 12025 RVA: 0x000D8C50 File Offset: 0x000D6E50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99838, XrefRangeEnd = 99839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnServerDisconnect(NetworkConnectionToClient conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PTNetworkManager.NativeMethodInfoPtr_OnServerDisconnect_Public_Virtual_Void_NetworkConnectionToClient_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002EFA RID: 12026 RVA: 0x000D8CA0 File Offset: 0x000D6EA0
		[CallerCount(7535)]
		[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnServerError(NetworkConnectionToClient conn, TransportError transportError, string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(transportError);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PTNetworkManager.NativeMethodInfoPtr_OnServerError_Public_Virtual_Void_NetworkConnectionToClient_TransportError_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EFB RID: 12027 RVA: 0x000D8D14 File Offset: 0x000D6F14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99839, XrefRangeEnd = 99840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnClientConnect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PTNetworkManager.NativeMethodInfoPtr_OnClientConnect_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EFC RID: 12028 RVA: 0x000D8D50 File Offset: 0x000D6F50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99840, XrefRangeEnd = 99852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnClientDisconnect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PTNetworkManager.NativeMethodInfoPtr_OnClientDisconnect_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EFD RID: 12029 RVA: 0x000D8D8C File Offset: 0x000D6F8C
		[CallerCount(7535)]
		[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnClientNotReady()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PTNetworkManager.NativeMethodInfoPtr_OnClientNotReady_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EFE RID: 12030 RVA: 0x000D8DC8 File Offset: 0x000D6FC8
		[CallerCount(7535)]
		[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnClientError(TransportError transportError, string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transportError);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PTNetworkManager.NativeMethodInfoPtr_OnClientError_Public_Virtual_Void_TransportError_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EFF RID: 12031 RVA: 0x000D8E28 File Offset: 0x000D7028
		[CallerCount(7535)]
		[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartHost()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PTNetworkManager.NativeMethodInfoPtr_OnStartHost_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F00 RID: 12032 RVA: 0x000D8E64 File Offset: 0x000D7064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99852, XrefRangeEnd = 99866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartServer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PTNetworkManager.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F01 RID: 12033 RVA: 0x000D8EA0 File Offset: 0x000D70A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99866, XrefRangeEnd = 99883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClientConnected(int userID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref userID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PTNetworkManager.NativeMethodInfoPtr_ClientConnected_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F02 RID: 12034 RVA: 0x000D8EE0 File Offset: 0x000D70E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99883, XrefRangeEnd = 99900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClientDisconnected(int userID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref userID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PTNetworkManager.NativeMethodInfoPtr_ClientDisconnected_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F03 RID: 12035 RVA: 0x000D8F20 File Offset: 0x000D7120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99900, XrefRangeEnd = 99905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShutdownServer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PTNetworkManager.NativeMethodInfoPtr_ShutdownServer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F04 RID: 12036 RVA: 0x000D8F54 File Offset: 0x000D7154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99905, XrefRangeEnd = 99909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator LogEvent(PTNetworkManager.ServerEventType eventType, Dictionary<string, string> data = null, bool shutdownOnComplete = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shutdownOnComplete;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PTNetworkManager.NativeMethodInfoPtr_LogEvent_Private_IEnumerator_ServerEventType_Dictionary_2_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002F05 RID: 12037 RVA: 0x000D8FC0 File Offset: 0x000D71C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99909, XrefRangeEnd = 99914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator HeartbeatLoop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PTNetworkManager.NativeMethodInfoPtr_HeartbeatLoop_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002F06 RID: 12038 RVA: 0x000D9000 File Offset: 0x000D7200
		[CallerCount(7535)]
		[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PTNetworkManager.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F07 RID: 12039 RVA: 0x000D903C File Offset: 0x000D723C
		[CallerCount(7535)]
		[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStopHost()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PTNetworkManager.NativeMethodInfoPtr_OnStopHost_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F08 RID: 12040 RVA: 0x000D9078 File Offset: 0x000D7278
		[CallerCount(7535)]
		[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStopServer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PTNetworkManager.NativeMethodInfoPtr_OnStopServer_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F09 RID: 12041 RVA: 0x000D90B4 File Offset: 0x000D72B4
		[CallerCount(7535)]
		[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStopClient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PTNetworkManager.NativeMethodInfoPtr_OnStopClient_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F0A RID: 12042 RVA: 0x000D90F0 File Offset: 0x000D72F0
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 99917, RefRangeEnd = 99938, XrefRangeStart = 99914, XrefRangeEnd = 99917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Player GetPlayerPrefab(int connId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref connId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PTNetworkManager.NativeMethodInfoPtr_GetPlayerPrefab_Public_Player_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
			}
		}

		// Token: 0x06002F0B RID: 12043 RVA: 0x000D913C File Offset: 0x000D733C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99938, XrefRangeEnd = 99945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddUserForConnID(int connId, AuthUserData userData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref connId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(userData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PTNetworkManager.NativeMethodInfoPtr_AddUserForConnID_Public_Void_Int32_AuthUserData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F0C RID: 12044 RVA: 0x000D918C File Offset: 0x000D738C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99945, XrefRangeEnd = 99948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AuthUserData GetUserDataFromConnID(int connId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref connId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PTNetworkManager.NativeMethodInfoPtr_GetUserDataFromConnID_Public_AuthUserData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AuthUserData>(intPtr3) : null;
			}
		}

		// Token: 0x06002F0D RID: 12045 RVA: 0x000D91D8 File Offset: 0x000D73D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99948, XrefRangeEnd = 99973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<int> GetConnectedUserIDs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PTNetworkManager.NativeMethodInfoPtr_GetConnectedUserIDs_Public_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr3) : null;
		}

		// Token: 0x06002F0E RID: 12046 RVA: 0x00012D75 File Offset: 0x00010F75
		public PTNetworkManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700109B RID: 4251
		// (get) Token: 0x06002F0F RID: 12047 RVA: 0x000D9218 File Offset: 0x000D7418
		// (set) Token: 0x06002F10 RID: 12048 RVA: 0x00012D7E File Offset: 0x00010F7E
		public unsafe Dictionary<int, AuthUserData> playerConnData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PTNetworkManager.NativeFieldInfoPtr_playerConnData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, AuthUserData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PTNetworkManager.NativeFieldInfoPtr_playerConnData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700109C RID: 4252
		// (get) Token: 0x06002F11 RID: 12049 RVA: 0x000D9248 File Offset: 0x000D7448
		// (set) Token: 0x06002F12 RID: 12050 RVA: 0x00012D9D File Offset: 0x00010F9D
		public unsafe Dictionary<int, Player> playerPrefabs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PTNetworkManager.NativeFieldInfoPtr_playerPrefabs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Player>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PTNetworkManager.NativeFieldInfoPtr_playerPrefabs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700109D RID: 4253
		// (get) Token: 0x06002F13 RID: 12051 RVA: 0x000D9278 File Offset: 0x000D7478
		// (set) Token: 0x06002F14 RID: 12052 RVA: 0x00012DBC File Offset: 0x00010FBC
		public unsafe static PTNetworkManager instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PTNetworkManager.NativeFieldInfoPtr_instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PTNetworkManager>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PTNetworkManager.NativeFieldInfoPtr_instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700109E RID: 4254
		// (get) Token: 0x06002F15 RID: 12053 RVA: 0x000D92A0 File Offset: 0x000D74A0
		// (set) Token: 0x06002F16 RID: 12054 RVA: 0x00012DCE File Offset: 0x00010FCE
		public unsafe float serverHeartbeatRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PTNetworkManager.NativeFieldInfoPtr_serverHeartbeatRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PTNetworkManager.NativeFieldInfoPtr_serverHeartbeatRate)) = value;
			}
		}

		// Token: 0x1700109F RID: 4255
		// (get) Token: 0x06002F17 RID: 12055 RVA: 0x000D92C8 File Offset: 0x000D74C8
		// (set) Token: 0x06002F18 RID: 12056 RVA: 0x00012DE9 File Offset: 0x00010FE9
		public unsafe int maxServerTimeout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PTNetworkManager.NativeFieldInfoPtr_maxServerTimeout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PTNetworkManager.NativeFieldInfoPtr_maxServerTimeout)) = value;
			}
		}

		// Token: 0x170010A0 RID: 4256
		// (get) Token: 0x06002F19 RID: 12057 RVA: 0x000D92F0 File Offset: 0x000D74F0
		// (set) Token: 0x06002F1A RID: 12058 RVA: 0x00012E04 File Offset: 0x00011004
		public unsafe int emptyServerPings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PTNetworkManager.NativeFieldInfoPtr_emptyServerPings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PTNetworkManager.NativeFieldInfoPtr_emptyServerPings)) = value;
			}
		}

		// Token: 0x040023D9 RID: 9177
		private static readonly IntPtr NativeFieldInfoPtr_playerConnData;

		// Token: 0x040023DA RID: 9178
		private static readonly IntPtr NativeFieldInfoPtr_playerPrefabs;

		// Token: 0x040023DB RID: 9179
		private static readonly IntPtr NativeFieldInfoPtr_instance;

		// Token: 0x040023DC RID: 9180
		private static readonly IntPtr NativeFieldInfoPtr_serverHeartbeatRate;

		// Token: 0x040023DD RID: 9181
		private static readonly IntPtr NativeFieldInfoPtr_maxServerTimeout;

		// Token: 0x040023DE RID: 9182
		private static readonly IntPtr NativeFieldInfoPtr_emptyServerPings;

		// Token: 0x040023DF RID: 9183
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040023E0 RID: 9184
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x040023E1 RID: 9185
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Public_Virtual_Void_0;

		// Token: 0x040023E2 RID: 9186
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Virtual_Void_0;

		// Token: 0x040023E3 RID: 9187
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Public_Virtual_Void_0;

		// Token: 0x040023E4 RID: 9188
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Public_Virtual_Void_0;

		// Token: 0x040023E5 RID: 9189
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureHeadlessFrameRate_Public_Virtual_Void_0;

		// Token: 0x040023E6 RID: 9190
		private static readonly IntPtr NativeMethodInfoPtr_OnApplicationQuit_Public_Virtual_Void_0;

		// Token: 0x040023E7 RID: 9191
		private static readonly IntPtr NativeMethodInfoPtr_ServerChangeScene_Public_Virtual_Void_String_0;

		// Token: 0x040023E8 RID: 9192
		private static readonly IntPtr NativeMethodInfoPtr_OnServerChangeScene_Public_Virtual_Void_String_0;

		// Token: 0x040023E9 RID: 9193
		private static readonly IntPtr NativeMethodInfoPtr_OnServerSceneChanged_Public_Virtual_Void_String_0;

		// Token: 0x040023EA RID: 9194
		private static readonly IntPtr NativeMethodInfoPtr_OnClientChangeScene_Public_Virtual_Void_String_SceneOperation_Boolean_0;

		// Token: 0x040023EB RID: 9195
		private static readonly IntPtr NativeMethodInfoPtr_OnClientSceneChanged_Public_Virtual_Void_0;

		// Token: 0x040023EC RID: 9196
		private static readonly IntPtr NativeMethodInfoPtr_OnServerConnect_Public_Virtual_Void_NetworkConnectionToClient_0;

		// Token: 0x040023ED RID: 9197
		private static readonly IntPtr NativeMethodInfoPtr_OnServerReady_Public_Virtual_Void_NetworkConnectionToClient_0;

		// Token: 0x040023EE RID: 9198
		private static readonly IntPtr NativeMethodInfoPtr_OnServerAddPlayer_Public_Virtual_Void_NetworkConnectionToClient_0;

		// Token: 0x040023EF RID: 9199
		private static readonly IntPtr NativeMethodInfoPtr_OnServerDisconnect_Public_Virtual_Void_NetworkConnectionToClient_0;

		// Token: 0x040023F0 RID: 9200
		private static readonly IntPtr NativeMethodInfoPtr_OnServerError_Public_Virtual_Void_NetworkConnectionToClient_TransportError_String_0;

		// Token: 0x040023F1 RID: 9201
		private static readonly IntPtr NativeMethodInfoPtr_OnClientConnect_Public_Virtual_Void_0;

		// Token: 0x040023F2 RID: 9202
		private static readonly IntPtr NativeMethodInfoPtr_OnClientDisconnect_Public_Virtual_Void_0;

		// Token: 0x040023F3 RID: 9203
		private static readonly IntPtr NativeMethodInfoPtr_OnClientNotReady_Public_Virtual_Void_0;

		// Token: 0x040023F4 RID: 9204
		private static readonly IntPtr NativeMethodInfoPtr_OnClientError_Public_Virtual_Void_TransportError_String_0;

		// Token: 0x040023F5 RID: 9205
		private static readonly IntPtr NativeMethodInfoPtr_OnStartHost_Public_Virtual_Void_0;

		// Token: 0x040023F6 RID: 9206
		private static readonly IntPtr NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0;

		// Token: 0x040023F7 RID: 9207
		private static readonly IntPtr NativeMethodInfoPtr_ClientConnected_Public_Void_Int32_0;

		// Token: 0x040023F8 RID: 9208
		private static readonly IntPtr NativeMethodInfoPtr_ClientDisconnected_Public_Void_Int32_0;

		// Token: 0x040023F9 RID: 9209
		private static readonly IntPtr NativeMethodInfoPtr_ShutdownServer_Public_Void_0;

		// Token: 0x040023FA RID: 9210
		private static readonly IntPtr NativeMethodInfoPtr_LogEvent_Private_IEnumerator_ServerEventType_Dictionary_2_String_String_Boolean_0;

		// Token: 0x040023FB RID: 9211
		private static readonly IntPtr NativeMethodInfoPtr_HeartbeatLoop_Private_IEnumerator_0;

		// Token: 0x040023FC RID: 9212
		private static readonly IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0;

		// Token: 0x040023FD RID: 9213
		private static readonly IntPtr NativeMethodInfoPtr_OnStopHost_Public_Virtual_Void_0;

		// Token: 0x040023FE RID: 9214
		private static readonly IntPtr NativeMethodInfoPtr_OnStopServer_Public_Virtual_Void_0;

		// Token: 0x040023FF RID: 9215
		private static readonly IntPtr NativeMethodInfoPtr_OnStopClient_Public_Virtual_Void_0;

		// Token: 0x04002400 RID: 9216
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerPrefab_Public_Player_Int32_0;

		// Token: 0x04002401 RID: 9217
		private static readonly IntPtr NativeMethodInfoPtr_AddUserForConnID_Public_Void_Int32_AuthUserData_0;

		// Token: 0x04002402 RID: 9218
		private static readonly IntPtr NativeMethodInfoPtr_GetUserDataFromConnID_Public_AuthUserData_Int32_0;

		// Token: 0x04002403 RID: 9219
		private static readonly IntPtr NativeMethodInfoPtr_GetConnectedUserIDs_Public_List_1_Int32_0;

		// Token: 0x020003E9 RID: 1001
		public enum ServerEventType
		{
			// Token: 0x04003C2C RID: 15404
			ServerStarted,
			// Token: 0x04003C2D RID: 15405
			ServerStopped,
			// Token: 0x04003C2E RID: 15406
			ClientConnected,
			// Token: 0x04003C2F RID: 15407
			ClientDisconnected
		}

		// Token: 0x020003EA RID: 1002
		[ObfuscatedName("Polytoria.Networking.PTNetworkManager+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06004D94 RID: 19860 RVA: 0x00150A80 File Offset: 0x0014EC80
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PTNetworkManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PTNetworkManager>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PTNetworkManager.__c>.NativeClassPtr);
				PTNetworkManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PTNetworkManager.__c>.NativeClassPtr, "<>9");
				PTNetworkManager.__c.NativeFieldInfoPtr___9__42_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PTNetworkManager.__c>.NativeClassPtr, "<>9__42_0");
				PTNetworkManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PTNetworkManager.__c>.NativeClassPtr, 100670354);
				PTNetworkManager.__c.NativeMethodInfoPtr__GetConnectedUserIDs_b__42_0_Internal_Int32_AuthUserData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PTNetworkManager.__c>.NativeClassPtr, 100670355);
			}

			// Token: 0x06004D95 RID: 19861 RVA: 0x00150AFC File Offset: 0x0014ECFC
			[CallerCount(2275)]
			[CachedScanResults(RefRangeStart = 7, RefRangeEnd = 2282, XrefRangeStart = 7, XrefRangeEnd = 2282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PTNetworkManager.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PTNetworkManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004D96 RID: 19862 RVA: 0x00150B38 File Offset: 0x0014ED38
			[CallerCount(0)]
			public unsafe int _GetConnectedUserIDs_b__42_0(AuthUserData i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(i);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PTNetworkManager.__c.NativeMethodInfoPtr__GetConnectedUserIDs_b__42_0_Internal_Int32_AuthUserData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004D97 RID: 19863 RVA: 0x0001D584 File Offset: 0x0001B784
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001A21 RID: 6689
			// (get) Token: 0x06004D98 RID: 19864 RVA: 0x00150B88 File Offset: 0x0014ED88
			// (set) Token: 0x06004D99 RID: 19865 RVA: 0x0001D58D File Offset: 0x0001B78D
			public unsafe static PTNetworkManager.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PTNetworkManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PTNetworkManager.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PTNetworkManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A22 RID: 6690
			// (get) Token: 0x06004D9A RID: 19866 RVA: 0x00150BB0 File Offset: 0x0014EDB0
			// (set) Token: 0x06004D9B RID: 19867 RVA: 0x0001D59F File Offset: 0x0001B79F
			public unsafe static Func<AuthUserData, int> __9__42_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PTNetworkManager.__c.NativeFieldInfoPtr___9__42_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AuthUserData, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PTNetworkManager.__c.NativeFieldInfoPtr___9__42_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003C30 RID: 15408
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04003C31 RID: 15409
			private static readonly IntPtr NativeFieldInfoPtr___9__42_0;

			// Token: 0x04003C32 RID: 15410
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003C33 RID: 15411
			private static readonly IntPtr NativeMethodInfoPtr__GetConnectedUserIDs_b__42_0_Internal_Int32_AuthUserData_0;
		}

		// Token: 0x020003EB RID: 1003
		[ObfuscatedName("Polytoria.Networking.PTNetworkManager+<HeartbeatLoop>d__33")]
		public sealed class _HeartbeatLoop_d__33 : Object
		{
			// Token: 0x06004D9C RID: 19868 RVA: 0x00150BD8 File Offset: 0x0014EDD8
			// Note: this type is marked as 'beforefieldinit'.
			static _HeartbeatLoop_d__33()
			{
				Il2CppClassPointerStore<PTNetworkManager._HeartbeatLoop_d__33>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PTNetworkManager>.NativeClassPtr, "<HeartbeatLoop>d__33");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PTNetworkManager._HeartbeatLoop_d__33>.NativeClassPtr);
				PTNetworkManager._HeartbeatLoop_d__33.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PTNetworkManager._HeartbeatLoop_d__33>.NativeClassPtr, "<>1__state");
				PTNetworkManager._HeartbeatLoop_d__33.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PTNetworkManager._HeartbeatLoop_d__33>.NativeClassPtr, "<>2__current");
				PTNetworkManager._HeartbeatLoop_d__33.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PTNetworkManager._HeartbeatLoop_d__33>.NativeClassPtr, "<>4__this");
				PTNetworkManager._HeartbeatLoop_d__33.NativeFieldInfoPtr__uwr_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PTNetworkManager._HeartbeatLoop_d__33>.NativeClassPtr, "<uwr>5__2");
				PTNetworkManager._HeartbeatLoop_d__33.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PTNetworkManager._HeartbeatLoop_d__33>.NativeClassPtr, 100670360);
				PTNetworkManager._HeartbeatLoop_d__33.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PTNetworkManager._HeartbeatLoop_d__33>.NativeClassPtr, 100670362);
				PTNetworkManager._HeartbeatLoop_d__33.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PTNetworkManager._HeartbeatLoop_d__33>.NativeClassPtr, 100670356);
				PTNetworkManager._HeartbeatLoop_d__33.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PTNetworkManager._HeartbeatLoop_d__33>.NativeClassPtr, 100670357);
				PTNetworkManager._HeartbeatLoop_d__33.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PTNetworkManager._HeartbeatLoop_d__33>.NativeClassPtr, 100670358);
				PTNetworkManager._HeartbeatLoop_d__33.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PTNetworkManager._HeartbeatLoop_d__33>.NativeClassPtr, 100670359);
				PTNetworkManager._HeartbeatLoop_d__33.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PTNetworkManager._HeartbeatLoop_d__33>.NativeClassPtr, 100670361);
			}

			// Token: 0x17001A27 RID: 6695
			// (get) Token: 0x06004D9D RID: 19869 RVA: 0x00150CE0 File Offset: 0x0014EEE0
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PTNetworkManager._HeartbeatLoop_d__33.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001A28 RID: 6696
			// (get) Token: 0x06004D9E RID: 19870 RVA: 0x00150D20 File Offset: 0x0014EF20
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PTNetworkManager._HeartbeatLoop_d__33.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004D9F RID: 19871 RVA: 0x00150D60 File Offset: 0x0014EF60
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 10168, RefRangeEnd = 10216, XrefRangeStart = 10168, XrefRangeEnd = 10216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _HeartbeatLoop_d__33(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PTNetworkManager._HeartbeatLoop_d__33>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PTNetworkManager._HeartbeatLoop_d__33.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004DA0 RID: 19872 RVA: 0x00150DA8 File Offset: 0x0014EFA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99520, XrefRangeEnd = 99525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PTNetworkManager._HeartbeatLoop_d__33.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004DA1 RID: 19873 RVA: 0x00150DDC File Offset: 0x0014EFDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99525, XrefRangeEnd = 99654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PTNetworkManager._HeartbeatLoop_d__33.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004DA2 RID: 19874 RVA: 0x00150E18 File Offset: 0x0014F018
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99654, XrefRangeEnd = 99657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PTNetworkManager._HeartbeatLoop_d__33.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004DA3 RID: 19875 RVA: 0x00150E4C File Offset: 0x0014F04C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99657, XrefRangeEnd = 99662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PTNetworkManager._HeartbeatLoop_d__33.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004DA4 RID: 19876 RVA: 0x0001D5B1 File Offset: 0x0001B7B1
			public _HeartbeatLoop_d__33(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001A23 RID: 6691
			// (get) Token: 0x06004DA5 RID: 19877 RVA: 0x00150E80 File Offset: 0x0014F080
			// (set) Token: 0x06004DA6 RID: 19878 RVA: 0x0001D5BA File Offset: 0x0001B7BA
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PTNetworkManager._HeartbeatLoop_d__33.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PTNetworkManager._HeartbeatLoop_d__33.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001A24 RID: 6692
			// (get) Token: 0x06004DA7 RID: 19879 RVA: 0x00150EA8 File Offset: 0x0014F0A8
			// (set) Token: 0x06004DA8 RID: 19880 RVA: 0x0001D5D5 File Offset: 0x0001B7D5
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PTNetworkManager._HeartbeatLoop_d__33.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PTNetworkManager._HeartbeatLoop_d__33.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A25 RID: 6693
			// (get) Token: 0x06004DA9 RID: 19881 RVA: 0x00150ED8 File Offset: 0x0014F0D8
			// (set) Token: 0x06004DAA RID: 19882 RVA: 0x0001D5F4 File Offset: 0x0001B7F4
			public unsafe PTNetworkManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PTNetworkManager._HeartbeatLoop_d__33.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PTNetworkManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PTNetworkManager._HeartbeatLoop_d__33.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A26 RID: 6694
			// (get) Token: 0x06004DAB RID: 19883 RVA: 0x00150F08 File Offset: 0x0014F108
			// (set) Token: 0x06004DAC RID: 19884 RVA: 0x0001D613 File Offset: 0x0001B813
			public unsafe UnityWebRequest _uwr_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PTNetworkManager._HeartbeatLoop_d__33.NativeFieldInfoPtr__uwr_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PTNetworkManager._HeartbeatLoop_d__33.NativeFieldInfoPtr__uwr_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003C34 RID: 15412
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003C35 RID: 15413
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003C36 RID: 15414
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003C37 RID: 15415
			private static readonly IntPtr NativeFieldInfoPtr__uwr_5__2;

			// Token: 0x04003C38 RID: 15416
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003C39 RID: 15417
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003C3A RID: 15418
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003C3B RID: 15419
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003C3C RID: 15420
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003C3D RID: 15421
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04003C3E RID: 15422
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}

		// Token: 0x020003EC RID: 1004
		[ObfuscatedName("Polytoria.Networking.PTNetworkManager+<LogEvent>d__32")]
		public sealed class _LogEvent_d__32 : Object
		{
			// Token: 0x06004DAD RID: 19885 RVA: 0x00150F38 File Offset: 0x0014F138
			// Note: this type is marked as 'beforefieldinit'.
			static _LogEvent_d__32()
			{
				Il2CppClassPointerStore<PTNetworkManager._LogEvent_d__32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PTNetworkManager>.NativeClassPtr, "<LogEvent>d__32");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PTNetworkManager._LogEvent_d__32>.NativeClassPtr);
				PTNetworkManager._LogEvent_d__32.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PTNetworkManager._LogEvent_d__32>.NativeClassPtr, "<>1__state");
				PTNetworkManager._LogEvent_d__32.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PTNetworkManager._LogEvent_d__32>.NativeClassPtr, "<>2__current");
				PTNetworkManager._LogEvent_d__32.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PTNetworkManager._LogEvent_d__32>.NativeClassPtr, 100670366);
				PTNetworkManager._LogEvent_d__32.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PTNetworkManager._LogEvent_d__32>.NativeClassPtr, 100670368);
				PTNetworkManager._LogEvent_d__32.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PTNetworkManager._LogEvent_d__32>.NativeClassPtr, 100670363);
				PTNetworkManager._LogEvent_d__32.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PTNetworkManager._LogEvent_d__32>.NativeClassPtr, 100670364);
				PTNetworkManager._LogEvent_d__32.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PTNetworkManager._LogEvent_d__32>.NativeClassPtr, 100670365);
				PTNetworkManager._LogEvent_d__32.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PTNetworkManager._LogEvent_d__32>.NativeClassPtr, 100670367);
			}

			// Token: 0x17001A2B RID: 6699
			// (get) Token: 0x06004DAE RID: 19886 RVA: 0x00151004 File Offset: 0x0014F204
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PTNetworkManager._LogEvent_d__32.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001A2C RID: 6700
			// (get) Token: 0x06004DAF RID: 19887 RVA: 0x00151044 File Offset: 0x0014F244
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PTNetworkManager._LogEvent_d__32.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004DB0 RID: 19888 RVA: 0x00151084 File Offset: 0x0014F284
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 10168, RefRangeEnd = 10216, XrefRangeStart = 10168, XrefRangeEnd = 10216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _LogEvent_d__32(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PTNetworkManager._LogEvent_d__32>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PTNetworkManager._LogEvent_d__32.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004DB1 RID: 19889 RVA: 0x001510CC File Offset: 0x0014F2CC
			[CallerCount(7535)]
			[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PTNetworkManager._LogEvent_d__32.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004DB2 RID: 19890 RVA: 0x00151100 File Offset: 0x0014F300
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99662, XrefRangeEnd = 99667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PTNetworkManager._LogEvent_d__32.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004DB3 RID: 19891 RVA: 0x0015113C File Offset: 0x0014F33C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99667, XrefRangeEnd = 99672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PTNetworkManager._LogEvent_d__32.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004DB4 RID: 19892 RVA: 0x0001D632 File Offset: 0x0001B832
			public _LogEvent_d__32(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001A29 RID: 6697
			// (get) Token: 0x06004DB5 RID: 19893 RVA: 0x00151170 File Offset: 0x0014F370
			// (set) Token: 0x06004DB6 RID: 19894 RVA: 0x0001D63B File Offset: 0x0001B83B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PTNetworkManager._LogEvent_d__32.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PTNetworkManager._LogEvent_d__32.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001A2A RID: 6698
			// (get) Token: 0x06004DB7 RID: 19895 RVA: 0x00151198 File Offset: 0x0014F398
			// (set) Token: 0x06004DB8 RID: 19896 RVA: 0x0001D656 File Offset: 0x0001B856
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PTNetworkManager._LogEvent_d__32.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PTNetworkManager._LogEvent_d__32.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003C3F RID: 15423
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003C40 RID: 15424
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003C41 RID: 15425
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003C42 RID: 15426
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003C43 RID: 15427
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003C44 RID: 15428
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003C45 RID: 15429
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003C46 RID: 15430
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}
	}
}
