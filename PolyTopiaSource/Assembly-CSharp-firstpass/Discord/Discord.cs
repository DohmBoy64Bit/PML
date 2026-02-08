using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.InteropServices;

namespace Discord
{
	// Token: 0x02000159 RID: 345
	public class Discord : Object
	{
		// Token: 0x060016C0 RID: 5824 RVA: 0x00073A20 File Offset: 0x00071C20
		// Note: this type is marked as 'beforefieldinit'.
		static Discord()
		{
			Il2CppClassPointerStore<Discord>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Discord", "Discord");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Discord>.NativeClassPtr);
			Discord.NativeFieldInfoPtr_SelfHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord>.NativeClassPtr, "SelfHandle");
			Discord.NativeFieldInfoPtr_EventsPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord>.NativeClassPtr, "EventsPtr");
			Discord.NativeFieldInfoPtr_Events = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord>.NativeClassPtr, "Events");
			Discord.NativeFieldInfoPtr_ApplicationEventsPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord>.NativeClassPtr, "ApplicationEventsPtr");
			Discord.NativeFieldInfoPtr_ApplicationEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord>.NativeClassPtr, "ApplicationEvents");
			Discord.NativeFieldInfoPtr_ApplicationManagerInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord>.NativeClassPtr, "ApplicationManagerInstance");
			Discord.NativeFieldInfoPtr_UserEventsPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord>.NativeClassPtr, "UserEventsPtr");
			Discord.NativeFieldInfoPtr_UserEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord>.NativeClassPtr, "UserEvents");
			Discord.NativeFieldInfoPtr_UserManagerInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord>.NativeClassPtr, "UserManagerInstance");
			Discord.NativeFieldInfoPtr_ImageEventsPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord>.NativeClassPtr, "ImageEventsPtr");
			Discord.NativeFieldInfoPtr_ImageEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord>.NativeClassPtr, "ImageEvents");
			Discord.NativeFieldInfoPtr_ImageManagerInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord>.NativeClassPtr, "ImageManagerInstance");
			Discord.NativeFieldInfoPtr_ActivityEventsPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord>.NativeClassPtr, "ActivityEventsPtr");
			Discord.NativeFieldInfoPtr_ActivityEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord>.NativeClassPtr, "ActivityEvents");
			Discord.NativeFieldInfoPtr_ActivityManagerInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord>.NativeClassPtr, "ActivityManagerInstance");
			Discord.NativeFieldInfoPtr_RelationshipEventsPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord>.NativeClassPtr, "RelationshipEventsPtr");
			Discord.NativeFieldInfoPtr_RelationshipEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord>.NativeClassPtr, "RelationshipEvents");
			Discord.NativeFieldInfoPtr_RelationshipManagerInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord>.NativeClassPtr, "RelationshipManagerInstance");
			Discord.NativeFieldInfoPtr_LobbyEventsPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord>.NativeClassPtr, "LobbyEventsPtr");
			Discord.NativeFieldInfoPtr_LobbyEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord>.NativeClassPtr, "LobbyEvents");
			Discord.NativeFieldInfoPtr_LobbyManagerInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord>.NativeClassPtr, "LobbyManagerInstance");
			Discord.NativeFieldInfoPtr_NetworkEventsPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord>.NativeClassPtr, "NetworkEventsPtr");
			Discord.NativeFieldInfoPtr_NetworkEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord>.NativeClassPtr, "NetworkEvents");
			Discord.NativeFieldInfoPtr_NetworkManagerInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord>.NativeClassPtr, "NetworkManagerInstance");
			Discord.NativeFieldInfoPtr_OverlayEventsPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord>.NativeClassPtr, "OverlayEventsPtr");
			Discord.NativeFieldInfoPtr_OverlayEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord>.NativeClassPtr, "OverlayEvents");
			Discord.NativeFieldInfoPtr_OverlayManagerInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord>.NativeClassPtr, "OverlayManagerInstance");
			Discord.NativeFieldInfoPtr_StorageEventsPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord>.NativeClassPtr, "StorageEventsPtr");
			Discord.NativeFieldInfoPtr_StorageEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord>.NativeClassPtr, "StorageEvents");
			Discord.NativeFieldInfoPtr_StorageManagerInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord>.NativeClassPtr, "StorageManagerInstance");
			Discord.NativeFieldInfoPtr_StoreEventsPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord>.NativeClassPtr, "StoreEventsPtr");
			Discord.NativeFieldInfoPtr_StoreEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord>.NativeClassPtr, "StoreEvents");
			Discord.NativeFieldInfoPtr_StoreManagerInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord>.NativeClassPtr, "StoreManagerInstance");
			Discord.NativeFieldInfoPtr_VoiceEventsPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord>.NativeClassPtr, "VoiceEventsPtr");
			Discord.NativeFieldInfoPtr_VoiceEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord>.NativeClassPtr, "VoiceEvents");
			Discord.NativeFieldInfoPtr_VoiceManagerInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord>.NativeClassPtr, "VoiceManagerInstance");
			Discord.NativeFieldInfoPtr_AchievementEventsPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord>.NativeClassPtr, "AchievementEventsPtr");
			Discord.NativeFieldInfoPtr_AchievementEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord>.NativeClassPtr, "AchievementEvents");
			Discord.NativeFieldInfoPtr_AchievementManagerInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord>.NativeClassPtr, "AchievementManagerInstance");
			Discord.NativeFieldInfoPtr_MethodsPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord>.NativeClassPtr, "MethodsPtr");
			Discord.NativeFieldInfoPtr_MethodsStructure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord>.NativeClassPtr, "MethodsStructure");
			Discord.NativeFieldInfoPtr_setLogHook = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord>.NativeClassPtr, "setLogHook");
			Discord.NativeMethodInfoPtr_get_Methods_Private_get_FFIMethods_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord>.NativeClassPtr, 100667382);
			Discord.NativeMethodInfoPtr__ctor_Public_Void_Int64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord>.NativeClassPtr, 100667383);
			Discord.NativeMethodInfoPtr_DiscordCreate_Private_Static_Result_UInt32_byref_FFICreateParams_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord>.NativeClassPtr, 100667381);
			Discord.NativeMethodInfoPtr_InitEvents_Private_Void_IntPtr_byref_FFIEvents_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord>.NativeClassPtr, 100667384);
			Discord.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord>.NativeClassPtr, 100667385);
			Discord.NativeMethodInfoPtr_RunCallbacks_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord>.NativeClassPtr, 100667386);
			Discord.NativeMethodInfoPtr_SetLogHookCallbackImpl_Private_Static_Void_IntPtr_LogLevel_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord>.NativeClassPtr, 100667387);
			Discord.NativeMethodInfoPtr_SetLogHook_Public_Void_LogLevel_SetLogHookHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord>.NativeClassPtr, 100667388);
			Discord.NativeMethodInfoPtr_GetApplicationManager_Public_ApplicationManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord>.NativeClassPtr, 100667389);
			Discord.NativeMethodInfoPtr_GetUserManager_Public_UserManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord>.NativeClassPtr, 100667390);
			Discord.NativeMethodInfoPtr_GetImageManager_Public_ImageManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord>.NativeClassPtr, 100667391);
			Discord.NativeMethodInfoPtr_GetActivityManager_Public_ActivityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord>.NativeClassPtr, 100667392);
			Discord.NativeMethodInfoPtr_GetRelationshipManager_Public_RelationshipManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord>.NativeClassPtr, 100667393);
			Discord.NativeMethodInfoPtr_GetLobbyManager_Public_LobbyManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord>.NativeClassPtr, 100667394);
			Discord.NativeMethodInfoPtr_GetNetworkManager_Public_NetworkManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord>.NativeClassPtr, 100667395);
			Discord.NativeMethodInfoPtr_GetOverlayManager_Public_OverlayManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord>.NativeClassPtr, 100667396);
			Discord.NativeMethodInfoPtr_GetStorageManager_Public_StorageManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord>.NativeClassPtr, 100667397);
			Discord.NativeMethodInfoPtr_GetStoreManager_Public_StoreManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord>.NativeClassPtr, 100667398);
			Discord.NativeMethodInfoPtr_GetVoiceManager_Public_VoiceManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord>.NativeClassPtr, 100667399);
			Discord.NativeMethodInfoPtr_GetAchievementManager_Public_AchievementManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord>.NativeClassPtr, 100667400);
		}

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x060016C1 RID: 5825 RVA: 0x00073F28 File Offset: 0x00072128
		public unsafe Discord.FFIMethods Methods
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 52359, RefRangeEnd = 52374, XrefRangeStart = 52346, XrefRangeEnd = 52359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.NativeMethodInfoPtr_get_Methods_Private_get_FFIMethods_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Discord.FFIMethods(intPtr);
			}
		}

		// Token: 0x060016C2 RID: 5826 RVA: 0x00073F60 File Offset: 0x00072160
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 52440, RefRangeEnd = 52441, XrefRangeStart = 52374, XrefRangeEnd = 52440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Discord(long clientId, ulong flags)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Discord>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clientId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.NativeMethodInfoPtr__ctor_Public_Void_Int64_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016C3 RID: 5827 RVA: 0x00073FB8 File Offset: 0x000721B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52441, XrefRangeEnd = 52443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Result DiscordCreate(uint version, ref Discord.FFICreateParams createParams, out IntPtr manager)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref version;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &createParams;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &manager;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.NativeMethodInfoPtr_DiscordCreate_Private_Static_Result_UInt32_byref_FFICreateParams_byref_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
		}

		// Token: 0x060016C4 RID: 5828 RVA: 0x00074014 File Offset: 0x00072214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52443, XrefRangeEnd = 52449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitEvents(IntPtr eventsPtr, ref Discord.FFIEvents events)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventsPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &events;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.NativeMethodInfoPtr_InitEvents_Private_Void_IntPtr_byref_FFIEvents_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016C5 RID: 5829 RVA: 0x00074060 File Offset: 0x00072260
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 52472, RefRangeEnd = 52473, XrefRangeStart = 52449, XrefRangeEnd = 52472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016C6 RID: 5830 RVA: 0x00074094 File Offset: 0x00072294
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 52474, RefRangeEnd = 52475, XrefRangeStart = 52473, XrefRangeEnd = 52474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RunCallbacks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.NativeMethodInfoPtr_RunCallbacks_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016C7 RID: 5831 RVA: 0x000740C8 File Offset: 0x000722C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52475, XrefRangeEnd = 52489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetLogHookCallbackImpl(IntPtr ptr, LogLevel level, string message)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(level);
			ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.NativeMethodInfoPtr_SetLogHookCallbackImpl_Private_Static_Void_IntPtr_LogLevel_String_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016C8 RID: 5832 RVA: 0x00074120 File Offset: 0x00072320
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52489, XrefRangeEnd = 52510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLogHook(LogLevel minLevel, Discord.SetLogHookHandler callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(minLevel);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.NativeMethodInfoPtr_SetLogHook_Public_Void_LogLevel_SetLogHookHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016C9 RID: 5833 RVA: 0x00074174 File Offset: 0x00072374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52510, XrefRangeEnd = 52522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ApplicationManager GetApplicationManager()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.NativeMethodInfoPtr_GetApplicationManager_Public_ApplicationManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ApplicationManager>(intPtr3) : null;
		}

		// Token: 0x060016CA RID: 5834 RVA: 0x000741B4 File Offset: 0x000723B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52522, XrefRangeEnd = 52543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UserManager GetUserManager()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.NativeMethodInfoPtr_GetUserManager_Public_UserManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UserManager>(intPtr3) : null;
		}

		// Token: 0x060016CB RID: 5835 RVA: 0x000741F4 File Offset: 0x000723F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52543, XrefRangeEnd = 52555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ImageManager GetImageManager()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.NativeMethodInfoPtr_GetImageManager_Public_ImageManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ImageManager>(intPtr3) : null;
		}

		// Token: 0x060016CC RID: 5836 RVA: 0x00074234 File Offset: 0x00072434
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 52562, RefRangeEnd = 52563, XrefRangeStart = 52555, XrefRangeEnd = 52562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActivityManager GetActivityManager()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.NativeMethodInfoPtr_GetActivityManager_Public_ActivityManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ActivityManager>(intPtr3) : null;
		}

		// Token: 0x060016CD RID: 5837 RVA: 0x00074274 File Offset: 0x00072474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52563, XrefRangeEnd = 52570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RelationshipManager GetRelationshipManager()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.NativeMethodInfoPtr_GetRelationshipManager_Public_RelationshipManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RelationshipManager>(intPtr3) : null;
		}

		// Token: 0x060016CE RID: 5838 RVA: 0x000742B4 File Offset: 0x000724B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52570, XrefRangeEnd = 52577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LobbyManager GetLobbyManager()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.NativeMethodInfoPtr_GetLobbyManager_Public_LobbyManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LobbyManager>(intPtr3) : null;
		}

		// Token: 0x060016CF RID: 5839 RVA: 0x000742F4 File Offset: 0x000724F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52577, XrefRangeEnd = 52583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NetworkManager GetNetworkManager()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.NativeMethodInfoPtr_GetNetworkManager_Public_NetworkManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkManager>(intPtr3) : null;
		}

		// Token: 0x060016D0 RID: 5840 RVA: 0x00074334 File Offset: 0x00072534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52583, XrefRangeEnd = 52589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OverlayManager GetOverlayManager()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.NativeMethodInfoPtr_GetOverlayManager_Public_OverlayManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<OverlayManager>(intPtr3) : null;
		}

		// Token: 0x060016D1 RID: 5841 RVA: 0x00074374 File Offset: 0x00072574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52589, XrefRangeEnd = 52595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StorageManager GetStorageManager()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.NativeMethodInfoPtr_GetStorageManager_Public_StorageManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StorageManager>(intPtr3) : null;
		}

		// Token: 0x060016D2 RID: 5842 RVA: 0x000743B4 File Offset: 0x000725B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52595, XrefRangeEnd = 52601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StoreManager GetStoreManager()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.NativeMethodInfoPtr_GetStoreManager_Public_StoreManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StoreManager>(intPtr3) : null;
		}

		// Token: 0x060016D3 RID: 5843 RVA: 0x000743F4 File Offset: 0x000725F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52601, XrefRangeEnd = 52607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VoiceManager GetVoiceManager()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.NativeMethodInfoPtr_GetVoiceManager_Public_VoiceManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VoiceManager>(intPtr3) : null;
		}

		// Token: 0x060016D4 RID: 5844 RVA: 0x00074434 File Offset: 0x00072634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52607, XrefRangeEnd = 52613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AchievementManager GetAchievementManager()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.NativeMethodInfoPtr_GetAchievementManager_Public_AchievementManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AchievementManager>(intPtr3) : null;
		}

		// Token: 0x060016D5 RID: 5845 RVA: 0x00008FD9 File Offset: 0x000071D9
		public Discord(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x060016D6 RID: 5846 RVA: 0x00074474 File Offset: 0x00072674
		// (set) Token: 0x060016D7 RID: 5847 RVA: 0x00008FE2 File Offset: 0x000071E2
		public unsafe GCHandle SelfHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_SelfHandle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GCHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_SelfHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x060016D8 RID: 5848 RVA: 0x000744A4 File Offset: 0x000726A4
		// (set) Token: 0x060016D9 RID: 5849 RVA: 0x00009001 File Offset: 0x00007201
		public unsafe IntPtr EventsPtr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_EventsPtr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_EventsPtr)) = value;
			}
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x060016DA RID: 5850 RVA: 0x000744CC File Offset: 0x000726CC
		// (set) Token: 0x060016DB RID: 5851 RVA: 0x0000901C File Offset: 0x0000721C
		public unsafe Discord.FFIEvents Events
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_Events);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_Events)) = value;
			}
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x060016DC RID: 5852 RVA: 0x000744F4 File Offset: 0x000726F4
		// (set) Token: 0x060016DD RID: 5853 RVA: 0x00009037 File Offset: 0x00007237
		public unsafe IntPtr ApplicationEventsPtr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_ApplicationEventsPtr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_ApplicationEventsPtr)) = value;
			}
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x060016DE RID: 5854 RVA: 0x0007451C File Offset: 0x0007271C
		// (set) Token: 0x060016DF RID: 5855 RVA: 0x00009052 File Offset: 0x00007252
		public unsafe ApplicationManager.FFIEvents ApplicationEvents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_ApplicationEvents);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_ApplicationEvents)) = value;
			}
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x060016E0 RID: 5856 RVA: 0x00074544 File Offset: 0x00072744
		// (set) Token: 0x060016E1 RID: 5857 RVA: 0x0000906D File Offset: 0x0000726D
		public unsafe ApplicationManager ApplicationManagerInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_ApplicationManagerInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ApplicationManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_ApplicationManagerInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x060016E2 RID: 5858 RVA: 0x00074574 File Offset: 0x00072774
		// (set) Token: 0x060016E3 RID: 5859 RVA: 0x0000908C File Offset: 0x0000728C
		public unsafe IntPtr UserEventsPtr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_UserEventsPtr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_UserEventsPtr)) = value;
			}
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x060016E4 RID: 5860 RVA: 0x0007459C File Offset: 0x0007279C
		// (set) Token: 0x060016E5 RID: 5861 RVA: 0x000090A7 File Offset: 0x000072A7
		public UserManager.FFIEvents UserEvents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_UserEvents);
				return new UserManager.FFIEvents(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UserManager.FFIEvents>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_UserEvents), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UserManager.FFIEvents>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x060016E6 RID: 5862 RVA: 0x000745CC File Offset: 0x000727CC
		// (set) Token: 0x060016E7 RID: 5863 RVA: 0x000090D5 File Offset: 0x000072D5
		public unsafe UserManager UserManagerInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_UserManagerInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UserManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_UserManagerInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x060016E8 RID: 5864 RVA: 0x000745FC File Offset: 0x000727FC
		// (set) Token: 0x060016E9 RID: 5865 RVA: 0x000090F4 File Offset: 0x000072F4
		public unsafe IntPtr ImageEventsPtr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_ImageEventsPtr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_ImageEventsPtr)) = value;
			}
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x060016EA RID: 5866 RVA: 0x00074624 File Offset: 0x00072824
		// (set) Token: 0x060016EB RID: 5867 RVA: 0x0000910F File Offset: 0x0000730F
		public unsafe ImageManager.FFIEvents ImageEvents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_ImageEvents);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_ImageEvents)) = value;
			}
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x060016EC RID: 5868 RVA: 0x0007464C File Offset: 0x0007284C
		// (set) Token: 0x060016ED RID: 5869 RVA: 0x0000912A File Offset: 0x0000732A
		public unsafe ImageManager ImageManagerInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_ImageManagerInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ImageManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_ImageManagerInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x060016EE RID: 5870 RVA: 0x0007467C File Offset: 0x0007287C
		// (set) Token: 0x060016EF RID: 5871 RVA: 0x00009149 File Offset: 0x00007349
		public unsafe IntPtr ActivityEventsPtr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_ActivityEventsPtr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_ActivityEventsPtr)) = value;
			}
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x060016F0 RID: 5872 RVA: 0x000746A4 File Offset: 0x000728A4
		// (set) Token: 0x060016F1 RID: 5873 RVA: 0x00009164 File Offset: 0x00007364
		public ActivityManager.FFIEvents ActivityEvents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_ActivityEvents);
				return new ActivityManager.FFIEvents(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ActivityManager.FFIEvents>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_ActivityEvents), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ActivityManager.FFIEvents>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x060016F2 RID: 5874 RVA: 0x000746D4 File Offset: 0x000728D4
		// (set) Token: 0x060016F3 RID: 5875 RVA: 0x00009192 File Offset: 0x00007392
		public unsafe ActivityManager ActivityManagerInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_ActivityManagerInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActivityManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_ActivityManagerInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x060016F4 RID: 5876 RVA: 0x00074704 File Offset: 0x00072904
		// (set) Token: 0x060016F5 RID: 5877 RVA: 0x000091B1 File Offset: 0x000073B1
		public unsafe IntPtr RelationshipEventsPtr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_RelationshipEventsPtr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_RelationshipEventsPtr)) = value;
			}
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x060016F6 RID: 5878 RVA: 0x0007472C File Offset: 0x0007292C
		// (set) Token: 0x060016F7 RID: 5879 RVA: 0x000091CC File Offset: 0x000073CC
		public RelationshipManager.FFIEvents RelationshipEvents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_RelationshipEvents);
				return new RelationshipManager.FFIEvents(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RelationshipManager.FFIEvents>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_RelationshipEvents), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RelationshipManager.FFIEvents>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x060016F8 RID: 5880 RVA: 0x0007475C File Offset: 0x0007295C
		// (set) Token: 0x060016F9 RID: 5881 RVA: 0x000091FA File Offset: 0x000073FA
		public unsafe RelationshipManager RelationshipManagerInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_RelationshipManagerInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RelationshipManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_RelationshipManagerInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x060016FA RID: 5882 RVA: 0x0007478C File Offset: 0x0007298C
		// (set) Token: 0x060016FB RID: 5883 RVA: 0x00009219 File Offset: 0x00007419
		public unsafe IntPtr LobbyEventsPtr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_LobbyEventsPtr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_LobbyEventsPtr)) = value;
			}
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x060016FC RID: 5884 RVA: 0x000747B4 File Offset: 0x000729B4
		// (set) Token: 0x060016FD RID: 5885 RVA: 0x00009234 File Offset: 0x00007434
		public LobbyManager.FFIEvents LobbyEvents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_LobbyEvents);
				return new LobbyManager.FFIEvents(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LobbyManager.FFIEvents>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_LobbyEvents), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LobbyManager.FFIEvents>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x060016FE RID: 5886 RVA: 0x000747E4 File Offset: 0x000729E4
		// (set) Token: 0x060016FF RID: 5887 RVA: 0x00009262 File Offset: 0x00007462
		public unsafe LobbyManager LobbyManagerInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_LobbyManagerInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LobbyManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_LobbyManagerInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06001700 RID: 5888 RVA: 0x00074814 File Offset: 0x00072A14
		// (set) Token: 0x06001701 RID: 5889 RVA: 0x00009281 File Offset: 0x00007481
		public unsafe IntPtr NetworkEventsPtr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_NetworkEventsPtr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_NetworkEventsPtr)) = value;
			}
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x06001702 RID: 5890 RVA: 0x0007483C File Offset: 0x00072A3C
		// (set) Token: 0x06001703 RID: 5891 RVA: 0x0000929C File Offset: 0x0000749C
		public NetworkManager.FFIEvents NetworkEvents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_NetworkEvents);
				return new NetworkManager.FFIEvents(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NetworkManager.FFIEvents>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_NetworkEvents), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NetworkManager.FFIEvents>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x06001704 RID: 5892 RVA: 0x0007486C File Offset: 0x00072A6C
		// (set) Token: 0x06001705 RID: 5893 RVA: 0x000092CA File Offset: 0x000074CA
		public unsafe NetworkManager NetworkManagerInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_NetworkManagerInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_NetworkManagerInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x06001706 RID: 5894 RVA: 0x0007489C File Offset: 0x00072A9C
		// (set) Token: 0x06001707 RID: 5895 RVA: 0x000092E9 File Offset: 0x000074E9
		public unsafe IntPtr OverlayEventsPtr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_OverlayEventsPtr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_OverlayEventsPtr)) = value;
			}
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x06001708 RID: 5896 RVA: 0x000748C4 File Offset: 0x00072AC4
		// (set) Token: 0x06001709 RID: 5897 RVA: 0x00009304 File Offset: 0x00007504
		public OverlayManager.FFIEvents OverlayEvents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_OverlayEvents);
				return new OverlayManager.FFIEvents(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OverlayManager.FFIEvents>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_OverlayEvents), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<OverlayManager.FFIEvents>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x0600170A RID: 5898 RVA: 0x000748F4 File Offset: 0x00072AF4
		// (set) Token: 0x0600170B RID: 5899 RVA: 0x00009332 File Offset: 0x00007532
		public unsafe OverlayManager OverlayManagerInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_OverlayManagerInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OverlayManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_OverlayManagerInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x0600170C RID: 5900 RVA: 0x00074924 File Offset: 0x00072B24
		// (set) Token: 0x0600170D RID: 5901 RVA: 0x00009351 File Offset: 0x00007551
		public unsafe IntPtr StorageEventsPtr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_StorageEventsPtr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_StorageEventsPtr)) = value;
			}
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x0600170E RID: 5902 RVA: 0x0007494C File Offset: 0x00072B4C
		// (set) Token: 0x0600170F RID: 5903 RVA: 0x0000936C File Offset: 0x0000756C
		public unsafe StorageManager.FFIEvents StorageEvents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_StorageEvents);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_StorageEvents)) = value;
			}
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06001710 RID: 5904 RVA: 0x00074974 File Offset: 0x00072B74
		// (set) Token: 0x06001711 RID: 5905 RVA: 0x00009387 File Offset: 0x00007587
		public unsafe StorageManager StorageManagerInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_StorageManagerInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_StorageManagerInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06001712 RID: 5906 RVA: 0x000749A4 File Offset: 0x00072BA4
		// (set) Token: 0x06001713 RID: 5907 RVA: 0x000093A6 File Offset: 0x000075A6
		public unsafe IntPtr StoreEventsPtr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_StoreEventsPtr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_StoreEventsPtr)) = value;
			}
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06001714 RID: 5908 RVA: 0x000749CC File Offset: 0x00072BCC
		// (set) Token: 0x06001715 RID: 5909 RVA: 0x000093C1 File Offset: 0x000075C1
		public StoreManager.FFIEvents StoreEvents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_StoreEvents);
				return new StoreManager.FFIEvents(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StoreManager.FFIEvents>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_StoreEvents), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StoreManager.FFIEvents>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x06001716 RID: 5910 RVA: 0x000749FC File Offset: 0x00072BFC
		// (set) Token: 0x06001717 RID: 5911 RVA: 0x000093EF File Offset: 0x000075EF
		public unsafe StoreManager StoreManagerInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_StoreManagerInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StoreManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_StoreManagerInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x06001718 RID: 5912 RVA: 0x00074A2C File Offset: 0x00072C2C
		// (set) Token: 0x06001719 RID: 5913 RVA: 0x0000940E File Offset: 0x0000760E
		public unsafe IntPtr VoiceEventsPtr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_VoiceEventsPtr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_VoiceEventsPtr)) = value;
			}
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x0600171A RID: 5914 RVA: 0x00074A54 File Offset: 0x00072C54
		// (set) Token: 0x0600171B RID: 5915 RVA: 0x00009429 File Offset: 0x00007629
		public VoiceManager.FFIEvents VoiceEvents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_VoiceEvents);
				return new VoiceManager.FFIEvents(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VoiceManager.FFIEvents>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_VoiceEvents), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<VoiceManager.FFIEvents>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x0600171C RID: 5916 RVA: 0x00074A84 File Offset: 0x00072C84
		// (set) Token: 0x0600171D RID: 5917 RVA: 0x00009457 File Offset: 0x00007657
		public unsafe VoiceManager VoiceManagerInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_VoiceManagerInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VoiceManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_VoiceManagerInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x0600171E RID: 5918 RVA: 0x00074AB4 File Offset: 0x00072CB4
		// (set) Token: 0x0600171F RID: 5919 RVA: 0x00009476 File Offset: 0x00007676
		public unsafe IntPtr AchievementEventsPtr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_AchievementEventsPtr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_AchievementEventsPtr)) = value;
			}
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x06001720 RID: 5920 RVA: 0x00074ADC File Offset: 0x00072CDC
		// (set) Token: 0x06001721 RID: 5921 RVA: 0x00009491 File Offset: 0x00007691
		public AchievementManager.FFIEvents AchievementEvents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_AchievementEvents);
				return new AchievementManager.FFIEvents(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AchievementManager.FFIEvents>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_AchievementEvents), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AchievementManager.FFIEvents>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x06001722 RID: 5922 RVA: 0x00074B0C File Offset: 0x00072D0C
		// (set) Token: 0x06001723 RID: 5923 RVA: 0x000094BF File Offset: 0x000076BF
		public unsafe AchievementManager AchievementManagerInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_AchievementManagerInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AchievementManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_AchievementManagerInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x06001724 RID: 5924 RVA: 0x00074B3C File Offset: 0x00072D3C
		// (set) Token: 0x06001725 RID: 5925 RVA: 0x000094DE File Offset: 0x000076DE
		public unsafe IntPtr MethodsPtr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_MethodsPtr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_MethodsPtr)) = value;
			}
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x06001726 RID: 5926 RVA: 0x00074B64 File Offset: 0x00072D64
		// (set) Token: 0x06001727 RID: 5927 RVA: 0x000094F9 File Offset: 0x000076F9
		public unsafe Object MethodsStructure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_MethodsStructure);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_MethodsStructure), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x06001728 RID: 5928 RVA: 0x00074B94 File Offset: 0x00072D94
		// (set) Token: 0x06001729 RID: 5929 RVA: 0x00009518 File Offset: 0x00007718
		public unsafe Nullable<GCHandle> setLogHook
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_setLogHook);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Nullable<GCHandle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.NativeFieldInfoPtr_setLogHook), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001300 RID: 4864
		private static readonly IntPtr NativeFieldInfoPtr_SelfHandle;

		// Token: 0x04001301 RID: 4865
		private static readonly IntPtr NativeFieldInfoPtr_EventsPtr;

		// Token: 0x04001302 RID: 4866
		private static readonly IntPtr NativeFieldInfoPtr_Events;

		// Token: 0x04001303 RID: 4867
		private static readonly IntPtr NativeFieldInfoPtr_ApplicationEventsPtr;

		// Token: 0x04001304 RID: 4868
		private static readonly IntPtr NativeFieldInfoPtr_ApplicationEvents;

		// Token: 0x04001305 RID: 4869
		private static readonly IntPtr NativeFieldInfoPtr_ApplicationManagerInstance;

		// Token: 0x04001306 RID: 4870
		private static readonly IntPtr NativeFieldInfoPtr_UserEventsPtr;

		// Token: 0x04001307 RID: 4871
		private static readonly IntPtr NativeFieldInfoPtr_UserEvents;

		// Token: 0x04001308 RID: 4872
		private static readonly IntPtr NativeFieldInfoPtr_UserManagerInstance;

		// Token: 0x04001309 RID: 4873
		private static readonly IntPtr NativeFieldInfoPtr_ImageEventsPtr;

		// Token: 0x0400130A RID: 4874
		private static readonly IntPtr NativeFieldInfoPtr_ImageEvents;

		// Token: 0x0400130B RID: 4875
		private static readonly IntPtr NativeFieldInfoPtr_ImageManagerInstance;

		// Token: 0x0400130C RID: 4876
		private static readonly IntPtr NativeFieldInfoPtr_ActivityEventsPtr;

		// Token: 0x0400130D RID: 4877
		private static readonly IntPtr NativeFieldInfoPtr_ActivityEvents;

		// Token: 0x0400130E RID: 4878
		private static readonly IntPtr NativeFieldInfoPtr_ActivityManagerInstance;

		// Token: 0x0400130F RID: 4879
		private static readonly IntPtr NativeFieldInfoPtr_RelationshipEventsPtr;

		// Token: 0x04001310 RID: 4880
		private static readonly IntPtr NativeFieldInfoPtr_RelationshipEvents;

		// Token: 0x04001311 RID: 4881
		private static readonly IntPtr NativeFieldInfoPtr_RelationshipManagerInstance;

		// Token: 0x04001312 RID: 4882
		private static readonly IntPtr NativeFieldInfoPtr_LobbyEventsPtr;

		// Token: 0x04001313 RID: 4883
		private static readonly IntPtr NativeFieldInfoPtr_LobbyEvents;

		// Token: 0x04001314 RID: 4884
		private static readonly IntPtr NativeFieldInfoPtr_LobbyManagerInstance;

		// Token: 0x04001315 RID: 4885
		private static readonly IntPtr NativeFieldInfoPtr_NetworkEventsPtr;

		// Token: 0x04001316 RID: 4886
		private static readonly IntPtr NativeFieldInfoPtr_NetworkEvents;

		// Token: 0x04001317 RID: 4887
		private static readonly IntPtr NativeFieldInfoPtr_NetworkManagerInstance;

		// Token: 0x04001318 RID: 4888
		private static readonly IntPtr NativeFieldInfoPtr_OverlayEventsPtr;

		// Token: 0x04001319 RID: 4889
		private static readonly IntPtr NativeFieldInfoPtr_OverlayEvents;

		// Token: 0x0400131A RID: 4890
		private static readonly IntPtr NativeFieldInfoPtr_OverlayManagerInstance;

		// Token: 0x0400131B RID: 4891
		private static readonly IntPtr NativeFieldInfoPtr_StorageEventsPtr;

		// Token: 0x0400131C RID: 4892
		private static readonly IntPtr NativeFieldInfoPtr_StorageEvents;

		// Token: 0x0400131D RID: 4893
		private static readonly IntPtr NativeFieldInfoPtr_StorageManagerInstance;

		// Token: 0x0400131E RID: 4894
		private static readonly IntPtr NativeFieldInfoPtr_StoreEventsPtr;

		// Token: 0x0400131F RID: 4895
		private static readonly IntPtr NativeFieldInfoPtr_StoreEvents;

		// Token: 0x04001320 RID: 4896
		private static readonly IntPtr NativeFieldInfoPtr_StoreManagerInstance;

		// Token: 0x04001321 RID: 4897
		private static readonly IntPtr NativeFieldInfoPtr_VoiceEventsPtr;

		// Token: 0x04001322 RID: 4898
		private static readonly IntPtr NativeFieldInfoPtr_VoiceEvents;

		// Token: 0x04001323 RID: 4899
		private static readonly IntPtr NativeFieldInfoPtr_VoiceManagerInstance;

		// Token: 0x04001324 RID: 4900
		private static readonly IntPtr NativeFieldInfoPtr_AchievementEventsPtr;

		// Token: 0x04001325 RID: 4901
		private static readonly IntPtr NativeFieldInfoPtr_AchievementEvents;

		// Token: 0x04001326 RID: 4902
		private static readonly IntPtr NativeFieldInfoPtr_AchievementManagerInstance;

		// Token: 0x04001327 RID: 4903
		private static readonly IntPtr NativeFieldInfoPtr_MethodsPtr;

		// Token: 0x04001328 RID: 4904
		private static readonly IntPtr NativeFieldInfoPtr_MethodsStructure;

		// Token: 0x04001329 RID: 4905
		private static readonly IntPtr NativeFieldInfoPtr_setLogHook;

		// Token: 0x0400132A RID: 4906
		private static readonly IntPtr NativeMethodInfoPtr_get_Methods_Private_get_FFIMethods_0;

		// Token: 0x0400132B RID: 4907
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int64_UInt64_0;

		// Token: 0x0400132C RID: 4908
		private static readonly IntPtr NativeMethodInfoPtr_DiscordCreate_Private_Static_Result_UInt32_byref_FFICreateParams_byref_IntPtr_0;

		// Token: 0x0400132D RID: 4909
		private static readonly IntPtr NativeMethodInfoPtr_InitEvents_Private_Void_IntPtr_byref_FFIEvents_0;

		// Token: 0x0400132E RID: 4910
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400132F RID: 4911
		private static readonly IntPtr NativeMethodInfoPtr_RunCallbacks_Public_Void_0;

		// Token: 0x04001330 RID: 4912
		private static readonly IntPtr NativeMethodInfoPtr_SetLogHookCallbackImpl_Private_Static_Void_IntPtr_LogLevel_String_0;

		// Token: 0x04001331 RID: 4913
		private static readonly IntPtr NativeMethodInfoPtr_SetLogHook_Public_Void_LogLevel_SetLogHookHandler_0;

		// Token: 0x04001332 RID: 4914
		private static readonly IntPtr NativeMethodInfoPtr_GetApplicationManager_Public_ApplicationManager_0;

		// Token: 0x04001333 RID: 4915
		private static readonly IntPtr NativeMethodInfoPtr_GetUserManager_Public_UserManager_0;

		// Token: 0x04001334 RID: 4916
		private static readonly IntPtr NativeMethodInfoPtr_GetImageManager_Public_ImageManager_0;

		// Token: 0x04001335 RID: 4917
		private static readonly IntPtr NativeMethodInfoPtr_GetActivityManager_Public_ActivityManager_0;

		// Token: 0x04001336 RID: 4918
		private static readonly IntPtr NativeMethodInfoPtr_GetRelationshipManager_Public_RelationshipManager_0;

		// Token: 0x04001337 RID: 4919
		private static readonly IntPtr NativeMethodInfoPtr_GetLobbyManager_Public_LobbyManager_0;

		// Token: 0x04001338 RID: 4920
		private static readonly IntPtr NativeMethodInfoPtr_GetNetworkManager_Public_NetworkManager_0;

		// Token: 0x04001339 RID: 4921
		private static readonly IntPtr NativeMethodInfoPtr_GetOverlayManager_Public_OverlayManager_0;

		// Token: 0x0400133A RID: 4922
		private static readonly IntPtr NativeMethodInfoPtr_GetStorageManager_Public_StorageManager_0;

		// Token: 0x0400133B RID: 4923
		private static readonly IntPtr NativeMethodInfoPtr_GetStoreManager_Public_StoreManager_0;

		// Token: 0x0400133C RID: 4924
		private static readonly IntPtr NativeMethodInfoPtr_GetVoiceManager_Public_VoiceManager_0;

		// Token: 0x0400133D RID: 4925
		private static readonly IntPtr NativeMethodInfoPtr_GetAchievementManager_Public_AchievementManager_0;

		// Token: 0x02000200 RID: 512
		[StructLayout(2)]
		public struct FFIEvents
		{
			// Token: 0x06001E66 RID: 7782 RVA: 0x0000C26D File Offset: 0x0000A46D
			// Note: this type is marked as 'beforefieldinit'.
			static FFIEvents()
			{
				Il2CppClassPointerStore<Discord.FFIEvents>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Discord>.NativeClassPtr, "FFIEvents");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Discord.FFIEvents>.NativeClassPtr);
			}

			// Token: 0x06001E67 RID: 7783 RVA: 0x0000C28D File Offset: 0x0000A48D
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Discord.FFIEvents>.NativeClassPtr, ref this));
			}
		}

		// Token: 0x02000201 RID: 513
		public sealed class FFIMethods : ValueType
		{
			// Token: 0x06001E68 RID: 7784 RVA: 0x0008F5F0 File Offset: 0x0008D7F0
			// Note: this type is marked as 'beforefieldinit'.
			static FFIMethods()
			{
				Il2CppClassPointerStore<Discord.FFIMethods>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Discord>.NativeClassPtr, "FFIMethods");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Discord.FFIMethods>.NativeClassPtr);
				Discord.FFIMethods.NativeFieldInfoPtr_Destroy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord.FFIMethods>.NativeClassPtr, "Destroy");
				Discord.FFIMethods.NativeFieldInfoPtr_RunCallbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord.FFIMethods>.NativeClassPtr, "RunCallbacks");
				Discord.FFIMethods.NativeFieldInfoPtr_SetLogHook = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord.FFIMethods>.NativeClassPtr, "SetLogHook");
				Discord.FFIMethods.NativeFieldInfoPtr_GetApplicationManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord.FFIMethods>.NativeClassPtr, "GetApplicationManager");
				Discord.FFIMethods.NativeFieldInfoPtr_GetUserManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord.FFIMethods>.NativeClassPtr, "GetUserManager");
				Discord.FFIMethods.NativeFieldInfoPtr_GetImageManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord.FFIMethods>.NativeClassPtr, "GetImageManager");
				Discord.FFIMethods.NativeFieldInfoPtr_GetActivityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord.FFIMethods>.NativeClassPtr, "GetActivityManager");
				Discord.FFIMethods.NativeFieldInfoPtr_GetRelationshipManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord.FFIMethods>.NativeClassPtr, "GetRelationshipManager");
				Discord.FFIMethods.NativeFieldInfoPtr_GetLobbyManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord.FFIMethods>.NativeClassPtr, "GetLobbyManager");
				Discord.FFIMethods.NativeFieldInfoPtr_GetNetworkManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord.FFIMethods>.NativeClassPtr, "GetNetworkManager");
				Discord.FFIMethods.NativeFieldInfoPtr_GetOverlayManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord.FFIMethods>.NativeClassPtr, "GetOverlayManager");
				Discord.FFIMethods.NativeFieldInfoPtr_GetStorageManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord.FFIMethods>.NativeClassPtr, "GetStorageManager");
				Discord.FFIMethods.NativeFieldInfoPtr_GetStoreManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord.FFIMethods>.NativeClassPtr, "GetStoreManager");
				Discord.FFIMethods.NativeFieldInfoPtr_GetVoiceManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord.FFIMethods>.NativeClassPtr, "GetVoiceManager");
				Discord.FFIMethods.NativeFieldInfoPtr_GetAchievementManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord.FFIMethods>.NativeClassPtr, "GetAchievementManager");
			}

			// Token: 0x06001E69 RID: 7785 RVA: 0x0000C29F File Offset: 0x0000A49F
			public FFIMethods(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001E6A RID: 7786 RVA: 0x0000C2A8 File Offset: 0x0000A4A8
			public FFIMethods()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Discord.FFIMethods>.NativeClassPtr))
			{
			}

			// Token: 0x17000700 RID: 1792
			// (get) Token: 0x06001E6B RID: 7787 RVA: 0x0008F748 File Offset: 0x0008D948
			// (set) Token: 0x06001E6C RID: 7788 RVA: 0x0000C2BA File Offset: 0x0000A4BA
			public unsafe Discord.FFIMethods.DestroyHandler Destroy
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.FFIMethods.NativeFieldInfoPtr_Destroy);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Discord.FFIMethods.DestroyHandler>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.FFIMethods.NativeFieldInfoPtr_Destroy), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000701 RID: 1793
			// (get) Token: 0x06001E6D RID: 7789 RVA: 0x0008F778 File Offset: 0x0008D978
			// (set) Token: 0x06001E6E RID: 7790 RVA: 0x0000C2D9 File Offset: 0x0000A4D9
			public unsafe Discord.FFIMethods.RunCallbacksMethod RunCallbacks
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.FFIMethods.NativeFieldInfoPtr_RunCallbacks);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Discord.FFIMethods.RunCallbacksMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.FFIMethods.NativeFieldInfoPtr_RunCallbacks), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000702 RID: 1794
			// (get) Token: 0x06001E6F RID: 7791 RVA: 0x0008F7A8 File Offset: 0x0008D9A8
			// (set) Token: 0x06001E70 RID: 7792 RVA: 0x0000C2F8 File Offset: 0x0000A4F8
			public unsafe Discord.FFIMethods.SetLogHookMethod SetLogHook
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.FFIMethods.NativeFieldInfoPtr_SetLogHook);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Discord.FFIMethods.SetLogHookMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.FFIMethods.NativeFieldInfoPtr_SetLogHook), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000703 RID: 1795
			// (get) Token: 0x06001E71 RID: 7793 RVA: 0x0008F7D8 File Offset: 0x0008D9D8
			// (set) Token: 0x06001E72 RID: 7794 RVA: 0x0000C317 File Offset: 0x0000A517
			public unsafe Discord.FFIMethods.GetApplicationManagerMethod GetApplicationManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.FFIMethods.NativeFieldInfoPtr_GetApplicationManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Discord.FFIMethods.GetApplicationManagerMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.FFIMethods.NativeFieldInfoPtr_GetApplicationManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000704 RID: 1796
			// (get) Token: 0x06001E73 RID: 7795 RVA: 0x0008F808 File Offset: 0x0008DA08
			// (set) Token: 0x06001E74 RID: 7796 RVA: 0x0000C336 File Offset: 0x0000A536
			public unsafe Discord.FFIMethods.GetUserManagerMethod GetUserManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.FFIMethods.NativeFieldInfoPtr_GetUserManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Discord.FFIMethods.GetUserManagerMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.FFIMethods.NativeFieldInfoPtr_GetUserManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000705 RID: 1797
			// (get) Token: 0x06001E75 RID: 7797 RVA: 0x0008F838 File Offset: 0x0008DA38
			// (set) Token: 0x06001E76 RID: 7798 RVA: 0x0000C355 File Offset: 0x0000A555
			public unsafe Discord.FFIMethods.GetImageManagerMethod GetImageManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.FFIMethods.NativeFieldInfoPtr_GetImageManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Discord.FFIMethods.GetImageManagerMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.FFIMethods.NativeFieldInfoPtr_GetImageManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000706 RID: 1798
			// (get) Token: 0x06001E77 RID: 7799 RVA: 0x0008F868 File Offset: 0x0008DA68
			// (set) Token: 0x06001E78 RID: 7800 RVA: 0x0000C374 File Offset: 0x0000A574
			public unsafe Discord.FFIMethods.GetActivityManagerMethod GetActivityManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.FFIMethods.NativeFieldInfoPtr_GetActivityManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Discord.FFIMethods.GetActivityManagerMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.FFIMethods.NativeFieldInfoPtr_GetActivityManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000707 RID: 1799
			// (get) Token: 0x06001E79 RID: 7801 RVA: 0x0008F898 File Offset: 0x0008DA98
			// (set) Token: 0x06001E7A RID: 7802 RVA: 0x0000C393 File Offset: 0x0000A593
			public unsafe Discord.FFIMethods.GetRelationshipManagerMethod GetRelationshipManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.FFIMethods.NativeFieldInfoPtr_GetRelationshipManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Discord.FFIMethods.GetRelationshipManagerMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.FFIMethods.NativeFieldInfoPtr_GetRelationshipManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000708 RID: 1800
			// (get) Token: 0x06001E7B RID: 7803 RVA: 0x0008F8C8 File Offset: 0x0008DAC8
			// (set) Token: 0x06001E7C RID: 7804 RVA: 0x0000C3B2 File Offset: 0x0000A5B2
			public unsafe Discord.FFIMethods.GetLobbyManagerMethod GetLobbyManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.FFIMethods.NativeFieldInfoPtr_GetLobbyManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Discord.FFIMethods.GetLobbyManagerMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.FFIMethods.NativeFieldInfoPtr_GetLobbyManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000709 RID: 1801
			// (get) Token: 0x06001E7D RID: 7805 RVA: 0x0008F8F8 File Offset: 0x0008DAF8
			// (set) Token: 0x06001E7E RID: 7806 RVA: 0x0000C3D1 File Offset: 0x0000A5D1
			public unsafe Discord.FFIMethods.GetNetworkManagerMethod GetNetworkManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.FFIMethods.NativeFieldInfoPtr_GetNetworkManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Discord.FFIMethods.GetNetworkManagerMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.FFIMethods.NativeFieldInfoPtr_GetNetworkManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700070A RID: 1802
			// (get) Token: 0x06001E7F RID: 7807 RVA: 0x0008F928 File Offset: 0x0008DB28
			// (set) Token: 0x06001E80 RID: 7808 RVA: 0x0000C3F0 File Offset: 0x0000A5F0
			public unsafe Discord.FFIMethods.GetOverlayManagerMethod GetOverlayManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.FFIMethods.NativeFieldInfoPtr_GetOverlayManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Discord.FFIMethods.GetOverlayManagerMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.FFIMethods.NativeFieldInfoPtr_GetOverlayManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700070B RID: 1803
			// (get) Token: 0x06001E81 RID: 7809 RVA: 0x0008F958 File Offset: 0x0008DB58
			// (set) Token: 0x06001E82 RID: 7810 RVA: 0x0000C40F File Offset: 0x0000A60F
			public unsafe Discord.FFIMethods.GetStorageManagerMethod GetStorageManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.FFIMethods.NativeFieldInfoPtr_GetStorageManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Discord.FFIMethods.GetStorageManagerMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.FFIMethods.NativeFieldInfoPtr_GetStorageManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700070C RID: 1804
			// (get) Token: 0x06001E83 RID: 7811 RVA: 0x0008F988 File Offset: 0x0008DB88
			// (set) Token: 0x06001E84 RID: 7812 RVA: 0x0000C42E File Offset: 0x0000A62E
			public unsafe Discord.FFIMethods.GetStoreManagerMethod GetStoreManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.FFIMethods.NativeFieldInfoPtr_GetStoreManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Discord.FFIMethods.GetStoreManagerMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.FFIMethods.NativeFieldInfoPtr_GetStoreManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700070D RID: 1805
			// (get) Token: 0x06001E85 RID: 7813 RVA: 0x0008F9B8 File Offset: 0x0008DBB8
			// (set) Token: 0x06001E86 RID: 7814 RVA: 0x0000C44D File Offset: 0x0000A64D
			public unsafe Discord.FFIMethods.GetVoiceManagerMethod GetVoiceManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.FFIMethods.NativeFieldInfoPtr_GetVoiceManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Discord.FFIMethods.GetVoiceManagerMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.FFIMethods.NativeFieldInfoPtr_GetVoiceManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700070E RID: 1806
			// (get) Token: 0x06001E87 RID: 7815 RVA: 0x0008F9E8 File Offset: 0x0008DBE8
			// (set) Token: 0x06001E88 RID: 7816 RVA: 0x0000C46C File Offset: 0x0000A66C
			public unsafe Discord.FFIMethods.GetAchievementManagerMethod GetAchievementManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.FFIMethods.NativeFieldInfoPtr_GetAchievementManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Discord.FFIMethods.GetAchievementManagerMethod>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Discord.FFIMethods.NativeFieldInfoPtr_GetAchievementManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040017ED RID: 6125
			private static readonly IntPtr NativeFieldInfoPtr_Destroy;

			// Token: 0x040017EE RID: 6126
			private static readonly IntPtr NativeFieldInfoPtr_RunCallbacks;

			// Token: 0x040017EF RID: 6127
			private static readonly IntPtr NativeFieldInfoPtr_SetLogHook;

			// Token: 0x040017F0 RID: 6128
			private static readonly IntPtr NativeFieldInfoPtr_GetApplicationManager;

			// Token: 0x040017F1 RID: 6129
			private static readonly IntPtr NativeFieldInfoPtr_GetUserManager;

			// Token: 0x040017F2 RID: 6130
			private static readonly IntPtr NativeFieldInfoPtr_GetImageManager;

			// Token: 0x040017F3 RID: 6131
			private static readonly IntPtr NativeFieldInfoPtr_GetActivityManager;

			// Token: 0x040017F4 RID: 6132
			private static readonly IntPtr NativeFieldInfoPtr_GetRelationshipManager;

			// Token: 0x040017F5 RID: 6133
			private static readonly IntPtr NativeFieldInfoPtr_GetLobbyManager;

			// Token: 0x040017F6 RID: 6134
			private static readonly IntPtr NativeFieldInfoPtr_GetNetworkManager;

			// Token: 0x040017F7 RID: 6135
			private static readonly IntPtr NativeFieldInfoPtr_GetOverlayManager;

			// Token: 0x040017F8 RID: 6136
			private static readonly IntPtr NativeFieldInfoPtr_GetStorageManager;

			// Token: 0x040017F9 RID: 6137
			private static readonly IntPtr NativeFieldInfoPtr_GetStoreManager;

			// Token: 0x040017FA RID: 6138
			private static readonly IntPtr NativeFieldInfoPtr_GetVoiceManager;

			// Token: 0x040017FB RID: 6139
			private static readonly IntPtr NativeFieldInfoPtr_GetAchievementManager;

			// Token: 0x0200026D RID: 621
			public sealed class DestroyHandler : MulticastDelegate
			{
				// Token: 0x06002275 RID: 8821 RVA: 0x0009BEBC File Offset: 0x0009A0BC
				// Note: this type is marked as 'beforefieldinit'.
				static DestroyHandler()
				{
					Il2CppClassPointerStore<Discord.FFIMethods.DestroyHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Discord.FFIMethods>.NativeClassPtr, "DestroyHandler");
					Discord.FFIMethods.DestroyHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord.FFIMethods.DestroyHandler>.NativeClassPtr, 100667401);
					Discord.FFIMethods.DestroyHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord.FFIMethods.DestroyHandler>.NativeClassPtr, 100667402);
					Discord.FFIMethods.DestroyHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord.FFIMethods.DestroyHandler>.NativeClassPtr, 100667403);
					Discord.FFIMethods.DestroyHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord.FFIMethods.DestroyHandler>.NativeClassPtr, 100667404);
				}

				// Token: 0x06002276 RID: 8822 RVA: 0x0009BF30 File Offset: 0x0009A130
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52282, XrefRangeEnd = 52285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe DestroyHandler(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Discord.FFIMethods.DestroyHandler>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.FFIMethods.DestroyHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002277 RID: 8823 RVA: 0x0009BF8C File Offset: 0x0009A18C
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr MethodsPtr)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref MethodsPtr;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.FFIMethods.DestroyHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06002278 RID: 8824 RVA: 0x0009BFCC File Offset: 0x0009A1CC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52285, XrefRangeEnd = 52288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr MethodsPtr, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref MethodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.FFIMethods.DestroyHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06002279 RID: 8825 RVA: 0x0009C03C File Offset: 0x0009A23C
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.FFIMethods.DestroyHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x0600227A RID: 8826 RVA: 0x0000E504 File Offset: 0x0000C704
				public DestroyHandler(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x0600227B RID: 8827 RVA: 0x0000E50D File Offset: 0x0000C70D
				public static implicit operator Discord.FFIMethods.DestroyHandler(Action<IntPtr> A_0)
				{
					return DelegateSupport.ConvertDelegate<Discord.FFIMethods.DestroyHandler>(A_0);
				}

				// Token: 0x0600227C RID: 8828 RVA: 0x0000E515 File Offset: 0x0000C715
				public static Discord.FFIMethods.DestroyHandler operator +(Discord.FFIMethods.DestroyHandler A_0, Discord.FFIMethods.DestroyHandler A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<Discord.FFIMethods.DestroyHandler>();
				}

				// Token: 0x0600227D RID: 8829 RVA: 0x0000E523 File Offset: 0x0000C723
				public static Discord.FFIMethods.DestroyHandler operator -(Discord.FFIMethods.DestroyHandler A_0, Discord.FFIMethods.DestroyHandler A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<Discord.FFIMethods.DestroyHandler>();
					}
					return delegate2;
				}

				// Token: 0x040019F9 RID: 6649
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x040019FA RID: 6650
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_0;

				// Token: 0x040019FB RID: 6651
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0;

				// Token: 0x040019FC RID: 6652
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x0200026E RID: 622
			public sealed class RunCallbacksMethod : MulticastDelegate
			{
				// Token: 0x0600227E RID: 8830 RVA: 0x0009C080 File Offset: 0x0009A280
				// Note: this type is marked as 'beforefieldinit'.
				static RunCallbacksMethod()
				{
					Il2CppClassPointerStore<Discord.FFIMethods.RunCallbacksMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Discord.FFIMethods>.NativeClassPtr, "RunCallbacksMethod");
					Discord.FFIMethods.RunCallbacksMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord.FFIMethods.RunCallbacksMethod>.NativeClassPtr, 100667405);
					Discord.FFIMethods.RunCallbacksMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord.FFIMethods.RunCallbacksMethod>.NativeClassPtr, 100667406);
					Discord.FFIMethods.RunCallbacksMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord.FFIMethods.RunCallbacksMethod>.NativeClassPtr, 100667407);
					Discord.FFIMethods.RunCallbacksMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord.FFIMethods.RunCallbacksMethod>.NativeClassPtr, 100667408);
				}

				// Token: 0x0600227F RID: 8831 RVA: 0x0009C0F4 File Offset: 0x0009A2F4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52288, XrefRangeEnd = 52291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe RunCallbacksMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Discord.FFIMethods.RunCallbacksMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.FFIMethods.RunCallbacksMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002280 RID: 8832 RVA: 0x0009C150 File Offset: 0x0009A350
				[CallerCount(0)]
				public unsafe Result Invoke(IntPtr methodsPtr)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.FFIMethods.RunCallbacksMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
					}
				}

				// Token: 0x06002281 RID: 8833 RVA: 0x0009C19C File Offset: 0x0009A39C
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.FFIMethods.RunCallbacksMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06002282 RID: 8834 RVA: 0x0009C20C File Offset: 0x0009A40C
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.FFIMethods.RunCallbacksMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Result>(intPtr3) : null;
					}
				}

				// Token: 0x06002283 RID: 8835 RVA: 0x0000E534 File Offset: 0x0000C734
				public RunCallbacksMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06002284 RID: 8836 RVA: 0x0000E53D File Offset: 0x0000C73D
				public static implicit operator Discord.FFIMethods.RunCallbacksMethod(Func<IntPtr, Result> A_0)
				{
					return DelegateSupport.ConvertDelegate<Discord.FFIMethods.RunCallbacksMethod>(A_0);
				}

				// Token: 0x06002285 RID: 8837 RVA: 0x0000E545 File Offset: 0x0000C745
				public static Discord.FFIMethods.RunCallbacksMethod operator +(Discord.FFIMethods.RunCallbacksMethod A_0, Discord.FFIMethods.RunCallbacksMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<Discord.FFIMethods.RunCallbacksMethod>();
				}

				// Token: 0x06002286 RID: 8838 RVA: 0x0000E553 File Offset: 0x0000C753
				public static Discord.FFIMethods.RunCallbacksMethod operator -(Discord.FFIMethods.RunCallbacksMethod A_0, Discord.FFIMethods.RunCallbacksMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<Discord.FFIMethods.RunCallbacksMethod>();
					}
					return delegate2;
				}

				// Token: 0x040019FD RID: 6653
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x040019FE RID: 6654
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Result_IntPtr_0;

				// Token: 0x040019FF RID: 6655
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0;

				// Token: 0x04001A00 RID: 6656
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Result_IAsyncResult_0;
			}

			// Token: 0x0200026F RID: 623
			public sealed class SetLogHookCallback : MulticastDelegate
			{
				// Token: 0x06002287 RID: 8839 RVA: 0x0009C25C File Offset: 0x0009A45C
				// Note: this type is marked as 'beforefieldinit'.
				static SetLogHookCallback()
				{
					Il2CppClassPointerStore<Discord.FFIMethods.SetLogHookCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Discord.FFIMethods>.NativeClassPtr, "SetLogHookCallback");
					Discord.FFIMethods.SetLogHookCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord.FFIMethods.SetLogHookCallback>.NativeClassPtr, 100667409);
					Discord.FFIMethods.SetLogHookCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_LogLevel_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord.FFIMethods.SetLogHookCallback>.NativeClassPtr, 100667410);
					Discord.FFIMethods.SetLogHookCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_LogLevel_String_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord.FFIMethods.SetLogHookCallback>.NativeClassPtr, 100667411);
					Discord.FFIMethods.SetLogHookCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord.FFIMethods.SetLogHookCallback>.NativeClassPtr, 100667412);
				}

				// Token: 0x06002288 RID: 8840 RVA: 0x0009C2D0 File Offset: 0x0009A4D0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52291, XrefRangeEnd = 52294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe SetLogHookCallback(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Discord.FFIMethods.SetLogHookCallback>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.FFIMethods.SetLogHookCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002289 RID: 8841 RVA: 0x0009C32C File Offset: 0x0009A52C
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr ptr, LogLevel level, string message)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(level);
					ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.FFIMethods.SetLogHookCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_LogLevel_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600228A RID: 8842 RVA: 0x0009C390 File Offset: 0x0009A590
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52294, XrefRangeEnd = 52300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr ptr, LogLevel level, string message, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr2;
					checked
					{
						ptr2 = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr2 = ref ptr;
					}
					ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(level);
					ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
					ptr2[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr2[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.FFIMethods.SetLogHookCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_LogLevel_String_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x0600228B RID: 8843 RVA: 0x0009C428 File Offset: 0x0009A628
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.FFIMethods.SetLogHookCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x0600228C RID: 8844 RVA: 0x0000E564 File Offset: 0x0000C764
				public SetLogHookCallback(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x0600228D RID: 8845 RVA: 0x0000E56D File Offset: 0x0000C76D
				public static implicit operator Discord.FFIMethods.SetLogHookCallback(Action<IntPtr, LogLevel, string> A_0)
				{
					return DelegateSupport.ConvertDelegate<Discord.FFIMethods.SetLogHookCallback>(A_0);
				}

				// Token: 0x0600228E RID: 8846 RVA: 0x0000E575 File Offset: 0x0000C775
				public static Discord.FFIMethods.SetLogHookCallback operator +(Discord.FFIMethods.SetLogHookCallback A_0, Discord.FFIMethods.SetLogHookCallback A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<Discord.FFIMethods.SetLogHookCallback>();
				}

				// Token: 0x0600228F RID: 8847 RVA: 0x0000E583 File Offset: 0x0000C783
				public static Discord.FFIMethods.SetLogHookCallback operator -(Discord.FFIMethods.SetLogHookCallback A_0, Discord.FFIMethods.SetLogHookCallback A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<Discord.FFIMethods.SetLogHookCallback>();
					}
					return delegate2;
				}

				// Token: 0x04001A01 RID: 6657
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001A02 RID: 6658
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_LogLevel_String_0;

				// Token: 0x04001A03 RID: 6659
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_LogLevel_String_AsyncCallback_Object_0;

				// Token: 0x04001A04 RID: 6660
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x02000270 RID: 624
			public sealed class SetLogHookMethod : MulticastDelegate
			{
				// Token: 0x06002290 RID: 8848 RVA: 0x0009C46C File Offset: 0x0009A66C
				// Note: this type is marked as 'beforefieldinit'.
				static SetLogHookMethod()
				{
					Il2CppClassPointerStore<Discord.FFIMethods.SetLogHookMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Discord.FFIMethods>.NativeClassPtr, "SetLogHookMethod");
					Discord.FFIMethods.SetLogHookMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord.FFIMethods.SetLogHookMethod>.NativeClassPtr, 100667413);
					Discord.FFIMethods.SetLogHookMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_LogLevel_IntPtr_SetLogHookCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord.FFIMethods.SetLogHookMethod>.NativeClassPtr, 100667414);
					Discord.FFIMethods.SetLogHookMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_LogLevel_IntPtr_SetLogHookCallback_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord.FFIMethods.SetLogHookMethod>.NativeClassPtr, 100667415);
					Discord.FFIMethods.SetLogHookMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord.FFIMethods.SetLogHookMethod>.NativeClassPtr, 100667416);
				}

				// Token: 0x06002291 RID: 8849 RVA: 0x0009C4E0 File Offset: 0x0009A6E0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe SetLogHookMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Discord.FFIMethods.SetLogHookMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.FFIMethods.SetLogHookMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002292 RID: 8850 RVA: 0x0009C53C File Offset: 0x0009A73C
				[CallerCount(0)]
				public unsafe void Invoke(IntPtr methodsPtr, LogLevel minLevel, IntPtr callbackData, Discord.FFIMethods.SetLogHookCallback callback)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(minLevel);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callbackData;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.FFIMethods.SetLogHookMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_LogLevel_IntPtr_SetLogHookCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06002293 RID: 8851 RVA: 0x0009C5B0 File Offset: 0x0009A7B0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52300, XrefRangeEnd = 52308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr methodsPtr, LogLevel minLevel, IntPtr callbackData, Discord.FFIMethods.SetLogHookCallback callback, AsyncCallback __callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref methodsPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(minLevel);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref callbackData;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(__callback);
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.FFIMethods.SetLogHookMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_LogLevel_IntPtr_SetLogHookCallback_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06002294 RID: 8852 RVA: 0x0009C658 File Offset: 0x0009A858
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.FFIMethods.SetLogHookMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x06002295 RID: 8853 RVA: 0x0000E594 File Offset: 0x0000C794
				public SetLogHookMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06002296 RID: 8854 RVA: 0x0000E59D File Offset: 0x0000C79D
				public static implicit operator Discord.FFIMethods.SetLogHookMethod(Action<IntPtr, LogLevel, IntPtr, Discord.FFIMethods.SetLogHookCallback> A_0)
				{
					return DelegateSupport.ConvertDelegate<Discord.FFIMethods.SetLogHookMethod>(A_0);
				}

				// Token: 0x06002297 RID: 8855 RVA: 0x0000E5A5 File Offset: 0x0000C7A5
				public static Discord.FFIMethods.SetLogHookMethod operator +(Discord.FFIMethods.SetLogHookMethod A_0, Discord.FFIMethods.SetLogHookMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<Discord.FFIMethods.SetLogHookMethod>();
				}

				// Token: 0x06002298 RID: 8856 RVA: 0x0000E5B3 File Offset: 0x0000C7B3
				public static Discord.FFIMethods.SetLogHookMethod operator -(Discord.FFIMethods.SetLogHookMethod A_0, Discord.FFIMethods.SetLogHookMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<Discord.FFIMethods.SetLogHookMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001A05 RID: 6661
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001A06 RID: 6662
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IntPtr_LogLevel_IntPtr_SetLogHookCallback_0;

				// Token: 0x04001A07 RID: 6663
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_LogLevel_IntPtr_SetLogHookCallback_AsyncCallback_Object_0;

				// Token: 0x04001A08 RID: 6664
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
			}

			// Token: 0x02000271 RID: 625
			public sealed class GetApplicationManagerMethod : MulticastDelegate
			{
				// Token: 0x06002299 RID: 8857 RVA: 0x0009C69C File Offset: 0x0009A89C
				// Note: this type is marked as 'beforefieldinit'.
				static GetApplicationManagerMethod()
				{
					Il2CppClassPointerStore<Discord.FFIMethods.GetApplicationManagerMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Discord.FFIMethods>.NativeClassPtr, "GetApplicationManagerMethod");
					Discord.FFIMethods.GetApplicationManagerMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord.FFIMethods.GetApplicationManagerMethod>.NativeClassPtr, 100667417);
					Discord.FFIMethods.GetApplicationManagerMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord.FFIMethods.GetApplicationManagerMethod>.NativeClassPtr, 100667418);
					Discord.FFIMethods.GetApplicationManagerMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord.FFIMethods.GetApplicationManagerMethod>.NativeClassPtr, 100667419);
					Discord.FFIMethods.GetApplicationManagerMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IntPtr_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord.FFIMethods.GetApplicationManagerMethod>.NativeClassPtr, 100667420);
				}

				// Token: 0x0600229A RID: 8858 RVA: 0x0009C710 File Offset: 0x0009A910
				[CallerCount(9)]
				[CachedScanResults(RefRangeStart = 52311, RefRangeEnd = 52320, XrefRangeStart = 52308, XrefRangeEnd = 52311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe GetApplicationManagerMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Discord.FFIMethods.GetApplicationManagerMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.FFIMethods.GetApplicationManagerMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600229B RID: 8859 RVA: 0x0009C76C File Offset: 0x0009A96C
				[CallerCount(0)]
				public unsafe IntPtr Invoke(IntPtr discordPtr)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref discordPtr;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.FFIMethods.GetApplicationManagerMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x0600229C RID: 8860 RVA: 0x0009C7B8 File Offset: 0x0009A9B8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr discordPtr, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref discordPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.FFIMethods.GetApplicationManagerMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x0600229D RID: 8861 RVA: 0x0009C828 File Offset: 0x0009AA28
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52320, XrefRangeEnd = 52322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IntPtr EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.FFIMethods.GetApplicationManagerMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IntPtr_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x0600229E RID: 8862 RVA: 0x0000E5C4 File Offset: 0x0000C7C4
				public GetApplicationManagerMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x0600229F RID: 8863 RVA: 0x0000E5CD File Offset: 0x0000C7CD
				public static implicit operator Discord.FFIMethods.GetApplicationManagerMethod(Func<IntPtr, IntPtr> A_0)
				{
					return DelegateSupport.ConvertDelegate<Discord.FFIMethods.GetApplicationManagerMethod>(A_0);
				}

				// Token: 0x060022A0 RID: 8864 RVA: 0x0000E5D5 File Offset: 0x0000C7D5
				public static Discord.FFIMethods.GetApplicationManagerMethod operator +(Discord.FFIMethods.GetApplicationManagerMethod A_0, Discord.FFIMethods.GetApplicationManagerMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<Discord.FFIMethods.GetApplicationManagerMethod>();
				}

				// Token: 0x060022A1 RID: 8865 RVA: 0x0000E5E3 File Offset: 0x0000C7E3
				public static Discord.FFIMethods.GetApplicationManagerMethod operator -(Discord.FFIMethods.GetApplicationManagerMethod A_0, Discord.FFIMethods.GetApplicationManagerMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<Discord.FFIMethods.GetApplicationManagerMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001A09 RID: 6665
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001A0A RID: 6666
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_IntPtr_0;

				// Token: 0x04001A0B RID: 6667
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0;

				// Token: 0x04001A0C RID: 6668
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IntPtr_IAsyncResult_0;
			}

			// Token: 0x02000272 RID: 626
			public sealed class GetUserManagerMethod : MulticastDelegate
			{
				// Token: 0x060022A2 RID: 8866 RVA: 0x0009C878 File Offset: 0x0009AA78
				// Note: this type is marked as 'beforefieldinit'.
				static GetUserManagerMethod()
				{
					Il2CppClassPointerStore<Discord.FFIMethods.GetUserManagerMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Discord.FFIMethods>.NativeClassPtr, "GetUserManagerMethod");
					Discord.FFIMethods.GetUserManagerMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord.FFIMethods.GetUserManagerMethod>.NativeClassPtr, 100667421);
					Discord.FFIMethods.GetUserManagerMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord.FFIMethods.GetUserManagerMethod>.NativeClassPtr, 100667422);
					Discord.FFIMethods.GetUserManagerMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord.FFIMethods.GetUserManagerMethod>.NativeClassPtr, 100667423);
					Discord.FFIMethods.GetUserManagerMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IntPtr_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord.FFIMethods.GetUserManagerMethod>.NativeClassPtr, 100667424);
				}

				// Token: 0x060022A3 RID: 8867 RVA: 0x0009C8EC File Offset: 0x0009AAEC
				[CallerCount(9)]
				[CachedScanResults(RefRangeStart = 52311, RefRangeEnd = 52320, XrefRangeStart = 52311, XrefRangeEnd = 52320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe GetUserManagerMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Discord.FFIMethods.GetUserManagerMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.FFIMethods.GetUserManagerMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060022A4 RID: 8868 RVA: 0x0009C948 File Offset: 0x0009AB48
				[CallerCount(0)]
				public unsafe IntPtr Invoke(IntPtr discordPtr)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref discordPtr;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.FFIMethods.GetUserManagerMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x060022A5 RID: 8869 RVA: 0x0009C994 File Offset: 0x0009AB94
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr discordPtr, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref discordPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.FFIMethods.GetUserManagerMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060022A6 RID: 8870 RVA: 0x0009CA04 File Offset: 0x0009AC04
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IntPtr EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.FFIMethods.GetUserManagerMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IntPtr_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x060022A7 RID: 8871 RVA: 0x0000E5F4 File Offset: 0x0000C7F4
				public GetUserManagerMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060022A8 RID: 8872 RVA: 0x0000E5FD File Offset: 0x0000C7FD
				public static implicit operator Discord.FFIMethods.GetUserManagerMethod(Func<IntPtr, IntPtr> A_0)
				{
					return DelegateSupport.ConvertDelegate<Discord.FFIMethods.GetUserManagerMethod>(A_0);
				}

				// Token: 0x060022A9 RID: 8873 RVA: 0x0000E605 File Offset: 0x0000C805
				public static Discord.FFIMethods.GetUserManagerMethod operator +(Discord.FFIMethods.GetUserManagerMethod A_0, Discord.FFIMethods.GetUserManagerMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<Discord.FFIMethods.GetUserManagerMethod>();
				}

				// Token: 0x060022AA RID: 8874 RVA: 0x0000E613 File Offset: 0x0000C813
				public static Discord.FFIMethods.GetUserManagerMethod operator -(Discord.FFIMethods.GetUserManagerMethod A_0, Discord.FFIMethods.GetUserManagerMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<Discord.FFIMethods.GetUserManagerMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001A0D RID: 6669
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001A0E RID: 6670
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_IntPtr_0;

				// Token: 0x04001A0F RID: 6671
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0;

				// Token: 0x04001A10 RID: 6672
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IntPtr_IAsyncResult_0;
			}

			// Token: 0x02000273 RID: 627
			public sealed class GetImageManagerMethod : MulticastDelegate
			{
				// Token: 0x060022AB RID: 8875 RVA: 0x0009CA54 File Offset: 0x0009AC54
				// Note: this type is marked as 'beforefieldinit'.
				static GetImageManagerMethod()
				{
					Il2CppClassPointerStore<Discord.FFIMethods.GetImageManagerMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Discord.FFIMethods>.NativeClassPtr, "GetImageManagerMethod");
					Discord.FFIMethods.GetImageManagerMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord.FFIMethods.GetImageManagerMethod>.NativeClassPtr, 100667425);
					Discord.FFIMethods.GetImageManagerMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord.FFIMethods.GetImageManagerMethod>.NativeClassPtr, 100667426);
					Discord.FFIMethods.GetImageManagerMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord.FFIMethods.GetImageManagerMethod>.NativeClassPtr, 100667427);
					Discord.FFIMethods.GetImageManagerMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IntPtr_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord.FFIMethods.GetImageManagerMethod>.NativeClassPtr, 100667428);
				}

				// Token: 0x060022AC RID: 8876 RVA: 0x0009CAC8 File Offset: 0x0009ACC8
				[CallerCount(9)]
				[CachedScanResults(RefRangeStart = 52311, RefRangeEnd = 52320, XrefRangeStart = 52311, XrefRangeEnd = 52320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe GetImageManagerMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Discord.FFIMethods.GetImageManagerMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.FFIMethods.GetImageManagerMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060022AD RID: 8877 RVA: 0x0009CB24 File Offset: 0x0009AD24
				[CallerCount(0)]
				public unsafe IntPtr Invoke(IntPtr discordPtr)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref discordPtr;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.FFIMethods.GetImageManagerMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x060022AE RID: 8878 RVA: 0x0009CB70 File Offset: 0x0009AD70
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr discordPtr, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref discordPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.FFIMethods.GetImageManagerMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060022AF RID: 8879 RVA: 0x0009CBE0 File Offset: 0x0009ADE0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IntPtr EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.FFIMethods.GetImageManagerMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IntPtr_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x060022B0 RID: 8880 RVA: 0x0000E624 File Offset: 0x0000C824
				public GetImageManagerMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060022B1 RID: 8881 RVA: 0x0000E62D File Offset: 0x0000C82D
				public static implicit operator Discord.FFIMethods.GetImageManagerMethod(Func<IntPtr, IntPtr> A_0)
				{
					return DelegateSupport.ConvertDelegate<Discord.FFIMethods.GetImageManagerMethod>(A_0);
				}

				// Token: 0x060022B2 RID: 8882 RVA: 0x0000E635 File Offset: 0x0000C835
				public static Discord.FFIMethods.GetImageManagerMethod operator +(Discord.FFIMethods.GetImageManagerMethod A_0, Discord.FFIMethods.GetImageManagerMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<Discord.FFIMethods.GetImageManagerMethod>();
				}

				// Token: 0x060022B3 RID: 8883 RVA: 0x0000E643 File Offset: 0x0000C843
				public static Discord.FFIMethods.GetImageManagerMethod operator -(Discord.FFIMethods.GetImageManagerMethod A_0, Discord.FFIMethods.GetImageManagerMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<Discord.FFIMethods.GetImageManagerMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001A11 RID: 6673
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001A12 RID: 6674
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_IntPtr_0;

				// Token: 0x04001A13 RID: 6675
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0;

				// Token: 0x04001A14 RID: 6676
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IntPtr_IAsyncResult_0;
			}

			// Token: 0x02000274 RID: 628
			public sealed class GetActivityManagerMethod : MulticastDelegate
			{
				// Token: 0x060022B4 RID: 8884 RVA: 0x0009CC30 File Offset: 0x0009AE30
				// Note: this type is marked as 'beforefieldinit'.
				static GetActivityManagerMethod()
				{
					Il2CppClassPointerStore<Discord.FFIMethods.GetActivityManagerMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Discord.FFIMethods>.NativeClassPtr, "GetActivityManagerMethod");
					Discord.FFIMethods.GetActivityManagerMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord.FFIMethods.GetActivityManagerMethod>.NativeClassPtr, 100667429);
					Discord.FFIMethods.GetActivityManagerMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord.FFIMethods.GetActivityManagerMethod>.NativeClassPtr, 100667430);
					Discord.FFIMethods.GetActivityManagerMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord.FFIMethods.GetActivityManagerMethod>.NativeClassPtr, 100667431);
					Discord.FFIMethods.GetActivityManagerMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IntPtr_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord.FFIMethods.GetActivityManagerMethod>.NativeClassPtr, 100667432);
				}

				// Token: 0x060022B5 RID: 8885 RVA: 0x0009CCA4 File Offset: 0x0009AEA4
				[CallerCount(9)]
				[CachedScanResults(RefRangeStart = 52311, RefRangeEnd = 52320, XrefRangeStart = 52311, XrefRangeEnd = 52320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe GetActivityManagerMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Discord.FFIMethods.GetActivityManagerMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.FFIMethods.GetActivityManagerMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060022B6 RID: 8886 RVA: 0x0009CD00 File Offset: 0x0009AF00
				[CallerCount(0)]
				public unsafe IntPtr Invoke(IntPtr discordPtr)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref discordPtr;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.FFIMethods.GetActivityManagerMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x060022B7 RID: 8887 RVA: 0x0009CD4C File Offset: 0x0009AF4C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr discordPtr, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref discordPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.FFIMethods.GetActivityManagerMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060022B8 RID: 8888 RVA: 0x0009CDBC File Offset: 0x0009AFBC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IntPtr EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.FFIMethods.GetActivityManagerMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IntPtr_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x060022B9 RID: 8889 RVA: 0x0000E654 File Offset: 0x0000C854
				public GetActivityManagerMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060022BA RID: 8890 RVA: 0x0000E65D File Offset: 0x0000C85D
				public static implicit operator Discord.FFIMethods.GetActivityManagerMethod(Func<IntPtr, IntPtr> A_0)
				{
					return DelegateSupport.ConvertDelegate<Discord.FFIMethods.GetActivityManagerMethod>(A_0);
				}

				// Token: 0x060022BB RID: 8891 RVA: 0x0000E665 File Offset: 0x0000C865
				public static Discord.FFIMethods.GetActivityManagerMethod operator +(Discord.FFIMethods.GetActivityManagerMethod A_0, Discord.FFIMethods.GetActivityManagerMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<Discord.FFIMethods.GetActivityManagerMethod>();
				}

				// Token: 0x060022BC RID: 8892 RVA: 0x0000E673 File Offset: 0x0000C873
				public static Discord.FFIMethods.GetActivityManagerMethod operator -(Discord.FFIMethods.GetActivityManagerMethod A_0, Discord.FFIMethods.GetActivityManagerMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<Discord.FFIMethods.GetActivityManagerMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001A15 RID: 6677
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001A16 RID: 6678
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_IntPtr_0;

				// Token: 0x04001A17 RID: 6679
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0;

				// Token: 0x04001A18 RID: 6680
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IntPtr_IAsyncResult_0;
			}

			// Token: 0x02000275 RID: 629
			public sealed class GetRelationshipManagerMethod : MulticastDelegate
			{
				// Token: 0x060022BD RID: 8893 RVA: 0x0009CE0C File Offset: 0x0009B00C
				// Note: this type is marked as 'beforefieldinit'.
				static GetRelationshipManagerMethod()
				{
					Il2CppClassPointerStore<Discord.FFIMethods.GetRelationshipManagerMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Discord.FFIMethods>.NativeClassPtr, "GetRelationshipManagerMethod");
					Discord.FFIMethods.GetRelationshipManagerMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord.FFIMethods.GetRelationshipManagerMethod>.NativeClassPtr, 100667433);
					Discord.FFIMethods.GetRelationshipManagerMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord.FFIMethods.GetRelationshipManagerMethod>.NativeClassPtr, 100667434);
					Discord.FFIMethods.GetRelationshipManagerMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord.FFIMethods.GetRelationshipManagerMethod>.NativeClassPtr, 100667435);
					Discord.FFIMethods.GetRelationshipManagerMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IntPtr_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord.FFIMethods.GetRelationshipManagerMethod>.NativeClassPtr, 100667436);
				}

				// Token: 0x060022BE RID: 8894 RVA: 0x0009CE80 File Offset: 0x0009B080
				[CallerCount(9)]
				[CachedScanResults(RefRangeStart = 52311, RefRangeEnd = 52320, XrefRangeStart = 52311, XrefRangeEnd = 52320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe GetRelationshipManagerMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Discord.FFIMethods.GetRelationshipManagerMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.FFIMethods.GetRelationshipManagerMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060022BF RID: 8895 RVA: 0x0009CEDC File Offset: 0x0009B0DC
				[CallerCount(0)]
				public unsafe IntPtr Invoke(IntPtr discordPtr)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref discordPtr;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.FFIMethods.GetRelationshipManagerMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x060022C0 RID: 8896 RVA: 0x0009CF28 File Offset: 0x0009B128
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr discordPtr, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref discordPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.FFIMethods.GetRelationshipManagerMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060022C1 RID: 8897 RVA: 0x0009CF98 File Offset: 0x0009B198
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IntPtr EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.FFIMethods.GetRelationshipManagerMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IntPtr_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x060022C2 RID: 8898 RVA: 0x0000E684 File Offset: 0x0000C884
				public GetRelationshipManagerMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060022C3 RID: 8899 RVA: 0x0000E68D File Offset: 0x0000C88D
				public static implicit operator Discord.FFIMethods.GetRelationshipManagerMethod(Func<IntPtr, IntPtr> A_0)
				{
					return DelegateSupport.ConvertDelegate<Discord.FFIMethods.GetRelationshipManagerMethod>(A_0);
				}

				// Token: 0x060022C4 RID: 8900 RVA: 0x0000E695 File Offset: 0x0000C895
				public static Discord.FFIMethods.GetRelationshipManagerMethod operator +(Discord.FFIMethods.GetRelationshipManagerMethod A_0, Discord.FFIMethods.GetRelationshipManagerMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<Discord.FFIMethods.GetRelationshipManagerMethod>();
				}

				// Token: 0x060022C5 RID: 8901 RVA: 0x0000E6A3 File Offset: 0x0000C8A3
				public static Discord.FFIMethods.GetRelationshipManagerMethod operator -(Discord.FFIMethods.GetRelationshipManagerMethod A_0, Discord.FFIMethods.GetRelationshipManagerMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<Discord.FFIMethods.GetRelationshipManagerMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001A19 RID: 6681
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001A1A RID: 6682
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_IntPtr_0;

				// Token: 0x04001A1B RID: 6683
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0;

				// Token: 0x04001A1C RID: 6684
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IntPtr_IAsyncResult_0;
			}

			// Token: 0x02000276 RID: 630
			public sealed class GetLobbyManagerMethod : MulticastDelegate
			{
				// Token: 0x060022C6 RID: 8902 RVA: 0x0009CFE8 File Offset: 0x0009B1E8
				// Note: this type is marked as 'beforefieldinit'.
				static GetLobbyManagerMethod()
				{
					Il2CppClassPointerStore<Discord.FFIMethods.GetLobbyManagerMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Discord.FFIMethods>.NativeClassPtr, "GetLobbyManagerMethod");
					Discord.FFIMethods.GetLobbyManagerMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord.FFIMethods.GetLobbyManagerMethod>.NativeClassPtr, 100667437);
					Discord.FFIMethods.GetLobbyManagerMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord.FFIMethods.GetLobbyManagerMethod>.NativeClassPtr, 100667438);
					Discord.FFIMethods.GetLobbyManagerMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord.FFIMethods.GetLobbyManagerMethod>.NativeClassPtr, 100667439);
					Discord.FFIMethods.GetLobbyManagerMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IntPtr_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord.FFIMethods.GetLobbyManagerMethod>.NativeClassPtr, 100667440);
				}

				// Token: 0x060022C7 RID: 8903 RVA: 0x0009D05C File Offset: 0x0009B25C
				[CallerCount(9)]
				[CachedScanResults(RefRangeStart = 52311, RefRangeEnd = 52320, XrefRangeStart = 52311, XrefRangeEnd = 52320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe GetLobbyManagerMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Discord.FFIMethods.GetLobbyManagerMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.FFIMethods.GetLobbyManagerMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060022C8 RID: 8904 RVA: 0x0009D0B8 File Offset: 0x0009B2B8
				[CallerCount(0)]
				public unsafe IntPtr Invoke(IntPtr discordPtr)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref discordPtr;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.FFIMethods.GetLobbyManagerMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x060022C9 RID: 8905 RVA: 0x0009D104 File Offset: 0x0009B304
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr discordPtr, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref discordPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.FFIMethods.GetLobbyManagerMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060022CA RID: 8906 RVA: 0x0009D174 File Offset: 0x0009B374
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IntPtr EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.FFIMethods.GetLobbyManagerMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IntPtr_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x060022CB RID: 8907 RVA: 0x0000E6B4 File Offset: 0x0000C8B4
				public GetLobbyManagerMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060022CC RID: 8908 RVA: 0x0000E6BD File Offset: 0x0000C8BD
				public static implicit operator Discord.FFIMethods.GetLobbyManagerMethod(Func<IntPtr, IntPtr> A_0)
				{
					return DelegateSupport.ConvertDelegate<Discord.FFIMethods.GetLobbyManagerMethod>(A_0);
				}

				// Token: 0x060022CD RID: 8909 RVA: 0x0000E6C5 File Offset: 0x0000C8C5
				public static Discord.FFIMethods.GetLobbyManagerMethod operator +(Discord.FFIMethods.GetLobbyManagerMethod A_0, Discord.FFIMethods.GetLobbyManagerMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<Discord.FFIMethods.GetLobbyManagerMethod>();
				}

				// Token: 0x060022CE RID: 8910 RVA: 0x0000E6D3 File Offset: 0x0000C8D3
				public static Discord.FFIMethods.GetLobbyManagerMethod operator -(Discord.FFIMethods.GetLobbyManagerMethod A_0, Discord.FFIMethods.GetLobbyManagerMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<Discord.FFIMethods.GetLobbyManagerMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001A1D RID: 6685
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001A1E RID: 6686
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_IntPtr_0;

				// Token: 0x04001A1F RID: 6687
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0;

				// Token: 0x04001A20 RID: 6688
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IntPtr_IAsyncResult_0;
			}

			// Token: 0x02000277 RID: 631
			public sealed class GetNetworkManagerMethod : MulticastDelegate
			{
				// Token: 0x060022CF RID: 8911 RVA: 0x0009D1C4 File Offset: 0x0009B3C4
				// Note: this type is marked as 'beforefieldinit'.
				static GetNetworkManagerMethod()
				{
					Il2CppClassPointerStore<Discord.FFIMethods.GetNetworkManagerMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Discord.FFIMethods>.NativeClassPtr, "GetNetworkManagerMethod");
					Discord.FFIMethods.GetNetworkManagerMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord.FFIMethods.GetNetworkManagerMethod>.NativeClassPtr, 100667441);
					Discord.FFIMethods.GetNetworkManagerMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord.FFIMethods.GetNetworkManagerMethod>.NativeClassPtr, 100667442);
					Discord.FFIMethods.GetNetworkManagerMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord.FFIMethods.GetNetworkManagerMethod>.NativeClassPtr, 100667443);
					Discord.FFIMethods.GetNetworkManagerMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IntPtr_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord.FFIMethods.GetNetworkManagerMethod>.NativeClassPtr, 100667444);
				}

				// Token: 0x060022D0 RID: 8912 RVA: 0x0009D238 File Offset: 0x0009B438
				[CallerCount(9)]
				[CachedScanResults(RefRangeStart = 52311, RefRangeEnd = 52320, XrefRangeStart = 52311, XrefRangeEnd = 52320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe GetNetworkManagerMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Discord.FFIMethods.GetNetworkManagerMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.FFIMethods.GetNetworkManagerMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060022D1 RID: 8913 RVA: 0x0009D294 File Offset: 0x0009B494
				[CallerCount(0)]
				public unsafe IntPtr Invoke(IntPtr discordPtr)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref discordPtr;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.FFIMethods.GetNetworkManagerMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x060022D2 RID: 8914 RVA: 0x0009D2E0 File Offset: 0x0009B4E0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr discordPtr, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref discordPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.FFIMethods.GetNetworkManagerMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060022D3 RID: 8915 RVA: 0x0009D350 File Offset: 0x0009B550
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IntPtr EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.FFIMethods.GetNetworkManagerMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IntPtr_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x060022D4 RID: 8916 RVA: 0x0000E6E4 File Offset: 0x0000C8E4
				public GetNetworkManagerMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060022D5 RID: 8917 RVA: 0x0000E6ED File Offset: 0x0000C8ED
				public static implicit operator Discord.FFIMethods.GetNetworkManagerMethod(Func<IntPtr, IntPtr> A_0)
				{
					return DelegateSupport.ConvertDelegate<Discord.FFIMethods.GetNetworkManagerMethod>(A_0);
				}

				// Token: 0x060022D6 RID: 8918 RVA: 0x0000E6F5 File Offset: 0x0000C8F5
				public static Discord.FFIMethods.GetNetworkManagerMethod operator +(Discord.FFIMethods.GetNetworkManagerMethod A_0, Discord.FFIMethods.GetNetworkManagerMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<Discord.FFIMethods.GetNetworkManagerMethod>();
				}

				// Token: 0x060022D7 RID: 8919 RVA: 0x0000E703 File Offset: 0x0000C903
				public static Discord.FFIMethods.GetNetworkManagerMethod operator -(Discord.FFIMethods.GetNetworkManagerMethod A_0, Discord.FFIMethods.GetNetworkManagerMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<Discord.FFIMethods.GetNetworkManagerMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001A21 RID: 6689
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001A22 RID: 6690
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_IntPtr_0;

				// Token: 0x04001A23 RID: 6691
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0;

				// Token: 0x04001A24 RID: 6692
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IntPtr_IAsyncResult_0;
			}

			// Token: 0x02000278 RID: 632
			public sealed class GetOverlayManagerMethod : MulticastDelegate
			{
				// Token: 0x060022D8 RID: 8920 RVA: 0x0009D3A0 File Offset: 0x0009B5A0
				// Note: this type is marked as 'beforefieldinit'.
				static GetOverlayManagerMethod()
				{
					Il2CppClassPointerStore<Discord.FFIMethods.GetOverlayManagerMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Discord.FFIMethods>.NativeClassPtr, "GetOverlayManagerMethod");
					Discord.FFIMethods.GetOverlayManagerMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord.FFIMethods.GetOverlayManagerMethod>.NativeClassPtr, 100667445);
					Discord.FFIMethods.GetOverlayManagerMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord.FFIMethods.GetOverlayManagerMethod>.NativeClassPtr, 100667446);
					Discord.FFIMethods.GetOverlayManagerMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord.FFIMethods.GetOverlayManagerMethod>.NativeClassPtr, 100667447);
					Discord.FFIMethods.GetOverlayManagerMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IntPtr_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord.FFIMethods.GetOverlayManagerMethod>.NativeClassPtr, 100667448);
				}

				// Token: 0x060022D9 RID: 8921 RVA: 0x0009D414 File Offset: 0x0009B614
				[CallerCount(9)]
				[CachedScanResults(RefRangeStart = 52311, RefRangeEnd = 52320, XrefRangeStart = 52311, XrefRangeEnd = 52320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe GetOverlayManagerMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Discord.FFIMethods.GetOverlayManagerMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.FFIMethods.GetOverlayManagerMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060022DA RID: 8922 RVA: 0x0009D470 File Offset: 0x0009B670
				[CallerCount(0)]
				public unsafe IntPtr Invoke(IntPtr discordPtr)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref discordPtr;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.FFIMethods.GetOverlayManagerMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x060022DB RID: 8923 RVA: 0x0009D4BC File Offset: 0x0009B6BC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr discordPtr, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref discordPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.FFIMethods.GetOverlayManagerMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060022DC RID: 8924 RVA: 0x0009D52C File Offset: 0x0009B72C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IntPtr EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.FFIMethods.GetOverlayManagerMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IntPtr_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x060022DD RID: 8925 RVA: 0x0000E714 File Offset: 0x0000C914
				public GetOverlayManagerMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060022DE RID: 8926 RVA: 0x0000E71D File Offset: 0x0000C91D
				public static implicit operator Discord.FFIMethods.GetOverlayManagerMethod(Func<IntPtr, IntPtr> A_0)
				{
					return DelegateSupport.ConvertDelegate<Discord.FFIMethods.GetOverlayManagerMethod>(A_0);
				}

				// Token: 0x060022DF RID: 8927 RVA: 0x0000E725 File Offset: 0x0000C925
				public static Discord.FFIMethods.GetOverlayManagerMethod operator +(Discord.FFIMethods.GetOverlayManagerMethod A_0, Discord.FFIMethods.GetOverlayManagerMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<Discord.FFIMethods.GetOverlayManagerMethod>();
				}

				// Token: 0x060022E0 RID: 8928 RVA: 0x0000E733 File Offset: 0x0000C933
				public static Discord.FFIMethods.GetOverlayManagerMethod operator -(Discord.FFIMethods.GetOverlayManagerMethod A_0, Discord.FFIMethods.GetOverlayManagerMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<Discord.FFIMethods.GetOverlayManagerMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001A25 RID: 6693
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001A26 RID: 6694
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_IntPtr_0;

				// Token: 0x04001A27 RID: 6695
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0;

				// Token: 0x04001A28 RID: 6696
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IntPtr_IAsyncResult_0;
			}

			// Token: 0x02000279 RID: 633
			public sealed class GetStorageManagerMethod : MulticastDelegate
			{
				// Token: 0x060022E1 RID: 8929 RVA: 0x0009D57C File Offset: 0x0009B77C
				// Note: this type is marked as 'beforefieldinit'.
				static GetStorageManagerMethod()
				{
					Il2CppClassPointerStore<Discord.FFIMethods.GetStorageManagerMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Discord.FFIMethods>.NativeClassPtr, "GetStorageManagerMethod");
					Discord.FFIMethods.GetStorageManagerMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord.FFIMethods.GetStorageManagerMethod>.NativeClassPtr, 100667449);
					Discord.FFIMethods.GetStorageManagerMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord.FFIMethods.GetStorageManagerMethod>.NativeClassPtr, 100667450);
					Discord.FFIMethods.GetStorageManagerMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord.FFIMethods.GetStorageManagerMethod>.NativeClassPtr, 100667451);
					Discord.FFIMethods.GetStorageManagerMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IntPtr_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord.FFIMethods.GetStorageManagerMethod>.NativeClassPtr, 100667452);
				}

				// Token: 0x060022E2 RID: 8930 RVA: 0x0009D5F0 File Offset: 0x0009B7F0
				[CallerCount(9)]
				[CachedScanResults(RefRangeStart = 52311, RefRangeEnd = 52320, XrefRangeStart = 52311, XrefRangeEnd = 52320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe GetStorageManagerMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Discord.FFIMethods.GetStorageManagerMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.FFIMethods.GetStorageManagerMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060022E3 RID: 8931 RVA: 0x0009D64C File Offset: 0x0009B84C
				[CallerCount(0)]
				public unsafe IntPtr Invoke(IntPtr discordPtr)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref discordPtr;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.FFIMethods.GetStorageManagerMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x060022E4 RID: 8932 RVA: 0x0009D698 File Offset: 0x0009B898
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr discordPtr, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref discordPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.FFIMethods.GetStorageManagerMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060022E5 RID: 8933 RVA: 0x0009D708 File Offset: 0x0009B908
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IntPtr EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.FFIMethods.GetStorageManagerMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IntPtr_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x060022E6 RID: 8934 RVA: 0x0000E744 File Offset: 0x0000C944
				public GetStorageManagerMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060022E7 RID: 8935 RVA: 0x0000E74D File Offset: 0x0000C94D
				public static implicit operator Discord.FFIMethods.GetStorageManagerMethod(Func<IntPtr, IntPtr> A_0)
				{
					return DelegateSupport.ConvertDelegate<Discord.FFIMethods.GetStorageManagerMethod>(A_0);
				}

				// Token: 0x060022E8 RID: 8936 RVA: 0x0000E755 File Offset: 0x0000C955
				public static Discord.FFIMethods.GetStorageManagerMethod operator +(Discord.FFIMethods.GetStorageManagerMethod A_0, Discord.FFIMethods.GetStorageManagerMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<Discord.FFIMethods.GetStorageManagerMethod>();
				}

				// Token: 0x060022E9 RID: 8937 RVA: 0x0000E763 File Offset: 0x0000C963
				public static Discord.FFIMethods.GetStorageManagerMethod operator -(Discord.FFIMethods.GetStorageManagerMethod A_0, Discord.FFIMethods.GetStorageManagerMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<Discord.FFIMethods.GetStorageManagerMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001A29 RID: 6697
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001A2A RID: 6698
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_IntPtr_0;

				// Token: 0x04001A2B RID: 6699
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0;

				// Token: 0x04001A2C RID: 6700
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IntPtr_IAsyncResult_0;
			}

			// Token: 0x0200027A RID: 634
			public sealed class GetStoreManagerMethod : MulticastDelegate
			{
				// Token: 0x060022EA RID: 8938 RVA: 0x0009D758 File Offset: 0x0009B958
				// Note: this type is marked as 'beforefieldinit'.
				static GetStoreManagerMethod()
				{
					Il2CppClassPointerStore<Discord.FFIMethods.GetStoreManagerMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Discord.FFIMethods>.NativeClassPtr, "GetStoreManagerMethod");
					Discord.FFIMethods.GetStoreManagerMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord.FFIMethods.GetStoreManagerMethod>.NativeClassPtr, 100667453);
					Discord.FFIMethods.GetStoreManagerMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord.FFIMethods.GetStoreManagerMethod>.NativeClassPtr, 100667454);
					Discord.FFIMethods.GetStoreManagerMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord.FFIMethods.GetStoreManagerMethod>.NativeClassPtr, 100667455);
					Discord.FFIMethods.GetStoreManagerMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IntPtr_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord.FFIMethods.GetStoreManagerMethod>.NativeClassPtr, 100667456);
				}

				// Token: 0x060022EB RID: 8939 RVA: 0x0009D7CC File Offset: 0x0009B9CC
				[CallerCount(9)]
				[CachedScanResults(RefRangeStart = 52311, RefRangeEnd = 52320, XrefRangeStart = 52311, XrefRangeEnd = 52320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe GetStoreManagerMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Discord.FFIMethods.GetStoreManagerMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.FFIMethods.GetStoreManagerMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060022EC RID: 8940 RVA: 0x0009D828 File Offset: 0x0009BA28
				[CallerCount(0)]
				public unsafe IntPtr Invoke(IntPtr discordPtr)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref discordPtr;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.FFIMethods.GetStoreManagerMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x060022ED RID: 8941 RVA: 0x0009D874 File Offset: 0x0009BA74
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr discordPtr, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref discordPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.FFIMethods.GetStoreManagerMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060022EE RID: 8942 RVA: 0x0009D8E4 File Offset: 0x0009BAE4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IntPtr EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.FFIMethods.GetStoreManagerMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IntPtr_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x060022EF RID: 8943 RVA: 0x0000E774 File Offset: 0x0000C974
				public GetStoreManagerMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060022F0 RID: 8944 RVA: 0x0000E77D File Offset: 0x0000C97D
				public static implicit operator Discord.FFIMethods.GetStoreManagerMethod(Func<IntPtr, IntPtr> A_0)
				{
					return DelegateSupport.ConvertDelegate<Discord.FFIMethods.GetStoreManagerMethod>(A_0);
				}

				// Token: 0x060022F1 RID: 8945 RVA: 0x0000E785 File Offset: 0x0000C985
				public static Discord.FFIMethods.GetStoreManagerMethod operator +(Discord.FFIMethods.GetStoreManagerMethod A_0, Discord.FFIMethods.GetStoreManagerMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<Discord.FFIMethods.GetStoreManagerMethod>();
				}

				// Token: 0x060022F2 RID: 8946 RVA: 0x0000E793 File Offset: 0x0000C993
				public static Discord.FFIMethods.GetStoreManagerMethod operator -(Discord.FFIMethods.GetStoreManagerMethod A_0, Discord.FFIMethods.GetStoreManagerMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<Discord.FFIMethods.GetStoreManagerMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001A2D RID: 6701
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001A2E RID: 6702
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_IntPtr_0;

				// Token: 0x04001A2F RID: 6703
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0;

				// Token: 0x04001A30 RID: 6704
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IntPtr_IAsyncResult_0;
			}

			// Token: 0x0200027B RID: 635
			public sealed class GetVoiceManagerMethod : MulticastDelegate
			{
				// Token: 0x060022F3 RID: 8947 RVA: 0x0009D934 File Offset: 0x0009BB34
				// Note: this type is marked as 'beforefieldinit'.
				static GetVoiceManagerMethod()
				{
					Il2CppClassPointerStore<Discord.FFIMethods.GetVoiceManagerMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Discord.FFIMethods>.NativeClassPtr, "GetVoiceManagerMethod");
					Discord.FFIMethods.GetVoiceManagerMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord.FFIMethods.GetVoiceManagerMethod>.NativeClassPtr, 100667457);
					Discord.FFIMethods.GetVoiceManagerMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord.FFIMethods.GetVoiceManagerMethod>.NativeClassPtr, 100667458);
					Discord.FFIMethods.GetVoiceManagerMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord.FFIMethods.GetVoiceManagerMethod>.NativeClassPtr, 100667459);
					Discord.FFIMethods.GetVoiceManagerMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IntPtr_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord.FFIMethods.GetVoiceManagerMethod>.NativeClassPtr, 100667460);
				}

				// Token: 0x060022F4 RID: 8948 RVA: 0x0009D9A8 File Offset: 0x0009BBA8
				[CallerCount(9)]
				[CachedScanResults(RefRangeStart = 52311, RefRangeEnd = 52320, XrefRangeStart = 52311, XrefRangeEnd = 52320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe GetVoiceManagerMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Discord.FFIMethods.GetVoiceManagerMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.FFIMethods.GetVoiceManagerMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060022F5 RID: 8949 RVA: 0x0009DA04 File Offset: 0x0009BC04
				[CallerCount(0)]
				public unsafe IntPtr Invoke(IntPtr discordPtr)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref discordPtr;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.FFIMethods.GetVoiceManagerMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x060022F6 RID: 8950 RVA: 0x0009DA50 File Offset: 0x0009BC50
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr discordPtr, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref discordPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.FFIMethods.GetVoiceManagerMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x060022F7 RID: 8951 RVA: 0x0009DAC0 File Offset: 0x0009BCC0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IntPtr EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.FFIMethods.GetVoiceManagerMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IntPtr_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x060022F8 RID: 8952 RVA: 0x0000E7A4 File Offset: 0x0000C9A4
				public GetVoiceManagerMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060022F9 RID: 8953 RVA: 0x0000E7AD File Offset: 0x0000C9AD
				public static implicit operator Discord.FFIMethods.GetVoiceManagerMethod(Func<IntPtr, IntPtr> A_0)
				{
					return DelegateSupport.ConvertDelegate<Discord.FFIMethods.GetVoiceManagerMethod>(A_0);
				}

				// Token: 0x060022FA RID: 8954 RVA: 0x0000E7B5 File Offset: 0x0000C9B5
				public static Discord.FFIMethods.GetVoiceManagerMethod operator +(Discord.FFIMethods.GetVoiceManagerMethod A_0, Discord.FFIMethods.GetVoiceManagerMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<Discord.FFIMethods.GetVoiceManagerMethod>();
				}

				// Token: 0x060022FB RID: 8955 RVA: 0x0000E7C3 File Offset: 0x0000C9C3
				public static Discord.FFIMethods.GetVoiceManagerMethod operator -(Discord.FFIMethods.GetVoiceManagerMethod A_0, Discord.FFIMethods.GetVoiceManagerMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<Discord.FFIMethods.GetVoiceManagerMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001A31 RID: 6705
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001A32 RID: 6706
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_IntPtr_0;

				// Token: 0x04001A33 RID: 6707
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0;

				// Token: 0x04001A34 RID: 6708
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IntPtr_IAsyncResult_0;
			}

			// Token: 0x0200027C RID: 636
			public sealed class GetAchievementManagerMethod : MulticastDelegate
			{
				// Token: 0x060022FC RID: 8956 RVA: 0x0009DB10 File Offset: 0x0009BD10
				// Note: this type is marked as 'beforefieldinit'.
				static GetAchievementManagerMethod()
				{
					Il2CppClassPointerStore<Discord.FFIMethods.GetAchievementManagerMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Discord.FFIMethods>.NativeClassPtr, "GetAchievementManagerMethod");
					Discord.FFIMethods.GetAchievementManagerMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord.FFIMethods.GetAchievementManagerMethod>.NativeClassPtr, 100667461);
					Discord.FFIMethods.GetAchievementManagerMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord.FFIMethods.GetAchievementManagerMethod>.NativeClassPtr, 100667462);
					Discord.FFIMethods.GetAchievementManagerMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord.FFIMethods.GetAchievementManagerMethod>.NativeClassPtr, 100667463);
					Discord.FFIMethods.GetAchievementManagerMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IntPtr_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord.FFIMethods.GetAchievementManagerMethod>.NativeClassPtr, 100667464);
				}

				// Token: 0x060022FD RID: 8957 RVA: 0x0009DB84 File Offset: 0x0009BD84
				[CallerCount(9)]
				[CachedScanResults(RefRangeStart = 52311, RefRangeEnd = 52320, XrefRangeStart = 52311, XrefRangeEnd = 52320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe GetAchievementManagerMethod(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Discord.FFIMethods.GetAchievementManagerMethod>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.FFIMethods.GetAchievementManagerMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060022FE RID: 8958 RVA: 0x0009DBE0 File Offset: 0x0009BDE0
				[CallerCount(0)]
				public unsafe IntPtr Invoke(IntPtr discordPtr)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref discordPtr;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.FFIMethods.GetAchievementManagerMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x060022FF RID: 8959 RVA: 0x0009DC2C File Offset: 0x0009BE2C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(IntPtr discordPtr, AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref discordPtr;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.FFIMethods.GetAchievementManagerMethod.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06002300 RID: 8960 RVA: 0x0009DC9C File Offset: 0x0009BE9C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IntPtr EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.FFIMethods.GetAchievementManagerMethod.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IntPtr_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x06002301 RID: 8961 RVA: 0x0000E7D4 File Offset: 0x0000C9D4
				public GetAchievementManagerMethod(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06002302 RID: 8962 RVA: 0x0000E7DD File Offset: 0x0000C9DD
				public static implicit operator Discord.FFIMethods.GetAchievementManagerMethod(Func<IntPtr, IntPtr> A_0)
				{
					return DelegateSupport.ConvertDelegate<Discord.FFIMethods.GetAchievementManagerMethod>(A_0);
				}

				// Token: 0x06002303 RID: 8963 RVA: 0x0000E7E5 File Offset: 0x0000C9E5
				public static Discord.FFIMethods.GetAchievementManagerMethod operator +(Discord.FFIMethods.GetAchievementManagerMethod A_0, Discord.FFIMethods.GetAchievementManagerMethod A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<Discord.FFIMethods.GetAchievementManagerMethod>();
				}

				// Token: 0x06002304 RID: 8964 RVA: 0x0000E7F3 File Offset: 0x0000C9F3
				public static Discord.FFIMethods.GetAchievementManagerMethod operator -(Discord.FFIMethods.GetAchievementManagerMethod A_0, Discord.FFIMethods.GetAchievementManagerMethod A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<Discord.FFIMethods.GetAchievementManagerMethod>();
					}
					return delegate2;
				}

				// Token: 0x04001A35 RID: 6709
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04001A36 RID: 6710
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_IntPtr_0;

				// Token: 0x04001A37 RID: 6711
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0;

				// Token: 0x04001A38 RID: 6712
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IntPtr_IAsyncResult_0;
			}
		}

		// Token: 0x02000202 RID: 514
		[StructLayout(2)]
		public struct FFICreateParams
		{
			// Token: 0x06001E89 RID: 7817 RVA: 0x0008FA18 File Offset: 0x0008DC18
			// Note: this type is marked as 'beforefieldinit'.
			static FFICreateParams()
			{
				Il2CppClassPointerStore<Discord.FFICreateParams>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Discord>.NativeClassPtr, "FFICreateParams");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Discord.FFICreateParams>.NativeClassPtr);
				Discord.FFICreateParams.NativeFieldInfoPtr_ClientId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord.FFICreateParams>.NativeClassPtr, "ClientId");
				Discord.FFICreateParams.NativeFieldInfoPtr_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord.FFICreateParams>.NativeClassPtr, "Flags");
				Discord.FFICreateParams.NativeFieldInfoPtr_Events = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord.FFICreateParams>.NativeClassPtr, "Events");
				Discord.FFICreateParams.NativeFieldInfoPtr_EventData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord.FFICreateParams>.NativeClassPtr, "EventData");
				Discord.FFICreateParams.NativeFieldInfoPtr_ApplicationEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord.FFICreateParams>.NativeClassPtr, "ApplicationEvents");
				Discord.FFICreateParams.NativeFieldInfoPtr_ApplicationVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord.FFICreateParams>.NativeClassPtr, "ApplicationVersion");
				Discord.FFICreateParams.NativeFieldInfoPtr_UserEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord.FFICreateParams>.NativeClassPtr, "UserEvents");
				Discord.FFICreateParams.NativeFieldInfoPtr_UserVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord.FFICreateParams>.NativeClassPtr, "UserVersion");
				Discord.FFICreateParams.NativeFieldInfoPtr_ImageEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord.FFICreateParams>.NativeClassPtr, "ImageEvents");
				Discord.FFICreateParams.NativeFieldInfoPtr_ImageVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord.FFICreateParams>.NativeClassPtr, "ImageVersion");
				Discord.FFICreateParams.NativeFieldInfoPtr_ActivityEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord.FFICreateParams>.NativeClassPtr, "ActivityEvents");
				Discord.FFICreateParams.NativeFieldInfoPtr_ActivityVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord.FFICreateParams>.NativeClassPtr, "ActivityVersion");
				Discord.FFICreateParams.NativeFieldInfoPtr_RelationshipEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord.FFICreateParams>.NativeClassPtr, "RelationshipEvents");
				Discord.FFICreateParams.NativeFieldInfoPtr_RelationshipVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord.FFICreateParams>.NativeClassPtr, "RelationshipVersion");
				Discord.FFICreateParams.NativeFieldInfoPtr_LobbyEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord.FFICreateParams>.NativeClassPtr, "LobbyEvents");
				Discord.FFICreateParams.NativeFieldInfoPtr_LobbyVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord.FFICreateParams>.NativeClassPtr, "LobbyVersion");
				Discord.FFICreateParams.NativeFieldInfoPtr_NetworkEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord.FFICreateParams>.NativeClassPtr, "NetworkEvents");
				Discord.FFICreateParams.NativeFieldInfoPtr_NetworkVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord.FFICreateParams>.NativeClassPtr, "NetworkVersion");
				Discord.FFICreateParams.NativeFieldInfoPtr_OverlayEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord.FFICreateParams>.NativeClassPtr, "OverlayEvents");
				Discord.FFICreateParams.NativeFieldInfoPtr_OverlayVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord.FFICreateParams>.NativeClassPtr, "OverlayVersion");
				Discord.FFICreateParams.NativeFieldInfoPtr_StorageEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord.FFICreateParams>.NativeClassPtr, "StorageEvents");
				Discord.FFICreateParams.NativeFieldInfoPtr_StorageVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord.FFICreateParams>.NativeClassPtr, "StorageVersion");
				Discord.FFICreateParams.NativeFieldInfoPtr_StoreEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord.FFICreateParams>.NativeClassPtr, "StoreEvents");
				Discord.FFICreateParams.NativeFieldInfoPtr_StoreVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord.FFICreateParams>.NativeClassPtr, "StoreVersion");
				Discord.FFICreateParams.NativeFieldInfoPtr_VoiceEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord.FFICreateParams>.NativeClassPtr, "VoiceEvents");
				Discord.FFICreateParams.NativeFieldInfoPtr_VoiceVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord.FFICreateParams>.NativeClassPtr, "VoiceVersion");
				Discord.FFICreateParams.NativeFieldInfoPtr_AchievementEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord.FFICreateParams>.NativeClassPtr, "AchievementEvents");
				Discord.FFICreateParams.NativeFieldInfoPtr_AchievementVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Discord.FFICreateParams>.NativeClassPtr, "AchievementVersion");
			}

			// Token: 0x06001E8A RID: 7818 RVA: 0x0000C48B File Offset: 0x0000A68B
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Discord.FFICreateParams>.NativeClassPtr, ref this));
			}

			// Token: 0x040017FC RID: 6140
			private static readonly IntPtr NativeFieldInfoPtr_ClientId;

			// Token: 0x040017FD RID: 6141
			private static readonly IntPtr NativeFieldInfoPtr_Flags;

			// Token: 0x040017FE RID: 6142
			private static readonly IntPtr NativeFieldInfoPtr_Events;

			// Token: 0x040017FF RID: 6143
			private static readonly IntPtr NativeFieldInfoPtr_EventData;

			// Token: 0x04001800 RID: 6144
			private static readonly IntPtr NativeFieldInfoPtr_ApplicationEvents;

			// Token: 0x04001801 RID: 6145
			private static readonly IntPtr NativeFieldInfoPtr_ApplicationVersion;

			// Token: 0x04001802 RID: 6146
			private static readonly IntPtr NativeFieldInfoPtr_UserEvents;

			// Token: 0x04001803 RID: 6147
			private static readonly IntPtr NativeFieldInfoPtr_UserVersion;

			// Token: 0x04001804 RID: 6148
			private static readonly IntPtr NativeFieldInfoPtr_ImageEvents;

			// Token: 0x04001805 RID: 6149
			private static readonly IntPtr NativeFieldInfoPtr_ImageVersion;

			// Token: 0x04001806 RID: 6150
			private static readonly IntPtr NativeFieldInfoPtr_ActivityEvents;

			// Token: 0x04001807 RID: 6151
			private static readonly IntPtr NativeFieldInfoPtr_ActivityVersion;

			// Token: 0x04001808 RID: 6152
			private static readonly IntPtr NativeFieldInfoPtr_RelationshipEvents;

			// Token: 0x04001809 RID: 6153
			private static readonly IntPtr NativeFieldInfoPtr_RelationshipVersion;

			// Token: 0x0400180A RID: 6154
			private static readonly IntPtr NativeFieldInfoPtr_LobbyEvents;

			// Token: 0x0400180B RID: 6155
			private static readonly IntPtr NativeFieldInfoPtr_LobbyVersion;

			// Token: 0x0400180C RID: 6156
			private static readonly IntPtr NativeFieldInfoPtr_NetworkEvents;

			// Token: 0x0400180D RID: 6157
			private static readonly IntPtr NativeFieldInfoPtr_NetworkVersion;

			// Token: 0x0400180E RID: 6158
			private static readonly IntPtr NativeFieldInfoPtr_OverlayEvents;

			// Token: 0x0400180F RID: 6159
			private static readonly IntPtr NativeFieldInfoPtr_OverlayVersion;

			// Token: 0x04001810 RID: 6160
			private static readonly IntPtr NativeFieldInfoPtr_StorageEvents;

			// Token: 0x04001811 RID: 6161
			private static readonly IntPtr NativeFieldInfoPtr_StorageVersion;

			// Token: 0x04001812 RID: 6162
			private static readonly IntPtr NativeFieldInfoPtr_StoreEvents;

			// Token: 0x04001813 RID: 6163
			private static readonly IntPtr NativeFieldInfoPtr_StoreVersion;

			// Token: 0x04001814 RID: 6164
			private static readonly IntPtr NativeFieldInfoPtr_VoiceEvents;

			// Token: 0x04001815 RID: 6165
			private static readonly IntPtr NativeFieldInfoPtr_VoiceVersion;

			// Token: 0x04001816 RID: 6166
			private static readonly IntPtr NativeFieldInfoPtr_AchievementEvents;

			// Token: 0x04001817 RID: 6167
			private static readonly IntPtr NativeFieldInfoPtr_AchievementVersion;

			// Token: 0x04001818 RID: 6168
			[FieldOffset(0)]
			public long ClientId;

			// Token: 0x04001819 RID: 6169
			[FieldOffset(8)]
			public ulong Flags;

			// Token: 0x0400181A RID: 6170
			[FieldOffset(16)]
			public IntPtr Events;

			// Token: 0x0400181B RID: 6171
			[FieldOffset(24)]
			public IntPtr EventData;

			// Token: 0x0400181C RID: 6172
			[FieldOffset(32)]
			public IntPtr ApplicationEvents;

			// Token: 0x0400181D RID: 6173
			[FieldOffset(40)]
			public uint ApplicationVersion;

			// Token: 0x0400181E RID: 6174
			[FieldOffset(48)]
			public IntPtr UserEvents;

			// Token: 0x0400181F RID: 6175
			[FieldOffset(56)]
			public uint UserVersion;

			// Token: 0x04001820 RID: 6176
			[FieldOffset(64)]
			public IntPtr ImageEvents;

			// Token: 0x04001821 RID: 6177
			[FieldOffset(72)]
			public uint ImageVersion;

			// Token: 0x04001822 RID: 6178
			[FieldOffset(80)]
			public IntPtr ActivityEvents;

			// Token: 0x04001823 RID: 6179
			[FieldOffset(88)]
			public uint ActivityVersion;

			// Token: 0x04001824 RID: 6180
			[FieldOffset(96)]
			public IntPtr RelationshipEvents;

			// Token: 0x04001825 RID: 6181
			[FieldOffset(104)]
			public uint RelationshipVersion;

			// Token: 0x04001826 RID: 6182
			[FieldOffset(112)]
			public IntPtr LobbyEvents;

			// Token: 0x04001827 RID: 6183
			[FieldOffset(120)]
			public uint LobbyVersion;

			// Token: 0x04001828 RID: 6184
			[FieldOffset(128)]
			public IntPtr NetworkEvents;

			// Token: 0x04001829 RID: 6185
			[FieldOffset(136)]
			public uint NetworkVersion;

			// Token: 0x0400182A RID: 6186
			[FieldOffset(144)]
			public IntPtr OverlayEvents;

			// Token: 0x0400182B RID: 6187
			[FieldOffset(152)]
			public uint OverlayVersion;

			// Token: 0x0400182C RID: 6188
			[FieldOffset(160)]
			public IntPtr StorageEvents;

			// Token: 0x0400182D RID: 6189
			[FieldOffset(168)]
			public uint StorageVersion;

			// Token: 0x0400182E RID: 6190
			[FieldOffset(176)]
			public IntPtr StoreEvents;

			// Token: 0x0400182F RID: 6191
			[FieldOffset(184)]
			public uint StoreVersion;

			// Token: 0x04001830 RID: 6192
			[FieldOffset(192)]
			public IntPtr VoiceEvents;

			// Token: 0x04001831 RID: 6193
			[FieldOffset(200)]
			public uint VoiceVersion;

			// Token: 0x04001832 RID: 6194
			[FieldOffset(208)]
			public IntPtr AchievementEvents;

			// Token: 0x04001833 RID: 6195
			[FieldOffset(216)]
			public uint AchievementVersion;
		}

		// Token: 0x02000203 RID: 515
		public sealed class SetLogHookHandler : MulticastDelegate
		{
			// Token: 0x06001E8B RID: 7819 RVA: 0x0008FC74 File Offset: 0x0008DE74
			// Note: this type is marked as 'beforefieldinit'.
			static SetLogHookHandler()
			{
				Il2CppClassPointerStore<Discord.SetLogHookHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Discord>.NativeClassPtr, "SetLogHookHandler");
				Discord.SetLogHookHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord.SetLogHookHandler>.NativeClassPtr, 100667465);
				Discord.SetLogHookHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_LogLevel_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord.SetLogHookHandler>.NativeClassPtr, 100667466);
				Discord.SetLogHookHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_LogLevel_String_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord.SetLogHookHandler>.NativeClassPtr, 100667467);
				Discord.SetLogHookHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Discord.SetLogHookHandler>.NativeClassPtr, 100667468);
			}

			// Token: 0x06001E8C RID: 7820 RVA: 0x0008FCE8 File Offset: 0x0008DEE8
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 52325, RefRangeEnd = 52342, XrefRangeStart = 52322, XrefRangeEnd = 52325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SetLogHookHandler(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Discord.SetLogHookHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.SetLogHookHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E8D RID: 7821 RVA: 0x0008FD44 File Offset: 0x0008DF44
			[CallerCount(0)]
			public unsafe void Invoke(LogLevel level, string message)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(level);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.SetLogHookHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_LogLevel_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E8E RID: 7822 RVA: 0x0008FD98 File Offset: 0x0008DF98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52342, XrefRangeEnd = 52346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(LogLevel level, string message, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(level);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.SetLogHookHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_LogLevel_String_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001E8F RID: 7823 RVA: 0x0008FE20 File Offset: 0x0008E020
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Discord.SetLogHookHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001E90 RID: 7824 RVA: 0x0000C49D File Offset: 0x0000A69D
			public SetLogHookHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001E91 RID: 7825 RVA: 0x0000C4A6 File Offset: 0x0000A6A6
			public static implicit operator Discord.SetLogHookHandler(Action<LogLevel, string> A_0)
			{
				return DelegateSupport.ConvertDelegate<Discord.SetLogHookHandler>(A_0);
			}

			// Token: 0x06001E92 RID: 7826 RVA: 0x0000C4AE File Offset: 0x0000A6AE
			public static Discord.SetLogHookHandler operator +(Discord.SetLogHookHandler A_0, Discord.SetLogHookHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<Discord.SetLogHookHandler>();
			}

			// Token: 0x06001E93 RID: 7827 RVA: 0x0000C4BC File Offset: 0x0000A6BC
			public static Discord.SetLogHookHandler operator -(Discord.SetLogHookHandler A_0, Discord.SetLogHookHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<Discord.SetLogHookHandler>();
				}
				return delegate2;
			}

			// Token: 0x04001834 RID: 6196
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001835 RID: 6197
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_LogLevel_String_0;

			// Token: 0x04001836 RID: 6198
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_LogLevel_String_AsyncCallback_Object_0;

			// Token: 0x04001837 RID: 6199
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
