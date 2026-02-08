using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Mirror;
using UnityEngine;

namespace Polytoria.Datamodel
{
	// Token: 0x020002A1 RID: 673
	public class PlayerDefaults : Instance
	{
		// Token: 0x060038D9 RID: 14553 RVA: 0x00101724 File Offset: 0x000FF924
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerDefaults()
		{
			Il2CppClassPointerStore<PlayerDefaults>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel", "PlayerDefaults");
			PlayerDefaults.NativeFieldInfoPtr_maxHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDefaults>.NativeClassPtr, "maxHealth");
			PlayerDefaults.NativeFieldInfoPtr_walkSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDefaults>.NativeClassPtr, "walkSpeed");
			PlayerDefaults.NativeFieldInfoPtr_sprintSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDefaults>.NativeClassPtr, "sprintSpeed");
			PlayerDefaults.NativeFieldInfoPtr_staminaEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDefaults>.NativeClassPtr, "staminaEnabled");
			PlayerDefaults.NativeFieldInfoPtr_stamina = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDefaults>.NativeClassPtr, "stamina");
			PlayerDefaults.NativeFieldInfoPtr_maxStamina = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDefaults>.NativeClassPtr, "maxStamina");
			PlayerDefaults.NativeFieldInfoPtr_staminaRegen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDefaults>.NativeClassPtr, "staminaRegen");
			PlayerDefaults.NativeFieldInfoPtr_jumpPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDefaults>.NativeClassPtr, "jumpPower");
			PlayerDefaults.NativeFieldInfoPtr_respawnTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDefaults>.NativeClassPtr, "respawnTime");
			PlayerDefaults.NativeFieldInfoPtr_chatColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDefaults>.NativeClassPtr, "chatColor");
			PlayerDefaults.NativeMethodInfoPtr_get_MaxHealth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDefaults>.NativeClassPtr, 100671971);
			PlayerDefaults.NativeMethodInfoPtr_set_MaxHealth_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDefaults>.NativeClassPtr, 100671972);
			PlayerDefaults.NativeMethodInfoPtr_get_WalkSpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDefaults>.NativeClassPtr, 100671973);
			PlayerDefaults.NativeMethodInfoPtr_set_WalkSpeed_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDefaults>.NativeClassPtr, 100671974);
			PlayerDefaults.NativeMethodInfoPtr_get_SprintSpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDefaults>.NativeClassPtr, 100671975);
			PlayerDefaults.NativeMethodInfoPtr_set_SprintSpeed_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDefaults>.NativeClassPtr, 100671976);
			PlayerDefaults.NativeMethodInfoPtr_get_StaminaEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDefaults>.NativeClassPtr, 100671977);
			PlayerDefaults.NativeMethodInfoPtr_set_StaminaEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDefaults>.NativeClassPtr, 100671978);
			PlayerDefaults.NativeMethodInfoPtr_get_Stamina_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDefaults>.NativeClassPtr, 100671979);
			PlayerDefaults.NativeMethodInfoPtr_set_Stamina_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDefaults>.NativeClassPtr, 100671980);
			PlayerDefaults.NativeMethodInfoPtr_get_MaxStamina_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDefaults>.NativeClassPtr, 100671981);
			PlayerDefaults.NativeMethodInfoPtr_set_MaxStamina_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDefaults>.NativeClassPtr, 100671982);
			PlayerDefaults.NativeMethodInfoPtr_get_StaminaRegen_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDefaults>.NativeClassPtr, 100671983);
			PlayerDefaults.NativeMethodInfoPtr_set_StaminaRegen_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDefaults>.NativeClassPtr, 100671984);
			PlayerDefaults.NativeMethodInfoPtr_get_JumpPower_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDefaults>.NativeClassPtr, 100671985);
			PlayerDefaults.NativeMethodInfoPtr_set_JumpPower_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDefaults>.NativeClassPtr, 100671986);
			PlayerDefaults.NativeMethodInfoPtr_get_RespawnTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDefaults>.NativeClassPtr, 100671987);
			PlayerDefaults.NativeMethodInfoPtr_set_RespawnTime_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDefaults>.NativeClassPtr, 100671988);
			PlayerDefaults.NativeMethodInfoPtr_get_ChatColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDefaults>.NativeClassPtr, 100671989);
			PlayerDefaults.NativeMethodInfoPtr_set_ChatColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDefaults>.NativeClassPtr, 100671990);
			PlayerDefaults.NativeMethodInfoPtr_get_NetworkmaxHealth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDefaults>.NativeClassPtr, 100671997);
			PlayerDefaults.NativeMethodInfoPtr_set_NetworkmaxHealth_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDefaults>.NativeClassPtr, 100671998);
			PlayerDefaults.NativeMethodInfoPtr_get_NetworkwalkSpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDefaults>.NativeClassPtr, 100671999);
			PlayerDefaults.NativeMethodInfoPtr_set_NetworkwalkSpeed_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDefaults>.NativeClassPtr, 100672000);
			PlayerDefaults.NativeMethodInfoPtr_get_NetworksprintSpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDefaults>.NativeClassPtr, 100672001);
			PlayerDefaults.NativeMethodInfoPtr_set_NetworksprintSpeed_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDefaults>.NativeClassPtr, 100672002);
			PlayerDefaults.NativeMethodInfoPtr_get_NetworkstaminaEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDefaults>.NativeClassPtr, 100672003);
			PlayerDefaults.NativeMethodInfoPtr_set_NetworkstaminaEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDefaults>.NativeClassPtr, 100672004);
			PlayerDefaults.NativeMethodInfoPtr_get_Networkstamina_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDefaults>.NativeClassPtr, 100672005);
			PlayerDefaults.NativeMethodInfoPtr_set_Networkstamina_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDefaults>.NativeClassPtr, 100672006);
			PlayerDefaults.NativeMethodInfoPtr_get_NetworkmaxStamina_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDefaults>.NativeClassPtr, 100672007);
			PlayerDefaults.NativeMethodInfoPtr_set_NetworkmaxStamina_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDefaults>.NativeClassPtr, 100672008);
			PlayerDefaults.NativeMethodInfoPtr_get_NetworkstaminaRegen_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDefaults>.NativeClassPtr, 100672009);
			PlayerDefaults.NativeMethodInfoPtr_set_NetworkstaminaRegen_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDefaults>.NativeClassPtr, 100672010);
			PlayerDefaults.NativeMethodInfoPtr_get_NetworkjumpPower_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDefaults>.NativeClassPtr, 100672011);
			PlayerDefaults.NativeMethodInfoPtr_set_NetworkjumpPower_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDefaults>.NativeClassPtr, 100672012);
			PlayerDefaults.NativeMethodInfoPtr_get_NetworkrespawnTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDefaults>.NativeClassPtr, 100672013);
			PlayerDefaults.NativeMethodInfoPtr_set_NetworkrespawnTime_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDefaults>.NativeClassPtr, 100672014);
			PlayerDefaults.NativeMethodInfoPtr_get_NetworkchatColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDefaults>.NativeClassPtr, 100672015);
			PlayerDefaults.NativeMethodInfoPtr_set_NetworkchatColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDefaults>.NativeClassPtr, 100672016);
			PlayerDefaults.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDefaults>.NativeClassPtr, 100671995);
			PlayerDefaults.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDefaults>.NativeClassPtr, 100671991);
			PlayerDefaults.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDefaults>.NativeClassPtr, 100671992);
			PlayerDefaults.NativeMethodInfoPtr_LoadDefaults_Public_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDefaults>.NativeClassPtr, 100671993);
			PlayerDefaults.NativeMethodInfoPtr_CmdLoadDefaults_Private_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDefaults>.NativeClassPtr, 100671994);
			PlayerDefaults.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDefaults>.NativeClassPtr, 100671996);
			PlayerDefaults.NativeMethodInfoPtr_UserCode_CmdLoadDefaults__Player_Protected_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDefaults>.NativeClassPtr, 100672017);
			PlayerDefaults.NativeMethodInfoPtr_InvokeUserCode_CmdLoadDefaults__Player_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDefaults>.NativeClassPtr, 100672018);
			PlayerDefaults.NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDefaults>.NativeClassPtr, 100672020);
			PlayerDefaults.NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDefaults>.NativeClassPtr, 100672021);
		}

		// Token: 0x170013C4 RID: 5060
		// (get) Token: 0x060038DA RID: 14554 RVA: 0x00101BFC File Offset: 0x000FFDFC
		// (set) Token: 0x060038DB RID: 14555 RVA: 0x00101C38 File Offset: 0x000FFE38
		public unsafe float MaxHealth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDefaults.NativeMethodInfoPtr_get_MaxHealth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 115990, RefRangeEnd = 115991, XrefRangeStart = 115984, XrefRangeEnd = 115990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDefaults.NativeMethodInfoPtr_set_MaxHealth_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170013C5 RID: 5061
		// (get) Token: 0x060038DC RID: 14556 RVA: 0x00101C78 File Offset: 0x000FFE78
		// (set) Token: 0x060038DD RID: 14557 RVA: 0x00101CB4 File Offset: 0x000FFEB4
		public unsafe float WalkSpeed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDefaults.NativeMethodInfoPtr_get_WalkSpeed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 115997, RefRangeEnd = 115998, XrefRangeStart = 115991, XrefRangeEnd = 115997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDefaults.NativeMethodInfoPtr_set_WalkSpeed_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170013C6 RID: 5062
		// (get) Token: 0x060038DE RID: 14558 RVA: 0x00101CF4 File Offset: 0x000FFEF4
		// (set) Token: 0x060038DF RID: 14559 RVA: 0x00101D30 File Offset: 0x000FFF30
		public unsafe float SprintSpeed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDefaults.NativeMethodInfoPtr_get_SprintSpeed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 116004, RefRangeEnd = 116005, XrefRangeStart = 115998, XrefRangeEnd = 116004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDefaults.NativeMethodInfoPtr_set_SprintSpeed_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170013C7 RID: 5063
		// (get) Token: 0x060038E0 RID: 14560 RVA: 0x00101D70 File Offset: 0x000FFF70
		// (set) Token: 0x060038E1 RID: 14561 RVA: 0x00101DAC File Offset: 0x000FFFAC
		public unsafe bool StaminaEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDefaults.NativeMethodInfoPtr_get_StaminaEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 116011, RefRangeEnd = 116012, XrefRangeStart = 116005, XrefRangeEnd = 116011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDefaults.NativeMethodInfoPtr_set_StaminaEnabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170013C8 RID: 5064
		// (get) Token: 0x060038E2 RID: 14562 RVA: 0x00101DEC File Offset: 0x000FFFEC
		// (set) Token: 0x060038E3 RID: 14563 RVA: 0x00101E28 File Offset: 0x00100028
		public unsafe float Stamina
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDefaults.NativeMethodInfoPtr_get_Stamina_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 116018, RefRangeEnd = 116019, XrefRangeStart = 116012, XrefRangeEnd = 116018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDefaults.NativeMethodInfoPtr_set_Stamina_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170013C9 RID: 5065
		// (get) Token: 0x060038E4 RID: 14564 RVA: 0x00101E68 File Offset: 0x00100068
		// (set) Token: 0x060038E5 RID: 14565 RVA: 0x00101EA4 File Offset: 0x001000A4
		public unsafe float MaxStamina
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDefaults.NativeMethodInfoPtr_get_MaxStamina_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 116025, RefRangeEnd = 116026, XrefRangeStart = 116019, XrefRangeEnd = 116025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDefaults.NativeMethodInfoPtr_set_MaxStamina_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170013CA RID: 5066
		// (get) Token: 0x060038E6 RID: 14566 RVA: 0x00101EE4 File Offset: 0x001000E4
		// (set) Token: 0x060038E7 RID: 14567 RVA: 0x00101F20 File Offset: 0x00100120
		public unsafe float StaminaRegen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDefaults.NativeMethodInfoPtr_get_StaminaRegen_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 116032, RefRangeEnd = 116033, XrefRangeStart = 116026, XrefRangeEnd = 116032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDefaults.NativeMethodInfoPtr_set_StaminaRegen_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170013CB RID: 5067
		// (get) Token: 0x060038E8 RID: 14568 RVA: 0x00101F60 File Offset: 0x00100160
		// (set) Token: 0x060038E9 RID: 14569 RVA: 0x00101F9C File Offset: 0x0010019C
		public unsafe float JumpPower
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDefaults.NativeMethodInfoPtr_get_JumpPower_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 116039, RefRangeEnd = 116040, XrefRangeStart = 116033, XrefRangeEnd = 116039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDefaults.NativeMethodInfoPtr_set_JumpPower_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170013CC RID: 5068
		// (get) Token: 0x060038EA RID: 14570 RVA: 0x00101FDC File Offset: 0x001001DC
		// (set) Token: 0x060038EB RID: 14571 RVA: 0x00102018 File Offset: 0x00100218
		public unsafe float RespawnTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDefaults.NativeMethodInfoPtr_get_RespawnTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 116046, RefRangeEnd = 116047, XrefRangeStart = 116040, XrefRangeEnd = 116046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDefaults.NativeMethodInfoPtr_set_RespawnTime_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170013CD RID: 5069
		// (get) Token: 0x060038EC RID: 14572 RVA: 0x00102058 File Offset: 0x00100258
		// (set) Token: 0x060038ED RID: 14573 RVA: 0x00102098 File Offset: 0x00100298
		public unsafe Color ChatColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDefaults.NativeMethodInfoPtr_get_ChatColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 116053, RefRangeEnd = 116054, XrefRangeStart = 116047, XrefRangeEnd = 116053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDefaults.NativeMethodInfoPtr_set_ChatColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170013CE RID: 5070
		// (get) Token: 0x060038EE RID: 14574 RVA: 0x001020DC File Offset: 0x001002DC
		// (set) Token: 0x060038EF RID: 14575 RVA: 0x00102118 File Offset: 0x00100318
		public unsafe float NetworkmaxHealth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDefaults.NativeMethodInfoPtr_get_NetworkmaxHealth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 115990, RefRangeEnd = 115991, XrefRangeStart = 115990, XrefRangeEnd = 115991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDefaults.NativeMethodInfoPtr_set_NetworkmaxHealth_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170013CF RID: 5071
		// (get) Token: 0x060038F0 RID: 14576 RVA: 0x00102158 File Offset: 0x00100358
		// (set) Token: 0x060038F1 RID: 14577 RVA: 0x00102194 File Offset: 0x00100394
		public unsafe float NetworkwalkSpeed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDefaults.NativeMethodInfoPtr_get_NetworkwalkSpeed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 115997, RefRangeEnd = 115998, XrefRangeStart = 115997, XrefRangeEnd = 115998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDefaults.NativeMethodInfoPtr_set_NetworkwalkSpeed_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170013D0 RID: 5072
		// (get) Token: 0x060038F2 RID: 14578 RVA: 0x001021D4 File Offset: 0x001003D4
		// (set) Token: 0x060038F3 RID: 14579 RVA: 0x00102210 File Offset: 0x00100410
		public unsafe float NetworksprintSpeed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDefaults.NativeMethodInfoPtr_get_NetworksprintSpeed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 116004, RefRangeEnd = 116005, XrefRangeStart = 116004, XrefRangeEnd = 116005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDefaults.NativeMethodInfoPtr_set_NetworksprintSpeed_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170013D1 RID: 5073
		// (get) Token: 0x060038F4 RID: 14580 RVA: 0x00102250 File Offset: 0x00100450
		// (set) Token: 0x060038F5 RID: 14581 RVA: 0x0010228C File Offset: 0x0010048C
		public unsafe bool NetworkstaminaEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDefaults.NativeMethodInfoPtr_get_NetworkstaminaEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 116011, RefRangeEnd = 116012, XrefRangeStart = 116011, XrefRangeEnd = 116012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDefaults.NativeMethodInfoPtr_set_NetworkstaminaEnabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170013D2 RID: 5074
		// (get) Token: 0x060038F6 RID: 14582 RVA: 0x001022CC File Offset: 0x001004CC
		// (set) Token: 0x060038F7 RID: 14583 RVA: 0x00102308 File Offset: 0x00100508
		public unsafe float Networkstamina
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDefaults.NativeMethodInfoPtr_get_Networkstamina_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 116018, RefRangeEnd = 116019, XrefRangeStart = 116018, XrefRangeEnd = 116019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDefaults.NativeMethodInfoPtr_set_Networkstamina_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170013D3 RID: 5075
		// (get) Token: 0x060038F8 RID: 14584 RVA: 0x00102348 File Offset: 0x00100548
		// (set) Token: 0x060038F9 RID: 14585 RVA: 0x00102384 File Offset: 0x00100584
		public unsafe float NetworkmaxStamina
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDefaults.NativeMethodInfoPtr_get_NetworkmaxStamina_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 116025, RefRangeEnd = 116026, XrefRangeStart = 116025, XrefRangeEnd = 116026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDefaults.NativeMethodInfoPtr_set_NetworkmaxStamina_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170013D4 RID: 5076
		// (get) Token: 0x060038FA RID: 14586 RVA: 0x001023C4 File Offset: 0x001005C4
		// (set) Token: 0x060038FB RID: 14587 RVA: 0x00102400 File Offset: 0x00100600
		public unsafe float NetworkstaminaRegen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDefaults.NativeMethodInfoPtr_get_NetworkstaminaRegen_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 116032, RefRangeEnd = 116033, XrefRangeStart = 116032, XrefRangeEnd = 116033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDefaults.NativeMethodInfoPtr_set_NetworkstaminaRegen_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170013D5 RID: 5077
		// (get) Token: 0x060038FC RID: 14588 RVA: 0x00102440 File Offset: 0x00100640
		// (set) Token: 0x060038FD RID: 14589 RVA: 0x0010247C File Offset: 0x0010067C
		public unsafe float NetworkjumpPower
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDefaults.NativeMethodInfoPtr_get_NetworkjumpPower_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 116039, RefRangeEnd = 116040, XrefRangeStart = 116039, XrefRangeEnd = 116040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDefaults.NativeMethodInfoPtr_set_NetworkjumpPower_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170013D6 RID: 5078
		// (get) Token: 0x060038FE RID: 14590 RVA: 0x001024BC File Offset: 0x001006BC
		// (set) Token: 0x060038FF RID: 14591 RVA: 0x001024F8 File Offset: 0x001006F8
		public unsafe float NetworkrespawnTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDefaults.NativeMethodInfoPtr_get_NetworkrespawnTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 116046, RefRangeEnd = 116047, XrefRangeStart = 116046, XrefRangeEnd = 116047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDefaults.NativeMethodInfoPtr_set_NetworkrespawnTime_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170013D7 RID: 5079
		// (get) Token: 0x06003900 RID: 14592 RVA: 0x00102538 File Offset: 0x00100738
		// (set) Token: 0x06003901 RID: 14593 RVA: 0x00102578 File Offset: 0x00100778
		public unsafe Color NetworkchatColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDefaults.NativeMethodInfoPtr_get_NetworkchatColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 116053, RefRangeEnd = 116054, XrefRangeStart = 116053, XrefRangeEnd = 116054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDefaults.NativeMethodInfoPtr_set_NetworkchatColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003902 RID: 14594 RVA: 0x001025BC File Offset: 0x001007BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116054, XrefRangeEnd = 116058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerDefaults()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerDefaults>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDefaults.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003903 RID: 14595 RVA: 0x001025F8 File Offset: 0x001007F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerDefaults.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003904 RID: 14596 RVA: 0x00102634 File Offset: 0x00100834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116058, XrefRangeEnd = 116086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerDefaults.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003905 RID: 14597 RVA: 0x00102670 File Offset: 0x00100870
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 116111, RefRangeEnd = 116115, XrefRangeStart = 116086, XrefRangeEnd = 116111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadDefaults(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDefaults.NativeMethodInfoPtr_LoadDefaults_Public_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003906 RID: 14598 RVA: 0x001026B4 File Offset: 0x001008B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116115, XrefRangeEnd = 116136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CmdLoadDefaults(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDefaults.NativeMethodInfoPtr_CmdLoadDefaults_Private_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003907 RID: 14599 RVA: 0x001026F8 File Offset: 0x001008F8
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 20124, RefRangeEnd = 20136, XrefRangeStart = 20124, XrefRangeEnd = 20136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Weaved()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerDefaults.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003908 RID: 14600 RVA: 0x00102740 File Offset: 0x00100940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116136, XrefRangeEnd = 116154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_CmdLoadDefaults__Player(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDefaults.NativeMethodInfoPtr_UserCode_CmdLoadDefaults__Player_Protected_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003909 RID: 14601 RVA: 0x00102784 File Offset: 0x00100984
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116154, XrefRangeEnd = 116175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_CmdLoadDefaults__Player(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDefaults.NativeMethodInfoPtr_InvokeUserCode_CmdLoadDefaults__Player_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600390A RID: 14602 RVA: 0x001027E0 File Offset: 0x001009E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116175, XrefRangeEnd = 116197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerDefaults.NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600390B RID: 14603 RVA: 0x0010283C File Offset: 0x00100A3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116197, XrefRangeEnd = 116260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerDefaults.NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600390C RID: 14604 RVA: 0x000162B0 File Offset: 0x000144B0
		public PlayerDefaults(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170013BA RID: 5050
		// (get) Token: 0x0600390D RID: 14605 RVA: 0x00102898 File Offset: 0x00100A98
		// (set) Token: 0x0600390E RID: 14606 RVA: 0x000162B9 File Offset: 0x000144B9
		public unsafe float maxHealth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDefaults.NativeFieldInfoPtr_maxHealth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDefaults.NativeFieldInfoPtr_maxHealth)) = value;
			}
		}

		// Token: 0x170013BB RID: 5051
		// (get) Token: 0x0600390F RID: 14607 RVA: 0x001028C0 File Offset: 0x00100AC0
		// (set) Token: 0x06003910 RID: 14608 RVA: 0x000162D4 File Offset: 0x000144D4
		public unsafe float walkSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDefaults.NativeFieldInfoPtr_walkSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDefaults.NativeFieldInfoPtr_walkSpeed)) = value;
			}
		}

		// Token: 0x170013BC RID: 5052
		// (get) Token: 0x06003911 RID: 14609 RVA: 0x001028E8 File Offset: 0x00100AE8
		// (set) Token: 0x06003912 RID: 14610 RVA: 0x000162EF File Offset: 0x000144EF
		public unsafe float sprintSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDefaults.NativeFieldInfoPtr_sprintSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDefaults.NativeFieldInfoPtr_sprintSpeed)) = value;
			}
		}

		// Token: 0x170013BD RID: 5053
		// (get) Token: 0x06003913 RID: 14611 RVA: 0x00102910 File Offset: 0x00100B10
		// (set) Token: 0x06003914 RID: 14612 RVA: 0x0001630A File Offset: 0x0001450A
		public unsafe bool staminaEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDefaults.NativeFieldInfoPtr_staminaEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDefaults.NativeFieldInfoPtr_staminaEnabled)) = value;
			}
		}

		// Token: 0x170013BE RID: 5054
		// (get) Token: 0x06003915 RID: 14613 RVA: 0x00102938 File Offset: 0x00100B38
		// (set) Token: 0x06003916 RID: 14614 RVA: 0x00016325 File Offset: 0x00014525
		public unsafe float stamina
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDefaults.NativeFieldInfoPtr_stamina);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDefaults.NativeFieldInfoPtr_stamina)) = value;
			}
		}

		// Token: 0x170013BF RID: 5055
		// (get) Token: 0x06003917 RID: 14615 RVA: 0x00102960 File Offset: 0x00100B60
		// (set) Token: 0x06003918 RID: 14616 RVA: 0x00016340 File Offset: 0x00014540
		public unsafe float maxStamina
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDefaults.NativeFieldInfoPtr_maxStamina);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDefaults.NativeFieldInfoPtr_maxStamina)) = value;
			}
		}

		// Token: 0x170013C0 RID: 5056
		// (get) Token: 0x06003919 RID: 14617 RVA: 0x00102988 File Offset: 0x00100B88
		// (set) Token: 0x0600391A RID: 14618 RVA: 0x0001635B File Offset: 0x0001455B
		public unsafe float staminaRegen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDefaults.NativeFieldInfoPtr_staminaRegen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDefaults.NativeFieldInfoPtr_staminaRegen)) = value;
			}
		}

		// Token: 0x170013C1 RID: 5057
		// (get) Token: 0x0600391B RID: 14619 RVA: 0x001029B0 File Offset: 0x00100BB0
		// (set) Token: 0x0600391C RID: 14620 RVA: 0x00016376 File Offset: 0x00014576
		public unsafe float jumpPower
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDefaults.NativeFieldInfoPtr_jumpPower);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDefaults.NativeFieldInfoPtr_jumpPower)) = value;
			}
		}

		// Token: 0x170013C2 RID: 5058
		// (get) Token: 0x0600391D RID: 14621 RVA: 0x001029D8 File Offset: 0x00100BD8
		// (set) Token: 0x0600391E RID: 14622 RVA: 0x00016391 File Offset: 0x00014591
		public unsafe float respawnTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDefaults.NativeFieldInfoPtr_respawnTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDefaults.NativeFieldInfoPtr_respawnTime)) = value;
			}
		}

		// Token: 0x170013C3 RID: 5059
		// (get) Token: 0x0600391F RID: 14623 RVA: 0x00102A00 File Offset: 0x00100C00
		// (set) Token: 0x06003920 RID: 14624 RVA: 0x000163AC File Offset: 0x000145AC
		public unsafe Color chatColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDefaults.NativeFieldInfoPtr_chatColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDefaults.NativeFieldInfoPtr_chatColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002C0F RID: 11279
		private static readonly IntPtr NativeFieldInfoPtr_maxHealth;

		// Token: 0x04002C10 RID: 11280
		private static readonly IntPtr NativeFieldInfoPtr_walkSpeed;

		// Token: 0x04002C11 RID: 11281
		private static readonly IntPtr NativeFieldInfoPtr_sprintSpeed;

		// Token: 0x04002C12 RID: 11282
		private static readonly IntPtr NativeFieldInfoPtr_staminaEnabled;

		// Token: 0x04002C13 RID: 11283
		private static readonly IntPtr NativeFieldInfoPtr_stamina;

		// Token: 0x04002C14 RID: 11284
		private static readonly IntPtr NativeFieldInfoPtr_maxStamina;

		// Token: 0x04002C15 RID: 11285
		private static readonly IntPtr NativeFieldInfoPtr_staminaRegen;

		// Token: 0x04002C16 RID: 11286
		private static readonly IntPtr NativeFieldInfoPtr_jumpPower;

		// Token: 0x04002C17 RID: 11287
		private static readonly IntPtr NativeFieldInfoPtr_respawnTime;

		// Token: 0x04002C18 RID: 11288
		private static readonly IntPtr NativeFieldInfoPtr_chatColor;

		// Token: 0x04002C19 RID: 11289
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxHealth_Public_get_Single_0;

		// Token: 0x04002C1A RID: 11290
		private static readonly IntPtr NativeMethodInfoPtr_set_MaxHealth_Public_set_Void_Single_0;

		// Token: 0x04002C1B RID: 11291
		private static readonly IntPtr NativeMethodInfoPtr_get_WalkSpeed_Public_get_Single_0;

		// Token: 0x04002C1C RID: 11292
		private static readonly IntPtr NativeMethodInfoPtr_set_WalkSpeed_Public_set_Void_Single_0;

		// Token: 0x04002C1D RID: 11293
		private static readonly IntPtr NativeMethodInfoPtr_get_SprintSpeed_Public_get_Single_0;

		// Token: 0x04002C1E RID: 11294
		private static readonly IntPtr NativeMethodInfoPtr_set_SprintSpeed_Public_set_Void_Single_0;

		// Token: 0x04002C1F RID: 11295
		private static readonly IntPtr NativeMethodInfoPtr_get_StaminaEnabled_Public_get_Boolean_0;

		// Token: 0x04002C20 RID: 11296
		private static readonly IntPtr NativeMethodInfoPtr_set_StaminaEnabled_Public_set_Void_Boolean_0;

		// Token: 0x04002C21 RID: 11297
		private static readonly IntPtr NativeMethodInfoPtr_get_Stamina_Public_get_Single_0;

		// Token: 0x04002C22 RID: 11298
		private static readonly IntPtr NativeMethodInfoPtr_set_Stamina_Public_set_Void_Single_0;

		// Token: 0x04002C23 RID: 11299
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxStamina_Public_get_Single_0;

		// Token: 0x04002C24 RID: 11300
		private static readonly IntPtr NativeMethodInfoPtr_set_MaxStamina_Public_set_Void_Single_0;

		// Token: 0x04002C25 RID: 11301
		private static readonly IntPtr NativeMethodInfoPtr_get_StaminaRegen_Public_get_Single_0;

		// Token: 0x04002C26 RID: 11302
		private static readonly IntPtr NativeMethodInfoPtr_set_StaminaRegen_Public_set_Void_Single_0;

		// Token: 0x04002C27 RID: 11303
		private static readonly IntPtr NativeMethodInfoPtr_get_JumpPower_Public_get_Single_0;

		// Token: 0x04002C28 RID: 11304
		private static readonly IntPtr NativeMethodInfoPtr_set_JumpPower_Public_set_Void_Single_0;

		// Token: 0x04002C29 RID: 11305
		private static readonly IntPtr NativeMethodInfoPtr_get_RespawnTime_Public_get_Single_0;

		// Token: 0x04002C2A RID: 11306
		private static readonly IntPtr NativeMethodInfoPtr_set_RespawnTime_Public_set_Void_Single_0;

		// Token: 0x04002C2B RID: 11307
		private static readonly IntPtr NativeMethodInfoPtr_get_ChatColor_Public_get_Color_0;

		// Token: 0x04002C2C RID: 11308
		private static readonly IntPtr NativeMethodInfoPtr_set_ChatColor_Public_set_Void_Color_0;

		// Token: 0x04002C2D RID: 11309
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkmaxHealth_Public_get_Single_0;

		// Token: 0x04002C2E RID: 11310
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkmaxHealth_Public_set_Void_Single_0;

		// Token: 0x04002C2F RID: 11311
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkwalkSpeed_Public_get_Single_0;

		// Token: 0x04002C30 RID: 11312
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkwalkSpeed_Public_set_Void_Single_0;

		// Token: 0x04002C31 RID: 11313
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworksprintSpeed_Public_get_Single_0;

		// Token: 0x04002C32 RID: 11314
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworksprintSpeed_Public_set_Void_Single_0;

		// Token: 0x04002C33 RID: 11315
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkstaminaEnabled_Public_get_Boolean_0;

		// Token: 0x04002C34 RID: 11316
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkstaminaEnabled_Public_set_Void_Boolean_0;

		// Token: 0x04002C35 RID: 11317
		private static readonly IntPtr NativeMethodInfoPtr_get_Networkstamina_Public_get_Single_0;

		// Token: 0x04002C36 RID: 11318
		private static readonly IntPtr NativeMethodInfoPtr_set_Networkstamina_Public_set_Void_Single_0;

		// Token: 0x04002C37 RID: 11319
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkmaxStamina_Public_get_Single_0;

		// Token: 0x04002C38 RID: 11320
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkmaxStamina_Public_set_Void_Single_0;

		// Token: 0x04002C39 RID: 11321
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkstaminaRegen_Public_get_Single_0;

		// Token: 0x04002C3A RID: 11322
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkstaminaRegen_Public_set_Void_Single_0;

		// Token: 0x04002C3B RID: 11323
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkjumpPower_Public_get_Single_0;

		// Token: 0x04002C3C RID: 11324
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkjumpPower_Public_set_Void_Single_0;

		// Token: 0x04002C3D RID: 11325
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkrespawnTime_Public_get_Single_0;

		// Token: 0x04002C3E RID: 11326
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkrespawnTime_Public_set_Void_Single_0;

		// Token: 0x04002C3F RID: 11327
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkchatColor_Public_get_Color_0;

		// Token: 0x04002C40 RID: 11328
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkchatColor_Public_set_Void_Color_0;

		// Token: 0x04002C41 RID: 11329
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002C42 RID: 11330
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04002C43 RID: 11331
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04002C44 RID: 11332
		private static readonly IntPtr NativeMethodInfoPtr_LoadDefaults_Public_Void_Player_0;

		// Token: 0x04002C45 RID: 11333
		private static readonly IntPtr NativeMethodInfoPtr_CmdLoadDefaults_Private_Void_Player_0;

		// Token: 0x04002C46 RID: 11334
		private static readonly IntPtr NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0;

		// Token: 0x04002C47 RID: 11335
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_CmdLoadDefaults__Player_Protected_Void_Player_0;

		// Token: 0x04002C48 RID: 11336
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_CmdLoadDefaults__Player_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002C49 RID: 11337
		private static readonly IntPtr NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0;

		// Token: 0x04002C4A RID: 11338
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0;
	}
}
