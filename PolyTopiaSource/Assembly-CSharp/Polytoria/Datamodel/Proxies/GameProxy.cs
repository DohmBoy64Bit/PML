using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Polytoria.Lua;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002D9 RID: 729
	public class GameProxy : InstanceProxy
	{
		// Token: 0x06004031 RID: 16433 RVA: 0x00120438 File Offset: 0x0011E638
		// Note: this type is marked as 'beforefieldinit'.
		static GameProxy()
		{
			Il2CppClassPointerStore<GameProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Proxies", "GameProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameProxy>.NativeClassPtr);
			GameProxy.NativeFieldInfoPtr_game = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameProxy>.NativeClassPtr, "game");
			GameProxy.NativeMethodInfoPtr_get_Rendered_Public_get_LuaEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameProxy>.NativeClassPtr, 100673346);
			GameProxy.NativeMethodInfoPtr_get_GameID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameProxy>.NativeClassPtr, 100673347);
			GameProxy.NativeMethodInfoPtr_get_PlayersConnected_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameProxy>.NativeClassPtr, 100673348);
			GameProxy.NativeMethodInfoPtr_get_InstanceCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameProxy>.NativeClassPtr, 100673349);
			GameProxy.NativeMethodInfoPtr_get_LocalInstanceCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameProxy>.NativeClassPtr, 100673350);
			GameProxy.NativeMethodInfoPtr__ctor_Public_Void_Game_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameProxy>.NativeClassPtr, 100673345);
		}

		// Token: 0x1700160A RID: 5642
		// (get) Token: 0x06004032 RID: 16434 RVA: 0x001204F4 File Offset: 0x0011E6F4
		public unsafe LuaEvent Rendered
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameProxy.NativeMethodInfoPtr_get_Rendered_Public_get_LuaEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LuaEvent>(intPtr3) : null;
			}
		}

		// Token: 0x1700160B RID: 5643
		// (get) Token: 0x06004033 RID: 16435 RVA: 0x00120534 File Offset: 0x0011E734
		public unsafe int GameID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameProxy.NativeMethodInfoPtr_get_GameID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700160C RID: 5644
		// (get) Token: 0x06004034 RID: 16436 RVA: 0x00120570 File Offset: 0x0011E770
		public unsafe int PlayersConnected
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameProxy.NativeMethodInfoPtr_get_PlayersConnected_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700160D RID: 5645
		// (get) Token: 0x06004035 RID: 16437 RVA: 0x001205AC File Offset: 0x0011E7AC
		public unsafe int InstanceCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameProxy.NativeMethodInfoPtr_get_InstanceCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700160E RID: 5646
		// (get) Token: 0x06004036 RID: 16438 RVA: 0x001205E8 File Offset: 0x0011E7E8
		public unsafe int LocalInstanceCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameProxy.NativeMethodInfoPtr_get_LocalInstanceCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004037 RID: 16439 RVA: 0x00120624 File Offset: 0x0011E824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameProxy(Game target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameProxy.NativeMethodInfoPtr__ctor_Public_Void_Game_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004038 RID: 16440 RVA: 0x00018629 File Offset: 0x00016829
		public GameProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001609 RID: 5641
		// (get) Token: 0x06004039 RID: 16441 RVA: 0x00120670 File Offset: 0x0011E870
		// (set) Token: 0x0600403A RID: 16442 RVA: 0x00018632 File Offset: 0x00016832
		public unsafe Game game
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameProxy.NativeFieldInfoPtr_game);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Game>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameProxy.NativeFieldInfoPtr_game), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040031E5 RID: 12773
		private static readonly IntPtr NativeFieldInfoPtr_game;

		// Token: 0x040031E6 RID: 12774
		private static readonly IntPtr NativeMethodInfoPtr_get_Rendered_Public_get_LuaEvent_0;

		// Token: 0x040031E7 RID: 12775
		private static readonly IntPtr NativeMethodInfoPtr_get_GameID_Public_get_Int32_0;

		// Token: 0x040031E8 RID: 12776
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayersConnected_Public_get_Int32_0;

		// Token: 0x040031E9 RID: 12777
		private static readonly IntPtr NativeMethodInfoPtr_get_InstanceCount_Public_get_Int32_0;

		// Token: 0x040031EA RID: 12778
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalInstanceCount_Public_get_Int32_0;

		// Token: 0x040031EB RID: 12779
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Game_0;
	}
}
