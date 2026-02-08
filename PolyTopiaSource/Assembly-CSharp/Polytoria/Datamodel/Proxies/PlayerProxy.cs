using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using MoonSharp.Interpreter;
using Polytoria.Lua;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002ED RID: 749
	public class PlayerProxy : InstanceProxy
	{
		// Token: 0x0600419C RID: 16796 RVA: 0x00126B78 File Offset: 0x00124D78
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerProxy()
		{
			Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Proxies", "PlayerProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr);
			PlayerProxy.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, "player");
			PlayerProxy.NativeMethodInfoPtr_get_RespawnTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673629);
			PlayerProxy.NativeMethodInfoPtr_set_RespawnTime_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673630);
			PlayerProxy.NativeMethodInfoPtr_get_Velocity_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673631);
			PlayerProxy.NativeMethodInfoPtr_set_Velocity_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673632);
			PlayerProxy.NativeMethodInfoPtr_get_MaxHealth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673633);
			PlayerProxy.NativeMethodInfoPtr_set_MaxHealth_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673634);
			PlayerProxy.NativeMethodInfoPtr_get_Health_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673635);
			PlayerProxy.NativeMethodInfoPtr_set_Health_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673636);
			PlayerProxy.NativeMethodInfoPtr_get_WalkSpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673637);
			PlayerProxy.NativeMethodInfoPtr_set_WalkSpeed_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673638);
			PlayerProxy.NativeMethodInfoPtr_get_SprintSpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673639);
			PlayerProxy.NativeMethodInfoPtr_set_SprintSpeed_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673640);
			PlayerProxy.NativeMethodInfoPtr_get_StaminaEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673641);
			PlayerProxy.NativeMethodInfoPtr_set_StaminaEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673642);
			PlayerProxy.NativeMethodInfoPtr_get_Stamina_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673643);
			PlayerProxy.NativeMethodInfoPtr_set_Stamina_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673644);
			PlayerProxy.NativeMethodInfoPtr_get_MaxStamina_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673645);
			PlayerProxy.NativeMethodInfoPtr_set_MaxStamina_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673646);
			PlayerProxy.NativeMethodInfoPtr_get_StaminaRegen_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673647);
			PlayerProxy.NativeMethodInfoPtr_set_StaminaRegen_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673648);
			PlayerProxy.NativeMethodInfoPtr_get_JumpPower_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673649);
			PlayerProxy.NativeMethodInfoPtr_set_JumpPower_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673650);
			PlayerProxy.NativeMethodInfoPtr_get_Position_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673651);
			PlayerProxy.NativeMethodInfoPtr_set_Position_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673652);
			PlayerProxy.NativeMethodInfoPtr_get_Rotation_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673653);
			PlayerProxy.NativeMethodInfoPtr_set_Rotation_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673654);
			PlayerProxy.NativeMethodInfoPtr_get_Size_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673655);
			PlayerProxy.NativeMethodInfoPtr_set_Size_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673656);
			PlayerProxy.NativeMethodInfoPtr_get_ChatColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673657);
			PlayerProxy.NativeMethodInfoPtr_set_ChatColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673658);
			PlayerProxy.NativeMethodInfoPtr_get_CanMove_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673659);
			PlayerProxy.NativeMethodInfoPtr_set_CanMove_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673660);
			PlayerProxy.NativeMethodInfoPtr_get_Anchored_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673661);
			PlayerProxy.NativeMethodInfoPtr_set_Anchored_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673662);
			PlayerProxy.NativeMethodInfoPtr_get_HeadColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673663);
			PlayerProxy.NativeMethodInfoPtr_set_HeadColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673664);
			PlayerProxy.NativeMethodInfoPtr_get_TorsoColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673665);
			PlayerProxy.NativeMethodInfoPtr_set_TorsoColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673666);
			PlayerProxy.NativeMethodInfoPtr_get_LeftArmColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673667);
			PlayerProxy.NativeMethodInfoPtr_set_LeftArmColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673668);
			PlayerProxy.NativeMethodInfoPtr_get_RightArmColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673669);
			PlayerProxy.NativeMethodInfoPtr_set_RightArmColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673670);
			PlayerProxy.NativeMethodInfoPtr_get_LeftLegColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673671);
			PlayerProxy.NativeMethodInfoPtr_set_LeftLegColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673672);
			PlayerProxy.NativeMethodInfoPtr_get_RightLegColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673673);
			PlayerProxy.NativeMethodInfoPtr_set_RightLegColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673674);
			PlayerProxy.NativeMethodInfoPtr_get_ShirtID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673675);
			PlayerProxy.NativeMethodInfoPtr_set_ShirtID_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673676);
			PlayerProxy.NativeMethodInfoPtr_get_PantsID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673677);
			PlayerProxy.NativeMethodInfoPtr_set_PantsID_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673678);
			PlayerProxy.NativeMethodInfoPtr_get_FaceID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673679);
			PlayerProxy.NativeMethodInfoPtr_set_FaceID_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673680);
			PlayerProxy.NativeMethodInfoPtr_get_IsInputFocused_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673681);
			PlayerProxy.NativeMethodInfoPtr_get_SittingIn_Public_get_Seat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673682);
			PlayerProxy.NativeMethodInfoPtr_get_Forward_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673683);
			PlayerProxy.NativeMethodInfoPtr_get_Right_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673684);
			PlayerProxy.NativeMethodInfoPtr_get_IsAdmin_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673685);
			PlayerProxy.NativeMethodInfoPtr_get_IsCreator_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673686);
			PlayerProxy.NativeMethodInfoPtr_get_UserID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673687);
			PlayerProxy.NativeMethodInfoPtr_get_Chatted_Public_get_LuaEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673688);
			PlayerProxy.NativeMethodInfoPtr_get_Died_Public_get_LuaEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673689);
			PlayerProxy.NativeMethodInfoPtr_get_Respawned_Public_get_LuaEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673690);
			PlayerProxy.NativeMethodInfoPtr__ctor_Public_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673628);
			PlayerProxy.NativeMethodInfoPtr_OwnsItem_Public_Void_Int32_DynValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673691);
			PlayerProxy.NativeMethodInfoPtr_Kick_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673692);
			PlayerProxy.NativeMethodInfoPtr_Sit_Public_Void_Seat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673693);
			PlayerProxy.NativeMethodInfoPtr_Unsit_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673694);
			PlayerProxy.NativeMethodInfoPtr_Respawn_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673695);
			PlayerProxy.NativeMethodInfoPtr_LoadAppearance_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673696);
			PlayerProxy.NativeMethodInfoPtr_ClearAppearance_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673697);
			PlayerProxy.NativeMethodInfoPtr_ResetAppearance_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673698);
			PlayerProxy.NativeMethodInfoPtr_LookAt_Public_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673699);
			PlayerProxy.NativeMethodInfoPtr_LookAt_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673700);
			PlayerProxy.NativeMethodInfoPtr_LookAt_Public_Void_DynamicInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673701);
			PlayerProxy.NativeMethodInfoPtr_Translate_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673702);
			PlayerProxy.NativeMethodInfoPtr_RotateAround_Public_Void_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673703);
			PlayerProxy.NativeMethodInfoPtr_Rotate_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673704);
			PlayerProxy.NativeMethodInfoPtr_InverseTransformPoint_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673705);
			PlayerProxy.NativeMethodInfoPtr_TransformPoint_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673706);
			PlayerProxy.NativeMethodInfoPtr_InverseTransformDirection_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673707);
			PlayerProxy.NativeMethodInfoPtr_TransformDirection_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673708);
			PlayerProxy.NativeMethodInfoPtr_InverseTransformVector_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673709);
			PlayerProxy.NativeMethodInfoPtr_TransformVector_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr, 100673710);
		}

		// Token: 0x1700169D RID: 5789
		// (get) Token: 0x0600419D RID: 16797 RVA: 0x00127238 File Offset: 0x00125438
		// (set) Token: 0x0600419E RID: 16798 RVA: 0x00127274 File Offset: 0x00125474
		public unsafe float RespawnTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_get_RespawnTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128856, XrefRangeEnd = 128858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_set_RespawnTime_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700169E RID: 5790
		// (get) Token: 0x0600419F RID: 16799 RVA: 0x001272B4 File Offset: 0x001254B4
		// (set) Token: 0x060041A0 RID: 16800 RVA: 0x001272F4 File Offset: 0x001254F4
		public unsafe Vector3 Velocity
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128858, XrefRangeEnd = 128859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_get_Velocity_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128859, XrefRangeEnd = 128860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_set_Velocity_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700169F RID: 5791
		// (get) Token: 0x060041A1 RID: 16801 RVA: 0x00127338 File Offset: 0x00125538
		// (set) Token: 0x060041A2 RID: 16802 RVA: 0x00127374 File Offset: 0x00125574
		public unsafe float MaxHealth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_get_MaxHealth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128860, XrefRangeEnd = 128862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_set_MaxHealth_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170016A0 RID: 5792
		// (get) Token: 0x060041A3 RID: 16803 RVA: 0x001273B4 File Offset: 0x001255B4
		// (set) Token: 0x060041A4 RID: 16804 RVA: 0x001273F0 File Offset: 0x001255F0
		public unsafe float Health
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_get_Health_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128862, XrefRangeEnd = 128864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_set_Health_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170016A1 RID: 5793
		// (get) Token: 0x060041A5 RID: 16805 RVA: 0x00127430 File Offset: 0x00125630
		// (set) Token: 0x060041A6 RID: 16806 RVA: 0x0012746C File Offset: 0x0012566C
		public unsafe float WalkSpeed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_get_WalkSpeed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128864, XrefRangeEnd = 128866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_set_WalkSpeed_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170016A2 RID: 5794
		// (get) Token: 0x060041A7 RID: 16807 RVA: 0x001274AC File Offset: 0x001256AC
		// (set) Token: 0x060041A8 RID: 16808 RVA: 0x001274E8 File Offset: 0x001256E8
		public unsafe float SprintSpeed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_get_SprintSpeed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128866, XrefRangeEnd = 128868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_set_SprintSpeed_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170016A3 RID: 5795
		// (get) Token: 0x060041A9 RID: 16809 RVA: 0x00127528 File Offset: 0x00125728
		// (set) Token: 0x060041AA RID: 16810 RVA: 0x00127564 File Offset: 0x00125764
		public unsafe bool StaminaEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_get_StaminaEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128868, XrefRangeEnd = 128870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_set_StaminaEnabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170016A4 RID: 5796
		// (get) Token: 0x060041AB RID: 16811 RVA: 0x001275A4 File Offset: 0x001257A4
		// (set) Token: 0x060041AC RID: 16812 RVA: 0x001275E0 File Offset: 0x001257E0
		public unsafe float Stamina
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_get_Stamina_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128870, XrefRangeEnd = 128872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_set_Stamina_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170016A5 RID: 5797
		// (get) Token: 0x060041AD RID: 16813 RVA: 0x00127620 File Offset: 0x00125820
		// (set) Token: 0x060041AE RID: 16814 RVA: 0x0012765C File Offset: 0x0012585C
		public unsafe float MaxStamina
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_get_MaxStamina_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128872, XrefRangeEnd = 128874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_set_MaxStamina_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170016A6 RID: 5798
		// (get) Token: 0x060041AF RID: 16815 RVA: 0x0012769C File Offset: 0x0012589C
		// (set) Token: 0x060041B0 RID: 16816 RVA: 0x001276D8 File Offset: 0x001258D8
		public unsafe float StaminaRegen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_get_StaminaRegen_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128874, XrefRangeEnd = 128876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_set_StaminaRegen_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170016A7 RID: 5799
		// (get) Token: 0x060041B1 RID: 16817 RVA: 0x00127718 File Offset: 0x00125918
		// (set) Token: 0x060041B2 RID: 16818 RVA: 0x00127754 File Offset: 0x00125954
		public unsafe float JumpPower
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_get_JumpPower_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128876, XrefRangeEnd = 128878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_set_JumpPower_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170016A8 RID: 5800
		// (get) Token: 0x060041B3 RID: 16819 RVA: 0x00127794 File Offset: 0x00125994
		// (set) Token: 0x060041B4 RID: 16820 RVA: 0x001277D4 File Offset: 0x001259D4
		public unsafe Vector3 Position
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128878, XrefRangeEnd = 128879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_get_Position_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128879, XrefRangeEnd = 128880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_set_Position_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170016A9 RID: 5801
		// (get) Token: 0x060041B5 RID: 16821 RVA: 0x00127818 File Offset: 0x00125A18
		// (set) Token: 0x060041B6 RID: 16822 RVA: 0x00127858 File Offset: 0x00125A58
		public unsafe Vector3 Rotation
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128880, XrefRangeEnd = 128881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_get_Rotation_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128881, XrefRangeEnd = 128882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_set_Rotation_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170016AA RID: 5802
		// (get) Token: 0x060041B7 RID: 16823 RVA: 0x0012789C File Offset: 0x00125A9C
		// (set) Token: 0x060041B8 RID: 16824 RVA: 0x001278DC File Offset: 0x00125ADC
		public unsafe Vector3 Size
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128882, XrefRangeEnd = 128883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_get_Size_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128883, XrefRangeEnd = 128884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_set_Size_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170016AB RID: 5803
		// (get) Token: 0x060041B9 RID: 16825 RVA: 0x00127920 File Offset: 0x00125B20
		// (set) Token: 0x060041BA RID: 16826 RVA: 0x00127960 File Offset: 0x00125B60
		public unsafe Color ChatColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_get_ChatColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128884, XrefRangeEnd = 128885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_set_ChatColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170016AC RID: 5804
		// (get) Token: 0x060041BB RID: 16827 RVA: 0x001279A4 File Offset: 0x00125BA4
		// (set) Token: 0x060041BC RID: 16828 RVA: 0x001279E0 File Offset: 0x00125BE0
		public unsafe bool CanMove
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_get_CanMove_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128885, XrefRangeEnd = 128887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_set_CanMove_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170016AD RID: 5805
		// (get) Token: 0x060041BD RID: 16829 RVA: 0x00127A20 File Offset: 0x00125C20
		// (set) Token: 0x060041BE RID: 16830 RVA: 0x00127A5C File Offset: 0x00125C5C
		public unsafe bool Anchored
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_get_Anchored_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128887, XrefRangeEnd = 128889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_set_Anchored_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170016AE RID: 5806
		// (get) Token: 0x060041BF RID: 16831 RVA: 0x00127A9C File Offset: 0x00125C9C
		// (set) Token: 0x060041C0 RID: 16832 RVA: 0x00127ADC File Offset: 0x00125CDC
		public unsafe Color HeadColor
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128889, XrefRangeEnd = 128890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_get_HeadColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128890, XrefRangeEnd = 128891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_set_HeadColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170016AF RID: 5807
		// (get) Token: 0x060041C1 RID: 16833 RVA: 0x00127B20 File Offset: 0x00125D20
		// (set) Token: 0x060041C2 RID: 16834 RVA: 0x00127B60 File Offset: 0x00125D60
		public unsafe Color TorsoColor
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128891, XrefRangeEnd = 128892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_get_TorsoColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128892, XrefRangeEnd = 128893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_set_TorsoColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170016B0 RID: 5808
		// (get) Token: 0x060041C3 RID: 16835 RVA: 0x00127BA4 File Offset: 0x00125DA4
		// (set) Token: 0x060041C4 RID: 16836 RVA: 0x00127BE4 File Offset: 0x00125DE4
		public unsafe Color LeftArmColor
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128893, XrefRangeEnd = 128894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_get_LeftArmColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128894, XrefRangeEnd = 128895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_set_LeftArmColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170016B1 RID: 5809
		// (get) Token: 0x060041C5 RID: 16837 RVA: 0x00127C28 File Offset: 0x00125E28
		// (set) Token: 0x060041C6 RID: 16838 RVA: 0x00127C68 File Offset: 0x00125E68
		public unsafe Color RightArmColor
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128895, XrefRangeEnd = 128896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_get_RightArmColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128896, XrefRangeEnd = 128897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_set_RightArmColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170016B2 RID: 5810
		// (get) Token: 0x060041C7 RID: 16839 RVA: 0x00127CAC File Offset: 0x00125EAC
		// (set) Token: 0x060041C8 RID: 16840 RVA: 0x00127CEC File Offset: 0x00125EEC
		public unsafe Color LeftLegColor
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128897, XrefRangeEnd = 128898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_get_LeftLegColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128898, XrefRangeEnd = 128899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_set_LeftLegColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170016B3 RID: 5811
		// (get) Token: 0x060041C9 RID: 16841 RVA: 0x00127D30 File Offset: 0x00125F30
		// (set) Token: 0x060041CA RID: 16842 RVA: 0x00127D70 File Offset: 0x00125F70
		public unsafe Color RightLegColor
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128899, XrefRangeEnd = 128900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_get_RightLegColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128900, XrefRangeEnd = 128901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_set_RightLegColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170016B4 RID: 5812
		// (get) Token: 0x060041CB RID: 16843 RVA: 0x00127DB4 File Offset: 0x00125FB4
		// (set) Token: 0x060041CC RID: 16844 RVA: 0x00127DF0 File Offset: 0x00125FF0
		public unsafe int ShirtID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_get_ShirtID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128901, XrefRangeEnd = 128903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_set_ShirtID_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170016B5 RID: 5813
		// (get) Token: 0x060041CD RID: 16845 RVA: 0x00127E30 File Offset: 0x00126030
		// (set) Token: 0x060041CE RID: 16846 RVA: 0x00127E6C File Offset: 0x0012606C
		public unsafe int PantsID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_get_PantsID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128903, XrefRangeEnd = 128905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_set_PantsID_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170016B6 RID: 5814
		// (get) Token: 0x060041CF RID: 16847 RVA: 0x00127EAC File Offset: 0x001260AC
		// (set) Token: 0x060041D0 RID: 16848 RVA: 0x00127EE8 File Offset: 0x001260E8
		public unsafe int FaceID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_get_FaceID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128905, XrefRangeEnd = 128907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_set_FaceID_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170016B7 RID: 5815
		// (get) Token: 0x060041D1 RID: 16849 RVA: 0x00127F28 File Offset: 0x00126128
		public unsafe bool IsInputFocused
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128907, XrefRangeEnd = 128909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_get_IsInputFocused_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170016B8 RID: 5816
		// (get) Token: 0x060041D2 RID: 16850 RVA: 0x00127F64 File Offset: 0x00126164
		public unsafe Seat SittingIn
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128909, XrefRangeEnd = 128911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_get_SittingIn_Public_get_Seat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Seat>(intPtr3) : null;
			}
		}

		// Token: 0x170016B9 RID: 5817
		// (get) Token: 0x060041D3 RID: 16851 RVA: 0x00127FA4 File Offset: 0x001261A4
		public unsafe Vector3 Forward
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128911, XrefRangeEnd = 128912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_get_Forward_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x170016BA RID: 5818
		// (get) Token: 0x060041D4 RID: 16852 RVA: 0x00127FE4 File Offset: 0x001261E4
		public unsafe Vector3 Right
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128912, XrefRangeEnd = 128913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_get_Right_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x170016BB RID: 5819
		// (get) Token: 0x060041D5 RID: 16853 RVA: 0x00128024 File Offset: 0x00126224
		public unsafe bool IsAdmin
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_get_IsAdmin_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170016BC RID: 5820
		// (get) Token: 0x060041D6 RID: 16854 RVA: 0x00128060 File Offset: 0x00126260
		public unsafe bool IsCreator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_get_IsCreator_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170016BD RID: 5821
		// (get) Token: 0x060041D7 RID: 16855 RVA: 0x0012809C File Offset: 0x0012629C
		public unsafe int UserID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_get_UserID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170016BE RID: 5822
		// (get) Token: 0x060041D8 RID: 16856 RVA: 0x001280D8 File Offset: 0x001262D8
		public unsafe LuaEvent Chatted
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_get_Chatted_Public_get_LuaEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LuaEvent>(intPtr3) : null;
			}
		}

		// Token: 0x170016BF RID: 5823
		// (get) Token: 0x060041D9 RID: 16857 RVA: 0x00128118 File Offset: 0x00126318
		public unsafe LuaEvent Died
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_get_Died_Public_get_LuaEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LuaEvent>(intPtr3) : null;
			}
		}

		// Token: 0x170016C0 RID: 5824
		// (get) Token: 0x060041DA RID: 16858 RVA: 0x00128158 File Offset: 0x00126358
		public unsafe LuaEvent Respawned
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_get_Respawned_Public_get_LuaEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LuaEvent>(intPtr3) : null;
			}
		}

		// Token: 0x060041DB RID: 16859 RVA: 0x00128198 File Offset: 0x00126398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerProxy(Player target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr__ctor_Public_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060041DC RID: 16860 RVA: 0x001281E4 File Offset: 0x001263E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128913, XrefRangeEnd = 128915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OwnsItem(int assetId, DynValue callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref assetId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_OwnsItem_Public_Void_Int32_DynValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041DD RID: 16861 RVA: 0x00128234 File Offset: 0x00126434
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128915, XrefRangeEnd = 128917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Kick(string reason = "You have been kicked from the server.")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(reason);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_Kick_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060041DE RID: 16862 RVA: 0x00128278 File Offset: 0x00126478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128917, XrefRangeEnd = 128919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Sit(Seat seat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(seat);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_Sit_Public_Void_Seat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060041DF RID: 16863 RVA: 0x001282BC File Offset: 0x001264BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128919, XrefRangeEnd = 128921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Unsit(bool addForce = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref addForce;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_Unsit_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060041E0 RID: 16864 RVA: 0x001282FC File Offset: 0x001264FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128921, XrefRangeEnd = 128923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Respawn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_Respawn_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041E1 RID: 16865 RVA: 0x00128330 File Offset: 0x00126530
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128923, XrefRangeEnd = 128925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadAppearance(int userID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref userID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_LoadAppearance_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060041E2 RID: 16866 RVA: 0x00128370 File Offset: 0x00126570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128925, XrefRangeEnd = 128927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearAppearance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_ClearAppearance_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041E3 RID: 16867 RVA: 0x001283A4 File Offset: 0x001265A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128927, XrefRangeEnd = 128929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetAppearance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_ResetAppearance_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041E4 RID: 16868 RVA: 0x001283D8 File Offset: 0x001265D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128929, XrefRangeEnd = 128930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LookAt(Vector3 lookTarget, Vector3 worldUp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lookTarget);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(worldUp);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_LookAt_Public_Void_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041E5 RID: 16869 RVA: 0x0012842C File Offset: 0x0012662C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128930, XrefRangeEnd = 128931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LookAt(Vector3 lookTarget)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lookTarget);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_LookAt_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060041E6 RID: 16870 RVA: 0x00128470 File Offset: 0x00126670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128931, XrefRangeEnd = 128933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LookAt(DynamicInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_LookAt_Public_Void_DynamicInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060041E7 RID: 16871 RVA: 0x001284B4 File Offset: 0x001266B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128933, XrefRangeEnd = 128934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Translate(Vector3 translation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(translation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_Translate_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060041E8 RID: 16872 RVA: 0x001284F8 File Offset: 0x001266F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128934, XrefRangeEnd = 128935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RotateAround(Vector3 point, Vector3 axis, float angle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(axis);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref angle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_RotateAround_Public_Void_Vector3_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041E9 RID: 16873 RVA: 0x0012855C File Offset: 0x0012675C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128935, XrefRangeEnd = 128936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Rotate(Vector3 eulerAngles)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eulerAngles);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_Rotate_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060041EA RID: 16874 RVA: 0x001285A0 File Offset: 0x001267A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128936, XrefRangeEnd = 128937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 InverseTransformPoint(Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_InverseTransformPoint_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x060041EB RID: 16875 RVA: 0x001285F0 File Offset: 0x001267F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128937, XrefRangeEnd = 128938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 TransformPoint(Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_TransformPoint_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x060041EC RID: 16876 RVA: 0x00128640 File Offset: 0x00126840
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128938, XrefRangeEnd = 128939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 InverseTransformDirection(Vector3 direction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(direction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_InverseTransformDirection_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x060041ED RID: 16877 RVA: 0x00128690 File Offset: 0x00126890
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128939, XrefRangeEnd = 128940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 TransformDirection(Vector3 direction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(direction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_TransformDirection_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x060041EE RID: 16878 RVA: 0x001286E0 File Offset: 0x001268E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128940, XrefRangeEnd = 128941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 InverseTransformVector(Vector3 vector)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vector);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_InverseTransformVector_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x060041EF RID: 16879 RVA: 0x00128730 File Offset: 0x00126930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128941, XrefRangeEnd = 128942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 TransformVector(Vector3 vector)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vector);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerProxy.NativeMethodInfoPtr_TransformVector_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
		}

		// Token: 0x060041F0 RID: 16880 RVA: 0x00018949 File Offset: 0x00016B49
		public PlayerProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700169C RID: 5788
		// (get) Token: 0x060041F1 RID: 16881 RVA: 0x00128780 File Offset: 0x00126980
		// (set) Token: 0x060041F2 RID: 16882 RVA: 0x00018952 File Offset: 0x00016B52
		public unsafe Player player
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerProxy.NativeFieldInfoPtr_player);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerProxy.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003314 RID: 13076
		private static readonly IntPtr NativeFieldInfoPtr_player;

		// Token: 0x04003315 RID: 13077
		private static readonly IntPtr NativeMethodInfoPtr_get_RespawnTime_Public_get_Single_0;

		// Token: 0x04003316 RID: 13078
		private static readonly IntPtr NativeMethodInfoPtr_set_RespawnTime_Public_set_Void_Single_0;

		// Token: 0x04003317 RID: 13079
		private static readonly IntPtr NativeMethodInfoPtr_get_Velocity_Public_get_Vector3_0;

		// Token: 0x04003318 RID: 13080
		private static readonly IntPtr NativeMethodInfoPtr_set_Velocity_Public_set_Void_Vector3_0;

		// Token: 0x04003319 RID: 13081
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxHealth_Public_get_Single_0;

		// Token: 0x0400331A RID: 13082
		private static readonly IntPtr NativeMethodInfoPtr_set_MaxHealth_Public_set_Void_Single_0;

		// Token: 0x0400331B RID: 13083
		private static readonly IntPtr NativeMethodInfoPtr_get_Health_Public_get_Single_0;

		// Token: 0x0400331C RID: 13084
		private static readonly IntPtr NativeMethodInfoPtr_set_Health_Public_set_Void_Single_0;

		// Token: 0x0400331D RID: 13085
		private static readonly IntPtr NativeMethodInfoPtr_get_WalkSpeed_Public_get_Single_0;

		// Token: 0x0400331E RID: 13086
		private static readonly IntPtr NativeMethodInfoPtr_set_WalkSpeed_Public_set_Void_Single_0;

		// Token: 0x0400331F RID: 13087
		private static readonly IntPtr NativeMethodInfoPtr_get_SprintSpeed_Public_get_Single_0;

		// Token: 0x04003320 RID: 13088
		private static readonly IntPtr NativeMethodInfoPtr_set_SprintSpeed_Public_set_Void_Single_0;

		// Token: 0x04003321 RID: 13089
		private static readonly IntPtr NativeMethodInfoPtr_get_StaminaEnabled_Public_get_Boolean_0;

		// Token: 0x04003322 RID: 13090
		private static readonly IntPtr NativeMethodInfoPtr_set_StaminaEnabled_Public_set_Void_Boolean_0;

		// Token: 0x04003323 RID: 13091
		private static readonly IntPtr NativeMethodInfoPtr_get_Stamina_Public_get_Single_0;

		// Token: 0x04003324 RID: 13092
		private static readonly IntPtr NativeMethodInfoPtr_set_Stamina_Public_set_Void_Single_0;

		// Token: 0x04003325 RID: 13093
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxStamina_Public_get_Single_0;

		// Token: 0x04003326 RID: 13094
		private static readonly IntPtr NativeMethodInfoPtr_set_MaxStamina_Public_set_Void_Single_0;

		// Token: 0x04003327 RID: 13095
		private static readonly IntPtr NativeMethodInfoPtr_get_StaminaRegen_Public_get_Single_0;

		// Token: 0x04003328 RID: 13096
		private static readonly IntPtr NativeMethodInfoPtr_set_StaminaRegen_Public_set_Void_Single_0;

		// Token: 0x04003329 RID: 13097
		private static readonly IntPtr NativeMethodInfoPtr_get_JumpPower_Public_get_Single_0;

		// Token: 0x0400332A RID: 13098
		private static readonly IntPtr NativeMethodInfoPtr_set_JumpPower_Public_set_Void_Single_0;

		// Token: 0x0400332B RID: 13099
		private static readonly IntPtr NativeMethodInfoPtr_get_Position_Public_get_Vector3_0;

		// Token: 0x0400332C RID: 13100
		private static readonly IntPtr NativeMethodInfoPtr_set_Position_Public_set_Void_Vector3_0;

		// Token: 0x0400332D RID: 13101
		private static readonly IntPtr NativeMethodInfoPtr_get_Rotation_Public_get_Vector3_0;

		// Token: 0x0400332E RID: 13102
		private static readonly IntPtr NativeMethodInfoPtr_set_Rotation_Public_set_Void_Vector3_0;

		// Token: 0x0400332F RID: 13103
		private static readonly IntPtr NativeMethodInfoPtr_get_Size_Public_get_Vector3_0;

		// Token: 0x04003330 RID: 13104
		private static readonly IntPtr NativeMethodInfoPtr_set_Size_Public_set_Void_Vector3_0;

		// Token: 0x04003331 RID: 13105
		private static readonly IntPtr NativeMethodInfoPtr_get_ChatColor_Public_get_Color_0;

		// Token: 0x04003332 RID: 13106
		private static readonly IntPtr NativeMethodInfoPtr_set_ChatColor_Public_set_Void_Color_0;

		// Token: 0x04003333 RID: 13107
		private static readonly IntPtr NativeMethodInfoPtr_get_CanMove_Public_get_Boolean_0;

		// Token: 0x04003334 RID: 13108
		private static readonly IntPtr NativeMethodInfoPtr_set_CanMove_Public_set_Void_Boolean_0;

		// Token: 0x04003335 RID: 13109
		private static readonly IntPtr NativeMethodInfoPtr_get_Anchored_Public_get_Boolean_0;

		// Token: 0x04003336 RID: 13110
		private static readonly IntPtr NativeMethodInfoPtr_set_Anchored_Public_set_Void_Boolean_0;

		// Token: 0x04003337 RID: 13111
		private static readonly IntPtr NativeMethodInfoPtr_get_HeadColor_Public_get_Color_0;

		// Token: 0x04003338 RID: 13112
		private static readonly IntPtr NativeMethodInfoPtr_set_HeadColor_Public_set_Void_Color_0;

		// Token: 0x04003339 RID: 13113
		private static readonly IntPtr NativeMethodInfoPtr_get_TorsoColor_Public_get_Color_0;

		// Token: 0x0400333A RID: 13114
		private static readonly IntPtr NativeMethodInfoPtr_set_TorsoColor_Public_set_Void_Color_0;

		// Token: 0x0400333B RID: 13115
		private static readonly IntPtr NativeMethodInfoPtr_get_LeftArmColor_Public_get_Color_0;

		// Token: 0x0400333C RID: 13116
		private static readonly IntPtr NativeMethodInfoPtr_set_LeftArmColor_Public_set_Void_Color_0;

		// Token: 0x0400333D RID: 13117
		private static readonly IntPtr NativeMethodInfoPtr_get_RightArmColor_Public_get_Color_0;

		// Token: 0x0400333E RID: 13118
		private static readonly IntPtr NativeMethodInfoPtr_set_RightArmColor_Public_set_Void_Color_0;

		// Token: 0x0400333F RID: 13119
		private static readonly IntPtr NativeMethodInfoPtr_get_LeftLegColor_Public_get_Color_0;

		// Token: 0x04003340 RID: 13120
		private static readonly IntPtr NativeMethodInfoPtr_set_LeftLegColor_Public_set_Void_Color_0;

		// Token: 0x04003341 RID: 13121
		private static readonly IntPtr NativeMethodInfoPtr_get_RightLegColor_Public_get_Color_0;

		// Token: 0x04003342 RID: 13122
		private static readonly IntPtr NativeMethodInfoPtr_set_RightLegColor_Public_set_Void_Color_0;

		// Token: 0x04003343 RID: 13123
		private static readonly IntPtr NativeMethodInfoPtr_get_ShirtID_Public_get_Int32_0;

		// Token: 0x04003344 RID: 13124
		private static readonly IntPtr NativeMethodInfoPtr_set_ShirtID_Public_set_Void_Int32_0;

		// Token: 0x04003345 RID: 13125
		private static readonly IntPtr NativeMethodInfoPtr_get_PantsID_Public_get_Int32_0;

		// Token: 0x04003346 RID: 13126
		private static readonly IntPtr NativeMethodInfoPtr_set_PantsID_Public_set_Void_Int32_0;

		// Token: 0x04003347 RID: 13127
		private static readonly IntPtr NativeMethodInfoPtr_get_FaceID_Public_get_Int32_0;

		// Token: 0x04003348 RID: 13128
		private static readonly IntPtr NativeMethodInfoPtr_set_FaceID_Public_set_Void_Int32_0;

		// Token: 0x04003349 RID: 13129
		private static readonly IntPtr NativeMethodInfoPtr_get_IsInputFocused_Public_get_Boolean_0;

		// Token: 0x0400334A RID: 13130
		private static readonly IntPtr NativeMethodInfoPtr_get_SittingIn_Public_get_Seat_0;

		// Token: 0x0400334B RID: 13131
		private static readonly IntPtr NativeMethodInfoPtr_get_Forward_Public_get_Vector3_0;

		// Token: 0x0400334C RID: 13132
		private static readonly IntPtr NativeMethodInfoPtr_get_Right_Public_get_Vector3_0;

		// Token: 0x0400334D RID: 13133
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAdmin_Public_get_Boolean_0;

		// Token: 0x0400334E RID: 13134
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCreator_Public_get_Boolean_0;

		// Token: 0x0400334F RID: 13135
		private static readonly IntPtr NativeMethodInfoPtr_get_UserID_Public_get_Int32_0;

		// Token: 0x04003350 RID: 13136
		private static readonly IntPtr NativeMethodInfoPtr_get_Chatted_Public_get_LuaEvent_0;

		// Token: 0x04003351 RID: 13137
		private static readonly IntPtr NativeMethodInfoPtr_get_Died_Public_get_LuaEvent_0;

		// Token: 0x04003352 RID: 13138
		private static readonly IntPtr NativeMethodInfoPtr_get_Respawned_Public_get_LuaEvent_0;

		// Token: 0x04003353 RID: 13139
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Player_0;

		// Token: 0x04003354 RID: 13140
		private static readonly IntPtr NativeMethodInfoPtr_OwnsItem_Public_Void_Int32_DynValue_0;

		// Token: 0x04003355 RID: 13141
		private static readonly IntPtr NativeMethodInfoPtr_Kick_Public_Void_String_0;

		// Token: 0x04003356 RID: 13142
		private static readonly IntPtr NativeMethodInfoPtr_Sit_Public_Void_Seat_0;

		// Token: 0x04003357 RID: 13143
		private static readonly IntPtr NativeMethodInfoPtr_Unsit_Public_Void_Boolean_0;

		// Token: 0x04003358 RID: 13144
		private static readonly IntPtr NativeMethodInfoPtr_Respawn_Public_Void_0;

		// Token: 0x04003359 RID: 13145
		private static readonly IntPtr NativeMethodInfoPtr_LoadAppearance_Public_Void_Int32_0;

		// Token: 0x0400335A RID: 13146
		private static readonly IntPtr NativeMethodInfoPtr_ClearAppearance_Public_Void_0;

		// Token: 0x0400335B RID: 13147
		private static readonly IntPtr NativeMethodInfoPtr_ResetAppearance_Public_Void_0;

		// Token: 0x0400335C RID: 13148
		private static readonly IntPtr NativeMethodInfoPtr_LookAt_Public_Void_Vector3_Vector3_0;

		// Token: 0x0400335D RID: 13149
		private static readonly IntPtr NativeMethodInfoPtr_LookAt_Public_Void_Vector3_0;

		// Token: 0x0400335E RID: 13150
		private static readonly IntPtr NativeMethodInfoPtr_LookAt_Public_Void_DynamicInstance_0;

		// Token: 0x0400335F RID: 13151
		private static readonly IntPtr NativeMethodInfoPtr_Translate_Public_Void_Vector3_0;

		// Token: 0x04003360 RID: 13152
		private static readonly IntPtr NativeMethodInfoPtr_RotateAround_Public_Void_Vector3_Vector3_Single_0;

		// Token: 0x04003361 RID: 13153
		private static readonly IntPtr NativeMethodInfoPtr_Rotate_Public_Void_Vector3_0;

		// Token: 0x04003362 RID: 13154
		private static readonly IntPtr NativeMethodInfoPtr_InverseTransformPoint_Public_Vector3_Vector3_0;

		// Token: 0x04003363 RID: 13155
		private static readonly IntPtr NativeMethodInfoPtr_TransformPoint_Public_Vector3_Vector3_0;

		// Token: 0x04003364 RID: 13156
		private static readonly IntPtr NativeMethodInfoPtr_InverseTransformDirection_Public_Vector3_Vector3_0;

		// Token: 0x04003365 RID: 13157
		private static readonly IntPtr NativeMethodInfoPtr_TransformDirection_Public_Vector3_Vector3_0;

		// Token: 0x04003366 RID: 13158
		private static readonly IntPtr NativeMethodInfoPtr_InverseTransformVector_Public_Vector3_Vector3_0;

		// Token: 0x04003367 RID: 13159
		private static readonly IntPtr NativeMethodInfoPtr_TransformVector_Public_Vector3_Vector3_0;
	}
}
