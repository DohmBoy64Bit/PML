using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Polytoria.Controllers;
using Polytoria.Types;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	// Token: 0x020002E9 RID: 745
	public class ParticlesProxy : DynamicInstanceProxy
	{
		// Token: 0x06004117 RID: 16663 RVA: 0x00124310 File Offset: 0x00122510
		// Note: this type is marked as 'beforefieldinit'.
		static ParticlesProxy()
		{
			Il2CppClassPointerStore<ParticlesProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel.Proxies", "ParticlesProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticlesProxy>.NativeClassPtr);
			ParticlesProxy.NativeFieldInfoPtr_particles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticlesProxy>.NativeClassPtr, "particles");
			ParticlesProxy.NativeMethodInfoPtr_get_ImageID_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticlesProxy>.NativeClassPtr, 100673512);
			ParticlesProxy.NativeMethodInfoPtr_set_ImageID_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticlesProxy>.NativeClassPtr, 100673513);
			ParticlesProxy.NativeMethodInfoPtr_get_ImageType_Public_get_ImageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticlesProxy>.NativeClassPtr, 100673514);
			ParticlesProxy.NativeMethodInfoPtr_set_ImageType_Public_set_Void_ImageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticlesProxy>.NativeClassPtr, 100673515);
			ParticlesProxy.NativeMethodInfoPtr_get_Color_Public_get_ColorRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticlesProxy>.NativeClassPtr, 100673516);
			ParticlesProxy.NativeMethodInfoPtr_set_Color_Public_set_Void_ColorRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticlesProxy>.NativeClassPtr, 100673517);
			ParticlesProxy.NativeMethodInfoPtr_get_ColorMode_Public_get_ParticleColorMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticlesProxy>.NativeClassPtr, 100673518);
			ParticlesProxy.NativeMethodInfoPtr_set_ColorMode_Public_set_Void_ParticleColorMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticlesProxy>.NativeClassPtr, 100673519);
			ParticlesProxy.NativeMethodInfoPtr_get_Lifetime_Public_get_NumberRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticlesProxy>.NativeClassPtr, 100673520);
			ParticlesProxy.NativeMethodInfoPtr_set_Lifetime_Public_set_Void_NumberRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticlesProxy>.NativeClassPtr, 100673521);
			ParticlesProxy.NativeMethodInfoPtr_get_SizeOverLifetime_Public_get_NumberRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticlesProxy>.NativeClassPtr, 100673522);
			ParticlesProxy.NativeMethodInfoPtr_set_SizeOverLifetime_Public_set_Void_NumberRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticlesProxy>.NativeClassPtr, 100673523);
			ParticlesProxy.NativeMethodInfoPtr_get_Speed_Public_get_NumberRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticlesProxy>.NativeClassPtr, 100673524);
			ParticlesProxy.NativeMethodInfoPtr_set_Speed_Public_set_Void_NumberRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticlesProxy>.NativeClassPtr, 100673525);
			ParticlesProxy.NativeMethodInfoPtr_get_EmissionRate_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticlesProxy>.NativeClassPtr, 100673526);
			ParticlesProxy.NativeMethodInfoPtr_set_EmissionRate_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticlesProxy>.NativeClassPtr, 100673527);
			ParticlesProxy.NativeMethodInfoPtr_get_MaxParticles_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticlesProxy>.NativeClassPtr, 100673528);
			ParticlesProxy.NativeMethodInfoPtr_set_MaxParticles_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticlesProxy>.NativeClassPtr, 100673529);
			ParticlesProxy.NativeMethodInfoPtr_get_Gravity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticlesProxy>.NativeClassPtr, 100673530);
			ParticlesProxy.NativeMethodInfoPtr_set_Gravity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticlesProxy>.NativeClassPtr, 100673531);
			ParticlesProxy.NativeMethodInfoPtr_get_SimulationSpace_Public_get_ParticleSimulationSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticlesProxy>.NativeClassPtr, 100673532);
			ParticlesProxy.NativeMethodInfoPtr_set_SimulationSpace_Public_set_Void_ParticleSimulationSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticlesProxy>.NativeClassPtr, 100673533);
			ParticlesProxy.NativeMethodInfoPtr_get_StartRotation_Public_get_NumberRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticlesProxy>.NativeClassPtr, 100673534);
			ParticlesProxy.NativeMethodInfoPtr_set_StartRotation_Public_set_Void_NumberRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticlesProxy>.NativeClassPtr, 100673535);
			ParticlesProxy.NativeMethodInfoPtr_get_AngularVelocity_Public_get_NumberRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticlesProxy>.NativeClassPtr, 100673536);
			ParticlesProxy.NativeMethodInfoPtr_set_AngularVelocity_Public_set_Void_NumberRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticlesProxy>.NativeClassPtr, 100673537);
			ParticlesProxy.NativeMethodInfoPtr_get_Autoplay_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticlesProxy>.NativeClassPtr, 100673538);
			ParticlesProxy.NativeMethodInfoPtr_set_Autoplay_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticlesProxy>.NativeClassPtr, 100673539);
			ParticlesProxy.NativeMethodInfoPtr_get_Loop_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticlesProxy>.NativeClassPtr, 100673540);
			ParticlesProxy.NativeMethodInfoPtr_set_Loop_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticlesProxy>.NativeClassPtr, 100673541);
			ParticlesProxy.NativeMethodInfoPtr_get_Duration_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticlesProxy>.NativeClassPtr, 100673542);
			ParticlesProxy.NativeMethodInfoPtr_set_Duration_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticlesProxy>.NativeClassPtr, 100673543);
			ParticlesProxy.NativeMethodInfoPtr_get_Shape_Public_get_ParticleShape_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticlesProxy>.NativeClassPtr, 100673544);
			ParticlesProxy.NativeMethodInfoPtr_set_Shape_Public_set_Void_ParticleShape_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticlesProxy>.NativeClassPtr, 100673545);
			ParticlesProxy.NativeMethodInfoPtr_get_ShapeRadius_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticlesProxy>.NativeClassPtr, 100673546);
			ParticlesProxy.NativeMethodInfoPtr_set_ShapeRadius_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticlesProxy>.NativeClassPtr, 100673547);
			ParticlesProxy.NativeMethodInfoPtr_get_ShapeAngle_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticlesProxy>.NativeClassPtr, 100673548);
			ParticlesProxy.NativeMethodInfoPtr_set_ShapeAngle_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticlesProxy>.NativeClassPtr, 100673549);
			ParticlesProxy.NativeMethodInfoPtr_get_ShapeScale_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticlesProxy>.NativeClassPtr, 100673550);
			ParticlesProxy.NativeMethodInfoPtr_set_ShapeScale_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticlesProxy>.NativeClassPtr, 100673551);
			ParticlesProxy.NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticlesProxy>.NativeClassPtr, 100673552);
			ParticlesProxy.NativeMethodInfoPtr_get_IsPaused_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticlesProxy>.NativeClassPtr, 100673553);
			ParticlesProxy.NativeMethodInfoPtr_get_IsStopped_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticlesProxy>.NativeClassPtr, 100673554);
			ParticlesProxy.NativeMethodInfoPtr_get_ParticleCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticlesProxy>.NativeClassPtr, 100673555);
			ParticlesProxy.NativeMethodInfoPtr_get_Time_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticlesProxy>.NativeClassPtr, 100673556);
			ParticlesProxy.NativeMethodInfoPtr_get_TotalTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticlesProxy>.NativeClassPtr, 100673557);
			ParticlesProxy.NativeMethodInfoPtr__ctor_Public_Void_Particles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticlesProxy>.NativeClassPtr, 100673511);
			ParticlesProxy.NativeMethodInfoPtr_Play_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticlesProxy>.NativeClassPtr, 100673558);
			ParticlesProxy.NativeMethodInfoPtr_Pause_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticlesProxy>.NativeClassPtr, 100673559);
			ParticlesProxy.NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticlesProxy>.NativeClassPtr, 100673560);
			ParticlesProxy.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticlesProxy>.NativeClassPtr, 100673561);
			ParticlesProxy.NativeMethodInfoPtr_Emit_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticlesProxy>.NativeClassPtr, 100673562);
			ParticlesProxy.NativeMethodInfoPtr_Simulate_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticlesProxy>.NativeClassPtr, 100673563);
		}

		// Token: 0x17001664 RID: 5732
		// (get) Token: 0x06004118 RID: 16664 RVA: 0x00124778 File Offset: 0x00122978
		// (set) Token: 0x06004119 RID: 16665 RVA: 0x001247B0 File Offset: 0x001229B0
		public unsafe string ImageID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticlesProxy.NativeMethodInfoPtr_get_ImageID_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128725, XrefRangeEnd = 128727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticlesProxy.NativeMethodInfoPtr_set_ImageID_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001665 RID: 5733
		// (get) Token: 0x0600411A RID: 16666 RVA: 0x001247F4 File Offset: 0x001229F4
		// (set) Token: 0x0600411B RID: 16667 RVA: 0x00124834 File Offset: 0x00122A34
		public unsafe ImageType ImageType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticlesProxy.NativeMethodInfoPtr_get_ImageType_Public_get_ImageType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ImageType>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128727, XrefRangeEnd = 128729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticlesProxy.NativeMethodInfoPtr_set_ImageType_Public_set_Void_ImageType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001666 RID: 5734
		// (get) Token: 0x0600411C RID: 16668 RVA: 0x00124878 File Offset: 0x00122A78
		// (set) Token: 0x0600411D RID: 16669 RVA: 0x001248B8 File Offset: 0x00122AB8
		public unsafe ColorRange Color
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticlesProxy.NativeMethodInfoPtr_get_Color_Public_get_ColorRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ColorRange>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128729, XrefRangeEnd = 128730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticlesProxy.NativeMethodInfoPtr_set_Color_Public_set_Void_ColorRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001667 RID: 5735
		// (get) Token: 0x0600411E RID: 16670 RVA: 0x001248FC File Offset: 0x00122AFC
		// (set) Token: 0x0600411F RID: 16671 RVA: 0x0012493C File Offset: 0x00122B3C
		public unsafe ParticleColorMode ColorMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticlesProxy.NativeMethodInfoPtr_get_ColorMode_Public_get_ParticleColorMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ParticleColorMode>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128730, XrefRangeEnd = 128732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticlesProxy.NativeMethodInfoPtr_set_ColorMode_Public_set_Void_ParticleColorMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001668 RID: 5736
		// (get) Token: 0x06004120 RID: 16672 RVA: 0x00124980 File Offset: 0x00122B80
		// (set) Token: 0x06004121 RID: 16673 RVA: 0x001249C0 File Offset: 0x00122BC0
		public unsafe NumberRange Lifetime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticlesProxy.NativeMethodInfoPtr_get_Lifetime_Public_get_NumberRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NumberRange>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128732, XrefRangeEnd = 128734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticlesProxy.NativeMethodInfoPtr_set_Lifetime_Public_set_Void_NumberRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001669 RID: 5737
		// (get) Token: 0x06004122 RID: 16674 RVA: 0x00124A04 File Offset: 0x00122C04
		// (set) Token: 0x06004123 RID: 16675 RVA: 0x00124A44 File Offset: 0x00122C44
		public unsafe NumberRange SizeOverLifetime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticlesProxy.NativeMethodInfoPtr_get_SizeOverLifetime_Public_get_NumberRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NumberRange>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128734, XrefRangeEnd = 128736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticlesProxy.NativeMethodInfoPtr_set_SizeOverLifetime_Public_set_Void_NumberRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700166A RID: 5738
		// (get) Token: 0x06004124 RID: 16676 RVA: 0x00124A88 File Offset: 0x00122C88
		// (set) Token: 0x06004125 RID: 16677 RVA: 0x00124AC8 File Offset: 0x00122CC8
		public unsafe NumberRange Speed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticlesProxy.NativeMethodInfoPtr_get_Speed_Public_get_NumberRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NumberRange>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128736, XrefRangeEnd = 128738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticlesProxy.NativeMethodInfoPtr_set_Speed_Public_set_Void_NumberRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700166B RID: 5739
		// (get) Token: 0x06004126 RID: 16678 RVA: 0x00124B0C File Offset: 0x00122D0C
		// (set) Token: 0x06004127 RID: 16679 RVA: 0x00124B48 File Offset: 0x00122D48
		public unsafe int EmissionRate
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticlesProxy.NativeMethodInfoPtr_get_EmissionRate_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128738, XrefRangeEnd = 128740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticlesProxy.NativeMethodInfoPtr_set_EmissionRate_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700166C RID: 5740
		// (get) Token: 0x06004128 RID: 16680 RVA: 0x00124B88 File Offset: 0x00122D88
		// (set) Token: 0x06004129 RID: 16681 RVA: 0x00124BC4 File Offset: 0x00122DC4
		public unsafe int MaxParticles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticlesProxy.NativeMethodInfoPtr_get_MaxParticles_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128740, XrefRangeEnd = 128742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticlesProxy.NativeMethodInfoPtr_set_MaxParticles_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700166D RID: 5741
		// (get) Token: 0x0600412A RID: 16682 RVA: 0x00124C04 File Offset: 0x00122E04
		// (set) Token: 0x0600412B RID: 16683 RVA: 0x00124C40 File Offset: 0x00122E40
		public unsafe float Gravity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticlesProxy.NativeMethodInfoPtr_get_Gravity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128742, XrefRangeEnd = 128744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticlesProxy.NativeMethodInfoPtr_set_Gravity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700166E RID: 5742
		// (get) Token: 0x0600412C RID: 16684 RVA: 0x00124C80 File Offset: 0x00122E80
		// (set) Token: 0x0600412D RID: 16685 RVA: 0x00124CC0 File Offset: 0x00122EC0
		public unsafe ParticleSimulationSpace SimulationSpace
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticlesProxy.NativeMethodInfoPtr_get_SimulationSpace_Public_get_ParticleSimulationSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ParticleSimulationSpace>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128744, XrefRangeEnd = 128746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticlesProxy.NativeMethodInfoPtr_set_SimulationSpace_Public_set_Void_ParticleSimulationSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700166F RID: 5743
		// (get) Token: 0x0600412E RID: 16686 RVA: 0x00124D04 File Offset: 0x00122F04
		// (set) Token: 0x0600412F RID: 16687 RVA: 0x00124D44 File Offset: 0x00122F44
		public unsafe NumberRange StartRotation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticlesProxy.NativeMethodInfoPtr_get_StartRotation_Public_get_NumberRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NumberRange>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128746, XrefRangeEnd = 128748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticlesProxy.NativeMethodInfoPtr_set_StartRotation_Public_set_Void_NumberRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001670 RID: 5744
		// (get) Token: 0x06004130 RID: 16688 RVA: 0x00124D88 File Offset: 0x00122F88
		// (set) Token: 0x06004131 RID: 16689 RVA: 0x00124DC8 File Offset: 0x00122FC8
		public unsafe NumberRange AngularVelocity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticlesProxy.NativeMethodInfoPtr_get_AngularVelocity_Public_get_NumberRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NumberRange>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128748, XrefRangeEnd = 128750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticlesProxy.NativeMethodInfoPtr_set_AngularVelocity_Public_set_Void_NumberRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001671 RID: 5745
		// (get) Token: 0x06004132 RID: 16690 RVA: 0x00124E0C File Offset: 0x0012300C
		// (set) Token: 0x06004133 RID: 16691 RVA: 0x00124E48 File Offset: 0x00123048
		public unsafe bool Autoplay
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticlesProxy.NativeMethodInfoPtr_get_Autoplay_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128750, XrefRangeEnd = 128752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticlesProxy.NativeMethodInfoPtr_set_Autoplay_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001672 RID: 5746
		// (get) Token: 0x06004134 RID: 16692 RVA: 0x00124E88 File Offset: 0x00123088
		// (set) Token: 0x06004135 RID: 16693 RVA: 0x00124EC4 File Offset: 0x001230C4
		public unsafe bool Loop
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticlesProxy.NativeMethodInfoPtr_get_Loop_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128752, XrefRangeEnd = 128754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticlesProxy.NativeMethodInfoPtr_set_Loop_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001673 RID: 5747
		// (get) Token: 0x06004136 RID: 16694 RVA: 0x00124F04 File Offset: 0x00123104
		// (set) Token: 0x06004137 RID: 16695 RVA: 0x00124F40 File Offset: 0x00123140
		public unsafe float Duration
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticlesProxy.NativeMethodInfoPtr_get_Duration_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128754, XrefRangeEnd = 128756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticlesProxy.NativeMethodInfoPtr_set_Duration_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001674 RID: 5748
		// (get) Token: 0x06004138 RID: 16696 RVA: 0x00124F80 File Offset: 0x00123180
		// (set) Token: 0x06004139 RID: 16697 RVA: 0x00124FC0 File Offset: 0x001231C0
		public unsafe ParticleShape Shape
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticlesProxy.NativeMethodInfoPtr_get_Shape_Public_get_ParticleShape_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ParticleShape>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128756, XrefRangeEnd = 128758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticlesProxy.NativeMethodInfoPtr_set_Shape_Public_set_Void_ParticleShape_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001675 RID: 5749
		// (get) Token: 0x0600413A RID: 16698 RVA: 0x00125004 File Offset: 0x00123204
		// (set) Token: 0x0600413B RID: 16699 RVA: 0x00125040 File Offset: 0x00123240
		public unsafe float ShapeRadius
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticlesProxy.NativeMethodInfoPtr_get_ShapeRadius_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128758, XrefRangeEnd = 128760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticlesProxy.NativeMethodInfoPtr_set_ShapeRadius_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001676 RID: 5750
		// (get) Token: 0x0600413C RID: 16700 RVA: 0x00125080 File Offset: 0x00123280
		// (set) Token: 0x0600413D RID: 16701 RVA: 0x001250BC File Offset: 0x001232BC
		public unsafe float ShapeAngle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticlesProxy.NativeMethodInfoPtr_get_ShapeAngle_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128760, XrefRangeEnd = 128762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticlesProxy.NativeMethodInfoPtr_set_ShapeAngle_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001677 RID: 5751
		// (get) Token: 0x0600413E RID: 16702 RVA: 0x001250FC File Offset: 0x001232FC
		// (set) Token: 0x0600413F RID: 16703 RVA: 0x0012513C File Offset: 0x0012333C
		public unsafe Vector3 ShapeScale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticlesProxy.NativeMethodInfoPtr_get_ShapeScale_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128762, XrefRangeEnd = 128763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticlesProxy.NativeMethodInfoPtr_set_ShapeScale_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001678 RID: 5752
		// (get) Token: 0x06004140 RID: 16704 RVA: 0x00125180 File Offset: 0x00123380
		public unsafe bool IsPlaying
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128763, XrefRangeEnd = 128765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticlesProxy.NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001679 RID: 5753
		// (get) Token: 0x06004141 RID: 16705 RVA: 0x001251BC File Offset: 0x001233BC
		public unsafe bool IsPaused
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128765, XrefRangeEnd = 128767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticlesProxy.NativeMethodInfoPtr_get_IsPaused_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700167A RID: 5754
		// (get) Token: 0x06004142 RID: 16706 RVA: 0x001251F8 File Offset: 0x001233F8
		public unsafe bool IsStopped
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128767, XrefRangeEnd = 128769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticlesProxy.NativeMethodInfoPtr_get_IsStopped_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700167B RID: 5755
		// (get) Token: 0x06004143 RID: 16707 RVA: 0x00125234 File Offset: 0x00123434
		public unsafe int ParticleCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128769, XrefRangeEnd = 128771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticlesProxy.NativeMethodInfoPtr_get_ParticleCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700167C RID: 5756
		// (get) Token: 0x06004144 RID: 16708 RVA: 0x00125270 File Offset: 0x00123470
		public unsafe float Time
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128771, XrefRangeEnd = 128773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticlesProxy.NativeMethodInfoPtr_get_Time_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700167D RID: 5757
		// (get) Token: 0x06004145 RID: 16709 RVA: 0x001252AC File Offset: 0x001234AC
		public unsafe float TotalTime
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128773, XrefRangeEnd = 128775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticlesProxy.NativeMethodInfoPtr_get_TotalTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004146 RID: 16710 RVA: 0x001252E8 File Offset: 0x001234E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParticlesProxy(Particles target)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticlesProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticlesProxy.NativeMethodInfoPtr__ctor_Public_Void_Particles_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004147 RID: 16711 RVA: 0x00125334 File Offset: 0x00123534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128775, XrefRangeEnd = 128777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticlesProxy.NativeMethodInfoPtr_Play_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004148 RID: 16712 RVA: 0x00125368 File Offset: 0x00123568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128777, XrefRangeEnd = 128779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticlesProxy.NativeMethodInfoPtr_Pause_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004149 RID: 16713 RVA: 0x0012539C File Offset: 0x0012359C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128779, XrefRangeEnd = 128781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticlesProxy.NativeMethodInfoPtr_Stop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600414A RID: 16714 RVA: 0x001253D0 File Offset: 0x001235D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128781, XrefRangeEnd = 128783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticlesProxy.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600414B RID: 16715 RVA: 0x00125404 File Offset: 0x00123604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128783, XrefRangeEnd = 128785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Emit(int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticlesProxy.NativeMethodInfoPtr_Emit_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600414C RID: 16716 RVA: 0x00125444 File Offset: 0x00123644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128785, XrefRangeEnd = 128787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Simulate(float time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParticlesProxy.NativeMethodInfoPtr_Simulate_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600414D RID: 16717 RVA: 0x000188A9 File Offset: 0x00016AA9
		public ParticlesProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001663 RID: 5731
		// (get) Token: 0x0600414E RID: 16718 RVA: 0x00125484 File Offset: 0x00123684
		// (set) Token: 0x0600414F RID: 16719 RVA: 0x000188B2 File Offset: 0x00016AB2
		public unsafe Particles particles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticlesProxy.NativeFieldInfoPtr_particles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Particles>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParticlesProxy.NativeFieldInfoPtr_particles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400329B RID: 12955
		private static readonly IntPtr NativeFieldInfoPtr_particles;

		// Token: 0x0400329C RID: 12956
		private static readonly IntPtr NativeMethodInfoPtr_get_ImageID_Public_get_String_0;

		// Token: 0x0400329D RID: 12957
		private static readonly IntPtr NativeMethodInfoPtr_set_ImageID_Public_set_Void_String_0;

		// Token: 0x0400329E RID: 12958
		private static readonly IntPtr NativeMethodInfoPtr_get_ImageType_Public_get_ImageType_0;

		// Token: 0x0400329F RID: 12959
		private static readonly IntPtr NativeMethodInfoPtr_set_ImageType_Public_set_Void_ImageType_0;

		// Token: 0x040032A0 RID: 12960
		private static readonly IntPtr NativeMethodInfoPtr_get_Color_Public_get_ColorRange_0;

		// Token: 0x040032A1 RID: 12961
		private static readonly IntPtr NativeMethodInfoPtr_set_Color_Public_set_Void_ColorRange_0;

		// Token: 0x040032A2 RID: 12962
		private static readonly IntPtr NativeMethodInfoPtr_get_ColorMode_Public_get_ParticleColorMode_0;

		// Token: 0x040032A3 RID: 12963
		private static readonly IntPtr NativeMethodInfoPtr_set_ColorMode_Public_set_Void_ParticleColorMode_0;

		// Token: 0x040032A4 RID: 12964
		private static readonly IntPtr NativeMethodInfoPtr_get_Lifetime_Public_get_NumberRange_0;

		// Token: 0x040032A5 RID: 12965
		private static readonly IntPtr NativeMethodInfoPtr_set_Lifetime_Public_set_Void_NumberRange_0;

		// Token: 0x040032A6 RID: 12966
		private static readonly IntPtr NativeMethodInfoPtr_get_SizeOverLifetime_Public_get_NumberRange_0;

		// Token: 0x040032A7 RID: 12967
		private static readonly IntPtr NativeMethodInfoPtr_set_SizeOverLifetime_Public_set_Void_NumberRange_0;

		// Token: 0x040032A8 RID: 12968
		private static readonly IntPtr NativeMethodInfoPtr_get_Speed_Public_get_NumberRange_0;

		// Token: 0x040032A9 RID: 12969
		private static readonly IntPtr NativeMethodInfoPtr_set_Speed_Public_set_Void_NumberRange_0;

		// Token: 0x040032AA RID: 12970
		private static readonly IntPtr NativeMethodInfoPtr_get_EmissionRate_Public_get_Int32_0;

		// Token: 0x040032AB RID: 12971
		private static readonly IntPtr NativeMethodInfoPtr_set_EmissionRate_Public_set_Void_Int32_0;

		// Token: 0x040032AC RID: 12972
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxParticles_Public_get_Int32_0;

		// Token: 0x040032AD RID: 12973
		private static readonly IntPtr NativeMethodInfoPtr_set_MaxParticles_Public_set_Void_Int32_0;

		// Token: 0x040032AE RID: 12974
		private static readonly IntPtr NativeMethodInfoPtr_get_Gravity_Public_get_Single_0;

		// Token: 0x040032AF RID: 12975
		private static readonly IntPtr NativeMethodInfoPtr_set_Gravity_Public_set_Void_Single_0;

		// Token: 0x040032B0 RID: 12976
		private static readonly IntPtr NativeMethodInfoPtr_get_SimulationSpace_Public_get_ParticleSimulationSpace_0;

		// Token: 0x040032B1 RID: 12977
		private static readonly IntPtr NativeMethodInfoPtr_set_SimulationSpace_Public_set_Void_ParticleSimulationSpace_0;

		// Token: 0x040032B2 RID: 12978
		private static readonly IntPtr NativeMethodInfoPtr_get_StartRotation_Public_get_NumberRange_0;

		// Token: 0x040032B3 RID: 12979
		private static readonly IntPtr NativeMethodInfoPtr_set_StartRotation_Public_set_Void_NumberRange_0;

		// Token: 0x040032B4 RID: 12980
		private static readonly IntPtr NativeMethodInfoPtr_get_AngularVelocity_Public_get_NumberRange_0;

		// Token: 0x040032B5 RID: 12981
		private static readonly IntPtr NativeMethodInfoPtr_set_AngularVelocity_Public_set_Void_NumberRange_0;

		// Token: 0x040032B6 RID: 12982
		private static readonly IntPtr NativeMethodInfoPtr_get_Autoplay_Public_get_Boolean_0;

		// Token: 0x040032B7 RID: 12983
		private static readonly IntPtr NativeMethodInfoPtr_set_Autoplay_Public_set_Void_Boolean_0;

		// Token: 0x040032B8 RID: 12984
		private static readonly IntPtr NativeMethodInfoPtr_get_Loop_Public_get_Boolean_0;

		// Token: 0x040032B9 RID: 12985
		private static readonly IntPtr NativeMethodInfoPtr_set_Loop_Public_set_Void_Boolean_0;

		// Token: 0x040032BA RID: 12986
		private static readonly IntPtr NativeMethodInfoPtr_get_Duration_Public_get_Single_0;

		// Token: 0x040032BB RID: 12987
		private static readonly IntPtr NativeMethodInfoPtr_set_Duration_Public_set_Void_Single_0;

		// Token: 0x040032BC RID: 12988
		private static readonly IntPtr NativeMethodInfoPtr_get_Shape_Public_get_ParticleShape_0;

		// Token: 0x040032BD RID: 12989
		private static readonly IntPtr NativeMethodInfoPtr_set_Shape_Public_set_Void_ParticleShape_0;

		// Token: 0x040032BE RID: 12990
		private static readonly IntPtr NativeMethodInfoPtr_get_ShapeRadius_Public_get_Single_0;

		// Token: 0x040032BF RID: 12991
		private static readonly IntPtr NativeMethodInfoPtr_set_ShapeRadius_Public_set_Void_Single_0;

		// Token: 0x040032C0 RID: 12992
		private static readonly IntPtr NativeMethodInfoPtr_get_ShapeAngle_Public_get_Single_0;

		// Token: 0x040032C1 RID: 12993
		private static readonly IntPtr NativeMethodInfoPtr_set_ShapeAngle_Public_set_Void_Single_0;

		// Token: 0x040032C2 RID: 12994
		private static readonly IntPtr NativeMethodInfoPtr_get_ShapeScale_Public_get_Vector3_0;

		// Token: 0x040032C3 RID: 12995
		private static readonly IntPtr NativeMethodInfoPtr_set_ShapeScale_Public_set_Void_Vector3_0;

		// Token: 0x040032C4 RID: 12996
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0;

		// Token: 0x040032C5 RID: 12997
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPaused_Public_get_Boolean_0;

		// Token: 0x040032C6 RID: 12998
		private static readonly IntPtr NativeMethodInfoPtr_get_IsStopped_Public_get_Boolean_0;

		// Token: 0x040032C7 RID: 12999
		private static readonly IntPtr NativeMethodInfoPtr_get_ParticleCount_Public_get_Int32_0;

		// Token: 0x040032C8 RID: 13000
		private static readonly IntPtr NativeMethodInfoPtr_get_Time_Public_get_Single_0;

		// Token: 0x040032C9 RID: 13001
		private static readonly IntPtr NativeMethodInfoPtr_get_TotalTime_Public_get_Single_0;

		// Token: 0x040032CA RID: 13002
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Particles_0;

		// Token: 0x040032CB RID: 13003
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Void_0;

		// Token: 0x040032CC RID: 13004
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Public_Void_0;

		// Token: 0x040032CD RID: 13005
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;

		// Token: 0x040032CE RID: 13006
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x040032CF RID: 13007
		private static readonly IntPtr NativeMethodInfoPtr_Emit_Public_Void_Int32_0;

		// Token: 0x040032D0 RID: 13008
		private static readonly IntPtr NativeMethodInfoPtr_Simulate_Public_Void_Single_0;
	}
}
