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
	// Token: 0x020000DD RID: 221
	[Serializable]
	public class MoveGizmoLookAndFeel3D : Settings
	{
		// Token: 0x06001230 RID: 4656 RVA: 0x00065444 File Offset: 0x00063644
		// Note: this type is marked as 'beforefieldinit'.
		static MoveGizmoLookAndFeel3D()
		{
			Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "RLD", "MoveGizmoLookAndFeel3D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr);
			MoveGizmoLookAndFeel3D.NativeFieldInfoPtr__isMidCapVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, "_isMidCapVisible");
			MoveGizmoLookAndFeel3D.NativeFieldInfoPtr__midCapLookAndFeel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, "_midCapLookAndFeel");
			MoveGizmoLookAndFeel3D.NativeFieldInfoPtr__vertSnapCapLookAndFeel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, "_vertSnapCapLookAndFeel");
			MoveGizmoLookAndFeel3D.NativeFieldInfoPtr__sglSliderVis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, "_sglSliderVis");
			MoveGizmoLookAndFeel3D.NativeFieldInfoPtr__sglSliderCapVis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, "_sglSliderCapVis");
			MoveGizmoLookAndFeel3D.NativeFieldInfoPtr__dblSliderVis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, "_dblSliderVis");
			MoveGizmoLookAndFeel3D.NativeFieldInfoPtr__sglSlidersLookAndFeel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, "_sglSlidersLookAndFeel");
			MoveGizmoLookAndFeel3D.NativeFieldInfoPtr__dblSlidersLookAndFeel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, "_dblSlidersLookAndFeel");
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_Scale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665782);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_UseZoomFactor_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665783);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderLength_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665784);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_BoxSliderHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665785);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_BoxSliderDepth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665786);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_CylinderSliderRadius_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665787);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderBoxCapWidth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665788);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderBoxCapHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665789);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderBoxCapDepth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665790);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderConeCapHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665791);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderConeCapBaseRadius_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665792);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderPyramidCapWidth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665793);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderPyramidCapHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665794);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderPyramidCapDepth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665795);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderTriPrismCapWidth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665796);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderTriPrismCapHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665797);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderTriPrismCapDepth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665798);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderSphereCapRadius_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665799);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderFillMode_Public_get_GizmoFillMode3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665800);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderCapFillMode_Public_get_GizmoFillMode3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665801);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderCapType_Public_get_GizmoCap3DType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665802);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderShadeMode_Public_get_GizmoShadeMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665803);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderCapShadeMode_Public_get_GizmoShadeMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665804);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderLineType_Public_get_GizmoLine3DType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665805);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_XColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665806);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_YColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665807);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_ZColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665808);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_DblSliderSize_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665809);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_DblSliderBorderBoxHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665810);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_DblSliderBorderBoxDepth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665811);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_DblSliderFillAlpha_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665812);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_DblSliderBorderShadeMode_Public_get_GizmoShadeMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665813);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_DblSliderBorderType_Public_get_GizmoQuad3DBorderType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665814);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_DblSliderBorderFillMode_Public_get_GizmoFillMode3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665815);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_VertSnapCapQuadWidth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665816);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_VertSnapCapQuadHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665817);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_VertSnapCapCircleRadius_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665818);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_VertSnapCapColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665819);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_VertSnapCapBorderColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665820);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_VertSnapCapHoveredColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665821);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_VertSnapCapHoveredBorderColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665822);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_VertSnapCapFillMode_Public_get_GizmoFillMode2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665823);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_VertSnapCapType_Public_get_GizmoCap2DType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665824);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_IsMidCapVisible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665825);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_set_IsMidCapVisible_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665826);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_MidCapBoxWidth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665827);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_MidCapBoxHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665828);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_MidCapBoxDepth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665829);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_MidCapSphereRadius_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665830);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_MidCapColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665831);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_MidCapFillMode_Public_get_GizmoFillMode3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665832);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_MidCapShadeMode_Public_get_GizmoShadeMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665833);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_MidCapType_Public_get_GizmoCap3DType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665834);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_HoveredColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665835);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665836);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_IsVertSnapCapTypeAllowed_Public_Boolean_GizmoCap2DType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665837);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_GetAllowedVertSnapCapTypes_Public_List_1_Enum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665838);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetVertSnapCapType_Public_Void_GizmoCap2DType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665839);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetVertSnapCapQuadWidth_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665840);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetVertSnapCapQuadHeight_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665841);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetVertSnapCapCircleRadius_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665842);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetVertSnapCapFillMode_Public_Void_GizmoFillMode2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665843);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetVertSnapCapColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665844);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetVertSnapCapBorderColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665845);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetVertSnapCapHoveredColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665846);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetVertSnapCapHoveredBorderColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665847);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_IsMidCapTypeAllowed_Public_Boolean_GizmoCap3DType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665848);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_GetAllowedMidCapTypes_Public_List_1_Enum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665849);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetMidCapType_Public_Void_GizmoCap3DType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665850);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetMidCapBoxWidth_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665851);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetMidCapBoxHeight_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665852);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetMidCapBoxDepth_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665853);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetMidCapSphereRadius_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665854);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetMidCapColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665855);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_IsSliderVisible_Public_Boolean_Int32_AxisSign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665856);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_IsDblSliderVisible_Public_Boolean_PlaneId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665857);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_IsSliderCapVisible_Public_Boolean_Int32_AxisSign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665858);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_IsPositiveSliderVisible_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665859);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_IsPositiveSliderCapVisible_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665860);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_IsNegativeSliderVisible_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665861);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_IsNegativeSliderCapVisible_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665862);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderVisible_Public_Void_Int32_AxisSign_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665863);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetDblSliderVisible_Public_Void_PlaneId_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665864);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderCapVisible_Public_Void_Int32_AxisSign_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665865);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetPositiveSliderVisible_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665866);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetPositiveCapVisible_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665867);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetNegativeSliderVisible_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665868);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetNegativeCapVisible_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665869);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderLength_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665870);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderLineType_Public_Void_GizmoLine3DType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665871);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetDblSliderBorderType_Public_Void_GizmoQuad3DBorderType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665872);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetDblSliderBorderBoxHeight_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665873);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetDblSliderBorderBoxDepth_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665874);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetBoxSliderHeight_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665875);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetBoxSliderDepth_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665876);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetCylinderSliderRadius_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665877);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetDblSliderSize_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665878);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetScale_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665879);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetUseZoomFactor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665880);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetAxisColor_Public_Void_Int32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665881);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetDblSliderFillAlpha_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665882);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetHoveredColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665883);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderShadeMode_Public_Void_GizmoShadeMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665884);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderCapShadeMode_Public_Void_GizmoShadeMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665885);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetMidCapShadeMode_Public_Void_GizmoShadeMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665886);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetDblSliderBorderShadeMode_Public_Void_GizmoShadeMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665887);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderCapType_Public_Void_GizmoCap3DType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665888);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderFillMode_Public_Void_GizmoFillMode3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665889);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderCapFillMode_Public_Void_GizmoFillMode3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665890);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetMidCapFillMode_Public_Void_GizmoFillMode3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665891);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetDblSliderBorderFillMode_Public_Void_GizmoFillMode3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665892);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderBoxCapWidth_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665893);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderBoxCapHeight_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665894);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderBoxCapDepth_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665895);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderConeCapHeight_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665896);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderConeCapBaseRadius_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665897);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderPyramidCapWidth_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665898);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderPyramidCapHeight_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665899);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderPyramidCapDepth_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665900);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderTriPrismCapWidth_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665901);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderTriPrismCapHeight_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665902);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderTriPrismCapDepth_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665903);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderSphereCapRadius_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665904);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_ConnectSliderLookAndFeel_Public_Void_GizmoLineSlider3D_Int32_AxisSign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665905);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_ConnectDblSliderLookAndFeel_Public_Void_GizmoPlaneSlider3D_PlaneId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665906);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_ConnectMidCapLookAndFeel_Public_Void_GizmoCap3D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665907);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_ConnectVertSnapCapLookAndFeel_Public_Void_GizmoCap2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665908);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_GetSglSliderLookAndFeel_Private_GizmoLineSlider3DLookAndFeel_Int32_AxisSign_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665909);
			MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_GetDblSliderLookAndFeel_Private_GizmoPlaneSlider3DLookAndFeel_PlaneId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr, 100665910);
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x06001231 RID: 4657 RVA: 0x00065F28 File Offset: 0x00064128
		public unsafe float Scale
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70167, RefRangeEnd = 70168, XrefRangeStart = 70167, XrefRangeEnd = 70167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_Scale_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x06001232 RID: 4658 RVA: 0x00065F64 File Offset: 0x00064164
		public unsafe bool UseZoomFactor
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 70168, RefRangeEnd = 70171, XrefRangeStart = 70168, XrefRangeEnd = 70168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_UseZoomFactor_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x06001233 RID: 4659 RVA: 0x00065FA0 File Offset: 0x000641A0
		public unsafe float SliderLength
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70171, RefRangeEnd = 70172, XrefRangeStart = 70171, XrefRangeEnd = 70171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderLength_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x06001234 RID: 4660 RVA: 0x00065FDC File Offset: 0x000641DC
		public unsafe float BoxSliderHeight
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70172, RefRangeEnd = 70173, XrefRangeStart = 70172, XrefRangeEnd = 70172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_BoxSliderHeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x06001235 RID: 4661 RVA: 0x00066018 File Offset: 0x00064218
		public unsafe float BoxSliderDepth
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70173, RefRangeEnd = 70174, XrefRangeStart = 70173, XrefRangeEnd = 70173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_BoxSliderDepth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x06001236 RID: 4662 RVA: 0x00066054 File Offset: 0x00064254
		public unsafe float CylinderSliderRadius
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70174, RefRangeEnd = 70175, XrefRangeStart = 70174, XrefRangeEnd = 70174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_CylinderSliderRadius_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x06001237 RID: 4663 RVA: 0x00066090 File Offset: 0x00064290
		public unsafe float SliderBoxCapWidth
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70175, RefRangeEnd = 70176, XrefRangeStart = 70175, XrefRangeEnd = 70175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderBoxCapWidth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x06001238 RID: 4664 RVA: 0x000660CC File Offset: 0x000642CC
		public unsafe float SliderBoxCapHeight
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70176, RefRangeEnd = 70177, XrefRangeStart = 70176, XrefRangeEnd = 70176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderBoxCapHeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x06001239 RID: 4665 RVA: 0x00066108 File Offset: 0x00064308
		public unsafe float SliderBoxCapDepth
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70177, RefRangeEnd = 70178, XrefRangeStart = 70177, XrefRangeEnd = 70177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderBoxCapDepth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x0600123A RID: 4666 RVA: 0x00066144 File Offset: 0x00064344
		public unsafe float SliderConeCapHeight
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70178, RefRangeEnd = 70179, XrefRangeStart = 70178, XrefRangeEnd = 70178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderConeCapHeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x0600123B RID: 4667 RVA: 0x00066180 File Offset: 0x00064380
		public unsafe float SliderConeCapBaseRadius
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70179, RefRangeEnd = 70180, XrefRangeStart = 70179, XrefRangeEnd = 70179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderConeCapBaseRadius_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x0600123C RID: 4668 RVA: 0x000661BC File Offset: 0x000643BC
		public unsafe float SliderPyramidCapWidth
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70180, RefRangeEnd = 70181, XrefRangeStart = 70180, XrefRangeEnd = 70180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderPyramidCapWidth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x0600123D RID: 4669 RVA: 0x000661F8 File Offset: 0x000643F8
		public unsafe float SliderPyramidCapHeight
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70181, RefRangeEnd = 70182, XrefRangeStart = 70181, XrefRangeEnd = 70181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderPyramidCapHeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x0600123E RID: 4670 RVA: 0x00066234 File Offset: 0x00064434
		public unsafe float SliderPyramidCapDepth
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70182, RefRangeEnd = 70183, XrefRangeStart = 70182, XrefRangeEnd = 70182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderPyramidCapDepth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x0600123F RID: 4671 RVA: 0x00066270 File Offset: 0x00064470
		public unsafe float SliderTriPrismCapWidth
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70183, RefRangeEnd = 70184, XrefRangeStart = 70183, XrefRangeEnd = 70183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderTriPrismCapWidth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x06001240 RID: 4672 RVA: 0x000662AC File Offset: 0x000644AC
		public unsafe float SliderTriPrismCapHeight
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70184, RefRangeEnd = 70185, XrefRangeStart = 70184, XrefRangeEnd = 70184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderTriPrismCapHeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x06001241 RID: 4673 RVA: 0x000662E8 File Offset: 0x000644E8
		public unsafe float SliderTriPrismCapDepth
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70185, RefRangeEnd = 70186, XrefRangeStart = 70185, XrefRangeEnd = 70185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderTriPrismCapDepth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x06001242 RID: 4674 RVA: 0x00066324 File Offset: 0x00064524
		public unsafe float SliderSphereCapRadius
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70186, RefRangeEnd = 70187, XrefRangeStart = 70186, XrefRangeEnd = 70186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderSphereCapRadius_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x06001243 RID: 4675 RVA: 0x00066360 File Offset: 0x00064560
		public unsafe GizmoFillMode3D SliderFillMode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70187, RefRangeEnd = 70188, XrefRangeStart = 70187, XrefRangeEnd = 70187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderFillMode_Public_get_GizmoFillMode3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoFillMode3D>(intPtr3) : null;
			}
		}

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x06001244 RID: 4676 RVA: 0x000663A0 File Offset: 0x000645A0
		public unsafe GizmoFillMode3D SliderCapFillMode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70188, RefRangeEnd = 70189, XrefRangeStart = 70188, XrefRangeEnd = 70188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderCapFillMode_Public_get_GizmoFillMode3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoFillMode3D>(intPtr3) : null;
			}
		}

		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x06001245 RID: 4677 RVA: 0x000663E0 File Offset: 0x000645E0
		public unsafe GizmoCap3DType SliderCapType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70189, RefRangeEnd = 70190, XrefRangeStart = 70189, XrefRangeEnd = 70189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderCapType_Public_get_GizmoCap3DType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoCap3DType>(intPtr3) : null;
			}
		}

		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x06001246 RID: 4678 RVA: 0x00066420 File Offset: 0x00064620
		public unsafe GizmoShadeMode SliderShadeMode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70190, RefRangeEnd = 70191, XrefRangeStart = 70190, XrefRangeEnd = 70190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderShadeMode_Public_get_GizmoShadeMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoShadeMode>(intPtr3) : null;
			}
		}

		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x06001247 RID: 4679 RVA: 0x00066460 File Offset: 0x00064660
		public unsafe GizmoShadeMode SliderCapShadeMode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70191, RefRangeEnd = 70192, XrefRangeStart = 70191, XrefRangeEnd = 70191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderCapShadeMode_Public_get_GizmoShadeMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoShadeMode>(intPtr3) : null;
			}
		}

		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x06001248 RID: 4680 RVA: 0x000664A0 File Offset: 0x000646A0
		public unsafe GizmoLine3DType SliderLineType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70192, RefRangeEnd = 70193, XrefRangeStart = 70192, XrefRangeEnd = 70192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_SliderLineType_Public_get_GizmoLine3DType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoLine3DType>(intPtr3) : null;
			}
		}

		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x06001249 RID: 4681 RVA: 0x000664E0 File Offset: 0x000646E0
		public unsafe Color XColor
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70193, RefRangeEnd = 70194, XrefRangeStart = 70193, XrefRangeEnd = 70193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_XColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
		}

		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x0600124A RID: 4682 RVA: 0x00066520 File Offset: 0x00064720
		public unsafe Color YColor
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70194, RefRangeEnd = 70195, XrefRangeStart = 70194, XrefRangeEnd = 70194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_YColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
		}

		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x0600124B RID: 4683 RVA: 0x00066560 File Offset: 0x00064760
		public unsafe Color ZColor
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70195, RefRangeEnd = 70196, XrefRangeStart = 70195, XrefRangeEnd = 70195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_ZColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
		}

		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x0600124C RID: 4684 RVA: 0x000665A0 File Offset: 0x000647A0
		public unsafe float DblSliderSize
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70196, RefRangeEnd = 70197, XrefRangeStart = 70196, XrefRangeEnd = 70196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_DblSliderSize_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x0600124D RID: 4685 RVA: 0x000665DC File Offset: 0x000647DC
		public unsafe float DblSliderBorderBoxHeight
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70197, RefRangeEnd = 70198, XrefRangeStart = 70197, XrefRangeEnd = 70197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_DblSliderBorderBoxHeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x0600124E RID: 4686 RVA: 0x00066618 File Offset: 0x00064818
		public unsafe float DblSliderBorderBoxDepth
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70198, RefRangeEnd = 70199, XrefRangeStart = 70198, XrefRangeEnd = 70198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_DblSliderBorderBoxDepth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x0600124F RID: 4687 RVA: 0x00066654 File Offset: 0x00064854
		public unsafe float DblSliderFillAlpha
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70199, RefRangeEnd = 70200, XrefRangeStart = 70199, XrefRangeEnd = 70199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_DblSliderFillAlpha_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x06001250 RID: 4688 RVA: 0x00066690 File Offset: 0x00064890
		public unsafe GizmoShadeMode DblSliderBorderShadeMode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70200, RefRangeEnd = 70201, XrefRangeStart = 70200, XrefRangeEnd = 70200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_DblSliderBorderShadeMode_Public_get_GizmoShadeMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoShadeMode>(intPtr3) : null;
			}
		}

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x06001251 RID: 4689 RVA: 0x000666D0 File Offset: 0x000648D0
		public unsafe GizmoQuad3DBorderType DblSliderBorderType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70201, RefRangeEnd = 70202, XrefRangeStart = 70201, XrefRangeEnd = 70201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_DblSliderBorderType_Public_get_GizmoQuad3DBorderType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoQuad3DBorderType>(intPtr3) : null;
			}
		}

		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x06001252 RID: 4690 RVA: 0x00066710 File Offset: 0x00064910
		public unsafe GizmoFillMode3D DblSliderBorderFillMode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70202, RefRangeEnd = 70203, XrefRangeStart = 70202, XrefRangeEnd = 70202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_DblSliderBorderFillMode_Public_get_GizmoFillMode3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoFillMode3D>(intPtr3) : null;
			}
		}

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x06001253 RID: 4691 RVA: 0x00066750 File Offset: 0x00064950
		public unsafe float VertSnapCapQuadWidth
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70203, RefRangeEnd = 70204, XrefRangeStart = 70203, XrefRangeEnd = 70203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_VertSnapCapQuadWidth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x06001254 RID: 4692 RVA: 0x0006678C File Offset: 0x0006498C
		public unsafe float VertSnapCapQuadHeight
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 70204, RefRangeEnd = 70206, XrefRangeStart = 70204, XrefRangeEnd = 70204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_VertSnapCapQuadHeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x06001255 RID: 4693 RVA: 0x000667C8 File Offset: 0x000649C8
		public unsafe float VertSnapCapCircleRadius
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70206, RefRangeEnd = 70207, XrefRangeStart = 70206, XrefRangeEnd = 70206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_VertSnapCapCircleRadius_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x06001256 RID: 4694 RVA: 0x00066804 File Offset: 0x00064A04
		public unsafe Color VertSnapCapColor
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70207, RefRangeEnd = 70208, XrefRangeStart = 70207, XrefRangeEnd = 70207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_VertSnapCapColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
		}

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x06001257 RID: 4695 RVA: 0x00066844 File Offset: 0x00064A44
		public unsafe Color VertSnapCapBorderColor
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70208, RefRangeEnd = 70209, XrefRangeStart = 70208, XrefRangeEnd = 70208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_VertSnapCapBorderColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
		}

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x06001258 RID: 4696 RVA: 0x00066884 File Offset: 0x00064A84
		public unsafe Color VertSnapCapHoveredColor
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70209, RefRangeEnd = 70210, XrefRangeStart = 70209, XrefRangeEnd = 70209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_VertSnapCapHoveredColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
		}

		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x06001259 RID: 4697 RVA: 0x000668C4 File Offset: 0x00064AC4
		public unsafe Color VertSnapCapHoveredBorderColor
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70210, RefRangeEnd = 70211, XrefRangeStart = 70210, XrefRangeEnd = 70210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_VertSnapCapHoveredBorderColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
		}

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x0600125A RID: 4698 RVA: 0x00066904 File Offset: 0x00064B04
		public unsafe GizmoFillMode2D VertSnapCapFillMode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70211, RefRangeEnd = 70212, XrefRangeStart = 70211, XrefRangeEnd = 70211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_VertSnapCapFillMode_Public_get_GizmoFillMode2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoFillMode2D>(intPtr3) : null;
			}
		}

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x0600125B RID: 4699 RVA: 0x00066944 File Offset: 0x00064B44
		public unsafe GizmoCap2DType VertSnapCapType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70212, RefRangeEnd = 70213, XrefRangeStart = 70212, XrefRangeEnd = 70212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_VertSnapCapType_Public_get_GizmoCap2DType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoCap2DType>(intPtr3) : null;
			}
		}

		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x0600125C RID: 4700 RVA: 0x00066984 File Offset: 0x00064B84
		// (set) Token: 0x0600125D RID: 4701 RVA: 0x000669C0 File Offset: 0x00064BC0
		public unsafe bool IsMidCapVisible
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_IsMidCapVisible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_set_IsMidCapVisible_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x0600125E RID: 4702 RVA: 0x00066A00 File Offset: 0x00064C00
		public unsafe float MidCapBoxWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_MidCapBoxWidth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x0600125F RID: 4703 RVA: 0x00066A3C File Offset: 0x00064C3C
		public unsafe float MidCapBoxHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_MidCapBoxHeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x06001260 RID: 4704 RVA: 0x00066A78 File Offset: 0x00064C78
		public unsafe float MidCapBoxDepth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_MidCapBoxDepth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x06001261 RID: 4705 RVA: 0x00066AB4 File Offset: 0x00064CB4
		public unsafe float MidCapSphereRadius
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_MidCapSphereRadius_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x06001262 RID: 4706 RVA: 0x00066AF0 File Offset: 0x00064CF0
		public unsafe Color MidCapColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_MidCapColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
		}

		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x06001263 RID: 4707 RVA: 0x00066B30 File Offset: 0x00064D30
		public unsafe GizmoFillMode3D MidCapFillMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_MidCapFillMode_Public_get_GizmoFillMode3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoFillMode3D>(intPtr3) : null;
			}
		}

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x06001264 RID: 4708 RVA: 0x00066B70 File Offset: 0x00064D70
		public unsafe GizmoShadeMode MidCapShadeMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_MidCapShadeMode_Public_get_GizmoShadeMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoShadeMode>(intPtr3) : null;
			}
		}

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x06001265 RID: 4709 RVA: 0x00066BB0 File Offset: 0x00064DB0
		public unsafe GizmoCap3DType MidCapType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_MidCapType_Public_get_GizmoCap3DType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoCap3DType>(intPtr3) : null;
			}
		}

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x06001266 RID: 4710 RVA: 0x00066BF0 File Offset: 0x00064DF0
		public unsafe Color HoveredColor
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 70213, RefRangeEnd = 70214, XrefRangeStart = 70213, XrefRangeEnd = 70213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_get_HoveredColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Color>(intPtr3) : null;
			}
		}

		// Token: 0x06001267 RID: 4711 RVA: 0x00066C30 File Offset: 0x00064E30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 70285, RefRangeEnd = 70287, XrefRangeStart = 70214, XrefRangeEnd = 70285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MoveGizmoLookAndFeel3D()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoveGizmoLookAndFeel3D>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001268 RID: 4712 RVA: 0x00066C6C File Offset: 0x00064E6C
		[CallerCount(0)]
		public unsafe bool IsVertSnapCapTypeAllowed(GizmoCap2DType capType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(capType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_IsVertSnapCapTypeAllowed_Public_Boolean_GizmoCap2DType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001269 RID: 4713 RVA: 0x00066CBC File Offset: 0x00064EBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70287, XrefRangeEnd = 70305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Enum> GetAllowedVertSnapCapTypes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_GetAllowedVertSnapCapTypes_Public_List_1_Enum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Enum>>(intPtr3) : null;
		}

		// Token: 0x0600126A RID: 4714 RVA: 0x00066CFC File Offset: 0x00064EFC
		[CallerCount(0)]
		public unsafe void SetVertSnapCapType(GizmoCap2DType capType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(capType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetVertSnapCapType_Public_Void_GizmoCap2DType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600126B RID: 4715 RVA: 0x00066D40 File Offset: 0x00064F40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70305, XrefRangeEnd = 70307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVertSnapCapQuadWidth(float width)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetVertSnapCapQuadWidth_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600126C RID: 4716 RVA: 0x00066D80 File Offset: 0x00064F80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70307, XrefRangeEnd = 70309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVertSnapCapQuadHeight(float height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref height;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetVertSnapCapQuadHeight_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600126D RID: 4717 RVA: 0x00066DC0 File Offset: 0x00064FC0
		[CallerCount(0)]
		public unsafe void SetVertSnapCapCircleRadius(float radius)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref radius;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetVertSnapCapCircleRadius_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600126E RID: 4718 RVA: 0x00066E00 File Offset: 0x00065000
		[CallerCount(0)]
		public unsafe void SetVertSnapCapFillMode(GizmoFillMode2D fillMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fillMode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetVertSnapCapFillMode_Public_Void_GizmoFillMode2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600126F RID: 4719 RVA: 0x00066E44 File Offset: 0x00065044
		[CallerCount(0)]
		public unsafe void SetVertSnapCapColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(color);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetVertSnapCapColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001270 RID: 4720 RVA: 0x00066E88 File Offset: 0x00065088
		[CallerCount(0)]
		public unsafe void SetVertSnapCapBorderColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(color);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetVertSnapCapBorderColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001271 RID: 4721 RVA: 0x00066ECC File Offset: 0x000650CC
		[CallerCount(0)]
		public unsafe void SetVertSnapCapHoveredColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(color);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetVertSnapCapHoveredColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001272 RID: 4722 RVA: 0x00066F10 File Offset: 0x00065110
		[CallerCount(0)]
		public unsafe void SetVertSnapCapHoveredBorderColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(color);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetVertSnapCapHoveredBorderColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001273 RID: 4723 RVA: 0x00066F54 File Offset: 0x00065154
		[CallerCount(0)]
		public unsafe bool IsMidCapTypeAllowed(GizmoCap3DType capType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(capType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_IsMidCapTypeAllowed_Public_Boolean_GizmoCap3DType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001274 RID: 4724 RVA: 0x00066FA4 File Offset: 0x000651A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70309, XrefRangeEnd = 70327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Enum> GetAllowedMidCapTypes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_GetAllowedMidCapTypes_Public_List_1_Enum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Enum>>(intPtr3) : null;
		}

		// Token: 0x06001275 RID: 4725 RVA: 0x00066FE4 File Offset: 0x000651E4
		[CallerCount(0)]
		public unsafe void SetMidCapType(GizmoCap3DType capType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(capType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetMidCapType_Public_Void_GizmoCap3DType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001276 RID: 4726 RVA: 0x00067028 File Offset: 0x00065228
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70327, XrefRangeEnd = 70329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMidCapBoxWidth(float width)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetMidCapBoxWidth_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001277 RID: 4727 RVA: 0x00067068 File Offset: 0x00065268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70329, XrefRangeEnd = 70331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMidCapBoxHeight(float height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref height;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetMidCapBoxHeight_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001278 RID: 4728 RVA: 0x000670A8 File Offset: 0x000652A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70331, XrefRangeEnd = 70333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMidCapBoxDepth(float depth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref depth;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetMidCapBoxDepth_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001279 RID: 4729 RVA: 0x000670E8 File Offset: 0x000652E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70333, XrefRangeEnd = 70335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMidCapSphereRadius(float radius)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref radius;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetMidCapSphereRadius_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600127A RID: 4730 RVA: 0x00067128 File Offset: 0x00065328
		[CallerCount(0)]
		public unsafe void SetMidCapColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(color);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetMidCapColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600127B RID: 4731 RVA: 0x0006716C File Offset: 0x0006536C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 62888, RefRangeEnd = 62894, XrefRangeStart = 62888, XrefRangeEnd = 62894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_IsSliderVisible_Public_Boolean_Int32_AxisSign_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600127C RID: 4732 RVA: 0x000671C8 File Offset: 0x000653C8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 70335, RefRangeEnd = 70338, XrefRangeStart = 70335, XrefRangeEnd = 70335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsDblSliderVisible(PlaneId planeId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(planeId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_IsDblSliderVisible_Public_Boolean_PlaneId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600127D RID: 4733 RVA: 0x00067218 File Offset: 0x00065418
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 70338, RefRangeEnd = 70344, XrefRangeStart = 70338, XrefRangeEnd = 70338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_IsSliderCapVisible_Public_Boolean_Int32_AxisSign_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600127E RID: 4734 RVA: 0x00067274 File Offset: 0x00065474
		[CallerCount(0)]
		public unsafe bool IsPositiveSliderVisible(int axisIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axisIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_IsPositiveSliderVisible_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600127F RID: 4735 RVA: 0x000672C0 File Offset: 0x000654C0
		[CallerCount(0)]
		public unsafe bool IsPositiveSliderCapVisible(int axisIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axisIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_IsPositiveSliderCapVisible_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001280 RID: 4736 RVA: 0x0006730C File Offset: 0x0006550C
		[CallerCount(0)]
		public unsafe bool IsNegativeSliderVisible(int axisIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axisIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_IsNegativeSliderVisible_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001281 RID: 4737 RVA: 0x00067358 File Offset: 0x00065558
		[CallerCount(0)]
		public unsafe bool IsNegativeSliderCapVisible(int axisIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axisIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_IsNegativeSliderCapVisible_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001282 RID: 4738 RVA: 0x000673A4 File Offset: 0x000655A4
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderVisible_Public_Void_Int32_AxisSign_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001283 RID: 4739 RVA: 0x00067404 File Offset: 0x00065604
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetDblSliderVisible_Public_Void_PlaneId_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001284 RID: 4740 RVA: 0x00067454 File Offset: 0x00065654
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderCapVisible_Public_Void_Int32_AxisSign_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001285 RID: 4741 RVA: 0x000674B4 File Offset: 0x000656B4
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetPositiveSliderVisible_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001286 RID: 4742 RVA: 0x00067500 File Offset: 0x00065700
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetPositiveCapVisible_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001287 RID: 4743 RVA: 0x0006754C File Offset: 0x0006574C
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetNegativeSliderVisible_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001288 RID: 4744 RVA: 0x00067598 File Offset: 0x00065798
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetNegativeCapVisible_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001289 RID: 4745 RVA: 0x000675E4 File Offset: 0x000657E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70344, XrefRangeEnd = 70346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSliderLength(float axisLength)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref axisLength;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderLength_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600128A RID: 4746 RVA: 0x00067624 File Offset: 0x00065824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70346, XrefRangeEnd = 70347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSliderLineType(GizmoLine3DType lineType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lineType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderLineType_Public_Void_GizmoLine3DType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600128B RID: 4747 RVA: 0x00067668 File Offset: 0x00065868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70347, XrefRangeEnd = 70348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDblSliderBorderType(GizmoQuad3DBorderType borderType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(borderType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetDblSliderBorderType_Public_Void_GizmoQuad3DBorderType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600128C RID: 4748 RVA: 0x000676AC File Offset: 0x000658AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70348, XrefRangeEnd = 70350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDblSliderBorderBoxHeight(float height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref height;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetDblSliderBorderBoxHeight_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600128D RID: 4749 RVA: 0x000676EC File Offset: 0x000658EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70350, XrefRangeEnd = 70352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDblSliderBorderBoxDepth(float depth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref depth;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetDblSliderBorderBoxDepth_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600128E RID: 4750 RVA: 0x0006772C File Offset: 0x0006592C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70352, XrefRangeEnd = 70354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBoxSliderHeight(float height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref height;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetBoxSliderHeight_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600128F RID: 4751 RVA: 0x0006776C File Offset: 0x0006596C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70354, XrefRangeEnd = 70356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBoxSliderDepth(float depth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref depth;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetBoxSliderDepth_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001290 RID: 4752 RVA: 0x000677AC File Offset: 0x000659AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70356, XrefRangeEnd = 70358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCylinderSliderRadius(float radius)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref radius;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetCylinderSliderRadius_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001291 RID: 4753 RVA: 0x000677EC File Offset: 0x000659EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70358, XrefRangeEnd = 70361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDblSliderSize(float size)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetDblSliderSize_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001292 RID: 4754 RVA: 0x0006782C File Offset: 0x00065A2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70361, XrefRangeEnd = 70369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetScale(float scale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scale;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetScale_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001293 RID: 4755 RVA: 0x0006786C File Offset: 0x00065A6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70369, XrefRangeEnd = 70371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUseZoomFactor(bool useZoomFactor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref useZoomFactor;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetUseZoomFactor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001294 RID: 4756 RVA: 0x000678AC File Offset: 0x00065AAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 70374, RefRangeEnd = 70375, XrefRangeStart = 70371, XrefRangeEnd = 70374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetAxisColor_Public_Void_Int32_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001295 RID: 4757 RVA: 0x000678FC File Offset: 0x00065AFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70375, XrefRangeEnd = 70379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDblSliderFillAlpha(float alpha)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref alpha;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetDblSliderFillAlpha_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001296 RID: 4758 RVA: 0x0006793C File Offset: 0x00065B3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70379, XrefRangeEnd = 70382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHoveredColor(Color hoveredColor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hoveredColor);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetHoveredColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001297 RID: 4759 RVA: 0x00067980 File Offset: 0x00065B80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70382, XrefRangeEnd = 70383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSliderShadeMode(GizmoShadeMode shadeMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(shadeMode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderShadeMode_Public_Void_GizmoShadeMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001298 RID: 4760 RVA: 0x000679C4 File Offset: 0x00065BC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70383, XrefRangeEnd = 70384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSliderCapShadeMode(GizmoShadeMode shadeMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(shadeMode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderCapShadeMode_Public_Void_GizmoShadeMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001299 RID: 4761 RVA: 0x00067A08 File Offset: 0x00065C08
		[CallerCount(0)]
		public unsafe void SetMidCapShadeMode(GizmoShadeMode shadeMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(shadeMode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetMidCapShadeMode_Public_Void_GizmoShadeMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600129A RID: 4762 RVA: 0x00067A4C File Offset: 0x00065C4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70384, XrefRangeEnd = 70385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDblSliderBorderShadeMode(GizmoShadeMode shadeMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(shadeMode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetDblSliderBorderShadeMode_Public_Void_GizmoShadeMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600129B RID: 4763 RVA: 0x00067A90 File Offset: 0x00065C90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70385, XrefRangeEnd = 70386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSliderCapType(GizmoCap3DType capType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(capType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderCapType_Public_Void_GizmoCap3DType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600129C RID: 4764 RVA: 0x00067AD4 File Offset: 0x00065CD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70386, XrefRangeEnd = 70387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSliderFillMode(GizmoFillMode3D fillMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fillMode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderFillMode_Public_Void_GizmoFillMode3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600129D RID: 4765 RVA: 0x00067B18 File Offset: 0x00065D18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70387, XrefRangeEnd = 70388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSliderCapFillMode(GizmoFillMode3D fillMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fillMode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderCapFillMode_Public_Void_GizmoFillMode3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600129E RID: 4766 RVA: 0x00067B5C File Offset: 0x00065D5C
		[CallerCount(0)]
		public unsafe void SetMidCapFillMode(GizmoFillMode3D fillMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fillMode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetMidCapFillMode_Public_Void_GizmoFillMode3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600129F RID: 4767 RVA: 0x00067BA0 File Offset: 0x00065DA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70388, XrefRangeEnd = 70389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDblSliderBorderFillMode(GizmoFillMode3D fillMode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fillMode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetDblSliderBorderFillMode_Public_Void_GizmoFillMode3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012A0 RID: 4768 RVA: 0x00067BE4 File Offset: 0x00065DE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70389, XrefRangeEnd = 70391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSliderBoxCapWidth(float width)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderBoxCapWidth_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012A1 RID: 4769 RVA: 0x00067C24 File Offset: 0x00065E24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70391, XrefRangeEnd = 70393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSliderBoxCapHeight(float height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref height;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderBoxCapHeight_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012A2 RID: 4770 RVA: 0x00067C64 File Offset: 0x00065E64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70393, XrefRangeEnd = 70395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSliderBoxCapDepth(float depth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref depth;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderBoxCapDepth_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012A3 RID: 4771 RVA: 0x00067CA4 File Offset: 0x00065EA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70395, XrefRangeEnd = 70397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSliderConeCapHeight(float height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref height;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderConeCapHeight_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012A4 RID: 4772 RVA: 0x00067CE4 File Offset: 0x00065EE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70397, XrefRangeEnd = 70399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSliderConeCapBaseRadius(float radius)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref radius;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderConeCapBaseRadius_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012A5 RID: 4773 RVA: 0x00067D24 File Offset: 0x00065F24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70399, XrefRangeEnd = 70401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSliderPyramidCapWidth(float width)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderPyramidCapWidth_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012A6 RID: 4774 RVA: 0x00067D64 File Offset: 0x00065F64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70401, XrefRangeEnd = 70403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSliderPyramidCapHeight(float height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref height;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderPyramidCapHeight_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012A7 RID: 4775 RVA: 0x00067DA4 File Offset: 0x00065FA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70403, XrefRangeEnd = 70405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSliderPyramidCapDepth(float depth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref depth;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderPyramidCapDepth_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012A8 RID: 4776 RVA: 0x00067DE4 File Offset: 0x00065FE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70405, XrefRangeEnd = 70407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSliderTriPrismCapWidth(float width)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderTriPrismCapWidth_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012A9 RID: 4777 RVA: 0x00067E24 File Offset: 0x00066024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70407, XrefRangeEnd = 70409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSliderTriPrismCapHeight(float height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref height;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderTriPrismCapHeight_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012AA RID: 4778 RVA: 0x00067E64 File Offset: 0x00066064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70409, XrefRangeEnd = 70411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSliderTriPrismCapDepth(float depth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref depth;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderTriPrismCapDepth_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012AB RID: 4779 RVA: 0x00067EA4 File Offset: 0x000660A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70411, XrefRangeEnd = 70413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSliderSphereCapRadius(float radius)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref radius;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_SetSliderSphereCapRadius_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012AC RID: 4780 RVA: 0x00067EE4 File Offset: 0x000660E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70413, XrefRangeEnd = 70417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_ConnectSliderLookAndFeel_Public_Void_GizmoLineSlider3D_Int32_AxisSign_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012AD RID: 4781 RVA: 0x00067F48 File Offset: 0x00066148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70417, XrefRangeEnd = 70420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConnectDblSliderLookAndFeel(GizmoPlaneSlider3D dblSlider, PlaneId planeId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dblSlider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(planeId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_ConnectDblSliderLookAndFeel_Public_Void_GizmoPlaneSlider3D_PlaneId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012AE RID: 4782 RVA: 0x00067F9C File Offset: 0x0006619C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 70422, RefRangeEnd = 70423, XrefRangeStart = 70420, XrefRangeEnd = 70422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConnectMidCapLookAndFeel(GizmoCap3D midCap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(midCap);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_ConnectMidCapLookAndFeel_Public_Void_GizmoCap3D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012AF RID: 4783 RVA: 0x00067FE0 File Offset: 0x000661E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70423, XrefRangeEnd = 70425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConnectVertSnapCapLookAndFeel(GizmoCap2D vertSnapCap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vertSnapCap);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_ConnectVertSnapCapLookAndFeel_Public_Void_GizmoCap2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012B0 RID: 4784 RVA: 0x00068024 File Offset: 0x00066224
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_GetSglSliderLookAndFeel_Private_GizmoLineSlider3DLookAndFeel_Int32_AxisSign_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoLineSlider3DLookAndFeel>(intPtr3) : null;
		}

		// Token: 0x060012B1 RID: 4785 RVA: 0x00068084 File Offset: 0x00066284
		[CallerCount(0)]
		public unsafe GizmoPlaneSlider3DLookAndFeel GetDblSliderLookAndFeel(PlaneId planeId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(planeId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoveGizmoLookAndFeel3D.NativeMethodInfoPtr_GetDblSliderLookAndFeel_Private_GizmoPlaneSlider3DLookAndFeel_PlaneId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GizmoPlaneSlider3DLookAndFeel>(intPtr3) : null;
			}
		}

		// Token: 0x060012B2 RID: 4786 RVA: 0x00009196 File Offset: 0x00007396
		public MoveGizmoLookAndFeel3D(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x060012B3 RID: 4787 RVA: 0x000680D4 File Offset: 0x000662D4
		// (set) Token: 0x060012B4 RID: 4788 RVA: 0x0000919F File Offset: 0x0000739F
		public unsafe bool _isMidCapVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmoLookAndFeel3D.NativeFieldInfoPtr__isMidCapVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmoLookAndFeel3D.NativeFieldInfoPtr__isMidCapVisible)) = value;
			}
		}

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x060012B5 RID: 4789 RVA: 0x000680FC File Offset: 0x000662FC
		// (set) Token: 0x060012B6 RID: 4790 RVA: 0x000091BA File Offset: 0x000073BA
		public unsafe GizmoCap3DLookAndFeel _midCapLookAndFeel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmoLookAndFeel3D.NativeFieldInfoPtr__midCapLookAndFeel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoCap3DLookAndFeel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmoLookAndFeel3D.NativeFieldInfoPtr__midCapLookAndFeel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x060012B7 RID: 4791 RVA: 0x0006812C File Offset: 0x0006632C
		// (set) Token: 0x060012B8 RID: 4792 RVA: 0x000091D9 File Offset: 0x000073D9
		public unsafe GizmoCap2DLookAndFeel _vertSnapCapLookAndFeel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmoLookAndFeel3D.NativeFieldInfoPtr__vertSnapCapLookAndFeel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GizmoCap2DLookAndFeel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmoLookAndFeel3D.NativeFieldInfoPtr__vertSnapCapLookAndFeel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x060012B9 RID: 4793 RVA: 0x0006815C File Offset: 0x0006635C
		// (set) Token: 0x060012BA RID: 4794 RVA: 0x000091F8 File Offset: 0x000073F8
		public unsafe Il2CppStructArray<bool> _sglSliderVis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmoLookAndFeel3D.NativeFieldInfoPtr__sglSliderVis);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmoLookAndFeel3D.NativeFieldInfoPtr__sglSliderVis), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x060012BB RID: 4795 RVA: 0x0006818C File Offset: 0x0006638C
		// (set) Token: 0x060012BC RID: 4796 RVA: 0x00009217 File Offset: 0x00007417
		public unsafe Il2CppStructArray<bool> _sglSliderCapVis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmoLookAndFeel3D.NativeFieldInfoPtr__sglSliderCapVis);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmoLookAndFeel3D.NativeFieldInfoPtr__sglSliderCapVis), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x060012BD RID: 4797 RVA: 0x000681BC File Offset: 0x000663BC
		// (set) Token: 0x060012BE RID: 4798 RVA: 0x00009236 File Offset: 0x00007436
		public unsafe Il2CppStructArray<bool> _dblSliderVis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmoLookAndFeel3D.NativeFieldInfoPtr__dblSliderVis);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmoLookAndFeel3D.NativeFieldInfoPtr__dblSliderVis), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x060012BF RID: 4799 RVA: 0x000681EC File Offset: 0x000663EC
		// (set) Token: 0x060012C0 RID: 4800 RVA: 0x00009255 File Offset: 0x00007455
		public unsafe Il2CppReferenceArray<GizmoLineSlider3DLookAndFeel> _sglSlidersLookAndFeel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmoLookAndFeel3D.NativeFieldInfoPtr__sglSlidersLookAndFeel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GizmoLineSlider3DLookAndFeel>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmoLookAndFeel3D.NativeFieldInfoPtr__sglSlidersLookAndFeel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x060012C1 RID: 4801 RVA: 0x0006821C File Offset: 0x0006641C
		// (set) Token: 0x060012C2 RID: 4802 RVA: 0x00009274 File Offset: 0x00007474
		public unsafe Il2CppReferenceArray<GizmoPlaneSlider3DLookAndFeel> _dblSlidersLookAndFeel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmoLookAndFeel3D.NativeFieldInfoPtr__dblSlidersLookAndFeel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GizmoPlaneSlider3DLookAndFeel>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MoveGizmoLookAndFeel3D.NativeFieldInfoPtr__dblSlidersLookAndFeel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D6B RID: 3435
		private static readonly IntPtr NativeFieldInfoPtr__isMidCapVisible;

		// Token: 0x04000D6C RID: 3436
		private static readonly IntPtr NativeFieldInfoPtr__midCapLookAndFeel;

		// Token: 0x04000D6D RID: 3437
		private static readonly IntPtr NativeFieldInfoPtr__vertSnapCapLookAndFeel;

		// Token: 0x04000D6E RID: 3438
		private static readonly IntPtr NativeFieldInfoPtr__sglSliderVis;

		// Token: 0x04000D6F RID: 3439
		private static readonly IntPtr NativeFieldInfoPtr__sglSliderCapVis;

		// Token: 0x04000D70 RID: 3440
		private static readonly IntPtr NativeFieldInfoPtr__dblSliderVis;

		// Token: 0x04000D71 RID: 3441
		private static readonly IntPtr NativeFieldInfoPtr__sglSlidersLookAndFeel;

		// Token: 0x04000D72 RID: 3442
		private static readonly IntPtr NativeFieldInfoPtr__dblSlidersLookAndFeel;

		// Token: 0x04000D73 RID: 3443
		private static readonly IntPtr NativeMethodInfoPtr_get_Scale_Public_get_Single_0;

		// Token: 0x04000D74 RID: 3444
		private static readonly IntPtr NativeMethodInfoPtr_get_UseZoomFactor_Public_get_Boolean_0;

		// Token: 0x04000D75 RID: 3445
		private static readonly IntPtr NativeMethodInfoPtr_get_SliderLength_Public_get_Single_0;

		// Token: 0x04000D76 RID: 3446
		private static readonly IntPtr NativeMethodInfoPtr_get_BoxSliderHeight_Public_get_Single_0;

		// Token: 0x04000D77 RID: 3447
		private static readonly IntPtr NativeMethodInfoPtr_get_BoxSliderDepth_Public_get_Single_0;

		// Token: 0x04000D78 RID: 3448
		private static readonly IntPtr NativeMethodInfoPtr_get_CylinderSliderRadius_Public_get_Single_0;

		// Token: 0x04000D79 RID: 3449
		private static readonly IntPtr NativeMethodInfoPtr_get_SliderBoxCapWidth_Public_get_Single_0;

		// Token: 0x04000D7A RID: 3450
		private static readonly IntPtr NativeMethodInfoPtr_get_SliderBoxCapHeight_Public_get_Single_0;

		// Token: 0x04000D7B RID: 3451
		private static readonly IntPtr NativeMethodInfoPtr_get_SliderBoxCapDepth_Public_get_Single_0;

		// Token: 0x04000D7C RID: 3452
		private static readonly IntPtr NativeMethodInfoPtr_get_SliderConeCapHeight_Public_get_Single_0;

		// Token: 0x04000D7D RID: 3453
		private static readonly IntPtr NativeMethodInfoPtr_get_SliderConeCapBaseRadius_Public_get_Single_0;

		// Token: 0x04000D7E RID: 3454
		private static readonly IntPtr NativeMethodInfoPtr_get_SliderPyramidCapWidth_Public_get_Single_0;

		// Token: 0x04000D7F RID: 3455
		private static readonly IntPtr NativeMethodInfoPtr_get_SliderPyramidCapHeight_Public_get_Single_0;

		// Token: 0x04000D80 RID: 3456
		private static readonly IntPtr NativeMethodInfoPtr_get_SliderPyramidCapDepth_Public_get_Single_0;

		// Token: 0x04000D81 RID: 3457
		private static readonly IntPtr NativeMethodInfoPtr_get_SliderTriPrismCapWidth_Public_get_Single_0;

		// Token: 0x04000D82 RID: 3458
		private static readonly IntPtr NativeMethodInfoPtr_get_SliderTriPrismCapHeight_Public_get_Single_0;

		// Token: 0x04000D83 RID: 3459
		private static readonly IntPtr NativeMethodInfoPtr_get_SliderTriPrismCapDepth_Public_get_Single_0;

		// Token: 0x04000D84 RID: 3460
		private static readonly IntPtr NativeMethodInfoPtr_get_SliderSphereCapRadius_Public_get_Single_0;

		// Token: 0x04000D85 RID: 3461
		private static readonly IntPtr NativeMethodInfoPtr_get_SliderFillMode_Public_get_GizmoFillMode3D_0;

		// Token: 0x04000D86 RID: 3462
		private static readonly IntPtr NativeMethodInfoPtr_get_SliderCapFillMode_Public_get_GizmoFillMode3D_0;

		// Token: 0x04000D87 RID: 3463
		private static readonly IntPtr NativeMethodInfoPtr_get_SliderCapType_Public_get_GizmoCap3DType_0;

		// Token: 0x04000D88 RID: 3464
		private static readonly IntPtr NativeMethodInfoPtr_get_SliderShadeMode_Public_get_GizmoShadeMode_0;

		// Token: 0x04000D89 RID: 3465
		private static readonly IntPtr NativeMethodInfoPtr_get_SliderCapShadeMode_Public_get_GizmoShadeMode_0;

		// Token: 0x04000D8A RID: 3466
		private static readonly IntPtr NativeMethodInfoPtr_get_SliderLineType_Public_get_GizmoLine3DType_0;

		// Token: 0x04000D8B RID: 3467
		private static readonly IntPtr NativeMethodInfoPtr_get_XColor_Public_get_Color_0;

		// Token: 0x04000D8C RID: 3468
		private static readonly IntPtr NativeMethodInfoPtr_get_YColor_Public_get_Color_0;

		// Token: 0x04000D8D RID: 3469
		private static readonly IntPtr NativeMethodInfoPtr_get_ZColor_Public_get_Color_0;

		// Token: 0x04000D8E RID: 3470
		private static readonly IntPtr NativeMethodInfoPtr_get_DblSliderSize_Public_get_Single_0;

		// Token: 0x04000D8F RID: 3471
		private static readonly IntPtr NativeMethodInfoPtr_get_DblSliderBorderBoxHeight_Public_get_Single_0;

		// Token: 0x04000D90 RID: 3472
		private static readonly IntPtr NativeMethodInfoPtr_get_DblSliderBorderBoxDepth_Public_get_Single_0;

		// Token: 0x04000D91 RID: 3473
		private static readonly IntPtr NativeMethodInfoPtr_get_DblSliderFillAlpha_Public_get_Single_0;

		// Token: 0x04000D92 RID: 3474
		private static readonly IntPtr NativeMethodInfoPtr_get_DblSliderBorderShadeMode_Public_get_GizmoShadeMode_0;

		// Token: 0x04000D93 RID: 3475
		private static readonly IntPtr NativeMethodInfoPtr_get_DblSliderBorderType_Public_get_GizmoQuad3DBorderType_0;

		// Token: 0x04000D94 RID: 3476
		private static readonly IntPtr NativeMethodInfoPtr_get_DblSliderBorderFillMode_Public_get_GizmoFillMode3D_0;

		// Token: 0x04000D95 RID: 3477
		private static readonly IntPtr NativeMethodInfoPtr_get_VertSnapCapQuadWidth_Public_get_Single_0;

		// Token: 0x04000D96 RID: 3478
		private static readonly IntPtr NativeMethodInfoPtr_get_VertSnapCapQuadHeight_Public_get_Single_0;

		// Token: 0x04000D97 RID: 3479
		private static readonly IntPtr NativeMethodInfoPtr_get_VertSnapCapCircleRadius_Public_get_Single_0;

		// Token: 0x04000D98 RID: 3480
		private static readonly IntPtr NativeMethodInfoPtr_get_VertSnapCapColor_Public_get_Color_0;

		// Token: 0x04000D99 RID: 3481
		private static readonly IntPtr NativeMethodInfoPtr_get_VertSnapCapBorderColor_Public_get_Color_0;

		// Token: 0x04000D9A RID: 3482
		private static readonly IntPtr NativeMethodInfoPtr_get_VertSnapCapHoveredColor_Public_get_Color_0;

		// Token: 0x04000D9B RID: 3483
		private static readonly IntPtr NativeMethodInfoPtr_get_VertSnapCapHoveredBorderColor_Public_get_Color_0;

		// Token: 0x04000D9C RID: 3484
		private static readonly IntPtr NativeMethodInfoPtr_get_VertSnapCapFillMode_Public_get_GizmoFillMode2D_0;

		// Token: 0x04000D9D RID: 3485
		private static readonly IntPtr NativeMethodInfoPtr_get_VertSnapCapType_Public_get_GizmoCap2DType_0;

		// Token: 0x04000D9E RID: 3486
		private static readonly IntPtr NativeMethodInfoPtr_get_IsMidCapVisible_Public_get_Boolean_0;

		// Token: 0x04000D9F RID: 3487
		private static readonly IntPtr NativeMethodInfoPtr_set_IsMidCapVisible_Public_set_Void_Boolean_0;

		// Token: 0x04000DA0 RID: 3488
		private static readonly IntPtr NativeMethodInfoPtr_get_MidCapBoxWidth_Public_get_Single_0;

		// Token: 0x04000DA1 RID: 3489
		private static readonly IntPtr NativeMethodInfoPtr_get_MidCapBoxHeight_Public_get_Single_0;

		// Token: 0x04000DA2 RID: 3490
		private static readonly IntPtr NativeMethodInfoPtr_get_MidCapBoxDepth_Public_get_Single_0;

		// Token: 0x04000DA3 RID: 3491
		private static readonly IntPtr NativeMethodInfoPtr_get_MidCapSphereRadius_Public_get_Single_0;

		// Token: 0x04000DA4 RID: 3492
		private static readonly IntPtr NativeMethodInfoPtr_get_MidCapColor_Public_get_Color_0;

		// Token: 0x04000DA5 RID: 3493
		private static readonly IntPtr NativeMethodInfoPtr_get_MidCapFillMode_Public_get_GizmoFillMode3D_0;

		// Token: 0x04000DA6 RID: 3494
		private static readonly IntPtr NativeMethodInfoPtr_get_MidCapShadeMode_Public_get_GizmoShadeMode_0;

		// Token: 0x04000DA7 RID: 3495
		private static readonly IntPtr NativeMethodInfoPtr_get_MidCapType_Public_get_GizmoCap3DType_0;

		// Token: 0x04000DA8 RID: 3496
		private static readonly IntPtr NativeMethodInfoPtr_get_HoveredColor_Public_get_Color_0;

		// Token: 0x04000DA9 RID: 3497
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000DAA RID: 3498
		private static readonly IntPtr NativeMethodInfoPtr_IsVertSnapCapTypeAllowed_Public_Boolean_GizmoCap2DType_0;

		// Token: 0x04000DAB RID: 3499
		private static readonly IntPtr NativeMethodInfoPtr_GetAllowedVertSnapCapTypes_Public_List_1_Enum_0;

		// Token: 0x04000DAC RID: 3500
		private static readonly IntPtr NativeMethodInfoPtr_SetVertSnapCapType_Public_Void_GizmoCap2DType_0;

		// Token: 0x04000DAD RID: 3501
		private static readonly IntPtr NativeMethodInfoPtr_SetVertSnapCapQuadWidth_Public_Void_Single_0;

		// Token: 0x04000DAE RID: 3502
		private static readonly IntPtr NativeMethodInfoPtr_SetVertSnapCapQuadHeight_Public_Void_Single_0;

		// Token: 0x04000DAF RID: 3503
		private static readonly IntPtr NativeMethodInfoPtr_SetVertSnapCapCircleRadius_Public_Void_Single_0;

		// Token: 0x04000DB0 RID: 3504
		private static readonly IntPtr NativeMethodInfoPtr_SetVertSnapCapFillMode_Public_Void_GizmoFillMode2D_0;

		// Token: 0x04000DB1 RID: 3505
		private static readonly IntPtr NativeMethodInfoPtr_SetVertSnapCapColor_Public_Void_Color_0;

		// Token: 0x04000DB2 RID: 3506
		private static readonly IntPtr NativeMethodInfoPtr_SetVertSnapCapBorderColor_Public_Void_Color_0;

		// Token: 0x04000DB3 RID: 3507
		private static readonly IntPtr NativeMethodInfoPtr_SetVertSnapCapHoveredColor_Public_Void_Color_0;

		// Token: 0x04000DB4 RID: 3508
		private static readonly IntPtr NativeMethodInfoPtr_SetVertSnapCapHoveredBorderColor_Public_Void_Color_0;

		// Token: 0x04000DB5 RID: 3509
		private static readonly IntPtr NativeMethodInfoPtr_IsMidCapTypeAllowed_Public_Boolean_GizmoCap3DType_0;

		// Token: 0x04000DB6 RID: 3510
		private static readonly IntPtr NativeMethodInfoPtr_GetAllowedMidCapTypes_Public_List_1_Enum_0;

		// Token: 0x04000DB7 RID: 3511
		private static readonly IntPtr NativeMethodInfoPtr_SetMidCapType_Public_Void_GizmoCap3DType_0;

		// Token: 0x04000DB8 RID: 3512
		private static readonly IntPtr NativeMethodInfoPtr_SetMidCapBoxWidth_Public_Void_Single_0;

		// Token: 0x04000DB9 RID: 3513
		private static readonly IntPtr NativeMethodInfoPtr_SetMidCapBoxHeight_Public_Void_Single_0;

		// Token: 0x04000DBA RID: 3514
		private static readonly IntPtr NativeMethodInfoPtr_SetMidCapBoxDepth_Public_Void_Single_0;

		// Token: 0x04000DBB RID: 3515
		private static readonly IntPtr NativeMethodInfoPtr_SetMidCapSphereRadius_Public_Void_Single_0;

		// Token: 0x04000DBC RID: 3516
		private static readonly IntPtr NativeMethodInfoPtr_SetMidCapColor_Public_Void_Color_0;

		// Token: 0x04000DBD RID: 3517
		private static readonly IntPtr NativeMethodInfoPtr_IsSliderVisible_Public_Boolean_Int32_AxisSign_0;

		// Token: 0x04000DBE RID: 3518
		private static readonly IntPtr NativeMethodInfoPtr_IsDblSliderVisible_Public_Boolean_PlaneId_0;

		// Token: 0x04000DBF RID: 3519
		private static readonly IntPtr NativeMethodInfoPtr_IsSliderCapVisible_Public_Boolean_Int32_AxisSign_0;

		// Token: 0x04000DC0 RID: 3520
		private static readonly IntPtr NativeMethodInfoPtr_IsPositiveSliderVisible_Public_Boolean_Int32_0;

		// Token: 0x04000DC1 RID: 3521
		private static readonly IntPtr NativeMethodInfoPtr_IsPositiveSliderCapVisible_Public_Boolean_Int32_0;

		// Token: 0x04000DC2 RID: 3522
		private static readonly IntPtr NativeMethodInfoPtr_IsNegativeSliderVisible_Public_Boolean_Int32_0;

		// Token: 0x04000DC3 RID: 3523
		private static readonly IntPtr NativeMethodInfoPtr_IsNegativeSliderCapVisible_Public_Boolean_Int32_0;

		// Token: 0x04000DC4 RID: 3524
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderVisible_Public_Void_Int32_AxisSign_Boolean_0;

		// Token: 0x04000DC5 RID: 3525
		private static readonly IntPtr NativeMethodInfoPtr_SetDblSliderVisible_Public_Void_PlaneId_Boolean_0;

		// Token: 0x04000DC6 RID: 3526
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderCapVisible_Public_Void_Int32_AxisSign_Boolean_0;

		// Token: 0x04000DC7 RID: 3527
		private static readonly IntPtr NativeMethodInfoPtr_SetPositiveSliderVisible_Public_Void_Int32_Boolean_0;

		// Token: 0x04000DC8 RID: 3528
		private static readonly IntPtr NativeMethodInfoPtr_SetPositiveCapVisible_Public_Void_Int32_Boolean_0;

		// Token: 0x04000DC9 RID: 3529
		private static readonly IntPtr NativeMethodInfoPtr_SetNegativeSliderVisible_Public_Void_Int32_Boolean_0;

		// Token: 0x04000DCA RID: 3530
		private static readonly IntPtr NativeMethodInfoPtr_SetNegativeCapVisible_Public_Void_Int32_Boolean_0;

		// Token: 0x04000DCB RID: 3531
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderLength_Public_Void_Single_0;

		// Token: 0x04000DCC RID: 3532
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderLineType_Public_Void_GizmoLine3DType_0;

		// Token: 0x04000DCD RID: 3533
		private static readonly IntPtr NativeMethodInfoPtr_SetDblSliderBorderType_Public_Void_GizmoQuad3DBorderType_0;

		// Token: 0x04000DCE RID: 3534
		private static readonly IntPtr NativeMethodInfoPtr_SetDblSliderBorderBoxHeight_Public_Void_Single_0;

		// Token: 0x04000DCF RID: 3535
		private static readonly IntPtr NativeMethodInfoPtr_SetDblSliderBorderBoxDepth_Public_Void_Single_0;

		// Token: 0x04000DD0 RID: 3536
		private static readonly IntPtr NativeMethodInfoPtr_SetBoxSliderHeight_Public_Void_Single_0;

		// Token: 0x04000DD1 RID: 3537
		private static readonly IntPtr NativeMethodInfoPtr_SetBoxSliderDepth_Public_Void_Single_0;

		// Token: 0x04000DD2 RID: 3538
		private static readonly IntPtr NativeMethodInfoPtr_SetCylinderSliderRadius_Public_Void_Single_0;

		// Token: 0x04000DD3 RID: 3539
		private static readonly IntPtr NativeMethodInfoPtr_SetDblSliderSize_Public_Void_Single_0;

		// Token: 0x04000DD4 RID: 3540
		private static readonly IntPtr NativeMethodInfoPtr_SetScale_Public_Void_Single_0;

		// Token: 0x04000DD5 RID: 3541
		private static readonly IntPtr NativeMethodInfoPtr_SetUseZoomFactor_Public_Void_Boolean_0;

		// Token: 0x04000DD6 RID: 3542
		private static readonly IntPtr NativeMethodInfoPtr_SetAxisColor_Public_Void_Int32_Color_0;

		// Token: 0x04000DD7 RID: 3543
		private static readonly IntPtr NativeMethodInfoPtr_SetDblSliderFillAlpha_Public_Void_Single_0;

		// Token: 0x04000DD8 RID: 3544
		private static readonly IntPtr NativeMethodInfoPtr_SetHoveredColor_Public_Void_Color_0;

		// Token: 0x04000DD9 RID: 3545
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderShadeMode_Public_Void_GizmoShadeMode_0;

		// Token: 0x04000DDA RID: 3546
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderCapShadeMode_Public_Void_GizmoShadeMode_0;

		// Token: 0x04000DDB RID: 3547
		private static readonly IntPtr NativeMethodInfoPtr_SetMidCapShadeMode_Public_Void_GizmoShadeMode_0;

		// Token: 0x04000DDC RID: 3548
		private static readonly IntPtr NativeMethodInfoPtr_SetDblSliderBorderShadeMode_Public_Void_GizmoShadeMode_0;

		// Token: 0x04000DDD RID: 3549
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderCapType_Public_Void_GizmoCap3DType_0;

		// Token: 0x04000DDE RID: 3550
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderFillMode_Public_Void_GizmoFillMode3D_0;

		// Token: 0x04000DDF RID: 3551
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderCapFillMode_Public_Void_GizmoFillMode3D_0;

		// Token: 0x04000DE0 RID: 3552
		private static readonly IntPtr NativeMethodInfoPtr_SetMidCapFillMode_Public_Void_GizmoFillMode3D_0;

		// Token: 0x04000DE1 RID: 3553
		private static readonly IntPtr NativeMethodInfoPtr_SetDblSliderBorderFillMode_Public_Void_GizmoFillMode3D_0;

		// Token: 0x04000DE2 RID: 3554
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderBoxCapWidth_Public_Void_Single_0;

		// Token: 0x04000DE3 RID: 3555
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderBoxCapHeight_Public_Void_Single_0;

		// Token: 0x04000DE4 RID: 3556
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderBoxCapDepth_Public_Void_Single_0;

		// Token: 0x04000DE5 RID: 3557
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderConeCapHeight_Public_Void_Single_0;

		// Token: 0x04000DE6 RID: 3558
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderConeCapBaseRadius_Public_Void_Single_0;

		// Token: 0x04000DE7 RID: 3559
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderPyramidCapWidth_Public_Void_Single_0;

		// Token: 0x04000DE8 RID: 3560
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderPyramidCapHeight_Public_Void_Single_0;

		// Token: 0x04000DE9 RID: 3561
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderPyramidCapDepth_Public_Void_Single_0;

		// Token: 0x04000DEA RID: 3562
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderTriPrismCapWidth_Public_Void_Single_0;

		// Token: 0x04000DEB RID: 3563
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderTriPrismCapHeight_Public_Void_Single_0;

		// Token: 0x04000DEC RID: 3564
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderTriPrismCapDepth_Public_Void_Single_0;

		// Token: 0x04000DED RID: 3565
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderSphereCapRadius_Public_Void_Single_0;

		// Token: 0x04000DEE RID: 3566
		private static readonly IntPtr NativeMethodInfoPtr_ConnectSliderLookAndFeel_Public_Void_GizmoLineSlider3D_Int32_AxisSign_0;

		// Token: 0x04000DEF RID: 3567
		private static readonly IntPtr NativeMethodInfoPtr_ConnectDblSliderLookAndFeel_Public_Void_GizmoPlaneSlider3D_PlaneId_0;

		// Token: 0x04000DF0 RID: 3568
		private static readonly IntPtr NativeMethodInfoPtr_ConnectMidCapLookAndFeel_Public_Void_GizmoCap3D_0;

		// Token: 0x04000DF1 RID: 3569
		private static readonly IntPtr NativeMethodInfoPtr_ConnectVertSnapCapLookAndFeel_Public_Void_GizmoCap2D_0;

		// Token: 0x04000DF2 RID: 3570
		private static readonly IntPtr NativeMethodInfoPtr_GetSglSliderLookAndFeel_Private_GizmoLineSlider3DLookAndFeel_Int32_AxisSign_0;

		// Token: 0x04000DF3 RID: 3571
		private static readonly IntPtr NativeMethodInfoPtr_GetDblSliderLookAndFeel_Private_GizmoPlaneSlider3DLookAndFeel_PlaneId_0;
	}
}
