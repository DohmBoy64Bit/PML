using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Polytoria.Lua;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002EE RID: 750
	public class PlayersProxy : InstanceProxy
	{
		// Token: 0x060041F3 RID: 16883 RVA: 0x001287B0 File Offset: 0x001269B0
		// Note: this type is marked as 'beforefieldinit'.
		static PlayersProxy()
		{
			Il2CppClassPointerStore<PlayersProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Proxies", "PlayersProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayersProxy>.NativeClassPtr);
			PlayersProxy.NativeFieldInfoPtr_players = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayersProxy>.NativeClassPtr, "players");
			PlayersProxy.NativeMethodInfoPtr_get_PlayerAdded_Public_get_LuaEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayersProxy>.NativeClassPtr, 100673712);
			PlayersProxy.NativeMethodInfoPtr_get_PlayerRemoved_Public_get_LuaEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayersProxy>.NativeClassPtr, 100673713);
			PlayersProxy.NativeMethodInfoPtr_get_PlayerCollisionEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayersProxy>.NativeClassPtr, 100673714);
			PlayersProxy.NativeMethodInfoPtr_set_PlayerCollisionEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayersProxy>.NativeClassPtr, 100673715);
			PlayersProxy.NativeMethodInfoPtr_get_LocalPlayer_Public_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayersProxy>.NativeClassPtr, 100673716);
			PlayersProxy.NativeMethodInfoPtr__ctor_Public_Void_Players_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayersProxy>.NativeClassPtr, 100673711);
			PlayersProxy.NativeMethodInfoPtr_GetPlayers_Public_Il2CppReferenceArray_1_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayersProxy>.NativeClassPtr, 100673717);
			PlayersProxy.NativeMethodInfoPtr_GetPlayer_Public_Player_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayersProxy>.NativeClassPtr, 100673718);
			PlayersProxy.NativeMethodInfoPtr_GetPlayerByID_Public_Player_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayersProxy>.NativeClassPtr, 100673719);
		}

		// Token: 0x170016C2 RID: 5826
		// (get) Token: 0x060041F4 RID: 16884 RVA: 0x001288A8 File Offset: 0x00126AA8
		public unsafe LuaEvent PlayerAdded
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayersProxy.NativeMethodInfoPtr_get_PlayerAdded_Public_get_LuaEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LuaEvent>(intPtr3) : null;
			}
		}

		// Token: 0x170016C3 RID: 5827
		// (get) Token: 0x060041F5 RID: 16885 RVA: 0x001288E8 File Offset: 0x00126AE8
		public unsafe LuaEvent PlayerRemoved
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayersProxy.NativeMethodInfoPtr_get_PlayerRemoved_Public_get_LuaEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LuaEvent>(intPtr3) : null;
			}
		}

		// Token: 0x170016C4 RID: 5828
		// (get) Token: 0x060041F6 RID: 16886 RVA: 0x00128928 File Offset: 0x00126B28
		// (set) Token: 0x060041F7 RID: 16887 RVA: 0x00128964 File Offset: 0x00126B64
		public unsafe bool PlayerCollisionEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayersProxy.NativeMethodInfoPtr_get_PlayerCollisionEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128942, XrefRangeEnd = 128944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayersProxy.NativeMethodInfoPtr_set_PlayerCollisionEnabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170016C5 RID: 5829
		// (get) Token: 0x060041F8 RID: 16888 RVA: 0x001289A4 File Offset: 0x00126BA4
		public unsafe Player LocalPlayer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayersProxy.NativeMethodInfoPtr_get_LocalPlayer_Public_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
			}
		}

		// Token: 0x060041F9 RID: 16889 RVA: 0x001289E4 File Offset: 0x00126BE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayersProxy(Players target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayersProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayersProxy.NativeMethodInfoPtr__ctor_Public_Void_Players_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060041FA RID: 16890 RVA: 0x00128A30 File Offset: 0x00126C30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128944, XrefRangeEnd = 128946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Player> GetPlayers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayersProxy.NativeMethodInfoPtr_GetPlayers_Public_Il2CppReferenceArray_1_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Player>>(intPtr3) : null;
		}

		// Token: 0x060041FB RID: 16891 RVA: 0x00128A70 File Offset: 0x00126C70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128946, XrefRangeEnd = 128948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Player GetPlayer(string username)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(username);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayersProxy.NativeMethodInfoPtr_GetPlayer_Public_Player_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
			}
		}

		// Token: 0x060041FC RID: 16892 RVA: 0x00128AC0 File Offset: 0x00126CC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128948, XrefRangeEnd = 128950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Player GetPlayerByID(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayersProxy.NativeMethodInfoPtr_GetPlayerByID_Public_Player_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
			}
		}

		// Token: 0x060041FD RID: 16893 RVA: 0x00018971 File Offset: 0x00016B71
		public PlayersProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170016C1 RID: 5825
		// (get) Token: 0x060041FE RID: 16894 RVA: 0x00128B0C File Offset: 0x00126D0C
		// (set) Token: 0x060041FF RID: 16895 RVA: 0x0001897A File Offset: 0x00016B7A
		public unsafe Players players
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayersProxy.NativeFieldInfoPtr_players);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Players>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayersProxy.NativeFieldInfoPtr_players), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003368 RID: 13160
		private static readonly IntPtr NativeFieldInfoPtr_players;

		// Token: 0x04003369 RID: 13161
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayerAdded_Public_get_LuaEvent_0;

		// Token: 0x0400336A RID: 13162
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayerRemoved_Public_get_LuaEvent_0;

		// Token: 0x0400336B RID: 13163
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayerCollisionEnabled_Public_get_Boolean_0;

		// Token: 0x0400336C RID: 13164
		private static readonly IntPtr NativeMethodInfoPtr_set_PlayerCollisionEnabled_Public_set_Void_Boolean_0;

		// Token: 0x0400336D RID: 13165
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalPlayer_Public_get_Player_0;

		// Token: 0x0400336E RID: 13166
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Players_0;

		// Token: 0x0400336F RID: 13167
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayers_Public_Il2CppReferenceArray_1_Player_0;

		// Token: 0x04003370 RID: 13168
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayer_Public_Player_String_0;

		// Token: 0x04003371 RID: 13169
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerByID_Public_Player_Int32_0;
	}
}
