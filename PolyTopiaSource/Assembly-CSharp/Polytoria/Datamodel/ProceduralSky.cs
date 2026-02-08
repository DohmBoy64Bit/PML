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
	// Token: 0x020002A5 RID: 677
	public class ProceduralSky : SkyBase
	{
		// Token: 0x06003994 RID: 14740 RVA: 0x001049EC File Offset: 0x00102BEC
		// Note: this type is marked as 'beforefieldinit'.
		static ProceduralSky()
		{
			Il2CppClassPointerStore<ProceduralSky>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel", "ProceduralSky");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProceduralSky>.NativeClassPtr);
			ProceduralSky.NativeFieldInfoPtr_sunSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralSky>.NativeClassPtr, "sunSize");
			ProceduralSky.NativeFieldInfoPtr_sunSizeConvergence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralSky>.NativeClassPtr, "sunSizeConvergence");
			ProceduralSky.NativeFieldInfoPtr_atmosphereThickness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralSky>.NativeClassPtr, "atmosphereThickness");
			ProceduralSky.NativeFieldInfoPtr_skyTint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralSky>.NativeClassPtr, "skyTint");
			ProceduralSky.NativeFieldInfoPtr_groundColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralSky>.NativeClassPtr, "groundColor");
			ProceduralSky.NativeFieldInfoPtr_exposure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralSky>.NativeClassPtr, "exposure");
			ProceduralSky.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_sunSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralSky>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_sunSize");
			ProceduralSky.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_sunSizeConvergence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralSky>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_sunSizeConvergence");
			ProceduralSky.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_atmosphereThickness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralSky>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_atmosphereThickness");
			ProceduralSky.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_skyTint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralSky>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_skyTint");
			ProceduralSky.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_groundColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralSky>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_groundColor");
			ProceduralSky.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_exposure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralSky>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_exposure");
			ProceduralSky.NativeMethodInfoPtr_get_SunSize_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralSky>.NativeClassPtr, 100672109);
			ProceduralSky.NativeMethodInfoPtr_set_SunSize_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralSky>.NativeClassPtr, 100672110);
			ProceduralSky.NativeMethodInfoPtr_get_SunSizeConvergence_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralSky>.NativeClassPtr, 100672111);
			ProceduralSky.NativeMethodInfoPtr_set_SunSizeConvergence_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralSky>.NativeClassPtr, 100672112);
			ProceduralSky.NativeMethodInfoPtr_get_AtmosphereThickness_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralSky>.NativeClassPtr, 100672113);
			ProceduralSky.NativeMethodInfoPtr_set_AtmosphereThickness_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralSky>.NativeClassPtr, 100672114);
			ProceduralSky.NativeMethodInfoPtr_get_SkyTint_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralSky>.NativeClassPtr, 100672115);
			ProceduralSky.NativeMethodInfoPtr_set_SkyTint_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralSky>.NativeClassPtr, 100672116);
			ProceduralSky.NativeMethodInfoPtr_get_GroundColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralSky>.NativeClassPtr, 100672117);
			ProceduralSky.NativeMethodInfoPtr_set_GroundColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralSky>.NativeClassPtr, 100672118);
			ProceduralSky.NativeMethodInfoPtr_get_Exposure_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralSky>.NativeClassPtr, 100672119);
			ProceduralSky.NativeMethodInfoPtr_set_Exposure_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralSky>.NativeClassPtr, 100672120);
			ProceduralSky.NativeMethodInfoPtr_get_NetworksunSize_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralSky>.NativeClassPtr, 100672133);
			ProceduralSky.NativeMethodInfoPtr_set_NetworksunSize_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralSky>.NativeClassPtr, 100672134);
			ProceduralSky.NativeMethodInfoPtr_get_NetworksunSizeConvergence_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralSky>.NativeClassPtr, 100672135);
			ProceduralSky.NativeMethodInfoPtr_set_NetworksunSizeConvergence_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralSky>.NativeClassPtr, 100672136);
			ProceduralSky.NativeMethodInfoPtr_get_NetworkatmosphereThickness_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralSky>.NativeClassPtr, 100672137);
			ProceduralSky.NativeMethodInfoPtr_set_NetworkatmosphereThickness_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralSky>.NativeClassPtr, 100672138);
			ProceduralSky.NativeMethodInfoPtr_get_NetworkskyTint_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralSky>.NativeClassPtr, 100672139);
			ProceduralSky.NativeMethodInfoPtr_set_NetworkskyTint_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralSky>.NativeClassPtr, 100672140);
			ProceduralSky.NativeMethodInfoPtr_get_NetworkgroundColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralSky>.NativeClassPtr, 100672141);
			ProceduralSky.NativeMethodInfoPtr_set_NetworkgroundColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralSky>.NativeClassPtr, 100672142);
			ProceduralSky.NativeMethodInfoPtr_get_Networkexposure_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralSky>.NativeClassPtr, 100672143);
			ProceduralSky.NativeMethodInfoPtr_set_Networkexposure_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralSky>.NativeClassPtr, 100672144);
			ProceduralSky.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralSky>.NativeClassPtr, 100672131);
			ProceduralSky.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralSky>.NativeClassPtr, 100672121);
			ProceduralSky.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralSky>.NativeClassPtr, 100672122);
			ProceduralSky.NativeMethodInfoPtr_Apply_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralSky>.NativeClassPtr, 100672123);
			ProceduralSky.NativeMethodInfoPtr_CopyProperties_Protected_Virtual_Void_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralSky>.NativeClassPtr, 100672124);
			ProceduralSky.NativeMethodInfoPtr_OnSunSizeChanged_Private_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralSky>.NativeClassPtr, 100672125);
			ProceduralSky.NativeMethodInfoPtr_OnSunSizeConvergenceChanged_Private_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralSky>.NativeClassPtr, 100672126);
			ProceduralSky.NativeMethodInfoPtr_OnAtmosphereThicknessChanged_Private_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralSky>.NativeClassPtr, 100672127);
			ProceduralSky.NativeMethodInfoPtr_OnSkyTintChanged_Private_Void_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralSky>.NativeClassPtr, 100672128);
			ProceduralSky.NativeMethodInfoPtr_OnGroundColorChanged_Private_Void_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralSky>.NativeClassPtr, 100672129);
			ProceduralSky.NativeMethodInfoPtr_OnExposureChanged_Private_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralSky>.NativeClassPtr, 100672130);
			ProceduralSky.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralSky>.NativeClassPtr, 100672132);
			ProceduralSky.NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralSky>.NativeClassPtr, 100672145);
			ProceduralSky.NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralSky>.NativeClassPtr, 100672146);
		}

		// Token: 0x17001402 RID: 5122
		// (get) Token: 0x06003995 RID: 14741 RVA: 0x00104E04 File Offset: 0x00103004
		// (set) Token: 0x06003996 RID: 14742 RVA: 0x00104E40 File Offset: 0x00103040
		public unsafe float SunSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralSky.NativeMethodInfoPtr_get_SunSize_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 117059, RefRangeEnd = 117062, XrefRangeStart = 117052, XrefRangeEnd = 117059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralSky.NativeMethodInfoPtr_set_SunSize_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001403 RID: 5123
		// (get) Token: 0x06003997 RID: 14743 RVA: 0x00104E80 File Offset: 0x00103080
		// (set) Token: 0x06003998 RID: 14744 RVA: 0x00104EBC File Offset: 0x001030BC
		public unsafe float SunSizeConvergence
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralSky.NativeMethodInfoPtr_get_SunSizeConvergence_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 117069, RefRangeEnd = 117072, XrefRangeStart = 117062, XrefRangeEnd = 117069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralSky.NativeMethodInfoPtr_set_SunSizeConvergence_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001404 RID: 5124
		// (get) Token: 0x06003999 RID: 14745 RVA: 0x00104EFC File Offset: 0x001030FC
		// (set) Token: 0x0600399A RID: 14746 RVA: 0x00104F38 File Offset: 0x00103138
		public unsafe float AtmosphereThickness
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralSky.NativeMethodInfoPtr_get_AtmosphereThickness_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 117079, RefRangeEnd = 117082, XrefRangeStart = 117072, XrefRangeEnd = 117079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralSky.NativeMethodInfoPtr_set_AtmosphereThickness_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001405 RID: 5125
		// (get) Token: 0x0600399B RID: 14747 RVA: 0x00104F78 File Offset: 0x00103178
		// (set) Token: 0x0600399C RID: 14748 RVA: 0x00104FB8 File Offset: 0x001031B8
		public unsafe Color SkyTint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralSky.NativeMethodInfoPtr_get_SkyTint_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 117088, RefRangeEnd = 117091, XrefRangeStart = 117082, XrefRangeEnd = 117088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralSky.NativeMethodInfoPtr_set_SkyTint_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001406 RID: 5126
		// (get) Token: 0x0600399D RID: 14749 RVA: 0x00104FFC File Offset: 0x001031FC
		// (set) Token: 0x0600399E RID: 14750 RVA: 0x0010503C File Offset: 0x0010323C
		public unsafe Color GroundColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralSky.NativeMethodInfoPtr_get_GroundColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 117097, RefRangeEnd = 117100, XrefRangeStart = 117091, XrefRangeEnd = 117097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralSky.NativeMethodInfoPtr_set_GroundColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001407 RID: 5127
		// (get) Token: 0x0600399F RID: 14751 RVA: 0x00105080 File Offset: 0x00103280
		// (set) Token: 0x060039A0 RID: 14752 RVA: 0x001050BC File Offset: 0x001032BC
		public unsafe float Exposure
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralSky.NativeMethodInfoPtr_get_Exposure_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 117107, RefRangeEnd = 117110, XrefRangeStart = 117100, XrefRangeEnd = 117107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralSky.NativeMethodInfoPtr_set_Exposure_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001408 RID: 5128
		// (get) Token: 0x060039A1 RID: 14753 RVA: 0x001050FC File Offset: 0x001032FC
		// (set) Token: 0x060039A2 RID: 14754 RVA: 0x00105138 File Offset: 0x00103338
		public unsafe float NetworksunSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralSky.NativeMethodInfoPtr_get_NetworksunSize_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117110, XrefRangeEnd = 117113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralSky.NativeMethodInfoPtr_set_NetworksunSize_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001409 RID: 5129
		// (get) Token: 0x060039A3 RID: 14755 RVA: 0x00105178 File Offset: 0x00103378
		// (set) Token: 0x060039A4 RID: 14756 RVA: 0x001051B4 File Offset: 0x001033B4
		public unsafe float NetworksunSizeConvergence
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralSky.NativeMethodInfoPtr_get_NetworksunSizeConvergence_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117113, XrefRangeEnd = 117116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralSky.NativeMethodInfoPtr_set_NetworksunSizeConvergence_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700140A RID: 5130
		// (get) Token: 0x060039A5 RID: 14757 RVA: 0x001051F4 File Offset: 0x001033F4
		// (set) Token: 0x060039A6 RID: 14758 RVA: 0x00105230 File Offset: 0x00103430
		public unsafe float NetworkatmosphereThickness
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralSky.NativeMethodInfoPtr_get_NetworkatmosphereThickness_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117116, XrefRangeEnd = 117119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralSky.NativeMethodInfoPtr_set_NetworkatmosphereThickness_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700140B RID: 5131
		// (get) Token: 0x060039A7 RID: 14759 RVA: 0x00105270 File Offset: 0x00103470
		// (set) Token: 0x060039A8 RID: 14760 RVA: 0x001052B0 File Offset: 0x001034B0
		public unsafe Color NetworkskyTint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralSky.NativeMethodInfoPtr_get_NetworkskyTint_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117119, XrefRangeEnd = 117122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralSky.NativeMethodInfoPtr_set_NetworkskyTint_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700140C RID: 5132
		// (get) Token: 0x060039A9 RID: 14761 RVA: 0x001052F4 File Offset: 0x001034F4
		// (set) Token: 0x060039AA RID: 14762 RVA: 0x00105334 File Offset: 0x00103534
		public unsafe Color NetworkgroundColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralSky.NativeMethodInfoPtr_get_NetworkgroundColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117122, XrefRangeEnd = 117125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralSky.NativeMethodInfoPtr_set_NetworkgroundColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700140D RID: 5133
		// (get) Token: 0x060039AB RID: 14763 RVA: 0x00105378 File Offset: 0x00103578
		// (set) Token: 0x060039AC RID: 14764 RVA: 0x001053B4 File Offset: 0x001035B4
		public unsafe float Networkexposure
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralSky.NativeMethodInfoPtr_get_Networkexposure_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117125, XrefRangeEnd = 117128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralSky.NativeMethodInfoPtr_set_Networkexposure_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060039AD RID: 14765 RVA: 0x001053F4 File Offset: 0x001035F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117128, XrefRangeEnd = 117170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProceduralSky()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProceduralSky>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralSky.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039AE RID: 14766 RVA: 0x00105430 File Offset: 0x00103630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117170, XrefRangeEnd = 117186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProceduralSky.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039AF RID: 14767 RVA: 0x0010546C File Offset: 0x0010366C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 117187, RefRangeEnd = 117189, XrefRangeStart = 117186, XrefRangeEnd = 117187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProceduralSky.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039B0 RID: 14768 RVA: 0x001054A8 File Offset: 0x001036A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117189, XrefRangeEnd = 117215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Apply()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProceduralSky.NativeMethodInfoPtr_Apply_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039B1 RID: 14769 RVA: 0x001054E4 File Offset: 0x001036E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117215, XrefRangeEnd = 117226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CopyProperties(Instance clone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clone);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProceduralSky.NativeMethodInfoPtr_CopyProperties_Protected_Virtual_Void_Instance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060039B2 RID: 14770 RVA: 0x00105534 File Offset: 0x00103734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117226, XrefRangeEnd = 117228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSunSizeChanged(float oldValue, float newValue)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralSky.NativeMethodInfoPtr_OnSunSizeChanged_Private_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039B3 RID: 14771 RVA: 0x00105580 File Offset: 0x00103780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117228, XrefRangeEnd = 117230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSunSizeConvergenceChanged(float oldValue, float newValue)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralSky.NativeMethodInfoPtr_OnSunSizeConvergenceChanged_Private_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039B4 RID: 14772 RVA: 0x001055CC File Offset: 0x001037CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117230, XrefRangeEnd = 117232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnAtmosphereThicknessChanged(float oldValue, float newValue)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralSky.NativeMethodInfoPtr_OnAtmosphereThicknessChanged_Private_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039B5 RID: 14773 RVA: 0x00105618 File Offset: 0x00103818
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117232, XrefRangeEnd = 117234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSkyTintChanged(Color oldValue, Color newValue)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralSky.NativeMethodInfoPtr_OnSkyTintChanged_Private_Void_Color_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039B6 RID: 14774 RVA: 0x0010566C File Offset: 0x0010386C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117234, XrefRangeEnd = 117236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGroundColorChanged(Color oldValue, Color newValue)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralSky.NativeMethodInfoPtr_OnGroundColorChanged_Private_Void_Color_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039B7 RID: 14775 RVA: 0x001056C0 File Offset: 0x001038C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117236, XrefRangeEnd = 117238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnExposureChanged(float oldValue, float newValue)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralSky.NativeMethodInfoPtr_OnExposureChanged_Private_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039B8 RID: 14776 RVA: 0x0010570C File Offset: 0x0010390C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 20124, RefRangeEnd = 20136, XrefRangeStart = 20124, XrefRangeEnd = 20136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Weaved()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProceduralSky.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060039B9 RID: 14777 RVA: 0x00105754 File Offset: 0x00103954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117238, XrefRangeEnd = 117252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProceduralSky.NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039BA RID: 14778 RVA: 0x001057B0 File Offset: 0x001039B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117252, XrefRangeEnd = 117290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProceduralSky.NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060039BB RID: 14779 RVA: 0x0001657D File Offset: 0x0001477D
		public ProceduralSky(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170013F6 RID: 5110
		// (get) Token: 0x060039BC RID: 14780 RVA: 0x0010580C File Offset: 0x00103A0C
		// (set) Token: 0x060039BD RID: 14781 RVA: 0x00016586 File Offset: 0x00014786
		public unsafe float sunSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralSky.NativeFieldInfoPtr_sunSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralSky.NativeFieldInfoPtr_sunSize)) = value;
			}
		}

		// Token: 0x170013F7 RID: 5111
		// (get) Token: 0x060039BE RID: 14782 RVA: 0x00105834 File Offset: 0x00103A34
		// (set) Token: 0x060039BF RID: 14783 RVA: 0x000165A1 File Offset: 0x000147A1
		public unsafe float sunSizeConvergence
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralSky.NativeFieldInfoPtr_sunSizeConvergence);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralSky.NativeFieldInfoPtr_sunSizeConvergence)) = value;
			}
		}

		// Token: 0x170013F8 RID: 5112
		// (get) Token: 0x060039C0 RID: 14784 RVA: 0x0010585C File Offset: 0x00103A5C
		// (set) Token: 0x060039C1 RID: 14785 RVA: 0x000165BC File Offset: 0x000147BC
		public unsafe float atmosphereThickness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralSky.NativeFieldInfoPtr_atmosphereThickness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralSky.NativeFieldInfoPtr_atmosphereThickness)) = value;
			}
		}

		// Token: 0x170013F9 RID: 5113
		// (get) Token: 0x060039C2 RID: 14786 RVA: 0x00105884 File Offset: 0x00103A84
		// (set) Token: 0x060039C3 RID: 14787 RVA: 0x000165D7 File Offset: 0x000147D7
		public unsafe Color skyTint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralSky.NativeFieldInfoPtr_skyTint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralSky.NativeFieldInfoPtr_skyTint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013FA RID: 5114
		// (get) Token: 0x060039C4 RID: 14788 RVA: 0x001058B4 File Offset: 0x00103AB4
		// (set) Token: 0x060039C5 RID: 14789 RVA: 0x000165F6 File Offset: 0x000147F6
		public unsafe Color groundColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralSky.NativeFieldInfoPtr_groundColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralSky.NativeFieldInfoPtr_groundColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013FB RID: 5115
		// (get) Token: 0x060039C6 RID: 14790 RVA: 0x001058E4 File Offset: 0x00103AE4
		// (set) Token: 0x060039C7 RID: 14791 RVA: 0x00016615 File Offset: 0x00014815
		public unsafe float exposure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralSky.NativeFieldInfoPtr_exposure);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralSky.NativeFieldInfoPtr_exposure)) = value;
			}
		}

		// Token: 0x170013FC RID: 5116
		// (get) Token: 0x060039C8 RID: 14792 RVA: 0x0010590C File Offset: 0x00103B0C
		// (set) Token: 0x060039C9 RID: 14793 RVA: 0x00016630 File Offset: 0x00014830
		public unsafe Action<float, float> _Mirror_SyncVarHookDelegate_sunSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralSky.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_sunSize);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralSky.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_sunSize), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013FD RID: 5117
		// (get) Token: 0x060039CA RID: 14794 RVA: 0x0010593C File Offset: 0x00103B3C
		// (set) Token: 0x060039CB RID: 14795 RVA: 0x0001664F File Offset: 0x0001484F
		public unsafe Action<float, float> _Mirror_SyncVarHookDelegate_sunSizeConvergence
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralSky.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_sunSizeConvergence);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralSky.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_sunSizeConvergence), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013FE RID: 5118
		// (get) Token: 0x060039CC RID: 14796 RVA: 0x0010596C File Offset: 0x00103B6C
		// (set) Token: 0x060039CD RID: 14797 RVA: 0x0001666E File Offset: 0x0001486E
		public unsafe Action<float, float> _Mirror_SyncVarHookDelegate_atmosphereThickness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralSky.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_atmosphereThickness);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralSky.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_atmosphereThickness), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013FF RID: 5119
		// (get) Token: 0x060039CE RID: 14798 RVA: 0x0010599C File Offset: 0x00103B9C
		// (set) Token: 0x060039CF RID: 14799 RVA: 0x0001668D File Offset: 0x0001488D
		public unsafe Action<Color, Color> _Mirror_SyncVarHookDelegate_skyTint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralSky.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_skyTint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Color, Color>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralSky.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_skyTint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001400 RID: 5120
		// (get) Token: 0x060039D0 RID: 14800 RVA: 0x001059CC File Offset: 0x00103BCC
		// (set) Token: 0x060039D1 RID: 14801 RVA: 0x000166AC File Offset: 0x000148AC
		public unsafe Action<Color, Color> _Mirror_SyncVarHookDelegate_groundColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralSky.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_groundColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Color, Color>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralSky.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_groundColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001401 RID: 5121
		// (get) Token: 0x060039D2 RID: 14802 RVA: 0x001059FC File Offset: 0x00103BFC
		// (set) Token: 0x060039D3 RID: 14803 RVA: 0x000166CB File Offset: 0x000148CB
		public unsafe Action<float, float> _Mirror_SyncVarHookDelegate_exposure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralSky.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_exposure);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralSky.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_exposure), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002CA9 RID: 11433
		private static readonly IntPtr NativeFieldInfoPtr_sunSize;

		// Token: 0x04002CAA RID: 11434
		private static readonly IntPtr NativeFieldInfoPtr_sunSizeConvergence;

		// Token: 0x04002CAB RID: 11435
		private static readonly IntPtr NativeFieldInfoPtr_atmosphereThickness;

		// Token: 0x04002CAC RID: 11436
		private static readonly IntPtr NativeFieldInfoPtr_skyTint;

		// Token: 0x04002CAD RID: 11437
		private static readonly IntPtr NativeFieldInfoPtr_groundColor;

		// Token: 0x04002CAE RID: 11438
		private static readonly IntPtr NativeFieldInfoPtr_exposure;

		// Token: 0x04002CAF RID: 11439
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_sunSize;

		// Token: 0x04002CB0 RID: 11440
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_sunSizeConvergence;

		// Token: 0x04002CB1 RID: 11441
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_atmosphereThickness;

		// Token: 0x04002CB2 RID: 11442
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_skyTint;

		// Token: 0x04002CB3 RID: 11443
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_groundColor;

		// Token: 0x04002CB4 RID: 11444
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_exposure;

		// Token: 0x04002CB5 RID: 11445
		private static readonly IntPtr NativeMethodInfoPtr_get_SunSize_Public_get_Single_0;

		// Token: 0x04002CB6 RID: 11446
		private static readonly IntPtr NativeMethodInfoPtr_set_SunSize_Public_set_Void_Single_0;

		// Token: 0x04002CB7 RID: 11447
		private static readonly IntPtr NativeMethodInfoPtr_get_SunSizeConvergence_Public_get_Single_0;

		// Token: 0x04002CB8 RID: 11448
		private static readonly IntPtr NativeMethodInfoPtr_set_SunSizeConvergence_Public_set_Void_Single_0;

		// Token: 0x04002CB9 RID: 11449
		private static readonly IntPtr NativeMethodInfoPtr_get_AtmosphereThickness_Public_get_Single_0;

		// Token: 0x04002CBA RID: 11450
		private static readonly IntPtr NativeMethodInfoPtr_set_AtmosphereThickness_Public_set_Void_Single_0;

		// Token: 0x04002CBB RID: 11451
		private static readonly IntPtr NativeMethodInfoPtr_get_SkyTint_Public_get_Color_0;

		// Token: 0x04002CBC RID: 11452
		private static readonly IntPtr NativeMethodInfoPtr_set_SkyTint_Public_set_Void_Color_0;

		// Token: 0x04002CBD RID: 11453
		private static readonly IntPtr NativeMethodInfoPtr_get_GroundColor_Public_get_Color_0;

		// Token: 0x04002CBE RID: 11454
		private static readonly IntPtr NativeMethodInfoPtr_set_GroundColor_Public_set_Void_Color_0;

		// Token: 0x04002CBF RID: 11455
		private static readonly IntPtr NativeMethodInfoPtr_get_Exposure_Public_get_Single_0;

		// Token: 0x04002CC0 RID: 11456
		private static readonly IntPtr NativeMethodInfoPtr_set_Exposure_Public_set_Void_Single_0;

		// Token: 0x04002CC1 RID: 11457
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworksunSize_Public_get_Single_0;

		// Token: 0x04002CC2 RID: 11458
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworksunSize_Public_set_Void_Single_0;

		// Token: 0x04002CC3 RID: 11459
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworksunSizeConvergence_Public_get_Single_0;

		// Token: 0x04002CC4 RID: 11460
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworksunSizeConvergence_Public_set_Void_Single_0;

		// Token: 0x04002CC5 RID: 11461
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkatmosphereThickness_Public_get_Single_0;

		// Token: 0x04002CC6 RID: 11462
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkatmosphereThickness_Public_set_Void_Single_0;

		// Token: 0x04002CC7 RID: 11463
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkskyTint_Public_get_Color_0;

		// Token: 0x04002CC8 RID: 11464
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkskyTint_Public_set_Void_Color_0;

		// Token: 0x04002CC9 RID: 11465
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkgroundColor_Public_get_Color_0;

		// Token: 0x04002CCA RID: 11466
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkgroundColor_Public_set_Void_Color_0;

		// Token: 0x04002CCB RID: 11467
		private static readonly IntPtr NativeMethodInfoPtr_get_Networkexposure_Public_get_Single_0;

		// Token: 0x04002CCC RID: 11468
		private static readonly IntPtr NativeMethodInfoPtr_set_Networkexposure_Public_set_Void_Single_0;

		// Token: 0x04002CCD RID: 11469
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002CCE RID: 11470
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04002CCF RID: 11471
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04002CD0 RID: 11472
		private static readonly IntPtr NativeMethodInfoPtr_Apply_Protected_Virtual_Void_0;

		// Token: 0x04002CD1 RID: 11473
		private static readonly IntPtr NativeMethodInfoPtr_CopyProperties_Protected_Virtual_Void_Instance_0;

		// Token: 0x04002CD2 RID: 11474
		private static readonly IntPtr NativeMethodInfoPtr_OnSunSizeChanged_Private_Void_Single_Single_0;

		// Token: 0x04002CD3 RID: 11475
		private static readonly IntPtr NativeMethodInfoPtr_OnSunSizeConvergenceChanged_Private_Void_Single_Single_0;

		// Token: 0x04002CD4 RID: 11476
		private static readonly IntPtr NativeMethodInfoPtr_OnAtmosphereThicknessChanged_Private_Void_Single_Single_0;

		// Token: 0x04002CD5 RID: 11477
		private static readonly IntPtr NativeMethodInfoPtr_OnSkyTintChanged_Private_Void_Color_Color_0;

		// Token: 0x04002CD6 RID: 11478
		private static readonly IntPtr NativeMethodInfoPtr_OnGroundColorChanged_Private_Void_Color_Color_0;

		// Token: 0x04002CD7 RID: 11479
		private static readonly IntPtr NativeMethodInfoPtr_OnExposureChanged_Private_Void_Single_Single_0;

		// Token: 0x04002CD8 RID: 11480
		private static readonly IntPtr NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0;

		// Token: 0x04002CD9 RID: 11481
		private static readonly IntPtr NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0;

		// Token: 0x04002CDA RID: 11482
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0;
	}
}
