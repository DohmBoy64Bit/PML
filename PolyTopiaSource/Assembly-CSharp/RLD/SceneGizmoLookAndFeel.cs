using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace RLD
{
	// Token: 0x0200007F RID: 127
	[Serializable]
	public class SceneGizmoLookAndFeel : Settings
	{
		// Token: 0x0600092D RID: 2349 RVA: 0x00044C88 File Offset: 0x00042E88
		// Note: this type is marked as 'beforefieldinit'.
		static SceneGizmoLookAndFeel()
		{
			Il2CppClassPointerStore<SceneGizmoLookAndFeel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "SceneGizmoLookAndFeel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneGizmoLookAndFeel>.NativeClassPtr);
			SceneGizmoLookAndFeel.NativeFieldInfoPtr__baseScreenSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneGizmoLookAndFeel>.NativeClassPtr, "_baseScreenSize");
			SceneGizmoLookAndFeel.NativeFieldInfoPtr__invBaseScreenSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneGizmoLookAndFeel>.NativeClassPtr, "_invBaseScreenSize");
			SceneGizmoLookAndFeel.NativeFieldInfoPtr__midCapLookAndFeel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneGizmoLookAndFeel>.NativeClassPtr, "_midCapLookAndFeel");
			SceneGizmoLookAndFeel.NativeFieldInfoPtr__axesCapsLookAndFeel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneGizmoLookAndFeel>.NativeClassPtr, "_axesCapsLookAndFeel");
			SceneGizmoLookAndFeel.NativeFieldInfoPtr__screenCorner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneGizmoLookAndFeel>.NativeClassPtr, "_screenCorner");
			SceneGizmoLookAndFeel.NativeFieldInfoPtr__screenOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneGizmoLookAndFeel>.NativeClassPtr, "_screenOffset");
			SceneGizmoLookAndFeel.NativeFieldInfoPtr__screenSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneGizmoLookAndFeel>.NativeClassPtr, "_screenSize");
			SceneGizmoLookAndFeel.NativeFieldInfoPtr__axesLabelTint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneGizmoLookAndFeel>.NativeClassPtr, "_axesLabelTint");
			SceneGizmoLookAndFeel.NativeFieldInfoPtr__camPrjSwitchLabelTint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneGizmoLookAndFeel>.NativeClassPtr, "_camPrjSwitchLabelTint");
			SceneGizmoLookAndFeel.NativeFieldInfoPtr__isCamPrjSwitchLabelVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneGizmoLookAndFeel>.NativeClassPtr, "_isCamPrjSwitchLabelVisible");
			SceneGizmoLookAndFeel.NativeMethodInfoPtr_get_AxisCapLookAndFeel_Private_get_GizmoCap3DLookAndFeel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoLookAndFeel>.NativeClassPtr, 100664674);
			SceneGizmoLookAndFeel.NativeMethodInfoPtr_get_ScreenCorner_Public_get_SceneGizmoScreenCorner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoLookAndFeel>.NativeClassPtr, 100664675);
			SceneGizmoLookAndFeel.NativeMethodInfoPtr_set_ScreenCorner_Public_set_Void_SceneGizmoScreenCorner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoLookAndFeel>.NativeClassPtr, 100664676);
			SceneGizmoLookAndFeel.NativeMethodInfoPtr_get_ScreenOffset_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoLookAndFeel>.NativeClassPtr, 100664677);
			SceneGizmoLookAndFeel.NativeMethodInfoPtr_set_ScreenOffset_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoLookAndFeel>.NativeClassPtr, 100664678);
			SceneGizmoLookAndFeel.NativeMethodInfoPtr_get_ScreenSize_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoLookAndFeel>.NativeClassPtr, 100664679);
			SceneGizmoLookAndFeel.NativeMethodInfoPtr_set_ScreenSize_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoLookAndFeel>.NativeClassPtr, 100664680);
			SceneGizmoLookAndFeel.NativeMethodInfoPtr_get_AxesLabelTint_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoLookAndFeel>.NativeClassPtr, 100664681);
			SceneGizmoLookAndFeel.NativeMethodInfoPtr_set_AxesLabelTint_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoLookAndFeel>.NativeClassPtr, 100664682);
			SceneGizmoLookAndFeel.NativeMethodInfoPtr_get_CamPrjSwitchLabelTint_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoLookAndFeel>.NativeClassPtr, 100664683);
			SceneGizmoLookAndFeel.NativeMethodInfoPtr_set_CamPrjSwitchLabelTint_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoLookAndFeel>.NativeClassPtr, 100664684);
			SceneGizmoLookAndFeel.NativeMethodInfoPtr_get_IsCamPrjSwitchLabelVisible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoLookAndFeel>.NativeClassPtr, 100664685);
			SceneGizmoLookAndFeel.NativeMethodInfoPtr_set_IsCamPrjSwitchLabelVisible_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoLookAndFeel>.NativeClassPtr, 100664686);
			SceneGizmoLookAndFeel.NativeMethodInfoPtr_get_CamPerspModeLabelTexture_Public_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoLookAndFeel>.NativeClassPtr, 100664687);
			SceneGizmoLookAndFeel.NativeMethodInfoPtr_get_CamOrthoModeLabelTexture_Public_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoLookAndFeel>.NativeClassPtr, 100664688);
			SceneGizmoLookAndFeel.NativeMethodInfoPtr_get_HoveredColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoLookAndFeel>.NativeClassPtr, 100664689);
			SceneGizmoLookAndFeel.NativeMethodInfoPtr_get_AxesCapType_Public_get_GizmoCap3DType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoLookAndFeel>.NativeClassPtr, 100664690);
			SceneGizmoLookAndFeel.NativeMethodInfoPtr_get_MidCapType_Public_get_GizmoCap3DType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoLookAndFeel>.NativeClassPtr, 100664691);
			SceneGizmoLookAndFeel.NativeMethodInfoPtr_get_MidCapBoxSize_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoLookAndFeel>.NativeClassPtr, 100664692);
			SceneGizmoLookAndFeel.NativeMethodInfoPtr_get_MidCapSphereRadius_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoLookAndFeel>.NativeClassPtr, 100664693);
			SceneGizmoLookAndFeel.NativeMethodInfoPtr_get_AxisConeHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoLookAndFeel>.NativeClassPtr, 100664694);
			SceneGizmoLookAndFeel.NativeMethodInfoPtr_get_AxisConeRadius_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoLookAndFeel>.NativeClassPtr, 100664695);
			SceneGizmoLookAndFeel.NativeMethodInfoPtr_get_AxisPyramidWidth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoLookAndFeel>.NativeClassPtr, 100664696);
			SceneGizmoLookAndFeel.NativeMethodInfoPtr_get_AxisPyramidHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoLookAndFeel>.NativeClassPtr, 100664697);
			SceneGizmoLookAndFeel.NativeMethodInfoPtr_get_AxisPyramidDepth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoLookAndFeel>.NativeClassPtr, 100664698);
			SceneGizmoLookAndFeel.NativeMethodInfoPtr_get_AxisLabelScreenSize_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoLookAndFeel>.NativeClassPtr, 100664699);
			SceneGizmoLookAndFeel.NativeMethodInfoPtr_get_AxisCamAlignFadeOutThreshold_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoLookAndFeel>.NativeClassPtr, 100664700);
			SceneGizmoLookAndFeel.NativeMethodInfoPtr_get_AxisCamAlignFadeOutDuration_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoLookAndFeel>.NativeClassPtr, 100664701);
			SceneGizmoLookAndFeel.NativeMethodInfoPtr_get_AxisCamAlignFadeOutAlpha_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoLookAndFeel>.NativeClassPtr, 100664702);
			SceneGizmoLookAndFeel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoLookAndFeel>.NativeClassPtr, 100664703);
			SceneGizmoLookAndFeel.NativeMethodInfoPtr_SetMidCapColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoLookAndFeel>.NativeClassPtr, 100664704);
			SceneGizmoLookAndFeel.NativeMethodInfoPtr_SetAxisCapColor_Public_Void_Color_Int32_AxisSign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoLookAndFeel>.NativeClassPtr, 100664705);
			SceneGizmoLookAndFeel.NativeMethodInfoPtr_GetAxisCapColor_Public_Color_Int32_AxisSign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoLookAndFeel>.NativeClassPtr, 100664706);
			SceneGizmoLookAndFeel.NativeMethodInfoPtr_SetHoveredColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoLookAndFeel>.NativeClassPtr, 100664707);
			SceneGizmoLookAndFeel.NativeMethodInfoPtr_SetMidCapFillMode_Public_Void_GizmoFillMode3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoLookAndFeel>.NativeClassPtr, 100664708);
			SceneGizmoLookAndFeel.NativeMethodInfoPtr_SetAxisCapFillMode_Public_Void_GizmoFillMode3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoLookAndFeel>.NativeClassPtr, 100664709);
			SceneGizmoLookAndFeel.NativeMethodInfoPtr_SetMidCapShadeMode_Public_Void_GizmoShadeMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoLookAndFeel>.NativeClassPtr, 100664710);
			SceneGizmoLookAndFeel.NativeMethodInfoPtr_SetAxisCapShadeMode_Public_Void_GizmoShadeMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoLookAndFeel>.NativeClassPtr, 100664711);
			SceneGizmoLookAndFeel.NativeMethodInfoPtr_GetAllowedMidCapTypes_Public_List_1_Enum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoLookAndFeel>.NativeClassPtr, 100664712);
			SceneGizmoLookAndFeel.NativeMethodInfoPtr_GetAllowedAxesCapTypes_Public_List_1_Enum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoLookAndFeel>.NativeClassPtr, 100664713);
			SceneGizmoLookAndFeel.NativeMethodInfoPtr_IsMidCapTypeAllowed_Public_Boolean_GizmoCap3DType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoLookAndFeel>.NativeClassPtr, 100664714);
			SceneGizmoLookAndFeel.NativeMethodInfoPtr_SetMidCapType_Public_Void_GizmoCap3DType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoLookAndFeel>.NativeClassPtr, 100664715);
			SceneGizmoLookAndFeel.NativeMethodInfoPtr_IsAxisCapTypeAllowed_Public_Boolean_GizmoCap3DType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoLookAndFeel>.NativeClassPtr, 100664716);
			SceneGizmoLookAndFeel.NativeMethodInfoPtr_SetAxisCapType_Public_Void_GizmoCap3DType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoLookAndFeel>.NativeClassPtr, 100664717);
			SceneGizmoLookAndFeel.NativeMethodInfoPtr_GetAxesLabelWorldSize_Public_Single_Camera_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoLookAndFeel>.NativeClassPtr, 100664718);
			SceneGizmoLookAndFeel.NativeMethodInfoPtr_CalculateMaxPrjSwitchLabelRectSize_Public_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoLookAndFeel>.NativeClassPtr, 100664719);
			SceneGizmoLookAndFeel.NativeMethodInfoPtr_ConnectMidCapLookAndFeel_Public_Void_GizmoCap3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoLookAndFeel>.NativeClassPtr, 100664720);
			SceneGizmoLookAndFeel.NativeMethodInfoPtr_ConnectAxisCapLookAndFeel_Public_Void_GizmoCap3D_Int32_AxisSign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoLookAndFeel>.NativeClassPtr, 100664721);
			SceneGizmoLookAndFeel.NativeMethodInfoPtr_GetAxisCapLookAndFeel_Private_GizmoCap3DLookAndFeel_Int32_AxisSign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoLookAndFeel>.NativeClassPtr, 100664722);
			SceneGizmoLookAndFeel.NativeMethodInfoPtr_OnScreenSizeChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneGizmoLookAndFeel>.NativeClassPtr, 100664723);
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x0600092E RID: 2350 RVA: 0x00045168 File Offset: 0x00043368
		public unsafe GizmoCap3DLookAndFeel AxisCapLookAndFeel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmoLookAndFeel.NativeMethodInfoPtr_get_AxisCapLookAndFeel_Private_get_GizmoCap3DLookAndFeel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoCap3DLookAndFeel>(intPtr3) : null;
			}
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x0600092F RID: 2351 RVA: 0x000451A8 File Offset: 0x000433A8
		// (set) Token: 0x06000930 RID: 2352 RVA: 0x000451E8 File Offset: 0x000433E8
		public unsafe SceneGizmoScreenCorner ScreenCorner
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmoLookAndFeel.NativeMethodInfoPtr_get_ScreenCorner_Public_get_SceneGizmoScreenCorner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SceneGizmoScreenCorner>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmoLookAndFeel.NativeMethodInfoPtr_set_ScreenCorner_Public_set_Void_SceneGizmoScreenCorner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000931 RID: 2353 RVA: 0x0004522C File Offset: 0x0004342C
		// (set) Token: 0x06000932 RID: 2354 RVA: 0x0004526C File Offset: 0x0004346C
		public unsafe Vector2 ScreenOffset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmoLookAndFeel.NativeMethodInfoPtr_get_ScreenOffset_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmoLookAndFeel.NativeMethodInfoPtr_set_ScreenOffset_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000933 RID: 2355 RVA: 0x000452B0 File Offset: 0x000434B0
		// (set) Token: 0x06000934 RID: 2356 RVA: 0x000452EC File Offset: 0x000434EC
		public unsafe float ScreenSize
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 57861, RefRangeEnd = 57864, XrefRangeStart = 57861, XrefRangeEnd = 57864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmoLookAndFeel.NativeMethodInfoPtr_get_ScreenSize_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64378, XrefRangeEnd = 64379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmoLookAndFeel.NativeMethodInfoPtr_set_ScreenSize_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000935 RID: 2357 RVA: 0x0004532C File Offset: 0x0004352C
		// (set) Token: 0x06000936 RID: 2358 RVA: 0x0004536C File Offset: 0x0004356C
		public unsafe Color AxesLabelTint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmoLookAndFeel.NativeMethodInfoPtr_get_AxesLabelTint_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmoLookAndFeel.NativeMethodInfoPtr_set_AxesLabelTint_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06000937 RID: 2359 RVA: 0x000453B0 File Offset: 0x000435B0
		// (set) Token: 0x06000938 RID: 2360 RVA: 0x000453F0 File Offset: 0x000435F0
		public unsafe Color CamPrjSwitchLabelTint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmoLookAndFeel.NativeMethodInfoPtr_get_CamPrjSwitchLabelTint_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmoLookAndFeel.NativeMethodInfoPtr_set_CamPrjSwitchLabelTint_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06000939 RID: 2361 RVA: 0x00045434 File Offset: 0x00043634
		// (set) Token: 0x0600093A RID: 2362 RVA: 0x00045470 File Offset: 0x00043670
		public unsafe bool IsCamPrjSwitchLabelVisible
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmoLookAndFeel.NativeMethodInfoPtr_get_IsCamPrjSwitchLabelVisible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmoLookAndFeel.NativeMethodInfoPtr_set_IsCamPrjSwitchLabelVisible_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x0600093B RID: 2363 RVA: 0x000454B0 File Offset: 0x000436B0
		public unsafe Texture2D CamPerspModeLabelTexture
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 64387, RefRangeEnd = 64389, XrefRangeStart = 64379, XrefRangeEnd = 64387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmoLookAndFeel.NativeMethodInfoPtr_get_CamPerspModeLabelTexture_Public_get_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x0600093C RID: 2364 RVA: 0x000454F0 File Offset: 0x000436F0
		public unsafe Texture2D CamOrthoModeLabelTexture
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 64397, RefRangeEnd = 64399, XrefRangeStart = 64389, XrefRangeEnd = 64397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmoLookAndFeel.NativeMethodInfoPtr_get_CamOrthoModeLabelTexture_Public_get_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
			}
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x0600093D RID: 2365 RVA: 0x00045530 File Offset: 0x00043730
		public unsafe Color HoveredColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmoLookAndFeel.NativeMethodInfoPtr_get_HoveredColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x0600093E RID: 2366 RVA: 0x00045570 File Offset: 0x00043770
		public unsafe GizmoCap3DType AxesCapType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 64399, RefRangeEnd = 64400, XrefRangeStart = 64399, XrefRangeEnd = 64399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmoLookAndFeel.NativeMethodInfoPtr_get_AxesCapType_Public_get_GizmoCap3DType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoCap3DType>(intPtr3) : null;
			}
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x0600093F RID: 2367 RVA: 0x000455B0 File Offset: 0x000437B0
		public unsafe GizmoCap3DType MidCapType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 64400, RefRangeEnd = 64401, XrefRangeStart = 64400, XrefRangeEnd = 64400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmoLookAndFeel.NativeMethodInfoPtr_get_MidCapType_Public_get_GizmoCap3DType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoCap3DType>(intPtr3) : null;
			}
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06000940 RID: 2368 RVA: 0x000455F0 File Offset: 0x000437F0
		public unsafe float MidCapBoxSize
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 64405, RefRangeEnd = 64409, XrefRangeStart = 64401, XrefRangeEnd = 64405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmoLookAndFeel.NativeMethodInfoPtr_get_MidCapBoxSize_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06000941 RID: 2369 RVA: 0x0004562C File Offset: 0x0004382C
		public unsafe float MidCapSphereRadius
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 64413, RefRangeEnd = 64415, XrefRangeStart = 64409, XrefRangeEnd = 64413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmoLookAndFeel.NativeMethodInfoPtr_get_MidCapSphereRadius_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06000942 RID: 2370 RVA: 0x00045668 File Offset: 0x00043868
		public unsafe float AxisConeHeight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64415, XrefRangeEnd = 64420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmoLookAndFeel.NativeMethodInfoPtr_get_AxisConeHeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06000943 RID: 2371 RVA: 0x000456A4 File Offset: 0x000438A4
		public unsafe float AxisConeRadius
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64420, XrefRangeEnd = 64425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmoLookAndFeel.NativeMethodInfoPtr_get_AxisConeRadius_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06000944 RID: 2372 RVA: 0x000456E0 File Offset: 0x000438E0
		public unsafe float AxisPyramidWidth
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64425, XrefRangeEnd = 64430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmoLookAndFeel.NativeMethodInfoPtr_get_AxisPyramidWidth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06000945 RID: 2373 RVA: 0x0004571C File Offset: 0x0004391C
		public unsafe float AxisPyramidHeight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64430, XrefRangeEnd = 64435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmoLookAndFeel.NativeMethodInfoPtr_get_AxisPyramidHeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06000946 RID: 2374 RVA: 0x00045758 File Offset: 0x00043958
		public unsafe float AxisPyramidDepth
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64435, XrefRangeEnd = 64440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmoLookAndFeel.NativeMethodInfoPtr_get_AxisPyramidDepth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06000947 RID: 2375 RVA: 0x00045794 File Offset: 0x00043994
		public unsafe float AxisLabelScreenSize
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 64444, RefRangeEnd = 64447, XrefRangeStart = 64440, XrefRangeEnd = 64444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmoLookAndFeel.NativeMethodInfoPtr_get_AxisLabelScreenSize_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06000948 RID: 2376 RVA: 0x000457D0 File Offset: 0x000439D0
		public unsafe float AxisCamAlignFadeOutThreshold
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmoLookAndFeel.NativeMethodInfoPtr_get_AxisCamAlignFadeOutThreshold_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06000949 RID: 2377 RVA: 0x0004580C File Offset: 0x00043A0C
		public unsafe float AxisCamAlignFadeOutDuration
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmoLookAndFeel.NativeMethodInfoPtr_get_AxisCamAlignFadeOutDuration_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x0600094A RID: 2378 RVA: 0x00045848 File Offset: 0x00043A48
		public unsafe float AxisCamAlignFadeOutAlpha
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmoLookAndFeel.NativeMethodInfoPtr_get_AxisCamAlignFadeOutAlpha_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x00045884 File Offset: 0x00043A84
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 64479, RefRangeEnd = 64481, XrefRangeStart = 64447, XrefRangeEnd = 64479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SceneGizmoLookAndFeel()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneGizmoLookAndFeel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmoLookAndFeel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x000458C0 File Offset: 0x00043AC0
		[CallerCount(0)]
		public unsafe void SetMidCapColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(color);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmoLookAndFeel.NativeMethodInfoPtr_SetMidCapColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x00045904 File Offset: 0x00043B04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64481, XrefRangeEnd = 64482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAxisCapColor(Color color, int axisIndex, AxisSign axisSign)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(color);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axisIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(axisSign);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmoLookAndFeel.NativeMethodInfoPtr_SetAxisCapColor_Public_Void_Color_Int32_AxisSign_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x00045968 File Offset: 0x00043B68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64482, XrefRangeEnd = 64483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Color GetAxisCapColor(int axisIndex, AxisSign axisSign)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axisIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(axisSign);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmoLookAndFeel.NativeMethodInfoPtr_GetAxisCapColor_Public_Color_Int32_AxisSign_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x000459C8 File Offset: 0x00043BC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64483, XrefRangeEnd = 64484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHoveredColor(Color hoveredColor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hoveredColor);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmoLookAndFeel.NativeMethodInfoPtr_SetHoveredColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x00045A0C File Offset: 0x00043C0C
		[CallerCount(0)]
		public unsafe void SetMidCapFillMode(GizmoFillMode3D fillMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fillMode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmoLookAndFeel.NativeMethodInfoPtr_SetMidCapFillMode_Public_Void_GizmoFillMode3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x00045A50 File Offset: 0x00043C50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64484, XrefRangeEnd = 64485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAxisCapFillMode(GizmoFillMode3D fillMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fillMode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmoLookAndFeel.NativeMethodInfoPtr_SetAxisCapFillMode_Public_Void_GizmoFillMode3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x00045A94 File Offset: 0x00043C94
		[CallerCount(0)]
		public unsafe void SetMidCapShadeMode(GizmoShadeMode shadeMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(shadeMode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmoLookAndFeel.NativeMethodInfoPtr_SetMidCapShadeMode_Public_Void_GizmoShadeMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x00045AD8 File Offset: 0x00043CD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64485, XrefRangeEnd = 64486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAxisCapShadeMode(GizmoShadeMode shadeMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(shadeMode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmoLookAndFeel.NativeMethodInfoPtr_SetAxisCapShadeMode_Public_Void_GizmoShadeMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x00045B1C File Offset: 0x00043D1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64486, XrefRangeEnd = 64504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Enum> GetAllowedMidCapTypes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmoLookAndFeel.NativeMethodInfoPtr_GetAllowedMidCapTypes_Public_List_1_Enum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Enum>>(intPtr3) : null;
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x00045B5C File Offset: 0x00043D5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64504, XrefRangeEnd = 64522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Enum> GetAllowedAxesCapTypes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmoLookAndFeel.NativeMethodInfoPtr_GetAllowedAxesCapTypes_Public_List_1_Enum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Enum>>(intPtr3) : null;
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x00045B9C File Offset: 0x00043D9C
		[CallerCount(0)]
		public unsafe bool IsMidCapTypeAllowed(GizmoCap3DType capType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(capType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmoLookAndFeel.NativeMethodInfoPtr_IsMidCapTypeAllowed_Public_Boolean_GizmoCap3DType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x00045BEC File Offset: 0x00043DEC
		[CallerCount(0)]
		public unsafe void SetMidCapType(GizmoCap3DType capType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(capType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmoLookAndFeel.NativeMethodInfoPtr_SetMidCapType_Public_Void_GizmoCap3DType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x00045C30 File Offset: 0x00043E30
		[CallerCount(0)]
		public unsafe bool IsAxisCapTypeAllowed(GizmoCap3DType capType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(capType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmoLookAndFeel.NativeMethodInfoPtr_IsAxisCapTypeAllowed_Public_Boolean_GizmoCap3DType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x00045C80 File Offset: 0x00043E80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64522, XrefRangeEnd = 64523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAxisCapType(GizmoCap3DType capType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(capType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmoLookAndFeel.NativeMethodInfoPtr_SetAxisCapType_Public_Void_GizmoCap3DType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x00045CC4 File Offset: 0x00043EC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64523, XrefRangeEnd = 64528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetAxesLabelWorldSize(Camera gizmoCam, Vector3 labelWorldPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gizmoCam);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(labelWorldPos);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmoLookAndFeel.NativeMethodInfoPtr_GetAxesLabelWorldSize_Public_Single_Camera_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x00045D24 File Offset: 0x00043F24
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 64556, RefRangeEnd = 64558, XrefRangeStart = 64528, XrefRangeEnd = 64556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 CalculateMaxPrjSwitchLabelRectSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmoLookAndFeel.NativeMethodInfoPtr_CalculateMaxPrjSwitchLabelRectSize_Public_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr3) : null;
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x00045D64 File Offset: 0x00043F64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64558, XrefRangeEnd = 64560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConnectMidCapLookAndFeel(GizmoCap3D midCap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(midCap);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmoLookAndFeel.NativeMethodInfoPtr_ConnectMidCapLookAndFeel_Public_Void_GizmoCap3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600095D RID: 2397 RVA: 0x00045DA8 File Offset: 0x00043FA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64560, XrefRangeEnd = 64564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConnectAxisCapLookAndFeel(GizmoCap3D axisCap, int axisIndex, AxisSign axisSign)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(axisCap);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axisIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(axisSign);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmoLookAndFeel.NativeMethodInfoPtr_ConnectAxisCapLookAndFeel_Public_Void_GizmoCap3D_Int32_AxisSign_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600095E RID: 2398 RVA: 0x00045E0C File Offset: 0x0004400C
		[CallerCount(0)]
		public unsafe GizmoCap3DLookAndFeel GetAxisCapLookAndFeel(int axisIndex, AxisSign axisSign)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axisIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(axisSign);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmoLookAndFeel.NativeMethodInfoPtr_GetAxisCapLookAndFeel_Private_GizmoCap3DLookAndFeel_Int32_AxisSign_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoCap3DLookAndFeel>(intPtr3) : null;
		}

		// Token: 0x0600095F RID: 2399 RVA: 0x00045E6C File Offset: 0x0004406C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 64585, RefRangeEnd = 64587, XrefRangeStart = 64564, XrefRangeEnd = 64585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnScreenSizeChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneGizmoLookAndFeel.NativeMethodInfoPtr_OnScreenSizeChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000960 RID: 2400 RVA: 0x0000523C File Offset: 0x0000343C
		public SceneGizmoLookAndFeel(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000961 RID: 2401 RVA: 0x00045EA0 File Offset: 0x000440A0
		// (set) Token: 0x06000962 RID: 2402 RVA: 0x00005245 File Offset: 0x00003445
		public unsafe static float _baseScreenSize
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(SceneGizmoLookAndFeel.NativeFieldInfoPtr__baseScreenSize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SceneGizmoLookAndFeel.NativeFieldInfoPtr__baseScreenSize, (void*)(&value));
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000963 RID: 2403 RVA: 0x00045EBC File Offset: 0x000440BC
		// (set) Token: 0x06000964 RID: 2404 RVA: 0x00005253 File Offset: 0x00003453
		public unsafe static float _invBaseScreenSize
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(SceneGizmoLookAndFeel.NativeFieldInfoPtr__invBaseScreenSize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SceneGizmoLookAndFeel.NativeFieldInfoPtr__invBaseScreenSize, (void*)(&value));
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000965 RID: 2405 RVA: 0x00045ED8 File Offset: 0x000440D8
		// (set) Token: 0x06000966 RID: 2406 RVA: 0x00005261 File Offset: 0x00003461
		public unsafe GizmoCap3DLookAndFeel _midCapLookAndFeel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneGizmoLookAndFeel.NativeFieldInfoPtr__midCapLookAndFeel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoCap3DLookAndFeel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneGizmoLookAndFeel.NativeFieldInfoPtr__midCapLookAndFeel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06000967 RID: 2407 RVA: 0x00045F08 File Offset: 0x00044108
		// (set) Token: 0x06000968 RID: 2408 RVA: 0x00005280 File Offset: 0x00003480
		public unsafe Il2CppReferenceArray<GizmoCap3DLookAndFeel> _axesCapsLookAndFeel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneGizmoLookAndFeel.NativeFieldInfoPtr__axesCapsLookAndFeel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GizmoCap3DLookAndFeel>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneGizmoLookAndFeel.NativeFieldInfoPtr__axesCapsLookAndFeel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000969 RID: 2409 RVA: 0x00045F38 File Offset: 0x00044138
		// (set) Token: 0x0600096A RID: 2410 RVA: 0x0000529F File Offset: 0x0000349F
		public unsafe SceneGizmoScreenCorner _screenCorner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneGizmoLookAndFeel.NativeFieldInfoPtr__screenCorner);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneGizmoScreenCorner>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneGizmoLookAndFeel.NativeFieldInfoPtr__screenCorner), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x0600096B RID: 2411 RVA: 0x00045F68 File Offset: 0x00044168
		// (set) Token: 0x0600096C RID: 2412 RVA: 0x000052BE File Offset: 0x000034BE
		public unsafe Vector2 _screenOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneGizmoLookAndFeel.NativeFieldInfoPtr__screenOffset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Vector2>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneGizmoLookAndFeel.NativeFieldInfoPtr__screenOffset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x0600096D RID: 2413 RVA: 0x00045F98 File Offset: 0x00044198
		// (set) Token: 0x0600096E RID: 2414 RVA: 0x000052DD File Offset: 0x000034DD
		public unsafe float _screenSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneGizmoLookAndFeel.NativeFieldInfoPtr__screenSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneGizmoLookAndFeel.NativeFieldInfoPtr__screenSize)) = value;
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x0600096F RID: 2415 RVA: 0x00045FC0 File Offset: 0x000441C0
		// (set) Token: 0x06000970 RID: 2416 RVA: 0x000052F8 File Offset: 0x000034F8
		public unsafe Color _axesLabelTint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneGizmoLookAndFeel.NativeFieldInfoPtr__axesLabelTint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneGizmoLookAndFeel.NativeFieldInfoPtr__axesLabelTint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000971 RID: 2417 RVA: 0x00045FF0 File Offset: 0x000441F0
		// (set) Token: 0x06000972 RID: 2418 RVA: 0x00005317 File Offset: 0x00003517
		public unsafe Color _camPrjSwitchLabelTint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneGizmoLookAndFeel.NativeFieldInfoPtr__camPrjSwitchLabelTint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Color>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneGizmoLookAndFeel.NativeFieldInfoPtr__camPrjSwitchLabelTint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06000973 RID: 2419 RVA: 0x00046020 File Offset: 0x00044220
		// (set) Token: 0x06000974 RID: 2420 RVA: 0x00005336 File Offset: 0x00003536
		public unsafe bool _isCamPrjSwitchLabelVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneGizmoLookAndFeel.NativeFieldInfoPtr__isCamPrjSwitchLabelVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneGizmoLookAndFeel.NativeFieldInfoPtr__isCamPrjSwitchLabelVisible)) = value;
			}
		}

		// Token: 0x04000702 RID: 1794
		private static readonly IntPtr NativeFieldInfoPtr__baseScreenSize;

		// Token: 0x04000703 RID: 1795
		private static readonly IntPtr NativeFieldInfoPtr__invBaseScreenSize;

		// Token: 0x04000704 RID: 1796
		private static readonly IntPtr NativeFieldInfoPtr__midCapLookAndFeel;

		// Token: 0x04000705 RID: 1797
		private static readonly IntPtr NativeFieldInfoPtr__axesCapsLookAndFeel;

		// Token: 0x04000706 RID: 1798
		private static readonly IntPtr NativeFieldInfoPtr__screenCorner;

		// Token: 0x04000707 RID: 1799
		private static readonly IntPtr NativeFieldInfoPtr__screenOffset;

		// Token: 0x04000708 RID: 1800
		private static readonly IntPtr NativeFieldInfoPtr__screenSize;

		// Token: 0x04000709 RID: 1801
		private static readonly IntPtr NativeFieldInfoPtr__axesLabelTint;

		// Token: 0x0400070A RID: 1802
		private static readonly IntPtr NativeFieldInfoPtr__camPrjSwitchLabelTint;

		// Token: 0x0400070B RID: 1803
		private static readonly IntPtr NativeFieldInfoPtr__isCamPrjSwitchLabelVisible;

		// Token: 0x0400070C RID: 1804
		private static readonly IntPtr NativeMethodInfoPtr_get_AxisCapLookAndFeel_Private_get_GizmoCap3DLookAndFeel_0;

		// Token: 0x0400070D RID: 1805
		private static readonly IntPtr NativeMethodInfoPtr_get_ScreenCorner_Public_get_SceneGizmoScreenCorner_0;

		// Token: 0x0400070E RID: 1806
		private static readonly IntPtr NativeMethodInfoPtr_set_ScreenCorner_Public_set_Void_SceneGizmoScreenCorner_0;

		// Token: 0x0400070F RID: 1807
		private static readonly IntPtr NativeMethodInfoPtr_get_ScreenOffset_Public_get_Vector2_0;

		// Token: 0x04000710 RID: 1808
		private static readonly IntPtr NativeMethodInfoPtr_set_ScreenOffset_Public_set_Void_Vector2_0;

		// Token: 0x04000711 RID: 1809
		private static readonly IntPtr NativeMethodInfoPtr_get_ScreenSize_Public_get_Single_0;

		// Token: 0x04000712 RID: 1810
		private static readonly IntPtr NativeMethodInfoPtr_set_ScreenSize_Public_set_Void_Single_0;

		// Token: 0x04000713 RID: 1811
		private static readonly IntPtr NativeMethodInfoPtr_get_AxesLabelTint_Public_get_Color_0;

		// Token: 0x04000714 RID: 1812
		private static readonly IntPtr NativeMethodInfoPtr_set_AxesLabelTint_Public_set_Void_Color_0;

		// Token: 0x04000715 RID: 1813
		private static readonly IntPtr NativeMethodInfoPtr_get_CamPrjSwitchLabelTint_Public_get_Color_0;

		// Token: 0x04000716 RID: 1814
		private static readonly IntPtr NativeMethodInfoPtr_set_CamPrjSwitchLabelTint_Public_set_Void_Color_0;

		// Token: 0x04000717 RID: 1815
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCamPrjSwitchLabelVisible_Public_get_Boolean_0;

		// Token: 0x04000718 RID: 1816
		private static readonly IntPtr NativeMethodInfoPtr_set_IsCamPrjSwitchLabelVisible_Public_set_Void_Boolean_0;

		// Token: 0x04000719 RID: 1817
		private static readonly IntPtr NativeMethodInfoPtr_get_CamPerspModeLabelTexture_Public_get_Texture2D_0;

		// Token: 0x0400071A RID: 1818
		private static readonly IntPtr NativeMethodInfoPtr_get_CamOrthoModeLabelTexture_Public_get_Texture2D_0;

		// Token: 0x0400071B RID: 1819
		private static readonly IntPtr NativeMethodInfoPtr_get_HoveredColor_Public_get_Color_0;

		// Token: 0x0400071C RID: 1820
		private static readonly IntPtr NativeMethodInfoPtr_get_AxesCapType_Public_get_GizmoCap3DType_0;

		// Token: 0x0400071D RID: 1821
		private static readonly IntPtr NativeMethodInfoPtr_get_MidCapType_Public_get_GizmoCap3DType_0;

		// Token: 0x0400071E RID: 1822
		private static readonly IntPtr NativeMethodInfoPtr_get_MidCapBoxSize_Public_get_Single_0;

		// Token: 0x0400071F RID: 1823
		private static readonly IntPtr NativeMethodInfoPtr_get_MidCapSphereRadius_Public_get_Single_0;

		// Token: 0x04000720 RID: 1824
		private static readonly IntPtr NativeMethodInfoPtr_get_AxisConeHeight_Public_get_Single_0;

		// Token: 0x04000721 RID: 1825
		private static readonly IntPtr NativeMethodInfoPtr_get_AxisConeRadius_Public_get_Single_0;

		// Token: 0x04000722 RID: 1826
		private static readonly IntPtr NativeMethodInfoPtr_get_AxisPyramidWidth_Public_get_Single_0;

		// Token: 0x04000723 RID: 1827
		private static readonly IntPtr NativeMethodInfoPtr_get_AxisPyramidHeight_Public_get_Single_0;

		// Token: 0x04000724 RID: 1828
		private static readonly IntPtr NativeMethodInfoPtr_get_AxisPyramidDepth_Public_get_Single_0;

		// Token: 0x04000725 RID: 1829
		private static readonly IntPtr NativeMethodInfoPtr_get_AxisLabelScreenSize_Public_get_Single_0;

		// Token: 0x04000726 RID: 1830
		private static readonly IntPtr NativeMethodInfoPtr_get_AxisCamAlignFadeOutThreshold_Public_get_Single_0;

		// Token: 0x04000727 RID: 1831
		private static readonly IntPtr NativeMethodInfoPtr_get_AxisCamAlignFadeOutDuration_Public_get_Single_0;

		// Token: 0x04000728 RID: 1832
		private static readonly IntPtr NativeMethodInfoPtr_get_AxisCamAlignFadeOutAlpha_Public_get_Single_0;

		// Token: 0x04000729 RID: 1833
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400072A RID: 1834
		private static readonly IntPtr NativeMethodInfoPtr_SetMidCapColor_Public_Void_Color_0;

		// Token: 0x0400072B RID: 1835
		private static readonly IntPtr NativeMethodInfoPtr_SetAxisCapColor_Public_Void_Color_Int32_AxisSign_0;

		// Token: 0x0400072C RID: 1836
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisCapColor_Public_Color_Int32_AxisSign_0;

		// Token: 0x0400072D RID: 1837
		private static readonly IntPtr NativeMethodInfoPtr_SetHoveredColor_Public_Void_Color_0;

		// Token: 0x0400072E RID: 1838
		private static readonly IntPtr NativeMethodInfoPtr_SetMidCapFillMode_Public_Void_GizmoFillMode3D_0;

		// Token: 0x0400072F RID: 1839
		private static readonly IntPtr NativeMethodInfoPtr_SetAxisCapFillMode_Public_Void_GizmoFillMode3D_0;

		// Token: 0x04000730 RID: 1840
		private static readonly IntPtr NativeMethodInfoPtr_SetMidCapShadeMode_Public_Void_GizmoShadeMode_0;

		// Token: 0x04000731 RID: 1841
		private static readonly IntPtr NativeMethodInfoPtr_SetAxisCapShadeMode_Public_Void_GizmoShadeMode_0;

		// Token: 0x04000732 RID: 1842
		private static readonly IntPtr NativeMethodInfoPtr_GetAllowedMidCapTypes_Public_List_1_Enum_0;

		// Token: 0x04000733 RID: 1843
		private static readonly IntPtr NativeMethodInfoPtr_GetAllowedAxesCapTypes_Public_List_1_Enum_0;

		// Token: 0x04000734 RID: 1844
		private static readonly IntPtr NativeMethodInfoPtr_IsMidCapTypeAllowed_Public_Boolean_GizmoCap3DType_0;

		// Token: 0x04000735 RID: 1845
		private static readonly IntPtr NativeMethodInfoPtr_SetMidCapType_Public_Void_GizmoCap3DType_0;

		// Token: 0x04000736 RID: 1846
		private static readonly IntPtr NativeMethodInfoPtr_IsAxisCapTypeAllowed_Public_Boolean_GizmoCap3DType_0;

		// Token: 0x04000737 RID: 1847
		private static readonly IntPtr NativeMethodInfoPtr_SetAxisCapType_Public_Void_GizmoCap3DType_0;

		// Token: 0x04000738 RID: 1848
		private static readonly IntPtr NativeMethodInfoPtr_GetAxesLabelWorldSize_Public_Single_Camera_Vector3_0;

		// Token: 0x04000739 RID: 1849
		private static readonly IntPtr NativeMethodInfoPtr_CalculateMaxPrjSwitchLabelRectSize_Public_Vector2_0;

		// Token: 0x0400073A RID: 1850
		private static readonly IntPtr NativeMethodInfoPtr_ConnectMidCapLookAndFeel_Public_Void_GizmoCap3D_0;

		// Token: 0x0400073B RID: 1851
		private static readonly IntPtr NativeMethodInfoPtr_ConnectAxisCapLookAndFeel_Public_Void_GizmoCap3D_Int32_AxisSign_0;

		// Token: 0x0400073C RID: 1852
		private static readonly IntPtr NativeMethodInfoPtr_GetAxisCapLookAndFeel_Private_GizmoCap3DLookAndFeel_Int32_AxisSign_0;

		// Token: 0x0400073D RID: 1853
		private static readonly IntPtr NativeMethodInfoPtr_OnScreenSizeChanged_Private_Void_0;
	}
}
