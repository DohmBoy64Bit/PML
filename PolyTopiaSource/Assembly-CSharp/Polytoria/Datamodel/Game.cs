using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Mirror;
using Polytoria.Lua;

namespace Polytoria.Datamodel
{
	// Token: 0x0200027D RID: 637
	public class Game : Instance
	{
		// Token: 0x0600322D RID: 12845 RVA: 0x000E5F70 File Offset: 0x000E4170
		// Note: this type is marked as 'beforefieldinit'.
		static Game()
		{
			Il2CppClassPointerStore<Game>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel", "Game");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Game>.NativeClassPtr);
			Game.NativeFieldInfoPtr_singleton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "singleton");
			Game.NativeFieldInfoPtr_Loaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "Loaded");
			Game.NativeFieldInfoPtr_Rendered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "Rendered");
			Game.NativeFieldInfoPtr_gameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "gameID");
			Game.NativeFieldInfoPtr_playersConnected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "playersConnected");
			Game.NativeFieldInfoPtr_GameName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "GameName");
			Game.NativeFieldInfoPtr_instanceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "instanceCount");
			Game.NativeFieldInfoPtr_localInstanceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "localInstanceCount");
			Game.NativeFieldInfoPtr_GameLoadedLocally = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "GameLoadedLocally");
			Game.NativeFieldInfoPtr_isGameLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game>.NativeClassPtr, "isGameLoaded");
			Game.NativeMethodInfoPtr_get_GameID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100670856);
			Game.NativeMethodInfoPtr_get_PlayersConnected_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100670857);
			Game.NativeMethodInfoPtr_get_InstanceCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100670858);
			Game.NativeMethodInfoPtr_get_LocalInstanceCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100670859);
			Game.NativeMethodInfoPtr_get_NetworkgameID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100670875);
			Game.NativeMethodInfoPtr_set_NetworkgameID_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100670876);
			Game.NativeMethodInfoPtr_get_NetworkplayersConnected_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100670877);
			Game.NativeMethodInfoPtr_set_NetworkplayersConnected_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100670878);
			Game.NativeMethodInfoPtr_get_NetworkinstanceCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100670879);
			Game.NativeMethodInfoPtr_set_NetworkinstanceCount_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100670880);
			Game.NativeMethodInfoPtr_add_Loaded_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100670854);
			Game.NativeMethodInfoPtr_remove_Loaded_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100670855);
			Game.NativeMethodInfoPtr_add_GameLoadedLocally_Public_Static_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100670860);
			Game.NativeMethodInfoPtr_remove_GameLoadedLocally_Public_Static_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100670861);
			Game.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100670873);
			Game.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100670862);
			Game.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100670863);
			Game.NativeMethodInfoPtr_InvokeLoaded_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100670864);
			Game.NativeMethodInfoPtr_InvokeLoadedLocal_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100670865);
			Game.NativeMethodInfoPtr_SetGameID_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100670866);
			Game.NativeMethodInfoPtr_BuildNavMesh_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100670867);
			Game.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100670868);
			Game.NativeMethodInfoPtr_WaitForGameLoad_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100670869);
			Game.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100670870);
			Game.NativeMethodInfoPtr_InstanceAdded_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100670871);
			Game.NativeMethodInfoPtr_InstanceRemoved_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100670872);
			Game.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100670874);
			Game.NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100670881);
			Game.NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game>.NativeClassPtr, 100670882);
		}

		// Token: 0x17001192 RID: 4498
		// (get) Token: 0x0600322E RID: 12846 RVA: 0x000E62AC File Offset: 0x000E44AC
		public unsafe int GameID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Game.NativeMethodInfoPtr_get_GameID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001193 RID: 4499
		// (get) Token: 0x0600322F RID: 12847 RVA: 0x000E62E8 File Offset: 0x000E44E8
		public unsafe int PlayersConnected
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Game.NativeMethodInfoPtr_get_PlayersConnected_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001194 RID: 4500
		// (get) Token: 0x06003230 RID: 12848 RVA: 0x000E6324 File Offset: 0x000E4524
		public unsafe int InstanceCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Game.NativeMethodInfoPtr_get_InstanceCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001195 RID: 4501
		// (get) Token: 0x06003231 RID: 12849 RVA: 0x000E6360 File Offset: 0x000E4560
		public unsafe int LocalInstanceCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Game.NativeMethodInfoPtr_get_LocalInstanceCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001196 RID: 4502
		// (get) Token: 0x06003232 RID: 12850 RVA: 0x000E639C File Offset: 0x000E459C
		// (set) Token: 0x06003233 RID: 12851 RVA: 0x000E63D8 File Offset: 0x000E45D8
		public unsafe int NetworkgameID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Game.NativeMethodInfoPtr_get_NetworkgameID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 103371, RefRangeEnd = 103372, XrefRangeStart = 103365, XrefRangeEnd = 103371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Game.NativeMethodInfoPtr_set_NetworkgameID_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001197 RID: 4503
		// (get) Token: 0x06003234 RID: 12852 RVA: 0x000E6418 File Offset: 0x000E4618
		// (set) Token: 0x06003235 RID: 12853 RVA: 0x000E6454 File Offset: 0x000E4654
		public unsafe int NetworkplayersConnected
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Game.NativeMethodInfoPtr_get_NetworkplayersConnected_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103372, XrefRangeEnd = 103378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Game.NativeMethodInfoPtr_set_NetworkplayersConnected_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001198 RID: 4504
		// (get) Token: 0x06003236 RID: 12854 RVA: 0x000E6494 File Offset: 0x000E4694
		// (set) Token: 0x06003237 RID: 12855 RVA: 0x000E64D0 File Offset: 0x000E46D0
		public unsafe int NetworkinstanceCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Game.NativeMethodInfoPtr_get_NetworkinstanceCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 103384, RefRangeEnd = 103389, XrefRangeStart = 103378, XrefRangeEnd = 103384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Game.NativeMethodInfoPtr_set_NetworkinstanceCount_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003238 RID: 12856 RVA: 0x000E6510 File Offset: 0x000E4710
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 103393, RefRangeEnd = 103394, XrefRangeStart = 103389, XrefRangeEnd = 103393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_Loaded(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Game.NativeMethodInfoPtr_add_Loaded_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003239 RID: 12857 RVA: 0x000E6554 File Offset: 0x000E4754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103394, XrefRangeEnd = 103398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_Loaded(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Game.NativeMethodInfoPtr_remove_Loaded_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600323A RID: 12858 RVA: 0x000E6598 File Offset: 0x000E4798
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 103405, RefRangeEnd = 103408, XrefRangeStart = 103398, XrefRangeEnd = 103405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_GameLoadedLocally(Action value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Game.NativeMethodInfoPtr_add_GameLoadedLocally_Public_Static_add_Void_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600323B RID: 12859 RVA: 0x000E65D0 File Offset: 0x000E47D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 103415, RefRangeEnd = 103416, XrefRangeStart = 103408, XrefRangeEnd = 103415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_GameLoadedLocally(Action value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Game.NativeMethodInfoPtr_remove_GameLoadedLocally_Public_Static_rem_Void_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600323C RID: 12860 RVA: 0x000E6608 File Offset: 0x000E4808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103416, XrefRangeEnd = 103425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Game()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Game>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Game.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600323D RID: 12861 RVA: 0x000E6644 File Offset: 0x000E4844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103425, XrefRangeEnd = 103430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Game.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600323E RID: 12862 RVA: 0x000E6680 File Offset: 0x000E4880
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103430, XrefRangeEnd = 103448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartServer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Game.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600323F RID: 12863 RVA: 0x000E66BC File Offset: 0x000E48BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 103461, RefRangeEnd = 103462, XrefRangeStart = 103448, XrefRangeEnd = 103461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeLoaded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Game.NativeMethodInfoPtr_InvokeLoaded_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003240 RID: 12864 RVA: 0x000E66F0 File Offset: 0x000E48F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103462, XrefRangeEnd = 103464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeLoadedLocal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Game.NativeMethodInfoPtr_InvokeLoadedLocal_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003241 RID: 12865 RVA: 0x000E6724 File Offset: 0x000E4924
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 103371, RefRangeEnd = 103372, XrefRangeStart = 103371, XrefRangeEnd = 103372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGameID(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Game.NativeMethodInfoPtr_SetGameID_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003242 RID: 12866 RVA: 0x000E6764 File Offset: 0x000E4964
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 103472, RefRangeEnd = 103473, XrefRangeStart = 103464, XrefRangeEnd = 103472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BuildNavMesh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Game.NativeMethodInfoPtr_BuildNavMesh_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003243 RID: 12867 RVA: 0x000E6798 File Offset: 0x000E4998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103473, XrefRangeEnd = 103489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Game.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003244 RID: 12868 RVA: 0x000E67D4 File Offset: 0x000E49D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103489, XrefRangeEnd = 103494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator WaitForGameLoad()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Game.NativeMethodInfoPtr_WaitForGameLoad_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06003245 RID: 12869 RVA: 0x000E6814 File Offset: 0x000E4A14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103494, XrefRangeEnd = 103517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Game.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003246 RID: 12870 RVA: 0x000E6848 File Offset: 0x000E4A48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103517, XrefRangeEnd = 103532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InstanceAdded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Game.NativeMethodInfoPtr_InstanceAdded_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003247 RID: 12871 RVA: 0x000E687C File Offset: 0x000E4A7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103532, XrefRangeEnd = 103547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InstanceRemoved()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Game.NativeMethodInfoPtr_InstanceRemoved_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003248 RID: 12872 RVA: 0x000E68B0 File Offset: 0x000E4AB0
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 20124, RefRangeEnd = 20136, XrefRangeStart = 20124, XrefRangeEnd = 20136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Weaved()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Game.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003249 RID: 12873 RVA: 0x000E68F8 File Offset: 0x000E4AF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103547, XrefRangeEnd = 103558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Game.NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600324A RID: 12874 RVA: 0x000E6954 File Offset: 0x000E4B54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103558, XrefRangeEnd = 103577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Game.NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600324B RID: 12875 RVA: 0x00013E53 File Offset: 0x00012053
		public Game(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001188 RID: 4488
		// (get) Token: 0x0600324C RID: 12876 RVA: 0x000E69B0 File Offset: 0x000E4BB0
		// (set) Token: 0x0600324D RID: 12877 RVA: 0x00013E5C File Offset: 0x0001205C
		public unsafe static Game singleton
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Game.NativeFieldInfoPtr_singleton, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Game>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Game.NativeFieldInfoPtr_singleton, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001189 RID: 4489
		// (get) Token: 0x0600324E RID: 12878 RVA: 0x000E69D8 File Offset: 0x000E4BD8
		// (set) Token: 0x0600324F RID: 12879 RVA: 0x00013E6E File Offset: 0x0001206E
		public unsafe Action Loaded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Game.NativeFieldInfoPtr_Loaded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Game.NativeFieldInfoPtr_Loaded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700118A RID: 4490
		// (get) Token: 0x06003250 RID: 12880 RVA: 0x000E6A08 File Offset: 0x000E4C08
		// (set) Token: 0x06003251 RID: 12881 RVA: 0x00013E8D File Offset: 0x0001208D
		public unsafe LuaEvent Rendered
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Game.NativeFieldInfoPtr_Rendered);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LuaEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Game.NativeFieldInfoPtr_Rendered), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700118B RID: 4491
		// (get) Token: 0x06003252 RID: 12882 RVA: 0x000E6A38 File Offset: 0x000E4C38
		// (set) Token: 0x06003253 RID: 12883 RVA: 0x00013EAC File Offset: 0x000120AC
		public unsafe int gameID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Game.NativeFieldInfoPtr_gameID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Game.NativeFieldInfoPtr_gameID)) = value;
			}
		}

		// Token: 0x1700118C RID: 4492
		// (get) Token: 0x06003254 RID: 12884 RVA: 0x000E6A60 File Offset: 0x000E4C60
		// (set) Token: 0x06003255 RID: 12885 RVA: 0x00013EC7 File Offset: 0x000120C7
		public unsafe int playersConnected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Game.NativeFieldInfoPtr_playersConnected);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Game.NativeFieldInfoPtr_playersConnected)) = value;
			}
		}

		// Token: 0x1700118D RID: 4493
		// (get) Token: 0x06003256 RID: 12886 RVA: 0x000E6A88 File Offset: 0x000E4C88
		// (set) Token: 0x06003257 RID: 12887 RVA: 0x00013EE2 File Offset: 0x000120E2
		public unsafe static string GameName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Game.NativeFieldInfoPtr_GameName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Game.NativeFieldInfoPtr_GameName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700118E RID: 4494
		// (get) Token: 0x06003258 RID: 12888 RVA: 0x000E6AA8 File Offset: 0x000E4CA8
		// (set) Token: 0x06003259 RID: 12889 RVA: 0x00013EF4 File Offset: 0x000120F4
		public unsafe int instanceCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Game.NativeFieldInfoPtr_instanceCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Game.NativeFieldInfoPtr_instanceCount)) = value;
			}
		}

		// Token: 0x1700118F RID: 4495
		// (get) Token: 0x0600325A RID: 12890 RVA: 0x000E6AD0 File Offset: 0x000E4CD0
		// (set) Token: 0x0600325B RID: 12891 RVA: 0x00013F0F File Offset: 0x0001210F
		public unsafe int localInstanceCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Game.NativeFieldInfoPtr_localInstanceCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Game.NativeFieldInfoPtr_localInstanceCount)) = value;
			}
		}

		// Token: 0x17001190 RID: 4496
		// (get) Token: 0x0600325C RID: 12892 RVA: 0x000E6AF8 File Offset: 0x000E4CF8
		// (set) Token: 0x0600325D RID: 12893 RVA: 0x00013F2A File Offset: 0x0001212A
		public unsafe static Action GameLoadedLocally
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Game.NativeFieldInfoPtr_GameLoadedLocally, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Game.NativeFieldInfoPtr_GameLoadedLocally, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001191 RID: 4497
		// (get) Token: 0x0600325E RID: 12894 RVA: 0x000E6B20 File Offset: 0x000E4D20
		// (set) Token: 0x0600325F RID: 12895 RVA: 0x00013F3C File Offset: 0x0001213C
		public unsafe bool isGameLoaded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Game.NativeFieldInfoPtr_isGameLoaded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Game.NativeFieldInfoPtr_isGameLoaded)) = value;
			}
		}

		// Token: 0x04002689 RID: 9865
		private static readonly IntPtr NativeFieldInfoPtr_singleton;

		// Token: 0x0400268A RID: 9866
		private static readonly IntPtr NativeFieldInfoPtr_Loaded;

		// Token: 0x0400268B RID: 9867
		private static readonly IntPtr NativeFieldInfoPtr_Rendered;

		// Token: 0x0400268C RID: 9868
		private static readonly IntPtr NativeFieldInfoPtr_gameID;

		// Token: 0x0400268D RID: 9869
		private static readonly IntPtr NativeFieldInfoPtr_playersConnected;

		// Token: 0x0400268E RID: 9870
		private static readonly IntPtr NativeFieldInfoPtr_GameName;

		// Token: 0x0400268F RID: 9871
		private static readonly IntPtr NativeFieldInfoPtr_instanceCount;

		// Token: 0x04002690 RID: 9872
		private static readonly IntPtr NativeFieldInfoPtr_localInstanceCount;

		// Token: 0x04002691 RID: 9873
		private static readonly IntPtr NativeFieldInfoPtr_GameLoadedLocally;

		// Token: 0x04002692 RID: 9874
		private static readonly IntPtr NativeFieldInfoPtr_isGameLoaded;

		// Token: 0x04002693 RID: 9875
		private static readonly IntPtr NativeMethodInfoPtr_get_GameID_Public_get_Int32_0;

		// Token: 0x04002694 RID: 9876
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayersConnected_Public_get_Int32_0;

		// Token: 0x04002695 RID: 9877
		private static readonly IntPtr NativeMethodInfoPtr_get_InstanceCount_Public_get_Int32_0;

		// Token: 0x04002696 RID: 9878
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalInstanceCount_Public_get_Int32_0;

		// Token: 0x04002697 RID: 9879
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkgameID_Public_get_Int32_0;

		// Token: 0x04002698 RID: 9880
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkgameID_Public_set_Void_Int32_0;

		// Token: 0x04002699 RID: 9881
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkplayersConnected_Public_get_Int32_0;

		// Token: 0x0400269A RID: 9882
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkplayersConnected_Public_set_Void_Int32_0;

		// Token: 0x0400269B RID: 9883
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkinstanceCount_Public_get_Int32_0;

		// Token: 0x0400269C RID: 9884
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkinstanceCount_Public_set_Void_Int32_0;

		// Token: 0x0400269D RID: 9885
		private static readonly IntPtr NativeMethodInfoPtr_add_Loaded_Public_add_Void_Action_0;

		// Token: 0x0400269E RID: 9886
		private static readonly IntPtr NativeMethodInfoPtr_remove_Loaded_Public_rem_Void_Action_0;

		// Token: 0x0400269F RID: 9887
		private static readonly IntPtr NativeMethodInfoPtr_add_GameLoadedLocally_Public_Static_add_Void_Action_0;

		// Token: 0x040026A0 RID: 9888
		private static readonly IntPtr NativeMethodInfoPtr_remove_GameLoadedLocally_Public_Static_rem_Void_Action_0;

		// Token: 0x040026A1 RID: 9889
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040026A2 RID: 9890
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040026A3 RID: 9891
		private static readonly IntPtr NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0;

		// Token: 0x040026A4 RID: 9892
		private static readonly IntPtr NativeMethodInfoPtr_InvokeLoaded_Public_Void_0;

		// Token: 0x040026A5 RID: 9893
		private static readonly IntPtr NativeMethodInfoPtr_InvokeLoadedLocal_Public_Void_0;

		// Token: 0x040026A6 RID: 9894
		private static readonly IntPtr NativeMethodInfoPtr_SetGameID_Public_Void_Int32_0;

		// Token: 0x040026A7 RID: 9895
		private static readonly IntPtr NativeMethodInfoPtr_BuildNavMesh_Public_Void_0;

		// Token: 0x040026A8 RID: 9896
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040026A9 RID: 9897
		private static readonly IntPtr NativeMethodInfoPtr_WaitForGameLoad_Public_IEnumerator_0;

		// Token: 0x040026AA RID: 9898
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040026AB RID: 9899
		private static readonly IntPtr NativeMethodInfoPtr_InstanceAdded_Public_Void_0;

		// Token: 0x040026AC RID: 9900
		private static readonly IntPtr NativeMethodInfoPtr_InstanceRemoved_Public_Void_0;

		// Token: 0x040026AD RID: 9901
		private static readonly IntPtr NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0;

		// Token: 0x040026AE RID: 9902
		private static readonly IntPtr NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0;

		// Token: 0x040026AF RID: 9903
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0;

		// Token: 0x020003EF RID: 1007
		[ObfuscatedName("Polytoria.Datamodel.Game+<WaitForGameLoad>d__29")]
		public sealed class _WaitForGameLoad_d__29 : Object
		{
			// Token: 0x06004DDB RID: 19931 RVA: 0x0015182C File Offset: 0x0014FA2C
			// Note: this type is marked as 'beforefieldinit'.
			static _WaitForGameLoad_d__29()
			{
				Il2CppClassPointerStore<Game._WaitForGameLoad_d__29>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Game>.NativeClassPtr, "<WaitForGameLoad>d__29");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Game._WaitForGameLoad_d__29>.NativeClassPtr);
				Game._WaitForGameLoad_d__29.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game._WaitForGameLoad_d__29>.NativeClassPtr, "<>1__state");
				Game._WaitForGameLoad_d__29.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game._WaitForGameLoad_d__29>.NativeClassPtr, "<>2__current");
				Game._WaitForGameLoad_d__29.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game._WaitForGameLoad_d__29>.NativeClassPtr, "<>4__this");
				Game._WaitForGameLoad_d__29.NativeFieldInfoPtr__startTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game._WaitForGameLoad_d__29>.NativeClassPtr, "<startTime>5__2");
				Game._WaitForGameLoad_d__29.NativeFieldInfoPtr__timeout_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game._WaitForGameLoad_d__29>.NativeClassPtr, "<timeout>5__3");
				Game._WaitForGameLoad_d__29.NativeFieldInfoPtr__lastInstances_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game._WaitForGameLoad_d__29>.NativeClassPtr, "<lastInstances>5__4");
				Game._WaitForGameLoad_d__29.NativeFieldInfoPtr__timeSinceChange_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game._WaitForGameLoad_d__29>.NativeClassPtr, "<timeSinceChange>5__5");
				Game._WaitForGameLoad_d__29.NativeFieldInfoPtr__minimumTime_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Game._WaitForGameLoad_d__29>.NativeClassPtr, "<minimumTime>5__6");
				Game._WaitForGameLoad_d__29.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game._WaitForGameLoad_d__29>.NativeClassPtr, 100670886);
				Game._WaitForGameLoad_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game._WaitForGameLoad_d__29>.NativeClassPtr, 100670888);
				Game._WaitForGameLoad_d__29.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game._WaitForGameLoad_d__29>.NativeClassPtr, 100670883);
				Game._WaitForGameLoad_d__29.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game._WaitForGameLoad_d__29>.NativeClassPtr, 100670884);
				Game._WaitForGameLoad_d__29.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game._WaitForGameLoad_d__29>.NativeClassPtr, 100670885);
				Game._WaitForGameLoad_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Game._WaitForGameLoad_d__29>.NativeClassPtr, 100670887);
			}

			// Token: 0x17001A42 RID: 6722
			// (get) Token: 0x06004DDC RID: 19932 RVA: 0x00151970 File Offset: 0x0014FB70
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Game._WaitForGameLoad_d__29.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x17001A43 RID: 6723
			// (get) Token: 0x06004DDD RID: 19933 RVA: 0x001519B0 File Offset: 0x0014FBB0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 10157, RefRangeEnd = 10167, XrefRangeStart = 10157, XrefRangeEnd = 10167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Game._WaitForGameLoad_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004DDE RID: 19934 RVA: 0x001519F0 File Offset: 0x0014FBF0
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 10168, RefRangeEnd = 10216, XrefRangeStart = 10168, XrefRangeEnd = 10216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _WaitForGameLoad_d__29(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Game._WaitForGameLoad_d__29>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Game._WaitForGameLoad_d__29.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004DDF RID: 19935 RVA: 0x00151A38 File Offset: 0x0014FC38
			[CallerCount(7535)]
			[CachedScanResults(RefRangeStart = 2417, RefRangeEnd = 9952, XrefRangeStart = 2417, XrefRangeEnd = 9952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Game._WaitForGameLoad_d__29.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004DE0 RID: 19936 RVA: 0x00151A6C File Offset: 0x0014FC6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103329, XrefRangeEnd = 103360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Game._WaitForGameLoad_d__29.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004DE1 RID: 19937 RVA: 0x00151AA8 File Offset: 0x0014FCA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103360, XrefRangeEnd = 103365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Game._WaitForGameLoad_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004DE2 RID: 19938 RVA: 0x0001D78E File Offset: 0x0001B98E
			public _WaitForGameLoad_d__29(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001A3A RID: 6714
			// (get) Token: 0x06004DE3 RID: 19939 RVA: 0x00151ADC File Offset: 0x0014FCDC
			// (set) Token: 0x06004DE4 RID: 19940 RVA: 0x0001D797 File Offset: 0x0001B997
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Game._WaitForGameLoad_d__29.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Game._WaitForGameLoad_d__29.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001A3B RID: 6715
			// (get) Token: 0x06004DE5 RID: 19941 RVA: 0x00151B04 File Offset: 0x0014FD04
			// (set) Token: 0x06004DE6 RID: 19942 RVA: 0x0001D7B2 File Offset: 0x0001B9B2
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Game._WaitForGameLoad_d__29.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Game._WaitForGameLoad_d__29.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A3C RID: 6716
			// (get) Token: 0x06004DE7 RID: 19943 RVA: 0x00151B34 File Offset: 0x0014FD34
			// (set) Token: 0x06004DE8 RID: 19944 RVA: 0x0001D7D1 File Offset: 0x0001B9D1
			public unsafe Game __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Game._WaitForGameLoad_d__29.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Game>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Game._WaitForGameLoad_d__29.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A3D RID: 6717
			// (get) Token: 0x06004DE9 RID: 19945 RVA: 0x00151B64 File Offset: 0x0014FD64
			// (set) Token: 0x06004DEA RID: 19946 RVA: 0x0001D7F0 File Offset: 0x0001B9F0
			public unsafe float _startTime_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Game._WaitForGameLoad_d__29.NativeFieldInfoPtr__startTime_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Game._WaitForGameLoad_d__29.NativeFieldInfoPtr__startTime_5__2)) = value;
				}
			}

			// Token: 0x17001A3E RID: 6718
			// (get) Token: 0x06004DEB RID: 19947 RVA: 0x00151B8C File Offset: 0x0014FD8C
			// (set) Token: 0x06004DEC RID: 19948 RVA: 0x0001D80B File Offset: 0x0001BA0B
			public unsafe float _timeout_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Game._WaitForGameLoad_d__29.NativeFieldInfoPtr__timeout_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Game._WaitForGameLoad_d__29.NativeFieldInfoPtr__timeout_5__3)) = value;
				}
			}

			// Token: 0x17001A3F RID: 6719
			// (get) Token: 0x06004DED RID: 19949 RVA: 0x00151BB4 File Offset: 0x0014FDB4
			// (set) Token: 0x06004DEE RID: 19950 RVA: 0x0001D826 File Offset: 0x0001BA26
			public unsafe int _lastInstances_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Game._WaitForGameLoad_d__29.NativeFieldInfoPtr__lastInstances_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Game._WaitForGameLoad_d__29.NativeFieldInfoPtr__lastInstances_5__4)) = value;
				}
			}

			// Token: 0x17001A40 RID: 6720
			// (get) Token: 0x06004DEF RID: 19951 RVA: 0x00151BDC File Offset: 0x0014FDDC
			// (set) Token: 0x06004DF0 RID: 19952 RVA: 0x0001D841 File Offset: 0x0001BA41
			public unsafe float _timeSinceChange_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Game._WaitForGameLoad_d__29.NativeFieldInfoPtr__timeSinceChange_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Game._WaitForGameLoad_d__29.NativeFieldInfoPtr__timeSinceChange_5__5)) = value;
				}
			}

			// Token: 0x17001A41 RID: 6721
			// (get) Token: 0x06004DF1 RID: 19953 RVA: 0x00151C04 File Offset: 0x0014FE04
			// (set) Token: 0x06004DF2 RID: 19954 RVA: 0x0001D85C File Offset: 0x0001BA5C
			public unsafe float _minimumTime_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Game._WaitForGameLoad_d__29.NativeFieldInfoPtr__minimumTime_5__6);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Game._WaitForGameLoad_d__29.NativeFieldInfoPtr__minimumTime_5__6)) = value;
				}
			}

			// Token: 0x04003C5C RID: 15452
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003C5D RID: 15453
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003C5E RID: 15454
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003C5F RID: 15455
			private static readonly IntPtr NativeFieldInfoPtr__startTime_5__2;

			// Token: 0x04003C60 RID: 15456
			private static readonly IntPtr NativeFieldInfoPtr__timeout_5__3;

			// Token: 0x04003C61 RID: 15457
			private static readonly IntPtr NativeFieldInfoPtr__lastInstances_5__4;

			// Token: 0x04003C62 RID: 15458
			private static readonly IntPtr NativeFieldInfoPtr__timeSinceChange_5__5;

			// Token: 0x04003C63 RID: 15459
			private static readonly IntPtr NativeFieldInfoPtr__minimumTime_5__6;

			// Token: 0x04003C64 RID: 15460
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003C65 RID: 15461
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003C66 RID: 15462
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003C67 RID: 15463
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003C68 RID: 15464
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003C69 RID: 15465
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
		}
	}
}
