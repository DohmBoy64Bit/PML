using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace Polytoria.Datamodel.Services
{
	// Token: 0x020002C3 RID: 707
	public class CoreUIService : MonoBehaviour
	{
		// Token: 0x06003E6D RID: 15981 RVA: 0x00118D90 File Offset: 0x00116F90
		// Note: this type is marked as 'beforefieldinit'.
		static CoreUIService()
		{
			Il2CppClassPointerStore<CoreUIService>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Services", "CoreUIService");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CoreUIService>.NativeClassPtr);
			CoreUIService.NativeFieldInfoPtr__Instance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreUIService>.NativeClassPtr, "<Instance>k__BackingField");
			CoreUIService.NativeFieldInfoPtr_userCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreUIService>.NativeClassPtr, "userCard");
			CoreUIService.NativeFieldInfoPtr_chat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreUIService>.NativeClassPtr, "chat");
			CoreUIService.NativeFieldInfoPtr_healthBar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreUIService>.NativeClassPtr, "healthBar");
			CoreUIService.NativeFieldInfoPtr_leaderboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreUIService>.NativeClassPtr, "leaderboard");
			CoreUIService.NativeFieldInfoPtr_hotbar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreUIService>.NativeClassPtr, "hotbar");
			CoreUIService.NativeFieldInfoPtr_menuButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreUIService>.NativeClassPtr, "menuButton");
			CoreUIService.NativeFieldInfoPtr_chatButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreUIService>.NativeClassPtr, "chatButton");
			CoreUIService.NativeFieldInfoPtr_resetButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreUIService>.NativeClassPtr, "resetButton");
			CoreUIService.NativeMethodInfoPtr_get_Instance_Public_Static_get_CoreUIService_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUIService>.NativeClassPtr, 100672917);
			CoreUIService.NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_CoreUIService_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUIService>.NativeClassPtr, 100672918);
			CoreUIService.NativeMethodInfoPtr_get_UserCardEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUIService>.NativeClassPtr, 100672919);
			CoreUIService.NativeMethodInfoPtr_set_UserCardEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUIService>.NativeClassPtr, 100672920);
			CoreUIService.NativeMethodInfoPtr_get_ChatEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUIService>.NativeClassPtr, 100672921);
			CoreUIService.NativeMethodInfoPtr_set_ChatEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUIService>.NativeClassPtr, 100672922);
			CoreUIService.NativeMethodInfoPtr_get_HealthBarEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUIService>.NativeClassPtr, 100672923);
			CoreUIService.NativeMethodInfoPtr_set_HealthBarEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUIService>.NativeClassPtr, 100672924);
			CoreUIService.NativeMethodInfoPtr_get_LeaderboardEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUIService>.NativeClassPtr, 100672925);
			CoreUIService.NativeMethodInfoPtr_set_LeaderboardEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUIService>.NativeClassPtr, 100672926);
			CoreUIService.NativeMethodInfoPtr_get_HotbarEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUIService>.NativeClassPtr, 100672927);
			CoreUIService.NativeMethodInfoPtr_set_HotbarEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUIService>.NativeClassPtr, 100672928);
			CoreUIService.NativeMethodInfoPtr_get_MenuButtonEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUIService>.NativeClassPtr, 100672929);
			CoreUIService.NativeMethodInfoPtr_set_MenuButtonEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUIService>.NativeClassPtr, 100672930);
			CoreUIService.NativeMethodInfoPtr_get_CanRespawn_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUIService>.NativeClassPtr, 100672931);
			CoreUIService.NativeMethodInfoPtr_set_CanRespawn_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUIService>.NativeClassPtr, 100672932);
			CoreUIService.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUIService>.NativeClassPtr, 100672934);
			CoreUIService.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreUIService>.NativeClassPtr, 100672933);
		}

		// Token: 0x17001587 RID: 5511
		// (get) Token: 0x06003E6E RID: 15982 RVA: 0x00118FDC File Offset: 0x001171DC
		// (set) Token: 0x06003E6F RID: 15983 RVA: 0x00119010 File Offset: 0x00117210
		public unsafe static CoreUIService Instance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124075, XrefRangeEnd = 124077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUIService.NativeMethodInfoPtr_get_Instance_Public_Static_get_CoreUIService_0, 0, (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CoreUIService>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124077, XrefRangeEnd = 124081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUIService.NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_CoreUIService_0, 0, (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001588 RID: 5512
		// (get) Token: 0x06003E70 RID: 15984 RVA: 0x00119048 File Offset: 0x00117248
		// (set) Token: 0x06003E71 RID: 15985 RVA: 0x00119084 File Offset: 0x00117284
		public unsafe bool UserCardEnabled
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 124083, RefRangeEnd = 124084, XrefRangeStart = 124081, XrefRangeEnd = 124083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUIService.NativeMethodInfoPtr_get_UserCardEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 124086, RefRangeEnd = 124087, XrefRangeStart = 124084, XrefRangeEnd = 124086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUIService.NativeMethodInfoPtr_set_UserCardEnabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001589 RID: 5513
		// (get) Token: 0x06003E72 RID: 15986 RVA: 0x001190C4 File Offset: 0x001172C4
		// (set) Token: 0x06003E73 RID: 15987 RVA: 0x00119100 File Offset: 0x00117300
		public unsafe bool ChatEnabled
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 124089, RefRangeEnd = 124090, XrefRangeStart = 124087, XrefRangeEnd = 124089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUIService.NativeMethodInfoPtr_get_ChatEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 124093, RefRangeEnd = 124094, XrefRangeStart = 124090, XrefRangeEnd = 124093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUIService.NativeMethodInfoPtr_set_ChatEnabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700158A RID: 5514
		// (get) Token: 0x06003E74 RID: 15988 RVA: 0x00119140 File Offset: 0x00117340
		// (set) Token: 0x06003E75 RID: 15989 RVA: 0x0011917C File Offset: 0x0011737C
		public unsafe bool HealthBarEnabled
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 124096, RefRangeEnd = 124097, XrefRangeStart = 124094, XrefRangeEnd = 124096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUIService.NativeMethodInfoPtr_get_HealthBarEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 124099, RefRangeEnd = 124100, XrefRangeStart = 124097, XrefRangeEnd = 124099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUIService.NativeMethodInfoPtr_set_HealthBarEnabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700158B RID: 5515
		// (get) Token: 0x06003E76 RID: 15990 RVA: 0x001191BC File Offset: 0x001173BC
		// (set) Token: 0x06003E77 RID: 15991 RVA: 0x001191F8 File Offset: 0x001173F8
		public unsafe bool LeaderboardEnabled
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 124102, RefRangeEnd = 124103, XrefRangeStart = 124100, XrefRangeEnd = 124102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUIService.NativeMethodInfoPtr_get_LeaderboardEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 124105, RefRangeEnd = 124106, XrefRangeStart = 124103, XrefRangeEnd = 124105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUIService.NativeMethodInfoPtr_set_LeaderboardEnabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700158C RID: 5516
		// (get) Token: 0x06003E78 RID: 15992 RVA: 0x00119238 File Offset: 0x00117438
		// (set) Token: 0x06003E79 RID: 15993 RVA: 0x00119274 File Offset: 0x00117474
		public unsafe bool HotbarEnabled
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 124108, RefRangeEnd = 124109, XrefRangeStart = 124106, XrefRangeEnd = 124108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUIService.NativeMethodInfoPtr_get_HotbarEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 124111, RefRangeEnd = 124112, XrefRangeStart = 124109, XrefRangeEnd = 124111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUIService.NativeMethodInfoPtr_set_HotbarEnabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700158D RID: 5517
		// (get) Token: 0x06003E7A RID: 15994 RVA: 0x001192B4 File Offset: 0x001174B4
		// (set) Token: 0x06003E7B RID: 15995 RVA: 0x001192F0 File Offset: 0x001174F0
		public unsafe bool MenuButtonEnabled
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 124114, RefRangeEnd = 124115, XrefRangeStart = 124112, XrefRangeEnd = 124114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUIService.NativeMethodInfoPtr_get_MenuButtonEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 124117, RefRangeEnd = 124118, XrefRangeStart = 124115, XrefRangeEnd = 124117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUIService.NativeMethodInfoPtr_set_MenuButtonEnabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700158E RID: 5518
		// (get) Token: 0x06003E7C RID: 15996 RVA: 0x00119330 File Offset: 0x00117530
		// (set) Token: 0x06003E7D RID: 15997 RVA: 0x0011936C File Offset: 0x0011756C
		public unsafe bool CanRespawn
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 124118, RefRangeEnd = 124119, XrefRangeStart = 124118, XrefRangeEnd = 124118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUIService.NativeMethodInfoPtr_get_CanRespawn_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 124121, RefRangeEnd = 124122, XrefRangeStart = 124119, XrefRangeEnd = 124121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUIService.NativeMethodInfoPtr_set_CanRespawn_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003E7E RID: 15998 RVA: 0x001193AC File Offset: 0x001175AC
		[CallerCount(61)]
		[CachedScanResults(RefRangeStart = 10788, RefRangeEnd = 10849, XrefRangeStart = 10788, XrefRangeEnd = 10849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CoreUIService()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CoreUIService>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUIService.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E7F RID: 15999 RVA: 0x001193E8 File Offset: 0x001175E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124122, XrefRangeEnd = 124126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreUIService.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E80 RID: 16000 RVA: 0x00017E87 File Offset: 0x00016087
		public CoreUIService(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700157E RID: 5502
		// (get) Token: 0x06003E81 RID: 16001 RVA: 0x0011941C File Offset: 0x0011761C
		// (set) Token: 0x06003E82 RID: 16002 RVA: 0x00017E90 File Offset: 0x00016090
		public unsafe static CoreUIService _Instance_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreUIService.NativeFieldInfoPtr__Instance_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CoreUIService>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreUIService.NativeFieldInfoPtr__Instance_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700157F RID: 5503
		// (get) Token: 0x06003E83 RID: 16003 RVA: 0x00119444 File Offset: 0x00117644
		// (set) Token: 0x06003E84 RID: 16004 RVA: 0x00017EA2 File Offset: 0x000160A2
		public unsafe GameObject userCard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoreUIService.NativeFieldInfoPtr_userCard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoreUIService.NativeFieldInfoPtr_userCard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001580 RID: 5504
		// (get) Token: 0x06003E85 RID: 16005 RVA: 0x00119474 File Offset: 0x00117674
		// (set) Token: 0x06003E86 RID: 16006 RVA: 0x00017EC1 File Offset: 0x000160C1
		public unsafe GameObject chat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoreUIService.NativeFieldInfoPtr_chat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoreUIService.NativeFieldInfoPtr_chat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001581 RID: 5505
		// (get) Token: 0x06003E87 RID: 16007 RVA: 0x001194A4 File Offset: 0x001176A4
		// (set) Token: 0x06003E88 RID: 16008 RVA: 0x00017EE0 File Offset: 0x000160E0
		public unsafe GameObject healthBar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoreUIService.NativeFieldInfoPtr_healthBar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoreUIService.NativeFieldInfoPtr_healthBar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001582 RID: 5506
		// (get) Token: 0x06003E89 RID: 16009 RVA: 0x001194D4 File Offset: 0x001176D4
		// (set) Token: 0x06003E8A RID: 16010 RVA: 0x00017EFF File Offset: 0x000160FF
		public unsafe GameObject leaderboard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoreUIService.NativeFieldInfoPtr_leaderboard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoreUIService.NativeFieldInfoPtr_leaderboard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001583 RID: 5507
		// (get) Token: 0x06003E8B RID: 16011 RVA: 0x00119504 File Offset: 0x00117704
		// (set) Token: 0x06003E8C RID: 16012 RVA: 0x00017F1E File Offset: 0x0001611E
		public unsafe GameObject hotbar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoreUIService.NativeFieldInfoPtr_hotbar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoreUIService.NativeFieldInfoPtr_hotbar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001584 RID: 5508
		// (get) Token: 0x06003E8D RID: 16013 RVA: 0x00119534 File Offset: 0x00117734
		// (set) Token: 0x06003E8E RID: 16014 RVA: 0x00017F3D File Offset: 0x0001613D
		public unsafe GameObject menuButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoreUIService.NativeFieldInfoPtr_menuButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoreUIService.NativeFieldInfoPtr_menuButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001585 RID: 5509
		// (get) Token: 0x06003E8F RID: 16015 RVA: 0x00119564 File Offset: 0x00117764
		// (set) Token: 0x06003E90 RID: 16016 RVA: 0x00017F5C File Offset: 0x0001615C
		public unsafe GameObject chatButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoreUIService.NativeFieldInfoPtr_chatButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoreUIService.NativeFieldInfoPtr_chatButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001586 RID: 5510
		// (get) Token: 0x06003E91 RID: 16017 RVA: 0x00119594 File Offset: 0x00117794
		// (set) Token: 0x06003E92 RID: 16018 RVA: 0x00017F7B File Offset: 0x0001617B
		public unsafe Button resetButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoreUIService.NativeFieldInfoPtr_resetButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoreUIService.NativeFieldInfoPtr_resetButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003091 RID: 12433
		private static readonly IntPtr NativeFieldInfoPtr__Instance_k__BackingField;

		// Token: 0x04003092 RID: 12434
		private static readonly IntPtr NativeFieldInfoPtr_userCard;

		// Token: 0x04003093 RID: 12435
		private static readonly IntPtr NativeFieldInfoPtr_chat;

		// Token: 0x04003094 RID: 12436
		private static readonly IntPtr NativeFieldInfoPtr_healthBar;

		// Token: 0x04003095 RID: 12437
		private static readonly IntPtr NativeFieldInfoPtr_leaderboard;

		// Token: 0x04003096 RID: 12438
		private static readonly IntPtr NativeFieldInfoPtr_hotbar;

		// Token: 0x04003097 RID: 12439
		private static readonly IntPtr NativeFieldInfoPtr_menuButton;

		// Token: 0x04003098 RID: 12440
		private static readonly IntPtr NativeFieldInfoPtr_chatButton;

		// Token: 0x04003099 RID: 12441
		private static readonly IntPtr NativeFieldInfoPtr_resetButton;

		// Token: 0x0400309A RID: 12442
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_CoreUIService_0;

		// Token: 0x0400309B RID: 12443
		private static readonly IntPtr NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_CoreUIService_0;

		// Token: 0x0400309C RID: 12444
		private static readonly IntPtr NativeMethodInfoPtr_get_UserCardEnabled_Public_get_Boolean_0;

		// Token: 0x0400309D RID: 12445
		private static readonly IntPtr NativeMethodInfoPtr_set_UserCardEnabled_Public_set_Void_Boolean_0;

		// Token: 0x0400309E RID: 12446
		private static readonly IntPtr NativeMethodInfoPtr_get_ChatEnabled_Public_get_Boolean_0;

		// Token: 0x0400309F RID: 12447
		private static readonly IntPtr NativeMethodInfoPtr_set_ChatEnabled_Public_set_Void_Boolean_0;

		// Token: 0x040030A0 RID: 12448
		private static readonly IntPtr NativeMethodInfoPtr_get_HealthBarEnabled_Public_get_Boolean_0;

		// Token: 0x040030A1 RID: 12449
		private static readonly IntPtr NativeMethodInfoPtr_set_HealthBarEnabled_Public_set_Void_Boolean_0;

		// Token: 0x040030A2 RID: 12450
		private static readonly IntPtr NativeMethodInfoPtr_get_LeaderboardEnabled_Public_get_Boolean_0;

		// Token: 0x040030A3 RID: 12451
		private static readonly IntPtr NativeMethodInfoPtr_set_LeaderboardEnabled_Public_set_Void_Boolean_0;

		// Token: 0x040030A4 RID: 12452
		private static readonly IntPtr NativeMethodInfoPtr_get_HotbarEnabled_Public_get_Boolean_0;

		// Token: 0x040030A5 RID: 12453
		private static readonly IntPtr NativeMethodInfoPtr_set_HotbarEnabled_Public_set_Void_Boolean_0;

		// Token: 0x040030A6 RID: 12454
		private static readonly IntPtr NativeMethodInfoPtr_get_MenuButtonEnabled_Public_get_Boolean_0;

		// Token: 0x040030A7 RID: 12455
		private static readonly IntPtr NativeMethodInfoPtr_set_MenuButtonEnabled_Public_set_Void_Boolean_0;

		// Token: 0x040030A8 RID: 12456
		private static readonly IntPtr NativeMethodInfoPtr_get_CanRespawn_Public_get_Boolean_0;

		// Token: 0x040030A9 RID: 12457
		private static readonly IntPtr NativeMethodInfoPtr_set_CanRespawn_Public_set_Void_Boolean_0;

		// Token: 0x040030AA RID: 12458
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040030AB RID: 12459
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
	}
}
