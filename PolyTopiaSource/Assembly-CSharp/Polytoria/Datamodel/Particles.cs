using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Mirror;
using Polytoria.Controllers;
using Polytoria.Types;
using UnityEngine;

namespace Polytoria.Datamodel
{
	// Token: 0x0200029A RID: 666
	public class Particles : DynamicInstance
	{
		// Token: 0x06003630 RID: 13872 RVA: 0x000F6724 File Offset: 0x000F4924
		// Note: this type is marked as 'beforefieldinit'.
		static Particles()
		{
			Il2CppClassPointerStore<Particles>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Polytoria.Datamodel", "Particles");
			Particles.NativeFieldInfoPtr_particles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particles>.NativeClassPtr, "particles");
			Particles.NativeFieldInfoPtr_imageID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particles>.NativeClassPtr, "imageID");
			Particles.NativeFieldInfoPtr_imageType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particles>.NativeClassPtr, "imageType");
			Particles.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particles>.NativeClassPtr, "color");
			Particles.NativeFieldInfoPtr_colorMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particles>.NativeClassPtr, "colorMode");
			Particles.NativeFieldInfoPtr_lifetime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particles>.NativeClassPtr, "lifetime");
			Particles.NativeFieldInfoPtr_sizeOverLifetime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particles>.NativeClassPtr, "sizeOverLifetime");
			Particles.NativeFieldInfoPtr_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particles>.NativeClassPtr, "speed");
			Particles.NativeFieldInfoPtr_emissionRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particles>.NativeClassPtr, "emissionRate");
			Particles.NativeFieldInfoPtr_maxParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particles>.NativeClassPtr, "maxParticles");
			Particles.NativeFieldInfoPtr_gravity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particles>.NativeClassPtr, "gravity");
			Particles.NativeFieldInfoPtr_simulationSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particles>.NativeClassPtr, "simulationSpace");
			Particles.NativeFieldInfoPtr_startRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particles>.NativeClassPtr, "startRotation");
			Particles.NativeFieldInfoPtr_angularVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particles>.NativeClassPtr, "angularVelocity");
			Particles.NativeFieldInfoPtr_autoplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particles>.NativeClassPtr, "autoplay");
			Particles.NativeFieldInfoPtr_loop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particles>.NativeClassPtr, "loop");
			Particles.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particles>.NativeClassPtr, "duration");
			Particles.NativeFieldInfoPtr_shape = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particles>.NativeClassPtr, "shape");
			Particles.NativeFieldInfoPtr_shapeRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particles>.NativeClassPtr, "shapeRadius");
			Particles.NativeFieldInfoPtr_shapeAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particles>.NativeClassPtr, "shapeAngle");
			Particles.NativeFieldInfoPtr_shapeScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particles>.NativeClassPtr, "shapeScale");
			Particles.NativeFieldInfoPtr_lastCacheKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particles>.NativeClassPtr, "lastCacheKey");
			Particles.NativeFieldInfoPtr_currentEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particles>.NativeClassPtr, "currentEntry");
			Particles.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_imageID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particles>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_imageID");
			Particles.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_imageType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particles>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_imageType");
			Particles.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particles>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_color");
			Particles.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_colorMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particles>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_colorMode");
			Particles.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_lifetime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particles>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_lifetime");
			Particles.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_sizeOverLifetime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particles>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_sizeOverLifetime");
			Particles.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particles>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_speed");
			Particles.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_emissionRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particles>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_emissionRate");
			Particles.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_maxParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particles>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_maxParticles");
			Particles.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_gravity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particles>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_gravity");
			Particles.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_simulationSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particles>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_simulationSpace");
			Particles.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_startRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particles>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_startRotation");
			Particles.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_angularVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particles>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_angularVelocity");
			Particles.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_autoplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particles>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_autoplay");
			Particles.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_loop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particles>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_loop");
			Particles.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particles>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_duration");
			Particles.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_shape = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particles>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_shape");
			Particles.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_shapeRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particles>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_shapeRadius");
			Particles.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_shapeAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particles>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_shapeAngle");
			Particles.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_shapeScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particles>.NativeClassPtr, "_Mirror_SyncVarHookDelegate_shapeScale");
			Particles.NativeMethodInfoPtr_get_ImageID_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671503);
			Particles.NativeMethodInfoPtr_set_ImageID_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671504);
			Particles.NativeMethodInfoPtr_get_ImageType_Public_get_ImageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671505);
			Particles.NativeMethodInfoPtr_set_ImageType_Public_set_Void_ImageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671506);
			Particles.NativeMethodInfoPtr_get_Color_Public_get_ColorRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671507);
			Particles.NativeMethodInfoPtr_set_Color_Public_set_Void_ColorRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671508);
			Particles.NativeMethodInfoPtr_get_ColorMode_Public_get_ParticleColorMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671509);
			Particles.NativeMethodInfoPtr_set_ColorMode_Public_set_Void_ParticleColorMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671510);
			Particles.NativeMethodInfoPtr_get_Lifetime_Public_get_NumberRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671511);
			Particles.NativeMethodInfoPtr_set_Lifetime_Public_set_Void_NumberRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671512);
			Particles.NativeMethodInfoPtr_get_SizeOverLifetime_Public_get_NumberRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671513);
			Particles.NativeMethodInfoPtr_set_SizeOverLifetime_Public_set_Void_NumberRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671514);
			Particles.NativeMethodInfoPtr_get_Speed_Public_get_NumberRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671515);
			Particles.NativeMethodInfoPtr_set_Speed_Public_set_Void_NumberRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671516);
			Particles.NativeMethodInfoPtr_get_EmissionRate_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671517);
			Particles.NativeMethodInfoPtr_set_EmissionRate_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671518);
			Particles.NativeMethodInfoPtr_get_MaxParticles_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671519);
			Particles.NativeMethodInfoPtr_set_MaxParticles_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671520);
			Particles.NativeMethodInfoPtr_get_Gravity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671521);
			Particles.NativeMethodInfoPtr_set_Gravity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671522);
			Particles.NativeMethodInfoPtr_get_SimulationSpace_Public_get_ParticleSimulationSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671523);
			Particles.NativeMethodInfoPtr_set_SimulationSpace_Public_set_Void_ParticleSimulationSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671524);
			Particles.NativeMethodInfoPtr_get_StartRotation_Public_get_NumberRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671525);
			Particles.NativeMethodInfoPtr_set_StartRotation_Public_set_Void_NumberRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671526);
			Particles.NativeMethodInfoPtr_get_AngularVelocity_Public_get_NumberRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671527);
			Particles.NativeMethodInfoPtr_set_AngularVelocity_Public_set_Void_NumberRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671528);
			Particles.NativeMethodInfoPtr_get_Autoplay_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671529);
			Particles.NativeMethodInfoPtr_set_Autoplay_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671530);
			Particles.NativeMethodInfoPtr_get_Loop_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671531);
			Particles.NativeMethodInfoPtr_set_Loop_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671532);
			Particles.NativeMethodInfoPtr_get_Duration_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671533);
			Particles.NativeMethodInfoPtr_set_Duration_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671534);
			Particles.NativeMethodInfoPtr_get_Shape_Public_get_ParticleShape_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671535);
			Particles.NativeMethodInfoPtr_set_Shape_Public_set_Void_ParticleShape_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671536);
			Particles.NativeMethodInfoPtr_get_ShapeRadius_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671537);
			Particles.NativeMethodInfoPtr_set_ShapeRadius_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671538);
			Particles.NativeMethodInfoPtr_get_ShapeAngle_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671539);
			Particles.NativeMethodInfoPtr_set_ShapeAngle_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671540);
			Particles.NativeMethodInfoPtr_get_ShapeScale_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671541);
			Particles.NativeMethodInfoPtr_set_ShapeScale_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671542);
			Particles.NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671543);
			Particles.NativeMethodInfoPtr_get_IsPaused_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671544);
			Particles.NativeMethodInfoPtr_get_IsStopped_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671545);
			Particles.NativeMethodInfoPtr_get_ParticleCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671546);
			Particles.NativeMethodInfoPtr_get_Time_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671547);
			Particles.NativeMethodInfoPtr_get_TotalTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671548);
			Particles.NativeMethodInfoPtr_get_NetworkimageID_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671589);
			Particles.NativeMethodInfoPtr_set_NetworkimageID_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671590);
			Particles.NativeMethodInfoPtr_get_NetworkimageType_Public_get_ImageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671591);
			Particles.NativeMethodInfoPtr_set_NetworkimageType_Public_set_Void_ImageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671592);
			Particles.NativeMethodInfoPtr_get_Networkcolor_Public_get_ColorRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671593);
			Particles.NativeMethodInfoPtr_set_Networkcolor_Public_set_Void_ColorRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671594);
			Particles.NativeMethodInfoPtr_get_NetworkcolorMode_Public_get_ParticleColorMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671595);
			Particles.NativeMethodInfoPtr_set_NetworkcolorMode_Public_set_Void_ParticleColorMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671596);
			Particles.NativeMethodInfoPtr_get_Networklifetime_Public_get_NumberRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671597);
			Particles.NativeMethodInfoPtr_set_Networklifetime_Public_set_Void_NumberRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671598);
			Particles.NativeMethodInfoPtr_get_NetworksizeOverLifetime_Public_get_NumberRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671599);
			Particles.NativeMethodInfoPtr_set_NetworksizeOverLifetime_Public_set_Void_NumberRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671600);
			Particles.NativeMethodInfoPtr_get_Networkspeed_Public_get_NumberRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671601);
			Particles.NativeMethodInfoPtr_set_Networkspeed_Public_set_Void_NumberRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671602);
			Particles.NativeMethodInfoPtr_get_NetworkemissionRate_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671603);
			Particles.NativeMethodInfoPtr_set_NetworkemissionRate_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671604);
			Particles.NativeMethodInfoPtr_get_NetworkmaxParticles_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671605);
			Particles.NativeMethodInfoPtr_set_NetworkmaxParticles_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671606);
			Particles.NativeMethodInfoPtr_get_Networkgravity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671607);
			Particles.NativeMethodInfoPtr_set_Networkgravity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671608);
			Particles.NativeMethodInfoPtr_get_NetworksimulationSpace_Public_get_ParticleSimulationSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671609);
			Particles.NativeMethodInfoPtr_set_NetworksimulationSpace_Public_set_Void_ParticleSimulationSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671610);
			Particles.NativeMethodInfoPtr_get_NetworkstartRotation_Public_get_NumberRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671611);
			Particles.NativeMethodInfoPtr_set_NetworkstartRotation_Public_set_Void_NumberRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671612);
			Particles.NativeMethodInfoPtr_get_NetworkangularVelocity_Public_get_NumberRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671613);
			Particles.NativeMethodInfoPtr_set_NetworkangularVelocity_Public_set_Void_NumberRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671614);
			Particles.NativeMethodInfoPtr_get_Networkautoplay_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671615);
			Particles.NativeMethodInfoPtr_set_Networkautoplay_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671616);
			Particles.NativeMethodInfoPtr_get_Networkloop_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671617);
			Particles.NativeMethodInfoPtr_set_Networkloop_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671618);
			Particles.NativeMethodInfoPtr_get_Networkduration_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671619);
			Particles.NativeMethodInfoPtr_set_Networkduration_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671620);
			Particles.NativeMethodInfoPtr_get_Networkshape_Public_get_ParticleShape_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671621);
			Particles.NativeMethodInfoPtr_set_Networkshape_Public_set_Void_ParticleShape_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671622);
			Particles.NativeMethodInfoPtr_get_NetworkshapeRadius_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671623);
			Particles.NativeMethodInfoPtr_set_NetworkshapeRadius_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671624);
			Particles.NativeMethodInfoPtr_get_NetworkshapeAngle_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671625);
			Particles.NativeMethodInfoPtr_set_NetworkshapeAngle_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671626);
			Particles.NativeMethodInfoPtr_get_NetworkshapeScale_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671627);
			Particles.NativeMethodInfoPtr_set_NetworkshapeScale_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671628);
			Particles.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671586);
			Particles.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671549);
			Particles.NativeMethodInfoPtr_OnHide_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671550);
			Particles.NativeMethodInfoPtr_OnShow_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671551);
			Particles.NativeMethodInfoPtr_GetImage_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671552);
			Particles.NativeMethodInfoPtr_Play_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671553);
			Particles.NativeMethodInfoPtr_Pause_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671554);
			Particles.NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671555);
			Particles.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671556);
			Particles.NativeMethodInfoPtr_Emit_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671557);
			Particles.NativeMethodInfoPtr_Simulate_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671558);
			Particles.NativeMethodInfoPtr_RpcPlay_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671559);
			Particles.NativeMethodInfoPtr_RpcPause_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671560);
			Particles.NativeMethodInfoPtr_RpcStop_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671561);
			Particles.NativeMethodInfoPtr_RpcClear_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671562);
			Particles.NativeMethodInfoPtr_RpcEmit_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671563);
			Particles.NativeMethodInfoPtr_RpcSimulate_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671564);
			Particles.NativeMethodInfoPtr_CopyProperties_Protected_Virtual_Void_Instance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671565);
			Particles.NativeMethodInfoPtr_OnImageIDChanged_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671566);
			Particles.NativeMethodInfoPtr_OnImageTypeChanged_Private_Void_ImageType_ImageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671567);
			Particles.NativeMethodInfoPtr_OnColorChanged_Private_Void_ColorRange_ColorRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671568);
			Particles.NativeMethodInfoPtr_OnColorModeChanged_Private_Void_ParticleColorMode_ParticleColorMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671569);
			Particles.NativeMethodInfoPtr_OnLifetimeChanged_Private_Void_NumberRange_NumberRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671570);
			Particles.NativeMethodInfoPtr_OnSizeOverLifetimeChanged_Private_Void_NumberRange_NumberRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671571);
			Particles.NativeMethodInfoPtr_OnSpeedChanged_Private_Void_NumberRange_NumberRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671572);
			Particles.NativeMethodInfoPtr_OnEmissionRateChanged_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671573);
			Particles.NativeMethodInfoPtr_OnMaxParticlesChanged_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671574);
			Particles.NativeMethodInfoPtr_OnGravityChanged_Private_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671575);
			Particles.NativeMethodInfoPtr_OnSimulationSpaceChanged_Private_Void_ParticleSimulationSpace_ParticleSimulationSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671576);
			Particles.NativeMethodInfoPtr_OnStartRotationChanged_Private_Void_NumberRange_NumberRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671577);
			Particles.NativeMethodInfoPtr_OnAngularVelocityChanged_Private_Void_NumberRange_NumberRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671578);
			Particles.NativeMethodInfoPtr_OnAutoplayChanged_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671579);
			Particles.NativeMethodInfoPtr_OnLoopChanged_Private_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671580);
			Particles.NativeMethodInfoPtr_OnDurationChanged_Private_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671581);
			Particles.NativeMethodInfoPtr_OnShapeChanged_Private_Void_ParticleShape_ParticleShape_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671582);
			Particles.NativeMethodInfoPtr_OnShapeRadiusChanged_Private_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671583);
			Particles.NativeMethodInfoPtr_OnShapeAngleChanged_Private_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671584);
			Particles.NativeMethodInfoPtr_OnShapeScaleChanged_Private_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671585);
			Particles.NativeMethodInfoPtr__GetImage_b__98_0_Private_Void_ImageCacheKey_ImageCacheEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671587);
			Particles.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671588);
			Particles.NativeMethodInfoPtr_UserCode_RpcPlay_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671629);
			Particles.NativeMethodInfoPtr_InvokeUserCode_RpcPlay_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671630);
			Particles.NativeMethodInfoPtr_UserCode_RpcPause_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671631);
			Particles.NativeMethodInfoPtr_InvokeUserCode_RpcPause_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671632);
			Particles.NativeMethodInfoPtr_UserCode_RpcStop_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671633);
			Particles.NativeMethodInfoPtr_InvokeUserCode_RpcStop_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671634);
			Particles.NativeMethodInfoPtr_UserCode_RpcClear_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671635);
			Particles.NativeMethodInfoPtr_InvokeUserCode_RpcClear_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671636);
			Particles.NativeMethodInfoPtr_UserCode_RpcEmit__Int32_Protected_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671637);
			Particles.NativeMethodInfoPtr_InvokeUserCode_RpcEmit__Int32_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671638);
			Particles.NativeMethodInfoPtr_UserCode_RpcSimulate__Single_Protected_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671639);
			Particles.NativeMethodInfoPtr_InvokeUserCode_RpcSimulate__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671640);
			Particles.NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671642);
			Particles.NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particles>.NativeClassPtr, 100671643);
		}

		// Token: 0x170012F7 RID: 4855
		// (get) Token: 0x06003631 RID: 13873 RVA: 0x000F7598 File Offset: 0x000F5798
		// (set) Token: 0x06003632 RID: 13874 RVA: 0x000F75D0 File Offset: 0x000F57D0
		public unsafe string ImageID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_get_ImageID_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 110484, RefRangeEnd = 110487, XrefRangeStart = 110480, XrefRangeEnd = 110484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_set_ImageID_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170012F8 RID: 4856
		// (get) Token: 0x06003633 RID: 13875 RVA: 0x000F7614 File Offset: 0x000F5814
		// (set) Token: 0x06003634 RID: 13876 RVA: 0x000F7654 File Offset: 0x000F5854
		public unsafe ImageType ImageType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_get_ImageType_Public_get_ImageType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ImageType>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 110491, RefRangeEnd = 110493, XrefRangeStart = 110487, XrefRangeEnd = 110491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_set_ImageType_Public_set_Void_ImageType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170012F9 RID: 4857
		// (get) Token: 0x06003635 RID: 13877 RVA: 0x000F7698 File Offset: 0x000F5898
		// (set) Token: 0x06003636 RID: 13878 RVA: 0x000F76D8 File Offset: 0x000F58D8
		public unsafe ColorRange Color
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_get_Color_Public_get_ColorRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ColorRange>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 110523, RefRangeEnd = 110526, XrefRangeStart = 110493, XrefRangeEnd = 110523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_set_Color_Public_set_Void_ColorRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170012FA RID: 4858
		// (get) Token: 0x06003637 RID: 13879 RVA: 0x000F771C File Offset: 0x000F591C
		// (set) Token: 0x06003638 RID: 13880 RVA: 0x000F775C File Offset: 0x000F595C
		public unsafe ParticleColorMode ColorMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_get_ColorMode_Public_get_ParticleColorMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ParticleColorMode>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 110543, RefRangeEnd = 110546, XrefRangeStart = 110526, XrefRangeEnd = 110543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_set_ColorMode_Public_set_Void_ParticleColorMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170012FB RID: 4859
		// (get) Token: 0x06003639 RID: 13881 RVA: 0x000F77A0 File Offset: 0x000F59A0
		// (set) Token: 0x0600363A RID: 13882 RVA: 0x000F77E0 File Offset: 0x000F59E0
		public unsafe NumberRange Lifetime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_get_Lifetime_Public_get_NumberRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NumberRange>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 110552, RefRangeEnd = 110555, XrefRangeStart = 110546, XrefRangeEnd = 110552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_set_Lifetime_Public_set_Void_NumberRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170012FC RID: 4860
		// (get) Token: 0x0600363B RID: 13883 RVA: 0x000F7824 File Offset: 0x000F5A24
		// (set) Token: 0x0600363C RID: 13884 RVA: 0x000F7864 File Offset: 0x000F5A64
		public unsafe NumberRange SizeOverLifetime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_get_SizeOverLifetime_Public_get_NumberRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NumberRange>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 110570, RefRangeEnd = 110573, XrefRangeStart = 110555, XrefRangeEnd = 110570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_set_SizeOverLifetime_Public_set_Void_NumberRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170012FD RID: 4861
		// (get) Token: 0x0600363D RID: 13885 RVA: 0x000F78A8 File Offset: 0x000F5AA8
		// (set) Token: 0x0600363E RID: 13886 RVA: 0x000F78E8 File Offset: 0x000F5AE8
		public unsafe NumberRange Speed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_get_Speed_Public_get_NumberRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NumberRange>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 110579, RefRangeEnd = 110582, XrefRangeStart = 110573, XrefRangeEnd = 110579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_set_Speed_Public_set_Void_NumberRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170012FE RID: 4862
		// (get) Token: 0x0600363F RID: 13887 RVA: 0x000F792C File Offset: 0x000F5B2C
		// (set) Token: 0x06003640 RID: 13888 RVA: 0x000F7968 File Offset: 0x000F5B68
		public unsafe int EmissionRate
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_get_EmissionRate_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 110588, RefRangeEnd = 110591, XrefRangeStart = 110582, XrefRangeEnd = 110588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_set_EmissionRate_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170012FF RID: 4863
		// (get) Token: 0x06003641 RID: 13889 RVA: 0x000F79A8 File Offset: 0x000F5BA8
		// (set) Token: 0x06003642 RID: 13890 RVA: 0x000F79E4 File Offset: 0x000F5BE4
		public unsafe int MaxParticles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_get_MaxParticles_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 110596, RefRangeEnd = 110599, XrefRangeStart = 110591, XrefRangeEnd = 110596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_set_MaxParticles_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001300 RID: 4864
		// (get) Token: 0x06003643 RID: 13891 RVA: 0x000F7A24 File Offset: 0x000F5C24
		// (set) Token: 0x06003644 RID: 13892 RVA: 0x000F7A60 File Offset: 0x000F5C60
		public unsafe float Gravity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_get_Gravity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 110605, RefRangeEnd = 110608, XrefRangeStart = 110599, XrefRangeEnd = 110605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_set_Gravity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001301 RID: 4865
		// (get) Token: 0x06003645 RID: 13893 RVA: 0x000F7AA0 File Offset: 0x000F5CA0
		// (set) Token: 0x06003646 RID: 13894 RVA: 0x000F7AE0 File Offset: 0x000F5CE0
		public unsafe ParticleSimulationSpace SimulationSpace
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_get_SimulationSpace_Public_get_ParticleSimulationSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ParticleSimulationSpace>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 110613, RefRangeEnd = 110616, XrefRangeStart = 110608, XrefRangeEnd = 110613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_set_SimulationSpace_Public_set_Void_ParticleSimulationSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001302 RID: 4866
		// (get) Token: 0x06003647 RID: 13895 RVA: 0x000F7B24 File Offset: 0x000F5D24
		// (set) Token: 0x06003648 RID: 13896 RVA: 0x000F7B64 File Offset: 0x000F5D64
		public unsafe NumberRange StartRotation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_get_StartRotation_Public_get_NumberRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NumberRange>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 110622, RefRangeEnd = 110625, XrefRangeStart = 110616, XrefRangeEnd = 110622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_set_StartRotation_Public_set_Void_NumberRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001303 RID: 4867
		// (get) Token: 0x06003649 RID: 13897 RVA: 0x000F7BA8 File Offset: 0x000F5DA8
		// (set) Token: 0x0600364A RID: 13898 RVA: 0x000F7BE8 File Offset: 0x000F5DE8
		public unsafe NumberRange AngularVelocity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_get_AngularVelocity_Public_get_NumberRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NumberRange>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 110631, RefRangeEnd = 110634, XrefRangeStart = 110625, XrefRangeEnd = 110631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_set_AngularVelocity_Public_set_Void_NumberRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001304 RID: 4868
		// (get) Token: 0x0600364B RID: 13899 RVA: 0x000F7C2C File Offset: 0x000F5E2C
		// (set) Token: 0x0600364C RID: 13900 RVA: 0x000F7C68 File Offset: 0x000F5E68
		public unsafe bool Autoplay
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_get_Autoplay_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 110638, RefRangeEnd = 110641, XrefRangeStart = 110634, XrefRangeEnd = 110638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_set_Autoplay_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001305 RID: 4869
		// (get) Token: 0x0600364D RID: 13901 RVA: 0x000F7CA8 File Offset: 0x000F5EA8
		// (set) Token: 0x0600364E RID: 13902 RVA: 0x000F7CE4 File Offset: 0x000F5EE4
		public unsafe bool Loop
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_get_Loop_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 110646, RefRangeEnd = 110649, XrefRangeStart = 110641, XrefRangeEnd = 110646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_set_Loop_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001306 RID: 4870
		// (get) Token: 0x0600364F RID: 13903 RVA: 0x000F7D24 File Offset: 0x000F5F24
		// (set) Token: 0x06003650 RID: 13904 RVA: 0x000F7D60 File Offset: 0x000F5F60
		public unsafe float Duration
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_get_Duration_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 110654, RefRangeEnd = 110657, XrefRangeStart = 110649, XrefRangeEnd = 110654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_set_Duration_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001307 RID: 4871
		// (get) Token: 0x06003651 RID: 13905 RVA: 0x000F7DA0 File Offset: 0x000F5FA0
		// (set) Token: 0x06003652 RID: 13906 RVA: 0x000F7DE0 File Offset: 0x000F5FE0
		public unsafe ParticleShape Shape
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_get_Shape_Public_get_ParticleShape_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ParticleShape>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 110662, RefRangeEnd = 110665, XrefRangeStart = 110657, XrefRangeEnd = 110662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_set_Shape_Public_set_Void_ParticleShape_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001308 RID: 4872
		// (get) Token: 0x06003653 RID: 13907 RVA: 0x000F7E24 File Offset: 0x000F6024
		// (set) Token: 0x06003654 RID: 13908 RVA: 0x000F7E60 File Offset: 0x000F6060
		public unsafe float ShapeRadius
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_get_ShapeRadius_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 110670, RefRangeEnd = 110673, XrefRangeStart = 110665, XrefRangeEnd = 110670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_set_ShapeRadius_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001309 RID: 4873
		// (get) Token: 0x06003655 RID: 13909 RVA: 0x000F7EA0 File Offset: 0x000F60A0
		// (set) Token: 0x06003656 RID: 13910 RVA: 0x000F7EDC File Offset: 0x000F60DC
		public unsafe float ShapeAngle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_get_ShapeAngle_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 110678, RefRangeEnd = 110681, XrefRangeStart = 110673, XrefRangeEnd = 110678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_set_ShapeAngle_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700130A RID: 4874
		// (get) Token: 0x06003657 RID: 13911 RVA: 0x000F7F1C File Offset: 0x000F611C
		// (set) Token: 0x06003658 RID: 13912 RVA: 0x000F7F5C File Offset: 0x000F615C
		public unsafe Vector3 ShapeScale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_get_ShapeScale_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 110686, RefRangeEnd = 110689, XrefRangeStart = 110681, XrefRangeEnd = 110686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_set_ShapeScale_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700130B RID: 4875
		// (get) Token: 0x06003659 RID: 13913 RVA: 0x000F7FA0 File Offset: 0x000F61A0
		public unsafe bool IsPlaying
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 110691, RefRangeEnd = 110692, XrefRangeStart = 110689, XrefRangeEnd = 110691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700130C RID: 4876
		// (get) Token: 0x0600365A RID: 13914 RVA: 0x000F7FDC File Offset: 0x000F61DC
		public unsafe bool IsPaused
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 110694, RefRangeEnd = 110695, XrefRangeStart = 110692, XrefRangeEnd = 110694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_get_IsPaused_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700130D RID: 4877
		// (get) Token: 0x0600365B RID: 13915 RVA: 0x000F8018 File Offset: 0x000F6218
		public unsafe bool IsStopped
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 110697, RefRangeEnd = 110698, XrefRangeStart = 110695, XrefRangeEnd = 110697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_get_IsStopped_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700130E RID: 4878
		// (get) Token: 0x0600365C RID: 13916 RVA: 0x000F8054 File Offset: 0x000F6254
		public unsafe int ParticleCount
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 110700, RefRangeEnd = 110701, XrefRangeStart = 110698, XrefRangeEnd = 110700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_get_ParticleCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700130F RID: 4879
		// (get) Token: 0x0600365D RID: 13917 RVA: 0x000F8090 File Offset: 0x000F6290
		public unsafe float Time
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 110703, RefRangeEnd = 110704, XrefRangeStart = 110701, XrefRangeEnd = 110703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_get_Time_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001310 RID: 4880
		// (get) Token: 0x0600365E RID: 13918 RVA: 0x000F80CC File Offset: 0x000F62CC
		public unsafe float TotalTime
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 110706, RefRangeEnd = 110707, XrefRangeStart = 110704, XrefRangeEnd = 110706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_get_TotalTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001311 RID: 4881
		// (get) Token: 0x0600365F RID: 13919 RVA: 0x000F8108 File Offset: 0x000F6308
		// (set) Token: 0x06003660 RID: 13920 RVA: 0x000F8140 File Offset: 0x000F6340
		public unsafe string NetworkimageID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_get_NetworkimageID_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110707, XrefRangeEnd = 110710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_set_NetworkimageID_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001312 RID: 4882
		// (get) Token: 0x06003661 RID: 13921 RVA: 0x000F8184 File Offset: 0x000F6384
		// (set) Token: 0x06003662 RID: 13922 RVA: 0x000F81C4 File Offset: 0x000F63C4
		public unsafe ImageType NetworkimageType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_get_NetworkimageType_Public_get_ImageType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ImageType>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110710, XrefRangeEnd = 110713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_set_NetworkimageType_Public_set_Void_ImageType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001313 RID: 4883
		// (get) Token: 0x06003663 RID: 13923 RVA: 0x000F8208 File Offset: 0x000F6408
		// (set) Token: 0x06003664 RID: 13924 RVA: 0x000F8248 File Offset: 0x000F6448
		public unsafe ColorRange Networkcolor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_get_Networkcolor_Public_get_ColorRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ColorRange>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110713, XrefRangeEnd = 110725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_set_Networkcolor_Public_set_Void_ColorRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001314 RID: 4884
		// (get) Token: 0x06003665 RID: 13925 RVA: 0x000F828C File Offset: 0x000F648C
		// (set) Token: 0x06003666 RID: 13926 RVA: 0x000F82CC File Offset: 0x000F64CC
		public unsafe ParticleColorMode NetworkcolorMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_get_NetworkcolorMode_Public_get_ParticleColorMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ParticleColorMode>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110725, XrefRangeEnd = 110728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_set_NetworkcolorMode_Public_set_Void_ParticleColorMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001315 RID: 4885
		// (get) Token: 0x06003667 RID: 13927 RVA: 0x000F8310 File Offset: 0x000F6510
		// (set) Token: 0x06003668 RID: 13928 RVA: 0x000F8350 File Offset: 0x000F6550
		public unsafe NumberRange Networklifetime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_get_Networklifetime_Public_get_NumberRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NumberRange>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110728, XrefRangeEnd = 110731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_set_Networklifetime_Public_set_Void_NumberRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001316 RID: 4886
		// (get) Token: 0x06003669 RID: 13929 RVA: 0x000F8394 File Offset: 0x000F6594
		// (set) Token: 0x0600366A RID: 13930 RVA: 0x000F83D4 File Offset: 0x000F65D4
		public unsafe NumberRange NetworksizeOverLifetime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_get_NetworksizeOverLifetime_Public_get_NumberRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NumberRange>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110731, XrefRangeEnd = 110734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_set_NetworksizeOverLifetime_Public_set_Void_NumberRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001317 RID: 4887
		// (get) Token: 0x0600366B RID: 13931 RVA: 0x000F8418 File Offset: 0x000F6618
		// (set) Token: 0x0600366C RID: 13932 RVA: 0x000F8458 File Offset: 0x000F6658
		public unsafe NumberRange Networkspeed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_get_Networkspeed_Public_get_NumberRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NumberRange>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110734, XrefRangeEnd = 110737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_set_Networkspeed_Public_set_Void_NumberRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001318 RID: 4888
		// (get) Token: 0x0600366D RID: 13933 RVA: 0x000F849C File Offset: 0x000F669C
		// (set) Token: 0x0600366E RID: 13934 RVA: 0x000F84D8 File Offset: 0x000F66D8
		public unsafe int NetworkemissionRate
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_get_NetworkemissionRate_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110737, XrefRangeEnd = 110740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_set_NetworkemissionRate_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001319 RID: 4889
		// (get) Token: 0x0600366F RID: 13935 RVA: 0x000F8518 File Offset: 0x000F6718
		// (set) Token: 0x06003670 RID: 13936 RVA: 0x000F8554 File Offset: 0x000F6754
		public unsafe int NetworkmaxParticles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_get_NetworkmaxParticles_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110740, XrefRangeEnd = 110743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_set_NetworkmaxParticles_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700131A RID: 4890
		// (get) Token: 0x06003671 RID: 13937 RVA: 0x000F8594 File Offset: 0x000F6794
		// (set) Token: 0x06003672 RID: 13938 RVA: 0x000F85D0 File Offset: 0x000F67D0
		public unsafe float Networkgravity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_get_Networkgravity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110743, XrefRangeEnd = 110746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_set_Networkgravity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700131B RID: 4891
		// (get) Token: 0x06003673 RID: 13939 RVA: 0x000F8610 File Offset: 0x000F6810
		// (set) Token: 0x06003674 RID: 13940 RVA: 0x000F8650 File Offset: 0x000F6850
		public unsafe ParticleSimulationSpace NetworksimulationSpace
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_get_NetworksimulationSpace_Public_get_ParticleSimulationSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ParticleSimulationSpace>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110746, XrefRangeEnd = 110749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_set_NetworksimulationSpace_Public_set_Void_ParticleSimulationSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700131C RID: 4892
		// (get) Token: 0x06003675 RID: 13941 RVA: 0x000F8694 File Offset: 0x000F6894
		// (set) Token: 0x06003676 RID: 13942 RVA: 0x000F86D4 File Offset: 0x000F68D4
		public unsafe NumberRange NetworkstartRotation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_get_NetworkstartRotation_Public_get_NumberRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NumberRange>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110749, XrefRangeEnd = 110752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_set_NetworkstartRotation_Public_set_Void_NumberRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700131D RID: 4893
		// (get) Token: 0x06003677 RID: 13943 RVA: 0x000F8718 File Offset: 0x000F6918
		// (set) Token: 0x06003678 RID: 13944 RVA: 0x000F8758 File Offset: 0x000F6958
		public unsafe NumberRange NetworkangularVelocity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_get_NetworkangularVelocity_Public_get_NumberRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NumberRange>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110752, XrefRangeEnd = 110755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_set_NetworkangularVelocity_Public_set_Void_NumberRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700131E RID: 4894
		// (get) Token: 0x06003679 RID: 13945 RVA: 0x000F879C File Offset: 0x000F699C
		// (set) Token: 0x0600367A RID: 13946 RVA: 0x000F87D8 File Offset: 0x000F69D8
		public unsafe bool Networkautoplay
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_get_Networkautoplay_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110755, XrefRangeEnd = 110758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_set_Networkautoplay_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700131F RID: 4895
		// (get) Token: 0x0600367B RID: 13947 RVA: 0x000F8818 File Offset: 0x000F6A18
		// (set) Token: 0x0600367C RID: 13948 RVA: 0x000F8854 File Offset: 0x000F6A54
		public unsafe bool Networkloop
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_get_Networkloop_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110758, XrefRangeEnd = 110761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_set_Networkloop_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001320 RID: 4896
		// (get) Token: 0x0600367D RID: 13949 RVA: 0x000F8894 File Offset: 0x000F6A94
		// (set) Token: 0x0600367E RID: 13950 RVA: 0x000F88D0 File Offset: 0x000F6AD0
		public unsafe float Networkduration
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_get_Networkduration_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110761, XrefRangeEnd = 110764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_set_Networkduration_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001321 RID: 4897
		// (get) Token: 0x0600367F RID: 13951 RVA: 0x000F8910 File Offset: 0x000F6B10
		// (set) Token: 0x06003680 RID: 13952 RVA: 0x000F8950 File Offset: 0x000F6B50
		public unsafe ParticleShape Networkshape
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_get_Networkshape_Public_get_ParticleShape_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ParticleShape>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110764, XrefRangeEnd = 110767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_set_Networkshape_Public_set_Void_ParticleShape_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001322 RID: 4898
		// (get) Token: 0x06003681 RID: 13953 RVA: 0x000F8994 File Offset: 0x000F6B94
		// (set) Token: 0x06003682 RID: 13954 RVA: 0x000F89D0 File Offset: 0x000F6BD0
		public unsafe float NetworkshapeRadius
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_get_NetworkshapeRadius_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110767, XrefRangeEnd = 110770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_set_NetworkshapeRadius_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001323 RID: 4899
		// (get) Token: 0x06003683 RID: 13955 RVA: 0x000F8A10 File Offset: 0x000F6C10
		// (set) Token: 0x06003684 RID: 13956 RVA: 0x000F8A4C File Offset: 0x000F6C4C
		public unsafe float NetworkshapeAngle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_get_NetworkshapeAngle_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110770, XrefRangeEnd = 110773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_set_NetworkshapeAngle_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17001324 RID: 4900
		// (get) Token: 0x06003685 RID: 13957 RVA: 0x000F8A8C File Offset: 0x000F6C8C
		// (set) Token: 0x06003686 RID: 13958 RVA: 0x000F8ACC File Offset: 0x000F6CCC
		public unsafe Vector3 NetworkshapeScale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_get_NetworkshapeScale_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110773, XrefRangeEnd = 110776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: In]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_set_NetworkshapeScale_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06003687 RID: 13959 RVA: 0x000F8B10 File Offset: 0x000F6D10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110776, XrefRangeEnd = 110923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Particles()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Particles>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003688 RID: 13960 RVA: 0x000F8B4C File Offset: 0x000F6D4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110923, XrefRangeEnd = 110936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Particles.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003689 RID: 13961 RVA: 0x000F8B88 File Offset: 0x000F6D88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110936, XrefRangeEnd = 110940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnHide()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Particles.NativeMethodInfoPtr_OnHide_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600368A RID: 13962 RVA: 0x000F8BC4 File Offset: 0x000F6DC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110940, XrefRangeEnd = 110942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnShow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Particles.NativeMethodInfoPtr_OnShow_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600368B RID: 13963 RVA: 0x000F8C00 File Offset: 0x000F6E00
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 110958, RefRangeEnd = 110962, XrefRangeStart = 110942, XrefRangeEnd = 110958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetImage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_GetImage_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600368C RID: 13964 RVA: 0x000F8C34 File Offset: 0x000F6E34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 110978, RefRangeEnd = 110979, XrefRangeStart = 110962, XrefRangeEnd = 110978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_Play_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600368D RID: 13965 RVA: 0x000F8C68 File Offset: 0x000F6E68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 110995, RefRangeEnd = 110996, XrefRangeStart = 110979, XrefRangeEnd = 110995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_Pause_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600368E RID: 13966 RVA: 0x000F8C9C File Offset: 0x000F6E9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 111012, RefRangeEnd = 111013, XrefRangeStart = 110996, XrefRangeEnd = 111012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_Stop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600368F RID: 13967 RVA: 0x000F8CD0 File Offset: 0x000F6ED0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 111029, RefRangeEnd = 111030, XrefRangeStart = 111013, XrefRangeEnd = 111029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003690 RID: 13968 RVA: 0x000F8D04 File Offset: 0x000F6F04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 111047, RefRangeEnd = 111048, XrefRangeStart = 111030, XrefRangeEnd = 111047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Emit(int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_Emit_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003691 RID: 13969 RVA: 0x000F8D44 File Offset: 0x000F6F44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 111065, RefRangeEnd = 111066, XrefRangeStart = 111048, XrefRangeEnd = 111065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Simulate(float time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_Simulate_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003692 RID: 13970 RVA: 0x000F8D84 File Offset: 0x000F6F84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111066, XrefRangeEnd = 111086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcPlay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_RpcPlay_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003693 RID: 13971 RVA: 0x000F8DB8 File Offset: 0x000F6FB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111086, XrefRangeEnd = 111106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcPause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_RpcPause_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003694 RID: 13972 RVA: 0x000F8DEC File Offset: 0x000F6FEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111106, XrefRangeEnd = 111126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcStop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_RpcStop_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003695 RID: 13973 RVA: 0x000F8E20 File Offset: 0x000F7020
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111126, XrefRangeEnd = 111146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcClear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_RpcClear_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003696 RID: 13974 RVA: 0x000F8E54 File Offset: 0x000F7054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111146, XrefRangeEnd = 111167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcEmit(int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_RpcEmit_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003697 RID: 13975 RVA: 0x000F8E94 File Offset: 0x000F7094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111167, XrefRangeEnd = 111188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcSimulate(float time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_RpcSimulate_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003698 RID: 13976 RVA: 0x000F8ED4 File Offset: 0x000F70D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111188, XrefRangeEnd = 111214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CopyProperties(Instance clone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clone);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Particles.NativeMethodInfoPtr_CopyProperties_Protected_Virtual_Void_Instance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003699 RID: 13977 RVA: 0x000F8F24 File Offset: 0x000F7124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111214, XrefRangeEnd = 111216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnImageIDChanged(string oldID, string newID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(oldID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(newID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_OnImageIDChanged_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600369A RID: 13978 RVA: 0x000F8F78 File Offset: 0x000F7178
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111216, XrefRangeEnd = 111218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnImageTypeChanged(ImageType oldType, ImageType newType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(oldType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_OnImageTypeChanged_Private_Void_ImageType_ImageType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600369B RID: 13979 RVA: 0x000F8FCC File Offset: 0x000F71CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111218, XrefRangeEnd = 111220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnColorChanged(ColorRange oldColor, ColorRange newColor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(oldColor);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newColor);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_OnColorChanged_Private_Void_ColorRange_ColorRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600369C RID: 13980 RVA: 0x000F9020 File Offset: 0x000F7220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111220, XrefRangeEnd = 111222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnColorModeChanged(ParticleColorMode oldColorMode, ParticleColorMode newColorMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(oldColorMode);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newColorMode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_OnColorModeChanged_Private_Void_ParticleColorMode_ParticleColorMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600369D RID: 13981 RVA: 0x000F9074 File Offset: 0x000F7274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111222, XrefRangeEnd = 111224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnLifetimeChanged(NumberRange oldLifetime, NumberRange newLifetime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(oldLifetime);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newLifetime);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_OnLifetimeChanged_Private_Void_NumberRange_NumberRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600369E RID: 13982 RVA: 0x000F90C8 File Offset: 0x000F72C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111224, XrefRangeEnd = 111226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSizeOverLifetimeChanged(NumberRange oldSizeOverLifetime, NumberRange newSizeOverLifetime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(oldSizeOverLifetime);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newSizeOverLifetime);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_OnSizeOverLifetimeChanged_Private_Void_NumberRange_NumberRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600369F RID: 13983 RVA: 0x000F911C File Offset: 0x000F731C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111226, XrefRangeEnd = 111228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSpeedChanged(NumberRange oldSpeed, NumberRange newSpeed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(oldSpeed);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newSpeed);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_OnSpeedChanged_Private_Void_NumberRange_NumberRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036A0 RID: 13984 RVA: 0x000F9170 File Offset: 0x000F7370
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111228, XrefRangeEnd = 111230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEmissionRateChanged(int oldEmissionRate, int newEmissionRate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref oldEmissionRate;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newEmissionRate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_OnEmissionRateChanged_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036A1 RID: 13985 RVA: 0x000F91BC File Offset: 0x000F73BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111230, XrefRangeEnd = 111232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMaxParticlesChanged(int oldMaxParticles, int newMaxParticles)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref oldMaxParticles;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newMaxParticles;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_OnMaxParticlesChanged_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036A2 RID: 13986 RVA: 0x000F9208 File Offset: 0x000F7408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111232, XrefRangeEnd = 111234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGravityChanged(float oldGravity, float newGravity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref oldGravity;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newGravity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_OnGravityChanged_Private_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036A3 RID: 13987 RVA: 0x000F9254 File Offset: 0x000F7454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111234, XrefRangeEnd = 111236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSimulationSpaceChanged(ParticleSimulationSpace oldSimulationSpace, ParticleSimulationSpace newSimulationSpace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(oldSimulationSpace);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newSimulationSpace);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_OnSimulationSpaceChanged_Private_Void_ParticleSimulationSpace_ParticleSimulationSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036A4 RID: 13988 RVA: 0x000F92A8 File Offset: 0x000F74A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111236, XrefRangeEnd = 111238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnStartRotationChanged(NumberRange oldStartRotation, NumberRange newStartRotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(oldStartRotation);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newStartRotation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_OnStartRotationChanged_Private_Void_NumberRange_NumberRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036A5 RID: 13989 RVA: 0x000F92FC File Offset: 0x000F74FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111238, XrefRangeEnd = 111240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnAngularVelocityChanged(NumberRange oldAngularVelocity, NumberRange newAngularVelocity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(oldAngularVelocity);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newAngularVelocity);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_OnAngularVelocityChanged_Private_Void_NumberRange_NumberRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036A6 RID: 13990 RVA: 0x000F9350 File Offset: 0x000F7550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111240, XrefRangeEnd = 111242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnAutoplayChanged(bool oldVal, bool newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref oldVal;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newVal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_OnAutoplayChanged_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036A7 RID: 13991 RVA: 0x000F939C File Offset: 0x000F759C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111242, XrefRangeEnd = 111244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnLoopChanged(bool oldLoop, bool newLoop)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref oldLoop;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newLoop;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_OnLoopChanged_Private_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036A8 RID: 13992 RVA: 0x000F93E8 File Offset: 0x000F75E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111244, XrefRangeEnd = 111246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDurationChanged(float oldDuration, float newDuration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref oldDuration;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newDuration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_OnDurationChanged_Private_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036A9 RID: 13993 RVA: 0x000F9434 File Offset: 0x000F7634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111246, XrefRangeEnd = 111248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnShapeChanged(ParticleShape oldShape, ParticleShape newShape)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(oldShape);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newShape);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_OnShapeChanged_Private_Void_ParticleShape_ParticleShape_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036AA RID: 13994 RVA: 0x000F9488 File Offset: 0x000F7688
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111248, XrefRangeEnd = 111250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnShapeRadiusChanged(float oldRadius, float newRadius)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref oldRadius;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newRadius;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_OnShapeRadiusChanged_Private_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036AB RID: 13995 RVA: 0x000F94D4 File Offset: 0x000F76D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111250, XrefRangeEnd = 111252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnShapeAngleChanged(float oldAngle, float newAngle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref oldAngle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newAngle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_OnShapeAngleChanged_Private_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036AC RID: 13996 RVA: 0x000F9520 File Offset: 0x000F7720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111252, XrefRangeEnd = 111254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnShapeScaleChanged(Vector3 oldScale, Vector3 newScale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(oldScale);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newScale);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_OnShapeScaleChanged_Private_Void_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036AD RID: 13997 RVA: 0x000F9574 File Offset: 0x000F7774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111254, XrefRangeEnd = 111264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _GetImage_b__98_0(ImageCacheKey key, ImageCacheEntry entry)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(entry);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr__GetImage_b__98_0_Private_Void_ImageCacheKey_ImageCacheEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036AE RID: 13998 RVA: 0x000F95C8 File Offset: 0x000F77C8
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 20124, RefRangeEnd = 20136, XrefRangeStart = 20124, XrefRangeEnd = 20136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Weaved()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Particles.NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060036AF RID: 13999 RVA: 0x000F9610 File Offset: 0x000F7810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111264, XrefRangeEnd = 111281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcPlay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_UserCode_RpcPlay_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036B0 RID: 14000 RVA: 0x000F9644 File Offset: 0x000F7844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111281, XrefRangeEnd = 111306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RpcPlay(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_InvokeUserCode_RpcPlay_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036B1 RID: 14001 RVA: 0x000F96A0 File Offset: 0x000F78A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111306, XrefRangeEnd = 111323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcPause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_UserCode_RpcPause_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036B2 RID: 14002 RVA: 0x000F96D4 File Offset: 0x000F78D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111323, XrefRangeEnd = 111348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RpcPause(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_InvokeUserCode_RpcPause_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036B3 RID: 14003 RVA: 0x000F9730 File Offset: 0x000F7930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111348, XrefRangeEnd = 111365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcStop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_UserCode_RpcStop_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036B4 RID: 14004 RVA: 0x000F9764 File Offset: 0x000F7964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111365, XrefRangeEnd = 111390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RpcStop(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_InvokeUserCode_RpcStop_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036B5 RID: 14005 RVA: 0x000F97C0 File Offset: 0x000F79C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111390, XrefRangeEnd = 111407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcClear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_UserCode_RpcClear_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036B6 RID: 14006 RVA: 0x000F97F4 File Offset: 0x000F79F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111407, XrefRangeEnd = 111432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RpcClear(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_InvokeUserCode_RpcClear_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036B7 RID: 14007 RVA: 0x000F9850 File Offset: 0x000F7A50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111432, XrefRangeEnd = 111450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcEmit__Int32(int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_UserCode_RpcEmit__Int32_Protected_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060036B8 RID: 14008 RVA: 0x000F9890 File Offset: 0x000F7A90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111450, XrefRangeEnd = 111477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RpcEmit__Int32(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_InvokeUserCode_RpcEmit__Int32_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036B9 RID: 14009 RVA: 0x000F98EC File Offset: 0x000F7AEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111477, XrefRangeEnd = 111495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UserCode_RpcSimulate__Single(float time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_UserCode_RpcSimulate__Single_Protected_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060036BA RID: 14010 RVA: 0x000F992C File Offset: 0x000F7B2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111495, XrefRangeEnd = 111522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeUserCode_RpcSimulate__Single(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Particles.NativeMethodInfoPtr_InvokeUserCode_RpcSimulate__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0, 0, (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036BB RID: 14011 RVA: 0x000F9988 File Offset: 0x000F7B88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111522, XrefRangeEnd = 111564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Particles.NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036BC RID: 14012 RVA: 0x000F99E4 File Offset: 0x000F7BE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111564, XrefRangeEnd = 111695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Particles.NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036BD RID: 14013 RVA: 0x00015414 File Offset: 0x00013614
		public Particles(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170012CC RID: 4812
		// (get) Token: 0x060036BE RID: 14014 RVA: 0x000F9A40 File Offset: 0x000F7C40
		// (set) Token: 0x060036BF RID: 14015 RVA: 0x0001541D File Offset: 0x0001361D
		public unsafe ParticleSystem particles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr_particles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr_particles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012CD RID: 4813
		// (get) Token: 0x060036C0 RID: 14016 RVA: 0x000F9A70 File Offset: 0x000F7C70
		// (set) Token: 0x060036C1 RID: 14017 RVA: 0x0001543C File Offset: 0x0001363C
		public unsafe string imageID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr_imageID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr_imageID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170012CE RID: 4814
		// (get) Token: 0x060036C2 RID: 14018 RVA: 0x000F9A98 File Offset: 0x000F7C98
		// (set) Token: 0x060036C3 RID: 14019 RVA: 0x0001545B File Offset: 0x0001365B
		public unsafe ImageType imageType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr_imageType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ImageType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr_imageType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012CF RID: 4815
		// (get) Token: 0x060036C4 RID: 14020 RVA: 0x000F9AC8 File Offset: 0x000F7CC8
		// (set) Token: 0x060036C5 RID: 14021 RVA: 0x0001547A File Offset: 0x0001367A
		public unsafe ColorRange color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr_color);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorRange>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr_color), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012D0 RID: 4816
		// (get) Token: 0x060036C6 RID: 14022 RVA: 0x000F9AF8 File Offset: 0x000F7CF8
		// (set) Token: 0x060036C7 RID: 14023 RVA: 0x00015499 File Offset: 0x00013699
		public unsafe ParticleColorMode colorMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr_colorMode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleColorMode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr_colorMode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012D1 RID: 4817
		// (get) Token: 0x060036C8 RID: 14024 RVA: 0x000F9B28 File Offset: 0x000F7D28
		// (set) Token: 0x060036C9 RID: 14025 RVA: 0x000154B8 File Offset: 0x000136B8
		public unsafe NumberRange lifetime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr_lifetime);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NumberRange>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr_lifetime), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012D2 RID: 4818
		// (get) Token: 0x060036CA RID: 14026 RVA: 0x000F9B58 File Offset: 0x000F7D58
		// (set) Token: 0x060036CB RID: 14027 RVA: 0x000154D7 File Offset: 0x000136D7
		public unsafe NumberRange sizeOverLifetime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr_sizeOverLifetime);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NumberRange>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr_sizeOverLifetime), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012D3 RID: 4819
		// (get) Token: 0x060036CC RID: 14028 RVA: 0x000F9B88 File Offset: 0x000F7D88
		// (set) Token: 0x060036CD RID: 14029 RVA: 0x000154F6 File Offset: 0x000136F6
		public unsafe NumberRange speed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr_speed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NumberRange>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr_speed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012D4 RID: 4820
		// (get) Token: 0x060036CE RID: 14030 RVA: 0x000F9BB8 File Offset: 0x000F7DB8
		// (set) Token: 0x060036CF RID: 14031 RVA: 0x00015515 File Offset: 0x00013715
		public unsafe int emissionRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr_emissionRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr_emissionRate)) = value;
			}
		}

		// Token: 0x170012D5 RID: 4821
		// (get) Token: 0x060036D0 RID: 14032 RVA: 0x000F9BE0 File Offset: 0x000F7DE0
		// (set) Token: 0x060036D1 RID: 14033 RVA: 0x00015530 File Offset: 0x00013730
		public unsafe int maxParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr_maxParticles);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr_maxParticles)) = value;
			}
		}

		// Token: 0x170012D6 RID: 4822
		// (get) Token: 0x060036D2 RID: 14034 RVA: 0x000F9C08 File Offset: 0x000F7E08
		// (set) Token: 0x060036D3 RID: 14035 RVA: 0x0001554B File Offset: 0x0001374B
		public unsafe float gravity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr_gravity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr_gravity)) = value;
			}
		}

		// Token: 0x170012D7 RID: 4823
		// (get) Token: 0x060036D4 RID: 14036 RVA: 0x000F9C30 File Offset: 0x000F7E30
		// (set) Token: 0x060036D5 RID: 14037 RVA: 0x00015566 File Offset: 0x00013766
		public unsafe ParticleSimulationSpace simulationSpace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr_simulationSpace);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSimulationSpace>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr_simulationSpace), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012D8 RID: 4824
		// (get) Token: 0x060036D6 RID: 14038 RVA: 0x000F9C60 File Offset: 0x000F7E60
		// (set) Token: 0x060036D7 RID: 14039 RVA: 0x00015585 File Offset: 0x00013785
		public unsafe NumberRange startRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr_startRotation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NumberRange>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr_startRotation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012D9 RID: 4825
		// (get) Token: 0x060036D8 RID: 14040 RVA: 0x000F9C90 File Offset: 0x000F7E90
		// (set) Token: 0x060036D9 RID: 14041 RVA: 0x000155A4 File Offset: 0x000137A4
		public unsafe NumberRange angularVelocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr_angularVelocity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NumberRange>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr_angularVelocity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012DA RID: 4826
		// (get) Token: 0x060036DA RID: 14042 RVA: 0x000F9CC0 File Offset: 0x000F7EC0
		// (set) Token: 0x060036DB RID: 14043 RVA: 0x000155C3 File Offset: 0x000137C3
		public unsafe bool autoplay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr_autoplay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr_autoplay)) = value;
			}
		}

		// Token: 0x170012DB RID: 4827
		// (get) Token: 0x060036DC RID: 14044 RVA: 0x000F9CE8 File Offset: 0x000F7EE8
		// (set) Token: 0x060036DD RID: 14045 RVA: 0x000155DE File Offset: 0x000137DE
		public unsafe bool loop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr_loop);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr_loop)) = value;
			}
		}

		// Token: 0x170012DC RID: 4828
		// (get) Token: 0x060036DE RID: 14046 RVA: 0x000F9D10 File Offset: 0x000F7F10
		// (set) Token: 0x060036DF RID: 14047 RVA: 0x000155F9 File Offset: 0x000137F9
		public unsafe float duration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr_duration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr_duration)) = value;
			}
		}

		// Token: 0x170012DD RID: 4829
		// (get) Token: 0x060036E0 RID: 14048 RVA: 0x000F9D38 File Offset: 0x000F7F38
		// (set) Token: 0x060036E1 RID: 14049 RVA: 0x00015614 File Offset: 0x00013814
		public unsafe ParticleShape shape
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr_shape);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleShape>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr_shape), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012DE RID: 4830
		// (get) Token: 0x060036E2 RID: 14050 RVA: 0x000F9D68 File Offset: 0x000F7F68
		// (set) Token: 0x060036E3 RID: 14051 RVA: 0x00015633 File Offset: 0x00013833
		public unsafe float shapeRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr_shapeRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr_shapeRadius)) = value;
			}
		}

		// Token: 0x170012DF RID: 4831
		// (get) Token: 0x060036E4 RID: 14052 RVA: 0x000F9D90 File Offset: 0x000F7F90
		// (set) Token: 0x060036E5 RID: 14053 RVA: 0x0001564E File Offset: 0x0001384E
		public unsafe float shapeAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr_shapeAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr_shapeAngle)) = value;
			}
		}

		// Token: 0x170012E0 RID: 4832
		// (get) Token: 0x060036E6 RID: 14054 RVA: 0x000F9DB8 File Offset: 0x000F7FB8
		// (set) Token: 0x060036E7 RID: 14055 RVA: 0x00015669 File Offset: 0x00013869
		public unsafe Vector3 shapeScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr_shapeScale);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector3>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr_shapeScale), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012E1 RID: 4833
		// (get) Token: 0x060036E8 RID: 14056 RVA: 0x000F9DE8 File Offset: 0x000F7FE8
		// (set) Token: 0x060036E9 RID: 14057 RVA: 0x00015688 File Offset: 0x00013888
		public unsafe ImageCacheKey lastCacheKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr_lastCacheKey);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ImageCacheKey>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr_lastCacheKey), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012E2 RID: 4834
		// (get) Token: 0x060036EA RID: 14058 RVA: 0x000F9E18 File Offset: 0x000F8018
		// (set) Token: 0x060036EB RID: 14059 RVA: 0x000156A7 File Offset: 0x000138A7
		public unsafe ImageCacheEntry currentEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr_currentEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ImageCacheEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr_currentEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012E3 RID: 4835
		// (get) Token: 0x060036EC RID: 14060 RVA: 0x000F9E48 File Offset: 0x000F8048
		// (set) Token: 0x060036ED RID: 14061 RVA: 0x000156C6 File Offset: 0x000138C6
		public unsafe Action<string, string> _Mirror_SyncVarHookDelegate_imageID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_imageID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_imageID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012E4 RID: 4836
		// (get) Token: 0x060036EE RID: 14062 RVA: 0x000F9E78 File Offset: 0x000F8078
		// (set) Token: 0x060036EF RID: 14063 RVA: 0x000156E5 File Offset: 0x000138E5
		public unsafe Action<ImageType, ImageType> _Mirror_SyncVarHookDelegate_imageType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_imageType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ImageType, ImageType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_imageType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012E5 RID: 4837
		// (get) Token: 0x060036F0 RID: 14064 RVA: 0x000F9EA8 File Offset: 0x000F80A8
		// (set) Token: 0x060036F1 RID: 14065 RVA: 0x00015704 File Offset: 0x00013904
		public unsafe Action<ColorRange, ColorRange> _Mirror_SyncVarHookDelegate_color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_color);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ColorRange, ColorRange>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_color), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012E6 RID: 4838
		// (get) Token: 0x060036F2 RID: 14066 RVA: 0x000F9ED8 File Offset: 0x000F80D8
		// (set) Token: 0x060036F3 RID: 14067 RVA: 0x00015723 File Offset: 0x00013923
		public unsafe Action<ParticleColorMode, ParticleColorMode> _Mirror_SyncVarHookDelegate_colorMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_colorMode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ParticleColorMode, ParticleColorMode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_colorMode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012E7 RID: 4839
		// (get) Token: 0x060036F4 RID: 14068 RVA: 0x000F9F08 File Offset: 0x000F8108
		// (set) Token: 0x060036F5 RID: 14069 RVA: 0x00015742 File Offset: 0x00013942
		public unsafe Action<NumberRange, NumberRange> _Mirror_SyncVarHookDelegate_lifetime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_lifetime);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<NumberRange, NumberRange>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_lifetime), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012E8 RID: 4840
		// (get) Token: 0x060036F6 RID: 14070 RVA: 0x000F9F38 File Offset: 0x000F8138
		// (set) Token: 0x060036F7 RID: 14071 RVA: 0x00015761 File Offset: 0x00013961
		public unsafe Action<NumberRange, NumberRange> _Mirror_SyncVarHookDelegate_sizeOverLifetime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_sizeOverLifetime);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<NumberRange, NumberRange>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_sizeOverLifetime), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012E9 RID: 4841
		// (get) Token: 0x060036F8 RID: 14072 RVA: 0x000F9F68 File Offset: 0x000F8168
		// (set) Token: 0x060036F9 RID: 14073 RVA: 0x00015780 File Offset: 0x00013980
		public unsafe Action<NumberRange, NumberRange> _Mirror_SyncVarHookDelegate_speed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_speed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<NumberRange, NumberRange>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_speed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012EA RID: 4842
		// (get) Token: 0x060036FA RID: 14074 RVA: 0x000F9F98 File Offset: 0x000F8198
		// (set) Token: 0x060036FB RID: 14075 RVA: 0x0001579F File Offset: 0x0001399F
		public unsafe Action<int, int> _Mirror_SyncVarHookDelegate_emissionRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_emissionRate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_emissionRate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012EB RID: 4843
		// (get) Token: 0x060036FC RID: 14076 RVA: 0x000F9FC8 File Offset: 0x000F81C8
		// (set) Token: 0x060036FD RID: 14077 RVA: 0x000157BE File Offset: 0x000139BE
		public unsafe Action<int, int> _Mirror_SyncVarHookDelegate_maxParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_maxParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_maxParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012EC RID: 4844
		// (get) Token: 0x060036FE RID: 14078 RVA: 0x000F9FF8 File Offset: 0x000F81F8
		// (set) Token: 0x060036FF RID: 14079 RVA: 0x000157DD File Offset: 0x000139DD
		public unsafe Action<float, float> _Mirror_SyncVarHookDelegate_gravity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_gravity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_gravity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012ED RID: 4845
		// (get) Token: 0x06003700 RID: 14080 RVA: 0x000FA028 File Offset: 0x000F8228
		// (set) Token: 0x06003701 RID: 14081 RVA: 0x000157FC File Offset: 0x000139FC
		public unsafe Action<ParticleSimulationSpace, ParticleSimulationSpace> _Mirror_SyncVarHookDelegate_simulationSpace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_simulationSpace);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ParticleSimulationSpace, ParticleSimulationSpace>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_simulationSpace), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012EE RID: 4846
		// (get) Token: 0x06003702 RID: 14082 RVA: 0x000FA058 File Offset: 0x000F8258
		// (set) Token: 0x06003703 RID: 14083 RVA: 0x0001581B File Offset: 0x00013A1B
		public unsafe Action<NumberRange, NumberRange> _Mirror_SyncVarHookDelegate_startRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_startRotation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<NumberRange, NumberRange>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_startRotation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012EF RID: 4847
		// (get) Token: 0x06003704 RID: 14084 RVA: 0x000FA088 File Offset: 0x000F8288
		// (set) Token: 0x06003705 RID: 14085 RVA: 0x0001583A File Offset: 0x00013A3A
		public unsafe Action<NumberRange, NumberRange> _Mirror_SyncVarHookDelegate_angularVelocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_angularVelocity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<NumberRange, NumberRange>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_angularVelocity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012F0 RID: 4848
		// (get) Token: 0x06003706 RID: 14086 RVA: 0x000FA0B8 File Offset: 0x000F82B8
		// (set) Token: 0x06003707 RID: 14087 RVA: 0x00015859 File Offset: 0x00013A59
		public unsafe Action<bool, bool> _Mirror_SyncVarHookDelegate_autoplay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_autoplay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_autoplay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012F1 RID: 4849
		// (get) Token: 0x06003708 RID: 14088 RVA: 0x000FA0E8 File Offset: 0x000F82E8
		// (set) Token: 0x06003709 RID: 14089 RVA: 0x00015878 File Offset: 0x00013A78
		public unsafe Action<bool, bool> _Mirror_SyncVarHookDelegate_loop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_loop);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_loop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012F2 RID: 4850
		// (get) Token: 0x0600370A RID: 14090 RVA: 0x000FA118 File Offset: 0x000F8318
		// (set) Token: 0x0600370B RID: 14091 RVA: 0x00015897 File Offset: 0x00013A97
		public unsafe Action<float, float> _Mirror_SyncVarHookDelegate_duration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_duration);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_duration), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012F3 RID: 4851
		// (get) Token: 0x0600370C RID: 14092 RVA: 0x000FA148 File Offset: 0x000F8348
		// (set) Token: 0x0600370D RID: 14093 RVA: 0x000158B6 File Offset: 0x00013AB6
		public unsafe Action<ParticleShape, ParticleShape> _Mirror_SyncVarHookDelegate_shape
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_shape);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ParticleShape, ParticleShape>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_shape), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012F4 RID: 4852
		// (get) Token: 0x0600370E RID: 14094 RVA: 0x000FA178 File Offset: 0x000F8378
		// (set) Token: 0x0600370F RID: 14095 RVA: 0x000158D5 File Offset: 0x00013AD5
		public unsafe Action<float, float> _Mirror_SyncVarHookDelegate_shapeRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_shapeRadius);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_shapeRadius), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012F5 RID: 4853
		// (get) Token: 0x06003710 RID: 14096 RVA: 0x000FA1A8 File Offset: 0x000F83A8
		// (set) Token: 0x06003711 RID: 14097 RVA: 0x000158F4 File Offset: 0x00013AF4
		public unsafe Action<float, float> _Mirror_SyncVarHookDelegate_shapeAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_shapeAngle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_shapeAngle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012F6 RID: 4854
		// (get) Token: 0x06003712 RID: 14098 RVA: 0x000FA1D8 File Offset: 0x000F83D8
		// (set) Token: 0x06003713 RID: 14099 RVA: 0x00015913 File Offset: 0x00013B13
		public unsafe Action<Vector3, Vector3> _Mirror_SyncVarHookDelegate_shapeScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_shapeScale);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Vector3, Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Particles.NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_shapeScale), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040029D4 RID: 10708
		private static readonly IntPtr NativeFieldInfoPtr_particles;

		// Token: 0x040029D5 RID: 10709
		private static readonly IntPtr NativeFieldInfoPtr_imageID;

		// Token: 0x040029D6 RID: 10710
		private static readonly IntPtr NativeFieldInfoPtr_imageType;

		// Token: 0x040029D7 RID: 10711
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x040029D8 RID: 10712
		private static readonly IntPtr NativeFieldInfoPtr_colorMode;

		// Token: 0x040029D9 RID: 10713
		private static readonly IntPtr NativeFieldInfoPtr_lifetime;

		// Token: 0x040029DA RID: 10714
		private static readonly IntPtr NativeFieldInfoPtr_sizeOverLifetime;

		// Token: 0x040029DB RID: 10715
		private static readonly IntPtr NativeFieldInfoPtr_speed;

		// Token: 0x040029DC RID: 10716
		private static readonly IntPtr NativeFieldInfoPtr_emissionRate;

		// Token: 0x040029DD RID: 10717
		private static readonly IntPtr NativeFieldInfoPtr_maxParticles;

		// Token: 0x040029DE RID: 10718
		private static readonly IntPtr NativeFieldInfoPtr_gravity;

		// Token: 0x040029DF RID: 10719
		private static readonly IntPtr NativeFieldInfoPtr_simulationSpace;

		// Token: 0x040029E0 RID: 10720
		private static readonly IntPtr NativeFieldInfoPtr_startRotation;

		// Token: 0x040029E1 RID: 10721
		private static readonly IntPtr NativeFieldInfoPtr_angularVelocity;

		// Token: 0x040029E2 RID: 10722
		private static readonly IntPtr NativeFieldInfoPtr_autoplay;

		// Token: 0x040029E3 RID: 10723
		private static readonly IntPtr NativeFieldInfoPtr_loop;

		// Token: 0x040029E4 RID: 10724
		private static readonly IntPtr NativeFieldInfoPtr_duration;

		// Token: 0x040029E5 RID: 10725
		private static readonly IntPtr NativeFieldInfoPtr_shape;

		// Token: 0x040029E6 RID: 10726
		private static readonly IntPtr NativeFieldInfoPtr_shapeRadius;

		// Token: 0x040029E7 RID: 10727
		private static readonly IntPtr NativeFieldInfoPtr_shapeAngle;

		// Token: 0x040029E8 RID: 10728
		private static readonly IntPtr NativeFieldInfoPtr_shapeScale;

		// Token: 0x040029E9 RID: 10729
		private static readonly IntPtr NativeFieldInfoPtr_lastCacheKey;

		// Token: 0x040029EA RID: 10730
		private static readonly IntPtr NativeFieldInfoPtr_currentEntry;

		// Token: 0x040029EB RID: 10731
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_imageID;

		// Token: 0x040029EC RID: 10732
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_imageType;

		// Token: 0x040029ED RID: 10733
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_color;

		// Token: 0x040029EE RID: 10734
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_colorMode;

		// Token: 0x040029EF RID: 10735
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_lifetime;

		// Token: 0x040029F0 RID: 10736
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_sizeOverLifetime;

		// Token: 0x040029F1 RID: 10737
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_speed;

		// Token: 0x040029F2 RID: 10738
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_emissionRate;

		// Token: 0x040029F3 RID: 10739
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_maxParticles;

		// Token: 0x040029F4 RID: 10740
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_gravity;

		// Token: 0x040029F5 RID: 10741
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_simulationSpace;

		// Token: 0x040029F6 RID: 10742
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_startRotation;

		// Token: 0x040029F7 RID: 10743
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_angularVelocity;

		// Token: 0x040029F8 RID: 10744
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_autoplay;

		// Token: 0x040029F9 RID: 10745
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_loop;

		// Token: 0x040029FA RID: 10746
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_duration;

		// Token: 0x040029FB RID: 10747
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_shape;

		// Token: 0x040029FC RID: 10748
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_shapeRadius;

		// Token: 0x040029FD RID: 10749
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_shapeAngle;

		// Token: 0x040029FE RID: 10750
		private static readonly IntPtr NativeFieldInfoPtr__Mirror_SyncVarHookDelegate_shapeScale;

		// Token: 0x040029FF RID: 10751
		private static readonly IntPtr NativeMethodInfoPtr_get_ImageID_Public_get_String_0;

		// Token: 0x04002A00 RID: 10752
		private static readonly IntPtr NativeMethodInfoPtr_set_ImageID_Public_set_Void_String_0;

		// Token: 0x04002A01 RID: 10753
		private static readonly IntPtr NativeMethodInfoPtr_get_ImageType_Public_get_ImageType_0;

		// Token: 0x04002A02 RID: 10754
		private static readonly IntPtr NativeMethodInfoPtr_set_ImageType_Public_set_Void_ImageType_0;

		// Token: 0x04002A03 RID: 10755
		private static readonly IntPtr NativeMethodInfoPtr_get_Color_Public_get_ColorRange_0;

		// Token: 0x04002A04 RID: 10756
		private static readonly IntPtr NativeMethodInfoPtr_set_Color_Public_set_Void_ColorRange_0;

		// Token: 0x04002A05 RID: 10757
		private static readonly IntPtr NativeMethodInfoPtr_get_ColorMode_Public_get_ParticleColorMode_0;

		// Token: 0x04002A06 RID: 10758
		private static readonly IntPtr NativeMethodInfoPtr_set_ColorMode_Public_set_Void_ParticleColorMode_0;

		// Token: 0x04002A07 RID: 10759
		private static readonly IntPtr NativeMethodInfoPtr_get_Lifetime_Public_get_NumberRange_0;

		// Token: 0x04002A08 RID: 10760
		private static readonly IntPtr NativeMethodInfoPtr_set_Lifetime_Public_set_Void_NumberRange_0;

		// Token: 0x04002A09 RID: 10761
		private static readonly IntPtr NativeMethodInfoPtr_get_SizeOverLifetime_Public_get_NumberRange_0;

		// Token: 0x04002A0A RID: 10762
		private static readonly IntPtr NativeMethodInfoPtr_set_SizeOverLifetime_Public_set_Void_NumberRange_0;

		// Token: 0x04002A0B RID: 10763
		private static readonly IntPtr NativeMethodInfoPtr_get_Speed_Public_get_NumberRange_0;

		// Token: 0x04002A0C RID: 10764
		private static readonly IntPtr NativeMethodInfoPtr_set_Speed_Public_set_Void_NumberRange_0;

		// Token: 0x04002A0D RID: 10765
		private static readonly IntPtr NativeMethodInfoPtr_get_EmissionRate_Public_get_Int32_0;

		// Token: 0x04002A0E RID: 10766
		private static readonly IntPtr NativeMethodInfoPtr_set_EmissionRate_Public_set_Void_Int32_0;

		// Token: 0x04002A0F RID: 10767
		private static readonly IntPtr NativeMethodInfoPtr_get_MaxParticles_Public_get_Int32_0;

		// Token: 0x04002A10 RID: 10768
		private static readonly IntPtr NativeMethodInfoPtr_set_MaxParticles_Public_set_Void_Int32_0;

		// Token: 0x04002A11 RID: 10769
		private static readonly IntPtr NativeMethodInfoPtr_get_Gravity_Public_get_Single_0;

		// Token: 0x04002A12 RID: 10770
		private static readonly IntPtr NativeMethodInfoPtr_set_Gravity_Public_set_Void_Single_0;

		// Token: 0x04002A13 RID: 10771
		private static readonly IntPtr NativeMethodInfoPtr_get_SimulationSpace_Public_get_ParticleSimulationSpace_0;

		// Token: 0x04002A14 RID: 10772
		private static readonly IntPtr NativeMethodInfoPtr_set_SimulationSpace_Public_set_Void_ParticleSimulationSpace_0;

		// Token: 0x04002A15 RID: 10773
		private static readonly IntPtr NativeMethodInfoPtr_get_StartRotation_Public_get_NumberRange_0;

		// Token: 0x04002A16 RID: 10774
		private static readonly IntPtr NativeMethodInfoPtr_set_StartRotation_Public_set_Void_NumberRange_0;

		// Token: 0x04002A17 RID: 10775
		private static readonly IntPtr NativeMethodInfoPtr_get_AngularVelocity_Public_get_NumberRange_0;

		// Token: 0x04002A18 RID: 10776
		private static readonly IntPtr NativeMethodInfoPtr_set_AngularVelocity_Public_set_Void_NumberRange_0;

		// Token: 0x04002A19 RID: 10777
		private static readonly IntPtr NativeMethodInfoPtr_get_Autoplay_Public_get_Boolean_0;

		// Token: 0x04002A1A RID: 10778
		private static readonly IntPtr NativeMethodInfoPtr_set_Autoplay_Public_set_Void_Boolean_0;

		// Token: 0x04002A1B RID: 10779
		private static readonly IntPtr NativeMethodInfoPtr_get_Loop_Public_get_Boolean_0;

		// Token: 0x04002A1C RID: 10780
		private static readonly IntPtr NativeMethodInfoPtr_set_Loop_Public_set_Void_Boolean_0;

		// Token: 0x04002A1D RID: 10781
		private static readonly IntPtr NativeMethodInfoPtr_get_Duration_Public_get_Single_0;

		// Token: 0x04002A1E RID: 10782
		private static readonly IntPtr NativeMethodInfoPtr_set_Duration_Public_set_Void_Single_0;

		// Token: 0x04002A1F RID: 10783
		private static readonly IntPtr NativeMethodInfoPtr_get_Shape_Public_get_ParticleShape_0;

		// Token: 0x04002A20 RID: 10784
		private static readonly IntPtr NativeMethodInfoPtr_set_Shape_Public_set_Void_ParticleShape_0;

		// Token: 0x04002A21 RID: 10785
		private static readonly IntPtr NativeMethodInfoPtr_get_ShapeRadius_Public_get_Single_0;

		// Token: 0x04002A22 RID: 10786
		private static readonly IntPtr NativeMethodInfoPtr_set_ShapeRadius_Public_set_Void_Single_0;

		// Token: 0x04002A23 RID: 10787
		private static readonly IntPtr NativeMethodInfoPtr_get_ShapeAngle_Public_get_Single_0;

		// Token: 0x04002A24 RID: 10788
		private static readonly IntPtr NativeMethodInfoPtr_set_ShapeAngle_Public_set_Void_Single_0;

		// Token: 0x04002A25 RID: 10789
		private static readonly IntPtr NativeMethodInfoPtr_get_ShapeScale_Public_get_Vector3_0;

		// Token: 0x04002A26 RID: 10790
		private static readonly IntPtr NativeMethodInfoPtr_set_ShapeScale_Public_set_Void_Vector3_0;

		// Token: 0x04002A27 RID: 10791
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0;

		// Token: 0x04002A28 RID: 10792
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPaused_Public_get_Boolean_0;

		// Token: 0x04002A29 RID: 10793
		private static readonly IntPtr NativeMethodInfoPtr_get_IsStopped_Public_get_Boolean_0;

		// Token: 0x04002A2A RID: 10794
		private static readonly IntPtr NativeMethodInfoPtr_get_ParticleCount_Public_get_Int32_0;

		// Token: 0x04002A2B RID: 10795
		private static readonly IntPtr NativeMethodInfoPtr_get_Time_Public_get_Single_0;

		// Token: 0x04002A2C RID: 10796
		private static readonly IntPtr NativeMethodInfoPtr_get_TotalTime_Public_get_Single_0;

		// Token: 0x04002A2D RID: 10797
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkimageID_Public_get_String_0;

		// Token: 0x04002A2E RID: 10798
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkimageID_Public_set_Void_String_0;

		// Token: 0x04002A2F RID: 10799
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkimageType_Public_get_ImageType_0;

		// Token: 0x04002A30 RID: 10800
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkimageType_Public_set_Void_ImageType_0;

		// Token: 0x04002A31 RID: 10801
		private static readonly IntPtr NativeMethodInfoPtr_get_Networkcolor_Public_get_ColorRange_0;

		// Token: 0x04002A32 RID: 10802
		private static readonly IntPtr NativeMethodInfoPtr_set_Networkcolor_Public_set_Void_ColorRange_0;

		// Token: 0x04002A33 RID: 10803
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkcolorMode_Public_get_ParticleColorMode_0;

		// Token: 0x04002A34 RID: 10804
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkcolorMode_Public_set_Void_ParticleColorMode_0;

		// Token: 0x04002A35 RID: 10805
		private static readonly IntPtr NativeMethodInfoPtr_get_Networklifetime_Public_get_NumberRange_0;

		// Token: 0x04002A36 RID: 10806
		private static readonly IntPtr NativeMethodInfoPtr_set_Networklifetime_Public_set_Void_NumberRange_0;

		// Token: 0x04002A37 RID: 10807
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworksizeOverLifetime_Public_get_NumberRange_0;

		// Token: 0x04002A38 RID: 10808
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworksizeOverLifetime_Public_set_Void_NumberRange_0;

		// Token: 0x04002A39 RID: 10809
		private static readonly IntPtr NativeMethodInfoPtr_get_Networkspeed_Public_get_NumberRange_0;

		// Token: 0x04002A3A RID: 10810
		private static readonly IntPtr NativeMethodInfoPtr_set_Networkspeed_Public_set_Void_NumberRange_0;

		// Token: 0x04002A3B RID: 10811
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkemissionRate_Public_get_Int32_0;

		// Token: 0x04002A3C RID: 10812
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkemissionRate_Public_set_Void_Int32_0;

		// Token: 0x04002A3D RID: 10813
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkmaxParticles_Public_get_Int32_0;

		// Token: 0x04002A3E RID: 10814
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkmaxParticles_Public_set_Void_Int32_0;

		// Token: 0x04002A3F RID: 10815
		private static readonly IntPtr NativeMethodInfoPtr_get_Networkgravity_Public_get_Single_0;

		// Token: 0x04002A40 RID: 10816
		private static readonly IntPtr NativeMethodInfoPtr_set_Networkgravity_Public_set_Void_Single_0;

		// Token: 0x04002A41 RID: 10817
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworksimulationSpace_Public_get_ParticleSimulationSpace_0;

		// Token: 0x04002A42 RID: 10818
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworksimulationSpace_Public_set_Void_ParticleSimulationSpace_0;

		// Token: 0x04002A43 RID: 10819
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkstartRotation_Public_get_NumberRange_0;

		// Token: 0x04002A44 RID: 10820
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkstartRotation_Public_set_Void_NumberRange_0;

		// Token: 0x04002A45 RID: 10821
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkangularVelocity_Public_get_NumberRange_0;

		// Token: 0x04002A46 RID: 10822
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkangularVelocity_Public_set_Void_NumberRange_0;

		// Token: 0x04002A47 RID: 10823
		private static readonly IntPtr NativeMethodInfoPtr_get_Networkautoplay_Public_get_Boolean_0;

		// Token: 0x04002A48 RID: 10824
		private static readonly IntPtr NativeMethodInfoPtr_set_Networkautoplay_Public_set_Void_Boolean_0;

		// Token: 0x04002A49 RID: 10825
		private static readonly IntPtr NativeMethodInfoPtr_get_Networkloop_Public_get_Boolean_0;

		// Token: 0x04002A4A RID: 10826
		private static readonly IntPtr NativeMethodInfoPtr_set_Networkloop_Public_set_Void_Boolean_0;

		// Token: 0x04002A4B RID: 10827
		private static readonly IntPtr NativeMethodInfoPtr_get_Networkduration_Public_get_Single_0;

		// Token: 0x04002A4C RID: 10828
		private static readonly IntPtr NativeMethodInfoPtr_set_Networkduration_Public_set_Void_Single_0;

		// Token: 0x04002A4D RID: 10829
		private static readonly IntPtr NativeMethodInfoPtr_get_Networkshape_Public_get_ParticleShape_0;

		// Token: 0x04002A4E RID: 10830
		private static readonly IntPtr NativeMethodInfoPtr_set_Networkshape_Public_set_Void_ParticleShape_0;

		// Token: 0x04002A4F RID: 10831
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkshapeRadius_Public_get_Single_0;

		// Token: 0x04002A50 RID: 10832
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkshapeRadius_Public_set_Void_Single_0;

		// Token: 0x04002A51 RID: 10833
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkshapeAngle_Public_get_Single_0;

		// Token: 0x04002A52 RID: 10834
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkshapeAngle_Public_set_Void_Single_0;

		// Token: 0x04002A53 RID: 10835
		private static readonly IntPtr NativeMethodInfoPtr_get_NetworkshapeScale_Public_get_Vector3_0;

		// Token: 0x04002A54 RID: 10836
		private static readonly IntPtr NativeMethodInfoPtr_set_NetworkshapeScale_Public_set_Void_Vector3_0;

		// Token: 0x04002A55 RID: 10837
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002A56 RID: 10838
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04002A57 RID: 10839
		private static readonly IntPtr NativeMethodInfoPtr_OnHide_Protected_Virtual_Void_0;

		// Token: 0x04002A58 RID: 10840
		private static readonly IntPtr NativeMethodInfoPtr_OnShow_Protected_Virtual_Void_0;

		// Token: 0x04002A59 RID: 10841
		private static readonly IntPtr NativeMethodInfoPtr_GetImage_Private_Void_0;

		// Token: 0x04002A5A RID: 10842
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Void_0;

		// Token: 0x04002A5B RID: 10843
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Public_Void_0;

		// Token: 0x04002A5C RID: 10844
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;

		// Token: 0x04002A5D RID: 10845
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04002A5E RID: 10846
		private static readonly IntPtr NativeMethodInfoPtr_Emit_Public_Void_Int32_0;

		// Token: 0x04002A5F RID: 10847
		private static readonly IntPtr NativeMethodInfoPtr_Simulate_Public_Void_Single_0;

		// Token: 0x04002A60 RID: 10848
		private static readonly IntPtr NativeMethodInfoPtr_RpcPlay_Private_Void_0;

		// Token: 0x04002A61 RID: 10849
		private static readonly IntPtr NativeMethodInfoPtr_RpcPause_Private_Void_0;

		// Token: 0x04002A62 RID: 10850
		private static readonly IntPtr NativeMethodInfoPtr_RpcStop_Private_Void_0;

		// Token: 0x04002A63 RID: 10851
		private static readonly IntPtr NativeMethodInfoPtr_RpcClear_Private_Void_0;

		// Token: 0x04002A64 RID: 10852
		private static readonly IntPtr NativeMethodInfoPtr_RpcEmit_Private_Void_Int32_0;

		// Token: 0x04002A65 RID: 10853
		private static readonly IntPtr NativeMethodInfoPtr_RpcSimulate_Private_Void_Single_0;

		// Token: 0x04002A66 RID: 10854
		private static readonly IntPtr NativeMethodInfoPtr_CopyProperties_Protected_Virtual_Void_Instance_0;

		// Token: 0x04002A67 RID: 10855
		private static readonly IntPtr NativeMethodInfoPtr_OnImageIDChanged_Private_Void_String_String_0;

		// Token: 0x04002A68 RID: 10856
		private static readonly IntPtr NativeMethodInfoPtr_OnImageTypeChanged_Private_Void_ImageType_ImageType_0;

		// Token: 0x04002A69 RID: 10857
		private static readonly IntPtr NativeMethodInfoPtr_OnColorChanged_Private_Void_ColorRange_ColorRange_0;

		// Token: 0x04002A6A RID: 10858
		private static readonly IntPtr NativeMethodInfoPtr_OnColorModeChanged_Private_Void_ParticleColorMode_ParticleColorMode_0;

		// Token: 0x04002A6B RID: 10859
		private static readonly IntPtr NativeMethodInfoPtr_OnLifetimeChanged_Private_Void_NumberRange_NumberRange_0;

		// Token: 0x04002A6C RID: 10860
		private static readonly IntPtr NativeMethodInfoPtr_OnSizeOverLifetimeChanged_Private_Void_NumberRange_NumberRange_0;

		// Token: 0x04002A6D RID: 10861
		private static readonly IntPtr NativeMethodInfoPtr_OnSpeedChanged_Private_Void_NumberRange_NumberRange_0;

		// Token: 0x04002A6E RID: 10862
		private static readonly IntPtr NativeMethodInfoPtr_OnEmissionRateChanged_Private_Void_Int32_Int32_0;

		// Token: 0x04002A6F RID: 10863
		private static readonly IntPtr NativeMethodInfoPtr_OnMaxParticlesChanged_Private_Void_Int32_Int32_0;

		// Token: 0x04002A70 RID: 10864
		private static readonly IntPtr NativeMethodInfoPtr_OnGravityChanged_Private_Void_Single_Single_0;

		// Token: 0x04002A71 RID: 10865
		private static readonly IntPtr NativeMethodInfoPtr_OnSimulationSpaceChanged_Private_Void_ParticleSimulationSpace_ParticleSimulationSpace_0;

		// Token: 0x04002A72 RID: 10866
		private static readonly IntPtr NativeMethodInfoPtr_OnStartRotationChanged_Private_Void_NumberRange_NumberRange_0;

		// Token: 0x04002A73 RID: 10867
		private static readonly IntPtr NativeMethodInfoPtr_OnAngularVelocityChanged_Private_Void_NumberRange_NumberRange_0;

		// Token: 0x04002A74 RID: 10868
		private static readonly IntPtr NativeMethodInfoPtr_OnAutoplayChanged_Private_Void_Boolean_Boolean_0;

		// Token: 0x04002A75 RID: 10869
		private static readonly IntPtr NativeMethodInfoPtr_OnLoopChanged_Private_Void_Boolean_Boolean_0;

		// Token: 0x04002A76 RID: 10870
		private static readonly IntPtr NativeMethodInfoPtr_OnDurationChanged_Private_Void_Single_Single_0;

		// Token: 0x04002A77 RID: 10871
		private static readonly IntPtr NativeMethodInfoPtr_OnShapeChanged_Private_Void_ParticleShape_ParticleShape_0;

		// Token: 0x04002A78 RID: 10872
		private static readonly IntPtr NativeMethodInfoPtr_OnShapeRadiusChanged_Private_Void_Single_Single_0;

		// Token: 0x04002A79 RID: 10873
		private static readonly IntPtr NativeMethodInfoPtr_OnShapeAngleChanged_Private_Void_Single_Single_0;

		// Token: 0x04002A7A RID: 10874
		private static readonly IntPtr NativeMethodInfoPtr_OnShapeScaleChanged_Private_Void_Vector3_Vector3_0;

		// Token: 0x04002A7B RID: 10875
		private static readonly IntPtr NativeMethodInfoPtr__GetImage_b__98_0_Private_Void_ImageCacheKey_ImageCacheEntry_0;

		// Token: 0x04002A7C RID: 10876
		private static readonly IntPtr NativeMethodInfoPtr_Weaved_Public_Virtual_Boolean_0;

		// Token: 0x04002A7D RID: 10877
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcPlay_Protected_Void_0;

		// Token: 0x04002A7E RID: 10878
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcPlay_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002A7F RID: 10879
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcPause_Protected_Void_0;

		// Token: 0x04002A80 RID: 10880
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcPause_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002A81 RID: 10881
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcStop_Protected_Void_0;

		// Token: 0x04002A82 RID: 10882
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcStop_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002A83 RID: 10883
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcClear_Protected_Void_0;

		// Token: 0x04002A84 RID: 10884
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcClear_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002A85 RID: 10885
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcEmit__Int32_Protected_Void_Int32_0;

		// Token: 0x04002A86 RID: 10886
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcEmit__Int32_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002A87 RID: 10887
		private static readonly IntPtr NativeMethodInfoPtr_UserCode_RpcSimulate__Single_Protected_Void_Single_0;

		// Token: 0x04002A88 RID: 10888
		private static readonly IntPtr NativeMethodInfoPtr_InvokeUserCode_RpcSimulate__Single_Protected_Static_Void_NetworkBehaviour_NetworkReader_NetworkConnectionToClient_0;

		// Token: 0x04002A89 RID: 10889
		private static readonly IntPtr NativeMethodInfoPtr_SerializeSyncVars_Public_Virtual_Void_NetworkWriter_Boolean_0;

		// Token: 0x04002A8A RID: 10890
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeSyncVars_Public_Virtual_Void_NetworkReader_Boolean_0;
	}
}
