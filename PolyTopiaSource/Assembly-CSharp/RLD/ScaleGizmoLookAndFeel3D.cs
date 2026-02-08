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
	// Token: 0x020000E8 RID: 232
	[Serializable]
	public class ScaleGizmoLookAndFeel3D : Settings
	{
		// Token: 0x0600146D RID: 5229 RVA: 0x0006ECC8 File Offset: 0x0006CEC8
		// Note: this type is marked as 'beforefieldinit'.
		static ScaleGizmoLookAndFeel3D()
		{
			Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "ScaleGizmoLookAndFeel3D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr);
			ScaleGizmoLookAndFeel3D.NativeFieldInfoPtr__midCapLookAndFeel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, "_midCapLookAndFeel");
			ScaleGizmoLookAndFeel3D.NativeFieldInfoPtr__sglSliderVis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, "_sglSliderVis");
			ScaleGizmoLookAndFeel3D.NativeFieldInfoPtr__sglSliderCapVis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, "_sglSliderCapVis");
			ScaleGizmoLookAndFeel3D.NativeFieldInfoPtr__dblSliderVis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, "_dblSliderVis");
			ScaleGizmoLookAndFeel3D.NativeFieldInfoPtr__scaleGuideLookAndFeel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, "_scaleGuideLookAndFeel");
			ScaleGizmoLookAndFeel3D.NativeFieldInfoPtr__isScaleGuideVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, "_isScaleGuideVisible");
			ScaleGizmoLookAndFeel3D.NativeFieldInfoPtr__sglSlidersLookAndFeel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, "_sglSlidersLookAndFeel");
			ScaleGizmoLookAndFeel3D.NativeFieldInfoPtr__dblSlidersLookAndFeel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, "_dblSlidersLookAndFeel");
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_Scale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666174);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_UseZoomFactor_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666175);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderLength_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666176);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_BoxSliderHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666177);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_BoxSliderDepth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666178);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_CylinderSliderRadius_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666179);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderBoxCapWidth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666180);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderBoxCapHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666181);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderBoxCapDepth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666182);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderConeCapHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666183);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderConeCapBaseRadius_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666184);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderPyramidCapWidth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666185);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderPyramidCapHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666186);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderPyramidCapDepth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666187);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderTriPrismCapWidth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666188);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderTriPrismCapHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666189);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderTriPrismCapDepth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666190);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderSphereCapRadius_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666191);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderFillMode_Public_get_GizmoFillMode3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666192);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderCapFillMode_Public_get_GizmoFillMode3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666193);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderCapType_Public_get_GizmoCap3DType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666194);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderShadeMode_Public_get_GizmoShadeMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666195);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderCapShadeMode_Public_get_GizmoShadeMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666196);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderLineType_Public_get_GizmoLine3DType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666197);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_XColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666198);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_YColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666199);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_ZColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666200);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_DblSliderSize_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666201);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_DblSliderFillAlpha_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666202);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_MidCapBoxWidth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666203);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_MidCapBoxHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666204);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_MidCapBoxDepth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666205);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_MidCapSphereRadius_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666206);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_MidCapType_Public_get_GizmoCap3DType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666207);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_MidCapShadeMode_Public_get_GizmoShadeMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666208);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_MidCapFillMode_Public_get_GizmoFillMode3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666209);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_MidCapColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666210);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_HoveredColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666211);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_IsScaleGuideVisible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666212);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_ScaleGuideAxisLength_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666213);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666214);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetScaleGuideVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666215);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_IsDblSliderVisible_Public_Boolean_PlaneId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666216);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetDblSliderVisible_Public_Void_PlaneId_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666217);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_IsSliderVisible_Public_Boolean_Int32_AxisSign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666218);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_IsSliderCapVisible_Public_Boolean_Int32_AxisSign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666219);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_IsPositiveSliderVisible_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666220);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_IsPositiveSliderCapVisible_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666221);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_IsNegativeSliderVisible_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666222);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_IsNegativeSliderCapVisible_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666223);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderVisible_Public_Void_Int32_AxisSign_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666224);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderCapVisible_Public_Void_Int32_AxisSign_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666225);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetPositiveSliderVisible_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666226);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetPositiveCapVisible_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666227);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetNegativeSliderVisible_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666228);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetNegativeCapVisible_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666229);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderLength_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666230);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderLineType_Public_Void_GizmoLine3DType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666231);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetBoxSliderHeight_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666232);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetBoxSliderDepth_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666233);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetCylinderSliderRadius_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666234);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetScale_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666235);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetUseZoomFactor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666236);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetScaleGuideAxisLength_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666237);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetAxisColor_Public_Void_Int32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666238);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetDblSliderFillAlpha_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666239);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetMidCapColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666240);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetHoveredColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666241);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderShadeMode_Public_Void_GizmoShadeMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666242);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderCapShadeMode_Public_Void_GizmoShadeMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666243);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetMidCapShadeMode_Public_Void_GizmoShadeMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666244);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderCapType_Public_Void_GizmoCap3DType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666245);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetMidCapType_Public_Void_GizmoCap3DType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666246);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_IsMidCapTypeAllowed_Public_Boolean_GizmoCap3DType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666247);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_GetAllowedMidCapTypes_Public_List_1_Enum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666248);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderFillMode_Public_Void_GizmoFillMode3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666249);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderCapFillMode_Public_Void_GizmoFillMode3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666250);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetMidCapFillMode_Public_Void_GizmoFillMode3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666251);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderBoxCapWidth_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666252);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderBoxCapHeight_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666253);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderBoxCapDepth_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666254);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderConeCapHeight_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666255);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderConeCapBaseRadius_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666256);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderPyramidCapWidth_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666257);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderPyramidCapHeight_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666258);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderPyramidCapDepth_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666259);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderTriPrismCapWidth_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666260);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderTriPrismCapHeight_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666261);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderTriPrismCapDepth_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666262);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderSphereCapRadius_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666263);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetMidCapBoxWidth_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666264);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetMidCapBoxHeight_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666265);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetMidCapBoxDepth_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666266);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetMidCapSphereRadius_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666267);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetDblSliderSize_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666268);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_ConnectSliderLookAndFeel_Public_Void_GizmoLineSlider3D_Int32_AxisSign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666269);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_ConnectMidCapLookAndFeel_Public_Void_GizmoCap3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666270);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_ConnectDblSliderLookAndFeel_Public_Void_GizmoPlaneSlider3D_PlaneId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666271);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_ConnectGizmoScaleGuideLookAndFeel_Public_Void_GizmoScaleGuide_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666272);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_GetSglSliderLookAndFeel_Private_GizmoLineSlider3DLookAndFeel_Int32_AxisSign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666273);
			ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_GetDblSliderLookAndFeel_Private_GizmoPlaneSlider3DLookAndFeel_PlaneId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr, 100666274);
		}

		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x0600146E RID: 5230 RVA: 0x0006F57C File Offset: 0x0006D77C
		public unsafe float Scale
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 70044, RefRangeEnd = 70046, XrefRangeStart = 70044, XrefRangeEnd = 70046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_Scale_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x0600146F RID: 5231 RVA: 0x0006F5B8 File Offset: 0x0006D7B8
		public unsafe bool UseZoomFactor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_UseZoomFactor_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x06001470 RID: 5232 RVA: 0x0006F5F4 File Offset: 0x0006D7F4
		public unsafe float SliderLength
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70171, RefRangeEnd = 70172, XrefRangeStart = 70171, XrefRangeEnd = 70172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderLength_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x06001471 RID: 5233 RVA: 0x0006F630 File Offset: 0x0006D830
		public unsafe float BoxSliderHeight
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70172, RefRangeEnd = 70173, XrefRangeStart = 70172, XrefRangeEnd = 70173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_BoxSliderHeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x06001472 RID: 5234 RVA: 0x0006F66C File Offset: 0x0006D86C
		public unsafe float BoxSliderDepth
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70173, RefRangeEnd = 70174, XrefRangeStart = 70173, XrefRangeEnd = 70174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_BoxSliderDepth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x06001473 RID: 5235 RVA: 0x0006F6A8 File Offset: 0x0006D8A8
		public unsafe float CylinderSliderRadius
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70174, RefRangeEnd = 70175, XrefRangeStart = 70174, XrefRangeEnd = 70175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_CylinderSliderRadius_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x06001474 RID: 5236 RVA: 0x0006F6E4 File Offset: 0x0006D8E4
		public unsafe float SliderBoxCapWidth
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70175, RefRangeEnd = 70176, XrefRangeStart = 70175, XrefRangeEnd = 70176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderBoxCapWidth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x06001475 RID: 5237 RVA: 0x0006F720 File Offset: 0x0006D920
		public unsafe float SliderBoxCapHeight
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70176, RefRangeEnd = 70177, XrefRangeStart = 70176, XrefRangeEnd = 70177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderBoxCapHeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x06001476 RID: 5238 RVA: 0x0006F75C File Offset: 0x0006D95C
		public unsafe float SliderBoxCapDepth
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70177, RefRangeEnd = 70178, XrefRangeStart = 70177, XrefRangeEnd = 70178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderBoxCapDepth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x06001477 RID: 5239 RVA: 0x0006F798 File Offset: 0x0006D998
		public unsafe float SliderConeCapHeight
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70178, RefRangeEnd = 70179, XrefRangeStart = 70178, XrefRangeEnd = 70179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderConeCapHeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x06001478 RID: 5240 RVA: 0x0006F7D4 File Offset: 0x0006D9D4
		public unsafe float SliderConeCapBaseRadius
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70179, RefRangeEnd = 70180, XrefRangeStart = 70179, XrefRangeEnd = 70180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderConeCapBaseRadius_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x06001479 RID: 5241 RVA: 0x0006F810 File Offset: 0x0006DA10
		public unsafe float SliderPyramidCapWidth
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70180, RefRangeEnd = 70181, XrefRangeStart = 70180, XrefRangeEnd = 70181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderPyramidCapWidth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x0600147A RID: 5242 RVA: 0x0006F84C File Offset: 0x0006DA4C
		public unsafe float SliderPyramidCapHeight
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70181, RefRangeEnd = 70182, XrefRangeStart = 70181, XrefRangeEnd = 70182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderPyramidCapHeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x0600147B RID: 5243 RVA: 0x0006F888 File Offset: 0x0006DA88
		public unsafe float SliderPyramidCapDepth
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70182, RefRangeEnd = 70183, XrefRangeStart = 70182, XrefRangeEnd = 70183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderPyramidCapDepth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x0600147C RID: 5244 RVA: 0x0006F8C4 File Offset: 0x0006DAC4
		public unsafe float SliderTriPrismCapWidth
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70183, RefRangeEnd = 70184, XrefRangeStart = 70183, XrefRangeEnd = 70184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderTriPrismCapWidth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x0600147D RID: 5245 RVA: 0x0006F900 File Offset: 0x0006DB00
		public unsafe float SliderTriPrismCapHeight
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70184, RefRangeEnd = 70185, XrefRangeStart = 70184, XrefRangeEnd = 70185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderTriPrismCapHeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x0600147E RID: 5246 RVA: 0x0006F93C File Offset: 0x0006DB3C
		public unsafe float SliderTriPrismCapDepth
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70185, RefRangeEnd = 70186, XrefRangeStart = 70185, XrefRangeEnd = 70186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderTriPrismCapDepth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x0600147F RID: 5247 RVA: 0x0006F978 File Offset: 0x0006DB78
		public unsafe float SliderSphereCapRadius
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70186, RefRangeEnd = 70187, XrefRangeStart = 70186, XrefRangeEnd = 70187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderSphereCapRadius_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x06001480 RID: 5248 RVA: 0x0006F9B4 File Offset: 0x0006DBB4
		public unsafe GizmoFillMode3D SliderFillMode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70187, RefRangeEnd = 70188, XrefRangeStart = 70187, XrefRangeEnd = 70188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderFillMode_Public_get_GizmoFillMode3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoFillMode3D>(intPtr3) : null;
			}
		}

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x06001481 RID: 5249 RVA: 0x0006F9F4 File Offset: 0x0006DBF4
		public unsafe GizmoFillMode3D SliderCapFillMode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70188, RefRangeEnd = 70189, XrefRangeStart = 70188, XrefRangeEnd = 70189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderCapFillMode_Public_get_GizmoFillMode3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoFillMode3D>(intPtr3) : null;
			}
		}

		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x06001482 RID: 5250 RVA: 0x0006FA34 File Offset: 0x0006DC34
		public unsafe GizmoCap3DType SliderCapType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70189, RefRangeEnd = 70190, XrefRangeStart = 70189, XrefRangeEnd = 70190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderCapType_Public_get_GizmoCap3DType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoCap3DType>(intPtr3) : null;
			}
		}

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x06001483 RID: 5251 RVA: 0x0006FA74 File Offset: 0x0006DC74
		public unsafe GizmoShadeMode SliderShadeMode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70190, RefRangeEnd = 70191, XrefRangeStart = 70190, XrefRangeEnd = 70191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderShadeMode_Public_get_GizmoShadeMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoShadeMode>(intPtr3) : null;
			}
		}

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x06001484 RID: 5252 RVA: 0x0006FAB4 File Offset: 0x0006DCB4
		public unsafe GizmoShadeMode SliderCapShadeMode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70191, RefRangeEnd = 70192, XrefRangeStart = 70191, XrefRangeEnd = 70192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderCapShadeMode_Public_get_GizmoShadeMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoShadeMode>(intPtr3) : null;
			}
		}

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x06001485 RID: 5253 RVA: 0x0006FAF4 File Offset: 0x0006DCF4
		public unsafe GizmoLine3DType SliderLineType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70192, RefRangeEnd = 70193, XrefRangeStart = 70192, XrefRangeEnd = 70193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderLineType_Public_get_GizmoLine3DType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoLine3DType>(intPtr3) : null;
			}
		}

		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x06001486 RID: 5254 RVA: 0x0006FB34 File Offset: 0x0006DD34
		public unsafe Color XColor
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70193, RefRangeEnd = 70194, XrefRangeStart = 70193, XrefRangeEnd = 70194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_XColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
		}

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x06001487 RID: 5255 RVA: 0x0006FB74 File Offset: 0x0006DD74
		public unsafe Color YColor
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70194, RefRangeEnd = 70195, XrefRangeStart = 70194, XrefRangeEnd = 70195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_YColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
		}

		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x06001488 RID: 5256 RVA: 0x0006FBB4 File Offset: 0x0006DDB4
		public unsafe Color ZColor
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70195, RefRangeEnd = 70196, XrefRangeStart = 70195, XrefRangeEnd = 70196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_ZColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
		}

		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x06001489 RID: 5257 RVA: 0x0006FBF4 File Offset: 0x0006DDF4
		public unsafe float DblSliderSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_DblSliderSize_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x0600148A RID: 5258 RVA: 0x0006FC30 File Offset: 0x0006DE30
		public unsafe float DblSliderFillAlpha
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70199, RefRangeEnd = 70200, XrefRangeStart = 70199, XrefRangeEnd = 70200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_DblSliderFillAlpha_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x0600148B RID: 5259 RVA: 0x0006FC6C File Offset: 0x0006DE6C
		public unsafe float MidCapBoxWidth
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70431, RefRangeEnd = 70432, XrefRangeStart = 70431, XrefRangeEnd = 70432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_MidCapBoxWidth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x0600148C RID: 5260 RVA: 0x0006FCA8 File Offset: 0x0006DEA8
		public unsafe float MidCapBoxHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_MidCapBoxHeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x0600148D RID: 5261 RVA: 0x0006FCE4 File Offset: 0x0006DEE4
		public unsafe float MidCapBoxDepth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_MidCapBoxDepth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x0600148E RID: 5262 RVA: 0x0006FD20 File Offset: 0x0006DF20
		public unsafe float MidCapSphereRadius
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_MidCapSphereRadius_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000794 RID: 1940
		// (get) Token: 0x0600148F RID: 5263 RVA: 0x0006FD5C File Offset: 0x0006DF5C
		public unsafe GizmoCap3DType MidCapType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 64400, RefRangeEnd = 64401, XrefRangeStart = 64400, XrefRangeEnd = 64401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_MidCapType_Public_get_GizmoCap3DType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoCap3DType>(intPtr3) : null;
			}
		}

		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x06001490 RID: 5264 RVA: 0x0006FD9C File Offset: 0x0006DF9C
		public unsafe GizmoShadeMode MidCapShadeMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_MidCapShadeMode_Public_get_GizmoShadeMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoShadeMode>(intPtr3) : null;
			}
		}

		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x06001491 RID: 5265 RVA: 0x0006FDDC File Offset: 0x0006DFDC
		public unsafe GizmoFillMode3D MidCapFillMode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70062, RefRangeEnd = 70063, XrefRangeStart = 70062, XrefRangeEnd = 70063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_MidCapFillMode_Public_get_GizmoFillMode3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoFillMode3D>(intPtr3) : null;
			}
		}

		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x06001492 RID: 5266 RVA: 0x0006FE1C File Offset: 0x0006E01C
		public unsafe Color MidCapColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_MidCapColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
		}

		// Token: 0x17000798 RID: 1944
		// (get) Token: 0x06001493 RID: 5267 RVA: 0x0006FE5C File Offset: 0x0006E05C
		public unsafe Color HoveredColor
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70213, RefRangeEnd = 70214, XrefRangeStart = 70213, XrefRangeEnd = 70214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_HoveredColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
		}

		// Token: 0x17000799 RID: 1945
		// (get) Token: 0x06001494 RID: 5268 RVA: 0x0006FE9C File Offset: 0x0006E09C
		public unsafe bool IsScaleGuideVisible
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_IsScaleGuideVisible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700079A RID: 1946
		// (get) Token: 0x06001495 RID: 5269 RVA: 0x0006FED8 File Offset: 0x0006E0D8
		public unsafe float ScaleGuideAxisLength
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_get_ScaleGuideAxisLength_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001496 RID: 5270 RVA: 0x0006FF14 File Offset: 0x0006E114
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 71955, RefRangeEnd = 71957, XrefRangeStart = 71886, XrefRangeEnd = 71955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScaleGizmoLookAndFeel3D()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScaleGizmoLookAndFeel3D>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001497 RID: 5271 RVA: 0x0006FF50 File Offset: 0x0006E150
		[CallerCount(0)]
		public unsafe void SetScaleGuideVisible(bool isVisible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isVisible;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetScaleGuideVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001498 RID: 5272 RVA: 0x0006FF90 File Offset: 0x0006E190
		[CallerCount(0)]
		public unsafe bool IsDblSliderVisible(PlaneId planeId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(planeId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_IsDblSliderVisible_Public_Boolean_PlaneId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001499 RID: 5273 RVA: 0x0006FFE0 File Offset: 0x0006E1E0
		[CallerCount(0)]
		public unsafe void SetDblSliderVisible(PlaneId planeId, bool isVisible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(planeId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isVisible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetDblSliderVisible_Public_Void_PlaneId_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600149A RID: 5274 RVA: 0x00070030 File Offset: 0x0006E230
		[CallerCount(0)]
		public unsafe bool IsSliderVisible(int axisIndex, AxisSign axisSign)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_IsSliderVisible_Public_Boolean_Int32_AxisSign_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600149B RID: 5275 RVA: 0x0007008C File Offset: 0x0006E28C
		[CallerCount(0)]
		public unsafe bool IsSliderCapVisible(int axisIndex, AxisSign axisSign)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_IsSliderCapVisible_Public_Boolean_Int32_AxisSign_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600149C RID: 5276 RVA: 0x000700E8 File Offset: 0x0006E2E8
		[CallerCount(0)]
		public unsafe bool IsPositiveSliderVisible(int axisIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axisIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_IsPositiveSliderVisible_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600149D RID: 5277 RVA: 0x00070134 File Offset: 0x0006E334
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 71437, RefRangeEnd = 71440, XrefRangeStart = 71437, XrefRangeEnd = 71440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPositiveSliderCapVisible(int axisIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axisIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_IsPositiveSliderCapVisible_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600149E RID: 5278 RVA: 0x00070180 File Offset: 0x0006E380
		[CallerCount(0)]
		public unsafe bool IsNegativeSliderVisible(int axisIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axisIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_IsNegativeSliderVisible_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600149F RID: 5279 RVA: 0x000701CC File Offset: 0x0006E3CC
		[CallerCount(0)]
		public unsafe bool IsNegativeSliderCapVisible(int axisIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axisIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_IsNegativeSliderCapVisible_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014A0 RID: 5280 RVA: 0x00070218 File Offset: 0x0006E418
		[CallerCount(0)]
		public unsafe void SetSliderVisible(int axisIndex, AxisSign axisSign, bool isVisible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axisIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(axisSign);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isVisible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderVisible_Public_Void_Int32_AxisSign_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014A1 RID: 5281 RVA: 0x00070278 File Offset: 0x0006E478
		[CallerCount(0)]
		public unsafe void SetSliderCapVisible(int axisIndex, AxisSign axisSign, bool isVisible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axisIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(axisSign);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isVisible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderCapVisible_Public_Void_Int32_AxisSign_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014A2 RID: 5282 RVA: 0x000702D8 File Offset: 0x0006E4D8
		[CallerCount(0)]
		public unsafe void SetPositiveSliderVisible(int axisIndex, bool isVisible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axisIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isVisible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetPositiveSliderVisible_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014A3 RID: 5283 RVA: 0x00070324 File Offset: 0x0006E524
		[CallerCount(0)]
		public unsafe void SetPositiveCapVisible(int axisIndex, bool isVisible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axisIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isVisible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetPositiveCapVisible_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014A4 RID: 5284 RVA: 0x00070370 File Offset: 0x0006E570
		[CallerCount(0)]
		public unsafe void SetNegativeSliderVisible(int axisIndex, bool isVisible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axisIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isVisible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetNegativeSliderVisible_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014A5 RID: 5285 RVA: 0x000703BC File Offset: 0x0006E5BC
		[CallerCount(0)]
		public unsafe void SetNegativeCapVisible(int axisIndex, bool isVisible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axisIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isVisible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetNegativeCapVisible_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014A6 RID: 5286 RVA: 0x00070408 File Offset: 0x0006E608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSliderLength(float axisLength)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axisLength;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderLength_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014A7 RID: 5287 RVA: 0x00070448 File Offset: 0x0006E648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSliderLineType(GizmoLine3DType lineType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lineType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderLineType_Public_Void_GizmoLine3DType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014A8 RID: 5288 RVA: 0x0007048C File Offset: 0x0006E68C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBoxSliderHeight(float height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref height;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetBoxSliderHeight_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014A9 RID: 5289 RVA: 0x000704CC File Offset: 0x0006E6CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBoxSliderDepth(float depth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref depth;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetBoxSliderDepth_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014AA RID: 5290 RVA: 0x0007050C File Offset: 0x0006E70C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCylinderSliderRadius(float radius)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref radius;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetCylinderSliderRadius_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014AB RID: 5291 RVA: 0x0007054C File Offset: 0x0006E74C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71957, XrefRangeEnd = 71965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetScale(float scale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scale;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetScale_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014AC RID: 5292 RVA: 0x0007058C File Offset: 0x0006E78C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71965, XrefRangeEnd = 71967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUseZoomFactor(bool useZoomFactor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref useZoomFactor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetUseZoomFactor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014AD RID: 5293 RVA: 0x000705CC File Offset: 0x0006E7CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71967, XrefRangeEnd = 71969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetScaleGuideAxisLength(float length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref length;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetScaleGuideAxisLength_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014AE RID: 5294 RVA: 0x0007060C File Offset: 0x0006E80C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 71972, RefRangeEnd = 71973, XrefRangeStart = 71969, XrefRangeEnd = 71972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAxisColor(int axisIndex, Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axisIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(color);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetAxisColor_Public_Void_Int32_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014AF RID: 5295 RVA: 0x0007065C File Offset: 0x0006E85C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDblSliderFillAlpha(float alpha)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref alpha;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetDblSliderFillAlpha_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014B0 RID: 5296 RVA: 0x0007069C File Offset: 0x0006E89C
		[CallerCount(0)]
		public unsafe void SetMidCapColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(color);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetMidCapColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014B1 RID: 5297 RVA: 0x000706E0 File Offset: 0x0006E8E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71973, XrefRangeEnd = 71976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHoveredColor(Color hoveredColor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hoveredColor);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetHoveredColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014B2 RID: 5298 RVA: 0x00070724 File Offset: 0x0006E924
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSliderShadeMode(GizmoShadeMode shadeMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(shadeMode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderShadeMode_Public_Void_GizmoShadeMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014B3 RID: 5299 RVA: 0x00070768 File Offset: 0x0006E968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSliderCapShadeMode(GizmoShadeMode shadeMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(shadeMode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderCapShadeMode_Public_Void_GizmoShadeMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014B4 RID: 5300 RVA: 0x000707AC File Offset: 0x0006E9AC
		[CallerCount(0)]
		public unsafe void SetMidCapShadeMode(GizmoShadeMode shadeMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(shadeMode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetMidCapShadeMode_Public_Void_GizmoShadeMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014B5 RID: 5301 RVA: 0x000707F0 File Offset: 0x0006E9F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSliderCapType(GizmoCap3DType capType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(capType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderCapType_Public_Void_GizmoCap3DType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014B6 RID: 5302 RVA: 0x00070834 File Offset: 0x0006EA34
		[CallerCount(0)]
		public unsafe void SetMidCapType(GizmoCap3DType capType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(capType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetMidCapType_Public_Void_GizmoCap3DType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014B7 RID: 5303 RVA: 0x00070878 File Offset: 0x0006EA78
		[CallerCount(0)]
		public unsafe bool IsMidCapTypeAllowed(GizmoCap3DType capType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(capType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_IsMidCapTypeAllowed_Public_Boolean_GizmoCap3DType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014B8 RID: 5304 RVA: 0x000708C8 File Offset: 0x0006EAC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71976, XrefRangeEnd = 71994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Enum> GetAllowedMidCapTypes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_GetAllowedMidCapTypes_Public_List_1_Enum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Enum>>(intPtr3) : null;
		}

		// Token: 0x060014B9 RID: 5305 RVA: 0x00070908 File Offset: 0x0006EB08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSliderFillMode(GizmoFillMode3D fillMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fillMode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderFillMode_Public_Void_GizmoFillMode3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014BA RID: 5306 RVA: 0x0007094C File Offset: 0x0006EB4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSliderCapFillMode(GizmoFillMode3D fillMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fillMode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderCapFillMode_Public_Void_GizmoFillMode3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014BB RID: 5307 RVA: 0x00070990 File Offset: 0x0006EB90
		[CallerCount(0)]
		public unsafe void SetMidCapFillMode(GizmoFillMode3D fillMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fillMode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetMidCapFillMode_Public_Void_GizmoFillMode3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014BC RID: 5308 RVA: 0x000709D4 File Offset: 0x0006EBD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSliderBoxCapWidth(float width)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderBoxCapWidth_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014BD RID: 5309 RVA: 0x00070A14 File Offset: 0x0006EC14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSliderBoxCapHeight(float height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref height;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderBoxCapHeight_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014BE RID: 5310 RVA: 0x00070A54 File Offset: 0x0006EC54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSliderBoxCapDepth(float depth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref depth;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderBoxCapDepth_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014BF RID: 5311 RVA: 0x00070A94 File Offset: 0x0006EC94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSliderConeCapHeight(float height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref height;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderConeCapHeight_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014C0 RID: 5312 RVA: 0x00070AD4 File Offset: 0x0006ECD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSliderConeCapBaseRadius(float radius)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref radius;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderConeCapBaseRadius_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014C1 RID: 5313 RVA: 0x00070B14 File Offset: 0x0006ED14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSliderPyramidCapWidth(float width)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderPyramidCapWidth_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014C2 RID: 5314 RVA: 0x00070B54 File Offset: 0x0006ED54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSliderPyramidCapHeight(float height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref height;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderPyramidCapHeight_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014C3 RID: 5315 RVA: 0x00070B94 File Offset: 0x0006ED94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSliderPyramidCapDepth(float depth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref depth;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderPyramidCapDepth_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014C4 RID: 5316 RVA: 0x00070BD4 File Offset: 0x0006EDD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSliderTriPrismCapWidth(float width)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderTriPrismCapWidth_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014C5 RID: 5317 RVA: 0x00070C14 File Offset: 0x0006EE14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSliderTriPrismCapHeight(float height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref height;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderTriPrismCapHeight_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014C6 RID: 5318 RVA: 0x00070C54 File Offset: 0x0006EE54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSliderTriPrismCapDepth(float depth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref depth;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderTriPrismCapDepth_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014C7 RID: 5319 RVA: 0x00070C94 File Offset: 0x0006EE94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSliderSphereCapRadius(float radius)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref radius;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderSphereCapRadius_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014C8 RID: 5320 RVA: 0x00070CD4 File Offset: 0x0006EED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71994, XrefRangeEnd = 71996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMidCapBoxWidth(float width)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetMidCapBoxWidth_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014C9 RID: 5321 RVA: 0x00070D14 File Offset: 0x0006EF14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71996, XrefRangeEnd = 71998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMidCapBoxHeight(float height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref height;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetMidCapBoxHeight_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014CA RID: 5322 RVA: 0x00070D54 File Offset: 0x0006EF54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71998, XrefRangeEnd = 72000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMidCapBoxDepth(float depth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref depth;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetMidCapBoxDepth_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014CB RID: 5323 RVA: 0x00070D94 File Offset: 0x0006EF94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72000, XrefRangeEnd = 72002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMidCapSphereRadius(float radius)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref radius;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetMidCapSphereRadius_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014CC RID: 5324 RVA: 0x00070DD4 File Offset: 0x0006EFD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72002, XrefRangeEnd = 72005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDblSliderSize(float size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_SetDblSliderSize_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014CD RID: 5325 RVA: 0x00070E14 File Offset: 0x0006F014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConnectSliderLookAndFeel(GizmoLineSlider3D slider, int axisIndex, AxisSign axisSign)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(slider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axisIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(axisSign);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_ConnectSliderLookAndFeel_Public_Void_GizmoLineSlider3D_Int32_AxisSign_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014CE RID: 5326 RVA: 0x00070E78 File Offset: 0x0006F078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConnectMidCapLookAndFeel(GizmoCap3D cap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cap);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_ConnectMidCapLookAndFeel_Public_Void_GizmoCap3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014CF RID: 5327 RVA: 0x00070EBC File Offset: 0x0006F0BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConnectDblSliderLookAndFeel(GizmoPlaneSlider3D slider, PlaneId planeId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(slider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(planeId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_ConnectDblSliderLookAndFeel_Public_Void_GizmoPlaneSlider3D_PlaneId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014D0 RID: 5328 RVA: 0x00070F10 File Offset: 0x0006F110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72005, XrefRangeEnd = 72007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConnectGizmoScaleGuideLookAndFeel(GizmoScaleGuide scaleGuide)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(scaleGuide);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_ConnectGizmoScaleGuideLookAndFeel_Public_Void_GizmoScaleGuide_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014D1 RID: 5329 RVA: 0x00070F54 File Offset: 0x0006F154
		[CallerCount(0)]
		public unsafe GizmoLineSlider3DLookAndFeel GetSglSliderLookAndFeel(int axisIndex, AxisSign axisSign)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_GetSglSliderLookAndFeel_Private_GizmoLineSlider3DLookAndFeel_Int32_AxisSign_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoLineSlider3DLookAndFeel>(intPtr3) : null;
		}

		// Token: 0x060014D2 RID: 5330 RVA: 0x00070FB4 File Offset: 0x0006F1B4
		[CallerCount(0)]
		public unsafe GizmoPlaneSlider3DLookAndFeel GetDblSliderLookAndFeel(PlaneId planeId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(planeId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScaleGizmoLookAndFeel3D.NativeMethodInfoPtr_GetDblSliderLookAndFeel_Private_GizmoPlaneSlider3DLookAndFeel_PlaneId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoPlaneSlider3DLookAndFeel>(intPtr3) : null;
			}
		}

		// Token: 0x060014D3 RID: 5331 RVA: 0x00009C08 File Offset: 0x00007E08
		public ScaleGizmoLookAndFeel3D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x060014D4 RID: 5332 RVA: 0x00071004 File Offset: 0x0006F204
		// (set) Token: 0x060014D5 RID: 5333 RVA: 0x00009C11 File Offset: 0x00007E11
		public unsafe GizmoCap3DLookAndFeel _midCapLookAndFeel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleGizmoLookAndFeel3D.NativeFieldInfoPtr__midCapLookAndFeel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoCap3DLookAndFeel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleGizmoLookAndFeel3D.NativeFieldInfoPtr__midCapLookAndFeel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x060014D6 RID: 5334 RVA: 0x00071034 File Offset: 0x0006F234
		// (set) Token: 0x060014D7 RID: 5335 RVA: 0x00009C30 File Offset: 0x00007E30
		public unsafe Il2CppStructArray<bool> _sglSliderVis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleGizmoLookAndFeel3D.NativeFieldInfoPtr__sglSliderVis);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleGizmoLookAndFeel3D.NativeFieldInfoPtr__sglSliderVis), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x060014D8 RID: 5336 RVA: 0x00071064 File Offset: 0x0006F264
		// (set) Token: 0x060014D9 RID: 5337 RVA: 0x00009C4F File Offset: 0x00007E4F
		public unsafe Il2CppStructArray<bool> _sglSliderCapVis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleGizmoLookAndFeel3D.NativeFieldInfoPtr__sglSliderCapVis);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleGizmoLookAndFeel3D.NativeFieldInfoPtr__sglSliderCapVis), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x060014DA RID: 5338 RVA: 0x00071094 File Offset: 0x0006F294
		// (set) Token: 0x060014DB RID: 5339 RVA: 0x00009C6E File Offset: 0x00007E6E
		public unsafe Il2CppStructArray<bool> _dblSliderVis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleGizmoLookAndFeel3D.NativeFieldInfoPtr__dblSliderVis);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleGizmoLookAndFeel3D.NativeFieldInfoPtr__dblSliderVis), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700076F RID: 1903
		// (get) Token: 0x060014DC RID: 5340 RVA: 0x000710C4 File Offset: 0x0006F2C4
		// (set) Token: 0x060014DD RID: 5341 RVA: 0x00009C8D File Offset: 0x00007E8D
		public unsafe GizmoScaleGuideLookAndFeel _scaleGuideLookAndFeel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleGizmoLookAndFeel3D.NativeFieldInfoPtr__scaleGuideLookAndFeel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoScaleGuideLookAndFeel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleGizmoLookAndFeel3D.NativeFieldInfoPtr__scaleGuideLookAndFeel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x060014DE RID: 5342 RVA: 0x000710F4 File Offset: 0x0006F2F4
		// (set) Token: 0x060014DF RID: 5343 RVA: 0x00009CAC File Offset: 0x00007EAC
		public unsafe bool _isScaleGuideVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleGizmoLookAndFeel3D.NativeFieldInfoPtr__isScaleGuideVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleGizmoLookAndFeel3D.NativeFieldInfoPtr__isScaleGuideVisible)) = value;
			}
		}

		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x060014E0 RID: 5344 RVA: 0x0007111C File Offset: 0x0006F31C
		// (set) Token: 0x060014E1 RID: 5345 RVA: 0x00009CC7 File Offset: 0x00007EC7
		public unsafe Il2CppReferenceArray<GizmoLineSlider3DLookAndFeel> _sglSlidersLookAndFeel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleGizmoLookAndFeel3D.NativeFieldInfoPtr__sglSlidersLookAndFeel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GizmoLineSlider3DLookAndFeel>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleGizmoLookAndFeel3D.NativeFieldInfoPtr__sglSlidersLookAndFeel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x060014E2 RID: 5346 RVA: 0x0007114C File Offset: 0x0006F34C
		// (set) Token: 0x060014E3 RID: 5347 RVA: 0x00009CE6 File Offset: 0x00007EE6
		public unsafe Il2CppReferenceArray<GizmoPlaneSlider3DLookAndFeel> _dblSlidersLookAndFeel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleGizmoLookAndFeel3D.NativeFieldInfoPtr__dblSlidersLookAndFeel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GizmoPlaneSlider3DLookAndFeel>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScaleGizmoLookAndFeel3D.NativeFieldInfoPtr__dblSlidersLookAndFeel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F3D RID: 3901
		private static readonly IntPtr NativeFieldInfoPtr__midCapLookAndFeel;

		// Token: 0x04000F3E RID: 3902
		private static readonly IntPtr NativeFieldInfoPtr__sglSliderVis;

		// Token: 0x04000F3F RID: 3903
		private static readonly IntPtr NativeFieldInfoPtr__sglSliderCapVis;

		// Token: 0x04000F40 RID: 3904
		private static readonly IntPtr NativeFieldInfoPtr__dblSliderVis;

		// Token: 0x04000F41 RID: 3905
		private static readonly IntPtr NativeFieldInfoPtr__scaleGuideLookAndFeel;

		// Token: 0x04000F42 RID: 3906
		private static readonly IntPtr NativeFieldInfoPtr__isScaleGuideVisible;

		// Token: 0x04000F43 RID: 3907
		private static readonly IntPtr NativeFieldInfoPtr__sglSlidersLookAndFeel;

		// Token: 0x04000F44 RID: 3908
		private static readonly IntPtr NativeFieldInfoPtr__dblSlidersLookAndFeel;

		// Token: 0x04000F45 RID: 3909
		private static readonly IntPtr NativeMethodInfoPtr_get_Scale_Public_get_Single_0;

		// Token: 0x04000F46 RID: 3910
		private static readonly IntPtr NativeMethodInfoPtr_get_UseZoomFactor_Public_get_Boolean_0;

		// Token: 0x04000F47 RID: 3911
		private static readonly IntPtr NativeMethodInfoPtr_get_SliderLength_Public_get_Single_0;

		// Token: 0x04000F48 RID: 3912
		private static readonly IntPtr NativeMethodInfoPtr_get_BoxSliderHeight_Public_get_Single_0;

		// Token: 0x04000F49 RID: 3913
		private static readonly IntPtr NativeMethodInfoPtr_get_BoxSliderDepth_Public_get_Single_0;

		// Token: 0x04000F4A RID: 3914
		private static readonly IntPtr NativeMethodInfoPtr_get_CylinderSliderRadius_Public_get_Single_0;

		// Token: 0x04000F4B RID: 3915
		private static readonly IntPtr NativeMethodInfoPtr_get_SliderBoxCapWidth_Public_get_Single_0;

		// Token: 0x04000F4C RID: 3916
		private static readonly IntPtr NativeMethodInfoPtr_get_SliderBoxCapHeight_Public_get_Single_0;

		// Token: 0x04000F4D RID: 3917
		private static readonly IntPtr NativeMethodInfoPtr_get_SliderBoxCapDepth_Public_get_Single_0;

		// Token: 0x04000F4E RID: 3918
		private static readonly IntPtr NativeMethodInfoPtr_get_SliderConeCapHeight_Public_get_Single_0;

		// Token: 0x04000F4F RID: 3919
		private static readonly IntPtr NativeMethodInfoPtr_get_SliderConeCapBaseRadius_Public_get_Single_0;

		// Token: 0x04000F50 RID: 3920
		private static readonly IntPtr NativeMethodInfoPtr_get_SliderPyramidCapWidth_Public_get_Single_0;

		// Token: 0x04000F51 RID: 3921
		private static readonly IntPtr NativeMethodInfoPtr_get_SliderPyramidCapHeight_Public_get_Single_0;

		// Token: 0x04000F52 RID: 3922
		private static readonly IntPtr NativeMethodInfoPtr_get_SliderPyramidCapDepth_Public_get_Single_0;

		// Token: 0x04000F53 RID: 3923
		private static readonly IntPtr NativeMethodInfoPtr_get_SliderTriPrismCapWidth_Public_get_Single_0;

		// Token: 0x04000F54 RID: 3924
		private static readonly IntPtr NativeMethodInfoPtr_get_SliderTriPrismCapHeight_Public_get_Single_0;

		// Token: 0x04000F55 RID: 3925
		private static readonly IntPtr NativeMethodInfoPtr_get_SliderTriPrismCapDepth_Public_get_Single_0;

		// Token: 0x04000F56 RID: 3926
		private static readonly IntPtr NativeMethodInfoPtr_get_SliderSphereCapRadius_Public_get_Single_0;

		// Token: 0x04000F57 RID: 3927
		private static readonly IntPtr NativeMethodInfoPtr_get_SliderFillMode_Public_get_GizmoFillMode3D_0;

		// Token: 0x04000F58 RID: 3928
		private static readonly IntPtr NativeMethodInfoPtr_get_SliderCapFillMode_Public_get_GizmoFillMode3D_0;

		// Token: 0x04000F59 RID: 3929
		private static readonly IntPtr NativeMethodInfoPtr_get_SliderCapType_Public_get_GizmoCap3DType_0;

		// Token: 0x04000F5A RID: 3930
		private static readonly IntPtr NativeMethodInfoPtr_get_SliderShadeMode_Public_get_GizmoShadeMode_0;

		// Token: 0x04000F5B RID: 3931
		private static readonly IntPtr NativeMethodInfoPtr_get_SliderCapShadeMode_Public_get_GizmoShadeMode_0;

		// Token: 0x04000F5C RID: 3932
		private static readonly IntPtr NativeMethodInfoPtr_get_SliderLineType_Public_get_GizmoLine3DType_0;

		// Token: 0x04000F5D RID: 3933
		private static readonly IntPtr NativeMethodInfoPtr_get_XColor_Public_get_Color_0;

		// Token: 0x04000F5E RID: 3934
		private static readonly IntPtr NativeMethodInfoPtr_get_YColor_Public_get_Color_0;

		// Token: 0x04000F5F RID: 3935
		private static readonly IntPtr NativeMethodInfoPtr_get_ZColor_Public_get_Color_0;

		// Token: 0x04000F60 RID: 3936
		private static readonly IntPtr NativeMethodInfoPtr_get_DblSliderSize_Public_get_Single_0;

		// Token: 0x04000F61 RID: 3937
		private static readonly IntPtr NativeMethodInfoPtr_get_DblSliderFillAlpha_Public_get_Single_0;

		// Token: 0x04000F62 RID: 3938
		private static readonly IntPtr NativeMethodInfoPtr_get_MidCapBoxWidth_Public_get_Single_0;

		// Token: 0x04000F63 RID: 3939
		private static readonly IntPtr NativeMethodInfoPtr_get_MidCapBoxHeight_Public_get_Single_0;

		// Token: 0x04000F64 RID: 3940
		private static readonly IntPtr NativeMethodInfoPtr_get_MidCapBoxDepth_Public_get_Single_0;

		// Token: 0x04000F65 RID: 3941
		private static readonly IntPtr NativeMethodInfoPtr_get_MidCapSphereRadius_Public_get_Single_0;

		// Token: 0x04000F66 RID: 3942
		private static readonly IntPtr NativeMethodInfoPtr_get_MidCapType_Public_get_GizmoCap3DType_0;

		// Token: 0x04000F67 RID: 3943
		private static readonly IntPtr NativeMethodInfoPtr_get_MidCapShadeMode_Public_get_GizmoShadeMode_0;

		// Token: 0x04000F68 RID: 3944
		private static readonly IntPtr NativeMethodInfoPtr_get_MidCapFillMode_Public_get_GizmoFillMode3D_0;

		// Token: 0x04000F69 RID: 3945
		private static readonly IntPtr NativeMethodInfoPtr_get_MidCapColor_Public_get_Color_0;

		// Token: 0x04000F6A RID: 3946
		private static readonly IntPtr NativeMethodInfoPtr_get_HoveredColor_Public_get_Color_0;

		// Token: 0x04000F6B RID: 3947
		private static readonly IntPtr NativeMethodInfoPtr_get_IsScaleGuideVisible_Public_get_Boolean_0;

		// Token: 0x04000F6C RID: 3948
		private static readonly IntPtr NativeMethodInfoPtr_get_ScaleGuideAxisLength_Public_get_Single_0;

		// Token: 0x04000F6D RID: 3949
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000F6E RID: 3950
		private static readonly IntPtr NativeMethodInfoPtr_SetScaleGuideVisible_Public_Void_Boolean_0;

		// Token: 0x04000F6F RID: 3951
		private static readonly IntPtr NativeMethodInfoPtr_IsDblSliderVisible_Public_Boolean_PlaneId_0;

		// Token: 0x04000F70 RID: 3952
		private static readonly IntPtr NativeMethodInfoPtr_SetDblSliderVisible_Public_Void_PlaneId_Boolean_0;

		// Token: 0x04000F71 RID: 3953
		private static readonly IntPtr NativeMethodInfoPtr_IsSliderVisible_Public_Boolean_Int32_AxisSign_0;

		// Token: 0x04000F72 RID: 3954
		private static readonly IntPtr NativeMethodInfoPtr_IsSliderCapVisible_Public_Boolean_Int32_AxisSign_0;

		// Token: 0x04000F73 RID: 3955
		private static readonly IntPtr NativeMethodInfoPtr_IsPositiveSliderVisible_Public_Boolean_Int32_0;

		// Token: 0x04000F74 RID: 3956
		private static readonly IntPtr NativeMethodInfoPtr_IsPositiveSliderCapVisible_Public_Boolean_Int32_0;

		// Token: 0x04000F75 RID: 3957
		private static readonly IntPtr NativeMethodInfoPtr_IsNegativeSliderVisible_Public_Boolean_Int32_0;

		// Token: 0x04000F76 RID: 3958
		private static readonly IntPtr NativeMethodInfoPtr_IsNegativeSliderCapVisible_Public_Boolean_Int32_0;

		// Token: 0x04000F77 RID: 3959
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderVisible_Public_Void_Int32_AxisSign_Boolean_0;

		// Token: 0x04000F78 RID: 3960
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderCapVisible_Public_Void_Int32_AxisSign_Boolean_0;

		// Token: 0x04000F79 RID: 3961
		private static readonly IntPtr NativeMethodInfoPtr_SetPositiveSliderVisible_Public_Void_Int32_Boolean_0;

		// Token: 0x04000F7A RID: 3962
		private static readonly IntPtr NativeMethodInfoPtr_SetPositiveCapVisible_Public_Void_Int32_Boolean_0;

		// Token: 0x04000F7B RID: 3963
		private static readonly IntPtr NativeMethodInfoPtr_SetNegativeSliderVisible_Public_Void_Int32_Boolean_0;

		// Token: 0x04000F7C RID: 3964
		private static readonly IntPtr NativeMethodInfoPtr_SetNegativeCapVisible_Public_Void_Int32_Boolean_0;

		// Token: 0x04000F7D RID: 3965
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderLength_Public_Void_Single_0;

		// Token: 0x04000F7E RID: 3966
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderLineType_Public_Void_GizmoLine3DType_0;

		// Token: 0x04000F7F RID: 3967
		private static readonly IntPtr NativeMethodInfoPtr_SetBoxSliderHeight_Public_Void_Single_0;

		// Token: 0x04000F80 RID: 3968
		private static readonly IntPtr NativeMethodInfoPtr_SetBoxSliderDepth_Public_Void_Single_0;

		// Token: 0x04000F81 RID: 3969
		private static readonly IntPtr NativeMethodInfoPtr_SetCylinderSliderRadius_Public_Void_Single_0;

		// Token: 0x04000F82 RID: 3970
		private static readonly IntPtr NativeMethodInfoPtr_SetScale_Public_Void_Single_0;

		// Token: 0x04000F83 RID: 3971
		private static readonly IntPtr NativeMethodInfoPtr_SetUseZoomFactor_Public_Void_Boolean_0;

		// Token: 0x04000F84 RID: 3972
		private static readonly IntPtr NativeMethodInfoPtr_SetScaleGuideAxisLength_Public_Void_Single_0;

		// Token: 0x04000F85 RID: 3973
		private static readonly IntPtr NativeMethodInfoPtr_SetAxisColor_Public_Void_Int32_Color_0;

		// Token: 0x04000F86 RID: 3974
		private static readonly IntPtr NativeMethodInfoPtr_SetDblSliderFillAlpha_Public_Void_Single_0;

		// Token: 0x04000F87 RID: 3975
		private static readonly IntPtr NativeMethodInfoPtr_SetMidCapColor_Public_Void_Color_0;

		// Token: 0x04000F88 RID: 3976
		private static readonly IntPtr NativeMethodInfoPtr_SetHoveredColor_Public_Void_Color_0;

		// Token: 0x04000F89 RID: 3977
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderShadeMode_Public_Void_GizmoShadeMode_0;

		// Token: 0x04000F8A RID: 3978
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderCapShadeMode_Public_Void_GizmoShadeMode_0;

		// Token: 0x04000F8B RID: 3979
		private static readonly IntPtr NativeMethodInfoPtr_SetMidCapShadeMode_Public_Void_GizmoShadeMode_0;

		// Token: 0x04000F8C RID: 3980
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderCapType_Public_Void_GizmoCap3DType_0;

		// Token: 0x04000F8D RID: 3981
		private static readonly IntPtr NativeMethodInfoPtr_SetMidCapType_Public_Void_GizmoCap3DType_0;

		// Token: 0x04000F8E RID: 3982
		private static readonly IntPtr NativeMethodInfoPtr_IsMidCapTypeAllowed_Public_Boolean_GizmoCap3DType_0;

		// Token: 0x04000F8F RID: 3983
		private static readonly IntPtr NativeMethodInfoPtr_GetAllowedMidCapTypes_Public_List_1_Enum_0;

		// Token: 0x04000F90 RID: 3984
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderFillMode_Public_Void_GizmoFillMode3D_0;

		// Token: 0x04000F91 RID: 3985
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderCapFillMode_Public_Void_GizmoFillMode3D_0;

		// Token: 0x04000F92 RID: 3986
		private static readonly IntPtr NativeMethodInfoPtr_SetMidCapFillMode_Public_Void_GizmoFillMode3D_0;

		// Token: 0x04000F93 RID: 3987
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderBoxCapWidth_Public_Void_Single_0;

		// Token: 0x04000F94 RID: 3988
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderBoxCapHeight_Public_Void_Single_0;

		// Token: 0x04000F95 RID: 3989
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderBoxCapDepth_Public_Void_Single_0;

		// Token: 0x04000F96 RID: 3990
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderConeCapHeight_Public_Void_Single_0;

		// Token: 0x04000F97 RID: 3991
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderConeCapBaseRadius_Public_Void_Single_0;

		// Token: 0x04000F98 RID: 3992
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderPyramidCapWidth_Public_Void_Single_0;

		// Token: 0x04000F99 RID: 3993
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderPyramidCapHeight_Public_Void_Single_0;

		// Token: 0x04000F9A RID: 3994
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderPyramidCapDepth_Public_Void_Single_0;

		// Token: 0x04000F9B RID: 3995
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderTriPrismCapWidth_Public_Void_Single_0;

		// Token: 0x04000F9C RID: 3996
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderTriPrismCapHeight_Public_Void_Single_0;

		// Token: 0x04000F9D RID: 3997
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderTriPrismCapDepth_Public_Void_Single_0;

		// Token: 0x04000F9E RID: 3998
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderSphereCapRadius_Public_Void_Single_0;

		// Token: 0x04000F9F RID: 3999
		private static readonly IntPtr NativeMethodInfoPtr_SetMidCapBoxWidth_Public_Void_Single_0;

		// Token: 0x04000FA0 RID: 4000
		private static readonly IntPtr NativeMethodInfoPtr_SetMidCapBoxHeight_Public_Void_Single_0;

		// Token: 0x04000FA1 RID: 4001
		private static readonly IntPtr NativeMethodInfoPtr_SetMidCapBoxDepth_Public_Void_Single_0;

		// Token: 0x04000FA2 RID: 4002
		private static readonly IntPtr NativeMethodInfoPtr_SetMidCapSphereRadius_Public_Void_Single_0;

		// Token: 0x04000FA3 RID: 4003
		private static readonly IntPtr NativeMethodInfoPtr_SetDblSliderSize_Public_Void_Single_0;

		// Token: 0x04000FA4 RID: 4004
		private static readonly IntPtr NativeMethodInfoPtr_ConnectSliderLookAndFeel_Public_Void_GizmoLineSlider3D_Int32_AxisSign_0;

		// Token: 0x04000FA5 RID: 4005
		private static readonly IntPtr NativeMethodInfoPtr_ConnectMidCapLookAndFeel_Public_Void_GizmoCap3D_0;

		// Token: 0x04000FA6 RID: 4006
		private static readonly IntPtr NativeMethodInfoPtr_ConnectDblSliderLookAndFeel_Public_Void_GizmoPlaneSlider3D_PlaneId_0;

		// Token: 0x04000FA7 RID: 4007
		private static readonly IntPtr NativeMethodInfoPtr_ConnectGizmoScaleGuideLookAndFeel_Public_Void_GizmoScaleGuide_0;

		// Token: 0x04000FA8 RID: 4008
		private static readonly IntPtr NativeMethodInfoPtr_GetSglSliderLookAndFeel_Private_GizmoLineSlider3DLookAndFeel_Int32_AxisSign_0;

		// Token: 0x04000FA9 RID: 4009
		private static readonly IntPtr NativeMethodInfoPtr_GetDblSliderLookAndFeel_Private_GizmoPlaneSlider3DLookAndFeel_PlaneId_0;
	}
}
