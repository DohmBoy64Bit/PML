using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Mirror;
using UnityEngine;
using UnityEngine.Networking;

namespace Polytoria.Datamodel.Services
{
	// Token: 0x020002C2 RID: 706
	public class ChatService : NetworkBehaviour
	{
		// Token: 0x06003E51 RID: 15953 RVA: 0x00118428 File Offset: 0x00116628
		// Note: this type is marked as 'beforefieldinit'.
		static ChatService()
		{
			Il2CppClassPointerStore<ChatService>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Services", "ChatService");
			ChatService.NativeFieldInfoPtr_MaxMessageLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatService>.NativeClassPtr, "MaxMessageLength");
			ChatService.NativeFieldInfoPtr_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatService>.NativeClassPtr, "Instance");
			ChatService.NativeFieldInfoPtr__players = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatService>.NativeClassPtr, "_players");
			ChatService.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatService>.NativeClassPtr, 100672901);
			ChatService.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatService>.NativeClassPtr, 100672889);
			ChatService.NativeMethodInfoPtr_BroadcastMessage_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatService>.NativeClassPtr, 100672890);
			ChatService.NativeMethodInfoPtr_UnicastMessage_Public_Void_String_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatService>.NativeClassPtr, 100672891);
			ChatService.NativeMethodInfoPtr_SendChat_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatService>.NativeClassPtr, 100672892);
			ChatService.NativeMethodInfoPtr_FilterChatExploits_Private_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatService>.NativeClassPtr, 100672893);
			ChatService.NativeMethodInfoPtr_DoSendChat_Private_Void_String_Color_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatService>.NativeClassPtr, 100672894);
			ChatService.NativeMethodInfoPtr_LogChatMessage_Private_IEnumerator_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatService>.NativeClassPtr, 100672895);
			ChatService.NativeMethodInfoPtr_CmdSendChat_Private_Void_String_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatService>.NativeClassPtr, 100672896);
			ChatService.NativeMethodInfoPtr_SendChatClientRpc_Private_Void_String_String_Color_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatService>.NativeClassPtr, 100672897);
			ChatService.NativeMethodInfoPtr_SendChatTargetRpc_Private_Void_NetworkConnection_String_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatService>.NativeClassPtr, 100672898);
			ChatService.NativeMethodInfoPtr_Invoke_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatService>.NativeClassPtr, 100672899);
			ChatService.NativeMethodInfoPtr_InvokeRepeating_Public_Void_String_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatService>.NativeClassPtr, 100672900);
			ChatService.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatService>.NativeClassPtr, 100672902);
			ChatService.NativeMethodInfoPtr_UserCode_CmdSendChat__String__NetworkConnectionToClient_Protected_Void_String_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatService>.NativeClassPtr, 100672903);
			ChatService.NativeMethodInfoPtr_InvokeUserCode_CmdSendChat__String__NetworkConnectionToClient_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatService>.NativeClassPtr, 100672904);
			ChatService.NativeMethodInfoPtr_UserCode_SendChatClientRpc__String__String__Color__Player_Protected_Void_String_String_Color_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatService>.NativeClassPtr, 100672905);
			ChatService.NativeMethodInfoPtr_InvokeUserCode_SendChatClientRpc__String__String__Color__Player_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatService>.NativeClassPtr, 100672906);
			ChatService.NativeMethodInfoPtr_UserCode_SendChatTargetRpc__NetworkConnection__String__String__Color_Protected_Void_NetworkConnection_String_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatService>.NativeClassPtr, 100672907);
			ChatService.NativeMethodInfoPtr_InvokeUserCode_SendChatTargetRpc__NetworkConnection__String__String__Color_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatService>.NativeClassPtr, 100672908);
		}

		// Token: 0x06003E52 RID: 15954 RVA: 0x0011861C File Offset: 0x0011681C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123746, XrefRangeEnd = 123747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChatService()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChatService>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatService.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E53 RID: 15955 RVA: 0x00118658 File Offset: 0x00116858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123747, XrefRangeEnd = 123753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatService.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E54 RID: 15956 RVA: 0x0011868C File Offset: 0x0011688C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 123761, RefRangeEnd = 123762, XrefRangeStart = 123753, XrefRangeEnd = 123761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BroadcastMessage(string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatService.NativeMethodInfoPtr_BroadcastMessage_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003E55 RID: 15957 RVA: 0x001186D0 File Offset: 0x001168D0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 123782, RefRangeEnd = 123785, XrefRangeStart = 123762, XrefRangeEnd = 123782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnicastMessage(string message, Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatService.NativeMethodInfoPtr_UnicastMessage_Public_Void_String_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E56 RID: 15958 RVA: 0x00118724 File Offset: 0x00116924
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 123813, RefRangeEnd = 123814, XrefRangeStart = 123785, XrefRangeEnd = 123813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendChat(string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatService.NativeMethodInfoPtr_SendChat_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003E57 RID: 15959 RVA: 0x00118768 File Offset: 0x00116968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123814, XrefRangeEnd = 123829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string FilterChatExploits(string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatService.NativeMethodInfoPtr_FilterChatExploits_Private_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003E58 RID: 15960 RVA: 0x001187B0 File Offset: 0x001169B0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 123909, RefRangeEnd = 123912, XrefRangeStart = 123829, XrefRangeEnd = 123909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoSendChat(string message, Color color, Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(color);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatService.NativeMethodInfoPtr_DoSendChat_Private_Void_String_Color_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E59 RID: 15961 RVA: 0x00118818 File Offset: 0x00116A18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123912, XrefRangeEnd = 123918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator LogChatMessage(int userId, string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref userId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatService.NativeMethodInfoPtr_LogChatMessage_Private_IEnumerator_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06003E5A RID: 15962 RVA: 0x00118878 File Offset: 0x00116A78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123918, XrefRangeEnd = 123939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CmdSendChat(string message, NetworkConnectionToClient sender = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sender);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatService.NativeMethodInfoPtr_CmdSendChat_Private_Void_String_NetworkConnectionToClient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E5B RID: 15963 RVA: 0x001188CC File Offset: 0x00116ACC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 123963, RefRangeEnd = 123964, XrefRangeStart = 123939, XrefRangeEnd = 123963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendChatClientRpc(string message, string username, Color color, Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(username);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(color);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatService.NativeMethodInfoPtr_SendChatClientRpc_Private_Void_String_String_Color_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E5C RID: 15964 RVA: 0x00118948 File Offset: 0x00116B48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123964, XrefRangeEnd = 123987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendChatTargetRpc(NetworkConnection target, string message, string username, Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(username);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(color);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatService.NativeMethodInfoPtr_SendChatTargetRpc_Private_Void_NetworkConnection_String_String_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E5D RID: 15965 RVA: 0x001189C4 File Offset: 0x00116BC4
		[CallerCount(7535)]
		[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Invoke(string methodName, float time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatService.NativeMethodInfoPtr_Invoke_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E5E RID: 15966 RVA: 0x00118A14 File Offset: 0x00116C14
		[CallerCount(7535)]
		[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void InvokeRepeating(string methodName, float time, float repeatRate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref repeatRate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatService.NativeMethodInfoPtr_InvokeRepeating_Public_Void_String_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E5F RID: 15967 RVA: 0x00118A74 File Offset: 0x00116C74
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 20124, RefRangeEnd = 20136, XrefRangeStart = 20124, XrefRangeEnd = 20136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Weaved()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChatService.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003E60 RID: 15968 RVA: 0x00118ABC File Offset: 0x00116CBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123987, XrefRangeEnd = 123991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_CmdSendChat__String__NetworkConnectionToClient(string message, NetworkConnectionToClient sender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sender);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatService.NativeMethodInfoPtr_UserCode_CmdSendChat__String__NetworkConnectionToClient_Protected_Void_String_NetworkConnectionToClient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E61 RID: 15969 RVA: 0x00118B10 File Offset: 0x00116D10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123991, XrefRangeEnd = 124007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_CmdSendChat__String__NetworkConnectionToClient(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatService.NativeMethodInfoPtr_InvokeUserCode_CmdSendChat__String__NetworkConnectionToClient_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E62 RID: 15970 RVA: 0x00118B6C File Offset: 0x00116D6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 124038, RefRangeEnd = 124039, XrefRangeStart = 124007, XrefRangeEnd = 124038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_SendChatClientRpc__String__String__Color__Player(string message, string username, Color color, Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(username);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(color);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatService.NativeMethodInfoPtr_UserCode_SendChatClientRpc__String__String__Color__Player_Protected_Void_String_String_Color_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E63 RID: 15971 RVA: 0x00118BE8 File Offset: 0x00116DE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124039, XrefRangeEnd = 124054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_SendChatClientRpc__String__String__Color__Player(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatService.NativeMethodInfoPtr_InvokeUserCode_SendChatClientRpc__String__String__Color__Player_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E64 RID: 15972 RVA: 0x00118C44 File Offset: 0x00116E44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124054, XrefRangeEnd = 124059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_SendChatTargetRpc__NetworkConnection__String__String__Color(NetworkConnection target, string message, string username, Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(username);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(color);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatService.NativeMethodInfoPtr_UserCode_SendChatTargetRpc__NetworkConnection__String__String__Color_Protected_Void_NetworkConnection_String_String_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E65 RID: 15973 RVA: 0x00118CC0 File Offset: 0x00116EC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124059, XrefRangeEnd = 124075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_SendChatTargetRpc__NetworkConnection__String__String__Color(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatService.NativeMethodInfoPtr_InvokeUserCode_SendChatTargetRpc__NetworkConnection__String__String__Color_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E66 RID: 15974 RVA: 0x00017E3F File Offset: 0x0001603F
		public ChatService(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700157B RID: 5499
		// (get) Token: 0x06003E67 RID: 15975 RVA: 0x00118D1C File Offset: 0x00116F1C
		// (set) Token: 0x06003E68 RID: 15976 RVA: 0x00017E48 File Offset: 0x00016048
		public unsafe static int MaxMessageLength
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ChatService.NativeFieldInfoPtr_MaxMessageLength, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ChatService.NativeFieldInfoPtr_MaxMessageLength, (void*)(&value));
			}
		}

		// Token: 0x1700157C RID: 5500
		// (get) Token: 0x06003E69 RID: 15977 RVA: 0x00118D38 File Offset: 0x00116F38
		// (set) Token: 0x06003E6A RID: 15978 RVA: 0x00017E56 File Offset: 0x00016056
		public unsafe static ChatService Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ChatService.NativeFieldInfoPtr_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChatService>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ChatService.NativeFieldInfoPtr_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700157D RID: 5501
		// (get) Token: 0x06003E6B RID: 15979 RVA: 0x00118D60 File Offset: 0x00116F60
		// (set) Token: 0x06003E6C RID: 15980 RVA: 0x00017E68 File Offset: 0x00016068
		public unsafe Players _players
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatService.NativeFieldInfoPtr__players);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Players>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatService.NativeFieldInfoPtr__players), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400307A RID: 12410
		private static readonly IntPtr NativeFieldInfoPtr_MaxMessageLength;

		// Token: 0x0400307B RID: 12411
		private static readonly IntPtr NativeFieldInfoPtr_Instance;

		// Token: 0x0400307C RID: 12412
		private static readonly IntPtr NativeFieldInfoPtr__players;

		// Token: 0x0400307D RID: 12413
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400307E RID: 12414
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400307F RID: 12415
		private static readonly IntPtr NativeMethodInfoPtr_BroadcastMessage_Public_Void_String_0;

		// Token: 0x04003080 RID: 12416
		private static readonly IntPtr NativeMethodInfoPtr_UnicastMessage_Public_Void_String_Player_0;

		// Token: 0x04003081 RID: 12417
		private static readonly IntPtr NativeMethodInfoPtr_SendChat_Public_Void_String_0;

		// Token: 0x04003082 RID: 12418
		private static readonly IntPtr NativeMethodInfoPtr_FilterChatExploits_Private_String_String_0;

		// Token: 0x04003083 RID: 12419
		private static readonly IntPtr NativeMethodInfoPtr_DoSendChat_Private_Void_String_Color_Player_0;

		// Token: 0x04003084 RID: 12420
		private static readonly IntPtr NativeMethodInfoPtr_LogChatMessage_Private_IEnumerator_Int32_String_0;

		// Token: 0x04003085 RID: 12421
		private static readonly IntPtr NativeMethodInfoPtr_CmdSendChat_Private_Void_String_NetworkConnectionToClient_0;

		// Token: 0x04003086 RID: 12422
		private static readonly IntPtr NativeMethodInfoPtr_SendChatClientRpc_Private_Void_String_String_Color_Player_0;

		// Token: 0x04003087 RID: 12423
		private static readonly IntPtr NativeMethodInfoPtr_SendChatTargetRpc_Private_Void_NetworkConnection_String_String_Color_0;

		// Token: 0x04003088 RID: 12424
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Void_String_Single_0;

		// Token: 0x04003089 RID: 12425
		private static readonly IntPtr NativeMethodInfoPtr_InvokeRepeating_Public_Void_String_Single_Single_0;

		// Token: 0x0400308A RID: 12426
		private static readonly IntPtr NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0;

		// Token: 0x0400308B RID: 12427
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_CmdSendChat__String__NetworkConnectionToClient_Protected_Void_String_NetworkConnectionToClient_0;

		// Token: 0x0400308C RID: 12428
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_CmdSendChat__String__NetworkConnectionToClient_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x0400308D RID: 12429
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_SendChatClientRpc__String__String__Color__Player_Protected_Void_String_String_Color_Player_0;

		// Token: 0x0400308E RID: 12430
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_SendChatClientRpc__String__String__Color__Player_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x0400308F RID: 12431
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_SendChatTargetRpc__NetworkConnection__String__String__Color_Protected_Void_NetworkConnection_String_String_Color_0;

		// Token: 0x04003090 RID: 12432
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_SendChatTargetRpc__NetworkConnection__String__String__Color_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x02000408 RID: 1032
		[ObfuscatedName("Polytoria.Datamodel.Services.ChatService+<LogChatMessage>d__9")]
		public sealed class _LogChatMessage_d__9 : global::Il2CppSystem.Object
		{
			// Token: 0x06004F0C RID: 20236 RVA: 0x00155134 File Offset: 0x00153334
			// Note: this type is marked as 'beforefieldinit'.
			static _LogChatMessage_d__9()
			{
				Il2CppClassPointerStore<ChatService._LogChatMessage_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChatService>.NativeClassPtr, "<LogChatMessage>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChatService._LogChatMessage_d__9>.NativeClassPtr);
				ChatService._LogChatMessage_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatService._LogChatMessage_d__9>.NativeClassPtr, "<>1__state");
				ChatService._LogChatMessage_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatService._LogChatMessage_d__9>.NativeClassPtr, "<>2__current");
				ChatService._LogChatMessage_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatService._LogChatMessage_d__9>.NativeClassPtr, "<>4__this");
				ChatService._LogChatMessage_d__9.NativeFieldInfoPtr_userId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatService._LogChatMessage_d__9>.NativeClassPtr, "userId");
				ChatService._LogChatMessage_d__9.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatService._LogChatMessage_d__9>.NativeClassPtr, "message");
				ChatService._LogChatMessage_d__9.NativeFieldInfoPtr__uwr_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatService._LogChatMessage_d__9>.NativeClassPtr, "<uwr>5__2");
				ChatService._LogChatMessage_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatService._LogChatMessage_d__9>.NativeClassPtr, 100672914);
				ChatService._LogChatMessage_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatService._LogChatMessage_d__9>.NativeClassPtr, 100672916);
				ChatService._LogChatMessage_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatService._LogChatMessage_d__9>.NativeClassPtr, 100672910);
				ChatService._LogChatMessage_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatService._LogChatMessage_d__9>.NativeClassPtr, 100672911);
				ChatService._LogChatMessage_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatService._LogChatMessage_d__9>.NativeClassPtr, 100672912);
				ChatService._LogChatMessage_d__9.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatService._LogChatMessage_d__9>.NativeClassPtr, 100672913);
				ChatService._LogChatMessage_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatService._LogChatMessage_d__9>.NativeClassPtr, 100672915);
			}

			// Token: 0x17001AAD RID: 6829
			// (get) Token: 0x06004F0D RID: 20237 RVA: 0x00155264 File Offset: 0x00153464
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatService._LogChatMessage_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001AAE RID: 6830
			// (get) Token: 0x06004F0E RID: 20238 RVA: 0x001552A4 File Offset: 0x001534A4
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatService._LogChatMessage_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004F0F RID: 20239 RVA: 0x001552E4 File Offset: 0x001534E4
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 10168, RefRangeEnd = 10216, XrefRangeStart = 10168, XrefRangeEnd = 10216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _LogChatMessage_d__9(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChatService._LogChatMessage_d__9>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatService._LogChatMessage_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004F10 RID: 20240 RVA: 0x0015532C File Offset: 0x0015352C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123686, XrefRangeEnd = 123691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatService._LogChatMessage_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F11 RID: 20241 RVA: 0x00155360 File Offset: 0x00153560
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123691, XrefRangeEnd = 123738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatService._LogChatMessage_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004F12 RID: 20242 RVA: 0x0015539C File Offset: 0x0015359C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123738, XrefRangeEnd = 123741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatService._LogChatMessage_d__9.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F13 RID: 20243 RVA: 0x001553D0 File Offset: 0x001535D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123741, XrefRangeEnd = 123746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatService._LogChatMessage_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004F14 RID: 20244 RVA: 0x0001E137 File Offset: 0x0001C337
			public _LogChatMessage_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001AA7 RID: 6823
			// (get) Token: 0x06004F15 RID: 20245 RVA: 0x00155404 File Offset: 0x00153604
			// (set) Token: 0x06004F16 RID: 20246 RVA: 0x0001E140 File Offset: 0x0001C340
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatService._LogChatMessage_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatService._LogChatMessage_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001AA8 RID: 6824
			// (get) Token: 0x06004F17 RID: 20247 RVA: 0x0015542C File Offset: 0x0015362C
			// (set) Token: 0x06004F18 RID: 20248 RVA: 0x0001E15B File Offset: 0x0001C35B
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatService._LogChatMessage_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatService._LogChatMessage_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AA9 RID: 6825
			// (get) Token: 0x06004F19 RID: 20249 RVA: 0x0015545C File Offset: 0x0015365C
			// (set) Token: 0x06004F1A RID: 20250 RVA: 0x0001E17A File Offset: 0x0001C37A
			public unsafe ChatService __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatService._LogChatMessage_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChatService>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatService._LogChatMessage_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AAA RID: 6826
			// (get) Token: 0x06004F1B RID: 20251 RVA: 0x0015548C File Offset: 0x0015368C
			// (set) Token: 0x06004F1C RID: 20252 RVA: 0x0001E199 File Offset: 0x0001C399
			public unsafe int userId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatService._LogChatMessage_d__9.NativeFieldInfoPtr_userId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatService._LogChatMessage_d__9.NativeFieldInfoPtr_userId)) = value;
				}
			}

			// Token: 0x17001AAB RID: 6827
			// (get) Token: 0x06004F1D RID: 20253 RVA: 0x001554B4 File Offset: 0x001536B4
			// (set) Token: 0x06004F1E RID: 20254 RVA: 0x0001E1B4 File Offset: 0x0001C3B4
			public unsafe string message
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatService._LogChatMessage_d__9.NativeFieldInfoPtr_message);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatService._LogChatMessage_d__9.NativeFieldInfoPtr_message), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001AAC RID: 6828
			// (get) Token: 0x06004F1F RID: 20255 RVA: 0x001554DC File Offset: 0x001536DC
			// (set) Token: 0x06004F20 RID: 20256 RVA: 0x0001E1D3 File Offset: 0x0001C3D3
			public unsafe UnityWebRequest _uwr_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatService._LogChatMessage_d__9.NativeFieldInfoPtr__uwr_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatService._LogChatMessage_d__9.NativeFieldInfoPtr__uwr_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003D1D RID: 15645
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003D1E RID: 15646
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003D1F RID: 15647
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003D20 RID: 15648
			private static readonly IntPtr NativeFieldInfoPtr_userId;

			// Token: 0x04003D21 RID: 15649
			private static readonly IntPtr NativeFieldInfoPtr_message;

			// Token: 0x04003D22 RID: 15650
			private static readonly IntPtr NativeFieldInfoPtr__uwr_5__2;

			// Token: 0x04003D23 RID: 15651
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003D24 RID: 15652
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003D25 RID: 15653
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003D26 RID: 15654
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003D27 RID: 15655
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003D28 RID: 15656
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04003D29 RID: 15657
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}
	}
}
