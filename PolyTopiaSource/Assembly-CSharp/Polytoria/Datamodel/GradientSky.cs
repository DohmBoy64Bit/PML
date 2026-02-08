using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Mirror;
using UnityEngine;

namespace Polytoria.Datamodel
{
	// Token: 0x0200027E RID: 638
	public class GradientSky : SkyBase
	{
		// Token: 0x06003260 RID: 12896 RVA: 0x000E6B48 File Offset: 0x000E4D48
		// Note: this type is marked as 'beforefieldinit'.
		static GradientSky()
		{
			Il2CppClassPointerStore<GradientSky>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel", "GradientSky");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GradientSky>.NativeClassPtr);
			GradientSky.NativeFieldInfoPtr_sunDiscColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, "sunDiscColor");
			GradientSky.NativeFieldInfoPtr_sunDiscMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, "sunDiscMultiplier");
			GradientSky.NativeFieldInfoPtr_sunDiscExponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, "sunDiscExponent");
			GradientSky.NativeFieldInfoPtr_sunHaloColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, "sunHaloColor");
			GradientSky.NativeFieldInfoPtr_sunHaloExponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, "sunHaloExponent");
			GradientSky.NativeFieldInfoPtr_sunHaloContribution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, "sunHaloContribution");
			GradientSky.NativeFieldInfoPtr_horizonLineColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, "horizonLineColor");
			GradientSky.NativeFieldInfoPtr_horizonLineExponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, "horizonLineExponent");
			GradientSky.NativeFieldInfoPtr_horizonLineContribution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, "horizonLineContribution");
			GradientSky.NativeFieldInfoPtr_skyGradientTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, "skyGradientTop");
			GradientSky.NativeFieldInfoPtr_skyGradientBottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, "skyGradientBottom");
			GradientSky.NativeFieldInfoPtr_skyGradientExponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, "skyGradientExponent");
			GradientSky.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_sunDiscColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_sunDiscColor");
			GradientSky.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_sunDiscMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_sunDiscMultiplier");
			GradientSky.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_sunDiscExponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_sunDiscExponent");
			GradientSky.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_sunHaloColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_sunHaloColor");
			GradientSky.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_sunHaloExponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_sunHaloExponent");
			GradientSky.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_sunHaloContribution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_sunHaloContribution");
			GradientSky.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_horizonLineColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_horizonLineColor");
			GradientSky.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_horizonLineExponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_horizonLineExponent");
			GradientSky.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_horizonLineContribution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_horizonLineContribution");
			GradientSky.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_skyGradientTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_skyGradientTop");
			GradientSky.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_skyGradientBottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_skyGradientBottom");
			GradientSky.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_skyGradientExponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_skyGradientExponent");
			GradientSky.NativeMethodInfoPtr_get_SunDiscColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, 100670889);
			GradientSky.NativeMethodInfoPtr_set_SunDiscColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, 100670890);
			GradientSky.NativeMethodInfoPtr_get_SunDiscMultiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, 100670891);
			GradientSky.NativeMethodInfoPtr_set_SunDiscMultiplier_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, 100670892);
			GradientSky.NativeMethodInfoPtr_get_SunDiscExponent_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, 100670893);
			GradientSky.NativeMethodInfoPtr_set_SunDiscExponent_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, 100670894);
			GradientSky.NativeMethodInfoPtr_get_SunHaloColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, 100670895);
			GradientSky.NativeMethodInfoPtr_set_SunHaloColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, 100670896);
			GradientSky.NativeMethodInfoPtr_get_SunHaloExponent_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, 100670897);
			GradientSky.NativeMethodInfoPtr_set_SunHaloExponent_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, 100670898);
			GradientSky.NativeMethodInfoPtr_get_SunHaloContribution_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, 100670899);
			GradientSky.NativeMethodInfoPtr_set_SunHaloContribution_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, 100670900);
			GradientSky.NativeMethodInfoPtr_get_HorizonLineColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, 100670901);
			GradientSky.NativeMethodInfoPtr_set_HorizonLineColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, 100670902);
			GradientSky.NativeMethodInfoPtr_get_HorizonLineExponent_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, 100670903);
			GradientSky.NativeMethodInfoPtr_set_HorizonLineExponent_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, 100670904);
			GradientSky.NativeMethodInfoPtr_get_HorizonLineContribution_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, 100670905);
			GradientSky.NativeMethodInfoPtr_set_HorizonLineContribution_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, 100670906);
			GradientSky.NativeMethodInfoPtr_get_SkyGradientTop_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, 100670907);
			GradientSky.NativeMethodInfoPtr_set_SkyGradientTop_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, 100670908);
			GradientSky.NativeMethodInfoPtr_get_SkyGradientBottom_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, 100670909);
			GradientSky.NativeMethodInfoPtr_set_SkyGradientBottom_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, 100670910);
			GradientSky.NativeMethodInfoPtr_get_SkyGradientExponent_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, 100670911);
			GradientSky.NativeMethodInfoPtr_set_SkyGradientExponent_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, 100670912);
			GradientSky.NativeMethodInfoPtr_get_NetworksunDiscColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, 100670931);
			GradientSky.NativeMethodInfoPtr_set_NetworksunDiscColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, 100670932);
			GradientSky.NativeMethodInfoPtr_get_NetworksunDiscMultiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, 100670933);
			GradientSky.NativeMethodInfoPtr_set_NetworksunDiscMultiplier_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, 100670934);
			GradientSky.NativeMethodInfoPtr_get_NetworksunDiscExponent_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, 100670935);
			GradientSky.NativeMethodInfoPtr_set_NetworksunDiscExponent_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, 100670936);
			GradientSky.NativeMethodInfoPtr_get_NetworksunHaloColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, 100670937);
			GradientSky.NativeMethodInfoPtr_set_NetworksunHaloColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, 100670938);
			GradientSky.NativeMethodInfoPtr_get_NetworksunHaloExponent_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, 100670939);
			GradientSky.NativeMethodInfoPtr_set_NetworksunHaloExponent_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, 100670940);
			GradientSky.NativeMethodInfoPtr_get_NetworksunHaloContribution_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, 100670941);
			GradientSky.NativeMethodInfoPtr_set_NetworksunHaloContribution_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, 100670942);
			GradientSky.NativeMethodInfoPtr_get_NetworkhorizonLineColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, 100670943);
			GradientSky.NativeMethodInfoPtr_set_NetworkhorizonLineColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, 100670944);
			GradientSky.NativeMethodInfoPtr_get_NetworkhorizonLineExponent_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, 100670945);
			GradientSky.NativeMethodInfoPtr_set_NetworkhorizonLineExponent_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, 100670946);
			GradientSky.NativeMethodInfoPtr_get_NetworkhorizonLineContribution_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, 100670947);
			GradientSky.NativeMethodInfoPtr_set_NetworkhorizonLineContribution_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, 100670948);
			GradientSky.NativeMethodInfoPtr_get_NetworkskyGradientTop_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, 100670949);
			GradientSky.NativeMethodInfoPtr_set_NetworkskyGradientTop_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, 100670950);
			GradientSky.NativeMethodInfoPtr_get_NetworkskyGradientBottom_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, 100670951);
			GradientSky.NativeMethodInfoPtr_set_NetworkskyGradientBottom_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, 100670952);
			GradientSky.NativeMethodInfoPtr_get_NetworkskyGradientExponent_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, 100670953);
			GradientSky.NativeMethodInfoPtr_set_NetworkskyGradientExponent_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, 100670954);
			GradientSky.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, 100670929);
			GradientSky.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, 100670913);
			GradientSky.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, 100670914);
			GradientSky.NativeMethodInfoPtr_Apply_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, 100670915);
			GradientSky.NativeMethodInfoPtr_CopyProperties_Protected_Virtual_Void_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, 100670916);
			GradientSky.NativeMethodInfoPtr_OnSunDiscColorChanged_Private_Void_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, 100670917);
			GradientSky.NativeMethodInfoPtr_OnSunDiscMultiplierChanged_Private_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, 100670918);
			GradientSky.NativeMethodInfoPtr_OnSunDiscExponentChanged_Private_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, 100670919);
			GradientSky.NativeMethodInfoPtr_OnSunHaloColorChanged_Private_Void_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, 100670920);
			GradientSky.NativeMethodInfoPtr_OnSunHaloExponentChanged_Private_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, 100670921);
			GradientSky.NativeMethodInfoPtr_OnSunHaloContributionChanged_Private_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, 100670922);
			GradientSky.NativeMethodInfoPtr_OnHorizonLineColorChanged_Private_Void_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, 100670923);
			GradientSky.NativeMethodInfoPtr_OnHorizonLineExponentChanged_Private_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, 100670924);
			GradientSky.NativeMethodInfoPtr_OnHorizonLineContributionChanged_Private_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, 100670925);
			GradientSky.NativeMethodInfoPtr_OnSkyGradientTopChanged_Private_Void_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, 100670926);
			GradientSky.NativeMethodInfoPtr_OnSkyGradientBottomChanged_Private_Void_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, 100670927);
			GradientSky.NativeMethodInfoPtr_OnSkyGradientExponentChanged_Private_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, 100670928);
			GradientSky.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, 100670930);
			GradientSky.NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, 100670955);
			GradientSky.NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientSky>.NativeClassPtr, 100670956);
		}

		// Token: 0x170011B1 RID: 4529
		// (get) Token: 0x06003261 RID: 12897 RVA: 0x000E72A8 File Offset: 0x000E54A8
		// (set) Token: 0x06003262 RID: 12898 RVA: 0x000E72E8 File Offset: 0x000E54E8
		public unsafe Color SunDiscColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSky.NativeMethodInfoPtr_get_SunDiscColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 103583, RefRangeEnd = 103586, XrefRangeStart = 103577, XrefRangeEnd = 103583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSky.NativeMethodInfoPtr_set_SunDiscColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170011B2 RID: 4530
		// (get) Token: 0x06003263 RID: 12899 RVA: 0x000E732C File Offset: 0x000E552C
		// (set) Token: 0x06003264 RID: 12900 RVA: 0x000E7368 File Offset: 0x000E5568
		public unsafe float SunDiscMultiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSky.NativeMethodInfoPtr_get_SunDiscMultiplier_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 103593, RefRangeEnd = 103596, XrefRangeStart = 103586, XrefRangeEnd = 103593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSky.NativeMethodInfoPtr_set_SunDiscMultiplier_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170011B3 RID: 4531
		// (get) Token: 0x06003265 RID: 12901 RVA: 0x000E73A8 File Offset: 0x000E55A8
		// (set) Token: 0x06003266 RID: 12902 RVA: 0x000E73E4 File Offset: 0x000E55E4
		public unsafe float SunDiscExponent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSky.NativeMethodInfoPtr_get_SunDiscExponent_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 103603, RefRangeEnd = 103606, XrefRangeStart = 103596, XrefRangeEnd = 103603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSky.NativeMethodInfoPtr_set_SunDiscExponent_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170011B4 RID: 4532
		// (get) Token: 0x06003267 RID: 12903 RVA: 0x000E7424 File Offset: 0x000E5624
		// (set) Token: 0x06003268 RID: 12904 RVA: 0x000E7464 File Offset: 0x000E5664
		public unsafe Color SunHaloColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSky.NativeMethodInfoPtr_get_SunHaloColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 103612, RefRangeEnd = 103615, XrefRangeStart = 103606, XrefRangeEnd = 103612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSky.NativeMethodInfoPtr_set_SunHaloColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170011B5 RID: 4533
		// (get) Token: 0x06003269 RID: 12905 RVA: 0x000E74A8 File Offset: 0x000E56A8
		// (set) Token: 0x0600326A RID: 12906 RVA: 0x000E74E4 File Offset: 0x000E56E4
		public unsafe float SunHaloExponent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSky.NativeMethodInfoPtr_get_SunHaloExponent_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 103622, RefRangeEnd = 103625, XrefRangeStart = 103615, XrefRangeEnd = 103622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSky.NativeMethodInfoPtr_set_SunHaloExponent_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170011B6 RID: 4534
		// (get) Token: 0x0600326B RID: 12907 RVA: 0x000E7524 File Offset: 0x000E5724
		// (set) Token: 0x0600326C RID: 12908 RVA: 0x000E7560 File Offset: 0x000E5760
		public unsafe float SunHaloContribution
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSky.NativeMethodInfoPtr_get_SunHaloContribution_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 103632, RefRangeEnd = 103635, XrefRangeStart = 103625, XrefRangeEnd = 103632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSky.NativeMethodInfoPtr_set_SunHaloContribution_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170011B7 RID: 4535
		// (get) Token: 0x0600326D RID: 12909 RVA: 0x000E75A0 File Offset: 0x000E57A0
		// (set) Token: 0x0600326E RID: 12910 RVA: 0x000E75E0 File Offset: 0x000E57E0
		public unsafe Color HorizonLineColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSky.NativeMethodInfoPtr_get_HorizonLineColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 103641, RefRangeEnd = 103644, XrefRangeStart = 103635, XrefRangeEnd = 103641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSky.NativeMethodInfoPtr_set_HorizonLineColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170011B8 RID: 4536
		// (get) Token: 0x0600326F RID: 12911 RVA: 0x000E7624 File Offset: 0x000E5824
		// (set) Token: 0x06003270 RID: 12912 RVA: 0x000E7660 File Offset: 0x000E5860
		public unsafe float HorizonLineExponent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSky.NativeMethodInfoPtr_get_HorizonLineExponent_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 103651, RefRangeEnd = 103654, XrefRangeStart = 103644, XrefRangeEnd = 103651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSky.NativeMethodInfoPtr_set_HorizonLineExponent_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170011B9 RID: 4537
		// (get) Token: 0x06003271 RID: 12913 RVA: 0x000E76A0 File Offset: 0x000E58A0
		// (set) Token: 0x06003272 RID: 12914 RVA: 0x000E76DC File Offset: 0x000E58DC
		public unsafe float HorizonLineContribution
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSky.NativeMethodInfoPtr_get_HorizonLineContribution_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 103661, RefRangeEnd = 103664, XrefRangeStart = 103654, XrefRangeEnd = 103661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSky.NativeMethodInfoPtr_set_HorizonLineContribution_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170011BA RID: 4538
		// (get) Token: 0x06003273 RID: 12915 RVA: 0x000E771C File Offset: 0x000E591C
		// (set) Token: 0x06003274 RID: 12916 RVA: 0x000E775C File Offset: 0x000E595C
		public unsafe Color SkyGradientTop
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSky.NativeMethodInfoPtr_get_SkyGradientTop_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 103670, RefRangeEnd = 103673, XrefRangeStart = 103664, XrefRangeEnd = 103670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSky.NativeMethodInfoPtr_set_SkyGradientTop_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170011BB RID: 4539
		// (get) Token: 0x06003275 RID: 12917 RVA: 0x000E77A0 File Offset: 0x000E59A0
		// (set) Token: 0x06003276 RID: 12918 RVA: 0x000E77E0 File Offset: 0x000E59E0
		public unsafe Color SkyGradientBottom
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSky.NativeMethodInfoPtr_get_SkyGradientBottom_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 103679, RefRangeEnd = 103682, XrefRangeStart = 103673, XrefRangeEnd = 103679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSky.NativeMethodInfoPtr_set_SkyGradientBottom_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170011BC RID: 4540
		// (get) Token: 0x06003277 RID: 12919 RVA: 0x000E7824 File Offset: 0x000E5A24
		// (set) Token: 0x06003278 RID: 12920 RVA: 0x000E7860 File Offset: 0x000E5A60
		public unsafe float SkyGradientExponent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSky.NativeMethodInfoPtr_get_SkyGradientExponent_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 103689, RefRangeEnd = 103692, XrefRangeStart = 103682, XrefRangeEnd = 103689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSky.NativeMethodInfoPtr_set_SkyGradientExponent_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170011BD RID: 4541
		// (get) Token: 0x06003279 RID: 12921 RVA: 0x000E78A0 File Offset: 0x000E5AA0
		// (set) Token: 0x0600327A RID: 12922 RVA: 0x000E78E0 File Offset: 0x000E5AE0
		public unsafe Color NetworksunDiscColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSky.NativeMethodInfoPtr_get_NetworksunDiscColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103692, XrefRangeEnd = 103695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSky.NativeMethodInfoPtr_set_NetworksunDiscColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170011BE RID: 4542
		// (get) Token: 0x0600327B RID: 12923 RVA: 0x000E7924 File Offset: 0x000E5B24
		// (set) Token: 0x0600327C RID: 12924 RVA: 0x000E7960 File Offset: 0x000E5B60
		public unsafe float NetworksunDiscMultiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSky.NativeMethodInfoPtr_get_NetworksunDiscMultiplier_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103695, XrefRangeEnd = 103698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSky.NativeMethodInfoPtr_set_NetworksunDiscMultiplier_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170011BF RID: 4543
		// (get) Token: 0x0600327D RID: 12925 RVA: 0x000E79A0 File Offset: 0x000E5BA0
		// (set) Token: 0x0600327E RID: 12926 RVA: 0x000E79DC File Offset: 0x000E5BDC
		public unsafe float NetworksunDiscExponent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSky.NativeMethodInfoPtr_get_NetworksunDiscExponent_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103698, XrefRangeEnd = 103701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSky.NativeMethodInfoPtr_set_NetworksunDiscExponent_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170011C0 RID: 4544
		// (get) Token: 0x0600327F RID: 12927 RVA: 0x000E7A1C File Offset: 0x000E5C1C
		// (set) Token: 0x06003280 RID: 12928 RVA: 0x000E7A5C File Offset: 0x000E5C5C
		public unsafe Color NetworksunHaloColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSky.NativeMethodInfoPtr_get_NetworksunHaloColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103701, XrefRangeEnd = 103704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSky.NativeMethodInfoPtr_set_NetworksunHaloColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170011C1 RID: 4545
		// (get) Token: 0x06003281 RID: 12929 RVA: 0x000E7AA0 File Offset: 0x000E5CA0
		// (set) Token: 0x06003282 RID: 12930 RVA: 0x000E7ADC File Offset: 0x000E5CDC
		public unsafe float NetworksunHaloExponent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSky.NativeMethodInfoPtr_get_NetworksunHaloExponent_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103704, XrefRangeEnd = 103707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSky.NativeMethodInfoPtr_set_NetworksunHaloExponent_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170011C2 RID: 4546
		// (get) Token: 0x06003283 RID: 12931 RVA: 0x000E7B1C File Offset: 0x000E5D1C
		// (set) Token: 0x06003284 RID: 12932 RVA: 0x000E7B58 File Offset: 0x000E5D58
		public unsafe float NetworksunHaloContribution
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSky.NativeMethodInfoPtr_get_NetworksunHaloContribution_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103707, XrefRangeEnd = 103710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSky.NativeMethodInfoPtr_set_NetworksunHaloContribution_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170011C3 RID: 4547
		// (get) Token: 0x06003285 RID: 12933 RVA: 0x000E7B98 File Offset: 0x000E5D98
		// (set) Token: 0x06003286 RID: 12934 RVA: 0x000E7BD8 File Offset: 0x000E5DD8
		public unsafe Color NetworkhorizonLineColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSky.NativeMethodInfoPtr_get_NetworkhorizonLineColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103710, XrefRangeEnd = 103713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSky.NativeMethodInfoPtr_set_NetworkhorizonLineColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170011C4 RID: 4548
		// (get) Token: 0x06003287 RID: 12935 RVA: 0x000E7C1C File Offset: 0x000E5E1C
		// (set) Token: 0x06003288 RID: 12936 RVA: 0x000E7C58 File Offset: 0x000E5E58
		public unsafe float NetworkhorizonLineExponent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSky.NativeMethodInfoPtr_get_NetworkhorizonLineExponent_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103713, XrefRangeEnd = 103716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSky.NativeMethodInfoPtr_set_NetworkhorizonLineExponent_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170011C5 RID: 4549
		// (get) Token: 0x06003289 RID: 12937 RVA: 0x000E7C98 File Offset: 0x000E5E98
		// (set) Token: 0x0600328A RID: 12938 RVA: 0x000E7CD4 File Offset: 0x000E5ED4
		public unsafe float NetworkhorizonLineContribution
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSky.NativeMethodInfoPtr_get_NetworkhorizonLineContribution_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103716, XrefRangeEnd = 103719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSky.NativeMethodInfoPtr_set_NetworkhorizonLineContribution_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170011C6 RID: 4550
		// (get) Token: 0x0600328B RID: 12939 RVA: 0x000E7D14 File Offset: 0x000E5F14
		// (set) Token: 0x0600328C RID: 12940 RVA: 0x000E7D54 File Offset: 0x000E5F54
		public unsafe Color NetworkskyGradientTop
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSky.NativeMethodInfoPtr_get_NetworkskyGradientTop_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103719, XrefRangeEnd = 103722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSky.NativeMethodInfoPtr_set_NetworkskyGradientTop_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170011C7 RID: 4551
		// (get) Token: 0x0600328D RID: 12941 RVA: 0x000E7D98 File Offset: 0x000E5F98
		// (set) Token: 0x0600328E RID: 12942 RVA: 0x000E7DD8 File Offset: 0x000E5FD8
		public unsafe Color NetworkskyGradientBottom
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSky.NativeMethodInfoPtr_get_NetworkskyGradientBottom_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103722, XrefRangeEnd = 103725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSky.NativeMethodInfoPtr_set_NetworkskyGradientBottom_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170011C8 RID: 4552
		// (get) Token: 0x0600328F RID: 12943 RVA: 0x000E7E1C File Offset: 0x000E601C
		// (set) Token: 0x06003290 RID: 12944 RVA: 0x000E7E58 File Offset: 0x000E6058
		public unsafe float NetworkskyGradientExponent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSky.NativeMethodInfoPtr_get_NetworkskyGradientExponent_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103725, XrefRangeEnd = 103728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSky.NativeMethodInfoPtr_set_NetworkskyGradientExponent_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003291 RID: 12945 RVA: 0x000E7E98 File Offset: 0x000E6098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103728, XrefRangeEnd = 103803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GradientSky()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GradientSky>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSky.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003292 RID: 12946 RVA: 0x000E7ED4 File Offset: 0x000E60D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103803, XrefRangeEnd = 103819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GradientSky.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003293 RID: 12947 RVA: 0x000E7F10 File Offset: 0x000E6110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103819, XrefRangeEnd = 103820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GradientSky.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003294 RID: 12948 RVA: 0x000E7F4C File Offset: 0x000E614C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103820, XrefRangeEnd = 103836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Apply()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GradientSky.NativeMethodInfoPtr_Apply_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003295 RID: 12949 RVA: 0x000E7F88 File Offset: 0x000E6188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103836, XrefRangeEnd = 103853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CopyProperties(Instance clone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clone);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GradientSky.NativeMethodInfoPtr_CopyProperties_Protected_Virtual_Void_Instance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003296 RID: 12950 RVA: 0x000E7FD8 File Offset: 0x000E61D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103853, XrefRangeEnd = 103855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSunDiscColorChanged(Color oldValue, Color newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(oldValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSky.NativeMethodInfoPtr_OnSunDiscColorChanged_Private_Void_Color_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003297 RID: 12951 RVA: 0x000E802C File Offset: 0x000E622C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103855, XrefRangeEnd = 103857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSunDiscMultiplierChanged(float oldValue, float newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref oldValue;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSky.NativeMethodInfoPtr_OnSunDiscMultiplierChanged_Private_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003298 RID: 12952 RVA: 0x000E8078 File Offset: 0x000E6278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103857, XrefRangeEnd = 103859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSunDiscExponentChanged(float oldValue, float newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref oldValue;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSky.NativeMethodInfoPtr_OnSunDiscExponentChanged_Private_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003299 RID: 12953 RVA: 0x000E80C4 File Offset: 0x000E62C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103859, XrefRangeEnd = 103861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSunHaloColorChanged(Color oldValue, Color newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(oldValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSky.NativeMethodInfoPtr_OnSunHaloColorChanged_Private_Void_Color_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600329A RID: 12954 RVA: 0x000E8118 File Offset: 0x000E6318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103861, XrefRangeEnd = 103863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSunHaloExponentChanged(float oldValue, float newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref oldValue;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSky.NativeMethodInfoPtr_OnSunHaloExponentChanged_Private_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600329B RID: 12955 RVA: 0x000E8164 File Offset: 0x000E6364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103863, XrefRangeEnd = 103865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSunHaloContributionChanged(float oldValue, float newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref oldValue;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSky.NativeMethodInfoPtr_OnSunHaloContributionChanged_Private_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600329C RID: 12956 RVA: 0x000E81B0 File Offset: 0x000E63B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103865, XrefRangeEnd = 103867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnHorizonLineColorChanged(Color oldValue, Color newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(oldValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSky.NativeMethodInfoPtr_OnHorizonLineColorChanged_Private_Void_Color_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600329D RID: 12957 RVA: 0x000E8204 File Offset: 0x000E6404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103867, XrefRangeEnd = 103869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnHorizonLineExponentChanged(float oldValue, float newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref oldValue;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSky.NativeMethodInfoPtr_OnHorizonLineExponentChanged_Private_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600329E RID: 12958 RVA: 0x000E8250 File Offset: 0x000E6450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103869, XrefRangeEnd = 103871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnHorizonLineContributionChanged(float oldValue, float newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref oldValue;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSky.NativeMethodInfoPtr_OnHorizonLineContributionChanged_Private_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600329F RID: 12959 RVA: 0x000E829C File Offset: 0x000E649C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103871, XrefRangeEnd = 103873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSkyGradientTopChanged(Color oldValue, Color newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(oldValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSky.NativeMethodInfoPtr_OnSkyGradientTopChanged_Private_Void_Color_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032A0 RID: 12960 RVA: 0x000E82F0 File Offset: 0x000E64F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103873, XrefRangeEnd = 103875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSkyGradientBottomChanged(Color oldValue, Color newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(oldValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSky.NativeMethodInfoPtr_OnSkyGradientBottomChanged_Private_Void_Color_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032A1 RID: 12961 RVA: 0x000E8344 File Offset: 0x000E6544
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103875, XrefRangeEnd = 103877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSkyGradientExponentChanged(float oldValue, float newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref oldValue;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientSky.NativeMethodInfoPtr_OnSkyGradientExponentChanged_Private_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032A2 RID: 12962 RVA: 0x000E8390 File Offset: 0x000E6590
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 20124, RefRangeEnd = 20136, XrefRangeStart = 20124, XrefRangeEnd = 20136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Weaved()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GradientSky.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060032A3 RID: 12963 RVA: 0x000E83D8 File Offset: 0x000E65D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103877, XrefRangeEnd = 103906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GradientSky.NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032A4 RID: 12964 RVA: 0x000E8434 File Offset: 0x000E6634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103906, XrefRangeEnd = 103980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GradientSky.NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032A5 RID: 12965 RVA: 0x00013F57 File Offset: 0x00012157
		public GradientSky(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001199 RID: 4505
		// (get) Token: 0x060032A6 RID: 12966 RVA: 0x000E8490 File Offset: 0x000E6690
		// (set) Token: 0x060032A7 RID: 12967 RVA: 0x00013F60 File Offset: 0x00012160
		public unsafe Color sunDiscColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientSky.NativeFieldInfoPtr_sunDiscColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientSky.NativeFieldInfoPtr_sunDiscColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700119A RID: 4506
		// (get) Token: 0x060032A8 RID: 12968 RVA: 0x000E84C0 File Offset: 0x000E66C0
		// (set) Token: 0x060032A9 RID: 12969 RVA: 0x00013F7F File Offset: 0x0001217F
		public unsafe float sunDiscMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientSky.NativeFieldInfoPtr_sunDiscMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientSky.NativeFieldInfoPtr_sunDiscMultiplier)) = value;
			}
		}

		// Token: 0x1700119B RID: 4507
		// (get) Token: 0x060032AA RID: 12970 RVA: 0x000E84E8 File Offset: 0x000E66E8
		// (set) Token: 0x060032AB RID: 12971 RVA: 0x00013F9A File Offset: 0x0001219A
		public unsafe float sunDiscExponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientSky.NativeFieldInfoPtr_sunDiscExponent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientSky.NativeFieldInfoPtr_sunDiscExponent)) = value;
			}
		}

		// Token: 0x1700119C RID: 4508
		// (get) Token: 0x060032AC RID: 12972 RVA: 0x000E8510 File Offset: 0x000E6710
		// (set) Token: 0x060032AD RID: 12973 RVA: 0x00013FB5 File Offset: 0x000121B5
		public unsafe Color sunHaloColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientSky.NativeFieldInfoPtr_sunHaloColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientSky.NativeFieldInfoPtr_sunHaloColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700119D RID: 4509
		// (get) Token: 0x060032AE RID: 12974 RVA: 0x000E8540 File Offset: 0x000E6740
		// (set) Token: 0x060032AF RID: 12975 RVA: 0x00013FD4 File Offset: 0x000121D4
		public unsafe float sunHaloExponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientSky.NativeFieldInfoPtr_sunHaloExponent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientSky.NativeFieldInfoPtr_sunHaloExponent)) = value;
			}
		}

		// Token: 0x1700119E RID: 4510
		// (get) Token: 0x060032B0 RID: 12976 RVA: 0x000E8568 File Offset: 0x000E6768
		// (set) Token: 0x060032B1 RID: 12977 RVA: 0x00013FEF File Offset: 0x000121EF
		public unsafe float sunHaloContribution
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientSky.NativeFieldInfoPtr_sunHaloContribution);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientSky.NativeFieldInfoPtr_sunHaloContribution)) = value;
			}
		}

		// Token: 0x1700119F RID: 4511
		// (get) Token: 0x060032B2 RID: 12978 RVA: 0x000E8590 File Offset: 0x000E6790
		// (set) Token: 0x060032B3 RID: 12979 RVA: 0x0001400A File Offset: 0x0001220A
		public unsafe Color horizonLineColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientSky.NativeFieldInfoPtr_horizonLineColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientSky.NativeFieldInfoPtr_horizonLineColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011A0 RID: 4512
		// (get) Token: 0x060032B4 RID: 12980 RVA: 0x000E85C0 File Offset: 0x000E67C0
		// (set) Token: 0x060032B5 RID: 12981 RVA: 0x00014029 File Offset: 0x00012229
		public unsafe float horizonLineExponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientSky.NativeFieldInfoPtr_horizonLineExponent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientSky.NativeFieldInfoPtr_horizonLineExponent)) = value;
			}
		}

		// Token: 0x170011A1 RID: 4513
		// (get) Token: 0x060032B6 RID: 12982 RVA: 0x000E85E8 File Offset: 0x000E67E8
		// (set) Token: 0x060032B7 RID: 12983 RVA: 0x00014044 File Offset: 0x00012244
		public unsafe float horizonLineContribution
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientSky.NativeFieldInfoPtr_horizonLineContribution);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientSky.NativeFieldInfoPtr_horizonLineContribution)) = value;
			}
		}

		// Token: 0x170011A2 RID: 4514
		// (get) Token: 0x060032B8 RID: 12984 RVA: 0x000E8610 File Offset: 0x000E6810
		// (set) Token: 0x060032B9 RID: 12985 RVA: 0x0001405F File Offset: 0x0001225F
		public unsafe Color skyGradientTop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientSky.NativeFieldInfoPtr_skyGradientTop);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientSky.NativeFieldInfoPtr_skyGradientTop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011A3 RID: 4515
		// (get) Token: 0x060032BA RID: 12986 RVA: 0x000E8640 File Offset: 0x000E6840
		// (set) Token: 0x060032BB RID: 12987 RVA: 0x0001407E File Offset: 0x0001227E
		public unsafe Color skyGradientBottom
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientSky.NativeFieldInfoPtr_skyGradientBottom);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientSky.NativeFieldInfoPtr_skyGradientBottom), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011A4 RID: 4516
		// (get) Token: 0x060032BC RID: 12988 RVA: 0x000E8670 File Offset: 0x000E6870
		// (set) Token: 0x060032BD RID: 12989 RVA: 0x0001409D File Offset: 0x0001229D
		public unsafe float skyGradientExponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientSky.NativeFieldInfoPtr_skyGradientExponent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientSky.NativeFieldInfoPtr_skyGradientExponent)) = value;
			}
		}

		// Token: 0x170011A5 RID: 4517
		// (get) Token: 0x060032BE RID: 12990 RVA: 0x000E8698 File Offset: 0x000E6898
		// (set) Token: 0x060032BF RID: 12991 RVA: 0x000140B8 File Offset: 0x000122B8
		public unsafe Action<Color, Color> _Mirror_SyncVarHookDelegate_sunDiscColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientSky.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_sunDiscColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Color, Color>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientSky.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_sunDiscColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011A6 RID: 4518
		// (get) Token: 0x060032C0 RID: 12992 RVA: 0x000E86C8 File Offset: 0x000E68C8
		// (set) Token: 0x060032C1 RID: 12993 RVA: 0x000140D7 File Offset: 0x000122D7
		public unsafe Action<float, float> _Mirror_SyncVarHookDelegate_sunDiscMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientSky.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_sunDiscMultiplier);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientSky.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_sunDiscMultiplier), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011A7 RID: 4519
		// (get) Token: 0x060032C2 RID: 12994 RVA: 0x000E86F8 File Offset: 0x000E68F8
		// (set) Token: 0x060032C3 RID: 12995 RVA: 0x000140F6 File Offset: 0x000122F6
		public unsafe Action<float, float> _Mirror_SyncVarHookDelegate_sunDiscExponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientSky.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_sunDiscExponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientSky.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_sunDiscExponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011A8 RID: 4520
		// (get) Token: 0x060032C4 RID: 12996 RVA: 0x000E8728 File Offset: 0x000E6928
		// (set) Token: 0x060032C5 RID: 12997 RVA: 0x00014115 File Offset: 0x00012315
		public unsafe Action<Color, Color> _Mirror_SyncVarHookDelegate_sunHaloColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientSky.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_sunHaloColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Color, Color>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientSky.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_sunHaloColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011A9 RID: 4521
		// (get) Token: 0x060032C6 RID: 12998 RVA: 0x000E8758 File Offset: 0x000E6958
		// (set) Token: 0x060032C7 RID: 12999 RVA: 0x00014134 File Offset: 0x00012334
		public unsafe Action<float, float> _Mirror_SyncVarHookDelegate_sunHaloExponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientSky.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_sunHaloExponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientSky.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_sunHaloExponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011AA RID: 4522
		// (get) Token: 0x060032C8 RID: 13000 RVA: 0x000E8788 File Offset: 0x000E6988
		// (set) Token: 0x060032C9 RID: 13001 RVA: 0x00014153 File Offset: 0x00012353
		public unsafe Action<float, float> _Mirror_SyncVarHookDelegate_sunHaloContribution
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientSky.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_sunHaloContribution);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientSky.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_sunHaloContribution), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011AB RID: 4523
		// (get) Token: 0x060032CA RID: 13002 RVA: 0x000E87B8 File Offset: 0x000E69B8
		// (set) Token: 0x060032CB RID: 13003 RVA: 0x00014172 File Offset: 0x00012372
		public unsafe Action<Color, Color> _Mirror_SyncVarHookDelegate_horizonLineColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientSky.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_horizonLineColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Color, Color>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientSky.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_horizonLineColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011AC RID: 4524
		// (get) Token: 0x060032CC RID: 13004 RVA: 0x000E87E8 File Offset: 0x000E69E8
		// (set) Token: 0x060032CD RID: 13005 RVA: 0x00014191 File Offset: 0x00012391
		public unsafe Action<float, float> _Mirror_SyncVarHookDelegate_horizonLineExponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientSky.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_horizonLineExponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientSky.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_horizonLineExponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011AD RID: 4525
		// (get) Token: 0x060032CE RID: 13006 RVA: 0x000E8818 File Offset: 0x000E6A18
		// (set) Token: 0x060032CF RID: 13007 RVA: 0x000141B0 File Offset: 0x000123B0
		public unsafe Action<float, float> _Mirror_SyncVarHookDelegate_horizonLineContribution
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientSky.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_horizonLineContribution);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientSky.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_horizonLineContribution), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011AE RID: 4526
		// (get) Token: 0x060032D0 RID: 13008 RVA: 0x000E8848 File Offset: 0x000E6A48
		// (set) Token: 0x060032D1 RID: 13009 RVA: 0x000141CF File Offset: 0x000123CF
		public unsafe Action<Color, Color> _Mirror_SyncVarHookDelegate_skyGradientTop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientSky.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_skyGradientTop);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Color, Color>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientSky.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_skyGradientTop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011AF RID: 4527
		// (get) Token: 0x060032D2 RID: 13010 RVA: 0x000E8878 File Offset: 0x000E6A78
		// (set) Token: 0x060032D3 RID: 13011 RVA: 0x000141EE File Offset: 0x000123EE
		public unsafe Action<Color, Color> _Mirror_SyncVarHookDelegate_skyGradientBottom
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientSky.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_skyGradientBottom);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Color, Color>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientSky.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_skyGradientBottom), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011B0 RID: 4528
		// (get) Token: 0x060032D4 RID: 13012 RVA: 0x000E88A8 File Offset: 0x000E6AA8
		// (set) Token: 0x060032D5 RID: 13013 RVA: 0x0001420D File Offset: 0x0001240D
		public unsafe Action<float, float> _Mirror_SyncVarHookDelegate_skyGradientExponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientSky.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_skyGradientExponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GradientSky.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_skyGradientExponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040026B0 RID: 9904
		private static readonly IntPtr NativeFieldInfoPtr_sunDiscColor;

		// Token: 0x040026B1 RID: 9905
		private static readonly IntPtr NativeFieldInfoPtr_sunDiscMultiplier;

		// Token: 0x040026B2 RID: 9906
		private static readonly IntPtr NativeFieldInfoPtr_sunDiscExponent;

		// Token: 0x040026B3 RID: 9907
		private static readonly IntPtr NativeFieldInfoPtr_sunHaloColor;

		// Token: 0x040026B4 RID: 9908
		private static readonly IntPtr NativeFieldInfoPtr_sunHaloExponent;

		// Token: 0x040026B5 RID: 9909
		private static readonly IntPtr NativeFieldInfoPtr_sunHaloContribution;

		// Token: 0x040026B6 RID: 9910
		private static readonly IntPtr NativeFieldInfoPtr_horizonLineColor;

		// Token: 0x040026B7 RID: 9911
		private static readonly IntPtr NativeFieldInfoPtr_horizonLineExponent;

		// Token: 0x040026B8 RID: 9912
		private static readonly IntPtr NativeFieldInfoPtr_horizonLineContribution;

		// Token: 0x040026B9 RID: 9913
		private static readonly IntPtr NativeFieldInfoPtr_skyGradientTop;

		// Token: 0x040026BA RID: 9914
		private static readonly IntPtr NativeFieldInfoPtr_skyGradientBottom;

		// Token: 0x040026BB RID: 9915
		private static readonly IntPtr NativeFieldInfoPtr_skyGradientExponent;

		// Token: 0x040026BC RID: 9916
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_sunDiscColor;

		// Token: 0x040026BD RID: 9917
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_sunDiscMultiplier;

		// Token: 0x040026BE RID: 9918
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_sunDiscExponent;

		// Token: 0x040026BF RID: 9919
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_sunHaloColor;

		// Token: 0x040026C0 RID: 9920
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_sunHaloExponent;

		// Token: 0x040026C1 RID: 9921
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_sunHaloContribution;

		// Token: 0x040026C2 RID: 9922
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_horizonLineColor;

		// Token: 0x040026C3 RID: 9923
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_horizonLineExponent;

		// Token: 0x040026C4 RID: 9924
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_horizonLineContribution;

		// Token: 0x040026C5 RID: 9925
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_skyGradientTop;

		// Token: 0x040026C6 RID: 9926
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_skyGradientBottom;

		// Token: 0x040026C7 RID: 9927
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_skyGradientExponent;

		// Token: 0x040026C8 RID: 9928
		private static readonly IntPtr NativeMethodInfoPtr_get_SunDiscColor_Public_get_Color_0;

		// Token: 0x040026C9 RID: 9929
		private static readonly IntPtr NativeMethodInfoPtr_set_SunDiscColor_Public_set_Void_Color_0;

		// Token: 0x040026CA RID: 9930
		private static readonly IntPtr NativeMethodInfoPtr_get_SunDiscMultiplier_Public_get_Single_0;

		// Token: 0x040026CB RID: 9931
		private static readonly IntPtr NativeMethodInfoPtr_set_SunDiscMultiplier_Public_set_Void_Single_0;

		// Token: 0x040026CC RID: 9932
		private static readonly IntPtr NativeMethodInfoPtr_get_SunDiscExponent_Public_get_Single_0;

		// Token: 0x040026CD RID: 9933
		private static readonly IntPtr NativeMethodInfoPtr_set_SunDiscExponent_Public_set_Void_Single_0;

		// Token: 0x040026CE RID: 9934
		private static readonly IntPtr NativeMethodInfoPtr_get_SunHaloColor_Public_get_Color_0;

		// Token: 0x040026CF RID: 9935
		private static readonly IntPtr NativeMethodInfoPtr_set_SunHaloColor_Public_set_Void_Color_0;

		// Token: 0x040026D0 RID: 9936
		private static readonly IntPtr NativeMethodInfoPtr_get_SunHaloExponent_Public_get_Single_0;

		// Token: 0x040026D1 RID: 9937
		private static readonly IntPtr NativeMethodInfoPtr_set_SunHaloExponent_Public_set_Void_Single_0;

		// Token: 0x040026D2 RID: 9938
		private static readonly IntPtr NativeMethodInfoPtr_get_SunHaloContribution_Public_get_Single_0;

		// Token: 0x040026D3 RID: 9939
		private static readonly IntPtr NativeMethodInfoPtr_set_SunHaloContribution_Public_set_Void_Single_0;

		// Token: 0x040026D4 RID: 9940
		private static readonly IntPtr NativeMethodInfoPtr_get_HorizonLineColor_Public_get_Color_0;

		// Token: 0x040026D5 RID: 9941
		private static readonly IntPtr NativeMethodInfoPtr_set_HorizonLineColor_Public_set_Void_Color_0;

		// Token: 0x040026D6 RID: 9942
		private static readonly IntPtr NativeMethodInfoPtr_get_HorizonLineExponent_Public_get_Single_0;

		// Token: 0x040026D7 RID: 9943
		private static readonly IntPtr NativeMethodInfoPtr_set_HorizonLineExponent_Public_set_Void_Single_0;

		// Token: 0x040026D8 RID: 9944
		private static readonly IntPtr NativeMethodInfoPtr_get_HorizonLineContribution_Public_get_Single_0;

		// Token: 0x040026D9 RID: 9945
		private static readonly IntPtr NativeMethodInfoPtr_set_HorizonLineContribution_Public_set_Void_Single_0;

		// Token: 0x040026DA RID: 9946
		private static readonly IntPtr NativeMethodInfoPtr_get_SkyGradientTop_Public_get_Color_0;

		// Token: 0x040026DB RID: 9947
		private static readonly IntPtr NativeMethodInfoPtr_set_SkyGradientTop_Public_set_Void_Color_0;

		// Token: 0x040026DC RID: 9948
		private static readonly IntPtr NativeMethodInfoPtr_get_SkyGradientBottom_Public_get_Color_0;

		// Token: 0x040026DD RID: 9949
		private static readonly IntPtr NativeMethodInfoPtr_set_SkyGradientBottom_Public_set_Void_Color_0;

		// Token: 0x040026DE RID: 9950
		private static readonly IntPtr NativeMethodInfoPtr_get_SkyGradientExponent_Public_get_Single_0;

		// Token: 0x040026DF RID: 9951
		private static readonly IntPtr NativeMethodInfoPtr_set_SkyGradientExponent_Public_set_Void_Single_0;

		// Token: 0x040026E0 RID: 9952
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworksunDiscColor_Public_get_Color_0;

		// Token: 0x040026E1 RID: 9953
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworksunDiscColor_Public_set_Void_Color_0;

		// Token: 0x040026E2 RID: 9954
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworksunDiscMultiplier_Public_get_Single_0;

		// Token: 0x040026E3 RID: 9955
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworksunDiscMultiplier_Public_set_Void_Single_0;

		// Token: 0x040026E4 RID: 9956
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworksunDiscExponent_Public_get_Single_0;

		// Token: 0x040026E5 RID: 9957
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworksunDiscExponent_Public_set_Void_Single_0;

		// Token: 0x040026E6 RID: 9958
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworksunHaloColor_Public_get_Color_0;

		// Token: 0x040026E7 RID: 9959
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworksunHaloColor_Public_set_Void_Color_0;

		// Token: 0x040026E8 RID: 9960
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworksunHaloExponent_Public_get_Single_0;

		// Token: 0x040026E9 RID: 9961
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworksunHaloExponent_Public_set_Void_Single_0;

		// Token: 0x040026EA RID: 9962
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworksunHaloContribution_Public_get_Single_0;

		// Token: 0x040026EB RID: 9963
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworksunHaloContribution_Public_set_Void_Single_0;

		// Token: 0x040026EC RID: 9964
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkhorizonLineColor_Public_get_Color_0;

		// Token: 0x040026ED RID: 9965
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkhorizonLineColor_Public_set_Void_Color_0;

		// Token: 0x040026EE RID: 9966
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkhorizonLineExponent_Public_get_Single_0;

		// Token: 0x040026EF RID: 9967
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkhorizonLineExponent_Public_set_Void_Single_0;

		// Token: 0x040026F0 RID: 9968
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkhorizonLineContribution_Public_get_Single_0;

		// Token: 0x040026F1 RID: 9969
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkhorizonLineContribution_Public_set_Void_Single_0;

		// Token: 0x040026F2 RID: 9970
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkskyGradientTop_Public_get_Color_0;

		// Token: 0x040026F3 RID: 9971
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkskyGradientTop_Public_set_Void_Color_0;

		// Token: 0x040026F4 RID: 9972
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkskyGradientBottom_Public_get_Color_0;

		// Token: 0x040026F5 RID: 9973
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkskyGradientBottom_Public_set_Void_Color_0;

		// Token: 0x040026F6 RID: 9974
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkskyGradientExponent_Public_get_Single_0;

		// Token: 0x040026F7 RID: 9975
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkskyGradientExponent_Public_set_Void_Single_0;

		// Token: 0x040026F8 RID: 9976
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040026F9 RID: 9977
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040026FA RID: 9978
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040026FB RID: 9979
		private static readonly IntPtr NativeMethodInfoPtr_Apply_Protected_Virtual_Void_0;

		// Token: 0x040026FC RID: 9980
		private static readonly IntPtr NativeMethodInfoPtr_CopyProperties_Protected_Virtual_Void_Instance_0;

		// Token: 0x040026FD RID: 9981
		private static readonly IntPtr NativeMethodInfoPtr_OnSunDiscColorChanged_Private_Void_Color_Color_0;

		// Token: 0x040026FE RID: 9982
		private static readonly IntPtr NativeMethodInfoPtr_OnSunDiscMultiplierChanged_Private_Void_Single_Single_0;

		// Token: 0x040026FF RID: 9983
		private static readonly IntPtr NativeMethodInfoPtr_OnSunDiscExponentChanged_Private_Void_Single_Single_0;

		// Token: 0x04002700 RID: 9984
		private static readonly IntPtr NativeMethodInfoPtr_OnSunHaloColorChanged_Private_Void_Color_Color_0;

		// Token: 0x04002701 RID: 9985
		private static readonly IntPtr NativeMethodInfoPtr_OnSunHaloExponentChanged_Private_Void_Single_Single_0;

		// Token: 0x04002702 RID: 9986
		private static readonly IntPtr NativeMethodInfoPtr_OnSunHaloContributionChanged_Private_Void_Single_Single_0;

		// Token: 0x04002703 RID: 9987
		private static readonly IntPtr NativeMethodInfoPtr_OnHorizonLineColorChanged_Private_Void_Color_Color_0;

		// Token: 0x04002704 RID: 9988
		private static readonly IntPtr NativeMethodInfoPtr_OnHorizonLineExponentChanged_Private_Void_Single_Single_0;

		// Token: 0x04002705 RID: 9989
		private static readonly IntPtr NativeMethodInfoPtr_OnHorizonLineContributionChanged_Private_Void_Single_Single_0;

		// Token: 0x04002706 RID: 9990
		private static readonly IntPtr NativeMethodInfoPtr_OnSkyGradientTopChanged_Private_Void_Color_Color_0;

		// Token: 0x04002707 RID: 9991
		private static readonly IntPtr NativeMethodInfoPtr_OnSkyGradientBottomChanged_Private_Void_Color_Color_0;

		// Token: 0x04002708 RID: 9992
		private static readonly IntPtr NativeMethodInfoPtr_OnSkyGradientExponentChanged_Private_Void_Single_Single_0;

		// Token: 0x04002709 RID: 9993
		private static readonly IntPtr NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0;

		// Token: 0x0400270A RID: 9994
		private static readonly IntPtr NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0;

		// Token: 0x0400270B RID: 9995
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0;
	}
}
