using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Mirror;
using Polytoria.Lua;

namespace Polytoria.Datamodel
{
	// Token: 0x02000292 RID: 658
	public class NetworkEvent : Instance
	{
		// Token: 0x0600345D RID: 13405 RVA: 0x000EEC9C File Offset: 0x000ECE9C
		// Note: this type is marked as 'beforefieldinit'.
		static NetworkEvent()
		{
			Il2CppClassPointerStore<NetworkEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel", "NetworkEvent");
			NetworkEvent.NativeFieldInfoPtr_InvokedServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvent>.NativeClassPtr, "InvokedServer");
			NetworkEvent.NativeFieldInfoPtr_InvokedClient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEvent>.NativeClassPtr, "InvokedClient");
			NetworkEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkEvent>.NativeClassPtr, 100671220);
			NetworkEvent.NativeMethodInfoPtr_InvokeServer_Public_Void_NetMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkEvent>.NativeClassPtr, 100671214);
			NetworkEvent.NativeMethodInfoPtr_InvokeClient_Public_Void_NetMessage_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkEvent>.NativeClassPtr, 100671215);
			NetworkEvent.NativeMethodInfoPtr_InvokeClients_Public_Void_NetMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkEvent>.NativeClassPtr, 100671216);
			NetworkEvent.NativeMethodInfoPtr_InvokeCmd_Private_Void_NetMessage_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkEvent>.NativeClassPtr, 100671217);
			NetworkEvent.NativeMethodInfoPtr_InvokeTargetRpc_Private_Void_NetworkConnection_NetMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkEvent>.NativeClassPtr, 100671218);
			NetworkEvent.NativeMethodInfoPtr_InvokeClientRpc_Private_Void_NetMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkEvent>.NativeClassPtr, 100671219);
			NetworkEvent.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkEvent>.NativeClassPtr, 100671221);
			NetworkEvent.NativeMethodInfoPtr_UserCode_InvokeCmd__NetMessage__NetworkConnectionToClient_Protected_Void_NetMessage_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkEvent>.NativeClassPtr, 100671222);
			NetworkEvent.NativeMethodInfoPtr_InvokeUserCode_InvokeCmd__NetMessage__NetworkConnectionToClient_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkEvent>.NativeClassPtr, 100671223);
			NetworkEvent.NativeMethodInfoPtr_UserCode_InvokeTargetRpc__NetworkConnection__NetMessage_Protected_Void_NetworkConnection_NetMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkEvent>.NativeClassPtr, 100671224);
			NetworkEvent.NativeMethodInfoPtr_InvokeUserCode_InvokeTargetRpc__NetworkConnection__NetMessage_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkEvent>.NativeClassPtr, 100671225);
			NetworkEvent.NativeMethodInfoPtr_UserCode_InvokeClientRpc__NetMessage_Protected_Void_NetMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkEvent>.NativeClassPtr, 100671226);
			NetworkEvent.NativeMethodInfoPtr_InvokeUserCode_InvokeClientRpc__NetMessage_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkEvent>.NativeClassPtr, 100671227);
		}

		// Token: 0x0600345E RID: 13406 RVA: 0x000EEE04 File Offset: 0x000ED004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106919, XrefRangeEnd = 106932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NetworkEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetworkEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600345F RID: 13407 RVA: 0x000EEE40 File Offset: 0x000ED040
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 106953, RefRangeEnd = 106954, XrefRangeStart = 106932, XrefRangeEnd = 106953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeServer(NetMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkEvent.NativeMethodInfoPtr_InvokeServer_Public_Void_NetMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003460 RID: 13408 RVA: 0x000EEE84 File Offset: 0x000ED084
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 106971, RefRangeEnd = 106972, XrefRangeStart = 106954, XrefRangeEnd = 106971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeClient(NetMessage msg, Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkEvent.NativeMethodInfoPtr_InvokeClient_Public_Void_NetMessage_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003461 RID: 13409 RVA: 0x000EEED8 File Offset: 0x000ED0D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 106988, RefRangeEnd = 106989, XrefRangeStart = 106972, XrefRangeEnd = 106988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeClients(NetMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkEvent.NativeMethodInfoPtr_InvokeClients_Public_Void_NetMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003462 RID: 13410 RVA: 0x000EEF1C File Offset: 0x000ED11C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 106953, RefRangeEnd = 106954, XrefRangeStart = 106953, XrefRangeEnd = 106954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeCmd(NetMessage msg, NetworkConnectionToClient sender = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sender);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkEvent.NativeMethodInfoPtr_InvokeCmd_Private_Void_NetMessage_NetworkConnectionToClient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003463 RID: 13411 RVA: 0x000EEF70 File Offset: 0x000ED170
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106989, XrefRangeEnd = 107010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeTargetRpc(NetworkConnection target, NetMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(msg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkEvent.NativeMethodInfoPtr_InvokeTargetRpc_Private_Void_NetworkConnection_NetMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003464 RID: 13412 RVA: 0x000EEFC4 File Offset: 0x000ED1C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107010, XrefRangeEnd = 107031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeClientRpc(NetMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkEvent.NativeMethodInfoPtr_InvokeClientRpc_Private_Void_NetMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003465 RID: 13413 RVA: 0x000EF008 File Offset: 0x000ED208
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 20124, RefRangeEnd = 20136, XrefRangeStart = 20124, XrefRangeEnd = 20136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Weaved()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NetworkEvent.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003466 RID: 13414 RVA: 0x000EF050 File Offset: 0x000ED250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107031, XrefRangeEnd = 107042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_InvokeCmd__NetMessage__NetworkConnectionToClient(NetMessage msg, NetworkConnectionToClient sender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sender);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkEvent.NativeMethodInfoPtr_UserCode_InvokeCmd__NetMessage__NetworkConnectionToClient_Protected_Void_NetMessage_NetworkConnectionToClient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003467 RID: 13415 RVA: 0x000EF0A4 File Offset: 0x000ED2A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107042, XrefRangeEnd = 107065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_InvokeCmd__NetMessage__NetworkConnectionToClient(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkEvent.NativeMethodInfoPtr_InvokeUserCode_InvokeCmd__NetMessage__NetworkConnectionToClient_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003468 RID: 13416 RVA: 0x000EF100 File Offset: 0x000ED300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107065, XrefRangeEnd = 107071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_InvokeTargetRpc__NetworkConnection__NetMessage(NetworkConnection target, NetMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(msg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkEvent.NativeMethodInfoPtr_UserCode_InvokeTargetRpc__NetworkConnection__NetMessage_Protected_Void_NetworkConnection_NetMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003469 RID: 13417 RVA: 0x000EF154 File Offset: 0x000ED354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107071, XrefRangeEnd = 107086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_InvokeTargetRpc__NetworkConnection__NetMessage(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkEvent.NativeMethodInfoPtr_InvokeUserCode_InvokeTargetRpc__NetworkConnection__NetMessage_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600346A RID: 13418 RVA: 0x000EF1B0 File Offset: 0x000ED3B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107086, XrefRangeEnd = 107092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_InvokeClientRpc__NetMessage(NetMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkEvent.NativeMethodInfoPtr_UserCode_InvokeClientRpc__NetMessage_Protected_Void_NetMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600346B RID: 13419 RVA: 0x000EF1F4 File Offset: 0x000ED3F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107092, XrefRangeEnd = 107107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_InvokeClientRpc__NetMessage(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkEvent.NativeMethodInfoPtr_InvokeUserCode_InvokeClientRpc__NetMessage_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600346C RID: 13420 RVA: 0x000149F6 File Offset: 0x00012BF6
		public NetworkEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001238 RID: 4664
		// (get) Token: 0x0600346D RID: 13421 RVA: 0x000EF250 File Offset: 0x000ED450
		// (set) Token: 0x0600346E RID: 13422 RVA: 0x000149FF File Offset: 0x00012BFF
		public unsafe LuaEvent InvokedServer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkEvent.NativeFieldInfoPtr_InvokedServer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LuaEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkEvent.NativeFieldInfoPtr_InvokedServer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001239 RID: 4665
		// (get) Token: 0x0600346F RID: 13423 RVA: 0x000EF280 File Offset: 0x000ED480
		// (set) Token: 0x06003470 RID: 13424 RVA: 0x00014A1E File Offset: 0x00012C1E
		public unsafe LuaEvent InvokedClient
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkEvent.NativeFieldInfoPtr_InvokedClient);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LuaEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkEvent.NativeFieldInfoPtr_InvokedClient), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002842 RID: 10306
		private static readonly IntPtr NativeFieldInfoPtr_InvokedServer;

		// Token: 0x04002843 RID: 10307
		private static readonly IntPtr NativeFieldInfoPtr_InvokedClient;

		// Token: 0x04002844 RID: 10308
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002845 RID: 10309
		private static readonly IntPtr NativeMethodInfoPtr_InvokeServer_Public_Void_NetMessage_0;

		// Token: 0x04002846 RID: 10310
		private static readonly IntPtr NativeMethodInfoPtr_InvokeClient_Public_Void_NetMessage_Player_0;

		// Token: 0x04002847 RID: 10311
		private static readonly IntPtr NativeMethodInfoPtr_InvokeClients_Public_Void_NetMessage_0;

		// Token: 0x04002848 RID: 10312
		private static readonly IntPtr NativeMethodInfoPtr_InvokeCmd_Private_Void_NetMessage_NetworkConnectionToClient_0;

		// Token: 0x04002849 RID: 10313
		private static readonly IntPtr NativeMethodInfoPtr_InvokeTargetRpc_Private_Void_NetworkConnection_NetMessage_0;

		// Token: 0x0400284A RID: 10314
		private static readonly IntPtr NativeMethodInfoPtr_InvokeClientRpc_Private_Void_NetMessage_0;

		// Token: 0x0400284B RID: 10315
		private static readonly IntPtr NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0;

		// Token: 0x0400284C RID: 10316
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_InvokeCmd__NetMessage__NetworkConnectionToClient_Protected_Void_NetMessage_NetworkConnectionToClient_0;

		// Token: 0x0400284D RID: 10317
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_InvokeCmd__NetMessage__NetworkConnectionToClient_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x0400284E RID: 10318
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_InvokeTargetRpc__NetworkConnection__NetMessage_Protected_Void_NetworkConnection_NetMessage_0;

		// Token: 0x0400284F RID: 10319
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_InvokeTargetRpc__NetworkConnection__NetMessage_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002850 RID: 10320
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_InvokeClientRpc__NetMessage_Protected_Void_NetMessage_0;

		// Token: 0x04002851 RID: 10321
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_InvokeClientRpc__NetMessage_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;
	}
}
