using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Polytoria.Lua;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002E6 RID: 742
	public class NetworkEventProxy : InstanceProxy
	{
		// Token: 0x060040D5 RID: 16597 RVA: 0x00122FF8 File Offset: 0x001211F8
		// Note: this type is marked as 'beforefieldinit'.
		static NetworkEventProxy()
		{
			Il2CppClassPointerStore<NetworkEventProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Proxies", "NetworkEventProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkEventProxy>.NativeClassPtr);
			NetworkEventProxy.NativeFieldInfoPtr_networkEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkEventProxy>.NativeClassPtr, "networkEvent");
			NetworkEventProxy.NativeMethodInfoPtr_get_InvokedServer_Public_get_LuaEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkEventProxy>.NativeClassPtr, 100673458);
			NetworkEventProxy.NativeMethodInfoPtr_get_InvokedClient_Public_get_LuaEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkEventProxy>.NativeClassPtr, 100673459);
			NetworkEventProxy.NativeMethodInfoPtr__ctor_Public_Void_NetworkEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkEventProxy>.NativeClassPtr, 100673457);
			NetworkEventProxy.NativeMethodInfoPtr_InvokeServer_Public_Void_NetMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkEventProxy>.NativeClassPtr, 100673460);
			NetworkEventProxy.NativeMethodInfoPtr_InvokeClient_Public_Void_NetMessage_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkEventProxy>.NativeClassPtr, 100673461);
			NetworkEventProxy.NativeMethodInfoPtr_InvokeClients_Public_Void_NetMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkEventProxy>.NativeClassPtr, 100673462);
		}

		// Token: 0x17001649 RID: 5705
		// (get) Token: 0x060040D6 RID: 16598 RVA: 0x001230B4 File Offset: 0x001212B4
		public unsafe LuaEvent InvokedServer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkEventProxy.NativeMethodInfoPtr_get_InvokedServer_Public_get_LuaEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LuaEvent>(intPtr3) : null;
			}
		}

		// Token: 0x1700164A RID: 5706
		// (get) Token: 0x060040D7 RID: 16599 RVA: 0x001230F4 File Offset: 0x001212F4
		public unsafe LuaEvent InvokedClient
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkEventProxy.NativeMethodInfoPtr_get_InvokedClient_Public_get_LuaEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LuaEvent>(intPtr3) : null;
			}
		}

		// Token: 0x060040D8 RID: 16600 RVA: 0x00123134 File Offset: 0x00121334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NetworkEventProxy(NetworkEvent target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetworkEventProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkEventProxy.NativeMethodInfoPtr__ctor_Public_Void_NetworkEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060040D9 RID: 16601 RVA: 0x00123180 File Offset: 0x00121380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128666, XrefRangeEnd = 128668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeServer(NetMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkEventProxy.NativeMethodInfoPtr_InvokeServer_Public_Void_NetMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060040DA RID: 16602 RVA: 0x001231C4 File Offset: 0x001213C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128668, XrefRangeEnd = 128670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkEventProxy.NativeMethodInfoPtr_InvokeClient_Public_Void_NetMessage_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040DB RID: 16603 RVA: 0x00123218 File Offset: 0x00121418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128670, XrefRangeEnd = 128672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeClients(NetMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkEventProxy.NativeMethodInfoPtr_InvokeClients_Public_Void_NetMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060040DC RID: 16604 RVA: 0x00018831 File Offset: 0x00016A31
		public NetworkEventProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001648 RID: 5704
		// (get) Token: 0x060040DD RID: 16605 RVA: 0x0012325C File Offset: 0x0012145C
		// (set) Token: 0x060040DE RID: 16606 RVA: 0x0001883A File Offset: 0x00016A3A
		public unsafe NetworkEvent networkEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkEventProxy.NativeFieldInfoPtr_networkEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkEventProxy.NativeFieldInfoPtr_networkEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003262 RID: 12898
		private static readonly IntPtr NativeFieldInfoPtr_networkEvent;

		// Token: 0x04003263 RID: 12899
		private static readonly IntPtr NativeMethodInfoPtr_get_InvokedServer_Public_get_LuaEvent_0;

		// Token: 0x04003264 RID: 12900
		private static readonly IntPtr NativeMethodInfoPtr_get_InvokedClient_Public_get_LuaEvent_0;

		// Token: 0x04003265 RID: 12901
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_NetworkEvent_0;

		// Token: 0x04003266 RID: 12902
		private static readonly IntPtr NativeMethodInfoPtr_InvokeServer_Public_Void_NetMessage_0;

		// Token: 0x04003267 RID: 12903
		private static readonly IntPtr NativeMethodInfoPtr_InvokeClient_Public_Void_NetMessage_Player_0;

		// Token: 0x04003268 RID: 12904
		private static readonly IntPtr NativeMethodInfoPtr_InvokeClients_Public_Void_NetMessage_0;
	}
}
