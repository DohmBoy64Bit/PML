using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text;

namespace Discord
{
	// Token: 0x0200015F RID: 351
	public class LobbyManager : Object
	{
		// Token: 0x06001779 RID: 6009 RVA: 0x000760E8 File Offset: 0x000742E8
		// Note: this type is marked as 'beforefieldinit'.
		static LobbyManager()
		{
			Il2CppClassPointerStore<LobbyManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Discord", "LobbyManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr);
			LobbyManager.NativeFieldInfoPtr_MethodsPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, "MethodsPtr");
			LobbyManager.NativeFieldInfoPtr_MethodsStructure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, "MethodsStructure");
			LobbyManager.NativeFieldInfoPtr_OnLobbyUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, "OnLobbyUpdate");
			LobbyManager.NativeFieldInfoPtr_OnLobbyDelete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, "OnLobbyDelete");
			LobbyManager.NativeFieldInfoPtr_OnMemberConnect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, "OnMemberConnect");
			LobbyManager.NativeFieldInfoPtr_OnMemberUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, "OnMemberUpdate");
			LobbyManager.NativeFieldInfoPtr_OnMemberDisconnect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, "OnMemberDisconnect");
			LobbyManager.NativeFieldInfoPtr_OnLobbyMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, "OnLobbyMessage");
			LobbyManager.NativeFieldInfoPtr_OnSpeaking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, "OnSpeaking");
			LobbyManager.NativeFieldInfoPtr_OnNetworkMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, "OnNetworkMessage");
			LobbyManager.NativeMethodInfoPtr_get_Methods_Private_get_FFIMethods_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, 100667652);
			LobbyManager.NativeMethodInfoPtr_add_OnLobbyUpdate_Public_add_Void_LobbyUpdateHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, 100667653);
			LobbyManager.NativeMethodInfoPtr_remove_OnLobbyUpdate_Public_rem_Void_LobbyUpdateHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, 100667654);
			LobbyManager.NativeMethodInfoPtr_add_OnLobbyDelete_Public_add_Void_LobbyDeleteHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, 100667655);
			LobbyManager.NativeMethodInfoPtr_remove_OnLobbyDelete_Public_rem_Void_LobbyDeleteHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, 100667656);
			LobbyManager.NativeMethodInfoPtr_add_OnMemberConnect_Public_add_Void_MemberConnectHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, 100667657);
			LobbyManager.NativeMethodInfoPtr_remove_OnMemberConnect_Public_rem_Void_MemberConnectHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, 100667658);
			LobbyManager.NativeMethodInfoPtr_add_OnMemberUpdate_Public_add_Void_MemberUpdateHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, 100667659);
			LobbyManager.NativeMethodInfoPtr_remove_OnMemberUpdate_Public_rem_Void_MemberUpdateHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, 100667660);
			LobbyManager.NativeMethodInfoPtr_add_OnMemberDisconnect_Public_add_Void_MemberDisconnectHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, 100667661);
			LobbyManager.NativeMethodInfoPtr_remove_OnMemberDisconnect_Public_rem_Void_MemberDisconnectHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, 100667662);
			LobbyManager.NativeMethodInfoPtr_add_OnLobbyMessage_Public_add_Void_LobbyMessageHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, 100667663);
			LobbyManager.NativeMethodInfoPtr_remove_OnLobbyMessage_Public_rem_Void_LobbyMessageHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, 100667664);
			LobbyManager.NativeMethodInfoPtr_add_OnSpeaking_Public_add_Void_SpeakingHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, 100667665);
			LobbyManager.NativeMethodInfoPtr_remove_OnSpeaking_Public_rem_Void_SpeakingHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, 100667666);
			LobbyManager.NativeMethodInfoPtr_add_OnNetworkMessage_Public_add_Void_NetworkMessageHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, 100667667);
			LobbyManager.NativeMethodInfoPtr_remove_OnNetworkMessage_Public_rem_Void_NetworkMessageHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, 100667668);
			LobbyManager.NativeMethodInfoPtr__ctor_Internal_Void_IntPtr_IntPtr_byref_FFIEvents_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, 100667669);
			LobbyManager.NativeMethodInfoPtr_InitEvents_Private_Void_IntPtr_byref_FFIEvents_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, 100667670);
			LobbyManager.NativeMethodInfoPtr_GetLobbyCreateTransaction_Public_LobbyTransaction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, 100667671);
			LobbyManager.NativeMethodInfoPtr_GetLobbyUpdateTransaction_Public_LobbyTransaction_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, 100667672);
			LobbyManager.NativeMethodInfoPtr_GetMemberUpdateTransaction_Public_LobbyMemberTransaction_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, 100667673);
			LobbyManager.NativeMethodInfoPtr_CreateLobbyCallbackImpl_Private_Static_Void_IntPtr_Result_byref_Lobby_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, 100667674);
			LobbyManager.NativeMethodInfoPtr_CreateLobby_Public_Void_LobbyTransaction_CreateLobbyHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, 100667675);
			LobbyManager.NativeMethodInfoPtr_UpdateLobbyCallbackImpl_Private_Static_Void_IntPtr_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, 100667676);
			LobbyManager.NativeMethodInfoPtr_UpdateLobby_Public_Void_Int64_LobbyTransaction_UpdateLobbyHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, 100667677);
			LobbyManager.NativeMethodInfoPtr_DeleteLobbyCallbackImpl_Private_Static_Void_IntPtr_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, 100667678);
			LobbyManager.NativeMethodInfoPtr_DeleteLobby_Public_Void_Int64_DeleteLobbyHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, 100667679);
			LobbyManager.NativeMethodInfoPtr_ConnectLobbyCallbackImpl_Private_Static_Void_IntPtr_Result_byref_Lobby_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, 100667680);
			LobbyManager.NativeMethodInfoPtr_ConnectLobby_Public_Void_Int64_String_ConnectLobbyHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, 100667681);
			LobbyManager.NativeMethodInfoPtr_ConnectLobbyWithActivitySecretCallbackImpl_Private_Static_Void_IntPtr_Result_byref_Lobby_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, 100667682);
			LobbyManager.NativeMethodInfoPtr_ConnectLobbyWithActivitySecret_Public_Void_String_ConnectLobbyWithActivitySecretHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, 100667683);
			LobbyManager.NativeMethodInfoPtr_DisconnectLobbyCallbackImpl_Private_Static_Void_IntPtr_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, 100667684);
			LobbyManager.NativeMethodInfoPtr_DisconnectLobby_Public_Void_Int64_DisconnectLobbyHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, 100667685);
			LobbyManager.NativeMethodInfoPtr_GetLobby_Public_Lobby_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, 100667686);
			LobbyManager.NativeMethodInfoPtr_GetLobbyActivitySecret_Public_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, 100667687);
			LobbyManager.NativeMethodInfoPtr_GetLobbyMetadataValue_Public_String_Int64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, 100667688);
			LobbyManager.NativeMethodInfoPtr_GetLobbyMetadataKey_Public_String_Int64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, 100667689);
			LobbyManager.NativeMethodInfoPtr_LobbyMetadataCount_Public_Int32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, 100667690);
			LobbyManager.NativeMethodInfoPtr_MemberCount_Public_Int32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, 100667691);
			LobbyManager.NativeMethodInfoPtr_GetMemberUserId_Public_Int64_Int64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, 100667692);
			LobbyManager.NativeMethodInfoPtr_GetMemberUser_Public_User_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, 100667693);
			LobbyManager.NativeMethodInfoPtr_GetMemberMetadataValue_Public_String_Int64_Int64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, 100667694);
			LobbyManager.NativeMethodInfoPtr_GetMemberMetadataKey_Public_String_Int64_Int64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, 100667695);
			LobbyManager.NativeMethodInfoPtr_MemberMetadataCount_Public_Int32_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, 100667696);
			LobbyManager.NativeMethodInfoPtr_UpdateMemberCallbackImpl_Private_Static_Void_IntPtr_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, 100667697);
			LobbyManager.NativeMethodInfoPtr_UpdateMember_Public_Void_Int64_Int64_LobbyMemberTransaction_UpdateMemberHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, 100667698);
			LobbyManager.NativeMethodInfoPtr_SendLobbyMessageCallbackImpl_Private_Static_Void_IntPtr_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, 100667699);
			LobbyManager.NativeMethodInfoPtr_SendLobbyMessage_Public_Void_Int64_Il2CppStructArray_1_Byte_SendLobbyMessageHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, 100667700);
			LobbyManager.NativeMethodInfoPtr_GetSearchQuery_Public_LobbySearchQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, 100667701);
			LobbyManager.NativeMethodInfoPtr_SearchCallbackImpl_Private_Static_Void_IntPtr_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, 100667702);
			LobbyManager.NativeMethodInfoPtr_Search_Public_Void_LobbySearchQuery_SearchHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, 100667703);
			LobbyManager.NativeMethodInfoPtr_LobbyCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, 100667704);
			LobbyManager.NativeMethodInfoPtr_GetLobbyId_Public_Int64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, 100667705);
			LobbyManager.NativeMethodInfoPtr_ConnectVoiceCallbackImpl_Private_Static_Void_IntPtr_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, 100667706);
			LobbyManager.NativeMethodInfoPtr_ConnectVoice_Public_Void_Int64_ConnectVoiceHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, 100667707);
			LobbyManager.NativeMethodInfoPtr_DisconnectVoiceCallbackImpl_Private_Static_Void_IntPtr_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, 100667708);
			LobbyManager.NativeMethodInfoPtr_DisconnectVoice_Public_Void_Int64_DisconnectVoiceHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, 100667709);
			LobbyManager.NativeMethodInfoPtr_ConnectNetwork_Public_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, 100667710);
			LobbyManager.NativeMethodInfoPtr_DisconnectNetwork_Public_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, 100667711);
			LobbyManager.NativeMethodInfoPtr_FlushNetwork_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, 100667712);
			LobbyManager.NativeMethodInfoPtr_OpenNetworkChannel_Public_Void_Int64_Byte_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, 100667713);
			LobbyManager.NativeMethodInfoPtr_SendNetworkMessage_Public_Void_Int64_Int64_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, 100667714);
			LobbyManager.NativeMethodInfoPtr_OnLobbyUpdateImpl_Private_Static_Void_IntPtr_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, 100667715);
			LobbyManager.NativeMethodInfoPtr_OnLobbyDeleteImpl_Private_Static_Void_IntPtr_Int64_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, 100667716);
			LobbyManager.NativeMethodInfoPtr_OnMemberConnectImpl_Private_Static_Void_IntPtr_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, 100667717);
			LobbyManager.NativeMethodInfoPtr_OnMemberUpdateImpl_Private_Static_Void_IntPtr_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, 100667718);
			LobbyManager.NativeMethodInfoPtr_OnMemberDisconnectImpl_Private_Static_Void_IntPtr_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, 100667719);
			LobbyManager.NativeMethodInfoPtr_OnLobbyMessageImpl_Private_Static_Void_IntPtr_Int64_Int64_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, 100667720);
			LobbyManager.NativeMethodInfoPtr_OnSpeakingImpl_Private_Static_Void_IntPtr_Int64_Int64_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, 100667721);
			LobbyManager.NativeMethodInfoPtr_OnNetworkMessageImpl_Private_Static_Void_IntPtr_Int64_Int64_Byte_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, 100667722);
			LobbyManager.NativeMethodInfoPtr_GetMemberUsers_Public_IEnumerable_1_User_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, 100667723);
			LobbyManager.NativeMethodInfoPtr_SendLobbyMessage_Public_Void_Int64_String_SendLobbyMessageHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, 100667724);
		}

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x0600177A RID: 6010 RVA: 0x00076794 File Offset: 0x00074994
		public unsafe LobbyManager.FFIMethods Methods
		{
			[CallerCount(37)]
			[CachedScanResults(RefRangeStart = 53673, RefRangeEnd = 53710, XrefRangeStart = 53660, XrefRangeEnd = 53673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NativeMethodInfoPtr_get_Methods_Private_get_FFIMethods_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new LobbyManager.FFIMethods(intPtr);
			}
		}

		// Token: 0x0600177B RID: 6011 RVA: 0x000767CC File Offset: 0x000749CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53710, XrefRangeEnd = 53714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnLobbyUpdate(LobbyManager.LobbyUpdateHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NativeMethodInfoPtr_add_OnLobbyUpdate_Public_add_Void_LobbyUpdateHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600177C RID: 6012 RVA: 0x00076810 File Offset: 0x00074A10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53714, XrefRangeEnd = 53718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnLobbyUpdate(LobbyManager.LobbyUpdateHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NativeMethodInfoPtr_remove_OnLobbyUpdate_Public_rem_Void_LobbyUpdateHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600177D RID: 6013 RVA: 0x00076854 File Offset: 0x00074A54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53718, XrefRangeEnd = 53722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnLobbyDelete(LobbyManager.LobbyDeleteHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NativeMethodInfoPtr_add_OnLobbyDelete_Public_add_Void_LobbyDeleteHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600177E RID: 6014 RVA: 0x00076898 File Offset: 0x00074A98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53722, XrefRangeEnd = 53726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnLobbyDelete(LobbyManager.LobbyDeleteHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NativeMethodInfoPtr_remove_OnLobbyDelete_Public_rem_Void_LobbyDeleteHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600177F RID: 6015 RVA: 0x000768DC File Offset: 0x00074ADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53726, XrefRangeEnd = 53730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnMemberConnect(LobbyManager.MemberConnectHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NativeMethodInfoPtr_add_OnMemberConnect_Public_add_Void_MemberConnectHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001780 RID: 6016 RVA: 0x00076920 File Offset: 0x00074B20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53730, XrefRangeEnd = 53734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnMemberConnect(LobbyManager.MemberConnectHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NativeMethodInfoPtr_remove_OnMemberConnect_Public_rem_Void_MemberConnectHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001781 RID: 6017 RVA: 0x00076964 File Offset: 0x00074B64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53734, XrefRangeEnd = 53738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnMemberUpdate(LobbyManager.MemberUpdateHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NativeMethodInfoPtr_add_OnMemberUpdate_Public_add_Void_MemberUpdateHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001782 RID: 6018 RVA: 0x000769A8 File Offset: 0x00074BA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53738, XrefRangeEnd = 53742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnMemberUpdate(LobbyManager.MemberUpdateHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NativeMethodInfoPtr_remove_OnMemberUpdate_Public_rem_Void_MemberUpdateHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001783 RID: 6019 RVA: 0x000769EC File Offset: 0x00074BEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53742, XrefRangeEnd = 53746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnMemberDisconnect(LobbyManager.MemberDisconnectHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NativeMethodInfoPtr_add_OnMemberDisconnect_Public_add_Void_MemberDisconnectHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001784 RID: 6020 RVA: 0x00076A30 File Offset: 0x00074C30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53746, XrefRangeEnd = 53750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnMemberDisconnect(LobbyManager.MemberDisconnectHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NativeMethodInfoPtr_remove_OnMemberDisconnect_Public_rem_Void_MemberDisconnectHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001785 RID: 6021 RVA: 0x00076A74 File Offset: 0x00074C74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53750, XrefRangeEnd = 53754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnLobbyMessage(LobbyManager.LobbyMessageHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NativeMethodInfoPtr_add_OnLobbyMessage_Public_add_Void_LobbyMessageHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001786 RID: 6022 RVA: 0x00076AB8 File Offset: 0x00074CB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53754, XrefRangeEnd = 53758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnLobbyMessage(LobbyManager.LobbyMessageHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NativeMethodInfoPtr_remove_OnLobbyMessage_Public_rem_Void_LobbyMessageHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001787 RID: 6023 RVA: 0x00076AFC File Offset: 0x00074CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53758, XrefRangeEnd = 53762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnSpeaking(LobbyManager.SpeakingHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NativeMethodInfoPtr_add_OnSpeaking_Public_add_Void_SpeakingHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001788 RID: 6024 RVA: 0x00076B40 File Offset: 0x00074D40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53762, XrefRangeEnd = 53766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnSpeaking(LobbyManager.SpeakingHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NativeMethodInfoPtr_remove_OnSpeaking_Public_rem_Void_SpeakingHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001789 RID: 6025 RVA: 0x00076B84 File Offset: 0x00074D84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53766, XrefRangeEnd = 53770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnNetworkMessage(LobbyManager.NetworkMessageHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NativeMethodInfoPtr_add_OnNetworkMessage_Public_add_Void_NetworkMessageHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600178A RID: 6026 RVA: 0x00076BC8 File Offset: 0x00074DC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53770, XrefRangeEnd = 53774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnNetworkMessage(LobbyManager.NetworkMessageHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NativeMethodInfoPtr_remove_OnNetworkMessage_Public_rem_Void_NetworkMessageHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600178B RID: 6027 RVA: 0x00076C0C File Offset: 0x00074E0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53774, XrefRangeEnd = 53776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LobbyManager(IntPtr ptr, IntPtr eventsPtr, ref LobbyManager.FFIEvents events)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr))
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eventsPtr;
			ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(events);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NativeMethodInfoPtr__ctor_Internal_Void_IntPtr_IntPtr_byref_FFIEvents_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600178C RID: 6028 RVA: 0x00076C74 File Offset: 0x00074E74
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 53854, RefRangeEnd = 53856, XrefRangeStart = 53776, XrefRangeEnd = 53854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitEvents(IntPtr eventsPtr, ref LobbyManager.FFIEvents events)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventsPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(events);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NativeMethodInfoPtr_InitEvents_Private_Void_IntPtr_byref_FFIEvents_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600178D RID: 6029 RVA: 0x00076CC8 File Offset: 0x00074EC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53856, XrefRangeEnd = 53857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LobbyTransaction GetLobbyCreateTransaction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NativeMethodInfoPtr_GetLobbyCreateTransaction_Public_LobbyTransaction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LobbyTransaction>(intPtr3) : null;
		}

		// Token: 0x0600178E RID: 6030 RVA: 0x00076D08 File Offset: 0x00074F08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53857, XrefRangeEnd = 53858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LobbyTransaction GetLobbyUpdateTransaction(long lobbyId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lobbyId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NativeMethodInfoPtr_GetLobbyUpdateTransaction_Public_LobbyTransaction_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LobbyTransaction>(intPtr3) : null;
			}
		}

		// Token: 0x0600178F RID: 6031 RVA: 0x00076D54 File Offset: 0x00074F54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53858, XrefRangeEnd = 53859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LobbyMemberTransaction GetMemberUpdateTransaction(long lobbyId, long userId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lobbyId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NativeMethodInfoPtr_GetMemberUpdateTransaction_Public_LobbyMemberTransaction_Int64_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LobbyMemberTransaction>(intPtr3) : null;
		}

		// Token: 0x06001790 RID: 6032 RVA: 0x00076DB0 File Offset: 0x00074FB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53859, XrefRangeEnd = 53866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CreateLobbyCallbackImpl(IntPtr ptr, Result result, ref Lobby lobby)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
			ref IntPtr ptr3 = ref ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(lobby);
			ptr3 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NativeMethodInfoPtr_CreateLobbyCallbackImpl_Private_Static_Void_IntPtr_Result_byref_Lobby_0, 0, (void**)ptr2, ref intPtr3);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			lobby = ((intPtr4 == 0) ? null : new Lobby(intPtr4));
		}

		// Token: 0x06001791 RID: 6033 RVA: 0x00076E1C File Offset: 0x0007501C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53866, XrefRangeEnd = 53877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateLobby(LobbyTransaction transaction, LobbyManager.CreateLobbyHandler callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transaction);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NativeMethodInfoPtr_CreateLobby_Public_Void_LobbyTransaction_CreateLobbyHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001792 RID: 6034 RVA: 0x00076E70 File Offset: 0x00075070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53877, XrefRangeEnd = 53884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateLobbyCallbackImpl(IntPtr ptr, Result result)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NativeMethodInfoPtr_UpdateLobbyCallbackImpl_Private_Static_Void_IntPtr_Result_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001793 RID: 6035 RVA: 0x00076EB4 File Offset: 0x000750B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53884, XrefRangeEnd = 53895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateLobby(long lobbyId, LobbyTransaction transaction, LobbyManager.UpdateLobbyHandler callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lobbyId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(transaction);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NativeMethodInfoPtr_UpdateLobby_Public_Void_Int64_LobbyTransaction_UpdateLobbyHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001794 RID: 6036 RVA: 0x00076F18 File Offset: 0x00075118
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53895, XrefRangeEnd = 53902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DeleteLobbyCallbackImpl(IntPtr ptr, Result result)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NativeMethodInfoPtr_DeleteLobbyCallbackImpl_Private_Static_Void_IntPtr_Result_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001795 RID: 6037 RVA: 0x00076F5C File Offset: 0x0007515C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53902, XrefRangeEnd = 53913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeleteLobby(long lobbyId, LobbyManager.DeleteLobbyHandler callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lobbyId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NativeMethodInfoPtr_DeleteLobby_Public_Void_Int64_DeleteLobbyHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001796 RID: 6038 RVA: 0x00076FAC File Offset: 0x000751AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53913, XrefRangeEnd = 53920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ConnectLobbyCallbackImpl(IntPtr ptr, Result result, ref Lobby lobby)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
			ref IntPtr ptr3 = ref ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(lobby);
			ptr3 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NativeMethodInfoPtr_ConnectLobbyCallbackImpl_Private_Static_Void_IntPtr_Result_byref_Lobby_0, 0, (void**)ptr2, ref intPtr3);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			lobby = ((intPtr4 == 0) ? null : new Lobby(intPtr4));
		}

		// Token: 0x06001797 RID: 6039 RVA: 0x00077018 File Offset: 0x00075218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53920, XrefRangeEnd = 53931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConnectLobby(long lobbyId, string secret, LobbyManager.ConnectLobbyHandler callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lobbyId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(secret);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NativeMethodInfoPtr_ConnectLobby_Public_Void_Int64_String_ConnectLobbyHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001798 RID: 6040 RVA: 0x0007707C File Offset: 0x0007527C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53931, XrefRangeEnd = 53938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ConnectLobbyWithActivitySecretCallbackImpl(IntPtr ptr, Result result, ref Lobby lobby)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
			ref IntPtr ptr3 = ref ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(lobby);
			ptr3 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NativeMethodInfoPtr_ConnectLobbyWithActivitySecretCallbackImpl_Private_Static_Void_IntPtr_Result_byref_Lobby_0, 0, (void**)ptr2, ref intPtr3);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			lobby = ((intPtr4 == 0) ? null : new Lobby(intPtr4));
		}

		// Token: 0x06001799 RID: 6041 RVA: 0x000770E8 File Offset: 0x000752E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53938, XrefRangeEnd = 53949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConnectLobbyWithActivitySecret(string activitySecret, LobbyManager.ConnectLobbyWithActivitySecretHandler callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(activitySecret);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NativeMethodInfoPtr_ConnectLobbyWithActivitySecret_Public_Void_String_ConnectLobbyWithActivitySecretHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600179A RID: 6042 RVA: 0x0007713C File Offset: 0x0007533C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53949, XrefRangeEnd = 53956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DisconnectLobbyCallbackImpl(IntPtr ptr, Result result)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NativeMethodInfoPtr_DisconnectLobbyCallbackImpl_Private_Static_Void_IntPtr_Result_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600179B RID: 6043 RVA: 0x00077180 File Offset: 0x00075380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53956, XrefRangeEnd = 53967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisconnectLobby(long lobbyId, LobbyManager.DisconnectLobbyHandler callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lobbyId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NativeMethodInfoPtr_DisconnectLobby_Public_Void_Int64_DisconnectLobbyHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600179C RID: 6044 RVA: 0x000771D0 File Offset: 0x000753D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53967, XrefRangeEnd = 53968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Lobby GetLobby(long lobbyId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lobbyId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NativeMethodInfoPtr_GetLobby_Public_Lobby_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Lobby>(intPtr3) : null;
			}
		}

		// Token: 0x0600179D RID: 6045 RVA: 0x0007721C File Offset: 0x0007541C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53968, XrefRangeEnd = 53979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetLobbyActivitySecret(long lobbyId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lobbyId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NativeMethodInfoPtr_GetLobbyActivitySecret_Public_String_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600179E RID: 6046 RVA: 0x00077260 File Offset: 0x00075460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53979, XrefRangeEnd = 53990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetLobbyMetadataValue(long lobbyId, string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lobbyId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NativeMethodInfoPtr_GetLobbyMetadataValue_Public_String_Int64_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600179F RID: 6047 RVA: 0x000772B8 File Offset: 0x000754B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53990, XrefRangeEnd = 54001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetLobbyMetadataKey(long lobbyId, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lobbyId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NativeMethodInfoPtr_GetLobbyMetadataKey_Public_String_Int64_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060017A0 RID: 6048 RVA: 0x0007730C File Offset: 0x0007550C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54001, XrefRangeEnd = 54002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LobbyMetadataCount(long lobbyId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lobbyId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NativeMethodInfoPtr_LobbyMetadataCount_Public_Int32_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017A1 RID: 6049 RVA: 0x00077358 File Offset: 0x00075558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54002, XrefRangeEnd = 54003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int MemberCount(long lobbyId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lobbyId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NativeMethodInfoPtr_MemberCount_Public_Int32_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017A2 RID: 6050 RVA: 0x000773A4 File Offset: 0x000755A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54003, XrefRangeEnd = 54004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long GetMemberUserId(long lobbyId, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lobbyId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NativeMethodInfoPtr_GetMemberUserId_Public_Int64_Int64_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017A3 RID: 6051 RVA: 0x000773FC File Offset: 0x000755FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54004, XrefRangeEnd = 54005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe User GetMemberUser(long lobbyId, long userId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lobbyId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NativeMethodInfoPtr_GetMemberUser_Public_User_Int64_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<User>(intPtr3) : null;
		}

		// Token: 0x060017A4 RID: 6052 RVA: 0x00077458 File Offset: 0x00075658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54005, XrefRangeEnd = 54016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetMemberMetadataValue(long lobbyId, long userId, string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lobbyId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NativeMethodInfoPtr_GetMemberMetadataValue_Public_String_Int64_Int64_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060017A5 RID: 6053 RVA: 0x000774BC File Offset: 0x000756BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54016, XrefRangeEnd = 54027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetMemberMetadataKey(long lobbyId, long userId, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lobbyId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NativeMethodInfoPtr_GetMemberMetadataKey_Public_String_Int64_Int64_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060017A6 RID: 6054 RVA: 0x0007751C File Offset: 0x0007571C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54027, XrefRangeEnd = 54028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int MemberMetadataCount(long lobbyId, long userId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lobbyId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NativeMethodInfoPtr_MemberMetadataCount_Public_Int32_Int64_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017A7 RID: 6055 RVA: 0x00077574 File Offset: 0x00075774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54028, XrefRangeEnd = 54035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateMemberCallbackImpl(IntPtr ptr, Result result)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NativeMethodInfoPtr_UpdateMemberCallbackImpl_Private_Static_Void_IntPtr_Result_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017A8 RID: 6056 RVA: 0x000775B8 File Offset: 0x000757B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54035, XrefRangeEnd = 54046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMember(long lobbyId, long userId, LobbyMemberTransaction transaction, LobbyManager.UpdateMemberHandler callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lobbyId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(transaction);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NativeMethodInfoPtr_UpdateMember_Public_Void_Int64_Int64_LobbyMemberTransaction_UpdateMemberHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017A9 RID: 6057 RVA: 0x0007762C File Offset: 0x0007582C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54046, XrefRangeEnd = 54053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SendLobbyMessageCallbackImpl(IntPtr ptr, Result result)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NativeMethodInfoPtr_SendLobbyMessageCallbackImpl_Private_Static_Void_IntPtr_Result_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017AA RID: 6058 RVA: 0x00077670 File Offset: 0x00075870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54053, XrefRangeEnd = 54064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendLobbyMessage(long lobbyId, Il2CppStructArray<byte> data, LobbyManager.SendLobbyMessageHandler callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lobbyId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NativeMethodInfoPtr_SendLobbyMessage_Public_Void_Int64_Il2CppStructArray_1_Byte_SendLobbyMessageHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017AB RID: 6059 RVA: 0x000776D4 File Offset: 0x000758D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54064, XrefRangeEnd = 54065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LobbySearchQuery GetSearchQuery()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NativeMethodInfoPtr_GetSearchQuery_Public_LobbySearchQuery_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LobbySearchQuery>(intPtr3) : null;
		}

		// Token: 0x060017AC RID: 6060 RVA: 0x00077714 File Offset: 0x00075914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54065, XrefRangeEnd = 54072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SearchCallbackImpl(IntPtr ptr, Result result)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NativeMethodInfoPtr_SearchCallbackImpl_Private_Static_Void_IntPtr_Result_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017AD RID: 6061 RVA: 0x00077758 File Offset: 0x00075958
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54072, XrefRangeEnd = 54083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Search(LobbySearchQuery query, LobbyManager.SearchHandler callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(query);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NativeMethodInfoPtr_Search_Public_Void_LobbySearchQuery_SearchHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017AE RID: 6062 RVA: 0x000777AC File Offset: 0x000759AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54083, XrefRangeEnd = 54084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LobbyCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NativeMethodInfoPtr_LobbyCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017AF RID: 6063 RVA: 0x000777E8 File Offset: 0x000759E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54084, XrefRangeEnd = 54085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long GetLobbyId(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NativeMethodInfoPtr_GetLobbyId_Public_Int64_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017B0 RID: 6064 RVA: 0x00077834 File Offset: 0x00075A34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54085, XrefRangeEnd = 54092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ConnectVoiceCallbackImpl(IntPtr ptr, Result result)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NativeMethodInfoPtr_ConnectVoiceCallbackImpl_Private_Static_Void_IntPtr_Result_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017B1 RID: 6065 RVA: 0x00077878 File Offset: 0x00075A78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54092, XrefRangeEnd = 54103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConnectVoice(long lobbyId, LobbyManager.ConnectVoiceHandler callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lobbyId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NativeMethodInfoPtr_ConnectVoice_Public_Void_Int64_ConnectVoiceHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017B2 RID: 6066 RVA: 0x000778C8 File Offset: 0x00075AC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54103, XrefRangeEnd = 54110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DisconnectVoiceCallbackImpl(IntPtr ptr, Result result)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NativeMethodInfoPtr_DisconnectVoiceCallbackImpl_Private_Static_Void_IntPtr_Result_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017B3 RID: 6067 RVA: 0x0007790C File Offset: 0x00075B0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54110, XrefRangeEnd = 54121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisconnectVoice(long lobbyId, LobbyManager.DisconnectVoiceHandler callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lobbyId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NativeMethodInfoPtr_DisconnectVoice_Public_Void_Int64_DisconnectVoiceHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017B4 RID: 6068 RVA: 0x0007795C File Offset: 0x00075B5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54121, XrefRangeEnd = 54122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConnectNetwork(long lobbyId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lobbyId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NativeMethodInfoPtr_ConnectNetwork_Public_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017B5 RID: 6069 RVA: 0x0007799C File Offset: 0x00075B9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54122, XrefRangeEnd = 54123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisconnectNetwork(long lobbyId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lobbyId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NativeMethodInfoPtr_DisconnectNetwork_Public_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060017B6 RID: 6070 RVA: 0x000779DC File Offset: 0x00075BDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54123, XrefRangeEnd = 54124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FlushNetwork()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NativeMethodInfoPtr_FlushNetwork_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017B7 RID: 6071 RVA: 0x00077A10 File Offset: 0x00075C10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54124, XrefRangeEnd = 54125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenNetworkChannel(long lobbyId, byte channelId, bool reliable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lobbyId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channelId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reliable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NativeMethodInfoPtr_OpenNetworkChannel_Public_Void_Int64_Byte_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017B8 RID: 6072 RVA: 0x00077A6C File Offset: 0x00075C6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54125, XrefRangeEnd = 54126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendNetworkMessage(long lobbyId, long userId, byte channelId, Il2CppStructArray<byte> data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lobbyId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channelId;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NativeMethodInfoPtr_SendNetworkMessage_Public_Void_Int64_Int64_Byte_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017B9 RID: 6073 RVA: 0x00077ADC File Offset: 0x00075CDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54126, XrefRangeEnd = 54132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnLobbyUpdateImpl(IntPtr ptr, long lobbyId)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lobbyId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NativeMethodInfoPtr_OnLobbyUpdateImpl_Private_Static_Void_IntPtr_Int64_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017BA RID: 6074 RVA: 0x00077B1C File Offset: 0x00075D1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54132, XrefRangeEnd = 54138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnLobbyDeleteImpl(IntPtr ptr, long lobbyId, uint reason)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lobbyId;
			ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reason;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NativeMethodInfoPtr_OnLobbyDeleteImpl_Private_Static_Void_IntPtr_Int64_UInt32_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017BB RID: 6075 RVA: 0x00077B6C File Offset: 0x00075D6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54138, XrefRangeEnd = 54144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnMemberConnectImpl(IntPtr ptr, long lobbyId, long userId)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lobbyId;
			ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NativeMethodInfoPtr_OnMemberConnectImpl_Private_Static_Void_IntPtr_Int64_Int64_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017BC RID: 6076 RVA: 0x00077BBC File Offset: 0x00075DBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54144, XrefRangeEnd = 54150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnMemberUpdateImpl(IntPtr ptr, long lobbyId, long userId)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lobbyId;
			ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NativeMethodInfoPtr_OnMemberUpdateImpl_Private_Static_Void_IntPtr_Int64_Int64_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017BD RID: 6077 RVA: 0x00077C0C File Offset: 0x00075E0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54150, XrefRangeEnd = 54156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnMemberDisconnectImpl(IntPtr ptr, long lobbyId, long userId)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lobbyId;
			ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NativeMethodInfoPtr_OnMemberDisconnectImpl_Private_Static_Void_IntPtr_Int64_Int64_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017BE RID: 6078 RVA: 0x00077C5C File Offset: 0x00075E5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54156, XrefRangeEnd = 54169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnLobbyMessageImpl(IntPtr ptr, long lobbyId, long userId, IntPtr dataPtr, int dataLen)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lobbyId;
			ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userId;
			ptr2[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataPtr;
			ptr2[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataLen;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NativeMethodInfoPtr_OnLobbyMessageImpl_Private_Static_Void_IntPtr_Int64_Int64_IntPtr_Int32_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017BF RID: 6079 RVA: 0x00077CC8 File Offset: 0x00075EC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54169, XrefRangeEnd = 54175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnSpeakingImpl(IntPtr ptr, long lobbyId, long userId, bool speaking)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lobbyId;
			ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userId;
			ptr2[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref speaking;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NativeMethodInfoPtr_OnSpeakingImpl_Private_Static_Void_IntPtr_Int64_Int64_Boolean_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017C0 RID: 6080 RVA: 0x00077D24 File Offset: 0x00075F24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54175, XrefRangeEnd = 54188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnNetworkMessageImpl(IntPtr ptr, long lobbyId, long userId, byte channelId, IntPtr dataPtr, int dataLen)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lobbyId;
			ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userId;
			ptr2[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channelId;
			ptr2[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataPtr;
			ptr2[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataLen;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NativeMethodInfoPtr_OnNetworkMessageImpl_Private_Static_Void_IntPtr_Int64_Int64_Byte_IntPtr_Int32_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017C1 RID: 6081 RVA: 0x00077D9C File Offset: 0x00075F9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54188, XrefRangeEnd = 54202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<User> GetMemberUsers(long lobbyID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lobbyID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NativeMethodInfoPtr_GetMemberUsers_Public_IEnumerable_1_User_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<User>>(intPtr3) : null;
			}
		}

		// Token: 0x060017C2 RID: 6082 RVA: 0x00077DE8 File Offset: 0x00075FE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54202, XrefRangeEnd = 54214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendLobbyMessage(long lobbyID, string data, LobbyManager.SendLobbyMessageHandler handler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lobbyID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(data);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(handler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NativeMethodInfoPtr_SendLobbyMessage_Public_Void_Int64_String_SendLobbyMessageHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017C3 RID: 6083 RVA: 0x000096E2 File Offset: 0x000078E2
		public LobbyManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x060017C4 RID: 6084 RVA: 0x00077E4C File Offset: 0x0007604C
		// (set) Token: 0x060017C5 RID: 6085 RVA: 0x000096EB File Offset: 0x000078EB
		public unsafe IntPtr MethodsPtr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.NativeFieldInfoPtr_MethodsPtr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.NativeFieldInfoPtr_MethodsPtr)) = value;
			}
		}

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x060017C6 RID: 6086 RVA: 0x00077E74 File Offset: 0x00076074
		// (set) Token: 0x060017C7 RID: 6087 RVA: 0x00009706 File Offset: 0x00007906
		public unsafe Object MethodsStructure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.NativeFieldInfoPtr_MethodsStructure);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.NativeFieldInfoPtr_MethodsStructure), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x060017C8 RID: 6088 RVA: 0x00077EA4 File Offset: 0x000760A4
		// (set) Token: 0x060017C9 RID: 6089 RVA: 0x00009725 File Offset: 0x00007925
		public unsafe LobbyManager.LobbyUpdateHandler OnLobbyUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.NativeFieldInfoPtr_OnLobbyUpdate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LobbyManager.LobbyUpdateHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.NativeFieldInfoPtr_OnLobbyUpdate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x060017CA RID: 6090 RVA: 0x00077ED4 File Offset: 0x000760D4
		// (set) Token: 0x060017CB RID: 6091 RVA: 0x00009744 File Offset: 0x00007944
		public unsafe LobbyManager.LobbyDeleteHandler OnLobbyDelete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.NativeFieldInfoPtr_OnLobbyDelete);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LobbyManager.LobbyDeleteHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.NativeFieldInfoPtr_OnLobbyDelete), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x060017CC RID: 6092 RVA: 0x00077F04 File Offset: 0x00076104
		// (set) Token: 0x060017CD RID: 6093 RVA: 0x00009763 File Offset: 0x00007963
		public unsafe LobbyManager.MemberConnectHandler OnMemberConnect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.NativeFieldInfoPtr_OnMemberConnect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LobbyManager.MemberConnectHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.NativeFieldInfoPtr_OnMemberConnect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x060017CE RID: 6094 RVA: 0x00077F34 File Offset: 0x00076134
		// (set) Token: 0x060017CF RID: 6095 RVA: 0x00009782 File Offset: 0x00007982
		public unsafe LobbyManager.MemberUpdateHandler OnMemberUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.NativeFieldInfoPtr_OnMemberUpdate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LobbyManager.MemberUpdateHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.NativeFieldInfoPtr_OnMemberUpdate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x060017D0 RID: 6096 RVA: 0x00077F64 File Offset: 0x00076164
		// (set) Token: 0x060017D1 RID: 6097 RVA: 0x000097A1 File Offset: 0x000079A1
		public unsafe LobbyManager.MemberDisconnectHandler OnMemberDisconnect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.NativeFieldInfoPtr_OnMemberDisconnect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LobbyManager.MemberDisconnectHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.NativeFieldInfoPtr_OnMemberDisconnect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x060017D2 RID: 6098 RVA: 0x00077F94 File Offset: 0x00076194
		// (set) Token: 0x060017D3 RID: 6099 RVA: 0x000097C0 File Offset: 0x000079C0
		public unsafe LobbyManager.LobbyMessageHandler OnLobbyMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.NativeFieldInfoPtr_OnLobbyMessage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LobbyManager.LobbyMessageHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.NativeFieldInfoPtr_OnLobbyMessage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x060017D4 RID: 6100 RVA: 0x00077FC4 File Offset: 0x000761C4
		// (set) Token: 0x060017D5 RID: 6101 RVA: 0x000097DF File Offset: 0x000079DF
		public unsafe LobbyManager.SpeakingHandler OnSpeaking
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.NativeFieldInfoPtr_OnSpeaking);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LobbyManager.SpeakingHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.NativeFieldInfoPtr_OnSpeaking), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x060017D6 RID: 6102 RVA: 0x00077FF4 File Offset: 0x000761F4
		// (set) Token: 0x060017D7 RID: 6103 RVA: 0x000097FE File Offset: 0x000079FE
		public unsafe LobbyManager.NetworkMessageHandler OnNetworkMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.NativeFieldInfoPtr_OnNetworkMessage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LobbyManager.NetworkMessageHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.NativeFieldInfoPtr_OnNetworkMessage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001378 RID: 4984
		private static readonly IntPtr NativeFieldInfoPtr_MethodsPtr;

		// Token: 0x04001379 RID: 4985
		private static readonly IntPtr NativeFieldInfoPtr_MethodsStructure;

		// Token: 0x0400137A RID: 4986
		private static readonly IntPtr NativeFieldInfoPtr_OnLobbyUpdate;

		// Token: 0x0400137B RID: 4987
		private static readonly IntPtr NativeFieldInfoPtr_OnLobbyDelete;

		// Token: 0x0400137C RID: 4988
		private static readonly IntPtr NativeFieldInfoPtr_OnMemberConnect;

		// Token: 0x0400137D RID: 4989
		private static readonly IntPtr NativeFieldInfoPtr_OnMemberUpdate;

		// Token: 0x0400137E RID: 4990
		private static readonly IntPtr NativeFieldInfoPtr_OnMemberDisconnect;

		// Token: 0x0400137F RID: 4991
		private static readonly IntPtr NativeFieldInfoPtr_OnLobbyMessage;

		// Token: 0x04001380 RID: 4992
		private static readonly IntPtr NativeFieldInfoPtr_OnSpeaking;

		// Token: 0x04001381 RID: 4993
		private static readonly IntPtr NativeFieldInfoPtr_OnNetworkMessage;

		// Token: 0x04001382 RID: 4994
		private static readonly IntPtr NativeMethodInfoPtr_get_Methods_Private_get_FFIMethods_0;

		// Token: 0x04001383 RID: 4995
		private static readonly IntPtr NativeMethodInfoPtr_add_OnLobbyUpdate_Public_add_Void_LobbyUpdateHandler_0;

		// Token: 0x04001384 RID: 4996
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnLobbyUpdate_Public_rem_Void_LobbyUpdateHandler_0;

		// Token: 0x04001385 RID: 4997
		private static readonly IntPtr NativeMethodInfoPtr_add_OnLobbyDelete_Public_add_Void_LobbyDeleteHandler_0;

		// Token: 0x04001386 RID: 4998
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnLobbyDelete_Public_rem_Void_LobbyDeleteHandler_0;

		// Token: 0x04001387 RID: 4999
		private static readonly IntPtr NativeMethodInfoPtr_add_OnMemberConnect_Public_add_Void_MemberConnectHandler_0;

		// Token: 0x04001388 RID: 5000
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnMemberConnect_Public_rem_Void_MemberConnectHandler_0;

		// Token: 0x04001389 RID: 5001
		private static readonly IntPtr NativeMethodInfoPtr_add_OnMemberUpdate_Public_add_Void_MemberUpdateHandler_0;

		// Token: 0x0400138A RID: 5002
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnMemberUpdate_Public_rem_Void_MemberUpdateHandler_0;

		// Token: 0x0400138B RID: 5003
		private static readonly IntPtr NativeMethodInfoPtr_add_OnMemberDisconnect_Public_add_Void_MemberDisconnectHandler_0;

		// Token: 0x0400138C RID: 5004
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnMemberDisconnect_Public_rem_Void_MemberDisconnectHandler_0;

		// Token: 0x0400138D RID: 5005
		private static readonly IntPtr NativeMethodInfoPtr_add_OnLobbyMessage_Public_add_Void_LobbyMessageHandler_0;

		// Token: 0x0400138E RID: 5006
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnLobbyMessage_Public_rem_Void_LobbyMessageHandler_0;

		// Token: 0x0400138F RID: 5007
		private static readonly IntPtr NativeMethodInfoPtr_add_OnSpeaking_Public_add_Void_SpeakingHandler_0;

		// Token: 0x04001390 RID: 5008
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnSpeaking_Public_rem_Void_SpeakingHandler_0;

		// Token: 0x04001391 RID: 5009
		private static readonly IntPtr NativeMethodInfoPtr_add_OnNetworkMessage_Public_add_Void_NetworkMessageHandler_0;

		// Token: 0x04001392 RID: 5010
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnNetworkMessage_Public_rem_Void_NetworkMessageHandler_0;

		// Token: 0x04001393 RID: 5011
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IntPtr_IntPtr_byref_FFIEvents_0;

		// Token: 0x04001394 RID: 5012
		private static readonly IntPtr NativeMethodInfoPtr_InitEvents_Private_Void_IntPtr_byref_FFIEvents_0;

		// Token: 0x04001395 RID: 5013
		private static readonly IntPtr NativeMethodInfoPtr_GetLobbyCreateTransaction_Public_LobbyTransaction_0;

		// Token: 0x04001396 RID: 5014
		private static readonly IntPtr NativeMethodInfoPtr_GetLobbyUpdateTransaction_Public_LobbyTransaction_Int64_0;

		// Token: 0x04001397 RID: 5015
		private static readonly IntPtr NativeMethodInfoPtr_GetMemberUpdateTransaction_Public_LobbyMemberTransaction_Int64_Int64_0;

		// Token: 0x04001398 RID: 5016
		private static readonly IntPtr NativeMethodInfoPtr_CreateLobbyCallbackImpl_Private_Static_Void_IntPtr_Result_byref_Lobby_0;

		// Token: 0x04001399 RID: 5017
		private static readonly IntPtr NativeMethodInfoPtr_CreateLobby_Public_Void_LobbyTransaction_CreateLobbyHandler_0;

		// Token: 0x0400139A RID: 5018
		private static readonly IntPtr NativeMethodInfoPtr_UpdateLobbyCallbackImpl_Private_Static_Void_IntPtr_Result_0;

		// Token: 0x0400139B RID: 5019
		private static readonly IntPtr NativeMethodInfoPtr_UpdateLobby_Public_Void_Int64_LobbyTransaction_UpdateLobbyHandler_0;

		// Token: 0x0400139C RID: 5020
		private static readonly IntPtr NativeMethodInfoPtr_DeleteLobbyCallbackImpl_Private_Static_Void_IntPtr_Result_0;

		// Token: 0x0400139D RID: 5021
		private static readonly IntPtr NativeMethodInfoPtr_DeleteLobby_Public_Void_Int64_DeleteLobbyHandler_0;

		// Token: 0x0400139E RID: 5022
		private static readonly IntPtr NativeMethodInfoPtr_ConnectLobbyCallbackImpl_Private_Static_Void_IntPtr_Result_byref_Lobby_0;

		// Token: 0x0400139F RID: 5023
		private static readonly IntPtr NativeMethodInfoPtr_ConnectLobby_Public_Void_Int64_String_ConnectLobbyHandler_0;

		// Token: 0x040013A0 RID: 5024
		private static readonly IntPtr NativeMethodInfoPtr_ConnectLobbyWithActivitySecretCallbackImpl_Private_Static_Void_IntPtr_Result_byref_Lobby_0;

		// Token: 0x040013A1 RID: 5025
		private static readonly IntPtr NativeMethodInfoPtr_ConnectLobbyWithActivitySecret_Public_Void_String_ConnectLobbyWithActivitySecretHandler_0;

		// Token: 0x040013A2 RID: 5026
		private static readonly IntPtr NativeMethodInfoPtr_DisconnectLobbyCallbackImpl_Private_Static_Void_IntPtr_Result_0;

		// Token: 0x040013A3 RID: 5027
		private static readonly IntPtr NativeMethodInfoPtr_DisconnectLobby_Public_Void_Int64_DisconnectLobbyHandler_0;

		// Token: 0x040013A4 RID: 5028
		private static readonly IntPtr NativeMethodInfoPtr_GetLobby_Public_Lobby_Int64_0;

		// Token: 0x040013A5 RID: 5029
		private static readonly IntPtr NativeMethodInfoPtr_GetLobbyActivitySecret_Public_String_Int64_0;

		// Token: 0x040013A6 RID: 5030
		private static readonly IntPtr NativeMethodInfoPtr_GetLobbyMetadataValue_Public_String_Int64_String_0;

		// Token: 0x040013A7 RID: 5031
		private static readonly IntPtr NativeMethodInfoPtr_GetLobbyMetadataKey_Public_String_Int64_Int32_0;

		// Token: 0x040013A8 RID: 5032
		private static readonly IntPtr NativeMethodInfoPtr_LobbyMetadataCount_Public_Int32_Int64_0;

		// Token: 0x040013A9 RID: 5033
		private static readonly IntPtr NativeMethodInfoPtr_MemberCount_Public_Int32_Int64_0;

		// Token: 0x040013AA RID: 5034
		private static readonly IntPtr NativeMethodInfoPtr_GetMemberUserId_Public_Int64_Int64_Int32_0;

		// Token: 0x040013AB RID: 5035
		private static readonly IntPtr NativeMethodInfoPtr_GetMemberUser_Public_User_Int64_Int64_0;

		// Token: 0x040013AC RID: 5036
		private static readonly IntPtr NativeMethodInfoPtr_GetMemberMetadataValue_Public_String_Int64_Int64_String_0;

		// Token: 0x040013AD RID: 5037
		private static readonly IntPtr NativeMethodInfoPtr_GetMemberMetadataKey_Public_String_Int64_Int64_Int32_0;

		// Token: 0x040013AE RID: 5038
		private static readonly IntPtr NativeMethodInfoPtr_MemberMetadataCount_Public_Int32_Int64_Int64_0;

		// Token: 0x040013AF RID: 5039
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMemberCallbackImpl_Private_Static_Void_IntPtr_Result_0;

		// Token: 0x040013B0 RID: 5040
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMember_Public_Void_Int64_Int64_LobbyMemberTransaction_UpdateMemberHandler_0;

		// Token: 0x040013B1 RID: 5041
		private static readonly IntPtr NativeMethodInfoPtr_SendLobbyMessageCallbackImpl_Private_Static_Void_IntPtr_Result_0;

		// Token: 0x040013B2 RID: 5042
		private static readonly IntPtr NativeMethodInfoPtr_SendLobbyMessage_Public_Void_Int64_Il2CppStructArray_1_Byte_SendLobbyMessageHandler_0;

		// Token: 0x040013B3 RID: 5043
		private static readonly IntPtr NativeMethodInfoPtr_GetSearchQuery_Public_LobbySearchQuery_0;

		// Token: 0x040013B4 RID: 5044
		private static readonly IntPtr NativeMethodInfoPtr_SearchCallbackImpl_Private_Static_Void_IntPtr_Result_0;

		// Token: 0x040013B5 RID: 5045
		private static readonly IntPtr NativeMethodInfoPtr_Search_Public_Void_LobbySearchQuery_SearchHandler_0;

		// Token: 0x040013B6 RID: 5046
		private static readonly IntPtr NativeMethodInfoPtr_LobbyCount_Public_Int32_0;

		// Token: 0x040013B7 RID: 5047
		private static readonly IntPtr NativeMethodInfoPtr_GetLobbyId_Public_Int64_Int32_0;

		// Token: 0x040013B8 RID: 5048
		private static readonly IntPtr NativeMethodInfoPtr_ConnectVoiceCallbackImpl_Private_Static_Void_IntPtr_Result_0;

		// Token: 0x040013B9 RID: 5049
		private static readonly IntPtr NativeMethodInfoPtr_ConnectVoice_Public_Void_Int64_ConnectVoiceHandler_0;

		// Token: 0x040013BA RID: 5050
		private static readonly IntPtr NativeMethodInfoPtr_DisconnectVoiceCallbackImpl_Private_Static_Void_IntPtr_Result_0;

		// Token: 0x040013BB RID: 5051
		private static readonly IntPtr NativeMethodInfoPtr_DisconnectVoice_Public_Void_Int64_DisconnectVoiceHandler_0;

		// Token: 0x040013BC RID: 5052
		private static readonly IntPtr NativeMethodInfoPtr_ConnectNetwork_Public_Void_Int64_0;

		// Token: 0x040013BD RID: 5053
		private static readonly IntPtr NativeMethodInfoPtr_DisconnectNetwork_Public_Void_Int64_0;

		// Token: 0x040013BE RID: 5054
		private static readonly IntPtr NativeMethodInfoPtr_FlushNetwork_Public_Void_0;

		// Token: 0x040013BF RID: 5055
		private static readonly IntPtr NativeMethodInfoPtr_OpenNetworkChannel_Public_Void_Int64_Byte_Boolean_0;

		// Token: 0x040013C0 RID: 5056
		private static readonly IntPtr NativeMethodInfoPtr_SendNetworkMessage_Public_Void_Int64_Int64_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x040013C1 RID: 5057
		private static readonly IntPtr NativeMethodInfoPtr_OnLobbyUpdateImpl_Private_Static_Void_IntPtr_Int64_0;

		// Token: 0x040013C2 RID: 5058
		private static readonly IntPtr NativeMethodInfoPtr_OnLobbyDeleteImpl_Private_Static_Void_IntPtr_Int64_UInt32_0;

		// Token: 0x040013C3 RID: 5059
		private static readonly IntPtr NativeMethodInfoPtr_OnMemberConnectImpl_Private_Static_Void_IntPtr_Int64_Int64_0;

		// Token: 0x040013C4 RID: 5060
		private static readonly IntPtr NativeMethodInfoPtr_OnMemberUpdateImpl_Private_Static_Void_IntPtr_Int64_Int64_0;

		// Token: 0x040013C5 RID: 5061
		private static readonly IntPtr NativeMethodInfoPtr_OnMemberDisconnectImpl_Private_Static_Void_IntPtr_Int64_Int64_0;

		// Token: 0x040013C6 RID: 5062
		private static readonly IntPtr NativeMethodInfoPtr_OnLobbyMessageImpl_Private_Static_Void_IntPtr_Int64_Int64_IntPtr_Int32_0;

		// Token: 0x040013C7 RID: 5063
		private static readonly IntPtr NativeMethodInfoPtr_OnSpeakingImpl_Private_Static_Void_IntPtr_Int64_Int64_Boolean_0;

		// Token: 0x040013C8 RID: 5064
		private static readonly IntPtr NativeMethodInfoPtr_OnNetworkMessageImpl_Private_Static_Void_IntPtr_Int64_Int64_Byte_IntPtr_Int32_0;

		// Token: 0x040013C9 RID: 5065
		private static readonly IntPtr NativeMethodInfoPtr_GetMemberUsers_Public_IEnumerable_1_User_Int64_0;

		// Token: 0x040013CA RID: 5066
		private static readonly IntPtr NativeMethodInfoPtr_SendLobbyMessage_Public_Void_Int64_String_SendLobbyMessageHandler_0;

		// Token: 0x02000215 RID: 533
		public sealed class FFIEvents : ValueType
		{
			// Token: 0x06001F12 RID: 7954 RVA: 0x00091664 File Offset: 0x0008F864
			// Note: this type is marked as 'beforefieldinit'.
			static FFIEvents()
			{
				Il2CppClassPointerStore<LobbyManager.FFIEvents>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, "FFIEvents");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyManager.FFIEvents>.NativeClassPtr);
				LobbyManager.FFIEvents.NativeFieldInfoPtr_OnLobbyUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyManager.FFIEvents>.NativeClassPtr, "OnLobbyUpdate");
				LobbyManager.FFIEvents.NativeFieldInfoPtr_OnLobbyDelete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyManager.FFIEvents>.NativeClassPtr, "OnLobbyDelete");
				LobbyManager.FFIEvents.NativeFieldInfoPtr_OnMemberConnect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyManager.FFIEvents>.NativeClassPtr, "OnMemberConnect");
				LobbyManager.FFIEvents.NativeFieldInfoPtr_OnMemberUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyManager.FFIEvents>.NativeClassPtr, "OnMemberUpdate");
				LobbyManager.FFIEvents.NativeFieldInfoPtr_OnMemberDisconnect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyManager.FFIEvents>.NativeClassPtr, "OnMemberDisconnect");
				LobbyManager.FFIEvents.NativeFieldInfoPtr_OnLobbyMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyManager.FFIEvents>.NativeClassPtr, "OnLobbyMessage");
				LobbyManager.FFIEvents.NativeFieldInfoPtr_OnSpeaking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyManager.FFIEvents>.NativeClassPtr, "OnSpeaking");
				LobbyManager.FFIEvents.NativeFieldInfoPtr_OnNetworkMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyManager.FFIEvents>.NativeClassPtr, "OnNetworkMessage");
			}

			// Token: 0x06001F13 RID: 7955 RVA: 0x0000C941 File Offset: 0x0000AB41
			public FFIEvents(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001F14 RID: 7956 RVA: 0x0000C94A File Offset: 0x0000AB4A
			public FFIEvents()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyManager.FFIEvents>.NativeClassPtr))
			{
			}

			// Token: 0x17000722 RID: 1826
			// (get) Token: 0x06001F15 RID: 7957 RVA: 0x00091730 File Offset: 0x0008F930
			// (set) Token: 0x06001F16 RID: 7958 RVA: 0x0000C95C File Offset: 0x0000AB5C
			public unsafe LobbyManager.FFIEvents.LobbyUpdateHandler OnLobbyUpdate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIEvents.NativeFieldInfoPtr_OnLobbyUpdate);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LobbyManager.FFIEvents.LobbyUpdateHandler>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIEvents.NativeFieldInfoPtr_OnLobbyUpdate), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000723 RID: 1827
			// (get) Token: 0x06001F17 RID: 7959 RVA: 0x00091760 File Offset: 0x0008F960
			// (set) Token: 0x06001F18 RID: 7960 RVA: 0x0000C97B File Offset: 0x0000AB7B
			public unsafe LobbyManager.FFIEvents.LobbyDeleteHandler OnLobbyDelete
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIEvents.NativeFieldInfoPtr_OnLobbyDelete);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LobbyManager.FFIEvents.LobbyDeleteHandler>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIEvents.NativeFieldInfoPtr_OnLobbyDelete), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000724 RID: 1828
			// (get) Token: 0x06001F19 RID: 7961 RVA: 0x00091790 File Offset: 0x0008F990
			// (set) Token: 0x06001F1A RID: 7962 RVA: 0x0000C99A File Offset: 0x0000AB9A
			public unsafe LobbyManager.FFIEvents.MemberConnectHandler OnMemberConnect
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIEvents.NativeFieldInfoPtr_OnMemberConnect);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LobbyManager.FFIEvents.MemberConnectHandler>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIEvents.NativeFieldInfoPtr_OnMemberConnect), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000725 RID: 1829
			// (get) Token: 0x06001F1B RID: 7963 RVA: 0x000917C0 File Offset: 0x0008F9C0
			// (set) Token: 0x06001F1C RID: 7964 RVA: 0x0000C9B9 File Offset: 0x0000ABB9
			public unsafe LobbyManager.FFIEvents.MemberUpdateHandler OnMemberUpdate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIEvents.NativeFieldInfoPtr_OnMemberUpdate);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LobbyManager.FFIEvents.MemberUpdateHandler>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIEvents.NativeFieldInfoPtr_OnMemberUpdate), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000726 RID: 1830
			// (get) Token: 0x06001F1D RID: 7965 RVA: 0x000917F0 File Offset: 0x0008F9F0
			// (set) Token: 0x06001F1E RID: 7966 RVA: 0x0000C9D8 File Offset: 0x0000ABD8
			public unsafe LobbyManager.FFIEvents.MemberDisconnectHandler OnMemberDisconnect
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIEvents.NativeFieldInfoPtr_OnMemberDisconnect);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LobbyManager.FFIEvents.MemberDisconnectHandler>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIEvents.NativeFieldInfoPtr_OnMemberDisconnect), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000727 RID: 1831
			// (get) Token: 0x06001F1F RID: 7967 RVA: 0x00091820 File Offset: 0x0008FA20
			// (set) Token: 0x06001F20 RID: 7968 RVA: 0x0000C9F7 File Offset: 0x0000ABF7
			public unsafe LobbyManager.FFIEvents.LobbyMessageHandler OnLobbyMessage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIEvents.NativeFieldInfoPtr_OnLobbyMessage);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LobbyManager.FFIEvents.LobbyMessageHandler>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIEvents.NativeFieldInfoPtr_OnLobbyMessage), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000728 RID: 1832
			// (get) Token: 0x06001F21 RID: 7969 RVA: 0x00091850 File Offset: 0x0008FA50
			// (set) Token: 0x06001F22 RID: 7970 RVA: 0x0000CA16 File Offset: 0x0000AC16
			public unsafe LobbyManager.FFIEvents.SpeakingHandler OnSpeaking
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIEvents.NativeFieldInfoPtr_OnSpeaking);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LobbyManager.FFIEvents.SpeakingHandler>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIEvents.NativeFieldInfoPtr_OnSpeaking), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000729 RID: 1833
			// (get) Token: 0x06001F23 RID: 7971 RVA: 0x00091880 File Offset: 0x0008FA80
			// (set) Token: 0x06001F24 RID: 7972 RVA: 0x0000CA35 File Offset: 0x0000AC35
			public unsafe LobbyManager.FFIEvents.NetworkMessageHandler OnNetworkMessage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIEvents.NativeFieldInfoPtr_OnNetworkMessage);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LobbyManager.FFIEvents.NetworkMessageHandler>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIEvents.NativeFieldInfoPtr_OnNetworkMessage), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400186F RID: 6255
			private static readonly IntPtr NativeFieldInfoPtr_OnLobbyUpdate;

			// Token: 0x04001870 RID: 6256
			private static readonly IntPtr NativeFieldInfoPtr_OnLobbyDelete;

			// Token: 0x04001871 RID: 6257
			private static readonly IntPtr NativeFieldInfoPtr_OnMemberConnect;

			// Token: 0x04001872 RID: 6258
			private static readonly IntPtr NativeFieldInfoPtr_OnMemberUpdate;

			// Token: 0x04001873 RID: 6259
			private static readonly IntPtr NativeFieldInfoPtr_OnMemberDisconnect;

			// Token: 0x04001874 RID: 6260
			private static readonly IntPtr NativeFieldInfoPtr_OnLobbyMessage;

			// Token: 0x04001875 RID: 6261
			private static readonly IntPtr NativeFieldInfoPtr_OnSpeaking;

			// Token: 0x04001876 RID: 6262
			private static readonly IntPtr NativeFieldInfoPtr_OnNetworkMessage;

			// Token: 0x02000296 RID: 662
			public sealed class LobbyUpdateHandler : MulticastDelegate
			{
				// Token: 0x060023C2 RID: 9154 RVA: 0x000A128C File Offset: 0x0009F48C
				// Note: this type is marked as 'beforefieldinit'.
				static LobbyUpdateHandler()
				{
					Il2CppClassPointerStore<LobbyManager.FFIEvents.LobbyUpdateHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyManager.FFIEvents>.NativeClassPtr, "LobbyUpdateHandler");
					LobbyManager.FFIEvents.LobbyUpdateHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIEvents.LobbyUpdateHandler>.NativeClassPtr, 100667725);
					LobbyManager.FFIEvents.LobbyUpdateHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIEvents.LobbyUpdateHandler>.NativeClassPtr, 100667726);
					LobbyManager.FFIEvents.LobbyUpdateHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIEvents.LobbyUpdateHandler>.NativeClassPtr, 100667727);
					LobbyManager.FFIEvents.LobbyUpdateHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIEvents.LobbyUpdateHandler>.NativeClassPtr, 100667728);
				}

				// Token: 0x060023C3 RID: 9155 RVA: 0x000A1300 File Offset: 0x0009F500
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe LobbyUpdateHandler(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyManager.FFIEvents.LobbyUpdateHandler>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIEvents.LobbyUpdateHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060023C4 RID: 9156 RVA: 0x000A135C File Offset: 0x0009F55C
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr ptr, long lobbyId)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lobbyId;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIEvents.LobbyUpdateHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060023C5 RID: 9157 RVA: 0x000A13A8 File Offset: 0x0009F5A8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr ptr, long lobbyId, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lobbyId;
					ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr2[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIEvents.LobbyUpdateHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060023C6 RID: 9158 RVA: 0x000A1428 File Offset: 0x0009F628
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIEvents.LobbyUpdateHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060023C7 RID: 9159 RVA: 0x0000EAE0 File Offset: 0x0000CCE0
				public LobbyUpdateHandler(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060023C8 RID: 9160 RVA: 0x0000EAE9 File Offset: 0x0000CCE9
				public static implicit operator LobbyManager.FFIEvents.LobbyUpdateHandler(Action<IntPtr, long> A_0)
				{
					return DelegateSupport.ConvertDelegate<LobbyManager.FFIEvents.LobbyUpdateHandler>(A_0);
				}

				// Token: 0x060023C9 RID: 9161 RVA: 0x0000EAF1 File Offset: 0x0000CCF1
				public static LobbyManager.FFIEvents.LobbyUpdateHandler operator +(LobbyManager.FFIEvents.LobbyUpdateHandler A_0, LobbyManager.FFIEvents.LobbyUpdateHandler A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<LobbyManager.FFIEvents.LobbyUpdateHandler>();
				}

				// Token: 0x060023CA RID: 9162 RVA: 0x0000EAFF File Offset: 0x0000CCFF
				public static LobbyManager.FFIEvents.LobbyUpdateHandler operator -(LobbyManager.FFIEvents.LobbyUpdateHandler A_0, LobbyManager.FFIEvents.LobbyUpdateHandler A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<LobbyManager.FFIEvents.LobbyUpdateHandler>();
					}
					return delegate2;
				}

				// Token: 0x04001A9D RID: 6813
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001A9E RID: 6814
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int64_0;

				// Token: 0x04001A9F RID: 6815
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_AsyncCallback_Object_0;

				// Token: 0x04001AA0 RID: 6816
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x02000297 RID: 663
			public sealed class LobbyDeleteHandler : MulticastDelegate
			{
				// Token: 0x060023CB RID: 9163 RVA: 0x000A146C File Offset: 0x0009F66C
				// Note: this type is marked as 'beforefieldinit'.
				static LobbyDeleteHandler()
				{
					Il2CppClassPointerStore<LobbyManager.FFIEvents.LobbyDeleteHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyManager.FFIEvents>.NativeClassPtr, "LobbyDeleteHandler");
					LobbyManager.FFIEvents.LobbyDeleteHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIEvents.LobbyDeleteHandler>.NativeClassPtr, 100667729);
					LobbyManager.FFIEvents.LobbyDeleteHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int64_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIEvents.LobbyDeleteHandler>.NativeClassPtr, 100667730);
					LobbyManager.FFIEvents.LobbyDeleteHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_UInt32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIEvents.LobbyDeleteHandler>.NativeClassPtr, 100667731);
					LobbyManager.FFIEvents.LobbyDeleteHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIEvents.LobbyDeleteHandler>.NativeClassPtr, 100667732);
				}

				// Token: 0x060023CC RID: 9164 RVA: 0x000A14E0 File Offset: 0x0009F6E0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53239, XrefRangeEnd = 53242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe LobbyDeleteHandler(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyManager.FFIEvents.LobbyDeleteHandler>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIEvents.LobbyDeleteHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060023CD RID: 9165 RVA: 0x000A153C File Offset: 0x0009F73C
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr ptr, long lobbyId, uint reason)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lobbyId;
					ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reason;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIEvents.LobbyDeleteHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int64_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060023CE RID: 9166 RVA: 0x000A1598 File Offset: 0x0009F798
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53242, XrefRangeEnd = 53249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr ptr, long lobbyId, uint reason, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lobbyId;
					ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reason;
					ptr2[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr2[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIEvents.LobbyDeleteHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_UInt32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060023CF RID: 9167 RVA: 0x000A1628 File Offset: 0x0009F828
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIEvents.LobbyDeleteHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060023D0 RID: 9168 RVA: 0x0000EB10 File Offset: 0x0000CD10
				public LobbyDeleteHandler(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060023D1 RID: 9169 RVA: 0x0000EB19 File Offset: 0x0000CD19
				public static implicit operator LobbyManager.FFIEvents.LobbyDeleteHandler(Action<IntPtr, long, uint> A_0)
				{
					return DelegateSupport.ConvertDelegate<LobbyManager.FFIEvents.LobbyDeleteHandler>(A_0);
				}

				// Token: 0x060023D2 RID: 9170 RVA: 0x0000EB21 File Offset: 0x0000CD21
				public static LobbyManager.FFIEvents.LobbyDeleteHandler operator +(LobbyManager.FFIEvents.LobbyDeleteHandler A_0, LobbyManager.FFIEvents.LobbyDeleteHandler A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<LobbyManager.FFIEvents.LobbyDeleteHandler>();
				}

				// Token: 0x060023D3 RID: 9171 RVA: 0x0000EB2F File Offset: 0x0000CD2F
				public static LobbyManager.FFIEvents.LobbyDeleteHandler operator -(LobbyManager.FFIEvents.LobbyDeleteHandler A_0, LobbyManager.FFIEvents.LobbyDeleteHandler A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<LobbyManager.FFIEvents.LobbyDeleteHandler>();
					}
					return delegate2;
				}

				// Token: 0x04001AA1 RID: 6817
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001AA2 RID: 6818
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int64_UInt32_0;

				// Token: 0x04001AA3 RID: 6819
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_UInt32_AsyncCallback_Object_0;

				// Token: 0x04001AA4 RID: 6820
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x02000298 RID: 664
			public sealed class MemberConnectHandler : MulticastDelegate
			{
				// Token: 0x060023D4 RID: 9172 RVA: 0x000A166C File Offset: 0x0009F86C
				// Note: this type is marked as 'beforefieldinit'.
				static MemberConnectHandler()
				{
					Il2CppClassPointerStore<LobbyManager.FFIEvents.MemberConnectHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyManager.FFIEvents>.NativeClassPtr, "MemberConnectHandler");
					LobbyManager.FFIEvents.MemberConnectHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIEvents.MemberConnectHandler>.NativeClassPtr, 100667733);
					LobbyManager.FFIEvents.MemberConnectHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIEvents.MemberConnectHandler>.NativeClassPtr, 100667734);
					LobbyManager.FFIEvents.MemberConnectHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_Int64_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIEvents.MemberConnectHandler>.NativeClassPtr, 100667735);
					LobbyManager.FFIEvents.MemberConnectHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIEvents.MemberConnectHandler>.NativeClassPtr, 100667736);
				}

				// Token: 0x060023D5 RID: 9173 RVA: 0x000A16E0 File Offset: 0x0009F8E0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe MemberConnectHandler(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyManager.FFIEvents.MemberConnectHandler>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIEvents.MemberConnectHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060023D6 RID: 9174 RVA: 0x000A173C File Offset: 0x0009F93C
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr ptr, long lobbyId, long userId)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lobbyId;
					ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userId;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIEvents.MemberConnectHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int64_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060023D7 RID: 9175 RVA: 0x000A1798 File Offset: 0x0009F998
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53249, XrefRangeEnd = 53256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr ptr, long lobbyId, long userId, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lobbyId;
					ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userId;
					ptr2[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr2[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIEvents.MemberConnectHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_Int64_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060023D8 RID: 9176 RVA: 0x000A1828 File Offset: 0x0009FA28
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIEvents.MemberConnectHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060023D9 RID: 9177 RVA: 0x0000EB40 File Offset: 0x0000CD40
				public MemberConnectHandler(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060023DA RID: 9178 RVA: 0x0000EB49 File Offset: 0x0000CD49
				public static implicit operator LobbyManager.FFIEvents.MemberConnectHandler(Action<IntPtr, long, long> A_0)
				{
					return DelegateSupport.ConvertDelegate<LobbyManager.FFIEvents.MemberConnectHandler>(A_0);
				}

				// Token: 0x060023DB RID: 9179 RVA: 0x0000EB51 File Offset: 0x0000CD51
				public static LobbyManager.FFIEvents.MemberConnectHandler operator +(LobbyManager.FFIEvents.MemberConnectHandler A_0, LobbyManager.FFIEvents.MemberConnectHandler A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<LobbyManager.FFIEvents.MemberConnectHandler>();
				}

				// Token: 0x060023DC RID: 9180 RVA: 0x0000EB5F File Offset: 0x0000CD5F
				public static LobbyManager.FFIEvents.MemberConnectHandler operator -(LobbyManager.FFIEvents.MemberConnectHandler A_0, LobbyManager.FFIEvents.MemberConnectHandler A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<LobbyManager.FFIEvents.MemberConnectHandler>();
					}
					return delegate2;
				}

				// Token: 0x04001AA5 RID: 6821
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001AA6 RID: 6822
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int64_Int64_0;

				// Token: 0x04001AA7 RID: 6823
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_Int64_AsyncCallback_Object_0;

				// Token: 0x04001AA8 RID: 6824
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x02000299 RID: 665
			public sealed class MemberUpdateHandler : MulticastDelegate
			{
				// Token: 0x060023DD RID: 9181 RVA: 0x000A186C File Offset: 0x0009FA6C
				// Note: this type is marked as 'beforefieldinit'.
				static MemberUpdateHandler()
				{
					Il2CppClassPointerStore<LobbyManager.FFIEvents.MemberUpdateHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyManager.FFIEvents>.NativeClassPtr, "MemberUpdateHandler");
					LobbyManager.FFIEvents.MemberUpdateHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIEvents.MemberUpdateHandler>.NativeClassPtr, 100667737);
					LobbyManager.FFIEvents.MemberUpdateHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIEvents.MemberUpdateHandler>.NativeClassPtr, 100667738);
					LobbyManager.FFIEvents.MemberUpdateHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_Int64_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIEvents.MemberUpdateHandler>.NativeClassPtr, 100667739);
					LobbyManager.FFIEvents.MemberUpdateHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIEvents.MemberUpdateHandler>.NativeClassPtr, 100667740);
				}

				// Token: 0x060023DE RID: 9182 RVA: 0x000A18E0 File Offset: 0x0009FAE0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe MemberUpdateHandler(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyManager.FFIEvents.MemberUpdateHandler>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIEvents.MemberUpdateHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060023DF RID: 9183 RVA: 0x000A193C File Offset: 0x0009FB3C
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr ptr, long lobbyId, long userId)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lobbyId;
					ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userId;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIEvents.MemberUpdateHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int64_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060023E0 RID: 9184 RVA: 0x000A1998 File Offset: 0x0009FB98
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr ptr, long lobbyId, long userId, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lobbyId;
					ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userId;
					ptr2[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr2[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIEvents.MemberUpdateHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_Int64_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060023E1 RID: 9185 RVA: 0x000A1A28 File Offset: 0x0009FC28
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIEvents.MemberUpdateHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060023E2 RID: 9186 RVA: 0x0000EB70 File Offset: 0x0000CD70
				public MemberUpdateHandler(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060023E3 RID: 9187 RVA: 0x0000EB79 File Offset: 0x0000CD79
				public static implicit operator LobbyManager.FFIEvents.MemberUpdateHandler(Action<IntPtr, long, long> A_0)
				{
					return DelegateSupport.ConvertDelegate<LobbyManager.FFIEvents.MemberUpdateHandler>(A_0);
				}

				// Token: 0x060023E4 RID: 9188 RVA: 0x0000EB81 File Offset: 0x0000CD81
				public static LobbyManager.FFIEvents.MemberUpdateHandler operator +(LobbyManager.FFIEvents.MemberUpdateHandler A_0, LobbyManager.FFIEvents.MemberUpdateHandler A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<LobbyManager.FFIEvents.MemberUpdateHandler>();
				}

				// Token: 0x060023E5 RID: 9189 RVA: 0x0000EB8F File Offset: 0x0000CD8F
				public static LobbyManager.FFIEvents.MemberUpdateHandler operator -(LobbyManager.FFIEvents.MemberUpdateHandler A_0, LobbyManager.FFIEvents.MemberUpdateHandler A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<LobbyManager.FFIEvents.MemberUpdateHandler>();
					}
					return delegate2;
				}

				// Token: 0x04001AA9 RID: 6825
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001AAA RID: 6826
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int64_Int64_0;

				// Token: 0x04001AAB RID: 6827
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_Int64_AsyncCallback_Object_0;

				// Token: 0x04001AAC RID: 6828
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x0200029A RID: 666
			public sealed class MemberDisconnectHandler : MulticastDelegate
			{
				// Token: 0x060023E6 RID: 9190 RVA: 0x000A1A6C File Offset: 0x0009FC6C
				// Note: this type is marked as 'beforefieldinit'.
				static MemberDisconnectHandler()
				{
					Il2CppClassPointerStore<LobbyManager.FFIEvents.MemberDisconnectHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyManager.FFIEvents>.NativeClassPtr, "MemberDisconnectHandler");
					LobbyManager.FFIEvents.MemberDisconnectHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIEvents.MemberDisconnectHandler>.NativeClassPtr, 100667741);
					LobbyManager.FFIEvents.MemberDisconnectHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIEvents.MemberDisconnectHandler>.NativeClassPtr, 100667742);
					LobbyManager.FFIEvents.MemberDisconnectHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_Int64_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIEvents.MemberDisconnectHandler>.NativeClassPtr, 100667743);
					LobbyManager.FFIEvents.MemberDisconnectHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIEvents.MemberDisconnectHandler>.NativeClassPtr, 100667744);
				}

				// Token: 0x060023E7 RID: 9191 RVA: 0x000A1AE0 File Offset: 0x0009FCE0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe MemberDisconnectHandler(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyManager.FFIEvents.MemberDisconnectHandler>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIEvents.MemberDisconnectHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060023E8 RID: 9192 RVA: 0x000A1B3C File Offset: 0x0009FD3C
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr ptr, long lobbyId, long userId)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lobbyId;
					ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userId;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIEvents.MemberDisconnectHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int64_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060023E9 RID: 9193 RVA: 0x000A1B98 File Offset: 0x0009FD98
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr ptr, long lobbyId, long userId, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lobbyId;
					ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userId;
					ptr2[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr2[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIEvents.MemberDisconnectHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_Int64_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060023EA RID: 9194 RVA: 0x000A1C28 File Offset: 0x0009FE28
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIEvents.MemberDisconnectHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060023EB RID: 9195 RVA: 0x0000EBA0 File Offset: 0x0000CDA0
				public MemberDisconnectHandler(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060023EC RID: 9196 RVA: 0x0000EBA9 File Offset: 0x0000CDA9
				public static implicit operator LobbyManager.FFIEvents.MemberDisconnectHandler(Action<IntPtr, long, long> A_0)
				{
					return DelegateSupport.ConvertDelegate<LobbyManager.FFIEvents.MemberDisconnectHandler>(A_0);
				}

				// Token: 0x060023ED RID: 9197 RVA: 0x0000EBB1 File Offset: 0x0000CDB1
				public static LobbyManager.FFIEvents.MemberDisconnectHandler operator +(LobbyManager.FFIEvents.MemberDisconnectHandler A_0, LobbyManager.FFIEvents.MemberDisconnectHandler A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<LobbyManager.FFIEvents.MemberDisconnectHandler>();
				}

				// Token: 0x060023EE RID: 9198 RVA: 0x0000EBBF File Offset: 0x0000CDBF
				public static LobbyManager.FFIEvents.MemberDisconnectHandler operator -(LobbyManager.FFIEvents.MemberDisconnectHandler A_0, LobbyManager.FFIEvents.MemberDisconnectHandler A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<LobbyManager.FFIEvents.MemberDisconnectHandler>();
					}
					return delegate2;
				}

				// Token: 0x04001AAD RID: 6829
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001AAE RID: 6830
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int64_Int64_0;

				// Token: 0x04001AAF RID: 6831
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_Int64_AsyncCallback_Object_0;

				// Token: 0x04001AB0 RID: 6832
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x0200029B RID: 667
			public sealed class LobbyMessageHandler : MulticastDelegate
			{
				// Token: 0x060023EF RID: 9199 RVA: 0x000A1C6C File Offset: 0x0009FE6C
				// Note: this type is marked as 'beforefieldinit'.
				static LobbyMessageHandler()
				{
					Il2CppClassPointerStore<LobbyManager.FFIEvents.LobbyMessageHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyManager.FFIEvents>.NativeClassPtr, "LobbyMessageHandler");
					LobbyManager.FFIEvents.LobbyMessageHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIEvents.LobbyMessageHandler>.NativeClassPtr, 100667745);
					LobbyManager.FFIEvents.LobbyMessageHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int64_Int64_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIEvents.LobbyMessageHandler>.NativeClassPtr, 100667746);
					LobbyManager.FFIEvents.LobbyMessageHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_Int64_IntPtr_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIEvents.LobbyMessageHandler>.NativeClassPtr, 100667747);
					LobbyManager.FFIEvents.LobbyMessageHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIEvents.LobbyMessageHandler>.NativeClassPtr, 100667748);
				}

				// Token: 0x060023F0 RID: 9200 RVA: 0x000A1CE0 File Offset: 0x0009FEE0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53256, XrefRangeEnd = 53259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe LobbyMessageHandler(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyManager.FFIEvents.LobbyMessageHandler>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIEvents.LobbyMessageHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060023F1 RID: 9201 RVA: 0x000A1D3C File Offset: 0x0009FF3C
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr ptr, long lobbyId, long userId, IntPtr dataPtr, int dataLen)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lobbyId;
					ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userId;
					ptr2[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataPtr;
					ptr2[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataLen;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIEvents.LobbyMessageHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int64_Int64_IntPtr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060023F2 RID: 9202 RVA: 0x000A1DB4 File Offset: 0x0009FFB4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53259, XrefRangeEnd = 53270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr ptr, long lobbyId, long userId, IntPtr dataPtr, int dataLen, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lobbyId;
					ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userId;
					ptr2[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataPtr;
					ptr2[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataLen;
					ptr2[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr2[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIEvents.LobbyMessageHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_Int64_IntPtr_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060023F3 RID: 9203 RVA: 0x000A1E60 File Offset: 0x000A0060
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIEvents.LobbyMessageHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060023F4 RID: 9204 RVA: 0x0000EBD0 File Offset: 0x0000CDD0
				public LobbyMessageHandler(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060023F5 RID: 9205 RVA: 0x0000EBD9 File Offset: 0x0000CDD9
				public static implicit operator LobbyManager.FFIEvents.LobbyMessageHandler(Action<IntPtr, long, long, IntPtr, int> A_0)
				{
					return DelegateSupport.ConvertDelegate<LobbyManager.FFIEvents.LobbyMessageHandler>(A_0);
				}

				// Token: 0x060023F6 RID: 9206 RVA: 0x0000EBE1 File Offset: 0x0000CDE1
				public static LobbyManager.FFIEvents.LobbyMessageHandler operator +(LobbyManager.FFIEvents.LobbyMessageHandler A_0, LobbyManager.FFIEvents.LobbyMessageHandler A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<LobbyManager.FFIEvents.LobbyMessageHandler>();
				}

				// Token: 0x060023F7 RID: 9207 RVA: 0x0000EBEF File Offset: 0x0000CDEF
				public static LobbyManager.FFIEvents.LobbyMessageHandler operator -(LobbyManager.FFIEvents.LobbyMessageHandler A_0, LobbyManager.FFIEvents.LobbyMessageHandler A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<LobbyManager.FFIEvents.LobbyMessageHandler>();
					}
					return delegate2;
				}

				// Token: 0x04001AB1 RID: 6833
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001AB2 RID: 6834
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int64_Int64_IntPtr_Int32_0;

				// Token: 0x04001AB3 RID: 6835
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_Int64_IntPtr_Int32_AsyncCallback_Object_0;

				// Token: 0x04001AB4 RID: 6836
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x0200029C RID: 668
			public sealed class SpeakingHandler : MulticastDelegate
			{
				// Token: 0x060023F8 RID: 9208 RVA: 0x000A1EA4 File Offset: 0x000A00A4
				// Note: this type is marked as 'beforefieldinit'.
				static SpeakingHandler()
				{
					Il2CppClassPointerStore<LobbyManager.FFIEvents.SpeakingHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyManager.FFIEvents>.NativeClassPtr, "SpeakingHandler");
					LobbyManager.FFIEvents.SpeakingHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIEvents.SpeakingHandler>.NativeClassPtr, 100667749);
					LobbyManager.FFIEvents.SpeakingHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int64_Int64_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIEvents.SpeakingHandler>.NativeClassPtr, 100667750);
					LobbyManager.FFIEvents.SpeakingHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_Int64_Boolean_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIEvents.SpeakingHandler>.NativeClassPtr, 100667751);
					LobbyManager.FFIEvents.SpeakingHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIEvents.SpeakingHandler>.NativeClassPtr, 100667752);
				}

				// Token: 0x060023F9 RID: 9209 RVA: 0x000A1F18 File Offset: 0x000A0118
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53270, XrefRangeEnd = 53273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe SpeakingHandler(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyManager.FFIEvents.SpeakingHandler>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIEvents.SpeakingHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060023FA RID: 9210 RVA: 0x000A1F74 File Offset: 0x000A0174
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr ptr, long lobbyId, long userId, bool speaking)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lobbyId;
					ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userId;
					ptr2[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref speaking;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIEvents.SpeakingHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int64_Int64_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060023FB RID: 9211 RVA: 0x000A1FDC File Offset: 0x000A01DC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53273, XrefRangeEnd = 53282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr ptr, long lobbyId, long userId, bool speaking, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lobbyId;
					ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userId;
					ptr2[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref speaking;
					ptr2[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr2[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIEvents.SpeakingHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_Int64_Boolean_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060023FC RID: 9212 RVA: 0x000A2078 File Offset: 0x000A0278
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIEvents.SpeakingHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060023FD RID: 9213 RVA: 0x0000EC00 File Offset: 0x0000CE00
				public SpeakingHandler(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060023FE RID: 9214 RVA: 0x0000EC09 File Offset: 0x0000CE09
				public static implicit operator LobbyManager.FFIEvents.SpeakingHandler(Action<IntPtr, long, long, bool> A_0)
				{
					return DelegateSupport.ConvertDelegate<LobbyManager.FFIEvents.SpeakingHandler>(A_0);
				}

				// Token: 0x060023FF RID: 9215 RVA: 0x0000EC11 File Offset: 0x0000CE11
				public static LobbyManager.FFIEvents.SpeakingHandler operator +(LobbyManager.FFIEvents.SpeakingHandler A_0, LobbyManager.FFIEvents.SpeakingHandler A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<LobbyManager.FFIEvents.SpeakingHandler>();
				}

				// Token: 0x06002400 RID: 9216 RVA: 0x0000EC1F File Offset: 0x0000CE1F
				public static LobbyManager.FFIEvents.SpeakingHandler operator -(LobbyManager.FFIEvents.SpeakingHandler A_0, LobbyManager.FFIEvents.SpeakingHandler A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<LobbyManager.FFIEvents.SpeakingHandler>();
					}
					return delegate2;
				}

				// Token: 0x04001AB5 RID: 6837
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001AB6 RID: 6838
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int64_Int64_Boolean_0;

				// Token: 0x04001AB7 RID: 6839
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_Int64_Boolean_AsyncCallback_Object_0;

				// Token: 0x04001AB8 RID: 6840
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x0200029D RID: 669
			public sealed class NetworkMessageHandler : MulticastDelegate
			{
				// Token: 0x06002401 RID: 9217 RVA: 0x000A20BC File Offset: 0x000A02BC
				// Note: this type is marked as 'beforefieldinit'.
				static NetworkMessageHandler()
				{
					Il2CppClassPointerStore<LobbyManager.FFIEvents.NetworkMessageHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyManager.FFIEvents>.NativeClassPtr, "NetworkMessageHandler");
					LobbyManager.FFIEvents.NetworkMessageHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIEvents.NetworkMessageHandler>.NativeClassPtr, 100667753);
					LobbyManager.FFIEvents.NetworkMessageHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int64_Int64_Byte_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIEvents.NetworkMessageHandler>.NativeClassPtr, 100667754);
					LobbyManager.FFIEvents.NetworkMessageHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_Int64_Byte_IntPtr_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIEvents.NetworkMessageHandler>.NativeClassPtr, 100667755);
					LobbyManager.FFIEvents.NetworkMessageHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIEvents.NetworkMessageHandler>.NativeClassPtr, 100667756);
				}

				// Token: 0x06002402 RID: 9218 RVA: 0x000A2130 File Offset: 0x000A0330
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53282, XrefRangeEnd = 53285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe NetworkMessageHandler(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyManager.FFIEvents.NetworkMessageHandler>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIEvents.NetworkMessageHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002403 RID: 9219 RVA: 0x000A218C File Offset: 0x000A038C
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr ptr, long lobbyId, long userId, byte channelId, IntPtr dataPtr, int dataLen)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lobbyId;
					ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userId;
					ptr2[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channelId;
					ptr2[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataPtr;
					ptr2[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataLen;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIEvents.NetworkMessageHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int64_Int64_Byte_IntPtr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002404 RID: 9220 RVA: 0x000A2210 File Offset: 0x000A0410
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53285, XrefRangeEnd = 53298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr ptr, long lobbyId, long userId, byte channelId, IntPtr dataPtr, int dataLen, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lobbyId;
					ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userId;
					ptr2[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channelId;
					ptr2[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataPtr;
					ptr2[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataLen;
					ptr2[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr2[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIEvents.NetworkMessageHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_Int64_Byte_IntPtr_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06002405 RID: 9221 RVA: 0x000A22C8 File Offset: 0x000A04C8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIEvents.NetworkMessageHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06002406 RID: 9222 RVA: 0x0000EC30 File Offset: 0x0000CE30
				public NetworkMessageHandler(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06002407 RID: 9223 RVA: 0x0000EC39 File Offset: 0x0000CE39
				public static implicit operator LobbyManager.FFIEvents.NetworkMessageHandler(Action<IntPtr, long, long, byte, IntPtr, int> A_0)
				{
					return DelegateSupport.ConvertDelegate<LobbyManager.FFIEvents.NetworkMessageHandler>(A_0);
				}

				// Token: 0x06002408 RID: 9224 RVA: 0x0000EC41 File Offset: 0x0000CE41
				public static LobbyManager.FFIEvents.NetworkMessageHandler operator +(LobbyManager.FFIEvents.NetworkMessageHandler A_0, LobbyManager.FFIEvents.NetworkMessageHandler A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<LobbyManager.FFIEvents.NetworkMessageHandler>();
				}

				// Token: 0x06002409 RID: 9225 RVA: 0x0000EC4F File Offset: 0x0000CE4F
				public static LobbyManager.FFIEvents.NetworkMessageHandler operator -(LobbyManager.FFIEvents.NetworkMessageHandler A_0, LobbyManager.FFIEvents.NetworkMessageHandler A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<LobbyManager.FFIEvents.NetworkMessageHandler>();
					}
					return delegate2;
				}

				// Token: 0x04001AB9 RID: 6841
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001ABA RID: 6842
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int64_Int64_Byte_IntPtr_Int32_0;

				// Token: 0x04001ABB RID: 6843
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_Int64_Byte_IntPtr_Int32_AsyncCallback_Object_0;

				// Token: 0x04001ABC RID: 6844
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}
		}

		// Token: 0x02000216 RID: 534
		public sealed class FFIMethods : ValueType
		{
			// Token: 0x06001F25 RID: 7973 RVA: 0x000918B0 File Offset: 0x0008FAB0
			// Note: this type is marked as 'beforefieldinit'.
			static FFIMethods()
			{
				Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, "FFIMethods");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr);
				LobbyManager.FFIMethods.NativeFieldInfoPtr_GetLobbyCreateTransaction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "GetLobbyCreateTransaction");
				LobbyManager.FFIMethods.NativeFieldInfoPtr_GetLobbyUpdateTransaction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "GetLobbyUpdateTransaction");
				LobbyManager.FFIMethods.NativeFieldInfoPtr_GetMemberUpdateTransaction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "GetMemberUpdateTransaction");
				LobbyManager.FFIMethods.NativeFieldInfoPtr_CreateLobby = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "CreateLobby");
				LobbyManager.FFIMethods.NativeFieldInfoPtr_UpdateLobby = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "UpdateLobby");
				LobbyManager.FFIMethods.NativeFieldInfoPtr_DeleteLobby = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "DeleteLobby");
				LobbyManager.FFIMethods.NativeFieldInfoPtr_ConnectLobby = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "ConnectLobby");
				LobbyManager.FFIMethods.NativeFieldInfoPtr_ConnectLobbyWithActivitySecret = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "ConnectLobbyWithActivitySecret");
				LobbyManager.FFIMethods.NativeFieldInfoPtr_DisconnectLobby = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "DisconnectLobby");
				LobbyManager.FFIMethods.NativeFieldInfoPtr_GetLobby = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "GetLobby");
				LobbyManager.FFIMethods.NativeFieldInfoPtr_GetLobbyActivitySecret = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "GetLobbyActivitySecret");
				LobbyManager.FFIMethods.NativeFieldInfoPtr_GetLobbyMetadataValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "GetLobbyMetadataValue");
				LobbyManager.FFIMethods.NativeFieldInfoPtr_GetLobbyMetadataKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "GetLobbyMetadataKey");
				LobbyManager.FFIMethods.NativeFieldInfoPtr_LobbyMetadataCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "LobbyMetadataCount");
				LobbyManager.FFIMethods.NativeFieldInfoPtr_MemberCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "MemberCount");
				LobbyManager.FFIMethods.NativeFieldInfoPtr_GetMemberUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "GetMemberUserId");
				LobbyManager.FFIMethods.NativeFieldInfoPtr_GetMemberUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "GetMemberUser");
				LobbyManager.FFIMethods.NativeFieldInfoPtr_GetMemberMetadataValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "GetMemberMetadataValue");
				LobbyManager.FFIMethods.NativeFieldInfoPtr_GetMemberMetadataKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "GetMemberMetadataKey");
				LobbyManager.FFIMethods.NativeFieldInfoPtr_MemberMetadataCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "MemberMetadataCount");
				LobbyManager.FFIMethods.NativeFieldInfoPtr_UpdateMember = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "UpdateMember");
				LobbyManager.FFIMethods.NativeFieldInfoPtr_SendLobbyMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "SendLobbyMessage");
				LobbyManager.FFIMethods.NativeFieldInfoPtr_GetSearchQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "GetSearchQuery");
				LobbyManager.FFIMethods.NativeFieldInfoPtr_Search = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "Search");
				LobbyManager.FFIMethods.NativeFieldInfoPtr_LobbyCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "LobbyCount");
				LobbyManager.FFIMethods.NativeFieldInfoPtr_GetLobbyId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "GetLobbyId");
				LobbyManager.FFIMethods.NativeFieldInfoPtr_ConnectVoice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "ConnectVoice");
				LobbyManager.FFIMethods.NativeFieldInfoPtr_DisconnectVoice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "DisconnectVoice");
				LobbyManager.FFIMethods.NativeFieldInfoPtr_ConnectNetwork = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "ConnectNetwork");
				LobbyManager.FFIMethods.NativeFieldInfoPtr_DisconnectNetwork = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "DisconnectNetwork");
				LobbyManager.FFIMethods.NativeFieldInfoPtr_FlushNetwork = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "FlushNetwork");
				LobbyManager.FFIMethods.NativeFieldInfoPtr_OpenNetworkChannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "OpenNetworkChannel");
				LobbyManager.FFIMethods.NativeFieldInfoPtr_SendNetworkMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "SendNetworkMessage");
			}

			// Token: 0x06001F26 RID: 7974 RVA: 0x0000CA54 File Offset: 0x0000AC54
			public FFIMethods(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001F27 RID: 7975 RVA: 0x0000CA5D File Offset: 0x0000AC5D
			public FFIMethods()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr))
			{
			}

			// Token: 0x1700072A RID: 1834
			// (get) Token: 0x06001F28 RID: 7976 RVA: 0x00091B70 File Offset: 0x0008FD70
			// (set) Token: 0x06001F29 RID: 7977 RVA: 0x0000CA6F File Offset: 0x0000AC6F
			public unsafe LobbyManager.FFIMethods.GetLobbyCreateTransactionMethod GetLobbyCreateTransaction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIMethods.NativeFieldInfoPtr_GetLobbyCreateTransaction);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LobbyManager.FFIMethods.GetLobbyCreateTransactionMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIMethods.NativeFieldInfoPtr_GetLobbyCreateTransaction), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700072B RID: 1835
			// (get) Token: 0x06001F2A RID: 7978 RVA: 0x00091BA0 File Offset: 0x0008FDA0
			// (set) Token: 0x06001F2B RID: 7979 RVA: 0x0000CA8E File Offset: 0x0000AC8E
			public unsafe LobbyManager.FFIMethods.GetLobbyUpdateTransactionMethod GetLobbyUpdateTransaction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIMethods.NativeFieldInfoPtr_GetLobbyUpdateTransaction);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LobbyManager.FFIMethods.GetLobbyUpdateTransactionMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIMethods.NativeFieldInfoPtr_GetLobbyUpdateTransaction), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700072C RID: 1836
			// (get) Token: 0x06001F2C RID: 7980 RVA: 0x00091BD0 File Offset: 0x0008FDD0
			// (set) Token: 0x06001F2D RID: 7981 RVA: 0x0000CAAD File Offset: 0x0000ACAD
			public unsafe LobbyManager.FFIMethods.GetMemberUpdateTransactionMethod GetMemberUpdateTransaction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIMethods.NativeFieldInfoPtr_GetMemberUpdateTransaction);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LobbyManager.FFIMethods.GetMemberUpdateTransactionMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIMethods.NativeFieldInfoPtr_GetMemberUpdateTransaction), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700072D RID: 1837
			// (get) Token: 0x06001F2E RID: 7982 RVA: 0x00091C00 File Offset: 0x0008FE00
			// (set) Token: 0x06001F2F RID: 7983 RVA: 0x0000CACC File Offset: 0x0000ACCC
			public unsafe LobbyManager.FFIMethods.CreateLobbyMethod CreateLobby
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIMethods.NativeFieldInfoPtr_CreateLobby);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LobbyManager.FFIMethods.CreateLobbyMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIMethods.NativeFieldInfoPtr_CreateLobby), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700072E RID: 1838
			// (get) Token: 0x06001F30 RID: 7984 RVA: 0x00091C30 File Offset: 0x0008FE30
			// (set) Token: 0x06001F31 RID: 7985 RVA: 0x0000CAEB File Offset: 0x0000ACEB
			public unsafe LobbyManager.FFIMethods.UpdateLobbyMethod UpdateLobby
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIMethods.NativeFieldInfoPtr_UpdateLobby);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LobbyManager.FFIMethods.UpdateLobbyMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIMethods.NativeFieldInfoPtr_UpdateLobby), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700072F RID: 1839
			// (get) Token: 0x06001F32 RID: 7986 RVA: 0x00091C60 File Offset: 0x0008FE60
			// (set) Token: 0x06001F33 RID: 7987 RVA: 0x0000CB0A File Offset: 0x0000AD0A
			public unsafe LobbyManager.FFIMethods.DeleteLobbyMethod DeleteLobby
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIMethods.NativeFieldInfoPtr_DeleteLobby);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LobbyManager.FFIMethods.DeleteLobbyMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIMethods.NativeFieldInfoPtr_DeleteLobby), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000730 RID: 1840
			// (get) Token: 0x06001F34 RID: 7988 RVA: 0x00091C90 File Offset: 0x0008FE90
			// (set) Token: 0x06001F35 RID: 7989 RVA: 0x0000CB29 File Offset: 0x0000AD29
			public unsafe LobbyManager.FFIMethods.ConnectLobbyMethod ConnectLobby
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIMethods.NativeFieldInfoPtr_ConnectLobby);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LobbyManager.FFIMethods.ConnectLobbyMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIMethods.NativeFieldInfoPtr_ConnectLobby), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000731 RID: 1841
			// (get) Token: 0x06001F36 RID: 7990 RVA: 0x00091CC0 File Offset: 0x0008FEC0
			// (set) Token: 0x06001F37 RID: 7991 RVA: 0x0000CB48 File Offset: 0x0000AD48
			public unsafe LobbyManager.FFIMethods.ConnectLobbyWithActivitySecretMethod ConnectLobbyWithActivitySecret
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIMethods.NativeFieldInfoPtr_ConnectLobbyWithActivitySecret);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LobbyManager.FFIMethods.ConnectLobbyWithActivitySecretMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIMethods.NativeFieldInfoPtr_ConnectLobbyWithActivitySecret), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000732 RID: 1842
			// (get) Token: 0x06001F38 RID: 7992 RVA: 0x00091CF0 File Offset: 0x0008FEF0
			// (set) Token: 0x06001F39 RID: 7993 RVA: 0x0000CB67 File Offset: 0x0000AD67
			public unsafe LobbyManager.FFIMethods.DisconnectLobbyMethod DisconnectLobby
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIMethods.NativeFieldInfoPtr_DisconnectLobby);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LobbyManager.FFIMethods.DisconnectLobbyMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIMethods.NativeFieldInfoPtr_DisconnectLobby), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000733 RID: 1843
			// (get) Token: 0x06001F3A RID: 7994 RVA: 0x00091D20 File Offset: 0x0008FF20
			// (set) Token: 0x06001F3B RID: 7995 RVA: 0x0000CB86 File Offset: 0x0000AD86
			public unsafe LobbyManager.FFIMethods.GetLobbyMethod GetLobby
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIMethods.NativeFieldInfoPtr_GetLobby);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LobbyManager.FFIMethods.GetLobbyMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIMethods.NativeFieldInfoPtr_GetLobby), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000734 RID: 1844
			// (get) Token: 0x06001F3C RID: 7996 RVA: 0x00091D50 File Offset: 0x0008FF50
			// (set) Token: 0x06001F3D RID: 7997 RVA: 0x0000CBA5 File Offset: 0x0000ADA5
			public unsafe LobbyManager.FFIMethods.GetLobbyActivitySecretMethod GetLobbyActivitySecret
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIMethods.NativeFieldInfoPtr_GetLobbyActivitySecret);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LobbyManager.FFIMethods.GetLobbyActivitySecretMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIMethods.NativeFieldInfoPtr_GetLobbyActivitySecret), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000735 RID: 1845
			// (get) Token: 0x06001F3E RID: 7998 RVA: 0x00091D80 File Offset: 0x0008FF80
			// (set) Token: 0x06001F3F RID: 7999 RVA: 0x0000CBC4 File Offset: 0x0000ADC4
			public unsafe LobbyManager.FFIMethods.GetLobbyMetadataValueMethod GetLobbyMetadataValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIMethods.NativeFieldInfoPtr_GetLobbyMetadataValue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LobbyManager.FFIMethods.GetLobbyMetadataValueMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIMethods.NativeFieldInfoPtr_GetLobbyMetadataValue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000736 RID: 1846
			// (get) Token: 0x06001F40 RID: 8000 RVA: 0x00091DB0 File Offset: 0x0008FFB0
			// (set) Token: 0x06001F41 RID: 8001 RVA: 0x0000CBE3 File Offset: 0x0000ADE3
			public unsafe LobbyManager.FFIMethods.GetLobbyMetadataKeyMethod GetLobbyMetadataKey
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIMethods.NativeFieldInfoPtr_GetLobbyMetadataKey);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LobbyManager.FFIMethods.GetLobbyMetadataKeyMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIMethods.NativeFieldInfoPtr_GetLobbyMetadataKey), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000737 RID: 1847
			// (get) Token: 0x06001F42 RID: 8002 RVA: 0x00091DE0 File Offset: 0x0008FFE0
			// (set) Token: 0x06001F43 RID: 8003 RVA: 0x0000CC02 File Offset: 0x0000AE02
			public unsafe LobbyManager.FFIMethods.LobbyMetadataCountMethod LobbyMetadataCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIMethods.NativeFieldInfoPtr_LobbyMetadataCount);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LobbyManager.FFIMethods.LobbyMetadataCountMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIMethods.NativeFieldInfoPtr_LobbyMetadataCount), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000738 RID: 1848
			// (get) Token: 0x06001F44 RID: 8004 RVA: 0x00091E10 File Offset: 0x00090010
			// (set) Token: 0x06001F45 RID: 8005 RVA: 0x0000CC21 File Offset: 0x0000AE21
			public unsafe LobbyManager.FFIMethods.MemberCountMethod MemberCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIMethods.NativeFieldInfoPtr_MemberCount);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LobbyManager.FFIMethods.MemberCountMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIMethods.NativeFieldInfoPtr_MemberCount), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000739 RID: 1849
			// (get) Token: 0x06001F46 RID: 8006 RVA: 0x00091E40 File Offset: 0x00090040
			// (set) Token: 0x06001F47 RID: 8007 RVA: 0x0000CC40 File Offset: 0x0000AE40
			public unsafe LobbyManager.FFIMethods.GetMemberUserIdMethod GetMemberUserId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIMethods.NativeFieldInfoPtr_GetMemberUserId);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LobbyManager.FFIMethods.GetMemberUserIdMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIMethods.NativeFieldInfoPtr_GetMemberUserId), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700073A RID: 1850
			// (get) Token: 0x06001F48 RID: 8008 RVA: 0x00091E70 File Offset: 0x00090070
			// (set) Token: 0x06001F49 RID: 8009 RVA: 0x0000CC5F File Offset: 0x0000AE5F
			public unsafe LobbyManager.FFIMethods.GetMemberUserMethod GetMemberUser
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIMethods.NativeFieldInfoPtr_GetMemberUser);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LobbyManager.FFIMethods.GetMemberUserMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIMethods.NativeFieldInfoPtr_GetMemberUser), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700073B RID: 1851
			// (get) Token: 0x06001F4A RID: 8010 RVA: 0x00091EA0 File Offset: 0x000900A0
			// (set) Token: 0x06001F4B RID: 8011 RVA: 0x0000CC7E File Offset: 0x0000AE7E
			public unsafe LobbyManager.FFIMethods.GetMemberMetadataValueMethod GetMemberMetadataValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIMethods.NativeFieldInfoPtr_GetMemberMetadataValue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LobbyManager.FFIMethods.GetMemberMetadataValueMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIMethods.NativeFieldInfoPtr_GetMemberMetadataValue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700073C RID: 1852
			// (get) Token: 0x06001F4C RID: 8012 RVA: 0x00091ED0 File Offset: 0x000900D0
			// (set) Token: 0x06001F4D RID: 8013 RVA: 0x0000CC9D File Offset: 0x0000AE9D
			public unsafe LobbyManager.FFIMethods.GetMemberMetadataKeyMethod GetMemberMetadataKey
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIMethods.NativeFieldInfoPtr_GetMemberMetadataKey);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LobbyManager.FFIMethods.GetMemberMetadataKeyMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIMethods.NativeFieldInfoPtr_GetMemberMetadataKey), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700073D RID: 1853
			// (get) Token: 0x06001F4E RID: 8014 RVA: 0x00091F00 File Offset: 0x00090100
			// (set) Token: 0x06001F4F RID: 8015 RVA: 0x0000CCBC File Offset: 0x0000AEBC
			public unsafe LobbyManager.FFIMethods.MemberMetadataCountMethod MemberMetadataCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIMethods.NativeFieldInfoPtr_MemberMetadataCount);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LobbyManager.FFIMethods.MemberMetadataCountMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIMethods.NativeFieldInfoPtr_MemberMetadataCount), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700073E RID: 1854
			// (get) Token: 0x06001F50 RID: 8016 RVA: 0x00091F30 File Offset: 0x00090130
			// (set) Token: 0x06001F51 RID: 8017 RVA: 0x0000CCDB File Offset: 0x0000AEDB
			public unsafe LobbyManager.FFIMethods.UpdateMemberMethod UpdateMember
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIMethods.NativeFieldInfoPtr_UpdateMember);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LobbyManager.FFIMethods.UpdateMemberMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIMethods.NativeFieldInfoPtr_UpdateMember), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700073F RID: 1855
			// (get) Token: 0x06001F52 RID: 8018 RVA: 0x00091F60 File Offset: 0x00090160
			// (set) Token: 0x06001F53 RID: 8019 RVA: 0x0000CCFA File Offset: 0x0000AEFA
			public unsafe LobbyManager.FFIMethods.SendLobbyMessageMethod SendLobbyMessage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIMethods.NativeFieldInfoPtr_SendLobbyMessage);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LobbyManager.FFIMethods.SendLobbyMessageMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIMethods.NativeFieldInfoPtr_SendLobbyMessage), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000740 RID: 1856
			// (get) Token: 0x06001F54 RID: 8020 RVA: 0x00091F90 File Offset: 0x00090190
			// (set) Token: 0x06001F55 RID: 8021 RVA: 0x0000CD19 File Offset: 0x0000AF19
			public unsafe LobbyManager.FFIMethods.GetSearchQueryMethod GetSearchQuery
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIMethods.NativeFieldInfoPtr_GetSearchQuery);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LobbyManager.FFIMethods.GetSearchQueryMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIMethods.NativeFieldInfoPtr_GetSearchQuery), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000741 RID: 1857
			// (get) Token: 0x06001F56 RID: 8022 RVA: 0x00091FC0 File Offset: 0x000901C0
			// (set) Token: 0x06001F57 RID: 8023 RVA: 0x0000CD38 File Offset: 0x0000AF38
			public unsafe LobbyManager.FFIMethods.SearchMethod Search
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIMethods.NativeFieldInfoPtr_Search);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LobbyManager.FFIMethods.SearchMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIMethods.NativeFieldInfoPtr_Search), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000742 RID: 1858
			// (get) Token: 0x06001F58 RID: 8024 RVA: 0x00091FF0 File Offset: 0x000901F0
			// (set) Token: 0x06001F59 RID: 8025 RVA: 0x0000CD57 File Offset: 0x0000AF57
			public unsafe LobbyManager.FFIMethods.LobbyCountMethod LobbyCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIMethods.NativeFieldInfoPtr_LobbyCount);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LobbyManager.FFIMethods.LobbyCountMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIMethods.NativeFieldInfoPtr_LobbyCount), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000743 RID: 1859
			// (get) Token: 0x06001F5A RID: 8026 RVA: 0x00092020 File Offset: 0x00090220
			// (set) Token: 0x06001F5B RID: 8027 RVA: 0x0000CD76 File Offset: 0x0000AF76
			public unsafe LobbyManager.FFIMethods.GetLobbyIdMethod GetLobbyId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIMethods.NativeFieldInfoPtr_GetLobbyId);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LobbyManager.FFIMethods.GetLobbyIdMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIMethods.NativeFieldInfoPtr_GetLobbyId), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000744 RID: 1860
			// (get) Token: 0x06001F5C RID: 8028 RVA: 0x00092050 File Offset: 0x00090250
			// (set) Token: 0x06001F5D RID: 8029 RVA: 0x0000CD95 File Offset: 0x0000AF95
			public unsafe LobbyManager.FFIMethods.ConnectVoiceMethod ConnectVoice
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIMethods.NativeFieldInfoPtr_ConnectVoice);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LobbyManager.FFIMethods.ConnectVoiceMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIMethods.NativeFieldInfoPtr_ConnectVoice), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000745 RID: 1861
			// (get) Token: 0x06001F5E RID: 8030 RVA: 0x00092080 File Offset: 0x00090280
			// (set) Token: 0x06001F5F RID: 8031 RVA: 0x0000CDB4 File Offset: 0x0000AFB4
			public unsafe LobbyManager.FFIMethods.DisconnectVoiceMethod DisconnectVoice
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIMethods.NativeFieldInfoPtr_DisconnectVoice);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LobbyManager.FFIMethods.DisconnectVoiceMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIMethods.NativeFieldInfoPtr_DisconnectVoice), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000746 RID: 1862
			// (get) Token: 0x06001F60 RID: 8032 RVA: 0x000920B0 File Offset: 0x000902B0
			// (set) Token: 0x06001F61 RID: 8033 RVA: 0x0000CDD3 File Offset: 0x0000AFD3
			public unsafe LobbyManager.FFIMethods.ConnectNetworkMethod ConnectNetwork
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIMethods.NativeFieldInfoPtr_ConnectNetwork);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LobbyManager.FFIMethods.ConnectNetworkMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIMethods.NativeFieldInfoPtr_ConnectNetwork), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000747 RID: 1863
			// (get) Token: 0x06001F62 RID: 8034 RVA: 0x000920E0 File Offset: 0x000902E0
			// (set) Token: 0x06001F63 RID: 8035 RVA: 0x0000CDF2 File Offset: 0x0000AFF2
			public unsafe LobbyManager.FFIMethods.DisconnectNetworkMethod DisconnectNetwork
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIMethods.NativeFieldInfoPtr_DisconnectNetwork);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LobbyManager.FFIMethods.DisconnectNetworkMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIMethods.NativeFieldInfoPtr_DisconnectNetwork), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000748 RID: 1864
			// (get) Token: 0x06001F64 RID: 8036 RVA: 0x00092110 File Offset: 0x00090310
			// (set) Token: 0x06001F65 RID: 8037 RVA: 0x0000CE11 File Offset: 0x0000B011
			public unsafe LobbyManager.FFIMethods.FlushNetworkMethod FlushNetwork
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIMethods.NativeFieldInfoPtr_FlushNetwork);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LobbyManager.FFIMethods.FlushNetworkMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIMethods.NativeFieldInfoPtr_FlushNetwork), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000749 RID: 1865
			// (get) Token: 0x06001F66 RID: 8038 RVA: 0x00092140 File Offset: 0x00090340
			// (set) Token: 0x06001F67 RID: 8039 RVA: 0x0000CE30 File Offset: 0x0000B030
			public unsafe LobbyManager.FFIMethods.OpenNetworkChannelMethod OpenNetworkChannel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIMethods.NativeFieldInfoPtr_OpenNetworkChannel);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LobbyManager.FFIMethods.OpenNetworkChannelMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIMethods.NativeFieldInfoPtr_OpenNetworkChannel), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700074A RID: 1866
			// (get) Token: 0x06001F68 RID: 8040 RVA: 0x00092170 File Offset: 0x00090370
			// (set) Token: 0x06001F69 RID: 8041 RVA: 0x0000CE4F File Offset: 0x0000B04F
			public unsafe LobbyManager.FFIMethods.SendNetworkMessageMethod SendNetworkMessage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIMethods.NativeFieldInfoPtr_SendNetworkMessage);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LobbyManager.FFIMethods.SendNetworkMessageMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyManager.FFIMethods.NativeFieldInfoPtr_SendNetworkMessage), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001877 RID: 6263
			private static readonly IntPtr NativeFieldInfoPtr_GetLobbyCreateTransaction;

			// Token: 0x04001878 RID: 6264
			private static readonly IntPtr NativeFieldInfoPtr_GetLobbyUpdateTransaction;

			// Token: 0x04001879 RID: 6265
			private static readonly IntPtr NativeFieldInfoPtr_GetMemberUpdateTransaction;

			// Token: 0x0400187A RID: 6266
			private static readonly IntPtr NativeFieldInfoPtr_CreateLobby;

			// Token: 0x0400187B RID: 6267
			private static readonly IntPtr NativeFieldInfoPtr_UpdateLobby;

			// Token: 0x0400187C RID: 6268
			private static readonly IntPtr NativeFieldInfoPtr_DeleteLobby;

			// Token: 0x0400187D RID: 6269
			private static readonly IntPtr NativeFieldInfoPtr_ConnectLobby;

			// Token: 0x0400187E RID: 6270
			private static readonly IntPtr NativeFieldInfoPtr_ConnectLobbyWithActivitySecret;

			// Token: 0x0400187F RID: 6271
			private static readonly IntPtr NativeFieldInfoPtr_DisconnectLobby;

			// Token: 0x04001880 RID: 6272
			private static readonly IntPtr NativeFieldInfoPtr_GetLobby;

			// Token: 0x04001881 RID: 6273
			private static readonly IntPtr NativeFieldInfoPtr_GetLobbyActivitySecret;

			// Token: 0x04001882 RID: 6274
			private static readonly IntPtr NativeFieldInfoPtr_GetLobbyMetadataValue;

			// Token: 0x04001883 RID: 6275
			private static readonly IntPtr NativeFieldInfoPtr_GetLobbyMetadataKey;

			// Token: 0x04001884 RID: 6276
			private static readonly IntPtr NativeFieldInfoPtr_LobbyMetadataCount;

			// Token: 0x04001885 RID: 6277
			private static readonly IntPtr NativeFieldInfoPtr_MemberCount;

			// Token: 0x04001886 RID: 6278
			private static readonly IntPtr NativeFieldInfoPtr_GetMemberUserId;

			// Token: 0x04001887 RID: 6279
			private static readonly IntPtr NativeFieldInfoPtr_GetMemberUser;

			// Token: 0x04001888 RID: 6280
			private static readonly IntPtr NativeFieldInfoPtr_GetMemberMetadataValue;

			// Token: 0x04001889 RID: 6281
			private static readonly IntPtr NativeFieldInfoPtr_GetMemberMetadataKey;

			// Token: 0x0400188A RID: 6282
			private static readonly IntPtr NativeFieldInfoPtr_MemberMetadataCount;

			// Token: 0x0400188B RID: 6283
			private static readonly IntPtr NativeFieldInfoPtr_UpdateMember;

			// Token: 0x0400188C RID: 6284
			private static readonly IntPtr NativeFieldInfoPtr_SendLobbyMessage;

			// Token: 0x0400188D RID: 6285
			private static readonly IntPtr NativeFieldInfoPtr_GetSearchQuery;

			// Token: 0x0400188E RID: 6286
			private static readonly IntPtr NativeFieldInfoPtr_Search;

			// Token: 0x0400188F RID: 6287
			private static readonly IntPtr NativeFieldInfoPtr_LobbyCount;

			// Token: 0x04001890 RID: 6288
			private static readonly IntPtr NativeFieldInfoPtr_GetLobbyId;

			// Token: 0x04001891 RID: 6289
			private static readonly IntPtr NativeFieldInfoPtr_ConnectVoice;

			// Token: 0x04001892 RID: 6290
			private static readonly IntPtr NativeFieldInfoPtr_DisconnectVoice;

			// Token: 0x04001893 RID: 6291
			private static readonly IntPtr NativeFieldInfoPtr_ConnectNetwork;

			// Token: 0x04001894 RID: 6292
			private static readonly IntPtr NativeFieldInfoPtr_DisconnectNetwork;

			// Token: 0x04001895 RID: 6293
			private static readonly IntPtr NativeFieldInfoPtr_FlushNetwork;

			// Token: 0x04001896 RID: 6294
			private static readonly IntPtr NativeFieldInfoPtr_OpenNetworkChannel;

			// Token: 0x04001897 RID: 6295
			private static readonly IntPtr NativeFieldInfoPtr_SendNetworkMessage;

			// Token: 0x0200029E RID: 670
			public sealed class GetLobbyCreateTransactionMethod : MulticastDelegate
			{
				// Token: 0x0600240A RID: 9226 RVA: 0x000A230C File Offset: 0x000A050C
				// Note: this type is marked as 'beforefieldinit'.
				static GetLobbyCreateTransactionMethod()
				{
					Il2CppClassPointerStore<LobbyManager.FFIMethods.GetLobbyCreateTransactionMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "GetLobbyCreateTransactionMethod");
					LobbyManager.FFIMethods.GetLobbyCreateTransactionMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.GetLobbyCreateTransactionMethod>.NativeClassPtr, 100667757);
					LobbyManager.FFIMethods.GetLobbyCreateTransactionMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.GetLobbyCreateTransactionMethod>.NativeClassPtr, 100667758);
					LobbyManager.FFIMethods.GetLobbyCreateTransactionMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_IntPtr_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.GetLobbyCreateTransactionMethod>.NativeClassPtr, 100667759);
					LobbyManager.FFIMethods.GetLobbyCreateTransactionMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_IntPtr_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.GetLobbyCreateTransactionMethod>.NativeClassPtr, 100667760);
				}

				// Token: 0x0600240B RID: 9227 RVA: 0x000A2380 File Offset: 0x000A0580
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe GetLobbyCreateTransactionMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyManager.FFIMethods.GetLobbyCreateTransactionMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.GetLobbyCreateTransactionMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600240C RID: 9228 RVA: 0x000A23DC File Offset: 0x000A05DC
				[CallerCount(0)]
				public unsafe Result Invoke(IntPtr methodsPtr, ref IntPtr transaction)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &transaction;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.GetLobbyCreateTransactionMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_byref_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x0600240D RID: 9229 RVA: 0x000A2438 File Offset: 0x000A0638
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53298, XrefRangeEnd = 53303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, ref IntPtr transaction, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &transaction;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.GetLobbyCreateTransactionMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_IntPtr_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x0600240E RID: 9230 RVA: 0x000A24B8 File Offset: 0x000A06B8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Result EndInvoke(ref IntPtr transaction, IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = &transaction;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.GetLobbyCreateTransactionMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_IntPtr_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x0600240F RID: 9231 RVA: 0x0000EC60 File Offset: 0x0000CE60
				public GetLobbyCreateTransactionMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001ABD RID: 6845
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001ABE RID: 6846
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_byref_IntPtr_0;

				// Token: 0x04001ABF RID: 6847
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_IntPtr_AsyncCallback_Object_0;

				// Token: 0x04001AC0 RID: 6848
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_IntPtr_IAsyncResult_0;
			}

			// Token: 0x0200029F RID: 671
			public sealed class GetLobbyUpdateTransactionMethod : MulticastDelegate
			{
				// Token: 0x06002410 RID: 9232 RVA: 0x000A2518 File Offset: 0x000A0718
				// Note: this type is marked as 'beforefieldinit'.
				static GetLobbyUpdateTransactionMethod()
				{
					Il2CppClassPointerStore<LobbyManager.FFIMethods.GetLobbyUpdateTransactionMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "GetLobbyUpdateTransactionMethod");
					LobbyManager.FFIMethods.GetLobbyUpdateTransactionMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.GetLobbyUpdateTransactionMethod>.NativeClassPtr, 100667761);
					LobbyManager.FFIMethods.GetLobbyUpdateTransactionMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.GetLobbyUpdateTransactionMethod>.NativeClassPtr, 100667762);
					LobbyManager.FFIMethods.GetLobbyUpdateTransactionMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_byref_IntPtr_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.GetLobbyUpdateTransactionMethod>.NativeClassPtr, 100667763);
					LobbyManager.FFIMethods.GetLobbyUpdateTransactionMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_IntPtr_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.GetLobbyUpdateTransactionMethod>.NativeClassPtr, 100667764);
				}

				// Token: 0x06002411 RID: 9233 RVA: 0x000A258C File Offset: 0x000A078C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe GetLobbyUpdateTransactionMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyManager.FFIMethods.GetLobbyUpdateTransactionMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.GetLobbyUpdateTransactionMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002412 RID: 9234 RVA: 0x000A25E8 File Offset: 0x000A07E8
				[CallerCount(0)]
				public unsafe Result Invoke(IntPtr methodsPtr, long lobbyId, ref IntPtr transaction)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lobbyId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &transaction;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.GetLobbyUpdateTransactionMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_byref_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x06002413 RID: 9235 RVA: 0x000A2650 File Offset: 0x000A0850
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53303, XrefRangeEnd = 53310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, long lobbyId, ref IntPtr transaction, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lobbyId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &transaction;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.GetLobbyUpdateTransactionMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_byref_IntPtr_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06002414 RID: 9236 RVA: 0x000A26E0 File Offset: 0x000A08E0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Result EndInvoke(ref IntPtr transaction, IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = &transaction;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.GetLobbyUpdateTransactionMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_IntPtr_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x06002415 RID: 9237 RVA: 0x0000EC69 File Offset: 0x0000CE69
				public GetLobbyUpdateTransactionMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001AC1 RID: 6849
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001AC2 RID: 6850
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_byref_IntPtr_0;

				// Token: 0x04001AC3 RID: 6851
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_byref_IntPtr_AsyncCallback_Object_0;

				// Token: 0x04001AC4 RID: 6852
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_IntPtr_IAsyncResult_0;
			}

			// Token: 0x020002A0 RID: 672
			public sealed class GetMemberUpdateTransactionMethod : MulticastDelegate
			{
				// Token: 0x06002416 RID: 9238 RVA: 0x000A2740 File Offset: 0x000A0940
				// Note: this type is marked as 'beforefieldinit'.
				static GetMemberUpdateTransactionMethod()
				{
					Il2CppClassPointerStore<LobbyManager.FFIMethods.GetMemberUpdateTransactionMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "GetMemberUpdateTransactionMethod");
					LobbyManager.FFIMethods.GetMemberUpdateTransactionMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.GetMemberUpdateTransactionMethod>.NativeClassPtr, 100667765);
					LobbyManager.FFIMethods.GetMemberUpdateTransactionMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_Int64_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.GetMemberUpdateTransactionMethod>.NativeClassPtr, 100667766);
					LobbyManager.FFIMethods.GetMemberUpdateTransactionMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_Int64_byref_IntPtr_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.GetMemberUpdateTransactionMethod>.NativeClassPtr, 100667767);
					LobbyManager.FFIMethods.GetMemberUpdateTransactionMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_IntPtr_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.GetMemberUpdateTransactionMethod>.NativeClassPtr, 100667768);
				}

				// Token: 0x06002417 RID: 9239 RVA: 0x000A27B4 File Offset: 0x000A09B4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53310, XrefRangeEnd = 53313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe GetMemberUpdateTransactionMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyManager.FFIMethods.GetMemberUpdateTransactionMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.GetMemberUpdateTransactionMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002418 RID: 9240 RVA: 0x000A2810 File Offset: 0x000A0A10
				[CallerCount(0)]
				public unsafe Result Invoke(IntPtr methodsPtr, long lobbyId, long userId, ref IntPtr transaction)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lobbyId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userId;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &transaction;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.GetMemberUpdateTransactionMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_Int64_byref_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x06002419 RID: 9241 RVA: 0x000A2888 File Offset: 0x000A0A88
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53313, XrefRangeEnd = 53322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, long lobbyId, long userId, ref IntPtr transaction, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lobbyId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userId;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &transaction;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.GetMemberUpdateTransactionMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_Int64_byref_IntPtr_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x0600241A RID: 9242 RVA: 0x000A2928 File Offset: 0x000A0B28
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Result EndInvoke(ref IntPtr transaction, IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = &transaction;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.GetMemberUpdateTransactionMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_IntPtr_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x0600241B RID: 9243 RVA: 0x0000EC72 File Offset: 0x0000CE72
				public GetMemberUpdateTransactionMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001AC5 RID: 6853
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001AC6 RID: 6854
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_Int64_byref_IntPtr_0;

				// Token: 0x04001AC7 RID: 6855
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_Int64_byref_IntPtr_AsyncCallback_Object_0;

				// Token: 0x04001AC8 RID: 6856
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_IntPtr_IAsyncResult_0;
			}

			// Token: 0x020002A1 RID: 673
			public sealed class CreateLobbyCallback : MulticastDelegate
			{
				// Token: 0x0600241C RID: 9244 RVA: 0x000A2988 File Offset: 0x000A0B88
				// Note: this type is marked as 'beforefieldinit'.
				static CreateLobbyCallback()
				{
					Il2CppClassPointerStore<LobbyManager.FFIMethods.CreateLobbyCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "CreateLobbyCallback");
					LobbyManager.FFIMethods.CreateLobbyCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.CreateLobbyCallback>.NativeClassPtr, 100667769);
					LobbyManager.FFIMethods.CreateLobbyCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_byref_Lobby_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.CreateLobbyCallback>.NativeClassPtr, 100667770);
					LobbyManager.FFIMethods.CreateLobbyCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_byref_Lobby_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.CreateLobbyCallback>.NativeClassPtr, 100667771);
					LobbyManager.FFIMethods.CreateLobbyCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_Lobby_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.CreateLobbyCallback>.NativeClassPtr, 100667772);
				}

				// Token: 0x0600241D RID: 9245 RVA: 0x000A29FC File Offset: 0x000A0BFC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe CreateLobbyCallback(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyManager.FFIMethods.CreateLobbyCallback>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.CreateLobbyCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600241E RID: 9246 RVA: 0x000A2A58 File Offset: 0x000A0C58
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr ptr, Result result, ref Lobby lobby)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					ref IntPtr ptr3 = ref ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(lobby);
					ptr3 = &intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.CreateLobbyCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_byref_Lobby_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					lobby = ((intPtr4 == 0) ? null : new Lobby(intPtr4));
				}

				// Token: 0x0600241F RID: 9247 RVA: 0x000A2AD0 File Offset: 0x000A0CD0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53322, XrefRangeEnd = 53331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr ptr, Result result, ref Lobby lobby, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					ref IntPtr ptr3 = ref ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(lobby);
					ptr3 = &intPtr;
					ptr2[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr2[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.CreateLobbyCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_byref_Lobby_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					lobby = ((intPtr4 == 0) ? null : new Lobby(intPtr4));
					IntPtr intPtr5 = intPtr2;
					return (intPtr5 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr5) : null;
				}

				// Token: 0x06002420 RID: 9248 RVA: 0x000A2B80 File Offset: 0x000A0D80
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(ref Lobby lobby, IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					IntPtr intPtr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						ref IntPtr ptr2 = ref *ptr;
						intPtr = IL2CPP.Il2CppObjectBaseToPtr(lobby);
						ptr2 = &intPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.CreateLobbyCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_Lobby_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					lobby = ((intPtr4 == 0) ? null : new Lobby(intPtr4));
				}

				// Token: 0x06002421 RID: 9249 RVA: 0x0000EC7B File Offset: 0x0000CE7B
				public CreateLobbyCallback(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001AC9 RID: 6857
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001ACA RID: 6858
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_byref_Lobby_0;

				// Token: 0x04001ACB RID: 6859
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_byref_Lobby_AsyncCallback_Object_0;

				// Token: 0x04001ACC RID: 6860
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_Lobby_IAsyncResult_0;
			}

			// Token: 0x020002A2 RID: 674
			public sealed class CreateLobbyMethod : MulticastDelegate
			{
				// Token: 0x06002422 RID: 9250 RVA: 0x000A2BEC File Offset: 0x000A0DEC
				// Note: this type is marked as 'beforefieldinit'.
				static CreateLobbyMethod()
				{
					Il2CppClassPointerStore<LobbyManager.FFIMethods.CreateLobbyMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "CreateLobbyMethod");
					LobbyManager.FFIMethods.CreateLobbyMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.CreateLobbyMethod>.NativeClassPtr, 100667773);
					LobbyManager.FFIMethods.CreateLobbyMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_IntPtr_IntPtr_CreateLobbyCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.CreateLobbyMethod>.NativeClassPtr, 100667774);
					LobbyManager.FFIMethods.CreateLobbyMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_IntPtr_CreateLobbyCallback_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.CreateLobbyMethod>.NativeClassPtr, 100667775);
					LobbyManager.FFIMethods.CreateLobbyMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.CreateLobbyMethod>.NativeClassPtr, 100667776);
				}

				// Token: 0x06002423 RID: 9251 RVA: 0x000A2C60 File Offset: 0x000A0E60
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe CreateLobbyMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyManager.FFIMethods.CreateLobbyMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.CreateLobbyMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002424 RID: 9252 RVA: 0x000A2CBC File Offset: 0x000A0EBC
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr methodsPtr, IntPtr transaction, IntPtr callbackData, LobbyManager.FFIMethods.CreateLobbyCallback callback)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref transaction;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callbackData;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.CreateLobbyMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_IntPtr_IntPtr_CreateLobbyCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002425 RID: 9253 RVA: 0x000A2D2C File Offset: 0x000A0F2C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53331, XrefRangeEnd = 53338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, IntPtr transaction, IntPtr callbackData, LobbyManager.FFIMethods.CreateLobbyCallback callback, AsyncCallback __callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref transaction;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callbackData;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(__callback);
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.CreateLobbyMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_IntPtr_CreateLobbyCallback_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06002426 RID: 9254 RVA: 0x000A2DD0 File Offset: 0x000A0FD0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.CreateLobbyMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06002427 RID: 9255 RVA: 0x0000EC84 File Offset: 0x0000CE84
				public CreateLobbyMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06002428 RID: 9256 RVA: 0x0000EC8D File Offset: 0x0000CE8D
				public static implicit operator LobbyManager.FFIMethods.CreateLobbyMethod(Action<IntPtr, IntPtr, IntPtr, LobbyManager.FFIMethods.CreateLobbyCallback> A_0)
				{
					return DelegateSupport.ConvertDelegate<LobbyManager.FFIMethods.CreateLobbyMethod>(A_0);
				}

				// Token: 0x06002429 RID: 9257 RVA: 0x0000EC95 File Offset: 0x0000CE95
				public static LobbyManager.FFIMethods.CreateLobbyMethod operator +(LobbyManager.FFIMethods.CreateLobbyMethod A_0, LobbyManager.FFIMethods.CreateLobbyMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<LobbyManager.FFIMethods.CreateLobbyMethod>();
				}

				// Token: 0x0600242A RID: 9258 RVA: 0x0000ECA3 File Offset: 0x0000CEA3
				public static LobbyManager.FFIMethods.CreateLobbyMethod operator -(LobbyManager.FFIMethods.CreateLobbyMethod A_0, LobbyManager.FFIMethods.CreateLobbyMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<LobbyManager.FFIMethods.CreateLobbyMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001ACD RID: 6861
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001ACE RID: 6862
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_IntPtr_IntPtr_CreateLobbyCallback_0;

				// Token: 0x04001ACF RID: 6863
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_IntPtr_CreateLobbyCallback_AsyncCallback_Object_0;

				// Token: 0x04001AD0 RID: 6864
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x020002A3 RID: 675
			public sealed class UpdateLobbyCallback : MulticastDelegate
			{
				// Token: 0x0600242B RID: 9259 RVA: 0x000A2E14 File Offset: 0x000A1014
				// Note: this type is marked as 'beforefieldinit'.
				static UpdateLobbyCallback()
				{
					Il2CppClassPointerStore<LobbyManager.FFIMethods.UpdateLobbyCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "UpdateLobbyCallback");
					LobbyManager.FFIMethods.UpdateLobbyCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.UpdateLobbyCallback>.NativeClassPtr, 100667777);
					LobbyManager.FFIMethods.UpdateLobbyCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.UpdateLobbyCallback>.NativeClassPtr, 100667778);
					LobbyManager.FFIMethods.UpdateLobbyCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.UpdateLobbyCallback>.NativeClassPtr, 100667779);
					LobbyManager.FFIMethods.UpdateLobbyCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.UpdateLobbyCallback>.NativeClassPtr, 100667780);
				}

				// Token: 0x0600242C RID: 9260 RVA: 0x000A2E88 File Offset: 0x000A1088
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe UpdateLobbyCallback(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyManager.FFIMethods.UpdateLobbyCallback>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.UpdateLobbyCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600242D RID: 9261 RVA: 0x000A2EE4 File Offset: 0x000A10E4
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr ptr, Result result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.UpdateLobbyCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600242E RID: 9262 RVA: 0x000A2F34 File Offset: 0x000A1134
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53338, XrefRangeEnd = 53344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr2[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.UpdateLobbyCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x0600242F RID: 9263 RVA: 0x000A2FB8 File Offset: 0x000A11B8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.UpdateLobbyCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06002430 RID: 9264 RVA: 0x0000ECB4 File Offset: 0x0000CEB4
				public UpdateLobbyCallback(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06002431 RID: 9265 RVA: 0x0000ECBD File Offset: 0x0000CEBD
				public static implicit operator LobbyManager.FFIMethods.UpdateLobbyCallback(Action<IntPtr, Result> A_0)
				{
					return DelegateSupport.ConvertDelegate<LobbyManager.FFIMethods.UpdateLobbyCallback>(A_0);
				}

				// Token: 0x06002432 RID: 9266 RVA: 0x0000ECC5 File Offset: 0x0000CEC5
				public static LobbyManager.FFIMethods.UpdateLobbyCallback operator +(LobbyManager.FFIMethods.UpdateLobbyCallback A_0, LobbyManager.FFIMethods.UpdateLobbyCallback A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<LobbyManager.FFIMethods.UpdateLobbyCallback>();
				}

				// Token: 0x06002433 RID: 9267 RVA: 0x0000ECD3 File Offset: 0x0000CED3
				public static LobbyManager.FFIMethods.UpdateLobbyCallback operator -(LobbyManager.FFIMethods.UpdateLobbyCallback A_0, LobbyManager.FFIMethods.UpdateLobbyCallback A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<LobbyManager.FFIMethods.UpdateLobbyCallback>();
					}
					return delegate2;
				}

				// Token: 0x04001AD1 RID: 6865
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001AD2 RID: 6866
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_0;

				// Token: 0x04001AD3 RID: 6867
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_AsyncCallback_Object_0;

				// Token: 0x04001AD4 RID: 6868
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x020002A4 RID: 676
			public sealed class UpdateLobbyMethod : MulticastDelegate
			{
				// Token: 0x06002434 RID: 9268 RVA: 0x000A2FFC File Offset: 0x000A11FC
				// Note: this type is marked as 'beforefieldinit'.
				static UpdateLobbyMethod()
				{
					Il2CppClassPointerStore<LobbyManager.FFIMethods.UpdateLobbyMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "UpdateLobbyMethod");
					LobbyManager.FFIMethods.UpdateLobbyMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.UpdateLobbyMethod>.NativeClassPtr, 100667781);
					LobbyManager.FFIMethods.UpdateLobbyMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int64_IntPtr_IntPtr_UpdateLobbyCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.UpdateLobbyMethod>.NativeClassPtr, 100667782);
					LobbyManager.FFIMethods.UpdateLobbyMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_IntPtr_IntPtr_UpdateLobbyCallback_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.UpdateLobbyMethod>.NativeClassPtr, 100667783);
					LobbyManager.FFIMethods.UpdateLobbyMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.UpdateLobbyMethod>.NativeClassPtr, 100667784);
				}

				// Token: 0x06002435 RID: 9269 RVA: 0x000A3070 File Offset: 0x000A1270
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53344, XrefRangeEnd = 53347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe UpdateLobbyMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyManager.FFIMethods.UpdateLobbyMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.UpdateLobbyMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002436 RID: 9270 RVA: 0x000A30CC File Offset: 0x000A12CC
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr methodsPtr, long lobbyId, IntPtr transaction, IntPtr callbackData, LobbyManager.FFIMethods.UpdateLobbyCallback callback)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lobbyId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref transaction;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callbackData;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.UpdateLobbyMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int64_IntPtr_IntPtr_UpdateLobbyCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002437 RID: 9271 RVA: 0x000A3148 File Offset: 0x000A1348
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53347, XrefRangeEnd = 53356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, long lobbyId, IntPtr transaction, IntPtr callbackData, LobbyManager.FFIMethods.UpdateLobbyCallback callback, AsyncCallback __callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lobbyId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref transaction;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callbackData;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(__callback);
					ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.UpdateLobbyMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_IntPtr_IntPtr_UpdateLobbyCallback_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06002438 RID: 9272 RVA: 0x000A31F8 File Offset: 0x000A13F8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.UpdateLobbyMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06002439 RID: 9273 RVA: 0x0000ECE4 File Offset: 0x0000CEE4
				public UpdateLobbyMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x0600243A RID: 9274 RVA: 0x0000ECED File Offset: 0x0000CEED
				public static implicit operator LobbyManager.FFIMethods.UpdateLobbyMethod(Action<IntPtr, long, IntPtr, IntPtr, LobbyManager.FFIMethods.UpdateLobbyCallback> A_0)
				{
					return DelegateSupport.ConvertDelegate<LobbyManager.FFIMethods.UpdateLobbyMethod>(A_0);
				}

				// Token: 0x0600243B RID: 9275 RVA: 0x0000ECF5 File Offset: 0x0000CEF5
				public static LobbyManager.FFIMethods.UpdateLobbyMethod operator +(LobbyManager.FFIMethods.UpdateLobbyMethod A_0, LobbyManager.FFIMethods.UpdateLobbyMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<LobbyManager.FFIMethods.UpdateLobbyMethod>();
				}

				// Token: 0x0600243C RID: 9276 RVA: 0x0000ED03 File Offset: 0x0000CF03
				public static LobbyManager.FFIMethods.UpdateLobbyMethod operator -(LobbyManager.FFIMethods.UpdateLobbyMethod A_0, LobbyManager.FFIMethods.UpdateLobbyMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<LobbyManager.FFIMethods.UpdateLobbyMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001AD5 RID: 6869
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001AD6 RID: 6870
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int64_IntPtr_IntPtr_UpdateLobbyCallback_0;

				// Token: 0x04001AD7 RID: 6871
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_IntPtr_IntPtr_UpdateLobbyCallback_AsyncCallback_Object_0;

				// Token: 0x04001AD8 RID: 6872
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x020002A5 RID: 677
			public sealed class DeleteLobbyCallback : MulticastDelegate
			{
				// Token: 0x0600243D RID: 9277 RVA: 0x000A323C File Offset: 0x000A143C
				// Note: this type is marked as 'beforefieldinit'.
				static DeleteLobbyCallback()
				{
					Il2CppClassPointerStore<LobbyManager.FFIMethods.DeleteLobbyCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "DeleteLobbyCallback");
					LobbyManager.FFIMethods.DeleteLobbyCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.DeleteLobbyCallback>.NativeClassPtr, 100667785);
					LobbyManager.FFIMethods.DeleteLobbyCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.DeleteLobbyCallback>.NativeClassPtr, 100667786);
					LobbyManager.FFIMethods.DeleteLobbyCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.DeleteLobbyCallback>.NativeClassPtr, 100667787);
					LobbyManager.FFIMethods.DeleteLobbyCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.DeleteLobbyCallback>.NativeClassPtr, 100667788);
				}

				// Token: 0x0600243E RID: 9278 RVA: 0x000A32B0 File Offset: 0x000A14B0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe DeleteLobbyCallback(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyManager.FFIMethods.DeleteLobbyCallback>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.DeleteLobbyCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600243F RID: 9279 RVA: 0x000A330C File Offset: 0x000A150C
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr ptr, Result result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.DeleteLobbyCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002440 RID: 9280 RVA: 0x000A335C File Offset: 0x000A155C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53356, XrefRangeEnd = 53362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr2[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.DeleteLobbyCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06002441 RID: 9281 RVA: 0x000A33E0 File Offset: 0x000A15E0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.DeleteLobbyCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06002442 RID: 9282 RVA: 0x0000ED14 File Offset: 0x0000CF14
				public DeleteLobbyCallback(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06002443 RID: 9283 RVA: 0x0000ED1D File Offset: 0x0000CF1D
				public static implicit operator LobbyManager.FFIMethods.DeleteLobbyCallback(Action<IntPtr, Result> A_0)
				{
					return DelegateSupport.ConvertDelegate<LobbyManager.FFIMethods.DeleteLobbyCallback>(A_0);
				}

				// Token: 0x06002444 RID: 9284 RVA: 0x0000ED25 File Offset: 0x0000CF25
				public static LobbyManager.FFIMethods.DeleteLobbyCallback operator +(LobbyManager.FFIMethods.DeleteLobbyCallback A_0, LobbyManager.FFIMethods.DeleteLobbyCallback A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<LobbyManager.FFIMethods.DeleteLobbyCallback>();
				}

				// Token: 0x06002445 RID: 9285 RVA: 0x0000ED33 File Offset: 0x0000CF33
				public static LobbyManager.FFIMethods.DeleteLobbyCallback operator -(LobbyManager.FFIMethods.DeleteLobbyCallback A_0, LobbyManager.FFIMethods.DeleteLobbyCallback A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<LobbyManager.FFIMethods.DeleteLobbyCallback>();
					}
					return delegate2;
				}

				// Token: 0x04001AD9 RID: 6873
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001ADA RID: 6874
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_0;

				// Token: 0x04001ADB RID: 6875
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_AsyncCallback_Object_0;

				// Token: 0x04001ADC RID: 6876
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x020002A6 RID: 678
			public sealed class DeleteLobbyMethod : MulticastDelegate
			{
				// Token: 0x06002446 RID: 9286 RVA: 0x000A3424 File Offset: 0x000A1624
				// Note: this type is marked as 'beforefieldinit'.
				static DeleteLobbyMethod()
				{
					Il2CppClassPointerStore<LobbyManager.FFIMethods.DeleteLobbyMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "DeleteLobbyMethod");
					LobbyManager.FFIMethods.DeleteLobbyMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.DeleteLobbyMethod>.NativeClassPtr, 100667789);
					LobbyManager.FFIMethods.DeleteLobbyMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int64_IntPtr_DeleteLobbyCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.DeleteLobbyMethod>.NativeClassPtr, 100667790);
					LobbyManager.FFIMethods.DeleteLobbyMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_IntPtr_DeleteLobbyCallback_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.DeleteLobbyMethod>.NativeClassPtr, 100667791);
					LobbyManager.FFIMethods.DeleteLobbyMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.DeleteLobbyMethod>.NativeClassPtr, 100667792);
				}

				// Token: 0x06002447 RID: 9287 RVA: 0x000A3498 File Offset: 0x000A1698
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe DeleteLobbyMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyManager.FFIMethods.DeleteLobbyMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.DeleteLobbyMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002448 RID: 9288 RVA: 0x000A34F4 File Offset: 0x000A16F4
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr methodsPtr, long lobbyId, IntPtr callbackData, LobbyManager.FFIMethods.DeleteLobbyCallback callback)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lobbyId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callbackData;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.DeleteLobbyMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int64_IntPtr_DeleteLobbyCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002449 RID: 9289 RVA: 0x000A3564 File Offset: 0x000A1764
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, long lobbyId, IntPtr callbackData, LobbyManager.FFIMethods.DeleteLobbyCallback callback, AsyncCallback __callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lobbyId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callbackData;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(__callback);
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.DeleteLobbyMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_IntPtr_DeleteLobbyCallback_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x0600244A RID: 9290 RVA: 0x000A3608 File Offset: 0x000A1808
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.DeleteLobbyMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x0600244B RID: 9291 RVA: 0x0000ED44 File Offset: 0x0000CF44
				public DeleteLobbyMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x0600244C RID: 9292 RVA: 0x0000ED4D File Offset: 0x0000CF4D
				public static implicit operator LobbyManager.FFIMethods.DeleteLobbyMethod(Action<IntPtr, long, IntPtr, LobbyManager.FFIMethods.DeleteLobbyCallback> A_0)
				{
					return DelegateSupport.ConvertDelegate<LobbyManager.FFIMethods.DeleteLobbyMethod>(A_0);
				}

				// Token: 0x0600244D RID: 9293 RVA: 0x0000ED55 File Offset: 0x0000CF55
				public static LobbyManager.FFIMethods.DeleteLobbyMethod operator +(LobbyManager.FFIMethods.DeleteLobbyMethod A_0, LobbyManager.FFIMethods.DeleteLobbyMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<LobbyManager.FFIMethods.DeleteLobbyMethod>();
				}

				// Token: 0x0600244E RID: 9294 RVA: 0x0000ED63 File Offset: 0x0000CF63
				public static LobbyManager.FFIMethods.DeleteLobbyMethod operator -(LobbyManager.FFIMethods.DeleteLobbyMethod A_0, LobbyManager.FFIMethods.DeleteLobbyMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<LobbyManager.FFIMethods.DeleteLobbyMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001ADD RID: 6877
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001ADE RID: 6878
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int64_IntPtr_DeleteLobbyCallback_0;

				// Token: 0x04001ADF RID: 6879
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_IntPtr_DeleteLobbyCallback_AsyncCallback_Object_0;

				// Token: 0x04001AE0 RID: 6880
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x020002A7 RID: 679
			public sealed class ConnectLobbyCallback : MulticastDelegate
			{
				// Token: 0x0600244F RID: 9295 RVA: 0x000A364C File Offset: 0x000A184C
				// Note: this type is marked as 'beforefieldinit'.
				static ConnectLobbyCallback()
				{
					Il2CppClassPointerStore<LobbyManager.FFIMethods.ConnectLobbyCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "ConnectLobbyCallback");
					LobbyManager.FFIMethods.ConnectLobbyCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.ConnectLobbyCallback>.NativeClassPtr, 100667793);
					LobbyManager.FFIMethods.ConnectLobbyCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_byref_Lobby_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.ConnectLobbyCallback>.NativeClassPtr, 100667794);
					LobbyManager.FFIMethods.ConnectLobbyCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_byref_Lobby_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.ConnectLobbyCallback>.NativeClassPtr, 100667795);
					LobbyManager.FFIMethods.ConnectLobbyCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_Lobby_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.ConnectLobbyCallback>.NativeClassPtr, 100667796);
				}

				// Token: 0x06002450 RID: 9296 RVA: 0x000A36C0 File Offset: 0x000A18C0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ConnectLobbyCallback(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyManager.FFIMethods.ConnectLobbyCallback>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.ConnectLobbyCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002451 RID: 9297 RVA: 0x000A371C File Offset: 0x000A191C
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr ptr, Result result, ref Lobby lobby)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					ref IntPtr ptr3 = ref ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(lobby);
					ptr3 = &intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.ConnectLobbyCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_byref_Lobby_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					lobby = ((intPtr4 == 0) ? null : new Lobby(intPtr4));
				}

				// Token: 0x06002452 RID: 9298 RVA: 0x000A3794 File Offset: 0x000A1994
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53362, XrefRangeEnd = 53371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr ptr, Result result, ref Lobby lobby, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					ref IntPtr ptr3 = ref ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(lobby);
					ptr3 = &intPtr;
					ptr2[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr2[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.ConnectLobbyCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_byref_Lobby_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					lobby = ((intPtr4 == 0) ? null : new Lobby(intPtr4));
					IntPtr intPtr5 = intPtr2;
					return (intPtr5 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr5) : null;
				}

				// Token: 0x06002453 RID: 9299 RVA: 0x000A3844 File Offset: 0x000A1A44
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(ref Lobby lobby, IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					IntPtr intPtr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						ref IntPtr ptr2 = ref *ptr;
						intPtr = IL2CPP.Il2CppObjectBaseToPtr(lobby);
						ptr2 = &intPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.ConnectLobbyCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_Lobby_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					lobby = ((intPtr4 == 0) ? null : new Lobby(intPtr4));
				}

				// Token: 0x06002454 RID: 9300 RVA: 0x0000ED74 File Offset: 0x0000CF74
				public ConnectLobbyCallback(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001AE1 RID: 6881
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001AE2 RID: 6882
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_byref_Lobby_0;

				// Token: 0x04001AE3 RID: 6883
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_byref_Lobby_AsyncCallback_Object_0;

				// Token: 0x04001AE4 RID: 6884
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_Lobby_IAsyncResult_0;
			}

			// Token: 0x020002A8 RID: 680
			public sealed class ConnectLobbyMethod : MulticastDelegate
			{
				// Token: 0x06002455 RID: 9301 RVA: 0x000A38B0 File Offset: 0x000A1AB0
				// Note: this type is marked as 'beforefieldinit'.
				static ConnectLobbyMethod()
				{
					Il2CppClassPointerStore<LobbyManager.FFIMethods.ConnectLobbyMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "ConnectLobbyMethod");
					LobbyManager.FFIMethods.ConnectLobbyMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.ConnectLobbyMethod>.NativeClassPtr, 100667797);
					LobbyManager.FFIMethods.ConnectLobbyMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int64_String_IntPtr_ConnectLobbyCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.ConnectLobbyMethod>.NativeClassPtr, 100667798);
					LobbyManager.FFIMethods.ConnectLobbyMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_String_IntPtr_ConnectLobbyCallback_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.ConnectLobbyMethod>.NativeClassPtr, 100667799);
					LobbyManager.FFIMethods.ConnectLobbyMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.ConnectLobbyMethod>.NativeClassPtr, 100667800);
				}

				// Token: 0x06002456 RID: 9302 RVA: 0x000A3924 File Offset: 0x000A1B24
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ConnectLobbyMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyManager.FFIMethods.ConnectLobbyMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.ConnectLobbyMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002457 RID: 9303 RVA: 0x000A3980 File Offset: 0x000A1B80
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr methodsPtr, long lobbyId, string secret, IntPtr callbackData, LobbyManager.FFIMethods.ConnectLobbyCallback callback)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lobbyId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(secret);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callbackData;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.ConnectLobbyMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int64_String_IntPtr_ConnectLobbyCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002458 RID: 9304 RVA: 0x000A3A00 File Offset: 0x000A1C00
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53371, XrefRangeEnd = 53378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, long lobbyId, string secret, IntPtr callbackData, LobbyManager.FFIMethods.ConnectLobbyCallback callback, AsyncCallback __callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lobbyId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(secret);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callbackData;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(__callback);
					ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.ConnectLobbyMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_String_IntPtr_ConnectLobbyCallback_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06002459 RID: 9305 RVA: 0x000A3AB4 File Offset: 0x000A1CB4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.ConnectLobbyMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x0600245A RID: 9306 RVA: 0x0000ED7D File Offset: 0x0000CF7D
				public ConnectLobbyMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x0600245B RID: 9307 RVA: 0x0000ED86 File Offset: 0x0000CF86
				public static implicit operator LobbyManager.FFIMethods.ConnectLobbyMethod(Action<IntPtr, long, string, IntPtr, LobbyManager.FFIMethods.ConnectLobbyCallback> A_0)
				{
					return DelegateSupport.ConvertDelegate<LobbyManager.FFIMethods.ConnectLobbyMethod>(A_0);
				}

				// Token: 0x0600245C RID: 9308 RVA: 0x0000ED8E File Offset: 0x0000CF8E
				public static LobbyManager.FFIMethods.ConnectLobbyMethod operator +(LobbyManager.FFIMethods.ConnectLobbyMethod A_0, LobbyManager.FFIMethods.ConnectLobbyMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<LobbyManager.FFIMethods.ConnectLobbyMethod>();
				}

				// Token: 0x0600245D RID: 9309 RVA: 0x0000ED9C File Offset: 0x0000CF9C
				public static LobbyManager.FFIMethods.ConnectLobbyMethod operator -(LobbyManager.FFIMethods.ConnectLobbyMethod A_0, LobbyManager.FFIMethods.ConnectLobbyMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<LobbyManager.FFIMethods.ConnectLobbyMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001AE5 RID: 6885
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001AE6 RID: 6886
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int64_String_IntPtr_ConnectLobbyCallback_0;

				// Token: 0x04001AE7 RID: 6887
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_String_IntPtr_ConnectLobbyCallback_AsyncCallback_Object_0;

				// Token: 0x04001AE8 RID: 6888
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x020002A9 RID: 681
			public sealed class ConnectLobbyWithActivitySecretCallback : MulticastDelegate
			{
				// Token: 0x0600245E RID: 9310 RVA: 0x000A3AF8 File Offset: 0x000A1CF8
				// Note: this type is marked as 'beforefieldinit'.
				static ConnectLobbyWithActivitySecretCallback()
				{
					Il2CppClassPointerStore<LobbyManager.FFIMethods.ConnectLobbyWithActivitySecretCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "ConnectLobbyWithActivitySecretCallback");
					LobbyManager.FFIMethods.ConnectLobbyWithActivitySecretCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.ConnectLobbyWithActivitySecretCallback>.NativeClassPtr, 100667801);
					LobbyManager.FFIMethods.ConnectLobbyWithActivitySecretCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_byref_Lobby_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.ConnectLobbyWithActivitySecretCallback>.NativeClassPtr, 100667802);
					LobbyManager.FFIMethods.ConnectLobbyWithActivitySecretCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_byref_Lobby_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.ConnectLobbyWithActivitySecretCallback>.NativeClassPtr, 100667803);
					LobbyManager.FFIMethods.ConnectLobbyWithActivitySecretCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_Lobby_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.ConnectLobbyWithActivitySecretCallback>.NativeClassPtr, 100667804);
				}

				// Token: 0x0600245F RID: 9311 RVA: 0x000A3B6C File Offset: 0x000A1D6C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ConnectLobbyWithActivitySecretCallback(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyManager.FFIMethods.ConnectLobbyWithActivitySecretCallback>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.ConnectLobbyWithActivitySecretCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002460 RID: 9312 RVA: 0x000A3BC8 File Offset: 0x000A1DC8
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr ptr, Result result, ref Lobby lobby)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					ref IntPtr ptr3 = ref ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(lobby);
					ptr3 = &intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.ConnectLobbyWithActivitySecretCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_byref_Lobby_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					lobby = ((intPtr4 == 0) ? null : new Lobby(intPtr4));
				}

				// Token: 0x06002461 RID: 9313 RVA: 0x000A3C40 File Offset: 0x000A1E40
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53378, XrefRangeEnd = 53387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr ptr, Result result, ref Lobby lobby, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					ref IntPtr ptr3 = ref ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(lobby);
					ptr3 = &intPtr;
					ptr2[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr2[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.ConnectLobbyWithActivitySecretCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_byref_Lobby_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					lobby = ((intPtr4 == 0) ? null : new Lobby(intPtr4));
					IntPtr intPtr5 = intPtr2;
					return (intPtr5 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr5) : null;
				}

				// Token: 0x06002462 RID: 9314 RVA: 0x000A3CF0 File Offset: 0x000A1EF0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(ref Lobby lobby, IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					IntPtr intPtr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						ref IntPtr ptr2 = ref *ptr;
						intPtr = IL2CPP.Il2CppObjectBaseToPtr(lobby);
						ptr2 = &intPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.ConnectLobbyWithActivitySecretCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_Lobby_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					lobby = ((intPtr4 == 0) ? null : new Lobby(intPtr4));
				}

				// Token: 0x06002463 RID: 9315 RVA: 0x0000EDAD File Offset: 0x0000CFAD
				public ConnectLobbyWithActivitySecretCallback(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001AE9 RID: 6889
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001AEA RID: 6890
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_byref_Lobby_0;

				// Token: 0x04001AEB RID: 6891
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_byref_Lobby_AsyncCallback_Object_0;

				// Token: 0x04001AEC RID: 6892
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_Lobby_IAsyncResult_0;
			}

			// Token: 0x020002AA RID: 682
			public sealed class ConnectLobbyWithActivitySecretMethod : MulticastDelegate
			{
				// Token: 0x06002464 RID: 9316 RVA: 0x000A3D5C File Offset: 0x000A1F5C
				// Note: this type is marked as 'beforefieldinit'.
				static ConnectLobbyWithActivitySecretMethod()
				{
					Il2CppClassPointerStore<LobbyManager.FFIMethods.ConnectLobbyWithActivitySecretMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "ConnectLobbyWithActivitySecretMethod");
					LobbyManager.FFIMethods.ConnectLobbyWithActivitySecretMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.ConnectLobbyWithActivitySecretMethod>.NativeClassPtr, 100667805);
					LobbyManager.FFIMethods.ConnectLobbyWithActivitySecretMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_String_IntPtr_ConnectLobbyWithActivitySecretCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.ConnectLobbyWithActivitySecretMethod>.NativeClassPtr, 100667806);
					LobbyManager.FFIMethods.ConnectLobbyWithActivitySecretMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_String_IntPtr_ConnectLobbyWithActivitySecretCallback_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.ConnectLobbyWithActivitySecretMethod>.NativeClassPtr, 100667807);
					LobbyManager.FFIMethods.ConnectLobbyWithActivitySecretMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.ConnectLobbyWithActivitySecretMethod>.NativeClassPtr, 100667808);
				}

				// Token: 0x06002465 RID: 9317 RVA: 0x000A3DD0 File Offset: 0x000A1FD0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ConnectLobbyWithActivitySecretMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyManager.FFIMethods.ConnectLobbyWithActivitySecretMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.ConnectLobbyWithActivitySecretMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002466 RID: 9318 RVA: 0x000A3E2C File Offset: 0x000A202C
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr methodsPtr, string activitySecret, IntPtr callbackData, LobbyManager.FFIMethods.ConnectLobbyWithActivitySecretCallback callback)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(activitySecret);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callbackData;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.ConnectLobbyWithActivitySecretMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_String_IntPtr_ConnectLobbyWithActivitySecretCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002467 RID: 9319 RVA: 0x000A3EA0 File Offset: 0x000A20A0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53387, XrefRangeEnd = 53392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, string activitySecret, IntPtr callbackData, LobbyManager.FFIMethods.ConnectLobbyWithActivitySecretCallback callback, AsyncCallback __callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(activitySecret);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callbackData;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(__callback);
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.ConnectLobbyWithActivitySecretMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_String_IntPtr_ConnectLobbyWithActivitySecretCallback_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06002468 RID: 9320 RVA: 0x000A3F48 File Offset: 0x000A2148
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.ConnectLobbyWithActivitySecretMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06002469 RID: 9321 RVA: 0x0000EDB6 File Offset: 0x0000CFB6
				public ConnectLobbyWithActivitySecretMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x0600246A RID: 9322 RVA: 0x0000EDBF File Offset: 0x0000CFBF
				public static implicit operator LobbyManager.FFIMethods.ConnectLobbyWithActivitySecretMethod(Action<IntPtr, string, IntPtr, LobbyManager.FFIMethods.ConnectLobbyWithActivitySecretCallback> A_0)
				{
					return DelegateSupport.ConvertDelegate<LobbyManager.FFIMethods.ConnectLobbyWithActivitySecretMethod>(A_0);
				}

				// Token: 0x0600246B RID: 9323 RVA: 0x0000EDC7 File Offset: 0x0000CFC7
				public static LobbyManager.FFIMethods.ConnectLobbyWithActivitySecretMethod operator +(LobbyManager.FFIMethods.ConnectLobbyWithActivitySecretMethod A_0, LobbyManager.FFIMethods.ConnectLobbyWithActivitySecretMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<LobbyManager.FFIMethods.ConnectLobbyWithActivitySecretMethod>();
				}

				// Token: 0x0600246C RID: 9324 RVA: 0x0000EDD5 File Offset: 0x0000CFD5
				public static LobbyManager.FFIMethods.ConnectLobbyWithActivitySecretMethod operator -(LobbyManager.FFIMethods.ConnectLobbyWithActivitySecretMethod A_0, LobbyManager.FFIMethods.ConnectLobbyWithActivitySecretMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<LobbyManager.FFIMethods.ConnectLobbyWithActivitySecretMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001AED RID: 6893
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001AEE RID: 6894
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_String_IntPtr_ConnectLobbyWithActivitySecretCallback_0;

				// Token: 0x04001AEF RID: 6895
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_String_IntPtr_ConnectLobbyWithActivitySecretCallback_AsyncCallback_Object_0;

				// Token: 0x04001AF0 RID: 6896
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x020002AB RID: 683
			public sealed class DisconnectLobbyCallback : MulticastDelegate
			{
				// Token: 0x0600246D RID: 9325 RVA: 0x000A3F8C File Offset: 0x000A218C
				// Note: this type is marked as 'beforefieldinit'.
				static DisconnectLobbyCallback()
				{
					Il2CppClassPointerStore<LobbyManager.FFIMethods.DisconnectLobbyCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "DisconnectLobbyCallback");
					LobbyManager.FFIMethods.DisconnectLobbyCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.DisconnectLobbyCallback>.NativeClassPtr, 100667809);
					LobbyManager.FFIMethods.DisconnectLobbyCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.DisconnectLobbyCallback>.NativeClassPtr, 100667810);
					LobbyManager.FFIMethods.DisconnectLobbyCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.DisconnectLobbyCallback>.NativeClassPtr, 100667811);
					LobbyManager.FFIMethods.DisconnectLobbyCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.DisconnectLobbyCallback>.NativeClassPtr, 100667812);
				}

				// Token: 0x0600246E RID: 9326 RVA: 0x000A4000 File Offset: 0x000A2200
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe DisconnectLobbyCallback(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyManager.FFIMethods.DisconnectLobbyCallback>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.DisconnectLobbyCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600246F RID: 9327 RVA: 0x000A405C File Offset: 0x000A225C
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr ptr, Result result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.DisconnectLobbyCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002470 RID: 9328 RVA: 0x000A40AC File Offset: 0x000A22AC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53392, XrefRangeEnd = 53398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr2[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.DisconnectLobbyCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06002471 RID: 9329 RVA: 0x000A4130 File Offset: 0x000A2330
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.DisconnectLobbyCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06002472 RID: 9330 RVA: 0x0000EDE6 File Offset: 0x0000CFE6
				public DisconnectLobbyCallback(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06002473 RID: 9331 RVA: 0x0000EDEF File Offset: 0x0000CFEF
				public static implicit operator LobbyManager.FFIMethods.DisconnectLobbyCallback(Action<IntPtr, Result> A_0)
				{
					return DelegateSupport.ConvertDelegate<LobbyManager.FFIMethods.DisconnectLobbyCallback>(A_0);
				}

				// Token: 0x06002474 RID: 9332 RVA: 0x0000EDF7 File Offset: 0x0000CFF7
				public static LobbyManager.FFIMethods.DisconnectLobbyCallback operator +(LobbyManager.FFIMethods.DisconnectLobbyCallback A_0, LobbyManager.FFIMethods.DisconnectLobbyCallback A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<LobbyManager.FFIMethods.DisconnectLobbyCallback>();
				}

				// Token: 0x06002475 RID: 9333 RVA: 0x0000EE05 File Offset: 0x0000D005
				public static LobbyManager.FFIMethods.DisconnectLobbyCallback operator -(LobbyManager.FFIMethods.DisconnectLobbyCallback A_0, LobbyManager.FFIMethods.DisconnectLobbyCallback A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<LobbyManager.FFIMethods.DisconnectLobbyCallback>();
					}
					return delegate2;
				}

				// Token: 0x04001AF1 RID: 6897
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001AF2 RID: 6898
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_0;

				// Token: 0x04001AF3 RID: 6899
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_AsyncCallback_Object_0;

				// Token: 0x04001AF4 RID: 6900
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x020002AC RID: 684
			public sealed class DisconnectLobbyMethod : MulticastDelegate
			{
				// Token: 0x06002476 RID: 9334 RVA: 0x000A4174 File Offset: 0x000A2374
				// Note: this type is marked as 'beforefieldinit'.
				static DisconnectLobbyMethod()
				{
					Il2CppClassPointerStore<LobbyManager.FFIMethods.DisconnectLobbyMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "DisconnectLobbyMethod");
					LobbyManager.FFIMethods.DisconnectLobbyMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.DisconnectLobbyMethod>.NativeClassPtr, 100667813);
					LobbyManager.FFIMethods.DisconnectLobbyMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int64_IntPtr_DisconnectLobbyCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.DisconnectLobbyMethod>.NativeClassPtr, 100667814);
					LobbyManager.FFIMethods.DisconnectLobbyMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_IntPtr_DisconnectLobbyCallback_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.DisconnectLobbyMethod>.NativeClassPtr, 100667815);
					LobbyManager.FFIMethods.DisconnectLobbyMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.DisconnectLobbyMethod>.NativeClassPtr, 100667816);
				}

				// Token: 0x06002477 RID: 9335 RVA: 0x000A41E8 File Offset: 0x000A23E8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe DisconnectLobbyMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyManager.FFIMethods.DisconnectLobbyMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.DisconnectLobbyMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002478 RID: 9336 RVA: 0x000A4244 File Offset: 0x000A2444
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr methodsPtr, long lobbyId, IntPtr callbackData, LobbyManager.FFIMethods.DisconnectLobbyCallback callback)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lobbyId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callbackData;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.DisconnectLobbyMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int64_IntPtr_DisconnectLobbyCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002479 RID: 9337 RVA: 0x000A42B4 File Offset: 0x000A24B4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, long lobbyId, IntPtr callbackData, LobbyManager.FFIMethods.DisconnectLobbyCallback callback, AsyncCallback __callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lobbyId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callbackData;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(__callback);
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.DisconnectLobbyMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_IntPtr_DisconnectLobbyCallback_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x0600247A RID: 9338 RVA: 0x000A4358 File Offset: 0x000A2558
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.DisconnectLobbyMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x0600247B RID: 9339 RVA: 0x0000EE16 File Offset: 0x0000D016
				public DisconnectLobbyMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x0600247C RID: 9340 RVA: 0x0000EE1F File Offset: 0x0000D01F
				public static implicit operator LobbyManager.FFIMethods.DisconnectLobbyMethod(Action<IntPtr, long, IntPtr, LobbyManager.FFIMethods.DisconnectLobbyCallback> A_0)
				{
					return DelegateSupport.ConvertDelegate<LobbyManager.FFIMethods.DisconnectLobbyMethod>(A_0);
				}

				// Token: 0x0600247D RID: 9341 RVA: 0x0000EE27 File Offset: 0x0000D027
				public static LobbyManager.FFIMethods.DisconnectLobbyMethod operator +(LobbyManager.FFIMethods.DisconnectLobbyMethod A_0, LobbyManager.FFIMethods.DisconnectLobbyMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<LobbyManager.FFIMethods.DisconnectLobbyMethod>();
				}

				// Token: 0x0600247E RID: 9342 RVA: 0x0000EE35 File Offset: 0x0000D035
				public static LobbyManager.FFIMethods.DisconnectLobbyMethod operator -(LobbyManager.FFIMethods.DisconnectLobbyMethod A_0, LobbyManager.FFIMethods.DisconnectLobbyMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<LobbyManager.FFIMethods.DisconnectLobbyMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001AF5 RID: 6901
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001AF6 RID: 6902
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int64_IntPtr_DisconnectLobbyCallback_0;

				// Token: 0x04001AF7 RID: 6903
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_IntPtr_DisconnectLobbyCallback_AsyncCallback_Object_0;

				// Token: 0x04001AF8 RID: 6904
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x020002AD RID: 685
			public sealed class GetLobbyMethod : MulticastDelegate
			{
				// Token: 0x0600247F RID: 9343 RVA: 0x000A439C File Offset: 0x000A259C
				// Note: this type is marked as 'beforefieldinit'.
				static GetLobbyMethod()
				{
					Il2CppClassPointerStore<LobbyManager.FFIMethods.GetLobbyMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "GetLobbyMethod");
					LobbyManager.FFIMethods.GetLobbyMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.GetLobbyMethod>.NativeClassPtr, 100667817);
					LobbyManager.FFIMethods.GetLobbyMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_byref_Lobby_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.GetLobbyMethod>.NativeClassPtr, 100667818);
					LobbyManager.FFIMethods.GetLobbyMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_byref_Lobby_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.GetLobbyMethod>.NativeClassPtr, 100667819);
					LobbyManager.FFIMethods.GetLobbyMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_Lobby_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.GetLobbyMethod>.NativeClassPtr, 100667820);
				}

				// Token: 0x06002480 RID: 9344 RVA: 0x000A4410 File Offset: 0x000A2610
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe GetLobbyMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyManager.FFIMethods.GetLobbyMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.GetLobbyMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002481 RID: 9345 RVA: 0x000A446C File Offset: 0x000A266C
				[CallerCount(0)]
				public unsafe Result Invoke(IntPtr methodsPtr, long lobbyId, ref Lobby lobby)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lobbyId;
					ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(lobby);
					ptr2 = &intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.GetLobbyMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_byref_Lobby_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					lobby = ((intPtr4 == 0) ? null : new Lobby(intPtr4));
					IntPtr intPtr5 = intPtr2;
					return (intPtr5 != 0) ? Il2CppObjectPool.Get<Result>(intPtr5) : null;
				}

				// Token: 0x06002482 RID: 9346 RVA: 0x000A44F0 File Offset: 0x000A26F0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53398, XrefRangeEnd = 53406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, long lobbyId, ref Lobby lobby, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lobbyId;
					ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(lobby);
					ptr2 = &intPtr;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.GetLobbyMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_byref_Lobby_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					lobby = ((intPtr4 == 0) ? null : new Lobby(intPtr4));
					IntPtr intPtr5 = intPtr2;
					return (intPtr5 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr5) : null;
				}

				// Token: 0x06002483 RID: 9347 RVA: 0x000A459C File Offset: 0x000A279C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Result EndInvoke(ref Lobby lobby, IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					IntPtr intPtr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						ref IntPtr ptr2 = ref *ptr;
						intPtr = IL2CPP.Il2CppObjectBaseToPtr(lobby);
						ptr2 = &intPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.GetLobbyMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_Lobby_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					lobby = ((intPtr4 == 0) ? null : new Lobby(intPtr4));
					IntPtr intPtr5 = intPtr2;
					return (intPtr5 != 0) ? Il2CppObjectPool.Get<Result>(intPtr5) : null;
				}

				// Token: 0x06002484 RID: 9348 RVA: 0x0000EE46 File Offset: 0x0000D046
				public GetLobbyMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001AF9 RID: 6905
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001AFA RID: 6906
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_byref_Lobby_0;

				// Token: 0x04001AFB RID: 6907
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_byref_Lobby_AsyncCallback_Object_0;

				// Token: 0x04001AFC RID: 6908
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_Lobby_IAsyncResult_0;
			}

			// Token: 0x020002AE RID: 686
			public sealed class GetLobbyActivitySecretMethod : MulticastDelegate
			{
				// Token: 0x06002485 RID: 9349 RVA: 0x000A4618 File Offset: 0x000A2818
				// Note: this type is marked as 'beforefieldinit'.
				static GetLobbyActivitySecretMethod()
				{
					Il2CppClassPointerStore<LobbyManager.FFIMethods.GetLobbyActivitySecretMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "GetLobbyActivitySecretMethod");
					LobbyManager.FFIMethods.GetLobbyActivitySecretMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.GetLobbyActivitySecretMethod>.NativeClassPtr, 100667821);
					LobbyManager.FFIMethods.GetLobbyActivitySecretMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.GetLobbyActivitySecretMethod>.NativeClassPtr, 100667822);
					LobbyManager.FFIMethods.GetLobbyActivitySecretMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_StringBuilder_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.GetLobbyActivitySecretMethod>.NativeClassPtr, 100667823);
					LobbyManager.FFIMethods.GetLobbyActivitySecretMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.GetLobbyActivitySecretMethod>.NativeClassPtr, 100667824);
				}

				// Token: 0x06002486 RID: 9350 RVA: 0x000A468C File Offset: 0x000A288C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe GetLobbyActivitySecretMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyManager.FFIMethods.GetLobbyActivitySecretMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.GetLobbyActivitySecretMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002487 RID: 9351 RVA: 0x000A46E8 File Offset: 0x000A28E8
				[CallerCount(0)]
				public unsafe Result Invoke(IntPtr methodsPtr, long lobbyId, StringBuilder secret)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lobbyId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(secret);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.GetLobbyActivitySecretMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x06002488 RID: 9352 RVA: 0x000A4754 File Offset: 0x000A2954
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53406, XrefRangeEnd = 53411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, long lobbyId, StringBuilder secret, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lobbyId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(secret);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.GetLobbyActivitySecretMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_StringBuilder_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06002489 RID: 9353 RVA: 0x000A47E8 File Offset: 0x000A29E8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Result EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.GetLobbyActivitySecretMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
					}
				}

				// Token: 0x0600248A RID: 9354 RVA: 0x0000EE4F File Offset: 0x0000D04F
				public GetLobbyActivitySecretMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x0600248B RID: 9355 RVA: 0x0000EE58 File Offset: 0x0000D058
				public static implicit operator LobbyManager.FFIMethods.GetLobbyActivitySecretMethod(Func<IntPtr, long, StringBuilder, Result> A_0)
				{
					return DelegateSupport.ConvertDelegate<LobbyManager.FFIMethods.GetLobbyActivitySecretMethod>(A_0);
				}

				// Token: 0x0600248C RID: 9356 RVA: 0x0000EE60 File Offset: 0x0000D060
				public static LobbyManager.FFIMethods.GetLobbyActivitySecretMethod operator +(LobbyManager.FFIMethods.GetLobbyActivitySecretMethod A_0, LobbyManager.FFIMethods.GetLobbyActivitySecretMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<LobbyManager.FFIMethods.GetLobbyActivitySecretMethod>();
				}

				// Token: 0x0600248D RID: 9357 RVA: 0x0000EE6E File Offset: 0x0000D06E
				public static LobbyManager.FFIMethods.GetLobbyActivitySecretMethod operator -(LobbyManager.FFIMethods.GetLobbyActivitySecretMethod A_0, LobbyManager.FFIMethods.GetLobbyActivitySecretMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<LobbyManager.FFIMethods.GetLobbyActivitySecretMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001AFD RID: 6909
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001AFE RID: 6910
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_StringBuilder_0;

				// Token: 0x04001AFF RID: 6911
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_StringBuilder_AsyncCallback_Object_0;

				// Token: 0x04001B00 RID: 6912
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0;
			}

			// Token: 0x020002AF RID: 687
			public sealed class GetLobbyMetadataValueMethod : MulticastDelegate
			{
				// Token: 0x0600248E RID: 9358 RVA: 0x000A4838 File Offset: 0x000A2A38
				// Note: this type is marked as 'beforefieldinit'.
				static GetLobbyMetadataValueMethod()
				{
					Il2CppClassPointerStore<LobbyManager.FFIMethods.GetLobbyMetadataValueMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "GetLobbyMetadataValueMethod");
					LobbyManager.FFIMethods.GetLobbyMetadataValueMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.GetLobbyMetadataValueMethod>.NativeClassPtr, 100667825);
					LobbyManager.FFIMethods.GetLobbyMetadataValueMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_String_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.GetLobbyMetadataValueMethod>.NativeClassPtr, 100667826);
					LobbyManager.FFIMethods.GetLobbyMetadataValueMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_String_StringBuilder_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.GetLobbyMetadataValueMethod>.NativeClassPtr, 100667827);
					LobbyManager.FFIMethods.GetLobbyMetadataValueMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.GetLobbyMetadataValueMethod>.NativeClassPtr, 100667828);
				}

				// Token: 0x0600248F RID: 9359 RVA: 0x000A48AC File Offset: 0x000A2AAC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe GetLobbyMetadataValueMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyManager.FFIMethods.GetLobbyMetadataValueMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.GetLobbyMetadataValueMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002490 RID: 9360 RVA: 0x000A4908 File Offset: 0x000A2B08
				[CallerCount(0)]
				public unsafe Result Invoke(IntPtr methodsPtr, long lobbyId, string key, StringBuilder value)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lobbyId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.GetLobbyMetadataValueMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_String_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x06002491 RID: 9361 RVA: 0x000A4988 File Offset: 0x000A2B88
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53411, XrefRangeEnd = 53416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, long lobbyId, string key, StringBuilder value, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lobbyId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.GetLobbyMetadataValueMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_String_StringBuilder_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06002492 RID: 9362 RVA: 0x000A4A30 File Offset: 0x000A2C30
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Result EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.GetLobbyMetadataValueMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
					}
				}

				// Token: 0x06002493 RID: 9363 RVA: 0x0000EE7F File Offset: 0x0000D07F
				public GetLobbyMetadataValueMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06002494 RID: 9364 RVA: 0x0000EE88 File Offset: 0x0000D088
				public static implicit operator LobbyManager.FFIMethods.GetLobbyMetadataValueMethod(Func<IntPtr, long, string, StringBuilder, Result> A_0)
				{
					return DelegateSupport.ConvertDelegate<LobbyManager.FFIMethods.GetLobbyMetadataValueMethod>(A_0);
				}

				// Token: 0x06002495 RID: 9365 RVA: 0x0000EE90 File Offset: 0x0000D090
				public static LobbyManager.FFIMethods.GetLobbyMetadataValueMethod operator +(LobbyManager.FFIMethods.GetLobbyMetadataValueMethod A_0, LobbyManager.FFIMethods.GetLobbyMetadataValueMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<LobbyManager.FFIMethods.GetLobbyMetadataValueMethod>();
				}

				// Token: 0x06002496 RID: 9366 RVA: 0x0000EE9E File Offset: 0x0000D09E
				public static LobbyManager.FFIMethods.GetLobbyMetadataValueMethod operator -(LobbyManager.FFIMethods.GetLobbyMetadataValueMethod A_0, LobbyManager.FFIMethods.GetLobbyMetadataValueMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<LobbyManager.FFIMethods.GetLobbyMetadataValueMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001B01 RID: 6913
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001B02 RID: 6914
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_String_StringBuilder_0;

				// Token: 0x04001B03 RID: 6915
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_String_StringBuilder_AsyncCallback_Object_0;

				// Token: 0x04001B04 RID: 6916
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0;
			}

			// Token: 0x020002B0 RID: 688
			public sealed class GetLobbyMetadataKeyMethod : MulticastDelegate
			{
				// Token: 0x06002497 RID: 9367 RVA: 0x000A4A80 File Offset: 0x000A2C80
				// Note: this type is marked as 'beforefieldinit'.
				static GetLobbyMetadataKeyMethod()
				{
					Il2CppClassPointerStore<LobbyManager.FFIMethods.GetLobbyMetadataKeyMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "GetLobbyMetadataKeyMethod");
					LobbyManager.FFIMethods.GetLobbyMetadataKeyMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.GetLobbyMetadataKeyMethod>.NativeClassPtr, 100667829);
					LobbyManager.FFIMethods.GetLobbyMetadataKeyMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_Int32_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.GetLobbyMetadataKeyMethod>.NativeClassPtr, 100667830);
					LobbyManager.FFIMethods.GetLobbyMetadataKeyMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_Int32_StringBuilder_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.GetLobbyMetadataKeyMethod>.NativeClassPtr, 100667831);
					LobbyManager.FFIMethods.GetLobbyMetadataKeyMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.GetLobbyMetadataKeyMethod>.NativeClassPtr, 100667832);
				}

				// Token: 0x06002498 RID: 9368 RVA: 0x000A4AF4 File Offset: 0x000A2CF4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe GetLobbyMetadataKeyMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyManager.FFIMethods.GetLobbyMetadataKeyMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.GetLobbyMetadataKeyMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002499 RID: 9369 RVA: 0x000A4B50 File Offset: 0x000A2D50
				[CallerCount(0)]
				public unsafe Result Invoke(IntPtr methodsPtr, long lobbyId, int index, StringBuilder key)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lobbyId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(key);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.GetLobbyMetadataKeyMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_Int32_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x0600249A RID: 9370 RVA: 0x000A4BCC File Offset: 0x000A2DCC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53416, XrefRangeEnd = 53423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, long lobbyId, int index, StringBuilder key, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lobbyId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(key);
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.GetLobbyMetadataKeyMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_Int32_StringBuilder_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x0600249B RID: 9371 RVA: 0x000A4C70 File Offset: 0x000A2E70
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Result EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.GetLobbyMetadataKeyMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
					}
				}

				// Token: 0x0600249C RID: 9372 RVA: 0x0000EEAF File Offset: 0x0000D0AF
				public GetLobbyMetadataKeyMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x0600249D RID: 9373 RVA: 0x0000EEB8 File Offset: 0x0000D0B8
				public static implicit operator LobbyManager.FFIMethods.GetLobbyMetadataKeyMethod(Func<IntPtr, long, int, StringBuilder, Result> A_0)
				{
					return DelegateSupport.ConvertDelegate<LobbyManager.FFIMethods.GetLobbyMetadataKeyMethod>(A_0);
				}

				// Token: 0x0600249E RID: 9374 RVA: 0x0000EEC0 File Offset: 0x0000D0C0
				public static LobbyManager.FFIMethods.GetLobbyMetadataKeyMethod operator +(LobbyManager.FFIMethods.GetLobbyMetadataKeyMethod A_0, LobbyManager.FFIMethods.GetLobbyMetadataKeyMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<LobbyManager.FFIMethods.GetLobbyMetadataKeyMethod>();
				}

				// Token: 0x0600249F RID: 9375 RVA: 0x0000EECE File Offset: 0x0000D0CE
				public static LobbyManager.FFIMethods.GetLobbyMetadataKeyMethod operator -(LobbyManager.FFIMethods.GetLobbyMetadataKeyMethod A_0, LobbyManager.FFIMethods.GetLobbyMetadataKeyMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<LobbyManager.FFIMethods.GetLobbyMetadataKeyMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001B05 RID: 6917
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001B06 RID: 6918
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_Int32_StringBuilder_0;

				// Token: 0x04001B07 RID: 6919
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_Int32_StringBuilder_AsyncCallback_Object_0;

				// Token: 0x04001B08 RID: 6920
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0;
			}

			// Token: 0x020002B1 RID: 689
			public sealed class LobbyMetadataCountMethod : MulticastDelegate
			{
				// Token: 0x060024A0 RID: 9376 RVA: 0x000A4CC0 File Offset: 0x000A2EC0
				// Note: this type is marked as 'beforefieldinit'.
				static LobbyMetadataCountMethod()
				{
					Il2CppClassPointerStore<LobbyManager.FFIMethods.LobbyMetadataCountMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "LobbyMetadataCountMethod");
					LobbyManager.FFIMethods.LobbyMetadataCountMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.LobbyMetadataCountMethod>.NativeClassPtr, 100667833);
					LobbyManager.FFIMethods.LobbyMetadataCountMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.LobbyMetadataCountMethod>.NativeClassPtr, 100667834);
					LobbyManager.FFIMethods.LobbyMetadataCountMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_byref_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.LobbyMetadataCountMethod>.NativeClassPtr, 100667835);
					LobbyManager.FFIMethods.LobbyMetadataCountMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.LobbyMetadataCountMethod>.NativeClassPtr, 100667836);
				}

				// Token: 0x060024A1 RID: 9377 RVA: 0x000A4D34 File Offset: 0x000A2F34
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe LobbyMetadataCountMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyManager.FFIMethods.LobbyMetadataCountMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.LobbyMetadataCountMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060024A2 RID: 9378 RVA: 0x000A4D90 File Offset: 0x000A2F90
				[CallerCount(0)]
				public unsafe Result Invoke(IntPtr methodsPtr, long lobbyId, ref int count)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lobbyId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &count;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.LobbyMetadataCountMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x060024A3 RID: 9379 RVA: 0x000A4DF8 File Offset: 0x000A2FF8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53423, XrefRangeEnd = 53430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, long lobbyId, ref int count, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lobbyId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &count;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.LobbyMetadataCountMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_byref_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060024A4 RID: 9380 RVA: 0x000A4E88 File Offset: 0x000A3088
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Result EndInvoke(ref int count, IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = &count;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.LobbyMetadataCountMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_Int32_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x060024A5 RID: 9381 RVA: 0x0000EEDF File Offset: 0x0000D0DF
				public LobbyMetadataCountMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001B09 RID: 6921
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001B0A RID: 6922
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_byref_Int32_0;

				// Token: 0x04001B0B RID: 6923
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_byref_Int32_AsyncCallback_Object_0;

				// Token: 0x04001B0C RID: 6924
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_Int32_IAsyncResult_0;
			}

			// Token: 0x020002B2 RID: 690
			public sealed class MemberCountMethod : MulticastDelegate
			{
				// Token: 0x060024A6 RID: 9382 RVA: 0x000A4EE8 File Offset: 0x000A30E8
				// Note: this type is marked as 'beforefieldinit'.
				static MemberCountMethod()
				{
					Il2CppClassPointerStore<LobbyManager.FFIMethods.MemberCountMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "MemberCountMethod");
					LobbyManager.FFIMethods.MemberCountMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.MemberCountMethod>.NativeClassPtr, 100667837);
					LobbyManager.FFIMethods.MemberCountMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.MemberCountMethod>.NativeClassPtr, 100667838);
					LobbyManager.FFIMethods.MemberCountMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_byref_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.MemberCountMethod>.NativeClassPtr, 100667839);
					LobbyManager.FFIMethods.MemberCountMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.MemberCountMethod>.NativeClassPtr, 100667840);
				}

				// Token: 0x060024A7 RID: 9383 RVA: 0x000A4F5C File Offset: 0x000A315C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe MemberCountMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyManager.FFIMethods.MemberCountMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.MemberCountMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060024A8 RID: 9384 RVA: 0x000A4FB8 File Offset: 0x000A31B8
				[CallerCount(0)]
				public unsafe Result Invoke(IntPtr methodsPtr, long lobbyId, ref int count)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lobbyId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &count;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.MemberCountMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x060024A9 RID: 9385 RVA: 0x000A5020 File Offset: 0x000A3220
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, long lobbyId, ref int count, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lobbyId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &count;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.MemberCountMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_byref_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060024AA RID: 9386 RVA: 0x000A50B0 File Offset: 0x000A32B0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Result EndInvoke(ref int count, IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = &count;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.MemberCountMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_Int32_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x060024AB RID: 9387 RVA: 0x0000EEE8 File Offset: 0x0000D0E8
				public MemberCountMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001B0D RID: 6925
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001B0E RID: 6926
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_byref_Int32_0;

				// Token: 0x04001B0F RID: 6927
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_byref_Int32_AsyncCallback_Object_0;

				// Token: 0x04001B10 RID: 6928
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_Int32_IAsyncResult_0;
			}

			// Token: 0x020002B3 RID: 691
			public sealed class GetMemberUserIdMethod : MulticastDelegate
			{
				// Token: 0x060024AC RID: 9388 RVA: 0x000A5110 File Offset: 0x000A3310
				// Note: this type is marked as 'beforefieldinit'.
				static GetMemberUserIdMethod()
				{
					Il2CppClassPointerStore<LobbyManager.FFIMethods.GetMemberUserIdMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "GetMemberUserIdMethod");
					LobbyManager.FFIMethods.GetMemberUserIdMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.GetMemberUserIdMethod>.NativeClassPtr, 100667841);
					LobbyManager.FFIMethods.GetMemberUserIdMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_Int32_byref_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.GetMemberUserIdMethod>.NativeClassPtr, 100667842);
					LobbyManager.FFIMethods.GetMemberUserIdMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_Int32_byref_Int64_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.GetMemberUserIdMethod>.NativeClassPtr, 100667843);
					LobbyManager.FFIMethods.GetMemberUserIdMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_Int64_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.GetMemberUserIdMethod>.NativeClassPtr, 100667844);
				}

				// Token: 0x060024AD RID: 9389 RVA: 0x000A5184 File Offset: 0x000A3384
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe GetMemberUserIdMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyManager.FFIMethods.GetMemberUserIdMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.GetMemberUserIdMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060024AE RID: 9390 RVA: 0x000A51E0 File Offset: 0x000A33E0
				[CallerCount(0)]
				public unsafe Result Invoke(IntPtr methodsPtr, long lobbyId, int index, ref long userId)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lobbyId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &userId;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.GetMemberUserIdMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_Int32_byref_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x060024AF RID: 9391 RVA: 0x000A5258 File Offset: 0x000A3458
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53430, XrefRangeEnd = 53439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, long lobbyId, int index, ref long userId, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lobbyId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &userId;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.GetMemberUserIdMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_Int32_byref_Int64_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060024B0 RID: 9392 RVA: 0x000A52F8 File Offset: 0x000A34F8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Result EndInvoke(ref long userId, IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = &userId;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.GetMemberUserIdMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_Int64_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x060024B1 RID: 9393 RVA: 0x0000EEF1 File Offset: 0x0000D0F1
				public GetMemberUserIdMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001B11 RID: 6929
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001B12 RID: 6930
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_Int32_byref_Int64_0;

				// Token: 0x04001B13 RID: 6931
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_Int32_byref_Int64_AsyncCallback_Object_0;

				// Token: 0x04001B14 RID: 6932
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_Int64_IAsyncResult_0;
			}

			// Token: 0x020002B4 RID: 692
			public sealed class GetMemberUserMethod : MulticastDelegate
			{
				// Token: 0x060024B2 RID: 9394 RVA: 0x000A5358 File Offset: 0x000A3558
				// Note: this type is marked as 'beforefieldinit'.
				static GetMemberUserMethod()
				{
					Il2CppClassPointerStore<LobbyManager.FFIMethods.GetMemberUserMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "GetMemberUserMethod");
					LobbyManager.FFIMethods.GetMemberUserMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.GetMemberUserMethod>.NativeClassPtr, 100667845);
					LobbyManager.FFIMethods.GetMemberUserMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_Int64_byref_User_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.GetMemberUserMethod>.NativeClassPtr, 100667846);
					LobbyManager.FFIMethods.GetMemberUserMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_Int64_byref_User_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.GetMemberUserMethod>.NativeClassPtr, 100667847);
					LobbyManager.FFIMethods.GetMemberUserMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_User_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.GetMemberUserMethod>.NativeClassPtr, 100667848);
				}

				// Token: 0x060024B3 RID: 9395 RVA: 0x000A53CC File Offset: 0x000A35CC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe GetMemberUserMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyManager.FFIMethods.GetMemberUserMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.GetMemberUserMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060024B4 RID: 9396 RVA: 0x000A5428 File Offset: 0x000A3628
				[CallerCount(0)]
				public unsafe Result Invoke(IntPtr methodsPtr, long lobbyId, long userId, ref User user)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lobbyId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userId;
					ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(user);
					ptr2 = &intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.GetMemberUserMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_Int64_byref_User_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					user = ((intPtr4 == 0) ? null : new User(intPtr4));
					IntPtr intPtr5 = intPtr2;
					return (intPtr5 != 0) ? Il2CppObjectPool.Get<Result>(intPtr5) : null;
				}

				// Token: 0x060024B5 RID: 9397 RVA: 0x000A54BC File Offset: 0x000A36BC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53439, XrefRangeEnd = 53449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, long lobbyId, long userId, ref User user, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lobbyId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userId;
					ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(user);
					ptr2 = &intPtr;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.GetMemberUserMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_Int64_byref_User_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					user = ((intPtr4 == 0) ? null : new User(intPtr4));
					IntPtr intPtr5 = intPtr2;
					return (intPtr5 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr5) : null;
				}

				// Token: 0x060024B6 RID: 9398 RVA: 0x000A5578 File Offset: 0x000A3778
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Result EndInvoke(ref User user, IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					IntPtr intPtr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						ref IntPtr ptr2 = ref *ptr;
						intPtr = IL2CPP.Il2CppObjectBaseToPtr(user);
						ptr2 = &intPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.GetMemberUserMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_User_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					IntPtr intPtr4 = intPtr;
					user = ((intPtr4 == 0) ? null : new User(intPtr4));
					IntPtr intPtr5 = intPtr2;
					return (intPtr5 != 0) ? Il2CppObjectPool.Get<Result>(intPtr5) : null;
				}

				// Token: 0x060024B7 RID: 9399 RVA: 0x0000EEFA File Offset: 0x0000D0FA
				public GetMemberUserMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001B15 RID: 6933
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001B16 RID: 6934
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_Int64_byref_User_0;

				// Token: 0x04001B17 RID: 6935
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_Int64_byref_User_AsyncCallback_Object_0;

				// Token: 0x04001B18 RID: 6936
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_User_IAsyncResult_0;
			}

			// Token: 0x020002B5 RID: 693
			public sealed class GetMemberMetadataValueMethod : MulticastDelegate
			{
				// Token: 0x060024B8 RID: 9400 RVA: 0x000A55F4 File Offset: 0x000A37F4
				// Note: this type is marked as 'beforefieldinit'.
				static GetMemberMetadataValueMethod()
				{
					Il2CppClassPointerStore<LobbyManager.FFIMethods.GetMemberMetadataValueMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "GetMemberMetadataValueMethod");
					LobbyManager.FFIMethods.GetMemberMetadataValueMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.GetMemberMetadataValueMethod>.NativeClassPtr, 100667849);
					LobbyManager.FFIMethods.GetMemberMetadataValueMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_Int64_String_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.GetMemberMetadataValueMethod>.NativeClassPtr, 100667850);
					LobbyManager.FFIMethods.GetMemberMetadataValueMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_Int64_String_StringBuilder_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.GetMemberMetadataValueMethod>.NativeClassPtr, 100667851);
					LobbyManager.FFIMethods.GetMemberMetadataValueMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.GetMemberMetadataValueMethod>.NativeClassPtr, 100667852);
				}

				// Token: 0x060024B9 RID: 9401 RVA: 0x000A5668 File Offset: 0x000A3868
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53449, XrefRangeEnd = 53452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe GetMemberMetadataValueMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyManager.FFIMethods.GetMemberMetadataValueMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.GetMemberMetadataValueMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060024BA RID: 9402 RVA: 0x000A56C4 File Offset: 0x000A38C4
				[CallerCount(0)]
				public unsafe Result Invoke(IntPtr methodsPtr, long lobbyId, long userId, string key, StringBuilder value)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lobbyId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userId;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.GetMemberMetadataValueMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_Int64_String_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x060024BB RID: 9403 RVA: 0x000A5754 File Offset: 0x000A3954
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53452, XrefRangeEnd = 53459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, long lobbyId, long userId, string key, StringBuilder value, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lobbyId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userId;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.GetMemberMetadataValueMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_Int64_String_StringBuilder_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060024BC RID: 9404 RVA: 0x000A5808 File Offset: 0x000A3A08
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Result EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.GetMemberMetadataValueMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
					}
				}

				// Token: 0x060024BD RID: 9405 RVA: 0x0000EF03 File Offset: 0x0000D103
				public GetMemberMetadataValueMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060024BE RID: 9406 RVA: 0x0000EF0C File Offset: 0x0000D10C
				public static implicit operator LobbyManager.FFIMethods.GetMemberMetadataValueMethod(Func<IntPtr, long, long, string, StringBuilder, Result> A_0)
				{
					return DelegateSupport.ConvertDelegate<LobbyManager.FFIMethods.GetMemberMetadataValueMethod>(A_0);
				}

				// Token: 0x060024BF RID: 9407 RVA: 0x0000EF14 File Offset: 0x0000D114
				public static LobbyManager.FFIMethods.GetMemberMetadataValueMethod operator +(LobbyManager.FFIMethods.GetMemberMetadataValueMethod A_0, LobbyManager.FFIMethods.GetMemberMetadataValueMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<LobbyManager.FFIMethods.GetMemberMetadataValueMethod>();
				}

				// Token: 0x060024C0 RID: 9408 RVA: 0x0000EF22 File Offset: 0x0000D122
				public static LobbyManager.FFIMethods.GetMemberMetadataValueMethod operator -(LobbyManager.FFIMethods.GetMemberMetadataValueMethod A_0, LobbyManager.FFIMethods.GetMemberMetadataValueMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<LobbyManager.FFIMethods.GetMemberMetadataValueMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001B19 RID: 6937
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001B1A RID: 6938
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_Int64_String_StringBuilder_0;

				// Token: 0x04001B1B RID: 6939
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_Int64_String_StringBuilder_AsyncCallback_Object_0;

				// Token: 0x04001B1C RID: 6940
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0;
			}

			// Token: 0x020002B6 RID: 694
			public sealed class GetMemberMetadataKeyMethod : MulticastDelegate
			{
				// Token: 0x060024C1 RID: 9409 RVA: 0x000A5858 File Offset: 0x000A3A58
				// Note: this type is marked as 'beforefieldinit'.
				static GetMemberMetadataKeyMethod()
				{
					Il2CppClassPointerStore<LobbyManager.FFIMethods.GetMemberMetadataKeyMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "GetMemberMetadataKeyMethod");
					LobbyManager.FFIMethods.GetMemberMetadataKeyMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.GetMemberMetadataKeyMethod>.NativeClassPtr, 100667853);
					LobbyManager.FFIMethods.GetMemberMetadataKeyMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_Int64_Int32_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.GetMemberMetadataKeyMethod>.NativeClassPtr, 100667854);
					LobbyManager.FFIMethods.GetMemberMetadataKeyMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_Int64_Int32_StringBuilder_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.GetMemberMetadataKeyMethod>.NativeClassPtr, 100667855);
					LobbyManager.FFIMethods.GetMemberMetadataKeyMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.GetMemberMetadataKeyMethod>.NativeClassPtr, 100667856);
				}

				// Token: 0x060024C2 RID: 9410 RVA: 0x000A58CC File Offset: 0x000A3ACC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53459, XrefRangeEnd = 53462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe GetMemberMetadataKeyMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyManager.FFIMethods.GetMemberMetadataKeyMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.GetMemberMetadataKeyMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060024C3 RID: 9411 RVA: 0x000A5928 File Offset: 0x000A3B28
				[CallerCount(0)]
				public unsafe Result Invoke(IntPtr methodsPtr, long lobbyId, long userId, int index, StringBuilder key)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lobbyId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userId;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(key);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.GetMemberMetadataKeyMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_Int64_Int32_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x060024C4 RID: 9412 RVA: 0x000A59B4 File Offset: 0x000A3BB4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53462, XrefRangeEnd = 53471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, long lobbyId, long userId, int index, StringBuilder key, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lobbyId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userId;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(key);
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.GetMemberMetadataKeyMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_Int64_Int32_StringBuilder_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060024C5 RID: 9413 RVA: 0x000A5A64 File Offset: 0x000A3C64
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Result EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.GetMemberMetadataKeyMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
					}
				}

				// Token: 0x060024C6 RID: 9414 RVA: 0x0000EF33 File Offset: 0x0000D133
				public GetMemberMetadataKeyMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060024C7 RID: 9415 RVA: 0x0000EF3C File Offset: 0x0000D13C
				public static implicit operator LobbyManager.FFIMethods.GetMemberMetadataKeyMethod(Func<IntPtr, long, long, int, StringBuilder, Result> A_0)
				{
					return DelegateSupport.ConvertDelegate<LobbyManager.FFIMethods.GetMemberMetadataKeyMethod>(A_0);
				}

				// Token: 0x060024C8 RID: 9416 RVA: 0x0000EF44 File Offset: 0x0000D144
				public static LobbyManager.FFIMethods.GetMemberMetadataKeyMethod operator +(LobbyManager.FFIMethods.GetMemberMetadataKeyMethod A_0, LobbyManager.FFIMethods.GetMemberMetadataKeyMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<LobbyManager.FFIMethods.GetMemberMetadataKeyMethod>();
				}

				// Token: 0x060024C9 RID: 9417 RVA: 0x0000EF52 File Offset: 0x0000D152
				public static LobbyManager.FFIMethods.GetMemberMetadataKeyMethod operator -(LobbyManager.FFIMethods.GetMemberMetadataKeyMethod A_0, LobbyManager.FFIMethods.GetMemberMetadataKeyMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<LobbyManager.FFIMethods.GetMemberMetadataKeyMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001B1D RID: 6941
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001B1E RID: 6942
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_Int64_Int32_StringBuilder_0;

				// Token: 0x04001B1F RID: 6943
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_Int64_Int32_StringBuilder_AsyncCallback_Object_0;

				// Token: 0x04001B20 RID: 6944
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0;
			}

			// Token: 0x020002B7 RID: 695
			public sealed class MemberMetadataCountMethod : MulticastDelegate
			{
				// Token: 0x060024CA RID: 9418 RVA: 0x000A5AB4 File Offset: 0x000A3CB4
				// Note: this type is marked as 'beforefieldinit'.
				static MemberMetadataCountMethod()
				{
					Il2CppClassPointerStore<LobbyManager.FFIMethods.MemberMetadataCountMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "MemberMetadataCountMethod");
					LobbyManager.FFIMethods.MemberMetadataCountMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.MemberMetadataCountMethod>.NativeClassPtr, 100667857);
					LobbyManager.FFIMethods.MemberMetadataCountMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_Int64_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.MemberMetadataCountMethod>.NativeClassPtr, 100667858);
					LobbyManager.FFIMethods.MemberMetadataCountMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_Int64_byref_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.MemberMetadataCountMethod>.NativeClassPtr, 100667859);
					LobbyManager.FFIMethods.MemberMetadataCountMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.MemberMetadataCountMethod>.NativeClassPtr, 100667860);
				}

				// Token: 0x060024CB RID: 9419 RVA: 0x000A5B28 File Offset: 0x000A3D28
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe MemberMetadataCountMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyManager.FFIMethods.MemberMetadataCountMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.MemberMetadataCountMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060024CC RID: 9420 RVA: 0x000A5B84 File Offset: 0x000A3D84
				[CallerCount(0)]
				public unsafe Result Invoke(IntPtr methodsPtr, long lobbyId, long userId, ref int count)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lobbyId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userId;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &count;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.MemberMetadataCountMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_Int64_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x060024CD RID: 9421 RVA: 0x000A5BFC File Offset: 0x000A3DFC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53471, XrefRangeEnd = 53480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, long lobbyId, long userId, ref int count, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lobbyId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userId;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &count;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.MemberMetadataCountMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_Int64_byref_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060024CE RID: 9422 RVA: 0x000A5C9C File Offset: 0x000A3E9C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Result EndInvoke(ref int count, IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = &count;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.MemberMetadataCountMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_Int32_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x060024CF RID: 9423 RVA: 0x0000EF63 File Offset: 0x0000D163
				public MemberMetadataCountMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001B21 RID: 6945
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001B22 RID: 6946
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_Int64_byref_Int32_0;

				// Token: 0x04001B23 RID: 6947
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_Int64_byref_Int32_AsyncCallback_Object_0;

				// Token: 0x04001B24 RID: 6948
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_Int32_IAsyncResult_0;
			}

			// Token: 0x020002B8 RID: 696
			public sealed class UpdateMemberCallback : MulticastDelegate
			{
				// Token: 0x060024D0 RID: 9424 RVA: 0x000A5CFC File Offset: 0x000A3EFC
				// Note: this type is marked as 'beforefieldinit'.
				static UpdateMemberCallback()
				{
					Il2CppClassPointerStore<LobbyManager.FFIMethods.UpdateMemberCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "UpdateMemberCallback");
					LobbyManager.FFIMethods.UpdateMemberCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.UpdateMemberCallback>.NativeClassPtr, 100667861);
					LobbyManager.FFIMethods.UpdateMemberCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.UpdateMemberCallback>.NativeClassPtr, 100667862);
					LobbyManager.FFIMethods.UpdateMemberCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.UpdateMemberCallback>.NativeClassPtr, 100667863);
					LobbyManager.FFIMethods.UpdateMemberCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.UpdateMemberCallback>.NativeClassPtr, 100667864);
				}

				// Token: 0x060024D1 RID: 9425 RVA: 0x000A5D70 File Offset: 0x000A3F70
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe UpdateMemberCallback(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyManager.FFIMethods.UpdateMemberCallback>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.UpdateMemberCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060024D2 RID: 9426 RVA: 0x000A5DCC File Offset: 0x000A3FCC
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr ptr, Result result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.UpdateMemberCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060024D3 RID: 9427 RVA: 0x000A5E1C File Offset: 0x000A401C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53480, XrefRangeEnd = 53486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr2[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.UpdateMemberCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060024D4 RID: 9428 RVA: 0x000A5EA0 File Offset: 0x000A40A0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.UpdateMemberCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060024D5 RID: 9429 RVA: 0x0000EF6C File Offset: 0x0000D16C
				public UpdateMemberCallback(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060024D6 RID: 9430 RVA: 0x0000EF75 File Offset: 0x0000D175
				public static implicit operator LobbyManager.FFIMethods.UpdateMemberCallback(Action<IntPtr, Result> A_0)
				{
					return DelegateSupport.ConvertDelegate<LobbyManager.FFIMethods.UpdateMemberCallback>(A_0);
				}

				// Token: 0x060024D7 RID: 9431 RVA: 0x0000EF7D File Offset: 0x0000D17D
				public static LobbyManager.FFIMethods.UpdateMemberCallback operator +(LobbyManager.FFIMethods.UpdateMemberCallback A_0, LobbyManager.FFIMethods.UpdateMemberCallback A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<LobbyManager.FFIMethods.UpdateMemberCallback>();
				}

				// Token: 0x060024D8 RID: 9432 RVA: 0x0000EF8B File Offset: 0x0000D18B
				public static LobbyManager.FFIMethods.UpdateMemberCallback operator -(LobbyManager.FFIMethods.UpdateMemberCallback A_0, LobbyManager.FFIMethods.UpdateMemberCallback A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<LobbyManager.FFIMethods.UpdateMemberCallback>();
					}
					return delegate2;
				}

				// Token: 0x04001B25 RID: 6949
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001B26 RID: 6950
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_0;

				// Token: 0x04001B27 RID: 6951
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_AsyncCallback_Object_0;

				// Token: 0x04001B28 RID: 6952
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x020002B9 RID: 697
			public sealed class UpdateMemberMethod : MulticastDelegate
			{
				// Token: 0x060024D9 RID: 9433 RVA: 0x000A5EE4 File Offset: 0x000A40E4
				// Note: this type is marked as 'beforefieldinit'.
				static UpdateMemberMethod()
				{
					Il2CppClassPointerStore<LobbyManager.FFIMethods.UpdateMemberMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "UpdateMemberMethod");
					LobbyManager.FFIMethods.UpdateMemberMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.UpdateMemberMethod>.NativeClassPtr, 100667865);
					LobbyManager.FFIMethods.UpdateMemberMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int64_Int64_IntPtr_IntPtr_UpdateMemberCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.UpdateMemberMethod>.NativeClassPtr, 100667866);
					LobbyManager.FFIMethods.UpdateMemberMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_Int64_IntPtr_IntPtr_UpdateMemberCallback_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.UpdateMemberMethod>.NativeClassPtr, 100667867);
					LobbyManager.FFIMethods.UpdateMemberMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.UpdateMemberMethod>.NativeClassPtr, 100667868);
				}

				// Token: 0x060024DA RID: 9434 RVA: 0x000A5F58 File Offset: 0x000A4158
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53486, XrefRangeEnd = 53489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe UpdateMemberMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyManager.FFIMethods.UpdateMemberMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.UpdateMemberMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060024DB RID: 9435 RVA: 0x000A5FB4 File Offset: 0x000A41B4
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr methodsPtr, long lobbyId, long userId, IntPtr transaction, IntPtr callbackData, LobbyManager.FFIMethods.UpdateMemberCallback callback)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lobbyId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userId;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref transaction;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callbackData;
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.UpdateMemberMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int64_Int64_IntPtr_IntPtr_UpdateMemberCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060024DC RID: 9436 RVA: 0x000A6040 File Offset: 0x000A4240
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53489, XrefRangeEnd = 53500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, long lobbyId, long userId, IntPtr transaction, IntPtr callbackData, LobbyManager.FFIMethods.UpdateMemberCallback callback, AsyncCallback __callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lobbyId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userId;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref transaction;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callbackData;
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(__callback);
					ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.UpdateMemberMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_Int64_IntPtr_IntPtr_UpdateMemberCallback_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060024DD RID: 9437 RVA: 0x000A6100 File Offset: 0x000A4300
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.UpdateMemberMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060024DE RID: 9438 RVA: 0x0000EF9C File Offset: 0x0000D19C
				public UpdateMemberMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060024DF RID: 9439 RVA: 0x0000EFA5 File Offset: 0x0000D1A5
				public static implicit operator LobbyManager.FFIMethods.UpdateMemberMethod(Action<IntPtr, long, long, IntPtr, IntPtr, LobbyManager.FFIMethods.UpdateMemberCallback> A_0)
				{
					return DelegateSupport.ConvertDelegate<LobbyManager.FFIMethods.UpdateMemberMethod>(A_0);
				}

				// Token: 0x060024E0 RID: 9440 RVA: 0x0000EFAD File Offset: 0x0000D1AD
				public static LobbyManager.FFIMethods.UpdateMemberMethod operator +(LobbyManager.FFIMethods.UpdateMemberMethod A_0, LobbyManager.FFIMethods.UpdateMemberMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<LobbyManager.FFIMethods.UpdateMemberMethod>();
				}

				// Token: 0x060024E1 RID: 9441 RVA: 0x0000EFBB File Offset: 0x0000D1BB
				public static LobbyManager.FFIMethods.UpdateMemberMethod operator -(LobbyManager.FFIMethods.UpdateMemberMethod A_0, LobbyManager.FFIMethods.UpdateMemberMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<LobbyManager.FFIMethods.UpdateMemberMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001B29 RID: 6953
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001B2A RID: 6954
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int64_Int64_IntPtr_IntPtr_UpdateMemberCallback_0;

				// Token: 0x04001B2B RID: 6955
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_Int64_IntPtr_IntPtr_UpdateMemberCallback_AsyncCallback_Object_0;

				// Token: 0x04001B2C RID: 6956
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x020002BA RID: 698
			public sealed class SendLobbyMessageCallback : MulticastDelegate
			{
				// Token: 0x060024E2 RID: 9442 RVA: 0x000A6144 File Offset: 0x000A4344
				// Note: this type is marked as 'beforefieldinit'.
				static SendLobbyMessageCallback()
				{
					Il2CppClassPointerStore<LobbyManager.FFIMethods.SendLobbyMessageCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "SendLobbyMessageCallback");
					LobbyManager.FFIMethods.SendLobbyMessageCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.SendLobbyMessageCallback>.NativeClassPtr, 100667869);
					LobbyManager.FFIMethods.SendLobbyMessageCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.SendLobbyMessageCallback>.NativeClassPtr, 100667870);
					LobbyManager.FFIMethods.SendLobbyMessageCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.SendLobbyMessageCallback>.NativeClassPtr, 100667871);
					LobbyManager.FFIMethods.SendLobbyMessageCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.SendLobbyMessageCallback>.NativeClassPtr, 100667872);
				}

				// Token: 0x060024E3 RID: 9443 RVA: 0x000A61B8 File Offset: 0x000A43B8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe SendLobbyMessageCallback(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyManager.FFIMethods.SendLobbyMessageCallback>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.SendLobbyMessageCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060024E4 RID: 9444 RVA: 0x000A6214 File Offset: 0x000A4414
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr ptr, Result result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.SendLobbyMessageCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060024E5 RID: 9445 RVA: 0x000A6264 File Offset: 0x000A4464
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53500, XrefRangeEnd = 53506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr2[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.SendLobbyMessageCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060024E6 RID: 9446 RVA: 0x000A62E8 File Offset: 0x000A44E8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.SendLobbyMessageCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060024E7 RID: 9447 RVA: 0x0000EFCC File Offset: 0x0000D1CC
				public SendLobbyMessageCallback(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060024E8 RID: 9448 RVA: 0x0000EFD5 File Offset: 0x0000D1D5
				public static implicit operator LobbyManager.FFIMethods.SendLobbyMessageCallback(Action<IntPtr, Result> A_0)
				{
					return DelegateSupport.ConvertDelegate<LobbyManager.FFIMethods.SendLobbyMessageCallback>(A_0);
				}

				// Token: 0x060024E9 RID: 9449 RVA: 0x0000EFDD File Offset: 0x0000D1DD
				public static LobbyManager.FFIMethods.SendLobbyMessageCallback operator +(LobbyManager.FFIMethods.SendLobbyMessageCallback A_0, LobbyManager.FFIMethods.SendLobbyMessageCallback A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<LobbyManager.FFIMethods.SendLobbyMessageCallback>();
				}

				// Token: 0x060024EA RID: 9450 RVA: 0x0000EFEB File Offset: 0x0000D1EB
				public static LobbyManager.FFIMethods.SendLobbyMessageCallback operator -(LobbyManager.FFIMethods.SendLobbyMessageCallback A_0, LobbyManager.FFIMethods.SendLobbyMessageCallback A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<LobbyManager.FFIMethods.SendLobbyMessageCallback>();
					}
					return delegate2;
				}

				// Token: 0x04001B2D RID: 6957
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001B2E RID: 6958
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_0;

				// Token: 0x04001B2F RID: 6959
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_AsyncCallback_Object_0;

				// Token: 0x04001B30 RID: 6960
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x020002BB RID: 699
			public sealed class SendLobbyMessageMethod : MulticastDelegate
			{
				// Token: 0x060024EB RID: 9451 RVA: 0x000A632C File Offset: 0x000A452C
				// Note: this type is marked as 'beforefieldinit'.
				static SendLobbyMessageMethod()
				{
					Il2CppClassPointerStore<LobbyManager.FFIMethods.SendLobbyMessageMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "SendLobbyMessageMethod");
					LobbyManager.FFIMethods.SendLobbyMessageMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.SendLobbyMessageMethod>.NativeClassPtr, 100667873);
					LobbyManager.FFIMethods.SendLobbyMessageMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int64_Il2CppStructArray_1_Byte_Int32_IntPtr_SendLobbyMessageCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.SendLobbyMessageMethod>.NativeClassPtr, 100667874);
					LobbyManager.FFIMethods.SendLobbyMessageMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_Il2CppStructArray_1_Byte_Int32_IntPtr_SendLobbyMessageCallback_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.SendLobbyMessageMethod>.NativeClassPtr, 100667875);
					LobbyManager.FFIMethods.SendLobbyMessageMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.SendLobbyMessageMethod>.NativeClassPtr, 100667876);
				}

				// Token: 0x060024EC RID: 9452 RVA: 0x000A63A0 File Offset: 0x000A45A0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53506, XrefRangeEnd = 53509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe SendLobbyMessageMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyManager.FFIMethods.SendLobbyMessageMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.SendLobbyMessageMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060024ED RID: 9453 RVA: 0x000A63FC File Offset: 0x000A45FC
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr methodsPtr, long lobbyId, Il2CppStructArray<byte> data, int dataLen, IntPtr callbackData, LobbyManager.FFIMethods.SendLobbyMessageCallback callback)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lobbyId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataLen;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callbackData;
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.SendLobbyMessageMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int64_Il2CppStructArray_1_Byte_Int32_IntPtr_SendLobbyMessageCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060024EE RID: 9454 RVA: 0x000A648C File Offset: 0x000A468C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53509, XrefRangeEnd = 53518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, long lobbyId, Il2CppStructArray<byte> data, int dataLen, IntPtr callbackData, LobbyManager.FFIMethods.SendLobbyMessageCallback callback, AsyncCallback __callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lobbyId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataLen;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callbackData;
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(__callback);
					ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.SendLobbyMessageMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_Il2CppStructArray_1_Byte_Int32_IntPtr_SendLobbyMessageCallback_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060024EF RID: 9455 RVA: 0x000A6550 File Offset: 0x000A4750
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.SendLobbyMessageMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060024F0 RID: 9456 RVA: 0x0000EFFC File Offset: 0x0000D1FC
				public SendLobbyMessageMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060024F1 RID: 9457 RVA: 0x0000F005 File Offset: 0x0000D205
				public static implicit operator LobbyManager.FFIMethods.SendLobbyMessageMethod(Action<IntPtr, long, Il2CppStructArray<byte>, int, IntPtr, LobbyManager.FFIMethods.SendLobbyMessageCallback> A_0)
				{
					return DelegateSupport.ConvertDelegate<LobbyManager.FFIMethods.SendLobbyMessageMethod>(A_0);
				}

				// Token: 0x060024F2 RID: 9458 RVA: 0x0000F00D File Offset: 0x0000D20D
				public static LobbyManager.FFIMethods.SendLobbyMessageMethod operator +(LobbyManager.FFIMethods.SendLobbyMessageMethod A_0, LobbyManager.FFIMethods.SendLobbyMessageMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<LobbyManager.FFIMethods.SendLobbyMessageMethod>();
				}

				// Token: 0x060024F3 RID: 9459 RVA: 0x0000F01B File Offset: 0x0000D21B
				public static LobbyManager.FFIMethods.SendLobbyMessageMethod operator -(LobbyManager.FFIMethods.SendLobbyMessageMethod A_0, LobbyManager.FFIMethods.SendLobbyMessageMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<LobbyManager.FFIMethods.SendLobbyMessageMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001B31 RID: 6961
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001B32 RID: 6962
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int64_Il2CppStructArray_1_Byte_Int32_IntPtr_SendLobbyMessageCallback_0;

				// Token: 0x04001B33 RID: 6963
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_Il2CppStructArray_1_Byte_Int32_IntPtr_SendLobbyMessageCallback_AsyncCallback_Object_0;

				// Token: 0x04001B34 RID: 6964
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x020002BC RID: 700
			public sealed class GetSearchQueryMethod : MulticastDelegate
			{
				// Token: 0x060024F4 RID: 9460 RVA: 0x000A6594 File Offset: 0x000A4794
				// Note: this type is marked as 'beforefieldinit'.
				static GetSearchQueryMethod()
				{
					Il2CppClassPointerStore<LobbyManager.FFIMethods.GetSearchQueryMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "GetSearchQueryMethod");
					LobbyManager.FFIMethods.GetSearchQueryMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.GetSearchQueryMethod>.NativeClassPtr, 100667877);
					LobbyManager.FFIMethods.GetSearchQueryMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.GetSearchQueryMethod>.NativeClassPtr, 100667878);
					LobbyManager.FFIMethods.GetSearchQueryMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_IntPtr_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.GetSearchQueryMethod>.NativeClassPtr, 100667879);
					LobbyManager.FFIMethods.GetSearchQueryMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_IntPtr_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.GetSearchQueryMethod>.NativeClassPtr, 100667880);
				}

				// Token: 0x060024F5 RID: 9461 RVA: 0x000A6608 File Offset: 0x000A4808
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe GetSearchQueryMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyManager.FFIMethods.GetSearchQueryMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.GetSearchQueryMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060024F6 RID: 9462 RVA: 0x000A6664 File Offset: 0x000A4864
				[CallerCount(0)]
				public unsafe Result Invoke(IntPtr methodsPtr, ref IntPtr query)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &query;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.GetSearchQueryMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_byref_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x060024F7 RID: 9463 RVA: 0x000A66C0 File Offset: 0x000A48C0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, ref IntPtr query, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &query;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.GetSearchQueryMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_IntPtr_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060024F8 RID: 9464 RVA: 0x000A6740 File Offset: 0x000A4940
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Result EndInvoke(ref IntPtr query, IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = &query;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.GetSearchQueryMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_IntPtr_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x060024F9 RID: 9465 RVA: 0x0000F02C File Offset: 0x0000D22C
				public GetSearchQueryMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001B35 RID: 6965
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001B36 RID: 6966
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_byref_IntPtr_0;

				// Token: 0x04001B37 RID: 6967
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_IntPtr_AsyncCallback_Object_0;

				// Token: 0x04001B38 RID: 6968
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_IntPtr_IAsyncResult_0;
			}

			// Token: 0x020002BD RID: 701
			public sealed class SearchCallback : MulticastDelegate
			{
				// Token: 0x060024FA RID: 9466 RVA: 0x000A67A0 File Offset: 0x000A49A0
				// Note: this type is marked as 'beforefieldinit'.
				static SearchCallback()
				{
					Il2CppClassPointerStore<LobbyManager.FFIMethods.SearchCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "SearchCallback");
					LobbyManager.FFIMethods.SearchCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.SearchCallback>.NativeClassPtr, 100667881);
					LobbyManager.FFIMethods.SearchCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.SearchCallback>.NativeClassPtr, 100667882);
					LobbyManager.FFIMethods.SearchCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.SearchCallback>.NativeClassPtr, 100667883);
					LobbyManager.FFIMethods.SearchCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.SearchCallback>.NativeClassPtr, 100667884);
				}

				// Token: 0x060024FB RID: 9467 RVA: 0x000A6814 File Offset: 0x000A4A14
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe SearchCallback(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyManager.FFIMethods.SearchCallback>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.SearchCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060024FC RID: 9468 RVA: 0x000A6870 File Offset: 0x000A4A70
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr ptr, Result result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.SearchCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060024FD RID: 9469 RVA: 0x000A68C0 File Offset: 0x000A4AC0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53518, XrefRangeEnd = 53524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr2[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.SearchCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060024FE RID: 9470 RVA: 0x000A6944 File Offset: 0x000A4B44
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.SearchCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060024FF RID: 9471 RVA: 0x0000F035 File Offset: 0x0000D235
				public SearchCallback(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06002500 RID: 9472 RVA: 0x0000F03E File Offset: 0x0000D23E
				public static implicit operator LobbyManager.FFIMethods.SearchCallback(Action<IntPtr, Result> A_0)
				{
					return DelegateSupport.ConvertDelegate<LobbyManager.FFIMethods.SearchCallback>(A_0);
				}

				// Token: 0x06002501 RID: 9473 RVA: 0x0000F046 File Offset: 0x0000D246
				public static LobbyManager.FFIMethods.SearchCallback operator +(LobbyManager.FFIMethods.SearchCallback A_0, LobbyManager.FFIMethods.SearchCallback A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<LobbyManager.FFIMethods.SearchCallback>();
				}

				// Token: 0x06002502 RID: 9474 RVA: 0x0000F054 File Offset: 0x0000D254
				public static LobbyManager.FFIMethods.SearchCallback operator -(LobbyManager.FFIMethods.SearchCallback A_0, LobbyManager.FFIMethods.SearchCallback A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<LobbyManager.FFIMethods.SearchCallback>();
					}
					return delegate2;
				}

				// Token: 0x04001B39 RID: 6969
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001B3A RID: 6970
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_0;

				// Token: 0x04001B3B RID: 6971
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_AsyncCallback_Object_0;

				// Token: 0x04001B3C RID: 6972
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x020002BE RID: 702
			public sealed class SearchMethod : MulticastDelegate
			{
				// Token: 0x06002503 RID: 9475 RVA: 0x000A6988 File Offset: 0x000A4B88
				// Note: this type is marked as 'beforefieldinit'.
				static SearchMethod()
				{
					Il2CppClassPointerStore<LobbyManager.FFIMethods.SearchMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "SearchMethod");
					LobbyManager.FFIMethods.SearchMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.SearchMethod>.NativeClassPtr, 100667885);
					LobbyManager.FFIMethods.SearchMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_IntPtr_IntPtr_SearchCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.SearchMethod>.NativeClassPtr, 100667886);
					LobbyManager.FFIMethods.SearchMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_IntPtr_SearchCallback_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.SearchMethod>.NativeClassPtr, 100667887);
					LobbyManager.FFIMethods.SearchMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.SearchMethod>.NativeClassPtr, 100667888);
				}

				// Token: 0x06002504 RID: 9476 RVA: 0x000A69FC File Offset: 0x000A4BFC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe SearchMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyManager.FFIMethods.SearchMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.SearchMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002505 RID: 9477 RVA: 0x000A6A58 File Offset: 0x000A4C58
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr methodsPtr, IntPtr query, IntPtr callbackData, LobbyManager.FFIMethods.SearchCallback callback)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref query;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callbackData;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.SearchMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_IntPtr_IntPtr_SearchCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002506 RID: 9478 RVA: 0x000A6AC8 File Offset: 0x000A4CC8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, IntPtr query, IntPtr callbackData, LobbyManager.FFIMethods.SearchCallback callback, AsyncCallback __callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref query;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callbackData;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(__callback);
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.SearchMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_IntPtr_SearchCallback_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06002507 RID: 9479 RVA: 0x000A6B6C File Offset: 0x000A4D6C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.SearchMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06002508 RID: 9480 RVA: 0x0000F065 File Offset: 0x0000D265
				public SearchMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06002509 RID: 9481 RVA: 0x0000F06E File Offset: 0x0000D26E
				public static implicit operator LobbyManager.FFIMethods.SearchMethod(Action<IntPtr, IntPtr, IntPtr, LobbyManager.FFIMethods.SearchCallback> A_0)
				{
					return DelegateSupport.ConvertDelegate<LobbyManager.FFIMethods.SearchMethod>(A_0);
				}

				// Token: 0x0600250A RID: 9482 RVA: 0x0000F076 File Offset: 0x0000D276
				public static LobbyManager.FFIMethods.SearchMethod operator +(LobbyManager.FFIMethods.SearchMethod A_0, LobbyManager.FFIMethods.SearchMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<LobbyManager.FFIMethods.SearchMethod>();
				}

				// Token: 0x0600250B RID: 9483 RVA: 0x0000F084 File Offset: 0x0000D284
				public static LobbyManager.FFIMethods.SearchMethod operator -(LobbyManager.FFIMethods.SearchMethod A_0, LobbyManager.FFIMethods.SearchMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<LobbyManager.FFIMethods.SearchMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001B3D RID: 6973
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001B3E RID: 6974
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_IntPtr_IntPtr_SearchCallback_0;

				// Token: 0x04001B3F RID: 6975
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_IntPtr_IntPtr_SearchCallback_AsyncCallback_Object_0;

				// Token: 0x04001B40 RID: 6976
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x020002BF RID: 703
			public sealed class LobbyCountMethod : MulticastDelegate
			{
				// Token: 0x0600250C RID: 9484 RVA: 0x000A6BB0 File Offset: 0x000A4DB0
				// Note: this type is marked as 'beforefieldinit'.
				static LobbyCountMethod()
				{
					Il2CppClassPointerStore<LobbyManager.FFIMethods.LobbyCountMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "LobbyCountMethod");
					LobbyManager.FFIMethods.LobbyCountMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.LobbyCountMethod>.NativeClassPtr, 100667889);
					LobbyManager.FFIMethods.LobbyCountMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.LobbyCountMethod>.NativeClassPtr, 100667890);
					LobbyManager.FFIMethods.LobbyCountMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.LobbyCountMethod>.NativeClassPtr, 100667891);
					LobbyManager.FFIMethods.LobbyCountMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.LobbyCountMethod>.NativeClassPtr, 100667892);
				}

				// Token: 0x0600250D RID: 9485 RVA: 0x000A6C24 File Offset: 0x000A4E24
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe LobbyCountMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyManager.FFIMethods.LobbyCountMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.LobbyCountMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600250E RID: 9486 RVA: 0x000A6C80 File Offset: 0x000A4E80
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr methodsPtr, ref int count)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &count;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.LobbyCountMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600250F RID: 9487 RVA: 0x000A6CCC File Offset: 0x000A4ECC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, ref int count, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &count;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.LobbyCountMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06002510 RID: 9488 RVA: 0x000A6D4C File Offset: 0x000A4F4C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(ref int count, IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = &count;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.LobbyCountMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_Int32_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002511 RID: 9489 RVA: 0x0000F095 File Offset: 0x0000D295
				public LobbyCountMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001B41 RID: 6977
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001B42 RID: 6978
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_byref_Int32_0;

				// Token: 0x04001B43 RID: 6979
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_byref_Int32_AsyncCallback_Object_0;

				// Token: 0x04001B44 RID: 6980
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_Int32_IAsyncResult_0;
			}

			// Token: 0x020002C0 RID: 704
			public sealed class GetLobbyIdMethod : MulticastDelegate
			{
				// Token: 0x06002512 RID: 9490 RVA: 0x000A6D9C File Offset: 0x000A4F9C
				// Note: this type is marked as 'beforefieldinit'.
				static GetLobbyIdMethod()
				{
					Il2CppClassPointerStore<LobbyManager.FFIMethods.GetLobbyIdMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "GetLobbyIdMethod");
					LobbyManager.FFIMethods.GetLobbyIdMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.GetLobbyIdMethod>.NativeClassPtr, 100667893);
					LobbyManager.FFIMethods.GetLobbyIdMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int32_byref_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.GetLobbyIdMethod>.NativeClassPtr, 100667894);
					LobbyManager.FFIMethods.GetLobbyIdMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int32_byref_Int64_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.GetLobbyIdMethod>.NativeClassPtr, 100667895);
					LobbyManager.FFIMethods.GetLobbyIdMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_Int64_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.GetLobbyIdMethod>.NativeClassPtr, 100667896);
				}

				// Token: 0x06002513 RID: 9491 RVA: 0x000A6E10 File Offset: 0x000A5010
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe GetLobbyIdMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyManager.FFIMethods.GetLobbyIdMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.GetLobbyIdMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002514 RID: 9492 RVA: 0x000A6E6C File Offset: 0x000A506C
				[CallerCount(0)]
				public unsafe Result Invoke(IntPtr methodsPtr, int index, ref long lobbyId)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lobbyId;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.GetLobbyIdMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int32_byref_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x06002515 RID: 9493 RVA: 0x000A6ED4 File Offset: 0x000A50D4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53524, XrefRangeEnd = 53531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, int index, ref long lobbyId, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &lobbyId;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.GetLobbyIdMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int32_byref_Int64_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06002516 RID: 9494 RVA: 0x000A6F64 File Offset: 0x000A5164
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Result EndInvoke(ref long lobbyId, IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = &lobbyId;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.GetLobbyIdMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_Int64_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x06002517 RID: 9495 RVA: 0x0000F09E File Offset: 0x0000D29E
				public GetLobbyIdMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x04001B45 RID: 6981
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001B46 RID: 6982
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int32_byref_Int64_0;

				// Token: 0x04001B47 RID: 6983
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int32_byref_Int64_AsyncCallback_Object_0;

				// Token: 0x04001B48 RID: 6984
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_byref_Int64_IAsyncResult_0;
			}

			// Token: 0x020002C1 RID: 705
			public sealed class ConnectVoiceCallback : MulticastDelegate
			{
				// Token: 0x06002518 RID: 9496 RVA: 0x000A6FC4 File Offset: 0x000A51C4
				// Note: this type is marked as 'beforefieldinit'.
				static ConnectVoiceCallback()
				{
					Il2CppClassPointerStore<LobbyManager.FFIMethods.ConnectVoiceCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "ConnectVoiceCallback");
					LobbyManager.FFIMethods.ConnectVoiceCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.ConnectVoiceCallback>.NativeClassPtr, 100667897);
					LobbyManager.FFIMethods.ConnectVoiceCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.ConnectVoiceCallback>.NativeClassPtr, 100667898);
					LobbyManager.FFIMethods.ConnectVoiceCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.ConnectVoiceCallback>.NativeClassPtr, 100667899);
					LobbyManager.FFIMethods.ConnectVoiceCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.ConnectVoiceCallback>.NativeClassPtr, 100667900);
				}

				// Token: 0x06002519 RID: 9497 RVA: 0x000A7038 File Offset: 0x000A5238
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ConnectVoiceCallback(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyManager.FFIMethods.ConnectVoiceCallback>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.ConnectVoiceCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600251A RID: 9498 RVA: 0x000A7094 File Offset: 0x000A5294
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr ptr, Result result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.ConnectVoiceCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600251B RID: 9499 RVA: 0x000A70E4 File Offset: 0x000A52E4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53531, XrefRangeEnd = 53537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr2[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.ConnectVoiceCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x0600251C RID: 9500 RVA: 0x000A7168 File Offset: 0x000A5368
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.ConnectVoiceCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x0600251D RID: 9501 RVA: 0x0000F0A7 File Offset: 0x0000D2A7
				public ConnectVoiceCallback(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x0600251E RID: 9502 RVA: 0x0000F0B0 File Offset: 0x0000D2B0
				public static implicit operator LobbyManager.FFIMethods.ConnectVoiceCallback(Action<IntPtr, Result> A_0)
				{
					return DelegateSupport.ConvertDelegate<LobbyManager.FFIMethods.ConnectVoiceCallback>(A_0);
				}

				// Token: 0x0600251F RID: 9503 RVA: 0x0000F0B8 File Offset: 0x0000D2B8
				public static LobbyManager.FFIMethods.ConnectVoiceCallback operator +(LobbyManager.FFIMethods.ConnectVoiceCallback A_0, LobbyManager.FFIMethods.ConnectVoiceCallback A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<LobbyManager.FFIMethods.ConnectVoiceCallback>();
				}

				// Token: 0x06002520 RID: 9504 RVA: 0x0000F0C6 File Offset: 0x0000D2C6
				public static LobbyManager.FFIMethods.ConnectVoiceCallback operator -(LobbyManager.FFIMethods.ConnectVoiceCallback A_0, LobbyManager.FFIMethods.ConnectVoiceCallback A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<LobbyManager.FFIMethods.ConnectVoiceCallback>();
					}
					return delegate2;
				}

				// Token: 0x04001B49 RID: 6985
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001B4A RID: 6986
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_0;

				// Token: 0x04001B4B RID: 6987
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_AsyncCallback_Object_0;

				// Token: 0x04001B4C RID: 6988
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x020002C2 RID: 706
			public sealed class ConnectVoiceMethod : MulticastDelegate
			{
				// Token: 0x06002521 RID: 9505 RVA: 0x000A71AC File Offset: 0x000A53AC
				// Note: this type is marked as 'beforefieldinit'.
				static ConnectVoiceMethod()
				{
					Il2CppClassPointerStore<LobbyManager.FFIMethods.ConnectVoiceMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "ConnectVoiceMethod");
					LobbyManager.FFIMethods.ConnectVoiceMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.ConnectVoiceMethod>.NativeClassPtr, 100667901);
					LobbyManager.FFIMethods.ConnectVoiceMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int64_IntPtr_ConnectVoiceCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.ConnectVoiceMethod>.NativeClassPtr, 100667902);
					LobbyManager.FFIMethods.ConnectVoiceMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_IntPtr_ConnectVoiceCallback_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.ConnectVoiceMethod>.NativeClassPtr, 100667903);
					LobbyManager.FFIMethods.ConnectVoiceMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.ConnectVoiceMethod>.NativeClassPtr, 100667904);
				}

				// Token: 0x06002522 RID: 9506 RVA: 0x000A7220 File Offset: 0x000A5420
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ConnectVoiceMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyManager.FFIMethods.ConnectVoiceMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.ConnectVoiceMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002523 RID: 9507 RVA: 0x000A727C File Offset: 0x000A547C
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr methodsPtr, long lobbyId, IntPtr callbackData, LobbyManager.FFIMethods.ConnectVoiceCallback callback)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lobbyId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callbackData;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.ConnectVoiceMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int64_IntPtr_ConnectVoiceCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002524 RID: 9508 RVA: 0x000A72EC File Offset: 0x000A54EC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, long lobbyId, IntPtr callbackData, LobbyManager.FFIMethods.ConnectVoiceCallback callback, AsyncCallback __callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lobbyId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callbackData;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(__callback);
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.ConnectVoiceMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_IntPtr_ConnectVoiceCallback_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06002525 RID: 9509 RVA: 0x000A7390 File Offset: 0x000A5590
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.ConnectVoiceMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06002526 RID: 9510 RVA: 0x0000F0D7 File Offset: 0x0000D2D7
				public ConnectVoiceMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06002527 RID: 9511 RVA: 0x0000F0E0 File Offset: 0x0000D2E0
				public static implicit operator LobbyManager.FFIMethods.ConnectVoiceMethod(Action<IntPtr, long, IntPtr, LobbyManager.FFIMethods.ConnectVoiceCallback> A_0)
				{
					return DelegateSupport.ConvertDelegate<LobbyManager.FFIMethods.ConnectVoiceMethod>(A_0);
				}

				// Token: 0x06002528 RID: 9512 RVA: 0x0000F0E8 File Offset: 0x0000D2E8
				public static LobbyManager.FFIMethods.ConnectVoiceMethod operator +(LobbyManager.FFIMethods.ConnectVoiceMethod A_0, LobbyManager.FFIMethods.ConnectVoiceMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<LobbyManager.FFIMethods.ConnectVoiceMethod>();
				}

				// Token: 0x06002529 RID: 9513 RVA: 0x0000F0F6 File Offset: 0x0000D2F6
				public static LobbyManager.FFIMethods.ConnectVoiceMethod operator -(LobbyManager.FFIMethods.ConnectVoiceMethod A_0, LobbyManager.FFIMethods.ConnectVoiceMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<LobbyManager.FFIMethods.ConnectVoiceMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001B4D RID: 6989
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001B4E RID: 6990
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int64_IntPtr_ConnectVoiceCallback_0;

				// Token: 0x04001B4F RID: 6991
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_IntPtr_ConnectVoiceCallback_AsyncCallback_Object_0;

				// Token: 0x04001B50 RID: 6992
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x020002C3 RID: 707
			public sealed class DisconnectVoiceCallback : MulticastDelegate
			{
				// Token: 0x0600252A RID: 9514 RVA: 0x000A73D4 File Offset: 0x000A55D4
				// Note: this type is marked as 'beforefieldinit'.
				static DisconnectVoiceCallback()
				{
					Il2CppClassPointerStore<LobbyManager.FFIMethods.DisconnectVoiceCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "DisconnectVoiceCallback");
					LobbyManager.FFIMethods.DisconnectVoiceCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.DisconnectVoiceCallback>.NativeClassPtr, 100667905);
					LobbyManager.FFIMethods.DisconnectVoiceCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.DisconnectVoiceCallback>.NativeClassPtr, 100667906);
					LobbyManager.FFIMethods.DisconnectVoiceCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.DisconnectVoiceCallback>.NativeClassPtr, 100667907);
					LobbyManager.FFIMethods.DisconnectVoiceCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.DisconnectVoiceCallback>.NativeClassPtr, 100667908);
				}

				// Token: 0x0600252B RID: 9515 RVA: 0x000A7448 File Offset: 0x000A5648
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe DisconnectVoiceCallback(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyManager.FFIMethods.DisconnectVoiceCallback>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.DisconnectVoiceCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600252C RID: 9516 RVA: 0x000A74A4 File Offset: 0x000A56A4
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr ptr, Result result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.DisconnectVoiceCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600252D RID: 9517 RVA: 0x000A74F4 File Offset: 0x000A56F4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53537, XrefRangeEnd = 53543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr ptr, Result result, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr2[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.DisconnectVoiceCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x0600252E RID: 9518 RVA: 0x000A7578 File Offset: 0x000A5778
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.DisconnectVoiceCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x0600252F RID: 9519 RVA: 0x0000F107 File Offset: 0x0000D307
				public DisconnectVoiceCallback(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06002530 RID: 9520 RVA: 0x0000F110 File Offset: 0x0000D310
				public static implicit operator LobbyManager.FFIMethods.DisconnectVoiceCallback(Action<IntPtr, Result> A_0)
				{
					return DelegateSupport.ConvertDelegate<LobbyManager.FFIMethods.DisconnectVoiceCallback>(A_0);
				}

				// Token: 0x06002531 RID: 9521 RVA: 0x0000F118 File Offset: 0x0000D318
				public static LobbyManager.FFIMethods.DisconnectVoiceCallback operator +(LobbyManager.FFIMethods.DisconnectVoiceCallback A_0, LobbyManager.FFIMethods.DisconnectVoiceCallback A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<LobbyManager.FFIMethods.DisconnectVoiceCallback>();
				}

				// Token: 0x06002532 RID: 9522 RVA: 0x0000F126 File Offset: 0x0000D326
				public static LobbyManager.FFIMethods.DisconnectVoiceCallback operator -(LobbyManager.FFIMethods.DisconnectVoiceCallback A_0, LobbyManager.FFIMethods.DisconnectVoiceCallback A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<LobbyManager.FFIMethods.DisconnectVoiceCallback>();
					}
					return delegate2;
				}

				// Token: 0x04001B51 RID: 6993
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001B52 RID: 6994
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Result_0;

				// Token: 0x04001B53 RID: 6995
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Result_AsyncCallback_Object_0;

				// Token: 0x04001B54 RID: 6996
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x020002C4 RID: 708
			public sealed class DisconnectVoiceMethod : MulticastDelegate
			{
				// Token: 0x06002533 RID: 9523 RVA: 0x000A75BC File Offset: 0x000A57BC
				// Note: this type is marked as 'beforefieldinit'.
				static DisconnectVoiceMethod()
				{
					Il2CppClassPointerStore<LobbyManager.FFIMethods.DisconnectVoiceMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "DisconnectVoiceMethod");
					LobbyManager.FFIMethods.DisconnectVoiceMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.DisconnectVoiceMethod>.NativeClassPtr, 100667909);
					LobbyManager.FFIMethods.DisconnectVoiceMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int64_IntPtr_DisconnectVoiceCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.DisconnectVoiceMethod>.NativeClassPtr, 100667910);
					LobbyManager.FFIMethods.DisconnectVoiceMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_IntPtr_DisconnectVoiceCallback_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.DisconnectVoiceMethod>.NativeClassPtr, 100667911);
					LobbyManager.FFIMethods.DisconnectVoiceMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.DisconnectVoiceMethod>.NativeClassPtr, 100667912);
				}

				// Token: 0x06002534 RID: 9524 RVA: 0x000A7630 File Offset: 0x000A5830
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe DisconnectVoiceMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyManager.FFIMethods.DisconnectVoiceMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.DisconnectVoiceMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002535 RID: 9525 RVA: 0x000A768C File Offset: 0x000A588C
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr methodsPtr, long lobbyId, IntPtr callbackData, LobbyManager.FFIMethods.DisconnectVoiceCallback callback)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lobbyId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callbackData;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.DisconnectVoiceMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int64_IntPtr_DisconnectVoiceCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002536 RID: 9526 RVA: 0x000A76FC File Offset: 0x000A58FC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, long lobbyId, IntPtr callbackData, LobbyManager.FFIMethods.DisconnectVoiceCallback callback, AsyncCallback __callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lobbyId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callbackData;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(__callback);
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.DisconnectVoiceMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_IntPtr_DisconnectVoiceCallback_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06002537 RID: 9527 RVA: 0x000A77A0 File Offset: 0x000A59A0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.DisconnectVoiceMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06002538 RID: 9528 RVA: 0x0000F137 File Offset: 0x0000D337
				public DisconnectVoiceMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06002539 RID: 9529 RVA: 0x0000F140 File Offset: 0x0000D340
				public static implicit operator LobbyManager.FFIMethods.DisconnectVoiceMethod(Action<IntPtr, long, IntPtr, LobbyManager.FFIMethods.DisconnectVoiceCallback> A_0)
				{
					return DelegateSupport.ConvertDelegate<LobbyManager.FFIMethods.DisconnectVoiceMethod>(A_0);
				}

				// Token: 0x0600253A RID: 9530 RVA: 0x0000F148 File Offset: 0x0000D348
				public static LobbyManager.FFIMethods.DisconnectVoiceMethod operator +(LobbyManager.FFIMethods.DisconnectVoiceMethod A_0, LobbyManager.FFIMethods.DisconnectVoiceMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<LobbyManager.FFIMethods.DisconnectVoiceMethod>();
				}

				// Token: 0x0600253B RID: 9531 RVA: 0x0000F156 File Offset: 0x0000D356
				public static LobbyManager.FFIMethods.DisconnectVoiceMethod operator -(LobbyManager.FFIMethods.DisconnectVoiceMethod A_0, LobbyManager.FFIMethods.DisconnectVoiceMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<LobbyManager.FFIMethods.DisconnectVoiceMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001B55 RID: 6997
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001B56 RID: 6998
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_Int64_IntPtr_DisconnectVoiceCallback_0;

				// Token: 0x04001B57 RID: 6999
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_IntPtr_DisconnectVoiceCallback_AsyncCallback_Object_0;

				// Token: 0x04001B58 RID: 7000
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x020002C5 RID: 709
			public sealed class ConnectNetworkMethod : MulticastDelegate
			{
				// Token: 0x0600253C RID: 9532 RVA: 0x000A77E4 File Offset: 0x000A59E4
				// Note: this type is marked as 'beforefieldinit'.
				static ConnectNetworkMethod()
				{
					Il2CppClassPointerStore<LobbyManager.FFIMethods.ConnectNetworkMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "ConnectNetworkMethod");
					LobbyManager.FFIMethods.ConnectNetworkMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.ConnectNetworkMethod>.NativeClassPtr, 100667913);
					LobbyManager.FFIMethods.ConnectNetworkMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.ConnectNetworkMethod>.NativeClassPtr, 100667914);
					LobbyManager.FFIMethods.ConnectNetworkMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.ConnectNetworkMethod>.NativeClassPtr, 100667915);
					LobbyManager.FFIMethods.ConnectNetworkMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.ConnectNetworkMethod>.NativeClassPtr, 100667916);
				}

				// Token: 0x0600253D RID: 9533 RVA: 0x000A7858 File Offset: 0x000A5A58
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ConnectNetworkMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyManager.FFIMethods.ConnectNetworkMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.ConnectNetworkMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600253E RID: 9534 RVA: 0x000A78B4 File Offset: 0x000A5AB4
				[CallerCount(0)]
				public unsafe Result Invoke(IntPtr methodsPtr, long lobbyId)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lobbyId;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.ConnectNetworkMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x0600253F RID: 9535 RVA: 0x000A7910 File Offset: 0x000A5B10
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, long lobbyId, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lobbyId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.ConnectNetworkMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06002540 RID: 9536 RVA: 0x000A7990 File Offset: 0x000A5B90
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Result EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.ConnectNetworkMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
					}
				}

				// Token: 0x06002541 RID: 9537 RVA: 0x0000F167 File Offset: 0x0000D367
				public ConnectNetworkMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06002542 RID: 9538 RVA: 0x0000F170 File Offset: 0x0000D370
				public static implicit operator LobbyManager.FFIMethods.ConnectNetworkMethod(Func<IntPtr, long, Result> A_0)
				{
					return DelegateSupport.ConvertDelegate<LobbyManager.FFIMethods.ConnectNetworkMethod>(A_0);
				}

				// Token: 0x06002543 RID: 9539 RVA: 0x0000F178 File Offset: 0x0000D378
				public static LobbyManager.FFIMethods.ConnectNetworkMethod operator +(LobbyManager.FFIMethods.ConnectNetworkMethod A_0, LobbyManager.FFIMethods.ConnectNetworkMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<LobbyManager.FFIMethods.ConnectNetworkMethod>();
				}

				// Token: 0x06002544 RID: 9540 RVA: 0x0000F186 File Offset: 0x0000D386
				public static LobbyManager.FFIMethods.ConnectNetworkMethod operator -(LobbyManager.FFIMethods.ConnectNetworkMethod A_0, LobbyManager.FFIMethods.ConnectNetworkMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<LobbyManager.FFIMethods.ConnectNetworkMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001B59 RID: 7001
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001B5A RID: 7002
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_0;

				// Token: 0x04001B5B RID: 7003
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_AsyncCallback_Object_0;

				// Token: 0x04001B5C RID: 7004
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0;
			}

			// Token: 0x020002C6 RID: 710
			public sealed class DisconnectNetworkMethod : MulticastDelegate
			{
				// Token: 0x06002545 RID: 9541 RVA: 0x000A79E0 File Offset: 0x000A5BE0
				// Note: this type is marked as 'beforefieldinit'.
				static DisconnectNetworkMethod()
				{
					Il2CppClassPointerStore<LobbyManager.FFIMethods.DisconnectNetworkMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "DisconnectNetworkMethod");
					LobbyManager.FFIMethods.DisconnectNetworkMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.DisconnectNetworkMethod>.NativeClassPtr, 100667917);
					LobbyManager.FFIMethods.DisconnectNetworkMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.DisconnectNetworkMethod>.NativeClassPtr, 100667918);
					LobbyManager.FFIMethods.DisconnectNetworkMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.DisconnectNetworkMethod>.NativeClassPtr, 100667919);
					LobbyManager.FFIMethods.DisconnectNetworkMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.DisconnectNetworkMethod>.NativeClassPtr, 100667920);
				}

				// Token: 0x06002546 RID: 9542 RVA: 0x000A7A54 File Offset: 0x000A5C54
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe DisconnectNetworkMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyManager.FFIMethods.DisconnectNetworkMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.DisconnectNetworkMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002547 RID: 9543 RVA: 0x000A7AB0 File Offset: 0x000A5CB0
				[CallerCount(0)]
				public unsafe Result Invoke(IntPtr methodsPtr, long lobbyId)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lobbyId;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.DisconnectNetworkMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x06002548 RID: 9544 RVA: 0x000A7B0C File Offset: 0x000A5D0C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, long lobbyId, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lobbyId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.DisconnectNetworkMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06002549 RID: 9545 RVA: 0x000A7B8C File Offset: 0x000A5D8C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Result EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.DisconnectNetworkMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
					}
				}

				// Token: 0x0600254A RID: 9546 RVA: 0x0000F197 File Offset: 0x0000D397
				public DisconnectNetworkMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x0600254B RID: 9547 RVA: 0x0000F1A0 File Offset: 0x0000D3A0
				public static implicit operator LobbyManager.FFIMethods.DisconnectNetworkMethod(Func<IntPtr, long, Result> A_0)
				{
					return DelegateSupport.ConvertDelegate<LobbyManager.FFIMethods.DisconnectNetworkMethod>(A_0);
				}

				// Token: 0x0600254C RID: 9548 RVA: 0x0000F1A8 File Offset: 0x0000D3A8
				public static LobbyManager.FFIMethods.DisconnectNetworkMethod operator +(LobbyManager.FFIMethods.DisconnectNetworkMethod A_0, LobbyManager.FFIMethods.DisconnectNetworkMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<LobbyManager.FFIMethods.DisconnectNetworkMethod>();
				}

				// Token: 0x0600254D RID: 9549 RVA: 0x0000F1B6 File Offset: 0x0000D3B6
				public static LobbyManager.FFIMethods.DisconnectNetworkMethod operator -(LobbyManager.FFIMethods.DisconnectNetworkMethod A_0, LobbyManager.FFIMethods.DisconnectNetworkMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<LobbyManager.FFIMethods.DisconnectNetworkMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001B5D RID: 7005
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001B5E RID: 7006
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_0;

				// Token: 0x04001B5F RID: 7007
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_AsyncCallback_Object_0;

				// Token: 0x04001B60 RID: 7008
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0;
			}

			// Token: 0x020002C7 RID: 711
			public sealed class FlushNetworkMethod : MulticastDelegate
			{
				// Token: 0x0600254E RID: 9550 RVA: 0x000A7BDC File Offset: 0x000A5DDC
				// Note: this type is marked as 'beforefieldinit'.
				static FlushNetworkMethod()
				{
					Il2CppClassPointerStore<LobbyManager.FFIMethods.FlushNetworkMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "FlushNetworkMethod");
					LobbyManager.FFIMethods.FlushNetworkMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.FlushNetworkMethod>.NativeClassPtr, 100667921);
					LobbyManager.FFIMethods.FlushNetworkMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.FlushNetworkMethod>.NativeClassPtr, 100667922);
					LobbyManager.FFIMethods.FlushNetworkMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.FlushNetworkMethod>.NativeClassPtr, 100667923);
					LobbyManager.FFIMethods.FlushNetworkMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.FlushNetworkMethod>.NativeClassPtr, 100667924);
				}

				// Token: 0x0600254F RID: 9551 RVA: 0x000A7C50 File Offset: 0x000A5E50
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe FlushNetworkMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyManager.FFIMethods.FlushNetworkMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.FlushNetworkMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002550 RID: 9552 RVA: 0x000A7CAC File Offset: 0x000A5EAC
				[CallerCount(0)]
				public unsafe Result Invoke(IntPtr methodsPtr)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.FlushNetworkMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
					}
				}

				// Token: 0x06002551 RID: 9553 RVA: 0x000A7CF8 File Offset: 0x000A5EF8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.FlushNetworkMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06002552 RID: 9554 RVA: 0x000A7D68 File Offset: 0x000A5F68
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Result EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.FlushNetworkMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
					}
				}

				// Token: 0x06002553 RID: 9555 RVA: 0x0000F1C7 File Offset: 0x0000D3C7
				public FlushNetworkMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06002554 RID: 9556 RVA: 0x0000F1D0 File Offset: 0x0000D3D0
				public static implicit operator LobbyManager.FFIMethods.FlushNetworkMethod(Func<IntPtr, Result> A_0)
				{
					return DelegateSupport.ConvertDelegate<LobbyManager.FFIMethods.FlushNetworkMethod>(A_0);
				}

				// Token: 0x06002555 RID: 9557 RVA: 0x0000F1D8 File Offset: 0x0000D3D8
				public static LobbyManager.FFIMethods.FlushNetworkMethod operator +(LobbyManager.FFIMethods.FlushNetworkMethod A_0, LobbyManager.FFIMethods.FlushNetworkMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<LobbyManager.FFIMethods.FlushNetworkMethod>();
				}

				// Token: 0x06002556 RID: 9558 RVA: 0x0000F1E6 File Offset: 0x0000D3E6
				public static LobbyManager.FFIMethods.FlushNetworkMethod operator -(LobbyManager.FFIMethods.FlushNetworkMethod A_0, LobbyManager.FFIMethods.FlushNetworkMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<LobbyManager.FFIMethods.FlushNetworkMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001B61 RID: 7009
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001B62 RID: 7010
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_0;

				// Token: 0x04001B63 RID: 7011
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0;

				// Token: 0x04001B64 RID: 7012
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0;
			}

			// Token: 0x020002C8 RID: 712
			public sealed class OpenNetworkChannelMethod : MulticastDelegate
			{
				// Token: 0x06002557 RID: 9559 RVA: 0x000A7DB8 File Offset: 0x000A5FB8
				// Note: this type is marked as 'beforefieldinit'.
				static OpenNetworkChannelMethod()
				{
					Il2CppClassPointerStore<LobbyManager.FFIMethods.OpenNetworkChannelMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "OpenNetworkChannelMethod");
					LobbyManager.FFIMethods.OpenNetworkChannelMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.OpenNetworkChannelMethod>.NativeClassPtr, 100667925);
					LobbyManager.FFIMethods.OpenNetworkChannelMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_Byte_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.OpenNetworkChannelMethod>.NativeClassPtr, 100667926);
					LobbyManager.FFIMethods.OpenNetworkChannelMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_Byte_Boolean_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.OpenNetworkChannelMethod>.NativeClassPtr, 100667927);
					LobbyManager.FFIMethods.OpenNetworkChannelMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.OpenNetworkChannelMethod>.NativeClassPtr, 100667928);
				}

				// Token: 0x06002558 RID: 9560 RVA: 0x000A7E2C File Offset: 0x000A602C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53543, XrefRangeEnd = 53546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe OpenNetworkChannelMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyManager.FFIMethods.OpenNetworkChannelMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.OpenNetworkChannelMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002559 RID: 9561 RVA: 0x000A7E88 File Offset: 0x000A6088
				[CallerCount(0)]
				public unsafe Result Invoke(IntPtr methodsPtr, long lobbyId, byte channelId, bool reliable)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lobbyId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channelId;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reliable;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.OpenNetworkChannelMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_Byte_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x0600255A RID: 9562 RVA: 0x000A7F00 File Offset: 0x000A6100
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53546, XrefRangeEnd = 53555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, long lobbyId, byte channelId, bool reliable, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lobbyId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channelId;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reliable;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.OpenNetworkChannelMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_Byte_Boolean_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x0600255B RID: 9563 RVA: 0x000A7F9C File Offset: 0x000A619C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Result EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.OpenNetworkChannelMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
					}
				}

				// Token: 0x0600255C RID: 9564 RVA: 0x0000F1F7 File Offset: 0x0000D3F7
				public OpenNetworkChannelMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x0600255D RID: 9565 RVA: 0x0000F200 File Offset: 0x0000D400
				public static implicit operator LobbyManager.FFIMethods.OpenNetworkChannelMethod(Func<IntPtr, long, byte, bool, Result> A_0)
				{
					return DelegateSupport.ConvertDelegate<LobbyManager.FFIMethods.OpenNetworkChannelMethod>(A_0);
				}

				// Token: 0x0600255E RID: 9566 RVA: 0x0000F208 File Offset: 0x0000D408
				public static LobbyManager.FFIMethods.OpenNetworkChannelMethod operator +(LobbyManager.FFIMethods.OpenNetworkChannelMethod A_0, LobbyManager.FFIMethods.OpenNetworkChannelMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<LobbyManager.FFIMethods.OpenNetworkChannelMethod>();
				}

				// Token: 0x0600255F RID: 9567 RVA: 0x0000F216 File Offset: 0x0000D416
				public static LobbyManager.FFIMethods.OpenNetworkChannelMethod operator -(LobbyManager.FFIMethods.OpenNetworkChannelMethod A_0, LobbyManager.FFIMethods.OpenNetworkChannelMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<LobbyManager.FFIMethods.OpenNetworkChannelMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001B65 RID: 7013
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001B66 RID: 7014
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_Byte_Boolean_0;

				// Token: 0x04001B67 RID: 7015
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_Byte_Boolean_AsyncCallback_Object_0;

				// Token: 0x04001B68 RID: 7016
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0;
			}

			// Token: 0x020002C9 RID: 713
			public sealed class SendNetworkMessageMethod : MulticastDelegate
			{
				// Token: 0x06002560 RID: 9568 RVA: 0x000A7FEC File Offset: 0x000A61EC
				// Note: this type is marked as 'beforefieldinit'.
				static SendNetworkMessageMethod()
				{
					Il2CppClassPointerStore<LobbyManager.FFIMethods.SendNetworkMessageMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyManager.FFIMethods>.NativeClassPtr, "SendNetworkMessageMethod");
					LobbyManager.FFIMethods.SendNetworkMessageMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.SendNetworkMessageMethod>.NativeClassPtr, 100667929);
					LobbyManager.FFIMethods.SendNetworkMessageMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_Int64_Byte_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.SendNetworkMessageMethod>.NativeClassPtr, 100667930);
					LobbyManager.FFIMethods.SendNetworkMessageMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_Int64_Byte_Il2CppStructArray_1_Byte_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.SendNetworkMessageMethod>.NativeClassPtr, 100667931);
					LobbyManager.FFIMethods.SendNetworkMessageMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.FFIMethods.SendNetworkMessageMethod>.NativeClassPtr, 100667932);
				}

				// Token: 0x06002561 RID: 9569 RVA: 0x000A8060 File Offset: 0x000A6260
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53555, XrefRangeEnd = 53558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe SendNetworkMessageMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyManager.FFIMethods.SendNetworkMessageMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.SendNetworkMessageMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002562 RID: 9570 RVA: 0x000A80BC File Offset: 0x000A62BC
				[CallerCount(0)]
				public unsafe Result Invoke(IntPtr methodsPtr, long lobbyId, long userId, byte channelId, Il2CppStructArray<byte> data, int dataLen)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lobbyId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userId;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channelId;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataLen;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.SendNetworkMessageMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_Int64_Byte_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
				}

				// Token: 0x06002563 RID: 9571 RVA: 0x000A8154 File Offset: 0x000A6354
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53558, XrefRangeEnd = 53569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, long lobbyId, long userId, byte channelId, Il2CppStructArray<byte> data, int dataLen, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lobbyId;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userId;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channelId;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataLen;
					ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.SendNetworkMessageMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_Int64_Byte_Il2CppStructArray_1_Byte_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06002564 RID: 9572 RVA: 0x000A8214 File Offset: 0x000A6414
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Result EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.FFIMethods.SendNetworkMessageMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
					}
				}

				// Token: 0x06002565 RID: 9573 RVA: 0x0000F227 File Offset: 0x0000D427
				public SendNetworkMessageMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06002566 RID: 9574 RVA: 0x0000F230 File Offset: 0x0000D430
				public static implicit operator LobbyManager.FFIMethods.SendNetworkMessageMethod(Func<IntPtr, long, long, byte, Il2CppStructArray<byte>, int, Result> A_0)
				{
					return DelegateSupport.ConvertDelegate<LobbyManager.FFIMethods.SendNetworkMessageMethod>(A_0);
				}

				// Token: 0x06002567 RID: 9575 RVA: 0x0000F238 File Offset: 0x0000D438
				public static LobbyManager.FFIMethods.SendNetworkMessageMethod operator +(LobbyManager.FFIMethods.SendNetworkMessageMethod A_0, LobbyManager.FFIMethods.SendNetworkMessageMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<LobbyManager.FFIMethods.SendNetworkMessageMethod>();
				}

				// Token: 0x06002568 RID: 9576 RVA: 0x0000F246 File Offset: 0x0000D446
				public static LobbyManager.FFIMethods.SendNetworkMessageMethod operator -(LobbyManager.FFIMethods.SendNetworkMessageMethod A_0, LobbyManager.FFIMethods.SendNetworkMessageMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<LobbyManager.FFIMethods.SendNetworkMessageMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001B69 RID: 7017
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001B6A RID: 7018
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_Int64_Int64_Byte_Il2CppStructArray_1_Byte_Int32_0;

				// Token: 0x04001B6B RID: 7019
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_Int64_Int64_Byte_Il2CppStructArray_1_Byte_Int32_AsyncCallback_Object_0;

				// Token: 0x04001B6C RID: 7020
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0;
			}
		}

		// Token: 0x02000217 RID: 535
		public sealed class CreateLobbyHandler : MulticastDelegate
		{
			// Token: 0x06001F6A RID: 8042 RVA: 0x000921A0 File Offset: 0x000903A0
			// Note: this type is marked as 'beforefieldinit'.
			static CreateLobbyHandler()
			{
				Il2CppClassPointerStore<LobbyManager.CreateLobbyHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, "CreateLobbyHandler");
				LobbyManager.CreateLobbyHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.CreateLobbyHandler>.NativeClassPtr, 100667933);
				LobbyManager.CreateLobbyHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_byref_Lobby_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.CreateLobbyHandler>.NativeClassPtr, 100667934);
				LobbyManager.CreateLobbyHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_byref_Lobby_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.CreateLobbyHandler>.NativeClassPtr, 100667935);
				LobbyManager.CreateLobbyHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_Lobby_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.CreateLobbyHandler>.NativeClassPtr, 100667936);
			}

			// Token: 0x06001F6B RID: 8043 RVA: 0x00092214 File Offset: 0x00090414
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 52325, RefRangeEnd = 52342, XrefRangeStart = 52325, XrefRangeEnd = 52342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CreateLobbyHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyManager.CreateLobbyHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.CreateLobbyHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F6C RID: 8044 RVA: 0x00092270 File Offset: 0x00090470
			[CallerCount(0)]
			public unsafe void Invoke(Result result, ref Lobby lobby)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				}
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(lobby);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LobbyManager.CreateLobbyHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_byref_Lobby_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				lobby = ((intPtr4 == 0) ? null : new Lobby(intPtr4));
			}

			// Token: 0x06001F6D RID: 8045 RVA: 0x000922DC File Offset: 0x000904DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53569, XrefRangeEnd = 53576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Result result, ref Lobby lobby, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				}
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(lobby);
				ptr2 = &intPtr;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LobbyManager.CreateLobbyHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_byref_Lobby_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				lobby = ((intPtr4 == 0) ? null : new Lobby(intPtr4));
				IntPtr intPtr5 = intPtr2;
				return (intPtr5 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr5) : null;
			}

			// Token: 0x06001F6E RID: 8046 RVA: 0x0009237C File Offset: 0x0009057C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(ref Lobby lobby, IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				IntPtr intPtr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					intPtr = IL2CPP.Il2CppObjectBaseToPtr(lobby);
					ptr2 = &intPtr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LobbyManager.CreateLobbyHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_Lobby_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				lobby = ((intPtr4 == 0) ? null : new Lobby(intPtr4));
			}

			// Token: 0x06001F6F RID: 8047 RVA: 0x0000CE6E File Offset: 0x0000B06E
			public CreateLobbyHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001898 RID: 6296
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001899 RID: 6297
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_byref_Lobby_0;

			// Token: 0x0400189A RID: 6298
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_byref_Lobby_AsyncCallback_Object_0;

			// Token: 0x0400189B RID: 6299
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_Lobby_IAsyncResult_0;
		}

		// Token: 0x02000218 RID: 536
		public sealed class UpdateLobbyHandler : MulticastDelegate
		{
			// Token: 0x06001F70 RID: 8048 RVA: 0x000923E8 File Offset: 0x000905E8
			// Note: this type is marked as 'beforefieldinit'.
			static UpdateLobbyHandler()
			{
				Il2CppClassPointerStore<LobbyManager.UpdateLobbyHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, "UpdateLobbyHandler");
				LobbyManager.UpdateLobbyHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.UpdateLobbyHandler>.NativeClassPtr, 100667937);
				LobbyManager.UpdateLobbyHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.UpdateLobbyHandler>.NativeClassPtr, 100667938);
				LobbyManager.UpdateLobbyHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.UpdateLobbyHandler>.NativeClassPtr, 100667939);
				LobbyManager.UpdateLobbyHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.UpdateLobbyHandler>.NativeClassPtr, 100667940);
			}

			// Token: 0x06001F71 RID: 8049 RVA: 0x0009245C File Offset: 0x0009065C
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 51861, RefRangeEnd = 51886, XrefRangeStart = 51861, XrefRangeEnd = 51886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UpdateLobbyHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyManager.UpdateLobbyHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.UpdateLobbyHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F72 RID: 8050 RVA: 0x000924B8 File Offset: 0x000906B8
			[CallerCount(0)]
			public unsafe void Invoke(Result result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.UpdateLobbyHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001F73 RID: 8051 RVA: 0x000924FC File Offset: 0x000906FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53576, XrefRangeEnd = 53580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Result result, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.UpdateLobbyHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001F74 RID: 8052 RVA: 0x00092570 File Offset: 0x00090770
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.UpdateLobbyHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001F75 RID: 8053 RVA: 0x0000CE77 File Offset: 0x0000B077
			public UpdateLobbyHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001F76 RID: 8054 RVA: 0x0000CE80 File Offset: 0x0000B080
			public static implicit operator LobbyManager.UpdateLobbyHandler(Action<Result> A_0)
			{
				return DelegateSupport.ConvertDelegate<LobbyManager.UpdateLobbyHandler>(A_0);
			}

			// Token: 0x06001F77 RID: 8055 RVA: 0x0000CE88 File Offset: 0x0000B088
			public static LobbyManager.UpdateLobbyHandler operator +(LobbyManager.UpdateLobbyHandler A_0, LobbyManager.UpdateLobbyHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<LobbyManager.UpdateLobbyHandler>();
			}

			// Token: 0x06001F78 RID: 8056 RVA: 0x0000CE96 File Offset: 0x0000B096
			public static LobbyManager.UpdateLobbyHandler operator -(LobbyManager.UpdateLobbyHandler A_0, LobbyManager.UpdateLobbyHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<LobbyManager.UpdateLobbyHandler>();
				}
				return delegate2;
			}

			// Token: 0x0400189C RID: 6300
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400189D RID: 6301
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0;

			// Token: 0x0400189E RID: 6302
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0;

			// Token: 0x0400189F RID: 6303
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000219 RID: 537
		public sealed class DeleteLobbyHandler : MulticastDelegate
		{
			// Token: 0x06001F79 RID: 8057 RVA: 0x000925B4 File Offset: 0x000907B4
			// Note: this type is marked as 'beforefieldinit'.
			static DeleteLobbyHandler()
			{
				Il2CppClassPointerStore<LobbyManager.DeleteLobbyHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, "DeleteLobbyHandler");
				LobbyManager.DeleteLobbyHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.DeleteLobbyHandler>.NativeClassPtr, 100667941);
				LobbyManager.DeleteLobbyHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.DeleteLobbyHandler>.NativeClassPtr, 100667942);
				LobbyManager.DeleteLobbyHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.DeleteLobbyHandler>.NativeClassPtr, 100667943);
				LobbyManager.DeleteLobbyHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.DeleteLobbyHandler>.NativeClassPtr, 100667944);
			}

			// Token: 0x06001F7A RID: 8058 RVA: 0x00092628 File Offset: 0x00090828
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 51861, RefRangeEnd = 51886, XrefRangeStart = 51861, XrefRangeEnd = 51886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DeleteLobbyHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyManager.DeleteLobbyHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.DeleteLobbyHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F7B RID: 8059 RVA: 0x00092684 File Offset: 0x00090884
			[CallerCount(0)]
			public unsafe void Invoke(Result result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.DeleteLobbyHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001F7C RID: 8060 RVA: 0x000926C8 File Offset: 0x000908C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53580, XrefRangeEnd = 53584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Result result, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.DeleteLobbyHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001F7D RID: 8061 RVA: 0x0009273C File Offset: 0x0009093C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.DeleteLobbyHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001F7E RID: 8062 RVA: 0x0000CEA7 File Offset: 0x0000B0A7
			public DeleteLobbyHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001F7F RID: 8063 RVA: 0x0000CEB0 File Offset: 0x0000B0B0
			public static implicit operator LobbyManager.DeleteLobbyHandler(Action<Result> A_0)
			{
				return DelegateSupport.ConvertDelegate<LobbyManager.DeleteLobbyHandler>(A_0);
			}

			// Token: 0x06001F80 RID: 8064 RVA: 0x0000CEB8 File Offset: 0x0000B0B8
			public static LobbyManager.DeleteLobbyHandler operator +(LobbyManager.DeleteLobbyHandler A_0, LobbyManager.DeleteLobbyHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<LobbyManager.DeleteLobbyHandler>();
			}

			// Token: 0x06001F81 RID: 8065 RVA: 0x0000CEC6 File Offset: 0x0000B0C6
			public static LobbyManager.DeleteLobbyHandler operator -(LobbyManager.DeleteLobbyHandler A_0, LobbyManager.DeleteLobbyHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<LobbyManager.DeleteLobbyHandler>();
				}
				return delegate2;
			}

			// Token: 0x040018A0 RID: 6304
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040018A1 RID: 6305
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0;

			// Token: 0x040018A2 RID: 6306
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0;

			// Token: 0x040018A3 RID: 6307
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x0200021A RID: 538
		public sealed class ConnectLobbyHandler : MulticastDelegate
		{
			// Token: 0x06001F82 RID: 8066 RVA: 0x00092780 File Offset: 0x00090980
			// Note: this type is marked as 'beforefieldinit'.
			static ConnectLobbyHandler()
			{
				Il2CppClassPointerStore<LobbyManager.ConnectLobbyHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, "ConnectLobbyHandler");
				LobbyManager.ConnectLobbyHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.ConnectLobbyHandler>.NativeClassPtr, 100667945);
				LobbyManager.ConnectLobbyHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_byref_Lobby_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.ConnectLobbyHandler>.NativeClassPtr, 100667946);
				LobbyManager.ConnectLobbyHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_byref_Lobby_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.ConnectLobbyHandler>.NativeClassPtr, 100667947);
				LobbyManager.ConnectLobbyHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_Lobby_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.ConnectLobbyHandler>.NativeClassPtr, 100667948);
			}

			// Token: 0x06001F83 RID: 8067 RVA: 0x000927F4 File Offset: 0x000909F4
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 52325, RefRangeEnd = 52342, XrefRangeStart = 52325, XrefRangeEnd = 52342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ConnectLobbyHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyManager.ConnectLobbyHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.ConnectLobbyHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F84 RID: 8068 RVA: 0x00092850 File Offset: 0x00090A50
			[CallerCount(0)]
			public unsafe void Invoke(Result result, ref Lobby lobby)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				}
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(lobby);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LobbyManager.ConnectLobbyHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_byref_Lobby_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				lobby = ((intPtr4 == 0) ? null : new Lobby(intPtr4));
			}

			// Token: 0x06001F85 RID: 8069 RVA: 0x000928BC File Offset: 0x00090ABC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53584, XrefRangeEnd = 53591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Result result, ref Lobby lobby, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				}
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(lobby);
				ptr2 = &intPtr;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LobbyManager.ConnectLobbyHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_byref_Lobby_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				lobby = ((intPtr4 == 0) ? null : new Lobby(intPtr4));
				IntPtr intPtr5 = intPtr2;
				return (intPtr5 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr5) : null;
			}

			// Token: 0x06001F86 RID: 8070 RVA: 0x0009295C File Offset: 0x00090B5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(ref Lobby lobby, IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				IntPtr intPtr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					intPtr = IL2CPP.Il2CppObjectBaseToPtr(lobby);
					ptr2 = &intPtr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LobbyManager.ConnectLobbyHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_Lobby_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				lobby = ((intPtr4 == 0) ? null : new Lobby(intPtr4));
			}

			// Token: 0x06001F87 RID: 8071 RVA: 0x0000CED7 File Offset: 0x0000B0D7
			public ConnectLobbyHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040018A4 RID: 6308
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040018A5 RID: 6309
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_byref_Lobby_0;

			// Token: 0x040018A6 RID: 6310
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_byref_Lobby_AsyncCallback_Object_0;

			// Token: 0x040018A7 RID: 6311
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_Lobby_IAsyncResult_0;
		}

		// Token: 0x0200021B RID: 539
		public sealed class ConnectLobbyWithActivitySecretHandler : MulticastDelegate
		{
			// Token: 0x06001F88 RID: 8072 RVA: 0x000929C8 File Offset: 0x00090BC8
			// Note: this type is marked as 'beforefieldinit'.
			static ConnectLobbyWithActivitySecretHandler()
			{
				Il2CppClassPointerStore<LobbyManager.ConnectLobbyWithActivitySecretHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, "ConnectLobbyWithActivitySecretHandler");
				LobbyManager.ConnectLobbyWithActivitySecretHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.ConnectLobbyWithActivitySecretHandler>.NativeClassPtr, 100667949);
				LobbyManager.ConnectLobbyWithActivitySecretHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_byref_Lobby_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.ConnectLobbyWithActivitySecretHandler>.NativeClassPtr, 100667950);
				LobbyManager.ConnectLobbyWithActivitySecretHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_byref_Lobby_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.ConnectLobbyWithActivitySecretHandler>.NativeClassPtr, 100667951);
				LobbyManager.ConnectLobbyWithActivitySecretHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_Lobby_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.ConnectLobbyWithActivitySecretHandler>.NativeClassPtr, 100667952);
			}

			// Token: 0x06001F89 RID: 8073 RVA: 0x00092A3C File Offset: 0x00090C3C
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 52325, RefRangeEnd = 52342, XrefRangeStart = 52325, XrefRangeEnd = 52342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ConnectLobbyWithActivitySecretHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyManager.ConnectLobbyWithActivitySecretHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.ConnectLobbyWithActivitySecretHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F8A RID: 8074 RVA: 0x00092A98 File Offset: 0x00090C98
			[CallerCount(0)]
			public unsafe void Invoke(Result result, ref Lobby lobby)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				}
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(lobby);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LobbyManager.ConnectLobbyWithActivitySecretHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_byref_Lobby_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				lobby = ((intPtr4 == 0) ? null : new Lobby(intPtr4));
			}

			// Token: 0x06001F8B RID: 8075 RVA: 0x00092B04 File Offset: 0x00090D04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53591, XrefRangeEnd = 53598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Result result, ref Lobby lobby, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				}
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(lobby);
				ptr2 = &intPtr;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LobbyManager.ConnectLobbyWithActivitySecretHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_byref_Lobby_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				lobby = ((intPtr4 == 0) ? null : new Lobby(intPtr4));
				IntPtr intPtr5 = intPtr2;
				return (intPtr5 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr5) : null;
			}

			// Token: 0x06001F8C RID: 8076 RVA: 0x00092BA4 File Offset: 0x00090DA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(ref Lobby lobby, IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				IntPtr intPtr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					intPtr = IL2CPP.Il2CppObjectBaseToPtr(lobby);
					ptr2 = &intPtr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LobbyManager.ConnectLobbyWithActivitySecretHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_Lobby_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				lobby = ((intPtr4 == 0) ? null : new Lobby(intPtr4));
			}

			// Token: 0x06001F8D RID: 8077 RVA: 0x0000CEE0 File Offset: 0x0000B0E0
			public ConnectLobbyWithActivitySecretHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040018A8 RID: 6312
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040018A9 RID: 6313
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_byref_Lobby_0;

			// Token: 0x040018AA RID: 6314
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_byref_Lobby_AsyncCallback_Object_0;

			// Token: 0x040018AB RID: 6315
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_Lobby_IAsyncResult_0;
		}

		// Token: 0x0200021C RID: 540
		public sealed class DisconnectLobbyHandler : MulticastDelegate
		{
			// Token: 0x06001F8E RID: 8078 RVA: 0x00092C10 File Offset: 0x00090E10
			// Note: this type is marked as 'beforefieldinit'.
			static DisconnectLobbyHandler()
			{
				Il2CppClassPointerStore<LobbyManager.DisconnectLobbyHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, "DisconnectLobbyHandler");
				LobbyManager.DisconnectLobbyHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.DisconnectLobbyHandler>.NativeClassPtr, 100667953);
				LobbyManager.DisconnectLobbyHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.DisconnectLobbyHandler>.NativeClassPtr, 100667954);
				LobbyManager.DisconnectLobbyHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.DisconnectLobbyHandler>.NativeClassPtr, 100667955);
				LobbyManager.DisconnectLobbyHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.DisconnectLobbyHandler>.NativeClassPtr, 100667956);
			}

			// Token: 0x06001F8F RID: 8079 RVA: 0x00092C84 File Offset: 0x00090E84
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 51861, RefRangeEnd = 51886, XrefRangeStart = 51861, XrefRangeEnd = 51886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DisconnectLobbyHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyManager.DisconnectLobbyHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.DisconnectLobbyHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F90 RID: 8080 RVA: 0x00092CE0 File Offset: 0x00090EE0
			[CallerCount(0)]
			public unsafe void Invoke(Result result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.DisconnectLobbyHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001F91 RID: 8081 RVA: 0x00092D24 File Offset: 0x00090F24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53598, XrefRangeEnd = 53602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Result result, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.DisconnectLobbyHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001F92 RID: 8082 RVA: 0x00092D98 File Offset: 0x00090F98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.DisconnectLobbyHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001F93 RID: 8083 RVA: 0x0000CEE9 File Offset: 0x0000B0E9
			public DisconnectLobbyHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001F94 RID: 8084 RVA: 0x0000CEF2 File Offset: 0x0000B0F2
			public static implicit operator LobbyManager.DisconnectLobbyHandler(Action<Result> A_0)
			{
				return DelegateSupport.ConvertDelegate<LobbyManager.DisconnectLobbyHandler>(A_0);
			}

			// Token: 0x06001F95 RID: 8085 RVA: 0x0000CEFA File Offset: 0x0000B0FA
			public static LobbyManager.DisconnectLobbyHandler operator +(LobbyManager.DisconnectLobbyHandler A_0, LobbyManager.DisconnectLobbyHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<LobbyManager.DisconnectLobbyHandler>();
			}

			// Token: 0x06001F96 RID: 8086 RVA: 0x0000CF08 File Offset: 0x0000B108
			public static LobbyManager.DisconnectLobbyHandler operator -(LobbyManager.DisconnectLobbyHandler A_0, LobbyManager.DisconnectLobbyHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<LobbyManager.DisconnectLobbyHandler>();
				}
				return delegate2;
			}

			// Token: 0x040018AC RID: 6316
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040018AD RID: 6317
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0;

			// Token: 0x040018AE RID: 6318
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0;

			// Token: 0x040018AF RID: 6319
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x0200021D RID: 541
		public sealed class UpdateMemberHandler : MulticastDelegate
		{
			// Token: 0x06001F97 RID: 8087 RVA: 0x00092DDC File Offset: 0x00090FDC
			// Note: this type is marked as 'beforefieldinit'.
			static UpdateMemberHandler()
			{
				Il2CppClassPointerStore<LobbyManager.UpdateMemberHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, "UpdateMemberHandler");
				LobbyManager.UpdateMemberHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.UpdateMemberHandler>.NativeClassPtr, 100667957);
				LobbyManager.UpdateMemberHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.UpdateMemberHandler>.NativeClassPtr, 100667958);
				LobbyManager.UpdateMemberHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.UpdateMemberHandler>.NativeClassPtr, 100667959);
				LobbyManager.UpdateMemberHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.UpdateMemberHandler>.NativeClassPtr, 100667960);
			}

			// Token: 0x06001F98 RID: 8088 RVA: 0x00092E50 File Offset: 0x00091050
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 51861, RefRangeEnd = 51886, XrefRangeStart = 51861, XrefRangeEnd = 51886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UpdateMemberHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyManager.UpdateMemberHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.UpdateMemberHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F99 RID: 8089 RVA: 0x00092EAC File Offset: 0x000910AC
			[CallerCount(0)]
			public unsafe void Invoke(Result result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.UpdateMemberHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001F9A RID: 8090 RVA: 0x00092EF0 File Offset: 0x000910F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53602, XrefRangeEnd = 53606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Result result, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.UpdateMemberHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001F9B RID: 8091 RVA: 0x00092F64 File Offset: 0x00091164
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.UpdateMemberHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001F9C RID: 8092 RVA: 0x0000CF19 File Offset: 0x0000B119
			public UpdateMemberHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001F9D RID: 8093 RVA: 0x0000CF22 File Offset: 0x0000B122
			public static implicit operator LobbyManager.UpdateMemberHandler(Action<Result> A_0)
			{
				return DelegateSupport.ConvertDelegate<LobbyManager.UpdateMemberHandler>(A_0);
			}

			// Token: 0x06001F9E RID: 8094 RVA: 0x0000CF2A File Offset: 0x0000B12A
			public static LobbyManager.UpdateMemberHandler operator +(LobbyManager.UpdateMemberHandler A_0, LobbyManager.UpdateMemberHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<LobbyManager.UpdateMemberHandler>();
			}

			// Token: 0x06001F9F RID: 8095 RVA: 0x0000CF38 File Offset: 0x0000B138
			public static LobbyManager.UpdateMemberHandler operator -(LobbyManager.UpdateMemberHandler A_0, LobbyManager.UpdateMemberHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<LobbyManager.UpdateMemberHandler>();
				}
				return delegate2;
			}

			// Token: 0x040018B0 RID: 6320
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040018B1 RID: 6321
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0;

			// Token: 0x040018B2 RID: 6322
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0;

			// Token: 0x040018B3 RID: 6323
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x0200021E RID: 542
		public sealed class SendLobbyMessageHandler : MulticastDelegate
		{
			// Token: 0x06001FA0 RID: 8096 RVA: 0x00092FA8 File Offset: 0x000911A8
			// Note: this type is marked as 'beforefieldinit'.
			static SendLobbyMessageHandler()
			{
				Il2CppClassPointerStore<LobbyManager.SendLobbyMessageHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, "SendLobbyMessageHandler");
				LobbyManager.SendLobbyMessageHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.SendLobbyMessageHandler>.NativeClassPtr, 100667961);
				LobbyManager.SendLobbyMessageHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.SendLobbyMessageHandler>.NativeClassPtr, 100667962);
				LobbyManager.SendLobbyMessageHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.SendLobbyMessageHandler>.NativeClassPtr, 100667963);
				LobbyManager.SendLobbyMessageHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.SendLobbyMessageHandler>.NativeClassPtr, 100667964);
			}

			// Token: 0x06001FA1 RID: 8097 RVA: 0x0009301C File Offset: 0x0009121C
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 51861, RefRangeEnd = 51886, XrefRangeStart = 51861, XrefRangeEnd = 51886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SendLobbyMessageHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyManager.SendLobbyMessageHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.SendLobbyMessageHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001FA2 RID: 8098 RVA: 0x00093078 File Offset: 0x00091278
			[CallerCount(0)]
			public unsafe void Invoke(Result result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.SendLobbyMessageHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001FA3 RID: 8099 RVA: 0x000930BC File Offset: 0x000912BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53606, XrefRangeEnd = 53610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Result result, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.SendLobbyMessageHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001FA4 RID: 8100 RVA: 0x00093130 File Offset: 0x00091330
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.SendLobbyMessageHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001FA5 RID: 8101 RVA: 0x0000CF49 File Offset: 0x0000B149
			public SendLobbyMessageHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001FA6 RID: 8102 RVA: 0x0000CF52 File Offset: 0x0000B152
			public static implicit operator LobbyManager.SendLobbyMessageHandler(Action<Result> A_0)
			{
				return DelegateSupport.ConvertDelegate<LobbyManager.SendLobbyMessageHandler>(A_0);
			}

			// Token: 0x06001FA7 RID: 8103 RVA: 0x0000CF5A File Offset: 0x0000B15A
			public static LobbyManager.SendLobbyMessageHandler operator +(LobbyManager.SendLobbyMessageHandler A_0, LobbyManager.SendLobbyMessageHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<LobbyManager.SendLobbyMessageHandler>();
			}

			// Token: 0x06001FA8 RID: 8104 RVA: 0x0000CF68 File Offset: 0x0000B168
			public static LobbyManager.SendLobbyMessageHandler operator -(LobbyManager.SendLobbyMessageHandler A_0, LobbyManager.SendLobbyMessageHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<LobbyManager.SendLobbyMessageHandler>();
				}
				return delegate2;
			}

			// Token: 0x040018B4 RID: 6324
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040018B5 RID: 6325
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0;

			// Token: 0x040018B6 RID: 6326
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0;

			// Token: 0x040018B7 RID: 6327
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x0200021F RID: 543
		public sealed class SearchHandler : MulticastDelegate
		{
			// Token: 0x06001FA9 RID: 8105 RVA: 0x00093174 File Offset: 0x00091374
			// Note: this type is marked as 'beforefieldinit'.
			static SearchHandler()
			{
				Il2CppClassPointerStore<LobbyManager.SearchHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, "SearchHandler");
				LobbyManager.SearchHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.SearchHandler>.NativeClassPtr, 100667965);
				LobbyManager.SearchHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.SearchHandler>.NativeClassPtr, 100667966);
				LobbyManager.SearchHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.SearchHandler>.NativeClassPtr, 100667967);
				LobbyManager.SearchHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.SearchHandler>.NativeClassPtr, 100667968);
			}

			// Token: 0x06001FAA RID: 8106 RVA: 0x000931E8 File Offset: 0x000913E8
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 51861, RefRangeEnd = 51886, XrefRangeStart = 51861, XrefRangeEnd = 51886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SearchHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyManager.SearchHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.SearchHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001FAB RID: 8107 RVA: 0x00093244 File Offset: 0x00091444
			[CallerCount(0)]
			public unsafe void Invoke(Result result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.SearchHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001FAC RID: 8108 RVA: 0x00093288 File Offset: 0x00091488
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53610, XrefRangeEnd = 53614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Result result, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.SearchHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001FAD RID: 8109 RVA: 0x000932FC File Offset: 0x000914FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.SearchHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001FAE RID: 8110 RVA: 0x0000CF79 File Offset: 0x0000B179
			public SearchHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001FAF RID: 8111 RVA: 0x0000CF82 File Offset: 0x0000B182
			public static implicit operator LobbyManager.SearchHandler(Action<Result> A_0)
			{
				return DelegateSupport.ConvertDelegate<LobbyManager.SearchHandler>(A_0);
			}

			// Token: 0x06001FB0 RID: 8112 RVA: 0x0000CF8A File Offset: 0x0000B18A
			public static LobbyManager.SearchHandler operator +(LobbyManager.SearchHandler A_0, LobbyManager.SearchHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<LobbyManager.SearchHandler>();
			}

			// Token: 0x06001FB1 RID: 8113 RVA: 0x0000CF98 File Offset: 0x0000B198
			public static LobbyManager.SearchHandler operator -(LobbyManager.SearchHandler A_0, LobbyManager.SearchHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<LobbyManager.SearchHandler>();
				}
				return delegate2;
			}

			// Token: 0x040018B8 RID: 6328
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040018B9 RID: 6329
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0;

			// Token: 0x040018BA RID: 6330
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0;

			// Token: 0x040018BB RID: 6331
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000220 RID: 544
		public sealed class ConnectVoiceHandler : MulticastDelegate
		{
			// Token: 0x06001FB2 RID: 8114 RVA: 0x00093340 File Offset: 0x00091540
			// Note: this type is marked as 'beforefieldinit'.
			static ConnectVoiceHandler()
			{
				Il2CppClassPointerStore<LobbyManager.ConnectVoiceHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, "ConnectVoiceHandler");
				LobbyManager.ConnectVoiceHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.ConnectVoiceHandler>.NativeClassPtr, 100667969);
				LobbyManager.ConnectVoiceHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.ConnectVoiceHandler>.NativeClassPtr, 100667970);
				LobbyManager.ConnectVoiceHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.ConnectVoiceHandler>.NativeClassPtr, 100667971);
				LobbyManager.ConnectVoiceHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.ConnectVoiceHandler>.NativeClassPtr, 100667972);
			}

			// Token: 0x06001FB3 RID: 8115 RVA: 0x000933B4 File Offset: 0x000915B4
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 51861, RefRangeEnd = 51886, XrefRangeStart = 51861, XrefRangeEnd = 51886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ConnectVoiceHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyManager.ConnectVoiceHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.ConnectVoiceHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001FB4 RID: 8116 RVA: 0x00093410 File Offset: 0x00091610
			[CallerCount(0)]
			public unsafe void Invoke(Result result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.ConnectVoiceHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001FB5 RID: 8117 RVA: 0x00093454 File Offset: 0x00091654
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53614, XrefRangeEnd = 53618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Result result, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.ConnectVoiceHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001FB6 RID: 8118 RVA: 0x000934C8 File Offset: 0x000916C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.ConnectVoiceHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001FB7 RID: 8119 RVA: 0x0000CFA9 File Offset: 0x0000B1A9
			public ConnectVoiceHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001FB8 RID: 8120 RVA: 0x0000CFB2 File Offset: 0x0000B1B2
			public static implicit operator LobbyManager.ConnectVoiceHandler(Action<Result> A_0)
			{
				return DelegateSupport.ConvertDelegate<LobbyManager.ConnectVoiceHandler>(A_0);
			}

			// Token: 0x06001FB9 RID: 8121 RVA: 0x0000CFBA File Offset: 0x0000B1BA
			public static LobbyManager.ConnectVoiceHandler operator +(LobbyManager.ConnectVoiceHandler A_0, LobbyManager.ConnectVoiceHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<LobbyManager.ConnectVoiceHandler>();
			}

			// Token: 0x06001FBA RID: 8122 RVA: 0x0000CFC8 File Offset: 0x0000B1C8
			public static LobbyManager.ConnectVoiceHandler operator -(LobbyManager.ConnectVoiceHandler A_0, LobbyManager.ConnectVoiceHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<LobbyManager.ConnectVoiceHandler>();
				}
				return delegate2;
			}

			// Token: 0x040018BC RID: 6332
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040018BD RID: 6333
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0;

			// Token: 0x040018BE RID: 6334
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0;

			// Token: 0x040018BF RID: 6335
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000221 RID: 545
		public sealed class DisconnectVoiceHandler : MulticastDelegate
		{
			// Token: 0x06001FBB RID: 8123 RVA: 0x0009350C File Offset: 0x0009170C
			// Note: this type is marked as 'beforefieldinit'.
			static DisconnectVoiceHandler()
			{
				Il2CppClassPointerStore<LobbyManager.DisconnectVoiceHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, "DisconnectVoiceHandler");
				LobbyManager.DisconnectVoiceHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.DisconnectVoiceHandler>.NativeClassPtr, 100667973);
				LobbyManager.DisconnectVoiceHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.DisconnectVoiceHandler>.NativeClassPtr, 100667974);
				LobbyManager.DisconnectVoiceHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.DisconnectVoiceHandler>.NativeClassPtr, 100667975);
				LobbyManager.DisconnectVoiceHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.DisconnectVoiceHandler>.NativeClassPtr, 100667976);
			}

			// Token: 0x06001FBC RID: 8124 RVA: 0x00093580 File Offset: 0x00091780
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 51861, RefRangeEnd = 51886, XrefRangeStart = 51861, XrefRangeEnd = 51886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DisconnectVoiceHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyManager.DisconnectVoiceHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.DisconnectVoiceHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001FBD RID: 8125 RVA: 0x000935DC File Offset: 0x000917DC
			[CallerCount(0)]
			public unsafe void Invoke(Result result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.DisconnectVoiceHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001FBE RID: 8126 RVA: 0x00093620 File Offset: 0x00091820
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53618, XrefRangeEnd = 53622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Result result, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.DisconnectVoiceHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001FBF RID: 8127 RVA: 0x00093694 File Offset: 0x00091894
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.DisconnectVoiceHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001FC0 RID: 8128 RVA: 0x0000CFD9 File Offset: 0x0000B1D9
			public DisconnectVoiceHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001FC1 RID: 8129 RVA: 0x0000CFE2 File Offset: 0x0000B1E2
			public static implicit operator LobbyManager.DisconnectVoiceHandler(Action<Result> A_0)
			{
				return DelegateSupport.ConvertDelegate<LobbyManager.DisconnectVoiceHandler>(A_0);
			}

			// Token: 0x06001FC2 RID: 8130 RVA: 0x0000CFEA File Offset: 0x0000B1EA
			public static LobbyManager.DisconnectVoiceHandler operator +(LobbyManager.DisconnectVoiceHandler A_0, LobbyManager.DisconnectVoiceHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<LobbyManager.DisconnectVoiceHandler>();
			}

			// Token: 0x06001FC3 RID: 8131 RVA: 0x0000CFF8 File Offset: 0x0000B1F8
			public static LobbyManager.DisconnectVoiceHandler operator -(LobbyManager.DisconnectVoiceHandler A_0, LobbyManager.DisconnectVoiceHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<LobbyManager.DisconnectVoiceHandler>();
				}
				return delegate2;
			}

			// Token: 0x040018C0 RID: 6336
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040018C1 RID: 6337
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Result_0;

			// Token: 0x040018C2 RID: 6338
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Result_AsyncCallback_Object_0;

			// Token: 0x040018C3 RID: 6339
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000222 RID: 546
		public sealed class LobbyUpdateHandler : MulticastDelegate
		{
			// Token: 0x06001FC4 RID: 8132 RVA: 0x000936D8 File Offset: 0x000918D8
			// Note: this type is marked as 'beforefieldinit'.
			static LobbyUpdateHandler()
			{
				Il2CppClassPointerStore<LobbyManager.LobbyUpdateHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, "LobbyUpdateHandler");
				LobbyManager.LobbyUpdateHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.LobbyUpdateHandler>.NativeClassPtr, 100667977);
				LobbyManager.LobbyUpdateHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.LobbyUpdateHandler>.NativeClassPtr, 100667978);
				LobbyManager.LobbyUpdateHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int64_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.LobbyUpdateHandler>.NativeClassPtr, 100667979);
				LobbyManager.LobbyUpdateHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.LobbyUpdateHandler>.NativeClassPtr, 100667980);
			}

			// Token: 0x06001FC5 RID: 8133 RVA: 0x0009374C File Offset: 0x0009194C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LobbyUpdateHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyManager.LobbyUpdateHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.LobbyUpdateHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001FC6 RID: 8134 RVA: 0x000937A8 File Offset: 0x000919A8
			[CallerCount(0)]
			public unsafe void Invoke(long lobbyId)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref lobbyId;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.LobbyUpdateHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001FC7 RID: 8135 RVA: 0x000937E8 File Offset: 0x000919E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53622, XrefRangeEnd = 53625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(long lobbyId, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref lobbyId;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.LobbyUpdateHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int64_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001FC8 RID: 8136 RVA: 0x00093858 File Offset: 0x00091A58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.LobbyUpdateHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001FC9 RID: 8137 RVA: 0x0000D009 File Offset: 0x0000B209
			public LobbyUpdateHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001FCA RID: 8138 RVA: 0x0000D012 File Offset: 0x0000B212
			public static implicit operator LobbyManager.LobbyUpdateHandler(Action<long> A_0)
			{
				return DelegateSupport.ConvertDelegate<LobbyManager.LobbyUpdateHandler>(A_0);
			}

			// Token: 0x06001FCB RID: 8139 RVA: 0x0000D01A File Offset: 0x0000B21A
			public static LobbyManager.LobbyUpdateHandler operator +(LobbyManager.LobbyUpdateHandler A_0, LobbyManager.LobbyUpdateHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<LobbyManager.LobbyUpdateHandler>();
			}

			// Token: 0x06001FCC RID: 8140 RVA: 0x0000D028 File Offset: 0x0000B228
			public static LobbyManager.LobbyUpdateHandler operator -(LobbyManager.LobbyUpdateHandler A_0, LobbyManager.LobbyUpdateHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<LobbyManager.LobbyUpdateHandler>();
				}
				return delegate2;
			}

			// Token: 0x040018C4 RID: 6340
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040018C5 RID: 6341
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int64_0;

			// Token: 0x040018C6 RID: 6342
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int64_AsyncCallback_Object_0;

			// Token: 0x040018C7 RID: 6343
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000223 RID: 547
		public sealed class LobbyDeleteHandler : MulticastDelegate
		{
			// Token: 0x06001FCD RID: 8141 RVA: 0x0009389C File Offset: 0x00091A9C
			// Note: this type is marked as 'beforefieldinit'.
			static LobbyDeleteHandler()
			{
				Il2CppClassPointerStore<LobbyManager.LobbyDeleteHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, "LobbyDeleteHandler");
				LobbyManager.LobbyDeleteHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.LobbyDeleteHandler>.NativeClassPtr, 100667981);
				LobbyManager.LobbyDeleteHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int64_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.LobbyDeleteHandler>.NativeClassPtr, 100667982);
				LobbyManager.LobbyDeleteHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int64_UInt32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.LobbyDeleteHandler>.NativeClassPtr, 100667983);
				LobbyManager.LobbyDeleteHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.LobbyDeleteHandler>.NativeClassPtr, 100667984);
			}

			// Token: 0x06001FCE RID: 8142 RVA: 0x00093910 File Offset: 0x00091B10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LobbyDeleteHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyManager.LobbyDeleteHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.LobbyDeleteHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001FCF RID: 8143 RVA: 0x0009396C File Offset: 0x00091B6C
			[CallerCount(0)]
			public unsafe void Invoke(long lobbyId, uint reason)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref lobbyId;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reason;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.LobbyDeleteHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int64_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001FD0 RID: 8144 RVA: 0x000939B8 File Offset: 0x00091BB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53625, XrefRangeEnd = 53630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(long lobbyId, uint reason, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref lobbyId;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref reason;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.LobbyDeleteHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int64_UInt32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001FD1 RID: 8145 RVA: 0x00093A38 File Offset: 0x00091C38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.LobbyDeleteHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001FD2 RID: 8146 RVA: 0x0000D039 File Offset: 0x0000B239
			public LobbyDeleteHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001FD3 RID: 8147 RVA: 0x0000D042 File Offset: 0x0000B242
			public static implicit operator LobbyManager.LobbyDeleteHandler(Action<long, uint> A_0)
			{
				return DelegateSupport.ConvertDelegate<LobbyManager.LobbyDeleteHandler>(A_0);
			}

			// Token: 0x06001FD4 RID: 8148 RVA: 0x0000D04A File Offset: 0x0000B24A
			public static LobbyManager.LobbyDeleteHandler operator +(LobbyManager.LobbyDeleteHandler A_0, LobbyManager.LobbyDeleteHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<LobbyManager.LobbyDeleteHandler>();
			}

			// Token: 0x06001FD5 RID: 8149 RVA: 0x0000D058 File Offset: 0x0000B258
			public static LobbyManager.LobbyDeleteHandler operator -(LobbyManager.LobbyDeleteHandler A_0, LobbyManager.LobbyDeleteHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<LobbyManager.LobbyDeleteHandler>();
				}
				return delegate2;
			}

			// Token: 0x040018C8 RID: 6344
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040018C9 RID: 6345
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int64_UInt32_0;

			// Token: 0x040018CA RID: 6346
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int64_UInt32_AsyncCallback_Object_0;

			// Token: 0x040018CB RID: 6347
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000224 RID: 548
		public sealed class MemberConnectHandler : MulticastDelegate
		{
			// Token: 0x06001FD6 RID: 8150 RVA: 0x00093A7C File Offset: 0x00091C7C
			// Note: this type is marked as 'beforefieldinit'.
			static MemberConnectHandler()
			{
				Il2CppClassPointerStore<LobbyManager.MemberConnectHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, "MemberConnectHandler");
				LobbyManager.MemberConnectHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.MemberConnectHandler>.NativeClassPtr, 100667985);
				LobbyManager.MemberConnectHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.MemberConnectHandler>.NativeClassPtr, 100667986);
				LobbyManager.MemberConnectHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int64_Int64_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.MemberConnectHandler>.NativeClassPtr, 100667987);
				LobbyManager.MemberConnectHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.MemberConnectHandler>.NativeClassPtr, 100667988);
			}

			// Token: 0x06001FD7 RID: 8151 RVA: 0x00093AF0 File Offset: 0x00091CF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MemberConnectHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyManager.MemberConnectHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.MemberConnectHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001FD8 RID: 8152 RVA: 0x00093B4C File Offset: 0x00091D4C
			[CallerCount(0)]
			public unsafe void Invoke(long lobbyId, long userId)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref lobbyId;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.MemberConnectHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int64_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001FD9 RID: 8153 RVA: 0x00093B98 File Offset: 0x00091D98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53630, XrefRangeEnd = 53635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(long lobbyId, long userId, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref lobbyId;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userId;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.MemberConnectHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int64_Int64_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001FDA RID: 8154 RVA: 0x00093C18 File Offset: 0x00091E18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.MemberConnectHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001FDB RID: 8155 RVA: 0x0000D069 File Offset: 0x0000B269
			public MemberConnectHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001FDC RID: 8156 RVA: 0x0000D072 File Offset: 0x0000B272
			public static implicit operator LobbyManager.MemberConnectHandler(Action<long, long> A_0)
			{
				return DelegateSupport.ConvertDelegate<LobbyManager.MemberConnectHandler>(A_0);
			}

			// Token: 0x06001FDD RID: 8157 RVA: 0x0000D07A File Offset: 0x0000B27A
			public static LobbyManager.MemberConnectHandler operator +(LobbyManager.MemberConnectHandler A_0, LobbyManager.MemberConnectHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<LobbyManager.MemberConnectHandler>();
			}

			// Token: 0x06001FDE RID: 8158 RVA: 0x0000D088 File Offset: 0x0000B288
			public static LobbyManager.MemberConnectHandler operator -(LobbyManager.MemberConnectHandler A_0, LobbyManager.MemberConnectHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<LobbyManager.MemberConnectHandler>();
				}
				return delegate2;
			}

			// Token: 0x040018CC RID: 6348
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040018CD RID: 6349
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int64_Int64_0;

			// Token: 0x040018CE RID: 6350
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int64_Int64_AsyncCallback_Object_0;

			// Token: 0x040018CF RID: 6351
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000225 RID: 549
		public sealed class MemberUpdateHandler : MulticastDelegate
		{
			// Token: 0x06001FDF RID: 8159 RVA: 0x00093C5C File Offset: 0x00091E5C
			// Note: this type is marked as 'beforefieldinit'.
			static MemberUpdateHandler()
			{
				Il2CppClassPointerStore<LobbyManager.MemberUpdateHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, "MemberUpdateHandler");
				LobbyManager.MemberUpdateHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.MemberUpdateHandler>.NativeClassPtr, 100667989);
				LobbyManager.MemberUpdateHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.MemberUpdateHandler>.NativeClassPtr, 100667990);
				LobbyManager.MemberUpdateHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int64_Int64_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.MemberUpdateHandler>.NativeClassPtr, 100667991);
				LobbyManager.MemberUpdateHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.MemberUpdateHandler>.NativeClassPtr, 100667992);
			}

			// Token: 0x06001FE0 RID: 8160 RVA: 0x00093CD0 File Offset: 0x00091ED0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MemberUpdateHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyManager.MemberUpdateHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.MemberUpdateHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001FE1 RID: 8161 RVA: 0x00093D2C File Offset: 0x00091F2C
			[CallerCount(0)]
			public unsafe void Invoke(long lobbyId, long userId)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref lobbyId;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.MemberUpdateHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int64_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001FE2 RID: 8162 RVA: 0x00093D78 File Offset: 0x00091F78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(long lobbyId, long userId, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref lobbyId;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userId;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.MemberUpdateHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int64_Int64_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001FE3 RID: 8163 RVA: 0x00093DF8 File Offset: 0x00091FF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.MemberUpdateHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001FE4 RID: 8164 RVA: 0x0000D099 File Offset: 0x0000B299
			public MemberUpdateHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001FE5 RID: 8165 RVA: 0x0000D0A2 File Offset: 0x0000B2A2
			public static implicit operator LobbyManager.MemberUpdateHandler(Action<long, long> A_0)
			{
				return DelegateSupport.ConvertDelegate<LobbyManager.MemberUpdateHandler>(A_0);
			}

			// Token: 0x06001FE6 RID: 8166 RVA: 0x0000D0AA File Offset: 0x0000B2AA
			public static LobbyManager.MemberUpdateHandler operator +(LobbyManager.MemberUpdateHandler A_0, LobbyManager.MemberUpdateHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<LobbyManager.MemberUpdateHandler>();
			}

			// Token: 0x06001FE7 RID: 8167 RVA: 0x0000D0B8 File Offset: 0x0000B2B8
			public static LobbyManager.MemberUpdateHandler operator -(LobbyManager.MemberUpdateHandler A_0, LobbyManager.MemberUpdateHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<LobbyManager.MemberUpdateHandler>();
				}
				return delegate2;
			}

			// Token: 0x040018D0 RID: 6352
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040018D1 RID: 6353
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int64_Int64_0;

			// Token: 0x040018D2 RID: 6354
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int64_Int64_AsyncCallback_Object_0;

			// Token: 0x040018D3 RID: 6355
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000226 RID: 550
		public sealed class MemberDisconnectHandler : MulticastDelegate
		{
			// Token: 0x06001FE8 RID: 8168 RVA: 0x00093E3C File Offset: 0x0009203C
			// Note: this type is marked as 'beforefieldinit'.
			static MemberDisconnectHandler()
			{
				Il2CppClassPointerStore<LobbyManager.MemberDisconnectHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, "MemberDisconnectHandler");
				LobbyManager.MemberDisconnectHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.MemberDisconnectHandler>.NativeClassPtr, 100667993);
				LobbyManager.MemberDisconnectHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.MemberDisconnectHandler>.NativeClassPtr, 100667994);
				LobbyManager.MemberDisconnectHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int64_Int64_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.MemberDisconnectHandler>.NativeClassPtr, 100667995);
				LobbyManager.MemberDisconnectHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.MemberDisconnectHandler>.NativeClassPtr, 100667996);
			}

			// Token: 0x06001FE9 RID: 8169 RVA: 0x00093EB0 File Offset: 0x000920B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MemberDisconnectHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyManager.MemberDisconnectHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.MemberDisconnectHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001FEA RID: 8170 RVA: 0x00093F0C File Offset: 0x0009210C
			[CallerCount(0)]
			public unsafe void Invoke(long lobbyId, long userId)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref lobbyId;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.MemberDisconnectHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int64_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001FEB RID: 8171 RVA: 0x00093F58 File Offset: 0x00092158
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(long lobbyId, long userId, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref lobbyId;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userId;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.MemberDisconnectHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int64_Int64_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001FEC RID: 8172 RVA: 0x00093FD8 File Offset: 0x000921D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.MemberDisconnectHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001FED RID: 8173 RVA: 0x0000D0C9 File Offset: 0x0000B2C9
			public MemberDisconnectHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001FEE RID: 8174 RVA: 0x0000D0D2 File Offset: 0x0000B2D2
			public static implicit operator LobbyManager.MemberDisconnectHandler(Action<long, long> A_0)
			{
				return DelegateSupport.ConvertDelegate<LobbyManager.MemberDisconnectHandler>(A_0);
			}

			// Token: 0x06001FEF RID: 8175 RVA: 0x0000D0DA File Offset: 0x0000B2DA
			public static LobbyManager.MemberDisconnectHandler operator +(LobbyManager.MemberDisconnectHandler A_0, LobbyManager.MemberDisconnectHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<LobbyManager.MemberDisconnectHandler>();
			}

			// Token: 0x06001FF0 RID: 8176 RVA: 0x0000D0E8 File Offset: 0x0000B2E8
			public static LobbyManager.MemberDisconnectHandler operator -(LobbyManager.MemberDisconnectHandler A_0, LobbyManager.MemberDisconnectHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<LobbyManager.MemberDisconnectHandler>();
				}
				return delegate2;
			}

			// Token: 0x040018D4 RID: 6356
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040018D5 RID: 6357
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int64_Int64_0;

			// Token: 0x040018D6 RID: 6358
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int64_Int64_AsyncCallback_Object_0;

			// Token: 0x040018D7 RID: 6359
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000227 RID: 551
		public sealed class LobbyMessageHandler : MulticastDelegate
		{
			// Token: 0x06001FF1 RID: 8177 RVA: 0x0009401C File Offset: 0x0009221C
			// Note: this type is marked as 'beforefieldinit'.
			static LobbyMessageHandler()
			{
				Il2CppClassPointerStore<LobbyManager.LobbyMessageHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, "LobbyMessageHandler");
				LobbyManager.LobbyMessageHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.LobbyMessageHandler>.NativeClassPtr, 100667997);
				LobbyManager.LobbyMessageHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int64_Int64_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.LobbyMessageHandler>.NativeClassPtr, 100667998);
				LobbyManager.LobbyMessageHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int64_Int64_Il2CppStructArray_1_Byte_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.LobbyMessageHandler>.NativeClassPtr, 100667999);
				LobbyManager.LobbyMessageHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.LobbyMessageHandler>.NativeClassPtr, 100668000);
			}

			// Token: 0x06001FF2 RID: 8178 RVA: 0x00094090 File Offset: 0x00092290
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LobbyMessageHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyManager.LobbyMessageHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.LobbyMessageHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001FF3 RID: 8179 RVA: 0x000940EC File Offset: 0x000922EC
			[CallerCount(0)]
			public unsafe void Invoke(long lobbyId, long userId, Il2CppStructArray<byte> data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref lobbyId;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userId;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.LobbyMessageHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int64_Int64_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001FF4 RID: 8180 RVA: 0x0009414C File Offset: 0x0009234C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53635, XrefRangeEnd = 53640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(long lobbyId, long userId, Il2CppStructArray<byte> data, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref lobbyId;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userId;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.LobbyMessageHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int64_Int64_Il2CppStructArray_1_Byte_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001FF5 RID: 8181 RVA: 0x000941E0 File Offset: 0x000923E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.LobbyMessageHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001FF6 RID: 8182 RVA: 0x0000D0F9 File Offset: 0x0000B2F9
			public LobbyMessageHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001FF7 RID: 8183 RVA: 0x0000D102 File Offset: 0x0000B302
			public static implicit operator LobbyManager.LobbyMessageHandler(Action<long, long, Il2CppStructArray<byte>> A_0)
			{
				return DelegateSupport.ConvertDelegate<LobbyManager.LobbyMessageHandler>(A_0);
			}

			// Token: 0x06001FF8 RID: 8184 RVA: 0x0000D10A File Offset: 0x0000B30A
			public static LobbyManager.LobbyMessageHandler operator +(LobbyManager.LobbyMessageHandler A_0, LobbyManager.LobbyMessageHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<LobbyManager.LobbyMessageHandler>();
			}

			// Token: 0x06001FF9 RID: 8185 RVA: 0x0000D118 File Offset: 0x0000B318
			public static LobbyManager.LobbyMessageHandler operator -(LobbyManager.LobbyMessageHandler A_0, LobbyManager.LobbyMessageHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<LobbyManager.LobbyMessageHandler>();
				}
				return delegate2;
			}

			// Token: 0x040018D8 RID: 6360
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040018D9 RID: 6361
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int64_Int64_Il2CppStructArray_1_Byte_0;

			// Token: 0x040018DA RID: 6362
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int64_Int64_Il2CppStructArray_1_Byte_AsyncCallback_Object_0;

			// Token: 0x040018DB RID: 6363
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000228 RID: 552
		public sealed class SpeakingHandler : MulticastDelegate
		{
			// Token: 0x06001FFA RID: 8186 RVA: 0x00094224 File Offset: 0x00092424
			// Note: this type is marked as 'beforefieldinit'.
			static SpeakingHandler()
			{
				Il2CppClassPointerStore<LobbyManager.SpeakingHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, "SpeakingHandler");
				LobbyManager.SpeakingHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.SpeakingHandler>.NativeClassPtr, 100668001);
				LobbyManager.SpeakingHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int64_Int64_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.SpeakingHandler>.NativeClassPtr, 100668002);
				LobbyManager.SpeakingHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int64_Int64_Boolean_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.SpeakingHandler>.NativeClassPtr, 100668003);
				LobbyManager.SpeakingHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.SpeakingHandler>.NativeClassPtr, 100668004);
			}

			// Token: 0x06001FFB RID: 8187 RVA: 0x00094298 File Offset: 0x00092498
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53640, XrefRangeEnd = 53643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SpeakingHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyManager.SpeakingHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.SpeakingHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001FFC RID: 8188 RVA: 0x000942F4 File Offset: 0x000924F4
			[CallerCount(0)]
			public unsafe void Invoke(long lobbyId, long userId, bool speaking)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref lobbyId;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userId;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref speaking;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.SpeakingHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int64_Int64_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001FFD RID: 8189 RVA: 0x00094350 File Offset: 0x00092550
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53643, XrefRangeEnd = 53650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(long lobbyId, long userId, bool speaking, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref lobbyId;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userId;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref speaking;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.SpeakingHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int64_Int64_Boolean_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001FFE RID: 8190 RVA: 0x000943E0 File Offset: 0x000925E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.SpeakingHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001FFF RID: 8191 RVA: 0x0000D129 File Offset: 0x0000B329
			public SpeakingHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002000 RID: 8192 RVA: 0x0000D132 File Offset: 0x0000B332
			public static implicit operator LobbyManager.SpeakingHandler(Action<long, long, bool> A_0)
			{
				return DelegateSupport.ConvertDelegate<LobbyManager.SpeakingHandler>(A_0);
			}

			// Token: 0x06002001 RID: 8193 RVA: 0x0000D13A File Offset: 0x0000B33A
			public static LobbyManager.SpeakingHandler operator +(LobbyManager.SpeakingHandler A_0, LobbyManager.SpeakingHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<LobbyManager.SpeakingHandler>();
			}

			// Token: 0x06002002 RID: 8194 RVA: 0x0000D148 File Offset: 0x0000B348
			public static LobbyManager.SpeakingHandler operator -(LobbyManager.SpeakingHandler A_0, LobbyManager.SpeakingHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<LobbyManager.SpeakingHandler>();
				}
				return delegate2;
			}

			// Token: 0x040018DC RID: 6364
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040018DD RID: 6365
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int64_Int64_Boolean_0;

			// Token: 0x040018DE RID: 6366
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int64_Int64_Boolean_AsyncCallback_Object_0;

			// Token: 0x040018DF RID: 6367
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000229 RID: 553
		public sealed class NetworkMessageHandler : MulticastDelegate
		{
			// Token: 0x06002003 RID: 8195 RVA: 0x00094424 File Offset: 0x00092624
			// Note: this type is marked as 'beforefieldinit'.
			static NetworkMessageHandler()
			{
				Il2CppClassPointerStore<LobbyManager.NetworkMessageHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LobbyManager>.NativeClassPtr, "NetworkMessageHandler");
				LobbyManager.NetworkMessageHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.NetworkMessageHandler>.NativeClassPtr, 100668005);
				LobbyManager.NetworkMessageHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int64_Int64_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.NetworkMessageHandler>.NativeClassPtr, 100668006);
				LobbyManager.NetworkMessageHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int64_Int64_Byte_Il2CppStructArray_1_Byte_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.NetworkMessageHandler>.NativeClassPtr, 100668007);
				LobbyManager.NetworkMessageHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyManager.NetworkMessageHandler>.NativeClassPtr, 100668008);
			}

			// Token: 0x06002004 RID: 8196 RVA: 0x00094498 File Offset: 0x00092698
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53650, XrefRangeEnd = 53653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NetworkMessageHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyManager.NetworkMessageHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NetworkMessageHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002005 RID: 8197 RVA: 0x000944F4 File Offset: 0x000926F4
			[CallerCount(0)]
			public unsafe void Invoke(long lobbyId, long userId, byte channelId, Il2CppStructArray<byte> data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref lobbyId;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userId;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channelId;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NetworkMessageHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int64_Int64_Byte_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002006 RID: 8198 RVA: 0x00094564 File Offset: 0x00092764
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53653, XrefRangeEnd = 53660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(long lobbyId, long userId, byte channelId, Il2CppStructArray<byte> data, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref lobbyId;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userId;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channelId;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NetworkMessageHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int64_Int64_Byte_Il2CppStructArray_1_Byte_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06002007 RID: 8199 RVA: 0x00094608 File Offset: 0x00092808
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyManager.NetworkMessageHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002008 RID: 8200 RVA: 0x0000D159 File Offset: 0x0000B359
			public NetworkMessageHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002009 RID: 8201 RVA: 0x0000D162 File Offset: 0x0000B362
			public static implicit operator LobbyManager.NetworkMessageHandler(Action<long, long, byte, Il2CppStructArray<byte>> A_0)
			{
				return DelegateSupport.ConvertDelegate<LobbyManager.NetworkMessageHandler>(A_0);
			}

			// Token: 0x0600200A RID: 8202 RVA: 0x0000D16A File Offset: 0x0000B36A
			public static LobbyManager.NetworkMessageHandler operator +(LobbyManager.NetworkMessageHandler A_0, LobbyManager.NetworkMessageHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<LobbyManager.NetworkMessageHandler>();
			}

			// Token: 0x0600200B RID: 8203 RVA: 0x0000D178 File Offset: 0x0000B378
			public static LobbyManager.NetworkMessageHandler operator -(LobbyManager.NetworkMessageHandler A_0, LobbyManager.NetworkMessageHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<LobbyManager.NetworkMessageHandler>();
				}
				return delegate2;
			}

			// Token: 0x040018E0 RID: 6368
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040018E1 RID: 6369
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int64_Int64_Byte_Il2CppStructArray_1_Byte_0;

			// Token: 0x040018E2 RID: 6370
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int64_Int64_Byte_Il2CppStructArray_1_Byte_AsyncCallback_Object_0;

			// Token: 0x040018E3 RID: 6371
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
