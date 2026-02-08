using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Mirror;
using Polytoria.Lua;

namespace Polytoria.Datamodel
{
	// Token: 0x020002A3 RID: 675
	public class Players : Instance
	{
		// Token: 0x0600393D RID: 14653 RVA: 0x00103120 File Offset: 0x00101320
		// Note: this type is marked as 'beforefieldinit'.
		static Players()
		{
			Il2CppClassPointerStore<Players>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel", "Players");
			Players.NativeFieldInfoPtr_PlayerAdded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Players>.NativeClassPtr, "PlayerAdded");
			Players.NativeFieldInfoPtr_PlayerRemoved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Players>.NativeClassPtr, "PlayerRemoved");
			Players.NativeFieldInfoPtr__localPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Players>.NativeClassPtr, "_localPlayer");
			Players.NativeFieldInfoPtr_playerCollisions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Players>.NativeClassPtr, "playerCollisions");
			Players.NativeMethodInfoPtr_get_LocalPlayer_Public_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Players>.NativeClassPtr, 100672038);
			Players.NativeMethodInfoPtr_get_PlayerCollisionEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Players>.NativeClassPtr, 100672039);
			Players.NativeMethodInfoPtr_set_PlayerCollisionEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Players>.NativeClassPtr, 100672040);
			Players.NativeMethodInfoPtr_get_NetworkplayerCollisions_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Players>.NativeClassPtr, 100672055);
			Players.NativeMethodInfoPtr_set_NetworkplayerCollisions_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Players>.NativeClassPtr, 100672056);
			Players.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Players>.NativeClassPtr, 100672053);
			Players.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Players>.NativeClassPtr, 100672041);
			Players.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Players>.NativeClassPtr, 100672042);
			Players.NativeMethodInfoPtr_GetPlayers_Public_Il2CppReferenceArray_1_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Players>.NativeClassPtr, 100672043);
			Players.NativeMethodInfoPtr_GetPlayer_Public_Player_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Players>.NativeClassPtr, 100672044);
			Players.NativeMethodInfoPtr_GetPlayerByID_Public_Player_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Players>.NativeClassPtr, 100672045);
			Players.NativeMethodInfoPtr_AddPlayer_Public_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Players>.NativeClassPtr, 100672046);
			Players.NativeMethodInfoPtr_DelayedPlayerAddEvent_Private_IEnumerator_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Players>.NativeClassPtr, 100672047);
			Players.NativeMethodInfoPtr_NotifyPlayerDestroyed_Public_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Players>.NativeClassPtr, 100672048);
			Players.NativeMethodInfoPtr_PlayerAddedClientRpc_Private_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Players>.NativeClassPtr, 100672049);
			Players.NativeMethodInfoPtr_PlayerRemovedClientRpc_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Players>.NativeClassPtr, 100672050);
			Players.NativeMethodInfoPtr_RpcSetPlayerCollisions_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Players>.NativeClassPtr, 100672051);
			Players.NativeMethodInfoPtr_SetLocalPlayer_Public_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Players>.NativeClassPtr, 100672052);
			Players.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Players>.NativeClassPtr, 100672054);
			Players.NativeMethodInfoPtr_UserCode_PlayerAddedClientRpc__Player_Protected_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Players>.NativeClassPtr, 100672057);
			Players.NativeMethodInfoPtr_InvokeUserCode_PlayerAddedClientRpc__Player_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Players>.NativeClassPtr, 100672058);
			Players.NativeMethodInfoPtr_UserCode_PlayerRemovedClientRpc__String_Protected_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Players>.NativeClassPtr, 100672059);
			Players.NativeMethodInfoPtr_InvokeUserCode_PlayerRemovedClientRpc__String_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Players>.NativeClassPtr, 100672060);
			Players.NativeMethodInfoPtr_UserCode_RpcSetPlayerCollisions__Boolean_Protected_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Players>.NativeClassPtr, 100672061);
			Players.NativeMethodInfoPtr_InvokeUserCode_RpcSetPlayerCollisions__Boolean_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Players>.NativeClassPtr, 100672062);
			Players.NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Players>.NativeClassPtr, 100672064);
			Players.NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Players>.NativeClassPtr, 100672065);
		}

		// Token: 0x170013E5 RID: 5093
		// (get) Token: 0x0600393E RID: 14654 RVA: 0x001033B4 File Offset: 0x001015B4
		public unsafe Player LocalPlayer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Players.NativeMethodInfoPtr_get_LocalPlayer_Public_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
			}
		}

		// Token: 0x170013E6 RID: 5094
		// (get) Token: 0x0600393F RID: 14655 RVA: 0x001033F4 File Offset: 0x001015F4
		// (set) Token: 0x06003940 RID: 14656 RVA: 0x00103430 File Offset: 0x00101630
		public unsafe bool PlayerCollisionEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Players.NativeMethodInfoPtr_get_PlayerCollisionEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 116379, RefRangeEnd = 116383, XrefRangeStart = 116342, XrefRangeEnd = 116379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Players.NativeMethodInfoPtr_set_PlayerCollisionEnabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170013E7 RID: 5095
		// (get) Token: 0x06003941 RID: 14657 RVA: 0x00103470 File Offset: 0x00101670
		// (set) Token: 0x06003942 RID: 14658 RVA: 0x001034AC File Offset: 0x001016AC
		public unsafe bool NetworkplayerCollisions
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Players.NativeMethodInfoPtr_get_NetworkplayerCollisions_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116383, XrefRangeEnd = 116389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Players.NativeMethodInfoPtr_set_NetworkplayerCollisions_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003943 RID: 14659 RVA: 0x001034EC File Offset: 0x001016EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116389, XrefRangeEnd = 116402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Players()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Players>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Players.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003944 RID: 14660 RVA: 0x00103528 File Offset: 0x00101728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Players.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003945 RID: 14661 RVA: 0x00103564 File Offset: 0x00101764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116402, XrefRangeEnd = 116405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Players.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003946 RID: 14662 RVA: 0x001035A0 File Offset: 0x001017A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 116408, RefRangeEnd = 116409, XrefRangeStart = 116405, XrefRangeEnd = 116408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Player> GetPlayers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Players.NativeMethodInfoPtr_GetPlayers_Public_Il2CppReferenceArray_1_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Player>>(intPtr3) : null;
		}

		// Token: 0x06003947 RID: 14663 RVA: 0x001035E0 File Offset: 0x001017E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 116414, RefRangeEnd = 116415, XrefRangeStart = 116409, XrefRangeEnd = 116414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Player GetPlayer(string username)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(username);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Players.NativeMethodInfoPtr_GetPlayer_Public_Player_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
			}
		}

		// Token: 0x06003948 RID: 14664 RVA: 0x00103630 File Offset: 0x00101830
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 116419, RefRangeEnd = 116421, XrefRangeStart = 116415, XrefRangeEnd = 116419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Player GetPlayerByID(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Players.NativeMethodInfoPtr_GetPlayerByID_Public_Player_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
			}
		}

		// Token: 0x06003949 RID: 14665 RVA: 0x0010367C File Offset: 0x0010187C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 116453, RefRangeEnd = 116454, XrefRangeStart = 116421, XrefRangeEnd = 116453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Players.NativeMethodInfoPtr_AddPlayer_Public_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600394A RID: 14666 RVA: 0x001036C0 File Offset: 0x001018C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116454, XrefRangeEnd = 116460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DelayedPlayerAddEvent(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Players.NativeMethodInfoPtr_DelayedPlayerAddEvent_Private_IEnumerator_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x0600394B RID: 14667 RVA: 0x00103710 File Offset: 0x00101910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116460, XrefRangeEnd = 116482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifyPlayerDestroyed(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Players.NativeMethodInfoPtr_NotifyPlayerDestroyed_Public_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600394C RID: 14668 RVA: 0x00103754 File Offset: 0x00101954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116482, XrefRangeEnd = 116503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayerAddedClientRpc(Player p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Players.NativeMethodInfoPtr_PlayerAddedClientRpc_Private_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600394D RID: 14669 RVA: 0x00103798 File Offset: 0x00101998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116503, XrefRangeEnd = 116524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayerRemovedClientRpc(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Players.NativeMethodInfoPtr_PlayerRemovedClientRpc_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600394E RID: 14670 RVA: 0x001037DC File Offset: 0x001019DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116524, XrefRangeEnd = 116545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcSetPlayerCollisions(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref enabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Players.NativeMethodInfoPtr_RpcSetPlayerCollisions_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600394F RID: 14671 RVA: 0x0010381C File Offset: 0x00101A1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLocalPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Players.NativeMethodInfoPtr_SetLocalPlayer_Public_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003950 RID: 14672 RVA: 0x00103860 File Offset: 0x00101A60
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 20124, RefRangeEnd = 20136, XrefRangeStart = 20124, XrefRangeEnd = 20136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Weaved()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Players.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003951 RID: 14673 RVA: 0x001038A8 File Offset: 0x00101AA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116545, XrefRangeEnd = 116551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_PlayerAddedClientRpc__Player(Player p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Players.NativeMethodInfoPtr_UserCode_PlayerAddedClientRpc__Player_Protected_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003952 RID: 14674 RVA: 0x001038EC File Offset: 0x00101AEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116551, XrefRangeEnd = 116573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_PlayerAddedClientRpc__Player(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Players.NativeMethodInfoPtr_InvokeUserCode_PlayerAddedClientRpc__Player_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003953 RID: 14675 RVA: 0x00103948 File Offset: 0x00101B48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116573, XrefRangeEnd = 116579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_PlayerRemovedClientRpc__String(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Players.NativeMethodInfoPtr_UserCode_PlayerRemovedClientRpc__String_Protected_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003954 RID: 14676 RVA: 0x0010398C File Offset: 0x00101B8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116579, XrefRangeEnd = 116599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_PlayerRemovedClientRpc__String(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Players.NativeMethodInfoPtr_InvokeUserCode_PlayerRemovedClientRpc__String_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003955 RID: 14677 RVA: 0x001039E8 File Offset: 0x00101BE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116599, XrefRangeEnd = 116601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcSetPlayerCollisions__Boolean(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref enabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Players.NativeMethodInfoPtr_UserCode_RpcSetPlayerCollisions__Boolean_Protected_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003956 RID: 14678 RVA: 0x00103A28 File Offset: 0x00101C28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116601, XrefRangeEnd = 116616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RpcSetPlayerCollisions__Boolean(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Players.NativeMethodInfoPtr_InvokeUserCode_RpcSetPlayerCollisions__Boolean_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003957 RID: 14679 RVA: 0x00103A84 File Offset: 0x00101C84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116616, XrefRangeEnd = 116619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Players.NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003958 RID: 14680 RVA: 0x00103AE0 File Offset: 0x00101CE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116619, XrefRangeEnd = 116625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Players.NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003959 RID: 14681 RVA: 0x00016467 File Offset: 0x00014667
		public Players(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170013E1 RID: 5089
		// (get) Token: 0x0600395A RID: 14682 RVA: 0x00103B3C File Offset: 0x00101D3C
		// (set) Token: 0x0600395B RID: 14683 RVA: 0x00016470 File Offset: 0x00014670
		public unsafe LuaEvent PlayerAdded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Players.NativeFieldInfoPtr_PlayerAdded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LuaEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Players.NativeFieldInfoPtr_PlayerAdded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013E2 RID: 5090
		// (get) Token: 0x0600395C RID: 14684 RVA: 0x00103B6C File Offset: 0x00101D6C
		// (set) Token: 0x0600395D RID: 14685 RVA: 0x0001648F File Offset: 0x0001468F
		public unsafe LuaEvent PlayerRemoved
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Players.NativeFieldInfoPtr_PlayerRemoved);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LuaEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Players.NativeFieldInfoPtr_PlayerRemoved), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013E3 RID: 5091
		// (get) Token: 0x0600395E RID: 14686 RVA: 0x00103B9C File Offset: 0x00101D9C
		// (set) Token: 0x0600395F RID: 14687 RVA: 0x000164AE File Offset: 0x000146AE
		public unsafe Player _localPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Players.NativeFieldInfoPtr__localPlayer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Players.NativeFieldInfoPtr__localPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013E4 RID: 5092
		// (get) Token: 0x06003960 RID: 14688 RVA: 0x00103BCC File Offset: 0x00101DCC
		// (set) Token: 0x06003961 RID: 14689 RVA: 0x000164CD File Offset: 0x000146CD
		public unsafe bool playerCollisions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Players.NativeFieldInfoPtr_playerCollisions);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Players.NativeFieldInfoPtr_playerCollisions)) = value;
			}
		}

		// Token: 0x04002C60 RID: 11360
		private static readonly IntPtr NativeFieldInfoPtr_PlayerAdded;

		// Token: 0x04002C61 RID: 11361
		private static readonly IntPtr NativeFieldInfoPtr_PlayerRemoved;

		// Token: 0x04002C62 RID: 11362
		private static readonly IntPtr NativeFieldInfoPtr__localPlayer;

		// Token: 0x04002C63 RID: 11363
		private static readonly IntPtr NativeFieldInfoPtr_playerCollisions;

		// Token: 0x04002C64 RID: 11364
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalPlayer_Public_get_Player_0;

		// Token: 0x04002C65 RID: 11365
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayerCollisionEnabled_Public_get_Boolean_0;

		// Token: 0x04002C66 RID: 11366
		private static readonly IntPtr NativeMethodInfoPtr_set_PlayerCollisionEnabled_Public_set_Void_Boolean_0;

		// Token: 0x04002C67 RID: 11367
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkplayerCollisions_Public_get_Boolean_0;

		// Token: 0x04002C68 RID: 11368
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkplayerCollisions_Public_set_Void_Boolean_0;

		// Token: 0x04002C69 RID: 11369
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002C6A RID: 11370
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04002C6B RID: 11371
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04002C6C RID: 11372
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayers_Public_Il2CppReferenceArray_1_Player_0;

		// Token: 0x04002C6D RID: 11373
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayer_Public_Player_String_0;

		// Token: 0x04002C6E RID: 11374
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerByID_Public_Player_Int32_0;

		// Token: 0x04002C6F RID: 11375
		private static readonly IntPtr NativeMethodInfoPtr_AddPlayer_Public_Void_Player_0;

		// Token: 0x04002C70 RID: 11376
		private static readonly IntPtr NativeMethodInfoPtr_DelayedPlayerAddEvent_Private_IEnumerator_Player_0;

		// Token: 0x04002C71 RID: 11377
		private static readonly IntPtr NativeMethodInfoPtr_NotifyPlayerDestroyed_Public_Void_Player_0;

		// Token: 0x04002C72 RID: 11378
		private static readonly IntPtr NativeMethodInfoPtr_PlayerAddedClientRpc_Private_Void_Player_0;

		// Token: 0x04002C73 RID: 11379
		private static readonly IntPtr NativeMethodInfoPtr_PlayerRemovedClientRpc_Private_Void_String_0;

		// Token: 0x04002C74 RID: 11380
		private static readonly IntPtr NativeMethodInfoPtr_RpcSetPlayerCollisions_Private_Void_Boolean_0;

		// Token: 0x04002C75 RID: 11381
		private static readonly IntPtr NativeMethodInfoPtr_SetLocalPlayer_Public_Void_Player_0;

		// Token: 0x04002C76 RID: 11382
		private static readonly IntPtr NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0;

		// Token: 0x04002C77 RID: 11383
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_PlayerAddedClientRpc__Player_Protected_Void_Player_0;

		// Token: 0x04002C78 RID: 11384
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_PlayerAddedClientRpc__Player_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002C79 RID: 11385
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_PlayerRemovedClientRpc__String_Protected_Void_String_0;

		// Token: 0x04002C7A RID: 11386
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_PlayerRemovedClientRpc__String_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002C7B RID: 11387
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcSetPlayerCollisions__Boolean_Protected_Void_Boolean_0;

		// Token: 0x04002C7C RID: 11388
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcSetPlayerCollisions__Boolean_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002C7D RID: 11389
		private static readonly IntPtr NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0;

		// Token: 0x04002C7E RID: 11390
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0;

		// Token: 0x02000401 RID: 1025
		[ObfuscatedName("Polytoria.Datamodel.Players+<DelayedPlayerAddEvent>d__15")]
		public sealed class _DelayedPlayerAddEvent_d__15 : Object
		{
			// Token: 0x06004E9D RID: 20125 RVA: 0x00153D90 File Offset: 0x00151F90
			// Note: this type is marked as 'beforefieldinit'.
			static _DelayedPlayerAddEvent_d__15()
			{
				Il2CppClassPointerStore<Players._DelayedPlayerAddEvent_d__15>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Players>.NativeClassPtr, "<DelayedPlayerAddEvent>d__15");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Players._DelayedPlayerAddEvent_d__15>.NativeClassPtr);
				Players._DelayedPlayerAddEvent_d__15.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Players._DelayedPlayerAddEvent_d__15>.NativeClassPtr, "<>1__state");
				Players._DelayedPlayerAddEvent_d__15.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Players._DelayedPlayerAddEvent_d__15>.NativeClassPtr, "<>2__current");
				Players._DelayedPlayerAddEvent_d__15.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Players._DelayedPlayerAddEvent_d__15>.NativeClassPtr, "<>4__this");
				Players._DelayedPlayerAddEvent_d__15.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Players._DelayedPlayerAddEvent_d__15>.NativeClassPtr, "player");
				Players._DelayedPlayerAddEvent_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Players._DelayedPlayerAddEvent_d__15>.NativeClassPtr, 100672069);
				Players._DelayedPlayerAddEvent_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Players._DelayedPlayerAddEvent_d__15>.NativeClassPtr, 100672071);
				Players._DelayedPlayerAddEvent_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Players._DelayedPlayerAddEvent_d__15>.NativeClassPtr, 100672066);
				Players._DelayedPlayerAddEvent_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Players._DelayedPlayerAddEvent_d__15>.NativeClassPtr, 100672067);
				Players._DelayedPlayerAddEvent_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Players._DelayedPlayerAddEvent_d__15>.NativeClassPtr, 100672068);
				Players._DelayedPlayerAddEvent_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Players._DelayedPlayerAddEvent_d__15>.NativeClassPtr, 100672070);
			}

			// Token: 0x17001A82 RID: 6786
			// (get) Token: 0x06004E9E RID: 20126 RVA: 0x00153E84 File Offset: 0x00152084
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Players._DelayedPlayerAddEvent_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001A83 RID: 6787
			// (get) Token: 0x06004E9F RID: 20127 RVA: 0x00153EC4 File Offset: 0x001520C4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Players._DelayedPlayerAddEvent_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004EA0 RID: 20128 RVA: 0x00153F04 File Offset: 0x00152104
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 10168, RefRangeEnd = 10216, XrefRangeStart = 10168, XrefRangeEnd = 10216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DelayedPlayerAddEvent_d__15(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Players._DelayedPlayerAddEvent_d__15>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Players._DelayedPlayerAddEvent_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004EA1 RID: 20129 RVA: 0x00153F4C File Offset: 0x0015214C
			[CallerCount(7535)]
			[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Players._DelayedPlayerAddEvent_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004EA2 RID: 20130 RVA: 0x00153F80 File Offset: 0x00152180
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116331, XrefRangeEnd = 116337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Players._DelayedPlayerAddEvent_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004EA3 RID: 20131 RVA: 0x00153FBC File Offset: 0x001521BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116337, XrefRangeEnd = 116342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Players._DelayedPlayerAddEvent_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004EA4 RID: 20132 RVA: 0x0001DD5D File Offset: 0x0001BF5D
			public _DelayedPlayerAddEvent_d__15(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001A7E RID: 6782
			// (get) Token: 0x06004EA5 RID: 20133 RVA: 0x00153FF0 File Offset: 0x001521F0
			// (set) Token: 0x06004EA6 RID: 20134 RVA: 0x0001DD66 File Offset: 0x0001BF66
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Players._DelayedPlayerAddEvent_d__15.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Players._DelayedPlayerAddEvent_d__15.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001A7F RID: 6783
			// (get) Token: 0x06004EA7 RID: 20135 RVA: 0x00154018 File Offset: 0x00152218
			// (set) Token: 0x06004EA8 RID: 20136 RVA: 0x0001DD81 File Offset: 0x0001BF81
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Players._DelayedPlayerAddEvent_d__15.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Players._DelayedPlayerAddEvent_d__15.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A80 RID: 6784
			// (get) Token: 0x06004EA9 RID: 20137 RVA: 0x00154048 File Offset: 0x00152248
			// (set) Token: 0x06004EAA RID: 20138 RVA: 0x0001DDA0 File Offset: 0x0001BFA0
			public unsafe Players __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Players._DelayedPlayerAddEvent_d__15.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Players>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Players._DelayedPlayerAddEvent_d__15.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A81 RID: 6785
			// (get) Token: 0x06004EAB RID: 20139 RVA: 0x00154078 File Offset: 0x00152278
			// (set) Token: 0x06004EAC RID: 20140 RVA: 0x0001DDBF File Offset: 0x0001BFBF
			public unsafe Player player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Players._DelayedPlayerAddEvent_d__15.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Players._DelayedPlayerAddEvent_d__15.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003CDC RID: 15580
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003CDD RID: 15581
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003CDE RID: 15582
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003CDF RID: 15583
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04003CE0 RID: 15584
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003CE1 RID: 15585
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003CE2 RID: 15586
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003CE3 RID: 15587
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003CE4 RID: 15588
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003CE5 RID: 15589
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}
	}
}
