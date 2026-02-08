using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Polytoria.Lua;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002E7 RID: 743
	public class NPCProxy : DynamicInstanceProxy
	{
		// Token: 0x060040DF RID: 16607 RVA: 0x0012328C File Offset: 0x0012148C
		// Note: this type is marked as 'beforefieldinit'.
		static NPCProxy()
		{
			Il2CppClassPointerStore<NPCProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Proxies", "NPCProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCProxy>.NativeClassPtr);
			NPCProxy.NativeFieldInfoPtr_npc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCProxy>.NativeClassPtr, "npc");
			NPCProxy.NativeMethodInfoPtr_get_Died_Public_get_LuaEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCProxy>.NativeClassPtr, 100673464);
			NPCProxy.NativeMethodInfoPtr_get_MoveTarget_Public_get_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCProxy>.NativeClassPtr, 100673465);
			NPCProxy.NativeMethodInfoPtr_set_MoveTarget_Public_set_Void_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCProxy>.NativeClassPtr, 100673466);
			NPCProxy.NativeMethodInfoPtr_get_HeadColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCProxy>.NativeClassPtr, 100673467);
			NPCProxy.NativeMethodInfoPtr_set_HeadColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCProxy>.NativeClassPtr, 100673468);
			NPCProxy.NativeMethodInfoPtr_get_TorsoColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCProxy>.NativeClassPtr, 100673469);
			NPCProxy.NativeMethodInfoPtr_set_TorsoColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCProxy>.NativeClassPtr, 100673470);
			NPCProxy.NativeMethodInfoPtr_get_LeftArmColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCProxy>.NativeClassPtr, 100673471);
			NPCProxy.NativeMethodInfoPtr_set_LeftArmColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCProxy>.NativeClassPtr, 100673472);
			NPCProxy.NativeMethodInfoPtr_get_RightArmColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCProxy>.NativeClassPtr, 100673473);
			NPCProxy.NativeMethodInfoPtr_set_RightArmColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCProxy>.NativeClassPtr, 100673474);
			NPCProxy.NativeMethodInfoPtr_get_LeftLegColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCProxy>.NativeClassPtr, 100673475);
			NPCProxy.NativeMethodInfoPtr_set_LeftLegColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCProxy>.NativeClassPtr, 100673476);
			NPCProxy.NativeMethodInfoPtr_get_RightLegColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCProxy>.NativeClassPtr, 100673477);
			NPCProxy.NativeMethodInfoPtr_set_RightLegColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCProxy>.NativeClassPtr, 100673478);
			NPCProxy.NativeMethodInfoPtr_get_Anchored_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCProxy>.NativeClassPtr, 100673479);
			NPCProxy.NativeMethodInfoPtr_set_Anchored_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCProxy>.NativeClassPtr, 100673480);
			NPCProxy.NativeMethodInfoPtr_get_Health_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCProxy>.NativeClassPtr, 100673481);
			NPCProxy.NativeMethodInfoPtr_set_Health_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCProxy>.NativeClassPtr, 100673482);
			NPCProxy.NativeMethodInfoPtr_get_MaxHealth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCProxy>.NativeClassPtr, 100673483);
			NPCProxy.NativeMethodInfoPtr_set_MaxHealth_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCProxy>.NativeClassPtr, 100673484);
			NPCProxy.NativeMethodInfoPtr_get_ShirtID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCProxy>.NativeClassPtr, 100673485);
			NPCProxy.NativeMethodInfoPtr_set_ShirtID_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCProxy>.NativeClassPtr, 100673486);
			NPCProxy.NativeMethodInfoPtr_get_PantsID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCProxy>.NativeClassPtr, 100673487);
			NPCProxy.NativeMethodInfoPtr_set_PantsID_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCProxy>.NativeClassPtr, 100673488);
			NPCProxy.NativeMethodInfoPtr_get_FaceID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCProxy>.NativeClassPtr, 100673489);
			NPCProxy.NativeMethodInfoPtr_set_FaceID_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCProxy>.NativeClassPtr, 100673490);
			NPCProxy.NativeMethodInfoPtr_get_WalkSpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCProxy>.NativeClassPtr, 100673491);
			NPCProxy.NativeMethodInfoPtr_set_WalkSpeed_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCProxy>.NativeClassPtr, 100673492);
			NPCProxy.NativeMethodInfoPtr_get_JumpPower_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCProxy>.NativeClassPtr, 100673493);
			NPCProxy.NativeMethodInfoPtr_set_JumpPower_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCProxy>.NativeClassPtr, 100673494);
			NPCProxy.NativeMethodInfoPtr_get_Velocity_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCProxy>.NativeClassPtr, 100673495);
			NPCProxy.NativeMethodInfoPtr_set_Velocity_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCProxy>.NativeClassPtr, 100673496);
			NPCProxy.NativeMethodInfoPtr_get_NavDestinationDistance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCProxy>.NativeClassPtr, 100673497);
			NPCProxy.NativeMethodInfoPtr_get_NavDestinationReached_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCProxy>.NativeClassPtr, 100673498);
			NPCProxy.NativeMethodInfoPtr_get_NavDestinationValid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCProxy>.NativeClassPtr, 100673499);
			NPCProxy.NativeMethodInfoPtr_get_Grounded_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCProxy>.NativeClassPtr, 100673500);
			NPCProxy.NativeMethodInfoPtr__ctor_Public_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCProxy>.NativeClassPtr, 100673463);
			NPCProxy.NativeMethodInfoPtr_Respawn_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCProxy>.NativeClassPtr, 100673501);
			NPCProxy.NativeMethodInfoPtr_Jump_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCProxy>.NativeClassPtr, 100673502);
			NPCProxy.NativeMethodInfoPtr_LoadAppearance_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCProxy>.NativeClassPtr, 100673503);
			NPCProxy.NativeMethodInfoPtr_ClearAppearance_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCProxy>.NativeClassPtr, 100673504);
			NPCProxy.NativeMethodInfoPtr_SetNavDestination_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCProxy>.NativeClassPtr, 100673505);
			NPCProxy.NativeMethodInfoPtr_EquipTool_Public_Void_Tool_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCProxy>.NativeClassPtr, 100673506);
			NPCProxy.NativeMethodInfoPtr_DropTool_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCProxy>.NativeClassPtr, 100673507);
		}

		// Token: 0x1700164C RID: 5708
		// (get) Token: 0x060040E0 RID: 16608 RVA: 0x00123654 File Offset: 0x00121854
		public unsafe LuaEvent Died
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCProxy.NativeMethodInfoPtr_get_Died_Public_get_LuaEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LuaEvent>(intPtr3) : null;
			}
		}

		// Token: 0x1700164D RID: 5709
		// (get) Token: 0x060040E1 RID: 16609 RVA: 0x00123694 File Offset: 0x00121894
		// (set) Token: 0x060040E2 RID: 16610 RVA: 0x001236D4 File Offset: 0x001218D4
		public unsafe Instance MoveTarget
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCProxy.NativeMethodInfoPtr_get_MoveTarget_Public_get_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instance>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128672, XrefRangeEnd = 128674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCProxy.NativeMethodInfoPtr_set_MoveTarget_Public_set_Void_Instance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700164E RID: 5710
		// (get) Token: 0x060040E3 RID: 16611 RVA: 0x00123718 File Offset: 0x00121918
		// (set) Token: 0x060040E4 RID: 16612 RVA: 0x00123758 File Offset: 0x00121958
		public unsafe Color HeadColor
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128674, XrefRangeEnd = 128675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCProxy.NativeMethodInfoPtr_get_HeadColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128675, XrefRangeEnd = 128676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCProxy.NativeMethodInfoPtr_set_HeadColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700164F RID: 5711
		// (get) Token: 0x060040E5 RID: 16613 RVA: 0x0012379C File Offset: 0x0012199C
		// (set) Token: 0x060040E6 RID: 16614 RVA: 0x001237DC File Offset: 0x001219DC
		public unsafe Color TorsoColor
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128676, XrefRangeEnd = 128677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCProxy.NativeMethodInfoPtr_get_TorsoColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128677, XrefRangeEnd = 128678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCProxy.NativeMethodInfoPtr_set_TorsoColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001650 RID: 5712
		// (get) Token: 0x060040E7 RID: 16615 RVA: 0x00123820 File Offset: 0x00121A20
		// (set) Token: 0x060040E8 RID: 16616 RVA: 0x00123860 File Offset: 0x00121A60
		public unsafe Color LeftArmColor
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128678, XrefRangeEnd = 128679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCProxy.NativeMethodInfoPtr_get_LeftArmColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128679, XrefRangeEnd = 128680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCProxy.NativeMethodInfoPtr_set_LeftArmColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001651 RID: 5713
		// (get) Token: 0x060040E9 RID: 16617 RVA: 0x001238A4 File Offset: 0x00121AA4
		// (set) Token: 0x060040EA RID: 16618 RVA: 0x001238E4 File Offset: 0x00121AE4
		public unsafe Color RightArmColor
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128680, XrefRangeEnd = 128681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCProxy.NativeMethodInfoPtr_get_RightArmColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128681, XrefRangeEnd = 128682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCProxy.NativeMethodInfoPtr_set_RightArmColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001652 RID: 5714
		// (get) Token: 0x060040EB RID: 16619 RVA: 0x00123928 File Offset: 0x00121B28
		// (set) Token: 0x060040EC RID: 16620 RVA: 0x00123968 File Offset: 0x00121B68
		public unsafe Color LeftLegColor
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128682, XrefRangeEnd = 128683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCProxy.NativeMethodInfoPtr_get_LeftLegColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128683, XrefRangeEnd = 128684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCProxy.NativeMethodInfoPtr_set_LeftLegColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001653 RID: 5715
		// (get) Token: 0x060040ED RID: 16621 RVA: 0x001239AC File Offset: 0x00121BAC
		// (set) Token: 0x060040EE RID: 16622 RVA: 0x001239EC File Offset: 0x00121BEC
		public unsafe Color RightLegColor
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128684, XrefRangeEnd = 128685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCProxy.NativeMethodInfoPtr_get_RightLegColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128685, XrefRangeEnd = 128686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCProxy.NativeMethodInfoPtr_set_RightLegColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001654 RID: 5716
		// (get) Token: 0x060040EF RID: 16623 RVA: 0x00123A30 File Offset: 0x00121C30
		// (set) Token: 0x060040F0 RID: 16624 RVA: 0x00123A6C File Offset: 0x00121C6C
		public unsafe bool Anchored
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCProxy.NativeMethodInfoPtr_get_Anchored_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128686, XrefRangeEnd = 128688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCProxy.NativeMethodInfoPtr_set_Anchored_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001655 RID: 5717
		// (get) Token: 0x060040F1 RID: 16625 RVA: 0x00123AAC File Offset: 0x00121CAC
		// (set) Token: 0x060040F2 RID: 16626 RVA: 0x00123AE8 File Offset: 0x00121CE8
		public unsafe float Health
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCProxy.NativeMethodInfoPtr_get_Health_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128688, XrefRangeEnd = 128690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCProxy.NativeMethodInfoPtr_set_Health_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001656 RID: 5718
		// (get) Token: 0x060040F3 RID: 16627 RVA: 0x00123B28 File Offset: 0x00121D28
		// (set) Token: 0x060040F4 RID: 16628 RVA: 0x00123B64 File Offset: 0x00121D64
		public unsafe float MaxHealth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCProxy.NativeMethodInfoPtr_get_MaxHealth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128690, XrefRangeEnd = 128692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCProxy.NativeMethodInfoPtr_set_MaxHealth_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001657 RID: 5719
		// (get) Token: 0x060040F5 RID: 16629 RVA: 0x00123BA4 File Offset: 0x00121DA4
		// (set) Token: 0x060040F6 RID: 16630 RVA: 0x00123BE0 File Offset: 0x00121DE0
		public unsafe int ShirtID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCProxy.NativeMethodInfoPtr_get_ShirtID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128692, XrefRangeEnd = 128694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCProxy.NativeMethodInfoPtr_set_ShirtID_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001658 RID: 5720
		// (get) Token: 0x060040F7 RID: 16631 RVA: 0x00123C20 File Offset: 0x00121E20
		// (set) Token: 0x060040F8 RID: 16632 RVA: 0x00123C5C File Offset: 0x00121E5C
		public unsafe int PantsID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCProxy.NativeMethodInfoPtr_get_PantsID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128694, XrefRangeEnd = 128696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCProxy.NativeMethodInfoPtr_set_PantsID_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001659 RID: 5721
		// (get) Token: 0x060040F9 RID: 16633 RVA: 0x00123C9C File Offset: 0x00121E9C
		// (set) Token: 0x060040FA RID: 16634 RVA: 0x00123CD8 File Offset: 0x00121ED8
		public unsafe int FaceID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCProxy.NativeMethodInfoPtr_get_FaceID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128696, XrefRangeEnd = 128698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCProxy.NativeMethodInfoPtr_set_FaceID_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700165A RID: 5722
		// (get) Token: 0x060040FB RID: 16635 RVA: 0x00123D18 File Offset: 0x00121F18
		// (set) Token: 0x060040FC RID: 16636 RVA: 0x00123D54 File Offset: 0x00121F54
		public unsafe float WalkSpeed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCProxy.NativeMethodInfoPtr_get_WalkSpeed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128698, XrefRangeEnd = 128700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCProxy.NativeMethodInfoPtr_set_WalkSpeed_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700165B RID: 5723
		// (get) Token: 0x060040FD RID: 16637 RVA: 0x00123D94 File Offset: 0x00121F94
		// (set) Token: 0x060040FE RID: 16638 RVA: 0x00123DD0 File Offset: 0x00121FD0
		public unsafe float JumpPower
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCProxy.NativeMethodInfoPtr_get_JumpPower_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128700, XrefRangeEnd = 128702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCProxy.NativeMethodInfoPtr_set_JumpPower_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700165C RID: 5724
		// (get) Token: 0x060040FF RID: 16639 RVA: 0x00123E10 File Offset: 0x00122010
		// (set) Token: 0x06004100 RID: 16640 RVA: 0x00123E50 File Offset: 0x00122050
		public unsafe Vector3 Velocity
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128702, XrefRangeEnd = 128703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCProxy.NativeMethodInfoPtr_get_Velocity_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128703, XrefRangeEnd = 128704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCProxy.NativeMethodInfoPtr_set_Velocity_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700165D RID: 5725
		// (get) Token: 0x06004101 RID: 16641 RVA: 0x00123E94 File Offset: 0x00122094
		public unsafe float NavDestinationDistance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128704, XrefRangeEnd = 128706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCProxy.NativeMethodInfoPtr_get_NavDestinationDistance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700165E RID: 5726
		// (get) Token: 0x06004102 RID: 16642 RVA: 0x00123ED0 File Offset: 0x001220D0
		public unsafe bool NavDestinationReached
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128706, XrefRangeEnd = 128708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCProxy.NativeMethodInfoPtr_get_NavDestinationReached_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700165F RID: 5727
		// (get) Token: 0x06004103 RID: 16643 RVA: 0x00123F0C File Offset: 0x0012210C
		public unsafe bool NavDestinationValid
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128708, XrefRangeEnd = 128710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCProxy.NativeMethodInfoPtr_get_NavDestinationValid_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001660 RID: 5728
		// (get) Token: 0x06004104 RID: 16644 RVA: 0x00123F48 File Offset: 0x00122148
		public unsafe bool Grounded
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCProxy.NativeMethodInfoPtr_get_Grounded_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004105 RID: 16645 RVA: 0x00123F84 File Offset: 0x00122184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCProxy(NPC target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCProxy.NativeMethodInfoPtr__ctor_Public_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004106 RID: 16646 RVA: 0x00123FD0 File Offset: 0x001221D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128710, XrefRangeEnd = 128712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Respawn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCProxy.NativeMethodInfoPtr_Respawn_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004107 RID: 16647 RVA: 0x00124004 File Offset: 0x00122204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128712, XrefRangeEnd = 128714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Jump()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCProxy.NativeMethodInfoPtr_Jump_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004108 RID: 16648 RVA: 0x00124038 File Offset: 0x00122238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128714, XrefRangeEnd = 128716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadAppearance(int userID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref userID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCProxy.NativeMethodInfoPtr_LoadAppearance_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004109 RID: 16649 RVA: 0x00124078 File Offset: 0x00122278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128716, XrefRangeEnd = 128718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearAppearance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCProxy.NativeMethodInfoPtr_ClearAppearance_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600410A RID: 16650 RVA: 0x001240AC File Offset: 0x001222AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128718, XrefRangeEnd = 128719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNavDestination(Vector3 destination)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCProxy.NativeMethodInfoPtr_SetNavDestination_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600410B RID: 16651 RVA: 0x001240F0 File Offset: 0x001222F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128719, XrefRangeEnd = 128721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EquipTool(Tool tool)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tool);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCProxy.NativeMethodInfoPtr_EquipTool_Public_Void_Tool_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600410C RID: 16652 RVA: 0x00124134 File Offset: 0x00122334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128721, XrefRangeEnd = 128723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DropTool()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCProxy.NativeMethodInfoPtr_DropTool_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600410D RID: 16653 RVA: 0x00018859 File Offset: 0x00016A59
		public NPCProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700164B RID: 5707
		// (get) Token: 0x0600410E RID: 16654 RVA: 0x00124168 File Offset: 0x00122368
		// (set) Token: 0x0600410F RID: 16655 RVA: 0x00018862 File Offset: 0x00016A62
		public unsafe NPC npc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCProxy.NativeFieldInfoPtr_npc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCProxy.NativeFieldInfoPtr_npc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003269 RID: 12905
		private static readonly IntPtr NativeFieldInfoPtr_npc;

		// Token: 0x0400326A RID: 12906
		private static readonly IntPtr NativeMethodInfoPtr_get_Died_Public_get_LuaEvent_0;

		// Token: 0x0400326B RID: 12907
		private static readonly IntPtr NativeMethodInfoPtr_get_MoveTarget_Public_get_Instance_0;

		// Token: 0x0400326C RID: 12908
		private static readonly IntPtr NativeMethodInfoPtr_set_MoveTarget_Public_set_Void_Instance_0;

		// Token: 0x0400326D RID: 12909
		private static readonly IntPtr NativeMethodInfoPtr_get_HeadColor_Public_get_Color_0;

		// Token: 0x0400326E RID: 12910
		private static readonly IntPtr NativeMethodInfoPtr_set_HeadColor_Public_set_Void_Color_0;

		// Token: 0x0400326F RID: 12911
		private static readonly IntPtr NativeMethodInfoPtr_get_TorsoColor_Public_get_Color_0;

		// Token: 0x04003270 RID: 12912
		private static readonly IntPtr NativeMethodInfoPtr_set_TorsoColor_Public_set_Void_Color_0;

		// Token: 0x04003271 RID: 12913
		private static readonly IntPtr NativeMethodInfoPtr_get_LeftArmColor_Public_get_Color_0;

		// Token: 0x04003272 RID: 12914
		private static readonly IntPtr NativeMethodInfoPtr_set_LeftArmColor_Public_set_Void_Color_0;

		// Token: 0x04003273 RID: 12915
		private static readonly IntPtr NativeMethodInfoPtr_get_RightArmColor_Public_get_Color_0;

		// Token: 0x04003274 RID: 12916
		private static readonly IntPtr NativeMethodInfoPtr_set_RightArmColor_Public_set_Void_Color_0;

		// Token: 0x04003275 RID: 12917
		private static readonly IntPtr NativeMethodInfoPtr_get_LeftLegColor_Public_get_Color_0;

		// Token: 0x04003276 RID: 12918
		private static readonly IntPtr NativeMethodInfoPtr_set_LeftLegColor_Public_set_Void_Color_0;

		// Token: 0x04003277 RID: 12919
		private static readonly IntPtr NativeMethodInfoPtr_get_RightLegColor_Public_get_Color_0;

		// Token: 0x04003278 RID: 12920
		private static readonly IntPtr NativeMethodInfoPtr_set_RightLegColor_Public_set_Void_Color_0;

		// Token: 0x04003279 RID: 12921
		private static readonly IntPtr NativeMethodInfoPtr_get_Anchored_Public_get_Boolean_0;

		// Token: 0x0400327A RID: 12922
		private static readonly IntPtr NativeMethodInfoPtr_set_Anchored_Public_set_Void_Boolean_0;

		// Token: 0x0400327B RID: 12923
		private static readonly IntPtr NativeMethodInfoPtr_get_Health_Public_get_Single_0;

		// Token: 0x0400327C RID: 12924
		private static readonly IntPtr NativeMethodInfoPtr_set_Health_Public_set_Void_Single_0;

		// Token: 0x0400327D RID: 12925
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxHealth_Public_get_Single_0;

		// Token: 0x0400327E RID: 12926
		private static readonly IntPtr NativeMethodInfoPtr_set_MaxHealth_Public_set_Void_Single_0;

		// Token: 0x0400327F RID: 12927
		private static readonly IntPtr NativeMethodInfoPtr_get_ShirtID_Public_get_Int32_0;

		// Token: 0x04003280 RID: 12928
		private static readonly IntPtr NativeMethodInfoPtr_set_ShirtID_Public_set_Void_Int32_0;

		// Token: 0x04003281 RID: 12929
		private static readonly IntPtr NativeMethodInfoPtr_get_PantsID_Public_get_Int32_0;

		// Token: 0x04003282 RID: 12930
		private static readonly IntPtr NativeMethodInfoPtr_set_PantsID_Public_set_Void_Int32_0;

		// Token: 0x04003283 RID: 12931
		private static readonly IntPtr NativeMethodInfoPtr_get_FaceID_Public_get_Int32_0;

		// Token: 0x04003284 RID: 12932
		private static readonly IntPtr NativeMethodInfoPtr_set_FaceID_Public_set_Void_Int32_0;

		// Token: 0x04003285 RID: 12933
		private static readonly IntPtr NativeMethodInfoPtr_get_WalkSpeed_Public_get_Single_0;

		// Token: 0x04003286 RID: 12934
		private static readonly IntPtr NativeMethodInfoPtr_set_WalkSpeed_Public_set_Void_Single_0;

		// Token: 0x04003287 RID: 12935
		private static readonly IntPtr NativeMethodInfoPtr_get_JumpPower_Public_get_Single_0;

		// Token: 0x04003288 RID: 12936
		private static readonly IntPtr NativeMethodInfoPtr_set_JumpPower_Public_set_Void_Single_0;

		// Token: 0x04003289 RID: 12937
		private static readonly IntPtr NativeMethodInfoPtr_get_Velocity_Public_get_Vector3_0;

		// Token: 0x0400328A RID: 12938
		private static readonly IntPtr NativeMethodInfoPtr_set_Velocity_Public_set_Void_Vector3_0;

		// Token: 0x0400328B RID: 12939
		private static readonly IntPtr NativeMethodInfoPtr_get_NavDestinationDistance_Public_get_Single_0;

		// Token: 0x0400328C RID: 12940
		private static readonly IntPtr NativeMethodInfoPtr_get_NavDestinationReached_Public_get_Boolean_0;

		// Token: 0x0400328D RID: 12941
		private static readonly IntPtr NativeMethodInfoPtr_get_NavDestinationValid_Public_get_Boolean_0;

		// Token: 0x0400328E RID: 12942
		private static readonly IntPtr NativeMethodInfoPtr_get_Grounded_Public_get_Boolean_0;

		// Token: 0x0400328F RID: 12943
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_NPC_0;

		// Token: 0x04003290 RID: 12944
		private static readonly IntPtr NativeMethodInfoPtr_Respawn_Public_Void_0;

		// Token: 0x04003291 RID: 12945
		private static readonly IntPtr NativeMethodInfoPtr_Jump_Public_Void_0;

		// Token: 0x04003292 RID: 12946
		private static readonly IntPtr NativeMethodInfoPtr_LoadAppearance_Public_Void_Int32_0;

		// Token: 0x04003293 RID: 12947
		private static readonly IntPtr NativeMethodInfoPtr_ClearAppearance_Public_Void_0;

		// Token: 0x04003294 RID: 12948
		private static readonly IntPtr NativeMethodInfoPtr_SetNavDestination_Public_Void_Vector3_0;

		// Token: 0x04003295 RID: 12949
		private static readonly IntPtr NativeMethodInfoPtr_EquipTool_Public_Void_Tool_0;

		// Token: 0x04003296 RID: 12950
		private static readonly IntPtr NativeMethodInfoPtr_DropTool_Public_Void_0;
	}
}
