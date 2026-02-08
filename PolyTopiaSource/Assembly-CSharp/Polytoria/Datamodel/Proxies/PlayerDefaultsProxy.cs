using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002EB RID: 747
	public class PlayerDefaultsProxy : InstanceProxy
	{
		// Token: 0x0600417A RID: 16762 RVA: 0x00126218 File Offset: 0x00124418
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerDefaultsProxy()
		{
			Il2CppClassPointerStore<PlayerDefaultsProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Proxies", "PlayerDefaultsProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerDefaultsProxy>.NativeClassPtr);
			PlayerDefaultsProxy.NativeFieldInfoPtr_playerDefaults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerDefaultsProxy>.NativeClassPtr, "playerDefaults");
			PlayerDefaultsProxy.NativeMethodInfoPtr_get_MaxHealth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDefaultsProxy>.NativeClassPtr, 100673603);
			PlayerDefaultsProxy.NativeMethodInfoPtr_set_MaxHealth_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDefaultsProxy>.NativeClassPtr, 100673604);
			PlayerDefaultsProxy.NativeMethodInfoPtr_get_WalkSpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDefaultsProxy>.NativeClassPtr, 100673605);
			PlayerDefaultsProxy.NativeMethodInfoPtr_set_WalkSpeed_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDefaultsProxy>.NativeClassPtr, 100673606);
			PlayerDefaultsProxy.NativeMethodInfoPtr_get_SprintSpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDefaultsProxy>.NativeClassPtr, 100673607);
			PlayerDefaultsProxy.NativeMethodInfoPtr_set_SprintSpeed_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDefaultsProxy>.NativeClassPtr, 100673608);
			PlayerDefaultsProxy.NativeMethodInfoPtr_get_StaminaEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDefaultsProxy>.NativeClassPtr, 100673609);
			PlayerDefaultsProxy.NativeMethodInfoPtr_set_StaminaEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDefaultsProxy>.NativeClassPtr, 100673610);
			PlayerDefaultsProxy.NativeMethodInfoPtr_get_Stamina_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDefaultsProxy>.NativeClassPtr, 100673611);
			PlayerDefaultsProxy.NativeMethodInfoPtr_set_Stamina_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDefaultsProxy>.NativeClassPtr, 100673612);
			PlayerDefaultsProxy.NativeMethodInfoPtr_get_MaxStamina_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDefaultsProxy>.NativeClassPtr, 100673613);
			PlayerDefaultsProxy.NativeMethodInfoPtr_set_MaxStamina_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDefaultsProxy>.NativeClassPtr, 100673614);
			PlayerDefaultsProxy.NativeMethodInfoPtr_get_StaminaRegen_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDefaultsProxy>.NativeClassPtr, 100673615);
			PlayerDefaultsProxy.NativeMethodInfoPtr_set_StaminaRegen_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDefaultsProxy>.NativeClassPtr, 100673616);
			PlayerDefaultsProxy.NativeMethodInfoPtr_get_JumpPower_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDefaultsProxy>.NativeClassPtr, 100673617);
			PlayerDefaultsProxy.NativeMethodInfoPtr_set_JumpPower_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDefaultsProxy>.NativeClassPtr, 100673618);
			PlayerDefaultsProxy.NativeMethodInfoPtr_get_RespawnTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDefaultsProxy>.NativeClassPtr, 100673619);
			PlayerDefaultsProxy.NativeMethodInfoPtr_set_RespawnTime_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDefaultsProxy>.NativeClassPtr, 100673620);
			PlayerDefaultsProxy.NativeMethodInfoPtr_get_ChatColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDefaultsProxy>.NativeClassPtr, 100673621);
			PlayerDefaultsProxy.NativeMethodInfoPtr_set_ChatColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDefaultsProxy>.NativeClassPtr, 100673622);
			PlayerDefaultsProxy.NativeMethodInfoPtr__ctor_Public_Void_PlayerDefaults_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDefaultsProxy>.NativeClassPtr, 100673602);
		}

		// Token: 0x1700168F RID: 5775
		// (get) Token: 0x0600417B RID: 16763 RVA: 0x00126400 File Offset: 0x00124600
		// (set) Token: 0x0600417C RID: 16764 RVA: 0x0012643C File Offset: 0x0012463C
		public unsafe float MaxHealth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDefaultsProxy.NativeMethodInfoPtr_get_MaxHealth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128833, XrefRangeEnd = 128835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDefaultsProxy.NativeMethodInfoPtr_set_MaxHealth_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001690 RID: 5776
		// (get) Token: 0x0600417D RID: 16765 RVA: 0x0012647C File Offset: 0x0012467C
		// (set) Token: 0x0600417E RID: 16766 RVA: 0x001264B8 File Offset: 0x001246B8
		public unsafe float WalkSpeed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDefaultsProxy.NativeMethodInfoPtr_get_WalkSpeed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128835, XrefRangeEnd = 128837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDefaultsProxy.NativeMethodInfoPtr_set_WalkSpeed_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001691 RID: 5777
		// (get) Token: 0x0600417F RID: 16767 RVA: 0x001264F8 File Offset: 0x001246F8
		// (set) Token: 0x06004180 RID: 16768 RVA: 0x00126534 File Offset: 0x00124734
		public unsafe float SprintSpeed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDefaultsProxy.NativeMethodInfoPtr_get_SprintSpeed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128837, XrefRangeEnd = 128839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDefaultsProxy.NativeMethodInfoPtr_set_SprintSpeed_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001692 RID: 5778
		// (get) Token: 0x06004181 RID: 16769 RVA: 0x00126574 File Offset: 0x00124774
		// (set) Token: 0x06004182 RID: 16770 RVA: 0x001265B0 File Offset: 0x001247B0
		public unsafe bool StaminaEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDefaultsProxy.NativeMethodInfoPtr_get_StaminaEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128839, XrefRangeEnd = 128841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDefaultsProxy.NativeMethodInfoPtr_set_StaminaEnabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001693 RID: 5779
		// (get) Token: 0x06004183 RID: 16771 RVA: 0x001265F0 File Offset: 0x001247F0
		// (set) Token: 0x06004184 RID: 16772 RVA: 0x0012662C File Offset: 0x0012482C
		public unsafe float Stamina
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDefaultsProxy.NativeMethodInfoPtr_get_Stamina_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128841, XrefRangeEnd = 128843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDefaultsProxy.NativeMethodInfoPtr_set_Stamina_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001694 RID: 5780
		// (get) Token: 0x06004185 RID: 16773 RVA: 0x0012666C File Offset: 0x0012486C
		// (set) Token: 0x06004186 RID: 16774 RVA: 0x001266A8 File Offset: 0x001248A8
		public unsafe float MaxStamina
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDefaultsProxy.NativeMethodInfoPtr_get_MaxStamina_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128843, XrefRangeEnd = 128845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDefaultsProxy.NativeMethodInfoPtr_set_MaxStamina_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001695 RID: 5781
		// (get) Token: 0x06004187 RID: 16775 RVA: 0x001266E8 File Offset: 0x001248E8
		// (set) Token: 0x06004188 RID: 16776 RVA: 0x00126724 File Offset: 0x00124924
		public unsafe float StaminaRegen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDefaultsProxy.NativeMethodInfoPtr_get_StaminaRegen_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128845, XrefRangeEnd = 128847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDefaultsProxy.NativeMethodInfoPtr_set_StaminaRegen_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001696 RID: 5782
		// (get) Token: 0x06004189 RID: 16777 RVA: 0x00126764 File Offset: 0x00124964
		// (set) Token: 0x0600418A RID: 16778 RVA: 0x001267A0 File Offset: 0x001249A0
		public unsafe float JumpPower
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDefaultsProxy.NativeMethodInfoPtr_get_JumpPower_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128847, XrefRangeEnd = 128849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDefaultsProxy.NativeMethodInfoPtr_set_JumpPower_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001697 RID: 5783
		// (get) Token: 0x0600418B RID: 16779 RVA: 0x001267E0 File Offset: 0x001249E0
		// (set) Token: 0x0600418C RID: 16780 RVA: 0x0012681C File Offset: 0x00124A1C
		public unsafe float RespawnTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDefaultsProxy.NativeMethodInfoPtr_get_RespawnTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128849, XrefRangeEnd = 128851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDefaultsProxy.NativeMethodInfoPtr_set_RespawnTime_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001698 RID: 5784
		// (get) Token: 0x0600418D RID: 16781 RVA: 0x0012685C File Offset: 0x00124A5C
		// (set) Token: 0x0600418E RID: 16782 RVA: 0x0012689C File Offset: 0x00124A9C
		public unsafe Color ChatColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDefaultsProxy.NativeMethodInfoPtr_get_ChatColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128851, XrefRangeEnd = 128852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDefaultsProxy.NativeMethodInfoPtr_set_ChatColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600418F RID: 16783 RVA: 0x001268E0 File Offset: 0x00124AE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerDefaultsProxy(PlayerDefaults target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerDefaultsProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerDefaultsProxy.NativeMethodInfoPtr__ctor_Public_Void_PlayerDefaults_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004190 RID: 16784 RVA: 0x000188F9 File Offset: 0x00016AF9
		public PlayerDefaultsProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700168E RID: 5774
		// (get) Token: 0x06004191 RID: 16785 RVA: 0x0012692C File Offset: 0x00124B2C
		// (set) Token: 0x06004192 RID: 16786 RVA: 0x00018902 File Offset: 0x00016B02
		public unsafe PlayerDefaults playerDefaults
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDefaultsProxy.NativeFieldInfoPtr_playerDefaults);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerDefaults>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerDefaultsProxy.NativeFieldInfoPtr_playerDefaults), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040032F8 RID: 13048
		private static readonly IntPtr NativeFieldInfoPtr_playerDefaults;

		// Token: 0x040032F9 RID: 13049
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxHealth_Public_get_Single_0;

		// Token: 0x040032FA RID: 13050
		private static readonly IntPtr NativeMethodInfoPtr_set_MaxHealth_Public_set_Void_Single_0;

		// Token: 0x040032FB RID: 13051
		private static readonly IntPtr NativeMethodInfoPtr_get_WalkSpeed_Public_get_Single_0;

		// Token: 0x040032FC RID: 13052
		private static readonly IntPtr NativeMethodInfoPtr_set_WalkSpeed_Public_set_Void_Single_0;

		// Token: 0x040032FD RID: 13053
		private static readonly IntPtr NativeMethodInfoPtr_get_SprintSpeed_Public_get_Single_0;

		// Token: 0x040032FE RID: 13054
		private static readonly IntPtr NativeMethodInfoPtr_set_SprintSpeed_Public_set_Void_Single_0;

		// Token: 0x040032FF RID: 13055
		private static readonly IntPtr NativeMethodInfoPtr_get_StaminaEnabled_Public_get_Boolean_0;

		// Token: 0x04003300 RID: 13056
		private static readonly IntPtr NativeMethodInfoPtr_set_StaminaEnabled_Public_set_Void_Boolean_0;

		// Token: 0x04003301 RID: 13057
		private static readonly IntPtr NativeMethodInfoPtr_get_Stamina_Public_get_Single_0;

		// Token: 0x04003302 RID: 13058
		private static readonly IntPtr NativeMethodInfoPtr_set_Stamina_Public_set_Void_Single_0;

		// Token: 0x04003303 RID: 13059
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxStamina_Public_get_Single_0;

		// Token: 0x04003304 RID: 13060
		private static readonly IntPtr NativeMethodInfoPtr_set_MaxStamina_Public_set_Void_Single_0;

		// Token: 0x04003305 RID: 13061
		private static readonly IntPtr NativeMethodInfoPtr_get_StaminaRegen_Public_get_Single_0;

		// Token: 0x04003306 RID: 13062
		private static readonly IntPtr NativeMethodInfoPtr_set_StaminaRegen_Public_set_Void_Single_0;

		// Token: 0x04003307 RID: 13063
		private static readonly IntPtr NativeMethodInfoPtr_get_JumpPower_Public_get_Single_0;

		// Token: 0x04003308 RID: 13064
		private static readonly IntPtr NativeMethodInfoPtr_set_JumpPower_Public_set_Void_Single_0;

		// Token: 0x04003309 RID: 13065
		private static readonly IntPtr NativeMethodInfoPtr_get_RespawnTime_Public_get_Single_0;

		// Token: 0x0400330A RID: 13066
		private static readonly IntPtr NativeMethodInfoPtr_set_RespawnTime_Public_set_Void_Single_0;

		// Token: 0x0400330B RID: 13067
		private static readonly IntPtr NativeMethodInfoPtr_get_ChatColor_Public_get_Color_0;

		// Token: 0x0400330C RID: 13068
		private static readonly IntPtr NativeMethodInfoPtr_set_ChatColor_Public_set_Void_Color_0;

		// Token: 0x0400330D RID: 13069
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_PlayerDefaults_0;
	}
}
